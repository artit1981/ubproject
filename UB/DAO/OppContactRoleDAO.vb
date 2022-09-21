Option Explicit On
Imports System.Data.SqlClient

Public Class OppContactRoleDAO

    Private mMode As DataMode
    Private mIDs As Long
    Private mRefID As Long
    Private mContactID As Long
    Private mContactRole As String

    'Private mContactDAO As OppContactRoleDAO

    'Public ReadOnly Property ContactDAO() As CustomerDAO
    '    Get
    '        If mContactDAO Is Nothing And mContactID > 0 Then
    '            mContactDAO = New ContactDAO
    '            mContactDAO.InitailData(mContactID)
    '        End If
    '        Return mContactDAO
    '    End Get
    'End Property

    Public Property ContactRole() As String
        Get
            Return mContactRole
        End Get
        Set(ByVal value As String)
            mContactRole = value
        End Set
    End Property

    Public Property ContactID() As Long
        Get
            Return mContactID
        End Get
        Set(ByVal Value As Long)
            mContactID = Value
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

    Public Property RefID() As Long
        Get
            Return mRefID
        End Get
        Set(ByVal value As Long)
            mRefID = value
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

    Public Function GetDataTable(ByVal pRefID As Long) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT  OppContactRole.OppContactRoleID AS ID,OppContactRole.ContactID,OppContactRole.ContactRole"
            SQL = SQL & " ,Contact.Title + Contact.Firstname + ' ' + Contact.LastName AS ContactName,Address.Email1 ,Address.Phone1,Address.Fax"
            SQL = SQL & " FROM OppContactRole"
            SQL = SQL & " LEFT OUTER JOIN Customer as Contact ON Contact.CustomerID=OppContactRole.ContactID "
            SQL = SQL & " LEFT OUTER JOIN Address ON Contact.AddressID=Address.AddressID  "
            SQL = SQL & " WHERE OppContactRole.OppID =" & pRefID
            SQL = SQL & " AND OppContactRole.IsDelete =0   "
            SQL = SQL & " ORDER BY OppContactRole.OppContactRoleID"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "OppContactRoleDAO.GetDataTable : " & e.Message)
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
            ElseIf ID <= 0 And ContactID <> 0 Then
                mMode = DataMode.ModeNew
            ElseIf ID > 0 And ContactID <> 0 Then
                mMode = DataMode.ModeEdit
            Else  'not chang
                mMode = DataMode.ModeNone
            End If

            Select Case mMode
                Case DataMode.ModeNew
                    mIDs = GenNewID("OppContactRoleID", "OppContactRole", tr)
                    SQL = " INSERT INTO OppContactRole  (OppContactRoleID,ContactID,OppID,ContactRole,IsDelete )"
                    SQL = SQL & " VALUES ( "
                    SQL = SQL & "   @ID"
                    SQL = SQL & " ,  @ContactID"
                    SQL = SQL & " ,  @OppID"
                    SQL = SQL & " ,  @ContactRole"
                    SQL = SQL & " ,  @IsDelete"
                    SQL = SQL & " ) "
                Case DataMode.ModeEdit
                    SQL = " Update OppContactRole   "
                    SQL = SQL & " SET"
                    SQL = SQL & " ContactID=@ContactID"
                    SQL = SQL & " ,OppID= @OppID"
                    SQL = SQL & " ,ContactRole=@ContactRole"
                    SQL = SQL & " WHERE OppContactRoleID= @ID"
                Case DataMode.ModeDelete
                    SQL = " UPDATE OppContactRole SET IsDelete=@IsDelete "
                    SQL = SQL & " WHERE OppContactRoleID= @ID"
                Case Else
                    Return False
                    Exit Function
            End Select
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@ID", mIDs))
            myCommand.Parameters.Add(New SqlParameter("@ContactID", ContactID))
            myCommand.Parameters.Add(New SqlParameter("@OppID", RefID))
            myCommand.Parameters.Add(New SqlParameter("@ContactRole", ContactRole))
            Select Case ModeData
                Case DataMode.ModeNew
                    myCommand.Parameters.Add(New SqlParameter("@IsDelete", 0))
                Case DataMode.ModeDelete
                    myCommand.Parameters.Add(New SqlParameter("@IsDelete", 1))
            End Select
            gConnection.executeInsertSqlCommand(myCommand, tr)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "OppContactRoleDAO.SaveData : " & e.Message)
            Return False
        End Try
    End Function

    'delete some record are remove from grid
    Public Function DeleteRemoveData(ByVal tr As SqlTransaction, ByVal pstrStayID As String) As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand

        SQL = ""
        Try
            SQL = " UPDATE OppContactRole SET IsDelete=@IsDelete "
            SQL = SQL & " WHERE OppContactRoleID NOT IN( " & pstrStayID & ")"
            SQL = SQL & " AND OppID=@RefID "
            SQL = SQL & " AND IsDelete =0  "
            myCommand = New SqlCommand
            myCommand.CommandText = SQL

            myCommand.Parameters.Add(New SqlParameter("@RefID", RefID))
            myCommand.Parameters.Add(New SqlParameter("@IsDelete", 1))
            gConnection.executeInsertSqlCommand(myCommand, tr)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "OppContactRoleDAO.DeleteRemoveData : " & e.Message)
            Return False
        End Try
    End Function

    'delete all ref
    Public Function DeleteAllData(ByVal tr As SqlTransaction) As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand
        SQL = ""
        Try
            SQL = " UPDATE OppContactRole SET IsDelete=@IsDelete "
            SQL = SQL & " WHERE OppID=@RefID "
            myCommand = New SqlCommand
            myCommand.CommandText = SQL

            myCommand.Parameters.Add(New SqlParameter("@RefID", RefID))
            myCommand.Parameters.Add(New SqlParameter("@IsDelete", 1))
            gConnection.executeInsertSqlCommand(myCommand, tr)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "OppContactRoleDAO.DeleteAllData : " & e.Message)
            Return False
        End Try
    End Function

    Public Sub New()
        mMode = DataMode.ModeNone
        mIDs = 0
        mRefID = 0
        mContactID = 0
        mContactRole = ""
        'mContactDAO = Nothing
    End Sub
End Class
