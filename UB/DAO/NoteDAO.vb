Option Explicit On

Imports System.Data.SqlClient

Public Class NoteDAO
    Private mMode As DataMode
    Private mIDs As Long
    Private mRefID As Long
    Private mRefTable As String
    Private mDescription As String
    Private mSEQ As Integer
    Private mCreateBy As String
    Private mCreateTime As DateTime




    Public Property Description() As String
        Get
            Return mDescription
        End Get
        Set(ByVal value As String)
            mDescription = value
        End Set
    End Property

    Public Property SEQ() As Integer
        Get
            Return mSEQ
        End Get
        Set(ByVal value As Integer)
            mSEQ = value
        End Set

    End Property
    Public Property ModeData() As Integer
        Get
            Return mMode
        End Get
        Set(ByVal Value As Integer)
            mMode = Value
        End Set
    End Property


    Public Property CreateBy() As String
        Get
            Return mCreateBy
        End Get
        Set(ByVal value As String)
            mCreateBy = value
        End Set
    End Property


    Public Property CreateTime() As DateTime
        Get
            Return mCreateTime
        End Get
        Set(ByVal value As DateTime)
            mCreateTime = value
        End Set
    End Property

    Public Property ID() As Long
        Get
            Return mIDs
        End Get
        Set(ByVal value As Long)
            mIDs = value
        End Set
    End Property

    Public Property RefID() As Long
        Get
            Return mRefID
        End Get
        Set(ByVal value As Long)
            mRefID = value
        End Set

    End Property
    Public Property RefTable() As String
        Get
            Return mRefTable
        End Get
        Set(ByVal value As String)
            mRefTable = value
        End Set
    End Property



    Public Function GetDataTable(ByVal pTable As String, ByVal pRefID As Long) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT  A.Description,A.Description AS DescriptionORG ,B.USERNAME AS CreateBy "
            SQL &=  " ,A.CreateTime ,A.NoteID AS ID  ,A.RefID ,A.RefTable,A.SEQ ,2 AS ModeData"
            SQL &=  " FROM Note A "
            SQL &=  " LEFT OUTER JOIN Admin_User B ON A.CreateBy=B.UserID "
            SQL &=  " WHERE RefTable = '" & pTable & "' "
            SQL &=  " AND RefID =" & pRefID
            SQL &=  " ORDER BY A.SEQ"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "NoteDAO.GetDataTable : " & e.Message)
        End Try
        Return dataTable
    End Function

    Public Function SaveData(ByVal tr As SqlTransaction) As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand

        SQL = ""
        Try
            If mMode = DataMode.ModeNew Then
            ElseIf mMode = DataMode.ModeDelete Then
            ElseIf ID <= 0 And Description <> "" Then
                mMode = DataMode.ModeNew
                'ElseIf Description.Trim <> DescriptionORG.Trim Then
                '    mMode = DataMode.ModeEdit
            Else  'not chang
                mMode = DataMode.ModeEdit
            End If

            Select Case mMode
                Case DataMode.ModeNew
                    mIDs = GenNewID("NoteID", "Note", tr)
                    SQL = " INSERT INTO Note  (NoteID,RefID,RefTable,Description,CreateBy,CreateTime )"
                    SQL &=  " VALUES ( @mIDs"
                    SQL &=  " ,  @mRefID"
                    SQL &=  " ,  @mRefTable"
                    SQL &=  " ,  @mDescription"
                    SQL &=  " ,  @gUserID"
                    SQL &=  " ,  @CreateTime"
                    SQL &=  " ) "
                Case DataMode.ModeEdit
                    SQL = " Update Note   "
                    SQL &=  " SET"
                    SQL &=  " Description=@mDescription"
                    SQL &=  " ,CreateBy= @gUserID"
                    SQL &=  " ,CreateTime=@CreateTime"
                    SQL &=  " ,SEQ=@SEQ"
                    SQL &=  " WHERE NoteID= @mIDs"
                Case DataMode.ModeDelete
                    SQL = " DELETE FROM Note  "
                    SQL &=  " WHERE NoteID= @mIDs"
                Case Else
                    Return False
                    Exit Function
            End Select
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@mIDs", mIDs))
            myCommand.Parameters.Add(New SqlParameter("@mRefID", RefID))
            myCommand.Parameters.Add(New SqlParameter("@mRefTable", RefTable.Trim))
            myCommand.Parameters.Add(New SqlParameter("@mDescription", Description))
            myCommand.Parameters.Add(New SqlParameter("@gUserID", gUserID))
            myCommand.Parameters.Add(New SqlParameter("@CreateTime", formatSQLDateTime(GetCurrentDate(tr))))
            myCommand.Parameters.Add(New SqlParameter("@SEQ", mSEQ))
            gConnection.executeInsertSqlCommand(myCommand, tr)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "NoteDAO.SaveData : " & e.Message)
            Return False
        End Try
    End Function

    Public Function DeleteAllData(ByVal tr As SqlTransaction) As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand
        SQL = ""
        Try
            SQL = " DELETE FROM Note  "
            SQL &=  " WHERE RefTable= @mRefTable"
            SQL &=  " AND RefID= @mRefID"
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@mRefID", RefID))
            myCommand.Parameters.Add(New SqlParameter("@mRefTable", RefTable.Trim))
            gConnection.executeInsertSqlCommand(myCommand, tr)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "NoteDAO.DeleteAllData : " & e.Message)
            Return False
        End Try
    End Function

    Public Sub New()
        mIDs = 0
        mRefID = 0
        mRefTable = ""
        mDescription = ""
        mSEQ = 0
        mCreateBy = ""
        mCreateTime = GetCurrentDate(Nothing)
    End Sub
End Class
