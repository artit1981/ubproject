
Option Explicit On

Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmCommission
    Inherits iEditForm
    Private Const mFormName As String = "frmCommission"
    Dim mcls As New CommissionDAO

#Region "Overrides"
    Protected Overrides Sub OnLoadForm(ByVal pMode As Integer, ByVal pID As Long, ByVal pOrderType As Long, ByVal pclsConvert As iOrder, ByVal pCusID As Long)
        Try
            SetComboTerritory()

            Call LoadData(pMode, pID)

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".OnLoadForm : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboTerritory()
        Try
            SetLookUpTerritory(TerritoryID)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboTerritory : " & e.Message)
        Finally
        End Try
    End Sub

    Protected Overrides Sub ClearAllForm(ByVal pMode As Integer)
        Try
            MyBase.ClearAllForm(pMode)
            Select Case pMode
                Case DataMode.ModeNew
                    ClearForm(GeneralTabPage)
                    ClearForm(UcAdmin1)
                    UcNote1.ClearControl()

            End Select

            XtraTabControl1.SelectedTabPage = GeneralTabPage
            ExpireDate.EditValue = DateAdd(DateInterval.Month, 1, GetCurrentDate(Nothing))
            Subject.Select()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".ClearAllForm : " & e.Message)
        End Try
    End Sub

    Protected Overrides Function Save(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        XtraTabControl1.SelectedTabPage = GeneralTabPage
        Try

            mcls.ID = pID
            mcls.ModeData = pMode
            mcls.Subject = Subject.Text.Trim
            mcls.CommissionType = CommissionType.EditValue
            mcls.TerritoryID = TerritoryID.EditValue
            mcls.StartDate = StartDate.EditValue
            mcls.ExpireDate = ExpireDate.EditValue
            mcls.Remark = Remark.Text.Trim
            mcls.IsInActive = UcAdmin1.CheckInAcive.Checked
            mcls.NoteDAOs = UcNote1.GetNoteDAOs

            If Verify() = True Then
                Dim lDtlList As New List(Of CommissionDtlDAO)
                For Each pDataDAO As MyRecord In bindingSource1
                    If pDataDAO.IsChange = 1 And pDataDAO.IsDelete = 0 Then
                        Dim lDataDAO = New CommissionDtlDAO
                        lDataDAO.CommissionID = pID
                        lDataDAO.CommissionDtlID = pDataDAO.CommissionDtlID
                        lDataDAO.SEQ = pDataDAO.SEQ
                        lDataDAO.AmountFrom = pDataDAO.AmountFrom
                        lDataDAO.AmountEnd = pDataDAO.AmountEnd
                        lDataDAO.ComAmount = pDataDAO.ComAmount
                        lDataDAO.ComPercen = pDataDAO.ComPercen

                        If pDataDAO.ModeData = 3 Then
                            lDataDAO.ModeData = Integer.Parse(DataMode.ModeDelete)
                        ElseIf lDataDAO.CommissionDtlID = 0 Then
                            lDataDAO.ModeData = Integer.Parse(DataMode.ModeNew)
                        Else
                            lDataDAO.ModeData = Integer.Parse(DataMode.ModeEdit)
                        End If

                        lDtlList.Add(lDataDAO)
                    End If
                Next

                mcls.DtlList = lDtlList
                Return mcls.SaveData()
            Else
                ShowProgress(False, "")
                XtraMessageBox.Show(Me, "พบข้อผิดพลาดกรุณาตรวจสอบ", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".Save : " & ex.Message)
            Return False
        End Try
    End Function


    Protected Overrides Sub OnClosedForm()
        mcls = Nothing
    End Sub
#End Region

#Region "Event"

    Private Sub FormChangedComponent1_FormControlChanged1(ByVal sender As Object, ByVal e As FormChangedEventArgs) Handles FormChangedComponent1.FormControlChanged
        MyBase.CheckFormChanged()
    End Sub

    Private Sub gridView_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
        ReGenSEQ()
    End Sub

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
        view.SetRowCellValue(e.RowHandle, view.Columns("CommissionDtlID"), 0)
        view.SetRowCellValue(e.RowHandle, view.Columns("AmountFrom"), 0)
        view.SetRowCellValue(e.RowHandle, view.Columns("AmountEnd"), 0)
        view.SetRowCellValue(e.RowHandle, view.Columns("ComAmount"), 0)
        view.SetRowCellValue(e.RowHandle, view.Columns("ComPercen"), 0)
        view.SetRowCellValue(e.RowHandle, view.Columns("ModeData"), 1)
        view.SetRowCellValue(e.RowHandle, view.Columns("IsDelete"), 0)
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
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ControlNavigator1_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles ControlNavigator1.ButtonClick
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gridView
        view.GridControl.Focus()
        Dim index As Integer = view.FocusedRowHandle
        Dim rec As New MyRecord, rec2 As New MyRecord
        Select Case e.Button.Tag

            Case "Remove"
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

#Region "Private"


    Private Function LoadData(ByVal pMode As Integer, ByVal pID As Long) As Boolean

        Try
            If pMode = DataMode.ModeNew Then
                LoadDataDtl(0)
            ElseIf pMode = DataMode.ModeEdit Then
                If mcls.InitailData(pID) Then
                    Subject.Text = mcls.Subject

                    CommissionType.EditValue = mcls.CommissionType
                    TerritoryID.EditValue = mcls.TerritoryID
                    StartDate.EditValue = mcls.StartDate
                    ExpireDate.EditValue = mcls.ExpireDate
                    Remark.EditValue = mcls.Remark
                    UcAdmin1.CheckInAcive.Checked = mcls.IsInActive
                    UcAdmin1.txtCreateBy.Text = mcls.CreateBy.Trim
                    UcAdmin1.txtCreateTime.Text = mcls.CreateTime
                    UcAdmin1.txtModifiBy.Text = mcls.ModifiedBy.Trim
                    UcAdmin1.txtModifiTime.Text = mcls.ModifiedTime

                    LoadDataDtl(pID)
                End If
            End If

            'Note
            UcNote1.ShowControl(mcls.TableName, pID)



        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".LoadData : " & ex.Message)
            Return False
        Finally

        End Try
    End Function

    Private Sub LoadDataDtl(ByVal pCommissionID As Long)
        Dim lcls As New CommissionDtlDAO
        Dim dataTable As New DataTable()
        Dim lBalance As Decimal = 0
        Try
            bindingSource1 = New BindingSource
            bindingSource1.DataSource = GetType(MyRecord)
            dataTable = lcls.GetDataTable(pCommissionID)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    Dim rec As New MyRecord()
                    rec.CommissionDtlID = dr("CommissionDtlID")
                    rec.CommissionID = ConvertNullToZero(dr("CommissionID"))
                    rec.SEQ = dr("SEQ")
                    rec.AmountFrom = ConvertNullToZero(dr("AmountFrom"))
                    rec.AmountEnd = ConvertNullToZero(dr("AmountEnd"))
                    rec.ComPercen = ConvertNullToZero(dr("ComPercen"))
                    rec.ComAmount = ConvertNullToZero(dr("ComAmount"))
                    rec.IsChange = 0
                    rec.ModeData = 2
                    rec.IsDelete = 0
                    bindingSource1.Add(rec)

                Next
            End If

            DxErrorProvider1.DataSource = bindingSource1
            DxErrorProvider1.ContainerControl = Me
            gridControl.DataSource = bindingSource1

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "frmBankAccountRec.LoadData : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub



    Private Function Verify() As Boolean
        Try
            DxErrorProvider1.ClearErrors()
            If Trim(Subject.Text) = "" Then
                SetErrorProvider(DxErrorProvider1, Subject, "กรุณาระบุข้อมูล")
            ElseIf mcls.CheckExist() Then
                SetErrorProvider(DxErrorProvider1, Subject, "ข้อมูลซ้ำ")
            End If





            Return DxErrorProvider1.HasErrors = False
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".Verify : " & e.Message)
        End Try
    End Function


    Private Sub ReGenSEQ()
        Try
            If gridView.RowCount > 0 Then
                For lRow = 0 To gridView.RowCount
                    gridView.SetRowCellValue(lRow, "SEQ", lRow + 1)
                Next
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, ".ReGenSEQ : " & e.Message)
        Finally
        End Try

    End Sub


#End Region


End Class

Public Class MyRecord
    Implements IDXDataErrorInfo

    Dim mIsDelete As Long = 0
    Public Property IsDelete() As Integer
        Get
            Return mIsDelete
        End Get
        Set(ByVal value As Integer)
            mIsDelete = value
        End Set
    End Property

    Dim mCommissionDtlID As Long = 0
    Public Property CommissionDtlID() As Long
        Get
            Return mCommissionDtlID
        End Get
        Set(ByVal value As Long)
            mCommissionDtlID = value
        End Set
    End Property

    Dim mSEQ As Long = 0
    Public Property SEQ() As Long
        Get
            Return mSEQ
        End Get
        Set(ByVal value As Long)
            mSEQ = value
        End Set
    End Property

    Dim mCommissionID As Long = 0
    Public Property CommissionID() As Long
        Get
            Return mCommissionID
        End Get
        Set(ByVal value As Long)
            mCommissionID = value
        End Set
    End Property

    Dim mAmountFrom As Double = 0
    Public Property AmountFrom() As Double
        Get
            Return mAmountFrom
        End Get
        Set(ByVal value As Double)
            mAmountFrom = value
        End Set
    End Property

    Dim mAmountEnd As Double = 0
    Public Property AmountEnd() As Double
        Get
            Return mAmountEnd
        End Get
        Set(ByVal value As Double)
            mAmountEnd = value
        End Set
    End Property

    Dim mComAmount As Double = 0
    Public Property ComAmount() As Double
        Get
            Return mComAmount
        End Get
        Set(ByVal value As Double)
            mComAmount = value
        End Set
    End Property

    Dim mComPercen As Double = 0
    Public Property ComPercen() As Double
        Get
            Return mComPercen
        End Get
        Set(ByVal value As Double)
            mComPercen = value
        End Set
    End Property

    Dim mIsChange As Integer = 0
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
        If propertyName = "AmountEnd" AndAlso AmountEnd = 0 Then
            info.ErrorText = String.Format("ข้อมูลไม่ถูกต้อง", propertyName)
            info.ErrorType = ErrorType.Critical
        End If


    End Sub


    Public Sub GetError(ByVal info As ErrorInfo) Implements IDXDataErrorInfo.GetError
        Dim propertyInfo As New ErrorInfo()
        GetPropertyError("AmountEnd", propertyInfo)
        If propertyInfo.ErrorText = "" Then
            GetPropertyError("AmountEnd", propertyInfo)
        End If
        If propertyInfo.ErrorText <> "" Then
            info.ErrorText = "พบข้อผิดพลาด"
        End If
    End Sub
#End Region
End Class
