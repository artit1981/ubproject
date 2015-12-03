Option Explicit On

Imports System.Data.SqlClient

Public Class UnitDAO
    Inherits iDAO

    Public ReadOnly Property TableName() As String
        Get
            Return "Product_Unit"
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
            Err.Raise(Err.Number, e.Source, "UnitDAO.CHECKSUM_AGG : " & e.Message)
            Return 0
        Finally
            dataTable = Nothing
        End Try
    End Function


    Public Function InitailData(ByVal pID As Long, ByVal pName As String) As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()
        Dim lUserDAO As New UserDAO

        Try
            SQL = "SELECT *   "
            SQL = SQL & " FROM Product_Unit "
            SQL = SQL & " WHERE 1=1 "
            If pID > 0 Then
                SQL = SQL & " AND UnitID=" & pID
            End If
            If pName <> "" Then
                SQL = SQL & " AND CodeThai='" & pName & "'"
            End If
            SQL = SQL & " ORDER BY UnitCode"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    ID = Int32.Parse(dr("UnitID"))
                    IsInActive = dr("IsInActive")
                    Code = dr("UnitCode").ToString
                    NameThai = dr("CodeThai").ToString
                    NameEng = dr("CodeEng").ToString
                    Code = dr("UnitCode").ToString
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
            Err.Raise(Err.Number, e.Source, "UnitDAO.InitailData : " & e.Message)
            Return False
        Finally
            lUserDAO = Nothing
            dataTable = Nothing
        End Try

    End Function


    Public Function GetInfoHtml() As String
        Dim Info As String = ""
        Try

            Info = Constants.vbCrLf & Constants.vbCrLf & "รหัสหน่วยนับ: " & Code
            Info &= Constants.vbCrLf & "ชื่อหน่วยนับ: " & NameThai
            Info &= Constants.vbCrLf & "ชื่อหน่วยนับ (Eng): " & NameEng
            
            Info &= Constants.vbCrLf & "รายละเอียด: " & Remark

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "GetInfoHtml : " & e.Message)

        End Try
        Return Info
    End Function


    Public Function GetDataTable(ByVal pID As Long, ByVal pOnlyActive As Boolean, Optional ByVal pCode As String = "", Optional ByVal pName As String = "") As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT UnitID AS ID,UnitCode,CodeThai"
            SQL = SQL & " FROM Product_Unit  "
            SQL = SQL & " WHERE IsDelete =0   "
            If pID > 0 Then
                SQL = SQL & "  AND UnitID=" & pID
            End If
            If pCode <> "" Then
                SQL = SQL & "  AND UnitCode='" & pCode.Trim & "'"
            End If
            If pName <> "" Then
                SQL = SQL & "  AND CodeThai='" & pName.Trim & "'"
            End If
            If pOnlyActive = True Then
                SQL = SQL & "  AND IsInActive = 0"
            End If
            SQL = SQL & " ORDER BY UnitCode"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "UnitDAO.GetDataTable : " & e.Message)
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
                    ID = GenNewID("UnitID", "Product_Unit", tr)
                    SQL = " INSERT INTO Product_Unit  (UnitID,UnitCode,CodeThai,CodeEng,Remark"
                    SQL = SQL & " ,CreateBy,CreateTime,IsInActive,IsDelete)"
                    SQL = SQL & " VALUES ( @mIDs"
                    SQL = SQL & " ,  @UnitCode"
                    SQL = SQL & " ,  @mNameThai"
                    SQL = SQL & " ,  @mNameEng"
                    SQL = SQL & " ,  @mRemark"
                    SQL = SQL & " ,  @gUserID"
                    SQL = SQL & " ,  @CreateTime"
                    SQL = SQL & " ,  @mIsInActive"
                    SQL = SQL & " ,  @mIsDelete"
                    SQL = SQL & " ) "
                Case DataMode.ModeEdit
                    SQL = " UPDATE Product_Unit SET "
                    SQL = SQL & " UnitCode=@UnitCode"
                    SQL = SQL & " ,CodeThai=@mNameThai"
                    SQL = SQL & " ,CodeEng=@mNameEng"
                    SQL = SQL & " ,Remark= @mRemark"
                    SQL = SQL & " ,ModifiedBy= @gUserID"
                    SQL = SQL & " ,ModifiedTime= @CreateTime"
                    SQL = SQL & " ,IsInActive= @mIsInActive"
                    SQL = SQL & " WHERE UnitID= @mIDs"
                Case DataMode.ModeDelete
                    SQL = " UPDATE Product_Unit SET IsDelete=@mIsDelete "
                    SQL = SQL & " ,ModifiedBy= @gUserID"
                    SQL = SQL & " ,ModifiedTime= @CreateTime"
                    SQL = SQL & " WHERE UnitID= @mIDs"
            End Select
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@mIDs", ID))
            myCommand.Parameters.Add(New SqlParameter("@UnitCode", Trim(Code)))
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
            Err.Raise(Err.Number, e.Source, "UnitDAO.SaveData : " & e.Message)
            Return False
        End Try

    End Function

    Public Function CheckExist() As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT UnitID  FROM Product_Unit"
            SQL = SQL & " WHERE IsDelete =0 AND UnitCode='" & Trim(Code) & "'"
            If ModeData = DataMode.ModeEdit Then
                SQL = SQL & " AND UnitID <> " & ID
            End If
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            Return dataTable.Rows.Count > 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "UnitDAO.CheckExist : " & e.Message)
            Return False
        Finally
            dataTable = Nothing
        End Try

    End Function

    Public Function CheckIsToUse() As Boolean ''ถูกใช้งานอยู่ ???

        'Dim SQL As String
        'Dim dataTable As New DataTable()

        'Try
        '    SQL = "SELECT UnitID  FROM Product_UOM"
        '    SQL = SQL & " WHERE IsDelete =0 AND UnitID=" & ID
        '    dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        '    Return dataTable.Rows.Count > 0
        'Catch e As Exception
        '    Err.Raise(Err.Number, e.Source, "UnitDAO.CheckNotExist : " & e.Message)
        'Finally
        '    dataTable = Nothing
        'End Try
        Return False
    End Function

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
