Option Explicit On

Imports System.Data.SqlClient
Public Class CommissionDtlDAO



#Region "Property"


    Dim mCommissionDtlID As Long = 0
    Public Property CommissionDtlID() As Long
        Get
            Return mCommissionDtlID
        End Get
        Set(ByVal value As Long)
            mCommissionDtlID = value
        End Set
    End Property

    Dim mSEQ As Long = 0
    Public Property SEQ() As Long
        Get
            Return mSEQ
        End Get
        Set(ByVal value As Long)
            mSEQ = value
        End Set
    End Property

    Dim mCommissionID As Long = 0
    Public Property CommissionID() As Long
        Get
            Return mCommissionID
        End Get
        Set(ByVal value As Long)
            mCommissionID = value
        End Set
    End Property

    Dim mAmountFrom As Double = 0
    Public Property AmountFrom() As Double
        Get
            Return mAmountFrom
        End Get
        Set(ByVal value As Double)
            mAmountFrom = value
        End Set
    End Property

    Dim mAmountEnd As Double = 0
    Public Property AmountEnd() As Double
        Get
            Return mAmountEnd
        End Get
        Set(ByVal value As Double)
            mAmountEnd = value
        End Set
    End Property

    Dim mComAmount As Double = 0
    Public Property ComAmount() As Double
        Get
            Return mComAmount
        End Get
        Set(ByVal value As Double)
            mComAmount = value
        End Set
    End Property

    Dim mComPercen As Double = 0
    Public Property ComPercen() As Double
        Get
            Return mComPercen
        End Get
        Set(ByVal value As Double)
            mComPercen = value
        End Set
    End Property


    Private mModeData As Integer
    Public Property ModeData() As Integer
        Get
            Return mModeData
        End Get
        Set(ByVal value As Integer)
            mModeData = value
        End Set
    End Property
#End Region

    Public Function GetDataTable(ByVal pCommissionID As Long) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT  CommissionDtlID,SEQ,CommissionID,AmountFrom,AmountEnd,ComAmount,ComPercen"
            SQL &= " FROM CommissionDtl"
            SQL &= " WHERE 0=0   "
            SQL &= " and CommissionID =" & pCommissionID
            SQL &= " ORDER BY SEQ"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "CommissionDtlDAO.GetDataTable : " & e.Message)
        End Try
        Return dataTable
    End Function


    Public Function SaveData(ByVal tr As SqlTransaction, ByVal pCommissionID As Long) As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand

        SQL = ""
        Try


            Select Case mModeData
                Case DataMode.ModeNew
                    mCommissionDtlID = GenNewID("CommissionDtlID", "CommissionDtl", tr)
                    SQL = " INSERT INTO CommissionDtl  (CommissionDtlID,SEQ,CommissionID,AmountFrom,AmountEnd,ComAmount,ComPercen  )"
                    SQL &= " VALUES ( "
                    SQL &= "   @CommissionDtlID"
                    SQL &= " ,  @SEQ"
                    SQL &= " ,  @CommissionID"
                    SQL &= " ,  @AmountFrom"
                    SQL &= " ,  @AmountEnd"
                    SQL &= " ,  @ComAmount"
                    SQL &= " ,  @ComPercen"
                    SQL &= " ) "
                Case DataMode.ModeEdit
                    SQL = " Update CommissionDtl   "
                    SQL &= " SET"
                    SQL &= " SEQ=@SEQ"
                    SQL &= " ,AmountFrom= @AmountFrom"
                    SQL &= " ,AmountEnd=@AmountEnd"
                    SQL &= " ,ComAmount=@ComAmount"
                    SQL &= " ,ComPercen=@ComPercen"
                    SQL &= " WHERE CommissionDtlID= @CommissionDtlID"
                Case DataMode.ModeDelete
                    SQL = " delete from  CommissionDtl  "
                    SQL &= " WHERE CommissionDtlID= @CommissionDtlID"
                Case Else
                    Return False
                    Exit Function
            End Select
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@CommissionDtlID", CommissionDtlID))
            myCommand.Parameters.Add(New SqlParameter("@SEQ", SEQ))
            myCommand.Parameters.Add(New SqlParameter("@CommissionID", pCommissionID))
            myCommand.Parameters.Add(New SqlParameter("@AmountFrom", AmountFrom))
            myCommand.Parameters.Add(New SqlParameter("@AmountEnd", AmountEnd))
            myCommand.Parameters.Add(New SqlParameter("@ComAmount", ComAmount))
            myCommand.Parameters.Add(New SqlParameter("@ComPercen", ComPercen))
            gConnection.executeInsertSqlCommand(myCommand, tr)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "CommissionDtlDAO.SaveData : " & e.Message)
            Return False
        End Try
    End Function




End Class
