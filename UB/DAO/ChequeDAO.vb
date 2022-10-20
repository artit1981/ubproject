
Option Explicit On
Imports System.Data.SqlClient

Public Class ChequeDAO
    'Inherits ChequeSubDAO

#Region "Property"
    Dim mIDs As Long
    Dim mMode As Integer
    Dim mRefOrderID As Long
    Dim mBankDocType As String
    Dim mChequeNo As String
    Dim mChequeDate As Date
    Dim mChequeBalance As Double
    Dim mChequePay As Double
    Dim mCashType As String
    Dim mChequeDateReceive As Date
    Dim mChequeDateDue As Date
    Dim mChequeOwnerTH As String
    Dim mChequeOwnerEN As String
    Dim mBankID As Long
    Dim mBankBranch As String
    Dim mChequeType As Integer
    Dim mChequeStep As String
    Dim mChequeStatus As String
    Dim mChequeDatePass As Date
    Dim mChequeDateStop As Date
    Dim mBankAccountID As Long
    Dim mRemark As String

    Public Property ID() As Long
        Get
            Return mIDs
        End Get
        Set(ByVal value As Long)
            mIDs = value
        End Set
    End Property


    Public Property BankDocType() As String
        Get
            Return mBankDocType
        End Get
        Set(ByVal value As String)
            mBankDocType = value
        End Set
    End Property

    Public Property ChequeNo() As String
        Get
            Return mChequeNo
        End Get
        Set(ByVal value As String)
            mChequeNo = value
        End Set
    End Property
    Public Property ChequeDate() As Date
        Get
            Return mChequeDate
        End Get
        Set(ByVal value As Date)
            mChequeDate = value
        End Set
    End Property

    Public Property ChequeBalance() As Double
        Get
            Return mChequeBalance
        End Get
        Set(ByVal value As Double)
            mChequeBalance = value
        End Set
    End Property
    Public Property ChequePay() As Double
        Get
            Return mChequePay
        End Get
        Set(ByVal value As Double)
            mChequePay = value
        End Set
    End Property

    Public Property ModeData() As Integer
        Get
            Return mMode
        End Get
        Set(ByVal Value As Integer)
            mMode = Value
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

    Public Property CashType() As String ' D , W
        Get
            Return mCashType
        End Get
        Set(ByVal value As String)
            mCashType = value
        End Set
    End Property


    Public Property ChequeDateReceive() As Date
        Get
            Return mChequeDateReceive
        End Get
        Set(ByVal value As Date)
            mChequeDateReceive = value
        End Set
    End Property
    Public Property ChequeDateDue() As Date
        Get
            Return mChequeDateDue
        End Get
        Set(ByVal value As Date)
            mChequeDateDue = value
        End Set
    End Property
    Public Property ChequeOwnerTH() As String
        Get
            Return mChequeOwnerTH
        End Get
        Set(ByVal value As String)
            mChequeOwnerTH = value
        End Set
    End Property
    Public Property ChequeOwnerEN() As String
        Get
            Return mChequeOwnerEN
        End Get
        Set(ByVal value As String)
            mChequeOwnerEN = value
        End Set
    End Property
    Public Property BankID() As Long
        Get
            Return mBankID
        End Get
        Set(ByVal value As Long)
            mBankID = value
        End Set
    End Property
    Public Property BankBranch() As String
        Get
            Return mBankBranch
        End Get
        Set(ByVal value As String)
            mBankBranch = value
        End Set
    End Property

    Public Property ChequeType() As Integer
        Get
            Return mChequeType
        End Get
        Set(ByVal value As Integer)
            mChequeType = value
        End Set
    End Property
    Public Property ChequeStep() As String
        Get
            Return mChequeStep
        End Get
        Set(ByVal value As String)
            mChequeStep = value
        End Set
    End Property
    Public Property ChequeStatus() As String
        Get
            Return mChequeStatus
        End Get
        Set(ByVal value As String)
            mChequeStatus = value
        End Set
    End Property
    Public Property ChequeDatePass() As Date
        Get
            Return mChequeDatePass
        End Get
        Set(ByVal value As Date)
            mChequeDatePass = value
        End Set
    End Property
    Public Property ChequeDateStop() As Date
        Get
            Return mChequeDateStop
        End Get
        Set(ByVal value As Date)
            mChequeDateStop = value
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
    Public Property Remark() As String
        Get
            Return mRemark
        End Get
        Set(ByVal value As String)
            mRemark = value
        End Set
    End Property
#End Region


    Public Function GetDataTable(ByVal pRefOrderID As Long, Optional ByVal pBankID As Long = 0 _
                                , Optional ByVal pDateFrom As Date = Nothing, Optional ByVal pDateTo As Date = Nothing _
                                , Optional ByVal pIsNewOnly As Boolean = False, Optional ByVal pChequeID As Long = 0) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT  ChequeID as ID,RefOrderID,BankDocType,CashType,ChequeOwnerTH,ChequeOwnerEN, BankID,BankAccountID "
            SQL &=  " ,ChequeNo,ChequeDate,ChequeBalance,ChequePay,BankBranch,ChequeType,ChequeStep ,ChequeStatus,Cheque.Remark  "
            SQL &=  " ,ChequeDateDue,ChequeDatePass,ChequeDateReceive,ChequeDateStop,ChequeOwnerTH,Orders.GrandTotal"
            SQL &=  " FROM Cheque"
            SQL &=  " LEFT OUTER JOIN Orders ON Orders.OrderID=Cheque.RefOrderID and Orders.IsDelete=0 and Orders.TableID in(" & MasterType.Receipt & "," & MasterType.ReceiptCut & ")"
            SQL &=  " WHERE Cheque.IsDelete =0   "
            If pChequeID > 0 Then
                SQL &=  " AND Cheque.ChequeID =" & pChequeID
            End If
            If pRefOrderID >= 0 Then
                SQL &=  " AND Cheque.RefOrderID =" & pRefOrderID
            End If
            If pBankID > 0 Then
                SQL &=  " AND BankID =" & pBankID
            End If
            If pDateFrom > "1990-01-01" And pDateTo > "1990-01-01" Then
                SQL &=  " AND ChequeDate between '" & formatSQLDate(pDateFrom) & "'"
                SQL &=  "                   and  '" & formatSQLDate(pDateTo) & "'"
            End If
            If pIsNewOnly = True Then
                SQL &=  " AND ChequeStatus ='N'"
            End If
            SQL &=  " ORDER BY ChequeID"

            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ChequeDAO.GetDataTable : " & e.Message)
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
                mMode = DataMode.ModeNone
            End If

            Select Case mMode
                Case DataMode.ModeNew
                    mIDs = GenNewID("ChequeID", "Cheque", tr)
                    SQL = " INSERT INTO Cheque (ChequeID,RefOrderID,BankDocType,ChequeNo,ChequeDate,ChequeBalance,ChequePay "
                    SQL &=  " ,CashType,ChequeDateReceive,ChequeDateDue,ChequeOwnerTH,ChequeOwnerEN,BankID,BankBranch "
                    SQL &=  " ,ChequeType,ChequeStep,ChequeStatus,ChequeDatePass,ChequeDateStop,BankAccountID"
                    SQL &=  " ,Remark,IsDelete )"
                    SQL &=  " VALUES ( "
                    SQL &=  "   @ID"
                    SQL &=  " ,  @RefOrderID"
                    SQL &=  " ,  @BankDocType"
                    SQL &=  " ,  @ChequeNo"
                    SQL &=  " ,  @ChequeDate"
                    SQL &=  " ,  @ChequeBalance"
                    SQL &=  " ,  @ChequePay"
                    SQL &=  " ,  @CashType"
                    SQL &=  " ,  @ChequeDateReceive"
                    SQL &=  " ,  @ChequeDateDue"
                    SQL &=  " ,  @ChequeOwnerTH"
                    SQL &=  " ,  @ChequeOwnerEN"
                    SQL &=  " ,  @BankID"
                    SQL &=  " ,  @BankBranch"
                    SQL &=  " ,  @ChequeType"
                    SQL &=  " ,  @ChequeStep"
                    SQL &=  " ,  @ChequeStatus"
                    SQL &=  " ,  @ChequeDatePass"
                    SQL &=  " ,  @ChequeDateStop"
                    SQL &=  " ,  @BankAccountID"
                    SQL &=  " ,  @Remark"
                    SQL &=  " ,  @IsDelete"
                    SQL &=  " ) "
                Case DataMode.ModeEdit
                    SQL = " Update Cheque SET"
                    SQL &=  " BankDocType=@BankDocType"
                    SQL &=  " ,ChequeNo=@ChequeNo"
                    SQL &=  " ,ChequeDate=@ChequeDate"
                    SQL &=  " ,ChequeBalance=@ChequeBalance"
                    SQL &=  " ,ChequePay=@ChequePay"
                    SQL &=  " ,CashType=@CashType"
                    SQL &=  " ,ChequeDateReceive=@ChequeDateReceive"
                    SQL &=  " ,ChequeDateDue=@ChequeDateDue"
                    SQL &=  " ,ChequeOwnerTH=@ChequeOwnerTH"
                    SQL &=  " ,ChequeOwnerEN=@ChequeOwnerEN"
                    SQL &=  " ,BankID=@BankID"
                    SQL &=  " ,BankBranch=@BankBranch"
                    SQL &=  " ,ChequeType=@ChequeType"
                    SQL &=  " ,ChequeStep=@ChequeStep"
                    SQL &=  " ,ChequeStatus=@ChequeStatus"
                    SQL &=  " ,ChequeDatePass=@ChequeDatePass"
                    SQL &=  " ,ChequeDateStop=@ChequeDateStop"
                    SQL &=  " ,BankAccountID=@BankAccountID"
                    SQL &=  " ,Remark=@Remark"
                    'SQL = SQL & " ,IsDelete=@IsDelete"
                    SQL &=  " WHERE ChequeID= @ID"
                Case DataMode.ModeDelete
                    SQL = " UPDATE Cheque SET IsDelete=@IsDelete "
                    SQL &=  " WHERE ChequeID= @ID"
                Case Else
                    Return False
                    Exit Function
            End Select
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@ID", mIDs))
            myCommand.Parameters.Add(New SqlParameter("@RefOrderID", RefOrderID))
            myCommand.Parameters.Add(New SqlParameter("@ChequeNo", ChequeNo))
            myCommand.Parameters.Add(New SqlParameter("@ChequeDate", formatSQLDate(ChequeDate)))
            myCommand.Parameters.Add(New SqlParameter("@BankDocType", ConvertNullToString(BankDocType)))
            myCommand.Parameters.Add(New SqlParameter("@ChequeBalance", ConvertNullToZero(ChequeBalance)))
            myCommand.Parameters.Add(New SqlParameter("@ChequePay", ConvertNullToZero(ChequePay)))
            myCommand.Parameters.Add(New SqlParameter("@CashType", ConvertNullToString(CashType)))
            myCommand.Parameters.Add(New SqlParameter("@ChequeDateReceive", formatSQLDate(ChequeDateReceive)))
            myCommand.Parameters.Add(New SqlParameter("@ChequeDateDue", formatSQLDate(ChequeDateDue)))
            myCommand.Parameters.Add(New SqlParameter("@ChequeOwnerTH", ConvertNullToString(ChequeOwnerTH)))
            myCommand.Parameters.Add(New SqlParameter("@ChequeOwnerEN", ConvertNullToString(ChequeOwnerEN)))
            myCommand.Parameters.Add(New SqlParameter("@BankID", ConvertNullToZero(BankID)))
            myCommand.Parameters.Add(New SqlParameter("@BankBranch", ConvertNullToString(BankBranch)))
            myCommand.Parameters.Add(New SqlParameter("@ChequeType", ConvertNullToZero(ChequeType)))
            myCommand.Parameters.Add(New SqlParameter("@ChequeStep", ConvertNullToString(ChequeStep)))
            myCommand.Parameters.Add(New SqlParameter("@ChequeStatus", ConvertNullToString(ChequeStatus)))
            myCommand.Parameters.Add(New SqlParameter("@ChequeDatePass", formatSQLDate(ChequeDatePass)))
            myCommand.Parameters.Add(New SqlParameter("@ChequeDateStop", formatSQLDate(ChequeDateStop)))
            myCommand.Parameters.Add(New SqlParameter("@BankAccountID", ConvertNullToZero(BankAccountID)))
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
            Err.Raise(Err.Number, e.Source, "ChequeDAO.SaveData : " & e.Message)
            Return False
        End Try
    End Function

    Public Function DeleteAllData(ByVal tr As SqlTransaction) As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand

        SQL = ""
        Try
            SQL = " UPDATE Cheque SET IsDelete=@IsDelete "
            SQL &=  " WHERE RefOrderID=@RefOrderID "
            myCommand = New SqlCommand
            myCommand.CommandText = SQL

            myCommand.Parameters.Add(New SqlParameter("@RefOrderID", RefOrderID))
            myCommand.Parameters.Add(New SqlParameter("@IsDelete", 1))
            gConnection.executeInsertSqlCommand(myCommand, tr)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ChequeDAO.DeleteAllData : " & e.Message)
            Return False
        End Try


    End Function

    Public Sub New()
        mIDs = 0
        mBankDocType = ""
        mChequeNo = ""
        mChequeBalance = 0
        mChequePay = 0
        mMode = DataMode.ModeNone
        mRefOrderID = 0
        mCashType = ""
        mChequeOwnerTH = ""
        mChequeOwnerEN = ""
        mBankID = 0
        mBankBranch = ""
        mChequeType = 1
        mChequeStep = ""
        mChequeStatus = "N"
        mBankAccountID = 0
        mRemark = ""
        mChequeDate = GetCurrentDate(Nothing)
        mChequeDateReceive = GetCurrentDate(Nothing)
        mChequeDateDue = GetCurrentDate(Nothing)
        mChequeDatePass = GetCurrentDate(Nothing)
        mChequeDateStop = GetCurrentDate(Nothing)
    End Sub

End Class
