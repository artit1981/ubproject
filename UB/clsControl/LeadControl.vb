Option Explicit On

Public Class LeadControl
    Implements iControl
    Private Const mCaption As String = "กลุ่มเป้าหมาย(Leads)"
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
                Call InitialFilterCon(mCtlForm.cboFindIn, FilterBy.Company + FilterBy.EmpName + FilterBy.Name + FilterBy.Subject)  'Call Global function
                Call SetControlMenuPrivilege(mCtlForm, MasterType.Lead)
                .Show()
            End With

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try

    End Sub



    Private Sub LoadData()
        Dim lcls As New CustomerDAO
        Dim dataTable As New DataTable()
        Try
            lcls.TableID = MasterType.Lead
            dataTable = lcls.GetDataTable(0, False)
            If dataTable.Rows.Count > 0 Then
                mCtlForm.GridControl.DataSource = dataTable
                mCtlForm.GridView.ViewCaption = mCaption
                Call GridStyle()
            Else
                mCtlForm.GridControl.DataSource = Nothing
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "LeadControl.LoadData : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Sub


    Private Sub GridStyle()
        With mCtlForm.GridView

            .Columns("ID").Width = 0
            .Columns("ID").Caption = "รหัส"
            .Columns("ID").Visible = False
            .Columns("Subject").Caption = "หัวเรื่อง"
            .Columns("Subject").Width = 300
            .Columns("NAME").Caption = "ชื่อ - นามสกุล"
            .Columns("NAME").Width = 250
            .Columns("CompanyName").Caption = "ชื่อบริษัท"
            .Columns("CompanyName").Width = 200
            .Columns("Rating").Caption = "ระดับความสนใจ"
            .Columns("Rating").Width = 100
            .Columns("LeadStatus").Caption = "สถานะ"
            .Columns("LeadStatus").Width = 100
            .Columns("Phone1").Caption = "โทรศัพท์"
            .Columns("Phone1").Width = 100
            .Columns("Fax").Caption = "โทรสาร"
            .Columns("Fax").Width = 100
            .Columns("Email1").Caption = "อีเมล์"
            .Columns("Email1").Width = 100
            .Columns("IsQuick").Caption = "Is Quick"
            .Columns("IsQuick").Width = 100
            .Columns("IsQuick").Visible = False
            .Columns("EMPNAME").Caption = "ผู้รับผิดชอบ"
            .Columns("EMPNAME").Width = 250
            .Columns("ModifiedTime").Caption = "แก้ไขล่าสุด"
            .Columns("ModifiedTime").Width = 200
            .Columns("ModifiedTime").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom

            .Columns("ParentCompany").Visible = False
        End With
    End Sub


    Private Sub mCtlForm_AddNew() Handles mCtlForm.AddNew
        Try
            Call ShowForm(DataMode.ModeNew, 0)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "LeadControl.mCtlForm_AddNew : " & ex.Message)
        End Try
    End Sub

    Private Sub ShowForm(ByVal pMode As Integer, ByVal pID As Long)
        Dim lFormEdit As frmLead
        Try
            lFormEdit = New frmLead
            With lFormEdit
                .Caption = mCaption
                .MdiParent = frmMain
                .ModeData = pMode
                .IDs = pID
                .Show()
            End With

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "LeadControl.ShowForm : " & ex.Message)
        End Try
    End Sub

    Private Sub Convert(ByVal pID As Long)
        Dim lfrmSelect As New frmConvertLead
        Dim lFormEdit As iEditForm
        Try

            With lfrmSelect
                .ShowDialog()
                ShowProgress(True, "Loading...")
                If lfrmSelect.IsSelectContact = 1 Then
                    lFormEdit = New frmContact
                    lFormEdit.Caption = "Contacts"
                    lFormEdit.MdiParent = frmMain
                    lFormEdit.ModeData = DataMode.ModeConvert
                    lFormEdit.IDs = pID
                    lFormEdit.Show()

                ElseIf lfrmSelect.IsSelectContact = 2 Then
                    lFormEdit = New frmAccount
                    lFormEdit.Caption = "Accounts"
                    lFormEdit.MdiParent = frmMain
                    lFormEdit.ModeData = DataMode.ModeConvert
                    lFormEdit.IDs = pID
                    lFormEdit.Show()
                End If
            End With
            ShowProgress(False, "")
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "LeadControl.ShowForm : " & ex.Message)
        Finally
            lfrmSelect = Nothing
        End Try
    End Sub

    Private Sub mCtlForm_CHeckRefresh() Handles mCtlForm.CHeckRefresh
        Dim lcls As New CustomerDAO
        Dim lCurrent As Long
        Try
            lcls.TableID = MasterType.Lead
            lCurrent = lcls.CHECKSUM_AGG
            If mCHECKSUM_AGG <> lCurrent Then
                LoadData()
                mCHECKSUM_AGG = lCurrent
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "LeadControl.mCtlForm_CHeckRefresh : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    Private Sub mCtlForm_Convert(ByVal pID As Long) Handles mCtlForm.Convert
        Try
            Call Convert(pID)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "LeadControl.mCtlForm_Copy : " & ex.Message)
        End Try
    End Sub

    Private Sub mCtlForm_Copy(ByVal pID As Long) Handles mCtlForm.Copy
        Try
            Call ShowForm(DataMode.ModeCopy, pID)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "LeadControl.mCtlForm_Copy : " & ex.Message)
        End Try
    End Sub

    Private Sub mCtlForm_CreateQuick() Handles mCtlForm.CreateQuick
        Dim lFormEdit As frmLeadQ

        Try
            lFormEdit = New frmLeadQ
            With lFormEdit
                .Text = mCaption
                .ShowDialog()
            End With

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "LeadControl.mCtlForm_CreateQuick : " & ex.Message)
        End Try
    End Sub



    Private Sub mCtlForm_Delete(ByRef pID As Long) Handles mCtlForm.Delete
        Dim lcls As New CustomerDAO

        Try
            lcls.TableID = MasterType.Lead
            If lcls.InitailData(pID) Then  ''ถูกใช้งานอยู่ ???
                If lcls.CheckIsToUse = False Then  ''ถูกใช้งานอยู่ ???
                    lcls.ID = pID
                    lcls.ModeData = DataMode.ModeDelete
                    If lcls.SaveData(Nothing) Then
                        Call LoadData()
                    End If
                Else
                    pID = 0
                End If
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "LeadControl.mCtlForm_Delete : " & ex.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    Private Sub mCtlForm_Edit(ByVal pID As Long) Handles mCtlForm.Edit
        Try
            Call ShowForm(DataMode.ModeEdit, pID)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "LeadControl.mCtlForm_Edit : " & ex.Message)
        End Try
    End Sub

    Private Sub mCtlForm_Import() Handles mCtlForm.Import
        frmImport.Show()
    End Sub

    Private Sub mCtlForm_InitDetail(ByVal pID As Long) Handles mCtlForm.InitDetail
        Dim lcls As New CustomerDAO
        Try
            lcls.TableID = MasterType.Lead
            If lcls.InitailData(pID) Then

                mCtlForm.UcInfo1.Init(lcls.GetInfoHtml, Nothing)
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "LeadControl.mCtlForm_InitDetail : " & ex.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    Private Sub mCtlForm_RefreshFind() Handles mCtlForm.RefreshFind
        Try
            Dim findText As String = mCtlForm.GridView.FindFilterText
            Dim lstrCon As String = InitialFilterMapping(mCtlForm.cboFindIn.SelectedItem)  'Call Global function
            mCtlForm.GridView.OptionsFind.FindFilterColumns = lstrCon
            mCtlForm.GridView.ApplyFindFilter(String.Empty)
            mCtlForm.GridView.ApplyFindFilter(findText)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "LeadControl.mCtlForm_ReLoad : " & ex.Message)
        End Try
    End Sub

    Private Sub mCtlForm_ReLoad() Handles mCtlForm.ReLoad
        Try
            Call LoadData()
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "LeadControl.mCtlForm_ReLoad : " & ex.Message)
        End Try
    End Sub

End Class
