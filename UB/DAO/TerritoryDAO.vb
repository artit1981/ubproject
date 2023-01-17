Imports System.Data.SqlClient

Public Class TerritoryDAO
    Inherits iDAO

    Private mManagerID As Long
    Private mclsManager As EmployeeDAO

    Public ReadOnly Property TableName() As String
        Get
            Return "Territory"
        End Get
    End Property

    Public ReadOnly Property ColumnKey() As String
        Get
            Return "TerritoryID"
        End Get
    End Property

    Public ReadOnly Property ClassName() As String
        Get
            Return "TerritoryDAO"
        End Get
    End Property

    Public Property ManagerID() As Long
        Get
            Return mManagerID
        End Get
        Set(ByVal value As Long)
            mManagerID = value
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

    Public ReadOnly Property Manager() As EmployeeDAO
        Get
            If ManagerID > 0 And mclsManager Is Nothing Then
                mclsManager = Nothing
                mclsManager = New EmployeeDAO
                mclsManager.InitailData(ManagerID)
            End If
            Return mclsManager
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


    Public Function InitailData(ByVal pID As Long) As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()
        Dim lUserDAO As New UserDAO

        Try
            SQL = "SELECT *   "
            SQL &=  " FROM  " & TableName
            SQL &=  " WHERE " & ColumnKey & "=" & pID
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    ID = Int32.Parse(dr(ColumnKey))
                    IsInActive = dr("IsInActive")
                    NameThai = dr("NameThai").ToString
                    NameEng = dr("NameEng").ToString
                    Remark = dr("Remark").ToString
                    Code = dr("TerritoryCode").ToString
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

                    ' Manager
                    ManagerID = Int32.Parse(dr("ManagerID"))
                    CommissionID = ConvertNullToZero(dr("CommissionID"))
                    'Load FileAttach
                    FileAttachs = LoadFileAttach(ID, TableName, Nothing)

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

            Info = Constants.vbCrLf & Constants.vbCrLf & "รหัสทีมขาย: " & Code
            Info &= Constants.vbCrLf & "ชื่อทีมขาย: " & NameThai
            Info &= Constants.vbCrLf & "ชื่อทีมขาย (Eng): " & NameEng
            Info &= Constants.vbCrLf & "หัวหน้าแผนก: "
            If Not mclsManager Is Nothing Then
                Info &= mclsManager.Title & mclsManager.FirstName & " " & mclsManager.LastName
            End If

            Info &= Constants.vbCrLf & "รายละเอียด: " & Remark

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, ClassName & ".GetInfoHtml : " & e.Message)

        End Try
        Return Info
    End Function


    Public Function GetDataTable(ByVal pID As Long, ByVal pOnlyActive As Boolean, Optional ByVal pSQL As String = "") As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT TerritoryID  AS ID,TerritoryCode,NameThai"
            SQL &= " FROM Territory  "
            SQL &= " WHERE IsDelete =0   "
            If pID > 0 Then
                SQL &= "  AND TerritoryID=" & pID
            End If
            If pOnlyActive = True Then
                SQL &= "  AND IsInActive = 0"
            End If
            If pSQL <> "" Then
                SQL &= pSQL
            End If
            SQL &= " ORDER BY TerritoryCode,NameThai"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, ClassName & ".GetDataTable : " & e.Message)
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
                    ID = GenNewID(ColumnKey, TableName, tr)
                    SQL = " INSERT INTO Territory  (TerritoryID,ManagerID,CommissionID,TerritoryCode,NameThai,NameEng,Remark"
                    SQL &=  " ,CreateBy,CreateTime,IsInActive,IsDelete)"
                    SQL &=  " VALUES ( @mIDs"
                    SQL &= " ,  @ManagerID"
                    SQL &= " ,  @CommissionID"
                    SQL &=  " ,  @TerritoryCode"
                    SQL &=  " ,  @NameThai"
                    SQL &=  " ,  @NameEng"
                    SQL &=  " ,  @Remark"
                    SQL &=  " ,  @gUserID"
                    SQL &=  " ,  @CreateTime"
                    SQL &=  " ,  @IsInActive"
                    SQL &=  " ,  @IsDelete"
                    SQL &=  " ) "
                Case DataMode.ModeEdit
                    SQL = " UPDATE Territory SET "
                    SQL &=  " TerritoryCode=@TerritoryCode"
                    SQL &= " ,ManagerID=@ManagerID"
                    SQL &= " ,CommissionID=@CommissionID"
                    SQL &=  " ,NameThai=@NameThai"
                    SQL &=  " ,NameEng=@NameEng"
                    SQL &=  " ,Remark= @Remark"
                    SQL &=  " ,ModifiedBy= @gUserID"
                    SQL &=  " ,ModifiedTime= @CreateTime"
                    SQL &=  " ,IsInActive= @IsInActive"
                    SQL &=  " WHERE TerritoryID= @mIDs"
                Case DataMode.ModeDelete
                    SQL = " UPDATE Territory SET IsDelete=@IsDelete "
                    SQL &=  " ,ModifiedBy= @gUserID"
                    SQL &=  " ,ModifiedTime= @CreateTime"
                    SQL &=  " WHERE TerritoryID= @mIDs"
            End Select
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@mIDs", ID))
            myCommand.Parameters.Add(New SqlParameter("@ManagerID", ManagerID))
            myCommand.Parameters.Add(New SqlParameter("@CommissionID", CommissionID))
            myCommand.Parameters.Add(New SqlParameter("@TerritoryCode", Trim(Code)))
            myCommand.Parameters.Add(New SqlParameter("@NameThai", Trim(NameThai)))
            myCommand.Parameters.Add(New SqlParameter("@NameEng", Trim(NameEng)))
            myCommand.Parameters.Add(New SqlParameter("@Remark", Trim(Remark)))
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
            SQL &=  " WHERE IsDelete =0 AND TerritoryCode='" & Trim(Code) & "'"
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
        Return False
    End Function

    Public Sub New()
        mManagerID = 0
        mclsManager = Nothing
    End Sub
End Class
