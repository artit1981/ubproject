Option Explicit On

Imports System.Data.SqlClient

Public Class PrivilegeDAO
    Inherits iDAO

    Private mMenuID As Long
    Private mPrivilege As Privilege

    Public Property PrivilegeData() As Long
        Get
            Return mPrivilege
        End Get
        Set(ByVal Value As Long)
            mPrivilege = Value
        End Set
    End Property

    Public Property MenuID() As Long
        Get
            Return mMenuID
        End Get
        Set(ByVal Value As Long)
            mMenuID = Value
        End Set
    End Property

   
    Public Function GetDataTable(ByVal pID As Long, ByVal pOnlyActive As Boolean) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT PrivilegeID AS ID,PrivilegeCode,Remark "
            SQL = SQL & " FROM Privilege  "
            SQL = SQL & " WHERE  IsDelete =0"
            If pID > 0 Then
                SQL = SQL & "  AND PrivilegeID=" & pID
            End If
            If pOnlyActive = True Then
                SQL = SQL & "  AND IsInActive = 0"
            End If
            SQL = SQL & " GROUP BY PrivilegeID,PrivilegeCode,Remark "
            SQL = SQL & " ORDER BY PrivilegeCode,Remark "
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "PrivilegeDAO.GetDataTable : " & e.Message)
        End Try
        Return dataTable

    End Function

    Public Function GetDataPrivilege(ByVal pID As Long) As DataTable
        Dim SQL As String = ""
        Dim dataTable As New DataTable()

        Try
            If pID > 0 Then
                SQL = "SELECT Privilege.MenuID,Menu.ShowMode,Menu.System,Menu.Module,Menu.MenuDisplay"
                SQL = SQL & " ,Menu.IsVisible,Menu.IsEnable,Menu.IsAdd,Menu.IsEdit"
                SQL = SQL & " ,Menu.IsDelete,Menu.IsPrint,Menu.IsImport"
                SQL = SQL & " ,Menu.IsCreateQuick,Menu.IsCopy,Menu.IsAssign,Menu.IsConvert ,Privilege.PrivilegeData,'N' AS IsNew "
                SQL = SQL & " FROM Privilege  "
                SQL = SQL & " LEFT OUTER JOIN Menu ON Privilege.MenuID=Menu.MenuID"
                SQL = SQL & " WHERE Privilege.PrivilegeID=" & pID
                SQL = SQL & " UNION ALL "
            End If
            SQL = SQL & " SELECT Menu.MenuID,Menu.ShowMode,Menu.System,Menu.Module,Menu.MenuDisplay"
            SQL = SQL & " ,Menu.IsVisible,Menu.IsEnable,Menu.IsAdd,Menu.IsEdit"
            SQL = SQL & " ,Menu.IsDelete,Menu.IsPrint,Menu.IsImport"
            SQL = SQL & " ,Menu.IsCreateQuick,Menu.IsCopy,Menu.IsAssign,Menu.IsConvert ,0 AS PrivilegeData,'Y' AS IsNew"
            SQL = SQL & " FROM Menu  "
            If pID > 0 Then
                SQL = SQL & " WHERE Menu.MenuID NOT IN (SELECT Privilege.MenuID FROM Privilege WHERE Privilege.PrivilegeID=" & pID & " )"
            End If
            SQL = SQL & " ORDER BY System,Module,MenuDisplay"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "PrivilegeDAO.GetDataPrivilege : " & e.Message)
        End Try
        Return dataTable

    End Function

    Public Function InitailData(ByVal pID As Long, ByVal pMenuID As Long) As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()
        Dim lUserDAO As New UserDAO
        'Dim lFileAttach As New NoteDAO
        Try
            SQL = "SELECT *   "
            SQL = SQL & " FROM Privilege "
            SQL = SQL & " WHERE PrivilegeID=" & pID
            If pMenuID > 0 Then
                SQL = SQL & " AND MenuID=" & pMenuID
            End If

            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    Code = dr("PrivilegeCode").ToString
                    ID = Int32.Parse(dr("PrivilegeID"))
                    IsInActive = dr("IsInActive")
                    Remark = dr("Remark").ToString
                    PrivilegeData = dr("PrivilegeData")
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

                    Return True
                    Exit For
                Next
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "PrivilegeDAO.InitailData : " & e.Message)
            Return False
        Finally
            lUserDAO = Nothing
            dataTable = Nothing
        End Try

    End Function


    Public Function CHECKSUM_AGG() As Long
        Dim SQL As String
        Dim dataTable As New DataTable()
        Try
            SQL = "SELECT CHECKSUM_AGG(BINARY_CHECKSUM(*)) FROM Privilege WITH (NOLOCK);"

            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    Return ConvertNullToZero(dr(0))
                    Exit For
                Next
            End If
            Return 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "PrivilegeDAO.CHECKSUM_AGG : " & e.Message)
            Return 0
        Finally
            dataTable = Nothing
        End Try
    End Function

    Public Function SaveData(ByVal pGrid As DevExpress.XtraGrid.Views.Grid.GridView) As Boolean
        Dim SQL As String, lLoop As Long
        Dim myCommand As SqlCommand
        Dim tr As SqlTransaction = Nothing

        SQL = ""
        Try
            tr = gConnection.Connection.BeginTransaction

            If ModeData = DataMode.ModeNew Then
                ID = GenNewID("PrivilegeID", "Privilege", tr)
            End If

            If ModeData = DataMode.ModeNew Or ModeData = DataMode.ModeEdit Then
                For lLoop = 0 To pGrid.RowCount
                    If pGrid.GetRowCellDisplayText(lLoop, "MenuID").Trim <> "" Then
                        If ModeData = DataMode.ModeNew Or pGrid.GetRowCellDisplayText(lLoop, "IsNew").Trim = "Y" Then
                            SQL = " INSERT INTO Privilege  (PrivilegeID,PrivilegeCode,Remark,MenuID,PrivilegeData"
                            SQL = SQL & " ,CreateBy,CreateTime,IsInActive,IsDelete)"
                            SQL = SQL & " VALUES ( @mIDs"
                            SQL = SQL & " ,  @mPrivilegeCode"
                            SQL = SQL & " ,  @mRemark"
                            SQL = SQL & " ,  @mMenuID"
                            SQL = SQL & " ,  @mPrivilegeData"
                            SQL = SQL & " ,  @gUserID"
                            SQL = SQL & " ,  @CreateTime"
                            SQL = SQL & " ,  @mIsInActive"
                            SQL = SQL & " ,  @mIsDelete"
                            SQL = SQL & " ) "
                        ElseIf ModeData = DataMode.ModeEdit Then
                            SQL = " UPDATE Privilege SET "
                            SQL = SQL & " PrivilegeCode=@mPrivilegeCode"
                            SQL = SQL & " ,Remark= @mRemark"
                            SQL = SQL & " ,PrivilegeData= @mPrivilegeData"
                            SQL = SQL & " ,ModifiedBy= @gUserID"
                            SQL = SQL & " ,ModifiedTime= @CreateTime"
                            SQL = SQL & " ,IsInActive= @mIsInActive"
                            SQL = SQL & " WHERE PrivilegeID= @mIDs"
                            SQL = SQL & " AND MenuID= @mMenuID"

                        End If

                        myCommand = New SqlCommand
                        myCommand.CommandText = SQL
                        myCommand.Parameters.Add(New SqlParameter("@mIDs", ID))
                        myCommand.Parameters.Add(New SqlParameter("@mPrivilegeCode", Trim(Code)))
                        myCommand.Parameters.Add(New SqlParameter("@mRemark", Trim(Remark)))
                        myCommand.Parameters.Add(New SqlParameter("@mMenuID", pGrid.GetRowCellDisplayText(lLoop, "MenuID").Trim))
                        myCommand.Parameters.Add(New SqlParameter("@mPrivilegeData", pGrid.GetRowCellDisplayText(lLoop, "PrivilegeData").Trim))

                        myCommand.Parameters.Add(New SqlParameter("@gUserID", gUserID))
                        myCommand.Parameters.Add(New SqlParameter("@CreateTime", formatSQLDateTime(GetCurrentDate(tr))))
                        myCommand.Parameters.Add(New SqlParameter("@mIsInActive", IsInActive))
                        myCommand.Parameters.Add(New SqlParameter("@mIsDelete", 0))
                        gConnection.executeInsertSqlCommand(myCommand, tr)
                    End If


                Next lLoop

            Else ''Delete
                SQL = " UPDATE Privilege SET IsDelete=@mIsDelete "
                SQL = SQL & " ,ModifiedBy= @gUserID"
                SQL = SQL & " ,ModifiedTime= @CreateTime"
                SQL = SQL & " WHERE PrivilegeID= @mIDs"
                myCommand = New SqlCommand
                myCommand.CommandText = SQL
                myCommand.Parameters.Add(New SqlParameter("@mIDs", ID))
                myCommand.Parameters.Add(New SqlParameter("@gUserID", gUserID))
                myCommand.Parameters.Add(New SqlParameter("@CreateTime", formatSQLDateTime(GetCurrentDate(tr))))
                myCommand.Parameters.Add(New SqlParameter("@mIsDelete", 1))
                gConnection.executeInsertSqlCommand(myCommand, tr)
            End If

            'Execute ALL 
            tr.Commit()
            Return True

        Catch e As Exception
            tr.Rollback()
            Err.Raise(Err.Number, e.Source, "PrivilegeDAO.SaveData : " & e.Message)
            Return False
        End Try


    End Function

    Public Function CheckExist() As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT PrivilegeID  FROM Privilege"
            SQL = SQL & " WHERE IsDelete =0 AND PrivilegeCode='" & Trim(Code) & "'"
            If ModeData = DataMode.ModeEdit Then
                SQL = SQL & " AND PrivilegeID <> " & ID
            End If
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            Return dataTable.Rows.Count > 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "PrivilegeDAO.CheckExist : " & e.Message)
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
            Err.Raise(Err.Number, e.Source, "PrivilegeDAO.CheckNotExist : " & e.Message)
        End Try
        Return False
    End Function
End Class
