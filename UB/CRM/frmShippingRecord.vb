Option Explicit On

Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmShippingRecord
    Inherits iEditForm
    Private Const mFormName As String = "frmShippingRecord"

#Region "Overrides"

    Protected Overrides Sub OnLoadForm(ByVal pMode As Integer, ByVal pID As Long, ByVal pOrderType As Long, ByVal pclsConvert As iOrder, ByVal pCusID As Long)
        Try

            InitialCombo()
            dtpDateFrom.EditValue = New DateTime(GetCurrentDate(Nothing).Year, 1, 1)
            dtpDateTo.EditValue = GetCurrentDate(Nothing)



            Call LoadData()
            Addbar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            PrintBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".OnLoadForm : " & e.Message)
        End Try
    End Sub

    Protected Overrides Sub ClearAllForm(ByVal pMode As Integer)
        Try
            MyBase.ClearAllForm(pMode)
            Select Case pMode
                Case DataMode.ModeNew, DataMode.ModeCopy, DataMode.ModeConvert


                Case DataMode.ModeEdit
                    'AccountCode.Properties.ReadOnly = True
                    'btnGenID.Enabled = False
            End Select


        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".ClearAllForm : " & e.Message)
        End Try

    End Sub

    Protected Overrides Function Save(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        Try
            If Verify() = True Then

                For Each pDataDAO As MyRecord In bindingSource1
                    If pDataDAO.IsChange = 1 And pDataDAO.IsDelete = 0 And pDataDAO.ModeData > 0 Then
                        Dim lDataDAO = New BankAccountRecordSDAO
                        lDataDAO.ID = pDataDAO.ID
                        If pDataDAO.ModeData = 3 Then
                            lDataDAO.ModeData = Integer.Parse(DataMode.ModeDelete)
                        ElseIf lDataDAO.ID = 0 Then
                            lDataDAO.ModeData = Integer.Parse(DataMode.ModeNew)
                        Else
                            lDataDAO.ModeData = Integer.Parse(DataMode.ModeEdit)
                        End If
                        lDataDAO.RecordDate = pDataDAO.RecordDate
                        lDataDAO.BankAccountID = pDataDAO.BankAccountID
                        lDataDAO.DR = pDataDAO.DR
                        lDataDAO.CR = pDataDAO.CR
                        lDataDAO.Remark = pDataDAO.Remark
                        lDataDAO.SaveData(Nothing)
                    End If
                Next
                Return True
            Else
                ShowProgress(False, "")
                XtraMessageBox.Show(Me, "พบข้อผิดพลาดกรุณาตรวจสอบ", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".Save : " & ex.Message)
            Return False
        End Try
    End Function


    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        LoadData()
    End Sub


    'Private Sub gridView_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gridView.ValidateRow
    '    Dim info As New ErrorInfo()
    '    TryCast(e.Row, MyRecord).GetError(info)
    '    e.Valid = info.ErrorText = ""

    'End Sub

    Private Sub gridView_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gridView.InvalidRowException
        e.ExceptionMode = ExceptionMode.NoAction
    End Sub

    Private Sub gridView_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles gridView.RowUpdated
        If e.Row IsNot Nothing Then
            TryCast(e.Row, MyRecord).IsChange = 1
        End If

    End Sub

    Private Sub gridView_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles gridView.InitNewRow
        Dim view As GridView = CType(sender, GridView)
        view.SetRowCellValue(e.RowHandle, view.Columns("RecordDate"), GetCurrentDate(Nothing))
        view.SetRowCellValue(e.RowHandle, view.Columns("ID"), 0)
        view.SetRowCellValue(e.RowHandle, view.Columns("DR"), 0)
        view.SetRowCellValue(e.RowHandle, view.Columns("CR"), 0)
        view.SetRowCellValue(e.RowHandle, view.Columns("ModeData"), 1)
        view.SetRowCellValue(e.RowHandle, view.Columns("Remark"), "")
        view.SetRowCellValue(e.RowHandle, view.Columns("IsDelete"), 0)
    End Sub

#End Region


#Region "Private"

    Private Sub InitialCombo()
        Try
            Call LoadDataBankAccount()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".InitialCombo : " & e.Message)
        End Try
    End Sub

    Private Sub LoadDataBankAccount()
        Dim lcls As New BankAccountDAO


        Try
            Dim dataTable = lcls.GetDataTable(0, True, 0, 0)
            BankAccountIDLookUpEdit.DataSource = dataTable

            Dim dataTable2 = lcls.GetDataTable(0, True, 0, 0)
            Dim drNewRow As DataRow = dataTable2.NewRow

            'specify the information of the new row.
            drNewRow("ID") = 0
            drNewRow("BankAccountCode") = "ALL"
            drNewRow("BankAccountNo") = "ALL"
            drNewRow("BankName") = "ALL"
            drNewRow("CusName") = "ALL"
            drNewRow("ACCNAME") = "ALL"

            dataTable2.Rows.Add(drNewRow)

            BankAccID.Properties.DataSource = dataTable2
            BankAccID.Properties.DisplayMember = "ACCNAME"
            BankAccID.Properties.ValueMember = "ID"
            BankAccID.EditValue = 0

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "frmBankAccountRec.LoadDataLocaton : " & e.Message)
        Finally

            lcls = Nothing
        End Try
    End Sub


    Private Sub LoadData()
        Dim lcls As New BankAccountRecordSDAO
        Dim dataTable As New DataTable()
        Dim lBalance As Decimal = 0
        Try
            bindingSource1 = New BindingSource
            bindingSource1.DataSource = GetType(MyRecord)
            dataTable = lcls.GetDataTable(BankAccID.EditValue, dtpDateFrom.EditValue, dtpDateTo.EditValue, chkShowDelete.Checked)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    Dim rec As New MyRecord()
                    rec.ID = dr("ID")
                    rec.BankAccountID = ConvertNullToZero(dr("BankAccountID"))
                    rec.RecordDate = dr("RecordDate")
                    rec.DR = ConvertNullToZero(dr("DR"))
                    rec.CR = ConvertNullToZero(dr("CR"))
                    rec.Remark = ConvertNullToString(dr("Remark"))
                    rec.IsChange = 0
                    rec.ModeData = 2
                    rec.IsDelete = ConvertNullToZero(dr("IsDelete"))
                    bindingSource1.Add(rec)
                    lBalance += rec.DR
                    lBalance -= rec.CR
                Next
            End If

            'Cheque
            'Comm
            Dim lTotal As Decimal = 0

            Dim SQL = " select * from vChequeBalance"
            SQL &= " where ChequeDate between '" & formatSQLDate(dtpDateFrom.EditValue) & "'"
            SQL &= " and  '" & formatSQLDate(dtpDateTo.EditValue) & "'"

            dataTable = gConnection.executeSelectQuery(SQL, Nothing, 180)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    Dim rec As New MyRecord()
                    rec.ID = 0
                    rec.BankAccountID = ConvertNullToZero(dr("BankAccountID"))
                    rec.RecordDate = dr("ChequeDate")
                    If ConvertNullToString(dr("CashType")) = "D" Then
                        rec.DR = ConvertNullToZero(dr("ChequeBalance"))
                    Else
                        rec.CR = ConvertNullToZero(dr("ChequeBalance"))
                    End If

                    rec.Remark = ConvertNullToString(dr("BankDocType")) & " : " & ConvertNullToString(dr("OrderCode"))
                    rec.IsChange = 0
                    rec.ModeData = 0
                    rec.IsDelete = 0
                    bindingSource1.Add(rec)
                    lBalance += rec.DR
                    lBalance -= rec.CR
                Next
            End If
             
            DxErrorProvider1.DataSource = bindingSource1
            DxErrorProvider1.ContainerControl = Me
            gridControl.DataSource = bindingSource1
            'gridView.Columns("ModeData").FilterInfo = New ColumnFilterInfo("[ModeData]<>3")
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "frmBankAccountRec.LoadData : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub
    Private Sub gridView_RowStyle(sender As Object, e As RowStyleEventArgs) Handles gridView.RowStyle

        Dim lData As Integer = 0
        Try
            If (e.RowHandle >= 0) Then

                lData = gridView.GetRowCellValue(e.RowHandle, gridView.Columns("IsDelete"))
                If lData = 1 Then
                    e.Appearance.BackColor = Color.WhiteSmoke
                    e.Appearance.ForeColor = Color.Red
                End If
                lData = gridView.GetRowCellValue(e.RowHandle, gridView.Columns("ModeData"))
                If lData = 3 Then
                    e.Appearance.BackColor = Color.WhiteSmoke
                    e.Appearance.ForeColor = Color.Red
                End If
                If lData = 0 Then
                    e.Appearance.BackColor = Color.WhiteSmoke
                    e.Appearance.ForeColor = Color.DarkBlue
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Function Verify() As Boolean
        Try
            DxErrorProvider1.ClearErrors()

            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".Verify : " & e.Message)
        End Try
    End Function

    Private Sub ControlNavigator1_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs)
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gridView
        view.GridControl.Focus()
        Dim index As Integer = view.FocusedRowHandle
        Dim rec As New MyRecord, rec2 As New MyRecord
        Select Case e.Button.Tag

            Case "Remove"
                If ConvertNullToZero(gridView.GetRowCellValue(index, "ModeData")) = 0 Then Exit Sub

                If ConvertNullToZero(gridView.GetRowCellValue(index, "IsDelete")) = 0 Then
                    If XtraMessageBox.Show(Me, "ยืนยันการลบ ใช่หรือไม่", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                        If ConvertNullToZero(gridView.GetRowCellValue(index, "ID")) = 0 Then
                            gridView.DeleteSelectedRows()
                            gridView.RefreshData()
                            gridControl.RefreshDataSource()
                        Else
                            gridView.SetRowCellValue(index, "ModeData", 3)
                            gridView.SetRowCellValue(index, "IsChange", 1)
                            gridView.RefreshData()
                            gridControl.RefreshDataSource()
                        End If
                    End If
                End If
            Case "MoveUp"
                If index > 0 Then
                    rec = bindingSource1.Item(index)
                    rec2 = bindingSource1.Item(index - 1)

                    bindingSource1.Item(index) = rec2
                    bindingSource1.Item(index - 1) = rec
                    gridView.RefreshData()
                    gridControl.RefreshDataSource()
                End If
            Case "MoveDown"
                If index < (bindingSource1.Count - 1) Then
                    rec = bindingSource1.Item(index)
                    rec2 = bindingSource1.Item(index + 1)

                    bindingSource1.Item(index) = rec2
                    bindingSource1.Item(index + 1) = rec
                    gridView.RefreshData()
                    gridControl.RefreshDataSource()
                End If

        End Select
    End Sub

#End Region

    Public Class MyRecord
        Implements IDXDataErrorInfo



        Public Sub New()

        End Sub

        Dim mOrderID As Long
        Public Property OrderID() As Long
            Get
                Return mOrderID
            End Get
            Set(ByVal value As Long)
                mOrderID = value
            End Set
        End Property

        Dim mOrderCode As String
        Public Property OrderCode() As String
            Get
                Return mOrderCode
            End Get
            Set(ByVal value As String)
                mOrderCode = value
            End Set
        End Property

        Dim mOrderDate As Date
        Public Property OrderDate() As Date
            Get
                Return mOrderDate
            End Get
            Set(ByVal value As Date)
                mOrderDate = value
            End Set
        End Property

        Dim mCustomerCode As String
        Public Property CustomerCode() As String
            Get
                Return mCustomerCode
            End Get
            Set(ByVal value As String)
                mCustomerCode = value
            End Set
        End Property

        Dim mCustomer As String
        Public Property Customer() As String
            Get
                Return mCustomer
            End Get
            Set(ByVal value As String)
                mCustomer = value
            End Set
        End Property

        Dim mOrderStatus As String
        Public Property OrderStatus() As String
            Get
                Return mOrderStatus
            End Get
            Set(ByVal value As String)
                mOrderStatus = value
            End Set
        End Property


        Dim mGrandTotal As Double
        Public Property GrandTotal() As Double
            Get
                Return mGrandTotal
            End Get
            Set(ByVal value As Double)
                mGrandTotal = value
            End Set
        End Property

        Dim mBillCode As String
        Public Property BillCode() As String
            Get
                Return mBillCode
            End Get
            Set(ByVal value As String)
                mBillCode = value
            End Set
        End Property

        Dim mReceiptCode As String
        Public Property ReceiptCode() As String
            Get
                Return mReceiptCode
            End Get
            Set(ByVal value As String)
                mReceiptCode = value
            End Set
        End Property

        Dim mEMPNAME As String
        Public Property EMPNAME() As String
            Get
                Return mEMPNAME
            End Get
            Set(ByVal value As String)
                mEMPNAME = value
            End Set
        End Property


        Dim mShippingPeriod As String
        Public Property ShippingPeriod() As String
            Get
                Return mShippingPeriod
            End Get
            Set(ByVal value As String)
                mShippingPeriod = value
            End Set
        End Property
        Dim mShippingMethod As String
        Public Property ShippingMethod() As String
            Get
                Return mShippingMethod
            End Get
            Set(ByVal value As String)
                mShippingMethod = value
            End Set
        End Property

        Dim mShippingEmpName As String
        Public Property ShippingEmpName() As String
            Get
                Return mShippingEmpName
            End Get
            Set(ByVal value As String)
                mShippingEmpName = value
            End Set
        End Property

        Dim mShippingStatus As String
        Public Property ShippingStatus() As String
            Get
                Return mShippingStatus
            End Get
            Set(ByVal value As String)
                mShippingStatus = value
            End Set
        End Property

        Dim mShippingRemark As String
        Public Property ShippingRemark() As String
            Get
                Return mShippingRemark
            End Get
            Set(ByVal value As String)
                mShippingRemark = value
            End Set
        End Property

        Dim mAssignEmpID As Long
        Public Property AssignEmpID() As Long
            Get
                Return mAssignEmpID
            End Get
            Set(ByVal value As Long)
                mAssignEmpID = value
            End Set
        End Property


        Dim mAssignDate As Date
        Public Property AssignDate() As Date
            Get
                Return mAssignDate
            End Get
            Set(ByVal value As Date)
                mAssignDate = value
            End Set
        End Property

#Region "IDXDataErrorInfo Members"
        Public Sub GetPropertyError(ByVal propertyName As String, ByVal info As ErrorInfo) Implements IDXDataErrorInfo.GetPropertyError
            'If propertyName = "RecordDate" AndAlso IsDate(RecordDate) = False Then
            '    info.ErrorText = String.Format("กรุณาวันที่", propertyName)
            '    info.ErrorType = ErrorType.Critical
            'End If
            'If propertyName = "BankAccountID" AndAlso ConvertNullToZero(BankAccountID) <= 0 AndAlso ConvertNullToZero(ModeData) > 0 Then
            '    info.ErrorText = String.Format("กรุณาระบุบัญชี", propertyName)
            '    info.ErrorType = ErrorType.Critical
            'End If
            'If propertyName = "DR" AndAlso IsDBNull(DR) Then
            '    DR = 0
            'End If
            'If propertyName = "CR" AndAlso IsDBNull(CR) Then
            '    CR = 0
            'End If
        End Sub


        Public Sub GetError(ByVal info As ErrorInfo) Implements IDXDataErrorInfo.GetError
            Dim propertyInfo As New ErrorInfo()
            GetPropertyError("RecordDate", propertyInfo)
            If propertyInfo.ErrorText = "" Then
                GetPropertyError("BankAccountID", propertyInfo)
            End If
            If propertyInfo.ErrorText <> "" Then
                info.ErrorText = "พบข้อผิดพลาด"
            End If
        End Sub
#End Region
    End Class


End Class