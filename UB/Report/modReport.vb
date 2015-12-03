Imports DevExpress.XtraReports.UI

'Imports DevExpress.XtraReports.UI
'Imports System.Data.SqlClient

Module modReport
    'Private mOrderType As MasterType
    Public Sub PrintReportOrder(ByVal pMasterType As Long, ByVal pOrderID As Long)
        Dim lfrmReport As New frmPreReport
        lfrmReport.InitialForm(pMasterType, pOrderID, "", Now, 0, Nothing, "", Nothing, Nothing)
        lfrmReport.ShowDialog()
        'pReport.ShowPreview()
    End Sub

    Public Sub PrintPayment(ByVal pOrderID As Long)
        Dim lfrmReport As New frmPreReport
        lfrmReport.InitialForm(1000, pOrderID, "", Now, 0, Nothing, "", Nothing, Nothing)
        lfrmReport.ShowDialog()
    End Sub

    Public Sub PrintCheque(ByVal pChequeID As Long, ByVal pcls As ChequeDAO)
        Dim lfrmReport As New frmPreReport
        lfrmReport.InitialForm(1001, 0, "", Now, pChequeID, pcls, "", Nothing, Nothing)
        lfrmReport.ShowDialog()
    End Sub

    Public Sub PrintBarCode(ByVal pProName As String, ByVal pBarCodeList As List(Of SnDAO))
        Dim lfrmReport As New frmPreReport
        lfrmReport.InitialForm(1002, 0, "", Now, 0, Nothing, pProName, pBarCodeList, Nothing)
        lfrmReport.ShowDialog()
    End Sub

    Public Sub ExecuteReportComm(ByVal pReport As XtraReport)
        Dim lfrmReport As New frmPreReport
        lfrmReport.InitialForm(1003, 0, "", Now, 0, Nothing, "", Nothing, pReport)
        lfrmReport.ShowDialog()
    End Sub

    Public Sub PrintTaxAtPay(ByVal pOrderID As Long, ByVal pTaxNo As String, ByVal pReportDate As Date)
        Dim lfrmReport As New frmPreReport
        lfrmReport.InitialForm(1004, pOrderID, pTaxNo, pReportDate, 0, Nothing, "", Nothing, Nothing)
        lfrmReport.ShowDialog()
    End Sub

    Public Sub ExecuteReportTax(ByVal pReport As XtraReport)
        Dim lfrmReport As New frmPreReport
        lfrmReport.InitialForm(1005, 0, "", Now, 0, Nothing, "", Nothing, pReport)
        lfrmReport.ShowDialog()
    End Sub

    'Public Sub ExecuteReportTax(ByVal pReport As XtraReport)
    '    Dim lfrmReport As New frmPreReport
    '    lfrmReport.InitialForm(1005, 0, "", Now, 0, Nothing, "", Nothing, pReport)
    '    lfrmReport.ShowDialog()
    'End Sub
    'Public Sub PrintReportOrder(ByVal pMasterType As Long, ByVal pOrderID As Long)
    '    If pOrderID > 0 Then
    '        mOrderType = pMasterType
    '        Try
    '            Select Case mOrderType
    '                Case MasterType.SellOrders, MasterType.Invoice, MasterType.Shiping, MasterType.Reserve, MasterType.PurchaseOrder _
    '                    , MasterType.Quotation, MasterType.Claim, MasterType.ClaimOut, MasterType.ReduceCredit, MasterType.ReduceCreditBuy, MasterType.Borrow, MasterType.Expose
    '                    Call PrintOrder(pOrderID)
    '                Case MasterType.Bill, MasterType.Receipt
    '                    Call PrintBill(pOrderID)
    '                    'Case MasterType.Quotation
    '                    '    Call PrintQuotation(pOrderID)
    '                    'Case MasterType.Claim
    '                    '    Call PrintClaim(pOrderID)
    '            End Select
    '        Catch ex As Exception
    '            Err.Raise(Err.Number, ex.Source, "modReport.PrintReportOrder : " & ex.Message)
    '        End Try
    '    End If
    'End Sub

    'Private Sub PrintOrder(ByVal pOrderID As Long)
    '    Dim report As New XtraReport
    '    'Dim report2 As rptClaim = Nothing
    '    Dim lclsOrder As New OrderSDAO
    '    Dim lclsCreditRole As New CreditRoleDAO
    '    Dim lclsShipingMethod As New MasterDAO
    '    Dim lclsReport As New TmpOrderDAO
    '    Dim lclsMaster As New MasterDAO
    '    Dim lclsContactPerson As New CustomerDAO
    '    Try

    '        BuildCompanyAddress(lclsReport)
    '        If lclsOrder.InitailData(pOrderID) Then
    '            Select Case mOrderType
    '                Case MasterType.PurchaseOrder
    '                    report = New rptPOOrders
    '                Case MasterType.SellOrders
    '                    report = New rptSellOrders
    '                    lclsReport.Header1 = "ใบสั่งขาย\Sell Order"
    '                Case MasterType.Reserve
    '                    report = New rptSellOrders
    '                    lclsReport.Header1 = "ใบสั่งจอง"
    '                Case MasterType.Quotation
    '                    report = New rptQuotation
    '                Case MasterType.Claim
    '                    report = New rptClaimMain
    '                    lclsReport.Header1 = "รับแจ้งเคลม"
    '                Case MasterType.Expose
    '                    report = New rptClaimMain
    '                    lclsReport.Header1 = "รายการเบิก"
    '                Case MasterType.Shiping, MasterType.ShipingBuy
    '                    report = New rptShipingReport
    '                Case MasterType.ReduceCredit, MasterType.ReduceCreditBuy
    '                    report = New rptReduceCredit
    '                Case MasterType.Borrow
    '                    report = New rptBorrow
    '                Case Else
    '                    report = New rptOrdersReport
    '            End Select

    '            lclsReport.AddressBill = lclsOrder.CustomerDAO.AddressS.AddressLong

    '            If lclsOrder.CustomerDAO.AddressShip.AddressNo = "" And lclsOrder.CustomerDAO.AddressShip.AddressName = "" Then
    '                lclsReport.AddressShip = lclsOrder.CustomerDAO.AddressS.AddressLong
    '            Else
    '                lclsReport.AddressShip = lclsOrder.CustomerDAO.AddressShip.AddressLong
    '            End If

    '            If lclsOrder.CreditRuleID > 0 Then
    '                If lclsCreditRole.InitailData(lclsOrder.CreditRuleID, "") Then
    '                    lclsReport.CreditRule = lclsCreditRole.NameThai
    '                Else
    '                    lclsReport.CreditRule = ""
    '                End If
    '            Else
    '                lclsReport.CreditRule = ""
    '            End If

    '            lclsReport.CustomerCode = lclsOrder.CustomerDAO.Code
    '            If lclsOrder.CustomerDAO.FirstName <> "" Then
    '                lclsReport.CustomerName = lclsOrder.CustomerDAO.Title & lclsOrder.CustomerDAO.FirstName & "  " & lclsOrder.CustomerDAO.LastName
    '            Else
    '                'lclsReport.Company = lclsOrder.CustomerDAO.CompanyName
    '                lclsReport.CustomerName = lclsOrder.CustomerDAO.CompanyName
    '            End If
    '            lclsReport.Institute = lclsOrder.Institute


    '            'ShipingMethodID
    '            If lclsOrder.ShipingMethodID > 0 Then
    '                lclsMaster.InitailData(lclsOrder.ShipingMethodID, MasterType.ShipingMethod)
    '                lclsReport.ShipingMethod = lclsMaster.NameThai
    '            End If

    '            'ContactPerson
    '            If lclsOrder.CustomerDAO.ContactPersonID > 0 Then
    '                If lclsContactPerson.InitailData(lclsOrder.CustomerDAO.ContactPersonID) Then
    '                    If lclsContactPerson.FirstName <> "" Then
    '                        lclsReport.ContactPerson = lclsContactPerson.Title & lclsContactPerson.FirstName & "  " & lclsContactPerson.LastName
    '                    Else
    '                        lclsReport.ContactPerson = lclsContactPerson.CompanyName
    '                    End If
    '                End If
    '            Else
    '                lclsReport.ContactPerson = lclsOrder.CustomerDAO.AddressS.ContactName
    '            End If


    '            'CompanyType
    '            If lclsOrder.CustomerDAO.CompanyTypeID > 0 Then
    '                lclsMaster = New MasterDAO
    '                lclsMaster.InitailData(lclsOrder.CustomerDAO.CompanyTypeID, MasterType.CompanyType)
    '                lclsReport.CustomerType = lclsMaster.NameThai
    '            Else
    '                lclsReport.CustomerType = ""
    '            End If

    '            'ShipingRuleID
    '            If lclsOrder.ShipingRuleID > 0 Then
    '                lclsMaster = New MasterDAO
    '                lclsMaster.InitailData(lclsOrder.ShipingRuleID, MasterType.ShipingRule)
    '                lclsReport.ShipingRule = lclsMaster.NameThai
    '            Else
    '                lclsReport.ShipingRule = ""
    '            End If

    '            lclsReport.RefOrderCode = ""
    '            lclsReport.RefOrderCode = lclsOrder.GetToRefOrderCode(lclsOrder.ID, Nothing)
    '            If mOrderType = MasterType.ReduceCredit Or mOrderType = MasterType.ReduceCreditBuy Then
    '                Dim lclsRefOreder As New OrderSDAO
    '                Dim lTotal As Decimal = 0
    '                If lclsOrder.RefToOrderID.Count > 0 Then
    '                    For Each pRefOrderID As Long In lclsOrder.RefToOrderID
    '                        If lclsRefOreder.InitailData(pRefOrderID) Then
    '                            lTotal = lTotal + lclsRefOreder.Total
    '                        End If
    '                    Next
    '                End If

    '                lclsReport.DiscountAmount = lTotal
    '            Else
    '                lclsReport.DiscountAmount = lclsOrder.DiscountAmount
    '            End If

    '            lclsReport.PO = lclsOrder.PO

    '            lclsReport.Employee = lclsOrder.CustomerDAO.EmployeeDAO.FirstName
    '            lclsReport.EmployeePhone = lclsOrder.CustomerDAO.EmployeeDAO.AddressS.Phone1
    '            lclsReport.CustomerPhone = lclsOrder.CustomerDAO.AddressS.Phone1
    '            lclsReport.CustomerFAX = lclsOrder.CustomerDAO.AddressS.Fax
    '            lclsReport.CustomerTax = lclsOrder.CustomerDAO.HistoryDAO.TaxID
    '            lclsReport.OrderCode = lclsOrder.Code
    '            lclsReport.OrderDate = lclsOrder.OrderDate
    '            lclsReport.ExpireDate = lclsOrder.ExpireDate

    '            lclsReport.Remark = lclsOrder.Remark
    '            lclsReport.SendBy = lclsOrder.SendBy
    '            lclsShipingMethod.InitailData(lclsOrder.ShipingMethodID, MasterType.ShipingMethod)
    '            lclsReport.ShipingMethod = lclsShipingMethod.NameThai
    '            lclsReport.ShipingDate = lclsOrder.ShipingDate
    '            lclsReport.QuotationDays = lclsOrder.QuotationDays
    '            lclsReport.Total = lclsOrder.Total
    '            lclsReport.VatAmount = lclsOrder.VatAmount
    '            lclsReport.VatPercen = lclsOrder.VatPercen

    '            lclsReport.DiscountPercen = lclsOrder.DiscountPercen
    '            lclsReport.GrandTotal = lclsOrder.GrandTotal
    '            lclsReport.GrandTotalSTR = ChangeToThaibathWord(lclsOrder.GrandTotal.ToString)

    '            lclsReport.SaveData()


    '            Dim lclsProList As New ProductListDAO
    '            Dim lclsTmpProList As New TmpProductList
    '            Dim lTableProList As DataTable
    '            Dim lIsSeqDup As Boolean, lSEQ As Long = 1
    '            Dim lOrderList As New List(Of Long)
    '            Dim lSN As SnDAO, lSNTable As DataTable, lSnCodeList As String = ""

    '            lOrderList.Add(pOrderID)

    '            lTableProList = lclsProList.GetDataTable(lOrderList, mOrderType.ToString, Nothing, False, "", False, False, False, False)
    '            lIsSeqDup = lclsProList.CheckSeqDup(pOrderID, mOrderType.ToString, Nothing, False)

    '            lclsTmpProList.ClearTemp()
    '            For Each pRow As DataRow In lTableProList.Rows
    '                If lIsSeqDup Then
    '                    lclsTmpProList.SEQ = lSEQ
    '                Else
    '                    lclsTmpProList.SEQ = pRow.Item("SEQ")
    '                End If

    '                lclsTmpProList.ProductID = pRow.Item("ProductID")
    '                lclsTmpProList.ProductCode = ConvertNullToString(pRow.Item("ProductCode"))
    '                If ConvertNullToString(pRow.Item("ProductNameExt")) <> "" Then
    '                    lclsTmpProList.ProductName = ConvertNullToString(pRow.Item("ProductNameExt"))
    '                Else
    '                    lclsTmpProList.ProductName = ConvertNullToString(pRow.Item("ProductName"))
    '                End If

    '                lclsTmpProList.ProductNameExt = ""
    '                lclsTmpProList.UnitCode = ConvertNullToString(pRow.Item("UnitName"))
    '                lclsTmpProList.Units = ConvertNullToZero(pRow.Item("Units"))
    '                lclsTmpProList.Cost = ConvertNullToZero(pRow.Item("Cost"))
    '                lclsTmpProList.Price = ConvertNullToZero(pRow.Item("Price"))
    '                lclsTmpProList.Discount = ConvertNullToZero(pRow.Item("Discount"))
    '                lclsTmpProList.Total = ConvertNullToZero(pRow.Item("ToTal"))
    '                lclsTmpProList.Remark = ConvertNullToString(pRow.Item("Remark"))
    '                Select Case mOrderType
    '                    Case MasterType.SellOrders, MasterType.Invoice, MasterType.InvoiceBuy, MasterType.Shiping, MasterType.ShipingBuy, MasterType.PurchaseOrder, MasterType.Borrow, MasterType.Claim, MasterType.Expose
    '                        lSnCodeList = ""
    '                        lSN = New SnDAO
    '                        lSNTable = lSN.GetDataTable(lOrderList, lclsTmpProList.ProductID, "", Nothing)
    '                        For Each pRowSn As DataRow In lSNTable.Rows
    '                            If lSnCodeList = "" Then
    '                                lSnCodeList = ConvertNullToString(pRowSn.Item("SerialNumberNo"))
    '                            Else
    '                                lSnCodeList = lSnCodeList & "," & ConvertNullToString(pRowSn.Item("SerialNumberNo"))
    '                            End If
    '                        Next

    '                        Select Case mOrderType
    '                            Case MasterType.SellOrders
    '                                lclsTmpProList.ProductName = Left(lclsTmpProList.ProductName, 25)
    '                            Case MasterType.Shiping, MasterType.ShipingBuy, MasterType.PurchaseOrder, MasterType.Borrow, MasterType.Claim, MasterType.Expose
    '                                lclsTmpProList.ProductName = Left(lclsTmpProList.ProductName, 40)
    '                            Case Else
    '                                lclsTmpProList.ProductName = Left(lclsTmpProList.ProductName, 60)
    '                        End Select
    '                        If lSnCodeList <> "" Then
    '                            lclsTmpProList.ProductName = lclsTmpProList.ProductName & "(" & lSnCodeList & ")"
    '                        End If

    '                End Select

    '                lclsTmpProList.SaveData()
    '                lSEQ = lSEQ + 1
    '            Next
    '            'lclsTmpProList.SaveNull(10 - lTableProList.Rows.Count)


    '            ExecuteReport(report, lclsOrder.Code, Nothing)
    '        End If
    '    Catch ex As Exception
    '        Err.Raise(Err.Number, ex.Source, "modReport.PrintOrder : " & ex.Message)
    '    Finally

    '    End Try
    'End Sub


    'Private Sub PrintQuotation(ByVal pOrderID As Long)
    '    Dim report As New rptQuotation
    '    Dim lclsOrder As New OrderSDAO
    '    Dim lclsCreditRole As New CreditRoleDAO
    '    Dim lclsMaster As New MasterDAO
    '    Dim lclsReport As New TmpOrderDAO
    '    Dim lclsContactPerson As New CustomerDAO

    '    Try
    '        If lclsOrder.InitailData(pOrderID) Then
    '            BuildCompanyAddress(lclsReport)

    '            lclsReport.AddressBill = lclsOrder.CustomerDAO.AddressS.AddressLong
    '            If lclsOrder.CustomerDAO.AddressShip.AddressNo = "" And lclsOrder.CustomerDAO.AddressShip.AddressName = "" Then
    '                lclsReport.AddressShip = lclsOrder.CustomerDAO.AddressS.AddressLong
    '            Else
    '                lclsReport.AddressShip = lclsOrder.CustomerDAO.AddressShip.AddressLong
    '            End If

    '            If lclsOrder.CreditRuleID > 0 Then
    '                If lclsCreditRole.InitailData(lclsOrder.CreditRuleID, "") Then
    '                    lclsReport.CreditRule = lclsCreditRole.NameThai
    '                Else
    '                    lclsReport.CreditRule = ""
    '                End If
    '            End If


    '            lclsReport.CustomerCode = lclsOrder.CustomerDAO.Code
    '            If lclsOrder.CustomerDAO.FirstName <> "" Then
    '                lclsReport.CustomerName = lclsOrder.CustomerDAO.Title & lclsOrder.CustomerDAO.FirstName & "  " & lclsOrder.CustomerDAO.LastName
    '            Else
    '                lclsReport.CustomerName = lclsOrder.CustomerDAO.CompanyName
    '            End If

    '            'ShipingMethodID
    '            If lclsOrder.ShipingMethodID > 0 Then
    '                lclsMaster.InitailData(lclsOrder.ShipingMethodID, MasterType.ShipingMethod)
    '                lclsReport.ShipingMethod = lclsMaster.NameThai
    '                If lclsContactPerson.FirstName <> "" Then
    '                    lclsReport.ContactPerson = lclsContactPerson.Title & lclsContactPerson.FirstName & "  " & lclsContactPerson.LastName
    '                Else
    '                    lclsReport.ContactPerson = lclsContactPerson.CompanyName
    '                End If
    '            End If


    '            'CompanyType
    '            If lclsOrder.CustomerDAO.CompanyTypeID > 0 Then
    '                lclsMaster.InitailData(lclsOrder.CustomerDAO.CompanyTypeID, MasterType.CompanyType)
    '                lclsReport.CustomerType = lclsMaster.NameThai
    '            Else
    '                lclsReport.CustomerType = ""
    '            End If


    '            'ShipingMethodID
    '            If lclsOrder.ShipingRuleID > 0 Then
    '                lclsMaster.InitailData(lclsOrder.ShipingRuleID, MasterType.ShipingRule)
    '                lclsReport.ShipingRule = lclsMaster.NameThai
    '            Else
    '                lclsReport.ShipingRule = ""
    '            End If


    '            'ContactPerson
    '            If lclsOrder.CustomerDAO.ContactPersonID > 0 Then
    '                If lclsContactPerson.InitailData(lclsOrder.CustomerDAO.ContactPersonID) Then
    '                    If lclsContactPerson.FirstName <> "" Then
    '                    End If
    '                End If
    '            End If

    '            lclsReport.Employee = lclsOrder.EmployeeDAO.FirstName
    '            lclsReport.CustomerPhone = lclsOrder.CustomerDAO.AddressS.Phone1
    '            lclsReport.CustomerFAX = lclsOrder.CustomerDAO.AddressS.Fax
    '            lclsReport.OrderCode = lclsOrder.Code
    '            lclsReport.OrderDate = lclsOrder.OrderDate
    '            lclsReport.ShipingDate = lclsOrder.ShipingDate
    '            lclsReport.ExpireDate = lclsOrder.ExpireDate
    '            lclsReport.QuotationDays = lclsOrder.QuotationDays
    '            lclsReport.PO = lclsOrder.PO
    '            lclsReport.Remark = lclsOrder.Remark
    '            lclsReport.SendBy = lclsOrder.SendBy
    '            lclsReport.ShipingDate = lclsOrder.ShipingDate
    '            lclsReport.Total = lclsOrder.Total
    '            lclsReport.VatAmount = lclsOrder.VatAmount
    '            lclsReport.VatPercen = lclsOrder.VatPercen
    '            lclsReport.DiscountAmount = lclsOrder.DiscountAmount
    '            lclsReport.DiscountPercen = lclsOrder.DiscountPercen
    '            lclsReport.GrandTotal = lclsOrder.GrandTotal
    '            lclsReport.GrandTotalSTR = ChangeToThaibathWord(lclsOrder.GrandTotal.ToString)
    '            lclsReport.SaveData()
    '        End If

    '        Dim lclsProList As New ProductListDAO
    '        Dim lclsTmpProList As New TmpProductList
    '        Dim lTableProList As DataTable

    '        lTableProList = lclsProList.GetDataTable(pOrderID, mOrderType.ToString, Nothing, False)
    '        lclsTmpProList.ClearTemp()
    '        For Each pRow As DataRow In lTableProList.Rows
    '            lclsTmpProList.SEQ = pRow.Item("SEQ")
    '            lclsTmpProList.ProductID = pRow.Item("ProductID")
    '            lclsTmpProList.ProductCode = ConvertNullToString(pRow.Item("ProductCode"))
    '            If ConvertNullToString(pRow.Item("ProductNameExt")) <> "" Then
    '                lclsTmpProList.ProductName = ConvertNullToString(pRow.Item("ProductNameExt"))
    '            Else
    '                lclsTmpProList.ProductName = ConvertNullToString(pRow.Item("ProductName"))
    '            End If
    '            lclsTmpProList.ProductNameExt = ""
    '            lclsTmpProList.UnitCode = ConvertNullToString(pRow.Item("UnitName"))
    '            lclsTmpProList.Units = ConvertNullToZero(pRow.Item("Units"))
    '            lclsTmpProList.Cost = ConvertNullToZero(pRow.Item("Cost"))
    '            lclsTmpProList.Price = ConvertNullToZero(pRow.Item("Price"))
    '            lclsTmpProList.Discount = ConvertNullToZero(pRow.Item("Discount"))
    '            lclsTmpProList.Total = ConvertNullToZero(pRow.Item("ToTal"))
    '            lclsTmpProList.Remark = ConvertNullToString(pRow.Item("Remark"))
    '            lclsTmpProList.SaveData()
    '        Next
    '        If lTableProList.Rows.Count < 20 Then
    '            lclsTmpProList.SaveNull(20 - lTableProList.Rows.Count)
    '        End If

    '        ExecuteReport(report, lclsOrder.Code)

    '    Catch ex As Exception
    '        Err.Raise(Err.Number, ex.Source, "modReport.PrintQuotation : " & ex.Message)
    '    Finally

    '        'DataTable = Nothing
    '    End Try
    'End Sub


    'Private Sub PrintClaim(ByVal pOrderID As Long)
    '    Dim report2 As New rptClaim
    '    Dim report As New rptClaimMain
    '    Dim lclsOrder As New OrderSDAO
    '    Dim lclsRefOrder As OrderSDAO
    '    Dim lclsReport As New TmpOrderDAO
    '    Try
    '        If lclsOrder.InitailData(pOrderID) Then
    '            BuildCompanyAddress(lclsReport)

    '            lclsReport.AddressBill = lclsOrder.CustomerDAO.AddressS.AddressLong
    '            If lclsOrder.CustomerDAO.AddressShip.AddressNo = "" And lclsOrder.CustomerDAO.AddressShip.AddressName = "" Then
    '                lclsReport.AddressShip = lclsOrder.CustomerDAO.AddressS.AddressLong
    '            Else
    '                lclsReport.AddressShip = lclsOrder.CustomerDAO.AddressShip.AddressLong
    '            End If

    '            lclsReport.CustomerCode = lclsOrder.CustomerDAO.Code
    '            If lclsOrder.CustomerDAO.FirstName <> "" Then
    '                lclsReport.CustomerName = lclsOrder.CustomerDAO.Title & lclsOrder.CustomerDAO.FirstName & "  " & lclsOrder.CustomerDAO.LastName
    '            Else
    '                lclsReport.CustomerName = lclsOrder.CustomerDAO.CompanyName
    '            End If

    '            lclsReport.Employee = lclsOrder.EmployeeDAO.FirstName
    '            lclsReport.CustomerPhone = lclsOrder.CustomerDAO.AddressS.Phone1
    '            lclsReport.CustomerFAX = lclsOrder.CustomerDAO.AddressS.Fax
    '            lclsReport.OrderCode = lclsOrder.Code
    '            lclsReport.OrderDate = lclsOrder.OrderDate
    '            lclsReport.ShipingDate = lclsOrder.ShipingDate
    '            lclsReport.ExpireDate = lclsOrder.ExpireDate
    '            lclsReport.QuotationDays = lclsOrder.QuotationDays

    '            lclsReport.Remark = lclsOrder.Remark
    '            lclsReport.SendBy = lclsOrder.SendBy
    '            lclsReport.ShipingDate = lclsOrder.ShipingDate
    '            lclsReport.Total = lclsOrder.Total
    '            lclsReport.VatAmount = lclsOrder.VatAmount
    '            lclsReport.VatPercen = lclsOrder.VatPercen
    '            lclsReport.DiscountAmount = lclsOrder.DiscountAmount
    '            lclsReport.DiscountPercen = lclsOrder.DiscountPercen
    '            lclsReport.GrandTotal = lclsOrder.GrandTotal
    '            lclsReport.GrandTotalSTR = ChangeToThaibathWord(lclsOrder.GrandTotal.ToString)
    '            If lclsOrder.RefOrderID > 0 Then
    '                lclsRefOrder = New OrderSDAO
    '                If lclsRefOrder.InitailData(lclsOrder.RefOrderID) = True Then
    '                    lclsReport.PO = lclsRefOrder.Code
    '                End If
    '            End If
    '            lclsReport.SaveData()
    '        End If

    '        Dim lclsProList As New ProductListDAO
    '        Dim lclsTmpProList As New TmpProductList
    '        Dim lTableProList As DataTable

    '        lTableProList = lclsProList.GetDataTable(pOrderID, mOrderType.ToString, Nothing, False)
    '        lclsTmpProList.ClearTemp()
    '        For Each pRow As DataRow In lTableProList.Rows
    '            lclsTmpProList.SEQ = pRow.Item("SEQ")
    '            lclsTmpProList.ProductID = pRow.Item("ProductID")
    '            lclsTmpProList.ProductCode = ConvertNullToString(pRow.Item("ProductCode"))
    '            If ConvertNullToString(pRow.Item("ProductNameExt")) <> "" Then
    '                lclsTmpProList.ProductName = ConvertNullToString(pRow.Item("ProductNameExt"))
    '            Else
    '                lclsTmpProList.ProductName = ConvertNullToString(pRow.Item("ProductName"))
    '            End If
    '            lclsTmpProList.ProductNameExt = ""
    '            lclsTmpProList.UnitCode = ConvertNullToString(pRow.Item("UnitName"))
    '            lclsTmpProList.Units = ConvertNullToZero(pRow.Item("Units"))
    '            lclsTmpProList.Cost = ConvertNullToZero(pRow.Item("Cost"))
    '            lclsTmpProList.Price = ConvertNullToZero(pRow.Item("Price"))
    '            lclsTmpProList.Discount = ConvertNullToZero(pRow.Item("Discount"))
    '            lclsTmpProList.Total = ConvertNullToZero(pRow.Item("ToTal"))
    '            lclsTmpProList.Remark = ConvertNullToString(pRow.Item("Remark"))
    '            lclsTmpProList.SaveData()
    '        Next
    '        'If lTableProList.Rows.Count < 20 Then
    '        '    lclsTmpProList.SaveNull(20 - lTableProList.Rows.Count)
    '        'End If

    '        ExecuteReport(report, lclsOrder.Code, report2)

    '    Catch ex As Exception
    '        Err.Raise(Err.Number, ex.Source, "modReport.PrintClaim : " & ex.Message)
    '    Finally

    '        'DataTable = Nothing
    '    End Try
    'End Sub

    'Public Sub PrintPayment(ByVal pOrderID As Long)
    '    Dim report As New rptPayment
    '    Dim lclsOrder As New OrderSDAO
    '    Dim lclsReport As New TmpOrderDAO
    '    Try
    '        If lclsOrder.InitailData(pOrderID) Then

    '            If lclsOrder.CustomerDAO.FirstName <> "" Then
    '                lclsReport.CustomerName = lclsOrder.CustomerDAO.Title & lclsOrder.CustomerDAO.FirstName & "  " & lclsOrder.CustomerDAO.LastName
    '            Else
    '                lclsReport.CustomerName = lclsOrder.CustomerDAO.CompanyName
    '            End If
    '            lclsReport.OrderCode = lclsOrder.Code
    '            lclsReport.OrderDate = lclsOrder.OrderDate

    '            'Cheque Detail
    '            Dim lTableCheque As DataTable
    '            Dim lclsCheque As New ChequeDAO
    '            Dim lclsBank As New BankDAO

    '            lTableCheque = lclsCheque.GetDataTable(pOrderID)
    '            For Each pRow As DataRow In lTableCheque.Rows
    '                lclsReport.Company = ConvertNullToString(pRow.Item("BankDocType")) & "  " & ConvertNullToString(pRow.Item("ChequeNo"))
    '                lclsBank.InitailData(ConvertNullToString(pRow.Item("BankID")), Nothing)
    '                lclsReport.CompanyWeb = lclsBank.NameThai
    '                lclsReport.ShipingDate = pRow.Item("ChequeDate")
    '                lclsReport.GrandTotal = ConvertNullToString(pRow.Item("ChequePay"))
    '            Next
    '            lclsReport.SaveData()
    '        End If

    '        Dim lclsList As New OrderSDetailDAO
    '        Dim lclsTmpProList As New TmpProductList
    '        Dim lTableList As DataTable

    '        lTableList = lclsList.GetDataTable(pOrderID, Nothing)
    '        lclsTmpProList.ClearTemp()
    '        For Each pRow As DataRow In lTableList.Rows
    '            lclsTmpProList.ProductCode = ConvertNullToString(pRow.Item("OrderCode"))
    '            lclsOrder = New OrderSDAO
    '            If lclsOrder.InitailData(ConvertNullToZero(pRow.Item("OrderID"))) = True Then
    '                lclsTmpProList.OrderDate = lclsOrder.OrderDate
    '                lclsTmpProList.ExpiryDate = lclsOrder.ExpireDate
    '            End If
    '            lclsTmpProList.Total = ConvertNullToZero(pRow.Item("BillTotal"))
    '            lclsTmpProList.SaveData()
    '        Next
    '        'If lTableProList.Rows.Count < 20 Then
    '        '    lclsTmpProList.SaveNull(20 - lTableProList.Rows.Count)
    '        'End If

    '        ExecuteReport(report, lclsOrder.Code)

    '    Catch ex As Exception
    '        Err.Raise(Err.Number, ex.Source, "modReport.PrintPayment : " & ex.Message)
    '    Finally

    '        'DataTable = Nothing
    '    End Try
    'End Sub


    'Private Sub PrintBill(ByVal pOrderID As Long)
    '    Dim report As New XtraReport
    '    Dim lclsOrder As New OrderSDAO
    '    Dim lclsReport As New TmpOrderDAO
    '    Try
    '        Select Case mOrderType
    '            Case MasterType.Bill
    '                report = New rptBillReport
    '            Case MasterType.Receipt
    '                report = New rptReceipt
    '        End Select
    '        If lclsOrder.InitailData(pOrderID) Then
    '            'Set company header
    '            BuildCompanyAddress(lclsReport)
    '            lclsReport.AddressBill = lclsOrder.CustomerDAO.AddressS.AddressLong
    '            If lclsOrder.CustomerDAO.AddressShip.AddressNo = "" And lclsOrder.CustomerDAO.AddressShip.AddressName = "" Then
    '                lclsReport.AddressShip = lclsOrder.CustomerDAO.AddressS.AddressLong
    '            Else
    '                lclsReport.AddressShip = lclsOrder.CustomerDAO.AddressShip.AddressLong
    '            End If
    '            lclsReport.CustomerCode = lclsOrder.CustomerDAO.Code
    '            If lclsOrder.CustomerDAO.FirstName <> "" Then
    '                lclsReport.CustomerName = lclsOrder.CustomerDAO.Title & lclsOrder.CustomerDAO.FirstName & "  " & lclsOrder.CustomerDAO.LastName
    '            Else
    '                lclsReport.CustomerName = lclsOrder.CustomerDAO.CompanyName
    '            End If
    '            lclsReport.Employee = lclsOrder.CustomerDAO.EmployeeDAO.FirstName
    '            lclsReport.CustomerPhone = lclsOrder.CustomerDAO.AddressS.Phone1
    '            lclsReport.CustomerFAX = lclsOrder.CustomerDAO.AddressS.Fax
    '            lclsReport.CustomerTax = lclsOrder.CustomerDAO.HistoryDAO.TaxID
    '            lclsReport.OrderCode = lclsOrder.Code
    '            lclsReport.OrderDate = lclsOrder.OrderDate
    '            lclsReport.ExpireDate = lclsOrder.ExpireDate
    '            lclsReport.PO = lclsOrder.PO
    '            lclsReport.Remark = lclsOrder.Remark
    '            lclsReport.SendBy = lclsOrder.SendBy
    '            lclsReport.ShipingDate = lclsOrder.ShipingDate
    '            lclsReport.Total = lclsOrder.Total
    '            lclsReport.VatAmount = lclsOrder.VatAmount
    '            lclsReport.VatPercen = lclsOrder.VatPercen
    '            lclsReport.DiscountAmount = lclsOrder.DiscountAmount
    '            lclsReport.DiscountPercen = lclsOrder.DiscountPercen
    '            lclsReport.GrandTotal = lclsOrder.GrandTotal
    '            lclsReport.GrandTotalSTR = ChangeToThaibathWord(lclsOrder.GrandTotal.ToString)
    '            lclsReport.SaveData()
    '        End If

    '        Dim lclsProList As New OrderSDetailDAO
    '        Dim lclsTmpProList As New TmpProductList
    '        Dim lTableProList As DataTable
    '        Dim i As Integer = 1

    '        lTableProList = lclsProList.GetDataTable(pOrderID, Nothing)
    '        lclsTmpProList.ClearTemp()
    '        For Each pRow As DataRow In lTableProList.Rows
    '            lclsTmpProList.SEQ = i
    '            lclsTmpProList.ProductID = pRow.Item("OrderID")
    '            lclsTmpProList.ProductName = ConvertNullToString(pRow.Item("OrderCode"))
    '            lclsTmpProList.OrderDate = pRow.Item("OrderDate")
    '            lclsOrder = New OrderSDAO
    '            If lclsOrder.InitailData(lclsTmpProList.ProductID) = True Then
    '                'lclsTmpProList.OrderDate = lclsOrder.OrderDate
    '                lclsTmpProList.ExpiryDate = lclsOrder.ExpireDate
    '            End If
    '            lclsTmpProList.Total = ConvertNullToZero(pRow.Item("BillTotal"))
    '            lclsTmpProList.Remark = ConvertNullToString(pRow.Item("Remark"))
    '            lclsTmpProList.SaveData()
    '            i = i + 1
    '        Next

    '        ExecuteReport(report, lclsOrder.Code)
    '    Catch ex As Exception
    '        Err.Raise(Err.Number, ex.Source, "modReport.PrintBill : " & ex.Message)
    '    Finally
    '    End Try
    'End Sub

    'Public Sub PrintTaxAtPay(ByVal pOrderID As Long, ByVal pTaxNo As String, ByVal pReportDate As Date)
    '    Dim report As New XtraReport
    '    Dim lclsOrder As New OrderSDAO
    '    Dim lclsReport As New TmpOrderDAO
    '    Dim ldtpOrderDate As Date
    '    Dim lTotal As Double = 0, lTaxTotal As Double = 0
    '    Try

    '        report = New rptTaxAtPay

    '        If lclsOrder.InitailData(pOrderID) Then
    '            'Set company header
    '            BuildCompanyAddress(lclsReport)
    '            lclsReport.AddressBill = lclsOrder.CustomerDAO.AddressS.AddressLong
    '            If lclsOrder.CustomerDAO.AddressShip.AddressNo = "" And lclsOrder.CustomerDAO.AddressShip.AddressName = "" Then
    '                lclsReport.AddressShip = lclsOrder.CustomerDAO.AddressS.AddressLong
    '            Else
    '                lclsReport.AddressShip = lclsOrder.CustomerDAO.AddressShip.AddressLong
    '            End If
    '            lclsReport.CustomerCode = lclsOrder.CustomerDAO.Code
    '            If lclsOrder.CustomerDAO.FirstName <> "" Then
    '                lclsReport.CustomerName = lclsOrder.CustomerDAO.Title & lclsOrder.CustomerDAO.FirstName & "  " & lclsOrder.CustomerDAO.LastName
    '            Else
    '                lclsReport.CustomerName = lclsOrder.CustomerDAO.CompanyName
    '            End If
    '            lclsReport.Employee = lclsOrder.CustomerDAO.EmployeeDAO.CustomerName
    '            lclsReport.CustomerPhone = lclsOrder.CustomerDAO.AddressS.Phone1
    '            lclsReport.CustomerFAX = lclsOrder.CustomerDAO.AddressS.Fax
    '            lclsReport.CustomerTax = lclsOrder.CustomerDAO.HistoryDAO.TaxID
    '            lclsReport.OrderCode = lclsOrder.Code
    '            lclsReport.OrderDate = lclsOrder.OrderDate
    '            lclsReport.ExpireDate = lclsOrder.ExpireDate
    '            lclsReport.PO = lclsOrder.PO
    '            lclsReport.Remark = lclsOrder.Remark
    '            lclsReport.SendBy = lclsOrder.SendBy
    '            lclsReport.ShipingDate = lclsOrder.ShipingDate
    '            lclsReport.Total = lclsOrder.Total
    '            lclsReport.VatAmount = lclsOrder.VatAmount
    '            lclsReport.VatPercen = lclsOrder.VatPercen
    '            lclsReport.DiscountAmount = lclsOrder.DiscountAmount
    '            lclsReport.DiscountPercen = lclsOrder.DiscountPercen
    '            lclsReport.GrandTotal = lclsOrder.GrandTotal
    '            lclsReport.GrandTotalSTR = ChangeToThaibathWord(lclsOrder.GrandTotal)
    '            lclsReport.SaveData()

    '            ldtpOrderDate = lclsOrder.OrderDate


    '            Dim lclsProList As New TaxOrderDAO
    '            Dim lTableProList As DataTable
    '            Dim SQL As String
    '            Dim myCommand As SqlCommand

    '            SQL = " DELETE FROM TmpTax WHERE UserID=@UserID "
    '            myCommand = New SqlCommand
    '            myCommand.CommandText = SQL
    '            myCommand.Parameters.Add(New SqlParameter("@UserID", gUserID))
    '            gConnection.executeInsertSqlCommand(myCommand, Nothing)

    '            'Insert blank row    
    '            SQL = " INSERT INTO TmpTax (UserID,SEQ,TaxType_Desc,TaxDate1,TaxDate2,TaxDate3,TaxDate4,TaxDate5,TaxDate6,TaxDate7,TaxDate8,TaxDate9,TaxDate10,TaxDate11,TaxDate12"
    '            SQL = SQL & " ,TaxTotal1,TaxTotal2,TaxTotal3,TaxTotal4,TaxTotal5,TaxTotal6,TaxTotal7,TaxTotal8,TaxTotal9,TaxTotal10,TaxTotal11,TaxTotal12 "
    '            SQL = SQL & " ,TaxAmount1,TaxAmount2,TaxAmount3,TaxAmount4,TaxAmount5,TaxAmount6,TaxAmount7,TaxAmount8,TaxAmount9,TaxAmount10,TaxAmount11,TaxAmount12 )"
    '            SQL = SQL & " VALUES ( " & gUserID
    '            SQL = SQL & " ,1,''" 'TaxType_Desc
    '            SQL = SQL & " ,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null" 'TaxDate
    '            SQL = SQL & " ,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null" 'TaxTotal
    '            SQL = SQL & " ,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null" 'TaxAmount
    '            SQL = SQL & " ) "

    '            myCommand = New SqlCommand
    '            myCommand.CommandText = SQL
    '            gConnection.executeInsertSqlCommand(myCommand, Nothing)

    '            'Loop to update by Tax Type
    '            lTableProList = lclsProList.GetDataTableByTaxNo(pTaxNo)
    '            For Each pRow As DataRow In lTableProList.Rows
    '                SQL = " Update TmpTax Set "
    '                SQL = SQL & " TaxDate" & ConvertNullToZero(pRow.Item("TaxTypeID")) & "='" & formatSQLDate(ldtpOrderDate) & "'"
    '                SQL = SQL & " ,TaxTotal" & ConvertNullToZero(pRow.Item("TaxTypeID")) & "=" & ConvertNullToZero(pRow.Item("TaxTotal"))
    '                SQL = SQL & " ,TaxAmount" & ConvertNullToZero(pRow.Item("TaxTypeID")) & "=" & ConvertNullToZero(pRow.Item("TaxAmount"))
    '                If ConvertNullToZero(pRow.Item("TaxTypeID")) = 12 Then ' Other
    '                    SQL = SQL & " ,TaxType_Desc ='" & ConvertNullToString(pRow.Item("OtherTax")) & "'"
    '                End If
    '                lTotal = lTotal + ConvertNullToZero(pRow.Item("TaxTotal"))
    '                lTaxTotal = lTaxTotal + ConvertNullToZero(pRow.Item("TaxAmount"))

    '                myCommand = New SqlCommand
    '                myCommand.CommandText = SQL
    '                gConnection.executeInsertSqlCommand(myCommand, Nothing)
    '            Next

    '            lclsReport.Total = lTotal
    '            lclsReport.VatAmount = lTaxTotal
    '            lclsReport.GrandTotalSTR = ChangeToThaibathWord(lTaxTotal)
    '            lclsReport.OrderDate = pReportDate
    '            lclsReport.SaveData()

    '            ExecuteReportTax(report, "Tax")
    '        End If
    '    Catch ex As Exception
    '        Err.Raise(Err.Number, ex.Source, "modReport.PrintTaxAtPay : " & ex.Message)
    '    Finally
    '    End Try
    'End Sub


    'Public Sub PrintCheque(ByVal pChequeID As Long, ByVal pcls As ChequeDAO)
    '    Dim report As New XtraReport
    '    Dim lclsReport As New TmpOrderDAO

    '    Try
    '        report = New rptCheque
    '        lclsReport.SaveData()

    '        Dim lclsProList As New ChequeDAO
    '        Dim lTableProList As DataTable
    '        Dim SQL As String, lstrBank As String = ""
    '        Dim myCommand As SqlCommand
    '        Dim lclsBank As New BankDAO
    '        Dim lSEQ As Long = 1
    '        SQL = " DELETE FROM TmpTax WHERE UserID=@UserID "
    '        myCommand = New SqlCommand
    '        myCommand.CommandText = SQL
    '        myCommand.Parameters.Add(New SqlParameter("@UserID", gUserID))
    '        gConnection.executeInsertSqlCommand(myCommand, Nothing)

    '        If pChequeID > 0 Then
    '            lTableProList = lclsProList.GetDataTable(-1, 0, , , , pChequeID)
    '            For Each pRow As DataRow In lTableProList.Rows

    '                If lclsBank.InitailData(ConvertNullToZero(pRow.Item("BankID")), Nothing) Then
    '                    lstrBank = lclsBank.NameThai
    '                End If

    '                SQL = " INSERT INTO TmpTax (UserID,SEQ,TaxText1,TaxText2,TaxDate1,TaxText3,TaxAmount1,TaxText4,TaxText5 )"
    '                SQL = SQL & " VALUES ( " & gUserID
    '                SQL = SQL & ", " & lSEQ
    '                SQL = SQL & " ,'" & ConvertNullToString(pRow.Item("BankDocType")) & "'"   'TaxText1
    '                SQL = SQL & " ,'" & ConvertNullToString(pRow.Item("ChequeNo")) & "'"      'TaxText2
    '                SQL = SQL & " ,'" & formatSQLDate(pRow.Item("ChequeDateReceive")) & "'"          'TaxDate1
    '                SQL = SQL & " ,'" & lstrBank & "'"                                        'TaxText3
    '                SQL = SQL & " ," & ConvertNullToZero(pRow.Item("ChequePay"))              'TaxAmount1    
    '                SQL = SQL & " ,'" & ChangeToThaibathWord(ConvertNullToZero(pRow.Item("ChequePay"))) & "'"        'TaxText4 
    '                SQL = SQL & " ,'" & ConvertNullToString(pRow.Item("ChequeOwnerTH")) & "'"   'TaxText5
    '                SQL = SQL & " ) "
    '                myCommand = New SqlCommand
    '                myCommand.CommandText = SQL
    '                gConnection.executeInsertSqlCommand(myCommand, Nothing)
    '                lSEQ = lSEQ + 1
    '            Next
    '        ElseIf IsNothing(pcls) = False Then
    '            If lclsBank.InitailData(pcls.BankID, Nothing) Then
    '                lstrBank = lclsBank.NameThai
    '            End If

    '            SQL = " INSERT INTO TmpTax (UserID,SEQ,TaxText1,TaxText2,TaxDate1,TaxText3,TaxAmount1,TaxText4,TaxText5 )"
    '            SQL = SQL & " VALUES ( " & gUserID
    '            SQL = SQL & ", " & lSEQ
    '            SQL = SQL & " ,'" & ConvertNullToString(pcls.BankDocType) & "'"   'TaxText1
    '            SQL = SQL & " ,'" & ConvertNullToString(pcls.ChequeNo) & "'"      'TaxText2
    '            SQL = SQL & " ,'" & formatSQLDate(pcls.ChequeDateReceive) & "'"          'TaxDate1
    '            SQL = SQL & " ,'" & lstrBank & "'"                                        'TaxText3
    '            SQL = SQL & " ," & ConvertNullToZero(pcls.ChequePay)              'TaxAmount1    
    '            SQL = SQL & " ,'" & ChangeToThaibathWord(ConvertNullToZero(pcls.ChequePay)) & "'"        'TaxText4 
    '            SQL = SQL & " ,'" & ConvertNullToString(pcls.ChequeOwnerTH) & "'"   'TaxText5
    '            SQL = SQL & " ) "
    '            myCommand = New SqlCommand
    '            myCommand.CommandText = SQL
    '            gConnection.executeInsertSqlCommand(myCommand, Nothing)
    '        Else
    '            Exit Sub
    '        End If


    '        ExecuteReportTax(report, "Cheque")
    '    Catch ex As Exception
    '        Err.Raise(Err.Number, ex.Source, "modReport.PrintCheque : " & ex.Message)
    '    Finally
    '    End Try
    'End Sub



    'Public Sub PrintBarCode(ByVal pProName As String, ByVal pBarCodeList As List(Of SnDAO))
    '    Dim report As New XtraReport
    '    Dim lclsReport As New TmpOrderDAO
    '    Try
    '        report = New rptBarcode
    '        Dim SQL As String, lSEQ As Long = 1, lCount As Long = 0
    '        Dim lSN(4) As String

    '        SQL = " DELETE FROM TmpTax WHERE UserID= " & gUserID
    '        gConnection.executeInsertQuery(SQL, Nothing)

    '        lSN(0) = "0"
    '        lSN(1) = "0"
    '        lSN(2) = "0"
    '        lSN(3) = "0"
    '        lSN(4) = "0"
    '        pProName = Left(pProName, 25)
    '        For Each pBarcode As SnDAO In pBarCodeList
    '            If lCount <= 4 Then
    '                lSN(lCount) = pBarcode.SerialNumberNo
    '                lCount = lCount + 1
    '            Else
    '                SQL = " INSERT INTO TmpTax (UserID,SEQ,TaxText1,TaxText2,TaxText3,TaxText4,TaxText5,TaxText6  )"
    '                SQL = SQL & " VALUES ( " & gUserID
    '                SQL = SQL & ", " & lSEQ
    '                SQL = SQL & "  ,'" & ConvertNullToString(lSN(0)) & "'"
    '                SQL = SQL & "  ,'" & ConvertNullToString(lSN(1)) & "'"
    '                SQL = SQL & "  ,'" & ConvertNullToString(lSN(2)) & "'"
    '                SQL = SQL & "  ,'" & ConvertNullToString(lSN(3)) & "'"
    '                SQL = SQL & "  ,'" & ConvertNullToString(lSN(4)) & "'"
    '                SQL = SQL & "  ,'" & pProName & "'"
    '                SQL = SQL & " ) "

    '                gConnection.executeInsertQuery(SQL, Nothing)


    '                lSEQ = lSEQ + 1
    '                lCount = 0

    '                lSN(lCount) = pBarcode.SerialNumberNo
    '                lCount = lCount + 1
    '                'lSN(0) = ""
    '                lSN(1) = "0"
    '                lSN(2) = "0"
    '                lSN(3) = "0"
    '                lSN(4) = "0"
    '            End If
    '        Next

    '        If lCount > 0 Then
    '            SQL = " INSERT INTO TmpTax (UserID,SEQ,TaxText1,TaxText2,TaxText3,TaxText4,TaxText5,TaxText6  )"
    '            SQL = SQL & " VALUES ( " & gUserID
    '            SQL = SQL & ", " & lSEQ
    '            SQL = SQL & "  ,'" & ConvertNullToString(lSN(0)) & "'"
    '            SQL = SQL & "  ,'" & ConvertNullToString(lSN(1)) & "'"
    '            SQL = SQL & "  ,'" & ConvertNullToString(lSN(2)) & "'"
    '            SQL = SQL & "  ,'" & ConvertNullToString(lSN(3)) & "'"
    '            SQL = SQL & "  ,'" & ConvertNullToString(lSN(4)) & "'"
    '            SQL = SQL & "  ,'" & pProName & "'"
    '            SQL = SQL & " ) "
    '            gConnection.executeInsertQuery(SQL, Nothing)
    '            lSEQ = lSEQ + 1
    '        End If
    '        ExecuteReportBarCode(report, "BarCode")
    '    Catch ex As Exception
    '        Err.Raise(Err.Number, ex.Source, "modReport.PrintBarCode : " & ex.Message)
    '    Finally
    '    End Try
    'End Sub




    'Public Sub PrintBarCode(ByVal pProName As String, ByVal pBarCodeList As List(Of SnDAO), ByVal pPrintProName As Boolean)
    '    Dim report As New XtraReport
    '    Dim lclsReport As New TmpOrderDAO
    '    Try
    '        If pPrintProName = True Then
    '            report = New rptBarcode
    '        Else
    '            report = New rptBarcode2
    '        End If

    '        Dim SQL As String, lSEQ As Long = 1
    '        Dim lSN As String

    '        SQL = " DELETE FROM TmpTax WHERE UserID= " & gUserID
    '        gConnection.executeInsertQuery(SQL, Nothing)

    '        lSN = "0"
    '        pProName = Left(pProName, 25)
    '        For Each pBarcode As SnDAO In pBarCodeList
    '            lSN = pBarcode.SerialNumberNo
    '            SQL = " INSERT INTO TmpTax (UserID,SEQ,TaxText1,TaxText6  )"
    '            SQL = SQL & " VALUES ( " & gUserID
    '            SQL = SQL & ", " & lSEQ
    '            SQL = SQL & "  ,'*" & ConvertNullToString(lSN).ToUpper & "*'"
    '            SQL = SQL & "  ,'*" & ConvertNullToString(lSN) & "*'"
    '            SQL = SQL & "  ,'" & pProName & "'"
    '            SQL = SQL & " ) "
    '            gConnection.executeInsertQuery(SQL, Nothing)
    '            lSEQ = lSEQ + 1
    '        Next

    '        ExecuteReportBarCode(report, "BarCode")
    '    Catch ex As Exception
    '        Err.Raise(Err.Number, ex.Source, "modReport.PrintBarCode : " & ex.Message)
    '    Finally
    '    End Try
    'End Sub


    'Public Sub ExecuteReport(ByVal pReport As XtraReport, ByVal pReportCode As String, Optional ByVal pReportSub As XtraReport = Nothing)
    '    Dim SQL As String
    '    Dim lDataTable As DBConnection.DataTableList
    '    Dim lDataTableList As New List(Of DBConnection.DataTableList)
    '    Try
    '        SQL = "SELECT TmpOrders.* "
    '        SQL = SQL & " FROM TmpOrders  "
    '        SQL = SQL & " WHERE UserID= " & gUserID
    '        lDataTable = New DBConnection.DataTableList
    '        lDataTable.SQL = SQL
    '        lDataTable.TableName = "TmpOrders"
    '        lDataTableList.Add(lDataTable)

    '        SQL = "SELECT TmpProductList.* "
    '        SQL = SQL & " FROM TmpProductList  "
    '        SQL = SQL & " WHERE UserID= " & gUserID
    '        SQL = SQL & " Order by SEQ"
    '        lDataTable = New DBConnection.DataTableList
    '        lDataTable.SQL = SQL
    '        lDataTable.TableName = "TmpProductList"
    '        lDataTableList.Add(lDataTable)

    '        pReport.DataSource = gConnection.executeSelectDS(lDataTableList)
    '        'If IsNothing(pReportSub) = False Then
    '        '    pReportSub.DataSource = gConnection.executeSelectDS(lDataTableList)
    '        'End If
    '        Dim lfrmReport As New frmPreReport
    '        lfrmReport.InitialForm(pReport, pReportCode)
    '        lfrmReport.ShowDialog()
    '        'pReport.ShowPreview()

    '        'Using printTool As New ReportPrintTool(pReport)
    '        '    pReport.
    '        'End Using
    '    Catch ex As Exception
    '        Err.Raise(Err.Number, ex.Source, "modReport.ExecuteReport : " & ex.Message)
    '    Finally
    '    End Try
    'End Sub

    'Public Sub ExecuteReportTax(ByVal pReport As XtraReport, ByVal pReportName As String)
    '    Dim SQL As String
    '    Dim lDataTable As DBConnection.DataTableList
    '    Dim lDataTableList As New List(Of DBConnection.DataTableList)
    '    Try
    '        SQL = "SELECT TmpOrders.* "
    '        SQL = SQL & " FROM TmpOrders  "
    '        SQL = SQL & " WHERE UserID= " & gUserID
    '        lDataTable = New DBConnection.DataTableList
    '        lDataTable.SQL = SQL
    '        lDataTable.TableName = "TmpOrders"
    '        lDataTableList.Add(lDataTable)

    '        SQL = "SELECT TmpTax.* "
    '        SQL = SQL & " FROM TmpTax  "
    '        SQL = SQL & " WHERE UserID= " & gUserID
    '        'SQL = SQL & " Order by SEQ"
    '        lDataTable = New DBConnection.DataTableList
    '        lDataTable.SQL = SQL
    '        lDataTable.TableName = "TmpTax"
    '        lDataTableList.Add(lDataTable)

    '        pReport.DataSource = gConnection.executeSelectDS(lDataTableList)
    '        Dim lfrmReport As New frmPreReport
    '        lfrmReport.InitialForm(pReport, pReportName)
    '        lfrmReport.ShowDialog()
    '        'pReport.ShowPreview()

    '    Catch ex As Exception
    '        Err.Raise(Err.Number, ex.Source, "modReport.ExecuteReportTax : " & ex.Message)
    '    Finally
    '    End Try
    'End Sub

    'Public Sub ExecuteReportBarCode(ByVal pReport As XtraReport, ByVal pReportName As String)
    '    Dim SQL As String
    '    Dim lDataTable As DBConnection.DataTableList
    '    Dim lDataTableList As New List(Of DBConnection.DataTableList)
    '    Try

    '        SQL = "SELECT TmpTax.* "
    '        SQL = SQL & " FROM TmpTax  "
    '        SQL = SQL & " WHERE UserID= " & gUserID
    '        lDataTable = New DBConnection.DataTableList
    '        lDataTable.SQL = SQL
    '        lDataTable.TableName = "TmpTax"
    '        lDataTableList.Add(lDataTable)

    '        pReport.DataSource = gConnection.executeSelectDS(lDataTableList)
    '        Dim lfrmReport As New frmPreReport
    '        lfrmReport.InitialForm(pReport, pReportName)
    '        lfrmReport.ShowDialog()

    '    Catch ex As Exception
    '        Err.Raise(Err.Number, ex.Source, "modReport.ExecuteReportTax : " & ex.Message)
    '    Finally
    '    End Try
    'End Sub

    Public Sub BuildCompanyAddress(ByRef pclsReport As TmpOrderDAO)
        Dim lclsCompanyDAO As New CompanyDAO
        Try
            If lclsCompanyDAO.InitailData(gCompanyID) Then
                pclsReport.Company = lclsCompanyDAO.CompanyName
                If lclsCompanyDAO.Owner = "" Then
                    pclsReport.CompanyOwner = lclsCompanyDAO.CompanyName
                Else
                    pclsReport.CompanyOwner = lclsCompanyDAO.Owner
                End If
                pclsReport.CompanyPhone = lclsCompanyDAO.AddressS.Phone1
                pclsReport.CompanyFAX = lclsCompanyDAO.AddressS.Fax
                pclsReport.CompanyAddress = lclsCompanyDAO.AddressS.AddressShort
                pclsReport.CompanyTax = lclsCompanyDAO.TaxID
                pclsReport.CompanyBankAccount = lclsCompanyDAO.BankAccount
                pclsReport.IsMainCompany = lclsCompanyDAO.IsMainCompany
                pclsReport.CompanyBranch = lclsCompanyDAO.Branch
                pclsReport.CompanyMail = lclsCompanyDAO.AddressS.Email1
                pclsReport.CompanyWeb = lclsCompanyDAO.AddressS.Website
                pclsReport.LogoID = lclsCompanyDAO.HistoryDAO.ImageID
                pclsReport.CompanyBankAccount = lclsCompanyDAO.BankAccount
                If ConvertNullToZero(lclsCompanyDAO.IsMainCompany) = 1 Then  ' *** ใช้กลับกัน 0 = is main , 1 2 3 =Brance
                    pclsReport.IsMainCompany = 0
                Else
                    pclsReport.IsMainCompany = ConvertNullToZero(lclsCompanyDAO.Branch)
                End If
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "modReport.BuildCompanyAddress : " & ex.Message)
        Finally
        End Try
    End Sub

End Module
