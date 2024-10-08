﻿Imports System.Data.SqlClient

Module modOrder

    Public Sub UpdateLaedStatus(ByVal LeadID As Long, ByVal pStatus As String, ByRef tr As SqlTransaction)
        Dim lcls As New CustomerDAO

        Try
            Dim lGenCode As String = ""
            lcls.TableID = MasterType.Lead
            lcls.InitailData(LeadID, , tr)
            lcls.ModeData = DataMode.ModeEdit
            lcls.LeadStatus = pStatus
            lcls.SaveData(tr)

        Catch e As Exception

            Err.Raise(Err.Number, e.Source, "modDAO.UpdateLastID : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    Public Function GetUnitNotRef(ByVal pRefOrderID As Long, RefFromTable As String, ByVal pRefToTable As String, ByVal RefToTableIDList As String _
                                       , ByRef ptr As SqlTransaction, ByVal pProlistID As Long, ByVal pProductID As Long, ByRef pNotRefUnit As Long) As RefOrderStatus
        Dim SQL As String
        Dim DataTable As DataTable
        Dim pRefFromUnit As Long = 0, pRefToUnit As Long = 0

        SQL = ""
        SQL = "SELECT Sum(p1.Units) as Units  "
        SQL &= " FROM ProductList p1"
        SQL &= " WHERE p1.IsDelete =0  and IsShow=1"
        SQL &= " AND p1.RefTable in (" & RefFromTable & " )"
        SQL &= " AND p1.RefID =" & pRefOrderID
        If pProlistID > 0 Then
            SQL &= " AND p1.ProductListID =" & pProlistID
        End If
        If pProductID > 0 Then
            SQL &= " AND p1.ProductID =" & pProductID
        End If
        DataTable = New DataTable
        DataTable = gConnection.executeSelectQuery(SQL, ptr)
        For Each pRow In DataTable.Rows
            pRefFromUnit = ConvertNullToZero(pRow("Units"))
            Exit For
        Next

        SQL = "SELECT Sum(p1.ProductListUnitRef1) as Units  "
        SQL &= " FROM ProductList p1"
        SQL &= " WHERE p1.IsDelete =0  and p1.IsShow=1 AND p1.RefTable in (" & pRefToTable & " )"
        SQL &= " AND  p1.ProductListRefID in ( "
        SQL &= "       select p2.ProductListID from ProductList p2 WHERE p2.IsDelete =0  and p2.IsShow=1"
        If pProlistID > 0 Then
            SQL &= "   AND p2.ProductListID =" & pProlistID
        End If
        If pProductID > 0 Then
            SQL &= "   AND p2.ProductID =" & pProductID
        End If
        SQL &= "       AND p2.RefID =" & pRefOrderID
        SQL &= "       AND p2.RefTable in (" & RefFromTable & ") )"

        SQL &= " AND p1.RefID IN( select OrderID from Orders where TableID in (" & RefToTableIDList & " )"
        SQL &= " and IsDelete=0  and  OrderStatus in('Open','Close','WaitApprove','Approve','Ordering','Ordered','Receive','Billed','Waiting'))"
        DataTable = New DataTable
        DataTable = gConnection.executeSelectQuery(SQL, ptr)
        For Each pRow In DataTable.Rows
            pRefToUnit = ConvertNullToZero(pRow("Units"))
            Exit For
        Next

        SQL = "SELECT Sum(p1.ProductListUnitRef2) as Units  "
        SQL &= " FROM ProductList p1"
        SQL &= " WHERE p1.IsDelete =0  and p1.IsShow=1 AND p1.RefTable in (" & pRefToTable & " )"
        SQL &= " AND  p1.ProductListRefID2 in ( "
        SQL &= "       select p2.ProductListID from ProductList p2 WHERE p2.IsDelete =0  and p2.IsShow=1"
        If pProlistID > 0 Then
            SQL &= "   AND p2.ProductListID =" & pProlistID
        End If
        If pProductID > 0 Then
            SQL &= "   AND p2.ProductID =" & pProductID
        End If
        SQL &= "       AND p2.RefID =" & pRefOrderID
        SQL &= "       AND p2.RefTable in (" & RefFromTable & ") )"

        SQL &= " AND p1.RefID IN( select OrderID from Orders where TableID in (" & RefToTableIDList & " )"
        SQL &= " and IsDelete=0  and  OrderStatus in('Open','Close','WaitApprove','Approve','Ordering','Ordered','Receive','Billed','Waiting'))"
        DataTable = New DataTable
        DataTable = gConnection.executeSelectQuery(SQL, ptr)
        For Each pRow In DataTable.Rows
            pRefToUnit = pRefToUnit + ConvertNullToZero(pRow("Units"))
            Exit For
        Next

        SQL = "SELECT Sum(p1.ProductListUnitRef3) as Units  "
        SQL &= " FROM ProductList p1"
        SQL &= " WHERE p1.IsDelete =0  and p1.IsShow=1 AND p1.RefTable in (" & pRefToTable & " )"
        SQL &= " AND  p1.ProductListRefID3 in ( "
        SQL &= "       select p2.ProductListID from ProductList p2 WHERE p2.IsDelete =0  and p2.IsShow=1"
        If pProlistID > 0 Then
            SQL &= "   AND p2.ProductListID =" & pProlistID
        End If
        If pProductID > 0 Then
            SQL &= "   AND p2.ProductID =" & pProductID
        End If
        SQL &= "       AND p2.RefID =" & pRefOrderID
        SQL &= "       AND p2.RefTable in (" & RefFromTable & ") )"

        SQL &= " AND p1.RefID IN( select OrderID from Orders where TableID in (" & RefToTableIDList & " )"
        SQL &= " and IsDelete=0  and  OrderStatus in('Open','Close','WaitApprove','Approve','Ordering','Ordered','Receive','Billed','Waiting'))"
        DataTable = New DataTable
        DataTable = gConnection.executeSelectQuery(SQL, ptr)
        For Each pRow In DataTable.Rows
            pRefToUnit = pRefToUnit + ConvertNullToZero(pRow("Units"))
            Exit For
        Next

        SQL = "SELECT Sum(p1.ProductListUnitRef4) as Units  "
        SQL &= " FROM ProductList p1"
        SQL &= " WHERE p1.IsDelete =0  and p1.IsShow=1 AND p1.RefTable in (" & pRefToTable & " )"
        SQL &= " AND  p1.ProductListRefID4 in ( "
        SQL &= "       select p2.ProductListID from ProductList p2 WHERE p2.IsDelete =0  and p2.IsShow=1"
        If pProlistID > 0 Then
            SQL &= "   AND p2.ProductListID =" & pProlistID
        End If
        If pProductID > 0 Then
            SQL &= "   AND p2.ProductID =" & pProductID
        End If
        SQL &= "       AND p2.RefID =" & pRefOrderID
        SQL &= "       AND p2.RefTable in (" & RefFromTable & ") )"

        SQL &= " AND p1.RefID IN( select OrderID from Orders where TableID in (" & RefToTableIDList & " )"
        SQL &= " and IsDelete=0  and  OrderStatus in('Open','Close','WaitApprove','Approve','Ordering','Ordered','Receive','Billed','Waiting'))"
        DataTable = New DataTable
        DataTable = gConnection.executeSelectQuery(SQL, ptr)
        For Each pRow In DataTable.Rows
            pRefToUnit = pRefToUnit + ConvertNullToZero(pRow("Units"))
            Exit For
        Next

        SQL = "SELECT Sum(p1.ProductListUnitRef5) as Units  "
        SQL &= " FROM ProductList p1"
        SQL &= " WHERE p1.IsDelete =0  and p1.IsShow=1 AND p1.RefTable in (" & pRefToTable & " )"
        SQL &= " AND  p1.ProductListRefID5 in ( "
        SQL &= "       select p2.ProductListID from ProductList p2 WHERE p2.IsDelete =0  and p2.IsShow=1"
        If pProlistID > 0 Then
            SQL &= "   AND p2.ProductListID =" & pProlistID
        End If
        If pProductID > 0 Then
            SQL &= "   AND p2.ProductID =" & pProductID
        End If
        SQL &= "       AND p2.RefID =" & pRefOrderID
        SQL &= "       AND p2.RefTable in (" & RefFromTable & ") )"

        SQL &= " AND p1.RefID IN( select OrderID from Orders where TableID in (" & RefToTableIDList & " )"
        SQL &= " and IsDelete=0  and  OrderStatus in('Open','Close','WaitApprove','Approve','Ordering','Ordered','Receive','Billed','Waiting'))"
        DataTable = New DataTable
        DataTable = gConnection.executeSelectQuery(SQL, ptr)
        For Each pRow In DataTable.Rows
            pRefToUnit = pRefToUnit + ConvertNullToZero(pRow("Units"))
            Exit For
        Next

        pNotRefUnit = pRefFromUnit - pRefToUnit

        If pRefToUnit = 0 Then                  'not to ref
            Return RefOrderStatus.NotToRef
        ElseIf pRefFromUnit > pRefToUnit Then   'ref some line,unit
            Return RefOrderStatus.RefSome
        Else                                    'ref all
            Return RefOrderStatus.RefAll
        End If

    End Function

    Public Function GetOrderFromPO(ByVal pPOCode As String) As Object
        Dim SQL As String
        Dim DataTable As DataTable
        Dim lOrderID As Long = 0
        Dim lOrderCode As String = ""
        Dim lGrandTotal As Decimal = 0
        Dim lOrderStatus As String = ""


        SQL = "SELECT OrderID,OrderCode,GrandTotal,OrderStatus  "
        SQL &= " FROM Orders"
        SQL &= " WHERE IsCancel=0 and  IsDelete=0 "
        SQL &= " AND PO='" & pPOCode.Trim & "' "
        SQL &= " AND TableID in (" & MasterType.Invoice & "," & MasterType.Shiping & "," & MasterType.InvoiceOnline & "," & MasterType.InvoiceAbb & ")"

        DataTable = New DataTable
        DataTable = gConnection.executeSelectQuery(SQL, Nothing)
        For Each pRow In DataTable.Rows
            lOrderID = ConvertNullToZero(pRow("OrderID"))
            lOrderCode = ConvertNullToString(pRow("OrderCode"))
            lGrandTotal = ConvertNullToZero(pRow("GrandTotal"))
            lOrderStatus = ConvertNullToString(pRow("OrderStatus"))
            Exit For
        Next

        Return {lOrderID, lOrderCode, lGrandTotal, lOrderStatus}
    End Function

    Public Function GetRefOrderStatus(ByVal pRefOrderID As Long, ByVal pOrderType As Long, ByVal pParentOrderID As Long, ByVal pProListID As Long, ByVal pProID As Long _
                                    , ByRef ptr As SqlTransaction, ByVal pMode As DataMode, ByRef pUnitNotRef As Long, ByVal pOrderUnit As Long) As String
        Dim SQL As String = "", lStatus As String = ""
        Dim tr As SqlTransaction = Nothing
        Dim lRefOrderType As MasterType
        Dim lRefStatus As RefOrderStatus = 0
        Try
            tr = ptr
            lRefOrderType = GetOrderTypeFromID(pRefOrderID, tr)

            If pOrderType = MasterType.StockIn Then 'Ref from PO
                lRefStatus = GetUnitNotRef(pRefOrderID, "'PurchaseOrder'", "'StockIn'", MasterType.StockIn, tr, pProListID, pProID, pUnitNotRef)
                If lRefStatus = RefOrderStatus.NotToRef Then
                    lStatus = EnumStatus.Open.ToString
                ElseIf lRefStatus = RefOrderStatus.RefSome Then
                    lStatus = EnumStatus.Waiting.ToString
                Else
                    lStatus = EnumStatus.Receive.ToString
                End If
            ElseIf pOrderType = MasterType.Invoice And lRefOrderType = MasterType.Borrow Then
                lRefStatus = GetUnitNotRef(pRefOrderID, "'Borrow'", "'Invoice'", MasterType.Invoice, tr, pProListID, pProID, pUnitNotRef)
                If lRefStatus = RefOrderStatus.NotToRef Then
                    lStatus = EnumStatus.Open.ToString
                ElseIf lRefStatus = RefOrderStatus.RefSome Then
                    lStatus = EnumStatus.Waiting.ToString
                Else
                    lStatus = EnumStatus.Close.ToString
                End If
            ElseIf pOrderType = MasterType.InvoiceOnline And lRefOrderType = MasterType.Borrow Then
                lRefStatus = GetUnitNotRef(pRefOrderID, "'Borrow'", "'InvoiceOnline'", MasterType.InvoiceOnline, tr, pProListID, pProID, pUnitNotRef)
                If lRefStatus = RefOrderStatus.NotToRef Then
                    lStatus = EnumStatus.Open.ToString
                ElseIf lRefStatus = RefOrderStatus.RefSome Then
                    lStatus = EnumStatus.Waiting.ToString
                Else
                    lStatus = EnumStatus.Close.ToString
                End If
            ElseIf pOrderType = MasterType.InvoiceAbb And lRefOrderType = MasterType.Borrow Then
                lRefStatus = GetUnitNotRef(pRefOrderID, "'Borrow'", "'InvoiceAbb'", MasterType.InvoiceAbb, tr, pProListID, pProID, pUnitNotRef)
                If lRefStatus = RefOrderStatus.NotToRef Then
                    lStatus = EnumStatus.Open.ToString
                ElseIf lRefStatus = RefOrderStatus.RefSome Then
                    lStatus = EnumStatus.Waiting.ToString
                Else
                    lStatus = EnumStatus.Close.ToString
                End If
            ElseIf pOrderType = MasterType.Borrow Or pOrderType = MasterType.Invoice Or pOrderType = MasterType.Shiping Or pOrderType = MasterType.InvoiceOnline Or pOrderType = MasterType.InvoiceAbb Then 'Ref from Sell
                lRefStatus = GetUnitNotRef(pRefOrderID, "'SellOrders'", "'Borrow','Invoice','Shiping','InvoiceOnline','InvoiceAbb'" _
                                                , MasterType.Borrow & "," & MasterType.Invoice & "," & MasterType.Shiping & "," & MasterType.InvoiceOnline & "," & MasterType.InvoiceAbb, tr, pProListID, pProID, pUnitNotRef)
                If lRefStatus = RefOrderStatus.NotToRef Then
                    lStatus = EnumStatus.Open.ToString
                ElseIf lRefStatus = RefOrderStatus.RefSome Then
                    lStatus = EnumStatus.Waiting.ToString
                Else
                    lStatus = EnumStatus.Close.ToString
                End If
            ElseIf pOrderType = MasterType.InvoiceBuy Or pOrderType = MasterType.ShipingBuy Then ' ref from PO
                If pMode = DataMode.ModeDelete Then
                    lRefStatus = GetUnitNotRef(pRefOrderID, "'PurchaseOrder'", "'StockIn'", MasterType.StockIn, tr, pProListID, pProID, pUnitNotRef)
                    If lRefStatus = RefOrderStatus.NotToRef Then
                        lStatus = EnumStatus.Open.ToString 'รอทำ stockin  
                    ElseIf lRefStatus = RefOrderStatus.RefSome Then
                        lStatus = EnumStatus.Waiting.ToString 'รอทำ stockin  
                    Else
                        lStatus = EnumStatus.Receive.ToString 'PO ที่ทำ stockin หมดแล้ว
                    End If
                Else
                    lRefStatus = GetUnitNotRef(pRefOrderID, "'PurchaseOrder'", "'InvoiceBuy','ShipingBuy'" _
                                                , MasterType.InvoiceBuy & "," & MasterType.ShipingBuy, tr, pProListID, pProID, pUnitNotRef)
                    If lRefStatus = RefOrderStatus.NotToRef Then
                        lStatus = EnumStatus.Open.ToString 'รอทำ 
                    ElseIf lRefStatus = RefOrderStatus.RefSome Then
                        lStatus = EnumStatus.Waiting.ToString
                    Else
                        lStatus = EnumStatus.Close.ToString 'PO ที่ทำ InvoiceBuy หมดแล้ว
                    End If
                End If
            ElseIf pOrderType = MasterType.Reserve Then 'Ref from QUOTAION
                lRefStatus = GetUnitNotRef(pRefOrderID, "'Quotation'", "'Reserve','SellOrders'" _
                                                , MasterType.Reserve & "," & MasterType.SellOrders, tr, pProListID, pProID, pUnitNotRef)
                If lRefStatus = RefOrderStatus.NotToRef Then
                    lStatus = EnumStatus.Open.ToString
                ElseIf lRefStatus = RefOrderStatus.RefSome Then
                    lStatus = EnumStatus.Waiting.ToString
                Else
                    lStatus = EnumStatus.Close.ToString 'Quotation ที่ทำ Reserve,SellOrders หมดแล้ว
                End If
            ElseIf pOrderType = MasterType.SellOrders Then
                If lRefOrderType = MasterType.Reserve Then '  ใบสั่งขายดึง Reserve มาทำ
                    lRefStatus = GetUnitNotRef(pRefOrderID, "'Reserve'", "'SellOrders'", MasterType.SellOrders, tr, pProListID, pProID, pUnitNotRef)
                    If lRefStatus = RefOrderStatus.NotToRef Then
                        lStatus = EnumStatus.Open.ToString
                    ElseIf lRefStatus = RefOrderStatus.RefSome Then
                        lStatus = EnumStatus.Waiting.ToString
                    Else
                        lStatus = EnumStatus.Close.ToString 'Reserve ที่ทำ  SellOrders หมดแล้ว
                    End If
                ElseIf lRefOrderType = MasterType.Quotation Then
                    lRefStatus = GetUnitNotRef(pRefOrderID, "'Quotation'", "'Reserve','SellOrders'" _
                                                 , MasterType.Reserve & "," & MasterType.SellOrders, tr, pProListID, pProID, pUnitNotRef)
                    If lRefStatus = RefOrderStatus.NotToRef Then
                        lStatus = EnumStatus.Open.ToString
                    ElseIf lRefStatus = RefOrderStatus.RefSome Then
                        lStatus = EnumStatus.Waiting.ToString
                    Else
                        lStatus = EnumStatus.Close.ToString 'Quotation ที่ทำ Reserve,SellOrders หมดแล้ว
                    End If
                End If
                'ElseIf pOrderType = MasterType.ReduceCreditBuy Or pOrderType = MasterType.AddCreditBuy Then
                '    lRefStatus = GetUnitNotRef(pRefOrderID, "'ShipingBuy','InvoiceBuy'", "'ReduceCreditBuy','AddCreditBuy'" _
                '                                    , MasterType.ReduceCreditBuy & "," & MasterType.AddCreditBuy, tr, pProListID, pProID, pUnitNotRef)
                '    If lRefStatus = RefOrderStatus.NotToRef Then
                '        lStatus = EnumStatus.Open.ToString
                '    ElseIf lRefStatus = RefOrderStatus.RefSome Then
                '        lStatus = EnumStatus.Waiting.ToString
                '    Else
                '        lStatus = EnumStatus.Close.ToString
                '    End If
            ElseIf pOrderType = MasterType.ClaimResult Then
                lRefStatus = GetUnitNotRef(pRefOrderID, "'ClaimOut'", "'ClaimResult'" _
                                                , MasterType.ClaimResult, tr, pProListID, pProID, pUnitNotRef)
                If lRefStatus = RefOrderStatus.NotToRef Then
                    lStatus = EnumStatus.Open.ToString
                ElseIf lRefStatus = RefOrderStatus.RefSome Then
                    lStatus = EnumStatus.Waiting.ToString
                Else
                    lStatus = EnumStatus.Close.ToString
                End If
            ElseIf pOrderType = MasterType.ClaimReturn Then
                lRefStatus = GetUnitNotRef(pRefOrderID, "'ClaimResult'", "'ClaimReturn'" _
                                                , MasterType.ClaimReturn, tr, pProListID, pProID, pUnitNotRef)
                If lRefStatus = RefOrderStatus.NotToRef Then
                    lStatus = EnumStatus.Open.ToString
                ElseIf lRefStatus = RefOrderStatus.RefSome Then
                    lStatus = EnumStatus.Waiting.ToString
                Else
                    lStatus = EnumStatus.Close.ToString
                End If
            ElseIf (pOrderType = MasterType.ReduceCredit Or pOrderType = MasterType.AddCredit) And lRefOrderType = MasterType.ClaimResult Then
                lRefStatus = GetUnitNotRef(pRefOrderID, "'ClaimResult'", "'ReduceCredit','AddCredit'", MasterType.AddCredit & "," & MasterType.ReduceCredit, tr, pProListID, pProID, pUnitNotRef)
                If lRefStatus = RefOrderStatus.NotToRef Then
                    lStatus = EnumStatus.Open.ToString
                ElseIf lRefStatus = RefOrderStatus.RefSome Then
                    lStatus = EnumStatus.Waiting.ToString
                Else
                    lStatus = EnumStatus.Close.ToString
                End If
            ElseIf (pOrderType = MasterType.ReduceCredit Or pOrderType = MasterType.AddCredit) And (lRefOrderType = MasterType.SellOrders Or lRefOrderType = MasterType.Invoice _
                     Or lRefOrderType = MasterType.InvoiceAbb Or lRefOrderType = MasterType.InvoiceOnline Or lRefOrderType = MasterType.Shiping) Then
                lRefStatus = GetUnitNotRef(pRefOrderID, "'SellOrders','Invoice','InvoiceAbb','InvoiceOnline','Shiping'", "'ReduceCredit','AddCredit'", MasterType.AddCredit & "," & MasterType.ReduceCredit, tr, pProListID, pProID, pUnitNotRef)
                If lRefStatus = RefOrderStatus.NotToRef Then
                    lStatus = EnumStatus.Open.ToString
                ElseIf lRefStatus = RefOrderStatus.RefSome Then
                    lStatus = EnumStatus.Waiting.ToString
                Else
                    lStatus = EnumStatus.Close.ToString
                End If
            Else ''อื่นๆ
                'lStatus = EnumStatus.Open.ToString
                pUnitNotRef = pOrderUnit  'Return all unit
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.GetRefOrderStatus : " & e.Message)
        Finally
        End Try
        Return lStatus
    End Function


    Public Sub UpdateRefOrderStatus(ByVal pRefToOrderID As List(Of Long), ByVal pOrderType As Long, ByVal pParentOrderID As Long, ByVal pStatus As String _
                                    , ByRef ptr As SqlTransaction, ByVal pMode As DataMode)
        Dim SQL As String = "", lStatus As String = ""
        Dim tr As SqlTransaction = Nothing
        Dim lRefStatus As RefOrderStatus = 0

        Try
            If ptr Is Nothing Then
                tr = gConnection.Connection.BeginTransaction
            Else
                tr = ptr
            End If

            For Each pRefOrderID As Long In pRefToOrderID
                lStatus = GetRefOrderStatus(pRefOrderID, pOrderType, pParentOrderID, 0, 0, tr, pMode, 0, 0)
                If lStatus = "" Then
                    lStatus = ConvertNullToString(pStatus)
                End If

                If lStatus <> "" Then
                    SQL = " UPDATE Orders SET "
                    SQL &= " OrderStatus='" & lStatus & "'"
                    SQL &= " where OrderID=" & ConvertNullToZero(pRefOrderID)
                    gConnection.executeInsertQuery(SQL, tr)

                    If pOrderType = MasterType.StockIn And lStatus = EnumStatus.Receive.ToString Then 'Ref from PO
                        Call NotifiReserveFromPO(pRefOrderID, tr)
                    End If

                End If
                If pMode = DataMode.ModeNew Then
                    SQL = " Insert into OrdersRef (OrderID,RefOrderID,IsDelete) values( " & pParentOrderID & "," & pRefOrderID & ",0)"
                    gConnection.executeInsertQuery(SQL, tr)
                ElseIf pMode = DataMode.ModeDelete Then
                    SQL = " delete from OrdersRef where OrderID=" & pParentOrderID & " and RefOrderID=" & pRefOrderID
                    gConnection.executeInsertQuery(SQL, tr)
                End If
            Next
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.UpdateRefOrderStatus : " & e.Message)
        Finally

        End Try
    End Sub

    Public Sub UpdateRefReserveStatus(ByVal pRefToReserveID As List(Of Long), ByVal pOrderType As Long, ByVal pParentOrderID As Long, ByRef ptr As SqlTransaction, ByVal pMode As DataMode)
        Dim SQL As String, lTableNameThai As String = "", lStatus As String = ""
        Dim tr As SqlTransaction = Nothing ', lOrderType As MasterType
        Dim lCount As Long = 0, lRefStatus As RefOrderStatus = 0, pUnitSameRef As Long = 0
        'Dim lclsOrder As OrderSDAO, lclsNotifi As New clsNotifi
        SQL = ""
        Try
            If ptr Is Nothing Then
                tr = gConnection.Connection.BeginTransaction
            Else
                tr = ptr
            End If
            For Each pOrderID As Long In pRefToReserveID


                lRefStatus = GetUnitNotRef(pOrderID, "'Reserve'", "'PurchaseOrder','CancelPO'" _
                                                   , MasterType.PurchaseOrder & "," & MasterType.CancelPO, tr, 0, 0, 0)

                If lRefStatus = RefOrderStatus.NotToRef Then
                    lStatus = EnumStatus.Waiting.ToString
                ElseIf lRefStatus = RefOrderStatus.RefSome Then
                    lStatus = EnumStatus.Ordering.ToString
                Else
                    lStatus = EnumStatus.Ordered.ToString
                End If

                If pOrderType = MasterType.PurchaseOrder Or pOrderType = MasterType.CancelPO Then
                    SQL = " UPDATE Orders SET "
                    SQL &= " MakePOStatus='" & lStatus & "'"
                    SQL &= " where OrderID=" & ConvertNullToZero(pOrderID)
                    gConnection.executeInsertQuery(SQL, tr)

                    'Add notifi
                    'lOrderType = GetOrderTypeFromID(pOrderID, tr)
                    'If lOrderType = MasterType.Reserve And lStatus = EnumStatus.Ordered.ToString Then
                    '    lclsOrder = New OrderSDAO
                    '    If lclsOrder.InitailData(pOrderID, , tr) Then
                    '        lclsNotifi = New clsNotifi
                    '        lclsNotifi.AddDataNotifi(2, "MakePO", "สร้างใบสั่งซื้อ", GetCurrentDate(tr), "Orders", lclsOrder.ID _
                    '            , "เอกสารเลขที่ " & lclsOrder.Code & " = Ordered ", tr, lclsOrder.EmployeeDAO(tr).EmpUserID)
                    '    End If
                    'End If
                End If

                If pMode = DataMode.ModeNew Then
                    SQL = " Insert into OrdersRef (OrderID,RefOrderID,RefReserveID,IsDelete) values( " & pParentOrderID & ",0," & pOrderID & ",0)"
                    gConnection.executeInsertQuery(SQL, tr)
                ElseIf pMode = DataMode.ModeDelete Then
                    SQL = " delete from OrdersRef where OrderID=" & pParentOrderID & " and RefReserveID=" & pOrderID
                    gConnection.executeInsertQuery(SQL, tr)
                End If
            Next
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.UpdateRefReserveStatus : " & e.Message)
        Finally
            'lcls = Nothing
        End Try
    End Sub

    Public Sub UpdateOrderByBill(ByVal RefBillID As Long, ByVal OrderID As Long, ByRef tr As SqlTransaction)
        Dim lcls As New OrderSDAO
        Try
            If lcls.InitailData(OrderID, "", tr) = True Then
                lcls.ModeData = DataMode.ModeEdit
                lcls.RefBillID = RefBillID
                If RefBillID > 0 Then
                    lcls.OrderStatus = EnumStatus.Billed.ToString
                Else
                    lcls.OrderStatus = EnumStatus.Open.ToString
                End If
                lcls.SaveData(tr)
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.UpdateOrderByBill : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    Public Sub UpdateOrderByReceipt(ByVal RefReceiptID As Long, ByVal OrderID As Long, ByVal PayAmount As Decimal, ByRef tr As SqlTransaction)
        Dim lcls As New OrderSDAO
        Try
            If lcls.InitailData(OrderID, "", tr) = True Then
                lcls.ModeData = DataMode.ModeEdit
                lcls.RefReceiptID = RefReceiptID
                lcls.PayTotal = PayAmount
                If RefReceiptID > 0 Then
                    lcls.OrderStatus = EnumStatus.Close.ToString
                ElseIf lcls.RefBillID > 0 Then
                    lcls.OrderStatus = EnumStatus.Billed.ToString
                Else
                    lcls.OrderStatus = EnumStatus.Open.ToString
                End If
                lcls.SaveData(tr)
            End If
        Catch e As Exception

            Err.Raise(Err.Number, e.Source, "modDAO.UpdateOrderByReceipt : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub


    Public Sub SaveOrderList(ByVal OrderList As List(Of SubOrder), ByVal ModeData As DataMode, ByVal BillID As Long, ByRef tr As SqlTransaction)
        'Dim lstrStayIDList As String = ""

        Try
            If OrderList Is Nothing Then
                'Delete All Ref Item
                If ModeData = DataMode.ModeDelete Then
                    Dim lSubOrder As New OrderSDetailDAO
                    lSubOrder.BillID = BillID
                    lSubOrder.DeleteAllData(tr)
                End If
            ElseIf OrderList.Count = 0 Then

            Else
                If ModeData <> DataMode.ModeEdit Then
                    For Each pSubOrder As OrderSDetailDAO In OrderList
                        pSubOrder.BillID = BillID
                        pSubOrder.ModeData = ModeData

                        If pSubOrder.SaveData(tr) Then

                        End If
                    Next
                End If
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SaveOrderList" & e.Message)
        End Try

    End Sub


    Public Sub SavePledge(ByVal pPledgeList As List(Of PledgeDAO), ByVal ModeData As DataMode, ByVal pRefOrderID As Long, ByRef tr As SqlTransaction)
        Try
            If pPledgeList Is Nothing Then
                'Delete All Ref Item
                If ModeData = DataMode.ModeDelete Then
                    Dim lSubOrder As New PledgeDAO
                    lSubOrder.RefOrderID = pRefOrderID
                    lSubOrder.DeleteAllData(tr)
                End If
            ElseIf pPledgeList.Count > 0 Then
                For Each pSubOrder As PledgeDAO In pPledgeList
                    pSubOrder.RefOrderID = pRefOrderID
                    pSubOrder.ModeData = ModeData
                    If pSubOrder.SaveData(tr) Then

                    End If
                Next
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SavePledge" & e.Message)
        End Try

    End Sub

    Public Sub SaveCheque(ByVal pChequeList As List(Of ChequeDAO), ByVal ModeData As DataMode, ByVal pRefOrderID As Long, ByRef tr As SqlTransaction)
        Try
            If pChequeList Is Nothing Then
                'Delete All Ref Item
                If ModeData = DataMode.ModeDelete Then
                    Dim lSubOrder As New ChequeDAO
                    lSubOrder.RefOrderID = pRefOrderID
                    lSubOrder.DeleteAllData(tr)
                End If
            ElseIf pChequeList.Count > 0 Then
                For Each pSubOrder As ChequeDAO In pChequeList
                    pSubOrder.RefOrderID = pRefOrderID
                    pSubOrder.ModeData = ModeData
                    If pSubOrder.SaveData(tr) Then

                    End If
                Next
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SaveCheque" & e.Message)
        End Try
    End Sub

    Public Sub SaveTaxOrder(ByVal pTaxOrderList As List(Of TaxOrderDAO), ByVal ModeData As DataMode, ByVal pRefOrderID As Long, ByRef tr As SqlTransaction)
        Try
            If pTaxOrderList Is Nothing Then
                'Delete All Ref Item
                If ModeData = DataMode.ModeDelete Then
                    Dim lSubOrder As New TaxOrderDAO
                    lSubOrder.RefOrderID = pRefOrderID
                    lSubOrder.DeleteAllData(tr)
                End If
            ElseIf pTaxOrderList.Count > 0 Then
                For Each pSubOrder As TaxOrderDAO In pTaxOrderList
                    pSubOrder.RefOrderID = pRefOrderID
                    If pSubOrder.SaveData(tr, ModeData) Then

                    End If
                Next
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SaveCheque" & e.Message)
        End Try
    End Sub

    Public Sub SetFlagProductList(ByVal ProductList As List(Of ProductListDAO), ByVal IsConfirm As Boolean, ByVal pID As Long, ByRef tr As SqlTransaction)
        Try
            If ProductList Is Nothing Then
            ElseIf ProductList.Count = 0 Then
            Else
                For Each ProductLocat As ProductListDAO In ProductList
                    ProductLocat.SaveToConfirm(pID, ProductLocat.ProductListRefID, IsConfirm, tr)
                Next
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SetFlagProductList" & e.Message)
        End Try
    End Sub


    Public Function GetToRefReserveCode(ByVal pParentOrderID As Long, ByRef tr As SqlTransaction, ByRef pRefToReserveID As List(Of Long)) As String
        Dim SQL As String = "", lstrCode As String = ""
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT  OrdersRef.OrderID,OrdersRef.RefReserveID, Orders.OrderCode  "
            SQL &= " FROM OrdersRef,Orders  "
            SQL &= " WHERE OrdersRef.RefReserveID=Orders.OrderID and Orders.IsDelete=0 and OrdersRef.IsDelete=0  and OrdersRef.OrderID=" & pParentOrderID
            SQL &= " ORDER BY Orders.OrderCode"
            dataTable = gConnection.executeSelectQuery(SQL, tr)
            If Not pRefToReserveID Is Nothing Then
                pRefToReserveID.Clear()
            End If

            lstrCode = ""
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    If lstrCode = "" Then
                        lstrCode = dr("OrderCode").ToString
                    Else
                        lstrCode = lstrCode & ", " & dr("OrderCode").ToString
                    End If
                    If Not pRefToReserveID Is Nothing Then
                        pRefToReserveID.Add(ConvertNullToZero(dr("RefReserveID")))
                    End If
                Next
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modOrder.GetToRefReserveCode : " & e.Message)
        End Try
        Return lstrCode
    End Function


    Public Sub NotifiReserveFromPO(ByVal pPOID As Long, ByRef ptr As SqlTransaction)
        Dim tr As SqlTransaction = Nothing
        Dim lclsOrder As OrderSDAO, lclsNotifi As New clsNotifi
        Dim lRefToReserveID As List(Of Long), lOrderType As Long
        Dim lPOCode As String = ""
        Try
            If ptr Is Nothing Then
                tr = gConnection.Connection.BeginTransaction
            Else
                tr = ptr
            End If

            lclsOrder = New OrderSDAO
            If lclsOrder.InitailData(pPOID, , tr) Then
                lPOCode = lclsOrder.Code
            End If

            lRefToReserveID = New List(Of Long)
            Call GetToRefReserveCode(pPOID, tr, lRefToReserveID)

            For Each pOrderID As Long In lRefToReserveID
                'Add notifi
                lOrderType = GetOrderTypeFromID(pOrderID, tr)
                If lOrderType = MasterType.Reserve Then
                    lclsOrder = New OrderSDAO
                    If lclsOrder.InitailData(pOrderID, , tr) Then
                        lclsNotifi = New clsNotifi
                        lclsNotifi.AddDataNotifi(2, "ใบจองสินค้า", "ใบจองสินค้า", GetCurrentDate(tr), "Orders", lclsOrder.ID _
                            , "ใบจองเลขที่ " & lclsOrder.Code & " นำสินค้าเข้าระบบแล้ว", tr, lclsOrder.EmployeeDAO(tr).EmpUserID)
                    End If
                End If
            Next
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modOrder.NotifiReserveFromPO : " & e.Message)
        Finally
            'lcls = Nothing
        End Try
    End Sub


    Public Function LoadSN(ByVal pOrderID As List(Of Long), ByVal pProListID As Long, ByVal pProID As Long) As List(Of SnDAO)
        Dim lclsSN As New SnDAO, dataSN As New DataTable()
        Dim lSNList As New List(Of SnDAO)
        LoadSN = Nothing
        Try
            dataSN = lclsSN.GetDataTable(pOrderID, pProListID, pProID, "", Nothing, True, "", False)
            For Each dr2 As DataRow In dataSN.Rows
                lclsSN = New SnDAO
                lclsSN.SerialNumberID = 0
                lclsSN.SerialNumberNo = ConvertNullToString(dr2("SerialNumberNo"))
                lclsSN.Status = ConvertNullToString(dr2("Status"))
                lclsSN.OrderID = ConvertNullToZero(dr2("OrderID"))
                lclsSN.ProductID = ConvertNullToZero(dr2("ProductID"))
                lclsSN.IsDelete = ConvertNullToZero(dr2("IsDelete"))
                lSNList.Add(lclsSN)
            Next
            Return lSNList
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modOrder..LoadSN : " & e.Message)
        Finally
        End Try
    End Function
End Module
