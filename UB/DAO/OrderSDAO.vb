﻿Option Explicit On
Imports System.Data.SqlClient
Public Class OrderSDAO
    Inherits iOrder

#Region "Property"
    Private mTableID As MasterType
    Public Overrides ReadOnly Property TableName() As String
        Get
            mTableID = TableID
            Return mTableID.ToString
            'Return "Orders"
        End Get
    End Property

#End Region

    Public Overrides Function InitailData(ByVal pID As Long, Optional ByVal pOrderCode As String = "", Optional ByVal tr As SqlTransaction = Nothing) As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()
        Dim lUserDAO As New UserDAO
        Try
            SQL = "SELECT *   "
            SQL = SQL & " FROM Orders WHERE 1=1"
            If pID > 0 Then
                SQL = SQL & " and OrderID=" & pID
            End If
            If TableID > 0 Then
                SQL = SQL & " and  TableID=" & TableID
            End If
            If pOrderCode.Trim <> "" Then
                SQL = SQL & " and  OrderCode='" & pOrderCode.Trim & "'"
                SQL = SQL & " and  IsCancel=0 and  IsDelete=0 "
            End If
            SQL = SQL & " ORDER BY OrderCode"
            dataTable = gConnection.executeSelectQuery(SQL, tr)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    Code = dr("OrderCode").ToString
                    TableID = ConvertNullToZero(dr("TableID"))
                    CustomerID = ConvertNullToZero(dr("CustomerID"))
                    EmpID = ConvertNullToZero(dr("EmpID"))
                    CreditRuleID = ConvertNullToZero(dr("CreditRuleID"))
                    VatTypeID = ConvertNullToZero(dr("VatTypeID"))
                    ShipingByID = ConvertNullToZero(dr("ShipingByID"))
                    ShipingMethodID = ConvertNullToZero(dr("ShipingMethodeID"))
                    ShipingRuleID = ConvertNullToZero(dr("ShipingRuleID"))
                    CurrencyID = ConvertNullToZero(dr("CurrencyID"))
                    QuotationRemarkID = ConvertNullToZero(dr("QuotationRemarkID"))
                    ExchangeRate = ConvertNullToZero(dr("ExchangeRate"))
                    If IsDBNull(dr("OrderDate")) Then
                        OrderDate = GetCurrentDate(tr)
                    Else
                        OrderDate = dr("OrderDate")
                    End If
                    If IsDBNull(dr("ShipingDate")) Then
                        ShipingDate = GetCurrentDate(tr)
                    Else
                        ShipingDate = dr("ShipingDate")
                    End If
                    If IsDBNull(dr("ExpireDate")) Then
                        ExpireDate = GetCurrentDate(tr)
                    Else
                        ExpireDate = dr("ExpireDate")
                    End If

                    TaxCanYes = ConvertNullToString(dr("TaxCanYes"))
                    TaxCondition = ConvertNullToString(dr("TaxCondition"))
                    If IsDBNull(dr("TaxMonthYear")) Then
                        TaxMonthYear = GetCurrentDate(tr)
                    Else
                        TaxMonthYear = dr("TaxMonthYear")
                    End If
                    TaxNumber = ConvertNullToString(dr("TaxNumber"))
                    TaxRemark = ConvertNullToString(dr("TaxRemark"))
                    TaxSection = ConvertNullToString(dr("TaxSection"))
                    TaxType = ConvertNullToString(dr("TaxType"))
                    TaxTotal = ConvertNullToZero(dr("TaxTotal"))
                    Institute = ConvertNullToString(dr("Institute"))
                    PayType = ConvertNullToString(dr("PayType"))
                    QuotationDays = ConvertNullToZero(dr("QuotationDays"))
                    PO = ConvertNullToString(dr("PO"))
                    OrderStatus = ConvertNullToString(dr("OrderStatus"))
                    CancelRemark = ConvertNullToString(dr("CancelRemark"))
                    IsCancel = dr("IsCancel")
                    Total = ConvertNullToZero(dr("Total"))
                    DiscountPercen = ConvertNullToZero(dr("DiscountPercen"))
                    DiscountAmount = ConvertNullToZero(dr("DiscountAmount"))
                    VatPercen = ConvertNullToZero(dr("VatPercen"))
                    VatAmount = ConvertNullToZero(dr("VatAmount"))
                    GrandTotal = ConvertNullToZero(dr("GrandTotal"))
                    PayTotal = ConvertNullToZero(dr("PayTotal"))
                    PledgeTotal = ConvertNullToZero(dr("PledgeTotal"))
                    Remark = ConvertNullToString(dr("Remark"))
                    SendBy = ConvertNullToString(dr("SendBy"))
                    InvoiceSuplierID = ConvertNullToString(dr("InvoiceSuplierID"))
                    RefBillID = ConvertNullToZero(dr("RefBillID"))
                    RefReceiptID = ConvertNullToZero(dr("RefReceiptID"))
                    StockType = ConvertNullToString(dr("StockType"))
                    ID = Int32.Parse(dr("OrderID"))
                    IsInActive = dr("IsInActive")
                    IsDelete = dr("IsDelete")
                    IsSumStock = ConvertNullToZero(dr("IsSumStock"))
                    IsMakePO = dr("IsMakePO")
                    IsEditVat = dr("IsEditVat")
                    IsNotPass = dr("IsNotPass")
                    CreateTime = ConvertNullToDateTime(dr("CreateTime"))
                    ModifiedTime = ConvertNullToDateTime(dr("ModifiedTime"))
                    If lUserDAO.InitailData(True, ConvertNullToZero(dr("CreateBy")), "", tr) Then
                        CreateBy = lUserDAO.UserName
                    Else
                        CreateBy = ""
                    End If

                    If ConvertNullToZero(dr("CreateBy")) = ConvertNullToZero(dr("ModifiedBy")) Then
                        ModifiedBy = CreateBy
                    Else
                        If lUserDAO.InitailData(True, ConvertNullToZero(dr("ModifiedBy")), "", tr) Then
                            ModifiedBy = lUserDAO.UserName
                        Else
                            ModifiedBy = ""
                        End If
                    End If
                    FileAttachs = LoadFileAttach(ID, TableName, tr)

                    Return True
                    Exit For
                Next
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "OrderSDAO.InitailData : " & e.Message)
            Return False
        Finally
            lUserDAO = Nothing
            dataTable = Nothing
        End Try
    End Function

    Public Function GetInfoHtml() As String
        Dim Info As String = ""
        'Try
        '    Info = Constants.vbCrLf & Constants.vbCrLf & mSubject
        '    Info &= Constants.vbCrLf & Constants.vbCrLf & "ชื่อ - สกุล: " & Title & FirstName & " " & LastName
        '    Info &= Constants.vbCrLf & "บริษัท: " & CompanyName
        '    Info &= Constants.vbCrLf & "โทรศัพท์มือถือ: " & AddressS.MobilePhone
        '    Info &= Constants.vbCrLf & "เบอร์โทรศัพท์: " & AddressS.Phone1
        '    Info &= Constants.vbCrLf & "เบอร์โทรสาร: " & AddressS.Fax
        '    Info &= Constants.vbCrLf & "อีเมลล์: " & AddressS.Email1
        'Catch e As Exception
        '    Err.Raise(Err.Number, e.Source, "OrderDAO.GetInfoHtml : " & e.Message)

        'End Try
        Return Info
    End Function

    Public Overrides Function SaveData(Optional ByRef ptr As SqlTransaction = Nothing) As Boolean
        Dim SQL As String, lTableNameThai As String = ""
        Dim tr As SqlTransaction = Nothing
        SQL = ""
        Try
            If ptr Is Nothing Then
                tr = gConnection.Connection.BeginTransaction
            Else
                tr = ptr
            End If

            Select Case TableID
                Case MasterType.SellOrders : lTableNameThai = "ใบสั่งขาย"
                Case MasterType.Quotation : lTableNameThai = "ใบเสนอราคา"
                Case MasterType.Shiping : lTableNameThai = "ใบส่งของ"
                Case MasterType.PurchaseOrder : lTableNameThai = "ใบสั่งซื้อ"
                Case MasterType.Reserve : lTableNameThai = "ใบสั่งจอง"
            End Select

            Select Case ModeData
                Case DataMode.ModeNew
                    EmpID = gEmpID
                    ID = GenNewID("OrderID", "Orders", tr)

                    '*** Check Approve
                    If gIsApproveSellOrder = True And TableID = MasterType.SellOrders Then
                        OrderStatus = EnumStatus.WaitApprove.ToString
                    ElseIf gIsApproveReserve = True And TableID = MasterType.Reserve Then
                        OrderStatus = EnumStatus.WaitApprove.ToString
                    ElseIf gIsApproveQua = True And TableID = MasterType.Quotation Then
                        OrderStatus = EnumStatus.WaitApprove.ToString
                    ElseIf gIsApproveBuyOrder And TableID = MasterType.PurchaseOrder Then
                        OrderStatus = EnumStatus.WaitApprove.ToString
                    ElseIf TableID = MasterType.PurchaseOrder Then
                        OrderStatus = EnumStatus.Waiting.ToString
                    Else
                        OrderStatus = EnumStatus.Open.ToString
                    End If

                    If OrderStatus = EnumStatus.WaitApprove.ToString Then
                        SaveApproveTX(1, DataMode.ModeNew, ID, lTableNameThai, TableName, Code, OrderDate, GrandTotal, "อนุมัติรายการ", OrderStatus, tr)
                    End If

                    '*** Check CheckLimitS
                    Dim lIsCheckOver As Boolean = False
                    If gIsCheckLimitSellOrder = True And TableID = MasterType.SellOrders Then
                        lIsCheckOver = True
                    ElseIf gIsCheckLimitReserve = True And TableID = MasterType.Reserve Then
                        lIsCheckOver = True
                    End If

                    If lIsCheckOver = True Then
                        Dim lCreditAmount As Decimal = GetCustomerCredit(CustomerID, tr)
                        If lCreditAmount > 0 Then
                            If GrandTotal > lCreditAmount Then
                                OrderStatus = EnumStatus.WaitApprove.ToString
                                SaveApproveTX(2, DataMode.ModeNew, ID, lTableNameThai, TableName, Code, OrderDate, GrandTotal _
                                              , "เกินวงเงิน [" & Format(GrandTotal, "#,##0.00") & " / " & Format(lCreditAmount, "#,##0.00") & "]" _
                                              , OrderStatus, tr)
                            End If
                        End If
                    End If

                    If PayType = "CASH" Then
                        PayTotal = GrandTotal
                        'if cash to close status
                        Select Case TableID
                            Case MasterType.InvoiceBuy, MasterType.ShipingBuy
                                If OrderStatus = EnumStatus.Open.ToString Then
                                    OrderStatus = EnumStatus.Close.ToString
                                End If
                        End Select
                    Else
                        PayTotal = 0
                    End If

                    If IsCancel = True Then
                        OrderStatus = EnumStatus.Cancel.ToString
                    End If

                    If TableID = MasterType.Reserve Then
                        MakePOStatus = EnumStatus.Ordering.ToString
                    Else
                        MakePOStatus = ""
                    End If

            End Select

            'Insert data to order table
            Call InsertOrder(tr)

            'Initial ALL List
            If ProductDAOs Is Nothing OrElse ProductDAOs.Count = 0 Then
                ProductDAOs = New List(Of ProductListDAO)
                ProductDAOs = BuildProductList(ID, TableName, tr)
            End If

            'Reset id as first day of year
            If ModeData = DataMode.ModeNew Then
                UpdateLastID(TableID, tr)
            End If

            Call UpdateCost(tr)
            Call UpdateBillReceipt(tr)
            Call SaveBalance(tr)
            Call SaveNote(NoteDAOs, ModeData, ID, TableName, tr)
            Call SaveAttachFile(FileAttachs, ModeData, ID, TableName, tr)
            Call SavePledge(PledgeDAOs, ModeData, ID, tr)
            Call SaveCheque(ChequeDAOs, ModeData, ID, tr)
            Call SaveTaxOrder(TaxOrderDAOs, ModeData, ID, tr)

            If ModeData = DataMode.ModeDelete Then
                If TableID = MasterType.Bill Or TableID = MasterType.Receipt Or TableID = MasterType.ReceiptBuy Or TableID = MasterType.ReceiptCut Then   '*** Check Order Type
                    Dim lOrderList As New OrderSDetailDAO
                    lOrderList.BillID = ID
                    lOrderList.DeleteAllData(tr)
                End If
            Else 'New ,Edit
                If TableID = MasterType.Bill Or TableID = MasterType.Receipt Or TableID = MasterType.ReceiptBuy Or TableID = MasterType.ReceiptCut Then   '*** Check Order Type
                    SaveOrderList(OrderDAOs, ModeData, ID, tr)
                End If
            End If

            Call SaveProductList(ProductDAOs, ModeData, ID, TableName, tr)
          
            'Rebuild RefToOrderID
            If ModeData = DataMode.ModeDelete Or OrderStatus = EnumStatus.NotApprove.ToString Then
                Call GetToRefOrderCode(ID, tr)
                If IsMakePO = True Then
                    Call GetToRefReserveCode(ID, tr)
                End If
            End If

            'Ref Order Status
            If IsNothing(RefToOrderID) = False Then
                Select Case TableID
                    Case MasterType.SellOrders, MasterType.Invoice, MasterType.Borrow, MasterType.Shiping, MasterType.InvoiceBuy, MasterType.Reserve, MasterType.ShipingBuy
                        If RefToOrderID.Count > 0 Then
                            For Each pOrderID As Long In RefToOrderID
                                If (ModeData = DataMode.ModeNew Or ModeData = DataMode.ModeEdit) And OrderStatus <> EnumStatus.NotApprove.ToString Then
                                    UpdateRefOrderStatus(TableID, ID, pOrderID, EnumStatus.Close.ToString, tr, ModeData)
                                    SetFlagProductList(ProductDAOs, True, pOrderID, tr)
                                Else 'Delete,NotApprove
                                    UpdateRefOrderStatus(TableID, ID, pOrderID, EnumStatus.Open.ToString, tr, DataMode.ModeDelete)
                                    SetFlagProductList(ProductDAOs, False, pOrderID, tr)
                                End If
                            Next
                        End If
                    Case MasterType.ReduceCredit, MasterType.ReduceCreditBuy, MasterType.AddCredit, MasterType.AddCreditBuy, MasterType.StockIn, MasterType.Asset, MasterType.Claim, MasterType.Expose
                        If RefToOrderID.Count > 0 Then
                            For Each pOrderID As Long In RefToOrderID
                                UpdateRefOrderStatus(TableID, ID, pOrderID, "", tr, ModeData)
                            Next
                        End If
                End Select
            End If

            'Make PO
            If IsNothing(RefToReserveID) = False Then
                If RefToReserveID.Count > 0 Then
                    For Each pOrderID As Long In RefToReserveID
                        If ModeData = DataMode.ModeNew Or ModeData = DataMode.ModeEdit Then
                            UpdateRefReserveStatus(TableID, ID, pOrderID, tr, ModeData)
                        Else 'Delete
                            UpdateRefReserveStatus(TableID, ID, pOrderID, tr, ModeData)
                        End If
                    Next
                End If

            End If
            'End If

            InsertActivity(ModeData, TableID, Code, tr)
            If ptr Is Nothing Then tr.Commit()

            Return True
        Catch e As Exception
            If ptr Is Nothing Then tr.Rollback()
            Err.Raise(Err.Number, e.Source, "OrderSDAO.SaveData : " & e.Message)
            Return False
        End Try
    End Function

  


    Public Function GetDataTable(ByVal pTableID As Long, ByVal pID As Long, ByVal pOnlyActive As Boolean, Optional ByVal pOtherCondition As String = "") As DataTable
        Dim SQL As String = ""
        Dim dataTable As New DataTable()

        Try
            Select Case pTableID
                Case MasterType.SellOrders, MasterType.Shiping, MasterType.Reserve, MasterType.Invoice, MasterType.Borrow, MasterType.Bill _
                    , MasterType.AddCredit, MasterType.Receipt, MasterType.ReduceCredit, MasterType.Claim, MasterType.ReceiptCut _
                    , MasterType.StockIn, MasterType.UpdateStock, MasterType.Expose
                    SQL = "SELECT DISTINCT Orders.OrderID AS ID,Orders.OrderCode AS Code,Orders.OrderDate  "
                    SQL = SQL & ",Customer.CustomerCode ,CASE WHEN Customer.CompanyName <>'' THEN Customer.CompanyName ELSE Customer.Title + Customer.Firstname + ' ' + Customer.LastName END Customer "
                Case MasterType.Quotation
                    SQL = "SELECT DISTINCT Orders.OrderID AS ID,Orders.OrderCode AS Code,Orders.OrderDate,Orders.ExpireDate  "
                    SQL = SQL & " ,Customer.CustomerCode,CASE WHEN Customer.CompanyName <>'' THEN Customer.CompanyName ELSE Customer.Title + Customer.Firstname + ' ' + Customer.LastName END Customer "
                Case MasterType.PurchaseOrder, MasterType.Asset, MasterType.ShipingBuy, MasterType.InvoiceBuy, MasterType.AddCreditBuy, MasterType.ReduceCreditBuy _
                    , MasterType.ClaimOut, MasterType.ReceiptBuy, MasterType.CancelPO
                    SQL = "SELECT DISTINCT Orders.OrderID AS ID,Orders.OrderCode AS Code,Orders.OrderDate  "
                    SQL = SQL & " ,Customer.CustomerCode,CASE WHEN Customer.CompanyName <>'' THEN Customer.CompanyName ELSE Customer.Title + Customer.Firstname + ' ' + Customer.LastName END Customer "
                    'Case MasterType.Bill, MasterType.Receipt
                    '    SQL = "SELECT Orders.OrderID AS ID,Orders.OrderCode AS Code,Orders.OrderDate  "
                    '    SQL = SQL & " ,CASE WHEN Customer.CompanyName <>'' THEN Customer.CompanyName ELSE Customer.Title + Customer.Firstname + ' ' + Customer.LastName END Customer "

            End Select

            If TableID = MasterType.StockIn Or TableID = MasterType.UpdateStock Then
                If TableID = MasterType.StockIn Then
                    SQL = SQL & " ,PO.OrderCode AS PO "
                End If
                SQL = SQL & " ,'' as OrderStatus "
            Else
                SQL = SQL & " ,Orders.OrderStatus "
            End If
            If TableID = MasterType.Reserve Then
                SQL = SQL & " ,Orders.MakePOStatus "
            End If
            If TableID = MasterType.Quotation Then
                SQL = SQL & ",RefOrder.OrderCode AS RefCode  "
            End If
            SQL = SQL & "  ,Orders.GrandTotal"
            If TableID = MasterType.SellOrders Then
                SQL = SQL & ",Invoice.OrderCode AS InvoiceCode,Shiping.OrderCode AS ShipingCode,Bill.OrderCode AS BillCode,Receipt.OrderCode AS ReceiptCode "
            End If
            If TableID = MasterType.Invoice Or TableID = MasterType.Shiping Then
                SQL = SQL & ",Bill.OrderCode AS BillCode,Receipt.OrderCode AS ReceiptCode "
            End If
            If TableID = MasterType.InvoiceBuy Or TableID = MasterType.ShipingBuy Or TableID = MasterType.ReduceCreditBuy Then
                SQL = SQL & ",Orders.InvoiceSuplierID "
            End If
            SQL = SQL & ",Orders.IsDelete,Orders.IsCancel, Orders.IsNotPass"

            SQL = SQL & " ,Employee.Title + Employee.Firstname + ' ' + Employee.LastName AS EMPNAME,Orders.ModifiedTime,case when Cheque.ChequeID > 1 then 1 else 0 end ChequeID"
            SQL = SQL & " FROM Orders  "
            SQL = SQL & " LEFT OUTER JOIN Employee ON Orders.EmpID=Employee.EmpID  "
            SQL = SQL & " LEFT OUTER JOIN Customer ON Orders.CustomerID=Customer.CustomerID  "
            SQL = SQL & " LEFT OUTER JOIN Orders AS Invoice ON Invoice.OrderID =(select max(OrderID) from OrdersRef where OrdersRef.IsDelete=0 and OrdersRef.RefOrderID=Orders.OrderID  ) and Invoice.IsDelete=0 and Invoice.TableID=" & MasterType.Invoice
            SQL = SQL & " LEFT OUTER JOIN Orders AS Shiping ON Shiping.OrderID=(select max(OrderID) from OrdersRef where OrdersRef.IsDelete=0 and OrdersRef.RefOrderID=Orders.OrderID  ) and Shiping.IsDelete=0 and Shiping.TableID=" & MasterType.Shiping
            SQL = SQL & " LEFT OUTER JOIN Orders AS Receipt ON Orders.RefReceiptID=Receipt.OrderID and Receipt.IsDelete=0 and Receipt.TableID in(" & MasterType.Receipt & "," & MasterType.ReceiptCut & ")"
            SQL = SQL & " LEFT OUTER JOIN Orders AS Bill ON Orders.RefBillID=Bill.OrderID and Bill.IsDelete=0 and Bill.TableID=" & MasterType.Bill
            If TableID = MasterType.Quotation Then
                SQL = SQL & " LEFT OUTER JOIN Orders AS RefOrder ON Orders.OrderStatus in('Close','Receive') and RefOrder.OrderID=(select max(OrderID) from OrdersRef where OrdersRef.IsDelete=0 and OrdersRef.RefOrderID=Orders.OrderID  ) and RefOrder.IsDelete=0  "
            End If
            SQL = SQL & " LEFT OUTER JOIN Orders AS PO ON PO.OrderID=(select max(RefOrderID) from OrdersRef where OrdersRef.IsDelete=0 and OrdersRef.OrderID=Orders.OrderID  ) and PO.IsDelete=0  "
            SQL = SQL & " LEFT OUTER JOIN Cheque ON Cheque.RefOrderID=Orders.OrderID and Cheque.IsDelete=0  "
            SQL = SQL & " WHERE Orders.TableID =" & TableID
            If pID > 0 Then
                SQL = SQL & "  AND Orders.OrderID=" & pID
            End If
            If pOnlyActive = True Then
                SQL = SQL & "  AND Orders.IsDelete = 0"
                SQL = SQL & "  AND Orders.IsCancel = 0"
            Else
                'SQL = SQL & "  AND Orders.IsDelete = 0"
            End If
            ''Set View level
            If gViewLevel = eViewLevel.Group Then
                SQL = SQL & "  AND Employee.TerritoryID=" & gTerritoryID
            ElseIf gViewLevel = eViewLevel.OnlyOwner Then
                SQL = SQL & "  AND Employee.EmpID=" & gEmpID
            End If
            If pOtherCondition <> "" Then
                SQL = SQL & pOtherCondition
            End If
            SQL = SQL & " ORDER BY Orders.OrderCode"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "OrderSDAO.GetDataTable : " & e.Message)
        End Try
        Return dataTable
    End Function

    Public Function GetDataTableForCombo(ByVal pTXOrderType As Long, ByVal pTableID As Long, ByVal pCustomerID As Long, ByVal pEffectDate As Date, ByVal pIsOpenOnly As Boolean, ByVal pSQL As String) As DataTable
        Dim SQL As String = ""
        Dim dataTable As New DataTable()

        Try
            'SQL = "SELECT Orders.OrderID AS ID,case when Orders.InvoiceSuplierID <> '' then Orders.InvoiceSuplierID else Orders.OrderCode end Code"
            SQL = "SELECT Orders.OrderID AS ID, Orders.OrderCode  Code,Orders.CustomerID"
            Select Case pTableID
                Case MasterType.Quotation
                    SQL = SQL & " ,Orders.OrderDate,Orders.ExpireDate  "
                Case Else
                    SQL = SQL & " ,Orders.OrderDate  "
            End Select
            SQL = SQL & ",Orders.InvoiceSuplierID "
            SQL = SQL & " ,Orders.OrderStatus,Orders.GrandTotal,Orders.PayTotal "
            SQL = SQL & " ,Employee.Title + Employee.Firstname + ' ' + Employee.LastName AS EMPNAME "
            SQL = SQL & " ,CASE WHEN Customer.CompanyName <>'' THEN Customer.CompanyName ELSE Customer.Title + Customer.Firstname + ' ' + Customer.LastName END Customer "
            SQL = SQL & " FROM Orders  "
            SQL = SQL & " LEFT OUTER JOIN Employee ON Orders.EmpID=Employee.EmpID  "
            SQL = SQL & " LEFT OUTER JOIN Customer ON Orders.CustomerID=Customer.CustomerID  "
            SQL = SQL & " WHERE Orders.IsDelete =0 AND Orders.IsCancel = 0  "
            SQL = SQL & " and Orders.TableID =" & pTableID
            If pSQL <> "" Then
                SQL = SQL & pSQL
            End If

            If pCustomerID > 0 Then
                SQL = SQL & "  AND Orders.CustomerID=" & pCustomerID
            End If
            SQL = SQL & "  AND Orders.IsInActive = 0"
            SQL = SQL & "  AND Orders.IsCancel= 0"
            SQL = SQL & "  AND Orders.OrderDate <= '" & formatSQLDate(pEffectDate) & "'"
            If pTableID = MasterType.Quotation Then
                SQL = SQL & "  AND ExpireDate > '" & formatSQLDate(pEffectDate) & "'"
            End If

            If pIsOpenOnly Then
                If pTableID = MasterType.PurchaseOrder And pTXOrderType = MasterType.StockIn Then
                    SQL = SQL & "  AND Orders.OrderStatus In ('Open','Approve','Waiting' ) "
                ElseIf pTableID = MasterType.PurchaseOrder Then
                    SQL = SQL & "  AND Orders.OrderStatus In ('Open','Approve','Waiting','Receive' ) "
                ElseIf pTXOrderType = MasterType.Bill Then
                    SQL = SQL & "  AND Orders.OrderStatus In ('Open','Approve'  ) "
                ElseIf pTXOrderType = MasterType.Receipt Or pTXOrderType = MasterType.ReceiptCut Then
                    SQL = SQL & "  AND Orders.OrderStatus In ('Open','Approve','Billed' ) "
                Else
                    SQL = SQL & "  AND Orders.OrderStatus In ('Open','Approve','Waiting') "
                End If

            End If
            ''Set View level
            If gViewLevel = eViewLevel.Group Then
                SQL = SQL & "  AND Employee.TerritoryID=" & gTerritoryID
            ElseIf gViewLevel = eViewLevel.OnlyOwner Then
                SQL = SQL & "  AND Employee.EmpID=" & gEmpID
            End If
            SQL = SQL & " ORDER BY Orders.OrderCode"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception

            Err.Raise(Err.Number, e.Source, "OrderSDAO.GetDataTableForCombo : " & e.Message)
        End Try
        Return dataTable
    End Function



    Public Overrides Function GetToRefOrderCode(ByVal pParentOrderID As Long, ByRef tr As SqlTransaction) As String
        Dim SQL As String = "", lstrCode As String = ""
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT  OrdersRef.OrderID,OrdersRef.RefOrderID, Orders.OrderCode  "
            SQL = SQL & " FROM OrdersRef,Orders  "
            SQL = SQL & " WHERE OrdersRef.RefOrderID=Orders.OrderID and Orders.IsDelete=0 and OrdersRef.IsDelete=0  and OrdersRef.OrderID=" & pParentOrderID
            SQL = SQL & " ORDER BY Orders.OrderCode"
            dataTable = gConnection.executeSelectQuery(SQL, tr)

            RefToOrderID.Clear()
            lstrCode = ""
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    If lstrCode = "" Then
                        lstrCode = dr("OrderCode").ToString
                    Else
                        lstrCode = lstrCode & ", " & dr("OrderCode").ToString
                    End If
                    RefToOrderID.Add(ConvertNullToZero(dr("RefOrderID")))
                Next
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "OrderSDAO.GetToRefOrderCode : " & e.Message)
        End Try
        Return lstrCode
    End Function



    Public Overrides Function GetToRefReserveCode(ByVal pParentOrderID As Long, ByRef tr As SqlTransaction) As String
        Dim SQL As String = "", lstrCode As String = ""
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT  OrdersRef.OrderID,OrdersRef.RefReserveID, Orders.OrderCode  "
            SQL = SQL & " FROM OrdersRef,Orders  "
            SQL = SQL & " WHERE OrdersRef.RefReserveID=Orders.OrderID and Orders.IsDelete=0 and OrdersRef.IsDelete=0  and OrdersRef.OrderID=" & pParentOrderID
            SQL = SQL & " ORDER BY Orders.OrderCode"
            dataTable = gConnection.executeSelectQuery(SQL, tr)

            RefToReserveID.Clear()
            lstrCode = ""
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    If lstrCode = "" Then
                        lstrCode = dr("OrderCode").ToString
                    Else
                        lstrCode = lstrCode & ", " & dr("OrderCode").ToString
                    End If
                    RefToReserveID.Add(ConvertNullToZero(dr("RefReserveID")))
                Next
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "OrderSDAO.GetToRefReserveCode : " & e.Message)
        End Try
        Return lstrCode
    End Function

    Public Function GetOrderTypeFromID(ByVal pOrderID As Long, ByRef tr As SqlTransaction) As Long
        Dim SQL As String = "", lstrCode As String = ""
        Dim dataTable As New DataTable()

        Try
            GetOrderTypeFromID = 0

            SQL = "SELECT TableID  "
            SQL = SQL & " FROM  Orders  "
            SQL = SQL & " WHERE Orders.OrderID=" & pOrderID
            dataTable = gConnection.executeSelectQuery(SQL, tr)

            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    Return ConvertNullToZero(dr("TableID"))
                Next
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "OrderSDAO.GetOrderTypeFromID : " & e.Message)
        End Try

    End Function

    Public Overrides Function CheckExist() As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()
        Try
            SQL = "SELECT OrderID  FROM Orders"
            SQL = SQL & " WHERE IsDelete =0 AND OrderCode='" & Trim(Code) & "'"
            SQL = SQL & " and TableID=" & TableID
            If ModeData = DataMode.ModeEdit Then
                SQL = SQL & " AND OrderID <> " & ID
            End If
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            Return dataTable.Rows.Count > 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "OrderDAO.CheckExist : " & e.Message)
            Return False
        Finally
            dataTable = Nothing
        End Try
    End Function

    Public Function CheckIsToUse() As Boolean ''ถูกใช้งานอยู่ ???
        Dim SQL As String = ""
        Dim dataTable As New DataTable()

        Try
          

            'SQL = "SELECT Orders.OrderID  FROM OrdersRef,Orders  "
            'SQL = SQL & " WHERE OrdersRef.OrderID=Orders.OrderID and OrdersRef.IsDelete=0  and OrdersRef.RefOrderID=" & ID
            'SQL = SQL & " and Orders.IsDelete=0"

            'If TableID = MasterType.Quotation Then
            '    SQL = SQL & " and Orders.TableID in(" & MasterType.Reserve & ")"
            'ElseIf TableID = MasterType.Reserve Then
            '    SQL = SQL & " and Orders.TableID in(" & MasterType.SellOrders & ")"
            'End If
            'dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            'If dataTable.Rows.Count > 0 Then
            '    Return True
            'End If
            Return False

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProductDAO.CheckNotExist : " & e.Message)
        Finally
            dataTable = Nothing
        End Try


    End Function

    Public Function CHECKSUM_AGG() As Long
        Dim SQL As String
        Dim dataTable As New DataTable()
        Try
            SQL = "SELECT CHECKSUM_AGG(BINARY_CHECKSUM(*))  "
            SQL = SQL & " FROM Orders"
            SQL = SQL & " WITH (NOLOCK)"
            SQL = SQL & " where TableID=" & TableID & " ;"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    Return ConvertNullToZero(dr(0))
                    Exit For
                Next
            End If
            Return 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "OrderSDAO.CHECKSUM_AGG : " & e.Message)
            Return 0
        Finally
            dataTable = Nothing
        End Try
    End Function

    Public Function BuildProductList(ByVal pRefID As Long, ByVal pRefTable As String, ByRef ptr As SqlTransaction) As List(Of ProductListDAO)
        Dim lcls As New ProductListDAO
        Dim dataTable As New DataTable()
        Dim lOrderList As New List(Of Long)
        Dim lProductDAOs = New List(Of ProductListDAO)
        lOrderList.Add(pRefID)
        Try
            dataTable = lcls.GetDataTable(lOrderList, pRefTable, ptr, False, "", False, 0, True)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    Dim rec As New ProductListDAO
                    rec.ID = dr("ID")
                    rec.SEQ = ConvertNullToZero(dr("SEQ"))
                    rec.ProductID = ConvertNullToZero(dr("ProductID"))
                    rec.ProductName = ConvertNullToString(dr("ProductName"))
                    rec.ProductNameExt = ConvertNullToString(dr("ProductNameExt"))
                    rec.LocationDTLID = ConvertNullToZero(dr("LocationDTLID"))
                    rec.UnitID = ConvertNullToZero(dr("UnitID"))
                    rec.UnitMainID = ConvertNullToZero(dr("UnitMainID"))
                    rec.Remark = ConvertNullToString(dr("Remark"))
                    rec.KeepMin = ConvertNullToZero(dr("KeepMin"))
                    rec.Units = ConvertNullToZero(dr("Units"))
                    rec.AdjustUnit = ConvertNullToZero(dr("AdjustUnit"))
                    rec.AdjustUnit_Old = ConvertNullToZero(dr("AdjustUnit"))
                    rec.Units_Old = rec.Units
                    rec.Price = ConvertNullToZero(dr("Price"))
                    rec.PriceMain = ConvertNullToZero(dr("PriceMain"))
                    rec.Cost = ConvertNullToZero(dr("Cost"))
                    rec.Discount = ConvertNullToZero(dr("Discount"))
                    rec.Total = ConvertNullToZero(dr("Total"))
                    lProductDAOs.Add(rec)
                Next
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "OrderSDAO.BuildProductList : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
        Return lProductDAOs
    End Function

    Public Sub BuildOrderList(ByVal pBillID As Long, ByRef ptr As SqlTransaction)
        Dim lcls As New OrderSDetailDAO
        Dim dataTable As New DataTable()

        Try
            OrderDAOs = New List(Of SubOrder)
            dataTable = lcls.GetDataTable(pBillID, ptr)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    Dim rec As New SubOrder()
                    rec.IsSelect = True
                    rec.ID = dr("ID")
                    rec.BillID = ConvertNullToZero(dr("BillID"))
                    rec.BillType = ConvertNullToString(dr("BillType"))
                    rec.OrderID = ConvertNullToZero(dr("OrderID"))
                    rec.OrderCode = ConvertNullToString(dr("OrderCode"))
                    rec.OrderDate = dr("OrderDate")
                    rec.CusName = ConvertNullToString(dr("CusName"))
                    rec.EmpName = ConvertNullToString(dr("EmpName"))
                    rec.BillTotal = ConvertNullToZero(dr("BillTotal"))
                    rec.GrandTotal = ConvertNullToZero(dr("GrandTotal"))
                    rec.Remark = ConvertNullToString(dr("Remark"))
                    rec.TableID = ConvertNullToString(dr("TableID"))
                    OrderDAOs.Add(rec)
                Next
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "OrderSDAO.BuildOrderList : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    Public Sub SaveProductList(ByRef ProductList As List(Of ProductListDAO), ByVal ModeData As Long, ByVal RefID As Long, ByVal TableName As String , ByRef tr As SqlTransaction)
        Dim lSEQ As Long = 1 ', lstrStayIDList As String = ""
        Dim lclsSN2 As SnDAO
        Dim lSNTable As DataTable
        Dim lOrderList As New List(Of Long) ', lSNInList As String = ""
        Dim lIsUpdate As Integer = 0  ' 0=no, 1=sum, 2=second
        Dim lclsSN As SnDAO
        Try
            'Condition for Up Stock
            lIsUpdate = CheckIsUseStock(TableID, RefToOrderID, StockType, tr)

            If ProductList Is Nothing Then
                '**** not delete prolist when delete order
            ElseIf ProductList.Count = 0 Then

            Else
                For Each pProList As ProductListDAO In ProductList
                    pProList.RefID = RefID
                    pProList.RefTable = TableName
                    pProList.SEQ = lSEQ
                    If ModeData = DataMode.ModeDelete Then
                        pProList.ModeData = DataMode.ModeDelete
                    ElseIf OrderStatus = EnumStatus.NotApprove.ToString Then
                        pProList.ModeData = DataMode.ModeNotApprove
                    ElseIf pProList.IsDelete = 1 Then
                        pProList.ModeData = DataMode.ModeDelete
                    ElseIf ModeData = DataMode.ModeNew Then
                        pProList.ModeData = DataMode.ModeNew
                        pProList.IsConfirm = 0
                    ElseIf pProList.ID = 0 Then ' Add new row on Edit Mode
                        pProList.ModeData = DataMode.ModeNew
                        pProList.IsConfirm = 0
                    End If

                    If pProList.SaveData(tr) Then
                        If pProList.IsShow = 1 Then
                            If pProList.UnitMainID <> pProList.UnitID Then
                                '*** Main Stock
                                UpdateStock(tr, pProList, lIsUpdate, True)
                            End If
                          
                            '*** ORG. Stock
                            UpdateStock(tr, pProList, lIsUpdate, False)

                            '*** SN
                            If pProList.ModeData = DataMode.ModeDelete Or pProList.ModeData = DataMode.ModeNotApprove Then
                                'Re Open status
                                If TableName = MasterType.SellOrders.ToString Or (lIsUpdate = 3 And StockType = "O") Then
                                    lOrderList = New List(Of Long)
                                    lOrderList.Add(RefID)

                                    lclsSN = New SnDAO
                                    lSNTable = Nothing
                                    lSNTable = lclsSN.GetDataTable(lOrderList, pProList.ID, pProList.ProductID, "", tr, False, "")
                                    For Each dr2 As DataRow In lSNTable.Rows
                                        lclsSN2 = New SnDAO
                                        lclsSN2.SetStatusBySN(tr, ConvertNullToZero(dr2("ProductID")), ConvertNullToString(dr2("SerialNumberNo")) _
                                                              , "New", 0)
                                    Next
                                End If
                                'Delete S/N  
                                If CheckSNIsClose(RefID, TableName, tr) Then
                                    Err.Raise(-1)
                                Else
                                    If TableName = MasterType.StockIn.ToString Or (lIsUpdate = 3 And StockType = "I") Then
                                        lclsSN2 = New SnDAO
                                        lclsSN2.DeleteFromModeDelete(tr, RefID, pProList.ID)
                                    End If
                                End If

                               
                            Else 'New ,Edit
                                If IsNothing(pProList.SNList) = False Then
                                    For Each pclsSN As SnDAO In pProList.SNList
                                        If pProList.ModeData = DataMode.ModeNew Then
                                            pclsSN.SerialNumberID = 0
                                            If TableName = MasterType.StockIn.ToString Or (lIsUpdate = 3 And StockType = "I") Then
                                                pclsSN.Status = "New"
                                            Else
                                                pclsSN.Status = "None"
                                            End If
                                        Else 'Edit
                                        End If
                                        pclsSN.OrderID = RefID
                                        pclsSN.ProductListID = pProList.ID
                                        pclsSN.ProductID = pProList.ProductID
                                        pclsSN.SaveData(tr, ModeData)

                                        'Update SN Status
                                        lclsSN2 = New SnDAO
                                        If pclsSN.IsDelete = 1 And (TableName = MasterType.SellOrders.ToString Or (lIsUpdate = 3 And StockType = "O")) Then
                                            lclsSN2.SetStatusBySN(tr, pProList.ProductID, pclsSN.SerialNumberNo, "New", 0)
                                        ElseIf TableName = MasterType.SellOrders.ToString Or (lIsUpdate = 3 And StockType = "O") Then 'Close SN
                                            lclsSN2.SetStatusBySN(tr, pProList.ProductID, pclsSN.SerialNumberNo, "Close", 0)
                                        End If
                                    Next
                                End If
                            End If '*** SN
                        End If '*** Is show
                    End If
                    If pProList.IsShow = 1 And pProList.IsDelete = 0 Then
                        lSEQ = lSEQ + 1
                    End If
                Next
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SaveProductList" & e.Message)
        End Try

    End Sub


    Private Sub UpdateStock(ByRef ptr As SqlTransaction, ByVal pProductList As ProductListDAO, ByVal pIsUpdate As Integer, ByVal pIsMainUnitID As Boolean)
        Try
            Dim lclsStock As ProductStockDAO
            Dim lclsStock_Old As ProductStockDAO
            Dim lclsClone As ProductStockDAO

            If pIsUpdate = 4 Then ''** Stock in
                'Update Stock +
                lclsStock = New ProductStockDAO
                lclsStock.ProductID = pProductList.ProductID
                If pIsMainUnitID = True Then
                    lclsStock.UnitID = pProductList.UnitMainID
                Else
                    lclsStock.UnitID = pProductList.UnitID
                End If

                lclsStock.LocationDTLID = pProductList.LocationDTLID
                lclsStock.Cost = pProductList.Cost
                If pProductList.ModeData = DataMode.ModeDelete Or pProductList.ModeData = DataMode.ModeNotApprove Then
                    If pIsMainUnitID = True Then
                        lclsStock.Units = pProductList.Units * -1
                    Else
                        lclsStock.Units = pProductList.AdjustUnit * -1
                    End If
                ElseIf pProductList.ID = 0 Or pProductList.ModeData = DataMode.ModeNew Then
                    If pIsMainUnitID = True Then
                        lclsStock.Units = pProductList.Units
                    Else
                        lclsStock.Units = pProductList.AdjustUnit
                    End If
                ElseIf pProductList.ID > 0 Or pProductList.ModeData = DataMode.ModeEdit Then
                    'if change location in mode edit
                    If pProductList.LocationDTLID <> pProductList.LocationDTLID_Old Then
                        'Remove unit from old location stock
                        lclsStock_Old = New ProductStockDAO
                        lclsStock_Old.ProductID = pProductList.ProductID
                        lclsStock_Old.LocationDTLID = pProductList.LocationDTLID_Old
                        lclsStock_Old.Cost = pProductList.Cost

                        If pIsMainUnitID = True Then
                            lclsStock_Old.UnitID = pProductList.UnitMainID
                            lclsStock_Old.Units = pProductList.Units_Old * -1
                        Else
                            lclsStock_Old.UnitID = pProductList.UnitID
                            lclsStock_Old.Units = pProductList.AdjustUnit_Old * -1
                        End If
                        'Update #01 with clone class 'ป้องการค่าโดนเปลี่ยนจึง clone ไปใช้
                        lclsClone = New ProductStockDAO
                        lclsClone = lclsStock_Old.Clone
                        lclsClone.SaveData(ptr, False, False, ID, Code)

                        'Update #02 with original class **SUM STOCK
                        lclsStock_Old.SaveData(ptr, True, False, ID, Code)

                        'Add new unit to new location
                        If pIsMainUnitID = True Then
                            lclsStock.Units = pProductList.Units
                        Else
                            lclsStock.Units = pProductList.AdjustUnit
                        End If
                    Else
                        If pIsMainUnitID = True Then
                            If pProductList.Units = pProductList.Units_Old Then
                                lclsStock.Units = 0
                            Else
                                lclsStock.Units = (pProductList.Units - pProductList.Units_Old)
                            End If
                        Else
                            If pProductList.AdjustUnit = pProductList.AdjustUnit_Old Then
                                lclsStock.Units = 0
                            Else
                                lclsStock.Units = (pProductList.AdjustUnit - pProductList.AdjustUnit_Old)
                            End If
                        End If

                    End If
                End If
                'Update #01 with clone class 'ป้องการค่าโดนเปลี่ยนจึง clone ไปใช้
                lclsClone = New ProductStockDAO
                lclsClone = lclsStock.Clone
                lclsClone.SaveData(ptr, False, False, ID, Code)
                'Update #02 with original class **SUM STOCK
                lclsStock.SaveData(ptr, True, False, ID, Code)

            ElseIf pIsUpdate > 0 Then
                lclsStock = New ProductStockDAO
                lclsStock.ProductID = pProductList.ProductID
                If pIsMainUnitID = True Then
                    lclsStock.UnitID = pProductList.UnitMainID
                Else
                    lclsStock.UnitID = pProductList.UnitID
                End If

                lclsStock.LocationDTLID = pProductList.LocationDTLID

                If pProductList.ModeData = DataMode.ModeDelete Or pProductList.ModeData = DataMode.ModeNotApprove Then
                    If pIsMainUnitID = True Then
                        lclsStock.Units = pProductList.Units
                    Else
                        lclsStock.Units = pProductList.AdjustUnit
                    End If

                ElseIf pProductList.ID = 0 Or pProductList.ModeData = DataMode.ModeNew Then
                    If pIsMainUnitID = True Then
                        lclsStock.Units = pProductList.Units * -1
                    Else
                        lclsStock.Units = pProductList.AdjustUnit * -1
                    End If
                ElseIf pProductList.ID > 0 Then
                    If pIsMainUnitID = True Then
                        If pProductList.Units = pProductList.Units_Old Then
                            lclsStock.Units = 0
                        Else
                            lclsStock.Units = (pProductList.Units - pProductList.Units_Old) * -1
                        End If
                    Else
                        If pProductList.AdjustUnit = pProductList.AdjustUnit_Old Then
                            lclsStock.Units = 0
                        Else
                            lclsStock.Units = (pProductList.AdjustUnit - pProductList.AdjustUnit_Old) * -1
                        End If
                    End If
                   
                End If

                If pIsUpdate = 1 Then  'sell stock sum
                    lclsStock.SaveData(ptr, True, False, ID, Code)
                ElseIf pIsUpdate = 2 Then 'Invoice,Shiping
                    lclsStock.SaveData(ptr, False, False, ID, Code)
                ElseIf pIsUpdate = 3 Then
                    If StockType = "I" Then
                        lclsStock.Units = lclsStock.Units * -1 ' I = คืนสต็อก
                    End If
                    'Update #01 with clone class 'ป้องการค่าโดนเปลี่ยนจึง clone ไปใช้
                    lclsClone = New ProductStockDAO
                    lclsClone = lclsStock.Clone
                    lclsClone.SaveData(ptr, False, False, ID, Code)
                    'Update #02 with original class **SUM STOCK
                    lclsStock.SaveData(ptr, True, False, ID, Code)
                End If
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "OrderSDAO.UpdateStock : " & e.Message)
        Finally
        End Try
    End Sub

    Private Sub InsertOrder(ByRef ptr As SqlTransaction)
        Dim Sql As String = ""
        Try
            Select Case ModeData
                Case DataMode.ModeNew
                    Sql = " INSERT INTO Orders  (OrderID,TableID,OrderCode,PO,OrderDate,ShipingDate,CustomerID,EmpID,CreditRuleID,VatTypeID,OrderStatus"
                    Sql &= " ,IsCancel,CancelRemark,Total,DiscountPercen,DiscountAmount,VatPercen,VatAmount,GrandTotal,PledgeTotal"
                    Sql &= " ,Remark,CreateBy,CreateTime,IsInActive,IsDelete "
                    Sql &= " ,RefBillID,SendBy,ExpireDate,QuotationDays,ShipingByID,ShipingMethodeID,AgencyID,PayType"
                    Sql &= " ,BillMedthodID,PayTotal,CurrencyID,ExchangeRate"
                    Sql &= " ,TaxCanYes,TaxCondition,TaxMonthYear,TaxNumber,TaxTotal "
                    Sql &= " ,TaxRemark,TaxSection,TaxType,ShipingRuleID,InvoiceSuplierID,Institute,StockType,IsSumStock,IsMakePO,MakePOStatus,IsEditVat"
                    Sql &= " ,QuotationRemarkID,IsNotPass)"
                    Sql &= " VALUES ( " & ID
                    Sql &= " , " & TableID
                    Sql &= " , '" & Trim(Code) & "'"
                    Sql &= " , '" & ConvertNullToString(PO) & "'"
                    Sql &= " , '" & formatSQLDate(OrderDate) & "'"
                    Sql &= " , '" & formatSQLDate(ShipingDate) & "'"
                    Sql &= " , " & ConvertNullToZero(CustomerID)
                    Sql &= " , " & ConvertNullToZero(EmpID)
                    Sql &= " , " & ConvertNullToZero(CreditRuleID)
                    Sql &= " , " & ConvertNullToZero(VatTypeID)
                    Sql &= " , '" & ConvertNullToString(OrderStatus) & "'"
                    Sql &= " , " & IIf(IsCancel = True, 1, 0)
                    Sql &= " , '" & ConvertNullToString(CancelRemark) & "'"
                    Sql &= " ,  " & ConvertNullToZero(Total)
                    Sql &= " ,  " & ConvertNullToZero(DiscountPercen)
                    Sql &= " ,  " & ConvertNullToZero(DiscountAmount)
                    Sql &= " ,  " & ConvertNullToZero(VatPercen)
                    Sql &= " ,  " & ConvertNullToZero(VatAmount)
                    Sql &= " ,  " & ConvertNullToZero(GrandTotal)
                    Sql &= " ,  " & ConvertNullToZero(PledgeTotal)
                    Sql &= " , '" & ConvertNullToString(Remark) & "'"
                    Sql &= " ,  " & gUserID
                    Sql &= " , '" & formatSQLDateTime(GetCurrentDate(ptr)) & "'"
                    Sql &= " ,  " & IIf(IsInActive = True, 1, 0)
                    Sql &= " ,0 "
                    Sql &= " , " & RefBillID
                    Sql &= " , '" & ConvertNullToString(SendBy) & "'"
                    Sql &= " , '" & formatSQLDate(ExpireDate) & "'"
                    Sql &= " ,  " & ConvertNullToZero(QuotationDays)
                    Sql &= " ,  " & ConvertNullToZero(ShipingByID)
                    Sql &= " ,  " & ConvertNullToZero(ShipingMethodID)
                    Sql &= " ,  " & 0
                    Sql &= " , '" & ConvertNullToString(PayType) & "'"
                    Sql &= " ,  " & ConvertNullToZero(BillMedthodID)
                    Sql &= " ,  " & ConvertNullToZero(PayTotal)
                    Sql &= " ,  " & ConvertNullToZero(CurrencyID)
                    Sql &= " ,  " & ConvertNullToZero(ExchangeRate)
                    Sql &= " , '" & ConvertNullToString(TaxCanYes) & "'"
                    Sql &= " , '" & ConvertNullToString(TaxCondition) & "'"
                    Sql &= " , '" & formatSQLDate(TaxMonthYear) & "'"
                    Sql &= " , '" & ConvertNullToString(TaxNumber) & "'"
                    Sql &= " ,  " & ConvertNullToZero(TaxTotal)
                    Sql &= " , '" & ConvertNullToString(TaxRemark) & "'"
                    Sql &= " , '" & ConvertNullToString(TaxSection) & "'"
                    Sql &= " , '" & ConvertNullToString(TaxType) & "'"
                    Sql &= " ,  " & ConvertNullToZero(ShipingRuleID)
                    Sql &= " , '" & ConvertNullToString(InvoiceSuplierID) & "'"
                    Sql &= " , '" & ConvertNullToString(Institute) & "'"
                    Sql &= " , '" & ConvertNullToString(StockType) & "'"
                    Sql &= " ,  " & IIf(IsSumStock = True, 1, 0)
                    Sql &= " ,  " & IIf(IsMakePO = True, 1, 0)
                    Sql &= " , '" & ConvertNullToString(MakePOStatus) & "'"
                    Sql &= " ,  " & IIf(IsEditVat = True, 1, 0)
                    Sql &= " ,  " & ConvertNullToZero(QuotationRemarkID)
                    Sql &= " ,  " & IIf(IsNotPass = True, 1, 0)
                    Sql &= " ) "

                Case DataMode.ModeEdit
                    If IsCancel = True Then
                        OrderStatus = EnumStatus.Cancel.ToString
                    End If
                    Sql = " UPDATE Orders SET "
                    Sql &= " EmpID=" & ConvertNullToZero(EmpID)
                    Sql &= " , OrderCode='" & ConvertNullToString(Code) & "'"
                    Sql &= " , CustomerID=" & ConvertNullToZero(CustomerID)
                    Sql &= " , CreditRuleID=" & ConvertNullToZero(CreditRuleID)
                    Sql &= " , VatTypeID=" & ConvertNullToZero(VatTypeID)
                    Sql &= " , PO='" & ConvertNullToString(PO) & "'"
                    Sql &= " , OrderStatus='" & ConvertNullToString(OrderStatus) & "'"
                    Sql &= " , IsCancel=" & IIf(IsCancel = True, 1, 0)
                    Sql &= " , CancelRemark='" & ConvertNullToString(CancelRemark) & "'"
                    Sql &= " , Total=" & ConvertNullToZero(Total)
                    Sql &= " , DiscountPercen=" & ConvertNullToZero(DiscountPercen)
                    Sql &= " , DiscountAmount= " & ConvertNullToZero(DiscountAmount)
                    Sql &= " , VatPercen=" & ConvertNullToZero(VatPercen)
                    Sql &= " , VatAmount=" & ConvertNullToZero(VatAmount)
                    Sql &= " , GrandTotal=" & ConvertNullToZero(GrandTotal)
                    Sql &= " , PledgeTotal=" & ConvertNullToZero(PledgeTotal)
                    Sql &= " , Remark='" & ConvertNullToString(Remark) & "'"
                    Sql &= " , ModifiedBy=" & gUserID
                    Sql &= " , ModifiedTime= '" & formatSQLDateTime(GetCurrentDate(ptr)) & "'"
                    Sql &= " , IsInActive= " & IIf(IsInActive = True, 1, 0)
                    Sql &= " , ShipingDate= '" & formatSQLDate(ShipingDate) & "'"
                    Sql &= " , IsSumStock= " & IIf(IsSumStock = True, 1, 0)
                    Sql &= " , IsEditVat= " & IIf(IsEditVat = True, 1, 0)
                    Sql &= " , IsNotPass= " & IIf(IsNotPass = True, 1, 0)
                    Sql &= " , RefBillID= " & RefBillID
                    Sql &= " , RefReceiptID= " & RefReceiptID
                    Sql &= " , SendBy= '" & ConvertNullToString(SendBy) & "'"
                    Sql &= " , OrderDate='" & formatSQLDate(OrderDate) & "'"
                    Sql &= " , ExpireDate='" & formatSQLDate(ExpireDate) & "'"
                    Sql &= " , QuotationDays=" & ConvertNullToZero(QuotationDays)
                    Sql &= " ,ShipingByID= " & ConvertNullToZero(ShipingByID)
                    Sql &= " ,ShipingMethodeID= " & ConvertNullToZero(ShipingMethodID)
                    Sql &= " ,PayType= '" & ConvertNullToString(PayType) & "'"
                    Sql &= " ,BillMedthodID=" & ConvertNullToZero(BillMedthodID)
                    Sql &= " ,PayTotal=" & ConvertNullToZero(PayTotal)
                    Sql &= " ,CurrencyID=" & ConvertNullToZero(CurrencyID)
                    Sql &= " ,ExchangeRate= " & ConvertNullToZero(ExchangeRate)
                    Sql &= " ,TaxCanYes='" & ConvertNullToString(TaxCanYes) & "'"
                    Sql &= " ,TaxCondition='" & ConvertNullToString(TaxCondition) & "'"
                    Sql &= " ,TaxMonthYear= '" & formatSQLDate(TaxMonthYear) & "'"
                    Sql &= " ,TaxNumber='" & ConvertNullToString(TaxNumber) & "'"
                    Sql &= " ,TaxTotal= " & ConvertNullToZero(TaxTotal)
                    Sql &= " ,TaxRemark='" & ConvertNullToString(TaxRemark) & "'"
                    Sql &= " ,TaxSection='" & ConvertNullToString(TaxSection) & "'"
                    Sql &= " ,TaxType='" & ConvertNullToString(TaxType) & "'"
                    Sql &= " ,ShipingRuleID=" & ConvertNullToZero(ShipingRuleID)
                    Sql &= " ,InvoiceSuplierID='" & ConvertNullToString(InvoiceSuplierID) & "'"
                    Sql &= " ,Institute='" & ConvertNullToString(Institute) & "'"
                    Sql &= " ,StockType='" & ConvertNullToString(StockType) & "'"
                    Sql &= " ,QuotationRemarkID=" & ConvertNullToZero(QuotationRemarkID)
                    Sql &= " WHERE OrderID=" & ID
                Case DataMode.ModeDelete
                    Sql = " UPDATE Orders SET IsDelete=1 "
                    Sql &= " ,ModifiedBy= " & gUserID
                    Sql &= " ,ModifiedTime='" & formatSQLDateTime(GetCurrentDate(ptr)) & "'"
                    Sql &= " WHERE OrderID=" & ID
            End Select
            gConnection.executeInsertQuery(Sql, ptr)

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "OrderSDAO.InsertOrder : " & e.Message)
        Finally

        End Try
    End Sub


    Private Sub SaveBalance(ByRef ptr As SqlTransaction)
        Try
            If ModeData = DataMode.ModeNew Or ModeData = DataMode.ModeDelete Then
                If TableID = MasterType.SellOrders And PayType = "CREDIT" Then
                    Dim clsBalance As New CreditBalanceDAO
                    If ModeData = DataMode.ModeNew Then
                        clsBalance.AddBalanc(ptr, CustomerID, ID, OrderDate, GrandTotal, "")
                    Else
                        clsBalance.AddBalanc(ptr, CustomerID, ID, OrderDate, GrandTotal * -1, "Cancel Order")
                    End If

                End If

                'Dis CreditBalance
                If TableID = MasterType.Receipt And PayType = "CASH" Then
                    Dim clsBalance As New CreditBalanceDAO
                    If ModeData = DataMode.ModeNew Then
                        clsBalance.AddBalanc(ptr, CustomerID, ID, OrderDate, GrandTotal * -1, "")
                    Else
                        clsBalance.AddBalanc(ptr, CustomerID, ID, OrderDate, GrandTotal * 1, "Cancel Order")
                    End If
                End If
            ElseIf ModeData = DataMode.ModeEdit Then
                Dim clsBalance As CreditBalanceDAO
                If CustomerID <> Order_Old(ptr).CustomerID Then
                    'Add CreditBalance
                    If TableID = MasterType.SellOrders And PayType = "CREDIT" Then
                        clsBalance = New CreditBalanceDAO
                        'New Cus
                        clsBalance.AddBalanc(ptr, CustomerID, ID, OrderDate, GrandTotal, "")
                        'Old Cus
                        clsBalance = New CreditBalanceDAO
                        clsBalance.AddBalanc(ptr, Order_Old(ptr).CustomerID, ID, OrderDate, GrandTotal * -1, "Cancel Order")
                    End If
                    'Dis CreditBalance
                    If TableID = MasterType.Receipt And PayType = "CASH" Then
                        clsBalance = New CreditBalanceDAO
                        clsBalance.AddBalanc(ptr, CustomerID, ID, OrderDate, GrandTotal * -1, "")
                        'Old Cus
                        clsBalance = New CreditBalanceDAO
                        clsBalance.AddBalanc(ptr, Order_Old(ptr).CustomerID, ID, OrderDate, GrandTotal * 1, "Cancel Order")
                    End If
                ElseIf Order_Old(ptr).GrandTotal <> GrandTotal Then
                    'Add CreditBalance
                    If TableID = MasterType.SellOrders And PayType = "CREDIT" Then
                        clsBalance = New CreditBalanceDAO
                        clsBalance.AddBalanc(ptr, CustomerID, ID, OrderDate, GrandTotal - Order_Old(ptr).GrandTotal, "Edit Order")
                    End If

                    'Dis CreditBalance
                    If TableID = MasterType.Receipt And PayType = "CASH" Then
                        clsBalance = New CreditBalanceDAO
                        clsBalance.AddBalanc(ptr, CustomerID, ID, OrderDate, (GrandTotal - Order_Old(ptr).GrandTotal) * -1, "Edit Order")
                    End If
                End If
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "OrderSDAO.SaveBalance : " & e.Message)
        Finally

        End Try
    End Sub


    Private Sub UpdateBillReceipt(ByRef ptr As SqlTransaction)
        Try
            If ModeData = DataMode.ModeNew Or ModeData = DataMode.ModeDelete Then
                'Ref Bill
                If TableID = MasterType.Bill Then   '*** Check Order Type
                    If IsNothing(OrderDAOs) Then
                        BuildOrderList(ID, ptr)
                    End If
                    If OrderDAOs.Count > 0 Then
                        For Each lRefOrder As SubOrder In OrderDAOs
                            If lRefOrder.OrderID > 0 Then
                                If ModeData = DataMode.ModeNew Then
                                    UpdateOrderByBill(ID, lRefOrder.OrderID, ptr)
                                Else
                                    UpdateOrderByBill(0, lRefOrder.OrderID, ptr)
                                End If
                            End If
                        Next
                    End If
                End If

                'Ref Receipt
                If TableID = MasterType.Receipt Or TableID = MasterType.ReceiptBuy Or TableID = MasterType.ReceiptCut Then   '*** Check Order Type
                    If IsNothing(OrderDAOs) Then
                        BuildOrderList(ID, ptr)
                    End If
                    If OrderDAOs.Count > 0 Then
                        For Each lRefOrder As SubOrder In OrderDAOs
                            If lRefOrder.OrderID > 0 Then
                                If ModeData = DataMode.ModeNew Then
                                    UpdateOrderByReceipt(ID, lRefOrder.OrderID, lRefOrder.BillTotal, ptr)
                                Else
                                    UpdateOrderByReceipt(0, lRefOrder.OrderID, 0, ptr)
                                End If

                            End If
                        Next
                    End If
                End If
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "OrderSDAO.UpdateCost : " & e.Message)
        Finally

        End Try
    End Sub
     
    Private Sub UpdateCost(ByRef ptr As SqlTransaction)
        Try
            If ModeData = DataMode.ModeNew Then
                If (TableID = MasterType.InvoiceBuy) Or (TableID = MasterType.ShipingBuy) Then
                    Dim lclsCost As New ProductCostDAO
                    If ProductDAOs Is Nothing Then
                    ElseIf ProductDAOs.Count > 0 Then
                        For Each ProductList As ProductListDAO In ProductDAOs
                            If ProductList.IsShow = 1 Then
                                lclsCost.ModeData = ModeData
                                lclsCost.SaveData(ProductList.ProductID, ProductCostDAO.CostTypes.Average, ProductList.Price, ProductList.ID, ptr)
                            End If
                        Next
                    End If
                End If
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "OrderSDAO.UpdateCost : " & e.Message)
        Finally

        End Try
    End Sub
     

    Public Function CheckSNIsClose(ByVal pOrderID As Long, ByVal pTableName As String, ByRef ptr As SqlTransaction) As Boolean
        Dim lSNTable As New DataTable
        Dim lclsOrder As New OrderSDAO
        Dim lProductDAOs As New List(Of ProductListDAO)
        Dim lOrderList As New List(Of Long), lclsSN As New SnDAO
        Dim lstrSNError As String = ""
        Try

            lProductDAOs = lclsOrder.BuildProductList(pOrderID, pTableName, ptr)
            For Each pProList As ProductListDAO In lProductDAOs
                lOrderList = New List(Of Long)
                lOrderList.Add(pOrderID)

                lclsSN = New SnDAO
                lSNTable = lclsSN.GetDataTable(lOrderList, pProList.ID, pProList.ProductID, "", ptr, False, "")
                lclsSN = Nothing
                For Each dr2 As DataRow In lSNTable.Rows
                    lclsSN = New SnDAO
                    If lclsSN.CheckSNIsExist(pProList.ProductID, ConvertNullToString(dr2("SerialNumberNo")), "'New'", ptr) = False Then
                        If lstrSNError = "" Then
                            lstrSNError = ConvertNullToString(dr2("SerialNumberNo"))
                        Else
                            lstrSNError = lstrSNError & ", " & ConvertNullToString(dr2("SerialNumberNo"))
                        End If
                        Exit For
                    End If
                Next
            Next
            If lstrSNError = "" Then
                Return False
            Else
                'XtraMessageBox.Show(Me, "Serial Number บางรายการถุก Close แล้ว" & vbNewLine & lstrSNError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Return True
            End If

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "OrderSDAO.CheckBeforeDelete : " & ex.Message)
        End Try
    End Function
End Class
