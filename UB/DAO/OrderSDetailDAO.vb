
Option Explicit On
Imports System.Data.SqlClient

Public Class OrderSDetailDAO

#Region "Property"
    Private mIsSelect As Boolean
    Private mMode As DataMode
    Private mIDs As Long
    Private mBillID As Long
    Private mTableID As Long
    Private mOrderID As Long
    Private mOrderCode As String
    Private mOrderDate As Date
    Private mCusName As String
    Private mEmpName As String
    Private mGrandTotal As Double
    Private mBillTotal As Double
    Private mRemark As String
    Private mBillType As String

    Dim mInvoiceSuplierID As String = ""
    Dim mCustomerID As Long = 0


    Public Property IsSelect() As Boolean
        Get
            Return mIsSelect
        End Get
        Set(ByVal Value As Boolean)
            mIsSelect = Value
        End Set
    End Property

    Public Property ModeData() As Integer
        Get
            Return mMode
        End Get
        Set(ByVal Value As Integer)
            mMode = Value
        End Set
    End Property
    Public Property ID() As Long
        Get
            Return mIDs
        End Get
        Set(ByVal value As Long)
            mIDs = value
        End Set
    End Property

    Public Property BillID() As Long
        Get
            Return mBillID
        End Get
        Set(ByVal value As Long)
            mBillID = value
        End Set
    End Property
    Public Property OrderID() As Long
        Get
            Return mOrderID
        End Get
        Set(ByVal value As Long)
            mOrderID = value
        End Set
    End Property
    Public Property CustomerID() As Long
        Get
            Return mCustomerID
        End Get
        Set(ByVal value As Long)
            mCustomerID = value
        End Set
    End Property
    Public Property TableID() As Long
        Get
            Return mTableID
        End Get
        Set(ByVal value As Long)
            mTableID = value
        End Set
    End Property
    Public Property InvoiceSuplierID() As String
        Get
            Return mInvoiceSuplierID
        End Get
        Set(ByVal value As String)
            mInvoiceSuplierID = value
        End Set
    End Property
    Public Property OrderCode() As String
        Get
            Return mOrderCode
        End Get
        Set(ByVal value As String)
            mOrderCode = value
        End Set
    End Property
    Public Property OrderDate() As Date
        Get
            Return mOrderDate
        End Get
        Set(ByVal value As Date)
            mOrderDate = value
        End Set
    End Property
    Public Property CusName() As String
        Get
            Return mCusName
        End Get
        Set(ByVal value As String)
            mCusName = value
        End Set
    End Property
    Public Property EmpName() As String
        Get
            Return mEmpName
        End Get
        Set(ByVal value As String)
            mEmpName = value
        End Set
    End Property
    Public Property GrandTotal() As Double
        Get
            Return mGrandTotal
        End Get
        Set(ByVal value As Double)
            mGrandTotal = value
        End Set

    End Property

    Public Property BillTotal() As Double
        Get
            Return mBillTotal
        End Get
        Set(ByVal value As Double)
            mBillTotal = value
        End Set
    End Property

    Public Property Remark() As String
        Get
            Return mRemark
        End Get
        Set(ByVal value As String)
            mRemark = value
        End Set
    End Property

    Public Property BillType() As String
        Get
            Return mBillType
        End Get
        Set(ByVal value As String)
            mBillType = value
        End Set
    End Property
#End Region


    Public Function GetDataTable(ByVal pBillID As Long, ByRef ptr As SqlTransaction) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()
        Try
            SQL = "SELECT  OrdersDetail.OrdersDetailID AS ID,0 as SEQ,OrdersDetail.BillID,OrdersDetail.TableID,OrdersDetail.OrderID "
            SQL = SQL & " ,OrdersDetail.OrderCode,OrdersDetail.OrderDate,OrdersDetail.CusName,OrdersDetail.EmpName,OrdersDetail.GrandTotal "
            SQL = SQL & " ,OrdersDetail.BillTotal,OrdersDetail.Remark,OrdersDetail.BillType" ',Orders.ExpireDate"
            SQL = SQL & " FROM OrdersDetail"
            'SQL = SQL & " Left outer join Orders on Orders.OrderID=OrdersDetail.OrderID"
            SQL = SQL & " WHERE OrdersDetail.BillID =" & pBillID
            SQL = SQL & " AND OrdersDetail.IsDelete =0   "
            SQL = SQL & " ORDER BY OrdersDetail.OrdersDetailID"
            dataTable = gConnection.executeSelectQuery(SQL, ptr)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "OrdersDetailDAO.GetDataTable : " & e.Message)
        End Try
        Return dataTable
    End Function

    Public Function SaveData(ByVal tr As SqlTransaction) As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand

        SQL = ""
        Try
            If mMode = DataMode.ModeNew Then
            ElseIf mMode = DataMode.ModeDelete Then
            ElseIf ID <= 0 And OrderID <> 0 Then
                mMode = DataMode.ModeNew
            ElseIf ID > 0 And OrderID <> 0 Then
                mMode = DataMode.ModeEdit
            Else  'not chang
                mMode = DataMode.ModeNone
            End If

            Select Case mMode
                Case DataMode.ModeNew
                    mIDs = GenNewID("OrdersDetailID", "OrdersDetail", tr)
                    SQL = " INSERT INTO OrdersDetail (OrdersDetailID,BillID,TableID,OrderID,OrderCode,OrderDate,CusName,EmpName,GrandTotal,BillTotal,Remark,BillType,IsDelete )"
                    SQL = SQL & " VALUES ( "
                    SQL = SQL & "   @ID"
                    SQL = SQL & " ,  @BillID"
                    SQL = SQL & " ,  @TableID"
                    SQL = SQL & " ,  @OrderID"
                    SQL = SQL & " ,  @OrderCode"
                    SQL = SQL & " ,  @OrderDate"
                    SQL = SQL & " ,  @CusName"
                    SQL = SQL & " ,  @EmpName"
                    SQL = SQL & " ,  @GrandTotal"
                    SQL = SQL & " ,  @BillTotal"
                    SQL = SQL & " ,  @Remark"
                    SQL = SQL & " ,  @BillType"
                    SQL = SQL & " ,  @IsDelete"
                    SQL = SQL & " ) "
                Case DataMode.ModeEdit
                    'SQL = " Update OrdersDetail   "
                    'SQL = SQL & " SET"
                    'SQL = SQL & " CusName=@CusName"
                    'SQL = SQL & " ,EmpName=@EmpName"
                    'SQL = SQL & " ,GrandTotal=@GrandTotal"
                    'SQL = SQL & " ,BillTotal=@BillTotal"
                    'SQL = SQL & " ,Remark=@Remark"
                    'SQL = SQL & " ,ProductID= @ProductID"
                    'SQL = SQL & " ,Remark=@Remark"
                    'SQL = SQL & " ,BillType=@BillType"
                    'SQL = SQL & " ,IsDelete=@IsDelete"
                    'SQL = SQL & " WHERE OrdersDetailID= @ID"
                Case DataMode.ModeDelete
                    SQL = " UPDATE OrdersDetail SET IsDelete=@IsDelete "
                    SQL = SQL & " WHERE OrdersDetailID= @ID"
                Case Else
                    Return False
                    Exit Function
            End Select
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@ID", mIDs))
            myCommand.Parameters.Add(New SqlParameter("@BillID", BillID))
            myCommand.Parameters.Add(New SqlParameter("@TableID", TableID))
            myCommand.Parameters.Add(New SqlParameter("@OrderID", OrderID))
            myCommand.Parameters.Add(New SqlParameter("@OrderCode", OrderCode))
            myCommand.Parameters.Add(New SqlParameter("@OrderDate", OrderDate))
            myCommand.Parameters.Add(New SqlParameter("@CusName", CusName))
            myCommand.Parameters.Add(New SqlParameter("@EmpName", EmpName))
            myCommand.Parameters.Add(New SqlParameter("@GrandTotal", GrandTotal))
            myCommand.Parameters.Add(New SqlParameter("@BillTotal", BillTotal))
            myCommand.Parameters.Add(New SqlParameter("@Remark", Remark.Trim))
            myCommand.Parameters.Add(New SqlParameter("@BillType", BillType))
            Select Case ModeData
                Case DataMode.ModeNew
                    myCommand.Parameters.Add(New SqlParameter("@IsDelete", 0))
                Case DataMode.ModeDelete
                    myCommand.Parameters.Add(New SqlParameter("@IsDelete", 1))
            End Select
            gConnection.executeInsertSqlCommand(myCommand, tr)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "OrdersDetailDAO.SaveData : " & e.Message)
            Return False
        End Try
    End Function

    'delete all ref
    Public Function DeleteAllData(ByVal tr As SqlTransaction) As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand

        SQL = ""
        Try
            SQL = " UPDATE OrdersDetail SET IsDelete=@IsDelete "
            SQL = SQL & " WHERE BillID=@BillID "
            myCommand = New SqlCommand
            myCommand.CommandText = SQL

            myCommand.Parameters.Add(New SqlParameter("@BillID", BillID))
            myCommand.Parameters.Add(New SqlParameter("@IsDelete", 1))
            gConnection.executeInsertSqlCommand(myCommand, tr)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "OrdersDetailDAO.DeleteAllData : " & e.Message)
            Return False
        End Try
    End Function

    Public Sub New()
        mMode = DataMode.ModeNone
        mIDs = 0
        BillID = 0
        OrderID = 0
        OrderCode = ""
        CusName = ""
        EmpName = ""
        GrandTotal = 0
        BillTotal = 0
        mTableID = 0
        mRemark = ""
        OrderDate = Nothing
        BillType = ""
        mIsSelect = False
    End Sub
End Class
