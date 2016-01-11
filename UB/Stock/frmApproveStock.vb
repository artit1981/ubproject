Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class frmApproveStock
    Private Const mFormName As String = "frmApproveStock"
    Private mIsFromLoad As Boolean = False
    Private mProcessID As Long = 0
    Private mProcessDate As Date

    Private Sub frmCheckStock_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.Text = "Update Stock"
            mIsFromLoad = True
            lblRemark.Text = "ไม่พบข้อมูล"
            InitialCombo()
            LoadLastProcess()
            LoadData()
            mIsFromLoad = False
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try

    End Sub



#Region "Private"
    Private Sub InitialCombo()
        Try
            SetComboProductCategory()
            SetComboProductBrand(0)
            SetComboProductType(0)
            SetComboProductGroupID(0)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".InitialCombo : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboProductCategory()
        Try
            SetLookUpProCategory(ProductCategoryID)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboProductCategory : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboProductBrand(ByVal pProCategoryID As Long)
        Try
            SetLookProBrand(ProductBrandID, pProCategoryID)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboProductBrand : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboProductType(ByVal pProCategoryID As Long)
        Try
            SetLookUpProType(ProductTypeID, pProCategoryID)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboProductType : " & e.Message)
        End Try
    End Sub
    Private Sub SetComboProductGroupID(ByVal pProCategoryID As Long)
        Try
            SetLookProGroup(ProductGroupID, pProCategoryID)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboProductGroupID : " & e.Message)
        End Try
    End Sub
    Private Function LoadData() As Boolean
        Try
            Dim lcls As New ProductStockDAO
            Dim dataTable As New DataTable()

            dataTable = lcls.GetDataStockByLocation2(ConvertNullToZero(ProductCategoryID.EditValue), ConvertNullToZero(ProductTypeID.EditValue) _
                                          , ConvertNullToZero(ProductGroupID.EditValue), ConvertNullToZero(ProductBrandID.EditValue), mProcessID, chkIsDiff.CheckState)
            If dataTable.Rows.Count > 0 Then
                If dataTable.Rows.Count > 0 Then
                    gridControl.DataSource = dataTable
                    gridView.ViewCaption = "Update Stock"
                    Call GridStyle()
                Else
                    gridControl.DataSource = Nothing
                End If
            Else
                gridControl.DataSource = Nothing
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".LoadData : " & e.Message)
        Finally
        End Try
    End Function

    Private Sub GridStyle()
        With gridView

            .Columns("ProductID").Visible = False

            .Columns("ProductCode").Caption = "รหัสสินค้า"
            .Columns("ProductCode").Width = 150
            .Columns("ProductCode").MaxWidth = 200

            .Columns("ProductName").Caption = "ชื่อสินค้า"
            .Columns("ProductName").MaxWidth = 0
            .Columns("ProductName").MinWidth = 300
            .Columns("ProductName").Width = 500

            .Columns("Location").Caption = "คลังเก็บ"
            .Columns("Location").Width = 200
            .Columns("Location").MaxWidth = 200
            .Columns("Location").MinWidth = 100

            .Columns("Unit").Caption = "หน่วย"
            .Columns("Unit").Width = 200
            .Columns("Unit").MaxWidth = 200
            .Columns("Unit").MinWidth = 100

            .Columns("Units").Caption = "จำนวน"
            .Columns("Units").Width = 200
            .Columns("Units").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            .Columns("Units").DisplayFormat.FormatString = "n2"
            .Columns("Units").MaxWidth = 200
            .Columns("Units").MinWidth = 150


            '.Columns("StockUnits").Caption = "จำนวนสต๊อกเดิม"
            '.Columns("StockUnits").Width = 200
            '.Columns("StockUnits").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            '.Columns("StockUnits").DisplayFormat.FormatString = "n2"
            '.Columns("StockUnits").MaxWidth = 200
            '.Columns("StockUnits").MinWidth = 150

            '.Columns("Remark").Caption = "รายละเอียด"
            '.Columns("Remark").Width = 200
        End With
    End Sub
#End Region

#Region "Event"



    Private Sub btnBrandRefresh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBrandRefresh.Click
        Try
            SetComboProductBrand(ConvertNullToZero(ProductCategoryID.EditValue))
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub
 
    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Try
            ShowProgress(True, "Loading...")
            LoadLastProcess()
            If mProcessID > 0 Then
                LoadData()
            Else
                gridControl.DataSource = Nothing
            End If

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub


    Private Sub btnProductCategory_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProductCategory.Click
        Try
            SetComboProductCategory()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub btnProductType_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProductType.Click
        Try
            SetComboProductType(ConvertNullToZero(ProductCategoryID.EditValue))
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub btnProductGroup_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProductGroup.Click
        Try
            SetComboProductGroupID(ConvertNullToZero(ProductCategoryID.EditValue))
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub
    'Private Sub ProductGroupID_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProductGroupID.EditValueChanged
    '    Try
    '        If mIsFromLoad = False Then
    '            SetComboProductCategory()
    '        End If
    '    Catch ex As Exception
    '        ShowErrorMsg(False, ex.Message)
    '    End Try
    'End Sub

    Private Sub ProductCategoryID_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProductCategoryID.EditValueChanged
        Try
            If mIsFromLoad = False Then
                SetComboProductType(ConvertNullToZero(ProductCategoryID.EditValue))
                SetComboProductBrand(ConvertNullToZero(ProductCategoryID.EditValue))
                SetComboProductGroupID(ConvertNullToZero(ProductCategoryID.EditValue))
            End If
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    'Private Sub ProductTypeID_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProductTypeID.EditValueChanged
    '    Try
    '        If mIsFromLoad = False Then
    '            SetComboProductBrand(ConvertNullToZero(ProductTypeID.EditValue))
    '        End If
    '    Catch ex As Exception
    '        ShowErrorMsg(False, ex.Message)
    '    End Try
    'End Sub
#End Region

  

    Private Sub btnExportExcel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExportExcel.Click
        Try
            Dim lfrm As New frmPreExport
            lfrm.InitialForm("Update Stock", gridControl)
            lfrm.ShowDialog()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try
    End Sub
    Private Sub frmCheckStock_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub btnSetStock_Click(sender As System.Object, e As System.EventArgs) Handles btnSetStock.Click
        Try
            Dim lStrMsg As String = ""
            If Int16.Parse(rdoStockUse.EditValue) = 1 Then ''Use in calc
                lStrMsg = "โดยใช้สต๊อกจากการคำนวนใหม่ !!!"
            Else
                lStrMsg = "โดยใช้สต๊อกเดิม !!!"
            End If
            If XtraMessageBox.Show("ยืนยันการอนุมัติ " & lStrMsg, "Confirm to approve", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                SaveData()
            End If

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try
    End Sub

    Private Function SaveData() As Boolean
        Dim tr As SqlTransaction = Nothing
        Try
            If mProcessID > 0 Then
                tr = gConnection.Connection.BeginTransaction
                UpdateProduct_Stock_Process(tr)

                tr.Commit()
                XtraMessageBox.Show(Me, "บันทึกรายการสำเร็จ", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                LoadData()
            Else
                XtraMessageBox.Show(Me, "ไม่พบรายการประมวลผลล่าสุด", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            End If
            Return True
        Catch e As Exception
            tr.Rollback()
            Err.Raise(Err.Number, e.Source, mFormName & ".SaveData : " & e.Message)
            Return False
        End Try
    End Function

  
    Private Sub UpdateProduct_Stock_Process(ByRef ptr As SqlTransaction)
        Dim SQL As String = ""
        Try
            SQL = " UPDATE Product_Stock_Process Set IsComfirm=1 "
            SQL &= " ,IsUseProcess=" & IIf(Int16.Parse(rdoStockUse.EditValue) = 1, 1, 0)
            SQL &= " ,ProcessBy=" & gUserID
            SQL &= " where ProcessID <=" & mProcessID
            SQL &= " And IsComfirm=0 "  'Set flag all as previous
            gConnection.executeInsertQuery(SQL, ptr)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".UpdateProduct_Stock_Process : " & e.Message)
        End Try
    End Sub

   

     
End Class
