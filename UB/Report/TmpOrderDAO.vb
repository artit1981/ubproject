Option Explicit On
Imports System.Data.SqlClient

Public Class TmpOrderDAO
#Region "Property"
    Dim mOrderCode As String
    Dim mOrderDate As Date
    Dim mShipingDate As Date
    Dim mCustomerCode As String
    Dim mCustomerName As String
    Dim mCompany As String
    Dim mAddressBill As String
    Dim mAddressShip As String
    Dim mPO As String
    Dim mCreditRule As String
    Dim mSendBy As String
    Dim mEmployee As String
    Dim mTotal As Decimal
    Dim mDiscountPercen As Decimal
    Dim mDiscountAmount As Decimal
    Dim mVatPercen As Decimal
    Dim mVatAmount As Decimal
    Dim mGrandTotal As Decimal
    Dim mGrandTotalSTR As String
    Dim mRemark As String
    Dim mCustomerPhone As String
    Dim mCustomerFAX As String
    Dim mPhone As String
    Dim mExpireDate As Date
    Dim mShipingMethod As String
    Dim mCompanyAddress As String
    Dim mCompanyPhone As String
    Dim mCompanyFAX As String
    Dim mCompanyTax As String
    Dim mCompanyBranch As String
    Dim mHeader1 As String
    Dim mHeader2 As String
    Dim mHeader3 As String
    Dim mCompanyOwner As String
    Dim mLogoID As Long
    Dim mCompanyMail As String
    Dim mCompanyWeb As String
    Dim mCustomerType As String
    Dim mShipingRule As String
    Dim mQuotationDays As Long
    Dim mContactPerson As String
    Dim mCustomerTax As String
    Dim mIsMainCompany As Long
    Dim mInstitute As String
    Dim mRefOrderCode As String
    Dim mEmployeePhone As String
    Dim mCompanyBankAccount As String
    Dim mEmployeePosition As String

    Public Property Header1() As String
        Get
            Return mHeader1
        End Get
        Set(ByVal value As String)
            mHeader1 = value
        End Set
    End Property
    Public Property Header2() As String
        Get
            Return mHeader2
        End Get
        Set(ByVal value As String)
            mHeader2 = value
        End Set
    End Property
    Public Property Header3() As String
        Get
            Return mHeader3
        End Get
        Set(ByVal value As String)
            mHeader3 = value
        End Set
    End Property
    Public ReadOnly Property UserID() As Long
        Get
            Return gUserID
        End Get
    End Property
    Public Property OrderCode() As String
        Get
            Return mOrderCode
        End Get
        Set(ByVal value As String)
            mOrderCode = value
        End Set
    End Property
    Public Property ExpireDate() As Date
        Get
            Return mExpireDate
        End Get
        Set(ByVal value As Date)
            mExpireDate = value
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

    Public Property ShipingDate() As Date
        Get
            Return mShipingDate
        End Get
        Set(ByVal value As Date)
            mShipingDate = value
        End Set
    End Property
    Public Property CustomerCode() As String
        Get
            Return mCustomerCode
        End Get
        Set(ByVal value As String)
            mCustomerCode = value
        End Set
    End Property
    Public Property CustomerName() As String
        Get
            Return mCustomerName
        End Get
        Set(ByVal value As String)
            mCustomerName = value
        End Set
    End Property
    Public Property CustomerPhone() As String
        Get
            Return mCustomerPhone
        End Get
        Set(ByVal value As String)
            mCustomerPhone = value
        End Set
    End Property
    Public Property CustomerFAX() As String
        Get
            Return mCustomerFAX
        End Get
        Set(ByVal value As String)
            mCustomerFAX = value
        End Set
    End Property
    Public Property CustomerType() As String
        Get
            Return mCustomerType
        End Get
        Set(ByVal value As String)
            mCustomerType = value
        End Set
    End Property
    Public Property CustomerTax() As String
        Get
            Return mCustomerTax
        End Get
        Set(ByVal value As String)
            mCustomerTax = value
        End Set
    End Property
    Public Property Company() As String
        Get
            Return mCompany
        End Get
        Set(ByVal value As String)
            mCompany = value
        End Set
    End Property
    Public Property CompanyOwner() As String
        Get
            Return mCompanyOwner
        End Get
        Set(ByVal value As String)
            mCompanyOwner = value
        End Set
    End Property
    Public Property CompanyAddress() As String
        Get
            Return mCompanyAddress
        End Get
        Set(ByVal value As String)
            mCompanyAddress = value
        End Set
    End Property
    Public Property CompanyPhone() As String
        Get
            Return mCompanyPhone
        End Get
        Set(ByVal value As String)
            mCompanyPhone = value
        End Set
    End Property
    Public Property AddressBill() As String
        Get
            Return mAddressBill
        End Get
        Set(ByVal value As String)
            mAddressBill = value
        End Set
    End Property
    Public Property AddressShip() As String
        Get
            Return mAddressShip
        End Get
        Set(ByVal value As String)
            mAddressShip = value
        End Set
    End Property
    Public Property PO() As String
        Get
            Return mPO
        End Get
        Set(ByVal value As String)
            mPO = value
        End Set
    End Property
    Public Property CreditRule() As String
        Get
            Return mCreditRule
        End Get
        Set(ByVal value As String)
            mCreditRule = value
        End Set
    End Property
    Public Property SendBy() As String
        Get
            Return mSendBy
        End Get
        Set(ByVal value As String)
            mSendBy = value
        End Set
    End Property
    Public Property ShipingMethod() As String
        Get
            Return mShipingMethod
        End Get
        Set(ByVal value As String)
            mShipingMethod = value
        End Set
    End Property
    Public Property ShipingRule() As String
        Get
            Return mShipingRule
        End Get
        Set(ByVal value As String)
            mShipingRule = value
        End Set
    End Property
    Public Property EmployeePhone() As String
        Get
            Return mEmployeePhone
        End Get
        Set(ByVal value As String)
            mEmployeePhone = value
        End Set
    End Property
    Public Property Employee() As String
        Get
            Return mEmployee
        End Get
        Set(ByVal value As String)
            mEmployee = value
        End Set
    End Property
    Public Property EmployeePosition() As String
        Get
            Return mEmployeePosition
        End Get
        Set(ByVal value As String)
            mEmployeePosition = value
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
    Public Property DiscountPercen() As Decimal
        Get
            Return mDiscountPercen
        End Get
        Set(ByVal value As Decimal)
            mDiscountPercen = value
        End Set
    End Property
    Public Property DiscountAmount() As Decimal
        Get
            Return mDiscountAmount
        End Get
        Set(ByVal value As Decimal)
            mDiscountAmount = value
        End Set
    End Property
    Public Property VatPercen() As Decimal
        Get
            Return mVatPercen
        End Get
        Set(ByVal value As Decimal)
            mVatPercen = value
        End Set
    End Property
    Public Property VatAmount() As Decimal
        Get
            Return mVatAmount
        End Get
        Set(ByVal value As Decimal)
            mVatAmount = value
        End Set
    End Property
    Public Property GrandTotal() As Decimal
        Get
            Return mGrandTotal
        End Get
        Set(ByVal value As Decimal)
            mGrandTotal = value
        End Set
    End Property
    Public Property GrandTotalSTR() As String
        Get
            Return mGrandTotalSTR
        End Get
        Set(ByVal value As String)
            mGrandTotalSTR = value
        End Set
    End Property
    Public Property Institute() As String
        Get
            Return mInstitute
        End Get
        Set(ByVal value As String)
            mInstitute = value
        End Set
    End Property
    Public Property RefOrderCode() As String
        Get
            Return mRefOrderCode
        End Get
        Set(ByVal value As String)
            mRefOrderCode = value
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

    Public Property CompanyFAX() As String
        Get
            Return mCompanyFAX
        End Get
        Set(ByVal value As String)
            mCompanyFAX = value
        End Set
    End Property

    Public Property CompanyTax() As String
        Get
            Return mCompanyTax
        End Get
        Set(ByVal value As String)
            mCompanyTax = value
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
    Public Property CompanyBranch() As String
        Get
            Return mCompanyBranch
        End Get
        Set(ByVal value As String)
            mCompanyBranch = value
        End Set
    End Property
    Public Property CompanyMail() As String
        Get
            Return mCompanyMail
        End Get
        Set(ByVal value As String)
            mCompanyMail = value
        End Set
    End Property
    Public Property CompanyWeb() As String
        Get
            Return mCompanyWeb
        End Get
        Set(ByVal value As String)
            mCompanyWeb = value
        End Set
    End Property
    Public Property CompanyBankAccount() As String
        Get
            Return mCompanyBankAccount
        End Get
        Set(ByVal value As String)
            mCompanyBankAccount = value
        End Set
    End Property

    Public Property LogoID() As Long
        Get
            Return mLogoID
        End Get
        Set(ByVal value As Long)
            mLogoID = value
        End Set
    End Property
    Public Property QuotationDays() As Long
        Get
            Return mQuotationDays
        End Get
        Set(ByVal value As Long)
            mQuotationDays = value
        End Set
    End Property
    Public Property ContactPerson() As String
        Get
            Return mContactPerson
        End Get
        Set(ByVal value As String)
            mContactPerson = value
        End Set
    End Property
    Private mCustomerEmail As String
    Public Property CustomerEmail() As String
        Get
            Return mCustomerEmail
        End Get
        Set(ByVal value As String)
            mCustomerEmail = value
        End Set
    End Property
#End Region



    Public Function SaveData() As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand

        SQL = ""
        Try
            SQL = " DELETE FROM TmpOrders WHERE UserID=@UserID "
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@UserID", UserID))
            gConnection.executeInsertSqlCommand(myCommand, Nothing)

            SQL = " INSERT INTO TmpOrders  (UserID,OrderCode,PO,OrderDate,ShipingDate,ExpireDate,CustomerCode,CustomerName,Company "
            SQL &=  " ,AddressBill,AddressShip,CreditRule,SendBy,Employee"
            SQL &=  " ,Total,DiscountPercen,DiscountAmount,VatPercen,VatAmount,GrandTotal,GrandTotalSTR,Remark"
            SQL &=  " ,CompanyAddress,CompanyPhone,CompanyFAX,CustomerPhone,CustomerFAX,CompanyTax,CompanyBranch,Header1,Header2,Header3"
            SQL &=  " ,CompanyOwner,CompanyMail,CompanyWeb,CustomerType,ShipingRule,QuotationDays,ContactPerson,ShipingMethod,CustomerTax,IsMainCompany"
            SQL &= " ,Institute, RefOrderCode,EmployeePhone,CompanyBankAccount,EmployeePosition,CustomerEmail "
            SQL &=  " )"
            SQL &=  " VALUES ( @UserID"
            SQL &=  " ,  @OrderCode"
            SQL &=  " ,  @PO"
            SQL &=  " ,  @OrderDate"
            SQL &=  " ,  @ShipingDate"
            SQL &=  " ,  @ExpireDate"
            SQL &=  " ,  @CustomerCode"
            SQL &=  " ,  @CustomerName"
            SQL &=  " ,  @Company "
            SQL &=  " ,  @AddressBill"
            SQL &=  " ,  @AddressShip"
            SQL &=  " ,  @CreditRule"
            SQL &=  " ,  @SendBy"
            SQL &=  " ,  @Employee"
            SQL &=  " ,  @Total "
            SQL &=  " ,  @DiscountPercen "
            SQL &=  " ,  @DiscountAmount "
            SQL &=  " ,  @VatPercen "
            SQL &=  " ,  @VatAmount "
            SQL &=  " ,  @GrandTotal "
            SQL &=  " ,  @GrandTotalSTR "
            SQL &=  " ,  @Remark "
            SQL &=  " ,  @CompanyAddress "
            SQL &=  " ,  @CompanyPhone "
            SQL &=  " ,  @CompanyFAX "
            SQL &=  " ,  @CustomerPhone "
            SQL &=  " ,  @CustomerFAX "
            SQL &=  " ,  @CompanyTax "
            SQL &=  " ,  @CompanyBranch "
            SQL &=  " ,  @Header1 "
            SQL &=  " ,  @Header2 "
            SQL &=  " ,  @Header3 "
            SQL &=  " ,  @CompanyOwner "
            SQL &=  " ,  @CompanyMail "
            SQL &=  " ,  @CompanyWeb "
            SQL &=  " ,  @CustomerType "
            SQL &=  " ,  @ShipingRule "
            SQL &=  " ,  @QuotationDays "
            SQL &=  " ,  @ContactPerson "
            SQL &=  " ,  @ShipingMethod "
            SQL &=  " ,  @CustomerTax "
            SQL &=  " ,  @IsMainCompany "
            SQL &= " ,@Institute, @RefOrderCode,@EmployeePhone,  @CompanyBankAccount,  @EmployeePosition ,@CustomerEmail "
            SQL &=  " ) "

            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@UserID", UserID))
            myCommand.Parameters.Add(New SqlParameter("@OrderCode", Trim(OrderCode)))
            myCommand.Parameters.Add(New SqlParameter("@PO", ConvertNullToString(PO)))
            myCommand.Parameters.Add(New SqlParameter("@CustomerCode", ConvertNullToString(CustomerCode)))
            myCommand.Parameters.Add(New SqlParameter("@CustomerName", ConvertNullToString(CustomerName)))
            myCommand.Parameters.Add(New SqlParameter("@OrderDate", formatSQLDate(OrderDate)))
            myCommand.Parameters.Add(New SqlParameter("@ShipingDate", formatSQLDate(ShipingDate)))
            myCommand.Parameters.Add(New SqlParameter("@ExpireDate", formatSQLDate(ExpireDate)))
            myCommand.Parameters.Add(New SqlParameter("@Company", ConvertNullToString(Company)))
            myCommand.Parameters.Add(New SqlParameter("@AddressBill", ConvertNullToString(AddressBill)))
            myCommand.Parameters.Add(New SqlParameter("@AddressShip", ConvertNullToString(AddressShip)))
            myCommand.Parameters.Add(New SqlParameter("@CreditRule", ConvertNullToString(CreditRule)))
            myCommand.Parameters.Add(New SqlParameter("@SendBy", ConvertNullToString(SendBy)))
            myCommand.Parameters.Add(New SqlParameter("@Total", ConvertNullToZero(Total)))
            myCommand.Parameters.Add(New SqlParameter("@DiscountPercen", ConvertNullToZero(DiscountPercen)))
            myCommand.Parameters.Add(New SqlParameter("@DiscountAmount", ConvertNullToZero(DiscountAmount)))
            myCommand.Parameters.Add(New SqlParameter("@VatPercen", ConvertNullToZero(VatPercen)))
            myCommand.Parameters.Add(New SqlParameter("@VatAmount", ConvertNullToZero(VatAmount)))
            myCommand.Parameters.Add(New SqlParameter("@GrandTotal", ConvertNullToZero(GrandTotal)))
            myCommand.Parameters.Add(New SqlParameter("@Remark", ConvertNullToString(Remark)))
            myCommand.Parameters.Add(New SqlParameter("@GrandTotalSTR", ConvertNullToString(GrandTotalSTR)))
            myCommand.Parameters.Add(New SqlParameter("@Employee", ConvertNullToString(Employee)))
            myCommand.Parameters.Add(New SqlParameter("@CompanyAddress", ConvertNullToString(CompanyAddress)))
            myCommand.Parameters.Add(New SqlParameter("@CompanyPhone", ConvertNullToString(CompanyPhone)))
            myCommand.Parameters.Add(New SqlParameter("@CustomerPhone", ConvertNullToString(CustomerPhone)))
            myCommand.Parameters.Add(New SqlParameter("@CustomerFAX", ConvertNullToString(CustomerFAX)))
            myCommand.Parameters.Add(New SqlParameter("@CompanyFAX", ConvertNullToString(CompanyFAX)))
            myCommand.Parameters.Add(New SqlParameter("@CompanyTax", ConvertNullToString(CompanyTax)))
            myCommand.Parameters.Add(New SqlParameter("@CompanyBranch", ConvertNullToString(CompanyBranch)))
            myCommand.Parameters.Add(New SqlParameter("@Header1", ConvertNullToString(Header1)))
            myCommand.Parameters.Add(New SqlParameter("@Header2", ConvertNullToString(Header2)))
            myCommand.Parameters.Add(New SqlParameter("@Header3", ConvertNullToString(Header3)))
            myCommand.Parameters.Add(New SqlParameter("@CompanyOwner", ConvertNullToString(CompanyOwner)))
            myCommand.Parameters.Add(New SqlParameter("@CompanyMail", ConvertNullToString(CompanyMail)))
            myCommand.Parameters.Add(New SqlParameter("@CompanyWeb", ConvertNullToString(CompanyWeb)))
            myCommand.Parameters.Add(New SqlParameter("@CustomerType", ConvertNullToString(CustomerType)))
            myCommand.Parameters.Add(New SqlParameter("@ShipingRule", ConvertNullToString(ShipingRule)))
            myCommand.Parameters.Add(New SqlParameter("@ContactPerson", ConvertNullToString(ContactPerson)))
            myCommand.Parameters.Add(New SqlParameter("@QuotationDays", ConvertNullToZero(QuotationDays)))
            myCommand.Parameters.Add(New SqlParameter("@ShipingMethod", ConvertNullToString(ShipingMethod)))
            myCommand.Parameters.Add(New SqlParameter("@CustomerTax", ConvertNullToString(CustomerTax)))
            myCommand.Parameters.Add(New SqlParameter("@IsMainCompany", ConvertNullToZero(IsMainCompany)))
            myCommand.Parameters.Add(New SqlParameter("@RefOrderCode", ConvertNullToString(RefOrderCode)))
            myCommand.Parameters.Add(New SqlParameter("@Institute", ConvertNullToString(Institute)))
            myCommand.Parameters.Add(New SqlParameter("@EmployeePhone", ConvertNullToString(EmployeePhone)))
            myCommand.Parameters.Add(New SqlParameter("@CompanyBankAccount", ConvertNullToString(CompanyBankAccount)))
            myCommand.Parameters.Add(New SqlParameter("@EmployeePosition", ConvertNullToString(EmployeePosition)))
            myCommand.Parameters.Add(New SqlParameter("@CustomerEmail", ConvertNullToString(CustomerEmail)))
            gConnection.executeInsertSqlCommand(myCommand, Nothing)

            If mLogoID > 0 Then
                SQL = " Update TmpOrders set Logo=(select FileData from AttachFile where FileID=" & mLogoID & ") WHERE UserID=@UserID "
                myCommand = New SqlCommand
                myCommand.CommandText = SQL
                myCommand.Parameters.Add(New SqlParameter("@UserID", UserID))
                gConnection.executeInsertSqlCommand(myCommand, Nothing)
            End If



            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "TmpOrderDAO.SaveData : " & e.Message)
            Return False
        End Try
    End Function

    Public Sub New()
        mOrderCode = ""
        mOrderDate = Now
        mShipingDate = Now
        mCustomerCode = ""
        mCustomerName = ""
        mCompany = ""
        mAddressBill = ""
        mAddressShip = ""
        mPO = ""
        mCreditRule = ""
        mSendBy = ""
        mEmployee = ""
        mTotal = 0
        mDiscountPercen = 0
        mDiscountAmount = 0
        mVatPercen = 0
        mVatAmount = 0
        mGrandTotal = 0
        mGrandTotalSTR = ""
        mRemark = ""
        mCustomerPhone = ""
        mCustomerFAX = ""
        mPhone = ""
        mExpireDate = Now
        mShipingMethod = ""
        mCompanyAddress = ""
        mCompanyPhone = ""
        mCompanyFAX = ""
        mCompanyTax = ""
        mCompanyBranch = ""
        mHeader1 = ""
        mHeader2 = ""
        mHeader3 = ""
        mCompanyOwner = ""
        mLogoID = 0
        mCompanyMail = ""
        mCompanyWeb = ""
        mCustomerType = ""
        mShipingRule = ""
        mQuotationDays = 0
        mContactPerson = ""
        mCustomerTax = ""
        mIsMainCompany = 1
        mInstitute = ""
        mRefOrderCode = ""
        mEmployeePhone = ""
        mCompanyBankAccount = ""
        mEmployeePosition = ""
        mCustomerEmail = ""
    End Sub
End Class
