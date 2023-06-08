Option Explicit On
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class CustomerImport
    Private mClassName As String = "CustomerImport"
    Private mRunningFormatDAO As RunningFormatDAO
    Private mCustomerPropertyS As List(Of CustomerProperty)
    Private mMasterType As MasterType

    Public Property MasterTypes() As Long

        Set(ByVal value As Long)
            mMasterType = value
        End Set
        Get
            Return mMasterType
        End Get
    End Property

    Public Property DataDAOs() As List(Of CustomerProperty)
        Get
            Return mCustomerPropertyS
        End Get
        Set(ByVal Value As List(Of CustomerProperty))
            mCustomerPropertyS = Value
        End Set
    End Property

    Public Function LoadFileToGrid(ByVal pDataTable As DataTable) As String
        Try
            Dim lError As String = "", lErrorList As String = "", lSEQ As Long = 1
            Dim rec As CustomerProperty
            mCustomerPropertyS = New List(Of CustomerProperty)

            If pDataTable.Rows.Count > 0 Then
                For Each dr As DataRow In pDataTable.Rows
                    rec = New CustomerProperty
                    rec.IsSelect = True  '' 0
                    If ConvertNullToString(dr(0)) = "" Then
                        rec.Code = "อัตโนมัติ"
                    Else
                        rec.Code = ConvertNullToString(dr(0))
                    End If
                    rec.MasterTypes = mMasterType
                    rec.Title = ConvertNullToString(dr(1), True, 50)
                    rec.FirstName = ConvertNullToString(dr(2), True, 100)
                    rec.LastName = ConvertNullToString(dr(3), True, 100)
                    rec.NickName = ConvertNullToString(dr(4), True, 50)
                    rec.AddressName = ConvertNullToString(dr(5), True, 50)
                    rec.AddressNo = ConvertNullToString(dr(6), True, 50)
                    rec.GroupNo = ConvertNullToString(dr(7), True, 50)
                    rec.Street = ConvertNullToString(dr(8), True, 50)
                    rec.District = ConvertNullToString(dr(9), True, 50)
                    rec.Amphur = ConvertNullToString(dr(10), True, 50)
                    rec.Province = ConvertNullToString(dr(11), True, 50)
                    rec.PostalCode = ConvertNullToString(dr(13), True, 50)
                    rec.Country = ConvertNullToString(dr(12), True, 50)
                    rec.Phone1 = ConvertNullToString(dr(14), True, 50)
                    rec.Fax = ConvertNullToString(dr(15), True, 50)
                    rec.Email1 = ConvertNullToString(dr(16), True, 50)
                    rec.Website = ConvertNullToString(dr(17), True, 50)
                    rec.IsCorporation = ConvertNullToString(dr(18), True, 50)
                    rec.CustomerGroup = ConvertNullToString(dr(19), True, 50)
                    rec.CustomerZone = ConvertNullToString(dr(20), True, 50)
                    rec.Emp = ConvertNullToString(dr(21), True, 50)
                    rec.CriterionPrice = ConvertNullToString(dr(22), True, 50)
                    rec.ContactPerson = ConvertNullToString(dr(23), True, 50)
                    rec.CreditAmount = ConvertNullToZero(dr(24))
                    rec.CreditRule = ConvertNullToString(dr(25), True, 50)
                    rec.VatType = ConvertNullToString(dr(26), True, 50)
                    rec.Branch = ConvertNullToString(dr(27), True, 50)
                    rec.TaxID = ConvertNullToString(dr(28), True, 50)
                    rec.IsNew = ConvertNullToString(dr(29))
                    lError = GetPropertyError(rec)
                    If lError <> "" Then
                        If lErrorList = "" Then
                            lErrorList = "******** Import Error *********"
                            lErrorList = lErrorList & vbNewLine & " Row : " & lSEQ & lError
                        Else
                            lErrorList = lErrorList & vbNewLine & " Row : " & lSEQ & lError
                        End If
                        rec.IsSelect = False
                    End If
                    lSEQ += 1
                    mCustomerPropertyS.Add(rec)
                Next
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mClassName & ".LoadFileToGrid : " & e.Message)
        End Try
    End Function

    Public Function GetPropertyError(ByVal pData As CustomerProperty) As String
        Dim lError As String = ""
        If String.IsNullOrEmpty(pData.IsNew) Then
            pData.IsNew = "Y" 'Default Y
        ElseIf pData.IsNew.ToString.Trim <> "Y" And pData.IsNew.ToString.Trim <> "N" Then
            lError = lError & vbNewLine & "ข้อมูล IsNew ไม่ถูกต้อง[Y,N]"
        End If

        If String.IsNullOrEmpty(pData.Code) Then
            lError = lError & vbNewLine & "กรุณาระบุข้อมูลรหัส"
        Else
            If pData.IsNew = "Y" Then
                If CheckCodeCheckExist(pData.Code) Then
                    lError = lError & vbNewLine & "รหัสซ้ำ"
                End If
            Else

                If CheckCodeCheckExist(pData.Code) = false Then
                    lError = lError & vbNewLine & "ไม่พบรหัส : " & pData.Code
                End If
            End If
        End If

        If String.IsNullOrEmpty(pData.FirstName) Then
            lError = lError & vbNewLine & "กรุณาระบุชื่อ"
        Else
            If pData.IsNew = "Y" Then

            Else
                pData.CustomerID = CheckNameExist(pData.FirstName)
                If pData.CustomerID = 0 Then
                    lError = lError & vbNewLine & "ไม่พบชื่อ : " & pData.FirstName
                End If
            End If
        End If

        If String.IsNullOrEmpty(pData.IsCorporation) Then
            lError = lError & vbNewLine & "กรุณาระบุข้อมูลนิติบุคคล"
        Else

            If pData.IsCorporation.ToString.Trim <> "Y" And pData.IsCorporation.ToString.Trim <> "N" Then
                lError = lError & vbNewLine & "ข้อมูลไม่ถูกต้อง [Y,N] : " & pData.IsCorporation
            End If

        End If




        If ConvertNullToString(pData.CustomerGroup) <> "" Then
            pData.CustomerGroupID = CheckDataMasterFromCode(pData.CustomerGroup, MasterType.CustomerGroup)
            If pData.CustomerGroupID = 0 Then
                lError = lError & vbNewLine & "ไม่พบกลุ่มลูกค้าในระบบ"
            End If
        Else
            pData.CustomerGroupID = 0
        End If

        If ConvertNullToString(pData.CustomerZone) <> "" Then
            pData.CustomerZoneID = CheckDataMasterFromCode(pData.CustomerZone, MasterType.CustomerZone)
            If pData.CustomerZoneID = 0 Then
                lError = lError & vbNewLine & "ไม่พบเขตลูกค้าในระบบ"
            End If
        Else
            pData.CustomerZoneID = 0
        End If


        If ConvertNullToString(pData.Emp) <> "" Then
            pData.EmpID = CheckEmployee(pData.Emp)
            If pData.EmpID <= 0 Then
                lError = lError & vbNewLine & "ไม่พบพนักงานในระบบ"
            End If
        Else
            pData.EmpID = 0
        End If

        If ConvertNullToString(pData.CriterionPrice) <> "" Then
            pData.CriterionPriceID = CheckDataMasterFromCode(pData.CriterionPrice, MasterType.CriterionPrice)
            If pData.CriterionPriceID = 0 Then
                lError = lError & vbNewLine & "ไม่พบเขตลูกค้าในระบบ"
            End If
        Else
            pData.CriterionPriceID = 0
        End If

        If ConvertNullToString(pData.ContactPerson) <> "" Then
            pData.ContactPersonID = CheckContact(pData.ContactPerson)
            If pData.ContactPersonID <= 0 Then
                lError = lError & vbNewLine & "ไม่พบผู้ติดต่อในระบบ"
            End If
        Else
            pData.ContactPersonID = 0
        End If

        If ConvertNullToString(pData.ContactPerson) <> "" Then
            pData.ContactPersonID = CheckContact(pData.ContactPerson)
            If pData.ContactPersonID <= 0 Then
                lError = lError & vbNewLine & "ไม่พบผู้ติดต่อในระบบ"
            End If
        Else
            pData.ContactPersonID = 0
        End If

        If ConvertNullToString(pData.CreditRule) <> "" Then
            pData.CreditRuleID = CheckCreditRole(pData.CreditRule)
            If pData.CreditRuleID <= 0 Then
                lError = lError & vbNewLine & "ไม่พบเงื่อนไขการชำระเงินในระบบ"
            End If
        Else
            pData.CreditRuleID = 0
        End If

        If ConvertNullToString(pData.VatType) <> "" Then
            pData.VatTypeID = CheckVatType(pData.VatType)
            If pData.VatTypeID <= 0 Then
                lError = lError & vbNewLine & "ไม่พบรูปแบบภาษีในระบบ"
            End If
        Else
            pData.VatTypeID = 0
        End If

        Return lError
    End Function

#Region "Verify"


    Private Function CheckDataMasterFromCode(ByVal pCode As String, ByVal pMasterType As Long) As Long
        Dim lcls As New MasterDAO

        Try
            If lcls.InitailData(0, pMasterType, pCode) Then
                Return lcls.ID
            Else
                Return 0
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mClassName & ".CheckDataMaster : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Function

    Private Function CheckEmployee(ByVal pName As String) As Long
        Dim lcls As New EmployeeDAO

        Try
            If lcls.InitailData(0, pName) Then
                Return lcls.ID
            Else
                Return 0
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mClassName & ".CheckEmployee : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Function

    Private Function CheckContact(ByVal pName As String) As Long
        Dim lcls As New CustomerDAO
        Try
            If lcls.InitailData(0, pName) Then
                Return lcls.ID
            Else
                Return 0
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mClassName & ".CheckContact : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Function

    Private Function CheckCreditRole(ByVal pName As String) As Long
        Dim lcls As New CreditRoleDAO
        Try
            If lcls.InitailData(0, pName) Then
                Return lcls.ID
            Else
                Return 0
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mClassName & ".CheckCreditRole : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Function

    Private Function CheckVatType(ByVal pName As String) As Long
        Dim lcls As New VatTypeDAO
        Try
            If lcls.InitailData(0, pName) Then
                Return lcls.ID
            Else
                Return 0
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mClassName & ".CheckVatType : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Function

    Private Function CheckCodeCheckExist(ByVal pCode As String) As Boolean
        Dim lcls As New CustomerDAO

        Try
            If pCode <> "อัตโนมัติ" Then
                lcls.TableID = mMasterType
                lcls.ModeData = DataMode.ModeNew
                lcls.Code = pCode
                Return lcls.CheckExist()
            Else
                Return False
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mClassName & ".CheckCodeCheckExist : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Function
    Private Function CheckNameExist(ByVal pName As String) As Long
        Dim lcls As New CustomerDAO
        Try
            If lcls.InitailData(0, pName, Nothing) Then
                Return lcls.ID
            Else
                Return 0
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mClassName & ".CheckNameExist : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Function
#End Region
    Public Function ImportData() As Long()
        Dim lRow As Long = 0
        Dim tr As SqlTransaction = Nothing
        Dim lclsLog As New ImportLog
        Dim lImportID As Long
        Dim lCount(1) As Long
        lCount(0) = 0 'All
        lCount(1) = 0 'Success
        Try
            If mCustomerPropertyS.Count > 0 Then
                tr = gConnection.Connection.BeginTransaction

                'Save Import log
                lclsLog.TableID = MasterTypes
                Call lclsLog.SaveData(tr)
                lImportID = lclsLog.ImportTXID

                'Bwegin import
                lCount(0) = mCustomerPropertyS.Count
                For Each clsProperty As CustomerProperty In mCustomerPropertyS
                    If clsProperty.IsSelect = True Then
                        clsProperty.SaveData(tr, lImportID)
                        If clsProperty.IsSelect = True Then
                            lCount(1) = lCount(1) + 1
                        End If
                    End If
                Next
                InsertActivity(DataMode.ModeImport, MasterTypes, "", tr)
                tr.Commit()

            End If
            Return lCount
        Catch e As Exception
            tr.Rollback()
            Err.Raise(Err.Number, e.Source, mClassName & ".ImportData : " & e.Message)
        Finally
        End Try
    End Function


    Public Sub New()
        mRunningFormatDAO = New RunningFormatDAO
        mRunningFormatDAO.InitailData(MasterType.Accounts, Nothing)
    End Sub
End Class


Public Class CustomerProperty
    Private mClassName As String = "CustomerProperty"

#Region "Property"
    Private mCode As String
    Dim mVerifyStep1 As Boolean
    Dim mIsSelect As Boolean
    Dim mTitle As String
    Dim mFirstName As String
    Dim mLastName As String
    Dim mNickName As String
    Dim mAddressName As String
    Dim mAddressNo As String
    Dim mGroupNo As String
    Dim mStreet As String
    Dim mDistrict As String
    Dim mAmphur As String
    Dim mProvince As String
    Dim mPostalCode As String
    Dim mCountry As String
    Dim mPhone1 As String
    Dim mFax As String
    Dim mEmail1 As String
    Dim mWebsite As String
    Dim mIsCorporation As String
    Dim mCustomerGroupID As Long
    Dim mCustomerGroup As String
    Dim mCustomerZoneID As Long
    Dim mCustomerZone As String
    Dim mEmpID As Long
    Dim mEmp As String
    Dim mCriterionPriceID As Long
    Dim mCriterionPrice As String
    Dim mContactPersonID As Long
    Dim mContactPerson As String
    Dim mCreditAmount As Decimal
    Dim mCreditRuleID As Long
    Dim mCreditRule As String
    Dim mVatTypeID As Long
    Dim mVatType As String
    Dim mBranch As String
    Dim mTaxID As String
    Private mMasterType As MasterType
    Dim mIsNew As String
    Dim mCustomerID As Long

    Public Property IsSelect() As Boolean
        Get
            Return mIsSelect
        End Get
        Set(ByVal value As Boolean)
            mIsSelect = value
        End Set
    End Property

    Public Property Code() As String
        Get
            Return mCode
        End Get
        Set(ByVal value As String)
            mCode = value
        End Set
    End Property

    Public Property Title() As String
        Get
            Return mTitle
        End Get
        Set(ByVal value As String)
            mTitle = value
        End Set
    End Property

    Public Property FirstName() As String
        Get
            Return mFirstName
        End Get
        Set(ByVal value As String)
            mFirstName = value
        End Set
    End Property

    Public Property LastName() As String
        Get
            Return mLastName
        End Get
        Set(ByVal value As String)
            mLastName = value
        End Set
    End Property

    Public Property NickName() As String
        Get
            Return mNickName
        End Get
        Set(ByVal value As String)
            mNickName = value
        End Set
    End Property
    Public Property AddressName() As String
        Get
            Return mAddressName
        End Get
        Set(ByVal Value As String)
            mAddressName = Value
        End Set
    End Property

    Public Property AddressNo() As String
        Get
            Return mAddressNo
        End Get
        Set(ByVal Value As String)
            mAddressNo = Value
        End Set

    End Property

    Public Property GroupNo() As String
        Get
            Return mGroupNo
        End Get
        Set(ByVal Value As String)
            mGroupNo = Value
        End Set
    End Property

    Public Property Street() As String
        Get
            Return mStreet
        End Get
        Set(ByVal Value As String)
            mStreet = Value
        End Set
    End Property

    Public Property District() As String
        Get
            Return mDistrict
        End Get
        Set(ByVal Value As String)
            mDistrict = Value
        End Set
    End Property

    Public Property Amphur() As String
        Get
            Return mAmphur
        End Get
        Set(ByVal Value As String)
            mAmphur = Value
        End Set
    End Property

    Public Property Province() As String
        Get
            Return mProvince
        End Get
        Set(ByVal Value As String)
            mProvince = Value
        End Set
    End Property

    Public Property PostalCode() As String
        Get
            Return mPostalCode
        End Get
        Set(ByVal Value As String)
            mPostalCode = Value
        End Set
    End Property

    Public Property Country() As String
        Get
            Return mCountry
        End Get
        Set(ByVal Value As String)
            mCountry = Value
        End Set
    End Property
    Public Property Phone1() As String
        Get
            Return mPhone1
        End Get
        Set(ByVal Value As String)
            mPhone1 = Value
        End Set
    End Property

    Public Property Fax() As String
        Get
            Return mFax
        End Get
        Set(ByVal Value As String)
            mFax = Value
        End Set
    End Property
    Public Property Email1() As String
        Get
            Return mEmail1
        End Get
        Set(ByVal Value As String)
            mEmail1 = Value
        End Set
    End Property
    Public Property Website() As String
        Get
            Return mWebsite
        End Get
        Set(ByVal Value As String)
            mWebsite = Value
        End Set
    End Property

    Public Property IsCorporation() As String
        Get
            Return mIsCorporation
        End Get
        Set(ByVal value As String)
            mIsCorporation = value
        End Set
    End Property

    Public Property CustomerGroup() As String
        Get
            Return mCustomerGroup
        End Get
        Set(ByVal value As String)
            mCustomerGroup = value
        End Set
    End Property
    Public Property CustomerZone() As String
        Get
            Return mCustomerZone
        End Get
        Set(ByVal value As String)
            mCustomerZone = value
        End Set
    End Property

    Public Property Emp() As String
        Get
            Return mEmp
        End Get
        Set(ByVal value As String)
            mEmp = value
        End Set
    End Property
    Public Property CriterionPrice() As String
        Get
            Return mCriterionPrice
        End Get
        Set(ByVal value As String)
            mCriterionPrice = value
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
    Public Property CreditAmount() As Decimal
        Get
            Return mCreditAmount
        End Get
        Set(ByVal value As Decimal)
            mCreditAmount = value
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
    Public Property VatType() As String
        Get
            Return mVatType
        End Get
        Set(ByVal value As String)
            mVatType = value
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

    Public Property TaxID() As String
        Get
            Return mTaxID
        End Get
        Set(ByVal Value As String)
            mTaxID = Value
        End Set
    End Property

    Public Property IsNew() As String
        Get
            Return mIsNew
        End Get
        Set(ByVal value As String)
            mIsNew = value
        End Set

    End Property

    ''Hide
    Public Property CustomerGroupID() As Long
        Get
            Return mCustomerGroupID
        End Get
        Set(ByVal value As Long)
            mCustomerGroupID = value
        End Set
    End Property

    Public Property CustomerZoneID() As Long
        Get
            Return mCustomerZoneID
        End Get
        Set(ByVal value As Long)
            mCustomerZoneID = value
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
    Public Property CriterionPriceID() As Long
        Get
            Return mCriterionPriceID
        End Get
        Set(ByVal value As Long)
            mCriterionPriceID = value
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

    Public Property CreditRuleID() As Long
        Get
            Return mCreditRuleID
        End Get
        Set(ByVal value As Long)
            mCreditRuleID = value
        End Set
    End Property
    Public Property VatTypeID() As Long
        Get
            Return mVatTypeID
        End Get
        Set(ByVal value As Long)
            mVatTypeID = value
        End Set
    End Property
    Private Property VerifyStep1() As Boolean
        Get
            Return mVerifyStep1
        End Get
        Set(ByVal value As Boolean)
            mVerifyStep1 = value
        End Set
    End Property

    Public Property MasterTypes() As Long

        Set(ByVal value As Long)
            mMasterType = value
        End Set
        Get
            Return mMasterType
        End Get
    End Property
    Public Property CustomerID() As Long
        Get
            Return mCustomerID
        End Get
        Set(ByVal value As Long)
            mCustomerID = value
        End Set
    End Property

#End Region







#Region "Save Product"
    Public Sub SaveData(ByRef ptr As SqlTransaction, ByVal pImportID As Long)
        Dim lclsDAO As New CustomerDAO, lSuccess As Boolean
        Try
            If IsNew = "Y" Then
                lclsDAO.ModeData = DataMode.ModeNew
                If Code.Trim = "อัตโนมัติ" Then
                    Code = AutoGenCode(mMasterType, ptr)
                    lclsDAO.AddressS = New AddressDAO
                    lclsDAO.HistoryDAO = New HistoryDAO
                    lSuccess = True
                Else
                    lSuccess = True
                End If
            Else
                lclsDAO.ModeData = DataMode.ModeEdit
                lSuccess = lclsDAO.InitailData(CustomerID, "", ptr)
            End If

            IsSelect = False   'Re verify --> Is success
            If lSuccess = True Then
                lclsDAO.TableID = mMasterType
                lclsDAO.Code = Code
                lclsDAO.CompanyName = FirstName
                lclsDAO.Title = Title
                lclsDAO.FirstName = FirstName
                lclsDAO.LastName = LastName
                lclsDAO.NickName = NickName
                lclsDAO.AddressS.AddressName = AddressName
                lclsDAO.AddressS.AddressNo = AddressNo
                lclsDAO.AddressS.GroupNo = GroupNo
                lclsDAO.AddressS.Street = Street
                lclsDAO.AddressS.District = District
                lclsDAO.AddressS.Amphur = Amphur
                lclsDAO.AddressS.Province = Province
                lclsDAO.AddressS.PostalCode = PostalCode
                lclsDAO.AddressS.Country = Country
                lclsDAO.AddressS.Phone1 = Phone1
                lclsDAO.AddressS.Fax = Fax
                lclsDAO.AddressS.Email1 = Email1
                lclsDAO.AddressS.Website = Website
                lclsDAO.IsCorporation = IIf(IsCorporation = "Y", 1, 0)
                lclsDAO.CustomerGroupID = CustomerGroupID
                lclsDAO.CustomerZoneID = CustomerZoneID
                lclsDAO.EmpID = EmpID
                lclsDAO.CriterionPriceID = CriterionPriceID
                lclsDAO.ContactPersonID = ContactPersonID
                lclsDAO.CreditAmount = CreditAmount
                lclsDAO.CreditRuleID = CreditRuleID
                lclsDAO.VatTypeID = VatTypeID
                lclsDAO.Branch = Branch
                lclsDAO.HistoryDAO.TaxID = TaxID
                lclsDAO.CurrencyID = 1
                lclsDAO.Rating = "Nomal"
                lclsDAO.ImportTXID = pImportID
                IsSelect = lclsDAO.SaveData(ptr)
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mClassName & ".SaveData : " & e.Message)
        Finally
            lclsDAO = Nothing
        End Try
    End Sub

#End Region

    Public Sub New()
        mVerifyStep1 = False
        mIsSelect = True
        mCode = ""
        mTitle = ""
        mFirstName = ""
        mLastName = ""
        mNickName = ""
        mAddressName = ""
        mAddressNo = ""
        mGroupNo = ""
        mStreet = ""
        mDistrict = ""
        mAmphur = ""
        mProvince = ""
        mPostalCode = ""
        mCountry = ""
        mPhone1 = ""
        mFax = ""
        mEmail1 = ""
        mWebsite = ""
        mIsCorporation = ""
        mCustomerGroupID = 0
        mCustomerGroup = ""
        mCustomerZoneID = 0
        mCustomerZone = ""
        mEmpID = 0
        mEmp = ""
        mCriterionPriceID = 0
        mCriterionPrice = ""
        mContactPersonID = 0
        mContactPerson = ""
        mCreditAmount = 0
        mCreditRuleID = 0
        mCreditRule = ""
        mVatTypeID = 0
        mVatType = ""
        mBranch = ""
        mTaxID = ""
        mIsNew = "Y"
        mCustomerID = 0
    End Sub
End Class
