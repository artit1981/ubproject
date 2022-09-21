Option Explicit On

Imports System.Data.SqlClient
Public Class BankAccountRecordSDAO



#Region "Property"

    Dim mMode As DataMode
    Dim mIDs As Long
    Dim mBankAccountID As Long
    Dim mRecordDate As Date
    Dim mRemark As String
    Dim mDR As Double
    Dim mCR As Double

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

    Public Property BankAccountID() As Long
        Get
            Return mBankAccountID
        End Get
        Set(ByVal value As Long)
            mBankAccountID = value
        End Set
    End Property


    Public Property RecordDate() As Date
        Get
            Return mRecordDate
        End Get
        Set(ByVal value As Date)
            mRecordDate = value
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

    Public Property DR() As Double
        Get
            Return mDR
        End Get
        Set(ByVal value As Double)
            mDR = value
        End Set
    End Property

    Public Property CR() As Double
        Get
            Return mCR
        End Get
        Set(ByVal value As Double)
            mCR = value
        End Set
    End Property
#End Region

    Public Function GetDataTable(ByVal pRefID As Long) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT  ID,BankAccountID ,RecordDate,Remark,DR,CR"
            SQL = SQL & " FROM BankAccountRecord"
            SQL = SQL & " WHERE IsDelete =0   "
            SQL = SQL & " ORDER BY ID"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "BankAccountRecordSDAO.GetDataTable : " & e.Message)
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
            ElseIf ID <= 0 Then
                mMode = DataMode.ModeNew
            ElseIf ID > 0 Then
                mMode = DataMode.ModeEdit
            Else  'not chang
            End If

            Select Case mMode
                Case DataMode.ModeNew
                    mIDs = GenNewID("ID", "BankAccountRecord", tr)
                    SQL = " INSERT INTO BankAccountRecord  (ID,BankAccountID,RecordDate,Remark,DR,CR,IsDelete )"
                    SQL = SQL & " VALUES ( "
                    SQL = SQL & "   @ID"
                    SQL = SQL & " ,  @BankAccountID"
                    SQL = SQL & " ,  @RecordDate"
                    SQL = SQL & " ,  @Remark"
                    SQL = SQL & " ,  @DR"
                    SQL = SQL & " ,  @CR"
                    SQL = SQL & " ,  @IsDelete"
                    SQL = SQL & " ) "
                Case DataMode.ModeEdit
                    SQL = " Update BankAccountRecord   "
                    SQL = SQL & " SET"
                    SQL = SQL & " BankAccountID=@BankAccountID"
                    SQL = SQL & " ,RecordDate= @RecordDate"
                    SQL = SQL & " ,Remark=@Remark"
                    SQL = SQL & " ,DR=@DR"
                    SQL = SQL & " ,CR=@CR"
                    SQL = SQL & " WHERE ID= @ID"
                Case DataMode.ModeDelete
                    SQL = " UPDATE BankAccountRecord SET IsDelete=@IsDelete "
                    SQL = SQL & " WHERE ID= @ID"
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

            Select Case ModeData
                Case DataMode.ModeNew
                    myCommand.Parameters.Add(New SqlParameter("@IsDelete", 0))
                Case DataMode.ModeDelete
                    myCommand.Parameters.Add(New SqlParameter("@IsDelete", 1))
            End Select
            gConnection.executeInsertSqlCommand(myCommand, tr)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "BankAccountRecordSDAO.SaveData : " & e.Message)
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
