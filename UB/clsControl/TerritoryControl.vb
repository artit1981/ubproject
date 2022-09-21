
Option Explicit On

Public Class TerritoryControl
    Implements iControl
    Private Const mCaption As String = "ทีมขาย"
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
    Private mCHECKSUM_AGG As Long

    Private ReadOnly Property ClassName() As String
        Get
            Return "TerritoryControl"
        End Get
    End Property

    Private ReadOnly Property Caption() As String
        Get
            Return mCaption
        End Get
    End Property


    Private Sub LoadData()
        Dim lcls As New TerritoryDAO
        Dim dataTable As New DataTable()

        Try
            dataTable = lcls.GetDataTable(0, False)

            If dataTable.Rows.Count > 0 Then
                Dim lRow As Long = mCtlForm.GridView.FocusedRowHandle
                mCtlForm.GridControl.DataSource = dataTable
                mCtlForm.GridView.ViewCaption = mCaption
                Call GridStyle()
                If lRow < mCtlForm.GridView.RowCount Then
                    mCtlForm.GridView.FocusedRowHandle = lRow
                End If
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
        mFindCode(0) = "รหัสทีมขาย"
        mFindCode(1) = "TerritoryCode"
        mFindName(0) = "ชื่อทีมขาย"
        mFindName(1) = "NameThai"


        Try
            With mCtlForm
                .cboFindIn.Properties.Items.Add(mFindAll(0))
                .cboFindIn.Properties.Items.Add(mFindCode(0))
                .cboFindIn.Properties.Items.Add(mFindName(0))
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

            .Columns("TerritoryCode").Caption = "รหัสทีมขาย"
            .Columns("TerritoryCode").Width = 400

            .Columns("NameThai").Caption = "ชื่อทีมขาย"
            .Columns("NameThai").Width = 700

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
        Dim lFormEdit As frmTerritory
        Try
            lFormEdit = New frmTerritory
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
        Dim lcls As New TerritoryDAO
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
        Dim lcls As New TerritoryDAO

        Try
            If lcls.InitailData(pID) Then
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
        Dim lclsDAO As New TerritoryDAO

        Try
            If lclsDAO.InitailData(pID) Then

                mCtlForm.UcInfo1.Init(lclsDAO.GetInfoHtml, Nothing)
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
            Dim lstrCon As String
            lstrCon = ""
            Select Case Trim(mCtlForm.cboFindIn.SelectedItem)
                Case mFindAll(0)
                    lstrCon = mFindAll(1)
                Case mFindCode(0)
                    lstrCon = mFindCode(1)
                Case mFindName(0)
                    lstrCon = mFindName(1)
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
