Imports System.Data.SqlClient
Public Class ProductTypeDAO
    Inherits iDAO

    'Private mProductCategoryID As Long
    'Private mProductCategoryDAO As ProductCategoryDAO

    'Public Property ProductCategoryID() As Long
    '    Get
    '        Return mProductCategoryID
    '    End Get
    '    Set(ByVal value As Long)
    '        mProductCategoryID = value
    '    End Set
    'End Property

    'Public ReadOnly Property ProductCategory() As ProductCategoryDAO
    '    Get
    '        If mProductCategoryID > 0 And mProductCategoryDAO Is Nothing Then
    '            mProductCategoryDAO = Nothing
    '            mProductCategoryDAO = New ProductCategoryDAO
    '            mProductCategoryDAO.InitailData(mProductCategoryID, Nothing, "")
    '        End If
    '        Return mProductCategoryDAO
    '    End Get
    'End Property

    Public ReadOnly Property TableName() As String
        Get
            Return "ProductType"
        End Get
    End Property

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
            Err.Raise(Err.Number, e.Source, "ProductTypeDAO.CHECKSUM_AGG : " & e.Message)
            Return 0
        Finally
            dataTable = Nothing
        End Try
    End Function

    Public Function InitailData(ByVal pID As Long, ByRef tr As SqlTransaction, ByVal pCode As String) As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()
        Dim lUserDAO As New UserDAO
        Try
            SQL = "SELECT *   "
            SQL = SQL & " FROM ProductType"
            SQL = SQL & " WHERE 1=1 "
            If pID > 0 Then
                SQL = SQL & " and ProductTypeID=" & pID
            End If
            If pCode <> "" Then
                SQL = SQL & " and NameThai='" & pCode & "'"
            End If

            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows

                    ID = Int32.Parse(dr("ProductTypeID"))
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

                    'ProductCategoryID = ConvertNullToZero(dr("ProductCategoryID"))

                    'Load FileAttach
                    FileAttachs = LoadFileAttach(ID, TableName, tr)

                    Return True
                    Exit For
                Next
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProductTypeDAO.InitailData : " & e.Message)
            Return False
        Finally
            lUserDAO = Nothing
            dataTable = Nothing
        End Try

    End Function


    Public Function GetInfoHtml() As String
        Dim Info As String = ""
        Try

            'Info = Constants.vbCrLf & Constants.vbCrLf & "รหัสคลัง: " & Code
            'Info &= Constants.vbCrLf & "ชื่อคลัง: " & NameThai
            'Info &= Constants.vbCrLf & "ชื่อคลัง (Eng): " & NameEng
            'Info &= Constants.vbCrLf & "ผู้ดูแล: "
            'If Not Employee Is Nothing Then
            '    Info &= Employee.Title & Employee.FirstName & " " & Employee.LastName
            'End If
            'Info &= Constants.vbCrLf & "สิทธิ์การใช้งาน: " & PrivilegeBy
            'Info &= Constants.vbCrLf & "กลุ่มพนักงาน: "
            'If Not EmpGroup Is Nothing Then
            '    Info &= EmpGroup.NameThai
            'End If
            'Info &= Constants.vbCrLf & "รายละเอียด: " & Remark

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProductTypeDAO.GetInfoHtml : " & e.Message)

        End Try
        Return Info
    End Function

    Public Function GetDataTable(ByVal pID As Long, ByVal pOnlyActive As Boolean, ByVal pProCategoryID As Long) As DataTable
        Dim SQL As String, lstrProTypeID As String = ""
        Dim dataTable As New DataTable()

        Try
            If pProCategoryID > 0 Then
                SQL = "SELECT ProductTypeID"
                SQL = SQL & " FROM ProductCategory  "
                SQL = SQL & " WHERE CategoryID =" & pProCategoryID
                dataTable = gConnection.executeSelectQuery(SQL, Nothing)
                If dataTable.Rows.Count > 0 Then
                    For Each dr As DataRow In dataTable.Rows
                        lstrProTypeID = ConvertNullToString(dr("ProductTypeID"))
                    Next
                End If
            End If
            
            SQL = "SELECT ProductTypeID AS ID,IDCode,NameThai "
            SQL = SQL & " FROM ProductType  "
            SQL = SQL & " WHERE IsDelete =0   "
            If pID > 0 Then
                SQL = SQL & "  AND ProductTypeID=" & pID
            End If
            If lstrProTypeID <> "" Then
                SQL = SQL & "  AND ProductTypeID in(" & lstrProTypeID & ")"
            End If
            If pOnlyActive = True Then
                SQL = SQL & "  AND IsInActive = 0"
            End If
            SQL = SQL & " ORDER BY IDCode,NameThai"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProductTypeDAO.GetDataTable : " & e.Message)
        End Try
        Return dataTable
    End Function

    'Public Function GetDataTableCombo(ByVal pID As Long, ByVal pOnlyActive As Boolean) As DataTable
    '    Dim SQL As String
    '    Dim dataTable As New DataTable()

    '    Try
    '        SQL = "SELECT ProductTypeID AS ID,IDCode,NameThai"
    '        SQL = SQL & " FROM ProductType "

    '        SQL = SQL & " WHERE IsDelete =0   "
    '        If pID > 0 Then
    '            SQL = SQL & "  AND ProductTypeID=" & pID
    '        End If
    '        If pOnlyActive = True Then
    '            SQL = SQL & "  AND IsInActive = 0"
    '        End If
    '        SQL = SQL & " ORDER BY IDCode,NameThai"
    '        dataTable = gConnection.executeSelectQuery(SQL, Nothing)
    '    Catch e As Exception
    '        Err.Raise(Err.Number, e.Source, "ProductTypeDAO.GetDataTable : " & e.Message)
    '    End Try
    '    Return dataTable
    'End Function

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

                    ID = GenNewID("ProductTypeID", "ProductType", tr)
                    SQL = " INSERT INTO ProductType  (ProductTypeID,IDCode,NameThai,NameEng"
                    SQL = SQL & " ,Remark" ',ProductCategoryID "
                    SQL = SQL & " ,CreateBy,CreateTime,IsInActive,IsDelete "

                    SQL = SQL & " )"
                    SQL = SQL & " VALUES ( @mIDs"
                    SQL = SQL & " ,  @IDCode"
                    SQL = SQL & " ,  @NameThai"
                    SQL = SQL & " ,  @NameEng"
                    SQL = SQL & " ,  @Remark"
                    'SQL = SQL & " ,  @ProductCategoryID"
                    SQL = SQL & " ,  @gUserID"
                    SQL = SQL & " ,  @CreateTime"
                    SQL = SQL & " ,  @mIsInActive"
                    SQL = SQL & " ,  @mIsDelete"
                    SQL = SQL & " ) "
                Case DataMode.ModeEdit
                    SQL = " UPDATE ProductType SET "
                    SQL = SQL & " IDCode=@IDCode"
                    SQL = SQL & " ,NameThai=@NameThai"
                    SQL = SQL & " ,NameEng=@NameEng"
                    SQL = SQL & " ,Remark=@Remark"
                    'SQL = SQL & " ,ProductCategoryID=@ProductCategoryID"
                    SQL = SQL & " ,ModifiedBy= @gUserID"
                    SQL = SQL & " ,ModifiedTime= @CreateTime"
                    SQL = SQL & " ,IsInActive= @mIsInActive"
                    SQL = SQL & " WHERE ProductTypeID= @mIDs"
                Case DataMode.ModeDelete
                    SQL = " UPDATE ProductType SET IsDelete=@mIsDelete "
                    SQL = SQL & " ,ModifiedBy= @gUserID"
                    SQL = SQL & " ,ModifiedTime= @CreateTime"
                    SQL = SQL & " WHERE ProductTypeID= @mIDs"
            End Select
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@mIDs", ID))
            myCommand.Parameters.Add(New SqlParameter("@IDCode", Trim(Code)))
            myCommand.Parameters.Add(New SqlParameter("@NameThai", Trim(NameThai)))
            myCommand.Parameters.Add(New SqlParameter("@NameEng", Trim(NameEng)))
            myCommand.Parameters.Add(New SqlParameter("@Remark", Trim(Remark)))
            'myCommand.Parameters.Add(New SqlParameter("@ProductCategoryID", ConvertNullToZero(ProductCategoryID)))
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
            Err.Raise(Err.Number, e.Source, "ProductTypeDAO.SaveData : " & e.Message)
            Return False
        End Try

    End Function


    Public Function CheckExist() As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT ProductTypeID  FROM ProductType"
            SQL = SQL & " WHERE IsDelete =0  "
            SQL = SQL & "  AND IDCode='" & Trim(Code) & "'"
            If ModeData = DataMode.ModeEdit Then
                SQL = SQL & " AND ProductTypeID <> " & ID
            End If
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            Return dataTable.Rows.Count > 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProductTypeDAO.CheckExist : " & e.Message)
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
            Err.Raise(Err.Number, e.Source, "ProductTypeDAO.CheckNotExist : " & e.Message)
        End Try
        Return False
    End Function


    Public Sub New()
        'mProductCategoryID = 0
        'mProductCategoryDAO = Nothing
    End Sub
End Class
