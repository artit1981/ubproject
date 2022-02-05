Option Explicit On

Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors

Public Class frmMaster

#Region "Public"
    Public Event Save(ByRef pSuccess As Boolean, ByVal pMode As Integer, ByVal pID As Long)
    Public Event Delete(ByRef pSuccess As Boolean, ByVal pID As Long)
    Public Event ReLoad(ByVal pID As Long)
    Public Event InitialData(ByVal pID As Long)


#End Region

#Region "Private"
    Private mMode As DataMode
    Private mID As Long


    Private Sub AddNew()

        mMode = DataMode.ModeNew
        txtThai.Select()
        XtraTabControl1.SelectedTabPage = GeneralTabPage
        Call UnLockAllControl()
        Call ClearForm(GeneralTabPage)
        Call ClearForm(AdminTabPage)
    End Sub

    Private Sub SavedData()
        Dim lSuccess As Boolean
        Dim rowHandle As Integer
        Try
            If mMode = DataMode.ModeNew Then
                mID = 0
            ElseIf GridView.RowCount = 0 Then
                mMode = DataMode.ModeNew
                mID = 0
            Else
                rowHandle = (TryCast(GridControl.MainView, ColumnView)).FocusedRowHandle
                If rowHandle < 0 Then
                    mID = 0
                Else
                    mID = GridView.GetRowCellDisplayText(rowHandle, "ID")
                End If
            End If
            RaiseEvent Save(lSuccess, mMode, mID)
            If lSuccess Then
                Call LockAllControl()
            End If

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try


    End Sub

    Private Sub LockAllControl()
        Try
            Call LockControl(txtThai)
            Call LockControl(txtEng)
            Call LockControl(txtRemark)
            DxErrorProvider1.SetError(txtThai, "")

            SaveBar.Enabled = False
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "LockAllControl : " & ex.Message)
        Finally
        End Try

    End Sub


    Private Sub UnLockAllControl()
        Try
            Call UnLockControl(txtThai)
            Call UnLockControl(txtEng)
            Call UnLockControl(txtRemark)
            SaveBar.Enabled = True
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "UnLockAllControl : " & ex.Message)
        Finally
        End Try

    End Sub
#End Region


#Region "Event"
    Private Sub frmMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            ShowProgress(True, "Loading...")
            XtraTabControl1.SelectedTabPage = GeneralTabPage
            If GridView.RowCount > 0 Then
                mID = GridView.GetRowCellDisplayText(0, "ID")
                RaiseEvent InitialData(mID)
            End If

            mMode = DataMode.ModeNone
            Call LockAllControl()
            Me.Select() 
        Catch ex As Exception 
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub GridView_RowClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView.RowClick
        Dim rowHandle As Integer
        Try
            If GridView.RowCount = 0 Then Exit Sub
            rowHandle = (TryCast(GridControl.MainView, ColumnView)).FocusedRowHandle
            If rowHandle < 0 Then
                mID = 0
            Else
                mID = GridView.GetRowCellDisplayText(rowHandle, "ID")
            End If
            ShowProgress(True, "Loading...")
            RaiseEvent InitialData(mID)
            mMode = DataMode.ModeNone
            Call LockAllControl() 
        Catch ex As Exception 
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub



    Private Sub AddBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles AddBar.ItemClick
        Try
            ShowProgress(True, "Loading...")
            Call AddNew() 
        Catch ex As Exception 
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub EditBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles EditBar.ItemClick
        Dim rowHandle As Integer
        Try
            rowHandle = (TryCast(GridControl.MainView, ColumnView)).FocusedRowHandle
            If rowHandle < 0 Then Exit Sub
            mMode = DataMode.ModeEdit
            Call UnLockAllControl()
            txtThai.Select()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub ExitBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ExitBar.ItemClick
        Me.Close()
    End Sub

    Private Sub SaveBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles SaveBar.ItemClick
        Try
            ShowProgress(True, "Saving...")
            Call SavedData()
            GridControl.Select()
        Catch ex As Exception 
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub DeleteBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles DeleteBar.ItemClick
        Dim lSuccess As Boolean
        Dim rowHandle As Integer
        Try
            rowHandle = (TryCast(GridControl.MainView, ColumnView)).FocusedRowHandle
            If rowHandle < 0 Then Exit Sub
            If XtraMessageBox.Show(Me, "ต้องการลบข้อมูลใช่หรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                ShowProgress(True, "Deleting...")
                mMode = DataMode.ModeDelete
                RaiseEvent Delete(lSuccess, mID)
            End If 
        Catch ex As Exception 
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub RefreshBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles RefreshBar.ItemClick
        Try
            ShowProgress(True, "Refreshing...")
            RaiseEvent ReLoad(0)
            mMode = DataMode.ModeNone
            Call LockAllControl()
        Catch ex As Exception 
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

#End Region



    Private Sub frmMaster_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class