  
                If IsNothing(RefToOrderID) = False Then
                    Select Case TableID
                        Case MasterType.SellOrders, MasterType.Invoice, MasterType.Borrow, MasterType.Shiping, MasterType.InvoiceBuy, MasterType.Reserve, MasterType.ShipingBuy

                            If RefToOrderID.Count > 0 Then
                                For Each pOrderID As Long In RefToOrderID
                                    If ModeData = DataMode.ModeNew Then
                                        UpdateRefOrderStatus(TableID, ID, pOrderID, "Close", tr, True)
                                        SetFlagProductList(ProductDAOs, True, pOrderID, tr)
                                    Else 'Delete
                                        UpdateRefOrderStatus(TableID, ID, pOrderID, "Open", tr, False)
                                        SetFlagProductList(ProductDAOs, False, pOrderID, tr)
                                    End If
                                Next
                            End If
                       
                End If
            End If
    
    Public Sub UpdateRefOrderStatus(ByVal pOrderType As Long, ByVal pParentOrderID As Long, ByVal pRefOrderID As Long, ByVal pStatus As String, ByRef ptr As SqlTransaction, ByVal pIsClose As Boolean)
        Dim SQL As String, lTableNameThai As String = "", lStatus As String = ""
        Dim tr As SqlTransaction = Nothing
        Dim DataTable As DataTable
        Dim lRefOrderType As MasterType
        SQL = ""
        Try
            If ptr Is Nothing Then
                tr = gConnection.Connection.BeginTransaction
            Else
                tr = ptr
            End If

            Dim lclsRefOrder As New OrderSDAO
            lRefOrderType = lclsRefOrder.GetOrderTypeFromID(pRefOrderID, tr)

            If pOrderType = MasterType.StockIn Then 'Ref from PO
                If pIsClose = False Then
                    lStatus = "Waiting"
                Else
                    SQL = "SELECT p1.*  "
                    SQL = SQL & " FROM ProductList p1"
                    SQL = SQL & " WHERE p1.IsDelete =0  "
                    SQL = SQL & " AND p1.RefTable in ('PurchaseOrder' )"
                    SQL = SQL & " AND p1.RefID =" & pRefOrderID
                    SQL = SQL & " AND p1.ProductListID not in ( "
                    SQL = SQL & "   select p2.ProductListRefID from ProductList p2 "
                    SQL = SQL & "   WHERE p2.IsDelete =0  and p2.ProductListRefID>0"
                    SQL = SQL & "   AND p2.RefTable ='StockIn' )"
                    DataTable = gConnection.executeSelectQuery(SQL, tr)
                    If IsNothing(DataTable) OrElse DataTable.Rows.Count = 0 Then
                        lStatus = "Receive"
                    Else
                        lStatus = "Waiting"
                    End If
                End If

                SQL = " UPDATE Orders SET "
                SQL = SQL & " OrderStatus='" & lStatus & "'"
                SQL = SQL & " where OrderID=" & ConvertNullToZero(pRefOrderID)
                gConnection.executeInsertQuery(SQL, tr)
            ElseIf pOrderType = MasterType.InvoiceBuy Or pOrderType = MasterType.ShipingBuy Then ' 
                If pIsClose = False Then
                    SQL = "SELECT p1.*  "
                    SQL = SQL & " FROM ProductList p1"
                    SQL = SQL & " WHERE p1.IsDelete =0  "
                    SQL = SQL & " AND p1.RefTable ='PurchaseOrder'"
                    SQL = SQL & " AND p1.RefID =" & pRefOrderID
                    SQL = SQL & " AND p1.ProductListID not in ( "
                    SQL = SQL & "   select p2.ProductListRefID from ProductList p2 "
                    SQL = SQL & "   WHERE p2.IsDelete =0  and p2.ProductListRefID>0"
                    SQL = SQL & "   AND p2.RefTable ='StockIn' )"
                    DataTable = gConnection.executeSelectQuery(SQL, tr)
                    If IsNothing(DataTable) OrElse DataTable.Rows.Count = 0 Then
                        lStatus = "Receive" 'PO ที่ทำ stockin หมดแล้ว
                    Else
                        lStatus = "Waiting" 'รอทำ stockin  
                    End If
                Else
                    SQL = "SELECT p1.*  "
                    SQL = SQL & " FROM ProductList p1"
                    SQL = SQL & " WHERE p1.IsDelete =0  "
                    SQL = SQL & " AND p1.RefTable ='PurchaseOrder'"
                    SQL = SQL & " AND p1.RefID =" & pRefOrderID
                    SQL = SQL & " AND p1.ProductListID not in ( "
                    SQL = SQL & "   select p2.ProductListRefID from ProductList p2 "
                    SQL = SQL & "   WHERE p2.IsDelete =0  and p2.ProductListRefID>0"
                    SQL = SQL & "   AND p2.RefTable in ('InvoiceBuy','ShipingBuy') )"
                    DataTable = gConnection.executeSelectQuery(SQL, tr)
                    If IsNothing(DataTable) OrElse DataTable.Rows.Count = 0 Then
                        lStatus = "Close" 'PO ที่ทำ InvoiceBuy หมดแล้ว
                    Else
                        'lStatus = "Waiting"
                    End If
                End If
                If lStatus <> "" Then
                    SQL = " UPDATE Orders SET "
                    SQL = SQL & " OrderStatus='" & lStatus & "'"
                    SQL = SQL & " where OrderID=" & ConvertNullToZero(pRefOrderID)
                    gConnection.executeInsertQuery(SQL, tr)
                End If
            
         
            Else ''อื่นๆ
                If ConvertNullToString(pStatus) <> "" Then
                    SQL = " UPDATE Orders SET "
                    SQL = SQL & " OrderStatus='" & ConvertNullToString(pStatus) & "'"
                    SQL = SQL & " where OrderID=" & ConvertNullToZero(pRefOrderID)
                    gConnection.executeInsertQuery(SQL, tr)
                End If
            End If

                If pIsClose = True Then
                    SQL = " Insert into OrdersRef (OrderID,RefOrderID,IsDelete) values( " & pParentOrderID & "," & pRefOrderID & ",0)"
                    gConnection.executeInsertQuery(SQL, tr)
                Else
                    SQL = " delete from OrdersRef where OrderID=" & pParentOrderID & " and RefOrderID=" & pRefOrderID
                    gConnection.executeInsertQuery(SQL, tr)
                End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.UpdateRefOrderStatus : " & e.Message)
        Finally
            'lcls = Nothing
        End Try
    End Sub