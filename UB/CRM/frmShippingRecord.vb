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
        'Try
        '    If Verify() = True Then

        '        'For Each pDataDAO As MyRecord In bindingSource1
        '        '    If pDataDAO.IsChange = 1 And pDataDAO.IsDelete = 0 And pDataDAO.ModeData > 0 Then
        '        '        Dim lDataDAO = New BankAccountRecordSDAO
        '        '        lDataDAO.ID = pDataDAO.ID
        '        '        If pDataDAO.ModeData = 3 Then
        '        '            lDataDAO.ModeData = Integer.Parse(DataMode.ModeDelete)
        '        '        ElseIf lDataDAO.ID = 0 Then
        '        '            lDataDAO.ModeData = Integer.Parse(DataMode.ModeNew)
        '        '        Else
        '        '            lDataDAO.ModeData = Integer.Parse(DataMode.ModeEdit)
        '        '        End If
        '        '        lDataDAO.RecordDate = pDataDAO.RecordDate
        '        '        lDataDAO.BankAccountID = pDataDAO.BankAccountID
        '        '        lDataDAO.DR = pDataDAO.DR
        '        '        lDataDAO.CR = pDataDAO.CR
        '        '        lDataDAO.Remark = pDataDAO.Remark
        '        '        lDataDAO.SaveData(Nothing)
        '        '    End If
        '        'Next
        '        Return True
        '    Else
        '        ShowProgress(False, "")
        '        XtraMessageBox.Show(Me, "พบข้อผิดพลาดกรุณาตรวจสอบ", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    End If
        'Catch ex As Exception
        '    Err.Raise(Err.Number, ex.Source, mFormName & ".Save : " & ex.Message)
        '    Return False
        'End Try
    End Function


    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        LoadData()
    End Sub


    'Private Sub gridView_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gridView.ValidateRow
    '    Dim info As New ErrorInfo()
    '    TryCast(e.Row, MyRecord).GetError(info)
    '    e.Valid = info.ErrorText = ""

    'End Sub

    'Private Sub gridView_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs)
    '    e.ExceptionMode = ExceptionMode.NoAction
    'End Sub

    'Private Sub gridView_RowUpdated(sender As Object, e As RowObjectEventArgs)
    '    If e.Row IsNot Nothing Then
    '        TryCast(e.Row, MyRecord).IsChange = 1
    '    End If

    'End Sub

    'Private Sub gridView_InitNewRow(sender As Object, e As InitNewRowEventArgs)
    '    Dim view As GridView = CType(sender, GridView)
    '    view.SetRowCellValue(e.RowHandle, view.Columns("RecordDate"), GetCurrentDate(Nothing))
    '    view.SetRowCellValue(e.RowHandle, view.Columns("ID"), 0)
    '    view.SetRowCellValue(e.RowHandle, view.Columns("DR"), 0)
    '    view.SetRowCellValue(e.RowHandle, view.Columns("CR"), 0)
    '    view.SetRowCellValue(e.RowHandle, view.Columns("ModeData"), 1)
    '    view.SetRowCellValue(e.RowHandle, view.Columns("Remark"), "")
    '    view.SetRowCellValue(e.RowHandle, view.Columns("IsDelete"), 0)
    'End Sub

#End Region


#Region "Private"

    Private Sub InitialCombo()
        Try
            'Call LoadDataBankAccount()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".InitialCombo : " & e.Message)
        End Try
    End Sub

    'Private Sub LoadDataBankAccount()
    '    Dim lcls As New BankAccountDAO


    '    Try
    '        Dim dataTable = lcls.GetDataTable(0, True, 0, 0)
    '        BankAccountIDLookUpEdit.DataSource = dataTable

    '        Dim dataTable2 = lcls.GetDataTable(0, True, 0, 0)
    '        Dim drNewRow As DataRow = dataTable2.NewRow

    '        'specify the information of the new row.
    '        drNewRow("ID") = 0
    '        drNewRow("BankAccountCode") = "ALL"
    '        drNewRow("BankAccountNo") = "ALL"
    '        drNewRow("BankName") = "ALL"
    '        drNewRow("CusName") = "ALL"
    '        drNewRow("ACCNAME") = "ALL"

    '        dataTable2.Rows.Add(drNewRow)

    '        BankAccID.Properties.DataSource = dataTable2
    '        BankAccID.Properties.DisplayMember = "ACCNAME"
    '        BankAccID.Properties.ValueMember = "ID"
    '        BankAccID.EditValue = 0

    '    Catch e As Exception
    '        Err.Raise(Err.Number, e.Source, "frmBankAccountRec.LoadDataLocaton : " & e.Message)
    '    Finally

    '        lcls = Nothing
    '    End Try
    'End Sub


    Private Sub LoadData()
        Dim lcls As New OrderSDAO

        'Dim lBalance As Decimal = 0
        Try

            Dim dataTable = lcls.GetDataTableForShippingRec(dtpDateFrom.EditValue, dtpDateTo.EditValue)

            'If dataTable.Rows.Count > 0 Then
            '    For Each dr As DataRow In dataTable.Rows
            '        Dim rec As New MyRecord()
            '        rec.ID = dr("ID")
            '        rec.BankAccountID = ConvertNullToZero(dr("BankAccountID"))
            '        rec.RecordDate = dr("RecordDate")
            '        rec.DR = ConvertNullToZero(dr("DR"))
            '        rec.CR = ConvertNullToZero(dr("CR"))
            '        rec.Remark = ConvertNullToString(dr("Remark"))
            '        rec.IsChange = 0
            '        rec.ModeData = 2
            '        rec.IsDelete = ConvertNullToZero(dr("IsDelete"))
            '        bindingSource1.Add(rec)
            '        lBalance += rec.DR
            '        lBalance -= rec.CR
            '    Next
            'End If




            DxErrorProvider1.ContainerControl = Me
            GridControl.DataSource = dataTable

            GridStyle()

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "frmBankAccountRec.LoadData : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    Private Sub GridStyle()
        With GridView

            .Columns("OrderID").Visible = False
            .Columns("IsSelect").Visible = False

            .Columns("OrderCode").Caption = "เลขที่"
            .Columns("OrderCode").Width = 100
            .Columns("OrderCode").MaxWidth = 120
            .Columns("OrderCode").OptionsColumn.ReadOnly = True

            .Columns("OrderDate").Caption = "วันที่"
            .Columns("OrderDate").Width = 80
            .Columns("OrderDate").MaxWidth = 90
            .Columns("OrderDate").OptionsColumn.ReadOnly = True

            .Columns("CustomerCode").Caption = "รหัสลูกค้า"
            .Columns("CustomerCode").Width = 90
            .Columns("CustomerCode").MinWidth = 90
            .Columns("CustomerCode").MaxWidth = 160
            .Columns("CustomerCode").OptionsColumn.ReadOnly = True

            .Columns("Customer").Caption = "ลูกค้า"
            .Columns("Customer").OptionsColumn.ReadOnly = True

            .Columns("OrderStatus").Caption = "สถานะ"
            .Columns("OrderStatus").Width = 70
            .Columns("OrderStatus").MaxWidth = 70
            .Columns("OrderStatus").OptionsColumn.ReadOnly = True

            .Columns("GrandTotal").Caption = "ยอดรวม"
            .Columns("GrandTotal").Width = 110
            .Columns("GrandTotal").MaxWidth = 120
            .Columns("GrandTotal").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            .Columns("GrandTotal").DisplayFormat.FormatString = "n2"
            .Columns("GrandTotal").OptionsColumn.ReadOnly = True

            .Columns("ReceiptCode").Caption = "เลขที่ใบเสร็จ"
            .Columns("ReceiptCode").Width = 90
            .Columns("ReceiptCode").MaxWidth = 90
            .Columns("ReceiptCode").OptionsColumn.ReadOnly = True

            .Columns("BillCode").Caption = "เลขที่บิล"
            .Columns("BillCode").Width = 90
            .Columns("BillCode").MaxWidth = 90
            .Columns("BillCode").OptionsColumn.ReadOnly = True

            .Columns("EMPNAME").Caption = "ผู้รับผิดชอบ"
            .Columns("EMPNAME").Width = 150
            .Columns("EMPNAME").MaxWidth = 160
            .Columns("EMPNAME").OptionsColumn.ReadOnly = True

            .Columns("ShippingPeriod").Caption = "กำหนดเวลาส่ง"
            .Columns("ShippingPeriod").Width = 90
            .Columns("ShippingPeriod").MaxWidth = 90
            .Columns("ShippingPeriod").OptionsColumn.ReadOnly = True

            .Columns("ShippingMethod").Caption = "ลักษณะงาน"
            .Columns("ShippingMethod").Width = 90
            .Columns("ShippingMethod").MaxWidth = 90
            .Columns("ShippingMethod").OptionsColumn.ReadOnly = True

            .Columns("ShippingEmp").Caption = "ชื่อผู้ส่ง"
            .Columns("ShippingEmp").Width = 90
            .Columns("ShippingEmp").MaxWidth = 90
            .Columns("ShippingEmp").OptionsColumn.ReadOnly = True

            .Columns("ShippingStatus").Caption = "สถานะ"
            .Columns("ShippingStatus").Width = 90
            .Columns("ShippingStatus").MaxWidth = 90
            .Columns("ShippingStatus").OptionsColumn.ReadOnly = True

            .Columns("ShippingRemark").Caption = "หมายเหตุ"
            .Columns("ShippingRemark").Width = 110
            .Columns("ShippingRemark").MaxWidth = 120
            .Columns("ShippingRemark").OptionsColumn.ReadOnly = True

        End With
    End Sub

    Private Sub btnAssign_Click(sender As Object, e As EventArgs) Handles btnAssign.Click
        Try
            Dim llRow As Long = 0
            Dim lList As New List(Of iOrder)
            For lRow = 0 To GridView.RowCount
                If GridView.GetRowCellValue(lRow, "IsSelect") = 1 Then
                    Dim liorder As New iOrder With {
                            .ID = GridView.GetRowCellValue(lRow, "OrderID")
                        }
                    lList.Add(liorder)
                End If
            Next
                If lList.Count > 0 Then
                    Dim lFrmEdit As New frmShippingRecordDTL
                    lFrmEdit.iOrderListDAO = lList
                    Dim lResult = lFrmEdit.ShowDialog()
                    If lResult = DialogResult.OK Then
                        LoadData()
                    End If
                End If
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)

        End Try


 
    End Sub
    'Private Sub gridView_RowStyle(sender As Object, e As RowStyleEventArgs)

    '    Dim lData As Integer = 0
    '    Try
    '        If (e.RowHandle >= 0) Then

    '            lData = GridView.GetRowCellValue(e.RowHandle, GridView.Columns("IsDelete"))
    '            If lData = 1 Then
    '                e.Appearance.BackColor = Color.WhiteSmoke
    '                e.Appearance.ForeColor = Color.Red
    '            End If
    '            lData = GridView.GetRowCellValue(e.RowHandle, GridView.Columns("ModeData"))
    '            If lData = 3 Then
    '                e.Appearance.BackColor = Color.WhiteSmoke
    '                e.Appearance.ForeColor = Color.Red
    '            End If
    '            If lData = 0 Then
    '                e.Appearance.BackColor = Color.WhiteSmoke
    '                e.Appearance.ForeColor = Color.DarkBlue
    '            End If
    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub
    'Private Function Verify() As Boolean
    '    Try
    '        DxErrorProvider1.ClearErrors()

    '        Return True
    '    Catch e As Exception
    '        Err.Raise(Err.Number, e.Source, mFormName & ".Verify : " & e.Message)
    '    End Try
    'End Function



#End Region

    'Public Class MyRecord
    '    'Implements IDXDataErrorInfo


    '    Dim mIsSelect As Integer = 0
    '    Public Property IsSelect() As Integer
    '        Get
    '            Return mIsSelect
    '        End Get
    '        Set(ByVal value As Integer)
    '            mIsSelect = value
    '        End Set
    '    End Property

    '    '        Public Sub New()

    '    '        End Sub

    '    Dim mOrderID As Long
    '    Public Property OrderID() As Long
    '        Get
    '            Return mOrderID
    '        End Get
    '        Set(ByVal value As Long)
    '            mOrderID = value
    '        End Set
    '    End Property

    '    '        Dim mOrderCode As String
    '    '        Public Property OrderCode() As String
    '    '            Get
    '    '                Return mOrderCode
    '    '            End Get
    '    '            Set(ByVal value As String)
    '    '                mOrderCode = value
    '    '            End Set
    '    '        End Property

    '    '        Dim mOrderDate As Date
    '    '        Public Property OrderDate() As Date
    '    '            Get
    '    '                Return mOrderDate
    '    '            End Get
    '    '            Set(ByVal value As Date)
    '    '                mOrderDate = value
    '    '            End Set
    '    '        End Property

    '    '        Dim mCustomerCode As String
    '    '        Public Property CustomerCode() As String
    '    '            Get
    '    '                Return mCustomerCode
    '    '            End Get
    '    '            Set(ByVal value As String)
    '    '                mCustomerCode = value
    '    '            End Set
    '    '        End Property

    '    '        Dim mCustomer As String
    '    '        Public Property Customer() As String
    '    '            Get
    '    '                Return mCustomer
    '    '            End Get
    '    '            Set(ByVal value As String)
    '    '                mCustomer = value
    '    '            End Set
    '    '        End Property

    '    '        Dim mOrderStatus As String
    '    '        Public Property OrderStatus() As String
    '    '            Get
    '    '                Return mOrderStatus
    '    '            End Get
    '    '            Set(ByVal value As String)
    '    '                mOrderStatus = value
    '    '            End Set
    '    '        End Property


    '    '        Dim mGrandTotal As Double
    '    '        Public Property GrandTotal() As Double
    '    '            Get
    '    '                Return mGrandTotal
    '    '            End Get
    '    '            Set(ByVal value As Double)
    '    '                mGrandTotal = value
    '    '            End Set
    '    '        End Property

    '    '        Dim mBillCode As String
    '    '        Public Property BillCode() As String
    '    '            Get
    '    '                Return mBillCode
    '    '            End Get
    '    '            Set(ByVal value As String)
    '    '                mBillCode = value
    '    '            End Set
    '    '        End Property

    '    '        Dim mReceiptCode As String
    '    '        Public Property ReceiptCode() As String
    '    '            Get
    '    '                Return mReceiptCode
    '    '            End Get
    '    '            Set(ByVal value As String)
    '    '                mReceiptCode = value
    '    '            End Set
    '    '        End Property

    '    '        Dim mEMPNAME As String
    '    '        Public Property EMPNAME() As String
    '    '            Get
    '    '                Return mEMPNAME
    '    '            End Get
    '    '            Set(ByVal value As String)
    '    '                mEMPNAME = value
    '    '            End Set
    '    '        End Property


    '    '        Dim mShippingPeriod As String
    '    '        Public Property ShippingPeriod() As String
    '    '            Get
    '    '                Return mShippingPeriod
    '    '            End Get
    '    '            Set(ByVal value As String)
    '    '                mShippingPeriod = value
    '    '            End Set
    '    '        End Property
    '    '        Dim mShippingMethod As String
    '    '        Public Property ShippingMethod() As String
    '    '            Get
    '    '                Return mShippingMethod
    '    '            End Get
    '    '            Set(ByVal value As String)
    '    '                mShippingMethod = value
    '    '            End Set
    '    '        End Property

    '    '        Dim mShippingEmp As String
    '    '        Public Property ShippingEmp() As String
    '    '            Get
    '    '                Return mShippingEmp
    '    '            End Get
    '    '            Set(ByVal value As String)
    '    '                mShippingEmp = value
    '    '            End Set
    '    '        End Property

    '    '        Dim mShippingStatus As String
    '    '        Public Property ShippingStatus() As String
    '    '            Get
    '    '                Return mShippingStatus
    '    '            End Get
    '    '            Set(ByVal value As String)
    '    '                mShippingStatus = value
    '    '            End Set
    '    '        End Property

    '    '        Dim mShippingRemark As String
    '    '        Public Property ShippingRemark() As String
    '    '            Get
    '    '                Return mShippingRemark
    '    '            End Get
    '    '            Set(ByVal value As String)
    '    '                mShippingRemark = value
    '    '            End Set
    '    '        End Property

    '    '        Dim mAssignEmp As String
    '    '        Public Property AssignEmp() As String
    '    '            Get
    '    '                Return mAssignEmp
    '    '            End Get
    '    '            Set(ByVal value As String)
    '    '                mAssignEmp = value
    '    '            End Set
    '    '        End Property


    '    '        Dim mAssignDate As Date
    '    '        Public Property AssignDate() As Date
    '    '            Get
    '    '                Return mAssignDate
    '    '            End Get
    '    '            Set(ByVal value As Date)
    '    '                mAssignDate = value
    '    '            End Set
    '    '        End Property


    '    '#Region "IDXDataErrorInfo Members"
    '    '        Public Sub GetPropertyError(ByVal propertyName As String, ByVal info As ErrorInfo) Implements IDXDataErrorInfo.GetPropertyError
    '    '            'If propertyName = "RecordDate" AndAlso IsDate(RecordDate) = False Then
    '    '            '    info.ErrorText = String.Format("กรุณาวันที่", propertyName)
    '    '            '    info.ErrorType = ErrorType.Critical
    '    '            'End If
    '    '            'If propertyName = "BankAccountID" AndAlso ConvertNullToZero(BankAccountID) <= 0 AndAlso ConvertNullToZero(ModeData) > 0 Then
    '    '            '    info.ErrorText = String.Format("กรุณาระบุบัญชี", propertyName)
    '    '            '    info.ErrorType = ErrorType.Critical
    '    '            'End If
    '    '            'If propertyName = "DR" AndAlso IsDBNull(DR) Then
    '    '            '    DR = 0
    '    '            'End If
    '    '            'If propertyName = "CR" AndAlso IsDBNull(CR) Then
    '    '            '    CR = 0
    '    '            'End If
    '    '        End Sub


    '    '        Public Sub GetError(ByVal info As ErrorInfo) Implements IDXDataErrorInfo.GetError
    '    '            Dim propertyInfo As New ErrorInfo()
    '    '            GetPropertyError("RecordDate", propertyInfo)
    '    '            If propertyInfo.ErrorText = "" Then
    '    '                GetPropertyError("BankAccountID", propertyInfo)
    '    '            End If
    '    '            If propertyInfo.ErrorText <> "" Then
    '    '                info.ErrorText = "พบข้อผิดพลาด"
    '    '            End If
    '    '        End Sub
    '    '#End Region
    'End Class


End Class