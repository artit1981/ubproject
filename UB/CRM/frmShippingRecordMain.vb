
Option Explicit On
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class frmShippingRecordMain




    Private Sub LoadData()
        Dim lcls As New OrderSDAO
        Try
            Dim dataTable = lcls.GetDataTableForShippingRec(dtpDateFrom.EditValue, dtpDateTo.EditValue, False)

            GridControl.DataSource = dataTable

            GridStyle()

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "frmBankAccountRec.LoadData : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    Private Sub GridStyle()
        With GridView

            .Columns("OrderID").Visible = False
            .Columns("IsSelect").Visible = False

            .Columns("OrderCode").Caption = "เลขที่"
            .Columns("OrderCode").Width = 100
            .Columns("OrderCode").MaxWidth = 120
            .Columns("OrderCode").OptionsColumn.ReadOnly = True

            .Columns("OrderDate").Caption = "วันที่"
            .Columns("OrderDate").Width = 80
            .Columns("OrderDate").MaxWidth = 90
            .Columns("OrderDate").OptionsColumn.ReadOnly = True

            .Columns("CustomerCode").Caption = "รหัสลูกค้า"
            .Columns("CustomerCode").Width = 90
            .Columns("CustomerCode").MinWidth = 90
            .Columns("CustomerCode").MaxWidth = 160
            .Columns("CustomerCode").OptionsColumn.ReadOnly = True

            .Columns("Customer").Caption = "ลูกค้า"
            .Columns("Customer").OptionsColumn.ReadOnly = True

            .Columns("OrderStatus").Caption = "สถานะ"
            .Columns("OrderStatus").Width = 70
            .Columns("OrderStatus").MaxWidth = 70
            .Columns("OrderStatus").OptionsColumn.ReadOnly = True

            .Columns("GrandTotal").Caption = "ยอดรวม"
            .Columns("GrandTotal").Width = 110
            .Columns("GrandTotal").MaxWidth = 120
            .Columns("GrandTotal").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            .Columns("GrandTotal").DisplayFormat.FormatString = "n2"
            .Columns("GrandTotal").OptionsColumn.ReadOnly = True

            .Columns("ReceiptCode").Caption = "เลขที่ใบเสร็จ"
            .Columns("ReceiptCode").Width = 90
            .Columns("ReceiptCode").MaxWidth = 90
            .Columns("ReceiptCode").OptionsColumn.ReadOnly = True

            .Columns("BillCode").Caption = "เลขที่บิล"
            .Columns("BillCode").Width = 90
            .Columns("BillCode").MaxWidth = 90
            .Columns("BillCode").OptionsColumn.ReadOnly = True

            .Columns("EMPNAME").Caption = "ผู้รับผิดชอบ"
            .Columns("EMPNAME").Width = 140
            .Columns("EMPNAME").MaxWidth = 150
            .Columns("EMPNAME").OptionsColumn.ReadOnly = True

            .Columns("ShippingPeriod").Caption = "กำหนดเวลาส่ง"
            .Columns("ShippingPeriod").Width = 90
            .Columns("ShippingPeriod").MaxWidth = 90
            .Columns("ShippingPeriod").OptionsColumn.ReadOnly = True

            .Columns("ShippingMethod").Caption = "ลักษณะงาน"
            .Columns("ShippingMethod").Width = 90
            .Columns("ShippingMethod").MaxWidth = 90
            .Columns("ShippingMethod").OptionsColumn.ReadOnly = True

            .Columns("ShippingEmp").Caption = "ชื่อผู้ส่ง"
            .Columns("ShippingEmp").Width = 140
            .Columns("ShippingEmp").MaxWidth = 150
            .Columns("ShippingEmp").OptionsColumn.ReadOnly = True

            .Columns("ShippingStatus").Caption = "สถานะ"
            .Columns("ShippingStatus").Width = 90
            .Columns("ShippingStatus").MaxWidth = 90
            .Columns("ShippingStatus").OptionsColumn.ReadOnly = True

            .Columns("ShippingRemark").Caption = "หมายเหตุ"
            .Columns("ShippingRemark").Width = 110
            .Columns("ShippingRemark").MaxWidth = 120
            .Columns("ShippingRemark").OptionsColumn.ReadOnly = True

        End With
    End Sub


    Private Sub RefreshBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles RefreshBar.ItemClick
        Try
            ShowProgress(True, "Loading...")
            Call LoadData()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub ExitBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ExitBar.ItemClick
        Me.Close()
    End Sub


    Private Sub frmShippingRecordMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            dtpDateFrom.EditValue = New DateTime(GetCurrentDate(Nothing).Year, 1, 1)
            dtpDateTo.EditValue = GetCurrentDate(Nothing)



            Call LoadData()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AssignToBar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles AssignToBar.ItemClick
        Try
            Dim llRow As Long = 0
            Dim lList As New List(Of iOrder)
            For lRow = 0 To GridView.RowCount
                If GridView.GetRowCellValue(lRow, "IsSelect") = 1 Then
                    Dim liorder As New iOrder With {
                            .ID = GridView.GetRowCellValue(lRow, "OrderID")
                        }
                    lList.Add(liorder)
                End If
            Next
            If lList.Count > 0 Then
                Dim lFrmEdit As New frmShippingRecordDTL
                lFrmEdit.iOrderListDAO = lList
                Dim lResult = lFrmEdit.ShowDialog()
                If lResult = DialogResult.OK Then
                    LoadData()
                End If
            End If
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)

        End Try

    End Sub

    Private Sub SummaryBar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles SummaryBar.ItemClick
        Try
            Dim lcls As New OrderSDAO
            Dim dataTable = lcls.GetDataTableForShippingRecSummary(dtpDateFrom.EditValue, dtpDateTo.EditValue)
            Dim lFrmEdit As New frmShippingRecordLog
            lFrmEdit.LogTable = dataTable
            Dim lResult = lFrmEdit.ShowDialog()

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)

        End Try

    End Sub

    Private Sub PrintBar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles PrintBar.ItemClick
        Try

            Dim lFrmEdit As New frmShippingRecReport
            'lFrmEdit.Parent = frmMain
            lFrmEdit.Show()

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)

        End Try

    End Sub
End Class