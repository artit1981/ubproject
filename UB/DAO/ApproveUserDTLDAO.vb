Option Explicit On
Imports System.Data.SqlClient

Public Class ApproveUserDTLDAO
    Private mMode As DataMode
    Private mIDs As Long
    Private mSEQ As Long
    Private mApproveType As Long
    Private mEmpID As Long
    Private mIsCancel As Boolean
    Private mApproveAmount As Decimal
    Private mRemark As String


#Region "Property"
    Dim mEmpName As String
    Dim mPositionName As String
    Dim mEmail1 As String
    Dim mPhone1 As String

    Public Property ModeData() As Integer
        Get
            Return mMode
        End Get
        Set(ByVal Value As Integer)
            mMode = Value
        End Set
    End Property
    Public Property ApproveUserDtlID() As Long
        Get
            Return mIDs
        End Get
        Set(ByVal value As Long)
            mIDs = value
        End Set

    End Property
    Public Property SEQ() As Long
        Get
            Return mSEQ
        End Get
        Set(ByVal value As Long)
            mSEQ = value
        End Set
    End Property
    Public Property ApproveType() As Long
        Get
            Return mApproveType
        End Get
        Set(ByVal value As Long)
            mApproveType = value
        End Set
    End Property
    Public Property EmpID() As Long
        Get
            Return mEmpID
        End Get
        Set(ByVal value As Long)
            mEmpID = value
        End Set
    End Property
    Public Property IsCancel() As Boolean
        Get
            Return mIsCancel
        End Get
        Set(ByVal value As Boolean)
            mIsCancel = value
        End Set
    End Property
    Public Property ApproveAmount() As Decimal
        Get
            Return mApproveAmount
        End Get
        Set(ByVal Value As Decimal)
            mApproveAmount = Value
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
    Public Property EmpName() As String
        Get
            Return mEmpName
        End Get
        Set(ByVal value As String)
            mEmpName = value
        End Set
    End Property
    Public Property PositionName() As String
        Get
            Return mPositionName
        End Get
        Set(ByVal value As String)
            mPositionName = value
        End Set
    End Property
    Public Property Email1() As String
        Get
            Return mEmail1
        End Get
        Set(ByVal value As String)
            mEmail1 = value
        End Set
    End Property
    Public Property Phone1() As String
        Get
            Return mPhone1
        End Get
        Set(ByVal value As String)
            mPhone1 = value
        End Set
    End Property
#End Region

    Public Function GetDataTable(ByVal pTypeID As Long, ByVal pEmpID As Long, ByVal pIsActiveOnly As Boolean) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT  ApproveUserDtl.SEQ,ApproveUserDtl.ApproveUserDtlID,ApproveUserDtl.EmpID,ApproveUserDtl.ApproveAmount,ApproveUserDtl.IsCancel,ApproveUserDtl.Remark "
            SQL &=  " ,Employee.Title + Employee.Firstname + ' ' + Employee.LastName AS EmpName "
            SQL &=  " ,Position.NameThai AS PositionName,Address.Phone1,Address.Email1,ApproveType  "
            SQL &=  " FROM ApproveUserDtl"
            SQL &=  " LEFT OUTER JOIN Employee ON Employee.EmpID=ApproveUserDtl.EmpID "
            SQL &=  " LEFT OUTER JOIN Address ON Employee.AddressID=Address.AddressID "
            SQL &=  " LEFT OUTER JOIN Position ON Employee.PositionID=Position.PositionID "
            SQL &=  " WHERE ApproveUserDtl.IsDelete =0   "
            If pTypeID > 0 Then
                SQL &=  " AND ApproveUserDtl.ApproveType =" & pTypeID
            End If
            If pEmpID > 0 Then
                SQL &=  " AND ApproveUserDtl.EmpID =" & pEmpID
            End If
            If pIsActiveOnly > True Then
                SQL &=  " AND ApproveUserDtl.IsCancel =0"
            End If
            SQL &=  " ORDER BY ApproveUserDtl.SEQ"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ApproveUserDTLDAO.GetDataTable : " & e.Message)
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
            ElseIf ApproveUserDtlID <= 0 And EmpID <> 0 Then
                mMode = DataMode.ModeNew
            ElseIf ApproveUserDtlID > 0 And EmpID <> 0 Then
                mMode = DataMode.ModeEdit
            Else  'not chang
                mMode = DataMode.ModeNone
            End If

            Select Case mMode
                Case DataMode.ModeNew
                    mIDs = GenNewID("ApproveUserDtlID", "ApproveUserDtl", tr)
                    SQL = " INSERT INTO ApproveUserDtl  (ApproveUserDtlID,ApproveType,SEQ,EmpID,ApproveAmount,IsCancel,Remark,IsDelete )"
                    SQL &=  " VALUES ( "
                    SQL &=  "   @ID"
                    SQL &=  " ,  @ApproveType"
                    SQL &=  " ,  @SEQ"
                    SQL &=  " ,  @EmpID"
                    SQL &=  " ,  @ApproveAmount"
                    SQL &=  " ,  @IsCancel"
                    SQL &=  " ,  @Remark"
                    SQL &=  " ,  @IsDelete"
                    SQL &=  " ) "
                Case DataMode.ModeEdit
                    SQL = " Update ApproveUserDtl   "
                    SQL &=  " SET"
                    SQL &=  " EmpID=@EmpID"
                    SQL &=  " ,ApproveAmount=@ApproveAmount"
                    SQL &=  " ,IsCancel=@IsCancel"
                    SQL &=  " ,Remark=@Remark"
                    SQL &=  " WHERE ApproveUserDtlID= @ID"
                Case DataMode.ModeDelete
                    SQL = " UPDATE ApproveUserDtl SET IsDelete=@IsDelete "
                    SQL &=  " WHERE ApproveUserDtlID= @ID"
                Case Else
                    Return False
                    Exit Function
            End Select
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@ID", mIDs))
            myCommand.Parameters.Add(New SqlParameter("@SEQ", SEQ))
            myCommand.Parameters.Add(New SqlParameter("@ApproveType", ApproveType))
            myCommand.Parameters.Add(New SqlParameter("@EmpID", EmpID))
            myCommand.Parameters.Add(New SqlParameter("@ApproveAmount", ApproveAmount))
            myCommand.Parameters.Add(New SqlParameter("@IsCancel", IsCancel))
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
            Err.Raise(Err.Number, e.Source, "ApproveUserDTLDAO.SaveData : " & e.Message)
            Return False
        End Try
    End Function

    'delete some record are remove from grid
    Public Function DeleteRemoveData(ByVal tr As SqlTransaction, ByVal pstrStayID As String) As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand

        SQL = ""
        Try
            SQL = " UPDATE ApproveUserDtl SET IsDelete=@IsDelete "
            SQL &=  " WHERE ApproveUserDtlID NOT IN( " & pstrStayID & ")"
            SQL &=  " AND ApproveType=@ApproveType "
            SQL &=  " AND IsDelete =0  "
            myCommand = New SqlCommand
            myCommand.CommandText = SQL

            myCommand.Parameters.Add(New SqlParameter("@ApproveType", ApproveType))
            myCommand.Parameters.Add(New SqlParameter("@IsDelete", 1))
            gConnection.executeInsertSqlCommand(myCommand, tr)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ApproveUserDTLDAO.DeleteRemoveData : " & e.Message)
            Return False
        End Try


    End Function

    Public Function DeleteAllData(ByVal tr As SqlTransaction) As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand

        SQL = ""
        Try
            SQL = " UPDATE ApproveUserDtl SET IsDelete=@IsDelete "
            SQL &=  " WHERE ApproveType=@ApproveType "
            myCommand = New SqlCommand
            myCommand.CommandText = SQL

            myCommand.Parameters.Add(New SqlParameter("@ApproveType", ApproveType))
            myCommand.Parameters.Add(New SqlParameter("@IsDelete", 1))
            gConnection.executeInsertSqlCommand(myCommand, tr)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ApproveUserDTLDAO.DeleteAllData : " & e.Message)
            Return False
        End Try


    End Function

    Public Sub New()
        mMode = DataMode.ModeNone
        mIDs = 0
        mIDs = 0
        mSEQ = 0
        mApproveType = 0
        mEmpID = 0
        mIsCancel = 0
        mApproveAmount = 0
        mRemark = ""
    End Sub

End Class
