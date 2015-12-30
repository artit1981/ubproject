Option Explicit On

Public Class frmOrderDTL
    Inherits iEditForm

    Private Sub frmOrderDTL_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.Addbar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.PrintBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.PrintBar2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.PrintChequeBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.PrintPaymantBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.OptionSubItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never


    End Sub
End Class