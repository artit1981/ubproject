Option Explicit On

Imports System.Data.SqlClient

Public Class LocationDTLDAO

    Private mMode As DataMode
    Private mIDs As Long
    Private mRefID As Long
    Private mIDCode As String
    Private mNameThai As String
    Private mRemark As String

#Region "Property"


    Public Property Remark() As String
        Get
            Return mRemark
        End Get
        Set(ByVal value As String)
            mRemark = value
        End Set
    End Property

    Public Property NameThai() As String
        Get
            Return mNameThai
        End Get
        Set(ByVal value As String)
            mNameThai = value
        End Set

    End Property

    Public Property IDCode() As String
        Get
            Return mIDCode
        End Get
        Set(ByVal value As String)
            mIDCode = value
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
#End Region


    Public Function GetDataTable(ByVal pRefID As Long, ByRef pTr As SqlTransaction) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT  LocationDTLID AS ID,IDCode,NameThai,Remark"
            SQL = SQL & " FROM Product_LocationDTL"
            If pRefID > 0 Then
                SQL = SQL & " WHERE RefID =" & pRefID
            End If
            SQL = SQL & " ORDER BY IDCode,NameThai"
            dataTable = gConnection.executeSelectQuery(SQL, pTr)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "LocationDTLDAO.GetDataTable : " & e.Message)
        End Try
        Return dataTable
    End Function

    Public Function InitailData(ByVal pID As Long, Optional ByVal pName As String = "", Optional ByRef pTr As SqlTransaction = Nothing) As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT *   "
            SQL = SQL & " FROM Product_LocationDTL"
            SQL = SQL & " WHERE 1=1 "
            If pID > 0 Then
                SQL = SQL & " AND LocationDTLID=" & pID
            End If
            If pName.Trim <> "" Then
                SQL = SQL & " AND NameThai='" & pName.Trim & "'"
            End If
            dataTable = gConnection.executeSelectQuery(SQL, pTr)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows

                    ID = Int32.Parse(dr("LocationDTLID"))
                    RefID = ConvertNullToZero(dr("RefID"))
                    IDCode = dr("IDCode").ToString
                    NameThai = ConvertNullToString(dr("NameThai"))
                    Remark = ConvertNullToString(dr("Remark"))

                    Return True
                    Exit For
                Next
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "LocationDTLDAO.InitailData : " & e.Message)
            Return False
        Finally
            dataTable = Nothing
        End Try
    End Function

    Public Function GetDataTableDTL(ByVal pRefID As Long) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            'SQL = "SELECT D.LocationDTLID,P.NameThai AS Location,D.NameThai AS LocationDTL  "
            SQL = "SELECT D.LocationDTLID as ID,D.NameThai "
            SQL = SQL & " FROM Product_LocationDTL D  "
            SQL = SQL & " LEFT OUTER JOIN Product_Location P ON D.RefID=P.LocationID AND P.IsDelete =0   "
            'SQL = SQL & " ORDER BY P.NameThai,D.NameThai"
            SQL = SQL & " ORDER BY  D.LocationDTLID"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "LocationDTLDAO.GetDataTableDTL : " & e.Message)
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
            ElseIf ID <= 0 And IDCode <> "" Then
                mMode = DataMode.ModeNew
            ElseIf ID > 0 And IDCode <> "" Then
                mMode = DataMode.ModeEdit
                'ElseIf IDCode.Trim <> CodeORG.Trim Then
                '    mMode = DataMode.ModeEdit
            Else  'not chang
                mMode = DataMode.ModeNone
            End If

            Select Case mMode
                Case DataMode.ModeNew
                    mIDs = GenNewID("LocationDTLID", "Product_LocationDTL", tr)
                    SQL = " INSERT INTO Product_LocationDTL  (LocationDTLID,RefID,IDCode,NameThai,Remark )"
                    SQL = SQL & " VALUES ( @LocationDTLID"
                    SQL = SQL & " ,  @RefID"
                    SQL = SQL & " ,  @IDCode"
                    SQL = SQL & " ,  @NameThai"
                    SQL = SQL & " ,  @Remark"
                    SQL = SQL & " ) "
                Case DataMode.ModeEdit
                    SQL = " Update Product_LocationDTL   "
                    SQL = SQL & " SET"
                    SQL = SQL & " IDCode=@IDCode"
                    SQL = SQL & " ,NameThai= @NameThai"
                    SQL = SQL & " ,Remark=@Remark"
                    SQL = SQL & " WHERE LocationDTLID= @LocationDTLID"
                Case DataMode.ModeDelete
                    SQL = " DELETE FROM Product_LocationDTL  "
                    SQL = SQL & " WHERE LocationDTLID= @LocationDTLID"
                Case Else
                    Return False
                    Exit Function
            End Select
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@LocationDTLID", mIDs))
            myCommand.Parameters.Add(New SqlParameter("@RefID", RefID))
            myCommand.Parameters.Add(New SqlParameter("@IDCode", IDCode.Trim))
            myCommand.Parameters.Add(New SqlParameter("@NameThai", NameThai.Trim))
            myCommand.Parameters.Add(New SqlParameter("@Remark", Remark.Trim))
            gConnection.executeInsertSqlCommand(myCommand, tr)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "LocationDTLDAO.SaveData : " & e.Message)
            Return False
        End Try
    End Function


    'delete some record are remove from grid
    Public Function DeleteRemoveData(ByVal tr As SqlTransaction, ByVal pstrStayID As String) As Boolean
        Dim SQL As String
        Dim lstrStayIDList As String = ""
        Dim myCommand As SqlCommand

        SQL = ""
        Try
            SQL = " DELETE FROM Product_LocationDTL  "
            SQL = SQL & " WHERE LocationDTLID NOT IN( " & pstrStayID & ")"
            SQL = SQL & " AND RefID=@RefID "
            myCommand = New SqlCommand
            myCommand.CommandText = SQL

            myCommand.Parameters.Add(New SqlParameter("@RefID", RefID))
            gConnection.executeInsertSqlCommand(myCommand, tr)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "LocationDTLDAO.DeleteRemoveData : " & e.Message)
            Return False
        End Try

    End Function

    Public Sub New()
        mMode = DataMode.ModeNone
        mIDs = 0
        mRefID = 0
        mIDCode = ""
        'mCodeORG = ""
        mNameThai = ""
        mRemark = ""
    End Sub
End Class
