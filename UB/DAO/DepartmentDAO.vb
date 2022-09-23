Option Explicit On

Imports System.Data.SqlClient



Public Class DepartmentDAO
    Inherits iDAO
    Private mManagerID As Long
    Private mclsManager As EmployeeDAO

#Region "Property"

    Public ReadOnly Property TableName() As String
        Get
            Return "Department"
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

#End Region

    Public Function CHECKSUM_AGG() As Long
        Dim SQL As String
        Dim dataTable As New DataTable()
        Try
            SQL = "SELECT CHECKSUM_AGG(BINARY_CHECKSUM(*)) FROM Department WITH (NOLOCK);"

            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    Return ConvertNullToZero(dr(0))
                    Exit For
                Next
            End If
            Return 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "DepartmentDAO.CHECKSUM_AGG : " & e.Message)
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
            SQL &=  " FROM Department "
            SQL &=  " WHERE DepartmentID=" & pID

            SQL &=  " ORDER BY IDCode"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    ID = Int32.Parse(dr("DepartmentID"))
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

                    ManagerID = ConvertNullToZero(dr("ManagerID"))

                    'Load FileAttach
                    FileAttachs = LoadFileAttach(ID, TableName, Nothing)

                    ''Load Note
                    'NoteDAOs = LoadNote(ID, TableName)

                    Return True
                    Exit For
                Next

            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "DepartmentDAO.InitailData : " & e.Message)
            Return False
        Finally
            lUserDAO = Nothing
            dataTable = Nothing
        End Try

    End Function


    Public Function GetInfoHtml() As String
        Dim Info As String = ""
        Try

            Info = Constants.vbCrLf & Constants.vbCrLf & "รหัสแผนก: " & Code
            Info &= Constants.vbCrLf & "ชื่อแผนก: " & NameThai
            Info &= Constants.vbCrLf & "ชื่อแผนก (Eng): " & NameEng
            Info &= Constants.vbCrLf & "หัวหน้าแผนก: "
            If Not Manager Is Nothing Then
                Info &= Manager.Title & Manager.FirstName & " " & Manager.LastName
            End If
            Info &= Constants.vbCrLf & "รายละเอียด: " & Remark

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "DepartmentDAO.GetInfoHtml : " & e.Message)

        End Try
        Return Info
    End Function


    Public Function GetDataTable(ByVal pID As Long, ByVal pOnlyActive As Boolean) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT DepartmentID AS ID,IDCode,NameThai"
            SQL &=  " FROM Department  "
            SQL &=  " WHERE IsDelete =0   "
            If pID > 0 Then
                SQL &=  "  AND DepartmentID=" & pID
            End If
            If pOnlyActive = True Then
                SQL &=  "  AND IsInActive = 0"
            End If
            SQL &=  " ORDER BY IDCode"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "DepartmentDAO.GetDataTable : " & e.Message)
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
                    ID = GenNewID("DepartmentID", "Department", tr)
                    SQL = " INSERT INTO Department  (DepartmentID,ManagerID,IDCode,NameThai,NameEng,Remark"
                    SQL &=  " ,CreateBy,CreateTime,IsInActive,IsDelete)"
                    SQL &=  " VALUES ( @mIDs"
                    SQL &=  " ,  @ManagerID"
                    SQL &=  " ,  @mIDCode"
                    SQL &=  " ,  @mNameThai"
                    SQL &=  " ,  @mNameEng"
                    SQL &=  " ,  @mRemark"
                    SQL &=  " ,  @gUserID"
                    SQL &=  " ,  @CreateTime"
                    SQL &=  " ,  @mIsInActive"
                    SQL &=  " ,  @mIsDelete"
                    SQL &=  " ) "
                Case DataMode.ModeEdit
                    SQL = " UPDATE Department SET "
                    SQL &=  " IDCode=@mIDCode"
                    SQL &=  " ,NameThai=@mNameThai"
                    SQL &=  " ,ManagerID=@ManagerID"
                    SQL &=  " ,NameEng=@mNameEng"
                    SQL &=  " ,Remark= @mRemark"
                    SQL &=  " ,ModifiedBy= @gUserID"
                    SQL &=  " ,ModifiedTime= @CreateTime"
                    SQL &=  " ,IsInActive= @mIsInActive"
                    SQL &=  " WHERE DepartmentID= @mIDs"
                Case DataMode.ModeDelete
                    SQL = " UPDATE Department SET IsDelete=@mIsDelete "
                    SQL &=  " ,ModifiedBy= @gUserID"
                    SQL &=  " ,ModifiedTime= @CreateTime"
                    SQL &=  " WHERE DepartmentID= @mIDs"
            End Select
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@mIDs", ID))
            myCommand.Parameters.Add(New SqlParameter("@ManagerID", ManagerID))
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
            Err.Raise(Err.Number, e.Source, "DepartmentDAO.SaveData : " & e.Message)
            Return False
        End Try

    End Function

    Public Function CheckExist() As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT DepartmentID  FROM Department"
            SQL &=  " WHERE IsDelete =0 AND IDCode='" & Trim(Code) & "'"
            If ModeData = DataMode.ModeEdit Then
                SQL &=  " AND DepartmentID <> " & ID
            End If
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            Return dataTable.Rows.Count > 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "DepartmentDAO.CheckExist : " & e.Message)
            Return False
        Finally
            dataTable = Nothing
        End Try

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
        '    Err.Raise(Err.Number, e.Source, "DepartmentDAO.CheckNotExist : " & e.Message)
        'Finally
        '    dataTable = Nothing
        'End Try
        Return False
    End Function

    Public Sub New()
        mclsManager = Nothing
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
