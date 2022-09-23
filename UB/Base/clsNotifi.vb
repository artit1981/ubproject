Option Explicit On
Imports System.Data.SqlClient
Public Class clsNotifi

    Public Enum eNotifyLevel
        Low = 1
        Normal = 2
        Hi = 3
    End Enum
    'Private mNotifiList As List(Of clsNotifi)
    Dim NotifyLevel_ As Integer = eNotifyLevel.Low
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


    Public Property NotifyLevel() As Integer
        Get
            Return NotifyLevel_
        End Get
        Set(ByVal value As Integer)
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
    Public Function GetNotifiList(ByVal pUserID As Long) As List(Of clsNotifi)
        Dim SQL As String
        Dim dataTable As New DataTable()
        Dim lclsNotifiList As New List(Of clsNotifi)
        Dim lclsNotifi As clsNotifi
        Try
            SQL = "SELECT * "
            SQL &=  " FROM NotifiData  "
            SQL &=  " WHERE IsClose=0 and UserID =" & pUserID
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    lclsNotifi = New clsNotifi
                    lclsNotifi.IsClose = ConvertNullToString(dr("IsClose"))
                    lclsNotifi.NotifyLevel = ConvertNullToZero(dr("NotifyLevel"))
                    lclsNotifi.System = ConvertNullToString(dr("System"))
                    lclsNotifi.MenuDisplay = ConvertNullToString(dr("MenuDisplay"))
                    lclsNotifi.ValueDate = dr("ValueDate")
                    lclsNotifi.RefTable = ConvertNullToString(dr("RefTable"))
                    lclsNotifi.RefID = ConvertNullToZero(dr("RefID"))
                    lclsNotifi.UserID = ConvertNullToZero(dr("UserID"))
                    lclsNotifi.Remark = ConvertNullToString(dr("Remark"))
                    lclsNotifiList.Add(lclsNotifi)
                Next
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "clsNotifi.GetNotifiList : " & e.Message)
        Finally

        End Try

        Return lclsNotifiList
    End Function

    Public Function InitialNotifi() As Boolean
        Dim dataTable As New DataTable()
        Try

            'ApproveTX
            Dim lclsApprove As New ApproveTX
            dataTable = lclsApprove.GetDataTable()
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    AddDataNotifi(eNotifyLevel.Hi, "Approve", "อนุมัติรายการ", dr("OrderDate"), "ApproveTX", dr("ApproveTXID") _
                                  , "เอกสารเลขที่ " & dr("OrderCode") & " : " & ConvertNullToString(dr("Remark")), Nothing, gUserID)
                Next
            End If



            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "clsNotifi.GetDataTable : " & e.Message)
        End Try
    End Function

    Public Function LoadExpireOrder() As DataTable
        Dim lcls As New OrderSDAO

        Try
            Dim SQL = " EXEC [dbo].[spOverdueTX] "
            SQL &= " @FromDate = '" & formatSQLDate(Now.Date.AddYears(-2)) & "'"
            SQL &= " ,@ToDate = '" & formatSQLDate(Now.Date) & "'"
            Dim dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            Return dataTable

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, ".LoadExpireOrder : " & e.Message)
        Finally

        End Try
    End Function
    Public Function CloseNotifi(ByVal pUserID As Long, ByVal pRefTable As String, ByVal pRefID As Long) As Boolean
        Dim SQL As String = ""
        Try

            SQL = " UPDATE NotifiData SET IsClose=1  "
            SQL &=  " WHERE UserID=" & gUserID
            SQL &=  " AND RefTable='" & pRefTable & "'"
            SQL &=  " AND RefID=" & pRefID
            SQL &=  " AND IsClose=0"
            gConnection.executeInsertQuery(SQL, Nothing)

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "clsNotifi.CloseNotifi : " & e.Message)
        End Try
    End Function

    Public Sub AddDataNotifi(ByVal pNotifyLevel As eNotifyLevel, ByVal pSystem As String, ByVal pMenuDisplay As String, ByVal pValueDate As Date, ByVal pRefTable As String _
                            , ByVal pRefID As Long, ByVal pRemark As String, ByRef ptr As SqlTransaction, ByVal pUserID As Long)
        Dim SQL As String = ""
        Try
            If IsNotExist(gUserID, pRefID, pRefTable, ptr) Then
                SQL = " INSERT INTO NotifiData  (IsClose,NotifyLevel,System,MenuDisplay,ValueDate,RefTable,RefID,UserID,Remark)"
                SQL &=  " VALUES (0"
                SQL &=  " , " & pNotifyLevel
                SQL &=  " ,'" & pSystem & "'"
                SQL &=  " ,'" & pMenuDisplay & "'"
                SQL &=  " ,'" & formatSQLDate(pValueDate) & "'"
                SQL &=  " ,'" & pRefTable & "'"
                SQL &=  " , " & pRefID
                SQL &=  " , " & pUserID
                SQL &=  " ,'" & pRemark & "'"
                SQL &=  " ) "
                gConnection.executeInsertQuery(SQL, ptr)

            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "clsNotifi.AddDataNotifi : " & e.Message)
        End Try
    End Sub

    Private Function IsNotExist(ByVal pUserID As Long, ByRef pRefID As Long, ByVal pRefTable As String, ByRef ptr As SqlTransaction) As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()
        Try
            SQL = "SELECT RefID  "
            SQL &=  " FROM NotifiData"
            SQL &=  " where UserID=" & pUserID
            SQL &=  " and RefID=" & pRefID
            SQL &=  " and RefTable='" & pRefTable & "'"
            dataTable = gConnection.executeSelectQuery(SQL, ptr)
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
