
Option Explicit On
Imports System.Data.SqlClient
Public Class ProductStockDAO

    Private mProductID As Long
    Private mLot As Long
    Private mCostType As ProductCostDAO.CostTypes
    Private mUnitID As Long
    Private mLocationDTLID As Long
    Private mUnits As Long
    Private mUnitsStock As Long
    Private mCost As Decimal
    Private mSumStockLocationDTLID As Long

    Public Function Clone() As ProductStockDAO
        Return DirectCast(Me.MemberwiseClone(), ProductStockDAO)
    End Function

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
    Public Property LocationDTLID() As Long
        Get
            Return mLocationDTLID
        End Get
        Set(ByVal value As Long)
            mLocationDTLID = value
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
    Public Property UnitsStock() As Long
        Get
            Return mUnitsStock
        End Get
        Set(ByVal Value As Long)
            mUnitsStock = Value
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
    Public Property CostType() As Long
        Get
            Return mCostType
        End Get
        Set(ByVal Value As Long)
            mCostType = Value
        End Set
    End Property

    Public Property Lot() As Long
        Get
            Return mLot
        End Get
        Set(ByVal Value As Long)
            mLot = Value
        End Set
    End Property

    Public Property SumStockLocationDTLID() As Long
        Get
            Return mSumStockLocationDTLID
        End Get
        Set(ByVal Value As Long)
            mSumStockLocationDTLID = Value
        End Set
    End Property

    Public Function IsExist_Initial(ByVal tr As SqlTransaction, ByVal pIsSumLocation As Boolean) As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()
        IsExist_Initial = False
        Try

            Call CheckSumStock(tr, pIsSumLocation)

            SQL = "SELECT Product_Stock.ProductID,Product_Stock.Units,Product.CostType,Product_Stock.Cost,Product_Stock.Lot "
            SQL = SQL & " FROM Product_Stock"
            SQL = SQL & " LEFT OUTER JOIN Product ON Product_Stock.ProductID=Product.ProductID  "
            SQL = SQL & " WHERE Product_Stock.ProductID =" & ProductID
            If UnitID > 0 Then
                SQL = SQL & " AND Product_Stock.UnitID =" & UnitID
            End If
            If pIsSumLocation = True Then
                If SumStockLocationDTLID > 0 Then
                    SQL = SQL & " AND Product_Stock.LocationDTLID =" & SumStockLocationDTLID
                End If
            Else
                If LocationDTLID > 0 Then
                    SQL = SQL & " AND Product_Stock.LocationDTLID =" & LocationDTLID
                End If
            End If

            If SumStockLocationDTLID = LocationDTLID Then
                SQL = SQL & " AND Product_Stock.IsSumStock =1"
            Else
                SQL = SQL & " AND Product_Stock.IsSumStock =0"
            End If
            dataTable = gConnection.executeSelectQuery(SQL, tr)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    UnitsStock = ConvertNullToZero(dr("Units"))
                    Cost = ConvertNullToZero(dr("Cost"))
                    CostType = ConvertNullToZero(dr("CostType"))
                    Lot = ConvertNullToZero(dr("Lot"))
                    Return True
                    Exit For
                Next
            Else
                Return False
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProductStockDAO.IsExist_Initial : " & e.Message)
        Finally
            dataTable = Nothing
        End Try

    End Function

    Public Function CheckSumStock(ByVal tr As SqlTransaction, ByVal pIsSumLocation As Boolean) As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()
        CheckSumStock = False
        Try
            SQL = "SELECT LocationDTLID  "
            SQL = SQL & " FROM RunningFormat"
            SQL = SQL & " WHERE MenuID =" & MasterType.SellOrders

            dataTable = gConnection.executeSelectQuery(SQL, tr)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    SumStockLocationDTLID = ConvertNullToZero(dr("LocationDTLID"))
                    If pIsSumLocation = True Then
                        LocationDTLID = SumStockLocationDTLID
                    End If
                    Return (SumStockLocationDTLID > 0)
                    Exit For
                Next
            Else
                SumStockLocationDTLID = 0
                Return False
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProductStockDAO.CheckSumStock : " & e.Message)
        Finally
            dataTable = Nothing
        End Try

    End Function

    Public Function GetDataTable(ByVal pProductID As Long, ByVal pProductCategoryID As Long, ByVal pProductTypeID As Long _
                                 , ByVal pProductGroupID As Long, ByVal pProductBrandID As Long) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT  Product_Stock.ProductID,Product_Stock.UnitID,Product_Stock.LocationDTLID,Product_Stock.Units "
            SQL = SQL & " ,Product.ProductCode,Product.ProductName,Product_Unit.CodeThai AS UnitName,Product_LocationS.KeepMin "
            SQL = SQL & " FROM Product_Stock"
            SQL = SQL & " LEFT OUTER JOIN Product ON Product.ProductID=Product_Stock.ProductID "
            SQL = SQL & " LEFT OUTER JOIN Product_Unit ON Product_Unit.UnitID=Product_Stock.UnitID "
            SQL = SQL & " LEFT OUTER JOIN Product_LocationS ON Product_LocationS.RefID=Product_Stock.ProductID "
            SQL = SQL & " WHERE 1=1 "
            If pProductID > 0 Then
                SQL = SQL & " AND Product_Stock.ProductID =" & pProductID
            End If
            If pProductCategoryID > 0 Then
                SQL = SQL & " AND Product.ProductCategoryID =" & pProductCategoryID
            End If
            If pProductTypeID > 0 Then
                SQL = SQL & " AND Product.ProductTypeID =" & pProductTypeID
            End If
            If pProductGroupID > 0 Then
                SQL = SQL & " AND Product.ProductGroupID =" & pProductGroupID
            End If
            If pProductBrandID > 0 Then
                SQL = SQL & " AND Product.ProductBrandID =" & pProductBrandID
            End If
            SQL = SQL & " ORDER BY Product.ProductCode,Product.ProductName "
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProductStockDAO.GetDataTable : " & e.Message)
        End Try
        Return dataTable
    End Function


    Public Function GetDataStockByLocation(ByVal pProductCategoryID As Long, ByVal pProductTypeID As Long _
                                 , ByVal pProductGroupID As Long, ByVal pProductBrandID As Long) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = " EXEC	 [dbo].[spCheckStock]"
            If pProductCategoryID = 0 Then
                SQL = SQL & " @pProductCategoryID = '0',"
            Else
                SQL = SQL & " @pProductCategoryID = '" & pProductCategoryID & "',"
            End If
            If pProductTypeID = 0 Then
                SQL = SQL & " @pProductTypeID = '0',"
            Else
                SQL = SQL & " @pProductTypeID = '" & pProductTypeID & "',"
            End If
            If pProductGroupID = 0 Then
                SQL = SQL & " @pProductGroupID = '0',"
            Else
                SQL = SQL & " @pProductGroupID = '" & pProductGroupID & "',"
            End If
            If pProductBrandID = 0 Then
                SQL = SQL & " @pProductBrandID = '0'"
            Else
                SQL = SQL & " @pProductBrandID = '" & pProductBrandID & "'"
            End If
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProductStockDAO.GetDataStockByLocation : " & e.Message)
        End Try
        Return dataTable
    End Function


    Public Function GetDataStockByLocation2(ByVal pProductCategoryID As Long, ByVal pProductTypeID As Long _
                                 , ByVal pProductGroupID As Long, ByVal pProductBrandID As Long) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = " select a.ProductID,b.ProductCode,b.ProductName"
            SQL &= " ,c.NameThai as Location,d.CodeThai as Unit,a.Units,a.LocationDTLID,a.UnitID ,b.IsSN"
            SQL &= " from Product_Stock a"
            SQL &= " left outer join Product b on a.ProductID=b.ProductID"
            SQL &= " left outer join Product_LocationDTL c on a.LocationDTLID=c.LocationDTLID"
            SQL &= " left outer join Product_Unit d on a.UnitID=d.UnitID"
            SQL &= " where  1=1 "

            SQL &= "  "
            If pProductCategoryID > 0 Then
                SQL = SQL & " and b.ProductCategoryID = '" & pProductCategoryID & "',"
            End If
            If pProductTypeID > 0 Then
                SQL = SQL & " and b.ProductTypeID = '" & pProductTypeID & "',"
            End If
            If pProductGroupID > 0 Then
                SQL = SQL & " and b.ProductGroupID = '" & pProductGroupID & "',"
            End If
            If pProductBrandID > 0 Then
                SQL = SQL & " and b.ProductBrandID = '" & pProductBrandID & "'"
            End If
            SQL = SQL & " ORDER BY b.ProductCode,b.ProductName,c.NameThai,d.CodeThai "
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProductStockDAO.GetDataStockByLocation2 : " & e.Message)
        End Try
        Return dataTable
    End Function
    Public Function SaveData(ByVal tr As SqlTransaction, ByVal pIsSumLocation As Boolean, ByVal pIsSetUnit As Boolean, ByVal pOrderID As Long, ByVal pOrderCode As String) As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand
        SQL = ""
        Try
            Lot = 1

            If IsExist_Initial(tr, pIsSumLocation) = False Then
                SQL = " INSERT INTO Product_Stock(ProductID,UnitID,LocationDTLID,Units,CostType,Lot,Cost "
                SQL = SQL & ",IsSumStock"
                SQL = SQL & " )"
                SQL = SQL & " VALUES ( "
                SQL = SQL & "   @ProductID"
                SQL = SQL & " ,  @UnitID"
                SQL = SQL & " ,  @LocationDTLID"
                SQL = SQL & " ,  @Units"
                SQL = SQL & " ,  @CostType"
                SQL = SQL & " ,  @Lot"
                SQL = SQL & " ,  @Cost"
                If SumStockLocationDTLID = LocationDTLID Then
                    SQL = SQL & ",1"
                Else
                    SQL = SQL & ",0"
                End If
                SQL = SQL & " ) "
            Else
                SQL = " Update Product_Stock   "
                SQL = SQL & " SET"
                If pIsSetUnit = True Then
                    SQL = SQL & " Units=@Units"
                Else
                    SQL = SQL & " Units=Units+@Units"
                End If

                SQL = SQL & " WHERE ProductID= @ProductID"
                SQL = SQL & " AND UnitID= @UnitID"
                SQL = SQL & " AND LocationDTLID=@LocationDTLID"
                If SumStockLocationDTLID = LocationDTLID Then
                    SQL = SQL & " and IsSumStock=1"
                Else
                    SQL = SQL & " and IsSumStock=0"
                End If
            End If
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@UnitID", UnitID))
            myCommand.Parameters.Add(New SqlParameter("@Lot", Lot))
            myCommand.Parameters.Add(New SqlParameter("@Units", Units))
            myCommand.Parameters.Add(New SqlParameter("@CostType", CostType))
            myCommand.Parameters.Add(New SqlParameter("@Cost", Cost))
            myCommand.Parameters.Add(New SqlParameter("@ProductID", ProductID))
            myCommand.Parameters.Add(New SqlParameter("@LocationDTLID", IIf(pIsSumLocation = True, SumStockLocationDTLID, LocationDTLID)))
            gConnection.executeInsertSqlCommand(myCommand, tr)

            If Units <> 0 Then
                'Insert Log
                SQL = " INSERT INTO  Product_Stock_Log (ProductID,UnitID,LocationDTLID,Units,CostType,Lot,Cost "
                SQL = SQL & ",IsSumStock,OrderID,OrderCode,OrderBy "
                SQL = SQL & " )"
                SQL = SQL & " VALUES ( "
                SQL = SQL & "  " & ProductID
                SQL = SQL & " , " & UnitID
                SQL = SQL & " , " & IIf(pIsSumLocation = True, SumStockLocationDTLID, LocationDTLID)
                SQL = SQL & " , " & Units
                SQL = SQL & " , " & CostType
                SQL = SQL & " , " & Lot
                SQL = SQL & " , " & Cost
                If SumStockLocationDTLID = LocationDTLID Then
                    SQL = SQL & ",1"
                Else
                    SQL = SQL & ",0"
                End If
                SQL = SQL & " , " & pOrderID
                SQL = SQL & " , '" & pOrderCode & "'"
                SQL = SQL & " , '" & gUserName & "'"
                SQL = SQL & " ) "
                gConnection.executeInsertQuery(SQL, tr)
            End If


            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProductStockDAO.SaveData : " & e.Message)
            Return False
        End Try
    End Function


    Public Sub New()
        mProductID = 0
        mUnitID = 0
        mUnits = 0
        mCost = 0
        mLot = 0
        mLocationDTLID = 0
        mSumStockLocationDTLID = 0
        mCostType = ProductCostDAO.CostTypes.Average
    End Sub
End Class
