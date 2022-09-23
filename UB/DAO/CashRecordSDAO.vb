Option Explicit On

Imports System.Data.SqlClient
Public Class CashRecordSDAO


#Region "Property"

    Dim mMode As DataMode
    Dim mIDs As Long
    Dim mCashItemID As Long
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

    Public Property CashItemID() As Long
        Get
            Return mCashItemID
        End Get
        Set(ByVal value As Long)
            mCashItemID = value
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

    Public Function GetDataTable(ByVal pCashItemID As Integer, ByVal pFromDate As Date, ByVal pTodate As Date) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT  ID,CashItemID ,RecordDate,Remark,DR,CR"
            SQL &= " FROM CashRecord"
            SQL &= " WHERE IsDelete =0   "
            If pCashItemID > 0 Then
                SQL &= " and CashItemID=" & pCashItemID
            End If
            SQL &= " and RecordDate between '" & formatSQLDate(pFromDate) & "' and '" & formatSQLDate(pTodate) & "'"
            SQL &= " ORDER BY ID"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "CashRecordSDAO.GetDataTable : " & e.Message)
        End Try
        Return dataTable
    End Function


    Public Function SaveData(ByVal tr As SqlTransaction) As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand

        SQL = ""
        Try

            Select Case mMode
                Case DataMode.ModeNew
                    mIDs = GenNewID("ID", "CashRecord", tr)
                    SQL = " INSERT INTO CashRecord  (ID,CashItemID,RecordDate,Remark,DR,CR,IsDelete,CreateBy,CreateTime )"
                    SQL &=  " VALUES ( "
                    SQL &=  "   @ID"
                    SQL &=  " ,  @CashItemID"
                    SQL &=  " ,  @RecordDate"
                    SQL &=  " ,  @Remark"
                    SQL &=  " ,  @DR"
                    SQL &=  " ,  @CR"
                    SQL &=  " ,  @IsDelete"
                    SQL &=  " ,  @gUserID"
                    SQL &=  " ,  @CreateTime"
                    SQL &=  " ) "
                Case DataMode.ModeEdit
                    SQL = " Update CashRecord   "
                    SQL &=  " SET"
                    SQL &=  " CashItemID=@CashItemID"
                    SQL &=  " ,RecordDate= @RecordDate"
                    SQL &=  " ,Remark=@Remark"
                    SQL &=  " ,DR=@DR"
                    SQL &=  " ,CR=@CR"
                    SQL &=  " ,ModifiedBy= @gUserID"
                    SQL &=  " ,ModifiedTime= @CreateTime"
                    SQL &=  " WHERE ID= @ID"
                Case DataMode.ModeDelete
                    SQL = " UPDATE CashRecord SET IsDelete=@IsDelete "
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
            myCommand.Parameters.Add(New SqlParameter("@CashItemID", CashItemID))
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
            Err.Raise(Err.Number, e.Source, "CashRecordSDAO.SaveData : " & e.Message)
            Return False
        End Try
    End Function


    Public Sub New()
        mMode = DataMode.ModeNone
        CashItemID = 0
        RecordDate = Now
        Remark = ""
        DR = 0
        CR = 0
    End Sub

End Class
