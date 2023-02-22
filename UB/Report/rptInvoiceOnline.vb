Public Class rptInvoiceOnline



    Private Sub XrLabel6_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel6.PrintOnPage
        XrLabel6.Visible = gShowDateReport
    End Sub

    Private Sub PanelTotal_PrintOnPage(sender As Object, e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles PanelTotal.PrintOnPage
        If e.PageCount - 1 = e.PageIndex Then
            PanelTotal.Visible = True
        Else
            PanelTotal.Visible = False
        End If
    End Sub
End Class