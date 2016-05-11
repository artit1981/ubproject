Option Explicit On
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraEditors
Imports System.Data.SqlClient

Public Class frmDebtAnalystReport
    Inherits iReport
    Private Const mFormName As String = "frmDebtAnalystReport"

    Protected Overrides Sub Print()
        Try
            PrintReport()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".Print : " & e.Message)
        End Try
    End Sub

    Protected Overrides Sub ClearAllForm()
        Try
            Dim thisMonth As New Date(DateTime.Today.Year, DateTime.Today.Month, 1)
            'thisMonth = thisMonth.AddMonths(-1)
            Me.DateFrom.EditValue = thisMonth.AddMonths(-1)
            Me.DateTo.EditValue = thisMonth.AddDays(-1)
            VatType.EditValue = "E"
            chkSelectAll.Checked = True

            SetComboCustomer()
            SetComboProductType("", ProductTypeID)
            SetComboProductBrand("", ProductBrandID)
            SetComboProduct()
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
            Employee.DataSource = dataTable
            Employee.DisplayMember = "NAME"
            Employee.ValueMember = "ID"

            For i As Integer = 0 To dataTable.DefaultView.Count - 1
                Employee.SetItemChecked(i, True)
            Next i

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
            dataTable = lcls.GetDataTableForCombo(True, False, False)
            Employee.DataSource = dataTable
            Employee.DisplayMember = "CusName"
            Employee.ValueMember = "ID"

            For i As Integer = 0 To dataTable.DefaultView.Count - 1
                Employee.SetItemChecked(i, True)
            Next i

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboEmployee : " & e.Message)
        Finally
            dataTable = Nothing
        End Try

    End Sub


    Private Sub SetComboProduct()
        Dim dataTable As New DataTable()
        Dim lcls As New ProductDAO
        Dim lSQL As String = "", sQN As String = "0"

        Try
            'ProductType
            For Each item As Object In ProductTypeID.CheckedItems
                Dim row As DataRowView = CType(item, DataRowView)
                If sQN = "" Then
                    sQN = ConvertNullToString(row(0))
                Else
                    sQN = sQN & "," & ConvertNullToString(row(0))
                End If
            Next
            lSQL = " and Product.ProductTypeID in (" & sQN & ")"



            'ProductBrand
            sQN = "0"
            For Each item As Object In ProductBrandID.CheckedItems
                Dim row As DataRowView = CType(item, DataRowView)
                If sQN = "" Then
                    sQN = ConvertNullToString(row(0))
                Else
                    sQN = sQN & "," & ConvertNullToString(row(0))
                End If
            Next
            lSQL = " and Product.ProductBrandID in (" & sQN & ")"

            'Product
            dataTable = lcls.GetDataTableForCombo(0, 0, True, "", lSQL)
            Product.DataSource = dataTable
            Product.DisplayMember = "ProductName"
            Product.ValueMember = "ID"

            For i As Integer = 0 To dataTable.DefaultView.Count - 1
                Product.SetItemChecked(i, True)
            Next i

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboProduct : " & e.Message)
        Finally
            dataTable = Nothing
        End Try

    End Sub

    Private Sub PrintReport()
        Dim report As New XtraReport
        Dim lclsReport As New TmpOrderDAO
        Try


            'Set company header
            BuildCompanyAddress(lclsReport)

            Select Case ReportType.EditValue
                Case 1
                    lclsReport.Header1 = "รายงานวิเคราะห์การขายแยกตามลูกค้า"
                    report = New rptSellByCus
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
            If chkShiping.Checked = True Then
                lOrderTypeList = lOrderTypeList & "," & MasterType.Shiping
            End If
            lOrderTypeList = lOrderTypeList & ")"

            'Build Employee List
            Dim lEmployeeList As String = "0"
            For Each item As Object In Employee.CheckedItems
                Dim row As DataRowView = CType(item, DataRowView)
                If lEmployeeList = "" Then
                    lEmployeeList = ConvertNullToString(row(0))
                Else
                    lEmployeeList = lEmployeeList & "," & ConvertNullToString(row(0))
                End If
            Next

            SQL = "SELECT Orders.OrderID,Orders.OrderCode  ,Orders.OrderDate ,Orders.InvoiceSuplierID "
            SQL = SQL & " ,CASE WHEN Customer.CompanyName <>'' THEN Customer.CompanyName ELSE Customer.Title + Customer.Firstname + ' ' + Customer.LastName END Customer "
            SQL = SQL & " ,Orders.Total,Orders.DiscountAmount,Orders.VatAmount,Orders.GrandTotal, Orders.TableID"
            SQL = SQL & " ,Employee.EmpCode,Employee.Title + Employee.Firstname + ' ' + Employee.LastName AS EmployeeName,Employee.Commission "
            SQL = SQL & " FROM Orders  "
            SQL = SQL & " INNER JOIN Customer ON Orders.CustomerID=Customer.CustomerID  "
            SQL = SQL & " LEFT OUTER JOIN Employee ON Customer.EmpID=Employee.EmpID  "
            SQL = SQL & " WHERE Orders.IsDelete =0   "
            SQL = SQL & " and Orders.OrderDate between '" & formatSQLDate(DateFrom.EditValue) & "'"
            SQL = SQL & "                      and '" & formatSQLDate(DateTo.EditValue) & "'"
            SQL = SQL & " and Orders.IsInActive = 0"
            SQL = SQL & " and Orders.TableID in " & lOrderTypeList
            Select Case ReportType.EditValue
                Case 1
                    SQL = SQL & " and Customer.CustomerID in (" & lEmployeeList & ")"
                Case 2
                    SQL = SQL & " and Customer.EmpID in (" & lEmployeeList & ")"
            End Select
            Select Case ReportType.EditValue
                Case 1
                    SQL = SQL & " ORDER BY Customer.Title,Customer.Firstname,Orders.OrderDate ,Orders.OrderCode"
                Case 2
                    SQL = SQL & " ORDER BY Employee.Title,Employee.Firstname,Orders.OrderDate ,Orders.OrderCode"
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

                    SQL = " INSERT INTO TmpTax (UserID,SEQ,TaxText1,TaxDate1,TaxText2,TaxText3,TaxTotal2,TaxTotal3,TaxTotal4,TaxTotal5,TaxTotal6,TaxTotal7  "
                    SQL = SQL & "  )"
                    SQL = SQL & " VALUES ( " & gUserID
                    SQL = SQL & " ," & i                                                                    'SEQ
                    SQL = SQL & " ,'" & ConvertNullToString(pRow.Item("EmployeeName")) & "'"                'TaxText1
                    SQL = SQL & " ,'" & formatSQLDate(pRow.Item("OrderDate")) & "'"                         'TaxDate1
                    If ConvertNullToString(pRow.Item("InvoiceSuplierID")) <> "" Then
                        SQL = SQL & " ,'" & ConvertNullToString(pRow.Item("InvoiceSuplierID")) & "'"        'TaxText2
                    Else
                        SQL = SQL & " ,'" & ConvertNullToString(pRow.Item("OrderCode")) & "'"               'TaxText2
                    End If
                    SQL = SQL & " ,'" & ConvertNullToString(pRow.Item("Customer")) & "'"                    'TaxText3
                    SQL = SQL & " , " & ConvertNullToZero(pRow.Item("Total"))                               'TaxTotal2
                    SQL = SQL & " , " & ConvertNullToZero(pRow.Item("DiscountAmount"))                      'TaxTotal3
                    SQL = SQL & " , " & ConvertNullToZero(pRow.Item("VatAmount"))                           'TaxTotal4
                    SQL = SQL & " , " & ConvertNullToZero(pRow.Item("GrandTotal"))                          'TaxTotal5
                    SQL = SQL & " , " & ConvertNullToZero(pRow.Item("Commission"))                          'TaxTotal6
                    SQL = SQL & " , " & lCommissionAMT                                                      'TaxTotal7
                    SQL = SQL & " ) "
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

    Private Sub chkSelectAll_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSelectAll.CheckedChanged
        If chkSelectAll.CheckState = CheckState.Checked Then
            Employee.CheckAll()
        Else
            Employee.UnCheckAll()
        End If

    End Sub

    Private Sub chkSelectAllPro_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSelectAllPro.CheckedChanged
        If chkSelectAllPro.CheckState = CheckState.Checked Then
            Product.CheckAll()
        Else
            Product.UnCheckAll()
        End If
    End Sub

    Private Sub ProductBrandID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProductBrandID.SelectedValueChanged
        SetComboProduct()
    End Sub
    Private Sub ProductTypeID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProductTypeID.SelectedValueChanged
        SetComboProduct()
    End Sub
End Class
