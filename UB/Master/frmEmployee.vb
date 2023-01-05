Option Explicit On

Imports DevExpress.XtraEditors

Public Class frmEmployee
    Inherits iEditForm
    Dim mcls As New EmployeeDAO
    Private Const mFormName As String = "frmEmployee"

#Region "Private"
    Private Sub InitialCombo()
        Try
            SetComboPrefixThai()
            SetComboPrefixEng()
            SetComboWorkingStatus()
            SetComboPosition()
            SetComboTerritory()
            SetComboEmpGroup()
            SetComboCommission()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".InitialCombo : " & e.Message)
        End Try
    End Sub
#End Region

#Region "Set combo"
    Private Sub SetComboPrefixThai()
        Try
            SetComboMaster(Title, MasterType.Prefix, True)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboPrefixThai : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboPrefixEng()
        Try
            SetComboMaster(TitleEng, MasterType.Prefix, False)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboPrefixEng : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboWorkingStatus()
        Try
            WorkingStatus.Properties.Items.Add("ทำงาน")
            WorkingStatus.Properties.Items.Add("ลาออก")
            WorkingStatus.Properties.Items.Add("พักงาน")
            WorkingStatus.Properties.Items.Add("เลิกจ้าง")
            WorkingStatus.Properties.Items.Add("เกษียณอายุ")
            WorkingStatus.Properties.Items.Add("โอนย้าย")
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboWorkingStatus : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboPosition()
        Dim lcls As New PositionDAO
        Dim dataTable As New DataTable()
        Try
            dataTable = lcls.GetDataTableForCombo(0, True)
            PositionID.Properties.DataSource = dataTable
            PositionID.Properties.DisplayMember = "NameThai"
            PositionID.Properties.ValueMember = "ID"
            PositionID.EditValue = DBNull.Value

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboPosition : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Sub

    Private Sub SetComboTerritory()
        Try
            SetLookUpTerritory(TerritoryID)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboTerritory : " & e.Message)
        Finally
        End Try
    End Sub

    Private Sub SetComboEmpGroup()
        Try
            SetComboMasterLook(cboEmpGroup, MasterType.EmpGroup)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboEmpGroup : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboCommission()
        Try
            SetLookUpCommission(CommissionID)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboCommission : " & e.Message)
        Finally
        End Try
    End Sub

#End Region



#Region "Event"
    Private Sub PositionID_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PositionID.EditValueChanged
        Dim lPositionID As Long, lcls As PositionDAO
        Try
            lPositionID = ConvertNullToZero(PositionID.GetColumnValue("ID"))
            If lPositionID > 0 Then
                lcls = New PositionDAO
                If lcls.InitailData(lPositionID) Then
                    txtDepartment.Text = lcls.Department.NameThai
                End If

                lcls = Nothing
            Else
                txtDepartment.Text = ""
            End If
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            lcls = Nothing
        End Try

    End Sub

    Private Sub btnRefreshPosition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshPosition.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboPosition()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub btnRefreshPrefix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshPrefix.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboPrefixThai()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub btnRefreshPrefixEng_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshPrefixEng.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboPrefixEng()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub btnRefreshTerritory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshTerritory.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboTerritory()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub TerritoryID_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TerritoryID.EditValueChanged
        Dim lTerritoryID As Long, lcls As TerritoryDAO
        lTerritoryID = ConvertNullToZero(TerritoryID.GetColumnValue("ID"))
        If lTerritoryID > 0 Then
            lcls = New TerritoryDAO
            If lcls.InitailData(lTerritoryID) Then
                txtDepartmenOwoner.Text = lcls.Manager.Title & lcls.Manager.FirstName & " " & lcls.Manager.LastName
            End If

            lcls = Nothing
        Else
            txtDepartmenOwoner.Text = ""
        End If
    End Sub

    Private Sub btnRefreshEmpG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshEmpG.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboEmpGroup()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub FormChangedComponent1_FormControlChanged1(ByVal sender As Object, ByVal e As FormChangedEventArgs) Handles FormChangedComponent1.FormControlChanged
        MyBase.CheckFormChanged()
    End Sub

#End Region

#Region "Private"

    Private Function LoadData(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        Dim lclsProvince As New ProvinceDAO
        Try
            If pMode = DataMode.ModeNew Then
                EmpCode.EditValue = AutoGenCode(MasterType.Employee)
                UcAddress1.InitailData(Nothing, lclsProvince.GetDataTable())

            ElseIf pMode = DataMode.ModeEdit Then
                If mcls.InitailData(pID) Then
                    EmpCode.Text = mcls.EmpCode
                    Title.Text = mcls.Title
                    Firstname.Text = mcls.FirstName
                    LastName.Text = mcls.LastName
                    TitleEng.Text = mcls.TitleEng
                    FirstnameEng.Text = mcls.FirstNameEng
                    LastNameEng.Text = mcls.LastNameEng
                    NickName.Text = mcls.NickName
                    StartDate.EditValue = mcls.StartDate
                    WorkingStatus.Text = mcls.WorkingStatus
                    PositionID.EditValue = mcls.PositionID
                    TerritoryID.EditValue = mcls.TerritoryID
                    cboEmpGroup.EditValue = mcls.EmpGroupID
                    Commission.EditValue = mcls.Commission
                    CommissionID.EditValue = mcls.CommissionID
                    Remark.Text = mcls.Remark
                    UcAdmin1.CheckInAcive.Checked = mcls.IsInActive
                    UcAdmin1.txtCreateBy.Text = mcls.CreateBy.Trim
                    UcAdmin1.txtCreateTime.Text = mcls.CreateTime
                    UcAdmin1.txtModifiBy.Text = mcls.ModifiedBy.Trim
                    UcAdmin1.txtModifiTime.Text = mcls.ModifiedTime
                    ViewLevel.SelectedIndex = mcls.ViewLevel - 1
                    ''FileAttachs
                    UcFileAttach1.ShowControl(mcls.FileAttachs)

                    ''Address
                    UcAddress1.InitailData(mcls.AddressS, lclsProvince.GetDataTable())

                    ''History
                    UcHistory1.InitailData(mcls.HistoryDAO)

                End If
            End If

            'Note
            UcNote1.ShowControl(mcls.TableName, pID)

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".LoadData : " & ex.Message)
            Return False
        Finally
            lclsProvince = Nothing
        End Try
    End Function

    Private Function Verify() As Boolean
        Dim lstrErr As String = ""
        Try
            DxErrorProvider1.ClearErrors()

            If Trim(EmpCode.Text) = "" Then
                SetErrorProvider(DxErrorProvider1, EmpCode, "กรุณาระบุรหัสพนักงาน")
            ElseIf mcls.CheckExist() Then
                SetErrorProvider(DxErrorProvider1, EmpCode, "รหัสพนักงานซ้ำ")
            End If
            lstrErr = lstrErr & DxErrorProvider1.GetError(EmpCode) & vbNewLine

            If Trim(Firstname.Text) = "" Then
                SetErrorProvider(DxErrorProvider1, Firstname, "กรุณาระบุชื่อพนักงาน")
                lstrErr = lstrErr & DxErrorProvider1.GetError(Firstname) & vbNewLine
            End If

            If GroupPrivilege.Visible = True Then
                If ConvertNullToZero(cboEmpGroup.EditValue) = 0 Then
                    SetErrorProvider(DxErrorProvider1, cboEmpGroup, "กรุณาระบุกลุ่มพนักงาน")
                    lstrErr = lstrErr & DxErrorProvider1.GetError(cboEmpGroup) & vbNewLine
                End If

                If ConvertNullToZero(ViewLevel.EditValue) <= 0 Then
                    SetErrorProvider(DxErrorProvider1, ViewLevel, "กรุณาระบุสิทธิในลูกค้า")
                    lstrErr = lstrErr & DxErrorProvider1.GetError(ViewLevel) & vbNewLine
                End If

            End If

            If ConvertNullToZero(Commission.EditValue) < 0 Then
                Commission.EditValue = 0
            ElseIf ConvertNullToZero(Commission.EditValue) > 100 Then
                Commission.EditValue = 100
            End If

            If lstrErr.Trim <> "" Then
                ShowProgress(False, "")
                lstrErr = "พบข้อผิดพลาดกรุณาตรวจสอบ : " & vbNewLine & lstrErr
                XtraMessageBox.Show(Me, lstrErr, "ตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Else
                Return True
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".Verify : " & e.Message)
        End Try
    End Function




#End Region

#Region "Overrides"
    Protected Overrides Sub OnLoadForm(ByVal pMode As Integer, ByVal pID As Long, ByVal pOrderType As Long, ByVal pclsConvert As iOrder, ByVal pCusID As Long)
        Try
            InitialCombo()
            Call LoadData(pMode, pID)
            Call SetPrivilege(pMode)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".OnLoadForm : " & e.Message)
        End Try
    End Sub

    Private Function SetPrivilege(ByVal pMode As Integer) As Boolean
        Dim lcls As New PrivilegeDAO
        Try
            If pMode = DataMode.ModeEdit Then
                If lcls.InitailData(gPrivilegeID, MasterType.ManageTeam) Then

                    GroupPrivilege.Visible = (lcls.PrivilegeData And Privilege.Visible) = Privilege.Visible
                    GroupPrivilege.Enabled = (lcls.PrivilegeData And Privilege.Enable) = Privilege.Enable

                Else
                    GroupPrivilege.Enabled = False
                End If
            Else
                GroupPrivilege.Enabled = True
                GroupPrivilege.Visible = True
            End If

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".SetPrivilege : " & ex.Message)
            Return False
        Finally
            lcls = Nothing
        End Try
    End Function

    Protected Overrides Sub ClearAllForm(ByVal pMode As Integer)
        Try
            MyBase.ClearAllForm(pMode)
            Select Case pMode
                Case DataMode.ModeNew
                    ClearForm(GeneralTabPage)
                    ClearForm(UcAdmin1)
                    UcFileAttach1.ClearControl()
                    UcAddress1.ClearControl()
                    UcNote1.ClearControl()
                    UcHistory1.ClearControl()
                    ViewLevel.SelectedIndex = 0
            End Select

            XtraTabControl1.SelectedTabPage = GeneralTabPage
            EmpCode.Select()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".ClearAllForm : " & e.Message)
        End Try

    End Sub

    Protected Overrides Function Save(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        XtraTabControl1.SelectedTabPage = GeneralTabPage
        Try
            mcls.ID = pID
            mcls.ModeData = pMode
            mcls.EmpCode = EmpCode.Text.Trim
            mcls.Title = Title.Text.Trim
            mcls.FirstName = Firstname.Text.Trim
            mcls.LastName = LastName.Text.Trim
            mcls.TitleEng = TitleEng.Text.Trim
            mcls.FirstNameEng = FirstnameEng.Text.Trim
            mcls.LastNameEng = LastNameEng.Text.Trim
            mcls.NickName = NickName.Text.Trim
            mcls.StartDate = StartDate.EditValue
            mcls.WorkingStatus = WorkingStatus.Text.Trim
            mcls.ViewLevel = ConvertNullToZero(ViewLevel.SelectedIndex + 1)
            mcls.PositionID = ConvertNullToZero(PositionID.GetColumnValue("ID"))
            mcls.TerritoryID = ConvertNullToZero(TerritoryID.GetColumnValue("ID"))
            mcls.EmpGroupID = ConvertNullToZero(cboEmpGroup.GetColumnValue("ID"))
            mcls.Remark = Remark.Text.Trim
            mcls.IsInActive = UcAdmin1.CheckInAcive.Checked
            mcls.Commission = ConvertNullToZero(Commission.EditValue)
            mcls.CommissionID = ConvertNullToZero(CommissionID.EditValue)
            mcls.NoteDAOs = UcNote1.GetNoteDAOs
            mcls.FileAttachs = UcFileAttach1.GetFileAttachs
            mcls.AddressS = UcAddress1.GetAddressDAO
            mcls.HistoryDAO = UcHistory1.GetDAO
            If Verify() = True Then
                Return mcls.SaveData()
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



    Private Sub btnGenID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenID.Click
        Try
            ShowProgress(True, "Loading...")
            EmpCode.EditValue = AutoGenCode(MasterType.Employee)
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try

    End Sub

    Private Sub btnRefreshCommissionID_Click(sender As Object, e As EventArgs) Handles btnRefreshCommissionID.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboCommission()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub
End Class
