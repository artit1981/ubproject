Option Explicit On
Imports System.Data.SqlClient
Public Class clsNotifi
    Public Enum eNotifyLevel
        Low = 1
        Normal = 2
        Hi = 3
    End Enum
    'Private mNotifiList As List(Of clsNotifi)
    Dim NotifyLevel_ As eNotifyLevel = eNotifyLevel.Low
    Dim System_ As String = ""
    Dim MenuDisplay_ As String = ""
    Dim ValueDate_ As Date = Now
    Dim Remark_ As String = ""
    Dim RefTable_ As String = ""
    Dim RefID_ As Long = 0
    Dim IsClose_ As Boolean = False
    Dim UserID_ As Long = 0

    Public Sub New()
    End Sub
#Region "Property"
    Public Property IsClose() As Boolean
        Get
            Return IsClose_
        End Get
        Set(ByVal value As Boolean)
            IsClose_ = value
        End Set
    End Property


    Public Property NotifyLevel() As eNotifyLevel
        Get
            Return NotifyLevel_
        End Get
        Set(ByVal value As eNotifyLevel)
            NotifyLevel_ = value
        End Set
    End Property

    Public Property System() As String
        Get
            Return System_
        End Get
        Set(ByVal value As String)
            System_ = value
        End Set
    End Property

    Public Property MenuDisplay() As String
        Get
            Return MenuDisplay_
        End Get
        Set(ByVal value As String)
            MenuDisplay_ = value
        End Set
    End Property
    Public Property ValueDate() As Date
        Get
            Return ValueDate_
        End Get
        Set(ByVal value As Date)
            ValueDate_ = value
        End Set
    End Property
    Public Property Remark() As String
        Get
            Return Remark_
        End Get
        Set(ByVal value As String)
            Remark_ = value
        End Set
    End Property
    Public Property RefID() As Long
        Get
            Return RefID_
        End Get
        Set(ByVal value As Long)
            RefID_ = value
        End Set
    End Property
    Public Property RefTable() As String
        Get
            Return RefTable_
        End Get
        Set(ByVal value As String)
            RefTable_ = value
        End Set
    End Property
    Public Property UserID() As Long
        Get
            Return UserID_
        End Get
        Set(ByVal value As Long)
            UserID_ = value
        End Set
    End Property
#End Region
#Region "Function"
    Public Function GetDataTable(ByVal pID As Long, ByVal pOnlyActive As Boolean, ByVal pProCategoryID As Long) As DataTable
        Dim SQL As String, lstrProTypeID As String = ""
        Dim dataTable As New DataTable()

        Try
            If pProCategoryID > 0 Then
                SQL = "SELECT ProductTypeID"
                SQL = SQL & " FROM ProductCategory  "
                SQL = SQL & " WHERE CategoryID =" & pProCategoryID
                dataTable = gConnection.executeSelectQuery(SQL, Nothing)
                If dataTable.Rows.Count > 0 Then
                    For Each dr As DataRow In dataTable.Rows
                        lstrProTypeID = ConvertNullToString(dr("ProductTypeID"))
                    Next
                End If
            End If

            SQL = "SELECT ProductTypeID AS ID,IDCode,NameThai "
            SQL = SQL & " FROM ProductType  "
            SQL = SQL & " WHERE IsDelete =0   "
            If pID > 0 Then
                SQL = SQL & "  AND ProductTypeID=" & pID
            End If
            If lstrProTypeID <> "" Then
                SQL = SQL & "  AND ProductTypeID in(" & lstrProTypeID & ")"
            End If
            If pOnlyActive = True Then
                SQL = SQL & "  AND IsInActive = 0"
            End If
            SQL = SQL & " ORDER BY IDCode,NameThai"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProductTypeDAO.GetDataTable : " & e.Message)
        End Try
        Return dataTable
    End Function

    Public Function InitialNotifi() As Boolean
        Dim dataTable As New DataTable()
        Try
            'mNotifiList = New List(Of clsNotifi)
            'ApproveTX
            Dim lclsApprove As New ApproveTX
            dataTable = lclsApprove.GetDataTable()
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    AddDataNotifi(eNotifyLevel.Hi, "อนุมัติเอกสาร", "อนุมัติรายการ", dr("OrderDate"), "ApproveTX", dr("ApproveTXID"), "")
                Next
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "clsNotifi.GetDataTable : " & e.Message)
        End Try
    End Function

    Private Sub AddDataNotifi(ByVal pNotifyLevel As eNotifyLevel, ByVal pSystem As String, ByVal pMenuDisplay As String, ByVal pValueDate As Date, ByVal pRefTable As String _
                            , ByVal pRefID As Long, ByVal pRemark As String)
        Dim SQL As String = ""
        Dim myCommand As SqlCommand

        Try
            If IsNotExist(gUserID, pRefID, pRefTable) Then
                SQL = " INSERT INTO NotifiData  (IsClose,NotifyLevel,System,MenuDisplay,ValueDate,RefTable,RefID,UserID,Remark)"
                SQL = SQL & " VALUES (0" &
                SQL = SQL & " , " & pNotifyLevel
                SQL = SQL & " ,'" & pSystem & "'"
                SQL = SQL & " ,'" & pMenuDisplay & "'"
                SQL = SQL & " ,'" & formatSQLDate(pValueDate) & "'"
                SQL = SQL & " ,'" & pRefTable & "'"
                SQL = SQL & " , " & pRefID
                SQL = SQL & " , " & gUserID
                SQL = SQL & " ,'" & pRemark & "'"
                SQL = SQL & " ) "
                myCommand = New SqlCommand
                myCommand.CommandText = SQL
                gConnection.executeInsertSqlCommand(myCommand, Nothing)

            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "clsNotifi.AddDataNotifi : " & e.Message)
        End Try
    End Sub

    Private Function IsNotExist(ByVal pUserID As Long, ByRef pRefID As Long, ByVal pRefTable As String) As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()
        Try
            SQL = "SELECT *  "
            SQL = SQL & " FROM NotifiData"
            SQL = SQL & " where UserID=" & pUserID
            SQL = SQL & " and RefID=" & pRefID
            SQL = SQL & " and RefTable='" & pRefTable & "'"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            Return dataTable.Rows.Count = 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "clsNotifi.IsExist : " & e.Message)
            Return False
        Finally
            dataTable = Nothing
        End Try
    End Function

#End Region
End Class
