Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Public Class rptInvoiceOwn



    Private Sub XrLabel6_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles XrLabel6.PrintOnPage
        XrLabel6.Visible = gShowDateReport
    End Sub



    'Private Sub PanelTotal_PrintOnPage(sender As Object, e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles PanelTotal.PrintOnPage
    '    If e.PageCount - 1 = e.PageIndex Then
    '        PanelTotal.Visible = True
    '    Else
    '        PanelTotal.Visible = False
    '    End If
    'End Sub

    'Private Sub PageFooterSubBand1_PrintOnPage(sender As Object, e As PrintOnPageEventArgs) Handles PageFooterSubBand1.PrintOnPage
    '    If e.PageCount - 1 = e.PageIndex Then
    '        PageFooterSubBand1.Visible = False
    '    Else
    '        PageFooterSubBand1.Visible = True
    '    End If
    'End Sub

    'Private Sub PageFooterSubBand2_PrintOnPage(sender As Object, e As PrintOnPageEventArgs) Handles PageFooterSubBand2.PrintOnPage
    '    If e.PageCount - 1 = e.PageIndex Then
    '        PageFooterSubBand2.Visible = True
    '    Else
    '        PageFooterSubBand2.Visible = False
    '    End If
    'End Sub

    'Private Sub PanelSub_PrintOnPage(sender As Object, e As PrintOnPageEventArgs)
    '    If e.PageCount - 1 = e.PageIndex Then
    '        PanelSub.Visible = False
    '    Else
    '        PanelSub.Visible = True
    '    End If
    'End Sub
End Class