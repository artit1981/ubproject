Public Class rptQuotation


    Private Sub XrLabel6_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel6.PrintOnPage
        XrLabel6.Visible = gShowDateReport
        XrLabel55.Visible = gShowDateReport
        XrLabel53.Visible = gShowDateReport
    End Sub

    Private Sub XrLabel55_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel55.PrintOnPage

        XrLabel55.Visible = gShowDateReport

    End Sub

    Private Sub XrLabel53_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel53.PrintOnPage

        XrLabel53.Visible = gShowDateReport
    End Sub
    'Private Sub XrLabel10_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel10.PrintOnPage
    '    If e.PageCount - 1 = e.PageIndex Then
    '        XrLabel10.Visible = True
    '    Else
    '        XrLabel10.Visible = False
    '    End If
    'End Sub

    'Private Sub XrLabel16_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel16.PrintOnPage
    '    If e.PageCount - 1 = e.PageIndex Then
    '        XrLabel16.Visible = True
    '    Else
    '        XrLabel16.Visible = False
    '    End If
    'End Sub

    'Private Sub XrLabel17_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel17.PrintOnPage
    '    If e.PageCount - 1 = e.PageIndex Then
    '        XrLabel17.Visible = True
    '    Else
    '        XrLabel17.Visible = False
    '    End If
    'End Sub

    'Private Sub XrLabel18_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel18.PrintOnPage
    '    If e.PageCount - 1 = e.PageIndex Then
    '        XrLabel18.Visible = True
    '    Else
    '        XrLabel18.Visible = False
    '    End If
    'End Sub

    'Private Sub XrLabel19_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel19.PrintOnPage
    '    If e.PageCount - 1 = e.PageIndex Then
    '        XrLabel19.Visible = True
    '    Else
    '        XrLabel19.Visible = False
    '    End If
    'End Sub

    'Private Sub XrLabel20_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel20.PrintOnPage
    '    If e.PageCount - 1 = e.PageIndex Then
    '        XrLabel20.Visible = True
    '    Else
    '        XrLabel20.Visible = False
    '    End If
    'End Sub
    'Private Sub XrLabel60_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel60.PrintOnPage
    '    If e.PageCount - 1 = e.PageIndex Then
    '        XrLabel60.Visible = True
    '    Else
    '        XrLabel60.Visible = False
    '    End If
    'End Sub
    'Private Sub XrLabel61_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel61.PrintOnPage
    '    If e.PageCount - 1 = e.PageIndex Then
    '        XrLabel61.Visible = True
    '    Else
    '        XrLabel61.Visible = False
    '    End If
    'End Sub
    'Private Sub XrLabel62_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel62.PrintOnPage
    '    If e.PageCount - 1 = e.PageIndex Then
    '        XrLabel62.Visible = True
    '    Else
    '        XrLabel62.Visible = False
    '    End If
    'End Sub
    'Private Sub XrLabel63_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel63.PrintOnPage
    '    If e.PageCount - 1 = e.PageIndex Then
    '        XrLabel63.Visible = True
    '    Else
    '        XrLabel63.Visible = False
    '    End If
    'End Sub
    'Private Sub XrLabel64_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel64.PrintOnPage
    '    If e.PageCount - 1 = e.PageIndex Then
    '        XrLabel64.Visible = True
    '    Else
    '        XrLabel64.Visible = False
    '    End If
    'End Sub
    'Private Sub XrLabel65_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel65.PrintOnPage
    '    If e.PageCount - 1 = e.PageIndex Then
    '        XrLabel65.Visible = True
    '    Else
    '        XrLabel65.Visible = False
    '    End If
    'End Sub
    'Private Sub XrLabel66_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel66.PrintOnPage
    '    If e.PageCount - 1 = e.PageIndex Then
    '        XrLabel66.Visible = True
    '    Else
    '        XrLabel66.Visible = False
    '    End If
    'End Sub
    'Private Sub XrLabel67_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel67.PrintOnPage
    '    If e.PageCount - 1 = e.PageIndex Then
    '        XrLabel67.Visible = True
    '    Else
    '        XrLabel67.Visible = False
    '    End If
    'End Sub
    'Private Sub XrLabel68_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel68.PrintOnPage
    '    If e.PageCount - 1 = e.PageIndex Then
    '        XrLabel68.Visible = True
    '    Else
    '        XrLabel68.Visible = False
    '    End If
    'End Sub
    'Private Sub XrLabel69_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel69.PrintOnPage
    '    If e.PageCount - 1 = e.PageIndex Then
    '        XrLabel69.Visible = True
    '    Else
    '        XrLabel69.Visible = False
    '    End If
    'End Sub
    'Private Sub XrLabel70_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel70.PrintOnPage
    '    If e.PageCount - 1 = e.PageIndex Then
    '        XrLabel70.Visible = True
    '    Else
    '        XrLabel70.Visible = False
    '    End If
    'End Sub
    'Private Sub XrLabel71_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel71.PrintOnPage
    '    If e.PageCount - 1 = e.PageIndex Then
    '        XrLabel71.Visible = True
    '    Else
    '        XrLabel71.Visible = False
    '    End If
    'End Sub
    'Private Sub XrLabel72_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel72.PrintOnPage
    '    If e.PageCount - 1 = e.PageIndex Then
    '        XrLabel72.Visible = True
    '    Else
    '        XrLabel72.Visible = False
    '    End If
    'End Sub
    'Private Sub XrLabel73_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel73.PrintOnPage
    '    If e.PageCount - 1 = e.PageIndex Then
    '        XrLabel73.Visible = True
    '    Else
    '        XrLabel73.Visible = False
    '    End If
    'End Sub
    'Private Sub XrShape5_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrShape5.PrintOnPage
    '    If e.PageCount - 1 = e.PageIndex Then
    '        XrShape5.Visible = True
    '    Else
    '        XrShape5.Visible = False
    '    End If
    'End Sub
    'Private Sub XrShape6_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrShape6.PrintOnPage
    '    If e.PageCount - 1 = e.PageIndex Then
    '        XrShape6.Visible = True
    '    Else
    '        XrShape6.Visible = False
    '    End If
    'End Sub
    'Private Sub XrLine7_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLine7.PrintOnPage
    '    If e.PageCount - 1 = e.PageIndex Then
    '        XrLine7.Visible = True
    '    Else
    '        XrLine7.Visible = False
    '    End If
    'End Sub
    'Private Sub XrLine8_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLine8.PrintOnPage
    '    If e.PageCount - 1 = e.PageIndex Then
    '        XrLine8.Visible = True
    '    Else
    '        XrLine8.Visible = False
    '    End If
    'End Sub
    'Private Sub XrLine9_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLine9.PrintOnPage
    '    If e.PageCount - 1 = e.PageIndex Then
    '        XrLine9.Visible = True
    '    Else
    '        XrLine9.Visible = False
    '    End If
    'End Sub
    'Private Sub XrLine10_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLine10.PrintOnPage
    '    If e.PageCount - 1 = e.PageIndex Then
    '        XrLine10.Visible = True
    '    Else
    '        XrLine10.Visible = False
    '    End If
    'End Sub
    'Private Sub XrLine11_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLine11.PrintOnPage
    '    If e.PageCount - 1 = e.PageIndex Then
    '        XrLine11.Visible = True
    '    Else
    '        XrLine11.Visible = False
    '    End If
    'End Sub
    'Private Sub XrLine12_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLine12.PrintOnPage
    '    If e.PageCount - 1 = e.PageIndex Then
    '        XrLine12.Visible = True
    '    Else
    '        XrLine12.Visible = False
    '    End If
    'End Sub
    'Private Sub XrShape4_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrShape4.PrintOnPage
    '    If e.PageCount - 1 = e.PageIndex Then
    '        XrShape4.Visible = True
    '    Else
    '        XrShape4.Visible = False
    '    End If
    'End Sub

    Private Sub XrShape7_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrShape7.PrintOnPage
        If e.PageCount - 1 = e.PageIndex Then
            XrShape7.Visible = False
        Else
            XrShape7.Visible = True
        End If
    End Sub
End Class