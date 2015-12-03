Public Class rptReceipt

    Private Sub XrLabel6_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel6.PrintOnPage
        XrLabel6.Visible = gShowDateReport
    End Sub
End Class