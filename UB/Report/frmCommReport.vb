Option Explicit On
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI

Public Class frmCommReport
    Inherits iReport
    Private Const mFormName As String = "frmCommReport"

    Protected Overrides Sub Print()
        Try
            PrintReport()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".Print : " & e.Message)
        End Try
    End Sub

    Protected Overrides Sub ClearAllForm()
        Try
            Dim thisMonth As New Date(GetCurrentDate(Nothing).Year, GetCurrentDate(Nothing).Month, 1)
            'thisMonth = thisMonth.AddMonths(-1)
            Me.DateFrom.EditValue = thisMonth.AddMonths(-1)
            Me.DateTo.EditValue = thisMonth.AddDays(-1)
            VatType.EditValue = "E"

            SetComboCustomer()

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".ClearAllForm : " & e.Message)
        End Try

    End Sub

    Private Sub SetComboEmployee()
        Dim dataTable As New DataTable()
        Dim lcls As New EmployeeDAO

        lblEmp.Text = "พนักงานขาย"
        VatType.Enabled = True
        Try
            dataTable = lcls.GetDataTable(0, True)
            UcMoverItem1.ShowControl(dataTable, "ID", "NAME")

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboEmployee : " & e.Message)
        Finally
            dataTable = Nothing
        End Try

    End Sub

    Private Sub SetComboCustomer()
        Dim dataTable As New DataTable()
        Dim lcls As New CustomerDAO

        lblEmp.Text = "ลูกค้า"
        VatType.Enabled = False
        Try
            lcls.TableID = MasterType.Accounts
            dataTable = lcls.GetDataTableForCombo(True, True, False)
            UcMoverItem1.ShowControl(dataTable, "ID", "CusName")
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboEmployee : " & e.Message)
        Finally
            dataTable = Nothing
        End Try

    End Sub



    Private Sub PrintReport()
        Dim report As New XtraReport
        Dim lclsReport As New TmpOrderDAO
        Try


            'Set company header
            BuildCompanyAddress(lclsReport, 0)

            Select Case ReportType.EditValue
                Case 1
                    lclsReport.Header1 = "รายงานวิเคราะห์การขายแยกตามลูกค้า"
                    If chkShowPO.CheckState = CheckState.Checked Then
                        report = New rptSellByCusPO
                    Else
                        report = New rptSellByCus
                    End If

                Case 2
                    report = New rptCommission
                    If VatType.EditValue = "E" Then
                        lclsReport.Header1 = "รายงานค่าคอมมิชชัน (คำนวณจากมูลค่าสินค้าไม่รวม Vat)"
                    Else
                        lclsReport.Header1 = "รายงานค่าคอมมิชชัน (คำนวณจากมูลค่าสินค้ารวม Vat)"
                    End If
            End Select

            lclsReport.Header2 = "วันที่ " & Format(DateFrom.EditValue, "dd MMMM yyyy") & " ถึง " & Format(DateTo.EditValue, "dd MMMM yyyy")
            lclsReport.Header3 = ""
            lclsReport.SaveData()

            Dim lTableOrder As New DataTable
            Dim myCommand As SqlCommand
            Dim i As Integer = 1
            Dim SQL As String
            Dim lCommissionAMT As Decimal = 0

            'Build Order List
            Dim lOrderTypeList As String = ""
            lOrderTypeList = "( 0"
            If chkInvoice.Checked = True Then
                lOrderTypeList = lOrderTypeList & "," & MasterType.Invoice
            End If
            If chkInvoiceOnline.Checked = True Then
                lOrderTypeList = lOrderTypeList & "," & MasterType.InvoiceOnline
            End If
            If chkInvoiceAbb.Checked = True Then
                lOrderTypeList = lOrderTypeList & "," & MasterType.InvoiceAbb
            End If
            If chkShiping.Checked = True Then
                lOrderTypeList = lOrderTypeList & "," & MasterType.Shiping
            End If
            lOrderTypeList = lOrderTypeList & ")"

            'Build Employee List
            Dim lEmployeeList As String = UcMoverItem1.GetSelectItem

            SQL = "SELECT Orders.OrderID,Orders.OrderCode  ,Orders.OrderDate ,Orders.InvoiceSuplierID ,Orders.PO"
            SQL &=  " ,CASE WHEN Customer.CompanyName <>'' THEN Customer.CompanyName ELSE Customer.Title + Customer.Firstname + ' ' + Customer.LastName END Customer "
            SQL &=  " ,Orders.Total,Orders.DiscountAmount,Orders.VatAmount,Orders.GrandTotal, Orders.TableID"
            SQL &=  " ,Employee.EmpCode,Employee.Title + Employee.Firstname + ' ' + Employee.LastName AS EmployeeName,Employee.Commission "
            SQL &=  " FROM Orders  "
            SQL &=  " INNER JOIN Customer ON Orders.CustomerID=Customer.CustomerID  "
            SQL &=  " LEFT OUTER JOIN Employee ON Customer.EmpID=Employee.EmpID  "
            SQL &=  " WHERE Orders.IsDelete =0   "
            SQL &=  " and Orders.OrderDate between '" & formatSQLDate(DateFrom.EditValue) & "'"
            SQL &=  "                      and '" & formatSQLDate(DateTo.EditValue) & "'"
            SQL &=  " and Orders.IsInActive = 0"
            SQL &=  " and Orders.TableID in " & lOrderTypeList
            Select Case ReportType.EditValue
                Case 1
                    SQL &=  " and Customer.CustomerID in (" & lEmployeeList & ")"
                Case 2
                    SQL &=  " and Customer.EmpID in (" & lEmployeeList & ")"
            End Select
            Select Case ReportType.EditValue
                Case 1
                    SQL &=  " ORDER BY Customer.Title,Customer.Firstname,Orders.OrderDate ,Orders.OrderCode"
                Case 2
                    SQL &=  " ORDER BY Employee.Title,Employee.Firstname,Orders.OrderDate ,Orders.OrderCode"
            End Select



            lTableOrder = gConnection.executeSelectQuery(SQL, Nothing)
            If lTableOrder.Rows.Count > 0 Then
                'Clear Tmp
                SQL = " DELETE FROM TmpTax WHERE UserID=" & gUserID
                myCommand = New SqlCommand
                myCommand.CommandText = SQL
                gConnection.executeInsertSqlCommand(myCommand, Nothing)

                For Each pRow As DataRow In lTableOrder.Rows
                    lCommissionAMT = 0
                    If VatType.EditValue = "E" Then
                        lCommissionAMT = (ConvertNullToZero(pRow.Item("GrandTotal")) - ConvertNullToZero(pRow.Item("VatAmount"))) * (ConvertNullToZero(pRow.Item("Commission")) / 100)
                    Else
                        lCommissionAMT = ConvertNullToZero(pRow.Item("GrandTotal")) * (ConvertNullToZero(pRow.Item("Commission")) / 100)
                    End If

                    SQL = " INSERT INTO TmpTax (UserID,SEQ,TaxText1,TaxDate1,TaxText2,TaxText3,TaxText4,TaxTotal2,TaxTotal3,TaxTotal4,TaxTotal5,TaxTotal6,TaxTotal7  "
                    SQL &=  "  )"
                    SQL &=  " VALUES ( " & gUserID
                    SQL &=  " ," & i                                                                    'SEQ
                    SQL &=  " ,'" & ConvertNullToString(pRow.Item("EmployeeName")) & "'"                'TaxText1
                    SQL &=  " ,'" & formatSQLDate(pRow.Item("OrderDate")) & "'"                         'TaxDate1
                    If ConvertNullToString(pRow.Item("InvoiceSuplierID")) <> "" Then
                        SQL &=  " ,'" & ConvertNullToString(pRow.Item("InvoiceSuplierID")) & "'"        'TaxText2
                    Else
                        SQL &=  " ,'" & ConvertNullToString(pRow.Item("OrderCode")) & "'"               'TaxText2
                    End If
                    SQL &=  " ,'" & ConvertNullToString(pRow.Item("Customer")) & "'"                    'TaxText3
                    SQL &=  " ,'" & ConvertNullToString(pRow.Item("PO")) & "'"                    'TaxText4
                    SQL &=  " , " & ConvertNullToZero(pRow.Item("Total"))                               'TaxTotal2
                    SQL &=  " , " & ConvertNullToZero(pRow.Item("DiscountAmount"))                      'TaxTotal3
                    SQL &=  " , " & ConvertNullToZero(pRow.Item("VatAmount"))                           'TaxTotal4
                    SQL &=  " , " & ConvertNullToZero(pRow.Item("GrandTotal"))                          'TaxTotal5
                    SQL &=  " , " & ConvertNullToZero(pRow.Item("Commission"))                          'TaxTotal6
                    SQL &=  " , " & lCommissionAMT                                                      'TaxTotal7
                    SQL &=  " ) "
                    myCommand = New SqlCommand
                    myCommand.CommandText = SQL
                    gConnection.executeInsertSqlCommand(myCommand, Nothing)

                    i = i + 1
                Next

                ExecuteReportComm(report)
            Else
                ShowProgress(False, "")
                XtraMessageBox.Show(Me, "ไม่พบรายการ", "รายงาน", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".PrintReport : " & ex.Message)
        Finally
        End Try
    End Sub

    Private Sub ReportType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportType.SelectedIndexChanged
        Select Case ReportType.EditValue
            Case 1
                SetComboCustomer()
            Case 2
                SetComboEmployee()
        End Select
    End Sub



End Class
