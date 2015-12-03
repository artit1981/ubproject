Imports System.Data.SqlClient

Module modApprove

    'pApproveType 1 = Order
    '             2 = Amount 
    'ApproveStatus    0 = Wait
    '             1 = Approve 
    Public Sub SaveApproveTX(ByVal pApproveType As Long, ByVal pModeData As DataMode, ByVal pOrderID As Long, ByVal pOrderType As String, ByVal pOrderTable As String, ByVal pOrderCode As String _
                             , ByVal pOrderDate As Date, ByVal pOrderAmount As Decimal, ByVal pRemark As String, ByVal pApproveStatus As String, ByRef tr As SqlTransaction)
        Try
            Dim lcls As New ApproveTX
            lcls.ModeData = pModeData
            lcls.OrderID = pOrderID
            lcls.OrderType = pOrderType
            lcls.OrderTable = pOrderTable
            lcls.OrderCode = pOrderCode
            lcls.OrderDate = pOrderDate
            lcls.OrderAmount = pOrderAmount
            lcls.Remark = pRemark
            lcls.ApproveType = pApproveType
            lcls.ApproveStatus = pApproveStatus
            lcls.SaveData(tr)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modApprove.SaveApproveTX : " & e.Message)
        End Try

    End Sub

    Public Sub SetOrderApproveTX(ByVal pOrderTable As String, ByVal pOrderID As Long, ByVal pOrderType As String, ByVal pApproveType As Long _
                           , ByVal pStatus As String, ByRef tr As SqlTransaction)
        Dim lclsOrder As iOrder = Nothing


        Try
            lclsOrder = New OrderSDAO
            'Select Case pOrderTable
            '    Case "Quotation"
            '        lclsOrder.TableID = MasterType.Quotation
            '    Case "Orders"
            '        lclsOrder.TableID = MasterType.SellOrders
            'End Select

            If Not IsMeetOtherTX(pOrderTable, pOrderID, pApproveType, tr) Then
                lclsOrder.InitailData(pOrderID, , tr)
                If lclsOrder.TableID = MasterType.PurchaseOrder Then
                    lclsOrder.OrderStatus = "Waiting"
                Else
                    lclsOrder.OrderStatus = pStatus
                End If

                lclsOrder.ModeData = DataMode.ModeEdit
                lclsOrder.SaveData(tr)
            End If



        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modApprove.SaveApproveTX : " & e.Message)
        End Try

    End Sub

    Public Function IsMeetOtherTX(ByVal pOrderTable As String, ByVal pOrderID As Long, ByVal pApproveType As Long, ByRef tr As SqlTransaction) As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()
        Try
            SQL = "SELECT * "
            SQL = SQL & " FROM ApproveTX  "
            SQL = SQL & " WHERE ApproveStatus='Wait Approve'  "
            SQL = SQL & " AND OrderTable='" & pOrderTable.Trim & "'"
            SQL = SQL & " AND OrderID=" & pOrderID
            SQL = SQL & " AND ApproveType <> " & pApproveType
            dataTable = gConnection.executeSelectQuery(SQL, tr)
            Return dataTable.Rows.Count > 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modApprove.IsMeetOtherTX : " & e.Message)
        End Try
    End Function

    Public Function CheckOverCreditAmount(ByVal pCusID As Long, ByVal pTXAmount As Decimal, ByRef ptr As SqlTransaction) As Decimal
        Dim lclsCreditAmount As Decimal
        Try
            lclsCreditAmount = GetCustomerCredit(pCusID, ptr)

            Return lclsCreditAmount < pTXAmount

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modApprove.CheckOverCreditAmount : " & e.Message)
        End Try
    End Function

    Public Function GetCustomerCredit(ByVal pCusID As Long, ByRef ptr As SqlTransaction) As Decimal
        Dim lclsCustomer As iPerson
        Try

            lclsCustomer = New CustomerDAO
            lclsCustomer.InitailData(pCusID, "", ptr)

            If lclsCustomer.CreditGroupID > 0 Then
                Dim lclsCreditGroup As New CreditGroupDAO
                If lclsCreditGroup.InitailData(lclsCustomer.CreditGroupID, ptr) Then
                    Return lclsCreditGroup.CreditAmount
                Else
                    Return 0
                End If
            Else
                Return lclsCustomer.CreditAmount
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modApprove.GetCustomerCredit : " & e.Message)
        End Try
    End Function


End Module
