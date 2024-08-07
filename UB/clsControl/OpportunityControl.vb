﻿Option Explicit On

Public Class OpportunityControl
    Implements iControl
    Private Const mCaption As String = "โอกาสทางการขาย"
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
                Call InitialFilterCon(mCtlForm.cboFindIn, FilterBy.OppName + FilterBy.Customer)  'Call Global function
                Call SetControlMenuPrivilege(mCtlForm, MasterType.Opportunity)
                .Show()
            End With

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try

    End Sub



    Private Sub LoadData()
        Dim lcls As New OpportunityDAO
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
            Err.Raise(Err.Number, e.Source, "OpportunityControl.LoadData : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Sub


    Private Sub GridStyle()
        With mCtlForm.GridView

            .Columns("ID").Visible = False
            .Columns("OppName").Caption = "ชื่อโอกาสทางการขาย"
            .Columns("OppName").Width = 300
            .Columns("Customer").Caption = "ลูกค้า"
            .Columns("Customer").Width = 250
            .Columns("OppStartDate").Caption = "วันที่เริ่มต้น"
            .Columns("OppStartDate").Width = 150
            .Columns("OppExpireDate").Caption = "วันที่สิ้นสุด"
            .Columns("OppExpireDate").Width = 150
            .Columns("EstimateRevenue").Caption = "ประมาณการรายได้"
            .Columns("EstimateRevenue").Width = 100
            .Columns("EstimateRevenue").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            .Columns("EstimateRevenue").DisplayFormat.FormatString = "n2"

            .Columns("ExpectRevenue").Caption = "รายได้คาดหวัง"
            .Columns("ExpectRevenue").Width = 100
            .Columns("ExpectRevenue").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            .Columns("ExpectRevenue").DisplayFormat.FormatString = "n2"

            .Columns("NameThai").Caption = "ช่วงโอกาส"
            .Columns("NameThai").Width = 150
            .Columns("IsClose").Caption = "Is Close"
            .Columns("IsClose").Width = 80
            .Columns("IsClose").Visible = False
            .Columns("CloseDate").Caption = "วันที่ปิดการขาย"
            .Columns("CloseDate").Width = 100
            .Columns("EMPNAME").Caption = "ผู้รับผิดชอบ"
            .Columns("EMPNAME").Width = 250
            .Columns("ModifiedTime").Caption = "แก้ไขล่าสุด"
            .Columns("ModifiedTime").Width = 200
            .Columns("ModifiedTime").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        End With
    End Sub


    Private Sub mCtlForm_AddNew() Handles mCtlForm.AddNew
        Try
            Call ShowForm(DataMode.ModeNew, 0)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "OpportunityControl.mCtlForm_AddNew : " & ex.Message)
        End Try
    End Sub

    Private Sub ShowForm(ByVal pMode As Integer, ByVal pID As Long)
        Dim lFormEdit As New frmOpportunity
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
        Dim lcls As New OpportunityDAO
        Dim lCurrent As Long
        Try
            lCurrent = lcls.CHECKSUM_AGG
            If mCHECKSUM_AGG <> lCurrent Then
                LoadData()
                mCHECKSUM_AGG = lCurrent
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "OpportunityControl.mCtlForm_CHeckRefresh : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    Private Sub mCtlForm_CreateQuick() Handles mCtlForm.CreateQuick

    End Sub

    Private Sub mCtlForm_Delete(ByRef pID As Long) Handles mCtlForm.Delete
        Dim lcls As New OpportunityDAO

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
            Err.Raise(Err.Number, ex.Source, "OpportunityControl.mCtlForm_Delete : " & ex.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    Private Sub mCtlForm_Edit(ByVal pID As Long) Handles mCtlForm.Edit
        Try
            Call ShowForm(DataMode.ModeEdit, pID)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "OpportunityControl.mCtlForm_Edit : " & ex.Message)
        End Try
    End Sub

    Private Sub mCtlForm_Import() Handles mCtlForm.Import
        frmImport.Show()
    End Sub

    Private Sub mCtlForm_InitDetail(ByVal pID As Long) Handles mCtlForm.InitDetail
        'Dim lclsLeadDAO As New LeadDAO

        'Try
        '    If lclsLeadDAO.InitailData(pID) Then

        '        mCtlForm.UcInfo1.Init(lclsLeadDAO.GetInfoHtml, Nothing)
        '    End If
        'Catch ex As Exception
        '    Err.Raise(Err.Number, ex.Source, "OpportunityControl.mCtlForm_InitDetail : " & ex.Message)
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
            Err.Raise(Err.Number, ex.Source, "OpportunityControl.mCtlForm_ReLoad : " & ex.Message)
        End Try
    End Sub

    Private Sub mCtlForm_ReLoad() Handles mCtlForm.ReLoad
        Try
            Call LoadData()
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "OpportunityControl.mCtlForm_ReLoad : " & ex.Message)
        End Try
    End Sub

End Class
