Option Explicit On

Imports DevExpress.XtraEditors
Imports System.Data.SqlClient

Public Class frmUpdateStockDTL
    Private mIsFromLoad As Boolean
    Private mProductListDAO As ProductListDAO
    Private mUnitMainID As Long

    Public WriteOnly Property ProductListDAO() As ProductListDAO
        Set(ByVal value As ProductListDAO)
            mProductListDAO = value
        End Set
    End Property

    Private Sub frmUpdateStockDTL_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.DialogResult = Windows.Forms.DialogResult.OK Or Me.DialogResult = Windows.Forms.DialogResult.Cancel Then
        Else
            e.Cancel = True
        End If
    End Sub


    Private Sub frmUpdateStockDTL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mIsFromLoad = True
        Try
            ProductCode.EditValue = mProductListDAO.ProductCode
            ProductName.EditValue = mProductListDAO.ProductName
            Units.EditValue = mProductListDAO.Units
            txtUnitName.EditValue = mProductListDAO.UnitName

            Dim lclsLocation As New LocationDTLDAO
            If lclsLocation.InitailData(mProductListDAO.LocationDTLID) Then
                txtLocation.EditValue = lclsLocation.NameThai
            End If

            Dim lclsProduct As New ProductDAO
            lclsProduct.InitailData(mProductListDAO.ProductID, "", "", "")
            mUnitMainID = lclsProduct.UnitMainID

            Dim lclsUnit As New UnitDAO
            lclsUnit.InitailData(mUnitMainID, "")
            UnitMainName.EditValue = lclsUnit.NameThai

            Dim lcls As New ProductUnitDAO
            Dim dataTable As New DataTable()
            UnitRate.EditValue = 0
            dataTable = lcls.GetDataTable(mProductListDAO.ProductID, 1, mProductListDAO.UnitID, "")
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    UnitRate.EditValue = ConvertNullToZero(dr("Rate"))
                    Exit For
                Next
            End If
            UnitsMain.EditValue = Units.EditValue * UnitRate.EditValue

            btnSN.Enabled = (mProductListDAO.IsSN = 1)

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try

        mIsFromLoad = False
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim lclsStock As ProductStockDAO, lclsClone As ProductStockDAO
        Dim tr As SqlTransaction = Nothing
        Dim lUnits As Long = 0
        Try
            If Verify() Then
                If XtraMessageBox.Show(Me, "ยืนยันการปรับสต๊อกสินค้า ใช่หรือไม่", "Product Stock", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    tr = gConnection.Connection.BeginTransaction

                    'Unit adjust
                    lUnits = Units.EditValue

                    lclsStock = New ProductStockDAO
                    lclsStock.ProductID = mProductListDAO.ProductID
                    lclsStock.UnitID = mProductListDAO.UnitID
                    lclsStock.LocationDTLID = mProductListDAO.LocationDTLID
                    lclsStock.Cost = mProductListDAO.Cost
                    lclsStock.Units = lUnits

                    'Update #01 with clone class 'ป้องการค่าโดนเปลี่ยนจึง clone ไปใช้
                    lclsClone = New ProductStockDAO
                    lclsClone = lclsStock.Clone
                    lclsClone.SaveData(tr, False, False, 0, MasterType.UpdateStock.ToString)

                    'Sum Stock
                    If IsSumStock.CheckState = CheckState.Checked Then
                        lclsStock.SaveData(tr, True, False, 0, MasterType.UpdateStock.ToString)
                    End If

                    'Main Unit
                    lUnits = UnitsMain.EditValue

                    lclsStock = New ProductStockDAO
                    lclsStock.ProductID = mProductListDAO.ProductID
                    lclsStock.UnitID = mUnitMainID
                    lclsStock.LocationDTLID = mProductListDAO.LocationDTLID
                    lclsStock.Cost = mProductListDAO.Cost
                    lclsStock.Units = lUnits

                    'Update #01 with clone class 'ป้องการค่าโดนเปลี่ยนจึง clone ไปใช้
                    lclsClone = New ProductStockDAO
                    lclsClone = lclsStock.Clone
                    lclsClone.SaveData(tr, False, False, 0, MasterType.UpdateStock.ToString)

                    'Sum Stock
                    If IsSumStock.CheckState = CheckState.Checked Then
                        lclsStock.SaveData(tr, True, False, 0, MasterType.UpdateStock.ToString)
                    End If

                    '-------------------------
                    'SN
                    For Each pclsSN In mProductListDAO.SNList
                        If UnitsMain.EditValue < 0 Then
                            pclsSN.SetStatusBySN(tr, mProductListDAO.ProductID, pclsSN.SerialNumberNo, "None", 0)
                        Else
                            pclsSN.Status = "New"
                            pclsSN.SerialNumberID = 0 ''New
                            pclsSN.OrderID = 0
                            pclsSN.ProductListID = 0
                            pclsSN.ProductID = mProductListDAO.ProductID
                            pclsSN.SaveData(tr, DataMode.ModeNew)
                        End If
                    Next

                    tr.Commit()
                    XtraMessageBox.Show(Me, "บันทึกรายการสำเร็จ", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                End If
            Else
                Me.DialogResult = Windows.Forms.DialogResult.None
            End If
        Catch ex As Exception
            tr.Rollback()
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Function Verify() As Boolean
        Dim lstrErr As String = ""
        Try
            If mProductListDAO Is Nothing Then
                lstrErr = "ข้อมูลสินค้าผิดพลาด" & vbNewLine
            End If

            If ConvertNullToZero(SpinUnit.EditValue) = 0 Then
                lstrErr = "กรุณาระบุจำนวนหน่วยที่ต้องการปรับเพิ่มขึ้น หรือลดลง" & vbNewLine
                SpinUnit.Focus()
            End If

            'SN
            If mProductListDAO.IsSN = 1 Then
                If mProductListDAO.IsSN = 1 And mProductListDAO.SNList Is Nothing Then
                    lstrErr = "กรุณาระบุ Serial number" & vbNewLine
                    btnSN.Focus()
                ElseIf Math.Abs(UnitsMain.EditValue) <> mProductListDAO.SNList.Count Then
                    lstrErr = "Serial number ไม่ถูกต้อง" & vbNewLine
                    btnSN.Focus()
                Else
                    For Each pclsSN In mProductListDAO.SNList
                        If UnitsMain.EditValue > 0 And pclsSN.CheckSNIsExist(mProductListDAO.ProductID, ConvertNullToString(pclsSN.SerialNumberNo), "'New','Close'", Nothing) = True Then
                            lstrErr = "Serial number ซ้ำ :" & pclsSN.SerialNumberNo & vbNewLine
                        ElseIf UnitsMain.EditValue < 0 And pclsSN.CheckSNIsExist(mProductListDAO.ProductID, ConvertNullToString(pclsSN.SerialNumberNo), "'New'", Nothing) = False Then
                            lstrErr = "ไม่พบ Serial number :" & pclsSN.SerialNumberNo & vbNewLine
                        End If
                    Next
                End If
            End If


            If lstrErr.Trim <> "" Then
                ShowProgress(False, "")
                lstrErr = "พบข้อผิดพลาดกรุณาตรวจสอบ : " & vbNewLine & lstrErr
                XtraMessageBox.Show(Me, lstrErr, "ตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Else
                Return True
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "frmUpdateStockDTL.Verify : " & e.Message)
        End Try
    End Function


    Private Sub btnSN_Click(sender As Object, e As System.EventArgs) Handles btnSN.Click
        Dim lfrmSN As New frmSN
        Try
                If Not mProductListDAO Is Nothing Then
                lfrmSN.Unit = Units.EditValue
                lfrmSN.UnitMain = UnitsMain.EditValue
                lfrmSN.ProductCodes = mProductListDAO.ProductCode
                lfrmSN.ProductNames = mProductListDAO.ProductName
                lfrmSN.IsModePrint = False
                lfrmSN.IsReadOnly = False
                lfrmSN.ProductIDs = mProductListDAO.ProductID
                lfrmSN.OrderType = MasterType.UpdateStock.ToString
                lfrmSN.StockType = ""
                lfrmSN.SnList = mProductListDAO.SNList
                lfrmSN.ShowDialog()
                mProductListDAO.SNList = lfrmSN.SnList
            End If
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    'Private Function GetUnitForUpdate() As Long
    '    Dim lstrErr As String = ""
    '    Try
    '        If mProductListDAO Is Nothing Then
    '            Return 0
    '        Else
    '            Return SpinUnit.EditValue
    '        End If
    '    Catch e As Exception
    '        Err.Raise(Err.Number, e.Source, "frmUpdateStockDTL.GetUnitForUpdate : " & e.Message)
    '    End Try
    'End Function

    Private Sub Units_EditValueChanged(sender As Object, e As System.EventArgs) Handles Units.EditValueChanged
        UnitsMain.EditValue = Units.EditValue * UnitRate.EditValue
    End Sub
End Class