
Option Explicit On
Imports System.Data.SqlClient

Public Class TaxOrderDAO


#Region "Property"
    Dim mIDs As Long
    Dim mMode As Integer
    Dim mTaxTypeID As Integer
    Dim mRefOrderID As Long
    Dim mTaxTotal As Double
    Dim mTaxRate As Double
    Dim mTaxAmount As Double
    Dim mOtherTax As String

    Public Property RefOrderID() As Long
        Get
            Return mRefOrderID
        End Get
        Set(ByVal value As Long)
            mRefOrderID = value
        End Set
    End Property

    Public Property TaxOrderID() As Long
        Get
            Return mIDs
        End Get
        Set(ByVal value As Long)
            mIDs = value
        End Set
    End Property
    Public Property TaxTypeID() As Long
        Get
            Return mTaxTypeID
        End Get
        Set(ByVal value As Long)
            mTaxTypeID = value
        End Set
    End Property
    Public Property TaxTotal() As Double
        Get
            Return mTaxTotal
        End Get
        Set(ByVal value As Double)
            mTaxTotal = value
        End Set
    End Property
    Public Property TaxRate() As Double
        Get
            Return mTaxRate
        End Get
        Set(ByVal value As Double)
            mTaxRate = value
        End Set
    End Property
    Public Property TaxAmount() As Double
        Get
            Return mTaxAmount
        End Get
        Set(ByVal value As Double)
            mTaxAmount = value
        End Set
    End Property
    Public Property OtherTax() As String
        Get
            Return mOtherTax
        End Get
        Set(ByVal value As String)
            mOtherTax = value
        End Set
    End Property

#End Region

    Public Function GetDataTable(ByVal pRefOrderID As Long, ByVal pIsSelectAll As Boolean) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT  TaxOrderID  ,TaxTypeID,TaxTotal,TaxRate,TaxAmount,OtherTax "
            SQL = SQL & " FROM TaxOrder"
            SQL = SQL & " WHERE IsDelete =0   "
            If pIsSelectAll = False Then
                SQL = SQL & " AND RefOrderID =" & pRefOrderID
            End If
            SQL = SQL & " ORDER BY TaxOrderID"

            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "TaxOrderDAO.GetDataTable : " & e.Message)
        End Try
        Return dataTable
    End Function

    Public Function GetDataTableByTaxNo(ByVal pTaxNo As String) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT TaxOrder.TaxTypeID,MAX(Orders.OrderDate) as OrderDate,MAX(TaxOrder.OtherTax) as OtherTax "
            SQL = SQL & ",sum(TaxOrder.TaxTotal) as TaxTotal,sum(TaxOrder.TaxAmount) as TaxAmount"
            SQL = SQL & " FROM Orders"
            SQL = SQL & " Inner join TaxOrder on TaxOrder.RefOrderID=Orders.OrderID "
            SQL = SQL & " WHERE Orders.IsDelete =0 and Orders.TaxNumber='" & pTaxNo & "'"
            SQL = SQL & " Group BY TaxOrder.TaxTypeID"
            SQL = SQL & " ORDER BY TaxOrder.TaxTypeID"

            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "TaxOrderDAO.GetDataTableByTaxNo : " & e.Message)
        End Try
        Return dataTable
    End Function

    Public Function SaveData(ByVal tr As SqlTransaction, pMode As Integer) As Boolean
        Dim SQL As String = ""
        Dim myCommand As SqlCommand
        Try
            If   TaxOrderID <= 0 And RefOrderID <> 0 Then
                mMode = DataMode.ModeNew
            ElseIf TaxOrderID > 0 And RefOrderID <> 0 Then
                mMode = DataMode.ModeEdit
            ElseIf pMode = DataMode.ModeDelete Then
                mMode = pMode
            Else  'not chang
                mMode = DataMode.ModeNone
            End If

            Select Case mMode
                Case DataMode.ModeNew
                    mIDs = GenNewID("TaxOrderID", "TaxOrder", tr)
                    SQL = " INSERT INTO TaxOrder (TaxOrderID,TaxTypeID,TaxTotal,TaxRate,TaxAmount,RefOrderID,IsDelete,OtherTax )"
                    SQL = SQL & " VALUES ( "
                    SQL = SQL & "   @TaxOrderID"
                    SQL = SQL & " ,  @TaxTypeID"
                    SQL = SQL & " ,  @TaxTotal"
                    SQL = SQL & " ,  @TaxRate"
                    SQL = SQL & " ,  @TaxAmount"
                    SQL = SQL & " ,  @RefOrderID"
                    SQL = SQL & " ,  @IsDelete"
                    SQL = SQL & " ,  @OtherTax"
                    SQL = SQL & " ) "
                Case DataMode.ModeEdit
                    SQL = " Update TaxOrder SET"
                    SQL = SQL & " TaxTypeID=@TaxTypeID"
                    SQL = SQL & " ,TaxTotal=@TaxTotal"
                    SQL = SQL & " ,TaxRate=@TaxRate"
                    SQL = SQL & " ,TaxAmount=@TaxAmount"
                    SQL = SQL & " ,OtherTax=@OtherTax"
                    SQL = SQL & " WHERE TaxOrderID= @TaxOrderID"
                Case DataMode.ModeDelete
                    SQL = " UPDATE TaxOrder SET IsDelete=@IsDelete "
                    SQL = SQL & " WHERE TaxOrderID= @TaxOrderID"
                Case Else
                    Return False
                    Exit Function
            End Select
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@TaxOrderID", mIDs))
            myCommand.Parameters.Add(New SqlParameter("@RefOrderID", RefOrderID))
            myCommand.Parameters.Add(New SqlParameter("@TaxTypeID", ConvertNullToZero(TaxTypeID)))
            myCommand.Parameters.Add(New SqlParameter("@TaxTotal", ConvertNullToZero(TaxTotal)))
            myCommand.Parameters.Add(New SqlParameter("@TaxRate", ConvertNullToZero(TaxRate)))
            myCommand.Parameters.Add(New SqlParameter("@TaxAmount", ConvertNullToZero(TaxAmount)))
            myCommand.Parameters.Add(New SqlParameter("@OtherTax", ConvertNullToString(OtherTax)))
            Select Case mMode
                Case DataMode.ModeNew
                    myCommand.Parameters.Add(New SqlParameter("@IsDelete", 0))
                Case DataMode.ModeDelete
                    myCommand.Parameters.Add(New SqlParameter("@IsDelete", 1))
            End Select
            gConnection.executeInsertSqlCommand(myCommand, tr)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "TaxOrderDAO.SaveData : " & e.Message)
            Return False
        End Try
    End Function

    Public Function DeleteAllData(ByVal tr As SqlTransaction) As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand

        SQL = ""
        Try
            SQL = " UPDATE TaxOrder SET IsDelete=@IsDelete "
            SQL = SQL & " WHERE RefOrderID=@RefOrderID "
            myCommand = New SqlCommand
            myCommand.CommandText = SQL

            myCommand.Parameters.Add(New SqlParameter("@RefOrderID", RefOrderID))
            myCommand.Parameters.Add(New SqlParameter("@IsDelete", 1))
            gConnection.executeInsertSqlCommand(myCommand, tr)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "TaxOrderDAO.DeleteAllData : " & e.Message)
            Return False
        End Try


    End Function
    Public Sub New()
        mOtherTax = ""
        mIDs = 0
        mMode = 0
        mTaxTypeID = 0
        mRefOrderID = 0
        mTaxTotal = 0
        mTaxRate = 0
        mTaxAmount = 0
    End Sub
End Class
