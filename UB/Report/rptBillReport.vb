Public Class rptBillReport

    Private Sub XrLabel13_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel13.PrintOnPage
        XrLabel13.Visible = gShowDateReport
    End Sub
End Class