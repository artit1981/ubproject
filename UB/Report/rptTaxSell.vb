Public Class rptTaxSell

    Private Sub IsMainCompany_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles IsMainCompany.PrintOnPage
        If IsMainCompany.Text = 0 Then
            IsMainCompany.Visible = False
        Else
            IsMainCompany.Visible = True
        End If
    End Sub

    Private Sub IsMain_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles IsMain.PrintOnPage
        If IsMainCompany.Text = 0 Then
            IsMain.Visible = True
        Else
            IsMain.Visible = False
        End If
    End Sub

    Private Sub IsNotMain_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles IsNotMain.PrintOnPage
        If IsMainCompany.Text <> 0 Then
            IsNotMain.Visible = True
        Else
            IsNotMain.Visible = False
        End If
    End Sub

    'Private Sub IsMainCompanyDTL2_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs)
    '    If IsMainCompanyDTL2.Text > 0 Then
    '        IsMainCompanyDTL2.Visible = True

    '    Else
    '        IsMainCompanyDTL2.Visible = False

    '    End If
    'End Sub


    'Private Sub IsMain2_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs)
    '    'IsMain2.Visible = (IsMainCompanyDTL.Text = 0)
    '    If IsMainCompanyDTL2.Text = 0 Then
    '        IsMain2.Visible = True
    '    Else
    '        IsMain2.Visible = False
    '    End If
    'End Sub


    Private Sub IsMainCompanyDTL_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles IsMainCompanyDTL.PrintOnPage
        If IsMainCompanyDTL.Text > 0 Then
            IsMainCompanyDTL.Visible = True
        Else
            IsMainCompanyDTL.Visible = False
        End If
    End Sub



    Private Sub NameCus_PrintOnPage(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles NameCus.PrintOnPage
        If Header1.Text = "รายงานภาษีขาย" Then
            NameCus.Text = "ชื่อผู้ขายสินค้า / ผู้รับบริการ"
        Else
            NameCus.Text = "ชื่อผู้ซื้อสินค้า / ผู้รับบริการ"
        End If
    End Sub


End Class