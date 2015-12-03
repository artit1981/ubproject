Option Explicit On
Imports System.Data.SqlClient


Public Class ActivityDAO

    Public Function GetDataTable(ByVal pFromDate As Date, ByVal pToDate As Date, ByVal pUserID As Long, ByVal pMenuID As Long) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT A.ActivityDate AS Date,A.ActivityDate AS Time,A.Action,B.MenuDisplay,C.UserName,A.ComputerName,A.Remark"
            SQL = SQL & " FROM Activity A"
            SQL = SQL & " LEFT OUTER JOIN Menu B ON B.MenuID=A.MenuID "
            SQL = SQL & " LEFT OUTER JOIN Admin_User C ON C.UserID=A.UserID  "
            SQL = SQL & " WHERE  ActivityDate between '" & formatSQLDateTime(pFromDate) & "' AND '" & formatSQLDateTime(pToDate) & "'"
            If pUserID > 0 Then
                SQL = SQL & "  AND A.UserID=" & pUserID
            End If

            If pMenuID > 0 Then
                SQL = SQL & "  AND A.MenuID=" & pMenuID
            End If
            SQL = SQL & " ORDER BY A.ActivityDate,A.Action,B.MenuDisplay,C.UserName"
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
            SQL = SQL & " VALUES ( @ActivityDate"
            SQL = SQL & " ,  @MenuID"
            SQL = SQL & " ,  @UserID"
            SQL = SQL & " ,  @Action"
            SQL = SQL & " ,  @ComputerName"
            SQL = SQL & " ,  @Remark"
            SQL = SQL & " ) "

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

End Class
