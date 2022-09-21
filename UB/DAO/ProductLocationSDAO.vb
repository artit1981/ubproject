Option Explicit On

Imports System.Data.SqlClient
Public Class ProductLocationSDAO



#Region "Property"
    Dim mIsMain As String
    Dim mIsInActive As Boolean
    Dim mMode As DataMode
    Dim mSEQ As Long
    Dim mRefID As Long
    Dim mIDs As Long
    Dim mLocationID As Long
    Dim mLocationDTLID As Long
    Dim mKeepMin As Long
    Dim mKeepMax As Long

    Public Property IsMain() As String
        Get
            Return mIsMain
        End Get
        Set(ByVal Value As String)
            mIsMain = Value
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

    Public Property ID() As Long
        Get
            Return mIDs
        End Get
        Set(ByVal value As Long)
            mIDs = value
        End Set
    End Property

    Public Property LocationID() As Long
        Get
            Return mLocationID
        End Get
        Set(ByVal value As Long)
            mLocationID = value
        End Set
    End Property


    Public Property LocationDTLID() As Long
        Get
            Return mLocationDTLID
        End Get
        Set(ByVal value As Long)
            mLocationDTLID = value
        End Set
    End Property

    Public Property KeepMin() As Long
        Get
            Return mKeepMin
        End Get
        Set(ByVal value As Long)
            mKeepMin = value
        End Set
    End Property


    Public Property KeepMax() As Long
        Get
            Return mKeepMax
        End Get
        Set(ByVal value As Long)
            mKeepMax = value
        End Set
    End Property
#End Region

    Public Function GetDataTable(ByVal pRefID As Long) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT  ID,SEQ,LocationID ,LocationDTLID, KeepMin,KeepMax,IsInActive,IsMain"
            SQL = SQL & " FROM Product_LocationS"
            SQL = SQL & " WHERE RefID =" & pRefID
            SQL = SQL & " AND IsDelete =0   "
            SQL = SQL & " ORDER BY SEQ"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProductLocationSDAO.GetDataTable : " & e.Message)
        End Try
        Return dataTable
    End Function

    Public Function GetDataTableDTL(ByVal pProductID As Long, ByVal pRefTable As String) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            If pRefTable = MasterType.SellOrders.ToString Then
                SQL = "SELECT 0 as ProductID,D.NameThai AS LocationDTL,D.LocationDTLID  "
                SQL = SQL & " FROM Product_LocationDTL D  "
                SQL = SQL & " where  D.LocationDTLID=(select LocationDTLID from RunningFormat where MenuID=" & MasterType.SellOrders & ")"
                SQL = SQL & " group BY D.NameThai,D.LocationDTLID"
                SQL = SQL & " ORDER BY D.NameThai"
            ElseIf pRefTable = MasterType.Invoice.ToString Or pRefTable = MasterType.Borrow.ToString _
                Or pRefTable = MasterType.ReduceCredit.ToString Or pRefTable = MasterType.ReduceCreditBuy.ToString _
                Or pRefTable = MasterType.AddCredit.ToString Or pRefTable = MasterType.AddCreditBuy.ToString Or pRefTable = MasterType.StockIn.ToString Then
                SQL = "SELECT P.RefID AS ProductID,D.NameThai AS LocationDTL,D.LocationDTLID  "
                SQL = SQL & " FROM Product_LocationS P"
                SQL = SQL & " LEFT OUTER JOIN Product_LocationDTL D ON D.LocationDTLID=P.LocationDTLID "
                SQL = SQL & " WHERE P.IsMain ='Y' AND P.IsInActive = 0 AND P.IsDelete = 0"
                If pProductID > 0 Then
                    SQL = SQL & " and P.RefID =" & pProductID
                End If
            ElseIf pRefTable = MasterType.Shiping.ToString Then
                SQL = "SELECT P.RefID AS ProductID,D.NameThai AS LocationDTL,D.LocationDTLID  "
                SQL = SQL & " FROM Product_LocationS P"
                SQL = SQL & " LEFT OUTER JOIN Product_LocationDTL D ON D.LocationDTLID=P.LocationDTLID "
                SQL = SQL & " WHERE P.IsMain <>'Y' AND P.IsInActive = 0 AND P.IsDelete = 0"
                If pProductID > 0 Then
                    SQL = SQL & " and P.RefID =" & pProductID
                End If
                'SQL = SQL & " group BY P.RefID ,D.NameThai,D.LocationDTLID"
                SQL = SQL & " ORDER BY IsMain "
            ElseIf pProductID > 0 Then
                SQL = "SELECT P.RefID AS ProductID,D.NameThai AS LocationDTL,D.LocationDTLID  "
                SQL = SQL & " FROM Product_LocationS P"
                SQL = SQL & " LEFT OUTER JOIN Product_LocationDTL D ON D.LocationDTLID=P.LocationDTLID "
                SQL = SQL & " WHERE P.IsInActive = 0 AND P.IsDelete = 0"
                SQL = SQL & " and P.RefID =" & pProductID
                SQL = SQL & " group BY P.RefID ,D.NameThai,D.LocationDTLID"
                SQL = SQL & " ORDER BY P.RefID,D.NameThai"
            Else
                SQL = "SELECT P.RefID AS ProductID,D.NameThai AS LocationDTL,D.LocationDTLID  "
                SQL = SQL & " FROM Product_LocationS P"
                SQL = SQL & " LEFT OUTER JOIN Product_LocationDTL D ON D.LocationDTLID=P.LocationDTLID "
                SQL = SQL & " WHERE    P.IsInActive = 0 AND P.IsDelete = 0"
                'SQL = SQL & " group BY P.RefID ,D.NameThai,D.LocationDTLID"
                SQL = SQL & " ORDER BY IsMain"
            End If

            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProductLocationSDAO.GetDataTableDTL : " & e.Message)
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
            ElseIf ID <= 0 And LocationDTLID <> 0 Then
                mMode = DataMode.ModeNew
            ElseIf ID > 0 And LocationDTLID <> 0 Then
                mMode = DataMode.ModeEdit
            Else  'not chang
                mMode = DataMode.ModeNone
            End If

            Select Case mMode
                Case DataMode.ModeNew
                    mIDs = GenNewID("ID", "Product_LocationS", tr)
                    SQL = " INSERT INTO Product_LocationS  (ID,SEQ,RefID,LocationID,LocationDTLID,KeepMin,KeepMax,IsDelete,IsInActive,IsMain )"
                    SQL = SQL & " VALUES ( "
                    SQL = SQL & "   @ID"
                    SQL = SQL & " ,  @SEQ"
                    SQL = SQL & " ,  @RefID"
                    SQL = SQL & " ,  @LocationID"
                    SQL = SQL & " ,  @LocationDTLID"
                    SQL = SQL & " ,  @KeepMin"
                    SQL = SQL & " ,  @KeepMax"
                    SQL = SQL & " ,  @IsDelete"
                    SQL = SQL & " ,  @IsInActive"
                    SQL = SQL & " ,  @IsMain"
                    SQL = SQL & " ) "
                Case DataMode.ModeEdit
                    SQL = " Update Product_LocationS   "
                    SQL = SQL & " SET"
                    SQL = SQL & " LocationID=@LocationID"
                    SQL = SQL & " ,LocationDTLID= @LocationDTLID"
                    SQL = SQL & " ,KeepMin=@KeepMin"
                    SQL = SQL & " ,KeepMax=@KeepMax"
                    SQL = SQL & " ,IsInActive=@IsInActive"
                    SQL = SQL & " ,IsMain=@IsMain"
                    SQL = SQL & " WHERE ID= @ID"
                Case DataMode.ModeDelete
                    SQL = " UPDATE Product_LocationS SET IsDelete=@IsDelete "
                    SQL = SQL & " WHERE ID= @ID"
                Case Else
                    Return False
                    Exit Function
            End Select
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@ID", mIDs))
            myCommand.Parameters.Add(New SqlParameter("@SEQ", SEQ))
            myCommand.Parameters.Add(New SqlParameter("@RefID", RefID))
            myCommand.Parameters.Add(New SqlParameter("@LocationID", LocationID))
            myCommand.Parameters.Add(New SqlParameter("@LocationDTLID", LocationDTLID))
            myCommand.Parameters.Add(New SqlParameter("@KeepMin", KeepMin))
            myCommand.Parameters.Add(New SqlParameter("@KeepMax", KeepMax))
            myCommand.Parameters.Add(New SqlParameter("@IsInActive", IsInActive))
            myCommand.Parameters.Add(New SqlParameter("@IsMain", ConvertNullToString(IsMain)))

            Select Case ModeData
                Case DataMode.ModeNew
                    myCommand.Parameters.Add(New SqlParameter("@IsDelete", 0))
                Case DataMode.ModeDelete
                    myCommand.Parameters.Add(New SqlParameter("@IsDelete", 1))
            End Select
            gConnection.executeInsertSqlCommand(myCommand, tr)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProductLocationSDAO.SaveData : " & e.Message)
            Return False
        End Try
    End Function

    'delete some record are remove from grid
    Public Function DeleteRemoveData(ByVal tr As SqlTransaction, ByVal pstrStayID As String) As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand

        SQL = ""
        Try
            SQL = " UPDATE Product_LocationS SET IsDelete=@IsDelete "
            SQL = SQL & " WHERE ID NOT IN( " & pstrStayID & ")"
            SQL = SQL & " AND IsDelete =0  "
            SQL = SQL & " AND RefID=@RefID "
            myCommand = New SqlCommand
            myCommand.CommandText = SQL

            myCommand.Parameters.Add(New SqlParameter("@RefID", RefID))
            myCommand.Parameters.Add(New SqlParameter("@IsDelete", 1))
            gConnection.executeInsertSqlCommand(myCommand, tr)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProductLocationSDAO.DeleteRemoveData : " & e.Message)
            Return False
        End Try
    End Function

    'delete all ref 
    Public Function DeleteAllData(ByVal tr As SqlTransaction) As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand
        SQL = ""
        Try
            SQL = " UPDATE Product_LocationS SET IsDelete=@IsDelete "
            SQL = SQL & " WHERE RefID=@RefID "
            myCommand = New SqlCommand
            myCommand.CommandText = SQL

            myCommand.Parameters.Add(New SqlParameter("@RefID", RefID))
            myCommand.Parameters.Add(New SqlParameter("@IsDelete", 1))
            gConnection.executeInsertSqlCommand(myCommand, tr)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProductLocationSDAO.DeleteAllData : " & e.Message)
            Return False
        End Try

    End Function

    Public Sub New()
        mMode = DataMode.ModeNone
        mIDs = 0
        mRefID = 0
        mSEQ = 0
        mLocationID = 0
        mLocationDTLID = 0
        mKeepMin = 0
        mKeepMax = 0
        mIsMain = ""
    End Sub

End Class
