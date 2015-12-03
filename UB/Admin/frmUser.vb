Option Explicit On

Imports DevExpress.XtraEditors

Public Class frmUser
    Inherits iEditForm
    Private Const mFormName As String = "frmUser"
    Dim mcls As New UserDAO



#Region "Overrides"
    Protected Overrides Sub OnLoadForm(ByVal pMode As Integer, ByVal pID As Long, ByVal pOrderType As Long, ByVal pclsConvert As iOrder, ByVal pCusID As Long)
        Try
            InitialCombo()
            Call LoadData(pMode, pID)

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".OnLoadForm : " & e.Message)
        End Try
    End Sub

    Protected Overrides Sub ClearAllForm(ByVal pMode As Integer)
        Try
            MyBase.ClearAllForm(pMode)
            Select Case pMode
                Case DataMode.ModeNew
                    ClearForm(GeneralTabPage)
                    UcFileAttach1.ClearControl()
                    UcNote1.ClearControl()
            End Select

            XtraTabControl1.SelectedTabPage = GeneralTabPage
            UserName.Select()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".ClearAllForm : " & e.Message)
        End Try

    End Sub

    Protected Overrides Function Save(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        XtraTabControl1.SelectedTabPage = GeneralTabPage
        Try
            mcls.ID = pID
            mcls.ModeData = pMode
            mcls.UserName = UserName.Text.Trim
            mcls.Password = Password.Text.Trim

            mcls.EmpID = ConvertNullToZero(EmpID.EditValue)
            mcls.PrivilegeID = ConvertNullToZero(PrivilegeID.GetColumnValue("ID"))

            mcls.Remark = Remark.Text.Trim
            mcls.IsInActive = CheckInAcive.Checked

            mcls.NoteDAOs = UcNote1.GetNoteDAOs
            mcls.FileAttachs = UcFileAttach1.GetFileAttachs

            If Verify() = True Then
                Return mcls.SaveData()
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


#Region "Private"
    Private Sub InitialCombo()
        Try
            SetComboEmployee()
            SetComboPrivilege()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".InitialCombo : " & e.Message)
        End Try
    End Sub
#End Region

#Region "Set combo"
    Private Sub SetComboEmployee()
        Dim lcls As New EmployeeDAO
        Dim dataTable As New DataTable()
        Try
            dataTable = lcls.GetDataTableForCombo(0, True)
            EmpID.Properties.DataSource = dataTable
            EmpID.Properties.DisplayMember = "EmpCode"
            EmpID.Properties.ValueMember = "ID"
            EmpID.EditValue = DBNull.Value

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboEmployee : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Sub

    Private Sub SetComboPrivilege()
        Dim lcls As New PrivilegeDAO
        Dim dataTable As New DataTable()
        Try
            dataTable = lcls.GetDataTable(0, True)
            PrivilegeID.Properties.DataSource = dataTable
            PrivilegeID.Properties.DisplayMember = "PrivilegeCode"
            PrivilegeID.Properties.ValueMember = "ID"
            PrivilegeID.EditValue = DBNull.Value

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboPrivilege : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Sub

    Private Function LoadData(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        Try
            If pMode = DataMode.ModeEdit Then
                If mcls.InitailData(True, pID, "") Then
                    UserName.Text = mcls.UserName
                    Password.Text = mcls.Password
                    Password_Confirm.Text = mcls.Password
                    EmpID.EditValue = mcls.EmpID
                    PrivilegeID.EditValue = mcls.PrivilegeID

                    Remark.Text = mcls.Remark
                    CheckInAcive.Checked = mcls.IsInActive


                    If mcls.EmployeeDAO Is Nothing Then
                        EmpployeeName.Text = ""
                    Else
                        EmpployeeName.Text = mcls.EmployeeDAO.Title & mcls.EmployeeDAO.FirstName & " " & mcls.EmployeeDAO.LastName
                    End If

                    ''FileAttachs
                    UcFileAttach1.ShowControl(mcls.FileAttachs)
                    UcNote1.ShowControl(mcls.TableName, pID)
                End If
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".LoadData : " & ex.Message)
            Return False
        End Try
    End Function




    Private Function Verify() As Boolean
        DxErrorProvider1.ClearErrors()
        Try

            If Trim(UserName.Text) = "" Then
                SetErrorProvider(DxErrorProvider1, UserName, "กรุณาระบุข้อมูล")
            ElseIf mcls.CheckExist() Then
                SetErrorProvider(DxErrorProvider1, UserName, "ข้อมูลซ้ำ")
            End If

            If Trim(Password.Text) = "" Then
                SetErrorProvider(DxErrorProvider1, Password, "กรุณาระบุข้อมูล")
            ElseIf Trim(Password.Text) <> Trim(Password_Confirm.Text) Then
                SetErrorProvider(DxErrorProvider1, Password, "ยืนยันรหัสผ่านไม่ถูกต้อง")
            End If
            If ConvertNullToZero(EmpID.EditValue) = 0 Then
                SetErrorProvider(DxErrorProvider1, EmpID, "กรุณาระบุข้อมูล")
            End If
            If ConvertNullToZero(PrivilegeID.EditValue) = 0 Then
                SetErrorProvider(DxErrorProvider1, PrivilegeID, "กรุณาระบุข้อมูล")
            End If
            Return DxErrorProvider1.HasErrors = False
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".Verify : " & e.Message)
        End Try

    End Function

#End Region


    Private Sub btnRefreshEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshEmp.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboEmployee()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub btnRefreshPrivilege_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshPrivilege.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboPrivilege()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub EmpID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpID.EditValueChanged
        Try
            Dim lID As Long, lcls As EmployeeDAO
            lID = ConvertNullToZero(EmpID.EditValue)
            If lID > 0 Then
                lcls = New EmployeeDAO
                If lcls.InitailData(lID) Then
                    EmpployeeName.Text = lcls.Title & lcls.FirstName & " " & lcls.LastName
                End If

                lcls = Nothing
            Else
                EmpployeeName.Text = ""
            End If
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub FormChangedComponent1_FormControlChanged1(ByVal sender As Object, ByVal e As FormChangedEventArgs) Handles FormChangedComponent1.FormControlChanged
        MyBase.CheckFormChanged()
    End Sub
End Class