Option Explicit On

Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI

Public Class frmTaxReport
    Inherits iReport
    Private Const mFormName As String = "frmTaxReport"

    Protected Overrides Sub Print()
        Try
            PrintReport()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".Print : " & e.Message)
        End Try
    End Sub

    Protected Overrides Sub ClearAllForm()
        Try
            OrderDate.EditValue = DateAdd(DateInterval.Month, -1, GetCurrentDate(Nothing))
            OrderType.EditValue = "S"
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".ClearAllForm : " & e.Message)
        End Try

    End Sub

    Private Sub PrintReport()
        Dim report As New XtraReport
        Dim lclsReport As New TmpOrderDAO
        Try
            report = New rptTaxSell

            'Set company header
            BuildCompanyAddress(lclsReport, 0)
            If OrderType.EditValue = "S" Then  'Sell
                lclsReport.Header1 = "รายงานภาษีขาย"
            ElseIf OrderType.EditValue = "A" Then
                lclsReport.Header1 = "รายงานภาษีขายอย่างย่อ"
            Else
                lclsReport.Header1 = "รายงานภาษีซื้อ"
            End If

            lclsReport.Header2 = "เดือนภาษี " & Format(OrderDate.EditValue, "MMMM") & " ปี " & Year(OrderDate.EditValue)
            lclsReport.Header3 = ""
            lclsReport.SaveData()

            Dim lclsTmpProList As New TmpProductList
            Dim lTableOrder As New DataTable
            Dim i As Integer = 1
            Dim SQL As String

            SQL = "SELECT Orders.OrderID,Orders.OrderCode  ,Orders.OrderDate ,Orders.InvoiceSuplierID "
            SQL &=  " ,CASE WHEN Customer.CompanyName <>'' THEN Customer.CompanyName ELSE Customer.Title + Customer.Firstname + ' ' + Customer.LastName END Customer "
            SQL &=  " ,Orders.Total,Orders.DiscountAmount,Orders.VatAmount,Customer.IsMainCompany, History.TaxID as CustomerTaxID,Customer.Branch, Orders.TableID"
            SQL &=  " FROM Orders  "
            SQL &=  " LEFT OUTER JOIN Customer ON Orders.CustomerID=Customer.CustomerID  "
            SQL &=  " LEFT OUTER JOIN History ON History.HistoryID=Customer.HistoryID  "
            SQL &=  " WHERE Orders.IsDelete =0   "
            SQL &=  " and Orders.VatAmount > 0 "
            SQL &=  " and Month(Orders.TaxMonthYear) =" & Month(OrderDate.EditValue)
            SQL &=  " and Year(Orders.TaxMonthYear) =" & IIf(Year(OrderDate.EditValue) > 2500, Year(OrderDate.EditValue) - 543, Year(OrderDate.EditValue))
            SQL &=  " and Orders.IsInActive = 0"
            If OrderType.EditValue = "B" Then 'buy
                SQL &= " and Orders.TableID in (" & MasterType.InvoiceBuy & "," & MasterType.Asset & "," & MasterType.ReduceCreditBuy & "," & MasterType.AddCreditBuy & ")"
            ElseIf OrderType.EditValue = "A" Then 'Abb
                SQL &= " and Orders.TableID in (" & MasterType.InvoiceAbb & ")"
            Else
                SQL &= " and Orders.TableID in (" & MasterType.Invoice & "," & MasterType.InvoiceOnline & "," & MasterType.ReduceCredit & "," & MasterType.AddCredit & ")"
            End If
            SQL &=  " ORDER BY Orders.OrderDate ,Orders.OrderCode"
            lTableOrder = gConnection.executeSelectQuery(SQL, Nothing)
            If lTableOrder.Rows.Count > 0 Then
                lclsTmpProList.ClearTemp()
                For Each pRow As DataRow In lTableOrder.Rows
                    lclsTmpProList.SEQ = i
                    lclsTmpProList.ProductID = pRow.Item("OrderID")
                    If OrderType.EditValue = "S" Or OrderType.EditValue = "A" Then 'Sell
                        lclsTmpProList.ProductName = ConvertNullToString(pRow.Item("OrderCode"))
                    Else
                        If ConvertNullToString(pRow.Item("InvoiceSuplierID")) <> "" Then
                            lclsTmpProList.ProductName = ConvertNullToString(pRow.Item("InvoiceSuplierID"))
                        Else
                            lclsTmpProList.ProductName = ConvertNullToString(pRow.Item("OrderCode"))
                        End If

                    End If

                    lclsTmpProList.OrderDate = pRow.Item("OrderDate")
                    lclsTmpProList.Customer = ConvertNullToString(pRow.Item("Customer"))

                    Select Case ConvertNullToZero(pRow.Item("TableID"))
                        Case MasterType.ReduceCredit, MasterType.ReduceCreditBuy
                            lclsTmpProList.Total = (ConvertNullToZero(pRow.Item("Total")) - ConvertNullToZero(pRow.Item("DiscountAmount"))) * -1
                            lclsTmpProList.Cost = ConvertNullToZero(pRow.Item("VatAmount")) * -1
                        Case Else
                            lclsTmpProList.Total = (ConvertNullToZero(pRow.Item("Total")) - ConvertNullToZero(pRow.Item("DiscountAmount")))
                            lclsTmpProList.Cost = ConvertNullToZero(pRow.Item("VatAmount"))
                    End Select

                    If ConvertNullToZero(pRow.Item("IsMainCompany")) = 1 Then  ' *** ใช้กลับกัน 0 = is main , 1 2 3 =Brance
                        lclsTmpProList.ProductCode = "/"
                        lclsTmpProList.IsMainCompany = 0
                    Else
                        lclsTmpProList.ProductCode = ""
                        lclsTmpProList.IsMainCompany = ConvertNullToZero(pRow.Item("Branch"))
                    End If

                    lclsTmpProList.CustomerTaxID = ConvertNullToString(pRow.Item("CustomerTaxID"))
                    lclsTmpProList.SaveData()
                    i = i + 1
                Next

                ExecuteReportTax(report)
            Else
                ShowProgress(False, "")
                XtraMessageBox.Show(Me, "ไม่พบรายการภาษี", "รายงานภาษี", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".PrintReport : " & ex.Message)
        Finally
        End Try
    End Sub

End Class
