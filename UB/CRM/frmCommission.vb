
Option Explicit On

Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class frmCommission
    Inherits iEditForm
    Private Const mFormName As String = "frmCommission"
    Dim mcls As New CampaignDAO
    Dim mCampaignDtlList As List(Of CampaignDetail)

    Public Property CampaignDtlList() As List(Of CampaignDetail)
        Get
            Return mCampaignDtlList
        End Get
        Set(ByVal value As List(Of CampaignDetail))
            mCampaignDtlList = value
        End Set
    End Property


#Region "Overrides"
    Protected Overrides Sub OnLoadForm(ByVal pMode As Integer, ByVal pID As Long, ByVal pOrderType As Long, ByVal pclsConvert As iOrder, ByVal pCusID As Long)
        Try

            Call LoadData(pMode, pID)

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".OnLoadForm : " & e.Message)
        End Try
    End Sub

    Protected Overrides Sub ClearAllForm(ByVal pMode As Integer)
        Try
            MyBase.ClearAllForm(pMode)
            Select Case pMode
                Case DataMode.ModeNew
                    ClearForm(GeneralTabPage)

                    ClearForm(UcAdmin1)
                    UcFileAttach1.ClearControl()

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


            mcls.CampaignStatus = CampaignStatus.EditValue
            mcls.StartDate = StartDate.EditValue
            mcls.ExpireDate = ExpireDate.EditValue
            mcls.Remark = Remark.Text.Trim
            mcls.IsInActive = UcAdmin1.CheckInAcive.Checked
            mcls.NoteDAOs = UcNote1.GetNoteDAOs
            mcls.FileAttachs = UcFileAttach1.GetFileAttachs
            If Verify() = True Then
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

    'Private Sub CampaignType_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles CampaignType.SelectedIndexChanged
    '    InitialCondition(CampaignType.EditValue)
    'End Sub


#End Region

#Region "Private"


    Private Function LoadData(ByVal pMode As Integer, ByVal pID As Long) As Boolean

        Try
            If pMode = DataMode.ModeNew Then

            ElseIf pMode = DataMode.ModeEdit Then
                If mcls.InitailData(pID) Then
                    Subject.Text = mcls.Subject

                    CampaignStatus.EditValue = mcls.CampaignStatus
                    StartDate.EditValue = mcls.StartDate
                    ExpireDate.EditValue = mcls.ExpireDate

                    Remark.EditValue = mcls.Remark

                    UcAdmin1.CheckInAcive.Checked = mcls.IsInActive
                    UcAdmin1.txtCreateBy.Text = mcls.CreateBy.Trim
                    UcAdmin1.txtCreateTime.Text = mcls.CreateTime
                    UcAdmin1.txtModifiBy.Text = mcls.ModifiedBy.Trim
                    UcAdmin1.txtModifiTime.Text = mcls.ModifiedTime

                    ''FileAttachs
                    UcFileAttach1.ShowControl(mcls.FileAttachs)
                End If
            End If

            'Note
            UcNote1.ShowControl(mcls.TableName, pID)

            Dim lOrderList As New List(Of Long)
            lOrderList.Add(mcls.ID)

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".LoadData : " & ex.Message)
            Return False
        Finally

        End Try
    End Function





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
        'If propertyName = "RecordDate" AndAlso IsDate(RecordDate) = False Then
        '    info.ErrorText = String.Format("กรุณาวันที่", propertyName)
        '    info.ErrorType = ErrorType.Critical
        'End If
        'If propertyName = "BankAccountID" AndAlso ConvertNullToZero(BankAccountID) <= 0 Then
        '    info.ErrorText = String.Format("กรุณาระบุบัญชี", propertyName)
        '    info.ErrorType = ErrorType.Critical
        'End If

    End Sub


    Public Sub GetError(ByVal info As ErrorInfo) Implements IDXDataErrorInfo.GetError
        Dim propertyInfo As New ErrorInfo()
        'GetPropertyError("RecordDate", propertyInfo)
        'If propertyInfo.ErrorText = "" Then
        '    GetPropertyError("BankAccountID", propertyInfo)
        'End If
        'If propertyInfo.ErrorText <> "" Then
        '    info.ErrorText = "พบข้อผิดพลาด"
        'End If
    End Sub
#End Region
End Class
