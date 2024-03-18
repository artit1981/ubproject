Public Class rptReceipt

    Private Sub XrLabel6_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel6.PrintOnPage
        XrLabel6.Visible = gShowDateReport
    End Sub

    Private Sub XrLabel9_PrintOnPage(sender As Object, e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel9.PrintOnPage
        XrLabel9.Visible = gShowDateReport
    End Sub

    Private Sub XrLabel10_PrintOnPage(sender As Object, e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel10.PrintOnPage
        XrLabel10.Visible = gShowDateReport
    End Sub
End Class