Option Explicit On
Imports System.Data.SqlClient
Public Class CampaignDAO
    Inherits iOrder

#Region "Property"

    Private mSubject As String = ""
    Dim mBudget As Decimal = 0
    Dim mMinimumAmount As Decimal = 0
    Dim mStartDate As Date
    Dim mCampaignType As Integer = 0
    Dim mEvaluateBy As Integer = 0
    Dim mCampaignStatus As Integer = 0
    Dim mStatusDesc As String = ""
    Dim mEmployeeListDAO As List(Of EmployeeListDAO)
    Dim mCustomerList As List(Of CustomerListDAO)
    Dim mMinimumUnit As Long = 0
    Dim mCpTypeCont1 As Decimal = 0
    Dim mCpTypeCont2 As Decimal = 0
    Dim mCpTypeCont3_1 As Decimal = 0
    Dim mCpTypeCont3_2 As Decimal = 0
    Dim mProductAddDAOs As List(Of ProductListDAO)
    Dim mEvaluateTarget As Decimal = 0


    Public Overrides ReadOnly Property TableName() As String
        Get
            Return "Campaign"
        End Get
    End Property

    Public Property Subject() As String
        Get
            Return mSubject
        End Get
        Set(ByVal value As String)
            mSubject = value
        End Set
    End Property

    Public Property Budget() As Decimal
        Get
            Return mBudget
        End Get
        Set(ByVal value As Decimal)
            mBudget = value
        End Set
    End Property
     
    Public Property MinimumAmount() As Decimal
        Get
            Return mMinimumAmount
        End Get
        Set(ByVal value As Decimal)
            mMinimumAmount = value
        End Set
    End Property
   
    Public Property MinimumUnit() As Long
        Get
            Return mMinimumUnit
        End Get
        Set(ByVal value As Long)
            mMinimumUnit = value
        End Set
    End Property

    Public Property CpTypeCont1() As Decimal
        Get
            Return mCpTypeCont1
        End Get
        Set(ByVal value As Decimal)
            mCpTypeCont1 = value
        End Set
    End Property

    Public Property CpTypeCont2() As Decimal
        Get
            Return mCpTypeCont2
        End Get
        Set(ByVal value As Decimal)
            mCpTypeCont2 = value
        End Set
    End Property
    Public Property CpTypeCont3_1() As Decimal
        Get
            Return mCpTypeCont3_1
        End Get
        Set(ByVal value As Decimal)
            mCpTypeCont3_1 = value
        End Set
    End Property
    Public Property CpTypeCont3_2() As Decimal
        Get
            Return mCpTypeCont3_2
        End Get
        Set(ByVal value As Decimal)
            mCpTypeCont3_2 = value
        End Set
    End Property

    Public Property StartDate() As Date
        Get
            Return mStartDate
        End Get
        Set(ByVal value As Date)
            mStartDate = value
        End Set
    End Property
     

    Public Property CampaignType() As Integer
        Get
            Return mCampaignType
        End Get
        Set(ByVal value As Integer)
            mCampaignType = value
        End Set
    End Property
    Public Property EvaluateBy() As Integer
        Get
            Return mEvaluateBy
        End Get
        Set(ByVal value As Integer)
            mEvaluateBy = value
        End Set
    End Property
    Public Property EvaluateTarget() As Decimal
        Get
            Return mEvaluateTarget
        End Get
        Set(ByVal value As Decimal)
            mEvaluateTarget = value
        End Set
    End Property
    Public Property CampaignStatus() As Integer
        Get
            Return mCampaignStatus
        End Get
        Set(ByVal value As Integer)
            mCampaignStatus = value
        End Set
    End Property

    Public Property StatusDesc() As String
        Get
            Return mStatusDesc
        End Get
        Set(ByVal value As String)
            mStatusDesc = value
        End Set

    End Property

    Public Property ProductAddDAOs() As List(Of ProductListDAO)
        Get
            Return mProductAddDAOs
        End Get
        Set(ByVal Value As List(Of ProductListDAO))
            mProductAddDAOs = Value
        End Set
    End Property

    Public Property EmployeeList() As List(Of EmployeeListDAO)
        Get
            Return mEmployeeListDAO
        End Get
        Set(ByVal Value As List(Of EmployeeListDAO))
            mEmployeeListDAO = Value
        End Set
    End Property

    Public Property CustomerList() As List(Of CustomerListDAO)
        Get
            Return mCustomerList
        End Get
        Set(ByVal Value As List(Of CustomerListDAO))
            mCustomerList = Value
        End Set
    End Property


#End Region

    Public Function CHECKSUM_AGG() As Long
        Dim SQL As String
        Dim dataTable As New DataTable()
        Try
            SQL = "SELECT CHECKSUM_AGG(BINARY_CHECKSUM(*)) FROM " & TableName & " WITH (NOLOCK);"

            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    Return ConvertNullToZero(dr(0))
                    Exit For
                Next
            End If
            Return 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "CampaignDAO.CHECKSUM_AGG : " & e.Message)
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
            SQL = SQL & " FROM Campaign "
            SQL = SQL & " WHERE 1=1"
            If pID > 0 Then
                SQL = SQL & " and CampaignID=" & pID
            End If
            If pName.Trim <> "" Then
                SQL = SQL & " and Subject='" & pName.Trim & "'"
            End If

            dataTable = gConnection.executeSelectQuery(SQL, tr)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows

                    Subject = ConvertNullToString(dr("Subject"))
                    ID = ConvertNullToZero(dr("CampaignID"))
                    Budget = ConvertNullToZero(dr("Budget"))
                    MinimumAmount = ConvertNullToZero(dr("MinimumAmount"))
                    MinimumUnit = ConvertNullToZero(dr("MinimumUnit"))
                    CpTypeCont1 = ConvertNullToZero(dr("CpTypeCont1"))
                    CpTypeCont2 = ConvertNullToZero(dr("CpTypeCont2"))
                    CpTypeCont3_1 = ConvertNullToZero(dr("CpTypeCont3_1"))
                    CpTypeCont3_2 = ConvertNullToZero(dr("CpTypeCont3_2"))
                    CampaignType = ConvertNullToZero(dr("CampaignType"))
                    EvaluateBy = ConvertNullToZero(dr("EvaluateBy"))
                    EvaluateTarget = ConvertNullToZero(dr("EvaluateTarget"))
                    CampaignStatus = ConvertNullToZero(dr("CampaignStatus"))
                    StatusDesc = ConvertNullToString(dr("StatusDesc"))
                    If IsDBNull(dr("StartDate")) Then
                        StartDate = GetCurrentDate(tr)
                    Else
                        StartDate = dr("StartDate")
                    End If
                    If IsDBNull(dr("ExpireDate")) Then
                        ExpireDate = GetCurrentDate(tr)
                    Else
                        ExpireDate = dr("ExpireDate")
                    End If
                     
                    Remark = ConvertNullToString(dr("Remark"))
                     
                    IsInActive = dr("IsInActive")
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
                    'Load FileAttach
                    FileAttachs = LoadFileAttach(ID, TableName, tr)

                    Return True
                    Exit For
                Next
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "CampaignDAO.InitailData : " & e.Message)
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
        '    Err.Raise(Err.Number, e.Source, "CampaignDAO.GetInfoHtml : " & e.Message)

        'End Try
        Return Info
    End Function


    Public Function GetDataTable(ByVal pID As Long, ByVal pOnlyActive As Boolean) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT CampaignID,Subject  "
            SQL = SQL & "  , StartDate, ExpireDate,Case when CampaignStatus=3 then 'Fail' when CampaignStatus=2 then 'Success' else 'Open' end CampaignStatus "
            SQL = SQL & " ,case when EvaluateBy=1 then 'จำนวนลูกค้า'  when EvaluateBy=2 then 'ยอดขาย' else 'กำไร' end  EvaluateBy"
            SQL = SQL & " ,Budget,EvaluateTarget,IsDelete"
            SQL = SQL & " FROM Campaign  "
            SQL = SQL & " WHERE 0=0   "
            If pID > 0 Then
                SQL = SQL & "  AND Campaign.CampaignID=" & pID
            End If
            If pOnlyActive = True Then
                SQL = SQL & " AND Campaign.IsDelete =0   "
                SQL = SQL & " AND Campaign.IsInActive = 0"
            End If
            
            SQL = SQL & " ORDER BY Campaign.CampaignID"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "CampaignDAO.GetDataTable : " & e.Message)
        End Try
        Return dataTable
    End Function


    Public Function GetDataTableCombo(ByVal pID As Long, ByVal pOnlyActive As Boolean, ByVal pStartDate As Date, ByVal pExpireDate As Date, ByVal pLoadAll As Boolean) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT Campaign.CampaignID,Campaign.Subject  "
            SQL = SQL & "  , StartDate, ExpireDate,Case when CampaignStatus=3 then 'Fail' when CampaignStatus=2 then 'Success' else 'Open' end CampaignStatus "
            SQL = SQL & " FROM Campaign  "
            SQL = SQL & " WHERE Campaign.IsDelete =0   "
            If pID > 0 Then
                SQL = SQL & "  AND Campaign.CampaignID=" & pID
            End If
            If pOnlyActive = True And pLoadAll = False Then
                SQL = SQL & "  AND Campaign.IsInActive = 0"
            End If
            If pLoadAll = False Then
                SQL = SQL & "  AND Campaign.StartDate <= '" & formatSQLDate(pStartDate) & "'"
                SQL = SQL & "  AND Campaign.ExpireDate >= '" & formatSQLDate(pExpireDate) & "'"
            End If
        

            SQL = SQL & " ORDER BY Campaign.CampaignID"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "CampaignDAO.GetDataTableCombo : " & e.Message)
        End Try
        Return dataTable
    End Function


    Public Overrides Function SaveData(Optional ByRef ptr As SqlTransaction = Nothing) As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand
        Dim tr As SqlTransaction = Nothing

        SQL = ""
        Try
            tr = gConnection.Connection.BeginTransaction

            Select Case ModeData
                Case DataMode.ModeNew

                    EmpID = gEmpID
                    ID = GenNewID("CampaignID", "Campaign", tr)
                    SQL = " INSERT INTO Campaign (CampaignID,Subject,Budget,MinimumAmount,StartDate ,ExpireDate "
                    SQL = SQL & " ,CampaignType ,EvaluateBy,EvaluateTarget , CampaignStatus,StatusDesc , Remark "
                    SQL = SQL & " ,CreateBy,CreateTime,IsInActive,IsDelete,MinimumUnit,CpTypeCont1,CpTypeCont2,CpTypeCont3_1,CpTypeCont3_2 "
                    SQL = SQL & " )"
                    SQL = SQL & " VALUES ( @IDs"
                    SQL = SQL & " ,  @Subject"
                    SQL = SQL & " ,  @Budget"
                    SQL = SQL & " ,  @MinimumAmount"
                    SQL = SQL & " ,  @StartDate"
                    SQL = SQL & " ,  @ExpireDate"
                    SQL = SQL & " ,  @CampaignType"
                    SQL = SQL & " ,  @EvaluateBy "
                    SQL = SQL & " ,  @EvaluateTarget "
                    SQL = SQL & " ,  @CampaignStatus "
                    SQL = SQL & " ,  @StatusDesc "
                    SQL = SQL & " ,  @Remark "
                    SQL = SQL & " ,  @gUserID"
                    SQL = SQL & " ,  @CreateTime"
                    SQL = SQL & " ,  @IsInActive"
                    SQL = SQL & " ,  @IsDelete"
                    SQL = SQL & " ,  @MinimumUnit"
                    SQL = SQL & " ,  @CpTypeCont1"
                    SQL = SQL & " ,  @CpTypeCont2"
                    SQL = SQL & " ,  @CpTypeCont3_1"
                    SQL = SQL & " ,  @CpTypeCont3_2"
                    SQL = SQL & " ) "
                Case DataMode.ModeEdit
                    SQL = " UPDATE Campaign SET "
                    SQL = SQL & " Subject=@Subject"
                    SQL = SQL & " , Budget=@Budget "
                    SQL = SQL & " , MinimumAmount=@MinimumAmount "
                    SQL = SQL & " , MinimumUnit=@MinimumUnit "
                    SQL = SQL & " , CpTypeCont1=@CpTypeCont1 "
                    SQL = SQL & " , CpTypeCont2=@CpTypeCont2 "
                    SQL = SQL & " , CpTypeCont3_1=@CpTypeCont3_1 "
                    SQL = SQL & " , CpTypeCont3_2=@CpTypeCont3_2 "
                    SQL = SQL & " , StartDate=@StartDate "
                    SQL = SQL & " , ExpireDate=@ExpireDate "
                    SQL = SQL & " , CampaignType=@CampaignType "
                    SQL = SQL & " , EvaluateBy=@EvaluateBy "
                    SQL = SQL & " , EvaluateTarget=@EvaluateTarget "
                    SQL = SQL & " , CampaignStatus=@CampaignStatus "
                    SQL = SQL & " , StatusDesc=@StatusDesc "
                    SQL = SQL & " , Remark=@Remark "
                    SQL = SQL & " ,ModifiedBy= @gUserID"
                    SQL = SQL & " ,ModifiedTime= @CreateTime"
                    SQL = SQL & " ,IsInActive= @IsInActive"
                    SQL = SQL & " WHERE CampaignID= @IDs"
                Case DataMode.ModeDelete
                    SQL = " UPDATE Campaign SET IsDelete=@IsDelete "
                    SQL = SQL & " ,ModifiedBy= @gUserID"
                    SQL = SQL & " ,ModifiedTime= @CreateTime"
                    SQL = SQL & " WHERE CampaignID= @IDs"
            End Select
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@IDs", ID))
            myCommand.Parameters.Add(New SqlParameter("@Subject", Trim(Subject)))
            myCommand.Parameters.Add(New SqlParameter("@Budget", ConvertNullToZero(Budget)))
            myCommand.Parameters.Add(New SqlParameter("@MinimumAmount", ConvertNullToZero(MinimumAmount)))
            myCommand.Parameters.Add(New SqlParameter("@MinimumUnit", ConvertNullToZero(MinimumUnit)))
            myCommand.Parameters.Add(New SqlParameter("@CpTypeCont1", ConvertNullToZero(CpTypeCont1)))
            myCommand.Parameters.Add(New SqlParameter("@CpTypeCont2", ConvertNullToZero(CpTypeCont2)))
            myCommand.Parameters.Add(New SqlParameter("@CpTypeCont3_1", ConvertNullToZero(CpTypeCont3_1)))
            myCommand.Parameters.Add(New SqlParameter("@CpTypeCont3_2", ConvertNullToZero(CpTypeCont3_2)))
            myCommand.Parameters.Add(New SqlParameter("@StartDate", formatSQLDate(StartDate)))
            myCommand.Parameters.Add(New SqlParameter("@ExpireDate", formatSQLDate(ExpireDate)))
            myCommand.Parameters.Add(New SqlParameter("@CampaignType", ConvertNullToZero(CampaignType)))
            myCommand.Parameters.Add(New SqlParameter("@EvaluateBy", ConvertNullToZero(EvaluateBy)))
            myCommand.Parameters.Add(New SqlParameter("@EvaluateTarget", ConvertNullToZero(EvaluateTarget)))
            myCommand.Parameters.Add(New SqlParameter("@CampaignStatus", ConvertNullToZero(CampaignStatus)))
            myCommand.Parameters.Add(New SqlParameter("@StatusDesc", ConvertNullToString(StatusDesc)))
            myCommand.Parameters.Add(New SqlParameter("@Remark", ConvertNullToString(Remark)))
            
            myCommand.Parameters.Add(New SqlParameter("@gUserID", gUserID))
            myCommand.Parameters.Add(New SqlParameter("@CreateTime", formatSQLDateTime(GetCurrentDate(tr))))
            myCommand.Parameters.Add(New SqlParameter("@IsInActive", IsInActive))


            Select Case ModeData
                Case DataMode.ModeNew
                    myCommand.Parameters.Add(New SqlParameter("@IsDelete", 0))
                Case DataMode.ModeDelete
                    myCommand.Parameters.Add(New SqlParameter("@IsDelete", 1))
            End Select

            gConnection.executeInsertSqlCommand(myCommand, tr)

            SaveNote(NoteDAOs, ModeData, ID, TableName, tr)
            SaveEmployeeList(EmployeeList, ModeData, ID, MasterType.Campaign, tr)
            SaveCustomerList(CustomerList, ModeData, ID, MasterType.Campaign, tr)
            SaveAttachFile(FileAttachs, ModeData, ID, TableName, tr)
            If ModeData <> DataMode.ModeDelete Then
                Dim lclsOrder As New OrderSDAO
                lclsOrder.TableID = 0
                lclsOrder.SaveProductList(ProductDAOs, ModeData, ID, TableName, tr)
                lclsOrder.SaveProductList(ProductAddDAOs, ModeData, ID, TableName & "_ProAdd", tr)
            End If
 

            tr.Commit()
            Return True
        Catch e As Exception
            tr.Rollback()
            Err.Raise(Err.Number, e.Source, "CampaignDAO.SaveData : " & e.Message)
            Return False
        End Try

    End Function
     
     
    Public Overrides Function CheckExist() As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT CampaignID  FROM Campaign"
            SQL = SQL & " WHERE IsDelete =0 AND Subject='" & Trim(mSubject) & "'"
            If ModeData = DataMode.ModeEdit Then
                SQL = SQL & " AND CampaignID <> " & ID
            End If
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            Return dataTable.Rows.Count > 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "CampaignDAO.CheckExist : " & e.Message)
            Return False
        Finally
            dataTable = Nothing
        End Try

    End Function

    Public Function CheckIsToUse() As Boolean ''ไม่ถูกใช้งานอยู่ ???
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT CampaignID  FROM Orders"
            SQL = SQL & " WHERE IsDelete =0  "
            SQL = SQL & " and CampaignID=" & ID
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            If dataTable.Rows.Count > 0 Then
                Return True
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "CampaignDAO.CheckIsToUse : " & e.Message)
        Finally
            dataTable = Nothing
        End Try
    End Function

     
End Class
