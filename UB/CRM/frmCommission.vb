
Option Explicit On

Imports DevExpress.XtraEditors

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
                    UcProductLists1.ClearControl()
                    UcProductLists2.ClearControl()
                    UcEmployee1.ClearControl()
                    UcCustomer1.ClearControl()
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

            mcls.Budget = Budget.EditValue
            mcls.MinimumAmount = MinimumAmount.EditValue
            mcls.MinimumUnit = MinimumUnit.EditValue
            mcls.CpTypeCont1 = CpTypeCont1.EditValue
            mcls.CpTypeCont2 = CpTypeCont2.EditValue
            mcls.CpTypeCont3_1 = CpTypeCont3_1.EditValue
            mcls.CpTypeCont3_2 = CpTypeCont3_2.EditValue
            mcls.CampaignType = CampaignType.EditValue
            mcls.EvaluateBy = EvaluateBy.EditValue
            mcls.EvaluateTarget = EvaluateTarget.EditValue
            mcls.CampaignStatus = CampaignStatus.EditValue
            mcls.StartDate = StartDate.EditValue
            mcls.ExpireDate = ExpireDate.EditValue
            mcls.Remark = Remark.Text.Trim
            mcls.IsInActive = UcAdmin1.CheckInAcive.Checked
            mcls.NoteDAOs = UcNote1.GetNoteDAOs
            mcls.FileAttachs = UcFileAttach1.GetFileAttachs
            mcls.ProductDAOs = UcProductLists1.GetDAOs(False, True, False, Nothing, False, 0, True, "", pMode, "")
            mcls.ProductAddDAOs = UcProductLists2.GetDAOs(False, True, False, Nothing, False, 0, True, "", pMode, "")
            mcls.EmployeeList = UcEmployee1.GetDAOs()
            mcls.CustomerList = UcCustomer1.GetDAOs()
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
                    Budget.EditValue = mcls.Budget
                    MinimumAmount.EditValue = mcls.MinimumAmount
                    MinimumUnit.EditValue = mcls.MinimumUnit
                    CpTypeCont1.EditValue = mcls.CpTypeCont1
                    CpTypeCont2.EditValue = mcls.CpTypeCont2
                    CpTypeCont3_1.EditValue = mcls.CpTypeCont3_1
                    CpTypeCont3_2.EditValue = mcls.CpTypeCont3_2
                    CampaignType.EditValue = mcls.CampaignType
                    'InitialCondition(mcls.CampaignType)
                    EvaluateBy.EditValue = mcls.EvaluateBy
                    EvaluateTarget.EditValue = mcls.EvaluateTarget
                    CampaignStatus.EditValue = mcls.CampaignStatus
                    StatusDesc.EditValue = mcls.StatusDesc
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
            UcProductLists1.ShowControl(pMode, lOrderList, mcls.TableName, ProColumn.Units + ProColumn.Price + ProColumn.UnitName + ProColumn.Total + ProColumn.Discount _
                                       , False, True, Nothing, True, mcls.TableName, False, mcls.IsDelete, "")
            UcProductLists2.ShowControl(pMode, lOrderList, mcls.TableName & "_ProAdd", ProColumn.Units + ProColumn.Price + ProColumn.UnitName + ProColumn.Total _
                                       , False, True, Nothing, True, mcls.TableName, False, mcls.IsDelete, "")
            UcEmployee1.ShowControl(mcls.ID, MasterType.Campaign, mcls.IsDelete)
            UcCustomer1.ShowControl(mcls.ID, MasterType.Campaign, mcls.IsDelete)
            UcCampaignDTL1.ShowControl(mCampaignDtlList)
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


            If DxErrorProvider1.HasErrors = False Then
                If UcProductLists1.IsError <> "" Then
                    XtraTabControl1.SelectedTabPage = ProductTabPage
                    Return False
                End If
            End If


            Return DxErrorProvider1.HasErrors = False
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".Verify : " & e.Message)
        End Try
    End Function



    'Private Sub InitialCondition(ByVal pCampaihnType As Integer)
    '    Try
    '        CpTypeCont1.Visible = False
    '        CpTypeCont2.Visible = False
    '        CpTypeCont3_1.Visible = False
    '        CpTypeCont3_2.Visible = False
    '        ProductAddTabPage.PageEnabled = False

    '        Select Case pCampaihnType
    '            Case 1 : CpTypeCont1.Visible = True
    '            Case 2 : CpTypeCont2.Visible = True
    '            Case 3
    '                CpTypeCont3_1.Visible = True
    '                CpTypeCont3_2.Visible = True
    '            Case 4
    '                ProductAddTabPage.PageEnabled = True
    '        End Select

    '    Catch e As Exception
    '        Err.Raise(Err.Number, e.Source, mFormName & ".InitialCondition : " & e.Message)
    '    End Try
    'End Sub

#End Region


End Class