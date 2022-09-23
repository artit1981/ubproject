Imports System.Data.SqlClient

Public Class CreditBalanceDAO

    Dim mCreditAmount As Decimal

    Public Property CreditAmount() As Decimal
        Get
            Return mCreditAmount
        End Get
        Set(ByVal value As Decimal)
            mCreditAmount = value
        End Set

    End Property
    Public Function InitailCreditBalance(ByVal pCusID As Long) As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()
        Try
            SQL = "SELECT Sum(OrderAmount) AS OrderAmount   "
            SQL &=  " FROM  CreditBalance"
            SQL &=  " WHERE CustomerID=" & pCusID
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    CreditAmount = ConvertNullToZero(dr("OrderAmount"))
                    Exit For
                Next
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "CreditBalanceDAO.InitailData : " & e.Message)
            Return False
        Finally
            dataTable = Nothing
        End Try
    End Function

    Public Function AddBalanc(ByVal ptr As SqlTransaction, ByVal pCustomerID As Long, ByVal pOrderID As Long, ByVal pOrderDate As Date, ByVal pOrderAmount As Decimal, ByVal pRemark As String) As Boolean
        Dim SQL As String = ""
        Dim myCommand As SqlCommand
        Dim tr As SqlTransaction = Nothing
        Try
            If ptr Is Nothing Then
                tr = gConnection.Connection.BeginTransaction
            Else
                tr = ptr
            End If

            SQL = " INSERT INTO CreditBalance (CustomerID,OrderID,OrderDate,OrderAmount,Remark,CreateBy,CreateTime )"
            SQL &=  " VALUES ( @CustomerID"
            SQL &=  " ,  @OrderID"
            SQL &=  " ,  @OrderDate"
            SQL &=  " ,  @OrderAmount"
            SQL &=  " ,  @Remark"
            SQL &=  " ,  @gUserID"
            SQL &=  " ,  @CreateTime"
            SQL &=  " ) "

            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@CustomerID", pCustomerID))
            myCommand.Parameters.Add(New SqlParameter("@OrderID", pOrderID))
            myCommand.Parameters.Add(New SqlParameter("@OrderDate", formatSQLDate(pOrderDate)))
            myCommand.Parameters.Add(New SqlParameter("@OrderAmount", ConvertNullToZero(pOrderAmount)))
            myCommand.Parameters.Add(New SqlParameter("@Remark", ConvertNullToString(pRemark)))
            myCommand.Parameters.Add(New SqlParameter("@gUserID", gUserID))
            myCommand.Parameters.Add(New SqlParameter("@CreateTime", formatSQLDateTime(GetCurrentDate(tr))))
            gConnection.executeInsertSqlCommand(myCommand, tr)

            If ptr Is Nothing Then tr.Commit()
            Return True
        Catch e As Exception
            If ptr Is Nothing Then tr.Rollback()
            Err.Raise(Err.Number, e.Source, "CreditBalanceDAO.AddBalanc : " & e.Message)
            Return False
        End Try


    End Function

    Public Sub New()
        mCreditAmount = 0
    End Sub
End Class
