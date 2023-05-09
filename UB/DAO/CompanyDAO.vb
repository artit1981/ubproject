Option Explicit On

Imports System.Data.SqlClient


Public Class CompanyDAO
    Inherits iPerson

#Region "Property"

    Dim mOwner As String
    Dim mTaxID As String
    Dim mTaxType As String
    Dim mTaxRate As Double
    Dim mRegisterDate As Date
    Dim mRegisterNo As String
    Dim mRegisterAsset As Double
    Dim mRegisterNum As Double
    Dim mRegisterCost As Double
    Dim mCommitteeNum As Double
    Dim mCommitteeName As String
    Dim mCheckLimitReserve As Integer
    Dim mCheckLimitSellOrder As Integer
    Dim mIsApproveQua As Integer
    Dim mIsApproveReserve As Integer
    Dim mIsApproveSellOrder As Integer
    Dim mIsApproveOffer As Integer
    Dim mIsApproveBuyOrder As Integer
    Dim llngHistoryID As Long
    Dim mBranch As String
    Dim mBankAccount As String = ""
    Dim mBankAccount2 As String = ""
    Dim mCheckLimitInvoice As Integer = 0
    Dim mCheckLimitShiping As Integer = 0
    Dim mIsApproveInvoice As Integer = 0
    Dim mIsApproveShiping As Integer = 0
    Dim mIsApproveBorrow As Integer = 0
    Dim mUnderLimit As Decimal = 0


    Public ReadOnly Property TableName() As String
        Get
            Return "Company"
        End Get
    End Property
    Public Property Owner() As String
        Get
            Return mOwner
        End Get
        Set(ByVal value As String)
            mOwner = value
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
        Set(ByVal value As String)
            mTaxID = value
        End Set
    End Property
    Public Property TaxType() As String
        Get
            Return mTaxType
        End Get
        Set(ByVal value As String)
            mTaxType = value
        End Set
    End Property
    Public Property TaxRate() As Double
        Get
            Return mTaxRate
        End Get
        Set(ByVal value As Double)
            mTaxRate = value
        End Set
    End Property
    Public Property RegisterDate() As Date
        Get
            Return mRegisterDate
        End Get
        Set(ByVal value As Date)
            mRegisterDate = value
        End Set
    End Property
    Public Property RegisterAsset() As Double
        Get
            Return mRegisterAsset
        End Get
        Set(ByVal value As Double)
            mRegisterAsset = value
        End Set
    End Property
    Public Property RegisterNum() As Double
        Get
            Return mRegisterNum
        End Get
        Set(ByVal value As Double)
            mRegisterNum = value
        End Set
    End Property
    Public Property RegisterCost() As Double
        Get
            Return mRegisterCost
        End Get
        Set(ByVal value As Double)
            mRegisterCost = value
        End Set
    End Property
    Public Property RegisterNo() As String
        Get
            Return mRegisterNo
        End Get
        Set(ByVal value As String)
            mRegisterNo = value
        End Set
    End Property
    Public Property CommitteeNum() As Double
        Get
            Return mCommitteeNum
        End Get
        Set(ByVal value As Double)
            mCommitteeNum = value
        End Set
    End Property
    Public Property CommitteeName() As String
        Get
            Return mCommitteeName
        End Get
        Set(ByVal value As String)
            mCommitteeName = value
        End Set
    End Property
    Public Property CheckLimitReserve() As Integer
        Get
            Return mCheckLimitReserve
        End Get
        Set(ByVal value As Integer)
            mCheckLimitReserve = value
        End Set
    End Property
    Public Property CheckLimitInvoice() As Integer
        Get
            Return mCheckLimitInvoice
        End Get
        Set(ByVal value As Integer)
            mCheckLimitInvoice = value
        End Set
    End Property
    Public Property UnderLimit() As Decimal
        Get
            Return mUnderLimit
        End Get
        Set(ByVal value As Decimal)
            mUnderLimit = value
        End Set
    End Property
    Public Property CheckLimitShiping() As Integer
        Get
            Return mCheckLimitShiping
        End Get
        Set(ByVal value As Integer)
            mCheckLimitShiping = value
        End Set
    End Property
    Public Property CheckLimitSellOrder() As Integer
        Get
            Return mCheckLimitSellOrder
        End Get
        Set(ByVal value As Integer)
            mCheckLimitSellOrder = value
        End Set
    End Property
    Public Property IsApproveQua() As Integer
        Get
            Return mIsApproveQua
        End Get
        Set(ByVal value As Integer)
            mIsApproveQua = value
        End Set
    End Property
    Public Property IsApproveReserve() As Integer
        Get
            Return mIsApproveReserve
        End Get
        Set(ByVal value As Integer)
            mIsApproveReserve = value
        End Set
    End Property
    Public Property IsApproveSellOrder() As Integer
        Get
            Return mIsApproveSellOrder
        End Get
        Set(ByVal value As Integer)
            mIsApproveSellOrder = value
        End Set
    End Property
    Public Property IsApproveOffer() As Integer
        Get
            Return mIsApproveOffer
        End Get
        Set(ByVal value As Integer)
            mIsApproveOffer = value
        End Set
    End Property
    Public Property IsApproveBuyOrder() As Integer
        Get
            Return mIsApproveBuyOrder
        End Get
        Set(ByVal value As Integer)
            mIsApproveBuyOrder = value
        End Set
    End Property
    Public Property IsApproveInvoice() As Integer
        Get
            Return mIsApproveInvoice
        End Get
        Set(ByVal value As Integer)
            mIsApproveInvoice = value
        End Set
    End Property
    Public Property IsApproveShiping() As Integer
        Get
            Return mIsApproveShiping
        End Get
        Set(ByVal value As Integer)
            mIsApproveShiping = value
        End Set
    End Property
    Public Property IsApproveBorrow() As Integer
        Get
            Return mIsApproveBorrow
        End Get
        Set(ByVal value As Integer)
            mIsApproveBorrow = value
        End Set
    End Property

    Public Property BankAccount() As String
        Get
            Return mBankAccount
        End Get
        Set(ByVal value As String)
            mBankAccount = value
        End Set
    End Property
    Public Property BankAccount2() As String
        Get
            Return mBankAccount2
        End Get
        Set(ByVal value As String)
            mBankAccount2 = value
        End Set
    End Property

    Private mShippingNotAssign As DateTime
    Public Property ShippingNotAssign() As DateTime
        Get
            Return mShippingNotAssign
        End Get
        Set(ByVal value As DateTime)
            mShippingNotAssign = value
        End Set

    End Property

    Private mShippingNotSuccess As DateTime
    Public Property ShippingNotSuccess() As DateTime
        Get
            Return mShippingNotSuccess
        End Get
        Set(ByVal value As DateTime)
            mShippingNotSuccess = value
        End Set

    End Property

#End Region

    Public Function CHECKSUM_AGG() As Long
        Dim SQL As String
        Dim dataTable As New DataTable()
        Try
            SQL = "SELECT CHECKSUM_AGG(BINARY_CHECKSUM(*)) FROM Company WITH (NOLOCK);"

            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    Return ConvertNullToZero(dr(0))
                    Exit For
                Next
            End If
            Return 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "CompanyDAO.CHECKSUM_AGG : " & e.Message)
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
            SQL &=  " FROM Company "
            SQL &=  " WHERE CompanyID=" & pID

            dataTable = gConnection.executeSelectQuery(SQL, tr)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    'Company 

                    Owner = ConvertNullToString(dr("Owner"))
                    TaxID = ConvertNullToString(dr("TaxID"))
                    TaxType = ConvertNullToString(dr("TaxType"))
                    TaxRate = ConvertNullToZero(dr("TaxRate"))
                    If IsDBNull(dr("RegisterDate")) Then
                        RegisterDate = GetCurrentDate(tr)
                    Else
                        RegisterDate = dr("RegisterDate")
                    End If
                    RegisterNo = ConvertNullToString(dr("RegisterNo"))
                    RegisterAsset = ConvertNullToZero(dr("RegisterAsset"))
                    RegisterNum = ConvertNullToZero(dr("RegisterNum"))
                    RegisterCost = ConvertNullToZero(dr("RegisterCost"))
                    CommitteeNum = ConvertNullToZero(dr("CommitteeNum"))
                    CommitteeName = ConvertNullToString(dr("CommitteeName"))
                    CheckLimitReserve = ConvertNullToZero(dr("CheckLimitReserve"))
                    CheckLimitSellOrder = ConvertNullToZero(dr("CheckLimitSellOrder"))
                    IsMainCompany = ConvertNullToZero(dr("IsMainCompany"))
                    Branch = ConvertNullToString(dr("Branch"))
                    IsApproveQua = ConvertNullToZero(dr("IsApproveQua"))
                    IsApproveReserve = ConvertNullToZero(dr("IsApproveReserve"))
                    IsApproveSellOrder = ConvertNullToZero(dr("IsApproveSellOrder"))
                    IsApproveOffer = ConvertNullToZero(dr("IsApproveOffer"))
                    IsApproveBuyOrder = ConvertNullToZero(dr("IsApproveBuyOrder"))
                    UnderLimit = ConvertNullToZero(dr("UnderLimit"))
                    IsApproveInvoice = ConvertNullToZero(dr("IsApproveInvoice"))
                    IsApproveShiping = ConvertNullToZero(dr("IsApproveShiping"))
                    IsApproveBorrow = ConvertNullToZero(dr("IsApproveBorrow"))
                    CheckLimitInvoice = ConvertNullToZero(dr("CheckLimitInvoice"))
                    CheckLimitShiping = ConvertNullToZero(dr("CheckLimitShiping"))
                    BankAccount = ConvertNullToString(dr("BankAccount"))
                    BankAccount2 = ConvertNullToString(dr("BankAccount2"))
                    ShippingNotAssign = dr("ShippingNotAssign")
                    ShippingNotSuccess = dr("ShippingNotSuccess")

                    'Person
                    ID = Int32.Parse(dr("CompanyID"))
                    IsInActive = dr("IsInActive")
                    CompanyName = ConvertNullToString(dr("CompanyName"))
                    FirstName = ConvertNullToString(dr("CompanyName"))
                    FirstNameEng = ConvertNullToString(dr("CompanyNameEng"))
                    Remark = dr("Remark").ToString
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

                    'Load AddressDAO
                    AddressS = Nothing
                    AddressS = New AddressDAO
                    AddressS.InitailData(ConvertNullToZero(dr("AddressID")), tr)


                    HistoryDAO = Nothing
                    HistoryDAO = New HistoryDAO
                    HistoryDAO.InitailData(ConvertNullToZero(dr("HistoryID")), tr)

                    'Load FileAttach
                    FileAttachs = LoadFileAttach(ID, TableName, tr)

                    Return True
                    Exit For
                Next
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "CompanyDAO.InitailData : " & e.Message)
            Return False
        Finally
            lUserDAO = Nothing
            dataTable = Nothing
        End Try

    End Function

    Public Function GetInfoHtml() As String
        Dim Info As String = ""
        Try
            'Info &= Constants.vbCrLf & Constants.vbCrLf & "รหัสพนักงาน: " & EmpCode
            'Info &= Constants.vbCrLf & Constants.vbCrLf & "ชื่อ - สกุล: " & Title & FirstName & " " & LastName
            'Info &= Constants.vbCrLf & "ชื่อเล่น: " & NickName
            'If Not PositionDAO Is Nothing Then
            '    Info &= Constants.vbCrLf & "ตำแหน่ง: " & PositionDAO.NameThai
            '    If Not PositionDAO.Department Is Nothing Then
            '        Info &= Constants.vbCrLf & "แผนก: " & PositionDAO.Department.NameThai
            '    End If
            'End If

            'Info &= Constants.vbCrLf & "โทรศัพท์มือถือ: " & AddressS.MobilePhone
            'Info &= Constants.vbCrLf & "เบอร์โทรศัพท์: " & AddressS.Phone1
            'Info &= Constants.vbCrLf & "เบอร์โทรสาร: " & AddressS.Fax
            'Info &= Constants.vbCrLf & "อีเมลล์: " & AddressS.Email1
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "CompanyDAO.GetInfoHtml : " & e.Message)

        End Try
        Return Info
    End Function


    Public Function GetDataTable(ByVal pID As Long, ByVal pOnlyActive As Boolean) As DataTable
        Dim SQL As String = ""
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT Company.CompanyID AS ID,Company.CompanyName,Company.Branch  ,ModifiedTime"
            SQL &=  " FROM Company  "
            SQL &=  " "
            SQL &=  " WHERE Company.IsDelete =0   "
            If pID > 0 Then
                SQL &=  "  AND Company.CompanyID=" & pID
            End If
            If pOnlyActive = True Then
                SQL &=  "  AND Company.IsInActive = 0"
            End If
            SQL &=  " ORDER BY Company.CompanyName,Company.Branch "
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "CompanyDAO.GetDataTable : " & e.Message)
        End Try
        Return dataTable
    End Function



    Public Overrides Function SaveData(Optional ByRef ptr As SqlTransaction = Nothing) As Boolean
        Dim SQL As String
        Dim llngAddressID As Long = 0
        Dim myCommand As SqlCommand
        Dim tr As SqlTransaction = Nothing

        SQL = ""
        Try
            tr = gConnection.Connection.BeginTransaction

            llngAddressID = SaveAddress(AddressS, ModeData, tr)
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
                    ID = GenNewID("CompanyID", TableName, tr)
                    SQL = " INSERT INTO Company  (CompanyID,CompanyName,CompanyNameEng,Owner,TaxID,TaxType "
                    SQL &=  " ,TaxRate,RegisterDate,Remark,RegisterNo,RegisterAsset,RegisterNum,RegisterCost "
                    SQL &=  " ,CommitteeNum,CommitteeName,HistoryID,AddressID,CheckLimitReserve,CheckLimitSellOrder,IsApproveQua "
                    SQL &=  " ,IsApproveReserve,IsApproveSellOrder,IsApproveOffer,IsApproveBuyOrder"
                    SQL &=  " ,CreateBy,CreateTime,IsInActive,IsDelete,IsMainCompany,Branch,BankAccount,BankAccount2   "
                    SQL &= " ,CheckLimitInvoice,CheckLimitShiping,UnderLimit,IsApproveInvoice,IsApproveShiping,IsApproveBorrow"
                    SQL &= " ,ShippingNotAssign,ShippingNotSuccess"
                    SQL &=  " )"
                    SQL &=  " VALUES ( @mIDs"
                    SQL &=  " ,  @CompanyName"
                    SQL &=  " ,  @CompanyNameEng"
                    SQL &=  " ,  @Owner"
                    SQL &=  " ,  @TaxID"
                    SQL &=  " ,  @TaxType"
                    SQL &=  " ,  @TaxRate"
                    SQL &=  " ,  @RegisterDate"
                    SQL &=  " ,  @Remark"
                    SQL &=  " ,  @RegisterNo"
                    SQL &=  " ,  @RegisterAsset "
                    SQL &=  " ,  @RegisterNum "
                    SQL &=  " ,  @RegisterCost "
                    SQL &=  " ,  @CommitteeNum "
                    SQL &=  " ,  @CommitteeName "
                    SQL &=  " ,  @HistoryID "
                    SQL &=  " ,  @AddressID "
                    SQL &=  " ,  @CheckLimitReserve "
                    SQL &=  " ,  @CheckLimitSellOrder "
                    SQL &=  " ,  @IsApproveQua "
                    SQL &=  " ,  @IsApproveReserve "
                    SQL &=  " ,  @IsApproveSellOrder "
                    SQL &=  " ,  @IsApproveOffer "
                    SQL &=  " ,  @IsApproveBuyOrder "
                    SQL &=  " ,  @gUserID"
                    SQL &=  " ,  @CreateTime"
                    SQL &=  " ,  @IsInActive"
                    SQL &=  " ,  @IsDelete"
                    SQL &=  " ,  @IsMainCompany"
                    SQL &=  " ,  @Branch"
                    SQL &=  " ,  @BankAccount"
                    SQL &=  " ,  @BankAccount2"
                    SQL &=  " ,  @CheckLimitInvoice"
                    SQL &=  " ,  @CheckLimitShiping"
                    SQL &=  " ,  @UnderLimit"
                    SQL &=  " ,  @IsApproveInvoice"
                    SQL &=  " ,  @IsApproveShiping"
                    SQL &= " ,  @IsApproveBorrow"
                    SQL &= " ,  @ShippingNotAssign"
                    SQL &= " ,  @ShippingNotSuccess"
                    SQL &=  " ) "
                Case DataMode.ModeEdit
                    SQL = " UPDATE Company SET "
                    SQL &=  " CompanyName=@CompanyName"
                    SQL &=  " ,  CompanyNameEng=@CompanyNameEng"
                    SQL &=  " ,  Owner=@Owner"
                    SQL &=  " ,  TaxID=@TaxID"
                    SQL &=  " ,  TaxType=@TaxType"
                    SQL &=  " ,  TaxRate=@TaxRate"
                    SQL &=  " ,  RegisterDate=@RegisterDate"
                    SQL &=  " ,  Remark=@Remark"
                    SQL &=  " ,  RegisterNo=@RegisterNo"
                    SQL &=  " ,  RegisterAsset=@RegisterAsset "
                    SQL &=  " ,  RegisterNum=@RegisterNum "
                    SQL &=  " ,  RegisterCost=@RegisterCost "
                    SQL &=  " ,  CommitteeNum=@CommitteeNum "
                    SQL &=  " ,  CommitteeName=@CommitteeName "
                    SQL &=  " ,  AddressID=@AddressID "
                    SQL &=  " ,  CheckLimitReserve=@CheckLimitReserve "
                    SQL &=  " ,  CheckLimitSellOrder=@CheckLimitSellOrder "
                    SQL &=  " ,  IsApproveQua=@IsApproveQua "
                    SQL &=  " ,  IsApproveReserve=@IsApproveReserve "
                    SQL &=  " ,  IsApproveOffer=@IsApproveOffer "
                    SQL &=  " ,  IsApproveBuyOrder=@IsApproveBuyOrder "
                    SQL &=  " ,  IsApproveSellOrder=@IsApproveSellOrder "
                    SQL &=  " ,  IsMainCompany=@IsMainCompany "
                    SQL &=  " ,  Branch=@Branch "
                    SQL &=  " ,  BankAccount=@BankAccount "
                    SQL &=  " ,  BankAccount2=@BankAccount2 "
                    SQL &=  " ,  CheckLimitInvoice=@CheckLimitInvoice"
                    SQL &=  " ,  CheckLimitShiping=@CheckLimitShiping"
                    SQL &=  " ,  UnderLimit=@UnderLimit"
                    SQL &=  " ,  IsApproveInvoice=@IsApproveInvoice"
                    SQL &=  " ,  IsApproveShiping=@IsApproveShiping"
                    SQL &= " ,  IsApproveBorrow=@IsApproveBorrow"
                    SQL &= " ,  ShippingNotAssign=@ShippingNotAssign"
                    SQL &= " ,  ShippingNotSuccess=@ShippingNotSuccess"
                    SQL &=  " WHERE CompanyID= @mIDs"
                Case DataMode.ModeDelete
                    SQL = " UPDATE Company SET IsDelete=@IsDelete "
                    SQL &=  " ,ModifiedBy= @gUserID"
                    SQL &=  " ,ModifiedTime= @CreateTime"
                    SQL &=  " WHERE CompanyID= @mIDs"
            End Select
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@mIDs", ID))
            myCommand.Parameters.Add(New SqlParameter("@CompanyName", Trim(FirstName)))
            myCommand.Parameters.Add(New SqlParameter("@RegisterDate", formatSQLDate(RegisterDate)))
            myCommand.Parameters.Add(New SqlParameter("@CompanyNameEng", FirstNameEng))
            myCommand.Parameters.Add(New SqlParameter("@Owner", Trim(Owner)))
            myCommand.Parameters.Add(New SqlParameter("@TaxID", Trim(TaxID)))
            myCommand.Parameters.Add(New SqlParameter("@TaxType", Trim(TaxType)))
            myCommand.Parameters.Add(New SqlParameter("@TaxRate", ConvertNullToZero(TaxRate)))
            myCommand.Parameters.Add(New SqlParameter("@Remark", Trim(Remark)))
            myCommand.Parameters.Add(New SqlParameter("@RegisterNo", Trim(RegisterNo)))
            myCommand.Parameters.Add(New SqlParameter("@RegisterAsset", ConvertNullToZero(RegisterAsset)))
            myCommand.Parameters.Add(New SqlParameter("@RegisterNum", ConvertNullToZero(RegisterNum)))
            myCommand.Parameters.Add(New SqlParameter("@RegisterCost", ConvertNullToZero(RegisterCost)))
            myCommand.Parameters.Add(New SqlParameter("@CommitteeNum", ConvertNullToZero(CommitteeNum)))
            myCommand.Parameters.Add(New SqlParameter("@CommitteeName", Trim(CommitteeName)))
            myCommand.Parameters.Add(New SqlParameter("@HistoryID", llngHistoryID))
            myCommand.Parameters.Add(New SqlParameter("@AddressID", llngAddressID))
            myCommand.Parameters.Add(New SqlParameter("@CheckLimitReserve", ConvertNullToZero(CheckLimitReserve)))
            myCommand.Parameters.Add(New SqlParameter("@CheckLimitSellOrder", ConvertNullToZero(CheckLimitSellOrder)))
            myCommand.Parameters.Add(New SqlParameter("@IsApproveQua", ConvertNullToZero(IsApproveQua)))
            myCommand.Parameters.Add(New SqlParameter("@IsApproveReserve", ConvertNullToZero(IsApproveReserve)))
            myCommand.Parameters.Add(New SqlParameter("@IsApproveOffer", ConvertNullToZero(IsApproveOffer)))
            myCommand.Parameters.Add(New SqlParameter("@IsApproveBuyOrder", ConvertNullToZero(IsApproveBuyOrder)))
            myCommand.Parameters.Add(New SqlParameter("@IsApproveSellOrder", ConvertNullToZero(IsApproveSellOrder)))
            myCommand.Parameters.Add(New SqlParameter("@CheckLimitInvoice", ConvertNullToZero(CheckLimitInvoice)))
            myCommand.Parameters.Add(New SqlParameter("@CheckLimitShiping", ConvertNullToZero(CheckLimitShiping)))
            myCommand.Parameters.Add(New SqlParameter("@UnderLimit", ConvertNullToZero(UnderLimit)))
            myCommand.Parameters.Add(New SqlParameter("@IsApproveInvoice", ConvertNullToZero(IsApproveInvoice)))
            myCommand.Parameters.Add(New SqlParameter("@IsApproveShiping", ConvertNullToZero(IsApproveShiping)))
            myCommand.Parameters.Add(New SqlParameter("@IsApproveBorrow", ConvertNullToZero(IsApproveBorrow)))
            myCommand.Parameters.Add(New SqlParameter("@IsMainCompany", ConvertNullToZero(IsMainCompany)))
            myCommand.Parameters.Add(New SqlParameter("@Branch", ConvertNullToString(Branch)))
            myCommand.Parameters.Add(New SqlParameter("@BankAccount", ConvertNullToString(BankAccount)))
            myCommand.Parameters.Add(New SqlParameter("@BankAccount2", ConvertNullToString(BankAccount2)))
            myCommand.Parameters.Add(New SqlParameter("@gUserID", gUserID))
            myCommand.Parameters.Add(New SqlParameter("@CreateTime", formatSQLDateTime(GetCurrentDate(tr))))
            myCommand.Parameters.Add(New SqlParameter("@IsInActive", IsInActive))
            myCommand.Parameters.Add(New SqlParameter("@ShippingNotAssign", formatSQLDateTime(ShippingNotAssign)))
            myCommand.Parameters.Add(New SqlParameter("@ShippingNotSuccess", formatSQLDateTime(ShippingNotSuccess)))

            Select Case ModeData
                Case DataMode.ModeNew
                    myCommand.Parameters.Add(New SqlParameter("@IsDelete", 0))
                Case DataMode.ModeDelete
                    myCommand.Parameters.Add(New SqlParameter("@IsDelete", 1))
            End Select

            gConnection.executeInsertSqlCommand(myCommand, tr)

            'Save Note
            SaveNote(NoteDAOs, ModeData, ID, TableName, tr)

            'Save Attach file
            SaveAttachFile(FileAttachs, ModeData, ID, TableName, tr)
            If ModeData = DataMode.ModeNew Then
                UpdateLastID(MasterType.Company, tr)
            End If

            tr.Commit()
            Return True
        Catch e As Exception
            tr.Rollback()
            Err.Raise(Err.Number, e.Source, "CompanyDAO.SaveData : " & e.Message)
            Return False
        End Try

    End Function

    Public Function CheckExist() As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT CompanyID  FROM Company"
            SQL &=  " WHERE IsDelete =0 AND CompanyName='" & Trim(FirstName) & "'"
            If ModeData = DataMode.ModeEdit Then
                SQL &=  " AND CompanyID <> " & ID
            End If
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            Return dataTable.Rows.Count > 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "CompanyDAO.CheckExist : " & e.Message)
            Return False
        Finally
            dataTable = Nothing
        End Try

    End Function

    Public Function CheckIsToUse() As Boolean ''ถูกใช้งานอยู่ ???

        'Dim SQL As String
        'Dim dataTable As New DataTable()

        Try
            'SQL = "SELECT LeadID  FROM Lead"
            'SQL = SQL & " WHERE IsDelete =0 AND Subject='" & Trim(mSubject) & "'"
            'If mMode = DataMode.ModeEdit Then
            '    SQL &=  " AND LeadID <> " & mIDs
            'End If
            'dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            'Return dataTable.Rows.Count > 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "CompanyDAO.CheckNotExist : " & e.Message)
        End Try
        Return False
    End Function


    Public Sub New()
        mOwner = ""
        mTaxID = ""
        mTaxType = ""
        mTaxRate = 0
        mRegisterDate = Now
        mRegisterNo = ""
        mRegisterAsset = 0
        mRegisterNum = 0
        mRegisterCost = 0
        mCommitteeNum = 0
        mCommitteeName = ""
        mCheckLimitReserve = 0
        mCheckLimitSellOrder = 0
        mIsApproveQua = 0
        mIsApproveReserve = 0
        mIsApproveSellOrder = 0
        mIsApproveOffer = 0
        mIsApproveBuyOrder = 0
        llngHistoryID = 0
        mBranch = ""
    End Sub
End Class
