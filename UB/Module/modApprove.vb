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
            If Not IsMeetOtherTX(pOrderTable, pOrderID, pApproveType, tr) Then
                lclsOrder.InitailData(pOrderID, , tr)
                If lclsOrder.TableID = MasterType.PurchaseOrder Then
                    lclsOrder.OrderStatus = EnumStatus.Waiting.ToString
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
            SQL &=  " FROM ApproveTX  "
            SQL &=  " WHERE ApproveStatus='WaitApprove'  "
            SQL &=  " AND OrderTable='" & pOrderTable.Trim & "'"
            SQL &=  " AND OrderID=" & pOrderID
            SQL &=  " AND ApproveType <> " & pApproveType
            dataTable = gConnection.executeSelectQuery(SQL, tr)
            Return dataTable.Rows.Count > 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modApprove.IsMeetOtherTX : " & e.Message)
        End Try
    End Function

    Public Function VerifyCompany() As Boolean
        VerifyCompany = False
        Try
            Dim lcls As New CompanyDAO
            If lcls.InitailData(gCompanyID) Then
                gIsCheckLimitReserve = lcls.CheckLimitReserve
                gIsCheckLimitSellOrder = lcls.CheckLimitSellOrder
                gIsCheckLimitInvoice = lcls.CheckLimitInvoice
                gIsCheckLimitShiping = lcls.CheckLimitShiping
                gIsApproveQua = lcls.IsApproveQua
                gIsApproveReserve = lcls.IsApproveReserve
                gIsApproveSellOrder = lcls.IsApproveSellOrder
                gIsApproveOffer = lcls.IsApproveOffer
                gIsApproveBuyOrder = lcls.IsApproveBuyOrder
                gIsApproveInvoice = lcls.IsApproveInvoice
                gIsApproveShiping = lcls.IsApproveShiping
                gIsApproveBorrow = lcls.IsApproveBorrow
                gUnderLimit = lcls.UnderLimit
                gCompanyName = lcls.CompanyName
                Return True
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modApprove.VerifyCompany : " & e.Message)
        End Try
    End Function


    Public Function VerifyApproveUser() As Boolean
        Dim dataTable As New DataTable()
        Try
            Dim lcls As New ApproveUserDTLDAO()
            dataTable = lcls.GetDataTable(1, gEmpID, True)
            gIsApproveOrderUser = dataTable.Rows.Count > 0

            dataTable = lcls.GetDataTable(2, gEmpID, True)
            If dataTable.Rows.Count > 0 Then
                gIsApproveLimitUser = True
                gLimitAmount = ConvertNullToZero(dataTable.Rows(0).Item("ApproveAmount"))
            Else
                gIsApproveLimitUser = False
                gLimitAmount = 0
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modApprove.VerifyApproveUser : " & e.Message)
        End Try
        Return True
    End Function

    Public Function GetCustomerCredit(ByVal pCusID As Long, ByRef ptr As SqlTransaction, ByRef pIsHoldBudget As Boolean) As Decimal
        Dim lclsCustomer As CustomerDAO
        Try

            lclsCustomer = New CustomerDAO
            lclsCustomer.InitailData(pCusID, "", ptr)
            pIsHoldBudget = (lclsCustomer.IsHoldButget = 1)
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
