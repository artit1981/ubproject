﻿Option Explicit On

Imports System.Data.SqlClient

Public Class MasterDAO
    Inherits iDAO

    Public Function InitailData(ByVal pID As Long, ByVal pMasterType As Long, Optional ByVal pCode As String = "") As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()
        Dim lUserDAO As New UserDAO
        Try
            SQL = "SELECT *   "
            SQL = SQL & " FROM " & GetMasterTableName(pMasterType)
            SQL = SQL & " WHERE 1=1 "
            If pID > 0 Then
                SQL = SQL & " AND MasterID=" & pID
            End If
            If pCode.Trim <> "" Then
                SQL = SQL & " AND CodeThai='" & pCode.Trim & "'"
            End If

            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    ID = Int32.Parse(dr("MasterID"))
                    IsInActive = dr("IsInActive")
                    NameThai = dr("CodeThai").ToString
                    NameEng = dr("CodeEng").ToString
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
                    Return True
                    Exit For
                Next
            Else
                NameThai = ""
                NameEng = ""
                Remark = ""
                CreateBy = ""
                ModifiedBy = ""
                CreateTime = ""
                ModifiedTime = ""
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "MasterDAO.InitailData : " & e.Message)
            Return False
        Finally
            lUserDAO = Nothing
            dataTable = Nothing
        End Try

    End Function


    Public Function GetDataTable(ByVal pID As Long, ByVal pTable As String, ByVal pOnlyActive As Boolean, Optional ByVal pSortByID As Boolean = False, Optional ByVal pProCategoryID As Long = 0) As DataTable
        Dim SQL As String, lstrProGroup As String = ""
        Dim dataTable As New DataTable()

        Try
            If pProCategoryID > 0 And pTable = "ProductGroup" Then
                SQL = "SELECT ProductGroupID"
                SQL = SQL & " FROM ProductCategory  "
                SQL = SQL & " WHERE CategoryID =" & pProCategoryID
                dataTable = gConnection.executeSelectQuery(SQL, Nothing)
                If dataTable.Rows.Count > 0 Then
                    For Each dr As DataRow In dataTable.Rows
                        lstrProGroup = ConvertNullToString(dr("ProductGroupID"))
                    Next
                End If
            End If

            SQL = "SELECT MasterID AS ID,CodeThai,CodeEng,Remark"
            SQL = SQL & " FROM " & pTable
            SQL = SQL & " WHERE IsDelete= 0   "
            If pID > 0 Then
                SQL = SQL & "AND MasterID=" & pID
            End If
            If lstrProGroup <> "" Then
                SQL = SQL & "AND MasterID in (" & lstrProGroup & ")"
            End If
            If pOnlyActive = True Then
                SQL = SQL & "  AND IsInActive = 0"
            End If
            If pSortByID = True Then
                SQL = SQL & " ORDER BY MasterID"
            Else
                SQL = SQL & " ORDER BY CodeThai"
            End If

            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "MasterDAO.GetDataTable : " & e.Message)
        End Try
        Return dataTable
    End Function

    Public Function SaveData(ByVal pTable As String) As Boolean
        Dim SQL As String
        SQL = ""
        Try
            Select Case ModeData
                Case DataMode.ModeNew
                    ID = GenNewID("MasterID", pTable, Nothing)
                    SQL = " INSERT INTO " & pTable & "  (MasterID,CodeThai,CodeEng,Remark,CreateBy,CreateTime,IsInActive,IsDelete )"
                    SQL = SQL & " VALUES ( " & ID
                    SQL = SQL & " , '" & Trim(NameThai) & "'"
                    SQL = SQL & " , '" & Trim(NameEng) & "'"
                    SQL = SQL & " , '" & Trim(Remark) & "'"
                    SQL = SQL & " , " & gUserID
                    SQL = SQL & " , '" & formatSQLDateTime(GetCurrentDate(Nothing)) & "'"
                    SQL = SQL & " ,0 "
                    SQL = SQL & " ,0 "
                    SQL = SQL & " ) "
                Case DataMode.ModeEdit
                    SQL = " UPDATE " & pTable & " SET "
                    SQL = SQL & " CodeThai= '" & Trim(NameThai) & "'"
                    SQL = SQL & " ,CodeEng= '" & Trim(NameEng) & "'"
                    SQL = SQL & " ,Remark= '" & Trim(Remark) & "'"
                    SQL = SQL & " ,ModifiedBy= " & gUserID
                    SQL = SQL & " ,ModifiedTime=  '" & formatSQLDateTime(GetCurrentDate(Nothing)) & "'"
                    SQL = SQL & " ,IsInActive=   " & IIf(IsInActive = True, 1, 0)
                    SQL = SQL & " WHERE MasterID= " & ID
                Case DataMode.ModeDelete
                    SQL = " UPDATE " & pTable & "  SET IsDelete = 1"
                    SQL = SQL & " ,ModifiedBy= " & gUserID
                    SQL = SQL & " ,ModifiedTime=  '" & formatSQLDateTime(GetCurrentDate(Nothing)) & "'"
                    SQL = SQL & " WHERE MasterID= " & ID
            End Select
            Return gConnection.executeInsertQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "MasterDAO.SaveData : " & e.Message)
            Return False
        End Try

    End Function

    Public Function CheckExist(ByVal pTable As String) As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT MasterID  FROM " & pTable & ""
            SQL = SQL & " WHERE CodeThai='" & Trim(NameThai) & "'"
            SQL = SQL & " AND IsDelete =0  "
            If ModeData = DataMode.ModeEdit Then
                SQL = SQL & "  AND MasterID <> " & ID
            End If
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            Return dataTable.Rows.Count > 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "MasterDAO.CheckExist : " & e.Message)
            Return False
        Finally
            dataTable = Nothing
        End Try

    End Function

    Public Function CheckNotExist(ByVal pTable As String) As String ''ถูกใช้งานอยู่ ???
        Dim MSG As String = ""
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
            Err.Raise(Err.Number, e.Source, "MasterDAO.CheckNotExist : " & e.Message)
        End Try
        Return MSG
    End Function


End Class
