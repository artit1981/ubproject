﻿Option Explicit On
Imports System.Data.SqlClient


Public Class ActivityDAO

    Public Function GetDataTable(ByVal pFromDate As Date, ByVal pToDate As Date, ByVal pUserID As Long, ByVal pMenuID As Long) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT A.ActivityDate AS Date,A.ActivityDate AS Time,A.Action,B.MenuDisplay,C.UserName,A.ComputerName,A.Remark"
            SQL &= " FROM Activity A"
            SQL &= " LEFT OUTER JOIN Menu B ON B.MenuID=A.MenuID "
            SQL &= " LEFT OUTER JOIN Admin_User C ON C.UserID=A.UserID  "
            SQL &= " WHERE  ActivityDate between '" & formatSQLDateTime(pFromDate) & "' AND '" & formatSQLDateTime(pToDate) & "'"
            If pUserID > 0 Then
                SQL &= "  AND A.UserID=" & pUserID
            End If

            If pMenuID > 0 Then
                SQL &= "  AND A.MenuID=" & pMenuID
            End If
            SQL &= " ORDER BY A.ActivityDate,A.Action,B.MenuDisplay,C.UserName"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ActivityDAO.GetDataTable : " & e.Message)
        End Try
        Return dataTable

    End Function

    Public Function SaveData(ByVal Action As String, ByVal MenuID As Long, ByVal Remark As String, ByRef ptr As SqlTransaction) As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand
        Dim tr As SqlTransaction = Nothing

        SQL = ""
        Try
            'tr = gConnection.Connection.BeginTransaction
            If ptr Is Nothing Then
                tr = gConnection.Connection.BeginTransaction
            Else
                tr = ptr
            End If
            SQL = " INSERT INTO Activity  (ActivityDate,MenuID,UserID,Action,ComputerName,Remark)"
            SQL &= " VALUES ( @ActivityDate"
            SQL &= " ,  @MenuID"
            SQL &= " ,  @UserID"
            SQL &= " ,  @Action"
            SQL &= " ,  @ComputerName"
            SQL &= " ,  @Remark"
            SQL &= " ) "

            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@ActivityDate", formatSQLDateTime(GetCurrentDate(tr))))
            myCommand.Parameters.Add(New SqlParameter("@MenuID", MenuID))
            myCommand.Parameters.Add(New SqlParameter("@UserID", gUserID))
            myCommand.Parameters.Add(New SqlParameter("@Action", Action))
            myCommand.Parameters.Add(New SqlParameter("@ComputerName", "Comname"))
            myCommand.Parameters.Add(New SqlParameter("@Remark", Remark))

            gConnection.executeInsertSqlCommand(myCommand, tr)

            'Execute ALL 
            If ptr Is Nothing Then tr.Commit()

            Return True

        Catch e As Exception
            tr.Rollback()
            Err.Raise(Err.Number, e.Source, "ActivityDAO.SaveData : " & e.Message)
            Return False
        End Try


    End Function

    Public Function SaveActivityLog(ByVal pMenuID As Long, ByVal pRemark As String, ByRef ptr As SqlTransaction) As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand
        Dim tr As SqlTransaction = Nothing

        SQL = ""
        Try
            'tr = gConnection.Connection.BeginTransaction
            If ptr Is Nothing Then
                tr = gConnection.Connection.BeginTransaction
            Else
                tr = ptr
            End If

            Dim lTable = GetDataLogTable(gUserID, pMenuID, tr)

            If lTable.Rows.Count > 0 Then
                SQL = " update NotifiLog "
                SQL &= " Set LogTime=@LogTime "
                SQL &= " where UserID=@UserID"
                SQL &= " and MenuID=@MenuID"
            Else
                SQL = " INSERT INTO NotifiLog (UserID,MenuID,LogTime,Remark)"
                SQL &= " VALUES ( @UserID"
                SQL &= " ,  @MenuID"
                SQL &= " ,  @LogTime"
                SQL &= " ,  @Remark"
                SQL &= " ) "
            End If

            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@LogTime", formatSQLDateTime(GetCurrentDate(tr))))
            myCommand.Parameters.Add(New SqlParameter("@MenuID", pMenuID))
            myCommand.Parameters.Add(New SqlParameter("@UserID", gUserID))
            myCommand.Parameters.Add(New SqlParameter("@Remark", pRemark))

            gConnection.executeInsertSqlCommand(myCommand, tr)

            'Execute ALL 
            If ptr Is Nothing Then tr.Commit()

            Return True

        Catch e As Exception
            tr.Rollback()
            Err.Raise(Err.Number, e.Source, "ActivityDAO.SaveData : " & e.Message)
            Return False
        End Try


    End Function

    Public Function GetDataLogTable(ByVal pUserID As Long, ByVal pMenuID As Long, ByRef ptr As SqlTransaction) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT UserID,MenuID,LogTime,Remark"
            SQL &= " FROM NotifiLog"
            SQL &= " WHERE  1=1 "
            If pUserID > 0 Then
                SQL &= "  AND UserID=" & pUserID
            End If

            If pMenuID > 0 Then
                SQL &= "  AND MenuID=" & pMenuID
            End If
            dataTable = gConnection.executeSelectQuery(SQL, ptr)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ActivityDAO.GetDataLogTable : " & e.Message)
        End Try
        Return dataTable

    End Function
End Class
