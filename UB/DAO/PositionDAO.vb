Option Explicit On
Imports System.Data.SqlClient

Public Class PositionDAO
    Inherits iDAO

    Private mDepartmentID As Long
    Private mclsDepartment As DepartmentDAO


    Public ReadOnly Property TableName() As String
        Get
            Return "Position"
        End Get
    End Property

    Public ReadOnly Property ColumnKey() As String
        Get
            Return "PositionID"
        End Get
    End Property

    Public ReadOnly Property ClassName() As String
        Get
            Return "PositionDAO"
        End Get
    End Property

    Public Property DepartmentID() As Long
        Get
            Return mDepartmentID
        End Get
        Set(ByVal value As Long)
            mDepartmentID = value
        End Set
    End Property

    Public ReadOnly Property Department() As DepartmentDAO
        Get

            If DepartmentID > 0 And mclsDepartment Is Nothing Then
                mclsDepartment = New DepartmentDAO
                mclsDepartment.InitailData(DepartmentID)
            End If
            Return mclsDepartment
        End Get
    End Property

    Public Function CHECKSUM_AGG() As Long
        Dim SQL As String
        Dim dataTable As New DataTable()
        Try
            SQL = "SELECT CHECKSUM_AGG(BINARY_CHECKSUM(*))  "
            SQL = SQL & " FROM  " & TableName
            SQL = SQL & " WITH (NOLOCK);"
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
        'Dim lFileAttach As New FileAttachDAO
        Try
            SQL = "SELECT *   "
            SQL = SQL & " FROM  " & TableName
            SQL = SQL & " WHERE " & ColumnKey & "=" & pID

            SQL = SQL & " ORDER BY IDCode"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    ID = Int32.Parse(dr(ColumnKey))
                    IsInActive = dr("IsInActive")
                    NameThai = dr("NameThai").ToString
                    NameEng = dr("NameEng").ToString
                    Code = dr("IDCode").ToString
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

                    'Department
                    DepartmentID = ConvertNullToZero(dr("DepartmentID"))


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

            Info = Constants.vbCrLf & Constants.vbCrLf & "รหัสตำแหน่ง: " & Code
            Info &= Constants.vbCrLf & "ชื่อตำแหน่ง: " & NameThai
            Info &= Constants.vbCrLf & "ชื่อตำแหน่ง (Eng): " & NameEng
            If Not mclsDepartment Is Nothing Then
                Info &= Constants.vbCrLf & "แผนก: " & mclsDepartment.NameThai
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
            SQL = "SELECT PositionID AS ID,IDCode,NameThai"
            SQL = SQL & " FROM Position  "
            SQL = SQL & " WHERE IsDelete =0   "
            If pID > 0 Then
                SQL = SQL & "  AND PositionID=" & pID
            End If
            If pOnlyActive = True Then
                SQL = SQL & "  AND IsInActive = 0"
            End If
            SQL = SQL & " ORDER BY IDCode"
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
            SQL = "SELECT PositionID AS ID,IDCode,NameThai"
            SQL = SQL & " FROM Position  "
            SQL = SQL & " WHERE IsDelete =0   "
            If pID > 0 Then
                SQL = SQL & "  AND PositionID=" & pID
            End If
            If pOnlyActive = True Then
                SQL = SQL & "  AND IsInActive = 0"
            End If
            SQL = SQL & " ORDER BY IDCode"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, ClassName & ".GetDataTableForCombo : " & e.Message)
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
                    SQL = " INSERT INTO Position  (PositionID,DepartmentID,IDCode,NameThai,NameEng,Remark"
                    SQL = SQL & " ,CreateBy,CreateTime,IsInActive,IsDelete)"
                    SQL = SQL & " VALUES ( @mIDs"
                    SQL = SQL & " ,  @mDepartmentID"
                    SQL = SQL & " ,  @mIDCode"
                    SQL = SQL & " ,  @mNameThai"
                    SQL = SQL & " ,  @mNameEng"
                    SQL = SQL & " ,  @mRemark"
                    SQL = SQL & " ,  @gUserID"
                    SQL = SQL & " ,  @CreateTime"
                    SQL = SQL & " ,  @mIsInActive"
                    SQL = SQL & " ,  @mIsDelete"
                    SQL = SQL & " ) "
                Case DataMode.ModeEdit
                    SQL = " UPDATE Position SET "
                    SQL = SQL & " IDCode=@mIDCode"
                    SQL = SQL & " ,DepartmentID=@mDepartmentID"
                    SQL = SQL & " ,NameThai=@mNameThai"
                    SQL = SQL & " ,NameEng=@mNameEng"
                    SQL = SQL & " ,Remark= @mRemark"
                    SQL = SQL & " ,ModifiedBy= @gUserID"
                    SQL = SQL & " ,ModifiedTime= @CreateTime"
                    SQL = SQL & " ,IsInActive= @mIsInActive"
                    SQL = SQL & " WHERE PositionID= @mIDs"
                Case DataMode.ModeDelete
                    SQL = " UPDATE Position SET IsDelete=@mIsDelete "
                    SQL = SQL & " ,ModifiedBy= @gUserID"
                    SQL = SQL & " ,ModifiedTime= @CreateTime"
                    SQL = SQL & " WHERE PositionID= @mIDs"
            End Select
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@mIDs", ID))
            myCommand.Parameters.Add(New SqlParameter("@mDepartmentID", DepartmentID))
            myCommand.Parameters.Add(New SqlParameter("@mIDCode", Trim(Code)))
            myCommand.Parameters.Add(New SqlParameter("@mNameThai", Trim(NameThai)))
            myCommand.Parameters.Add(New SqlParameter("@mNameEng", Trim(NameEng)))
            myCommand.Parameters.Add(New SqlParameter("@mRemark", Trim(Remark)))
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

            'Save Note
            SaveNote(NoteDAOs, ModeData, ID, TableName, tr)

            'Save Attach file
            SaveAttachFile(FileAttachs, ModeData, ID, TableName, tr)


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
            SQL = SQL & " WHERE IsDelete =0 AND IDCode='" & Trim(Code) & "'"
            If ModeData = DataMode.ModeEdit Then
                SQL = SQL & " AND " & ColumnKey & " <> " & ID
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
            '    SQL = SQL & " AND LeadID <> " & mIDs
            'End If
            'dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            'Return dataTable.Rows.Count > 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, ClassName & ".CheckNotExist : " & e.Message)
        End Try
        Return False
    End Function

    Public Sub New()
        mDepartmentID = 0
        mclsDepartment = Nothing
    End Sub
End Class
