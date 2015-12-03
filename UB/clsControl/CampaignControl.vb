Option Explicit On
Imports DevExpress.XtraEditors

Public Class CampaignControl
    Implements iControl
    Private Const mCaption As String = "โปรโมชั่น"
    Private WithEvents mCtlForm As frmControls
    Private mCHECKSUM_AGG As Long

    Public Sub Execute(ByVal pOrderType As Integer) Implements iControl.Execute
        Try
            mCtlForm = New frmControls
            With mCtlForm
                .Text = mCaption
                .MdiParent = frmMain
                .OptionBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                Call LoadData()
                Call InitialFilterCon(mCtlForm.cboFindIn, FilterBy.Subject)  'Call Global function
                Call SetControlMenuPrivilege(mCtlForm, MasterType.Campaign)
                .Show()
            End With

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try

    End Sub



    Private Sub LoadData()
        Dim lcls As New CampaignDAO
        Dim dataTable As New DataTable()

        Try
            dataTable = lcls.GetDataTable(0, False)

            If dataTable.Rows.Count > 0 Then
                mCtlForm.GridControl.DataSource = dataTable
                mCtlForm.GridView.ViewCaption = mCaption
                Call GridStyle()
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


    Private Sub GridStyle()
        With mCtlForm.GridView

            .Columns("ID").Visible = False
            .Columns("Subject").Caption = "ชื่อโปรโมชั่น/ Campaign"
            .Columns("Subject").Width = 300
            .Columns("StartDate").Caption = "วันที่เริ่มต้น"
            .Columns("StartDate").Width = 80
            .Columns("ExpireDate").Caption = "วันที่สิ้นสุด"
            .Columns("ExpireDate").Width = 80
            '.Columns("Budget").Caption = "งบประมาณ"
            '.Columns("Budget").Width = 100
            '.Columns("Budget").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            '.Columns("Budget").DisplayFormat.FormatString = "n2"
            '.Columns("MinimumAmount").Caption = "ยอดซื้อขั้นต่ำ"
            '.Columns("MinimumAmount").Width = 100
            '.Columns("MinimumAmount").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            '.Columns("MinimumAmount").DisplayFormat.FormatString = "n2"
            .Columns("CampaignStatus").Caption = "สถานะ"
            .Columns("CampaignStatus").Width = 80
            .Columns("Remark").Caption = "รายละเอียด"
            '.Columns("CloseDate").Width = 100
            .Columns("ModifiedTime").Caption = "แก้ไขล่าสุด"
            .Columns("ModifiedTime").Width = 100
            .Columns("ModifiedTime").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        End With
    End Sub


    Private Sub mCtlForm_AddNew() Handles mCtlForm.AddNew
        Try
            Call ShowForm(DataMode.ModeNew, 0)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "CampaignControl.mCtlForm_AddNew : " & ex.Message)
        End Try
    End Sub

    Private Sub ShowForm(ByVal pMode As Integer, ByVal pID As Long)
        Dim lFormEdit As New frmCampaign
        Try
            With lFormEdit
                .Caption = mCaption
                .MdiParent = frmMain
                .ModeData = pMode
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

    Private Sub mCtlForm_CreateQuick() Handles mCtlForm.CreateQuick

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

    Private Sub mCtlForm_Edit(ByVal pID As Long) Handles mCtlForm.Edit
        Try
            Call ShowForm(DataMode.ModeEdit, pID)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "CampaignControl.mCtlForm_Edit : " & ex.Message)
        End Try
    End Sub
 

    Private Sub mCtlForm_InitDetail(ByVal pID As Long) Handles mCtlForm.InitDetail
        'Dim lclsLeadDAO As New LeadDAO

        'Try
        '    If lclsLeadDAO.InitailData(pID) Then

        '        mCtlForm.UcInfo1.Init(lclsLeadDAO.GetInfoHtml, Nothing)
        '    End If
        'Catch ex As Exception
        '    Err.Raise(Err.Number, ex.Source, "CampaignControl.mCtlForm_InitDetail : " & ex.Message)
        'Finally
        '    lclsLeadDAO = Nothing
        'End Try
    End Sub

    Private Sub mCtlForm_RefreshFind() Handles mCtlForm.RefreshFind
        Try
            Dim findText As String = mCtlForm.GridView.FindFilterText
            Dim lstrCon As String = InitialFilterMapping(mCtlForm.cboFindIn.SelectedItem)  'Call Global function
            mCtlForm.GridView.OptionsFind.FindFilterColumns = lstrCon
            mCtlForm.GridView.ApplyFindFilter(String.Empty)
            mCtlForm.GridView.ApplyFindFilter(findText)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "CampaignControl.mCtlForm_ReLoad : " & ex.Message)
        End Try
    End Sub

    Private Sub mCtlForm_ReLoad() Handles mCtlForm.ReLoad
        Try
            Call LoadData()
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "CampaignControl.mCtlForm_ReLoad : " & ex.Message)
        End Try
    End Sub

End Class
