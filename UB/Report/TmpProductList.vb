Option Explicit On
Imports System.Data.SqlClient

Public Class TmpProductList

#Region "Property"
    Dim mSEQ As Integer
    Dim mProductID As Long
    Dim mProductName As String
    Dim mProductNameExt As String
    Dim mUnitCode As String
    Dim mUnits As Long
    Dim mCost As Decimal
    Dim mPrice As Decimal
    Dim mDiscount As Decimal
    Dim mTotal As Decimal
    Dim mRemark As String
    Dim mProductCode As String
    Dim mOrderDate As Date
    Dim mExpiryDate As Date
    Dim mCustomer As String
    Dim mCustomerTaxID As String
    Dim mIsMainCompany As Long
    Dim mClaimRemark As String
    Public ReadOnly Property UserID() As Long
        Get
            Return gUserID
        End Get
    End Property

    Public Property SEQ() As Integer
        Get
            Return mSEQ
        End Get
        Set(ByVal value As Integer)
            mSEQ = value
        End Set
    End Property

    Public Property ProductID() As Long
        Get
            Return mProductID
        End Get
        Set(ByVal value As Long)
            mProductID = value
        End Set
    End Property

    Public Property ProductCode() As String
        Get
            Return mProductCode
        End Get
        Set(ByVal value As String)
            mProductCode = value
        End Set
    End Property

    Public Property ProductName() As String
        Get
            Return mProductName
        End Get
        Set(ByVal value As String)
            mProductName = value
        End Set
    End Property
    Public Property ProductNameExt() As String
        Get
            Return mProductNameExt
        End Get
        Set(ByVal value As String)
            mProductNameExt = value
        End Set
    End Property
    Public Property UnitCode() As String
        Get
            Return mUnitCode
        End Get
        Set(ByVal value As String)
            mUnitCode = value
        End Set
    End Property
    Public Property Units() As Long
        Get
            Return mUnits
        End Get
        Set(ByVal value As Long)
            mUnits = value
        End Set
    End Property

    Public Property Cost() As Decimal
        Get
            Return mCost
        End Get
        Set(ByVal value As Decimal)
            mCost = value
        End Set
    End Property
    Public Property Price() As Decimal
        Get
            Return mPrice
        End Get
        Set(ByVal value As Decimal)
            mPrice = value
        End Set
    End Property
    Public Property Discount() As Decimal
        Get
            Return mDiscount
        End Get
        Set(ByVal value As Decimal)
            mDiscount = value
        End Set
    End Property
    Public Property Total() As Decimal
        Get
            Return mTotal
        End Get
        Set(ByVal value As Decimal)
            mTotal = value
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
    Public Property OrderDate() As Date
        Get
            Return mOrderDate
        End Get
        Set(ByVal value As Date)
            mOrderDate = value
        End Set
    End Property
    Public Property ExpiryDate() As Date
        Get
            Return mExpiryDate
        End Get
        Set(ByVal value As Date)
            mExpiryDate = value
        End Set


    End Property

    Public Property CustomerTaxID() As String
        Get
            Return mCustomerTaxID
        End Get
        Set(ByVal value As String)
            mCustomerTaxID = value
        End Set
    End Property

    Public Property Customer() As String
        Get
            Return mCustomer
        End Get
        Set(ByVal value As String)
            mCustomer = value
        End Set
    End Property

    Public Property IsMainCompany() As Long
        Get
            Return mIsMainCompany
        End Get
        Set(ByVal value As Long)
            mIsMainCompany = value
        End Set
    End Property
    Public Property ClaimRemark() As String
        Get
            Return mClaimRemark
        End Get
        Set(ByVal value As String)
            mClaimRemark = value
        End Set
    End Property
#End Region

    Public Function ClearTemp() As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand
        Dim tr As SqlTransaction = Nothing
        SQL = ""
        Try
            SQL = " DELETE FROM TmpProductList WHERE UserID=@UserID "
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@UserID", UserID))
            gConnection.executeInsertSqlCommand(myCommand, tr)

            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "TmpProductList.ClearTemp : " & e.Message)
            Return False
        End Try
    End Function


    Public Function SaveData() As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand
        Dim tr As SqlTransaction = Nothing
        SQL = ""
        Try
            SQL = " INSERT INTO TmpProductList (UserID,SEQ,ProductID,ProductCode,ProductName,ProductNameExt,UnitCode,Units"
            SQL &=  " ,Cost,Price,Discount,Total,Remark,OrderDate,ExpiryDate,Customer,CustomerTaxID,IsMainCompany,ClaimRemark)"
            SQL &=  " VALUES ( @UserID"
            SQL &=  " ,  @SEQ"
            SQL &=  " ,  @ProductID"
            SQL &=  " ,  @ProductCode"
            SQL &=  " ,  @ProductName"
            SQL &=  " ,  @ProductNameExt"
            SQL &=  " ,  @UnitCode"
            SQL &=  " ,  @Units"
            SQL &=  " ,  @Cost"
            SQL &=  " ,  @Price"
            SQL &=  " ,  @Discount"
            SQL &=  " ,  @Total"
            SQL &=  " ,  @Remark"
            SQL &=  " ,  @OrderDate"
            SQL &=  " ,  @ExpiryDate"
            SQL &=  " ,  @Customer"
            SQL &=  " ,  @CustomerTaxID"
            SQL &=  " ,  @IsMainCompany"
            SQL &=  " ,  @ClaimRemark"
            SQL &=  " ) "

            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@UserID", UserID))
            myCommand.Parameters.Add(New SqlParameter("@SEQ", ConvertNullToZero(SEQ)))
            myCommand.Parameters.Add(New SqlParameter("@ProductID", ConvertNullToZero(ProductID)))
            myCommand.Parameters.Add(New SqlParameter("@ProductCode", ConvertNullToString(ProductCode)))
            myCommand.Parameters.Add(New SqlParameter("@ProductName", ConvertNullToString(ProductName)))
            myCommand.Parameters.Add(New SqlParameter("@ProductNameExt", ConvertNullToString(ProductNameExt)))
            myCommand.Parameters.Add(New SqlParameter("@UnitCode", ConvertNullToString(UnitCode)))
            myCommand.Parameters.Add(New SqlParameter("@Units", ConvertNullToZero(Units)))
            myCommand.Parameters.Add(New SqlParameter("@Cost", ConvertNullToZero(Cost)))
            myCommand.Parameters.Add(New SqlParameter("@Price", ConvertNullToZero(Price)))
            myCommand.Parameters.Add(New SqlParameter("@Discount", ConvertNullToZero(Discount)))
            myCommand.Parameters.Add(New SqlParameter("@Total", ConvertNullToZero(Total)))
            myCommand.Parameters.Add(New SqlParameter("@Remark", ConvertNullToString(Remark)))
            myCommand.Parameters.Add(New SqlParameter("@OrderDate", formatSQLDate(OrderDate)))
            myCommand.Parameters.Add(New SqlParameter("@ExpiryDate", formatSQLDate(ExpiryDate)))
            myCommand.Parameters.Add(New SqlParameter("@Customer", ConvertNullToString(Customer)))
            myCommand.Parameters.Add(New SqlParameter("@CustomerTaxID", ConvertNullToString(CustomerTaxID)))
            myCommand.Parameters.Add(New SqlParameter("@IsMainCompany", ConvertNullToZero(IsMainCompany)))
            myCommand.Parameters.Add(New SqlParameter("@ClaimRemark", ConvertNullToString(ClaimRemark)))
            gConnection.executeInsertSqlCommand(myCommand, tr)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "TmpProductList.SaveData : " & e.Message)
            Return False
        End Try
    End Function


    Public Function SaveNull(ByVal pLoop As Integer) As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand
        Dim tr As SqlTransaction = Nothing
        SQL = ""
        Try
            Do While pLoop > 0
                SQL = " INSERT INTO TmpProductList (UserID,SEQ,ProductID,ProductCode,ProductName,ProductNameExt,UnitCode,Units"
                SQL &=  " ,Cost,Price,Discount,Total,Remark,OrderDate,ExpiryDate,Customer,CustomerTaxID,IsMainCompany,ClaimRemark)"
                SQL &=  " VALUES ( @UserID"
                SQL &=  " , 999"
                SQL &=  " , NULL"
                SQL &=  " , NULL"
                SQL &=  " , NULL"
                SQL &=  " , NULL"
                SQL &=  " , NULL"
                SQL &=  " , NULL"
                SQL &=  " , NULL"
                SQL &=  " , NULL"
                SQL &=  " , NULL"
                SQL &=  " , NULL"
                SQL &=  " , NULL"
                SQL &=  " , NULL"
                SQL &=  " , NULL"
                SQL &=  " , NULL"
                SQL &=  " , NULL"
                SQL &=  " , NULL"
                SQL &=  " , NULL"
                SQL &=  " ) "
                myCommand = New SqlCommand
                myCommand.CommandText = SQL
                myCommand.Parameters.Add(New SqlParameter("@UserID", UserID))
                gConnection.executeInsertSqlCommand(myCommand, tr)
                pLoop = pLoop - 1
            Loop


            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "TmpProductList.SaveData : " & e.Message)
            Return False
        End Try
    End Function

    Public Sub New()
        mSEQ = 0
        mProductID = 0
        mProductName = ""
        mProductNameExt = ""
        mUnitCode = ""
        mUnits = 0
        mCost = 0
        mPrice = 0
        mDiscount = 0
        mTotal = 0
        mRemark = 0
        mProductCode = ""
        mOrderDate = GetCurrentDate(Nothing)
        mExpiryDate = GetCurrentDate(Nothing)
        mCustomer = ""
        mCustomerTaxID = ""
        mIsMainCompany = 1
        mClaimRemark = ""
    End Sub
End Class
