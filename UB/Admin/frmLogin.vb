Imports System.Deployment.Application

Public Class frmLogin

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        gCompanyID = 1
        UpdateConfiger()
        Try
            If txtLogin.Text.Trim = "" Then
                SetErrorProvider(DxErrorProvider1, txtLogin, "กรุณาระบุข้อมูล")
                Exit Sub
            Else
                SetErrorProvider(DxErrorProvider1, txtLogin, "")
            End If

            If txtPassword.Text.Trim = "" Then
                SetErrorProvider(DxErrorProvider1, txtPassword, "กรุณาระบุข้อมูล")
                Exit Sub
            Else
                SetErrorProvider(DxErrorProvider1, txtPassword, "")
            End If
            Cursor = Cursors.WaitCursor
            Dim lResult As String = gConnection.TestConnection
            If lResult = "" Then
                chSetup.Checked = False

                If VerifyUser() Then
                    VerifyEmployee()
                    VerifyApproveUser()
                    AppConfigFileSettings.UpdateAppSettings("LastLogin", txtLogin.Text)
                    Call InsertActivity(DataMode.ModeLogIn, 0, "", Nothing)


                    'frmImport.MasterTypes = MasterType.Accounts
                    'frmImport.Show()

                    frmSelectCompany.ShowDialog()
                    Me.Hide()
                    VerifyCompany()
                    VerifyShippingNotifi()
                    frmMain.Show()
                    ''PrintTaxAtPay(5)
                End If

            Else
                txtResult.Text = "ไม่สามารถติดต่อฐานข้อมูลได้ :" & Microsoft.VisualBasic.Constants.vbCrLf & lResult
                chSetup.Checked = True
            End If

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            Cursor = Cursors.Default
        End Try

    End Sub



    Private Function VerifyUser() As Boolean
        VerifyUser = False
        Try
            Dim lcls As New UserDAO
            If lcls.InitailData(False, 0, txtLogin.Text) Then
                If lcls.IsInActive = True Then
                    SetErrorProvider(DxErrorProvider1, txtLogin, "ผู้ใช้งานนี้ถูกระงับการใช้งาน")
                ElseIf lcls.Password.Trim <> txtPassword.Text.Trim Then
                    gUserID = lcls.ID
                    SetErrorProvider(DxErrorProvider1, txtPassword, "รหัสไม่ถูกต้อง")
                    InsertActivity(DataMode.ModeLogIn, 0, "ระบุรหัสผิด", Nothing)
                Else
                    gUserID = lcls.ID
                    gPrivilegeID = lcls.PrivilegeID
                    gUserName = lcls.UserName
                    gEmpID = lcls.EmpID
                    VerifyUser = True
                    SetErrorProvider(DxErrorProvider1, txtLogin, "")
                    SetErrorProvider(DxErrorProvider1, txtPassword, "")
                End If
            Else
                SetErrorProvider(DxErrorProvider1, txtLogin, "ไม่พบผู้ใช้งาน")
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "frmLogin.VerifyUser : " & e.Message)
        End Try

    End Function

    Private Function VerifyEmployee() As Boolean
        VerifyEmployee = False
        Try
            Dim lcls As New EmployeeDAO
            If lcls.InitailData(gEmpID) Then
                gEmpName = lcls.Title & lcls.FirstName & " " & lcls.LastName
                gTerritoryID = lcls.TerritoryID
                gViewLevel = lcls.ViewLevel
                VerifyEmployee = True
            Else
                gEmpName = ""
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "frmLogin.VerifyEmployee : " & e.Message)
        End Try
    End Function




    Private Sub UpdateConfiger()
        gDBServerName = DBServerName.Text
        gDatabaseName = DatabaseName.Text
        gDBUser = txtDBUser.Text
        gDBPass = txtDBPass.Text
        AppConfigFileSettings.UpdateAppSettings("DBServerName", gDBServerName)
        AppConfigFileSettings.UpdateAppSettings("DatabaseName", gDatabaseName)
        AppConfigFileSettings.UpdateAppSettings("DatabaseUserID", gDBUser)
        AppConfigFileSettings.UpdateAppSettings("DatabasePwd", gDBPass)
        AppConfigFileSettings.LoadAppSettings()
        gConString = "server=" & gDBServerName & ";database=" & gDatabaseName & ";uid=" & gDBUser & ";pwd=" & gDBPass & ";application name=BS stress utility"
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NavBarGroup1.Expanded = False

        If gLastLogin = "" Then
        Else
            txtLogin.Text = gLastLogin
            txtPassword.Select()
        End If

        DBServerName.Text = gDBServerName
        DatabaseName.Text = gDatabaseName
        txtDBUser.Text = gDBUser
        txtDBPass.Text = gDBPass

        If (ApplicationDeployment.IsNetworkDeployed) Then
            Me.Text = "Login : V." & ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString
        Else
            Me.Text = "Login : V." & Application.ProductVersion
            txtPassword.Text = "admin"
        End If

        frmSplash.Hide()
        'PrintReportOrder(MasterType.Quotation, 11)
        'Try
        '    Dim lResult As String = gConnection.TestConnection
        '    If lResult = "" Then
        '        chSetup.Checked = False
        '    Else
        '        txtResult.Text = lResult
        '        chSetup.Checked = True
        '    End If

        'Catch ex As Exception
        '    ShowErrorMsg(False, ex.Message)
        'End Try
    End Sub


    Private Sub NavBarGroup1_ItemChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NavBarGroup1.ItemChanged
        If NavBarGroup1.Expanded = True Then
            Me.Height = 364

        Else
            Me.Height = 214
        End If
    End Sub

    Private Sub chSetup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chSetup.CheckedChanged
        NavBarGroup1.Expanded = chSetup.Checked
        'If chSetup.Checked = True Then
        '    Me.Height = 364
        'Else
        '    Me.Height = 214
        'End If
    End Sub

End Class