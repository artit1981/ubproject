Option Explicit On

Imports System.Data.SqlClient
 
Public Class ProductUnitDAO

    Private mMode As DataMode
    Private mIDs As Long
    Private mSEQ As Long
    Private mRefID As Long
    Private mBuyOrSell As Long
    Private mUnitID As Long
    Private mRate As Decimal
    Private mRemark As String
    Private mIsInActive As Boolean

    Private mUnitDAO As MasterDAO

    Public ReadOnly Property UnitDAO() As MasterDAO
        Get
            If mUnitDAO Is Nothing And mUnitID > 0 Then
                mUnitDAO = New MasterDAO
                mUnitDAO.InitailData(mUnitID, MasterType.UnitBar)
            End If
            Return mUnitDAO
        End Get
    End Property
    Public Property Remark() As String
        Get
            Return mRemark
        End Get
        Set(ByVal value As String)
            mRemark = value
        End Set
    End Property

    Public Property IsInActive() As Boolean
        Get
            Return mIsInActive
        End Get
        Set(ByVal Value As Boolean)
            mIsInActive = Value
        End Set

    End Property
    Public Property Rate() As Decimal
        Get
            Return mRate
        End Get
        Set(ByVal Value As Decimal)
            mRate = Value
        End Set
    End Property

    Public Property UnitID() As Long
        Get
            Return mUnitID
        End Get
        Set(ByVal Value As Long)
            mUnitID = Value
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

    Public Property SEQ() As Long
        Get
            Return mSEQ
        End Get
        Set(ByVal value As Long)
            mSEQ = value
        End Set
    End Property

    Public Property RefID() As Long
        Get
            Return mRefID
        End Get
        Set(ByVal value As Long)
            mRefID = value
        End Set

    End Property

    Public Property BuyOrSell() As Long
        Get
            Return mBuyOrSell
        End Get
        Set(ByVal Value As Long)
            mBuyOrSell = Value
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

    Public Function GetDataTable(ByVal pRefID As Long, ByVal plngBuyOrSell As Integer, Optional ByVal pUnitID As Long = 0, Optional ByVal pUnitName As String = "") As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT Product_Unit.UnitCode ,Product_Unit.CodeThai AS UnitName ,Product_UOM.Rate"
            SQL = SQL & " , Product_UOM.UOMID AS ID,Product_UOM.SEQ,Product_UOM.UnitID, Product_UOM.Remark,Product_UOM.RefID,Product_UOM.IsInActive"
            SQL = SQL & " FROM Product_UOM"
            SQL = SQL & " LEFT OUTER JOIN Product_Unit ON Product_Unit.UnitID=Product_UOM.UnitID "
            SQL = SQL & " WHERE Product_UOM.RefID =" & pRefID
            SQL = SQL & " AND Product_UOM.IsDelete =0   "
            SQL = SQL & " AND BuyOrSell =" & plngBuyOrSell
            If pUnitID > 0 Then
                SQL = SQL & " AND Product_UOM.UnitID =" & pUnitID
            End If
            If pUnitName <> "" Then
                SQL = SQL & " AND Product_Unit.CodeThai ='" & pUnitName & "'"
            End If

            SQL = SQL & " ORDER BY Product_UOM.SEQ"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProductUnitDAO.GetDataTable : " & e.Message)
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
            ElseIf ID <= 0 And UnitID <> 0 Then
                mMode = DataMode.ModeNew
            ElseIf ID > 0 And UnitID <> 0 Then
                mMode = DataMode.ModeEdit


            Else  'not chang
                mMode = DataMode.ModeNone
            End If

            Select Case mMode
                Case DataMode.ModeNew
                    mIDs = GenNewID("UOMID", "Product_UOM", tr)
                    SQL = " INSERT INTO Product_UOM  (UOMID,SEQ,RefID,BuyOrSell,UnitID,Rate,Remark,IsDelete,IsInActive )"
                    SQL = SQL & " VALUES ( "
                    SQL = SQL & "   @ID"
                    SQL = SQL & " ,  @SEQ"
                    SQL = SQL & " ,  @RefID"
                    SQL = SQL & " ,  @BuyOrSell"
                    SQL = SQL & " ,  @UnitID"
                    SQL = SQL & " ,  @Rate"
                    SQL = SQL & " ,  @Remark"
                    SQL = SQL & " ,  @IsDelete"
                    SQL = SQL & " ,  @IsInActive"
                    SQL = SQL & " ) "
                Case DataMode.ModeEdit
                    SQL = " Update Product_UOM   "
                    SQL = SQL & " SET"
                    SQL = SQL & " UnitID=@UnitID"
                    SQL = SQL & " ,Rate= @Rate"
                    SQL = SQL & " ,Remark=@Remark"
                    SQL = SQL & " ,IsInActive=@IsInActive"
                    SQL = SQL & " WHERE UOMID= @ID"
                Case DataMode.ModeDelete
                    SQL = " UPDATE Product_UOM SET IsDelete=@IsDelete "
                    SQL = SQL & " WHERE UOMID= @ID"
                Case Else
                    Return False
                    Exit Function
            End Select
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@ID", mIDs))
            myCommand.Parameters.Add(New SqlParameter("@SEQ", SEQ))
            myCommand.Parameters.Add(New SqlParameter("@RefID", RefID))
            myCommand.Parameters.Add(New SqlParameter("@BuyOrSell", BuyOrSell))
            myCommand.Parameters.Add(New SqlParameter("@UnitID", UnitID))
            myCommand.Parameters.Add(New SqlParameter("@Rate", Rate))
            myCommand.Parameters.Add(New SqlParameter("@Remark", Remark.Trim))
            myCommand.Parameters.Add(New SqlParameter("@IsInActive", IsInActive))

            Select Case ModeData
                Case DataMode.ModeNew
                    myCommand.Parameters.Add(New SqlParameter("@IsDelete", 0))
                Case DataMode.ModeDelete
                    myCommand.Parameters.Add(New SqlParameter("@IsDelete", 1))
            End Select
            gConnection.executeInsertSqlCommand(myCommand, tr)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProductUnitDAO.SaveData : " & e.Message)
            Return False
        End Try
    End Function

    'delete some record are remove from grid
    Public Function DeleteRemoveData(ByVal tr As SqlTransaction, ByVal pstrStayID As String) As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand
        SQL = ""
        Try
            SQL = " UPDATE Product_UOM SET IsDelete=@IsDelete "
            SQL = SQL & " WHERE UOMID NOT IN( " & pstrStayID & ")"
            SQL = SQL & " AND RefID=@RefID "
            SQL = SQL & " AND BuyOrSell=@BuyOrSell "
            SQL = SQL & " AND IsDelete =0  "
            myCommand = New SqlCommand
            myCommand.CommandText = SQL

            myCommand.Parameters.Add(New SqlParameter("@RefID", RefID))
            myCommand.Parameters.Add(New SqlParameter("@BuyOrSell", BuyOrSell))
            myCommand.Parameters.Add(New SqlParameter("@IsDelete", 1))
            gConnection.executeInsertSqlCommand(myCommand, tr)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProductUnitDAO.DeleteRemoveData : " & e.Message)
            Return False
        End Try
    End Function

    'delete all ref
    Public Function DeleteAllData(ByVal tr As SqlTransaction) As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand
        SQL = ""
        Try
            SQL = " UPDATE Product_UOM SET IsDelete=@IsDelete "
            SQL = SQL & " WHERE RefID=@RefID "
            SQL = SQL & " AND BuyOrSell=@BuyOrSell "
            myCommand = New SqlCommand
            myCommand.CommandText = SQL

            myCommand.Parameters.Add(New SqlParameter("@RefID", RefID))
            myCommand.Parameters.Add(New SqlParameter("@BuyOrSell", BuyOrSell))
            myCommand.Parameters.Add(New SqlParameter("@IsDelete", 1))
            gConnection.executeInsertSqlCommand(myCommand, tr)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProductUnitDAO.DeleteAllData : " & e.Message)
            Return False
        End Try
    End Function

    Public Sub New()
        mMode = DataMode.ModeNone
        mIDs = 0
        mRefID = 0
        mSEQ = 0
        mRate = 0
        mUnitID = 0
        mBuyOrSell = 0
        mRemark = ""
        mUnitDAO = Nothing
    End Sub
End Class
