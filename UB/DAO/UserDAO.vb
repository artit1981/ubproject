Option Explicit On

Imports System.Data.SqlClient


Public Class UserDAO
    Inherits iDAO

    Private mEmpID As Long
    Private mPrivilegeID As Long
    Private mclsEmployee As EmployeeDAO
    Private mclsPrivilege As PrivilegeDAO
    Private mUserName As String
    Private mPassword As String

    Public Property UserName() As String
        Get
            Return mUserName
        End Get
        Set(ByVal value As String)
            mUserName = value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return mPassword
        End Get
        Set(ByVal value As String)
            mPassword = value
        End Set

    End Property
    Public ReadOnly Property TableName() As String
        Get
            Return "Admin_User"
        End Get
    End Property

    Public ReadOnly Property ColumnKey() As String
        Get
            Return "UserID"
        End Get
    End Property

    Public ReadOnly Property ClassName() As String
        Get
            Return "UserDAO"
        End Get
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

    Public Property PrivilegeID() As Long
        Get
            Return mPrivilegeID
        End Get
        Set(ByVal value As Long)
            mPrivilegeID = value
        End Set
    End Property

    Public ReadOnly Property PrivilegeDAO() As PrivilegeDAO
        Get
            If mclsPrivilege Is Nothing Then
                mclsPrivilege = New PrivilegeDAO
                mclsPrivilege.InitailData(PrivilegeID, 0)
            End If
            Return mclsPrivilege
        End Get

    End Property

    Public Function CHECKSUM_AGG() As Long
        Dim SQL As String
        Dim dataTable As New DataTable()
        Try
            SQL = "SELECT CHECKSUM_AGG(BINARY_CHECKSUM(*))  "
            SQL &=  " FROM  " & TableName
            SQL &=  " WITH (NOLOCK);"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    Return ConvertNullToZero(dr(0))
                    Exit For
                Next
            End If
            Return 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, ClassName & ".CHECKSUM_AGG : " & e.Message)
            Return 0
        Finally
            dataTable = Nothing
        End Try
    End Function


    Public Function InitailData(ByVal pByID As Boolean, ByVal pID As Long, ByVal pName As String, Optional ByVal tr As SqlTransaction = Nothing) As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()
        Dim lUserDAO As New UserDAO

        Try
            SQL = "SELECT *   "
            SQL &=  " FROM  " & TableName
            If pByID Then
                SQL &=  " WHERE " & ColumnKey & "=" & pID
            Else
                SQL &=  " WHERE UserName='" & Trim(pName) & "'"
            End If

            dataTable = gConnection.executeSelectQuery(SQL, tr)
            If dataTable.Rows.Count <= 0 Then
                Return False
            Else
                For Each dr As DataRow In dataTable.Rows
                    ID = Int32.Parse(dr(ColumnKey))
                    IsInActive = dr("IsInActive")
                    UserName = dr("UserName").ToString
                    Remark = dr("Remark").ToString

                    Dim lcls As New clsEncrypt
                    Password = lcls.decryptString(dr("Password").ToString)
                    lcls = Nothing


                    ' PrivilegeID
                    PrivilegeID = ConvertNullToZero(dr("PrivilegeID"))


                    ' Employee
                    EmpID = ConvertNullToZero(dr("EmpID"))

                    'Load FileAttach
                    If tr Is Nothing Then
                        FileAttachs = LoadFileAttach(ID, TableName, Nothing)
                    End If


                    Return True
                    Exit For
                Next

            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, ClassName & ".InitailData : " & e.Message)
            Return False
        Finally
            lUserDAO = Nothing
            dataTable = Nothing
        End Try

    End Function


    Public Function GetInfoHtml() As String
        Dim Info As String = ""
        Try

            Info = Constants.vbCrLf & Constants.vbCrLf & "ชื่อเข้าระบบ: " & UserName
            Info &= Constants.vbCrLf & "กลุ่มสิทธิการใช้งาน: "
            If Not mclsPrivilege Is Nothing Then
                Info &= mclsEmployee.Title & mclsEmployee.FirstName & " " & mclsEmployee.LastName
            End If
            Info &= Constants.vbCrLf & "ชื่อพนักงาน: "
            If Not mclsEmployee Is Nothing Then
                Info &= mclsEmployee.Title & mclsEmployee.FirstName & " " & mclsEmployee.LastName
            End If

            Info &= Constants.vbCrLf & "รายละเอียด: " & Remark

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, ClassName & ".GetInfoHtml : " & e.Message)

        End Try
        Return Info
    End Function


    Public Function GetDataTable(ByVal pID As Long, ByVal pOnlyActive As Boolean) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT Admin_User.UserID AS ID,Admin_User.UserName,Employee.Title+Employee.Firstname + ' ' + Employee.LastName AS EmpName,Admin_User.Remark"
            SQL &=  " FROM Admin_User  "
            SQL &=  " LEFT OUTER JOIN  Employee ON Employee.EmpID=Admin_User.EmpID"
            SQL &=  " WHERE Admin_User.IsDelete =0   "
            If pID > 0 Then
                SQL &=  "  AND Admin_User.UserID=" & pID
            End If
            If pOnlyActive = True Then
                SQL &=  "  AND Admin_User.IsInActive = 0"
            End If
            SQL &=  " ORDER BY Admin_User.UserName,Admin_User.Remark"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, ClassName & ".GetDataTable : " & e.Message)
        End Try
        Return dataTable
    End Function

    Public Function GetDataTableForCombo(ByVal pID As Long, ByVal pOnlyActive As Boolean) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT Admin_User.UserID AS ID,Admin_User.UserName,Employee.Title+Employee.Firstname + ' ' + Employee.LastName AS EmpName,Admin_User.Remark"
            SQL &=  " FROM Admin_User  "
            SQL &=  " LEFT OUTER JOIN  Employee ON Employee.EmpID=Admin_User.EmpID"
            SQL &=  " WHERE Admin_User.IsDelete =0   "
            If pID > 0 Then
                SQL &=  "  AND Admin_User.UserID=" & pID
            End If
            If pOnlyActive = True Then
                SQL &=  "  AND Admin_User.IsInActive = 0"
            End If
            SQL &=  " ORDER BY Admin_User.UserName,Admin_User.Remark"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, ClassName & ".GetDataTableForCombo : " & e.Message)
        End Try
        Return dataTable
    End Function
    Public Function SaveData() As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand
        Dim tr As SqlTransaction = Nothing

        SQL = ""
        Try
            tr = gConnection.Connection.BeginTransaction

            Select Case ModeData
                Case DataMode.ModeNew
                    ID = GenNewID(ColumnKey, TableName, tr)
                    SQL = " INSERT INTO Admin_User  (UserID,UserName,Password,EmpID,PrivilegeID,Remark"
                    SQL &=  " ,CreateBy,CreateTime,IsInActive,IsDelete)"
                    SQL &=  " VALUES ( @mIDs"
                    SQL &=  " ,  @UserName"
                    SQL &=  " ,  @Password"
                    SQL &=  " ,  @EmpID"
                    SQL &=  " ,  @PrivilegeID"
                    SQL &=  " ,  @Remark"
                    SQL &=  " ,  @gUserID"
                    SQL &=  " ,  @CreateTime"
                    SQL &=  " ,  @IsInActive"
                    SQL &=  " ,  @IsDelete"
                    SQL &=  " ) "
                Case DataMode.ModeEdit
                    SQL = " UPDATE Admin_User SET "
                    SQL &=  " UserName=@UserName"
                    SQL &=  " ,Password=@Password"
                    SQL &=  " ,EmpID=@EmpID"
                    SQL &=  " ,PrivilegeID=@PrivilegeID"
                    SQL &=  " ,Remark= @Remark"
                    SQL &=  " ,ModifiedBy= @gUserID"
                    SQL &=  " ,ModifiedTime= @CreateTime"
                    SQL &=  " ,IsInActive= @IsInActive"
                    SQL &=  " WHERE UserID= @mIDs"
                Case DataMode.ModeDelete
                    SQL = " UPDATE Admin_User SET IsDelete=@IsDelete "
                    SQL &=  " ,ModifiedBy= @gUserID"
                    SQL &=  " ,ModifiedTime= @CreateTime"
                    SQL &=  " WHERE UserID= @mIDs"
            End Select
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@mIDs", ID))
            myCommand.Parameters.Add(New SqlParameter("@EmpID", EmpID))
            myCommand.Parameters.Add(New SqlParameter("@PrivilegeID", PrivilegeID))
            myCommand.Parameters.Add(New SqlParameter("@UserName", Trim(UserName)))

            myCommand.Parameters.Add(New SqlParameter("@Remark", Trim(Remark)))
            myCommand.Parameters.Add(New SqlParameter("@gUserID", gUserID))
            myCommand.Parameters.Add(New SqlParameter("@CreateTime", formatSQLDateTime(GetCurrentDate(tr))))
            myCommand.Parameters.Add(New SqlParameter("@IsInActive", IsInActive))

            Dim lcls As New clsEncrypt
            Dim lstrPass As String
            lstrPass = lcls.encryptString(Password)
            myCommand.Parameters.Add(New SqlParameter("@Password", lstrPass))
            lcls = Nothing


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

            'Execute ALL 
            tr.Commit()
            Return True

        Catch e As Exception
            tr.Rollback()
            Err.Raise(Err.Number, e.Source, ClassName & ".SaveData : " & e.Message)
            Return False
        End Try

    End Function

    Public Function CheckExist() As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT " & ColumnKey & "  FROM " & TableName
            SQL &=  " WHERE IsDelete =0 AND UserName='" & Trim(UserName) & "'"
            If ModeData = DataMode.ModeEdit Then
                SQL &=  " AND " & ColumnKey & " <> " & ID
            End If
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            Return dataTable.Rows.Count > 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, ClassName & ".CheckExist : " & e.Message)
            Return False
        Finally
            dataTable = Nothing
        End Try

    End Function

    Public Function CheckIsToUse() As Boolean ''ถูกใช้งานอยู่ ???
        Dim MSG As String = ""
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
            Err.Raise(Err.Number, e.Source, ClassName & ".CheckNotExist : " & e.Message)
        End Try
        Return MSG
    End Function

    Public Sub New()
        mEmpID = 0
        mPrivilegeID = 0
        mclsEmployee = Nothing
        mclsPrivilege = Nothing
        mUserName = ""
        mPassword = ""
    End Sub
End Class
