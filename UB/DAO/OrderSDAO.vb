Option Explicit On
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
                        OrderStatus = "Wait Approve"
                    ElseIf gIsApproveReserve = True And TableID = MasterType.Reserve Then
                        OrderStatus = "Wait Approve"
                    ElseIf gIsApproveQua = True And TableID = MasterType.Quotation Then
                        OrderStatus = "Wait Approve"
                    ElseIf gIsApproveBuyOrder And TableID = MasterType.PurchaseOrder Then
                        OrderStatus = "Wait Approve"
                    ElseIf TableID = MasterType.PurchaseOrder Then
                        OrderStatus = "Waiting"
                    Else
                        OrderStatus = "Open"
                    End If

                    If OrderStatus = "Wait Approve" Then
                        SaveApproveTX(1, DataMode.ModeNew, ID, lTableNameThai, TableName, Code, OrderDate, GrandTotal, "", OrderStatus, tr)
                    End If

                    '*** Check CheckLimitS
                    Dim lIsCheckOver As Boolean = False
                    If gIsCheckLimitSellOrder = True And TableID = MasterType.SellOrders Then
                        lIsCheckOver = True
                    ElseIf gIsCheckLimitReserve = True And TableID = MasterType.Reserve Then
                        lIsCheckOver = True
                    End If

                    If lIsCheckOver = True Then
                        If CheckOverCreditAmount(CustomerID, GrandTotal, tr) Then
                            OrderStatus = "Wait Approve"
                            SaveApproveTX(2, DataMode.ModeNew, ID, lTableNameThai, TableName, Code, OrderDate, GrandTotal, "เกินวงเงิน", OrderStatus, tr)
                        End If
                    End If

                    If PayType = "CASH" Then
                        PayTotal = GrandTotal
                        'if cash to close status
                        Select Case TableID
                            Case MasterType.InvoiceBuy, MasterType.ShipingBuy
                                If OrderStatus = "Open" Then
                                    OrderStatus = "Close"
                                End If
                        End Select
                    Else
                        PayTotal = 0
                    End If

                    If IsCancel = True Then
                        OrderStatus = "Cancel"
                    End If

                    If TableID = MasterType.Reserve Then
                        MakePOStatus = "Ordering"
                    Else
                        MakePOStatus = ""
                    End If

                    SQL = " INSERT INTO Orders  (OrderID,TableID,OrderCode,PO,OrderDate,ShipingDate,CustomerID,EmpID,CreditRuleID,VatTypeID,OrderStatus"
                    SQL = SQL & " ,IsCancel,CancelRemark,Total,DiscountPercen,DiscountAmount,VatPercen,VatAmount,GrandTotal,PledgeTotal"
                    SQL = SQL & " ,Remark,CreateBy,CreateTime,IsInActive,IsDelete "
                    SQL = SQL & " ,RefBillID,SendBy,ExpireDate,QuotationDays,ShipingByID,ShipingMethodeID,AgencyID,PayType"
                    SQL = SQL & " ,BillMedthodID,PayTotal,CurrencyID,ExchangeRate"
                    SQL = SQL & " ,TaxCanYes,TaxCondition,TaxMonthYear,TaxNumber,TaxTotal "
                    SQL = SQL & " ,TaxRemark,TaxSection,TaxType,ShipingRuleID,InvoiceSuplierID,Institute,StockType,IsSumStock,IsMakePO,MakePOStatus,IsEditVat"
                    SQL = SQL & " ,QuotationRemarkID,IsNotPass)"
                    SQL = SQL & " VALUES ( " & ID
                    SQL = SQL & " , " & TableID
                    SQL = SQL & " , '" & Trim(Code) & "'"
                    SQL = SQL & " , '" & ConvertNullToString(PO) & "'"
                    SQL = SQL & " , '" & formatSQLDate(OrderDate) & "'"
                    SQL = SQL & " , '" & formatSQLDate(ShipingDate) & "'"
                    SQL = SQL & " , " & ConvertNullToZero(CustomerID)
                    SQL = SQL & " , " & ConvertNullToZero(EmpID)
                    SQL = SQL & " , " & ConvertNullToZero(CreditRuleID)
                    SQL = SQL & " , " & ConvertNullToZero(VatTypeID)
                    SQL = SQL & " , '" & ConvertNullToString(OrderStatus) & "'"
                    SQL = SQL & " , " & IIf(IsCancel = True, 1, 0)
                    SQL = SQL & " , '" & ConvertNullToString(CancelRemark) & "'"
                    SQL = SQL & " ,  " & ConvertNullToZero(Total)
                    SQL = SQL & " ,  " & ConvertNullToZero(DiscountPercen)
                    SQL = SQL & " ,  " & ConvertNullToZero(DiscountAmount)
                    SQL = SQL & " ,  " & ConvertNullToZero(VatPercen)
                    SQL = SQL & " ,  " & ConvertNullToZero(VatAmount)
                    SQL = SQL & " ,  " & ConvertNullToZero(GrandTotal)
                    SQL = SQL & " ,  " & ConvertNullToZero(PledgeTotal)
                    SQL = SQL & " , '" & ConvertNullToString(Remark) & "'"
                    SQL = SQL & " ,  " & gUserID
                    SQL = SQL & " , '" & formatSQLDateTime(GetCurrentDate(tr)) & "'"
                    SQL = SQL & " ,  " & IIf(IsInActive = True, 1, 0)
                    SQL = SQL & " ,0 "
                    'SQL = SQL & " , " & RefOrderID
                    SQL = SQL & " , " & RefBillID
                    SQL = SQL & " , '" & ConvertNullToString(SendBy) & "'"
                    SQL = SQL & " , '" & formatSQLDate(ExpireDate) & "'"
                    SQL = SQL & " ,  " & ConvertNullToZero(QuotationDays)
                    SQL = SQL & " ,  " & ConvertNullToZero(ShipingByID)
                    SQL = SQL & " ,  " & ConvertNullToZero(ShipingMethodID)
                    SQL = SQL & " ,  " & 0
                    SQL = SQL & " , '" & ConvertNullToString(PayType) & "'"
                    SQL = SQL & " ,  " & ConvertNullToZero(BillMedthodID)
                    SQL = SQL & " ,  " & ConvertNullToZero(PayTotal)
                    SQL = SQL & " ,  " & ConvertNullToZero(CurrencyID)
                    SQL = SQL & " ,  " & ConvertNullToZero(ExchangeRate)
                    SQL = SQL & " , '" & ConvertNullToString(TaxCanYes) & "'"
                    SQL = SQL & " , '" & ConvertNullToString(TaxCondition) & "'"
                    SQL = SQL & " , '" & formatSQLDate(TaxMonthYear) & "'"
                    SQL = SQL & " , '" & ConvertNullToString(TaxNumber) & "'"
                    SQL = SQL & " ,  " & ConvertNullToZero(TaxTotal)
                    SQL = SQL & " , '" & ConvertNullToString(TaxRemark) & "'"
                    SQL = SQL & " , '" & ConvertNullToString(TaxSection) & "'"
                    SQL = SQL & " , '" & ConvertNullToString(TaxType) & "'"
                    SQL = SQL & " ,  " & ConvertNullToZero(ShipingRuleID)
                    SQL = SQL & " , '" & ConvertNullToString(InvoiceSuplierID) & "'"
                    SQL = SQL & " , '" & ConvertNullToString(Institute) & "'"
                    SQL = SQL & " , '" & ConvertNullToString(StockType) & "'"
                    SQL = SQL & " ,  " & IIf(IsSumStock = True, 1, 0)
                    SQL = SQL & " ,  " & IIf(IsMakePO = True, 1, 0)
                    SQL = SQL & " , '" & ConvertNullToString(MakePOStatus) & "'"
                    SQL = SQL & " ,  " & IIf(IsEditVat = True, 1, 0)
                    SQL = SQL & " ,  " & ConvertNullToZero(QuotationRemarkID)
                    SQL = SQL & " ,  " & IIf(IsNotPass = True, 1, 0)
                    SQL = SQL & " ) "

                Case DataMode.ModeEdit
                    If IsCancel = True Then
                        OrderStatus = "Cancel"
                    End If
                    SQL = " UPDATE Orders SET "
                    SQL = SQL & " EmpID=" & ConvertNullToZero(EmpID)
                    SQL = SQL & " , OrderCode='" & ConvertNullToString(Code) & "'"
                    SQL = SQL & " , CustomerID=" & ConvertNullToZero(CustomerID)
                    SQL = SQL & " , CreditRuleID=" & ConvertNullToZero(CreditRuleID)
                    SQL = SQL & " , VatTypeID=" & ConvertNullToZero(VatTypeID)
                    SQL = SQL & " , PO='" & ConvertNullToString(PO) & "'"
                    SQL = SQL & " , OrderStatus='" & ConvertNullToString(OrderStatus) & "'"
                    SQL = SQL & " , IsCancel=" & IIf(IsCancel = True, 1, 0)
                    SQL = SQL & " , CancelRemark='" & ConvertNullToString(CancelRemark) & "'"
                    SQL = SQL & " , Total=" & ConvertNullToZero(Total)
                    SQL = SQL & " , DiscountPercen=" & ConvertNullToZero(DiscountPercen)
                    SQL = SQL & " , DiscountAmount= " & ConvertNullToZero(DiscountAmount)
                    SQL = SQL & " , VatPercen=" & ConvertNullToZero(VatPercen)
                    SQL = SQL & " , VatAmount=" & ConvertNullToZero(VatAmount)
                    SQL = SQL & " , GrandTotal=" & ConvertNullToZero(GrandTotal)
                    SQL = SQL & " , PledgeTotal=" & ConvertNullToZero(PledgeTotal)
                    SQL = SQL & " , Remark='" & ConvertNullToString(Remark) & "'"
                    SQL = SQL & " , ModifiedBy=" & gUserID
                    SQL = SQL & " , ModifiedTime= '" & formatSQLDateTime(GetCurrentDate(tr)) & "'"
                    SQL = SQL & " , IsInActive= " & IIf(IsInActive = True, 1, 0)
                    SQL = SQL & " , ShipingDate= '" & formatSQLDate(ShipingDate) & "'"
                    SQL = SQL & " , IsSumStock= " & IIf(IsSumStock = True, 1, 0)
                    SQL = SQL & " , IsEditVat= " & IIf(IsEditVat = True, 1, 0)
                    SQL = SQL & " , IsNotPass= " & IIf(IsNotPass = True, 1, 0)
                    SQL = SQL & " , RefBillID= " & RefBillID
                    SQL = SQL & " , RefReceiptID= " & RefReceiptID
                    SQL = SQL & " , SendBy= '" & ConvertNullToString(SendBy) & "'"
                    SQL = SQL & " , OrderDate='" & formatSQLDate(OrderDate) & "'"
                    SQL = SQL & " , ExpireDate='" & formatSQLDate(ExpireDate) & "'"
                    SQL = SQL & " , QuotationDays=" & ConvertNullToZero(QuotationDays)
                    SQL = SQL & " ,ShipingByID= " & ConvertNullToZero(ShipingByID)
                    SQL = SQL & " ,ShipingMethodeID= " & ConvertNullToZero(ShipingMethodID)
                    SQL = SQL & " ,PayType= '" & ConvertNullToString(PayType) & "'"
                    SQL = SQL & " ,BillMedthodID=" & ConvertNullToZero(BillMedthodID)
                    SQL = SQL & " ,PayTotal=" & ConvertNullToZero(PayTotal)
                    SQL = SQL & " ,CurrencyID=" & ConvertNullToZero(CurrencyID)
                    SQL = SQL & " ,ExchangeRate= " & ConvertNullToZero(ExchangeRate)
                    SQL = SQL & " ,TaxCanYes='" & ConvertNullToString(TaxCanYes) & "'"
                    SQL = SQL & " ,TaxCondition='" & ConvertNullToString(TaxCondition) & "'"
                    SQL = SQL & " ,TaxMonthYear= '" & formatSQLDate(TaxMonthYear) & "'"
                    SQL = SQL & " ,TaxNumber='" & ConvertNullToString(TaxNumber) & "'"
                    SQL = SQL & " ,TaxTotal= " & ConvertNullToZero(TaxTotal)
                    SQL = SQL & " ,TaxRemark='" & ConvertNullToString(TaxRemark) & "'"
                    SQL = SQL & " ,TaxSection='" & ConvertNullToString(TaxSection) & "'"
                    SQL = SQL & " ,TaxType='" & ConvertNullToString(TaxType) & "'"
                    SQL = SQL & " ,ShipingRuleID=" & ConvertNullToZero(ShipingRuleID)
                    SQL = SQL & " ,InvoiceSuplierID='" & ConvertNullToString(InvoiceSuplierID) & "'"
                    SQL = SQL & " ,Institute='" & ConvertNullToString(Institute) & "'"
                    SQL = SQL & " ,StockType='" & ConvertNullToString(StockType) & "'"
                    SQL = SQL & " ,QuotationRemarkID=" & ConvertNullToZero(QuotationRemarkID)
                    SQL = SQL & " WHERE OrderID=" & ID
                Case DataMode.ModeDelete
                        SQL = " UPDATE Orders SET IsDelete=1 "
                        SQL = SQL & " ,ModifiedBy= " & gUserID
                        SQL = SQL & " ,ModifiedTime='" & formatSQLDateTime(GetCurrentDate(tr)) & "'"
                        SQL = SQL & " WHERE OrderID=" & ID
            End Select
            gConnection.executeInsertQuery(SQL, tr)

            'Initial ALL List
            If ProductDAOs Is Nothing OrElse ProductDAOs.Count = 0 Then
                BuildProductList(ID, TableName, tr)
            End If

            UpdateCost(tr)

            'Condition for update etc.
            If ModeData = DataMode.ModeNew Or ModeData = DataMode.ModeDelete Then
                If ModeData = DataMode.ModeNew Then
                    UpdateLastID(TableID, tr)
                End If

                'Ref Bill
                If TableID = MasterType.Bill Then   '*** Check Order Type
                    If IsNothing(OrderDAOs) Then
                        BuildOrderList(ID, tr)
                    End If
                    If OrderDAOs.Count > 0 Then
                        For Each lRefOrder As SubOrder In OrderDAOs
                            If lRefOrder.OrderID > 0 Then
                                If ModeData = DataMode.ModeNew Then
                                    UpdateOrderByBill(ID, lRefOrder.OrderID, tr)
                                Else
                                    UpdateOrderByBill(0, lRefOrder.OrderID, tr)
                                End If
                            End If
                        Next
                    End If
                End If

                'Ref Receipt
                If TableID = MasterType.Receipt Or TableID = MasterType.ReceiptBuy Or TableID = MasterType.ReceiptCut Then   '*** Check Order Type
                    If IsNothing(OrderDAOs) Then
                        BuildOrderList(ID, tr)
                    End If
                    If OrderDAOs.Count > 0 Then
                        For Each lRefOrder As SubOrder In OrderDAOs
                            If lRefOrder.OrderID > 0 Then
                                If ModeData = DataMode.ModeNew Then
                                    UpdateOrderByReceipt(ID, lRefOrder.OrderID, lRefOrder.BillTotal, tr)
                                Else
                                    UpdateOrderByReceipt(0, lRefOrder.OrderID, 0, tr)
                                End If

                            End If
                        Next
                    End If
                End If

                'Add CreditBalance
                If TableID = MasterType.SellOrders And PayType = "CREDIT" Then
                    Dim clsBalance As New CreditBalanceDAO
                    If ModeData = DataMode.ModeNew Then
                        clsBalance.AddBalanc(tr, CustomerID, ID, OrderDate, GrandTotal, "")
                    Else
                        clsBalance.AddBalanc(tr, CustomerID, ID, OrderDate, GrandTotal * -1, "Cancel Order")
                    End If

                End If

                'Dis CreditBalance
                If TableID = MasterType.Receipt And PayType = "CASH" Then
                    Dim clsBalance As New CreditBalanceDAO
                    If ModeData = DataMode.ModeNew Then
                        clsBalance.AddBalanc(tr, CustomerID, ID, OrderDate, GrandTotal * -1, "")
                    Else
                        clsBalance.AddBalanc(tr, CustomerID, ID, OrderDate, GrandTotal * 1, "Cancel Order")
                    End If
                End If
            ElseIf ModeData = DataMode.ModeEdit Then
                Dim clsBalance As CreditBalanceDAO
                If CustomerID <> Order_Old(tr).CustomerID Then
                    'Add CreditBalance
                    If TableID = MasterType.SellOrders And PayType = "CREDIT" Then
                        clsBalance = New CreditBalanceDAO
                        'New Cus
                        clsBalance.AddBalanc(tr, CustomerID, ID, OrderDate, GrandTotal, "")
                        'Old Cus
                        clsBalance = New CreditBalanceDAO
                        clsBalance.AddBalanc(tr, Order_Old(tr).CustomerID, ID, OrderDate, GrandTotal * -1, "Cancel Order")
                    End If
                    'Dis CreditBalance
                    If TableID = MasterType.Receipt And PayType = "CASH" Then
                        clsBalance = New CreditBalanceDAO
                        clsBalance.AddBalanc(tr, CustomerID, ID, OrderDate, GrandTotal * -1, "")
                        'Old Cus
                        clsBalance = New CreditBalanceDAO
                        clsBalance.AddBalanc(tr, Order_Old(tr).CustomerID, ID, OrderDate, GrandTotal * 1, "Cancel Order")
                    End If
                ElseIf Order_Old(tr).GrandTotal <> GrandTotal Then
                    'Add CreditBalance
                    If TableID = MasterType.SellOrders And PayType = "CREDIT" Then
                        clsBalance = New CreditBalanceDAO
                        clsBalance.AddBalanc(tr, CustomerID, ID, OrderDate, GrandTotal - Order_Old(tr).GrandTotal, "Edit Order")
                    End If

                    'Dis CreditBalance
                    If TableID = MasterType.Receipt And PayType = "CASH" Then
                        clsBalance = New CreditBalanceDAO
                        clsBalance.AddBalanc(tr, CustomerID, ID, OrderDate, (GrandTotal - Order_Old(tr).GrandTotal) * -1, "Edit Order")
                    End If
                End If

            End If
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
          
            'If ModeData = DataMode.ModeNew Or ModeData = DataMode.ModeDelete Then
            'Ref Order
            'Rebuild RefToOrderID
            If ModeData = DataMode.ModeDelete Then
                Call GetToRefOrderCode(ID, tr)
                If IsMakePO = True Then
                    Call GetToRefReserveCode(ID, tr)
                End If
            End If

            If IsNothing(RefToOrderID) = False Then
                Select Case TableID
                    Case MasterType.SellOrders, MasterType.Invoice, MasterType.Borrow, MasterType.Shiping, MasterType.InvoiceBuy, MasterType.Reserve, MasterType.ShipingBuy

                        If RefToOrderID.Count > 0 Then
                            For Each pOrderID As Long In RefToOrderID
                                If ModeData = DataMode.ModeNew Or ModeData = DataMode.ModeEdit Then
                                    UpdateRefOrderStatus(TableID, ID, pOrderID, "Close", tr, ModeData)
                                    SetFlagProductList(ProductDAOs, True, pOrderID, tr)
                                Else 'Delete
                                    UpdateRefOrderStatus(TableID, ID, pOrderID, "Open", tr, ModeData)
                                    SetFlagProductList(ProductDAOs, False, pOrderID, tr)
                                End If
                            Next
                        End If
                    Case MasterType.ReduceCredit, MasterType.ReduceCreditBuy, MasterType.AddCredit, MasterType.AddCreditBuy, MasterType.StockIn, MasterType.Asset, MasterType.Claim, MasterType.Expose
                        If ModeData = DataMode.ModeDelete Then
                            Call GetToRefOrderCode(ID, tr)
                        End If
                        If RefToOrderID.Count > 0 Then
                            For Each pOrderID As Long In RefToOrderID
                                If ModeData = DataMode.ModeNew Or ModeData = DataMode.ModeEdit Then
                                    UpdateRefOrderStatus(TableID, ID, pOrderID, "", tr, ModeData)
                                Else 'Delete
                                    UpdateRefOrderStatus(TableID, ID, pOrderID, "", tr, ModeData)
                                End If
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
                    SQL = SQL & " ,CASE WHEN Customer.CompanyName <>'' THEN Customer.CompanyName ELSE Customer.Title + Customer.Firstname + ' ' + Customer.LastName END Customer "
                Case MasterType.Quotation
                    SQL = "SELECT DISTINCT Orders.OrderID AS ID,Orders.OrderCode AS Code,Orders.OrderDate,Orders.ExpireDate  "
                    SQL = SQL & " ,CASE WHEN Customer.CompanyName <>'' THEN Customer.CompanyName ELSE Customer.Title + Customer.Firstname + ' ' + Customer.LastName END Customer "
                Case MasterType.PurchaseOrder, MasterType.Asset, MasterType.ShipingBuy, MasterType.InvoiceBuy, MasterType.AddCreditBuy, MasterType.ReduceCreditBuy _
                    , MasterType.ClaimOut, MasterType.ReceiptBuy, MasterType.CancelPO
                    SQL = "SELECT DISTINCT Orders.OrderID AS ID,Orders.OrderCode AS Code,Orders.OrderDate  "
                    SQL = SQL & " ,CASE WHEN Customer.CompanyName <>'' THEN Customer.CompanyName ELSE Customer.Title + Customer.Firstname + ' ' + Customer.LastName END Customer "
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
          

            SQL = "SELECT Orders.OrderID  FROM OrdersRef,Orders  "
            SQL = SQL & " WHERE OrdersRef.OrderID=Orders.OrderID and OrdersRef.IsDelete=0  and OrdersRef.RefOrderID=" & ID
            SQL = SQL & " and Orders.IsDelete=0"

            If TableID = MasterType.Quotation Then
                SQL = SQL & " and Orders.TableID in(" & MasterType.Reserve & ")"
            ElseIf TableID = MasterType.Reserve Then
                SQL = SQL & " and Orders.TableID in(" & MasterType.SellOrders & ")"
            End If
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            If dataTable.Rows.Count > 0 Then
                Return True
            End If
            'Return False

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

    Public Sub BuildProductList(ByVal pRefID As Long, ByVal pRefTable As String, ByRef ptr As SqlTransaction)
        Dim lcls As New ProductListDAO
        Dim dataTable As New DataTable()
        Dim lOrderList As New List(Of Long)
        lOrderList.Add(pRefID)
        Try
            ProductDAOs = New List(Of ProductListDAO)
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
                    rec.Remark = ConvertNullToString(dr("Remark"))
                    rec.KeepMin = ConvertNullToZero(dr("KeepMin"))
                    rec.Units = ConvertNullToZero(dr("Units"))
                    rec.Units_Old = rec.Units
                    rec.Price = ConvertNullToZero(dr("Price"))
                    rec.Cost = ConvertNullToZero(dr("Cost"))
                    rec.Discount = ConvertNullToZero(dr("Discount"))
                    rec.Total = ConvertNullToZero(dr("Total"))
                    ProductDAOs.Add(rec)
                Next
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "OrderSDAO.BuildProductList : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Sub

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
        Dim lstrStayIDList As String = "", lSEQ As Long = 1
        Dim lclsSN As SnDAO, lclsSN2 As SnDAO
        Dim lSNTable As DataTable
        Dim lOrderList As New List(Of Long), lSNInList As String = ""
        Dim lUpdateStstus As Boolean = False
        Dim lIsUpdate As Integer = 0  ' 0=no, 1=sum, 2=second
        Dim lclsStock As ProductStockDAO

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
                    ElseIf ModeData = DataMode.ModeNew Then
                        pProList.ModeData = DataMode.ModeNew
                        pProList.IsConfirm = 0
                    End If

                    If pProList.SaveData(tr) Then
                        If ModeData = DataMode.ModeEdit Then
                            If pProList.ID > 0 Then
                                lstrStayIDList = IIf(lstrStayIDList = "", pProList.ID, lstrStayIDList & "," & pProList.ID)
                            End If
                        End If

                        If pProList.IsShow = 1 Then
                            '*** Stock
                            UpdateStock(tr, pProList, lIsUpdate)

                            '*** SN
                            If ModeData = DataMode.ModeDelete Then
                                'Re Open status
                                If TableName = MasterType.SellOrders.ToString Or (lIsUpdate = 3 And StockType = "O") Then
                                    lOrderList = New List(Of Long)
                                    lOrderList.Add(RefID)

                                    lclsSN = New SnDAO
                                    lSNTable = lclsSN.GetDataTable(lOrderList, pProList.ID, pProList.ProductID, "", tr, ModeData = DataMode.ModeDelete, "")
                                    For Each dr2 As DataRow In lSNTable.Rows
                                        lclsSN2 = New SnDAO
                                        lclsSN2.SetStatusBySN(tr, ConvertNullToZero(dr2("ProductID")), ConvertNullToString(dr2("SerialNumberNo")), "New")
                                    Next
                                End If

                                'Delete
                                lclsSN2 = New SnDAO
                                lclsSN2.DeleteFromModeDelete(tr, RefID, pProList.ID)

                            Else
                                If IsNothing(pProList.SNList) = False Then
                                    For Each pclsSN As SnDAO In pProList.SNList
                                        lUpdateStstus = False
                                        lclsSN = pclsSN
                                        If ModeData = DataMode.ModeNew Then
                                            lclsSN.SerialNumberID = 0
                                            If TableName = MasterType.StockIn.ToString Or TableName = MasterType.UpdateStock.ToString _
                                                Or (lIsUpdate = 3 And StockType = "I") Then
                                                lclsSN.Status = "New"
                                            Else
                                                lclsSN.Status = "None"
                                            End If
                                        End If
                                        If TableName = MasterType.UpdateStock.ToString And pProList.Units < 0 Then
                                            lclsSN.Status = "None"
                                            lUpdateStstus = True
                                        End If
                                        lclsSN.OrderID = RefID
                                        lclsSN.ProductListID = pProList.ID
                                        lclsSN.ProductID = pProList.ProductID
                                        lclsSN.SerialNumberNo = pclsSN.SerialNumberNo
                                        lclsSN.SaveData(tr, ModeData, lUpdateStstus)

                                        'Close SN
                                        If TableName = MasterType.SellOrders.ToString Or (lIsUpdate = 3 And StockType = "O") Then
                                            lclsSN2 = New SnDAO
                                            lclsSN2.SetStatusBySN(tr, pProList.ProductID, lclsSN.SerialNumberNo, "Close")
                                        End If

                                        If ModeData = DataMode.ModeEdit Then
                                            If lclsSN.SerialNumberID > 0 Then
                                                lSNInList = IIf(lSNInList = "", lclsSN.SerialNumberID, lSNInList & "," & lclsSN.SerialNumberID)
                                            End If
                                        End If
                                    Next

                                    If lSNInList <> "" And ModeData = DataMode.ModeEdit Then
                                        If TableName = MasterType.SellOrders.ToString Or (lIsUpdate = 3 And StockType = "O") Then
                                            lclsSN2 = New SnDAO
                                            lclsSN2.SetStatusBySNAtRemove(tr, RefID, pProList.ProductID, lSNInList, "New", pProList.ID)
                                        End If
                                        lclsSN2 = New SnDAO
                                        lclsSN2.DeleteRemoveData(tr, RefID, pProList.ProductID, lSNInList, pProList.ID)
                                    End If
                                    lSNInList = ""
                                End If
                            End If '*** SN
                        End If '*** Is show

                    End If
                    If pProList.IsShow = 1 Then
                        lSEQ = lSEQ + 1
                    End If
                Next

                'Delete Remove Item
                If ModeData = DataMode.ModeEdit And lstrStayIDList <> "" Then
                    'SN
                    If TableName = MasterType.SellOrders.ToString Or (lIsUpdate = 3 And StockType = "O") Then
                        lclsSN = New SnDAO
                        lclsSN.SetStatusFromProListRemove(tr, RefID, lstrStayIDList, "New")
                    End If

                    lclsSN2 = New SnDAO
                    lclsSN2.DeleteFromProListRemove(tr, RefID, lstrStayIDList)

                    'Stock
                    If lIsUpdate = 4 Then
                        Dim lclsProlist As New ProductListDAO
                        Dim dataTable As New DataTable()
                        lOrderList = New List(Of Long)
                        lOrderList.Add(ID)
                        dataTable = lclsProlist.GetDataTable(lOrderList, TableName, tr, False, lstrStayIDList, False, 0, True)

                        For Each dr As DataRow In dataTable.Rows
                            If ConvertNullToZero(dr("IsShow")) = 1 Then
                                lclsStock = New ProductStockDAO
                                lclsStock.ProductID = ConvertNullToZero(dr("ProductID"))
                                lclsStock.UnitID = ConvertNullToZero(dr("UnitID"))
                                lclsStock.LocationDTLID = ConvertNullToZero(dr("LocationDTLID"))
                                lclsStock.Units = ConvertNullToZero(dr("Units")) * -1

                                lclsStock.SaveData(tr, False, False, ID, Code)
                                lclsStock.SaveData(tr, True, False, ID, Code)
                            End If

                         
                        Next

                    ElseIf lIsUpdate = 5 Then
                        Dim lclsProlist As New ProductListDAO
                        Dim dataTable As New DataTable()
                        lOrderList = New List(Of Long)
                        lOrderList.Add(ID)
                        dataTable = lclsProlist.GetDataTable(lOrderList, TableName, tr, False, lstrStayIDList, False, 0, True)

                        For Each dr As DataRow In dataTable.Rows
                            If ConvertNullToZero(dr("IsShow")) = 1 Then
                                lclsStock = New ProductStockDAO
                                lclsStock.ProductID = ConvertNullToZero(dr("ProductID"))
                                lclsStock.UnitID = ConvertNullToZero(dr("UnitID"))
                                lclsStock.LocationDTLID = ConvertNullToZero(dr("LocationDTLID"))
                                lclsStock.Units = ConvertNullToZero(dr("Units")) * -1

                                lclsStock.SaveData(tr, False, False, ID, Code)
                                If IsSumStock = True Then
                                    lclsStock.SaveData(tr, True, False, ID, Code)
                                End If
                            End If

                        Next
                    ElseIf lIsUpdate > 0 Then
                        Dim lclsProlist As New ProductListDAO
                        Dim dataTable As New DataTable()
                        lOrderList = New List(Of Long)
                        lOrderList.Add(ID)
                        dataTable = lclsProlist.GetDataTable(lOrderList, TableName, tr, False, lstrStayIDList, False, 0, True)

                        For Each dr As DataRow In dataTable.Rows
                            If ConvertNullToZero(dr("IsShow")) = 1 Then
                                lclsStock = New ProductStockDAO
                                lclsStock.ProductID = ConvertNullToZero(dr("ProductID"))
                                lclsStock.UnitID = ConvertNullToZero(dr("UnitID"))
                                lclsStock.LocationDTLID = ConvertNullToZero(dr("LocationDTLID"))

                                lclsStock.Units = ConvertNullToZero(dr("Units")) * 1

                                If lIsUpdate = 1 Then  'sell stock sum
                                    lclsStock.SaveData(tr, True, False, ID, Code)
                                ElseIf lIsUpdate = 2 Then
                                    lclsStock.SaveData(tr, False, False, ID, Code)
                                ElseIf lIsUpdate = 3 Then
                                    If StockType = "I" Then
                                        lclsStock.Units = lclsStock.Units * -1 ' I = คืนสต็อก
                                    End If
                                    lclsStock.SaveData(tr, False, False, ID, Code)
                                    lclsStock.SaveData(tr, True, False, ID, Code)
                                End If
                            End If
                        Next
                    End If

                    'ProList
                    Dim ProList As New ProductListDAO
                    ProList.RefID = RefID
                    ProList.RefTable = TableName
                    ProList.DeleteRemoveData(tr, lstrStayIDList)
                End If
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SaveProductList" & e.Message)
        End Try

    End Sub


    Private Sub UpdateStock(ByRef ptr As SqlTransaction, ByVal pProductList As ProductListDAO, ByVal pIsUpdate As Integer)
        Dim lcls As New ProductStockDAO
        Try

            Dim lclsStock As ProductStockDAO
            Dim lclsStock_Old As ProductStockDAO


            If pIsUpdate = 4 Then ''** Stock in
                'Update Stock +
                lclsStock = New ProductStockDAO
                lclsStock.ProductID = pProductList.ProductID
                lclsStock.UnitID = pProductList.UnitID
                lclsStock.LocationDTLID = pProductList.LocationDTLID
                lclsStock.Cost = pProductList.Cost


                If ModeData = DataMode.ModeDelete Then
                    lclsStock.Units = pProductList.Units * -1
                ElseIf pProductList.ID = 0 Then
                    lclsStock.Units = pProductList.Units * 1
                ElseIf pProductList.ID > 0 Then
                    'if change location in mode edit
                    If pProductList.LocationDTLID <> pProductList.LocationDTLID_Old Then
                        'Remove unit from old location stock
                        lclsStock_Old = New ProductStockDAO
                        lclsStock_Old.ProductID = pProductList.ProductID
                        lclsStock_Old.UnitID = pProductList.UnitID
                        lclsStock_Old.LocationDTLID = pProductList.LocationDTLID_Old
                        lclsStock_Old.Cost = pProductList.Cost
                        lclsStock_Old.Units = pProductList.Units_Old * -1
                        lclsStock_Old.SaveData(ptr, False, False, ID, Code)
                        lclsStock_Old.SaveData(ptr, True, False, ID, Code)

                        'Add new unit to new location
                        lclsStock.Units = pProductList.Units
                    Else
                        If pProductList.Units = pProductList.Units_Old Then
                            lclsStock.Units = 0
                        Else
                            lclsStock.Units = (pProductList.Units - pProductList.Units_Old)
                        End If
                    End If

                End If
 

                lclsStock.SaveData(ptr, False, False, ID, Code)
                lclsStock.SaveData(ptr, True, False, ID, Code)


                 

            ElseIf pIsUpdate = 5 Then ''Update stock

                lclsStock = New ProductStockDAO
                lclsStock.ProductID = pProductList.ProductID
                lclsStock.UnitID = pProductList.UnitID
                lclsStock.LocationDTLID = pProductList.LocationDTLID
                lclsStock.Cost = pProductList.Cost

                If ModeData = DataMode.ModeDelete Then
                    lclsStock.Units = pProductList.Units * -1
                ElseIf pProductList.ID = 0 Then
                    lclsStock.Units = pProductList.Units * 1
                ElseIf pProductList.ID > 0 Then
                    'if change location in mode edit
                    If pProductList.LocationDTLID <> pProductList.LocationDTLID_Old Then
                        'Remove unit from old location stock
                        lclsStock_Old = New ProductStockDAO
                        lclsStock_Old.ProductID = pProductList.ProductID
                        lclsStock_Old.UnitID = pProductList.UnitID
                        lclsStock_Old.LocationDTLID = pProductList.LocationDTLID_Old
                        lclsStock_Old.Cost = pProductList.Cost
                        lclsStock_Old.Units = pProductList.Units_Old * -1
                        lclsStock_Old.SaveData(ptr, False, False, ID, Code)
                        If IsSumStock = True Then
                            lclsStock_Old.SaveData(ptr, True, False, ID, Code)
                        End If

                        'Add new unit to new location
                        lclsStock.Units = pProductList.Units
                    Else
                        If pProductList.Units = pProductList.Units_Old Then
                            lclsStock.Units = 0
                        Else
                            lclsStock.Units = (pProductList.Units - pProductList.Units_Old)
                        End If
                    End If
                End If

                lclsStock.SaveData(ptr, False, False, ID, Code)
                If IsSumStock = True Then
                    lclsStock.SaveData(ptr, True, False, ID, Code)
                End If
                 

            ElseIf pIsUpdate > 0 Then

                lcls = New ProductStockDAO
                lcls.ProductID = pProductList.ProductID
                lcls.UnitID = pProductList.UnitID
                lcls.LocationDTLID = pProductList.LocationDTLID

                If ModeData = DataMode.ModeDelete Then
                    lcls.Units = pProductList.Units * 1
                ElseIf pProductList.ID = 0 Then
                    lcls.Units = pProductList.Units * -1
                ElseIf pProductList.ID > 0 Then
                    If pProductList.Units = pProductList.Units_Old Then
                        lcls.Units = 0
                    Else
                        lcls.Units = (pProductList.Units - pProductList.Units_Old) * -1
                    End If
                End If

                If pIsUpdate = 1 Then  'sell stock sum
                    lcls.SaveData(ptr, True, False, ID, Code)
                ElseIf pIsUpdate = 2 Then
                    lcls.SaveData(ptr, False, False, ID, Code)
                ElseIf pIsUpdate = 3 Then
                    If StockType = "I" Then
                        lcls.Units = lcls.Units * -1 ' I = คืนสต็อก
                    End If
                    lcls.SaveData(ptr, False, False, ID, Code)
                    lcls.SaveData(ptr, True, False, ID, Code)
                End If
            End If
            'End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "OrderSDAO.UpdateStock : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub


    'Private Sub UpdateStock(ByRef ptr As SqlTransaction)
    '    Dim lcls As New ProductStockDAO
    '    Dim lIsUpdate As Integer = 0  ' 0=no, 1=sum, 2=second
    '    Dim lProInList As String = ""

    '    Try
    '        If TableID = MasterType.SellOrders Then
    '            lIsUpdate = 1
    '        ElseIf (TableID = MasterType.Invoice) Or (TableID = MasterType.Shiping) Or (TableID = MasterType.Borrow) Then
    '            lIsUpdate = 2
    '            If IsNothing(RefToOrderID) = False Then
    '                If RefToOrderID.Count > 0 And TableID = MasterType.Invoice Then
    '                    For Each pOrderID As Long In RefToOrderID
    '                        Dim lclsOrder As New OrderSDAO
    '                        If lclsOrder.InitailData(pOrderID, , ptr) Then
    '                            If lclsOrder.TableID = MasterType.Borrow Then
    '                                lIsUpdate = 0
    '                            End If
    '                        End If
    '                    Next
    '                End If
    '            End If
    '        ElseIf (TableID = MasterType.ReduceCredit) Or (TableID = MasterType.AddCredit) _
    '                Or (TableID = MasterType.ReduceCreditBuy) Or (TableID = MasterType.AddCreditBuy) Then
    '            If StockType = "N" Or StockType = "" Then
    '                lIsUpdate = 0
    '            Else
    '                lIsUpdate = 3
    '            End If
    '        ElseIf (TableID = MasterType.StockIn) Then
    '            lIsUpdate = 4
    '        ElseIf (TableID = MasterType.UpdateStock) Then
    '            lIsUpdate = 5
    '        End If

    '        Dim lclsStock As ProductStockDAO
    '        Dim lclsStock_Old As ProductStockDAO


    '        If lIsUpdate = 4 Then ''** Stock in
    '            lProInList = ""
    '            'Update Stock +

    '            If ProductDAOs Is Nothing Then
    '            ElseIf ProductDAOs.Count = 0 Then
    '            Else
    '                For Each ProductList As ProductListDAO In ProductDAOs
    '                    lclsStock = New ProductStockDAO
    '                    lclsStock.ProductID = ProductList.ProductID
    '                    lclsStock.UnitID = ProductList.UnitID
    '                    lclsStock.LocationDTLID = ProductList.LocationDTLID
    '                    lclsStock.Cost = ProductList.Cost


    '                    If ModeData = DataMode.ModeDelete Then
    '                        lclsStock.Units = ProductList.Units * -1
    '                    ElseIf ProductList.ID = 0 Then
    '                        lclsStock.Units = ProductList.Units * 1
    '                    ElseIf ProductList.ID > 0 Then
    '                        'if change location in mode edit
    '                        If ProductList.LocationDTLID <> ProductList.LocationDTLID_Old Then
    '                            'Remove unit from old location stock
    '                            lclsStock_Old = New ProductStockDAO
    '                            lclsStock_Old.ProductID = ProductList.ProductID
    '                            lclsStock_Old.UnitID = ProductList.UnitID
    '                            lclsStock_Old.LocationDTLID = ProductList.LocationDTLID_Old
    '                            lclsStock_Old.Cost = ProductList.Cost
    '                            lclsStock_Old.Units = ProductList.Units_Old * -1
    '                            lclsStock_Old.SaveData(ptr, False, False, ID, Code)
    '                            lclsStock_Old.SaveData(ptr, True, False, ID, Code)

    '                            'Add new unit to new location
    '                            lclsStock.Units = ProductList.Units
    '                        Else
    '                            If ProductList.Units = ProductList.Units_Old Then
    '                                lclsStock.Units = 0
    '                            Else
    '                                lclsStock.Units = (ProductList.Units - ProductList.Units_Old)
    '                            End If
    '                        End If

    '                    End If

    '                    If ModeData = DataMode.ModeEdit Then
    '                        'Build prolist
    '                        If ProductList.ID > 0 Then
    '                            lProInList = IIf(lProInList = "", ProductList.ID, lProInList & "," & ProductList.ID)
    '                        End If
    '                    End If

    '                    lclsStock.SaveData(ptr, False, False, ID, Code)
    '                    lclsStock.SaveData(ptr, True, False, ID, Code)
    '                Next

    '                If lProInList <> "" Then
    '                    'Update for delete row
    '                    Dim lclsProlist As New ProductListDAO
    '                    Dim dataTable As New DataTable()
    '                    Dim lOrderList As New List(Of Long)
    '                    lOrderList.Add(ID)
    '                    dataTable = lclsProlist.GetDataTable(lOrderList, TableName, ptr, False, lProInList, False, False, False, False)

    '                    For Each dr As DataRow In dataTable.Rows
    '                        lclsStock = New ProductStockDAO
    '                        lclsStock.ProductID = ConvertNullToZero(dr("ProductID"))
    '                        lclsStock.UnitID = ConvertNullToZero(dr("UnitID"))
    '                        lclsStock.LocationDTLID = ConvertNullToZero(dr("LocationDTLID"))
    '                        lclsStock.Units = ConvertNullToZero(dr("Units")) * -1

    '                        lclsStock.SaveData(ptr, False, False, ID, Code)
    '                        lclsStock.SaveData(ptr, True, False, ID, Code)
    '                    Next
    '                End If
    '            End If

    '            ' ''Update Cost
    '            'Dim lclsCost As New ProductCostDAO
    '            'If ProductDAOs Is Nothing Then
    '            'ElseIf ProductDAOs.Count > 0 Then
    '            '    For Each ProductList As ProductListDAO In ProductDAOs
    '            '        lclsCost.ModeData = ModeData
    '            '        lclsCost.SaveData(ProductList.ProductID, ProductCostDAO.CostTypes.Average, ProductList.Cost, ProductList.ID, ptr)
    '            '    Next
    '            'End If

    '        ElseIf lIsUpdate = 5 Then ''Update stock
    '            For Each ProductList As ProductListDAO In ProductDAOs
    '                lclsStock = New ProductStockDAO
    '                lclsStock.ProductID = ProductList.ProductID
    '                lclsStock.UnitID = ProductList.UnitID
    '                lclsStock.LocationDTLID = ProductList.LocationDTLID
    '                lclsStock.Cost = ProductList.Cost

    '                If ModeData = DataMode.ModeDelete Then
    '                    lclsStock.Units = ProductList.Units * -1
    '                ElseIf ProductList.ID = 0 Then
    '                    lclsStock.Units = ProductList.Units * 1
    '                ElseIf ProductList.ID > 0 Then
    '                    'if change location in mode edit
    '                    If ProductList.LocationDTLID <> ProductList.LocationDTLID_Old Then
    '                        'Remove unit from old location stock
    '                        lclsStock_Old = New ProductStockDAO
    '                        lclsStock_Old.ProductID = ProductList.ProductID
    '                        lclsStock_Old.UnitID = ProductList.UnitID
    '                        lclsStock_Old.LocationDTLID = ProductList.LocationDTLID_Old
    '                        lclsStock_Old.Cost = ProductList.Cost
    '                        lclsStock_Old.Units = ProductList.Units_Old * -1
    '                        lclsStock_Old.SaveData(ptr, False, False, ID, Code)
    '                        If IsSumStock = True Then
    '                            lclsStock_Old.SaveData(ptr, True, False, ID, Code)
    '                        End If


    '                        'Add new unit to new location
    '                        lclsStock.Units = ProductList.Units
    '                    Else
    '                        If ProductList.Units = ProductList.Units_Old Then
    '                            lclsStock.Units = 0
    '                        Else
    '                            lclsStock.Units = (ProductList.Units - ProductList.Units_Old)
    '                        End If
    '                    End If
    '                End If
    '                If ModeData = DataMode.ModeEdit Then
    '                    'Build prolist
    '                    If ProductList.ID > 0 Then
    '                        lProInList = IIf(lProInList = "", ProductList.ID, lProInList & "," & ProductList.ID)
    '                    End If
    '                End If
    '                lclsStock.SaveData(ptr, False, False, ID, Code)
    '                If IsSumStock = True Then
    '                    lclsStock.SaveData(ptr, True, False, ID, Code)
    '                End If


    '            Next
    '            If lProInList <> "" Then
    '                'Update for delete row
    '                Dim lclsProlist As New ProductListDAO
    '                Dim dataTable As New DataTable()
    '                Dim lOrderList As New List(Of Long)
    '                lOrderList.Add(ID)
    '                dataTable = lclsProlist.GetDataTable(lOrderList, TableName, ptr, False, lProInList, False, False, False, False)

    '                For Each dr As DataRow In dataTable.Rows
    '                    lclsStock = New ProductStockDAO
    '                    lclsStock.ProductID = ConvertNullToZero(dr("ProductID"))
    '                    lclsStock.UnitID = ConvertNullToZero(dr("UnitID"))
    '                    lclsStock.LocationDTLID = ConvertNullToZero(dr("LocationDTLID"))
    '                    lclsStock.Units = ConvertNullToZero(dr("Units")) * -1

    '                    lclsStock.SaveData(ptr, False, False, ID, Code)
    '                    If IsSumStock = True Then
    '                        lclsStock.SaveData(ptr, True, False, ID, Code)
    '                    End If

    '                Next
    '            End If

    '        ElseIf lIsUpdate > 0 Then
    '            For Each ProductList As ProductListDAO In ProductDAOs
    '                lcls = New ProductStockDAO
    '                lcls.ProductID = ProductList.ProductID
    '                lcls.UnitID = ProductList.UnitID
    '                lcls.LocationDTLID = ProductList.LocationDTLID

    '                If ModeData = DataMode.ModeDelete Then
    '                    lcls.Units = ProductList.Units * 1
    '                ElseIf ProductList.ID = 0 Then
    '                    lcls.Units = ProductList.Units * -1
    '                ElseIf ProductList.ID > 0 Then
    '                    If ProductList.Units = ProductList.Units_Old Then
    '                        lcls.Units = 0
    '                    Else
    '                        lcls.Units = (ProductList.Units - ProductList.Units_Old) * -1
    '                    End If
    '                End If

    '                If ModeData = DataMode.ModeEdit Then
    '                    'Build prolist
    '                    If ProductList.ID > 0 Then
    '                        lProInList = IIf(lProInList = "", ProductList.ID, lProInList & "," & ProductList.ID)
    '                    End If
    '                End If


    '                If lIsUpdate = 1 Then  'sell stock sum
    '                    lcls.SaveData(ptr, True, False, ID, Code)
    '                ElseIf lIsUpdate = 2 Then
    '                    lcls.SaveData(ptr, False, False, ID, Code)
    '                ElseIf lIsUpdate = 3 Then
    '                    If StockType = "I" Then
    '                        lcls.Units = lcls.Units * -1 ' I = คืนสต็อก
    '                    End If
    '                    lcls.SaveData(ptr, False, False, ID, Code)
    '                    lcls.SaveData(ptr, True, False, ID, Code)
    '                End If
    '            Next

    '            If lProInList <> "" Then
    '                'Update for delete row
    '                Dim lclsProlist As New ProductListDAO
    '                Dim dataTable As New DataTable()
    '                Dim lOrderList As New List(Of Long)
    '                lOrderList.Add(ID)
    '                dataTable = lclsProlist.GetDataTable(lOrderList, TableName, ptr, False, lProInList, False, False, False, False)

    '                For Each dr As DataRow In dataTable.Rows
    '                    lcls = New ProductStockDAO
    '                    lcls.ProductID = ConvertNullToZero(dr("ProductID"))
    '                    lcls.UnitID = ConvertNullToZero(dr("UnitID"))
    '                    lcls.LocationDTLID = ConvertNullToZero(dr("LocationDTLID"))

    '                    lcls.Units = ConvertNullToZero(dr("Units")) * 1

    '                    If lIsUpdate = 1 Then  'sell stock sum
    '                        lcls.SaveData(ptr, True, False, ID, Code)
    '                    ElseIf lIsUpdate = 2 Then
    '                        lcls.SaveData(ptr, False, False, ID, Code)
    '                    ElseIf lIsUpdate = 3 Then
    '                        If StockType = "I" Then
    '                            lcls.Units = lcls.Units * -1 ' I = คืนสต็อก
    '                        End If
    '                        lcls.SaveData(ptr, False, False, ID, Code)
    '                        lcls.SaveData(ptr, True, False, ID, Code)
    '                    End If
    '                Next

    '            End If

    '        End If
    '        'End If
    '    Catch e As Exception
    '        Err.Raise(Err.Number, e.Source, "OrderSDAO.UpdateStock : " & e.Message)
    '    Finally
    '        lcls = Nothing
    '    End Try
    'End Sub


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

    'Private Sub UpdateSN(ByRef ptr As SqlTransaction)
    '    Dim lclsSN As SnDAO, lclsSNRef As SnDAO, lSNInList As String = "", lProIDList As String = ""
    '    Dim lSNTable As DataTable
    '    Dim lUpdateStstus As Boolean = False
    '    Try
    '        If ProductDAOs Is Nothing Then
    '        ElseIf ProductDAOs.Count = 0 Then
    '        Else
    '            If ModeData = DataMode.ModeDelete Then
    '                'Re Open status
    '                If TableID = MasterType.SellOrders Then
    '                    Dim lOrderList As New List(Of Long)
    '                    lOrderList.Add(ID)

    '                    lclsSN = New SnDAO
    '                    lSNTable = lclsSN.GetDataTable(lOrderList, 0, "", ptr)
    '                    For Each dr2 As DataRow In lSNTable.Rows
    '                        lclsSN = New SnDAO
    '                        lclsSN.SetStatusBySN(ptr, ConvertNullToZero(dr2("ProductID")), ConvertNullToString(dr2("SerialNumberNo")), "New")
    '                    Next
    '                End If
    '                lclsSN = New SnDAO
    '                lclsSN.DeleteFromModeDelete(ptr, ID, 0)
    '            Else
    '                For Each ProductList As ProductListDAO In ProductDAOs
    '                    lSNInList = ""

    '                    If ModeData = DataMode.ModeDelete Then
    '                        lclsSN = New SnDAO
    '                        lclsSN.DeleteFromModeDelete(ptr, ID, ProductList.ProductID)
    '                    Else

    '                        If IsNothing(ProductList.SNList) = False Then
    '                            For Each pclsSN As SnDAO In ProductList.SNList
    '                                lclsSN = pclsSN
    '                                If ModeData = DataMode.ModeNew Then
    '                                    lclsSN.SerialNumberID = 0
    '                                    If TableID = MasterType.StockIn Or TableID = MasterType.UpdateStock Then
    '                                        lclsSN.Status = "New"
    '                                    Else
    '                                        lclsSN.Status = "None"
    '                                    End If
    '                                End If
    '                                If TableID = MasterType.UpdateStock And ProductList.Units < 0 Then
    '                                    lclsSN.Status = "None"
    '                                    lUpdateStstus = True
    '                                End If
    '                                lclsSN.OrderID = ID
    '                                lclsSN.ProductID = ProductList.ProductID
    '                                lclsSN.SerialNumberNo = pclsSN.SerialNumberNo
    '                                lclsSN.SaveData(ptr, ModeData, lUpdateStstus)

    '                                'Close SN
    '                                If TableID = MasterType.SellOrders Then
    '                                    lclsSNRef = New SnDAO
    '                                    lclsSNRef.SetStatusBySN(ptr, ProductList.ProductID, pclsSN.SerialNumberNo, "Close")
    '                                End If

    '                                If ModeData = DataMode.ModeEdit Then
    '                                    If lclsSN.SerialNumberID > 0 Then
    '                                        lSNInList = IIf(lSNInList = "", lclsSN.SerialNumberID, lSNInList & "," & lclsSN.SerialNumberID)
    '                                    End If
    '                                End If
    '                            Next

    '                        End If
    '                        If lSNInList <> "" And ModeData = DataMode.ModeEdit Then

    '                            If TableID = MasterType.SellOrders Then
    '                                lclsSNRef = New SnDAO
    '                                lclsSNRef.SetStatusBySNAtRemove(ptr, ID, ProductList.ProductID, lSNInList, "New")
    '                            End If

    '                            lclsSN = New SnDAO
    '                            lclsSN.DeleteRemoveData(ptr, ID, ProductList.ProductID, lSNInList)
    '                        End If
    '                    End If

    '                    If ModeData = DataMode.ModeEdit Then
    '                        'Build prolist
    '                        If ProductList.ProductID > 0 Then
    '                            lProIDList = IIf(lProIDList = "", ProductList.ProductID, lProIDList & "," & ProductList.ProductID)
    '                        End If
    '                    End If

    '                Next
    '                If lProIDList <> "" Then 'Remove when Prolist delete
    '                    If TableID = MasterType.SellOrders Then
    '                        lclsSNRef = New SnDAO
    '                        lclsSNRef.SetStatusFromProListRemove(ptr, ID, lProIDList, "New")
    '                    End If

    '                    lclsSN = New SnDAO
    '                    lclsSN.DeleteFromProListRemove(ptr, ID, lProIDList)
    '                End If
    '            End If
    '        End If
    '    Catch e As Exception
    '        Err.Raise(Err.Number, e.Source, "OrderSDAO.UpdateSN : " & e.Message)
    '    Finally
    '        lclsSN = Nothing
    '    End Try
    'End Sub

End Class
