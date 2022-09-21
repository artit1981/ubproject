Public Class CompanyControl
    Implements iControl
    Private Const mCaption As String = "บริษัท"

    Public Sub Execute(ByVal pOrderType As Integer) Implements iControl.Execute
        Try
            mCtlForm = New frmControls
            With mCtlForm
                .Text = Caption
                .MdiParent = frmMain
                .OptionBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Call LoadData()
                Call InitialFilterCon(mCtlForm.cboFindIn, FilterBy.Company)  'Call Global function

                .Show()
            End With

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try
    End Sub

    Private WithEvents mCtlForm As frmControls
    Private mCHECKSUM_AGG As Long

    Private ReadOnly Property ClassName() As String
        Get
            Return "CompanyControl"
        End Get
    End Property

    Private ReadOnly Property Caption() As String
        Get
            Return mCaption
        End Get

    End Property



    Private Sub LoadData()
        Dim lcls As New CompanyDAO
        Dim dataTable As New DataTable()

        Try
            dataTable = lcls.GetDataTable(0, False)

            If dataTable.Rows.Count > 0 Then
                mCtlForm.GridControl.DataSource = dataTable
                mCtlForm.GridView.ViewCaption = Caption
                Call GridStyle()
            Else
                mCtlForm.GridControl.DataSource = Nothing
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, ClassName & ".LoadData : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Sub

    Private Sub GridStyle()
        With mCtlForm.GridView

            .Columns("ID").Width = 0
            .Columns("ID").Caption = ""
            .Columns("ID").Visible = False

            .Columns("CompanyName").Caption = "ชื่อบริษัท"
            .Columns("CompanyName").Width = 400

            .Columns("Branch").Caption = "ชื่อสาขา"
            .Columns("Branch").Width = 300

            .Columns("ModifiedTime").Caption = "แก้ไขล่าสุด"
            .Columns("ModifiedTime").Width = 150
            .Columns("ModifiedTime").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom

        End With
    End Sub


    Private Sub mCtlForm_AddNew() Handles mCtlForm.AddNew
        Try
            Call ShowForm(DataMode.ModeNew, 0)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, ClassName & ".mCtlForm_AddNew : " & ex.Message)
        End Try
    End Sub

    Private Sub ShowForm(ByVal pMode As Integer, ByVal pID As Long)
        Dim lFormEdit As frmCompany
        Try

            lFormEdit = New frmCompany
            With lFormEdit
                .Caption = mCaption
                .MdiParent = frmMain
                .ModeData = pMode
                .IDs = pID
                .Show()
            End With

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, ClassName & ".ShowForm : " & ex.Message)
        End Try
    End Sub

    Private Sub mCtlForm_CHeckRefresh() Handles mCtlForm.CHeckRefresh
        Dim lcls As New CompanyDAO
        Dim lCurrent As Long
        Try
            lCurrent = lcls.CHECKSUM_AGG
            If mCHECKSUM_AGG <> lCurrent Then
                LoadData()
                mCHECKSUM_AGG = lCurrent
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, ClassName & ".mCtlForm_CHeckRefresh : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    Private Sub mCtlForm_Delete(ByRef pID As Long) Handles mCtlForm.Delete
        Dim lcls As New CompanyDAO

        Try
            If lcls.InitailData(pID) Then
                If lcls.CheckIsToUse = False Then  ''ถูกใช้งานอยู่ ???
                    lcls.ID = pID
                    lcls.ModeData = DataMode.ModeDelete
                    If lcls.InitailData(pID) Then
                        If lcls.SaveData() Then
                            Call LoadData()
                        End If
                    End If
                Else
                    pID = 0
                End If
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, ClassName & ".mCtlForm_Delete : " & ex.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    Private Sub mCtlForm_Edit(ByVal pID As Long) Handles mCtlForm.Edit
        Try
            Call ShowForm(DataMode.ModeEdit, pID)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, ClassName & ".mCtlForm_Edit : " & ex.Message)
        End Try
    End Sub

    Private Sub mCtlForm_InitDetail(ByVal pID As Long) Handles mCtlForm.InitDetail
        Dim lclsDAO As New CompanyDAO

        Try
            If lclsDAO.InitailData(pID) Then
                Dim lFILE As Image = Nothing
                If Not lclsDAO.HistoryDAO.ImageS Is Nothing Then
                    lFILE = lclsDAO.HistoryDAO.ImageS.Images
                End If
                mCtlForm.UcInfo1.Init(lclsDAO.GetInfoHtml, lFILE)
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, ClassName & ".mCtlForm_InitDetail : " & ex.Message)
        Finally
            lclsDAO = Nothing
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
            Err.Raise(Err.Number, ex.Source, ClassName & ".mCtlForm_ReLoad : " & ex.Message)
        End Try
    End Sub

End Class
