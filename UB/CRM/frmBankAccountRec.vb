Option Explicit On

Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmBankAccountRec
    Inherits iEditForm
    Private Const mFormName As String = "frmBankAccountRec"

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


            lblBalance.Text = "ยอดคงเหลือ  " & lBalance.ToString("#,##0.00")
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

    Private Sub ControlNavigator1_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles ControlNavigator1.ButtonClick
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

        Dim mIDs As Long
        Dim mBankAccountID As Long
        Dim mRecordDate As Date
        Dim mRemark As String
        Dim mDR As Double
        Dim mCR As Double
        Dim mIsChange As Integer
        Dim mIsDelete As Integer
        Public Sub New()
            ID = 0
            RecordDate = Now
            DR = 0
            CR = 0
        End Sub
        Public Property IsDelete() As Integer
            Get
                Return mIsDelete
            End Get
            Set(ByVal value As Integer)
                mIsDelete = value
            End Set
        End Property
        Public Property ID() As Long
            Get
                Return mIDs
            End Get
            Set(ByVal value As Long)
                mIDs = value
            End Set
        End Property

        Public Property BankAccountID() As Long
            Get
                Return mBankAccountID
            End Get
            Set(ByVal value As Long)
                mBankAccountID = value
            End Set
        End Property


        Public Property RecordDate() As Date
            Get
                Return mRecordDate
            End Get
            Set(ByVal value As Date)
                mRecordDate = value
            End Set
        End Property
        Public Property Remark() As String
            Get
                Return mRemark
            End Get
            Set(ByVal value As String)
                mRemark = value
            End Set
        End Property

        Public Property DR() As Double
            Get
                Return mDR
            End Get
            Set(ByVal value As Double)
                mDR = value
            End Set
        End Property

        Public Property CR() As Double
            Get
                Return mCR
            End Get
            Set(ByVal value As Double)
                mCR = value
            End Set
        End Property
        Public Property IsChange() As Integer
            Get
                Return mIsChange
            End Get
            Set(ByVal value As Integer)
                mIsChange = value
            End Set
        End Property

        Private mModeData As Integer
        Public Property ModeData() As Integer
            Get
                Return mModeData
            End Get
            Set(ByVal value As Integer)
                mModeData = value
            End Set
        End Property
#Region "IDXDataErrorInfo Members"
        Public Sub GetPropertyError(ByVal propertyName As String, ByVal info As ErrorInfo) Implements IDXDataErrorInfo.GetPropertyError
            If propertyName = "RecordDate" AndAlso IsDate(RecordDate) = False Then
                info.ErrorText = String.Format("กรุณาวันที่", propertyName)
                info.ErrorType = ErrorType.Critical
            End If
            If propertyName = "BankAccountID" AndAlso ConvertNullToZero(BankAccountID) <= 0 AndAlso ConvertNullToZero(ModeData) > 0 Then
                info.ErrorText = String.Format("กรุณาระบุบัญชี", propertyName)
                info.ErrorType = ErrorType.Critical
            End If
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