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
            'Dim thisMonth As New Date(DateTime.Today.Year, DateTime.Today.Month, 1)
            'thisMonth = thisMonth.AddMonths(-1)
            Me.DateFrom.EditValue = DateTime.Today
            Me.DateTo.EditValue = DateTime.Today
            Me.DateAsOf.EditValue = DateTime.Today
            chkSelectAll.Checked = True

            SetComboCustomer()
            
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".ClearAllForm : " & e.Message)
        End Try

    End Sub

    Private Sub SetComboCustomer()
        Dim dataTable As New DataTable()
        Dim lcls As New CustomerDAO
       
        Try
            If ReportType.EditValue = 1 Then
                lcls.TableID = MasterType.Accounts
            Else
                lcls.TableID = MasterType.Agency
            End If

            dataTable = lcls.GetDataTableForCombo(True, False, False)
            lsCustomer.DataSource = dataTable
            lsCustomer.DisplayMember = "CusName"
            lsCustomer.ValueMember = "ID"

            For i As Integer = 0 To dataTable.DefaultView.Count - 1
                lsCustomer.SetItemChecked(i, True)
            Next i

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboCustomer : " & e.Message)
        Finally
            dataTable = Nothing
        End Try

    End Sub


    Private Sub PrintReport()
        Dim report As New XtraReport
        Dim lclsReport As New TmpOrderDAO
        Dim lAsOfDate As Date, lExpireDate As Date

        Try
            lAsOfDate = DateAsOf.EditValue
            'Set company header
            BuildCompanyAddress(lclsReport)
            report = New rptDebtAnalyst
            Select Case ReportType.EditValue
                Case 1
                    lclsReport.Header1 = "รายงานวิเคราะห์อายุลูกหนี้(แบบแจกแจง)"
                Case 2
                    lclsReport.Header1 = "รายงานวิเคราะห์อายุเจ้าหนี้(แบบแจกแจง)"
            End Select

            lclsReport.Header2 = "วันที่แยกอายุหนี้ " & Format(DateAsOf.EditValue, "dd MMMM yyyy") & " รายการจากวันที่ " & Format(DateFrom.EditValue, "dd MMMM yyyy") & " ถึง " & Format(DateTo.EditValue, "dd MMMM yyyy")
            lclsReport.Header3 = ""
            lclsReport.SaveData()

            Dim lTableOrder As New DataTable
            Dim myCommand As SqlCommand
            Dim i As Integer = 1
            Dim SQL As String

            'Build Order List
            Dim lOrderTypeList As String = ""
            lOrderTypeList = " 0"
            If chkInvoice.Checked = True And ReportType.EditValue = 1 Then
                lOrderTypeList = lOrderTypeList & "," & MasterType.Invoice
            ElseIf chkInvoice.Checked = True And ReportType.EditValue = 2 Then
                lOrderTypeList = lOrderTypeList & "," & MasterType.Invoice
            End If

            If chkShiping.Checked = True And ReportType.EditValue = 1 Then
                lOrderTypeList = lOrderTypeList & "," & MasterType.Shiping
            ElseIf chkShiping.Checked = True And ReportType.EditValue = 2 Then
                lOrderTypeList = lOrderTypeList & "," & MasterType.ShipingBuy
            End If

            If chkAddCre.Checked = True And ReportType.EditValue = 1 Then
                lOrderTypeList = lOrderTypeList & "," & MasterType.AddCredit
            ElseIf chkAddCre.Checked = True And ReportType.EditValue = 2 Then
                lOrderTypeList = lOrderTypeList & "," & MasterType.AddCreditBuy
            End If

            If chkRedue.Checked = True And ReportType.EditValue = 1 Then
                lOrderTypeList = lOrderTypeList & "," & MasterType.ReduceCredit
            ElseIf chkRedue.Checked = True And ReportType.EditValue = 2 Then
                lOrderTypeList = lOrderTypeList & "," & MasterType.ReduceCreditBuy
            End If

            If chkBorrow.Checked = True And ReportType.EditValue = 1 Then
                lOrderTypeList = lOrderTypeList & "," & MasterType.Borrow
            End If

            'Build Employee List
            Dim lCusList As String = "0"
            For Each item As Object In lsCustomer.CheckedItems
                Dim row As DataRowView = CType(item, DataRowView)
                If lCusList = "" Then
                    lCusList = ConvertNullToString(row(0))
                Else
                    lCusList = lCusList & "," & ConvertNullToString(row(0))
                End If
            Next

            Dim lclsOrder As New OrderSDAO
            Dim lPayAmount As Decimal = 0, lNotPayAmount As Decimal = 0, lDayPast As Long = 0

            lTableOrder = lclsOrder.GetDataTableForDebtAnalyst(DateAsOf.EditValue, DateFrom.EditValue, DateTo.EditValue, lCusList, lOrderTypeList)
            If lTableOrder.Rows.Count > 0 Then
                'Clear Tmp
                SQL = " DELETE FROM TmpTax WHERE UserID=" & gUserID
                myCommand = New SqlCommand
                myCommand.CommandText = SQL
                gConnection.executeInsertSqlCommand(myCommand, Nothing)

                For Each pRow As DataRow In lTableOrder.Rows
                    lExpireDate = pRow.Item("ExpireDate")
                    lPayAmount = 0
                    lNotPayAmount = 0
                    If ConvertNullToZero(pRow.Item("ReceiptID")) > 0 Then
                        lPayAmount = CalcPayAmount(pRow.Item("ReceiptID"))
                        If ConvertNullToZero(pRow.Item("GrandTotal")) <= lPayAmount Then
                            lNotPayAmount = 0
                        Else
                            lNotPayAmount = ConvertNullToZero(pRow.Item("GrandTotal")) - lPayAmount
                        End If
                    Else
                        lNotPayAmount = ConvertNullToZero(pRow.Item("GrandTotal"))
                    End If

                    lDayPast = DateDiff(DateInterval.Day, lExpireDate, lAsOfDate)

                    SQL = " INSERT INTO TmpTax (UserID,SEQ,TaxText1,TaxText2,TaxText3,TaxText4,TaxDate1,TaxText5,TaxText6,TaxTotal1,TaxDate2,TaxTotal2"
                    SQL = SQL & " ,TaxTotal3,TaxTotal4,TaxTotal5,TaxTotal6,TaxTotal7,TaxTotal8,TaxTotal9   )"
                    SQL = SQL & " VALUES ( " & gUserID
                    SQL = SQL & " ," & i                                                                    'SEQ
                    SQL = SQL & " ,'" & ConvertNullToString(pRow.Item("EmpCode")) & "'"                     'TaxText1
                    SQL = SQL & " ,'" & ConvertNullToString(pRow.Item("Employee")) & "'"                    'TaxText2
                    SQL = SQL & " ,'" & ConvertNullToString(pRow.Item("CustomerCode")) & "'"                'TaxText3
                    SQL = SQL & " ,'" & ConvertNullToString(pRow.Item("Customer")) & "'"                    'TaxText4
                    SQL = SQL & " ,'" & formatSQLDate(pRow.Item("OrderDate")) & "'"                         'TaxDate1
                    SQL = SQL & " ,'" & ConvertNullToString(pRow.Item("OrderCode")) & "'"                   'TaxText5
                    SQL = SQL & " ,'" & ConvertNullToString(pRow.Item("OrderType")) & "'"                   'TaxText6
                    SQL = SQL & " , " & ConvertNullToZero(pRow.Item("GrandTotal"))                          'TaxTotal1
                    SQL = SQL & " ,'" & formatSQLDate(pRow.Item("ExpireDate")) & "'"                        'TaxDate2
                    'ยังไม่ครบกำหนด
                    If lDayPast <= 0 Then
                        SQL = SQL & " , " & ConvertNullToZero(pRow.Item("GrandTotal"))                      'TaxTotal2 
                    Else : SQL = SQL & " ,0"
                    End If
                    'ยอดคงค้าง                     
                    SQL = SQL & " , " & lNotPayAmount                                                       'TaxTotal3 
                    '1M
                    If lDayPast > 0 And lDayPast <= 30 Then
                        SQL = SQL & " , " & lNotPayAmount                                                   'TaxTotal4 
                    Else : SQL = SQL & " ,0"
                    End If
                    '2M
                    If lDayPast > 30 And lDayPast <= 60 Then
                        SQL = SQL & " , " & lNotPayAmount                                                   'TaxTotal5 
                    Else : SQL = SQL & " ,0"
                    End If
                    '3M
                    If lDayPast > 60 And lDayPast <= 90 Then
                        SQL = SQL & " , " & lNotPayAmount                                                   'TaxTotal6 
                    Else : SQL = SQL & " ,0"
                    End If
                    '4M
                    If lDayPast > 90 And lDayPast <= 120 Then
                        SQL = SQL & " , " & lNotPayAmount                                                   'TaxTotal7 
                    Else : SQL = SQL & " ,0"
                    End If
                    '>4M
                    If lDayPast > 120 Then
                        SQL = SQL & " , " & lNotPayAmount                                                   'TaxTotal8 
                    Else : SQL = SQL & " ,0"
                    End If

                    SQL = SQL & " , " & lDayPast                                                            'TaxTotal9

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

    Private Function CalcPayAmount(ByVal pReceiptID As Long) As Decimal
        Dim dataTable As New DataTable()
        Dim lcls As New ChequeDAO
        CalcPayAmount = 0
        Try
            lcls = New ChequeDAO
            dataTable = lcls.GetDataTable(pReceiptID)
            If dataTable.Rows.Count > 0 Then
                For Each pRow As DataRow In dataTable.Rows
                    CalcPayAmount = CalcPayAmount + ConvertNullToZero(pRow.Item("ChequePay"))
                Next
            End If


        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".CalcPayAmount : " & e.Message)
        Finally
            dataTable = Nothing
        End Try
    End Function

    Private Sub ReportType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportType.SelectedIndexChanged
        SetComboCustomer()
    End Sub

    Private Sub chkSelectAll_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSelectAll.CheckedChanged
        If chkSelectAll.CheckState = CheckState.Checked Then
            lsCustomer.CheckAll()
        Else
            lsCustomer.UnCheckAll()
        End If

    End Sub

   
End Class
