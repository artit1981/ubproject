﻿Public Class rptShipingReport


    Private Sub XrLabel10_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel10.PrintOnPage
        If e.PageCount - 1 = e.PageIndex Then
            XrLabel10.Visible = True
        Else
            XrLabel10.Visible = False
        End If
    End Sub



    Private Sub XrLabel6_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel6.PrintOnPage
        XrLabel6.Visible = gShowDateReport
    End Sub
End Class