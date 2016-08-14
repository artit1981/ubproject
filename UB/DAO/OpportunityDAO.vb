Option Explicit On
Imports System.Data.SqlClient
Public Class OpportunityDAO
    Inherits iOrder

#Region "Property"
    Private mOppContactRoleDAOs As List(Of OppContactRoleDAO)
    Private mSubject As String
    Private mOpportunityTypeID As Long
    Private mOpportunityStageID As Long
    Private mCampaignID As Long
    Private mOppStartDate As Date
    Private mOppExpireDate As Date
    Private mIsSysRevenue As Boolean
    Private mEstimateRevenue As Double
    Private mIsClose As Boolean
    Private mCloseDate As Date
    Private mExpectRevenue As Double
    Private mRealRevenue As Double
    Private mCloseRemark As String
    Dim mCloseResult As Boolean


    Public Overrides ReadOnly Property TableName() As String
        Get
            Return "Opportunity"
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

    Public Property OpportunityTypeID() As Long
        Get
            Return mOpportunityTypeID
        End Get
        Set(ByVal value As Long)
            mOpportunityTypeID = value
        End Set
    End Property

    Public Property OpportunityStageID() As Long
        Get
            Return mOpportunityStageID
        End Get
        Set(ByVal value As Long)
            mOpportunityStageID = value
        End Set
    End Property

    Public Property CampaignID() As Long
        Get
            Return mCampaignID
        End Get
        Set(ByVal value As Long)
            mCampaignID = value
        End Set
    End Property

    Public Property OppStartDate() As Date
        Get
            Return mOppStartDate
        End Get
        Set(ByVal value As Date)
            mOppStartDate = value
        End Set
    End Property

    Public Property OppExpireDate() As Date
        Get
            Return mOppExpireDate
        End Get
        Set(ByVal value As Date)
            mOppExpireDate = value
        End Set
    End Property

    Public Property IsSysRevenue() As Boolean
        Get
            Return mIsSysRevenue
        End Get
        Set(ByVal value As Boolean)
            mIsSysRevenue = value
        End Set
    End Property


    Public Property EstimateRevenue() As Double
        Get
            Return mEstimateRevenue
        End Get
        Set(ByVal value As Double)
            mEstimateRevenue = value
        End Set

    End Property


    Public Property ExpectRevenue() As Double
        Get
            Return mExpectRevenue
        End Get
        Set(ByVal value As Double)
            mExpectRevenue = value
        End Set

    End Property

    Public Property IsClose() As Boolean
        Get
            Return mIsClose
        End Get
        Set(ByVal value As Boolean)
            mIsClose = value
        End Set

    End Property

    Public Property CloseDate() As Date
        Get
            Return mCloseDate
        End Get
        Set(ByVal value As Date)
            mCloseDate = value
        End Set
    End Property

    Public Property RealRevenue() As Double
        Get
            Return mRealRevenue
        End Get
        Set(ByVal value As Double)
            mRealRevenue = value
        End Set

    End Property

    Public Property CloseResult() As Boolean
        Get
            Return mCloseResult
        End Get
        Set(ByVal value As Boolean)
            mCloseResult = value
        End Set

    End Property

    Public Property CloseRemark() As String
        Get
            Return mCloseRemark
        End Get
        Set(ByVal value As String)
            mCloseRemark = value
        End Set

    End Property

    Public Property OppContactRoleDAOs() As List(Of OppContactRoleDAO)
        Get
            Return mOppContactRoleDAOs
        End Get
        Set(ByVal Value As List(Of OppContactRoleDAO))
            mOppContactRoleDAOs = Value
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
            Err.Raise(Err.Number, e.Source, "OpportunityDAO.CHECKSUM_AGG : " & e.Message)
            Return 0
        Finally
            dataTable = Nothing
        End Try
    End Function

    Public Overrides Function InitailData(ByVal pID As Long, Optional ByVal pName As String = "", Optional ByVal tr As SqlTransaction = Nothing) As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()
        Dim lUserDAO As New UserDAO
        'Dim lFileAttach As New FileAttachDAO
        Try
            SQL = "SELECT *   "
            SQL = SQL & " FROM Opportunity "
            SQL = SQL & " WHERE 1=1"
            If pID > 0 Then
                SQL = SQL & " and OppID=" & pID
            End If
            If pName.Trim <> "" Then
                SQL = SQL & " and OppName='" & pName.Trim & "'"
            End If
            SQL = SQL & " ORDER BY OppName"
            dataTable = gConnection.executeSelectQuery(SQL, tr)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows

                    Subject = dr("OppName").ToString
                    CustomerID = ConvertNullToZero(dr("CustomerID"))
                    OpportunityTypeID = ConvertNullToZero(dr("OpportunityTypeID"))
                    OpportunityStageID = ConvertNullToZero(dr("OpportunityStageID"))
                    CampaignID = ConvertNullToZero(dr("CampaignID"))
                    If IsDBNull(dr("OppStartDate")) Then
                        OppStartDate = GetCurrentDate(tr)
                    Else
                        OppStartDate = dr("OppStartDate")
                    End If
                    If IsDBNull(dr("OppExpireDate")) Then
                        OppExpireDate = GetCurrentDate(tr)
                    Else
                        OppExpireDate = dr("OppExpireDate")
                    End If
                    EstimateRevenue = ConvertNullToZero(dr("EstimateRevenue"))
                    ExpectRevenue = ConvertNullToZero(dr("ExpectRevenue"))
                    IsSysRevenue = dr("IsSysRevenue")
                    SourceID = ConvertNullToZero(dr("SourceID"))
                    Remark = ConvertNullToString(dr("Remark"))
                    IsClose = dr("IsClose")
                    If IsDBNull(dr("CloseDate")) Then
                        CloseDate = GetCurrentDate(tr)
                    Else
                        CloseDate = dr("CloseDate")
                    End If
                    EmpID = ConvertNullToZero(dr("EmpID"))

                    'Person
                    ID = Int32.Parse(dr("OppID"))
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
            Err.Raise(Err.Number, e.Source, "OpportunityDAO.InitailData : " & e.Message)
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
        '    Err.Raise(Err.Number, e.Source, "OpportunityDAO.GetInfoHtml : " & e.Message)

        'End Try
        Return Info
    End Function


    Public Function GetDataTable(ByVal pID As Long, ByVal pOnlyActive As Boolean) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT Opportunity.OppID AS ID,Opportunity.OppName  "
            SQL = SQL & " ,CASE WHEN Customer.CompanyName <>'' THEN Customer.CompanyName ELSE Customer.Title + Customer.Firstname + ' ' + Customer.LastName END Customer  "
            SQL = SQL & " ,OppStartDate,OppExpireDate,EstimateRevenue,ExpectRevenue,OpportunityStage.NameThai,Opportunity.IsClose,Opportunity.CloseDate"
            SQL = SQL & " ,Employee.Title + Employee.Firstname + ' ' + Employee.LastName AS EMPNAME,Opportunity.ModifiedTime"
            SQL = SQL & " FROM Opportunity  "
            SQL = SQL & " LEFT OUTER JOIN Employee ON Opportunity.EmpID=Employee.EmpID  "
            SQL = SQL & " LEFT OUTER JOIN Customer ON Opportunity.CustomerID=Customer.CustomerID  "
            SQL = SQL & " LEFT OUTER JOIN OpportunityStage ON OpportunityStage.OpportunityStageID=Opportunity.OpportunityStageID  "
            SQL = SQL & " WHERE Opportunity.IsDelete =0   "
            If pID > 0 Then
                SQL = SQL & "  AND Opportunity.OppID=" & pID
            End If
            If pOnlyActive = True Then
                SQL = SQL & "  AND Opportunity.IsInActive = 0"
            End If
            ''Set View level
            If gViewLevel = eViewLevel.Group Then
                SQL = SQL & "  AND Employee.TerritoryID=" & gTerritoryID
            ElseIf gViewLevel = eViewLevel.OnlyOwner Then
                SQL = SQL & "  AND Employee.EmpID=" & gEmpID
            End If
            SQL = SQL & " ORDER BY Opportunity.OppName"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "OpportunityDAO.GetDataTable : " & e.Message)
        End Try
        Return dataTable
    End Function

    Public Function GetDataTableForCombo(ByVal pCustomerID As Long, ByVal pEffectDate As Date) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT Opportunity.OppID AS ID,Opportunity.OppName  "
            SQL = SQL & " ,OppStartDate,OppExpireDate,Opportunity.CloseDate,EstimateRevenue,ExpectRevenue,OpportunityStage.NameThai"
            SQL = SQL & " ,Employee.Title + Employee.Firstname + ' ' + Employee.LastName AS EMPNAME"
            SQL = SQL & " FROM Opportunity  "
            SQL = SQL & " LEFT OUTER JOIN Employee ON Opportunity.EmpID=Employee.EmpID  "
            SQL = SQL & " LEFT OUTER JOIN OpportunityStage ON OpportunityStage.OpportunityStageID=Opportunity.OpportunityStageID  "
            SQL = SQL & " WHERE Opportunity.IsDelete =0   "
            SQL = SQL & "  AND Opportunity.IsInActive = 0   "
            If pCustomerID > 0 Then
                SQL = SQL & "  AND Opportunity.CustomerID=" & pCustomerID
            End If
            SQL = SQL & "  AND OppStartDate <= '" & formatSQLDate(pEffectDate) & "'"
            SQL = SQL & "  AND OppExpireDate > '" & formatSQLDate(pEffectDate) & "'"
            SQL = SQL & "  AND ( IsClose= 0  "
            SQL = SQL & "           OR ( IsClose= 1 AND  CloseDate >  '" & formatSQLDate(pEffectDate) & "' )"
            SQL = SQL & "       )"
            ''Set View level
            If gViewLevel = eViewLevel.Group Then
                SQL = SQL & "  AND Employee.TerritoryID=" & gTerritoryID
            ElseIf gViewLevel = eViewLevel.OnlyOwner Then
                SQL = SQL & "  AND Employee.EmpID=" & gEmpID
            End If
            SQL = SQL & " ORDER BY Opportunity.OppName"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "OpportunityDAO.GetDataTableForCombo : " & e.Message)
        End Try
        Return dataTable
    End Function


    Public Function GetHistoryTable(ByVal pID As Long) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT OppHistory.ModifiedTime "
            SQL = SQL & " ,CASE WHEN Customer.CompanyName <>'' THEN Customer.CompanyName ELSE Customer.Title + Customer.Firstname + ' ' + Customer.LastName END Customer  "
            SQL = SQL & " ,OpportunityStage.NameThai,EstimateRevenue,ExpectRevenue,OppHistory.IsClose,OppHistory.CloseDate"
            SQL = SQL & " ,Admin_User.UserName "
            SQL = SQL & " FROM OppHistory  "
            SQL = SQL & " LEFT OUTER JOIN Admin_User ON Admin_User.UserID=OppHistory.ModifiedBy  "
            SQL = SQL & " LEFT OUTER JOIN Customer ON OppHistory.CustomerID=Customer.CustomerID  "
            SQL = SQL & " LEFT OUTER JOIN OpportunityStage ON OpportunityStage.OpportunityStageID=OppHistory.OpportunityStageID  "
            SQL = SQL & " WHERE  OppHistory.OppID=" & pID
            SQL = SQL & " ORDER BY OppHistory.ModifiedTime "
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "OpportunityDAO.GetHistoryTable : " & e.Message)
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
                    IsClose = False
                    EmpID = gEmpID
                    ID = GenNewID("OppID", "Opportunity", tr)
                    SQL = " INSERT INTO Opportunity  (OppID,OppName,CustomerID,OpportunityTypeID,OpportunityStageID,CampaignID"
                    SQL = SQL & " ,OppStartDate,OppExpireDate,IsSysRevenue,EstimateRevenue,ExpectRevenue,SourceID "
                    SQL = SQL & " ,Remark,IsClose,CloseDate,EmpID"
                    SQL = SQL & " ,CreateBy,CreateTime,IsInActive,IsDelete "
                    SQL = SQL & " )"
                    SQL = SQL & " VALUES ( @IDs"
                    SQL = SQL & " ,  @OppName"
                    SQL = SQL & " ,  @CustomerID"
                    SQL = SQL & " ,  @OpportunityTypeID"
                    SQL = SQL & " ,  @OpportunityStageID"
                    SQL = SQL & " ,  @CampaignID"
                    SQL = SQL & " ,  @OppStartDate"
                    SQL = SQL & " ,  @OppExpireDate "
                    SQL = SQL & " ,  @IsSysRevenue "
                    SQL = SQL & " ,  @EstimateRevenue "
                    SQL = SQL & " ,  @ExpectRevenue "
                    SQL = SQL & " ,  @SourceID "
                    SQL = SQL & " ,  @Remark "
                    SQL = SQL & " ,  @IsClose "
                    SQL = SQL & " ,  @CloseDate "
                    SQL = SQL & " ,  @EmpID "

                    SQL = SQL & " ,  @gUserID"
                    SQL = SQL & " ,  @CreateTime"
                    SQL = SQL & " ,  @IsInActive"
                    SQL = SQL & " ,  @IsDelete"

                    SQL = SQL & " ) "
                Case DataMode.ModeEdit
                    SQL = " UPDATE Opportunity SET "
                    SQL = SQL & " OppName=@OppName"
                    SQL = SQL & " , CustomerID=@CustomerID "
                    SQL = SQL & " , OpportunityTypeID=@OpportunityTypeID "
                    SQL = SQL & " , OpportunityStageID=@OpportunityStageID "
                    SQL = SQL & " , CampaignID=@CampaignID "
                    SQL = SQL & " , OppStartDate=@OppStartDate "
                    SQL = SQL & " , OppExpireDate=@OppExpireDate "
                    SQL = SQL & " , IsSysRevenue=@IsSysRevenue "
                    SQL = SQL & " , EstimateRevenue=@EstimateRevenue "
                    SQL = SQL & " , ExpectRevenue=@ExpectRevenue "
                    SQL = SQL & " , SourceID=@SourceID "
                    SQL = SQL & " , Remark=@Remark "
                    SQL = SQL & " , IsClose=@IsClose "
                    SQL = SQL & " , CloseDate=@CloseDate "
                    SQL = SQL & " , EmpID=@EmpID "
                    SQL = SQL & " ,ModifiedBy= @gUserID"
                    SQL = SQL & " ,ModifiedTime= @CreateTime"
                    SQL = SQL & " ,IsInActive= @IsInActive"
                    SQL = SQL & " ,RealRevenue= @RealRevenue"
                    SQL = SQL & " ,CloseResult= @CloseResult"
                    SQL = SQL & " ,CloseRemark= @CloseRemark"
                    SQL = SQL & " WHERE OppID= @IDs"
                Case DataMode.ModeDelete
                    SQL = " UPDATE Opportunity SET IsDelete=@IsDelete "
                    SQL = SQL & " ,ModifiedBy= @gUserID"
                    SQL = SQL & " ,ModifiedTime= @CreateTime"
                    SQL = SQL & " WHERE OppID= @IDs"
            End Select
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@IDs", ID))
            myCommand.Parameters.Add(New SqlParameter("@OppName", Trim(Subject)))
            myCommand.Parameters.Add(New SqlParameter("@CustomerID", ConvertNullToZero(CustomerID)))
            myCommand.Parameters.Add(New SqlParameter("@OpportunityTypeID", ConvertNullToZero(OpportunityTypeID)))
            myCommand.Parameters.Add(New SqlParameter("@OpportunityStageID", ConvertNullToZero(OpportunityStageID)))
            myCommand.Parameters.Add(New SqlParameter("@CampaignID", ConvertNullToZero(CampaignID)))
            myCommand.Parameters.Add(New SqlParameter("@OppStartDate", formatSQLDate(OppStartDate)))
            myCommand.Parameters.Add(New SqlParameter("@OppExpireDate", formatSQLDate(OppExpireDate)))
            myCommand.Parameters.Add(New SqlParameter("@IsSysRevenue", IsSysRevenue))
            myCommand.Parameters.Add(New SqlParameter("@EstimateRevenue", ConvertNullToZero(EstimateRevenue)))
            myCommand.Parameters.Add(New SqlParameter("@ExpectRevenue", ConvertNullToZero(ExpectRevenue)))
            myCommand.Parameters.Add(New SqlParameter("@SourceID", ConvertNullToZero(SourceID)))
            myCommand.Parameters.Add(New SqlParameter("@Remark", ConvertNullToString(Remark)))
            myCommand.Parameters.Add(New SqlParameter("@IsClose", IsClose))
            myCommand.Parameters.Add(New SqlParameter("@RealRevenue", ConvertNullToZero(RealRevenue)))
            myCommand.Parameters.Add(New SqlParameter("@CloseResult", CloseResult))
            myCommand.Parameters.Add(New SqlParameter("@CloseRemark", ConvertNullToString(CloseRemark)))
            If IsClose = True Then
                myCommand.Parameters.Add(New SqlParameter("@CloseDate", CloseDate))
            Else
                myCommand.Parameters.Add(New SqlParameter("@CloseDate", DBNull.Value))
            End If
            myCommand.Parameters.Add(New SqlParameter("@EmpID", ConvertNullToZero(EmpID)))

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
            SaveAttachFile(FileAttachs, ModeData, ID, TableName, tr)
            If ModeData <> DataMode.ModeDelete Then
                Dim lclsOrder As New OrderSDAO
                lclsOrder.TableID = 0
                lclsOrder.SaveProductList(ProductDAOs, ModeData, ID, TableName, tr)
            End If
            SaveOppContactRole(tr)
            If ModeData = DataMode.ModeEdit Then
                SaveHistory(tr)
            End If

            tr.Commit()
            Return True
        Catch e As Exception
            tr.Rollback()
            Err.Raise(Err.Number, e.Source, "OpportunityDAO.SaveData : " & e.Message)
            Return False
        End Try

    End Function

    Private Sub SaveOppContactRole(ByVal tr As SqlTransaction)
        Dim lstrStayIDList As String = ""
        Dim OppContactRoleDAO2 As New OppContactRoleDAO
        Try
            If OppContactRoleDAOs Is Nothing Then
                If ModeData = DataMode.ModeDelete Then
                    OppContactRoleDAO2 = New OppContactRoleDAO
                    OppContactRoleDAO2.RefID = ID
                    OppContactRoleDAO2.DeleteAllData(tr)
                End If
            ElseIf OppContactRoleDAOs.Count = 0 Then

            Else
                For Each OppContactRoleDAO As OppContactRoleDAO In OppContactRoleDAOs
                    OppContactRoleDAO.RefID = ID

                    If ModeData = DataMode.ModeDelete Then
                        OppContactRoleDAO.ModeData = DataMode.ModeDelete
                    ElseIf ModeData = DataMode.ModeEdit Then
                    End If
                    If OppContactRoleDAO.SaveData(tr) Then
                        If ModeData = DataMode.ModeEdit Then
                            If OppContactRoleDAO.ID > 0 Then
                                lstrStayIDList = IIf(lstrStayIDList = "", OppContactRoleDAO.ID, lstrStayIDList & "," & OppContactRoleDAO.ID)
                            End If
                        End If
                    End If
                Next
                'Delete Remove Item
                OppContactRoleDAO2 = New OppContactRoleDAO
                OppContactRoleDAO2.RefID = ID

                If ModeData = DataMode.ModeEdit And lstrStayIDList <> "" Then
                    OppContactRoleDAO2.DeleteRemoveData(tr, lstrStayIDList)
                End If
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "OpportunityDAO.SaveOppContactRole" & e.Message)
        End Try
    End Sub

    Private Sub SaveHistory(ByVal tr As SqlTransaction)
        Dim SQL As String
        Dim myCommand As SqlCommand

        SQL = ""
        Try
            SQL = " INSERT INTO OppHistory (OppID,CustomerID,OpportunityStageID"
            SQL = SQL & " ,EstimateRevenue,ExpectRevenue,IsClose,CloseDate,EmpID "
            SQL = SQL & " ,ModifiedBy,ModifiedTime "
            SQL = SQL & " )"
            SQL = SQL & " VALUES ( @IDs"
            SQL = SQL & " ,  @CustomerID"
            SQL = SQL & " ,  @OpportunityStageID"
            SQL = SQL & " ,  @EstimateRevenue "
            SQL = SQL & " ,  @ExpectRevenue "
            SQL = SQL & " ,  @IsClose "
            SQL = SQL & " ,  @CloseDate "
            SQL = SQL & " ,  @EmpID "
            SQL = SQL & " ,  @gUserID"
            SQL = SQL & " ,  @CreateTime"
            SQL = SQL & " ) "

            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@IDs", ID))
            myCommand.Parameters.Add(New SqlParameter("@CustomerID", ConvertNullToZero(CustomerID)))
            myCommand.Parameters.Add(New SqlParameter("@OpportunityStageID", ConvertNullToZero(OpportunityStageID)))
            myCommand.Parameters.Add(New SqlParameter("@EstimateRevenue", ConvertNullToZero(EstimateRevenue)))
            myCommand.Parameters.Add(New SqlParameter("@ExpectRevenue", ConvertNullToZero(ExpectRevenue)))
            myCommand.Parameters.Add(New SqlParameter("@IsClose", IsClose))
            If IsClose = True Then
                myCommand.Parameters.Add(New SqlParameter("@CloseDate", CloseDate))
            Else
                myCommand.Parameters.Add(New SqlParameter("@CloseDate", DBNull.Value))
            End If
            myCommand.Parameters.Add(New SqlParameter("@EmpID", ConvertNullToZero(EmpID)))
            myCommand.Parameters.Add(New SqlParameter("@gUserID", gUserID))
            myCommand.Parameters.Add(New SqlParameter("@CreateTime", formatSQLDateTime(GetCurrentDate(tr))))

            gConnection.executeInsertSqlCommand(myCommand, tr)

        Catch e As Exception
            tr.Rollback()
            Err.Raise(Err.Number, e.Source, "OpportunityDAO.SaveHistory : " & e.Message)

        End Try
    End Sub

    Public Overrides Function CheckExist() As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT OppID  FROM Opportunity"
            SQL = SQL & " WHERE IsDelete =0 AND OppName='" & Trim(mSubject) & "'"
            If ModeData = DataMode.ModeEdit Then
                SQL = SQL & " AND OppID <> " & ID
            End If
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            Return dataTable.Rows.Count > 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "OpportunityDAO.CheckExist : " & e.Message)
            Return False
        Finally
            dataTable = Nothing
        End Try

    End Function

    Public Function CheckIsToUse() As String ''ถูกใช้งานอยู่ ???

        'Dim SQL As String
        'Dim dataTable As New DataTable()

        Try
            'SQL = "SELECT LeadID  FROM Lead"
            'SQL = SQL & " WHERE IsDelete =0 AND Subject='" & Trim(mSubject) & "'"
            'If mMode = DataMode.ModeEdit Then
            '    SQL = SQL & " AND LeadID <> " & mIDs
            'End If
            'dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            'Return dataTable.Rows.Count > 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "OpportunityDAO.CheckNotExist : " & e.Message)
        End Try
        Return False
    End Function

 
 

    Public Sub New()
        mOppContactRoleDAOs = Nothing
        mSubject = ""
        mOpportunityTypeID = 0
        mOpportunityStageID = 0
        mCampaignID = 0
        mOppStartDate = Nothing
        mOppExpireDate = Nothing
        mIsSysRevenue = 0
        mEstimateRevenue = True
        mIsClose = False
        mCloseDate = Nothing
        mExpectRevenue = 0
        mRealRevenue = 0
        mCloseRemark = ""

    End Sub
End Class
