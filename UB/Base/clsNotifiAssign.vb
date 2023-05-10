Option Explicit On
Imports System.Data.SqlClient
Public Class clsNotifiAssign




    Dim UserID_ As Long = 0

    Public Sub New()
    End Sub
#Region "Property"
    Dim IsClose_ As Boolean = False
    Public Property IsClose() As Boolean
        Get
            Return IsClose_
        End Get
        Set(ByVal value As Boolean)
            IsClose_ = value
        End Set
    End Property

    Dim OrderID_ As Long = 0
    Public Property OrderID() As Long
        Get
            Return OrderID_
        End Get
        Set(ByVal value As Long)
            OrderID_ = value
        End Set
    End Property

    Dim OrderCode_ As String = ""
    Public Property OrderCode() As String
        Get
            Return OrderCode_
        End Get
        Set(ByVal value As String)
            OrderCode_ = value
        End Set
    End Property

    Dim StatusType_ As Integer = 1
    Public Property StatusType() As Integer
        Get
            Return StatusType_
        End Get
        Set(ByVal value As Integer)
            StatusType_ = value
        End Set
    End Property

    Dim AssignDate_ As String
    Public Property AssignDate() As String
        Get
            Return AssignDate_
        End Get
        Set(ByVal value As String)
            AssignDate_ = value
        End Set
    End Property

    Dim AssignEmp_ As String = ""
    Public Property AssignEmp() As String
        Get
            Return AssignEmp_
        End Get
        Set(ByVal value As String)
            AssignEmp_ = value
        End Set
    End Property

    Dim ShippingEmp_ As String = ""
    Public Property ShippingEmp() As String
        Get
            Return ShippingEmp_
        End Get
        Set(ByVal value As String)
            ShippingEmp_ = value
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
    Public Function GetNotifiList(ByVal pUserID As Long, ByVal pStatusType As Integer) As List(Of clsNotifiAssign)
        Dim SQL As String
        Dim dataTable As New DataTable()
        Dim lclsNotifiList As New List(Of clsNotifiAssign)
        Dim lclsNotifi As clsNotifiAssign
        Try
            SQL = "SELECT * "
            SQL &= " FROM NotifiAssign  "
            SQL &= " WHERE IsClose=0 and UserID =" & pUserID
            SQL &= " and StatusType =" & pStatusType
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    lclsNotifi = New clsNotifiAssign
                    lclsNotifi.IsClose = ConvertNullToString(dr("IsClose"))
                    lclsNotifi.StatusType = ConvertNullToZero(dr("StatusType"))
                    lclsNotifi.OrderID = ConvertNullToZero(dr("OrderID"))
                    lclsNotifi.OrderCode = ConvertNullToString(dr("OrderCode"))
                    lclsNotifi.AssignDate = ConvertNullToString(dr("AssignDate"))


                    lclsNotifi.AssignEmp = ConvertNullToString(dr("AssignEmp"))
                    lclsNotifi.ShippingEmp = ConvertNullToString(dr("ShippingEmp"))
                    lclsNotifi.UserID = ConvertNullToZero(dr("UserID"))

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
        Dim lcls As New OrderSDAO
        Dim SQL As String = ""
        Try

            Dim dataTable = lcls.GetDataTableForShippingRec(New DateTime(GetCurrentDate(Nothing).Year, 1, 1), GetCurrentDate(Nothing), False, True)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    SQL = " INSERT INTO NotifiData  ([IsClose],[OrderID],[OrderCode],[StatusType],[AssignDate],[AssignEmp],[ShippingEmp],[UserID])"
                    SQL &= " VALUES (0"
                    SQL &= " , " & dr("OrderID")
                    SQL &= " ,'" & dr("OrderCode") & "'"

                    If ConvertNullToString(dr("ShippingEmp")) = "" Then
                        SQL &= " ,1 "
                    Else
                        SQL &= " ,2 "
                    End If

                    If IsDBNull(dr("AssignDate")) Then
                        SQL &= " ,''"
                    Else
                        SQL &= " ,'" & dr("AssignDate").ToString("dd/MM/yyyy") & "'"
                    End If
                    SQL &= " ,''"  'AssignEmp
                    SQL &= " ,'" & ConvertNullToString(dr("ShippingEmp")) & "'"
                    SQL &= " ," & gUserID
                    SQL &= " ) "
                    gConnection.executeInsertQuery(SQL, Nothing)


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
            Dim SQL = " SET ARITHABORT OFF; EXEC [dbo].[spOverdueTX] "
            SQL &= " @FromDate = '" & formatSQLDate(GetCurrentDate(Nothing).AddYears(-2)) & "'"
            SQL &= " ,@ToDate = '" & formatSQLDate(GetCurrentDate(Nothing)) & "'"
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
            SQL &= " WHERE UserID=" & gUserID
            SQL &= " AND RefTable='" & pRefTable & "'"
            SQL &= " AND RefID=" & pRefID
            SQL &= " AND IsClose=0"
            gConnection.executeInsertQuery(SQL, Nothing)

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "clsNotifi.CloseNotifi : " & e.Message)
        End Try
    End Function



#End Region
End Class
