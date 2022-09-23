
Option Explicit On
Imports System.Data.SqlClient
Public Class PledgeDAO

#Region "Property"
    Private mMode As DataMode
    Private mIDs As Long
    Private mRefOrderID As Long
    Private mOrderCode As String
    Private mOrderDate As Date
    Private mTotal As Double
    Private mRemark As String


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

    Public Property RefOrderID() As Long
        Get
            Return mRefOrderID
        End Get
        Set(ByVal value As Long)
            mRefOrderID = value
        End Set
    End Property
    Public Property OrderCode() As String
        Get
            Return mOrderCode
        End Get
        Set(ByVal value As String)
            mOrderCode = value
        End Set
    End Property

    Public Property OrderDate() As Date
        Get
            Return mOrderDate
        End Get
        Set(ByVal value As Date)
            mOrderDate = value
        End Set
    End Property
    Public Property Total() As Double
        Get
            Return mTotal
        End Get
        Set(ByVal value As Double)
            mTotal = value
        End Set
    End Property

    Public Property Remark() As String
        Get
            Return mRemark
        End Get
        Set(ByVal value As String)
            mRemark = value
        End Set
    End Property

#End Region

    Public Function GetDataTable(ByVal pRefOrderID As Long) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()
        Try
            SQL = "SELECT  PledgeID AS ID,RefOrderID,OrderCode,OrderDate,Total,Remark"
            SQL &=  " FROM Pledge"
            SQL &=  " WHERE RefOrderID =" & pRefOrderID
            SQL &=  " AND Pledge.IsDelete =0   "
            SQL &=  " ORDER BY PledgeID"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "PledgeDAO.GetDataTable : " & e.Message)
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
            ElseIf ID <= 0 And RefOrderID <> 0 Then
                mMode = DataMode.ModeNew
            ElseIf ID > 0 And RefOrderID <> 0 Then
                mMode = DataMode.ModeEdit
            Else  'not chang
                mMode = DataMode.ModeNone
            End If

            Select Case mMode
                Case DataMode.ModeNew
                    mIDs = GenNewID("PledgeID", "Pledge", tr)
                    SQL = " INSERT INTO Pledge (PledgeID,RefOrderID,OrderCode,OrderDate,Total,Remark,IsDelete )"
                    SQL &=  " VALUES ( "
                    SQL &=  "   @ID"
                    SQL &=  " ,  @RefOrderID"
                    SQL &=  " ,  @OrderCode"
                    SQL &=  " ,  @OrderDate"
                    SQL &=  " ,  @Total"
                    SQL &=  " ,  @Remark"
                    SQL &=  " ,  @IsDelete"
                    SQL &=  " ) "
                Case DataMode.ModeEdit
                    SQL = " Update Pledge SET"
                    SQL &=  " OrderCode=@OrderCode"
                    SQL &=  " ,OrderDate=@OrderDate"
                    SQL &=  " ,Total=@Total"
                    SQL &=  " ,Remark=@Remark"
                    SQL &=  " WHERE PledgeID= @ID"
                Case DataMode.ModeDelete
                    SQL = " UPDATE Pledge SET IsDelete=@IsDelete "
                    SQL &=  " WHERE PledgeID= @ID"
                Case Else
                    Return False
                    Exit Function
            End Select
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@ID", mIDs))
            myCommand.Parameters.Add(New SqlParameter("@RefOrderID", RefOrderID))
            myCommand.Parameters.Add(New SqlParameter("@OrderCode", OrderCode))
            myCommand.Parameters.Add(New SqlParameter("@OrderDate", formatSQLDate(OrderDate)))
            myCommand.Parameters.Add(New SqlParameter("@Total", ConvertNullToZero(Total)))
            myCommand.Parameters.Add(New SqlParameter("@Remark", Remark.Trim))
            Select Case ModeData
                Case DataMode.ModeNew
                    myCommand.Parameters.Add(New SqlParameter("@IsDelete", 0))
                Case DataMode.ModeDelete
                    myCommand.Parameters.Add(New SqlParameter("@IsDelete", 1))
            End Select
            gConnection.executeInsertSqlCommand(myCommand, tr)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "PledgeDAO.SaveData : " & e.Message)
            Return False
        End Try
    End Function

    'delete all ref
    Public Function DeleteAllData(ByVal tr As SqlTransaction) As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand

        SQL = ""
        Try
            SQL = " UPDATE Pledge SET IsDelete=@IsDelete "
            SQL &=  " WHERE RefOrderID=@RefOrderID "
            myCommand = New SqlCommand
            myCommand.CommandText = SQL

            myCommand.Parameters.Add(New SqlParameter("@RefOrderID", RefOrderID))
            myCommand.Parameters.Add(New SqlParameter("@IsDelete", 1))
            gConnection.executeInsertSqlCommand(myCommand, tr)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "PledgeDAO.DeleteAllData : " & e.Message)
            Return False
        End Try
    End Function

    Public Sub New()
        mMode = DataMode.ModeNone
        mIDs = 0
        mRefOrderID = 0
        mOrderCode = ""
        mTotal = 0
        mRemark = ""
        mOrderDate = Now.Date
    End Sub
End Class
