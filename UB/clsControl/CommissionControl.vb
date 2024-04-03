Option Explicit On

Public Class CommissionControl
    Implements iControl
    Private Const mCaption As String = "คอมมิชชั่น"
    Private WithEvents mCtlForm As frmControlCommission
    Private mCHECKSUM_AGG As Long
    Private bindingSource1 As BindingSource

    Public Sub Execute(ByVal pOrderType As Integer) Implements iControl.Execute
        Try
            mCtlForm = New frmControlCommission
            With mCtlForm
                .Text = mCaption
                .MdiParent = frmMain
                Call LoadData()
                Call SetControlMenuPrivilege(mCtlForm, MasterType.Commission)
                .Show()
            End With

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try

    End Sub

    Private Sub SetControlMenuPrivilege(ByVal pfrmControl As frmControlCommission, ByVal pMenuId As Long)
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
            Err.Raise(Err.Number, ex.Source, "CommissionControl.SetControlMenuPrivilege : " & ex.Message)
        Finally
            lcls = Nothing
            lclsPrivilege = Nothing
        End Try
    End Sub



    Private Sub LoadData()
        Dim lcls As New CommissionDAO
        Dim dataTable As New DataTable()
        Dim lIsActiveOnly As Boolean = True
        Try

            'If mCtlForm.chkShowDelete.Checked = True Then
            '    lIsActiveOnly = False
            'Else
            lIsActiveOnly = True
            'End If

            dataTable = lcls.GetDataTable(0, lIsActiveOnly)

            If dataTable.Rows.Count > 0 Then
                mCtlForm.GridControl.DataSource = dataTable
                mCtlForm.GridView.ViewCaption = mCaption
                Call GridStyle()
            Else
                mCtlForm.GridControl.DataSource = Nothing
            End If


        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "CommissionControl.LoadData : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Sub

    Private Sub GridStyle()
        With mCtlForm.GridView
            'CommissionID,Subject, StartDate, ExpireDate,IsDelete
            .Columns("CommissionID").Visible = False
            .Columns("IsDelete").Visible = False

            .Columns("Subject").Caption = "ชื่อคอมมิชชั่น"
            .Columns("Subject").Width = 300
            .Columns("Subject").MaxWidth = 0

            .Columns("StartDate").Caption = "วันเริ่มต้น"
            .Columns("StartDate").Width = 200
            .Columns("StartDate").MaxWidth = 250

            .Columns("ExpireDate").Caption = "วันสิ้นสุด"
            .Columns("ExpireDate").Width = 150
            .Columns("ExpireDate").MaxWidth = 200

            '.Columns("ModifiedTime").Caption = "แก้ไขล่าสุด"
            '.Columns("ModifiedTime").Width = 150
            '.Columns("ModifiedTime").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom

        End With
    End Sub

    Private Sub mCtlForm_AddNew() Handles mCtlForm.AddNew
        Try
            Call ShowForm(DataMode.ModeNew, 0, 0)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "CommissionControl.mCtlForm_AddNew : " & ex.Message)
        End Try
    End Sub

    Private Sub ShowForm(ByVal pMode As Integer, ByVal pID As Long, ByVal pIndex As Long)
        Dim lFormEdit As New frmCommission
        Try

            With lFormEdit
                .Caption = mCaption
                .MdiParent = frmMain
                .ModeData = pMode
                .IDs = pID
                .Show()
            End With

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "CommissionControl.ShowForm : " & ex.Message)
        End Try
    End Sub

    Private Sub mCtlForm_CHeckRefresh() Handles mCtlForm.CHeckRefresh
        Dim lcls As New CommissionDAO
        Dim lCurrent As Long
        Try
            lCurrent = lcls.CHECKSUM_AGG
            If mCHECKSUM_AGG <> lCurrent Then
                LoadData()
                mCHECKSUM_AGG = lCurrent
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "CommissionControl.mCtlForm_CHeckRefresh : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    Private Sub mCtlForm_Delete(ByRef pID As Long) Handles mCtlForm.Delete
        Dim lcls As New CommissionDAO

        Try
            If lcls.InitailData(pID) Then  ''ถูกใช้งานอยู่ ???
                lcls.ID = pID
                lcls.ModeData = DataMode.ModeDelete
                If lcls.SaveData() Then
                    Call LoadData()
                End If
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "CommissionControl.mCtlForm_Delete : " & ex.Message)
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
            Err.Raise(Err.Number, ex.Source, "CommissionControl.mCtlForm_Edit : " & ex.Message)
        End Try
    End Sub

    Private Sub mCtlForm_InitStatus(pIsDelete As Integer) Handles mCtlForm.InitStatus
        mCtlForm.DeleteBar.Enabled = (pIsDelete = 0)
    End Sub

    Private Sub mCtlForm_ReLoad() Handles mCtlForm.ReLoad
        Try
            Call LoadData()
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "CommissionControl.mCtlForm_ReLoad : " & ex.Message)
        End Try
    End Sub

End Class
