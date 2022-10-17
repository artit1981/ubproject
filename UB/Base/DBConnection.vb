Option Explicit On
Imports System.Data.SqlClient



Public Class DBConnection
    Private conn As SqlConnection


    Public Sub New()
        conn = New SqlConnection()
        conn.ConnectionString = gConString
    End Sub

    Public Function TestConnection() As String
        Try
            If conn.State = ConnectionState.Closed OrElse conn.State = ConnectionState.Broken Then

                conn.ConnectionString = gConString

                conn.Open()
            End If
            Return ""
        Catch e As SqlException
            Return e.Message
        Finally
            Err.Clear()
        End Try
    End Function

    Public Function DoesUserHavePermission() As Boolean

        Try
            Dim clientPermission As SqlClientPermission = New SqlClientPermission(Security.Permissions.PermissionState.Unrestricted)

            ' this will throw an error if the user does not have the permissions
            clientPermission.Demand()

            Return True

        Catch ex As Exception

            Return False

        End Try

        Return True

    End Function

    Public Function Connection() As SqlConnection
        Try
            If conn.State = ConnectionState.Closed OrElse conn.State = ConnectionState.Broken Then
                conn.Open()
            End If
        Catch ex As SqlException
            ShowErrorMsg(True, "การติดต่อฐานข้อมูลผิดพลาด กรุณาตรวจสอบ : " & vbNewLine & ex.Message & vbNewLine & " at DBConnection.Connection")
        Finally
        End Try
        Return conn
    End Function

    Private Function OpenConnection() As SqlConnection
        Try
            If conn.State = ConnectionState.Closed OrElse conn.State = ConnectionState.Broken Then
                conn.Open()
            End If
        Catch ex As SqlException
            ShowErrorMsg(True, "การติดต่อฐานข้อมูลผิดพลาด กรุณาตรวจสอบ : " & vbNewLine & ex.Message & vbNewLine & " at DBConnection.OpenConnection")
        Finally
        End Try
        Return conn
    End Function

    Public Function executeInsertQuery(ByVal SQl As String, ByRef tr As SqlTransaction) As Boolean
        'Dim tr As SqlTransaction
        Dim myCommand As New SqlCommand()

        myCommand.Connection = OpenConnection()
        'tr = conn.BeginTransaction
        Try
            myCommand.CommandType = CommandType.Text
            myCommand.CommandText = SQl
            If Not tr Is Nothing Then
                myCommand.Transaction = tr
            End If
            myCommand.ExecuteNonQuery()

            'tr.Commit()
            Return True
        Catch e As SqlException
            'tr.Rollback()
            ShowErrorMsg(True, "การติดต่อฐานข้อมูลผิดพลาด กรุณาตรวจสอบ : " & vbNewLine & e.Message & vbNewLine & " at DBConnection.executeInsertQuery")
            Return False
        End Try

    End Function

    Public Function executeInsertSqlCommand(ByVal myCommand As SqlCommand, ByRef tr As SqlTransaction) As Boolean
        Try
            If Not myCommand Is Nothing Then
                myCommand.Connection = OpenConnection()
                If Not tr Is Nothing Then
                    myCommand.Transaction = tr
                End If
                myCommand.ExecuteNonQuery()
                Return True
            End If

        Catch e As SqlException
            ShowErrorMsg(True, "การติดต่อฐานข้อมูลผิดพลาด กรุณาตรวจสอบ : " & vbNewLine & e.Message & vbNewLine & " at DBConnection.executeInsertSqlCommand")
            Return False
        End Try
    End Function

    Public Function executeSelectDS(ByVal pDataTableList As List(Of DataTableList)) As DataSet
        Dim myCommand As New SqlCommand()
        Dim myAdapter = New SqlDataAdapter
        Dim ds As New DataSet()
        Try

            myCommand.Connection = OpenConnection()
            For Each dr As DataTableList In pDataTableList
                myCommand.CommandText = dr.SQL
                myCommand.CommandType = CommandType.Text
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(ds, dr.TableName)
            Next
        Catch e As SqlException
            ShowErrorMsg(True, "การติดต่อฐานข้อมูลผิดพลาด กรุณาตรวจสอบ : " & vbNewLine & e.Message & vbNewLine & " at DBConnection.executeSelectDS")
            Return Nothing
        Finally
        End Try
        Return ds
    End Function
    Public Function executeSelectQuery(ByVal SQl As String, ByRef tr As SqlTransaction, Optional ByVal pTimeOut As Integer = 0) As DataTable
        Dim myCommand As New SqlCommand()
        Dim dataTable As New DataTable()
        dataTable = Nothing
        Dim ds As New DataSet()
        'conn.Close()
        Try
            myCommand.Connection = OpenConnection()
            myCommand.CommandText = SQl
            myCommand.CommandType = CommandType.Text
            If Not tr Is Nothing Then
                myCommand.Transaction = tr
            End If
            If pTimeOut > 0 Then
                myCommand.CommandTimeout = pTimeOut
            Else
                myCommand.ResetCommandTimeout()
            End If
            Dim myAdapter = New SqlDataAdapter
            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(ds, "TABLE")
            dataTable = ds.Tables("TABLE")
        Catch e As SqlException
            ShowErrorMsg(True, "การติดต่อฐานข้อมูลผิดพลาด กรุณาตรวจสอบ : " & vbNewLine & e.Message & vbNewLine & " at DBConnection.executeSelectQuery")
            Return Nothing
        Finally
        End Try
        Return dataTable
    End Function

    'Public Function executeInsertQuery(ByVal _query As [String], ByVal sqlParameter As SqlParameter()) As Boolean
    '    Dim myCommand As New SqlCommand()
    '    Try
    '        myCommand.Connection = openConnection()
    '        myCommand.CommandText = _query
    '        myCommand.Parameters.AddRange(sqlParameter)
    '        myAdapter.InsertCommand = myCommand
    '        myCommand.ExecuteNonQuery()
    '    Catch e As SqlException
    '        Console.Write("Error - Connection.executeInsertQuery - Query: " + _query + " " & vbLf & "Exception: " & vbLf + e.StackTrace.ToString())
    '        Return False
    '    Finally
    '    End Try
    '    Return True
    'End Function
    'Public Function executeUpdateQuery(ByVal _query As [String], ByVal sqlParameter As SqlParameter()) As Boolean
    '    Dim myCommand As New SqlCommand()
    '    Try
    '        myCommand.Connection = openConnection()
    '        myCommand.CommandText = _query
    '        myCommand.Parameters.AddRange(sqlParameter)
    '        myAdapter.UpdateCommand = myCommand
    '        myCommand.ExecuteNonQuery()
    '    Catch e As SqlException
    '        Console.Write("Error - Connection.executeUpdateQuery - Query: " + _query + " " & vbLf & "Exception: " + e.StackTrace.ToString())
    '        Return False
    '    Finally
    '    End Try
    '    Return True
    'End Function

    Public Function CloseConnection() As Boolean
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            Return True
        Catch ex As SqlException
            ShowErrorMsg(False, ex.Message)
            Return False
        Finally
        End Try

    End Function

    Public Class DataTableList
        Private mSQL As String
        Private mTableName As String

        Public Property SQL() As String
            Get
                Return mSQL
            End Get
            Set(ByVal value As String)
                mSQL = value
            End Set
        End Property

        Public Property TableName() As String
            Get
                Return mTableName
            End Get
            Set(ByVal value As String)
                mTableName = value
            End Set
        End Property
    End Class
End Class
