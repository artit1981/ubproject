﻿
Option Explicit On
Imports System.Data.SqlClient

Public Class ProductListDAO
    Public Function Clone() As ProductListDAO
        Return DirectCast(Me.MemberwiseClone(), ProductListDAO)
    End Function
#Region "Property"
    Private mIsSelect As Boolean
    Private mMode As DataMode
    Private mIDs As Long
    Private mSEQ As Long
    Private mRefID As Long
    Private mRefTable As String
    Private mUnitID As Long
    Private mProductID As Long
    Private mRemark As String
    Private mUnits As Long
    Private mPrice As Decimal
    Private mCost As Decimal
    Private mTotal As Decimal
    Private mUnitDAO As MasterDAO
    Private mLocationDTLID As Long
    Private mProductName As String
    Private mDiscount As Decimal
    Private mIsConfirm As Boolean
    Private mKeepMin As Long
    Private mProductNameExt As String
    Private mUnits_Old As Long
    Private mProductCode As String
    Private mUnitName As String
    Private mLocationDTLID_Old As Long
    Private mProductListRefID As Long
    Private mSNList As List(Of SnDAO)
    Private mIsSN As Integer
    Private mIsShow As Integer = 1
    Private mIsMerge As Integer = 0
    Private mUnitMainID As Long = 0
    Private mAdjustUnit As Long = 0
    Private mRateUnit As Decimal = 1
    Private mIsDelete As Integer = 0
    Private mAdjustUnit_Old As Long = 0
    Private mPriceMain As Decimal = 0
    Private mProductListRefID2 As Long = 0
    Private mProductListRefID3 As Long = 0
    Private mProductListUnitRef2 As Long = 0
    Private mProductListUnitRef3 As Long = 0
    Private mProductListUnitRef1 As Long = 0
    Private mRefOrderCode As String = ""
    Private mClaimRemark As String = ""
    Private mClaimResult As String = ""

    Public Property IsSelect() As Boolean
        Get
            Return mIsSelect
        End Get
        Set(ByVal Value As Boolean)
            mIsSelect = Value
        End Set
    End Property

    Public Property ModePro() As Integer
        Get
            Return mMode
        End Get
        Set(ByVal value As Integer)
            mMode = value
        End Set
    End Property

    Public ReadOnly Property UnitDAO() As MasterDAO
        Get
            If mUnitDAO Is Nothing And mUnitID > 0 Then
                mUnitDAO = New MasterDAO
                mUnitDAO.InitailData(mUnitID, MasterType.UnitBar)
            End If
            Return mUnitDAO
        End Get
    End Property

    Public Property Discount() As Decimal
        Get
            Return mDiscount
        End Get
        Set(ByVal Value As Decimal)
            mDiscount = Value
        End Set

    End Property

    Public Property ProductCode() As String
        Get
            Return mProductCode
        End Get
        Set(ByVal value As String)
            mProductCode = value
        End Set
    End Property

    Public Property ProductName() As String
        Get
            Return mProductName
        End Get
        Set(ByVal value As String)
            mProductName = value
        End Set
    End Property

    Public Property ProductNameExt() As String
        Get
            Return mProductNameExt
        End Get
        Set(ByVal value As String)
            mProductNameExt = value
        End Set
    End Property

    Public Property UnitName() As String
        Get
            Return mUnitName
        End Get
        Set(ByVal value As String)
            mUnitName = value
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

    Public Property LocationDTLID_Old() As Long
        Get
            Return mLocationDTLID_Old
        End Get
        Set(ByVal value As Long)
            mLocationDTLID_Old = value
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

    Public Property Total() As Decimal
        Get
            Return mTotal
        End Get
        Set(ByVal Value As Decimal)
            mTotal = Value
        End Set

    End Property

    Public Property Cost() As Decimal
        Get
            Return mCost
        End Get
        Set(ByVal Value As Decimal)
            mCost = Value
        End Set

    End Property

    Public Property Price() As Decimal
        Get
            Return mPrice
        End Get
        Set(ByVal Value As Decimal)
            mPrice = Value
        End Set

    End Property

    Public Property PriceMain() As Decimal
        Get
            Return mPriceMain
        End Get
        Set(ByVal Value As Decimal)
            mPriceMain = Value
        End Set

    End Property

    Public Property KeepMin() As Long
        Get
            Return mKeepMin
        End Get
        Set(ByVal Value As Long)
            mKeepMin = Value
        End Set
    End Property

    Public Property Units() As Long
        Get
            Return mUnits
        End Get
        Set(ByVal Value As Long)
            mUnits = Value
        End Set
    End Property

    Public Property ProductID() As Long
        Get
            Return mProductID
        End Get
        Set(ByVal Value As Long)
            mProductID = Value
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

    Public Property RefTable() As String
        Get
            Return mRefTable
        End Get
        Set(ByVal Value As String)
            mRefTable = Value
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

    Public Property IsConfirm() As Boolean
        Get
            Return mIsConfirm
        End Get
        Set(ByVal value As Boolean)
            mIsConfirm = value
        End Set

    End Property

    Public Property Units_Old() As Long
        Get
            Return mUnits_Old
        End Get
        Set(ByVal Value As Long)
            mUnits_Old = Value
        End Set
    End Property

    Public Property ProductListRefID() As Long
        Get
            Return mProductListRefID
        End Get
        Set(ByVal Value As Long)
            mProductListRefID = Value
        End Set
    End Property

    Public Property ProductListRefID2() As Long
        Get
            Return mProductListRefID2
        End Get
        Set(ByVal Value As Long)
            mProductListRefID2 = Value
        End Set
    End Property
    Public Property ProductListRefID3() As Long
        Get
            Return mProductListRefID3
        End Get
        Set(ByVal Value As Long)
            mProductListRefID3 = Value
        End Set
    End Property
    Private mProductListRefID4 As Long
    Public Property ProductListRefID4() As Long
        Get
            Return mProductListRefID4
        End Get
        Set(ByVal Value As Long)
            mProductListRefID4 = Value
        End Set
    End Property
    Private mProductListRefID5 As Long
    Public Property ProductListRefID5() As Long
        Get
            Return mProductListRefID5
        End Get
        Set(ByVal Value As Long)
            mProductListRefID5 = Value
        End Set
    End Property
    Public Property ProductListUnitRef1() As Long
        Get
            Return mProductListUnitRef1
        End Get
        Set(ByVal Value As Long)
            mProductListUnitRef1 = Value
        End Set
    End Property
    Public Property ProductListUnitRef2() As Long
        Get
            Return mProductListUnitRef2
        End Get
        Set(ByVal Value As Long)
            mProductListUnitRef2 = Value
        End Set
    End Property

    Public Property ProductListUnitRef3() As Long
        Get
            Return mProductListUnitRef3
        End Get
        Set(ByVal Value As Long)
            mProductListUnitRef3 = Value
        End Set
    End Property

    Private mProductListUnitRef4 As Long
    Public Property ProductListUnitRef4() As Long
        Get
            Return mProductListUnitRef4
        End Get
        Set(ByVal Value As Long)
            mProductListUnitRef4 = Value
        End Set
    End Property

    Private mProductListUnitRef5 As Long
    Public Property ProductListUnitRef5() As Long
        Get
            Return mProductListUnitRef5
        End Get
        Set(ByVal Value As Long)
            mProductListUnitRef5 = Value
        End Set
    End Property
    Public Property SNList() As List(Of SnDAO)
        Get
            Return mSNList
        End Get
        Set(ByVal Value As List(Of SnDAO))
            mSNList = Value
        End Set
    End Property

    Public Property IsSN() As Integer
        Get
            Return mIsSN
        End Get
        Set(ByVal Value As Integer)
            mIsSN = Value
        End Set
    End Property
    Public Property IsShow() As Integer
        Get
            Return mIsShow
        End Get
        Set(ByVal Value As Integer)
            mIsShow = Value
        End Set
    End Property
    Public Property IsMerge() As Integer
        Get
            Return mIsMerge
        End Get
        Set(ByVal Value As Integer)
            mIsMerge = Value
        End Set
    End Property
    Public Property UnitMainID() As Long
        Get
            Return mUnitMainID
        End Get
        Set(ByVal value As Long)
            mUnitMainID = value
        End Set
    End Property
    Public Property AdjustUnit() As Long
        Get
            Return mAdjustUnit
        End Get
        Set(ByVal value As Long)
            mAdjustUnit = value
        End Set
    End Property
    Public Property AdjustUnit_Old() As Long
        Get
            Return mAdjustUnit_Old
        End Get
        Set(ByVal value As Long)
            mAdjustUnit_Old = value
        End Set
    End Property

    Public Property RateUnit() As Decimal
        Get
            Return mRateUnit
        End Get
        Set(ByVal value As Decimal)
            mRateUnit = value
        End Set
    End Property
    Public Property IsDelete() As Integer
        Get
            Return mIsDelete
        End Get
        Set(ByVal Value As Integer)
            mIsDelete = Value
        End Set
    End Property

    Public Property RefOrderCode() As String
        Get
            Return mRefOrderCode
        End Get
        Set(ByVal value As String)
            mRefOrderCode = value
        End Set
    End Property

    Public Property ClaimRemark() As String
        Get
            Return mClaimRemark
        End Get
        Set(ByVal value As String)
            mClaimRemark = value
        End Set
    End Property
    Public Property ClaimResult() As String
        Get
            Return mClaimResult
        End Get
        Set(ByVal Value As String)
            mClaimResult = Value
        End Set
    End Property

    Dim mRealPrice As Decimal = 0
    Public Property RealPrice() As Decimal
        Get
            Return mRealPrice
        End Get
        Set(ByVal Value As Decimal)
            mRealPrice = Value
        End Set

    End Property


#End Region

    Public Function GetDataTable(ByVal pRefID As List(Of Long), ByVal pRefTable As String, ByVal tr As SqlTransaction, ByVal pIsCheckConfirm As Boolean _
                                 , ByVal pExcludeProListID As String, ByVal pIsDelete As Boolean, ByVal pCheckType As String, ByVal pIsShowALL As Boolean) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()
        Dim lRefOrderList As String = ConvertListToString(pRefID)

        'lCheckType = pCheckType
        Try 'ใช้ชื่อสินค้าจาก Table Product
            SQL = "SELECT  ProductList.ProductID,ProductList.ProductListID AS ID,ProductList.SEQ,Product.Remark,ProductList.RefID,ProductList.RefTable"
            SQL &= " ,Product.ProductCode,Product.ProductName,ProductList.ProductNameExt,ProductList.Cost,ProductList.Price,ProductList.PriceMain,ProductList.Units,ProductList.KeepMin "
            SQL &= " ,ProductList.UnitID,Product_Unit.UnitCode ,Product_Unit.CodeThai AS UnitName,ProductList.ToTal,ProductList.LocationDTLID ,ProductList.Discount,ProductList.ProductListRefID"
            SQL &= " ,Product.IsSN ,ProductList.IsShow ,ProductList.IsMerge,ProductList.UnitMainID,ProductList.AdjustUnit,ProductList.RateUnit,ProductList.IsDelete"
            SQL &= " ,Product.UnitMainID AS UnitMainIDSell,Product.UnitMainIDBuy,ProductList.ClaimRemark,ProductList.ClaimResult,ProductList.RealPrice"
            SQL &= " FROM ProductList"
            SQL &= " LEFT OUTER JOIN Product ON Product.ProductID=ProductList.ProductID "
            SQL &= " LEFT OUTER JOIN Product_Unit ON Product_Unit.UnitID=ProductList.UnitID "
            SQL &= " WHERE 1=1   "
            If pIsDelete = False Then
                SQL &= " and ProductList.IsDelete =0   "
            End If

            If pRefTable <> "" Then
                SQL &= " AND ProductList.RefTable ='" & pRefTable & "'"
                If pRefTable = "PurchaseOrder" And pCheckType = MasterType.StockIn.ToString Then  ' And pCheckToStockIn = True Then 'ดูว่า PO ต้องไม่เคยโดนรับสินค้าโดย Stockin 
                    SQL &= " AND ProductList.ProductListID not in( select p2.ProductListRefID from ProductList p2 "
                    SQL &= "   WHERE p2.IsDelete =0  "
                    SQL &= "   AND p2.RefTable ='StockIn' and p2.ProductListRefID > 0)"
                End If
            End If
            If pExcludeProListID <> "" Then
                SQL &= " AND ProductList.ProductListID not in(" & pExcludeProListID & ")"
            End If

            If pIsCheckConfirm = True Then
                SQL &= " AND ProductList.IsConfirm =0 "
                If lRefOrderList <> "" Then
                    SQL &= " AND ProductList.RefID in(" & lRefOrderList & ")"
                End If
            End If
            If pIsShowALL = False Then
                SQL &= " AND ProductList.IsShow=1 "
            End If
            If lRefOrderList <> "" Then
                SQL &= " AND ProductList.RefID in(" & lRefOrderList & ")"
                SQL &= " ORDER BY ProductList.IsShow desc, ProductList.SEQ"
            Else
                SQL &= " ORDER BY Product.ProductCode"
            End If


            dataTable = gConnection.executeSelectQuery(SQL, tr)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProductListDAO.GetDataTable : " & e.Message)
        End Try
        Return dataTable
    End Function

    Public Function CheckSeqDup(ByVal pRefID As Long, ByVal pRefTable As String, ByVal tr As SqlTransaction, ByVal pIsCheckConfirm As Boolean) As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try 'ใช้ชื่อสินค้าจาก Table Product
            SQL = "SELECT count( ProductList.ProductID) as SEQ  "
            SQL &= " FROM ProductList"
            SQL &= " WHERE ProductList.IsDelete =0 and SEQ=1  "

            If pRefTable <> "" Then
                SQL &= " AND ProductList.RefTable ='" & pRefTable & "'"
            End If
            If pIsCheckConfirm = True Then
                SQL &= " AND ProductList.IsConfirm =0 "
                If pRefID > 0 Then
                    SQL &= " AND ProductList.RefID =" & pRefID
                End If
            Else
                SQL &= " AND ProductList.RefID =" & pRefID
            End If
            dataTable = gConnection.executeSelectQuery(SQL, tr)
            For Each pRow As DataRow In dataTable.Rows
                Return ConvertNullToZero(pRow.Item("SEQ")) > 1
            Next

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProductListDAO.CheckSeqDup : " & e.Message)
        End Try

    End Function

    Public Function SaveData(ByVal tr As SqlTransaction, ByVal pLogTime As Date) As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand

        SQL = ""
        Try
            If mMode = DataMode.ModeNew Then
            ElseIf mMode = DataMode.ModeDelete Then
            ElseIf mMode = DataMode.ModeNotApprove Then
                Return True
            ElseIf ID <= 0 And ProductID <> 0 Then
                mMode = DataMode.ModeNew
            ElseIf ID > 0 And ProductID <> 0 Then
                mMode = DataMode.ModeEdit
            Else  'not chang
                mMode = DataMode.ModeNone
            End If

            Select Case mMode
                Case DataMode.ModeNew
                    ID = GenNewID("ProductListID", "ProductList", tr)
                    SQL = " INSERT INTO ProductList  (ProductListID,SEQ,RefID,RefTable,ProductID,UnitID,KeepMin,Units,Cost,Price,PriceMain,Total,Remark,IsDelete"
                    SQL &= " ,ProductName,ProductNameExt,Discount,IsConfirm,LocationDTLID  "
                    SQL &= " ,ProductListRefID,ProductListRefID2,ProductListRefID3,ProductListRefID4,ProductListRefID5"
                    SQL &= " ,IsShow,IsMerge,UnitMainID,AdjustUnit,RateUnit"
                    SQL &= " ,ProductListUnitRef1,ProductListUnitRef2,ProductListUnitRef3,ProductListUnitRef4,ProductListUnitRef5"
                    SQL &= " ,ClaimRemark,ClaimResult,RealPrice)"
                    SQL &= " VALUES ( "
                    SQL &= "   @ID"
                    SQL &= " ,  @SEQ"
                    SQL &= " ,  @RefID"
                    SQL &= " ,  @RefTable"
                    SQL &= " ,  @ProductID"
                    SQL &= " ,  @UnitID"
                    SQL &= " ,  @KeepMin"
                    SQL &= " ,  @Units"
                    SQL &= " ,  @Cost"
                    SQL &= " ,  @Price"
                    SQL &= " ,  @PriceMain"
                    SQL &= " ,  @Total"
                    SQL &= " ,  @Remark"
                    SQL &= " ,  @IsDelete"
                    SQL &= " ,  @ProductName"
                    SQL &= " ,  @ProductNameExt"
                    SQL &= " ,  @Discount"
                    SQL &= " ,  0"
                    SQL &= " ,  @LocationDTLID"
                    SQL &= " ,  @ProductListRefID"
                    SQL &= " ,  @ProductListRefID2"
                    SQL &= " ,  @ProductListRefID3"
                    SQL &= " ,  @ProductListRefID4"
                    SQL &= " ,  @ProductListRefID5"
                    SQL &= " ,  @IsShow"
                    SQL &= " ,  @IsMerge"
                    SQL &= " ,  @UnitMainID"
                    SQL &= " ,  @AdjustUnit"
                    SQL &= " ,  @RateUnit"
                    SQL &= " ,  @ProductListUnitRef1"
                    SQL &= " ,  @ProductListUnitRef2"
                    SQL &= " ,  @ProductListUnitRef3"
                    SQL &= " ,  @ProductListUnitRef4"
                    SQL &= " ,  @ProductListUnitRef5"
                    SQL &= " ,  @ClaimRemark"
                    SQL &= " ,  @ClaimResult"
                    SQL &= " ,  @RealPrice"
                    SQL &= " ) "
                Case DataMode.ModeEdit
                    SQL = " Update ProductList   "
                    SQL &= " SET"
                    SQL &= " UnitID=@UnitID"
                    SQL &= " ,SEQ=@SEQ"
                    SQL &= " ,KeepMin=@KeepMin"
                    SQL &= " ,Units=@Units"
                    SQL &= " ,Cost=@Cost"
                    SQL &= " ,Price=@Price"
                    SQL &= " ,PriceMain=@PriceMain"
                    SQL &= " ,Total=@Total"
                    SQL &= " ,ProductID= @ProductID"
                    SQL &= " ,Remark=@Remark"
                    SQL &= " ,ProductName=@ProductName"
                    SQL &= " ,ProductNameExt=@ProductNameExt"
                    SQL &= " ,Discount=@Discount"
                    SQL &= " ,LocationDTLID=@LocationDTLID"
                    SQL &= " ,AdjustUnit=@AdjustUnit"
                    SQL &= " ,RateUnit=@RateUnit"
                    SQL &= " ,ClaimRemark=@ClaimRemark"
                    SQL &= " ,ClaimResult=@ClaimResult"
                    SQL &= " ,RealPrice=@RealPrice"
                    SQL &= " WHERE ProductListID= @ID"
                Case DataMode.ModeDelete
                    SQL = " UPDATE ProductList SET IsDelete=@IsDelete "
                    SQL &= " WHERE ProductListID= @ID"
                Case Else
                    Return False
                    Exit Function
            End Select
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@ID", mIDs))
            myCommand.Parameters.Add(New SqlParameter("@SEQ", SEQ))
            myCommand.Parameters.Add(New SqlParameter("@RefID", RefID))
            myCommand.Parameters.Add(New SqlParameter("@RefTable", RefTable))
            myCommand.Parameters.Add(New SqlParameter("@UnitID", UnitID))
            myCommand.Parameters.Add(New SqlParameter("@KeepMin", KeepMin))
            myCommand.Parameters.Add(New SqlParameter("@Units", Units))
            myCommand.Parameters.Add(New SqlParameter("@Total", Total))
            myCommand.Parameters.Add(New SqlParameter("@Cost", Cost))
            myCommand.Parameters.Add(New SqlParameter("@Price", Price))
            myCommand.Parameters.Add(New SqlParameter("@PriceMain", PriceMain))
            myCommand.Parameters.Add(New SqlParameter("@ProductID", ProductID))
            myCommand.Parameters.Add(New SqlParameter("@Remark", Remark.Trim))
            myCommand.Parameters.Add(New SqlParameter("@ProductName", ProductName))
            myCommand.Parameters.Add(New SqlParameter("@ProductNameExt", ConvertNullToString(ProductNameExt)))
            myCommand.Parameters.Add(New SqlParameter("@Discount", Discount))
            myCommand.Parameters.Add(New SqlParameter("@UnitMainID", UnitMainID))
            myCommand.Parameters.Add(New SqlParameter("@LocationDTLID", LocationDTLID))
            myCommand.Parameters.Add(New SqlParameter("@ProductListRefID", ProductListRefID))
            myCommand.Parameters.Add(New SqlParameter("@ProductListRefID2", ProductListRefID2))
            myCommand.Parameters.Add(New SqlParameter("@ProductListRefID3", ProductListRefID3))
            myCommand.Parameters.Add(New SqlParameter("@ProductListRefID4", ProductListRefID4))
            myCommand.Parameters.Add(New SqlParameter("@ProductListRefID5", ProductListRefID5))
            myCommand.Parameters.Add(New SqlParameter("@ProductListUnitRef1", ProductListUnitRef1))
            myCommand.Parameters.Add(New SqlParameter("@ProductListUnitRef2", ProductListUnitRef2))
            myCommand.Parameters.Add(New SqlParameter("@ProductListUnitRef3", ProductListUnitRef3))
            myCommand.Parameters.Add(New SqlParameter("@ProductListUnitRef4", ProductListUnitRef4))
            myCommand.Parameters.Add(New SqlParameter("@ProductListUnitRef5", ProductListUnitRef5))
            myCommand.Parameters.Add(New SqlParameter("@IsShow", IsShow))
            myCommand.Parameters.Add(New SqlParameter("@IsMerge", IsMerge))
            myCommand.Parameters.Add(New SqlParameter("@AdjustUnit", AdjustUnit))
            myCommand.Parameters.Add(New SqlParameter("@RateUnit", RateUnit))
            myCommand.Parameters.Add(New SqlParameter("@ClaimRemark", ConvertNullToString(ClaimRemark)))
            myCommand.Parameters.Add(New SqlParameter("@ClaimResult", ConvertNullToString(ClaimResult)))
            myCommand.Parameters.Add(New SqlParameter("@RealPrice", ConvertNullToZero(RealPrice)))
            Select Case ModeData
                Case DataMode.ModeNew
                    myCommand.Parameters.Add(New SqlParameter("@IsDelete", 0))
                Case DataMode.ModeDelete
                    myCommand.Parameters.Add(New SqlParameter("@IsDelete", 1))
            End Select
            gConnection.executeInsertSqlCommand(myCommand, tr)

            'Keep data detail log
            'InsertLog(tr, pLogTime)

            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProductListDAO.SaveData : " & e.Message)
            Return False
        End Try
    End Function

    'Private Sub InsertLog(ByRef ptr As SqlTransaction, ByVal pLogTime As Date)
    '    Dim Sql As String = ""
    '    Try
    '        Sql = " INSERT INTO ProductListLog  (LogTime,ProductListID,SEQ,RefID,RefTable,ProductID,ProductName,ProductNameExt,LocationDTLID,UnitID"
    '        Sql &= " ,KeepMin,Units,Cost,Price,Discount,Total,Remark,IsDelete,IsConfirm,ProductListRefID "
    '        Sql &= " ,IsShow,IsMerge,AdjustUnit,RateUnit,UnitMainID,PriceMain,ProductListRefID2,ProductListRefID3 "
    '        Sql &= " ,ProductListUnitRef2,ProductListUnitRef3,ProductListUnitRef1 ,ClaimRemark,ClaimResult )"
    '        Sql &= " SELECT '" & formatSQLDateTime(pLogTime) & "'"
    '        Sql &= " ,ProductListID,SEQ,RefID,RefTable,ProductID,ProductName,ProductNameExt,LocationDTLID,UnitID"
    '        Sql &= " ,KeepMin,Units,Cost,Price,Discount,Total,Remark,IsDelete,IsConfirm,ProductListRefID"
    '        Sql &= " ,IsShow,IsMerge,AdjustUnit,RateUnit,UnitMainID,PriceMain,ProductListRefID2,ProductListRefID3 "
    '        Sql &= " ,ProductListUnitRef2,ProductListUnitRef3,ProductListUnitRef1,ClaimRemark,ClaimResult"
    '        Sql &= " FROM ProductList"
    '        Sql &= " WHERE ProductListID=" & ID
    '        gConnection.executeInsertQuery(Sql, ptr)
    '    Catch e As Exception
    '        Err.Raise(Err.Number, e.Source, "ProductListDAO.InsertLog : " & e.Message)
    '    End Try
    'End Sub


    Public Function SaveToConfirm(ByVal pRefID As Long, ByVal pProductListID As Long, ByVal pIsConfirm As Boolean, ByVal tr As SqlTransaction) As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand

        SQL = ""
        Try
            If pRefID > 0 Or pProductListID > 0 Then
                SQL = " Update ProductList   "
                SQL &= " SET IsConfirm=" & IIf(pIsConfirm = True, 1, 0)
                SQL &= " WHERE 1=1 "
                If pRefID > 0 Then
                    SQL &= " and RefID=" & pRefID
                End If
                If pProductListID > 0 Then
                    SQL &= " and ProductListID=" & pProductListID
                End If
                myCommand = New SqlCommand
                myCommand.CommandText = SQL

                gConnection.executeInsertSqlCommand(myCommand, tr)
            End If

            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProductListDAO.SaveData : " & e.Message)
            Return False
        End Try
    End Function

    'delete some record are remove from grid
    Public Function DeleteRemoveData(ByVal tr As SqlTransaction, ByVal pstrStayID As String) As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand

        SQL = ""
        Try
            SQL = " UPDATE ProductList SET IsDelete=@IsDelete "
            SQL &= " WHERE ProductListID NOT IN( " & pstrStayID & ")"
            SQL &= " AND RefID=@RefID "
            SQL &= " AND RefTable=@RefTable "
            SQL &= " AND IsDelete =0  "
            myCommand = New SqlCommand
            myCommand.CommandText = SQL

            myCommand.Parameters.Add(New SqlParameter("@RefID", RefID))
            myCommand.Parameters.Add(New SqlParameter("@RefTable", RefTable))
            myCommand.Parameters.Add(New SqlParameter("@IsDelete", 1))
            gConnection.executeInsertSqlCommand(myCommand, tr)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProductListDAO.DeleteRemoveData : " & e.Message)
            Return False
        End Try


    End Function

    Public Function DeleteAllData(ByVal tr As SqlTransaction) As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand

        SQL = ""
        Try
            SQL = " UPDATE ProductList SET IsDelete=@IsDelete "
            SQL &= " WHERE RefID=@RefID "
            SQL &= " AND RefTable=@RefTable "
            myCommand = New SqlCommand
            myCommand.CommandText = SQL

            myCommand.Parameters.Add(New SqlParameter("@RefID", RefID))
            myCommand.Parameters.Add(New SqlParameter("@RefTable", RefTable))
            myCommand.Parameters.Add(New SqlParameter("@IsDelete", 1))
            gConnection.executeInsertSqlCommand(myCommand, tr)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProductListDAO.DeleteAllData : " & e.Message)
            Return False
        End Try


    End Function

    Public Sub New()
        mMode = DataMode.ModeNone
        mIDs = 0
        mRefID = 0
        mSEQ = 0
        mProductID = 0
        mUnitID = 0
        mUnits = 0
        mCost = 0
        mPrice = 0
        mTotal = 0
        mRefTable = 0
        mRemark = ""
        mUnitDAO = Nothing
        mProductName = ""
        mProductNameExt = ""
        mDiscount = 0
        mIsConfirm = False
        mKeepMin = 0
        mUnits_Old = 0
        mProductCode = ""
        mUnitName = ""
        mLocationDTLID_Old = 0
        mProductListRefID = 0
        mClaimRemark = ""
        mClaimResult = ""
    End Sub
End Class
