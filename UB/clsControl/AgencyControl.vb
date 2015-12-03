Option Explicit On
Imports DevExpress.XtraEditors
 
Public Class AgencyControl
    Implements iControl
    Private Const mCaption As String = "เจ้าหนี้"

    Public Sub Execute(ByVal pOrderType As Integer) Implements iControl.Execute
        Try
            mCtlForm = New frmControls
            With mCtlForm
                .Text = mCaption
                .MdiParent = frmMain
                .OptionBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                Call LoadData()
                Call InitialFilterCon(mCtlForm.cboFindIn, FilterBy.Company + FilterBy.EmpName + FilterBy.Rate + FilterBy.Code) 'Call Global function
                Call SetControlMenuPrivilege(mCtlForm, MasterType.Agency)
                .Show()
            End With

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try

    End Sub
    Private WithEvents mCtlForm As frmControls
    Private mCHECKSUM_AGG As Long


    Private Sub LoadData()
        Dim lcls As New CustomerDAO
        Dim dataTable As New DataTable()

        Try
            lcls.TableID = MasterType.Agency
            dataTable = lcls.GetDataTable(0, False)

            If dataTable.Rows.Count > 0 Then
                mCtlForm.GridControl.DataSource = dataTable
                mCtlForm.GridView.ViewCaption = mCaption
                Call GridStyle()
            Else
                mCtlForm.GridControl.DataSource = Nothing
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "AgencyControl.LoadData : " & e.Message)
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
            .Columns("Code").Caption = "รหัส"
            .Columns("Code").Width = 300
            .Columns("CompanyName").Caption = "ชื่อบริษัท"
            .Columns("CompanyName").Width = 250
            .Columns("Rating").Caption = "ระดับความสนใจ"
            .Columns("Rating").Width = 100

            .Columns("ContactPerson").Caption = "ผู้ติดต่อ"
            .Columns("ContactPerson").Width = 250
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


    Private Sub ShowForm(ByVal pMode As Integer, ByVal pID As Long)
        Dim lFormEdit As frmAgency
        Try
            lFormEdit = New frmAgency
            With lFormEdit
                .Caption = mCaption
                .MdiParent = frmMain
                .ModeData = pMode
                .IDs = pID
                .Show()
            End With

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "AgencyControl.ShowForm : " & ex.Message)
        End Try
    End Sub

    Private Sub mCtlForm_AddNew() Handles mCtlForm.AddNew
        Try
            Call ShowForm(DataMode.ModeNew, 0)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "AgencyControl.mCtlForm_AddNew : " & ex.Message)
        End Try
    End Sub


    Private Sub mCtlForm_CHeckRefresh() Handles mCtlForm.CHeckRefresh
        Dim lcls As New CustomerDAO
        Dim lCurrent As Long
        Try
            lcls.TableID = MasterType.Agency
            lCurrent = lcls.CHECKSUM_AGG
            If mCHECKSUM_AGG <> lCurrent Then
                LoadData()
                mCHECKSUM_AGG = lCurrent
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "AgencyControl.mCtlForm_CHeckRefresh : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub



    Private Sub mCtlForm_Copy(ByVal pID As Long) Handles mCtlForm.Copy
        Try
            Call ShowForm(DataMode.ModeCopy, pID)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "AgencyControl.mCtlForm_Copy : " & ex.Message)
        End Try
    End Sub

    Private Sub mCtlForm_CreateQuick() Handles mCtlForm.CreateQuick
        'Dim lFormEdit As frmAccount

        'Try
        '    lFormEdit = New frmAccount
        '    With lFormEdit
        '        .Caption = mCaption
        '        .MdiParent = frmMain
        '        .ModeData = pMode
        '        .IDs = pID
        '        .Show()
        '    End With

        'Catch ex As Exception
        '    Err.Raise(Err.Number, ex.Source, "AgencyControl.ShowForm : " & ex.Message)
        'End Try
    End Sub

    Private Sub mCtlForm_Delete(ByRef pID As Long) Handles mCtlForm.Delete
        Dim lcls As New CustomerDAO

        Try
            lcls.TableID = MasterType.Agency
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
            Err.Raise(Err.Number, ex.Source, "AgencyControl.mCtlForm_Delete : " & ex.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    Private Sub mCtlForm_Edit(ByVal pID As Long) Handles mCtlForm.Edit
        Try
            Call ShowForm(DataMode.ModeEdit, pID)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "AgencyControl.mCtlForm_Edit : " & ex.Message)
        End Try
    End Sub

    Private Sub mCtlForm_Import() Handles mCtlForm.Import
        frmImport.MasterTypes = MasterType.Agency
        frmImport.Show()
    End Sub

    Private Sub mCtlForm_InitDetail(ByVal pID As Long) Handles mCtlForm.InitDetail
        Dim lcls As New CustomerDAO

        Try
            lcls.TableID = MasterType.Agency
            If lcls.InitailData(pID) Then

                mCtlForm.UcInfo1.Init(lcls.GetInfoHtml, Nothing)
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "AgencyControl.mCtlForm_InitDetail : " & ex.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    Private Sub mCtlForm_MouseCaptureChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles mCtlForm.MouseCaptureChanged

    End Sub

    Private Sub mCtlForm_RefreshFind() Handles mCtlForm.RefreshFind
        Try
            Dim findText As String = mCtlForm.GridView.FindFilterText
            Dim lstrCon As String = InitialFilterMapping(mCtlForm.cboFindIn.SelectedItem)  'Call Global function
            mCtlForm.GridView.OptionsFind.FindFilterColumns = lstrCon
            mCtlForm.GridView.ApplyFindFilter(String.Empty)
            mCtlForm.GridView.ApplyFindFilter(findText)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "AgencyControl.mCtlForm_RefreshFind : " & ex.Message)
        End Try
    End Sub

    Private Sub mCtlForm_ReLoad() Handles mCtlForm.ReLoad
        Try
            Call LoadData()
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "AgencyControl.mCtlForm_ReLoad : " & ex.Message)
        End Try
    End Sub
End Class
