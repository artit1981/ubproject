
Option Explicit On
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class frmControls
#Region "Public"
    Public Event AddNew()
    Public Event CreateQuick()
    Public Event Import()
    Public Event Edit(ByVal pID As Long)
    Public Event Copy(ByVal pID As Long)
    Public Event Convert(ByVal pID As Long)
    Public Event Delete(ByRef pID As Long)
    Public Event ReLoad()
    Public Event RefreshFind()
    Public Event CHeckRefresh()
    Public Event InitDetail(ByVal pID As Long)
    Public Event InitStatus(ByVal pID As Long)
    Public Event MakeOrder(ByVal pID As Long)
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
            mID = GridView.GetRowCellDisplayText(rowHandle, "ID")
            mRowFocus = rowHandle
            RaiseEvent Edit(mID)

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
        cboFindIn.Properties.ReadOnly = Not CheckFind.Checked
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
        'GridView.Columns("NAME").Group()
        'GridView.OptionsView.ShowGroupedColumns = False
        'GridView.OptionsView.ShowColumnHeaders = False
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
            DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
            InitFindCondition()
            mIsFromLoad = False
            mLoadTimer = 0
            dtpDateTo.EditValue = DateAdd(DateInterval.Day, 7, GetCurrentDate(Nothing))
            dtpDateFrom.EditValue = DateAdd(DateInterval.Month, -3, GetCurrentDate(Nothing))

            'If DatePanel.Visible = True Then

            '    Dim styleCondition As StyleFormatCondition = New StyleFormatCondition()
            '    Dim styleCondition2 As StyleFormatCondition = New StyleFormatCondition()

            '    GridView.FormatConditions.Add(styleCondition)
            '    GridView.FormatConditions.Add(styleCondition2)

            '    styleCondition.Column = GridView.Columns("IsCancel")
            '    styleCondition.Condition = FormatConditionEnum.Equal
            '    styleCondition.Value1 = 1
            '    styleCondition.Appearance.BackColor = Color.WhiteSmoke
            '    styleCondition.Appearance.ForeColor = Color.YellowGreen
            '    styleCondition.ApplyToRow = True

            '    styleCondition2.Column = GridView.Columns("IsDelete")
            '    styleCondition2.Condition = FormatConditionEnum.Equal
            '    styleCondition2.Value1 = 1
            '    styleCondition2.Appearance.BackColor = Color.WhiteSmoke
            '    styleCondition2.Appearance.ForeColor = Color.Red
            '    styleCondition2.ApplyToRow = True

            '    'Dim condition As New StyleFormatCondition(FormatConditionEnum.Equal, GridView.Columns("IsDelete"), Nothing, 1, Nothing, True)
            '    'condition.Appearance.ForeColor = Color.Red
            '    ' condition.Appearance.BackColor = Color.WhiteSmoke
            '    'GridView.FormatConditions.Add(condition)

            '    'Dim condition2 As New StyleFormatCondition(FormatConditionEnum.Equal, GridView.Columns("IsCancel"), Nothing, 1, Nothing, True)
            '    ''condition2.c()
            '    'condition2.Appearance.ForeColor = Color.YellowGreen
            '    'condition2.Appearance.BackColor = Color.WhiteSmoke

            '    'GridView.FormatConditions.Add(condition2)

            '    'AddHandler GridView.CustomDrawRowPreview, AddressOf gridView_CustomDrawRowPreview
            'End If
         
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try
    End Sub

    Private Sub gridView_CustomDrawRowPreview(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs)
        e.Appearance.Assign((TryCast(e.Info, GridDataRowInfo)).Appearance)
    End Sub
    Private Sub cboFindIn_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFindIn.SelectedIndexChanged
        Try
            RaiseEvent RefreshFind()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try
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


    Private Sub PrintBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles PrintBar.ItemClick
        Try

            If GridView.RowCount > 0 Then
                ShowProgress(True, "Loading...")
                GridControl.ShowPrintPreview()
            End If
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try

    End Sub

    Private Sub DeleteBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles DeleteBar.ItemClick
        Dim rowHandle As Integer
        Try
            If GridView.RowCount = 0 Then Exit Sub
            rowHandle = (TryCast(GridControl.MainView, ColumnView)).FocusedRowHandle
            If rowHandle < 0 Then Exit Sub

            mID = GridView.GetRowCellDisplayText(rowHandle, "ID")
            If XtraMessageBox.Show(Me, "ต้องการลบข้อมูลใช่หรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                ShowProgress(True, "Deleting...")
                mRowFocus = rowHandle
                Dim lID As Long = mID
                RaiseEvent Delete(lID)
                If lID = 0 Then
                    ShowProgress(False, "")
                    XtraMessageBox.Show("ข้อมูลถูกใช้งานอยู่ ไม่สามารถลบได้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf lID = 1 Then
                    ShowProgress(False, "")
                    XtraMessageBox.Show("Serial Number บางรายการถุก Close แล้ว", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                    'If mRowFocus > 0 Then
                    '    GridView.FocusedRowHandle = mRowFocus
                    'End If

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

    Private Sub GridView_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView.FocusedRowChanged
        Try
            InitDetails()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try
    End Sub

    Private Sub InitDetails()
        Dim rowHandle As Integer
        Try

            If GridView.RowCount = 0 Then Exit Sub
            rowHandle = (TryCast(GridControl.MainView, ColumnView)).FocusedRowHandle

            If rowHandle < 0 Then Exit Sub

            mID = ConvertNullToZero(GridView.GetRowCellDisplayText(rowHandle, "ID"))
            If mID > 0 Then
                'mRowFocus = rowHandle
                If CheckShowInfo.Checked = True And mIsFromLoad = False Then
                    ShowProgress(True, "Loading...")
                    RaiseEvent InitDetail(mID)
                End If
                RaiseEvent InitStatus(mID)
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "frmControl.InitDetails : " & e.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub CheckShowInfo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckShowInfo.CheckedChanged
        Try
            If CheckShowInfo.Checked = False Then
                DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
            Else
                DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
                InitDetails()
            End If
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try
    End Sub

    Private Sub DockPanel1_ClosingPanel(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking.DockPanelCancelEventArgs) Handles DockPanel1.ClosingPanel
        CheckShowInfo.Checked = False
    End Sub

    Private Sub CopyBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CopyBar.ItemClick
        Dim rowHandle As Integer
        Try

            If GridView.RowCount = 0 Then Exit Sub
            rowHandle = (TryCast(GridControl.MainView, ColumnView)).FocusedRowHandle


            If rowHandle < 0 Then Exit Sub

            ShowProgress(True, "Loading...")
            mID = GridView.GetRowCellDisplayText(rowHandle, "ID")
            If mID > 0 Then
                mRowFocus = rowHandle
                RaiseEvent Copy(mID)
            End If


        Catch ex As Exception

            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub QuickBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles QuickBar.ItemClick
        Try
            'ShowProgress(True, "Loading...")
            RaiseEvent CreateQuick()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            'ShowProgress(False, "")
        End Try
    End Sub

    Private Sub ImportBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ImportBar.ItemClick
        Try
            ShowProgress(True, "Loading...")
            RaiseEvent Import()
            mRowFocus = 0
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub ConvertBar_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ConvertBar.ItemClick
        Dim rowHandle As Integer
        Try

            If GridView.RowCount = 0 Then Exit Sub
            rowHandle = (TryCast(GridControl.MainView, ColumnView)).FocusedRowHandle


            If rowHandle < 0 Then Exit Sub

            'ShowProgress(True, "Loading...")
            mID = GridView.GetRowCellDisplayText(rowHandle, "ID")
            If mID > 0 Then
                RaiseEvent Convert(mID)
            End If
            mRowFocus = 0

        Catch ex As Exception

            ShowErrorMsg(False, ex.Message)
        Finally
            'ShowProgress(False, "")
        End Try
    End Sub

    Private Sub MakeOrderBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles MakeOrderBar.ItemClick
        Dim rowHandle As Integer
        Try

            If GridView.RowCount = 0 Then Exit Sub
            rowHandle = (TryCast(GridControl.MainView, ColumnView)).FocusedRowHandle


            If rowHandle < 0 Then Exit Sub

            'ShowProgress(True, "Loading...")
            mID = GridView.GetRowCellDisplayText(rowHandle, "ID")
            If mID > 0 Then
                RaiseEvent MakeOrder(mID)
            End If


        Catch ex As Exception

            ShowErrorMsg(False, ex.Message)
        Finally
            'ShowProgress(False, "")
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

    Private Sub GridView_RowStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles GridView.RowStyle

        Dim lData As Integer = 0, lStatus As String = "", lChequeID As Long = 0, lIsNotPass As Long = 0
        Try
            If DatePanel.Visible = True Then
                If (e.RowHandle >= 0) Then
                    lData = GridView.GetRowCellValue(e.RowHandle, GridView.Columns("IsCancel"))
                    If lData = 1 Then
                        e.Appearance.BackColor = Color.WhiteSmoke
                        e.Appearance.ForeColor = Color.YellowGreen
                    End If

                    lData = GridView.GetRowCellValue(e.RowHandle, GridView.Columns("IsDelete"))
                    If lData = 1 Then
                        e.Appearance.BackColor = Color.WhiteSmoke
                        e.Appearance.ForeColor = Color.Red
                    End If

                    lStatus = ConvertNullToString(GridView.GetRowCellValue(e.RowHandle, GridView.Columns("OrderStatus")))
                    lChequeID = ConvertNullToZero(GridView.GetRowCellValue(e.RowHandle, GridView.Columns("ChequeID")))
                    If (lStatus = EnumStatus.Open.ToString Or lStatus = EnumStatus.Receive.ToString) And lData = 0 And lChequeID = 0 Then
                        e.Appearance.BackColor = Color.LightGreen
                        'e.Appearance.ForeColor = Color.Red

                    End If

                    lIsNotPass = ConvertNullToZero(GridView.GetRowCellValue(e.RowHandle, GridView.Columns("IsNotPass")))
                    If lIsNotPass = 1 Then
                        e.Appearance.BackColor = Color.Orange
                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class