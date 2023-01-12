Option Explicit On

Imports System.Data.SqlClient


Public Class EmployeeDAO
    Inherits iPerson
    Private mPositionDAO As PositionDAO
    Private mEmpCode As String
    Private mEmpGroupID As Long
    Private mPositionID As Long
    Private mStartDate As Date
    Private mWorkingStatus As String
    Private mViewLevel As eViewLevel
    Dim mCommission As Decimal
    Dim mEmpUserID As Long

    Public ReadOnly Property TableName() As String
        Get
            Return "Employee"
        End Get
    End Property

    Public ReadOnly Property PositionDAO() As PositionDAO
        Get

            If PositionID > 0 And mPositionDAO Is Nothing Then
                mPositionDAO = New PositionDAO
                mPositionDAO.InitailData(PositionID)
            End If

            Return mPositionDAO
        End Get
    End Property


    Public Property StartDate() As Date
        Get
            Return mStartDate
        End Get
        Set(ByVal value As Date)
            mStartDate = value
        End Set
    End Property

    Public Property WorkingStatus() As String
        Get
            Return mWorkingStatus
        End Get
        Set(ByVal value As String)
            mWorkingStatus = value
        End Set
    End Property

    Public Property PositionID() As Long
        Get
            Return mPositionID
        End Get
        Set(ByVal value As Long)
            mPositionID = value
        End Set
    End Property


    Public Property ViewLevel() As Long
        Get
            Return mViewLevel
        End Get
        Set(ByVal value As Long)
            mViewLevel = value
        End Set
    End Property


    Public Property EmpGroupID() As Long
        Get
            Return mEmpGroupID
        End Get
        Set(ByVal value As Long)
            mEmpGroupID = value
        End Set

    End Property


    Public Property EmpUserID() As Long
        Get
            Return mEmpUserID
        End Get
        Set(ByVal value As Long)
            mEmpUserID = value
        End Set

    End Property

    Dim mCommissionID As Long = 0
    Public Property CommissionID() As Long
        Get
            Return mCommissionID
        End Get
        Set(ByVal value As Long)
            mCommissionID = value
        End Set

    End Property

    Dim mTargetPerMonth As Decimal = 0
    Public Property TargetPerMonth() As Decimal
        Get
            Return mTargetPerMonth
        End Get
        Set(ByVal value As Decimal)
            mTargetPerMonth = value
        End Set

    End Property

    Public Property Commission() As Decimal
        Get
            Return mCommission
        End Get
        Set(ByVal value As Decimal)
            mCommission = value
        End Set

    End Property

    Public Property EmpCode() As String
        Get
            Return mEmpCode
        End Get
        Set(ByVal value As String)
            mEmpCode = value
        End Set
    End Property

    Public Function CHECKSUM_AGG() As Long
        Dim SQL As String
        Dim dataTable As New DataTable()
        Try
            SQL = "SELECT CHECKSUM_AGG(BINARY_CHECKSUM(*)) FROM Employee WITH (NOLOCK);"

            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    Return ConvertNullToZero(dr(0))
                    Exit For
                Next
            End If
            Return 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "EmployeeDAO.CHECKSUM_AGG : " & e.Message)
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
            SQL = "SELECT E.* ,U.UserID  "
            SQL &=  " FROM Employee E"
            SQL &=  " Left outer join Admin_User U ON U.EmpID=E.EmpID"
            SQL &=  " WHERE 1=1"
            If pID > 0 Then
                SQL &=  " and E.EmpID=" & pID
            End If
            If pName <> "" Then
                SQL &=  " and E.Firstname like '%" & pName & "%'"
            End If
            SQL &=  " ORDER BY E.EmpCode"
            dataTable = gConnection.executeSelectQuery(SQL, tr)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    'Employee 
                    If IsDBNull(dr("StartDate")) Then
                        StartDate = GetCurrentDate(tr)
                    Else
                        StartDate = dr("StartDate")
                    End If
                    EmpCode = ConvertNullToString(dr("EmpCode"))
                    WorkingStatus = ConvertNullToString(dr("WorkingStatus"))

                    'Person
                    ID = Int32.Parse(dr("EmpID"))
                    IsInActive = dr("IsInActive")
                    Title = ConvertNullToString(dr("Title"))
                    FirstName = ConvertNullToString(dr("Firstname"))
                    LastName = ConvertNullToString(dr("LastName"))
                    TitleEng = ConvertNullToString(dr("TitleEng"))
                    FirstNameEng = ConvertNullToString(dr("FirstNameEng"))
                    LastNameEng = ConvertNullToString(dr("LastNameEng"))
                    NickName = ConvertNullToString(dr("NickName"))


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
                    If ConvertNullToZero(dr("ViewLevel")) = 0 Then
                        ViewLevel = eViewLevel.All
                    Else
                        ViewLevel = ConvertNullToZero(dr("ViewLevel"))
                    End If

                    TerritoryID = ConvertNullToZero(dr("TerritoryID"))
                    EmpGroupID = ConvertNullToZero(dr("EmpGroupID"))
                    Commission = ConvertNullToZero(dr("Commission"))
                    EmpUserID = ConvertNullToZero(dr("UserID"))
                    CommissionID = ConvertNullToZero(dr("CommissionID"))
                    TargetPerMonth = ConvertNullToZero(dr("TargetPerMonth"))

                    'Load Position
                    PositionID = ConvertNullToZero(dr("PositionID"))

                    'Load AddressDAO
                    AddressS = Nothing
                    AddressS = New AddressDAO
                    AddressS.InitailData(ConvertNullToZero(dr("AddressID")), tr)

                    'Load HistoryDAO
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
            Err.Raise(Err.Number, e.Source, "EmployeeDAO.InitailData : " & e.Message)
            Return False
        Finally
            lUserDAO = Nothing
            dataTable = Nothing
        End Try

    End Function

    Public Function GetInfoHtml() As String
        Dim Info As String = ""
        Try
            Info &= Constants.vbCrLf & Constants.vbCrLf & "รหัสพนักงาน: " & EmpCode
            Info &= Constants.vbCrLf & Constants.vbCrLf & "ชื่อ - สกุล: " & Title & FirstName & " " & LastName
            Info &= Constants.vbCrLf & "ชื่อเล่น: " & NickName
            If Not PositionDAO Is Nothing Then
                Info &= Constants.vbCrLf & "ตำแหน่ง: " & PositionDAO.NameThai
                If Not PositionDAO.Department Is Nothing Then
                    Info &= Constants.vbCrLf & "แผนก: " & PositionDAO.Department.NameThai
                End If
            End If

            Info &= Constants.vbCrLf & "โทรศัพท์มือถือ: " & AddressS.MobilePhone
            Info &= Constants.vbCrLf & "เบอร์โทรศัพท์: " & AddressS.Phone1
            Info &= Constants.vbCrLf & "เบอร์โทรสาร: " & AddressS.Fax
            Info &= Constants.vbCrLf & "อีเมลล์: " & AddressS.Email1
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "EmployeeDAO.GetInfoHtml : " & e.Message)

        End Try
        Return Info
    End Function


    Public Function GetDataTable(ByVal pID As Long, ByVal pOnlyActive As Boolean) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT EmpID AS ID,EmpCode,Title + Firstname + ' ' + LastName AS NAME "
            SQL &=  " FROM Employee  "
            SQL &=  " WHERE IsDelete =0   "
            If pID > 0 Then
                SQL &=  "  AND EmpID=" & pID
            End If
            If pOnlyActive = True Then
                SQL &=  "  AND IsInActive = 0"
            End If
            SQL &=  " ORDER BY EmpCode,Title,Firstname"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "EmployeeDAO.GetDataTable : " & e.Message)
        End Try
        Return dataTable
    End Function

    Public Function GetDataTableForCombo(ByVal pID As Long, ByVal pOnlyActive As Boolean, Optional ByVal pSQL As String = "") As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT EmpID AS ID,EmpCode,Title + Firstname + ' ' + LastName AS NAME "
            SQL &= " FROM Employee  "
            SQL &= " WHERE IsDelete =0   "
            If pID > 0 Then
                SQL &= "  AND EmpID=" & pID
            End If
            If pOnlyActive = True Then
                SQL &= "  AND IsInActive = 0 "
            End If
            If pSQL <> "" Then
                SQL &= pSQL
            End If
            SQL &= " ORDER BY EmpCode,Title,Firstname"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "EmployeeDAO.GetDataTableForCombo : " & e.Message)
        End Try
        Return dataTable
    End Function

    Public Function GetDataTableForCombo2(ByVal pID As Long, ByVal pOnlyActive As Boolean, ByVal pEmpName As String) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT Employee.EmpID AS ID,Employee.EmpCode,Employee.Title + Employee.Firstname + ' ' + Employee.LastName AS EmpName  "
            SQL &=  " ,Position.NameThai AS PositionName,Address.Phone1,Address.Email1"
            SQL &=  " FROM Employee  "
            SQL &=  " LEFT OUTER JOIN Address ON Employee.AddressID=Address.AddressID "
            SQL &=  " LEFT OUTER JOIN Position ON Employee.PositionID=Position.PositionID "
            SQL &=  " WHERE Employee.IsDelete =0   "
            If pID > 0 Then
                SQL &=  "  AND Employee.EmpID=" & pID
            End If
            If pEmpName.trim <> "" Then
                SQL &=  "  AND Employee.Firstname Like'%" & pEmpName.Trim & "%'"
            End If
            If pOnlyActive = True Then
                SQL &=  "  AND Employee.IsInActive = 0"
            End If
            SQL &=  " ORDER BY Employee.EmpCode,Employee.Title,Employee.Firstname"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "EmployeeDAO.GetDataTableForCombo2 : " & e.Message)
        End Try
        Return dataTable
    End Function


    Public Overrides Function SaveData(Optional ByRef ptr As SqlTransaction = Nothing) As Boolean
        Dim SQL As String
        Dim llngAddressID As Long = 0, llngHistoryID As Long = 0
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
                    ID = GenNewID("EmpID", TableName, tr)
                    SQL = " INSERT INTO Employee  (EmpID,EmpCode "
                    SQL &=  " ,Title,Firstname,LastName,TitleEng,FirstnameEng,LastNameEng,NickName,Remark"
                    SQL &=  " ,CreateBy,CreateTime,IsInActive,IsDelete,AddressID,PositionID,TerritoryID,HistoryID "
                    SQL &= " ,StartDate,WorkingStatus,EmpGroupID,ViewLevel,Commission,CommissionID,TargetPerMonth "
                    SQL &=  " )"
                    SQL &=  " VALUES ( @mIDs"
                    SQL &=  " ,  @EmpCode"
                    SQL &=  " ,  @Title"
                    SQL &=  " ,  @FirstName"
                    SQL &=  " ,  @LastName"
                    SQL &=  " ,  @TitleEng"
                    SQL &=  " ,  @FirstNameEng"
                    SQL &=  " ,  @LastNameEng"
                    SQL &=  " ,  @NickName"
                    SQL &=  " ,  @Remark"
                    SQL &=  " ,  @gUserID"
                    SQL &=  " ,  @CreateTime"
                    SQL &=  " ,  @IsInActive"
                    SQL &=  " ,  @IsDelete"
                    SQL &=  " ,  @AddressID"
                    SQL &=  " ,  @PositionID"
                    SQL &=  " ,  @TerritoryID"
                    SQL &=  " ,  @HistoryID"
                    SQL &=  " ,  @StartDate"
                    SQL &=  " ,  @WorkingStatus"
                    SQL &=  " ,  @EmpGroupID"
                    SQL &=  " ,  @ViewLevel"
                    SQL &= " ,  @Commission"
                    SQL &= " ,  @CommissionID"
                    SQL &= " ,  @TargetPerMonth"
                    SQL &=  " ) "
                Case DataMode.ModeEdit
                    SQL = " UPDATE Employee SET "
                    SQL &=  " EmpCode=@EmpCode"
                    SQL &=  " ,Title=@Title"
                    SQL &=  " ,Firstname=@FirstName"
                    SQL &=  " ,LastName=@LastName"
                    SQL &=  " ,TitleEng=@TitleEng"
                    SQL &=  " ,FirstnameEng=@FirstNameEng"
                    SQL &=  " ,LastNameEng=@LastNameEng"
                    SQL &=  " ,NickName=@NickName"
                    SQL &=  " ,Remark= @Remark"
                    SQL &=  " ,ModifiedBy= @gUserID"
                    SQL &=  " ,ModifiedTime= @CreateTime"
                    SQL &=  " ,IsInActive= @IsInActive"
                    SQL &=  " ,PositionID= @PositionID"
                    SQL &=  " ,TerritoryID= @TerritoryID"
                    SQL &=  " ,StartDate= @StartDate"
                    SQL &=  " ,WorkingStatus= @WorkingStatus"
                    SQL &=  " ,EmpGroupID= @EmpGroupID"
                    SQL &=  " ,ViewLevel= @ViewLevel"
                    SQL &= " ,Commission= @Commission"
                    SQL &= " ,CommissionID= @CommissionID"
                    SQL &= " ,TargetPerMonth= @TargetPerMonth"
                    SQL &=  " WHERE EmpID= @mIDs"
                Case DataMode.ModeDelete
                    SQL = " UPDATE Employee SET IsDelete=@IsDelete "
                    SQL &=  " ,ModifiedBy= @gUserID"
                    SQL &=  " ,ModifiedTime= @CreateTime"
                    SQL &=  " WHERE EmpID= @mIDs"
            End Select
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@mIDs", ID))
            myCommand.Parameters.Add(New SqlParameter("@EmpCode", Trim(EmpCode)))
            myCommand.Parameters.Add(New SqlParameter("@StartDate", formatSQLDate(StartDate)))
            myCommand.Parameters.Add(New SqlParameter("@WorkingStatus", WorkingStatus))

            myCommand.Parameters.Add(New SqlParameter("@Title", Trim(Title)))
            myCommand.Parameters.Add(New SqlParameter("@FirstName", Trim(FirstName)))
            myCommand.Parameters.Add(New SqlParameter("@LastName", Trim(LastName)))
            myCommand.Parameters.Add(New SqlParameter("@TitleEng", Trim(TitleEng)))
            myCommand.Parameters.Add(New SqlParameter("@FirstNameEng", Trim(FirstNameEng)))
            myCommand.Parameters.Add(New SqlParameter("@LastNameEng", Trim(LastNameEng)))
            myCommand.Parameters.Add(New SqlParameter("@NickName", Trim(NickName)))

            myCommand.Parameters.Add(New SqlParameter("@Remark", Trim(Remark)))
            myCommand.Parameters.Add(New SqlParameter("@gUserID", gUserID))
            myCommand.Parameters.Add(New SqlParameter("@CreateTime", formatSQLDateTime(GetCurrentDate(tr))))
            myCommand.Parameters.Add(New SqlParameter("@IsInActive", IsInActive))

            myCommand.Parameters.Add(New SqlParameter("@PositionID", PositionID))
            myCommand.Parameters.Add(New SqlParameter("@TerritoryID", TerritoryID))
            myCommand.Parameters.Add(New SqlParameter("@AddressID", llngAddressID))
            myCommand.Parameters.Add(New SqlParameter("@HistoryID", llngHistoryID))
            myCommand.Parameters.Add(New SqlParameter("@EmpGroupID", EmpGroupID))
            myCommand.Parameters.Add(New SqlParameter("@ViewLevel", ViewLevel))
            myCommand.Parameters.Add(New SqlParameter("@Commission", ConvertNullToZero(Commission)))
            myCommand.Parameters.Add(New SqlParameter("@CommissionID", ConvertNullToZero(CommissionID)))
            myCommand.Parameters.Add(New SqlParameter("@TargetPerMonth", ConvertNullToZero(TargetPerMonth)))
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
                UpdateLastID(MasterType.Employee, tr)
            End If

            tr.Commit()
            Return True
        Catch e As Exception
            tr.Rollback()
            Err.Raise(Err.Number, e.Source, "EmployeeDAO.SaveData : " & e.Message)
            Return False
        End Try

    End Function

    Public Function CheckExist() As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT EmpID  FROM Employee"
            SQL &=  " WHERE IsDelete =0 AND EmpCode='" & Trim(EmpCode) & "'"
            If ModeData = DataMode.ModeEdit Then
                SQL &=  " AND EmpID <> " & ID
            End If
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            Return dataTable.Rows.Count > 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "EmployeeDAO.CheckExist : " & e.Message)
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
            Err.Raise(Err.Number, e.Source, "EmployeeDAO.CheckNotExist : " & e.Message)
        End Try
        Return False
    End Function


    Public Sub New()
        mPositionDAO = Nothing
        mEmpCode = ""
        mPositionID = 0
        mStartDate = Now
        mWorkingStatus = ""
        mViewLevel = 3
        mCommission = 0
        mEmpUserID = 0
    End Sub
End Class
