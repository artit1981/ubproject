Option Explicit On
Imports System.Data.SqlClient

Public Class CustomerDAO
    Inherits iPerson


#Region "Property"
    Dim mEmpID As Long
    Dim mclsEmployee As EmployeeDAO
    Dim mContactRole As String
    Dim mIsHoldButget As Integer
    Dim mCurrencyID As Long
    Dim mLeadID As Long
    Dim mCompanyTypeID As Long
    Dim mCompanyRelateID As Long
    Dim mIndustryTypeID As Long
    Dim mBusinessTypeID As Long
    Dim mEstimatedBudjet As Decimal
    Dim mBuyingTimeFrame As Long
    Dim mIsQuick As String
    Dim mclsLeadDAO As CustomerDAO
    Dim mRating As String
    Dim mNoOfEmployee As Long
    Dim mAnnualRevenue As Decimal
    Dim mDecisionMakerID As Long
    Dim mclsDecisionMaker_Con As CustomerDAO
    Private mTableID As MasterType
    Dim mLeadType As String
    Dim mLeadStatus As String
    Dim mDisqualifyStatus As String
    Dim mEsttablishedDate As Date
    Dim mRelateAccountID As Long
    Dim mSubject As String
    Private mIsConvert As String
    Private mCapital As Decimal
    Private mProductDAOs As List(Of ProductListDAO)
    Private mContactPersonID As Long
    Dim mBranch As String
    Dim mBankAccountID1 As Long
    Dim mBankAccountID2 As Long
    Dim mBankAccountID3 As Long
    Dim mCustomerType As String = ""


    Public Property TableID() As Long
        Get
            Return mTableID
        End Get
        Set(ByVal value As Long)
            mTableID = value
        End Set
    End Property

    Public ReadOnly Property TableName() As String
        Get
            mTableID = TableID
            Return mTableID.ToString
            'Return "Account"
        End Get
    End Property

    Public Property Rating() As String
        Get
            Return mRating
        End Get
        Set(ByVal value As String)
            mRating = value
        End Set
    End Property
    Public Property NoOfEmployee() As Long
        Get
            Return mNoOfEmployee
        End Get
        Set(ByVal value As Long)
            mNoOfEmployee = value
        End Set
    End Property
    Public Property AnnualRevenue() As Decimal
        Get
            Return mAnnualRevenue
        End Get
        Set(ByVal value As Decimal)
            mAnnualRevenue = value
        End Set
    End Property
    Public Property ContactRole() As String
        Get
            Return mContactRole
        End Get
        Set(ByVal value As String)
            mContactRole = value
        End Set
    End Property
    Public Property IsQuick() As String
        Get
            Return mIsQuick
        End Get
        Set(ByVal value As String)
            mIsQuick = value
        End Set
    End Property
    Public Property BuyingTimeFrame() As Long
        Get
            Return mBuyingTimeFrame
        End Get
        Set(ByVal value As Long)
            mBuyingTimeFrame = value
        End Set
    End Property
    Public Property EstimatedBudjet() As Decimal
        Get
            Return mEstimatedBudjet
        End Get
        Set(ByVal value As Decimal)
            mEstimatedBudjet = value
        End Set
    End Property

    Public Property IsHoldButget() As Integer
        Get
            Return mIsHoldButget
        End Get
        Set(ByVal value As Integer)
            mIsHoldButget = value
        End Set
    End Property
    Public Property BusinessTypeID() As Long
        Get
            Return mBusinessTypeID
        End Get
        Set(ByVal value As Long)
            mBusinessTypeID = value
        End Set
    End Property

    Public Property IndustryTypeID() As Long
        Get
            Return mIndustryTypeID
        End Get
        Set(ByVal value As Long)
            mIndustryTypeID = value
        End Set
    End Property

    Public Property Branch() As String
        Get
            Return mBranch
        End Get
        Set(ByVal value As String)
            mBranch = value
        End Set
    End Property
    Public Property Subject() As String
        Get
            Return mSubject
        End Get
        Set(ByVal value As String)
            mSubject = value
        End Set
    End Property

    Public Property ContactPersonID() As Long
        Get
            Return mContactPersonID
        End Get
        Set(ByVal value As Long)
            mContactPersonID = value
        End Set
    End Property

    Public Property CompanyTypeID() As Long
        Get
            Return mCompanyTypeID
        End Get
        Set(ByVal value As Long)
            mCompanyTypeID = value
        End Set
    End Property

    Public Property CompanyRelateID() As Long
        Get
            Return mCompanyRelateID
        End Get
        Set(ByVal value As Long)
            mCompanyRelateID = value
        End Set
    End Property

    Public Property BankAccountID1() As Long
        Get
            Return mBankAccountID1
        End Get
        Set(ByVal value As Long)
            mBankAccountID1 = value
        End Set
    End Property

    Public Property BankAccountID2() As Long
        Get
            Return mBankAccountID2
        End Get
        Set(ByVal value As Long)
            mBankAccountID2 = value
        End Set
    End Property

    Public Property BankAccountID3() As Long
        Get
            Return mBankAccountID3
        End Get
        Set(ByVal value As Long)
            mBankAccountID3 = value
        End Set
    End Property

    Public Property LeadID() As Long
        Get
            Return mLeadID
        End Get
        Set(ByVal value As Long)
            mLeadID = value
        End Set
    End Property
    Public ReadOnly Property Lead() As CustomerDAO
        Get
            If mLeadID > 0 And mclsLeadDAO Is Nothing Then
                mclsLeadDAO = Nothing
                mclsLeadDAO = New CustomerDAO
                mclsLeadDAO.InitailData(mLeadID)
            End If
            Return mclsLeadDAO
        End Get
    End Property

    Public Property CurrencyID() As Long
        Get
            Return mCurrencyID
        End Get
        Set(ByVal value As Long)
            mCurrencyID = value
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

    Public Property LeadType() As String
        Get
            Return mLeadType
        End Get
        Set(ByVal value As String)
            mLeadType = value
        End Set
    End Property

    Public Property LeadStatus() As String
        Get
            Return mLeadStatus
        End Get
        Set(ByVal value As String)
            mLeadStatus = value
        End Set

    End Property
    Public Property DisqualifyStatus() As String
        Get
            Return mDisqualifyStatus
        End Get
        Set(ByVal value As String)
            mDisqualifyStatus = value
        End Set
    End Property
    Public Property EsttablishedDate() As Date
        Get
            Return mEsttablishedDate
        End Get
        Set(ByVal value As Date)
            mEsttablishedDate = value
        End Set
    End Property
    Public Property IsConvert() As String
        Get
            Return mIsConvert
        End Get
        Set(ByVal value As String)
            mIsConvert = value
        End Set
    End Property
    Public Property Capital() As Decimal
        Get
            Return mCapital
        End Get
        Set(ByVal value As Decimal)
            mCapital = value
        End Set
    End Property

    Public Property EmpID() As Long
        Get
            Return mEmpID
        End Get
        Set(ByVal value As Long)
            mEmpID = value
        End Set
    End Property
    Public ReadOnly Property EmployeeDAO() As EmployeeDAO
        Get
            If mclsEmployee Is Nothing Then
                mclsEmployee = New EmployeeDAO
                mclsEmployee.InitailData(EmpID)
            End If
            Return mclsEmployee
        End Get
    End Property
    Public Property DecisionMakerID() As Long
        Get
            Return mDecisionMakerID
        End Get
        Set(ByVal value As Long)
            mDecisionMakerID = value
        End Set
    End Property

    Public Property RelateAccountID() As Long
        Get
            Return mRelateAccountID
        End Get
        Set(ByVal value As Long)
            mRelateAccountID = value
        End Set
    End Property

    Public ReadOnly Property DecisionMakerDAO_Con() As CustomerDAO
        Get
            If mclsDecisionMaker_Con Is Nothing Then
                mclsDecisionMaker_Con = New CustomerDAO
                mclsDecisionMaker_Con.InitailData(DecisionMakerID)
            End If
            Return mclsDecisionMaker_Con
        End Get
    End Property


    Public Property ProductDAOs() As List(Of ProductListDAO)
        Get
            Return mProductDAOs
        End Get
        Set(ByVal Value As List(Of ProductListDAO))
            mProductDAOs = Value
        End Set
    End Property

#End Region

    Public Function CHECKSUM_AGG() As Long
        Dim SQL As String
        Dim dataTable As New DataTable()
        Try
            SQL = "SELECT CHECKSUM_AGG(BINARY_CHECKSUM(*)) FROM Customer "
            SQL &=  " WITH (NOLOCK)"
            SQL &=  " where CustomerType='" & TableName & "' ;"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    Return ConvertNullToZero(dr(0))
                    Exit For
                Next
            End If
            Return 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "CustomerDAO.CHECKSUM_AGG : " & e.Message)
            Return 0
        Finally
            dataTable = Nothing
        End Try
    End Function

    Public Overrides Function InitailData(ByVal pID As Long, Optional ByVal pName As String = "", Optional ByVal tr As SqlTransaction = Nothing) As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()
        Dim lUserDAO As New UserDAO
        Try
            SQL = "SELECT *   "
            SQL &=  " FROM Customer"
            If pName <> "" Then
                SQL &=  " WHERE Firstname LIKE '%" & pName & "%'"
            Else
                SQL &=  " WHERE CustomerID=" & pID
            End If
            If TableName <> "" And TableName <> "0" Then
                SQL &=  " and CustomerType ='" & TableName & "'"
            End If
            SQL &=  " ORDER BY CustomerCode"
            dataTable = gConnection.executeSelectQuery(SQL, tr)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    If IsDBNull(dr("EsttablishedDate")) Then
                        EsttablishedDate = GetCurrentDate(tr)
                    Else
                        EsttablishedDate = dr("EsttablishedDate")
                    End If
                    Subject = dr("Subject").ToString
                    CustomerType = ConvertNullToString(dr("CustomerType"))
                    LeadStatus = ConvertNullToString(dr("LeadStatus"))
                    LeadType = ConvertNullToString(dr("LeadType"))
                    Branch = ConvertNullToString(dr("Branch"))
                    DisqualifyStatus = ConvertNullToString(dr("DisqualifyStatus"))
                    Rating = ConvertNullToString(dr("Rating"))
                    ContactPersonID = ConvertNullToZero(dr("ContactPersonID"))
                    DecisionMakerID = ConvertNullToZero(dr("DecisionMakerID"))
                    ContactRole = ConvertNullToString(dr("ContactRole"))
                    LeadID = ConvertNullToZero(dr("LeadID"))
                    EstimatedBudjet = ConvertNullToZero(dr("EstimatedBudjet"))
                    IndustryTypeID = ConvertNullToZero(dr("IndustryTypeID"))
                    BusinessTypeID = ConvertNullToZero(dr("BusinessTypeID"))
                    IsHoldButget = ConvertNullToZero(dr("IsHoldButget"))
                    CreditAmount = ConvertNullToZero(dr("CreditAmount"))
                    BuyingTimeFrame = ConvertNullToZero(dr("BuyingTimeFrame"))
                    TerritoryID = ConvertNullToZero(dr("TerritoryID"))
                    CreditRuleID = ConvertNullToZero(dr("CreditRuleID"))
                    CurrencyID = ConvertNullToZero(dr("CurrencyID"))
                    NoOfEmployee = ConvertNullToZero(dr("NoOfEmployee"))
                    AnnualRevenue = ConvertNullToZero(dr("AnnualRevenue"))
                    CriterionPriceID = ConvertNullToZero(dr("CriterionPriceID"))
                    CompanyRelateID = ConvertNullToZero(dr("CompanyRelateID"))
                    CompanyTypeID = ConvertNullToZero(dr("CompanyTypeID"))
                    CustomerZoneID = ConvertNullToZero(dr("CustomerZoneID"))
                    CustomerGroupID = ConvertNullToZero(dr("CustomerGroupID"))
                    IsCorporation = ConvertNullToZero(dr("IsCorporation"))
                    CreditGroupID = ConvertNullToZero(dr("CreditGroupID"))
                    RelateAccountID = ConvertNullToZero(dr("RelateAccountID"))
                    Capital = ConvertNullToZero(dr("Capital"))
                    ImportTXID = ConvertNullToZero(dr("ImportTXID"))
                    IsMainCompany = ConvertNullToZero(dr("IsMainCompany"))
                    BankAccountID1 = ConvertNullToZero(dr("BankAccountID1"))
                    BankAccountID2 = ConvertNullToZero(dr("BankAccountID2"))
                    BankAccountID3 = ConvertNullToZero(dr("BankAccountID3"))

                    'Person
                    ID = Int32.Parse(dr("CustomerID"))
                    IsInActive = dr("IsInActive")
                    Code = ConvertNullToString(dr("CustomerCode"))
                    Title = ConvertNullToString(dr("Title"))
                    FirstName = ConvertNullToString(dr("Firstname"))
                    LastName = ConvertNullToString(dr("LastName"))
                    Position = ConvertNullToString(dr("Position"))
                    CompanyName = ConvertNullToString(dr("CompanyName"))
                    SourceID = ConvertNullToZero(dr("SourceID"))
                    EmpID = ConvertNullToZero(dr("EmpID"))
                    VatTypeID = ConvertNullToZero(dr("VatTypeID"))
                    BillDay = ConvertNullToZero(dr("BillDay"))
                    ChqDay = ConvertNullToZero(dr("ChqDay"))
                    BillDayTo = ConvertNullToZero(dr("BillDayTo"))
                    ChqDayTo = ConvertNullToZero(dr("ChqDayTo"))
                    Remark = dr("Remark").ToString
                    SendBy = dr("SendBy").ToString
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


                    AddressS = Nothing
                    AddressS = New AddressDAO
                    AddressS.InitailData(ConvertNullToZero(dr("AddressID")), tr)


                    'Ship Address
                    AddressShip = Nothing
                    AddressShip = New AddressDAO
                    AddressShip.InitailData(ConvertNullToZero(dr("AddressIDShip")), tr)

                    'If AddressShip.AddressName = "" And AddressShip.AddressNo = "" Then
                    '    AddressShip = AddressS
                    'End If
                    FileAttachs = LoadFileAttach(ID, TableName, tr)

                    HistoryDAO = Nothing
                    HistoryDAO = New HistoryDAO
                    HistoryDAO.InitailData(ConvertNullToZero(dr("HistoryID")), tr)

                    Return True
                    Exit For
                Next

            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "CustomerDAO.InitailData : " & e.Message)
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
        '    Err.Raise(Err.Number, e.Source, "CustomerDAO.GetInfoHtml : " & e.Message)

        'End Try
        Return Info
    End Function

    Public Function GetDataTable(ByVal pID As Long, ByVal pOnlyActive As Boolean) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try

            SQL = "SELECT A.CustomerID AS ID"

            If mTableID = MasterType.Lead Then
                SQL &=  " ,A.Subject"
            End If
            If mTableID = MasterType.Accounts Or mTableID = MasterType.Contacts Or mTableID = MasterType.Agency Then
                SQL &=  " ,A.CustomerCode AS Code"
            End If
            If mTableID = MasterType.Contacts Or mTableID = MasterType.Lead Then
                SQL &=  " ,A.Title + A.Firstname + ' ' + A.LastName AS NAME"
            End If

            SQL &=  " ,A.CompanyName "
            If mTableID = MasterType.Lead Then
                SQL &=  " ,A.LeadStatus"
            End If
            If mTableID = MasterType.Agency Or mTableID = MasterType.Lead Or mTableID = MasterType.Accounts Then
                SQL &=  " ,A.Rating"
            End If
            If mTableID = MasterType.Accounts Then
                SQL &=  " ,Contact.Title + Contact.Firstname + ' ' + Contact.LastName as ContactPerson"
            ElseIf mTableID = MasterType.Agency Then
                SQL &=  " ,Address.ContactName as ContactPerson"
            End If
            SQL &=  " ,A.IsQuick "
            SQL &=  " ,Address.Phone1,Address.Fax,Address.Email1 "
            SQL &=  " ,Employee.Title + Employee.Firstname + ' ' + Employee.LastName AS EMPNAME "
            SQL &=  " ,A.ModifiedTime"
            SQL &=  " FROM Customer A"
            If mTableID = MasterType.Accounts Or mTableID = MasterType.Agency Then
                SQL &=  " LEFT OUTER JOIN Customer as Contact ON Contact.CustomerID=A.ContactPersonID  "
            End If
            SQL &=  " LEFT OUTER JOIN Employee ON A.EmpID=Employee.EmpID  "
            SQL &=  " LEFT OUTER JOIN Address ON A.AddressID=Address.AddressID  "
            SQL &=  " WHERE A.IsDelete =0   "
            If TableName <> "" And TableName <> "0" Then
                SQL &=  "  AND A.CustomerType='" & TableName & "'"
            End If

            If pID > 0 Then
                SQL &=  "  AND A.CustomerID=" & pID
            End If
            If pOnlyActive = True Then
                SQL &=  "  AND A.IsInActive= 0"
            End If
            If gViewLevel = eViewLevel.Group Then
                SQL &=  "  AND A.TerritoryID=" & gTerritoryID
            ElseIf gViewLevel = eViewLevel.OnlyOwner Then
                SQL &=  "  AND A.EmpID=" & gEmpID
            End If

            If mTableID = MasterType.Accounts Or mTableID = MasterType.Contacts Or mTableID = MasterType.Agency Then
                SQL &=  " ORDER BY A.CustomerCode"
            ElseIf mTableID = MasterType.Lead Then
                SQL &=  " ORDER BY A.Subject"
            End If

            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "CustomerDAO.GetDataTable : " & e.Message)
        End Try
        Return dataTable
    End Function

    Public Function GetDataTableForCombo(ByVal pOnlyActive As Boolean, ByVal pSelectBoth As Boolean, ByVal pCus_Agency As Boolean) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT A.CustomerID AS ID,A.CustomerCode AS Code"
            If pCus_Agency = True Then
                SQL &=  " ,case when A.CompanyName='' then A.Title + A.Firstname + ' ' + A.LastName else A.CompanyName end CusName"
                SQL &=  " ,CustomerType AS Type "
            ElseIf pSelectBoth = False Then
                Select Case mTableID
                    Case MasterType.Accounts, MasterType.Agency
                        SQL &=  " ,A.CompanyName AS CusName"
                    Case MasterType.Contacts
                        SQL &=  " ,A.Title + A.Firstname + ' ' + A.LastName AS CusName,A.CompanyName"
                End Select

            ElseIf pSelectBoth = True Then
                SQL &=  " ,case when A.CompanyName='' then A.Title + A.Firstname + ' ' + A.LastName else A.CompanyName end CusName"
                If mTableID = MasterType.Accounts Or mTableID = MasterType.Contacts Then
                    SQL &= " ,CustomerType AS Type "
                ElseIf mTableID = MasterType.Agency Then
                    SQL &=  " ,'เจ้าหนี้' AS Type"
                End If
            End If
            SQL &=  " ,Address.Phone1,Address.Fax,Address.Email1 "
            SQL &=  " ,Employee.Title + Employee.Firstname + ' ' + Employee.LastName AS EMPNAME "
            SQL &=  " FROM Customer A"
            SQL &=  " LEFT OUTER JOIN Employee ON A.EmpID=Employee.EmpID  "
            SQL &=  " LEFT OUTER JOIN Address ON A.AddressID=Address.AddressID  "
            SQL &=  " WHERE A.IsDelete =0   "
            If pOnlyActive = True Then
                SQL &=  "  AND A.IsInActive= 0"
            End If
            If pCus_Agency = True Then
                SQL &=  " AND A.CustomerType in('Contacts','Accounts','Agency')"
            ElseIf pSelectBoth = True Then
                If mTableID = MasterType.Accounts Or mTableID = MasterType.Contacts Then
                    SQL &= " AND A.CustomerType in('Contacts','Accounts')"
                ElseIf mTableID = MasterType.Agency Then
                    SQL &=  " AND A.CustomerType in('Agency')"
                End If
            Else
                SQL &=  " AND A.CustomerType in('" & TableName & "')"
            End If

            If gViewLevel = eViewLevel.Group Then
                SQL &=  "  AND A.TerritoryID=" & gTerritoryID
            ElseIf gViewLevel = eViewLevel.OnlyOwner Then
                SQL &=  "  AND A.EmpID=" & gEmpID
            End If
            SQL &=  " ORDER BY Code "
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "CustomerDAO.GetDataTableForCombo : " & e.Message)
        End Try
        Return dataTable
    End Function

    Public Overrides Function SaveData(Optional ByRef ptr As SqlTransaction = Nothing) As Boolean
        Dim SQL As String
        Dim llngAddressID As Long = 0, llngHistoryID As Long = 0, llngAddressShipID As Long = 0
        Dim myCommand As SqlCommand
        Dim tr As SqlTransaction = Nothing

        SQL = ""
        Try
            If ptr Is Nothing Then
                tr = gConnection.Connection.BeginTransaction
            Else
                tr = ptr
            End If


            llngAddressID = SaveAddress(AddressS, ModeData, tr)
            llngAddressShipID = SaveAddress(AddressShip, ModeData, tr)

            'History 
            If HistoryDAO Is Nothing Then
                HistoryDAO = New HistoryDAO
            Else
                HistoryDAO.ModeData = ModeData
                HistoryDAO.SaveData(tr)
                llngHistoryID = HistoryDAO.ID
            End If

            Select Case ModeData
                Case DataMode.ModeNew
                    If EmpID = 0 Then
                        EmpID = gEmpID
                    End If
                    LeadStatus = "New"
                    ID = GenNewID("CustomerID", "Customer", tr)
                    SQL = " INSERT INTO Customer (CustomerID,CustomerCode,Remark "
                    SQL &=  " ,Rating,DecisionMakerID,ContactRole,NoOfEmployee,AnnualRevenue "
                    SQL &=  " ,HistoryID,SourceID,LeadID,IndustryTypeID,BusinessTypeID "
                    SQL &=  " ,EstimatedBudjet,IsHoldButget,CreditAmount,BuyingTimeFrame,CreditRuleID,CurrencyID ,VatTypeID,BillDay,BillDayTo,ChqDay,ChqDayTo"
                    SQL &=  " ,IsQuick,TerritoryID,AddressID,AddressIDShip,EmpID,CriterionPriceID,CompanyTypeID,CompanyRelateID"
                    SQL &=  " ,CreateBy,CreateTime,IsInActive,IsDelete,CustomerZoneID,SendBy,CreditGroupID "
                    SQL &=  " ,Title,Firstname,LastName,CompanyName,Position,Subject,LeadType,LeadStatus,DisqualifyStatus"
                    SQL &=  " ,RelateAccountID,IsConvert,Capital,CustomerType,ContactPersonID,CustomerGroupID,IsCorporation,Branch,ImportTXID,IsMainCompany"
                    SQL &=  " ,BankAccountID1,BankAccountID2,BankAccountID3"
                    SQL &=  " )"
                    SQL &=  " VALUES ( @mIDs"
                    SQL &=  " ,  @CustomerCode"
                    SQL &=  " ,  @Remark"
                    SQL &=  " ,  @Rating"
                    SQL &=  " ,  @DecisionMakerID"
                    SQL &=  " ,  @ContactRole"
                    SQL &=  " ,  @NoOfEmployee"
                    SQL &=  " ,  @AnnualRevenue"
                    SQL &=  " ,  @HistoryID"
                    SQL &=  " ,  @SourceID"
                    SQL &=  " ,  @LeadID"
                    SQL &=  " ,  @IndustryTypeID"
                    SQL &=  " ,  @BusinessTypeID"
                    SQL &=  " ,  @EstimatedBudjet"
                    SQL &=  " ,  @IsHoldButget"
                    SQL &=  " ,  @CreditAmount"
                    SQL &=  " ,  @BuyingTimeFrame"
                    SQL &=  " ,  @CreditRuleID"
                    SQL &=  " ,  @CurrencyID"
                    SQL &=  " ,  @VatTypeID"
                    SQL &=  " ,  @BillDay"
                    SQL &=  " ,  @BillDayTo"
                    SQL &=  " ,  @ChqDay"
                    SQL &=  " ,  @ChqDayTo"
                    SQL &=  " ,  @IsQuick"
                    SQL &=  " ,  @TerritoryID"
                    SQL &=  " ,  @AddressID"
                    SQL &=  " ,  @AddressIDShip "
                    SQL &=  " ,  @EmpID"
                    SQL &=  " ,  @CriterionPriceID"
                    SQL &=  " ,  @CompanyTypeID"
                    SQL &=  " ,  @CompanyRelateID"
                    SQL &=  " ,  @gUserID"
                    SQL &=  " ,  @CreateTime"
                    SQL &=  " ,  @IsInActive"
                    SQL &=  " ,  @IsDelete"
                    SQL &=  " ,  @CustomerZoneID"
                    SQL &=  " ,  @SendBy"
                    SQL &=  " ,  @CreditGroupID"
                    SQL &=  " ,  @Title"
                    SQL &=  " ,  @FirstName"
                    SQL &=  " ,  @LastName"
                    SQL &=  " ,  @CompanyName"
                    SQL &=  " ,  @Position"
                    SQL &=  " ,  @mSubject"
                    SQL &=  " ,  @LeadType"
                    SQL &=  " ,  @LeadStatus"
                    SQL &=  " ,  @DisqualifyStatus"
                    SQL &=  " ,  @RelateAccountID"
                    SQL &=  " ,  @IsConvert"
                    SQL &=  " ,  @Capital"
                    SQL &=  " ,  @CustomerType"
                    SQL &=  " ,  @ContactPersonID"
                    SQL &=  " ,  @CustomerGroupID"
                    SQL &=  " ,  @IsCorporation"
                    SQL &=  " ,  @Branch"
                    SQL &=  " ,  @ImportTXID"
                    SQL &=  " ,  @IsMainCompany"
                    SQL &=  " ,  @BankAccountID1,@BankAccountID2,@BankAccountID3"
                    SQL &=  " ) "
                Case DataMode.ModeEdit
                    SQL = " UPDATE Customer"
                    SQL &=  " SET CustomerCode=@CustomerCode"
                    SQL &=  " ,Rating=@Rating"
                    SQL &=  " ,DecisionMakerID=@DecisionMakerID"
                    SQL &=  " ,CompanyName=@CompanyName"
                    SQL &=  " ,NoOfEmployee=@NoOfEmployee"
                    SQL &=  " ,AnnualRevenue=@AnnualRevenue"
                    SQL &=  " ,Remark= @Remark"
                    SQL &=  " ,ContactRole=@ContactRole"
                    SQL &=  " ,SourceID=@SourceID "
                    SQL &=  " ,LeadID=@LeadID "
                    SQL &=  " ,IndustryTypeID=@IndustryTypeID "
                    SQL &=  " ,BusinessTypeID=@BusinessTypeID "
                    SQL &=  " ,EstimatedBudjet=@EstimatedBudjet "
                    SQL &=  " ,IsHoldButget=@IsHoldButget "
                    SQL &=  " ,CreditAmount=@CreditAmount "
                    SQL &=  " ,BuyingTimeFrame=@BuyingTimeFrame "
                    SQL &=  " ,CreditRuleID=@CreditRuleID "
                    SQL &=  " ,CurrencyID=@CurrencyID "
                    SQL &=  " ,TerritoryID=@TerritoryID "
                    SQL &=  " ,EmpID=@EmpID "
                    SQL &=  " ,CriterionPriceID=@CriterionPriceID "
                    SQL &=  " ,CompanyTypeID=@CompanyTypeID "
                    SQL &=  " ,CompanyRelateID=@CompanyRelateID "
                    SQL &=  " ,ModifiedBy= @gUserID"
                    SQL &=  " ,ModifiedTime= @CreateTime"
                    SQL &=  " ,IsInActive= @IsInActive"
                    SQL &=  " ,VatTypeID=@VatTypeID "
                    SQL &=  " ,BillDay=@BillDay "
                    SQL &=  " ,BillDayTo=@BillDayTo "
                    SQL &=  " ,ChqDay=@ChqDay "
                    SQL &=  " ,ChqDayTo=@ChqDayTo "
                    SQL &=  " ,CustomerZoneID=@CustomerZoneID "
                    SQL &=  " ,SendBy=@SendBy "
                    SQL &=  " ,CreditGroupID=@CreditGroupID "
                    SQL &=  " ,Title=@Title"
                    SQL &=  " ,Firstname=@FirstName"
                    SQL &=  " ,LastName=@LastName"
                    SQL &=  " ,Position=@Position"
                    SQL &=  " ,Subject=@mSubject"
                    SQL &=  " ,LeadType=@LeadType"
                    SQL &=  " ,DisqualifyStatus= @DisqualifyStatus"
                    SQL &=  " ,RelateAccountID= @RelateAccountID"
                    SQL &=  " ,Capital= @Capital"
                    SQL &=  " ,LeadStatus= @LeadStatus"
                    SQL &=  " ,ContactPersonID= @ContactPersonID"
                    SQL &=  " ,CustomerGroupID= @CustomerGroupID"
                    SQL &=  " ,IsCorporation= @IsCorporation"
                    SQL &=  " ,Branch= @Branch"
                    SQL &=  " ,IsMainCompany= @IsMainCompany"
                    SQL &=  " ,BankAccountID1= @BankAccountID1"
                    SQL &=  " ,BankAccountID2= @BankAccountID2"
                    SQL &=  " ,BankAccountID3= @BankAccountID3"
                    SQL &=  " WHERE CustomerID= @mIDs"
                Case DataMode.ModeDelete
                    SQL = " UPDATE Customer SET IsDelete=@IsDelete "
                    SQL &=  " ,ModifiedBy= @gUserID"
                    SQL &=  " ,ModifiedTime= @CreateTime"
                    SQL &=  " WHERE CustomerID= @mIDs"
            End Select
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@mIDs", ID))
            myCommand.Parameters.Add(New SqlParameter("@CustomerCode", Trim(Code)))
            myCommand.Parameters.Add(New SqlParameter("@Title", Trim(Title)))
            myCommand.Parameters.Add(New SqlParameter("@FirstName", Trim(FirstName)))
            myCommand.Parameters.Add(New SqlParameter("@LastName", Trim(LastName)))
            myCommand.Parameters.Add(New SqlParameter("@Position", Trim(Position)))
            myCommand.Parameters.Add(New SqlParameter("@Rating", Trim(Rating)))
            myCommand.Parameters.Add(New SqlParameter("@ContactPersonID", ConvertNullToZero(ContactPersonID)))
            myCommand.Parameters.Add(New SqlParameter("@DecisionMakerID", ConvertNullToZero(DecisionMakerID)))
            myCommand.Parameters.Add(New SqlParameter("@NoOfEmployee", ConvertNullToZero(NoOfEmployee)))
            myCommand.Parameters.Add(New SqlParameter("@AnnualRevenue", ConvertNullToZero(AnnualRevenue)))
            myCommand.Parameters.Add(New SqlParameter("@CompanyName", Trim(CompanyName)))
            myCommand.Parameters.Add(New SqlParameter("@Remark", Trim(Remark)))
            myCommand.Parameters.Add(New SqlParameter("@ContactRole", Trim(ContactRole)))
            myCommand.Parameters.Add(New SqlParameter("@SourceID", ConvertNullToZero(SourceID)))
            myCommand.Parameters.Add(New SqlParameter("@LeadID", ConvertNullToZero(LeadID)))
            myCommand.Parameters.Add(New SqlParameter("@IndustryTypeID", IndustryTypeID))
            myCommand.Parameters.Add(New SqlParameter("@BusinessTypeID", BusinessTypeID))
            myCommand.Parameters.Add(New SqlParameter("@EstimatedBudjet", ConvertNullToZero(EstimatedBudjet)))
            myCommand.Parameters.Add(New SqlParameter("@IsHoldButget", IsHoldButget))
            myCommand.Parameters.Add(New SqlParameter("@CreditAmount", ConvertNullToZero(CreditAmount)))
            myCommand.Parameters.Add(New SqlParameter("@BuyingTimeFrame", ConvertNullToZero(BuyingTimeFrame)))
            myCommand.Parameters.Add(New SqlParameter("@CreditRuleID", ConvertNullToZero(CreditRuleID)))
            myCommand.Parameters.Add(New SqlParameter("@CurrencyID", ConvertNullToZero(CurrencyID)))
            myCommand.Parameters.Add(New SqlParameter("@IsQuick", ConvertNullToString(IsQuick)))
            myCommand.Parameters.Add(New SqlParameter("@CompanyRelateID", ConvertNullToZero(CompanyRelateID)))
            myCommand.Parameters.Add(New SqlParameter("@CompanyTypeID", ConvertNullToZero(CompanyTypeID)))
            myCommand.Parameters.Add(New SqlParameter("@TerritoryID", TerritoryID))
            myCommand.Parameters.Add(New SqlParameter("@AddressID", llngAddressID))
            myCommand.Parameters.Add(New SqlParameter("@AddressIDShip", ConvertNullToZero(llngAddressShipID)))
            myCommand.Parameters.Add(New SqlParameter("@EmpID", EmpID))
            myCommand.Parameters.Add(New SqlParameter("@CriterionPriceID", CriterionPriceID))
            myCommand.Parameters.Add(New SqlParameter("@gUserID", gUserID))
            myCommand.Parameters.Add(New SqlParameter("@CreateTime", formatSQLDateTime(GetCurrentDate(tr))))
            myCommand.Parameters.Add(New SqlParameter("@IsInActive", IsInActive))
            myCommand.Parameters.Add(New SqlParameter("@HistoryID", llngHistoryID))
            myCommand.Parameters.Add(New SqlParameter("@VatTypeID", ConvertNullToZero(VatTypeID)))
            myCommand.Parameters.Add(New SqlParameter("@BillDay", ConvertNullToZero(BillDay)))
            myCommand.Parameters.Add(New SqlParameter("@ChqDay", ConvertNullToZero(ChqDay)))
            myCommand.Parameters.Add(New SqlParameter("@BillDayTo", ConvertNullToZero(BillDayTo)))
            myCommand.Parameters.Add(New SqlParameter("@ChqDayTo", ConvertNullToZero(ChqDayTo)))
            myCommand.Parameters.Add(New SqlParameter("@CustomerZoneID", ConvertNullToZero(CustomerZoneID)))
            myCommand.Parameters.Add(New SqlParameter("@SendBy", ConvertNullToString(SendBy)))
            myCommand.Parameters.Add(New SqlParameter("@CreditGroupID", ConvertNullToZero(CreditGroupID)))
            myCommand.Parameters.Add(New SqlParameter("@mSubject", Trim(Subject)))
            myCommand.Parameters.Add(New SqlParameter("@LeadType", Trim(LeadType)))
            myCommand.Parameters.Add(New SqlParameter("@LeadStatus", LeadStatus))
            myCommand.Parameters.Add(New SqlParameter("@DisqualifyStatus", DisqualifyStatus))
            myCommand.Parameters.Add(New SqlParameter("@EsttablishedDate", formatSQLDate(EsttablishedDate)))
            myCommand.Parameters.Add(New SqlParameter("@RelateAccountID", RelateAccountID))
            myCommand.Parameters.Add(New SqlParameter("@IsConvert", ConvertNullToString(IsConvert)))
            myCommand.Parameters.Add(New SqlParameter("@Capital", ConvertNullToZero(Capital)))
            myCommand.Parameters.Add(New SqlParameter("@CustomerType", ConvertNullToString(TableName)))
            myCommand.Parameters.Add(New SqlParameter("@CustomerGroupID", ConvertNullToZero(CustomerGroupID)))
            myCommand.Parameters.Add(New SqlParameter("@IsCorporation", ConvertNullToZero(IsCorporation)))
            myCommand.Parameters.Add(New SqlParameter("@Branch", ConvertNullToString(Branch)))
            myCommand.Parameters.Add(New SqlParameter("@ImportTXID", ConvertNullToZero(ImportTXID)))
            myCommand.Parameters.Add(New SqlParameter("@IsMainCompany", ConvertNullToZero(IsMainCompany)))
            myCommand.Parameters.Add(New SqlParameter("@BankAccountID1", ConvertNullToZero(BankAccountID1)))
            myCommand.Parameters.Add(New SqlParameter("@BankAccountID2", ConvertNullToZero(BankAccountID2)))
            myCommand.Parameters.Add(New SqlParameter("@BankAccountID3", ConvertNullToZero(BankAccountID3)))
            Select Case ModeData
                Case DataMode.ModeNew
                    myCommand.Parameters.Add(New SqlParameter("@IsDelete", 0))
                Case DataMode.ModeDelete
                    myCommand.Parameters.Add(New SqlParameter("@IsDelete", 1))
            End Select

            gConnection.executeInsertSqlCommand(myCommand, tr)

            SaveNote(NoteDAOs, ModeData, ID, TableName, tr)
            SaveAttachFile(FileAttachs, ModeData, ID, TableName, tr)

            If TableID = MasterType.Lead And ModeData <> DataMode.ModeDelete Then
                Dim lclsOrder As New OrderSDAO
                lclsOrder.TableID = 0
                lclsOrder.SaveProductList(ProductDAOs, ModeData, ID, TableName, tr)
            End If

            If ModeData = DataMode.ModeNew Then
                UpdateLastID(TableID, tr)
                'UpdateMaxID(ID, "Account", tr)
                If LeadID > 0 Then
                    UpdateLaedStatus(LeadID, "Qualified", tr)
                End If
            End If
            If ptr Is Nothing Then tr.Commit()
            Return True
        Catch e As Exception
            tr.Rollback()
            Err.Raise(Err.Number, e.Source, "CustomerDAO.SaveData : " & e.Message)
            Return False
        End Try

    End Function

    Public Function CheckExist() As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT CustomerID  FROM Customer"
            If TableID = MasterType.Lead Then
                SQL &=  " WHERE IsDelete=0 AND Subject='" & Trim(Code) & "'"
            Else
                SQL &=  " WHERE IsDelete=0 AND CustomerCode='" & Trim(Code) & "'"
            End If

            If ModeData = DataMode.ModeEdit Then
                SQL &=  " AND CustomerID <> " & ID
            End If
            SQL &=  " AND CustomerType='" & TableName & "' ;"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            Return dataTable.Rows.Count > 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "CustomerDAO.CheckExist : " & e.Message)
            Return False
        Finally
            dataTable = Nothing
        End Try

    End Function

    Public Function CheckIsToUse() As Boolean ''ไม่ถูกใช้งานอยู่ ???
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT CustomerID  FROM Orders"
            SQL &=  " WHERE IsDelete =0  "
            SQL &=  " and CustomerID=" & ID
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            If dataTable.Rows.Count > 0 Then
                Return True
            End If

            SQL = "SELECT CustomerID  FROM CustomerList"
            SQL &=  " WHERE IsDelete =0  "
            SQL &=  " and CustomerID=" & ID
            dataTable = New DataTable()
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            If dataTable.Rows.Count > 0 Then
                Return True
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "CustomerDAO.CheckNotExist : " & e.Message)
        Finally
            dataTable = Nothing
        End Try
    End Function

    Public Sub New()
        mIndustryTypeID = 0
        mBusinessTypeID = 0
        mEstimatedBudjet = 0
        mEmpID = 0
        mBuyingTimeFrame = 0
        mIsQuick = "No"
        mContactRole = ""
        mIsHoldButget = False
        mCurrencyID = 1
        mLeadStatus = ""
        mLeadType = ""
        mclsLeadDAO = Nothing
        mclsEmployee = Nothing
        mRating = ""
        mNoOfEmployee = 0
        mAnnualRevenue = 0
        mContactPersonID = 0

        mDecisionMakerID = 0
        mclsDecisionMaker_Con = Nothing
        mCompanyRelateID = 0
        mCompanyTypeID = 0
        mDisqualifyStatus = ""
        mRelateAccountID = 0
        mSubject = ""
        mIsConvert = "No"
        mCapital = 0
        mBranch = ""
        mBankAccountID1 = 0
        mBankAccountID2 = 0
        mBankAccountID3 = 0
    End Sub
End Class
