Option Explicit On

Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI

Public Class frmDealReport
    Inherits iReport
    Private Const mFormName As String = "frmDealReport"

    Protected Overrides Sub Print()
        Try
            PrintReport()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".Print : " & e.Message)
        End Try
    End Sub

    Protected Overrides Sub ClearAllForm()
        Try
            OrderDate.EditValue = GetCurrentDate(Nothing)
            OrderType.EditValue = "S"
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".ClearAllForm : " & e.Message)
        End Try

    End Sub

    Private Sub PrintReport()
        Dim report As New XtraReport
        Dim lclsReport As New TmpOrderDAO
        Try


            'Set company header
            BuildCompanyAddress(lclsReport, 0)
            If OrderType.EditValue = "S" Then 'Sell
                If OrderType2.EditValue = "S" Then
                    report = New rptDealSell
                    lclsReport.Header1 = "รายงานการรับชำระหนี้ของลูกหนี้การค้าปี " & Year(OrderDate.EditValue)
                Else
                    report = New rptDealSellNot
                    lclsReport.Header1 = "รายงานค้างชำระหนี้ของลูกหนี้การค้าปี " & Year(OrderDate.EditValue)
                End If

            Else
                If OrderType2.EditValue = "S" Then
                    lclsReport.Header1 = "รายงานการจ่ายชำระหนี้ของเจ้าหนี้การค้าปี " & Year(OrderDate.EditValue)
                Else
                    lclsReport.Header1 = "รายงานค้างชำระหนี้ของเจ้าหนี้การค้าปี " & Year(OrderDate.EditValue)
                End If
                report = New rptDealBuy

            End If

            lclsReport.Header2 = ""
            lclsReport.Header3 = ""
            lclsReport.SaveData()


            Dim lTableOrder As New DataTable
            Dim i As Integer = 1
            Dim SQL As String
            SQL = "SELECT TMP.OrderID,TMP.BillCode ,TMP.BillDate,TMP.OrderCode,TMP.InvoiceSuplierID "
            SQL &=  " ,TMP.Total ,TMP.VatAmount,TMP.GrandTotal,TMP.OrderDate,TMP.DiscountAmount  "
            SQL &=  " ,TMP.Customer,TableID "
            SQL &=  " FROM ("
            If OrderType2.EditValue = "S" Then
                SQL &=  "SELECT Orders.OrderID,Orders.OrderCode AS BillCode ,Orders.OrderDate AS BillDate,OD.OrderCode,OD.InvoiceSuplierID "
                SQL &=  " ,OD.Total ,OD.VatAmount,OD.GrandTotal,OD.OrderDate,OD.DiscountAmount,OD.TableID  "
                SQL &=  " ,CASE WHEN Customer.CompanyName <>'' THEN Customer.CompanyName ELSE Customer.Title + Customer.Firstname + ' ' + Customer.LastName END Customer "
                SQL &=  " FROM Orders  "
                SQL &=  " INNER JOIN OrdersDetail ON Orders.OrderID=OrdersDetail.BillID AND OrdersDetail.IsDelete=0 "
                SQL &=  " INNER JOIN Orders OD ON OD.OrderID=OrdersDetail.OrderID  "
                SQL &=  " INNER JOIN Customer ON OD.CustomerID=Customer.CustomerID  "
                SQL &=  " WHERE Orders.IsDelete =0   "
                SQL &=  " and Year(Orders.OrderDate) =" & IIf(Year(OrderDate.EditValue) > 2500, Year(OrderDate.EditValue) - 543, Year(OrderDate.EditValue))
                SQL &=  " and Year(OD.OrderDate) =" & IIf(Year(OrderDate.EditValue) > 2500, (Year(OrderDate.EditValue) - 543) - 1, (Year(OrderDate.EditValue) - 1))
                SQL &=  " and Orders.IsInActive = 0 and OD.VatAmount > 0"
                If OrderType.EditValue = "B" Then 'buy
                    SQL &=  " and Orders.TableID in (" & MasterType.ReceiptBuy & ")"
                Else
                    SQL &=  " and Orders.TableID in (" & MasterType.Receipt & ")"
                End If
            Else
                SQL &=  "SELECT Orders.OrderID,Orders.OrderCode AS BillCode ,Orders.OrderDate AS BillDate,Orders.OrderCode,Orders.InvoiceSuplierID "
                SQL &=  " ,Orders.Total ,Orders.VatAmount,Orders.GrandTotal,Orders.OrderDate ,Orders.DiscountAmount,Orders.TableID "
                SQL &=  " ,CASE WHEN Customer.CompanyName <>'' THEN Customer.CompanyName ELSE Customer.Title + Customer.Firstname + ' ' + Customer.LastName END Customer "
                SQL &=  " FROM Orders  "
                SQL &=  " INNER JOIN Customer ON Orders.CustomerID=Customer.CustomerID  "
                SQL &=  " WHERE Orders.IsDelete =0   "
                SQL &=  " and Year(Orders.OrderDate) =" & IIf(Year(OrderDate.EditValue) > 2500, (Year(OrderDate.EditValue) - 543) - 1, (Year(OrderDate.EditValue) - 1))
                SQL &=  " and Orders.IsInActive = 0 and Orders.RefReceiptID=0 and Orders.VatAmount > 0"
                If OrderType.EditValue = "B" Then 'buy
                    SQL &=  " and Orders.TableID in (" & MasterType.InvoiceBuy & ")"
                Else
                    SQL &= " and Orders.TableID in (" & MasterType.Invoice & "," & MasterType.InvoiceOnline & ")"
                End If
            End If

            SQL &=  " ) as TMP"

            If OrderType.EditValue = "S" Then 'Sell
                SQL &=  "  ORDER BY  BillDate,Customer ,OrderDate"
            Else
                SQL &=  "  ORDER BY Customer ,OrderDate"
            End If

            lTableOrder = gConnection.executeSelectQuery(SQL, Nothing)
            If lTableOrder.Rows.Count > 0 Then
                'Clear
                Dim myCommand As SqlCommand
                Dim lclsBank As New BankDAO
                Dim lSEQ As Long = 1
                SQL = " DELETE FROM TmpTax WHERE UserID=@UserID "
                myCommand = New SqlCommand
                myCommand.CommandText = SQL
                myCommand.Parameters.Add(New SqlParameter("@UserID", gUserID))
                gConnection.executeInsertSqlCommand(myCommand, Nothing)

                For Each pRow As DataRow In lTableOrder.Rows
                    SQL = " INSERT INTO TmpTax (UserID,SEQ,TaxDate1,TaxDate2,TaxText1,TaxText2,TaxAmount1,TaxAmount2 ,TaxAmount3)"
                    SQL &=  " VALUES ( " & gUserID
                    SQL &=  ", " & lSEQ
                    SQL &=  " ,'" & formatSQLDate(pRow.Item("BillDate")) & "'"          'TaxDate1
                    SQL &=  " ,'" & formatSQLDate(pRow.Item("OrderDate")) & "'"          'TaxDate2
                    If ConvertNullToString(pRow.Item("InvoiceSuplierID")) <> "" Then         'TaxText1
                        SQL &=  " ,'" & ConvertNullToString(pRow.Item("InvoiceSuplierID")) & "'"
                    Else
                        SQL &=  " ,'" & ConvertNullToString(pRow.Item("OrderCode")) & "'"
                    End If
                    SQL &=  " ,'" & ConvertNullToString(pRow.Item("Customer")) & "'"      'TaxText2
                    If ConvertNullToZero(pRow.Item("TableID")) = MasterType.ReduceCredit Or ConvertNullToZero(pRow.Item("TableID")) = MasterType.ReduceCreditBuy Then
                        SQL &=  " ," & (ConvertNullToZero(pRow.Item("Total") - ConvertNullToZero(pRow.Item("DiscountAmount")))) * -1           'TaxAmount1    
                        SQL &=  " ," & ConvertNullToZero(pRow.Item("VatAmount")) * -1         'TaxAmount2   
                        SQL &=  " ," & ConvertNullToZero(pRow.Item("GrandTotal")) * -1            'TaxAmount3    
                    Else
                        SQL &=  " ," & ConvertNullToZero(pRow.Item("Total") - ConvertNullToZero(pRow.Item("DiscountAmount")))              'TaxAmount1    
                        SQL &=  " ," & ConvertNullToZero(pRow.Item("VatAmount"))              'TaxAmount2   
                        SQL &=  " ," & ConvertNullToZero(pRow.Item("GrandTotal"))              'TaxAmount3    
                    End If
                    SQL &=  " ) "
                    myCommand = New SqlCommand
                    myCommand.CommandText = SQL
                    gConnection.executeInsertSqlCommand(myCommand, Nothing)
                    lSEQ = lSEQ + 1
                Next

                ExecuteReportComm(report)
            Else
                ShowProgress(False, "")
                XtraMessageBox.Show(Me, "ไม่พบรายการ", "รายงานชำระหนี้", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".PrintReport : " & ex.Message)
        Finally
        End Try
    End Sub

End Class
