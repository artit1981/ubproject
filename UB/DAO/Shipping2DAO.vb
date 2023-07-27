
Option Explicit On
Imports System.Data.SqlClient

Public Class Shipping2DAO

#Region "Property"

    Private mMode As DataMode = DataMode.ModeNew
    Public Property ModeData() As Integer
        Get
            Return mMode
        End Get
        Set(ByVal Value As Integer)
            mMode = Value
        End Set
    End Property


    Dim mIsSelect As Boolean = False
    Public Property IsSelect() As Boolean
        Get
            Return mIsSelect
        End Get
        Set(ByVal value As Boolean)
            mIsSelect = value
        End Set
    End Property


    Private mIDs As Long = 0
    Public Property OrderID() As Long
        Get
            Return mIDs
        End Get
        Set(ByVal value As Long)
            mIDs = value
        End Set
    End Property

    Private mOrderCode As String = ""
    Public Property OrderCode() As String
        Get
            Return mOrderCode
        End Get
        Set(ByVal value As String)
            mOrderCode = value
        End Set
    End Property
    Private mOrderDate As Date
    Public Property OrderDate() As Date
        Get
            Return mOrderDate
        End Get
        Set(ByVal value As Date)
            mOrderDate = value
        End Set
    End Property

    Private mCusName As String = ""
    Public Property CusName() As String
        Get
            Return mCusName
        End Get
        Set(ByVal value As String)
            mCusName = value
        End Set
    End Property

    Private mGrandTotal As Double = 0
    Public Property GrandTotal() As Double
        Get
            Return mGrandTotal
        End Get
        Set(ByVal value As Double)
            mGrandTotal = value
        End Set

    End Property


    Private mReceiptCode As String = ""
    Public Property ReceiptCode() As String
        Get
            Return mReceiptCode
        End Get
        Set(ByVal value As String)
            mReceiptCode = value
        End Set
    End Property


    Private mBillCode As String = ""
    Public Property BillCode() As String
        Get
            Return mBillCode
        End Get
        Set(ByVal value As String)
            mBillCode = value
        End Set
    End Property



    Private mRemark As String = ""
    Public Property Remark() As String
        Get
            Return mRemark
        End Get
        Set(ByVal value As String)
            mRemark = value
        End Set
    End Property

    Dim mEmpID As Long = 0
    Public Property EmpID() As Long
        Get
            Return mEmpID
        End Get
        Set(ByVal value As Long)
            mEmpID = value
        End Set
    End Property


    Dim mShippingPeriod As String = ""
    Public Property ShippingPeriod() As String
        Get
            Return mShippingPeriod
        End Get
        Set(ByVal value As String)
            mShippingPeriod = value
        End Set
    End Property


    Dim mShippingMethod As String = ""
    Public Property ShippingMethod() As String
        Get
            Return mShippingMethod
        End Get
        Set(ByVal value As String)
            mShippingMethod = value
        End Set
    End Property

    Dim mShippingStatus As String = ""
    Public Property ShippingStatus() As String
        Get
            Return mShippingStatus
        End Get
        Set(ByVal value As String)
            mShippingStatus = value
        End Set
    End Property


    Dim mShippingRemark As String = ""
    Public Property ShippingRemark() As String
        Get
            Return mShippingRemark
        End Get
        Set(ByVal value As String)
            mShippingRemark = value
        End Set
    End Property

    Dim mShippingEmpID As Long = 0
    Public Property ShippingEmpID() As Long
        Get
            Return mShippingEmpID
        End Get
        Set(ByVal value As Long)
            mShippingEmpID = value
        End Set
    End Property

    Dim mAssignEmpID As Long = 0
    Public Property AssignEmpID() As Long
        Get
            Return mAssignEmpID
        End Get
        Set(ByVal value As Long)
            mAssignEmpID = value
        End Set
    End Property

    Dim mAssignDate As Date
    Public Property AssignDate() As Date
        Get
            Return mAssignDate
        End Get
        Set(ByVal value As Date)
            mAssignDate = value
        End Set
    End Property


#End Region


    Public Function GetDataTable(ByVal pFromDate As Date, ByVal pToDate As Date) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()
        Try
            SQL = "SELECT  [OrderID],[OrderCode],[OrderDate],[CusName] as Customer,[GrandTotal],ReceiptCode,BillCode "
            SQL &= " ,ShippingRec2.[Remark],[ShippingPeriod],[ShippingMethod],[ShippingStatus],[ShippingRemark] "
            SQL &= " ,[ShippingEmpID],[AssignEmpID],[AssignDate]"
            SQL &= " ,Employee.Title + Employee.Firstname + ' ' + Employee.LastName AS EMPNAME"
            SQL &= " ,ShippingEmp.Title + ShippingEmp.Firstname + ' ' + ShippingEmp.LastName AS ShippingEmp"
            SQL &= " FROM ShippingRec2"
            SQL &= " LEFT OUTER JOIN Employee ON ShippingRec2.EmpID=Employee.EmpID  "
            SQL &= " LEFT OUTER JOIN Employee ShippingEmp ON ShippingRec2.ShippingEmpID=ShippingEmp.EmpID  "
            SQL &= " WHERE OrderDate between '" & formatSQLDate(pFromDate) & "' and '" & formatSQLDate(pToDate) & "'"
            'SQL &= " AND OrdersDetail.IsDelete =0   "
            SQL &= " ORDER BY OrderID "
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, ".GetDataTable : " & e.Message)
        End Try
        Return dataTable
    End Function

    Public Function GetDataTableForShippingRecSummary(ByVal pFromDate As Date, ByVal pToDate As Date) As DataTable
        Dim SQL As String = ""
        Dim dataTable As New DataTable()

        Try
            SQL = " SELECT  ShippingEmp,sum(SuccessCount) SuccessCount,sum(NotSuccessCount)NotSuccessCount,sum(SomeCount )SomeCount,sum(InProcessCount )InProcessCount"
            SQL &= " FROM("
            SQL &= " SELECT ShippingEmp.Title + ShippingEmp.Firstname + ' ' + ShippingEmp.LastName AS ShippingEmp"
            SQL &= " ,case when Orders.ShippingStatus='สำเร็จ' then 1 else 0 end SuccessCount  "
            SQL &= " ,case when Orders.ShippingStatus='ไม่สำเร็จ' then 1 else 0 end NotSuccessCount  "
            SQL &= " ,case when Orders.ShippingStatus='สำเร็จบางส่วน' then 1 else 0 end SomeCount  "
            SQL &= " ,case when Orders.ShippingStatus='กำลังดำเนินการ' then 1 else 0 end InProcessCount  "
            SQL &= " FROM ShippingRec2 Orders    "
            SQL &= " LEFT OUTER JOIN Employee ShippingEmp ON Orders.ShippingEmpID=ShippingEmp.EmpID    "
            SQL &= " WHERE Orders.ShippingEmpID>0    "
            SQL &= " AND Orders.OrderDate Between '" & formatSQLDate(pFromDate) & "' and '" & formatSQLDate(pToDate) & "'"
            SQL &= " ) as tmp "
            SQL &= " group by ShippingEmp "
            SQL &= " ORDER by ShippingEmp "
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "GetDataTableForShippingRecSummary : " & e.Message)
        End Try
        Return dataTable
    End Function

    Public Function InitailData(ByVal pID As Long) As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()
        Dim lUserDAO As New UserDAO
        Try
            SQL = "SELECT *   "
            SQL &= " FROM ShippingRec2 WHERE 1=1"
            If pID > 0 Then
                SQL &= " and OrderID=" & pID
            End If

            SQL &= " ORDER BY OrderID"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows

                    OrderID = pID
                    OrderCode = dr("OrderCode").ToString

                    If IsDBNull(dr("OrderDate")) Then
                        OrderDate = GetCurrentDate(Nothing)
                    Else
                        OrderDate = dr("OrderDate")
                    End If
                    CusName = ConvertNullToString(dr("CusName"))
                    GrandTotal = ConvertNullToZero(dr("GrandTotal"))
                    ReceiptCode = ConvertNullToString(dr("ReceiptCode"))
                    BillCode = ConvertNullToString(dr("BillCode"))
                    Remark = ConvertNullToString(dr("Remark"))
                    EmpID = ConvertNullToZero(dr("EmpID"))
                    ShippingEmpID = ConvertNullToZero(dr("ShippingEmpID"))
                    AssignEmpID = ConvertNullToZero(dr("AssignEmpID"))
                    ShippingPeriod = ConvertNullToString(dr("ShippingPeriod"))
                    ShippingMethod = ConvertNullToString(dr("ShippingMethod"))
                    ShippingStatus = ConvertNullToString(dr("ShippingStatus"))
                    ShippingRemark = ConvertNullToString(dr("ShippingRemark"))

                    If IsDBNull(dr("AssignDate")) Then
                        AssignDate = GetCurrentDate(Nothing)
                    Else
                        AssignDate = dr("AssignDate")
                    End If


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

    Public Function SaveData() As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand
        Dim tr As SqlTransaction = Nothing
        SQL = ""
        Try
            tr = gConnection.Connection.BeginTransaction

            Select Case mMode
                Case DataMode.ModeNew
                    mIDs = GenNewID("OrderID", "ShippingRec2", tr)
                    SQL = " INSERT INTO ShippingRec2 ([OrderID],[OrderCode],[OrderDate],[CusName],[GrandTotal],ReceiptCode,BillCode,EmpID ,[Remark]"
                    SQL &= " ,[ShippingPeriod],[ShippingMethod],[ShippingStatus],[ShippingRemark] "
                    SQL &= " ,[ShippingEmpID],[AssignEmpID],[AssignDate] "
                    SQL &= " ) "

                    SQL &= " VALUES ( "
                    SQL &= "   @ID"
                    SQL &= " ,  @OrderCode"
                    SQL &= " ,  @OrderDate"
                    SQL &= " ,  @CusName"
                    SQL &= " ,  @GrandTotal"
                    SQL &= " ,  @ReceiptCode"
                    SQL &= " ,  @BillCode"
                    SQL &= " ,  @EmpID"
                    SQL &= " ,  @Remark"
                    SQL &= " ,  @ShippingPeriod"
                    SQL &= " ,  @ShippingMethod"
                    SQL &= " ,  @ShippingStatus"
                    SQL &= " ,  @ShippingRemark"
                    SQL &= " ,  @ShippingEmpID"
                    SQL &= " ,  @AssignEmpID"
                    SQL &= " ,  @AssignDate"
                    SQL &= " ) "
                Case DataMode.ModeEdit
                    SQL = " Update ShippingRec2   "
                    SQL = SQL & " SET"
                    SQL = SQL & " OrderCode=@OrderCode"
                    SQL = SQL & " ,OrderDate=@OrderDate"
                    SQL = SQL & " ,CusName=@CusName"
                    SQL = SQL & " ,GrandTotal=@GrandTotal"
                    SQL = SQL & " ,ReceiptCode=@ReceiptCode"
                    SQL = SQL & " ,BillCode=@BillCode"
                    SQL = SQL & " ,EmpID=@EmpID"
                    SQL = SQL & " ,Remark=@Remark"
                    SQL = SQL & " ,ShippingPeriod=@ShippingPeriod"
                    SQL = SQL & " ,ShippingMethod=@ShippingMethod"
                    SQL = SQL & " ,ShippingStatus=@ShippingStatus"
                    SQL = SQL & " ,ShippingRemark=@ShippingRemark"
                    SQL = SQL & " ,ShippingEmpID=@ShippingEmpID"
                    SQL = SQL & " ,AssignEmpID=@AssignEmpID"
                    SQL = SQL & " ,AssignDate=@AssignDate"
                    SQL = SQL & " WHERE OrderID= @ID"
                Case DataMode.ModeDelete
                    'SQL = " UPDATE OrdersDetail SET IsDelete=@IsDelete "
                    'SQL &= " WHERE OrdersDetailID= @ID"
                Case Else
                    Return False
                    Exit Function
            End Select
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@ID", OrderID))
            myCommand.Parameters.Add(New SqlParameter("@OrderCode", OrderCode))
            myCommand.Parameters.Add(New SqlParameter("@OrderDate", OrderDate))
            myCommand.Parameters.Add(New SqlParameter("@CusName", CusName))
            myCommand.Parameters.Add(New SqlParameter("@GrandTotal", GrandTotal))
            myCommand.Parameters.Add(New SqlParameter("@ReceiptCode", ReceiptCode))
            myCommand.Parameters.Add(New SqlParameter("@BillCode", BillCode))
            myCommand.Parameters.Add(New SqlParameter("@EmpID", EmpID))
            myCommand.Parameters.Add(New SqlParameter("@Remark", Remark))
            myCommand.Parameters.Add(New SqlParameter("@ShippingPeriod", ShippingPeriod))
            myCommand.Parameters.Add(New SqlParameter("@ShippingMethod", ShippingMethod))
            myCommand.Parameters.Add(New SqlParameter("@ShippingStatus", ShippingStatus))
            myCommand.Parameters.Add(New SqlParameter("@ShippingRemark", ShippingRemark))
            myCommand.Parameters.Add(New SqlParameter("@ShippingEmpID", ShippingEmpID))
            myCommand.Parameters.Add(New SqlParameter("@AssignEmpID", gUserID))
            myCommand.Parameters.Add(New SqlParameter("@AssignDate", GetCurrentDate(tr)))

            'Select Case ModeData
            '    Case DataMode.ModeNew
            '        myCommand.Parameters.Add(New SqlParameter("@IsDelete", 0))
            '    Case DataMode.ModeDelete
            '        myCommand.Parameters.Add(New SqlParameter("@IsDelete", 1))
            'End Select
            gConnection.executeInsertSqlCommand(myCommand, tr)

            If tr IsNot Nothing Then tr.Commit()

            Return True
        Catch e As Exception
            If tr Is Nothing Then tr.Rollback()
            Err.Raise(Err.Number, e.Source, "OrdersDetailDAO.SaveData : " & e.Message)
            Return False
        End Try
    End Function

End Class
