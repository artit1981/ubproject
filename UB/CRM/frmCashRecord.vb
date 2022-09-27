Option Explicit On

Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmCashRecord
    Inherits iEditForm
    Private Const mFormName As String = "frmCashRecord"

#Region "Overrides"

    Protected Overrides Sub OnLoadForm(ByVal pMode As Integer, ByVal pID As Long, ByVal pOrderType As Long, ByVal pclsConvert As iOrder, ByVal pCusID As Long)
        Try

            InitialCombo()
            dtpDateFrom.EditValue = DateSerial(Now.Year + 543, 1, 1)
            dtpDateTo.EditValue = Now


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
                If gridView.RowCount > 0 Then
                    For lRow = 0 To gridView.RowCount
                        If ConvertNullToZero(gridView.GetRowCellValue(lRow, "IsChange")) = 1 Then
                            Dim lDataDAO = New CashRecordSDAO
                            lDataDAO.ID = ConvertNullToZero(gridView.GetRowCellDisplayText(lRow, "ID"))
                            If lDataDAO.ID = 0 Then
                                lDataDAO.ModeData = Integer.Parse(DataMode.ModeNew)
                            Else
                                lDataDAO.ModeData = Integer.Parse(DataMode.ModeEdit)
                            End If
                            lDataDAO.RecordDate = gridView.GetRowCellValue(lRow, "RecordDate")
                            lDataDAO.CashItemID = ConvertNullToZero(gridView.GetRowCellValue(lRow, "CashItemID"))
                            lDataDAO.DR = ConvertNullToZero(gridView.GetRowCellDisplayText(lRow, "DR"))
                            lDataDAO.CR = ConvertNullToZero(gridView.GetRowCellDisplayText(lRow, "CR"))
                            lDataDAO.Remark = ConvertNullToString(gridView.GetRowCellDisplayText(lRow, "Remark"))
                            lDataDAO.SaveData(Nothing)
                        End If
                    Next
                End If

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


    Private Sub gridView_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gridView.ValidateRow
        Dim info As New ErrorInfo()
        TryCast(e.Row, MyRecord).GetError(info)
        e.Valid = info.ErrorText = ""

    End Sub

    Private Sub gridView_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gridView.InvalidRowException
        e.ExceptionMode = ExceptionMode.NoAction
    End Sub

    Private Sub gridView_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles gridView.RowUpdated
        TryCast(e.Row, MyRecord).IsChange = 1
    End Sub

    Private Sub gridView_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles gridView.InitNewRow
        Dim view As GridView = CType(sender, GridView)
        view.SetRowCellValue(e.RowHandle, view.Columns("RecordDate"), DateTime.Today)
        view.SetRowCellValue(e.RowHandle, view.Columns("ID"), 0)
        view.SetRowCellValue(e.RowHandle, view.Columns("DR"), 0)
        view.SetRowCellValue(e.RowHandle, view.Columns("CR"), 0)
        view.SetRowCellValue(e.RowHandle, view.Columns("Remark"), "")
    End Sub

#End Region


#Region "Private"

    Private Sub InitialCombo()
        Try
            Call LoadDataCashItem()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".InitialCombo : " & e.Message)
        End Try
    End Sub

    Private Sub LoadDataCashItem()
        Dim lcls As New MasterDAO


        Dim pTable = GetMasterTableName(Integer.Parse(MasterType.CashItem))
        Try
            Dim dataTable = lcls.GetDataTable(0, pTable, True)
            CashItemIDLookUpEdit.DataSource = dataTable

            Dim dataTable2 = dataTable.Clone
            Dim drNewRow As DataRow = dataTable2.NewRow

            'specify the information of the new row.
            drNewRow("ID") = 0
            drNewRow("CodeThai") = "ALL"

            dataTable2.Rows.Add(drNewRow)

            CashItemID.Properties.DataSource = dataTable2
            CashItemID.Properties.DisplayMember = "CodeThai"
            CashItemID.Properties.ValueMember = "ID"
            CashItemID.EditValue = 0

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, ".LoadDataCashItem : " & e.Message)
        Finally

        End Try

    End Sub


    Private Sub LoadData()
        Dim lcls As New CashRecordSDAO

        Try
            'bindingSource1 = Nothing
            bindingSource1.DataSource = GetType(MyRecord)
            Dim dataTable = lcls.GetDataTable(CashItemID.EditValue, dtpDateFrom.EditValue, dtpDateTo.EditValue)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    Dim rec As New MyRecord()
                    rec.ID = dr("ID")
                    rec.CashItemID = ConvertNullToZero(dr("CashItemID"))
                    rec.RecordDate = dr("RecordDate")
                    rec.DR = ConvertNullToZero(dr("DR"))
                    rec.CR = ConvertNullToZero(dr("CR"))
                    rec.Remark = ConvertNullToString(dr("Remark"))
                    rec.IsChange = 0
                    bindingSource1.Add(rec)
                Next
            End If

            DxErrorProvider1.DataSource = bindingSource1
            DxErrorProvider1.ContainerControl = Me
            gridControl.DataSource = bindingSource1

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucProductLocation.LoadData : " & e.Message)
        Finally

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

#End Region

    Public Class MyRecord
        Implements IDXDataErrorInfo

        Dim mIDs As Long
        Dim mCashItemID As Long
        Dim mRecordDate As Date
        Dim mRemark As String
        Dim mDR As Double
        Dim mCR As Double
        Dim mIsChange As Integer

        Public Sub New()
            ID = 0
            RecordDate = Now
            DR = 0
            CR = 0
        End Sub

        Public Property ID() As Long
            Get
                Return mIDs
            End Get
            Set(ByVal value As Long)
                mIDs = value
            End Set
        End Property

        Public Property CashItemID() As Long
            Get
                Return mCashItemID
            End Get
            Set(ByVal value As Long)
                mCashItemID = value
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
#Region "IDXDataErrorInfo Members"
        Public Sub GetPropertyError(ByVal propertyName As String, ByVal info As ErrorInfo) Implements IDXDataErrorInfo.GetPropertyError
            If propertyName = "RecordDate" AndAlso IsDate(RecordDate) = False Then
                info.ErrorText = String.Format("กรุณาวันที่", propertyName)
                info.ErrorType = ErrorType.Critical
            End If
            If propertyName = "CashItemID" AndAlso ConvertNullToZero(CashItemID) <= 0 Then
                info.ErrorText = String.Format("กรุณาระบุรายการเงินสดย่อย", propertyName)
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
                GetPropertyError("CashItemID", propertyInfo)
            End If
            If propertyInfo.ErrorText <> "" Then
                info.ErrorText = "พบข้อผิดพลาด"
            End If
        End Sub
#End Region
    End Class


End Class