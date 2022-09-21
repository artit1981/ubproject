
Option Explicit On

Public Class RunnignFormatControl
    Implements iControl
    Private Const mCaption As String = "Running Format"

    Public Sub Execute(ByVal pOrderType As Integer) Implements iControl.Execute
        Try
            mCtlForm = New frmControls
            With mCtlForm
                .Text = mCaption
                .MdiParent = frmMain
                .OptionBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Call LoadData()
                Call LoadFilter()
                Call SetControlMenuPrivilege(mCtlForm, MasterType.RunningFormat)
                .Show()
            End With

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try
    End Sub

    Private WithEvents mCtlForm As frmControls
    Private mFindAll(1) As String
    Private mFindSystem(1) As String
    Private mFindMenu(1) As String
    Private mCHECKSUM_AGG As Long

    Private Sub LoadData()
        Dim lcls As New RunningFormatDAO
        Dim dataTable As New DataTable()

        Try


            dataTable = lcls.GetDataTable()

            If dataTable.Rows.Count > 0 Then
                mCtlForm.GridControl.DataSource = dataTable
                mCtlForm.GridView.ViewCaption = mCaption
                Call GridStyle()
            Else
                mCtlForm.GridControl.DataSource = Nothing
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "clsControlRunnignFormat.LoadData : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Sub


    Private Sub LoadFilter()
        mFindAll(0) = "ทั้งหมด"
        mFindAll(1) = "*"
        mFindSystem(0) = "ระบบ"
        mFindSystem(1) = "System"
        mFindMenu(0) = "เมนู"
        mFindMenu(1) = "MenuDisplay"


        Try
            With mCtlForm
                .cboFindIn.Properties.Items.Add(mFindAll(0))
                .cboFindIn.Properties.Items.Add(mFindSystem(0))
                .cboFindIn.Properties.Items.Add(mFindMenu(0))
                .cboFindIn.SelectedIndex = 0
            End With

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "clsControlRunnignFormat.LoadFilter : " & e.Message)
        Finally
        End Try
    End Sub

    Private Sub GridStyle()
        With mCtlForm.GridView

            .Columns("ID").Visible = False

            .Columns("System").Caption = "ระบบ"
            .Columns("System").Width = 400

            .Columns("MenuDisplay").Caption = "เมนู"
            .Columns("MenuDisplay").Width = 700

        End With
    End Sub


    Private Sub mCtlForm_AddNew() Handles mCtlForm.AddNew
        'Try
        '    Call ShowForm(DataMode.ModeNew, 0)
        'Catch ex As Exception
        '    Err.Raise(Err.Number, ex.Source, "clsControlRunnignFormat.mCtlForm_AddNew : " & ex.Message)
        'End Try
    End Sub

    Private Sub ShowForm(ByVal pMode As Integer, ByVal pID As Long)
        Dim lFormEdit As frmRuningFormat
        Try

            lFormEdit = New frmRuningFormat
            With lFormEdit
                .Caption = mCaption
                .MdiParent = frmMain
                .ModeData = pMode
                .IDs = pID
                .Show()
            End With

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "clsControlRunnignFormat.ShowForm : " & ex.Message)
        End Try
    End Sub

    Private Sub mCtlForm_CHeckRefresh() Handles mCtlForm.CHeckRefresh
        Dim lcls As New RunningFormatDAO
        Dim lCurrent As Long
        Try
            lCurrent = lcls.CHECKSUM_AGG
            If mCHECKSUM_AGG <> lCurrent Then
                LoadData()
                mCHECKSUM_AGG = lCurrent
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "clsControlRunnignFormat.mCtlForm_CHeckRefresh : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    Private Sub mCtlForm_Delete(ByRef pID As Long) Handles mCtlForm.Delete

    End Sub

    Private Sub mCtlForm_Edit(ByVal pID As Long) Handles mCtlForm.Edit
        Try
            Call ShowForm(DataMode.ModeEdit, pID)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "clsControlRunnignFormat.mCtlForm_Edit : " & ex.Message)
        End Try
    End Sub

    Private Sub mCtlForm_InitDetail(ByVal pID As Long) Handles mCtlForm.InitDetail
        'Dim lclsDepartmentDAO As New DepartmentDAO

        'Try
        '    If lclsDepartmentDAO.InitailData(pID) Then

        '        mCtlForm.UcInfo1.Init(lclsDepartmentDAO.GetInfoHtml, Nothing)
        '    End If
        'Catch ex As Exception
        '    Err.Raise(Err.Number, ex.Source, "clsControlRunnignFormat.mCtlForm_InitDetail : " & ex.Message)
        'Finally
        '    lclsDepartmentDAO = Nothing
        'End Try
    End Sub

    Private Sub mCtlForm_RefreshFind() Handles mCtlForm.RefreshFind
        Try
            Dim findText As String = mCtlForm.GridView.FindFilterText
            Dim lstrCon As String
            lstrCon = ""
            Select Case Trim(mCtlForm.cboFindIn.SelectedItem)
                Case mFindAll(0)
                    lstrCon = mFindAll(1)
                Case mFindSystem(0)
                    lstrCon = mFindSystem(1)
                Case mFindMenu(0)
                    lstrCon = mFindMenu(1)
            End Select
            mCtlForm.GridView.OptionsFind.FindFilterColumns = lstrCon
            mCtlForm.GridView.ApplyFindFilter(String.Empty)
            mCtlForm.GridView.ApplyFindFilter(findText)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "clsControlRunnignFormat.mCtlForm_ReLoad : " & ex.Message)
        End Try
    End Sub

    Private Sub mCtlForm_ReLoad() Handles mCtlForm.ReLoad
        Try
            Call LoadData()
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "clsControlRunnignFormat.mCtlForm_ReLoad : " & ex.Message)
        End Try
    End Sub

End Class
