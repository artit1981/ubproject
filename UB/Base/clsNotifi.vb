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
            SQL = SQL & " FROM NotifiData  "
            SQL = SQL & " WHERE IsClose=0 and UserID =" & pUserID
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

            'Overdue Order
            LoadExpireOrder(MasterType.Receipt, MasterType.Invoice)
            LoadExpireOrder(MasterType.Receipt, MasterType.Shiping)
            'LoadExpireOrder(MasterType.Bill, MasterType.Invoice)
            'LoadExpireOrder(MasterType.Bill, MasterType.Shiping)

            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "clsNotifi.GetDataTable : " & e.Message)
        End Try
    End Function

    Private Function LoadExpireOrder(ByVal pParentOrderType As MasterType, ByVal pChildOrderType As MasterType) As Boolean
        Dim lcls As New OrderSDAO
        Dim dataTable As New DataTable()
        Dim SQL As String
        Dim lIsOpen As Boolean = True
        Try
            SQL = " AND Orders.OrderDate Between '" & formatSQLDate(Now.Date.AddYears(-2)) & "' AND '" & formatSQLDate(Now.Date) & "'"
            If pParentOrderType = MasterType.Bill Then
                SQL &= " AND Orders.RefBillID>0 "
            End If
            If pParentOrderType = MasterType.Receipt Then
                SQL &= " AND Orders.RefReceiptID>0 "
                SQL &= " AND Orders.RefReceiptID not in(select RefOrderID from Cheque where Cheque.IsDelete=0 )"
            End If
            SQL &= " AND ExpireDate <= '" & formatSQLDate(Now.Date) & "'"


            Dim lOrderTypeName As String = ""
            Dim lclsMenu As New MenuADO
            lclsMenu.InitailData(pChildOrderType)
            lOrderTypeName = lclsMenu.MenuDisplay

            lcls.TableID = pChildOrderType
            dataTable = lcls.GetDataTableForCombo(pParentOrderType, pChildOrderType, 0, Now.Date, lIsOpen, SQL)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows

                    AddDataNotifi(eNotifyLevel.Hi, "Overdue", lOrderTypeName, dr("ExpireDate"), pChildOrderType.ToString, dr("ID") _
                                  , "รายการเกินกำหนดชำระ เลขที่ " & dr("Code"), Nothing, gUserID)

                Next
                Return True
            Else
                Return False
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, ".LoadExpireOrder : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Function
    Public Function CloseNotifi(ByVal pUserID As Long, ByVal pRefTable As String, ByVal pRefID As Long) As Boolean
        Dim SQL As String = ""
        Try

            SQL = " UPDATE NotifiData SET IsClose=1  "
            SQL = SQL & " WHERE UserID=" & gUserID
            SQL = SQL & " AND RefTable='" & pRefTable & "'"
            SQL = SQL & " AND RefID=" & pRefID
            SQL = SQL & " AND IsClose=0"
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
                SQL = SQL & " VALUES (0"
                SQL = SQL & " , " & pNotifyLevel
                SQL = SQL & " ,'" & pSystem & "'"
                SQL = SQL & " ,'" & pMenuDisplay & "'"
                SQL = SQL & " ,'" & formatSQLDate(pValueDate) & "'"
                SQL = SQL & " ,'" & pRefTable & "'"
                SQL = SQL & " , " & pRefID
                SQL = SQL & " , " & pUserID
                SQL = SQL & " ,'" & pRemark & "'"
                SQL = SQL & " ) "
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
            SQL = SQL & " FROM NotifiData"
            SQL = SQL & " where UserID=" & pUserID
            SQL = SQL & " and RefID=" & pRefID
            SQL = SQL & " and RefTable='" & pRefTable & "'"
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
