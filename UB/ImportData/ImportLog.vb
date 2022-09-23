Option Explicit On
Imports System.Data.SqlClient
Public Class ImportLog

#Region "Property"
    Dim mImportTXID As Long
    Dim mTableID As Long
    Dim mUserID As Long
    Dim mImportRow As Long

    Public ReadOnly Property TableName() As String
        Get
            Return "ImportLog"
        End Get
    End Property

    Public Property ImportTXID() As Long
        Get
            Return mImportTXID
        End Get
        Set(ByVal Value As Long)
            mImportTXID = Value
        End Set
    End Property

    Public Property TableID() As Long
        Get
            Return mTableID
        End Get
        Set(ByVal Value As Long)
            mTableID = Value
        End Set
    End Property

    Public Property UserID() As Long
        Get
            Return mUserID
        End Get
        Set(ByVal Value As Long)
            mUserID = Value
        End Set
    End Property
    Public Property ImportRow() As Long
        Get
            Return mImportRow
        End Get
        Set(ByVal Value As Long)
            mImportRow = Value
        End Set
    End Property
#End Region

    Public Function InitailData(ByVal pID As Long) As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()
        Dim lUserDAO As New UserDAO

        InitailData = False
        Try
            SQL = "SELECT *   "
            SQL &=  " FROM ImportLog "
            SQL &=  " WHERE ImportTXID=" & pID
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    ImportTXID = Int32.Parse(dr("ImportTXID"))
                    TableID = ConvertNullToZero(dr("TableID"))
                    ImportRow = ConvertNullToZero(dr("ImportRow"))
                    Return True
                    Exit For
                Next
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ImportLog.InitailData : " & e.Message)
            Return False
        Finally
            lUserDAO = Nothing
            dataTable = Nothing
        End Try
    End Function


    Public Function SaveData(ByRef ptr As SqlTransaction) As Boolean
        Dim SQL As String
        Dim llngAddressID As Long = 0
        Dim myCommand As SqlCommand
        Dim tr As SqlTransaction = Nothing
        SQL = ""
        Try
            If ptr Is Nothing Then
                tr = gConnection.Connection.BeginTransaction
            Else
                tr = ptr
            End If

            ImportTXID = GenNewID("ImportTXID", "ImportLog", tr)
            SQL = " INSERT INTO ImportLog  (ImportTXID,TableID,ImportRow,UserID,ImportDate  )"
            SQL &=  " VALUES ( @ImportTXID"
            SQL &=  " ,  @TableID"
            SQL &=  " ,  @ImportRow"
            SQL &=  " ,  @UserID"
            SQL &=  " ,  @ImportDate"
            SQL &=  " ) "

            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@ImportTXID", ImportTXID))
            myCommand.Parameters.Add(New SqlParameter("@TableID", TableID))
            myCommand.Parameters.Add(New SqlParameter("@ImportRow", ConvertNullToZero(ImportRow)))
            myCommand.Parameters.Add(New SqlParameter("@UserID", gUserID))
            myCommand.Parameters.Add(New SqlParameter("@ImportDate", formatSQLDateTime(GetCurrentDate(tr))))

            gConnection.executeInsertSqlCommand(myCommand, tr)

            If ptr Is Nothing Then tr.Commit()
            Return True
        Catch e As Exception
            If ptr Is Nothing Then tr.Rollback()
            Err.Raise(Err.Number, e.Source, "ImportLog.SaveData : " & e.Message)
            Return False
        End Try

    End Function

    Public Sub New()
        mImportTXID = 0
        mTableID = 0
        mUserID = 0
        mImportRow = 0
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
