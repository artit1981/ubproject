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

    Public Function GetDataTable(ByVal pBankAccID As Integer, ByVal pFromDate As Date, ByVal pTodate As Date, lIsIncludeDelete As Boolean) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT  ID,BankAccountID ,RecordDate,Remark,DR,CR,IsDelete"
            SQL &= " FROM BankAccountRecord"
            SQL &= " WHERE 0=0   "
            If lIsIncludeDelete = False Then
                SQL &= " and IsDelete =0   "
            End If
            If pBankAccID > 0 Then
                SQL &= " and BankAccountID=" & pBankAccID
            End If
            SQL &= " and RecordDate between '" & formatSQLDate(pFromDate) & "' and '" & formatSQLDate(pTodate) & "'"
            SQL &= " ORDER BY ID"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "CommissionDtlDAO.GetDataTable : " & e.Message)
        End Try
        Return dataTable
    End Function


    Public Function SaveData(ByVal tr As SqlTransaction) As Boolean
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
                    SQL &= " BankAccountID=@BankAccountID"
                    SQL &= " ,RecordDate= @RecordDate"
                    SQL &= " ,Remark=@Remark"
                    SQL &= " ,DR=@DR"
                    SQL &= " ,CR=@CR"
                    SQL &= " ,ModifiedBy= @gUserID"
                    SQL &= " ,ModifiedTime= @CreateTime"
                    SQL &= " WHERE ID= @ID"
                Case DataMode.ModeDelete
                    SQL = " UPDATE BankAccountRecord SET IsDelete=@IsDelete "
                    SQL &= " ,ModifiedBy= @gUserID"
                    SQL &= " ,ModifiedTime= @CreateTime"
                    SQL &= " WHERE ID= @ID"
                Case Else
                    Return False
                    Exit Function
            End Select
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@ID", mIDs))
            myCommand.Parameters.Add(New SqlParameter("@BankAccountID", BankAccountID))
            myCommand.Parameters.Add(New SqlParameter("@RecordDate", RecordDate))
            myCommand.Parameters.Add(New SqlParameter("@Remark", Remark))
            myCommand.Parameters.Add(New SqlParameter("@DR", DR))
            myCommand.Parameters.Add(New SqlParameter("@CR", CR))
            myCommand.Parameters.Add(New SqlParameter("@gUserID", gUserID))
            myCommand.Parameters.Add(New SqlParameter("@CreateTime", formatSQLDateTime(GetCurrentDate(tr))))
            Select Case ModeData
                Case DataMode.ModeNew
                    myCommand.Parameters.Add(New SqlParameter("@IsDelete", 0))
                Case DataMode.ModeDelete
                    myCommand.Parameters.Add(New SqlParameter("@IsDelete", 1))
            End Select
            gConnection.executeInsertSqlCommand(myCommand, tr)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "CommissionDtlDAO.SaveData : " & e.Message)
            Return False
        End Try
    End Function


    Public Sub New()
        mMode = DataMode.ModeNone
        BankAccountID = 0
        RecordDate = Now
        Remark = ""
        DR = 0
        CR = 0
    End Sub

End Class
