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

    Public Function GetDataTable(ByVal pBankAccID As Integer, ByVal pFromDate As Date, ByVal pTodate As Date) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT  ID,BankAccountID ,RecordDate,Remark,DR,CR"
            SQL &= " FROM BankAccountRecord"
            SQL &= " WHERE IsDelete =0   "
            If pBankAccID > 0 Then
                SQL &= " and BankAccountID=" & pBankAccID
            End If
            SQL &= " and RecordDate between '" & formatSQLDate(pFromDate) & "' and '" & formatSQLDate(pTodate) & "'"
            SQL &= " ORDER BY ID"
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
            'If mMode = DataMode.ModeNew Then
            'ElseIf mMode = DataMode.ModeDelete Then
            'ElseIf ID <= 0 Then
            '    mMode = DataMode.ModeNew
            '    'ElseIf ID > 0 Then
            '    '    mMode = DataMode.ModeEdit
            'Else  'not chang
            '    Return True
            'End If

            Select Case mMode
                Case DataMode.ModeNew
                    mIDs = GenNewID("ID", "BankAccountRecord", tr)
                    SQL = " INSERT INTO BankAccountRecord  (ID,BankAccountID,RecordDate,Remark,DR,CR,IsDelete,CreateBy,CreateTime )"
                    SQL &=  " VALUES ( "
                    SQL &=  "   @ID"
                    SQL &=  " ,  @BankAccountID"
                    SQL &=  " ,  @RecordDate"
                    SQL &=  " ,  @Remark"
                    SQL &=  " ,  @DR"
                    SQL &=  " ,  @CR"
                    SQL &=  " ,  @IsDelete"
                    SQL &=  " ,  @gUserID"
                    SQL &=  " ,  @CreateTime"
                    SQL &=  " ) "
                Case DataMode.ModeEdit
                    SQL = " Update BankAccountRecord   "
                    SQL &=  " SET"
                    SQL &=  " BankAccountID=@BankAccountID"
                    SQL &=  " ,RecordDate= @RecordDate"
                    SQL &=  " ,Remark=@Remark"
                    SQL &=  " ,DR=@DR"
                    SQL &=  " ,CR=@CR"
                    SQL &=  " ,ModifiedBy= @gUserID"
                    SQL &=  " ,ModifiedTime= @CreateTime"
                    SQL &=  " WHERE ID= @ID"
                Case DataMode.ModeDelete
                    SQL = " UPDATE BankAccountRecord SET IsDelete=@IsDelete "
                    SQL &=  " ,ModifiedBy= @gUserID"
                    SQL &=  " ,ModifiedTime= @CreateTime"
                    SQL &=  " WHERE ID= @ID"
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
