Public Class UserControl
    Implements iControl
    Private Const mCaption As String = "ผู้ใช้งาน"

    Public Sub Execute(ByVal pOrderType As Integer) Implements iControl.Execute
        Try
            mCtlForm = New frmControls
            With mCtlForm
                .Text = Caption
                .MdiParent = frmMain
                .OptionBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Call LoadData()
                Call LoadFilter()
                .Show()
            End With

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try
    End Sub

    Private WithEvents mCtlForm As frmControls
    Private mFindAll(1) As String
    Private mFindCode(1) As String
    Private mFindName(1) As String
    Private mFindEmp(1) As String
    Private mCHECKSUM_AGG As Long

    Private ReadOnly Property ClassName() As String
        Get
            Return "UserControl"
        End Get
    End Property

    Private ReadOnly Property Caption() As String
        Get
            Return mCaption
        End Get

    End Property

    Private Sub LoadData()
        Dim lcls As New UserDAO
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


    Private Sub LoadFilter()
        mFindAll(0) = "ทั้งหมด"
        mFindAll(1) = "*"
        mFindCode(0) = "ชื่อเข้าระบบ"
        mFindCode(1) = "UserName"
        mFindName(0) = "รายละเอียด"
        mFindName(1) = "Remark"
        mFindEmp(0) = "พนักงาน"
        mFindEmp(1) = "EmpName"

        Try
            With mCtlForm
                .cboFindIn.Properties.Items.Add(mFindAll(0))
                .cboFindIn.Properties.Items.Add(mFindCode(0))
                .cboFindIn.Properties.Items.Add(mFindName(0))
                .cboFindIn.Properties.Items.Add(mFindEmp(0))
                .cboFindIn.SelectedIndex = 0
            End With

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, ClassName & ".LoadFilter : " & e.Message)
        Finally
        End Try
    End Sub

    Private Sub GridStyle()
        With mCtlForm.GridView

            .Columns("ID").Width = 0
            .Columns("ID").Caption = ""
            .Columns("ID").Visible = False

            .Columns("UserName").Caption = "ชื่อเข้าระบบ"
            .Columns("UserName").Width = 400

            .Columns("EmpName").Caption = "พนักงาน"
            .Columns("EmpName").Width = 400

            .Columns("Remark").Caption = "รายละเอียด"
            .Columns("Remark").Width = 700

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
        Dim lFormEdit As frmUser
        Try

            lFormEdit = New frmUser
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
        Dim lcls As New UserDAO
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
        Dim lcls As New UserDAO

        Try
            If lcls.InitailData(True, pID, "", Nothing) Then
                If lcls.CheckIsToUse = False Then  ''ถูกใช้งานอยู่ ???
                    lcls.ID = pID
                    lcls.ModeData = DataMode.ModeDelete
                    If lcls.InitailData(True, pID, "") Then
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
        Dim lclsDAO As New UserDAO

        Try
            If lclsDAO.InitailData(True, pID, "") Then
                mCtlForm.UcInfo1.Init(lclsDAO.GetInfoHtml, Nothing)
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, ClassName & ".mCtlForm_InitDetail : " & ex.Message)

        End Try
    End Sub

    Private Sub mCtlForm_RefreshFind() Handles mCtlForm.RefreshFind
        Try
            Dim findText As String = mCtlForm.GridView.FindFilterText
            Dim lstrCon As String
            lstrCon = ""
            Select Case Trim(mCtlForm.cboFindIn.SelectedItem)
                Case mFindAll(0)
                    lstrCon = mFindAll(1)
                Case mFindCode(0)
                    lstrCon = mFindCode(1)
                Case mFindName(0)
                    lstrCon = mFindName(1)
                Case mFindEmp(0)
                    lstrCon = mFindEmp(1)
            End Select
            mCtlForm.GridView.OptionsFind.FindFilterColumns = lstrCon
            mCtlForm.GridView.ApplyFindFilter(String.Empty)
            mCtlForm.GridView.ApplyFindFilter(findText)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, ClassName & ".mCtlForm_ReLoad : " & ex.Message)
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
