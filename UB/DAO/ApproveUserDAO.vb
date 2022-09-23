Option Explicit On
Imports System.Data.SqlClient

Public Class ApproveUserDAO
    Inherits iDAO
    Private mApproveUsers1 As List(Of ApproveUserDTLDAO)
    Private mApproveUsers2 As List(Of ApproveUserDTLDAO)


#Region "Property"

    Public ReadOnly Property TableName() As String
        Get
            Return "ApproveUser"
        End Get
    End Property

    Public Property ApproveUsersDAOs1() As List(Of ApproveUserDTLDAO)
        Get
            Return mApproveUsers1
        End Get
        Set(ByVal Value As List(Of ApproveUserDTLDAO))
            mApproveUsers1 = Value
        End Set
    End Property

    Public Property ApproveUsersDAOs2() As List(Of ApproveUserDTLDAO)
        Get
            Return mApproveUsers2
        End Get
        Set(ByVal Value As List(Of ApproveUserDTLDAO))
            mApproveUsers2 = Value
        End Set
    End Property

#End Region

    Public Function CHECKSUM_AGG() As Long
        Dim SQL As String
        Dim dataTable As New DataTable()
        Try
            SQL = "SELECT CHECKSUM_AGG(BINARY_CHECKSUM(*)) FROM ApproveUser WITH (NOLOCK);"

            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    Return ConvertNullToZero(dr(0))
                    Exit For
                Next
            End If
            Return 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ApproveUserDAO.CHECKSUM_AGG : " & e.Message)
            Return 0
        Finally
            dataTable = Nothing
        End Try
    End Function


    Public Function InitailData(ByVal pID As Long) As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()
        Dim lUserDAO As New UserDAO
        'Dim lFileAttach As New FileAttachDAO
        Try
            SQL = "SELECT *   "
            SQL &=  " FROM ApproveUser "
            SQL &=  " WHERE ApproveUserID=" & pID

            SQL &=  " ORDER BY ApproveUserID"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    ID = Int32.Parse(dr("ApproveUserID"))
                    IsInActive = dr("IsInActive")
                    Remark = dr("Remark").ToString
                    CreateTime = ConvertNullToDateTime(dr("CreateTime"))
                    ModifiedTime = ConvertNullToDateTime(dr("ModifiedTime"))
                    If lUserDAO.InitailData(True, ConvertNullToZero(dr("CreateBy")), "") Then
                        CreateBy = lUserDAO.UserName
                    Else
                        CreateBy = ""
                    End If

                    If ConvertNullToZero(dr("CreateBy")) = ConvertNullToZero(dr("ModifiedBy")) Then
                        ModifiedBy = CreateBy
                    Else
                        If lUserDAO.InitailData(True, ConvertNullToZero(dr("ModifiedBy")), "") Then
                            ModifiedBy = lUserDAO.UserName
                        Else
                            ModifiedBy = ""
                        End If
                    End If



                    'Load FileAttach
                    FileAttachs = LoadFileAttach(ID, TableName, Nothing)

                    Return True
                    Exit For
                Next

            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ApproveUserDAO.InitailData : " & e.Message)
            Return False
        Finally
            lUserDAO = Nothing
            dataTable = Nothing
        End Try

    End Function


    Public Function GetInfoHtml() As String
        Dim Info As String = ""
        'Try

        '    Info = Constants.vbCrLf & Constants.vbCrLf & "รหัสแผนก: " & Code
        '    Info &= Constants.vbCrLf & "ชื่อแผนก: " & NameThai
        '    Info &= Constants.vbCrLf & "ชื่อแผนก (Eng): " & NameEng
        '    Info &= Constants.vbCrLf & "หัวหน้าแผนก: "
        '    If Not Manager Is Nothing Then
        '        Info &= Manager.Title & Manager.FirstName & " " & Manager.LastName
        '    End If
        '    Info &= Constants.vbCrLf & "รายละเอียด: " & Remark

        'Catch e As Exception
        '    Err.Raise(Err.Number, e.Source, "ApproveUserDAO.GetInfoHtml : " & e.Message)

        'End Try
        Return Info
    End Function


    Public Function GetDataTable(ByVal pID As Long, ByVal pOnlyActive As Boolean) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT ApproveUserID AS ID,Remark "
            SQL &=  " FROM ApproveUser  "
            SQL &=  " WHERE IsDelete =0   "
            If pID > 0 Then
                SQL &=  "  AND ApproveUserID=" & pID
            End If
            If pOnlyActive = True Then
                SQL &=  "  AND IsInActive = 0"
            End If
            SQL &=  " ORDER BY ApproveUserID"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ApproveUserDAO.GetDataTable : " & e.Message)
        End Try
        Return dataTable
    End Function

    Public Function SaveData() As Boolean
        Dim SQL As String
        Dim llngAddressID As Long = 0
        Dim myCommand As SqlCommand
        Dim tr As SqlTransaction = Nothing
        SQL = ""
        Try

            tr = gConnection.Connection.BeginTransaction

            Select Case ModeData
                Case DataMode.ModeNew
                    ID = GenNewID("ApproveUserID", "ApproveUser", tr)
                    SQL = " INSERT INTO ApproveUser  (ApproveUserID,Remark"
                    SQL &=  " ,CreateBy,CreateTime,IsInActive,IsDelete)"
                    SQL &=  " VALUES ( @ApproveUserID"
                    SQL &=  " ,  @Remark"
                    SQL &=  " ,  @gUserID"
                    SQL &=  " ,  @CreateTime"
                    SQL &=  " ,  @mIsInActive"
                    SQL &=  " ,  @mIsDelete"
                    SQL &=  " ) "
                Case DataMode.ModeEdit
                    SQL = " UPDATE ApproveUser SET "
                    SQL &=  " Remark=@Remark"
                    SQL &=  " ,ModifiedBy= @gUserID"
                    SQL &=  " ,ModifiedTime= @CreateTime"
                    SQL &=  " ,IsInActive= @mIsInActive"
                    SQL &=  " WHERE ApproveUserID= @ApproveUserID"
                Case DataMode.ModeDelete
                    SQL = " UPDATE ApproveUser SET IsDelete=@mIsDelete "
                    SQL &=  " ,ModifiedBy= @gUserID"
                    SQL &=  " ,ModifiedTime= @CreateTime"
                    SQL &=  " WHERE ApproveUserID= @ApproveUserID"
            End Select
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@ApproveUserID", ID))
            myCommand.Parameters.Add(New SqlParameter("@Remark", Trim(Remark)))
            myCommand.Parameters.Add(New SqlParameter("@gUserID", gUserID))
            myCommand.Parameters.Add(New SqlParameter("@CreateTime", formatSQLDateTime(GetCurrentDate(tr))))
            myCommand.Parameters.Add(New SqlParameter("@mIsInActive", IsInActive))

            Select Case ModeData
                Case DataMode.ModeNew
                    myCommand.Parameters.Add(New SqlParameter("@mIsDelete", 0))
                Case DataMode.ModeDelete
                    myCommand.Parameters.Add(New SqlParameter("@mIsDelete", 1))
            End Select
            gConnection.executeInsertSqlCommand(myCommand, tr)

            SaveNote(NoteDAOs, ModeData, ID, TableName, tr)
            SaveAttachFile(FileAttachs, ModeData, ID, TableName, tr)
            SaveApproveUserDtl(1, ApproveUsersDAOs1, ModeData, tr)
            SaveApproveUserDtl(2, ApproveUsersDAOs2, ModeData, tr)

            tr.Commit()
            Return True
        Catch e As Exception
            tr.Rollback()
            Err.Raise(Err.Number, e.Source, "ApproveUserDAO.SaveData : " & e.Message)
            Return False
        End Try

    End Function

    Public Function CheckExist() As Boolean
        'Dim SQL As String
        'Dim dataTable As New DataTable()
        Return False
        'Try
        '    'SQL = "SELECT DepartmentID  FROM Department"
        '    'SQL = SQL & " WHERE IsDelete =0 AND IDCode='" & Trim(Code) & "'"
        '    'If ModeData = DataMode.ModeEdit Then
        '    '    SQL &=  " AND DepartmentID <> " & ID
        '    'End If
        '    'dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        '    'Return dataTable.Rows.Count > 0
        'Catch ex As Exception
        '    Err.Raise(Err.Number, ex.Source, "ApproveUserDAO.CheckExist : " & ex.Message)
        '    Return False
        'Finally

        ''dataTable = Nothing
        'End Try

    End Function

    Public Function CheckIsToUse() As Boolean ''ถูกใช้งานอยู่ ???
        'Dim MSG As String = ""
        'Dim SQL As String
        'Dim dataTable As New DataTable()

        'Try
        '    SQL = "SELECT DepartmentID  FROM Position"
        '    SQL &=  " WHERE IsDelete =0 AND DepartmentID=" & ID
        '    dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        '    Return dataTable.Rows.Count = 0
        'Catch e As Exception
        '    Err.Raise(Err.Number, e.Source, "ApproveUserDAO.CheckNotExist : " & e.Message)
        'Finally
        '    dataTable = Nothing
        'End Try
        Return False
    End Function

    Public Sub New()
        mApproveUsers1 = Nothing
        mApproveUsers2 = Nothing
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
