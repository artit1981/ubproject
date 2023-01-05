
Option Explicit On
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class frmControlCommission
#Region "Public"
    Public Event AddNew()
    Public Event Edit(ByVal pID As Long, ByVal pIndex As Long)
    Public Event Delete(ByRef pID As Long)
    Public Event ReLoad()
    Public Event CHeckRefresh()
    Public Event InitStatus(ByVal pIsDelete As Integer)
#End Region

#Region "Private"
    Private mID As Long
    Private mIsFromLoad As Boolean = True
    Private mLoadTimer As Long
    Private mRowFocus As Long
#End Region

    Private Sub EditBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles EditBar.ItemClick
        Dim rowHandle As Integer
        Try

            If GridView.RowCount = 0 Then Exit Sub
            rowHandle = (TryCast(GridControl.MainView, ColumnView)).FocusedRowHandle

            If rowHandle < 0 Then Exit Sub

            ShowProgress(True, "Loading...")
            mID = GridView.GetRowCellDisplayText(rowHandle, "CommissionID")
            mRowFocus = rowHandle
            RaiseEvent Edit(mID, mRowFocus)

        Catch ex As Exception

            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub AddBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles AddBar.ItemClick
        Try
            ShowProgress(True, "Loading...")
            mRowFocus = 0
            RaiseEvent AddNew()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub InitFindCondition()
        'Find
        GridView.OptionsFind.AllowFindPanel = CheckFind.Checked
        GridView.OptionsFind.AlwaysVisible = CheckFind.Checked
        GridView.OptionsFind.HighlightFindResults = True
        If (Not GridView.OptionsFind.AllowFindPanel) Then
            GridView.HideFindPanel()
        Else
            GridView.ShowFindPanel()
        End If

        'Refresh
        CheckIsRefresh.Checked = True
        cboRefreshTime.Text = 3
        Timer1.Interval = cboRefreshTime.Text * 1000
        Timer1.Start()
    End Sub

    Private Sub CheckFind_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckFind.CheckedChanged
        ShowProgress(True, "Loading...")
        InitFindCondition()

        ShowProgress(False, "")
    End Sub

    Private Sub frmControls_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyData = Keys.Escape Then
            Me.Close()
        End If
    End Sub


    Private Sub frmControls_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            mRowFocus = 0
            mIsFromLoad = True
            CheckShowInfo.Checked = False
            InitFindCondition()
            mIsFromLoad = False
            mLoadTimer = 0
            dtpDateTo.EditValue = DateAdd(DateInterval.Day, 7, GetCurrentDate(Nothing))
            dtpDateFrom.EditValue = DateAdd(DateInterval.Month, -1, GetCurrentDate(Nothing))

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try
    End Sub

    Private Sub gridView_CustomDrawRowPreview(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs)
        e.Appearance.Assign((TryCast(e.Info, GridDataRowInfo)).Appearance)
    End Sub


    Private Sub RefreshBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles RefreshBar.ItemClick
        Try
            ShowProgress(True, "Loading...")
            mRowFocus = 0
            RaiseEvent ReLoad()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub ExitBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ExitBar.ItemClick
        Me.Close()
    End Sub


    Private Sub DeleteBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles DeleteBar.ItemClick
        Dim rowHandle As Integer
        Try
            If GridView.RowCount = 0 Then Exit Sub
            rowHandle = (TryCast(GridControl.MainView, ColumnView)).FocusedRowHandle
            If rowHandle < 0 Then Exit Sub

            mID = GridView.GetRowCellDisplayText(rowHandle, "CommissionID")
            If XtraMessageBox.Show(Me, "ต้องการลบข้อมูลใช่หรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                ShowProgress(True, "Deleting...")
                mRowFocus = rowHandle
                Dim lID As Long = mID
                RaiseEvent Delete(lID)
                If lID = 0 Then
                    ShowProgress(False, "")
                    XtraMessageBox.Show("ข้อมูลถูกใช้งานอยู่ ไม่สามารถลบได้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            ShowProgress(False, "")
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            If CheckIsRefresh.Checked = True Then
                If mLoadTimer < 15 Then
                    mLoadTimer = mLoadTimer + 1
                Else
                    RaiseEvent CHeckRefresh()
                    mLoadTimer = 0
                End If

            End If
            If CheckShowInfo.Checked = False Then
                'SplitControl1.SplitterPosition = SplitControl1.Width
            End If
        Catch ex As Exception

            'ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub cboRefreshTime_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRefreshTime.SelectedIndexChanged
        Timer1.Interval = cboRefreshTime.Text * 1000
    End Sub


    Private Sub frmControls_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Try
            'SplitControl1.SplitterPosition = Me.Width - 200
            'SplitControl1.Panel1.MinSize = Me.Width - 250
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub


    Private Sub btnExportExcel_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportExcel.EditValueChanged

    End Sub

    Private Sub dtpDateFrom_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpDateFrom.Click
        If DatePanel.Visible = True Then
            RaiseEvent ReLoad()
        End If
    End Sub

    Private Sub dtpDateTo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpDateTo.Click
        If DatePanel.Visible = True Then
            RaiseEvent ReLoad()
        End If
    End Sub


    Private Sub GridView_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView.FocusedRowChanged
        Dim rowHandle As Integer
        Try
            If GridView.RowCount = 0 Then Exit Sub
            rowHandle = (TryCast(GridControl.MainView, ColumnView)).FocusedRowHandle

            If rowHandle < 0 Then Exit Sub

            mID = ConvertNullToZero(GridView.GetRowCellDisplayText(rowHandle, "CommissionID"))
            If mID > 0 Then
                RaiseEvent InitStatus(ConvertNullToZero(GridView.GetRowCellDisplayText(rowHandle, "IsDelete")))
            End If
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try
    End Sub


    Private Sub GridView_RowStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles GridView.RowStyle
        Dim lData As Integer = 0, lStatus As String = ""
        Try
            If DatePanel.Visible = True Then
                If (e.RowHandle >= 0) Then
                    lData = GridView.GetRowCellValue(e.RowHandle, GridView.Columns("IsDelete"))
                    If lData = 1 Then
                        e.Appearance.BackColor = Color.WhiteSmoke
                        e.Appearance.ForeColor = Color.Red
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


End Class