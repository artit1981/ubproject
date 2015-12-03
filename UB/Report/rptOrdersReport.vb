Public Class rptOrdersReport

     
    Private Sub XrLabel10_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel10.PrintOnPage
        If e.PageCount - 1 = e.PageIndex Then
            XrLabel10.Visible = True
        Else
            XrLabel10.Visible = False
        End If
    End Sub

    Private Sub XrLabel16_PrintOnPage(sender As Object, e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel16.PrintOnPage
        If e.PageCount - 1 = e.PageIndex Then
            XrLabel16.Visible = True
        Else
            XrLabel16.Visible = False
        End If
    End Sub

    Private Sub XrLabel17_PrintOnPage(sender As Object, e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel17.PrintOnPage
        If e.PageCount - 1 = e.PageIndex Then
            XrLabel17.Visible = True
        Else
            XrLabel17.Visible = False
        End If
    End Sub

    Private Sub XrLabel18_PrintOnPage(sender As Object, e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel18.PrintOnPage
        If e.PageCount - 1 = e.PageIndex Then
            XrLabel18.Visible = True
        Else
            XrLabel18.Visible = False
        End If
    End Sub

    Private Sub XrLabel19_PrintOnPage(sender As Object, e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel19.PrintOnPage
        If e.PageCount - 1 = e.PageIndex Then
            XrLabel19.Visible = True
        Else
            XrLabel19.Visible = False
        End If

    End Sub

    Private Sub XrLabel20_PrintOnPage(sender As Object, e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel20.PrintOnPage
        If e.PageCount - 1 = e.PageIndex Then
            XrLabel20.Visible = True
        Else
            XrLabel20.Visible = False
        End If
    End Sub

    Private Sub XrLabel26_PrintOnPage(sender As Object, e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel26.PrintOnPage
        If e.PageCount - 1 = e.PageIndex Then
            XrLabel26.Visible = True
        Else
            XrLabel26.Visible = False
        End If
    End Sub


    Private Sub XrLabel27_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel27.PrintOnPage
        If e.PageCount - 1 = e.PageIndex Then
            XrLabel27.Visible = True
        Else
            XrLabel27.Visible = False
        End If
    End Sub

    Private Sub XrLabel28_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel28.PrintOnPage
        If e.PageCount - 1 = e.PageIndex Then
            XrLabel28.Visible = True
        Else
            XrLabel28.Visible = False
        End If
    End Sub

    Private Sub XrLabel6_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel6.PrintOnPage
        XrLabel6.Visible = gShowDateReport

    End Sub

    Private Sub XrLabel23_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel23.PrintOnPage

        XrLabel23.Visible = gShowDateReport
    End Sub

    Private Sub XrLabel74_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel74.PrintOnPage
        If XrLabel29.Text = "" Then
            XrLabel74.Visible = False
        Else
            XrLabel74.Visible = True
        End If
    End Sub
End Class