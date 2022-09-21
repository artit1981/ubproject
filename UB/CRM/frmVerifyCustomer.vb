Public Class frmVerifyCustomer



    Private Sub frmVerifyCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            With Me
                .Text = "Verify Customer"
                .MdiParent = frmMain

                Call LoadDataLead()
                Call LoadDataContact()
                Call LoadDataAccount()
                Call InitialFilterCon(cboFindLead, FilterBy.Company + FilterBy.EmpName + FilterBy.Name + FilterBy.Subject)  'Call Global function
                Call InitialFilterCon(cboFindContact, FilterBy.Company + FilterBy.EmpName + FilterBy.Name + FilterBy.Code)  'Call Global function
                Call InitialFilterCon(cboFindAccount, FilterBy.Company + FilterBy.EmpName + FilterBy.Rate + FilterBy.Code) 'Call Global function

            End With

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try
    End Sub

    Private Sub LoadDataLead()
        Dim lcls As New CustomerDAO
        Dim dataTable As New DataTable()

        Try
            lcls.TableID = MasterType.Lead
            dataTable = lcls.GetDataTable(0, False)

            If dataTable.Rows.Count > 0 Then
                GridControl1.DataSource = dataTable
                GridView1.ViewCaption = "Leads"
                Call GridStyleLead()
            Else
                GridControl1.DataSource = Nothing
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "frmVerifyCustomer.LoadData : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Sub

    Private Sub GridStyleLead()
        With GridView1

            .Columns("ID").Width = 0
            .Columns("ID").Caption = "รหัส"
            .Columns("ID").Visible = False
            .Columns("Subject").Caption = "หัวเรื่อง"
            .Columns("Subject").Width = 300
            .Columns("NAME").Caption = "ชื่อ - นามสกุล"
            .Columns("NAME").Width = 250
            .Columns("CompanyName").Caption = "ชื่อบริษัท"
            .Columns("CompanyName").Width = 250
            .Columns("Rating").Caption = "ระดับความสนใจ"
            .Columns("Rating").Width = 150
            .Columns("LeadStatus").Caption = "สถานะ"
            .Columns("LeadStatus").Width = 150
            .Columns("LeadStatus").Visible = False
            .Columns("IsQuick").Caption = "Is Quick"
            .Columns("IsQuick").Width = 100
            .Columns("IsQuick").Visible = False
            .Columns("EMPNAME").Caption = "ผู้รับผิดชอบ"
            .Columns("EMPNAME").Width = 250
            .Columns("EMPNAME").Visible = False
            .Columns("ModifiedTime").Caption = "แก้ไขล่าสุด"
            .Columns("ModifiedTime").Width = 200
            .Columns("ModifiedTime").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            '.Columns("ModifiedTime").Visible = False
            .Columns("Phone1").Caption = "โทรศัพท์"
            .Columns("Phone1").Width = 100
            .Columns("Fax").Caption = "โทรสาร"
            .Columns("Fax").Width = 100
            .Columns("Email1").Caption = "อีเมล์"
            .Columns("Email1").Width = 100
        End With
    End Sub

    Private Sub LoadDataContact()
        Dim lcls As New CustomerDAO
        Dim dataTable As New DataTable()
        Try
            lcls.TableID = MasterType.Contacts
            dataTable = lcls.GetDataTable(0, False)
            If dataTable.Rows.Count > 0 Then
                GridControl2.DataSource = dataTable
                GridView2.ViewCaption = "Contacts"
                Call GridStyleContact()
            Else
                GridControl2.DataSource = Nothing
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "frmVerifyCustomer.LoadDataContact : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Sub

    Private Sub GridStyleContact()
        With GridView2
            .Columns("ID").Width = 0
            .Columns("ID").Caption = "รหัส"
            .Columns("ID").Visible = False
            .Columns("Code").Caption = "รหัสลูกค้า"
            .Columns("Code").Width = 300
            .Columns("NAME").Caption = "ชื่อ - นามสกุล"
            .Columns("NAME").Width = 250
            .Columns("CompanyName").Caption = "ชื่อบริษัท"
            .Columns("CompanyName").Width = 250
            .Columns("IsQuick").Caption = "Is Quick"
            .Columns("IsQuick").Width = 100
            .Columns("EMPNAME").Caption = "ผู้รับผิดชอบ"
            .Columns("EMPNAME").Width = 250
            .Columns("ModifiedTime").Caption = "แก้ไขล่าสุด"
            .Columns("ModifiedTime").Width = 150
            .Columns("ModifiedTime").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            .Columns("Phone1").Caption = "โทรศัพท์"
            .Columns("Phone1").Width = 100
            .Columns("Fax").Caption = "โทรสาร"
            .Columns("Fax").Width = 100
            .Columns("Email1").Caption = "อีเมล์"
            .Columns("Email1").Width = 100
        End With
    End Sub

    Private Sub LoadDataAccount()
        Dim lcls As New CustomerDAO
        Dim dataTable As New DataTable()

        Try
            lcls.TableID = MasterType.Accounts
            dataTable = lcls.GetDataTable(0, False)

            If dataTable.Rows.Count > 0 Then
                GridControl3.DataSource = dataTable
                GridView3.ViewCaption = "Accounts"
                Call GridStyleAccount()
            Else
                GridControl3.DataSource = Nothing
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "frmVerifyCustomer.LoadDataAccount : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Sub

    Private Sub GridStyleAccount()
        With GridView3
            .Columns("ID").Width = 0
            .Columns("ID").Caption = "รหัส"
            .Columns("ID").Visible = False
            .Columns("Code").Caption = "รหัส"
            .Columns("Code").Width = 300
            .Columns("CompanyName").Caption = "ชื่อบริษัท"
            .Columns("CompanyName").Width = 250
            .Columns("Rating").Caption = "ระดับความสนใจ"
            .Columns("Rating").Width = 100
            '.Columns("OWNER").Caption = "ผู้ติดต่อ"
            '.Columns("OWNER").Width = 250
            .Columns("IsQuick").Caption = "Is Quick"
            .Columns("IsQuick").Width = 100
            .Columns("EMPNAME").Caption = "ผู้รับผิดชอบ"
            .Columns("EMPNAME").Width = 250
            .Columns("ModifiedTime").Caption = "แก้ไขล่าสุด"
            .Columns("ModifiedTime").Width = 150
            .Columns("ModifiedTime").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            .Columns("Phone1").Caption = "โทรศัพท์"
            .Columns("Phone1").Width = 100
            .Columns("Fax").Caption = "โทรสาร"
            .Columns("Fax").Width = 100
            .Columns("Email1").Caption = "อีเมล์"
            .Columns("Email1").Width = 100
        End With
    End Sub

    Private Sub RefreshFindLead()
        Try
            Dim lstrCon As String = InitialFilterMapping(cboFindLead.SelectedItem)  'Call Global function            
            GridView1.OptionsFind.FindFilterColumns = lstrCon
            GridView1.ApplyFindFilter(String.Empty)
            GridView1.ApplyFindFilter(txtFindLead.Text)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "frmVerifyCustomer.RefreshFindLead : " & ex.Message)
        End Try
    End Sub

    Private Sub RefreshFindContact()
        Try
            Dim lstrCon As String = InitialFilterMapping(cboFindContact.SelectedItem)  'Call Global function   
            GridView2.OptionsFind.FindFilterColumns = lstrCon
            GridView2.ApplyFindFilter(String.Empty)
            GridView2.ApplyFindFilter(txtFindContract.Text)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "frmVerifyCustomer.RefreshFindContact : " & ex.Message)
        End Try
    End Sub

    Private Sub RefreshFindAccount()
        Try
            Dim lstrCon As String = InitialFilterMapping(cboFindAccount.SelectedItem)  'Call Global function   
            GridView3.OptionsFind.FindFilterColumns = lstrCon
            GridView3.ApplyFindFilter(String.Empty)
            GridView3.ApplyFindFilter(txtFindAccount.Text)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "frmVerifyCustomer.RefreshFindAccount : " & ex.Message)
        End Try
    End Sub


    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Try
            RefreshFindLead()
            RefreshFindContact()
            RefreshFindAccount()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try
    End Sub

    Private Sub btnClearAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearAll.Click
        Try
            'Lead
            txtFindLead.Text = ""
            cboFindLead.SelectedIndex = 0
            RefreshFindLead()

            'Contact
            txtFindContract.Text = ""
            cboFindContact.SelectedIndex = 0
            RefreshFindContact()

            'Account
            txtFindAccount.Text = ""
            cboFindAccount.SelectedIndex = 0
            RefreshFindAccount()

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try
    End Sub

    Private Sub frmVerifyCustomer_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class