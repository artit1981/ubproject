Option Explicit On
Imports DevExpress.XtraEditors

Public Class CampaignControl
    Implements iControl
    Private Const mCaption As String = "โปรโมชั่น"
    Private WithEvents mCtlForm As frmControlCampaign
    Private mCHECKSUM_AGG As Long
    Private bindingSource1 As BindingSource

    Public Sub Execute(ByVal pOrderType As Integer) Implements iControl.Execute
        Try
            mCtlForm = New frmControlCampaign
            With mCtlForm
                .Text = mCaption
                .MdiParent = frmMain
                Call LoadData()
                Call SetControlMenuPrivilege(mCtlForm, MasterType.Campaign)
                .Show()
            End With

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try

    End Sub

    Private Sub SetControlMenuPrivilege(ByVal pfrmControl As frmControlCampaign, ByVal pMenuId As Long)
        Dim lcls As New MenuADO
        Dim lclsPrivilege As New PrivilegeDAO
        Try
            If lclsPrivilege.InitailData(gPrivilegeID, pMenuId) Then
                pfrmControl.AddBar.Enabled = (lclsPrivilege.PrivilegeData And Privilege.Add) = Privilege.Add
                pfrmControl.EditBar.Enabled = (lclsPrivilege.PrivilegeData And Privilege.Edit) = Privilege.Edit
                pfrmControl.DeleteBar.Enabled = (lclsPrivilege.PrivilegeData And Privilege.Delete) = Privilege.Delete
                pfrmControl.ImportBar.Enabled = (lclsPrivilege.PrivilegeData And Privilege.Import) = Privilege.Import
                pfrmControl.QuickBar.Enabled = (lclsPrivilege.PrivilegeData And Privilege.Quick) = Privilege.Quick
                pfrmControl.CopyBar.Enabled = (lclsPrivilege.PrivilegeData And Privilege.Copy) = Privilege.Copy
                pfrmControl.AssignBar.Enabled = (lclsPrivilege.PrivilegeData And Privilege.Assign) = Privilege.Assign
                pfrmControl.ConvertBar.Enabled = (lclsPrivilege.PrivilegeData And Privilege.Convert) = Privilege.Convert

            End If

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "CampaignControl.SetControlMenuPrivilege : " & ex.Message)
        Finally
            lcls = Nothing
            lclsPrivilege = Nothing
        End Try
    End Sub



    Private Sub LoadData()
        Dim lcls As New CampaignDAO
        Dim dataTable As New DataTable()
        Dim lclsCampaignSub As CampaignSub
        Dim lAcitivityAmount As Decimal
        Dim lIsActiveOnly As Boolean = True
        Try

            If mCtlForm.chkShowDelete.Checked = True Then
                lIsActiveOnly = False
            Else
                lIsActiveOnly = True
            End If
            bindingSource1 = Nothing
            bindingSource1 = New BindingSource
            bindingSource1.DataSource = GetType(CampaignSub)
            dataTable = lcls.GetDataTable(0, lIsActiveOnly)

            If dataTable.Rows.Count > 0 Then
                For Each pRow In dataTable.Rows
                    lAcitivityAmount = 0
                    lclsCampaignSub = New CampaignSub
                    lclsCampaignSub.CampaignID = ConvertNullToZero(pRow("CampaignID"))
                    lclsCampaignSub.Subject = ConvertNullToString(pRow("Subject"))
                    lclsCampaignSub.StartDate = pRow("StartDate")
                    lclsCampaignSub.ExpireDate = pRow("ExpireDate")
                    lclsCampaignSub.Budget = ConvertNullToZero(pRow("Budget"))
                    lclsCampaignSub.EvaluateTarget = ConvertNullToZero(pRow("EvaluateTarget"))
                    lclsCampaignSub.EvaluateBy = ConvertNullToString(pRow("EvaluateBy"))
                    lclsCampaignSub.CampaignStatus = ConvertNullToString(pRow("CampaignStatus"))
                    lclsCampaignSub.IsDelete = ConvertNullToZero(pRow("IsDelete"))
                    lclsCampaignSub.CampaignDTL = LoadDataDetail(lclsCampaignSub.CampaignID, lclsCampaignSub.EvaluateBy, lAcitivityAmount)
                    lclsCampaignSub.Activity = lAcitivityAmount
                    bindingSource1.Add(lclsCampaignSub)
                Next

                mCtlForm.GridControl.DataSource = bindingSource1
                mCtlForm.GridView.ViewCaption = mCaption
            Else
                mCtlForm.GridControl.DataSource = Nothing
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "CampaignControl.LoadData : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Sub


    Private Function LoadDataDetail(ByVal pCampaignID As Long, ByVal pEvaluateBy As String, ByRef pAcitivityAmount As Decimal) As List(Of CampaignDetail)
        Dim lcls As New OrderSDAO
        Dim dataTable As New DataTable()
        Dim lclsList As New List(Of CampaignDetail), lclsDtl As CampaignDetail
        Dim lCusIDList As New List(Of Long), lCusID As Long = 0

        Try
            pAcitivityAmount = 0
            dataTable = lcls.GetDataTableForCampaign(pCampaignID)

            If dataTable.Rows.Count > 0 Then
                For Each pRow In dataTable.Rows
                    lclsDtl = New CampaignDetail
                    lclsDtl.OrderID = ConvertNullToZero(pRow("OrderID"))
                    lclsDtl.OrderCode = ConvertNullToString(pRow("OrderCode"))
                    lclsDtl.CustomerName = ConvertNullToString(pRow("Customer"))
                    lclsDtl.TotalAmount = ConvertNullToZero(pRow("TotalAmount"))
                    lclsDtl.TotalGain = ConvertNullToZero(pRow("TotalGain"))
                    lclsDtl.ProductName = ConvertNullToString(pRow("ProductName"))
                    lCusID = ConvertNullToZero(pRow("CustomerID"))
                    If pEvaluateBy.Trim = "ยอดขาย" Then
                        pAcitivityAmount = pAcitivityAmount + lclsDtl.TotalAmount
                    Else
                        pAcitivityAmount = pAcitivityAmount + lclsDtl.TotalGain
                    End If

                    Select Case pEvaluateBy.Trim
                        Case "จำนวนลูกค้า"
                            If lCusIDList.Exists(Function(x) x = lCusID) = False Then
                                pAcitivityAmount = pAcitivityAmount + 1
                                lCusIDList.Add(lCusID)
                            End If
                        Case "ยอดขาย"
                            pAcitivityAmount = pAcitivityAmount + lclsDtl.TotalAmount
                        Case Else
                            pAcitivityAmount = pAcitivityAmount + lclsDtl.TotalGain
                    End Select
                    lclsList.Add(lclsDtl)
                Next
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "CampaignControl.LoadDataDetail : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
        Return lclsList
    End Function


    Private Sub mCtlForm_AddNew() Handles mCtlForm.AddNew
        Try
            Call ShowForm(DataMode.ModeNew, 0, 0)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "CampaignControl.mCtlForm_AddNew : " & ex.Message)
        End Try
    End Sub

    Private Sub ShowForm(ByVal pMode As Integer, ByVal pID As Long, ByVal pIndex As Long)
        Dim lFormEdit As New frmCampaign
        Try
            Dim rec As CampaignSub = TryCast(bindingSource1.Item(pIndex), CampaignSub)

            With lFormEdit
                .Caption = mCaption
                .MdiParent = frmMain
                .ModeData = pMode
                .CampaignDtlList = rec.CampaignDTL
                .IDs = pID
                .Show()
            End With

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "OpportunityControl.ShowForm : " & ex.Message)
        End Try
    End Sub

    Private Sub mCtlForm_CHeckRefresh() Handles mCtlForm.CHeckRefresh
        Dim lcls As New CampaignDAO
        Dim lCurrent As Long
        Try
            lCurrent = lcls.CHECKSUM_AGG
            If mCHECKSUM_AGG <> lCurrent Then
                LoadData()
                mCHECKSUM_AGG = lCurrent
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "CampaignControl.mCtlForm_CHeckRefresh : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    Private Sub mCtlForm_Delete(ByRef pID As Long) Handles mCtlForm.Delete
        Dim lcls As New CampaignDAO

        Try
            If lcls.InitailData(pID) Then  ''ถูกใช้งานอยู่ ???
                If lcls.CheckIsToUse = False Then  ''ถูกใช้งานอยู่ ???
                    lcls.ID = pID
                    lcls.ModeData = DataMode.ModeDelete
                    If lcls.SaveData() Then
                        Call LoadData()
                    End If
                Else
                    pID = 0
                End If
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "CampaignControl.mCtlForm_Delete : " & ex.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    'Private Sub mCtlForm_Detail(pIndex As Long) Handles mCtlForm.Detail

    'End Sub
     

    Private Sub mCtlForm_Edit(ByVal pID As Long, ByVal pIndex As Long) Handles mCtlForm.Edit
        Try
            Call ShowForm(DataMode.ModeEdit, pID, pIndex)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "CampaignControl.mCtlForm_Edit : " & ex.Message)
        End Try
    End Sub

    Private Sub mCtlForm_InitStatus(pIsDelete As Integer) Handles mCtlForm.InitStatus
        mCtlForm.DeleteBar.Enabled = (pIsDelete = 0)
    End Sub
 
    Private Sub mCtlForm_ReLoad() Handles mCtlForm.ReLoad
        Try
            Call LoadData()
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "CampaignControl.mCtlForm_ReLoad : " & ex.Message)
        End Try
    End Sub

End Class
