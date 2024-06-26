﻿Option Explicit On
Imports System.Data.SqlClient
Public Class SnDAO


#Region "Property"

    Dim mSerialNumberID As Long = 0
    Dim mOrderID As Long = 0
    Dim mProductID As Long = 0
    Dim mSerialNumberNo As String = ""
    Dim mStatus As String = ""
    Dim mIsSelect As Boolean = False
    Dim mProductListID As Long
    Dim mIsDelete As Long = 0

    Public Property IsSelect() As Boolean
        Get
            Return mIsSelect
        End Get
        Set(ByVal value As Boolean)
            mIsSelect = value
        End Set
    End Property
    Public Property ProductListID() As Long
        Get
            Return mProductListID
        End Get
        Set(ByVal value As Long)
            mProductListID = value
        End Set
    End Property
    Public Property SerialNumberID() As Long
        Get
            Return mSerialNumberID
        End Get
        Set(ByVal value As Long)
            mSerialNumberID = value
        End Set
    End Property
    Public Property OrderID() As Long
        Get
            Return mOrderID
        End Get
        Set(ByVal value As Long)
            mOrderID = value
        End Set
    End Property
    Public Property ProductID() As Long
        Get
            Return mProductID
        End Get
        Set(ByVal value As Long)
            mProductID = value
        End Set
    End Property
    Public Property SerialNumberNo() As String
        Get
            Return mSerialNumberNo
        End Get
        Set(ByVal value As String)
            mSerialNumberNo = value
        End Set
    End Property

    Dim mProductName As String = ""
    Public Property ProductName() As String
        Get
            Return mProductName
        End Get
        Set(ByVal value As String)
            mProductName = value
        End Set
    End Property
    Public Property Status() As String
        Get
            Return mStatus
        End Get
        Set(ByVal value As String)
            mStatus = value
        End Set
    End Property

    Public Property IsDelete() As Long
        Get
            Return mIsDelete
        End Get
        Set(ByVal value As Long)
            mIsDelete = value
        End Set
    End Property

#End Region

#Region "Public"


    Public Function GetDataTable(ByVal pOrderID As List(Of Long), ByVal pProductListID As Long, ByVal pProductID As Long _
                                  , ByVal pStatus As String, ByRef tr As SqlTransaction, ByVal pIsDelete As Boolean, ByVal pExcludeSnID As String, ByVal pIsOrderDesc As Boolean) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()
        Dim lRefOrderList As String = ConvertListToString(pOrderID)
        Try
            SQL = "SELECT  "
            If pIsOrderDesc Then
                SQL &= " TOP (1) "
            End If

            SQL &= " SerialNumberID,SerialNumberNo,OrderID,ProductID,Status,ProductListID,IsDelete,IsReset "
            SQL &= " FROM SerialNumber"
            SQL &= " WHERE 1=1 "
            If lRefOrderList <> "" Then
                SQL &= " AND OrderID in(" & lRefOrderList & ")"
            End If
            If pProductListID > 0 Then
                SQL &= " AND ProductListID=" & pProductListID
            End If
            If pProductID > 0 Then
                SQL &= " AND ProductID =" & pProductID
            End If
            If pStatus <> "" Then
                SQL &= " AND Status in(" & pStatus & ")"
            End If
            If pExcludeSnID <> "" Then ' กันกรณีขายสินค้าเดี่ยวกันใน 1 บิล จะตัด SN ซ้ำเพราะ DB ยังไม่ Commit
                SQL &= " AND SerialNumberID not in(" & pExcludeSnID & ")"
            End If
            If pIsDelete = False Then
                SQL &= " and SerialNumber.IsDelete =0   "
            End If

            SQL &= " ORDER BY SerialNumberID"
            If pIsOrderDesc Then
                SQL &= " DESC "
            End If
            dataTable = gConnection.executeSelectQuery(SQL, tr)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "SnDAO.GetDataTable : " & e.Message)
        End Try
        Return dataTable
    End Function

    Public Function CheckSNIsExist(ByVal pProductID As Long, ByVal pSN As String, ByVal pSTatus As String, ByRef tr As SqlTransaction) As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()
        Try
            SQL = "SELECT  SerialNumberID "
            SQL &=  " FROM SerialNumber"
            SQL &=  " WHERE ProductID =" & pProductID
            SQL &=  " AND SerialNumberNo ='" & pSN & "'"
            SQL &=  " AND Status in(" & pSTatus & ") and IsDelete=0"
            dataTable = gConnection.executeSelectQuery(SQL, tr)
            Return dataTable.Rows.Count > 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "SnDAO.CheckSNIsExist : " & e.Message)
        End Try
    End Function

    Public Function SaveData(ByVal tr As SqlTransaction, ByVal pMode As Integer) As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand
        SQL = ""
        Try

            If SerialNumberID = 0 Then
                pMode = DataMode.ModeNew
            ElseIf pMode = DataMode.ModeEdit And IsDelete = 1 And SerialNumberID > 0 Then
                pMode = DataMode.ModeDelete
            End If

            Select Case pMode
                Case DataMode.ModeNew
                    SerialNumberID = GenNewID("SerialNumberID", "SerialNumber", tr)
                    SQL = " INSERT INTO SerialNumber  (SerialNumberID,SerialNumberNo,OrderID,ProductID,Status,ProductListID ,IsDelete,IsReset)"
                    SQL &=  " VALUES ( "
                    SQL &=  "   @SerialNumberID"
                    SQL &=  " ,  @SerialNumberNo"
                    SQL &=  " ,  @OrderID"
                    SQL &=  " ,  @ProductID"
                    SQL &=  " ,  @Status"
                    SQL &=  " ,  @ProductListID"
                    SQL &= " , 0 "
                    SQL &= " , 0 "
                    SQL &=  " ) "
                Case DataMode.ModeEdit
                    SQL = " Update SerialNumber   "
                    SQL &=  " SET"
                    SQL &=  " Status=@Status"
                    SQL &=  " ,SerialNumberNo=@SerialNumberNo"
                    SQL &=  " WHERE SerialNumberID= @SerialNumberID"
                Case DataMode.ModeDelete
                    SQL = " Update SerialNumber Set IsDelete=1 "
                    SQL &=  " WHERE SerialNumberID= @SerialNumberID"
                Case Else
                    Return False
                    Exit Function
            End Select

            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@SerialNumberID", SerialNumberID))
            myCommand.Parameters.Add(New SqlParameter("@SerialNumberNo", SerialNumberNo))
            myCommand.Parameters.Add(New SqlParameter("@OrderID", OrderID))
            myCommand.Parameters.Add(New SqlParameter("@ProductID", ProductID))
            myCommand.Parameters.Add(New SqlParameter("@ProductListID", ProductListID))
            myCommand.Parameters.Add(New SqlParameter("@Status", Status))

            gConnection.executeInsertSqlCommand(myCommand, tr)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "SnDAO.SaveData : " & e.Message)
            Return False
        End Try
    End Function


    Public Sub SetStatusBySN(ByVal tr As SqlTransaction, ByVal pProductID As Long, ByVal pSN As String, ByVal pStatus As String, ByVal pSNID As Long)
        Dim SQL As String
        SQL = ""
        Try
            SQL = " Update SerialNumber   "
            SQL &=  " SET Status='" & pStatus & "'"
            SQL &=  " WHERE SerialNumberNo='" & pSN & "'"
            SQL &=  " AND ProductID=" & pProductID
            SQL &=  " AND Status <> 'None'  and IsDelete=0"
            If pSNID > 0 Then
                SQL &=  " AND SerialNumberID=" & pSNID
            End If
            gConnection.executeInsertQuery(SQL, tr)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "SnDAO.SetStatusBySN : " & e.Message)

        End Try
    End Sub

    Public Sub SetStatusBySNAtRemove(ByVal tr As SqlTransaction, ByVal pOrderID As Long, ByVal pProductID As Long, ByVal pSnIDList As String _
                                     , ByVal pStatus As String, ByVal pProductListID As Long)
        Dim SQL As String
        SQL = ""
        Try
            SQL = " Update SerialNumber   "
            SQL &=  " SET Status='" & pStatus & "'"
            SQL &=  " WHERE SerialNumberNo in ( "
            SQL &=  "      select SerialNumberNo from SerialNumber where SerialNumberID not in (" & pSnIDList & ")"
            SQL &=  "      AND ProductID=" & pProductID & " AND OrderID=" & pOrderID & " and IsDelete=0  AND ProductListID=" & pProductListID & " ) "
            SQL &=  " AND ProductID=" & pProductID
            SQL &=  " AND Status <> 'None'  and IsDelete=0 "
            gConnection.executeInsertQuery(SQL, tr)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "SnDAO.SetStatusBySN : " & e.Message)

        End Try
    End Sub


    'delete some record are remove from grid
    Public Function DeleteRemoveData(ByVal tr As SqlTransaction, ByVal pOrderID As Long, ByVal pProductID As Long, ByVal pstrStayID As String, ByVal pProductListID As Long) As Boolean
        Dim SQL As String
        SQL = ""
        Try
            SQL = " Update SerialNumber set IsDelete=1  "
            SQL &=  " WHERE SerialNumberID NOT IN( " & pstrStayID & ")"
            SQL &=  " AND OrderID=" & pOrderID
            SQL &=  " AND ProductListID=" & pProductListID
            SQL &=  " and IsDelete=0  AND ProductID=" & pProductID
            gConnection.executeInsertQuery(SQL, tr)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "SnDAO.DeleteRemoveData : " & e.Message)
            Return False
        End Try
    End Function

    'delete all when order delete
    Public Function DeleteFromModeDelete(ByVal tr As SqlTransaction, ByVal pOrderID As Long, ByVal pProductListID As Long) As Boolean
        Dim SQL As String
        SQL = ""
        Try
            SQL = " Update SerialNumber set IsDelete=1  "
            SQL &=  " WHERE  OrderID=" & pOrderID
            If pProductListID > 0 Then
                SQL &=  " AND ProductListID=" & pProductListID
            End If

            gConnection.executeInsertQuery(SQL, tr)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "SnDAO.DeleteFromModeDelete : " & e.Message)
            Return False
        End Try
    End Function

    'Update to re open some record are remove from grid List Prolist
    Public Function SetStatusFromProListRemove(ByVal tr As SqlTransaction, ByVal pOrderID As Long, ByVal pProductListIDRemove As String, ByVal pStatus As String) As Boolean
        Dim SQL As String
        SQL = ""
        Try
            SQL = " Update SerialNumber   "
            SQL &=  " SET Status='" & pStatus & "'"
            SQL &=  " WHERE SerialNumberNo in ( "
            SQL &=  "      select SerialNumberNo from SerialNumber where ProductListID not in (" & pProductListIDRemove & ")"
            SQL &=  "      AND OrderID=" & pOrderID & " and IsDelete=0 )"
            SQL &=  " AND Status <> 'None' and IsDelete=0 "
            gConnection.executeInsertQuery(SQL, tr)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "SnDAO.SetStatusFromProListRemove : " & e.Message)
            Return False
        End Try
    End Function


    'delete some record are remove from grid List Prolist
    Public Function DeleteFromProListRemove(ByVal tr As SqlTransaction, ByVal pOrderID As Long, ByVal pProductListRemove As String) As Boolean
        Dim SQL As String
        SQL = ""
        Try
            SQL = " Update SerialNumber set IsDelete=1  "
            SQL &= " WHERE  OrderID=" & pOrderID
            SQL &= " AND ProductListID not in (" & pProductListRemove & ") and IsDelete=0 "
            gConnection.executeInsertQuery(SQL, tr)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "SnDAO.DeleteFromProListRemove : " & e.Message)
            Return False
        End Try
    End Function

    'Reset Running of all product in last sn no.
    Public Sub ResetRunningNo(ByVal tr As SqlTransaction)
        Dim SQL As String
        Try
            SQL = " update [SerialNumber] set IsReset=1   "
            SQL &= "  where SerialNumberID in("
            SQL &= "  	select SerialNumberID"
            SQL &= "  	FROM (select SerialNumberID, SerialNumberNo,ProductID,Status,OrderID, ROW_NUMBER() "
            SQL &= "  		over (partition by ProductID ORDER BY SerialNumberID DESC) as MAX_ID"
            SQL &= "  		from [SerialNumber]"
            SQL &= "  		where Status in ('New','Close')"
            SQL &= "  	  ) x"
            SQL &= "  	WHERE MAX_ID = 1 "
            SQL &= " )"
            gConnection.executeInsertQuery(SQL, tr)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "SnDAO.ResetRunningNo : " & e.Message)

        End Try
    End Sub


#End Region
End Class
