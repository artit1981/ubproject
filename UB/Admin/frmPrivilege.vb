Option Explicit On

Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base


Public Class frmPrivilege
    Inherits iEditForm
    Dim mcls As New PrivilegeDAO
    Private Const mFormName As String = "frmPrivilege"
    Private mIsFormLoad As Boolean


#Region "Overrides"
    Protected Overrides Sub OnLoadForm(ByVal pMode As Integer, ByVal pID As Long, ByVal pOrderType As Long, ByVal pclsConvert As iOrder, ByVal pCusID As Long)
        Try
            mIsFormLoad = True
            If pMode = DataMode.ModeNew Then
                LoadDataMenu(0)
            ElseIf pMode = DataMode.ModeEdit Then
                Call LoadData(pMode, pID)
                LoadDataMenu(pID)
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".OnLoadForm : " & e.Message)
        Finally
            mIsFormLoad = False
        End Try
    End Sub

    Protected Overrides Sub ClearAllForm(ByVal pMode As Integer)
        Try
            MyBase.ClearAllForm(pMode)
            Select Case pMode
                Case DataMode.ModeNew
                    ClearForm(GeneralTabPage)
                    ClearForm(AdminTabPage)
                    ClearForm(GroupDisplay)
                    ClearForm(GroupEvent)
                    ClearForm(GroupAction)
            End Select

            XtraTabControl1.SelectedTabPage = GeneralTabPage
            txtThai.Select()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".ClearAllForm : " & e.Message)
        End Try

    End Sub

    Protected Overrides Function Save(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        XtraTabControl1.SelectedTabPage = GeneralTabPage
        Try
            mcls.ID = pID
            mcls.ModeData = pMode
            mcls.Code = txtThai.Text.Trim
            mcls.Remark = txtRemark.Text.Trim
            mcls.IsInActive = CheckInAcive.Checked
            If Verify() = True Then
                Return mcls.SaveData(GridView)
            Else
                ShowProgress(False, "")
                XtraMessageBox.Show(Me, "พบข้อผิดพลาดกรุณาตรวจสอบ", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".Save : " & ex.Message)
            Return False
        End Try
    End Function

    Protected Overrides Sub OnClosedForm()
        mcls = Nothing
    End Sub
#End Region

#Region "Event"
    Private Sub FormChangedComponent1_FormControlChanged1(ByVal sender As Object, ByVal e As FormChangedEventArgs) Handles FormChangedComponent1.FormControlChanged
        MyBase.CheckFormChanged()
    End Sub
    Private Sub GridView_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView.FocusedRowChanged
        Dim rowHandle As Integer
        Try
            If mIsFormLoad = True Then Exit Sub
            If GridView.RowCount = 0 Then Exit Sub
            rowHandle = (TryCast(GridControl.MainView, ColumnView)).FocusedRowHandle


            If rowHandle < 0 Then Exit Sub
            'ShowProgress(True, "Loading...")

            Call SetRowChange(rowHandle)
            Call SetPrivilegeData(GridView.GetRowCellDisplayText(rowHandle, "PrivilegeData"))
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            'ShowProgress(False, "")
        End Try
    End Sub

    Private Sub SetRowChange(ByVal rowHandle As Long)
        Try
            CheckVisible.Enabled = IIf(GridView.GetRowCellDisplayText(rowHandle, "IsVisible") = "Checked", True, False)
            CheckEnable.Enabled = IIf(GridView.GetRowCellDisplayText(rowHandle, "IsEnable") = "Checked", True, False)
            CheckAdd.Enabled = IIf(GridView.GetRowCellDisplayText(rowHandle, "IsAdd") = "Checked", True, False)
            CheckEdit.Enabled = IIf(GridView.GetRowCellDisplayText(rowHandle, "IsEdit") = "Checked", True, False)
            CheckDelete.Enabled = IIf(GridView.GetRowCellDisplayText(rowHandle, "IsDelete") = "Checked", True, False)
            CheckPrint.Enabled = IIf(GridView.GetRowCellDisplayText(rowHandle, "IsPrint") = "Checked", True, False)
            CheckCreateQuick.Enabled = IIf(GridView.GetRowCellDisplayText(rowHandle, "IsCreateQuick") = "Checked", True, False)
            CheckCopy.Enabled = IIf(GridView.GetRowCellDisplayText(rowHandle, "IsCopy") = "Checked", True, False)
            CheckAssign.Enabled = IIf(GridView.GetRowCellDisplayText(rowHandle, "IsAssign") = "Checked", True, False)
            CheckConvert.Enabled = IIf(GridView.GetRowCellDisplayText(rowHandle, "IsConvert") = "Checked", True, False)
            CheckImport.Enabled = IIf(GridView.GetRowCellDisplayText(rowHandle, "IsImport") = "Checked", True, False)
            GroupDisplay.Text = "Display Menu : " & GridView.GetRowCellDisplayText(rowHandle, "MenuDisplay")
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetRowChange : " & e.Message)
        Finally
        End Try

    End Sub


    Private Function GetPrivilegeData() As Long
        Dim lPrivilege As Privilege = 0
        Try
            lPrivilege = lPrivilege + IIf(CheckVisible.Checked, Privilege.Visible, 0)
            lPrivilege = lPrivilege + IIf(CheckEnable.Checked, Privilege.Enable, 0)
            lPrivilege = lPrivilege + IIf(CheckAdd.Checked, Privilege.Add, 0)
            lPrivilege = lPrivilege + IIf(CheckEdit.Checked, Privilege.Edit, 0)
            lPrivilege = lPrivilege + IIf(CheckDelete.Checked, Privilege.Delete, 0)
            lPrivilege = lPrivilege + IIf(CheckPrint.Checked, Privilege.Print, 0)
            lPrivilege = lPrivilege + IIf(CheckCreateQuick.Checked, Privilege.Quick, 0)
            lPrivilege = lPrivilege + IIf(CheckCopy.Checked, Privilege.Copy, 0)
            lPrivilege = lPrivilege + IIf(CheckAssign.Checked, Privilege.Assign, 0)
            lPrivilege = lPrivilege + IIf(CheckConvert.Checked, Privilege.Convert, 0)
            lPrivilege = lPrivilege + IIf(CheckImport.Checked, Privilege.Import, 0)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".GetPrivilegeData : " & e.Message)
        Finally
        End Try
        Return lPrivilege
    End Function

    Private Function SetPrivilegeData(ByVal lPrivilege As Privilege) As Long
        Try
            CheckVisible.Checked = (lPrivilege And Privilege.Visible) = Privilege.Visible
            CheckEnable.Checked = (lPrivilege And Privilege.Enable) = Privilege.Enable
            CheckAdd.Checked = (lPrivilege And Privilege.Add) = Privilege.Add
            CheckEdit.Checked = (lPrivilege And Privilege.Edit) = Privilege.Edit
            CheckDelete.Checked = (lPrivilege And Privilege.Delete) = Privilege.Delete
            CheckPrint.Checked = (lPrivilege And Privilege.Print) = Privilege.Print
            CheckCreateQuick.Checked = (lPrivilege And Privilege.Quick) = Privilege.Quick
            CheckCopy.Checked = (lPrivilege And Privilege.Copy) = Privilege.Copy
            CheckAssign.Checked = (lPrivilege And Privilege.Assign) = Privilege.Assign
            CheckConvert.Checked = (lPrivilege And Privilege.Convert) = Privilege.Convert
            CheckImport.Checked = (lPrivilege And Privilege.Import) = Privilege.Import
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".GetPrivilegeData : " & e.Message)
        Finally
        End Try
        Return lPrivilege
    End Function

    Private Function LoadData(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        Try
            If mcls.InitailData(pID, 0) Then
                txtThai.Text = mcls.Code
                txtRemark.Text = mcls.Remark
                CheckInAcive.Checked = mcls.IsInActive
                txtCreateBy.Text = mcls.CreateBy.Trim
                txtCreateTime.Text = mcls.CreateTime
                txtModifiBy.Text = mcls.ModifiedBy.Trim
                txtModifiTime.Text = mcls.ModifiedTime
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".LoadData : " & ex.Message)
            Return False
        End Try

    End Function
    Private Sub LoadDataMenu(ByVal pID As Long)
        'Dim lcls As New PrivilegeDAO
        Dim dataTable As New DataTable()

        Try
            dataTable = mcls.GetDataPrivilege(pID)

            If dataTable.Rows.Count > 0 Then
                GridControl.DataSource = dataTable

                Call GridStyle()
                GridView.OptionsView.ShowGroupedColumns = False
                GridView.OptionsView.ShowGroupPanel = False
                GridView.Columns(2).Group()
                GridView.Columns(3).Group()
                GridView.ExpandAllGroups()
            Else
                GridControl.DataSource = Nothing
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".LoadDataMenu : " & e.Message)
        Finally
            dataTable = Nothing
        End Try

    End Sub

    Private Sub GridStyle()
        With GridView

            .Columns("MenuID").Width = 0
            .Columns("MenuID").Caption = " "
            .Columns("MenuID").Visible = False
            .Columns("ShowMode").Visible = False
            .Columns("IsVisible").Visible = False
            .Columns("IsEnable").Visible = False
            .Columns("IsAdd").Visible = False
            .Columns("IsEdit").Visible = False
            .Columns("IsDelete").Visible = False
            .Columns("IsPrint").Visible = False
            .Columns("IsCreateQuick").Visible = False
            .Columns("IsCopy").Visible = False
            .Columns("IsAssign").Visible = False
            .Columns("IsConvert").Visible = False
            .Columns("IsImport").Visible = False
            .Columns("PrivilegeData").Visible = False
            .Columns("IsNew").Visible = False

            .Columns("System").Caption = "ระบบ"
            .Columns("System").Width = 300

            .Columns("Module").Caption = "ระบบย่อย"
            .Columns("Module").Width = 400

            .Columns("MenuDisplay").Caption = "เมนู"
            .Columns("MenuDisplay").Width = 400
        End With
    End Sub


#End Region

    Private Sub btnSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectAll.Click
        For Each ctrControl As System.Windows.Forms.Control In GroupDisplay.Controls
            If Object.ReferenceEquals(ctrControl.[GetType](), GetType(DevExpress.XtraEditors.CheckEdit)) Then
                If DirectCast(ctrControl, DevExpress.XtraEditors.CheckEdit).Enabled = True Then
                    DirectCast(ctrControl, DevExpress.XtraEditors.CheckEdit).Checked = True
                End If
            End If
        Next
        For Each ctrControl As System.Windows.Forms.Control In GroupEvent.Controls
            If Object.ReferenceEquals(ctrControl.[GetType](), GetType(DevExpress.XtraEditors.CheckEdit)) Then
                If DirectCast(ctrControl, DevExpress.XtraEditors.CheckEdit).Enabled = True Then
                    DirectCast(ctrControl, DevExpress.XtraEditors.CheckEdit).Checked = True
                End If
            End If
        Next
        For Each ctrControl As System.Windows.Forms.Control In GroupAction.Controls
            If Object.ReferenceEquals(ctrControl.[GetType](), GetType(DevExpress.XtraEditors.CheckEdit)) Then
                If DirectCast(ctrControl, DevExpress.XtraEditors.CheckEdit).Enabled = True Then
                    DirectCast(ctrControl, DevExpress.XtraEditors.CheckEdit).Checked = True
                End If
            End If
        Next
    End Sub

    Private Sub btnUnAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnAll.Click
        For Each ctrControl As System.Windows.Forms.Control In GroupDisplay.Controls
            If Object.ReferenceEquals(ctrControl.[GetType](), GetType(DevExpress.XtraEditors.CheckEdit)) Then
                If DirectCast(ctrControl, DevExpress.XtraEditors.CheckEdit).Enabled = True Then
                    DirectCast(ctrControl, DevExpress.XtraEditors.CheckEdit).Checked = False
                End If
            End If
        Next
        For Each ctrControl As System.Windows.Forms.Control In GroupEvent.Controls
            If Object.ReferenceEquals(ctrControl.[GetType](), GetType(DevExpress.XtraEditors.CheckEdit)) Then
                If Object.ReferenceEquals(ctrControl.[GetType](), GetType(DevExpress.XtraEditors.CheckEdit)) Then
                    DirectCast(ctrControl, DevExpress.XtraEditors.CheckEdit).Checked = False
                End If
            End If
        Next
        For Each ctrControl As System.Windows.Forms.Control In GroupAction.Controls
            If Object.ReferenceEquals(ctrControl.[GetType](), GetType(DevExpress.XtraEditors.CheckEdit)) Then
                If Object.ReferenceEquals(ctrControl.[GetType](), GetType(DevExpress.XtraEditors.CheckEdit)) Then
                    DirectCast(ctrControl, DevExpress.XtraEditors.CheckEdit).Checked = False
                End If
            End If
        Next
    End Sub



    Private Function Verify() As Boolean
        Try
            DxErrorProvider1.ClearErrors()

            If Trim(txtThai.Text) = "" Then
                SetErrorProvider(DxErrorProvider1, txtThai, "กรุณาระบุข้อมูล")
            ElseIf mcls.CheckExist() Then
                SetErrorProvider(DxErrorProvider1, txtThai, "ข้อมูลซ้ำ")
            End If
            Return DxErrorProvider1.HasErrors = False
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "frmPrevilege.Verify : " & e.Message)
        End Try
    End Function



    Private Sub SetRowData()
        Dim rowHandle As Integer
        Try
            'If lIsFormLoad = True Then Exit Sub
            If GridView.RowCount = 0 Then Exit Sub
            rowHandle = (TryCast(GridControl.MainView, ColumnView)).FocusedRowHandle


            If rowHandle < 0 Then Exit Sub
            ShowProgress(True, "Loading...")
            GridView.SetRowCellValue(rowHandle, "PrivilegeData", GetPrivilegeData())

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try

    End Sub

    Private Sub CheckVisible_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckVisible.CheckedChanged
        SetRowData()
    End Sub

    Private Sub CheckEnable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEnable.CheckedChanged
        SetRowData()
    End Sub

    Private Sub CheckAdd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckAdd.CheckedChanged
        SetRowData()
    End Sub

    Private Sub CheckEdit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit.CheckedChanged
        SetRowData()
    End Sub

    Private Sub CheckDelete_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckDelete.CheckedChanged
        SetRowData()
    End Sub

    Private Sub CheckPrint_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckPrint.CheckedChanged
        SetRowData()
    End Sub

    Private Sub CheckImport_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckImport.CheckedChanged
        SetRowData()
    End Sub

    Private Sub CheckCreateQuick_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckCreateQuick.CheckedChanged
        SetRowData()
    End Sub

    Private Sub CheckCopy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckCopy.CheckedChanged
        SetRowData()
    End Sub

    Private Sub CheckAssign_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckAssign.CheckedChanged
        SetRowData()
    End Sub

    Private Sub CheckConvert_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckConvert.CheckedChanged
        SetRowData()
    End Sub


    Private Sub frmPrivilege_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class