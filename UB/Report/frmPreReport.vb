'Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Extensions
Imports DevExpress.XtraReports.UI

Imports System.Data.SqlClient
Imports Zen.Barcode
Imports System.IO
'Imports Spire.Barcode

Public Class frmPreReport
    Private mReportCode As String
    Private mReport As XtraReport
    Private mOrderType As MasterType
    Private mOrderID As Long
    Private mTaxNo As String
    Private mReportDate As Date
    Private mChequeID As Long
    Private mclsCheque As ChequeDAO
    Private mProName As String
    Private mBarCodeList As List(Of SnDAO)


    Public Function InitialForm(ByVal pMasterType As Long, ByVal pOrderID As Long, ByVal pTaxNo As String, ByVal pReportDate As Date _
                                , ByVal pChequeID As Long, ByVal pclsCheque As ChequeDAO _
                                , ByVal pProName As String, ByVal pBarCodeList As List(Of SnDAO), ByVal pReport As XtraReport) As Boolean
        Try

            mOrderID = pOrderID
            mOrderType = pMasterType
            mTaxNo = pTaxNo
            mReportDate = pReportDate
            mChequeID = pChequeID
            mclsCheque = pclsCheque
            mProName = pProName
            mBarCodeList = pBarCodeList
            mReport = pReport
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "frmPreReport.InitialForm : " & e.Message)
            Return False
        End Try


    End Function

    Public Sub PrintReportOrder(ByVal pClaimLoop As Long)
        Try
            Select Case mOrderType
                Case MasterType.SellOrders, MasterType.Invoice, MasterType.Shiping, MasterType.Reserve, MasterType.PurchaseOrder _
                    , MasterType.Quotation, MasterType.Claim, MasterType.ClaimOut, MasterType.ReduceCredit, MasterType.ReduceCreditBuy, MasterType.Borrow, MasterType.Expose, MasterType.ClaimReturn
                    Call PrintOrder(mOrderID, pClaimLoop)
                Case MasterType.Bill, MasterType.Receipt, MasterType.ReceiptBuy
                    Call PrintBill(mOrderID)
                    'Case MasterType.Quotation
                    '    Call PrintQuotation(pOrderID)
                    'Case MasterType.Claim
                    '    Call PrintClaim(pOrderID)
            End Select
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "modReport.PrintReportOrder : " & ex.Message)
        End Try

    End Sub


    Private Sub PrintOrder(ByVal pOrderID As Long, ByVal pClaimLoop As Long)
        Dim report As New XtraReport
        Dim lclsOrder As New OrderSDAO
        Dim lclsCreditRole As New CreditRoleDAO
        Dim lclsShipingMethod As New MasterDAO
        Dim lclsReport As New TmpOrderDAO
        Dim lclsMaster As New MasterDAO
        Dim lclsContactPerson As New CustomerDAO

        Try
            BuildCompanyAddress(lclsReport)
            If lclsOrder.InitailData(pOrderID) Then
                Select Case mOrderType
                    Case MasterType.PurchaseOrder
                        report = New rptPOOrders
                    Case MasterType.SellOrders
                        report = New rptSellOrders
                        lclsReport.Header1 = "ใบสั่งขาย\Sell Order"
                    Case MasterType.Reserve
                        report = New rptSellOrders
                        lclsReport.Header1 = "ใบสั่งจอง"
                    Case MasterType.Quotation
                        report = New rptQuotation
                    Case MasterType.Claim
                        report = New rptClaimMain
                        lclsReport.Header1 = "รับแจ้งเคลม"
                        If pClaimLoop = 1 Then
                            lclsReport.Header2 = "ต้นฉบับ"
                        Else
                            lclsReport.Header2 = "สำเนา(ลูกค้า)"
                        End If
                    Case MasterType.ClaimReturn
                        report = New rptClaimReturn
                        lclsReport.Header1 = "ใบเคลมคืนสินค้า"
                        If pClaimLoop = 1 Then
                            lclsReport.Header2 = "ต้นฉบับ"
                        Else
                            lclsReport.Header2 = "สำเนา(ลูกค้า)"
                        End If
                    Case MasterType.Expose
                        report = New rptExpose
                        lclsReport.Header1 = "รายการเบิก"
                    Case MasterType.Shiping, MasterType.ShipingBuy
                        report = New rptShipingReport
                    Case MasterType.ReduceCredit, MasterType.ReduceCreditBuy
                        report = New rptReduceCredit
                    Case MasterType.Borrow
                        report = New rptBorrow
                    Case Else
                        report = New rptOrdersReport
                End Select

                lclsReport.AddressBill = lclsOrder.CustomerDAO.AddressS.AddressLong
                If IsNothing(lclsOrder.CustomerDAO.AddressShip) = False Then
                    If lclsOrder.CustomerDAO.AddressShip.AddressNo = "" And lclsOrder.CustomerDAO.AddressShip.AddressName = "" Then
                        If IsNothing(lclsOrder.CustomerDAO.AddressS) = False Then
                            lclsReport.AddressShip = lclsOrder.CustomerDAO.AddressS.AddressLong
                        End If
                    Else
                        lclsReport.AddressShip = lclsOrder.CustomerDAO.AddressShip.AddressLong
                    End If
                Else
                    If IsNothing(lclsOrder.CustomerDAO.AddressS) = False Then
                        lclsReport.AddressShip = lclsOrder.CustomerDAO.AddressS.AddressLong
                    Else
                        lclsReport.AddressShip = ""
                    End If
                End If

                If mOrderType = MasterType.Quotation Then
                    lclsReport.ExpireDate = lclsOrder.ExpireDate
                Else
                    lclsReport.ExpireDate = lclsOrder.ExpireDate
                End If

                If lclsOrder.CreditRuleID > 0 Then
                    If lclsCreditRole.InitailData(lclsOrder.CreditRuleID, "") Then
                        lclsReport.CreditRule = lclsCreditRole.NameThai
                        If mOrderType = MasterType.Quotation And lclsCreditRole.CreditDay > 0 Then
                            lclsReport.ExpireDate = DateAdd(DateInterval.Day, lclsCreditRole.CreditDay, lclsOrder.OrderDate)
                        End If
                    Else
                        lclsReport.CreditRule = ""
                    End If
                Else
                    lclsReport.CreditRule = ""
                End If

                lclsReport.CustomerCode = lclsOrder.CustomerDAO.Code
                If lclsOrder.CustomerDAO.FirstName <> "" Then
                    lclsReport.CustomerName = lclsOrder.CustomerDAO.Title & lclsOrder.CustomerDAO.FirstName & "  " & lclsOrder.CustomerDAO.LastName
                Else
                    lclsReport.CustomerName = lclsOrder.CustomerDAO.CompanyName
                End If
                lclsReport.Institute = lclsOrder.Institute

                'ShipingMethodID
                If lclsOrder.ShipingMethodID > 0 Then
                    lclsMaster.InitailData(lclsOrder.ShipingMethodID, MasterType.ShipingMethod)
                    lclsReport.ShipingMethod = lclsMaster.NameThai
                End If

                'ContactPerson
                If IsNothing(lclsOrder.CustomerDAO) = False Then
                    If lclsOrder.CustomerDAO.ContactPersonID > 0 Then
                        If lclsContactPerson.InitailData(lclsOrder.CustomerDAO.ContactPersonID) Then
                            If lclsContactPerson.FirstName <> "" Then
                                lclsReport.ContactPerson = lclsContactPerson.Title & lclsContactPerson.FirstName & "  " & lclsContactPerson.LastName
                            Else
                                lclsReport.ContactPerson = lclsContactPerson.CompanyName
                            End If
                        End If
                    Else
                        lclsReport.ContactPerson = lclsOrder.CustomerDAO.AddressS.ContactName
                    End If
                End If

                'CompanyType
                If lclsOrder.CustomerDAO.CompanyTypeID > 0 Then
                    lclsMaster = New MasterDAO
                    lclsMaster.InitailData(lclsOrder.CustomerDAO.CompanyTypeID, MasterType.CompanyType)
                    lclsReport.CustomerType = lclsMaster.NameThai
                Else
                    lclsReport.CustomerType = ""
                End If

                'ShipingRuleID
                If lclsOrder.ShipingRuleID > 0 Then
                    lclsMaster = New MasterDAO
                    lclsMaster.InitailData(lclsOrder.ShipingRuleID, MasterType.ShipingRule)
                    lclsReport.ShipingRule = lclsMaster.NameThai
                Else
                    lclsReport.ShipingRule = ""
                End If

                lclsReport.RefOrderCode = ""
                lclsReport.RefOrderCode = lclsOrder.GetToRefOrderCode(lclsOrder.ID, Nothing)

                If mOrderType = MasterType.ReduceCredit Or mOrderType = MasterType.ReduceCreditBuy Then
                    Dim lclsRefOreder As New OrderSDAO
                    Dim lTotal As Decimal = 0
                    If lclsOrder.RefToOrderID.Count > 0 Then
                        For Each pRefOrderID As Long In lclsOrder.RefToOrderID
                            If lclsRefOreder.InitailData(pRefOrderID) Then
                                lTotal = lTotal + lclsRefOreder.Total
                            End If
                        Next
                    End If
                    lclsReport.DiscountAmount = lTotal
                ElseIf mOrderType = MasterType.ClaimReturn Then
                    For Each pRefID In lclsOrder.RefToOrderID
                        lclsReport.RefOrderCode = lclsOrder.GetToRefOrderCode(pRefID, Nothing)
                        Exit For
                    Next
                Else
                    lclsReport.DiscountAmount = lclsOrder.DiscountAmount
                End If

                lclsReport.PO = lclsOrder.PO
                If IsNothing(lclsOrder.CustomerDAO.EmployeeDAO) = False Then
                    '*** Use Employee of Customer data
                    lclsReport.Employee = lclsOrder.CustomerDAO.EmployeeDAO.FirstName
                    If IsNothing(lclsOrder.CustomerDAO.EmployeeDAO.AddressS) = False Then
                        lclsReport.EmployeePhone = lclsOrder.CustomerDAO.EmployeeDAO.AddressS.Phone1
                    End If
                    If IsNothing(lclsOrder.CustomerDAO.EmployeeDAO.PositionDAO) = False Then
                        lclsReport.EmployeePosition = lclsOrder.CustomerDAO.EmployeeDAO.PositionDAO.NameThai
                    End If
                End If
                If IsNothing(lclsOrder.CustomerDAO.AddressS) = False Then
                    lclsReport.CustomerPhone = lclsOrder.CustomerDAO.AddressS.Phone1
                    lclsReport.CustomerFAX = lclsOrder.CustomerDAO.AddressS.Fax
                End If
                If IsNothing(lclsOrder.CustomerDAO.HistoryDAO) = False Then
                    lclsReport.CustomerTax = lclsOrder.CustomerDAO.HistoryDAO.TaxID
                End If

                If mOrderType = MasterType.ReduceCreditBuy Then
                    lclsReport.OrderCode = lclsOrder.InvoiceSuplierID
                Else
                    lclsReport.OrderCode = lclsOrder.Code
                End If
                lclsReport.OrderDate = lclsOrder.OrderDate
                lclsReport.SendBy = lclsOrder.SendBy
                lclsShipingMethod.InitailData(lclsOrder.ShipingMethodID, MasterType.ShipingMethod)
                lclsReport.ShipingMethod = lclsShipingMethod.NameThai
                lclsReport.ShipingDate = lclsOrder.ShipingDate
                lclsReport.QuotationDays = lclsOrder.QuotationDays
                lclsReport.Total = lclsOrder.Total
                lclsReport.VatAmount = lclsOrder.VatAmount
                lclsReport.VatPercen = lclsOrder.VatPercen
                lclsReport.DiscountPercen = lclsOrder.DiscountPercen
                lclsReport.GrandTotal = lclsOrder.GrandTotal
                lclsReport.GrandTotalSTR = ChangeToThaibathWord(lclsOrder.GrandTotal.ToString)
                If mOrderType = MasterType.Quotation Then
                    If lclsOrder.QuotationRemarkID > 0 Then
                        lclsMaster = New MasterDAO
                        lclsMaster.InitailData(lclsOrder.QuotationRemarkID, MasterType.QuotationRemark)
                        lclsReport.Remark = lclsMaster.Remark
                    Else
                        lclsReport.Remark = ""
                    End If
                Else
                    lclsReport.Remark = lclsOrder.Remark
                End If

                lclsReport.SaveData()

                Dim lSEQ As Long = 0
                Call InitialProductLine(pOrderID, lSEQ)
                Call InitialProductRemark(pOrderID, lSEQ)
                mReport = report
                ExecuteReport()
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "modReport.PrintOrder : " & ex.Message)
        Finally

        End Try
    End Sub

    Private Sub InitialProductLine(ByVal pOrderID As Long, ByRef pSEQ As Long)
        Try

            Dim lclsProList As New ProductListDAO
            Dim lclsTmpProList As New TmpProductList
            Dim lTableProList As DataTable
            Dim lIsSeqDup As Boolean, lSEQ As Long = 1
            Dim lOrderList As New List(Of Long)
            Dim lSN As SnDAO, lSNTable As DataTable, lSnCodeList As String = ""

            lOrderList.Add(pOrderID)

            lTableProList = lclsProList.GetDataTable(lOrderList, mOrderType.ToString, Nothing, False, "", False, 0, False)
            lIsSeqDup = lclsProList.CheckSeqDup(pOrderID, mOrderType.ToString, Nothing, False)

            lclsTmpProList.ClearTemp()
            For Each pRow As DataRow In lTableProList.Rows

                lclsTmpProList = New TmpProductList

                If lIsSeqDup Then
                    lclsTmpProList.SEQ = lSEQ
                Else
                    lclsTmpProList.SEQ = pRow.Item("SEQ")
                End If

                lclsTmpProList.ProductID = pRow.Item("ProductID")
                lclsTmpProList.ProductCode = ConvertNullToString(pRow.Item("ProductCode"))
                If ConvertNullToString(pRow.Item("ProductNameExt")) <> "" Then
                    lclsTmpProList.ProductName = ConvertNullToString(pRow.Item("ProductNameExt"))
                Else
                    lclsTmpProList.ProductName = ConvertNullToString(pRow.Item("ProductName"))
                End If

                lclsTmpProList.ProductNameExt = ""
                lclsTmpProList.UnitCode = ConvertNullToString(pRow.Item("UnitName"))
                lclsTmpProList.Units = ConvertNullToZero(pRow.Item("AdjustUnit"))
                lclsTmpProList.Cost = ConvertNullToZero(pRow.Item("Cost"))
                lclsTmpProList.Price = ConvertNullToZero(pRow.Item("Price"))
                lclsTmpProList.Discount = ConvertNullToZero(pRow.Item("Discount"))
                lclsTmpProList.Total = ConvertNullToZero(pRow.Item("ToTal"))
                lclsTmpProList.Remark = ConvertNullToString(pRow.Item("Remark"))
                If mOrderType = MasterType.ClaimReturn Then
                    lclsTmpProList.ClaimRemark = ConvertNullToString(pRow.Item("ClaimResult"))
                Else
                    lclsTmpProList.ClaimRemark = ConvertNullToString(pRow.Item("ClaimRemark"))
                End If

                Select Case mOrderType
                    Case MasterType.SellOrders, MasterType.Invoice, MasterType.InvoiceBuy, MasterType.Shiping, MasterType.ShipingBuy, MasterType.PurchaseOrder, MasterType.Borrow, MasterType.Claim, MasterType.Expose
                        lSnCodeList = ""
                        lSN = New SnDAO
                        lSNTable = lSN.GetDataTable(lOrderList, ConvertNullToZero(pRow.Item("ID")), lclsTmpProList.ProductID, "", Nothing, False, "")
                        For Each pRowSn As DataRow In lSNTable.Rows
                            If lSnCodeList = "" Then
                                lSnCodeList = ConvertNullToString(pRowSn.Item("SerialNumberNo"))
                            Else
                                lSnCodeList = lSnCodeList & "," & ConvertNullToString(pRowSn.Item("SerialNumberNo"))
                            End If
                        Next

                        Select Case mOrderType
                            Case MasterType.SellOrders
                                If Len(lclsTmpProList.ProductName) > 25 Then
                                    lclsTmpProList.ProductName = lclsTmpProList.ProductName.Substring(0, 25)
                                End If
                            Case MasterType.Shiping, MasterType.ShipingBuy, MasterType.Borrow, MasterType.Claim, MasterType.Expose
                                If Len(lclsTmpProList.ProductName) > 40 Then
                                    lclsTmpProList.ProductName = lclsTmpProList.ProductName.Substring(0, 40)
                                End If
                            Case MasterType.PurchaseOrder
                                If Len(lclsTmpProList.ProductName) > 120 Then
                                    lclsTmpProList.ProductName = lclsTmpProList.ProductName.Substring(0, 120)
                                End If

                            Case Else
                                If Len(lclsTmpProList.ProductName) > 60 Then
                                    lclsTmpProList.ProductName = lclsTmpProList.ProductName.Substring(0, 60)
                                End If
                        End Select
                        If lSnCodeList <> "" Then
                            lclsTmpProList.ProductName = lclsTmpProList.ProductName & "(" & lSnCodeList & ")"
                        End If

                End Select

                lclsTmpProList.SaveData()
                lSEQ = lSEQ + 1
            Next

            pSEQ = lSEQ
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "modReport.InitialProductLine : " & ex.Message)
        End Try
    End Sub


    Private Sub InitialProductRemark(ByVal pOrderID As Long, ByVal pSEQ As Long)
        Try
            Dim lclsNote As New NoteDAO
            Dim lTableNote As DataTable
            Dim lclsTmpProList As New TmpProductList

            lTableNote = lclsNote.GetDataTable(mOrderType.ToString & "_PRO", pOrderID)
            For Each pRow As DataRow In lTableNote.Rows
                lclsTmpProList.SEQ = pSEQ
                lclsTmpProList.ProductID = 0
                lclsTmpProList.ProductCode = ""
                lclsTmpProList.ProductName = ConvertNullToString(pRow.Item("Description"))
                lclsTmpProList.SaveData()
                pSEQ = pSEQ + 1
            Next
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "modReport.InitialProductRemark : " & ex.Message)
        End Try
    End Sub

    Private Sub PrintBill(ByVal pOrderID As Long)
        Dim report As New XtraReport
        Dim lclsOrder As New OrderSDAO
        Dim lclsReport As New TmpOrderDAO
        Try
            Select Case mOrderType
                Case MasterType.Bill
                    report = New rptBillReport
                Case MasterType.Receipt, MasterType.ReceiptBuy
                    report = New rptReceipt
            End Select
            If lclsOrder.InitailData(pOrderID) Then
                'Set company header
                BuildCompanyAddress(lclsReport)
                lclsReport.AddressBill = lclsOrder.CustomerDAO.AddressS.AddressLong
                If lclsOrder.CustomerDAO.AddressShip.AddressNo = "" And lclsOrder.CustomerDAO.AddressShip.AddressName = "" Then
                    lclsReport.AddressShip = lclsOrder.CustomerDAO.AddressS.AddressLong
                Else
                    lclsReport.AddressShip = lclsOrder.CustomerDAO.AddressShip.AddressLong
                End If
                lclsReport.CustomerCode = lclsOrder.CustomerDAO.Code
                If lclsOrder.CustomerDAO.FirstName <> "" Then
                    lclsReport.CustomerName = lclsOrder.CustomerDAO.Title & lclsOrder.CustomerDAO.FirstName & "  " & lclsOrder.CustomerDAO.LastName
                Else
                    lclsReport.CustomerName = lclsOrder.CustomerDAO.CompanyName
                End If
                lclsReport.Employee = lclsOrder.CustomerDAO.EmployeeDAO.FirstName
                lclsReport.CustomerPhone = lclsOrder.CustomerDAO.AddressS.Phone1
                lclsReport.CustomerFAX = lclsOrder.CustomerDAO.AddressS.Fax
                lclsReport.CustomerTax = lclsOrder.CustomerDAO.HistoryDAO.TaxID
                lclsReport.OrderCode = lclsOrder.Code
                lclsReport.OrderDate = lclsOrder.OrderDate
                lclsReport.ExpireDate = lclsOrder.ExpireDate
                lclsReport.PO = lclsOrder.PO
                lclsReport.Remark = lclsOrder.Remark
                lclsReport.SendBy = lclsOrder.SendBy
                lclsReport.ShipingDate = lclsOrder.ShipingDate
                lclsReport.Total = lclsOrder.Total
                lclsReport.VatAmount = lclsOrder.VatAmount
                lclsReport.VatPercen = lclsOrder.VatPercen
                lclsReport.DiscountAmount = lclsOrder.DiscountAmount
                lclsReport.DiscountPercen = lclsOrder.DiscountPercen
                lclsReport.GrandTotal = lclsOrder.GrandTotal
                lclsReport.GrandTotalSTR = ChangeToThaibathWord(lclsOrder.GrandTotal.ToString)
               
                'lclsReport.SaveData()
            End If

            Dim lclsProList As New OrderSDetailDAO
            Dim lclsTmpProList As New TmpProductList
            Dim lTableProList As DataTable
            Dim i As Integer = 1

            lTableProList = lclsProList.GetDataTable(pOrderID, Nothing)
            lclsTmpProList.ClearTemp()
            For Each pRow As DataRow In lTableProList.Rows
                lclsTmpProList.SEQ = i
                lclsTmpProList.ProductID = pRow.Item("OrderID")
                lclsTmpProList.ProductName = ConvertNullToString(pRow.Item("OrderCode"))
                lclsTmpProList.OrderDate = pRow.Item("OrderDate")
                lclsOrder = New OrderSDAO
                If lclsOrder.InitailData(lclsTmpProList.ProductID) = True Then
                    'lclsTmpProList.OrderDate = lclsOrder.OrderDate
                    lclsTmpProList.ExpiryDate = lclsOrder.ExpireDate
                End If
                lclsTmpProList.Total = ConvertNullToZero(pRow.Item("BillTotal"))
                lclsTmpProList.Remark = ConvertNullToString(pRow.Item("Remark"))


                If mOrderType = MasterType.Bill And i = 1 Then

                    Dim lclsCompanyDAO As New CompanyDAO
                    If lclsCompanyDAO.InitailData(gCompanyID) Then
                        If ConvertNullToZero(pRow.Item("TableID")) = MasterType.Shiping Or ConvertNullToZero(pRow.Item("TableID")) = MasterType.ShipingBuy Then
                            lclsReport.Header2 = lclsCompanyDAO.BankAccount2
                        Else
                            lclsReport.Header2 = lclsCompanyDAO.BankAccount
                        End If
                    End If

                    If ConvertNullToZero(pRow.Item("TableID")) = MasterType.Shiping Or ConvertNullToZero(pRow.Item("TableID")) = MasterType.ShipingBuy Then
                        lclsReport.Header1 = "กรุณาสั่งจ่ายเช็ค ในนาม ""คุณดลพร เล็กอุทัยวรรณ"" พร้อมทั้งขีดคร่อม หรือประทับตรา A/C PAYEE ONLY  และขีดฆ่าผู้ถือ"
                    Else
                        lclsReport.Header1 = "กรุณาสั่งจ่ายในนาม ""บริษัท ยูนิค บิสซิเนส เซ็นเตอร์ จำกัด"" พร้อมทั้งขีดคร่อม หรือประทับตรา A/C PAYEE ONLY และขีดฆ่าผู้ถือ"
                    End If
                End If
                lclsTmpProList.SaveData()
                i = i + 1
            Next
          
           
            lclsReport.SaveData()
            mReport = report
            ExecuteReport()
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "modReport.PrintBill : " & ex.Message)
        Finally
        End Try
    End Sub


    Private Sub PrintPayment(ByVal pOrderID As Long)
        Dim report As New XtraReport
        Dim lclsOrder As New OrderSDAO
        Dim lclsReport As New TmpOrderDAO
        Try
            If lclsOrder.InitailData(pOrderID) Then
                Select Case lclsOrder.TableID
                    Case MasterType.ReceiptBuy
                        report = New rptPaymentBuy
                    Case Else
                        report = New rptPayment
                End Select
                If lclsOrder.CustomerDAO.FirstName <> "" Then
                    lclsReport.CustomerName = lclsOrder.CustomerDAO.Title & lclsOrder.CustomerDAO.FirstName & "  " & lclsOrder.CustomerDAO.LastName
                Else
                    lclsReport.CustomerName = lclsOrder.CustomerDAO.CompanyName
                End If
                lclsReport.OrderCode = lclsOrder.Code
                lclsReport.OrderDate = lclsOrder.OrderDate

                'Cheque Detail
                Dim lTableCheque As DataTable
                Dim lclsCheque As New ChequeDAO
                Dim lclsBank As New BankDAO
                Dim lChequeTotal As Decimal = 0

                lTableCheque = lclsCheque.GetDataTable(pOrderID)
                For Each pRow As DataRow In lTableCheque.Rows
                    lclsReport.Company = ConvertNullToString(pRow.Item("BankDocType")) & "  " & ConvertNullToString(pRow.Item("ChequeNo"))
                    lclsBank.InitailData(ConvertNullToZero(pRow.Item("BankID")), Nothing)
                    lclsReport.CompanyWeb = lclsBank.NameThai
                    lclsReport.ShipingDate = pRow.Item("ChequeDateDue")
                    lChequeTotal = lChequeTotal + ConvertNullToZero(pRow.Item("ChequePay"))
                Next
                lclsReport.GrandTotal = lChequeTotal
                lclsReport.SaveData()
            End If

            Dim lclsList As New OrderSDetailDAO
            Dim lclsTmpProList As New TmpProductList
            Dim lTableList As DataTable

            lTableList = lclsList.GetDataTable(pOrderID, Nothing)
            lclsTmpProList.ClearTemp()
            For Each pRow As DataRow In lTableList.Rows
                lclsTmpProList.ProductCode = ConvertNullToString(pRow.Item("OrderCode"))
                lclsOrder = New OrderSDAO
                If lclsOrder.InitailData(ConvertNullToZero(pRow.Item("OrderID"))) = True Then
                    lclsTmpProList.OrderDate = lclsOrder.OrderDate
                    lclsTmpProList.ExpiryDate = lclsOrder.ExpireDate
                    lclsTmpProList.ProductName = lclsOrder.InvoiceSuplierID
                End If
                lclsTmpProList.Total = ConvertNullToZero(pRow.Item("BillTotal"))
                lclsTmpProList.SaveData()
            Next
            'If lTableProList.Rows.Count < 20 Then
            '    lclsTmpProList.SaveNull(20 - lTableProList.Rows.Count)
            'End If
            mReport = report
            ExecuteReport()

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "modReport.PrintPayment : " & ex.Message)
        Finally

            'DataTable = Nothing
        End Try
    End Sub


    Public Sub PrintTaxAtPay(ByVal pOrderID As Long)
        Dim report As New XtraReport
        Dim lclsOrder As New OrderSDAO
        Dim lclsReport As New TmpOrderDAO
        Dim ldtpOrderDate As Date
        Dim lTotal As Double = 0, lTaxTotal As Double = 0
        Try

            report = New rptTaxAtPay

            If lclsOrder.InitailData(pOrderID) Then
                'Set company header
                BuildCompanyAddress(lclsReport)
                lclsReport.AddressBill = lclsOrder.CustomerDAO.AddressS.AddressLong
                If lclsOrder.CustomerDAO.AddressShip.AddressNo = "" And lclsOrder.CustomerDAO.AddressShip.AddressName = "" Then
                    lclsReport.AddressShip = lclsOrder.CustomerDAO.AddressS.AddressLong
                Else
                    lclsReport.AddressShip = lclsOrder.CustomerDAO.AddressShip.AddressLong
                End If
                lclsReport.CustomerCode = lclsOrder.CustomerDAO.Code
                If lclsOrder.CustomerDAO.FirstName <> "" Then
                    lclsReport.CustomerName = lclsOrder.CustomerDAO.Title & lclsOrder.CustomerDAO.FirstName & "  " & lclsOrder.CustomerDAO.LastName
                Else
                    lclsReport.CustomerName = lclsOrder.CustomerDAO.CompanyName
                End If
                lclsReport.Employee = lclsOrder.CustomerDAO.EmployeeDAO.CustomerName
                lclsReport.CustomerPhone = lclsOrder.CustomerDAO.AddressS.Phone1
                lclsReport.CustomerFAX = lclsOrder.CustomerDAO.AddressS.Fax
                lclsReport.CustomerTax = lclsOrder.CustomerDAO.HistoryDAO.TaxID
                lclsReport.OrderCode = lclsOrder.Code
                lclsReport.OrderDate = lclsOrder.OrderDate
                lclsReport.ExpireDate = lclsOrder.ExpireDate
                lclsReport.PO = lclsOrder.PO
                lclsReport.Remark = lclsOrder.Remark
                lclsReport.SendBy = lclsOrder.SendBy
                lclsReport.ShipingDate = lclsOrder.ShipingDate
                lclsReport.Total = lclsOrder.Total
                lclsReport.VatAmount = lclsOrder.VatAmount
                lclsReport.VatPercen = lclsOrder.VatPercen
                lclsReport.DiscountAmount = lclsOrder.DiscountAmount
                lclsReport.DiscountPercen = lclsOrder.DiscountPercen
                lclsReport.GrandTotal = lclsOrder.GrandTotal
                lclsReport.GrandTotalSTR = ChangeToThaibathWord(lclsOrder.GrandTotal)
                lclsReport.SaveData()

                ldtpOrderDate = lclsOrder.OrderDate


                Dim lclsProList As New TaxOrderDAO
                Dim lTableProList As DataTable
                Dim SQL As String
                Dim myCommand As SqlCommand

                SQL = " DELETE FROM TmpTax WHERE UserID=@UserID "
                myCommand = New SqlCommand
                myCommand.CommandText = SQL
                myCommand.Parameters.Add(New SqlParameter("@UserID", gUserID))
                gConnection.executeInsertSqlCommand(myCommand, Nothing)

                'Insert blank row    
                SQL = " INSERT INTO TmpTax (UserID,SEQ,TaxType_Desc,TaxDate1,TaxDate2,TaxDate3,TaxDate4,TaxDate5,TaxDate6,TaxDate7,TaxDate8,TaxDate9,TaxDate10,TaxDate11,TaxDate12"
                SQL = SQL & " ,TaxTotal1,TaxTotal2,TaxTotal3,TaxTotal4,TaxTotal5,TaxTotal6,TaxTotal7,TaxTotal8,TaxTotal9,TaxTotal10,TaxTotal11,TaxTotal12 "
                SQL = SQL & " ,TaxAmount1,TaxAmount2,TaxAmount3,TaxAmount4,TaxAmount5,TaxAmount6,TaxAmount7,TaxAmount8,TaxAmount9,TaxAmount10,TaxAmount11,TaxAmount12 )"
                SQL = SQL & " VALUES ( " & gUserID
                SQL = SQL & " ,1,''" 'TaxType_Desc
                SQL = SQL & " ,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null" 'TaxDate
                SQL = SQL & " ,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null" 'TaxTotal
                SQL = SQL & " ,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null" 'TaxAmount
                SQL = SQL & " ) "

                myCommand = New SqlCommand
                myCommand.CommandText = SQL
                gConnection.executeInsertSqlCommand(myCommand, Nothing)

                'Loop to update by Tax Type
                lTableProList = lclsProList.GetDataTableByTaxNo(mTaxNo)
                For Each pRow As DataRow In lTableProList.Rows
                    SQL = " Update TmpTax Set "
                    SQL = SQL & " TaxDate" & ConvertNullToZero(pRow.Item("TaxTypeID")) & "='" & formatSQLDate(ldtpOrderDate) & "'"
                    SQL = SQL & " ,TaxTotal" & ConvertNullToZero(pRow.Item("TaxTypeID")) & "=" & ConvertNullToZero(pRow.Item("TaxTotal"))
                    SQL = SQL & " ,TaxAmount" & ConvertNullToZero(pRow.Item("TaxTypeID")) & "=" & ConvertNullToZero(pRow.Item("TaxAmount"))
                    If ConvertNullToZero(pRow.Item("TaxTypeID")) = 12 Then ' Other
                        SQL = SQL & " ,TaxType_Desc ='" & ConvertNullToString(pRow.Item("OtherTax")) & "'"
                    End If
                    lTotal = lTotal + ConvertNullToZero(pRow.Item("TaxTotal"))
                    lTaxTotal = lTaxTotal + ConvertNullToZero(pRow.Item("TaxAmount"))

                    myCommand = New SqlCommand
                    myCommand.CommandText = SQL
                    gConnection.executeInsertSqlCommand(myCommand, Nothing)
                Next

                lclsReport.Total = lTotal
                lclsReport.VatAmount = lTaxTotal
                lclsReport.GrandTotalSTR = ChangeToThaibathWord(lTaxTotal)
                lclsReport.OrderDate = mReportDate
                lclsReport.SaveData()

                mReport = report
                ExecuteReportTax()
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "modReport.PrintTaxAtPay : " & ex.Message)
        Finally
        End Try
    End Sub


    Public Sub PrintCheque()
        Dim report As New XtraReport
        Dim lclsReport As New TmpOrderDAO

        Try
            report = New rptCheque
            lclsReport.SaveData()

            Dim lclsCheque As New ChequeDAO
            Dim lTableProList As DataTable
            Dim SQL As String, lstrBank As String = ""
            Dim myCommand As SqlCommand
            Dim lclsBank As New BankDAO
            Dim lSEQ As Long = 1
            SQL = " DELETE FROM TmpTax WHERE UserID=@UserID "
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@UserID", gUserID))
            gConnection.executeInsertSqlCommand(myCommand, Nothing)

            If mChequeID > 0 Then
                lTableProList = lclsCheque.GetDataTable(-1, 0, , , , mChequeID)
                For Each pRow As DataRow In lTableProList.Rows

                    If lclsBank.InitailData(ConvertNullToZero(pRow.Item("BankID")), Nothing) Then
                        lstrBank = lclsBank.NameThai
                    End If

                    SQL = " INSERT INTO TmpTax (UserID,SEQ,TaxText1,TaxText2,TaxDate1,TaxText3,TaxAmount1,TaxText4,TaxText5 )"
                    SQL = SQL & " VALUES ( " & gUserID
                    SQL = SQL & ", " & lSEQ
                    SQL = SQL & " ,'" & ConvertNullToString(pRow.Item("BankDocType")) & "'"   'TaxText1
                    SQL = SQL & " ,'" & ConvertNullToString(pRow.Item("ChequeNo")) & "'"      'TaxText2
                    SQL = SQL & " ,'" & formatSQLDate(pRow.Item("ChequeDateReceive")) & "'"          'TaxDate1
                    SQL = SQL & " ,'" & lstrBank & "'"                                        'TaxText3
                    SQL = SQL & " ," & ConvertNullToZero(pRow.Item("ChequePay"))              'TaxAmount1    
                    SQL = SQL & " ,'" & ChangeToThaibathWord(ConvertNullToZero(pRow.Item("ChequePay"))) & "'"        'TaxText4 
                    SQL = SQL & " ,'" & ConvertNullToString(pRow.Item("ChequeOwnerTH")) & "'"   'TaxText5
                    SQL = SQL & " ) "
                    myCommand = New SqlCommand
                    myCommand.CommandText = SQL
                    gConnection.executeInsertSqlCommand(myCommand, Nothing)
                    lSEQ = lSEQ + 1
                Next
            ElseIf IsNothing(mclsCheque) = False Then
                If lclsBank.InitailData(mclsCheque.BankID, Nothing) Then
                    lstrBank = lclsBank.NameThai
                End If

                SQL = " INSERT INTO TmpTax (UserID,SEQ,TaxText1,TaxText2,TaxDate1,TaxText3,TaxAmount1,TaxText4,TaxText5 )"
                SQL = SQL & " VALUES ( " & gUserID
                SQL = SQL & ", " & lSEQ
                SQL = SQL & " ,'" & ConvertNullToString(mclsCheque.BankDocType) & "'"   'TaxText1
                SQL = SQL & " ,'" & ConvertNullToString(mclsCheque.ChequeNo) & "'"      'TaxText2
                SQL = SQL & " ,'" & formatSQLDate(mclsCheque.ChequeDateReceive) & "'"          'TaxDate1
                SQL = SQL & " ,'" & lstrBank & "'"                                        'TaxText3
                SQL = SQL & " ," & ConvertNullToZero(mclsCheque.ChequePay)              'TaxAmount1    
                SQL = SQL & " ,'" & ChangeToThaibathWord(ConvertNullToZero(mclsCheque.ChequePay)) & "'"        'TaxText4 
                SQL = SQL & " ,'" & ConvertNullToString(mclsCheque.ChequeOwnerTH) & "'"   'TaxText5
                SQL = SQL & " ) "
                myCommand = New SqlCommand
                myCommand.CommandText = SQL
                gConnection.executeInsertSqlCommand(myCommand, Nothing)
            Else
                Exit Sub
            End If

            mReport = report
            ExecuteReportTax()
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "modReport.PrintCheque : " & ex.Message)
        Finally
        End Try
    End Sub




    Public Sub PrintBarCode()
        Dim report As New XtraReport
        Dim lclsReport As New TmpOrderDAO
        Dim myCommand As SqlCommand
        'Dim bdf As Object
        Try
            report = New rptBarcode2
            'Select Case cboBarcode.EditValue
            '    Case ("Code 11")
            '        bdf = BarcodeDrawFactory.Code11WithChecksum
            'Case "Code 128"
            'bdf = BarcodeDrawFactory.Code128WithChecksum
            '    Case "Code 39"
            'bdf = BarcodeDrawFactory.Code39WithChecksum
            '    Case "Code 93"
            'bdf = BarcodeDrawFactory.Code93WithChecksum
            '    Case "EAN13"
            'bdf = BarcodeDrawFactory.CodeEan13WithChecksum
            '    Case Else
            'bdf = BarcodeDrawFactory.Code93WithChecksum
            'End Select



            Dim SQL As String, lSEQ As Long = 1
            Dim lSN As String

            SQL = " DELETE FROM TmpTax WHERE UserID= " & gUserID
            gConnection.executeInsertQuery(SQL, Nothing)

            lSN = "0"
            If Len(mProName) > 25 Then
                mProName = mProName.Substring(0, 25)
            End If

            Dim bdf As Code128BarcodeDraw = BarcodeDrawFactory.Code128WithChecksum

            'PictureEdit1.Image = bdf.Draw("149A-12345", 20)

            For Each pBarcode As SnDAO In mBarCodeList
                If pBarcode.IsDelete = 0 Then
                    lSN = pBarcode.SerialNumberNo
                    SQL = " INSERT INTO TmpTax (UserID,SEQ,TaxText1,TaxText6,TaxImage  )"
                    SQL = SQL & " VALUES (@UserID "
                    SQL = SQL & ",@SEQ "
                    SQL = SQL & " ,@TaxText1"
                    SQL = SQL & " ,@TaxText6 "
                    SQL = SQL & " ,@TaxImage) "
                    myCommand = New SqlCommand
                    myCommand.CommandText = SQL
                    myCommand.Parameters.Add(New SqlParameter("@UserID", gUserID))
                    myCommand.Parameters.Add(New SqlParameter("@SEQ", lSEQ))
                    myCommand.Parameters.Add(New SqlParameter("@TaxText1", ConvertNullToString(lSN)))
                    myCommand.Parameters.Add(New SqlParameter("@TaxText6", ConvertNullToString(mProName)))
                    'myCommand.Parameters.Add(New SqlParameter("@TaxImage", bdf.Draw(ConvertNullToString(lSN), 20)))
                    Dim ms = New MemoryStream()
                    'bdf.Draw(ConvertNullToString(lSN), 40, 10).Save(ms, System.Drawing.Imaging.ImageFormat.Bmp) ' Use appropriate format here

                    Dim lImage As Image = bdf.Draw(ConvertNullToString(lSN), 50, 20)
                    lImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                    Dim bytes = ms.ToArray()
                    myCommand.Parameters.Add(New SqlParameter("@TaxImage", bytes))
                    gConnection.executeInsertSqlCommand(myCommand, Nothing)
                    lSEQ = lSEQ + 1

                    PictureEdit1.Image = lImage
                End If
            Next
            mReport = report
            ExecuteReportBarCode()
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "modReport.PrintBarCode : " & ex.Message)
        Finally
        End Try
    End Sub

#Region "Comment"
    'Private Function GenBarcode(ByVal pText As String) As Image
    '    Dim settings As BarcodeSettings
    '    settings = New BarcodeSettings()
    '    'Dim data As String = "12345"
    '    Dim type As String = "Code128"


    '    settings.Data2D = pText
    '    settings.Data = pText

    '    settings.Type = CType(System.Enum.Parse(GetType(BarCodeType), type), BarCodeType)

    '    Dim fontSize As Short = 8
    '    Dim font As String = "SimSun"

    '    Dim barHeight As Short = 20

    '    settings.ShowText = False



    '    settings.ShowCheckSumChar = True




    '    'generate the barcode use the settings
    '    Dim generator As New BarCodeGenerator(settings)
    '    Dim barcode As Image = generator.GenerateImage()
    '    Return barcode
    '    ''save the barcode as an image
    '    'barcode.Save("..\..\..\..\Data\barcode.png")

    '    ''launch the generated barcode image
    '    'Process.Start("..\..\..\..\Data\barcode.png")
    'End Function

    'Public Sub PrintBarCode()
    '    Dim report As New XtraReport
    '    Dim lclsReport As New TmpOrderDAO
    '    Try
    '        Select Case cboBarcode.EditValue
    '            Case "Codabar"
    '                report = New rptBarcode_Codabar
    '            Case ("Code 11")
    '                report = New rptBarcode_Code11
    '            Case "Code 128"
    '                report = New rptBarcode_Code128
    '            Case "EAN128"
    '                report = New rptBarcode_EAN128
    '            Case "Code 39"
    '                report = New rptBarcode_Code39
    '            Case "Code 39 Extended"
    '                report = New rptBarcode_Code39Exten
    '            Case "Code 93"
    '                report = New rptBarcode_Code93
    '            Case "Code 93 Extended"
    '                report = New rptBarcode_Code93Exten
    '            Case "Matrix 2 of 5"
    '                report = New rptBarcode_Matrix2o5
    '            Case "EAN13"
    '                report = New rptBarcode_EAN13
    '            Case "MSI/Plessey"
    '                report = New rptBarcode_MSI
    '            Case "UPC-A"
    '                report = New rptBarcode_UPC
    '            Case Else
    '                report = New rptBarcode
    '        End Select



    '        Dim SQL As String, lSEQ As Long = 1
    '        Dim lSN As String

    '        SQL = " DELETE FROM TmpTax WHERE UserID= " & gUserID
    '        gConnection.executeInsertQuery(SQL, Nothing)

    '        lSN = "0"
    '        If Len(mProName) > 25 Then
    '            mProName = mProName.Substring(0, 25)
    '        End If

    '        For Each pBarcode As SnDAO In mBarCodeList
    '            lSN = pBarcode.SerialNumberNo
    '            SQL = " INSERT INTO TmpTax (UserID,SEQ,TaxText1,TaxText6  )"
    '            SQL = SQL & " VALUES ( " & gUserID
    '            SQL = SQL & ", " & lSEQ
    '            SQL = SQL & "  ,'" & ConvertNullToString(lSN) & "'"
    '            'SQL = SQL & "  ,'*" & ConvertNullToString(lSN) & "*'"
    '            SQL = SQL & "  ,'" & mProName & "'"
    '            SQL = SQL & " ) "
    '            gConnection.executeInsertQuery(SQL, Nothing)
    '            lSEQ = lSEQ + 1
    '        Next
    '        mReport = report
    '        ExecuteReportBarCode()
    '    Catch ex As Exception
    '        Err.Raise(Err.Number, ex.Source, "modReport.PrintBarCode : " & ex.Message)
    '    Finally
    '    End Try
    'End Sub
#End Region

    Private Sub InitialCondition()
        Dim lclsOrder As New OrderSDAO
        If mOrderID = 1001 Then
            mReportCode = "Cheque"
        ElseIf mOrderID = 1002 Then
            mReportCode = "BarCode"
        ElseIf mOrderID = 1003 Then
            mReportCode = "Commission"
        ElseIf mOrderID = 1004 Or mOrderID = 1005 Then
            mReportCode = "Tax"
        Else
            If mOrderID > 0 Then
                If lclsOrder.InitailData(mOrderID) Then
                    mReportCode = lclsOrder.Code
                    mReportCode = Replace(mReportCode, "\", "-")
                    mReportCode = Replace(mReportCode, "/", "-")
                End If
            End If

        End If

        txtBrows.Enabled = False
        txtBrows.Text = ""

        Select Case rdoCondition.EditValue
            Case 1
            Case 2
            Case 3
            Case 4
                txtBrows.Enabled = True
                txtBrows.Text = "C:\" & mReportCode & ".pdf"
            Case 5
                txtBrows.Enabled = True
                txtBrows.Text = "C:\" & mReportCode & ".xlsx"
        End Select

    End Sub



    Private Sub ExecuteReport()
        Dim SQL As String
        Dim lDataTable As DBConnection.DataTableList
        Dim lDataTableList As New List(Of DBConnection.DataTableList)
        Try
            SQL = "SELECT TmpOrders.* "
            SQL = SQL & " FROM TmpOrders  "
            SQL = SQL & " WHERE UserID= " & gUserID
            lDataTable = New DBConnection.DataTableList
            lDataTable.SQL = SQL
            lDataTable.TableName = "TmpOrders"
            lDataTableList.Add(lDataTable)

            SQL = "SELECT TmpProductList.* "
            SQL = SQL & " FROM TmpProductList  "
            SQL = SQL & " WHERE UserID= " & gUserID
            SQL = SQL & " Order by SEQ"
            lDataTable = New DBConnection.DataTableList
            lDataTable.SQL = SQL
            lDataTable.TableName = "TmpProductList"
            lDataTableList.Add(lDataTable)

            mReport.DataSource = gConnection.executeSelectDS(lDataTableList)

            'Dim lfrmReport As New frmPreReport
            'lfrmReport.InitialForm(pReport, pReportCode)
            'lfrmReport.ShowDialog()
            'pReport.ShowPreview()

            'Using printTool As New ReportPrintTool(pReport)
            '    pReport. 
            'End Using
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "modReport.ExecuteReport : " & ex.Message)
        Finally
        End Try
    End Sub


    Public Sub ExecuteReportTax()
        Dim SQL As String
        Dim lDataTable As DBConnection.DataTableList
        Dim lDataTableList As New List(Of DBConnection.DataTableList)
        Try
            SQL = "SELECT TmpOrders.* "
            SQL = SQL & " FROM TmpOrders  "
            SQL = SQL & " WHERE UserID= " & gUserID
            lDataTable = New DBConnection.DataTableList
            lDataTable.SQL = SQL
            lDataTable.TableName = "TmpOrders"
            lDataTableList.Add(lDataTable)

            SQL = "SELECT TmpTax.* "
            SQL = SQL & " FROM TmpTax  "
            SQL = SQL & " WHERE UserID= " & gUserID
            'SQL = SQL & " Order by SEQ"
            lDataTable = New DBConnection.DataTableList
            lDataTable.SQL = SQL
            lDataTable.TableName = "TmpTax"
            lDataTableList.Add(lDataTable)

            mReport.DataSource = gConnection.executeSelectDS(lDataTableList)
            'Dim lfrmReport As New frmPreReport
            'lfrmReport.InitialForm(pReport, pReportName)
            'lfrmReport.ShowDialog()
            ''pReport.ShowPreview()

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "modReport.ExecuteReportTax : " & ex.Message)
        Finally
        End Try
    End Sub


    Public Sub ExecuteReportBarCode()
        Dim SQL As String
        Dim lDataTable As DBConnection.DataTableList
        Dim lDataTableList As New List(Of DBConnection.DataTableList)
        Try

            SQL = "SELECT TmpTax.* "
            SQL = SQL & " FROM TmpTax  "
            SQL = SQL & " WHERE UserID= " & gUserID
            lDataTable = New DBConnection.DataTableList
            lDataTable.SQL = SQL
            lDataTable.TableName = "TmpTax"
            lDataTableList.Add(lDataTable)

            mReport.DataSource = gConnection.executeSelectDS(lDataTableList)
            'Dim lfrmReport As New frmPreReport
            'lfrmReport.InitialForm(pReport, pReportName)
            'lfrmReport.ShowDialog()

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "modReport.ExecuteReportTax : " & ex.Message)
        Finally
        End Try
    End Sub




    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Try
            ShowProgress(True, "Printing...")
            gShowDateReport = chkDate.Checked

            If mOrderType = 1000 Then
                PrintPayment(mOrderID)
                PrintReport()
            ElseIf mOrderType = 1001 Then
                PrintCheque()
                PrintReport()
            ElseIf mOrderType = 1002 Then
                PrintBarCode()

                PrintReport()

                'Dim bdf As Code128BarcodeDraw = BarcodeDrawFactory.Code128WithChecksum
                'PictureEdit1.Image = bdf.Draw("123456", 50, 2)
            ElseIf mOrderType = 1003 Then
                ExecuteReportTax()
                PrintReport()
            ElseIf mOrderType = 1004 Then
                PrintTaxAtPay(mOrderID)
                PrintReport()
            ElseIf mOrderType = 1005 Then
                ExecuteReport()
                PrintReport()
            ElseIf mOrderType = MasterType.Claim Or mOrderType = MasterType.ClaimReturn Then
                If chkPrintCopy.Checked = True Then
                    PrintReportOrder(1)
                    PrintReport()
                    PrintReportOrder(2)
                    PrintReport()
                Else
                    PrintReportOrder(1)
                    PrintReport()
                End If

            Else
                PrintReportOrder(0)
                PrintReport()
            End If
            Me.Close()
            'End Using
        Catch ex As Exception
            ShowProgress(False, "")
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try


    End Sub


    Private Sub PrintReport()
        Try
            Select Case rdoCondition.EditValue
                Case 1 : mReport.ShowPreview()
                Case 2 : mReport.PrintDialog()
                Case 3 : mReport.Print()
                Case 4 : mReport.ExportToPdf(txtBrows.Text)
                    Process.Start(txtBrows.Text)
                Case 5 : mReport.ExportToXlsx(txtBrows.Text)
                    Process.Start(txtBrows.Text)
            End Select
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "modReport.ExecuteReportTax : " & ex.Message)
        Finally

        End Try
    End Sub

    Private Sub frmPreReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ShowProgress(False, "Loading...")
            InitialCondition()
        Catch ex As Exception
            ShowProgress(False, "")
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub


    Private Sub txtBrows_ButtonPressed(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtBrows.ButtonPressed
        Select Case rdoCondition.EditValue
            Case 4
                SaveFileDialog1.FileName = mReportCode & ".pdf"
            Case 5
                SaveFileDialog1.FileName = mReportCode & ".xlsx"
        End Select
        SaveFileDialog1.ShowDialog()
        'SaveFileDialog1.CheckFileExists
        txtBrows.Text = SaveFileDialog1.FileName
    End Sub

    Private Sub rdoCondition_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoCondition.SelectedIndexChanged
        InitialCondition()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Function chkPrintProName() As Object
        Throw New NotImplementedException
    End Function

End Class