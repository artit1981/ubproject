Option Explicit On


Public Class ContactControl
    Implements iControl
    Private Const mCaption As String = "Contacts"
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
                Call InitialFilterCon(mCtlForm.cboFindIn, FilterBy.Company + FilterBy.EmpName + FilterBy.Name + FilterBy.Code)  'Call Global function
                Call SetControlMenuPrivilege(mCtlForm, MasterType.Contacts)
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
            lcls.TableID = MasterType.Contacts
            dataTable = lcls.GetDataTable(0, False)
            If dataTable.Rows.Count > 0 Then
                mCtlForm.GridControl.DataSource = dataTable
                mCtlForm.GridView.ViewCaption = mCaption
                Call GridStyle()
            Else
                mCtlForm.GridControl.DataSource = Nothing
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ContactControl.LoadData : " & e.Message)
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
            .Columns("Code").Caption = "รหัสลูกค้า"
            .Columns("Code").Width = 300
            .Columns("NAME").Caption = "ชื่อ - นามสกุล"
            .Columns("NAME").Width = 250
            .Columns("CompanyName").Caption = "ชื่อบริษัท"
            .Columns("CompanyName").Width = 250
            .Columns("IsQuick").Caption = "Is Quick"
            .Columns("IsQuick").Width = 100
            .Columns("IsQuick").Visible = False
            .Columns("EMPNAME").Caption = "ผู้รับผิดชอบ"
            .Columns("EMPNAME").Width = 250
            .Columns("ModifiedTime").Caption = "แก้ไขล่าสุด"
            .Columns("ModifiedTime").Width = 150
            .Columns("ModifiedTime").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            .Columns("Phone1").Caption = "โทรศัพท์"
            .Columns("Phone1").Width = 100
            .Columns("Fax").Caption = "โทรสาร"
            .Columns("Fax").Width = 100
            .Columns("Email1").Caption = "อีเมล์"
            .Columns("Email1").Width = 100
        End With
    End Sub


    Private Sub mCtlForm_AddNew() Handles mCtlForm.AddNew
        Try
            Call ShowForm(DataMode.ModeNew, 0)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "ContactControl.mCtlForm_AddNew : " & ex.Message)
        End Try
    End Sub

    Private Sub mCtlForm_Copy(ByVal pID As Long) Handles mCtlForm.Copy
        Try
            Call ShowForm(DataMode.ModeCopy, pID)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "ContactControl.mCtlForm_Copy : " & ex.Message)
        End Try
    End Sub

    Private Sub ShowForm(ByVal pMode As Integer, ByVal pID As Long)
        Dim lFormEdit As frmContact
        Try
            lFormEdit = New frmContact
            With lFormEdit
                .Caption = mCaption
                .MdiParent = frmMain
                .ModeData = pMode
                .IDs = pID
                .Show()
            End With

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "ContactControl.ShowForm : " & ex.Message)
        End Try
    End Sub

    Private Sub mCtlForm_CHeckRefresh() Handles mCtlForm.CHeckRefresh
        Dim lcls As New CustomerDAO
        Dim lCurrent As Long
        Try
            lcls.TableID = MasterType.Contacts
            lCurrent = lcls.CHECKSUM_AGG
            If mCHECKSUM_AGG <> lCurrent Then
                LoadData()
                mCHECKSUM_AGG = lCurrent
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ContactControl.mCtlForm_CHeckRefresh : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    Private Sub mCtlForm_Delete(ByRef pID As Long) Handles mCtlForm.Delete
        Dim lcls As New CustomerDAO

        Try
            lcls.TableID = MasterType.Contacts
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
            Err.Raise(Err.Number, ex.Source, "ContactControl.mCtlForm_Delete : " & ex.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    Private Sub mCtlForm_Edit(ByVal pID As Long) Handles mCtlForm.Edit
        Try
            Call ShowForm(DataMode.ModeEdit, pID)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "ContactControl.mCtlForm_Edit : " & ex.Message)
        End Try
    End Sub

    Private Sub mCtlForm_InitDetail(ByVal pID As Long) Handles mCtlForm.InitDetail
        Dim lcls As New CustomerDAO

        Try
            lcls.TableID = MasterType.Contacts
            If lcls.InitailData(pID) Then
                mCtlForm.UcInfo1.Init(lcls.GetInfoHtml, Nothing)
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "ContactControl.mCtlForm_InitDetail : " & ex.Message)
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
            Err.Raise(Err.Number, ex.Source, "ContactControl.mCtlForm_RefreshFind : " & ex.Message)
        End Try
    End Sub

    Private Sub mCtlForm_ReLoad() Handles mCtlForm.ReLoad
        Try
            Call LoadData()
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "ContactControl.mCtlForm_ReLoad : " & ex.Message)
        End Try
    End Sub

    Private Sub mCtlForm_Import() Handles mCtlForm.Import
        frmImport.MasterTypes = MasterType.Contacts
        frmImport.Show()
    End Sub
End Class
