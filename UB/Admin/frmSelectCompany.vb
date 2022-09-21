Imports DevExpress.XtraEditors.Controls

Public Class frmSelectCompany

    Private Sub frmSelectCompany_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim lcls As New CompanyDAO
        Dim dataTable As New DataTable()

        Try
            rdoCompany.Properties.Items.Clear()
            dataTable = lcls.GetDataTable(0, True)
            If dataTable.Rows.Count = 1 Then
                Me.Close()
            Else
                For Each pRow As DataRow In dataTable.Rows
                    rdoCompany.Properties.Items.Add(New RadioGroupItem(pRow.Item("ID"), pRow.Item("CompanyName").ToString.Trim))
                Next
                rdoCompany.SelectedIndex = 0
            End If

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally

        End Try

    End Sub

    Private Sub SelectClose()
        Try
            gCompanyID = rdoCompany.EditValue
            Me.Close()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally

        End Try

    End Sub

    Private Sub rdoCompany_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rdoCompany.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            SelectClose()
        End If
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        SelectClose()
    End Sub
End Class