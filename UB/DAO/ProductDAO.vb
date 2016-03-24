Option Explicit On
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class ProductDAO
    Inherits iDAO
    
    Dim mProductImageS As List(Of FileAttachDAO)
    Dim mProductUnitBuyDAOs As List(Of ProductUnitDAO)
    Dim mProductUnitSellDAOs As List(Of ProductUnitDAO)
    Dim mProductLocationSDAOs As List(Of ProductLocationSDAO)
    Dim mProductSubstituteDAOs As List(Of ProductListDAO)
    Dim mProductSetDAOs As List(Of ProductListDAO)
 


#Region "Property"
    Dim mCostType As ProductCostDAO.CostTypes
    Dim mTaxType As Boolean
    Dim mIsSN As Integer
    Dim mIsProductSet As Boolean
    Dim mUnitMainID As Long
    Dim mUnitSecondID As Long
    Dim mPriceStandard As Decimal
    Dim mPrice1 As Decimal
    Dim mPrice2 As Decimal
    Dim mPrice3 As Decimal
    Dim mPrice4 As Decimal
    Dim mPrice5 As Decimal
    Dim mPrice6 As Decimal
    Dim mPriceSale As Decimal
    Dim mPriceBuy As Decimal
    Dim mProductFomulaID As Long
    Dim mProductCategoryID As Long
    Dim mProductBrandID As Long
    Dim mProductTypeID As Long
    Dim mProductGroup1 As Long
    Dim mProductGroup2 As Long
    Dim mProductGroup3 As Long
    Dim mProductGroup4 As Long
    Dim mProductGroup5 As Long
    Dim mProductDimension1 As Long
    Dim mProductDimension2 As Long
    Dim mProductDimension3 As Long
    Dim mProductDimension4 As Long
    Dim mProductDimension5 As Long
    Dim mWeight As String
    Dim mSize As String
    Dim mGeneration As String
    Dim mColor As String
    Dim mCost As Decimal
    Dim mProductBrand As ProductBrandDAO
    Dim mProductGroupID As Long
    Dim mGuaranteeDay As Long = 0
    Dim mUnitMainIDBuy As Long = 0


    Public ReadOnly Property TableName() As String
        Get
            Return "Product"
        End Get
    End Property

    Public Property IsSN() As Integer
        Get
            Return mIsSN
        End Get
        Set(ByVal value As Integer)
            mIsSN = value
        End Set
    End Property

    Public Property IsProductSet() As Boolean
        Get
            Return mIsProductSet
        End Get
        Set(ByVal value As Boolean)
            mIsProductSet = value
        End Set
    End Property


    Public Property PriceStandard() As Decimal
        Get
            Return mPriceStandard
        End Get
        Set(ByVal value As Decimal)
            mPriceStandard = value
        End Set

    End Property


    Public Property Price1() As Decimal
        Get
            Return mPrice1
        End Get
        Set(ByVal value As Decimal)
            mPrice1 = value
        End Set

    End Property

    Public Property Price2() As Decimal
        Get
            Return mPrice2
        End Get
        Set(ByVal value As Decimal)
            mPrice2 = value
        End Set

    End Property

    Public Property Price3() As Decimal
        Get
            Return mPrice3
        End Get
        Set(ByVal value As Decimal)
            mPrice3 = value
        End Set
    End Property
    Public Property Price4() As Decimal
        Get
            Return mPrice4
        End Get
        Set(ByVal value As Decimal)
            mPrice4 = value
        End Set
    End Property
    Public Property Price5() As Decimal
        Get
            Return mPrice5
        End Get
        Set(ByVal value As Decimal)
            mPrice5 = value
        End Set
    End Property
    Public Property Price6() As Decimal
        Get
            Return mPrice6
        End Get
        Set(ByVal value As Decimal)
            mPrice6 = value
        End Set
    End Property
    Public Property PriceSale() As Decimal
        Get
            Return mPriceSale
        End Get
        Set(ByVal value As Decimal)
            mPriceSale = value
        End Set

    End Property
    Public Property PriceBuy() As Decimal
        Get
            Return mPriceBuy
        End Get
        Set(ByVal value As Decimal)
            mPriceBuy = value
        End Set
    End Property
    Public Property Cost() As Decimal
        Get
            Return mCost
        End Get
        Set(ByVal value As Decimal)
            mCost = value
        End Set
    End Property
    Public Property TaxType() As Boolean
        Get
            Return mTaxType
        End Get
        Set(ByVal value As Boolean)
            mTaxType = value
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

    Public Property UnitMainIDBuy() As Long
        Get
            Return mUnitMainIDBuy
        End Get
        Set(ByVal value As Long)
            mUnitMainIDBuy = value
        End Set
    End Property

    Public Property UnitSecondID() As Long
        Get
            Return mUnitSecondID
        End Get
        Set(ByVal value As Long)
            mUnitSecondID = value
        End Set
    End Property

    Public Property ProductFomulaID() As Long
        Get
            Return mProductFomulaID
        End Get
        Set(ByVal value As Long)
            mProductFomulaID = value
        End Set
    End Property

    Public Property ProductGroupID() As Long
        Get
            Return mProductGroupID
        End Get
        Set(ByVal value As Long)
            mProductGroupID = value
        End Set
    End Property

    Public Property ProductCategoryID() As Long
        Get
            Return mProductCategoryID
        End Get
        Set(ByVal value As Long)
            mProductCategoryID = value
        End Set
    End Property

    Public Property ProductBrandID() As Long
        Get
            Return mProductBrandID
        End Get
        Set(ByVal value As Long)
            mProductBrandID = value
        End Set
    End Property

    Public ReadOnly Property ProductBrand() As ProductBrandDAO
        Get
            If mProductBrandID > 0 And mProductBrand Is Nothing Then
                mProductBrand = New ProductBrandDAO
                mProductBrand.InitailData(mProductBrandID, Nothing, "")
            End If
            Return mProductBrand
        End Get
        'Set(ByVal value As ProductBrandDAO)
        '    mProductBrand = value
        'End Set
    End Property


    Public Property ProductTypeID() As Long
        Get
            Return mProductTypeID
        End Get
        Set(ByVal value As Long)
            mProductTypeID = value
        End Set
    End Property


    'Public Property Product_LocationsID() As Long
    '    Get
    '        Return mProduct_LocationsID
    '    End Get
    '    Set(ByVal value As Long)
    '        mProduct_LocationsID = value
    '    End Set
    'End Property


    Public Property ProductGroup1() As Long
        Get
            Return mProductGroup1
        End Get
        Set(ByVal value As Long)
            mProductGroup1 = value
        End Set
    End Property

    Public Property ProductGroup2() As Long
        Get
            Return mProductGroup2
        End Get
        Set(ByVal value As Long)
            mProductGroup2 = value
        End Set
    End Property

    Public Property ProductGroup3() As Long
        Get
            Return mProductGroup3
        End Get
        Set(ByVal value As Long)
            mProductGroup3 = value
        End Set
    End Property

    Public Property ProductGroup4() As Long
        Get
            Return mProductGroup4
        End Get
        Set(ByVal value As Long)
            mProductGroup4 = value
        End Set
    End Property

    Public Property ProductGroup5() As Long
        Get
            Return mProductGroup5
        End Get
        Set(ByVal value As Long)
            mProductGroup5 = value
        End Set
    End Property

    Public Property ProductDimension1() As Long
        Get
            Return mProductDimension1
        End Get
        Set(ByVal value As Long)
            mProductDimension1 = value
        End Set

    End Property

    Public Property ProductDimension2() As Long
        Get
            Return mProductDimension2
        End Get
        Set(ByVal value As Long)
            mProductDimension2 = value
        End Set

    End Property

    Public Property ProductDimension3() As Long
        Get
            Return mProductDimension3
        End Get
        Set(ByVal value As Long)
            mProductDimension3 = value
        End Set

    End Property

    Public Property ProductDimension4() As Long
        Get
            Return mProductDimension4
        End Get
        Set(ByVal value As Long)
            mProductDimension4 = value
        End Set

    End Property

    Public Property ProductDimension5() As Long
        Get
            Return mProductDimension5
        End Get
        Set(ByVal value As Long)
            mProductDimension5 = value
        End Set

    End Property

    Public Property GuaranteeDay() As Long
        Get
            Return mGuaranteeDay
        End Get
        Set(ByVal value As Long)
            mGuaranteeDay = value
        End Set

    End Property
    Public Property Color() As String
        Get
            Return mColor
        End Get
        Set(ByVal value As String)
            mColor = value
        End Set
    End Property

    Public Property Generation() As String
        Get
            Return mGeneration
        End Get
        Set(ByVal value As String)
            mGeneration = value
        End Set
    End Property


    Public Property Size() As String
        Get
            Return mSize
        End Get
        Set(ByVal value As String)
            mSize = value
        End Set
    End Property

    Public Property Weight() As String
        Get
            Return mWeight
        End Get
        Set(ByVal value As String)
            mWeight = value
        End Set

    End Property
    Public Property CostType() As ProductCostDAO.CostTypes
        Get
            Return mCostType
        End Get
        Set(ByVal value As ProductCostDAO.CostTypes)
            mCostType = value
        End Set
    End Property


    Public Property ProductImageS(ByVal ptr As SqlTransaction) As List(Of FileAttachDAO)
        Get
            If mProductImageS Is Nothing Then
                mProductImageS = LoadFileAttach(ID, TableName & "_Image", ptr)
            End If
            Return mProductImageS
        End Get
        Set(ByVal Value As List(Of FileAttachDAO))
            mProductImageS = Value
        End Set
    End Property


    Public Property ProductUnitBuyDAOs() As List(Of ProductUnitDAO)
        Get
            'If mProductUnitBuyDAOs Is Nothing Then
            '    LoadProductUnitBuyDAOS()
            'End If
            Return mProductUnitBuyDAOs
        End Get
        Set(ByVal Value As List(Of ProductUnitDAO))
            mProductUnitBuyDAOs = Value
        End Set
    End Property

    Public Property ProductUnitSellDAOs() As List(Of ProductUnitDAO)
        Get
            'If mProductUnitSellDAOs Is Nothing Then
            '    LoadProductUnitSellDAOS()
            'End If
            Return mProductUnitSellDAOs
        End Get
        Set(ByVal Value As List(Of ProductUnitDAO))
            mProductUnitSellDAOs = Value
        End Set

    End Property
    Public Property ProductLocationSDAOs() As List(Of ProductLocationSDAO)
        Get
            'If mProductLocationSDAOs Is Nothing Then
            '    LoadProductLocationSDAO()
            'End If
            Return mProductLocationSDAOs
        End Get
        Set(ByVal Value As List(Of ProductLocationSDAO))
            mProductLocationSDAOs = Value
        End Set
    End Property

    Public Property ProductSubstituteDAOs() As List(Of ProductListDAO)
        Get
            'If mProductSubstituteDAOs Is Nothing Then
            '    LoadProductSubstitute()
            'End If
            Return mProductSubstituteDAOs
        End Get
        Set(ByVal Value As List(Of ProductListDAO))
            mProductSubstituteDAOs = Value
        End Set
    End Property

    Public Property ProductSetDAOs() As List(Of ProductListDAO)
        Get
            Return mProductSetDAOs
        End Get
        Set(ByVal Value As List(Of ProductListDAO))
            mProductSetDAOs = Value
        End Set
    End Property

#End Region


    Public Function CHECKSUM_AGG() As Long
        Dim SQL As String
        Dim dataTable As New DataTable()
        Try
            SQL = "SELECT CHECKSUM_AGG(BINARY_CHECKSUM(*)) FROM " & TableName & " WITH (NOLOCK);"

            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    Return ConvertNullToZero(dr(0))
                    Exit For
                Next
            End If
            Return 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProductDAO.CHECKSUM_AGG : " & e.Message)
            Return 0
        Finally
            dataTable = Nothing
        End Try
    End Function


    Public Function InitailData(ByVal pID As Long, ByVal pCustomerID As Long, ByVal pProductCode As String, ByVal pProductName As String _
                               , Optional ByVal ptr As SqlTransaction = Nothing) As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()
        Dim lUserDAO As New UserDAO

        Try
            SQL = "SELECT *   "
            SQL = SQL & " FROM " & TableName
            SQL = SQL & " WHERE 1=1"
            If pID > 0 Then
                SQL = SQL & "  AND ProductID=" & pID
            End If
            If pProductCode.Trim <> "" Then
                SQL = SQL & "  AND ProductCode='" & pProductCode.Trim & "'"
            End If
            If pProductName.Trim <> "" Then
                SQL = SQL & "  AND ProductName='" & pProductName.Trim & "'"
            End If
            dataTable = gConnection.executeSelectQuery(SQL, ptr)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    ID = Int32.Parse(dr("ProductID"))
                    IsInActive = dr("IsInActive")
                    Code = dr("ProductCode").ToString
                    NameThai = dr("ProductName").ToString
                    NameEng = dr("ProductNameEng").ToString
                    Remark = dr("Remark").ToString
                    CreateTime = ConvertNullToDateTime(dr("CreateTime"))
                    ModifiedTime = ConvertNullToDateTime(dr("ModifiedTime"))
                    If lUserDAO.InitailData(True, ConvertNullToZero(dr("CreateBy")), "", ptr) Then
                        CreateBy = lUserDAO.UserName
                    Else
                        CreateBy = ""
                    End If

                    If ConvertNullToZero(dr("CreateBy")) = ConvertNullToZero(dr("ModifiedBy")) Then
                        ModifiedBy = CreateBy
                    Else
                        If lUserDAO.InitailData(True, ConvertNullToZero(dr("ModifiedBy")), "", ptr) Then
                            ModifiedBy = lUserDAO.UserName
                        Else
                            ModifiedBy = ""
                        End If
                    End If


                    CostType = ConvertNullToZero(dr("CostType"))
                    PriceStandard = ConvertNullToZero(dr("PriceStandard"))
                    Price1 = ConvertNullToZero(dr("Price1"))
                    Price2 = ConvertNullToZero(dr("Price2"))
                    Price3 = ConvertNullToZero(dr("Price3"))
                    Price4 = ConvertNullToZero(dr("Price4"))
                    Price5 = ConvertNullToZero(dr("Price5"))
                    Price6 = ConvertNullToZero(dr("Price6"))
                    Weight = ConvertNullToString(dr("Weight"))
                    Size = ConvertNullToString(dr("Size"))
                    Generation = ConvertNullToString(dr("Generation"))
                    Color = ConvertNullToString(dr("Color"))
                    TaxType = dr("TaxType")
                    IsSN = ConvertNullToZero(dr("IsSN"))
                    IsProductSet = ConvertNullToBoolean(dr("IsProductSet"))
                    UnitMainID = ConvertNullToZero(dr("UnitMainID"))
                    UnitMainIDBuy = ConvertNullToZero(dr("UnitMainIDBuy"))
                    UnitSecondID = ConvertNullToZero(dr("UnitSecondID"))

                    ProductFomulaID = ConvertNullToZero(dr("ProductFomulaID"))
                    ProductCategoryID = ConvertNullToZero(dr("ProductCategoryID"))
                    ProductBrandID = ConvertNullToZero(dr("ProductBrandID"))
                    ProductTypeID = ConvertNullToZero(dr("ProductTypeID"))
                    ProductGroupID = ConvertNullToZero(dr("ProductGroupID"))
                    ProductGroup1 = ConvertNullToZero(dr("ProductGroup1"))
                    ProductGroup2 = ConvertNullToZero(dr("ProductGroup2"))
                    ProductGroup3 = ConvertNullToZero(dr("ProductGroup3"))
                    ProductGroup4 = ConvertNullToZero(dr("ProductGroup4"))
                    ProductGroup5 = ConvertNullToZero(dr("ProductGroup5"))
                    ProductDimension1 = ConvertNullToZero(dr("ProductDimension1"))
                    ProductDimension2 = ConvertNullToZero(dr("ProductDimension2"))
                    ProductDimension3 = ConvertNullToZero(dr("ProductDimension3"))
                    ProductDimension4 = ConvertNullToZero(dr("ProductDimension4"))
                    ProductDimension5 = ConvertNullToZero(dr("ProductDimension5"))
                    ImportTXID = ConvertNullToZero(dr("ImportTXID"))
                    GuaranteeDay = ConvertNullToZero(dr("GuaranteeDay"))
                    'Calc Price
                    If pCustomerID > 0 Then
                        'Customer
                        Dim lclsCus As New CustomerDAO
                        lclsCus.InitailData(pCustomerID, "", ptr)

                        Dim lclsInform As New InformPriceDAO
                        If lclsInform.InitailData(pCustomerID, ID, ptr) Then
                            PriceSale = lclsInform.PriceSale
                        End If
                        If PriceSale = 0 Then
                            Select Case lclsCus.CriterionPriceID
                                Case 0
                                    PriceSale = PriceStandard
                                Case 1
                                    PriceSale = Price1
                                Case 2
                                    PriceSale = Price2
                                Case 3
                                    PriceSale = Price3
                                Case 4
                                    PriceSale = Price4
                                Case 5
                                    PriceSale = Price5
                                Case 6
                                    PriceSale = Price6
                                Case Else
                                    PriceSale = PriceStandard
                            End Select
                        End If


                        Dim lclsInformBuy As New InformPriceBuyDAO
                        If lclsInformBuy.InitailData(pCustomerID, ID, ptr) Then
                            PriceBuy = lclsInformBuy.PriceBuy
                        End If
                        If PriceBuy = 0 Then
                            Select Case lclsCus.CriterionPriceID
                                Case 0
                                    PriceBuy = PriceStandard
                                Case 1
                                    PriceBuy = Price1
                                Case 2
                                    PriceBuy = Price1
                                Case 3
                                    PriceBuy = Price1
                                Case 4
                                    PriceBuy = Price1
                                Case 5
                                    PriceBuy = Price1
                                Case 6
                                    PriceBuy = Price1
                                Case Else
                                    PriceSale = PriceStandard
                            End Select
                        End If
                        lclsInform = Nothing
                        lclsInformBuy = Nothing
                        lclsCus = Nothing
                    Else
                        PriceSale = PriceStandard
                        PriceBuy = PriceStandard
                    End If

                    'Calc Cost
                    Dim lclsCost As New ProductCostDAO
                    If lclsCost.InitailData(ID, mCostType, 0, ptr) Then
                        Cost = lclsCost.Cost
                    Else
                        Cost = PriceSale
                    End If

                    FileAttachs = LoadFileAttach(ID, TableName & "_File", ptr)
                    Return True
                    Exit For
                Next
            End If



        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProductDAO.InitailData : " & e.Message)
            Return False
        Finally
            lUserDAO = Nothing
            dataTable = Nothing
        End Try

    End Function


    Public Function GetInfoHtml() As String
        Dim Info As String = ""
        Try

            Info = Constants.vbCrLf & Constants.vbCrLf & "รหัสสินค้า: " & Code
            Info &= Constants.vbCrLf & "ชื่อสินค้า: " & NameThai
            Info &= Constants.vbCrLf & "ชื่อสินค้า (Eng): " & NameEng
            Info &= Constants.vbCrLf & "ราคา: " & PriceStandard
            'Info &= Constants.vbCrLf & "หัวหน้าแผนก: "
            'If Not Manager Is Nothing Then
            '    Info &= Manager.Title & Manager.FirstName & " " & Manager.LastName
            'End If
            Info &= Constants.vbCrLf & "รายละเอียด: " & Remark

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProductDAO.GetInfoHtml : " & e.Message)

        End Try
        Return Info
    End Function


    Public Function GetDataTable(ByVal pID As Long, ByVal pOnlyActive As Boolean, Optional ByVal pProductCode As String = "") As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT ProductID AS ID,ProductCode,ProductName,PriceStandard AS Price,Remark"
            SQL = SQL & " FROM " & TableName
            SQL = SQL & " WHERE IsDelete =0   "
            If pID > 0 Then
                SQL = SQL & "  AND ProductID=" & pID
            End If
            If pProductCode.Trim <> "" Then
                SQL = SQL & "  AND ProductCode='" & pProductCode.Trim & "'"
            End If
            If pOnlyActive = True Then
                SQL = SQL & "  AND IsInActive = 0"
            End If
            SQL = SQL & " ORDER BY ProductCode"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProductDAO.GetDataTable : " & e.Message)
        End Try
        Return dataTable
    End Function

    Public Function GetDataTableForCombo(ByVal pID As Long, ByVal pCustomerID As Long, ByVal pOnlyActive As Boolean, ByVal pProductCode As String, Optional ByVal pSQL As String = "") As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT 'TRUE' AS IsSelect, Product.ProductID AS ID,Product.ProductCode,Product.ProductName"
            If pCustomerID = 0 Then
                SQL = SQL & ",Product.PriceStandard AS Price "
            Else
                SQL = SQL & ",CASE WHEN InformPrice.PriceInform > 0 THEN InformPrice.PriceInform  "
                SQL = SQL & " ELSE Product.PriceStandard END Price "
            End If
            SQL = SQL & " FROM Product"
            If pCustomerID > 0 Then
                SQL = SQL & " LEFT OUTER JOIN InformPrice ON Product.ProductID=InformPrice.ProductID AND InformPrice.CustomerID=" & pCustomerID
            End If
            SQL = SQL & " WHERE Product.IsDelete =0   "
            If pID > 0 Then
                SQL = SQL & "  AND Product.ProductID=" & pID
            End If
            If pProductCode.Trim <> "" Then
                SQL = SQL & "  AND Product.ProductCode='" & pProductCode.Trim & "'"
            End If
            If pOnlyActive = True Then
                SQL = SQL & "  AND Product.IsInActive = 0"
            End If

            SQL = SQL & pSQL

            SQL = SQL & " ORDER BY Product.ProductCode"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProductDAO.GetDataTableForCombo : " & e.Message)
        End Try
        Return dataTable
    End Function


    Public Function SaveData(Optional ByRef ptr As SqlTransaction = Nothing) As Boolean
        Dim SQL As String
        Dim llngAddressID As Long = 0
        Dim myCommand As SqlCommand
        Dim tr As SqlTransaction = Nothing
        SQL = ""
        Try

            If ptr Is Nothing Then
                tr = gConnection.Connection.BeginTransaction
            Else
                tr = ptr
            End If

            Select Case ModeData
                Case DataMode.ModeNew
                    ID = GenNewID("ProductID", TableName, tr)
                    SQL = " INSERT INTO Product  (ProductID,ProductCode,ProductName,ProductNameEng "
                    SQL = SQL & " ,CostType,PriceStandard,Price1,Price2,Price3,Price4,Price5,Price6"
                    SQL = SQL & " ,TaxType,IsSN,IsProductSet,UnitMainID,UnitMainIDBuy,UnitSecondID,ProductFomulaID "
                    SQL = SQL & " ,ProductCategoryID,ProductBrandID,ProductTypeID,ProductGroupID,ProductGroup1,ProductGroup2"
                    SQL = SQL & " ,ProductGroup3,ProductGroup4,ProductGroup5,ProductDimension1,ProductDimension2,ProductDimension3 "
                    SQL = SQL & " ,ProductDimension4,ProductDimension5,Weight,Size,Generation,Color"
                    SQL = SQL & " ,Remark,CreateBy,CreateTime,IsInActive,IsDelete,ImportTXID,GuaranteeDay)"
                    SQL = SQL & " VALUES ( @mIDs"
                    SQL = SQL & " ,  @Code"
                    SQL = SQL & " ,  @ProductName"
                    SQL = SQL & " ,  @ProductNameEng"
                    SQL = SQL & " ,  @CostType"
                    SQL = SQL & " ,  @PriceStandard"
                    SQL = SQL & " ,  @Price1"
                    SQL = SQL & " ,  @Price2"
                    SQL = SQL & " ,  @Price3"
                    SQL = SQL & " ,  @Price4"
                    SQL = SQL & " ,  @Price5"
                    SQL = SQL & " ,  @Price6"
                    SQL = SQL & " ,  @TaxType"
                    SQL = SQL & " ,  @IsSN"
                    SQL = SQL & " ,  @IsProductSet"
                    SQL = SQL & " ,  @UnitMainID"
                    SQL = SQL & " ,  @UnitMainIDBuy"
                    SQL = SQL & " ,  @UnitSecondID"
                    SQL = SQL & " ,  @ProductFomulaID"
                    SQL = SQL & " ,  @ProductCategoryID"
                    SQL = SQL & " ,  @ProductBrandID"
                    SQL = SQL & " ,  @ProductTypeID"
                    SQL = SQL & " ,  @ProductGroupID"
                    SQL = SQL & " ,  @ProductGroup1"
                    SQL = SQL & " ,  @ProductGroup2"
                    SQL = SQL & " ,  @ProductGroup3"
                    SQL = SQL & " ,  @ProductGroup4"
                    SQL = SQL & " ,  @ProductGroup5"
                    SQL = SQL & " ,  @ProductDimension1"
                    SQL = SQL & " ,  @ProductDimension2"
                    SQL = SQL & " ,  @ProductDimension3"
                    SQL = SQL & " ,  @ProductDimension4"
                    SQL = SQL & " ,  @ProductDimension5"
                    SQL = SQL & " ,  @Weight"
                    SQL = SQL & " ,  @Size"
                    SQL = SQL & " ,  @Generation"
                    SQL = SQL & " ,  @Color"
                    SQL = SQL & " ,  @Remark"
                    SQL = SQL & " ,  @gUserID"
                    SQL = SQL & " ,  @CreateTime"
                    SQL = SQL & " ,  @mIsInActive"
                    SQL = SQL & " ,  @mIsDelete"
                    SQL = SQL & " ,  @ImportTXID"
                    SQL = SQL & " ,  @GuaranteeDay"
                    SQL = SQL & " ) "
                Case DataMode.ModeEdit
                    SQL = " UPDATE Product SET "
                    SQL = SQL & "  ProductCode=@Code"
                    SQL = SQL & " ,  ProductName=@ProductName"
                    SQL = SQL & " ,  ProductNameEng=@ProductNameEng"
                    SQL = SQL & " ,  CostType=@CostType"
                    SQL = SQL & " ,  PriceStandard=@PriceStandard"
                    SQL = SQL & " ,  Price1=@Price1"
                    SQL = SQL & " ,  Price2=@Price2"
                    SQL = SQL & " ,  Price3=@Price3"
                    SQL = SQL & " ,  Price4=@Price4"
                    SQL = SQL & " ,  Price5=@Price5"
                    SQL = SQL & " ,  Price6=@Price6"
                    SQL = SQL & " ,  TaxType=@TaxType"
                    SQL = SQL & " ,  IsSN=@IsSN"
                    SQL = SQL & " ,  IsProductSet=@IsProductSet"
                    SQL = SQL & " ,  UnitSecondID=@UnitSecondID"
                    SQL = SQL & " ,  UnitMainID=@UnitMainID"
                    SQL = SQL & " ,  UnitMainIDBuy=@UnitMainIDBuy"
                    SQL = SQL & " ,  ProductFomulaID=@ProductFomulaID"
                    SQL = SQL & " ,  ProductCategoryID=@ProductCategoryID"
                    SQL = SQL & " ,  ProductBrandID=@ProductBrandID"
                    SQL = SQL & " ,  ProductTypeID=@ProductTypeID"
                    SQL = SQL & " ,  ProductGroupID=@ProductGroupID"
                    SQL = SQL & " ,  ProductGroup1=@ProductGroup1"
                    SQL = SQL & " ,  ProductGroup2=@ProductGroup2"
                    SQL = SQL & " ,  ProductGroup3=@ProductGroup3"
                    SQL = SQL & " ,  ProductGroup4=@ProductGroup4"
                    SQL = SQL & " ,  ProductGroup5=@ProductGroup5"
                    SQL = SQL & " ,  ProductDimension1=@ProductDimension1"
                    SQL = SQL & " ,  ProductDimension2=@ProductDimension2"
                    SQL = SQL & " ,  ProductDimension3=@ProductDimension3"
                    SQL = SQL & " ,  ProductDimension4=@ProductDimension4"
                    SQL = SQL & " ,  ProductDimension5=@ProductDimension5"
                    SQL = SQL & " ,  Weight=@Weight"
                    SQL = SQL & " ,  Size=@Size"
                    SQL = SQL & " ,  Generation=@Generation"
                    SQL = SQL & " ,  Color=@Color"
                    SQL = SQL & " ,  GuaranteeDay=@GuaranteeDay"
                    SQL = SQL & " ,Remark= @Remark"
                    SQL = SQL & " ,ModifiedBy= @gUserID"
                    SQL = SQL & " ,ModifiedTime= @CreateTime"
                    SQL = SQL & " ,IsInActive= @mIsInActive"
                    SQL = SQL & " WHERE ProductID= @mIDs"
                Case DataMode.ModeDelete
                    SQL = " UPDATE Product SET IsDelete=@mIsDelete "
                    SQL = SQL & " ,ModifiedBy= @gUserID"
                    SQL = SQL & " ,ModifiedTime= @CreateTime"
                    SQL = SQL & " WHERE ProductID= @mIDs"
            End Select
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@mIDs", ID))
            myCommand.Parameters.Add(New SqlParameter("@Code", Trim(Code)))
            myCommand.Parameters.Add(New SqlParameter("@ProductName", Trim(NameThai)))
            myCommand.Parameters.Add(New SqlParameter("@ProductNameEng", Trim(NameEng)))
            myCommand.Parameters.Add(New SqlParameter("@Remark", Trim(Remark)))
            myCommand.Parameters.Add(New SqlParameter("@gUserID", gUserID))
            myCommand.Parameters.Add(New SqlParameter("@CreateTime", formatSQLDateTime(GetCurrentDate(tr))))
            myCommand.Parameters.Add(New SqlParameter("@mIsInActive", IsInActive))

            myCommand.Parameters.Add(New SqlParameter("@CostType", ConvertNullToZero(mCostType)))
            myCommand.Parameters.Add(New SqlParameter("@PriceStandard", ConvertNullToZero(PriceStandard)))
            myCommand.Parameters.Add(New SqlParameter("@Price1", ConvertNullToZero(Price1)))
            myCommand.Parameters.Add(New SqlParameter("@Price2", ConvertNullToZero(Price2)))
            myCommand.Parameters.Add(New SqlParameter("@Price3", ConvertNullToZero(Price3)))
            myCommand.Parameters.Add(New SqlParameter("@Price4", ConvertNullToZero(Price4)))
            myCommand.Parameters.Add(New SqlParameter("@Price5", ConvertNullToZero(Price5)))
            myCommand.Parameters.Add(New SqlParameter("@Price6", ConvertNullToZero(Price6)))
            myCommand.Parameters.Add(New SqlParameter("@TaxType", TaxType))
            myCommand.Parameters.Add(New SqlParameter("@IsSN", IsSN))
            myCommand.Parameters.Add(New SqlParameter("@IsProductSet", IsProductSet))
            myCommand.Parameters.Add(New SqlParameter("@UnitSecondID", ConvertNullToZero(UnitSecondID)))
            myCommand.Parameters.Add(New SqlParameter("@UnitMainID", ConvertNullToZero(UnitMainID)))
            myCommand.Parameters.Add(New SqlParameter("@UnitMainIDBuy", ConvertNullToZero(UnitMainIDBuy)))
            myCommand.Parameters.Add(New SqlParameter("@ProductFomulaID", ConvertNullToZero(ProductFomulaID)))
            myCommand.Parameters.Add(New SqlParameter("@ProductCategoryID", ConvertNullToZero(ProductCategoryID)))
            myCommand.Parameters.Add(New SqlParameter("@ProductBrandID", ConvertNullToZero(ProductBrandID)))
            myCommand.Parameters.Add(New SqlParameter("@ProductTypeID", ConvertNullToZero(ProductTypeID)))
            myCommand.Parameters.Add(New SqlParameter("@ProductGroupID", ConvertNullToZero(ProductGroupID)))
            myCommand.Parameters.Add(New SqlParameter("@ProductGroup1", ConvertNullToZero(ProductGroup1)))
            myCommand.Parameters.Add(New SqlParameter("@ProductGroup2", ConvertNullToZero(ProductGroup2)))
            myCommand.Parameters.Add(New SqlParameter("@ProductGroup3", ConvertNullToZero(ProductGroup3)))
            myCommand.Parameters.Add(New SqlParameter("@ProductGroup4", ConvertNullToZero(ProductGroup4)))
            myCommand.Parameters.Add(New SqlParameter("@ProductGroup5", ConvertNullToZero(ProductGroup5)))
            myCommand.Parameters.Add(New SqlParameter("@ProductDimension1", ConvertNullToZero(ProductDimension1)))
            myCommand.Parameters.Add(New SqlParameter("@ProductDimension2", ConvertNullToZero(ProductDimension2)))
            myCommand.Parameters.Add(New SqlParameter("@ProductDimension3", ConvertNullToZero(ProductDimension3)))
            myCommand.Parameters.Add(New SqlParameter("@ProductDimension4", ConvertNullToZero(ProductDimension4)))
            myCommand.Parameters.Add(New SqlParameter("@ProductDimension5", ConvertNullToZero(ProductDimension5)))
            myCommand.Parameters.Add(New SqlParameter("@Weight", ConvertNullToString(Weight)))
            myCommand.Parameters.Add(New SqlParameter("@Size", ConvertNullToString(Size)))
            myCommand.Parameters.Add(New SqlParameter("@Generation", ConvertNullToString(Generation)))
            myCommand.Parameters.Add(New SqlParameter("@Color", ConvertNullToString(Color)))
            myCommand.Parameters.Add(New SqlParameter("@ImportTXID", ConvertNullToZero(ImportTXID)))
            myCommand.Parameters.Add(New SqlParameter("@GuaranteeDay", ConvertNullToZero(GuaranteeDay)))
            Select Case ModeData
                Case DataMode.ModeNew
                    myCommand.Parameters.Add(New SqlParameter("@mIsDelete", 0))
                Case DataMode.ModeDelete
                    myCommand.Parameters.Add(New SqlParameter("@mIsDelete", 1))
            End Select
            gConnection.executeInsertSqlCommand(myCommand, tr)

            SaveNote(NoteDAOs, ModeData, ID, TableName, tr)
            SaveAttachFile(FileAttachs, ModeData, ID, TableName & "_File", tr)
            SaveAttachFile(ProductImageS(tr), ModeData, ID, TableName & "_Image", tr)
            SaveProductLocationS(tr)
            SaveProductUnitBuyDAOs(tr)
            SaveProductUnitSellDAOs(tr)
            Dim lclsOrder As New OrderSDAO
            lclsOrder.TableID = 0
            lclsOrder.SaveProductList(ProductSubstituteDAOs, ModeData, ID, TableName, tr)
            lclsOrder = New OrderSDAO
            lclsOrder.TableID = 0
            lclsOrder.SaveProductList(ProductSetDAOs, ModeData, ID, TableName & "_ProSet", tr)

            If ModeData = DataMode.ModeNew Then
                UpdateLastID(MasterType.Product, tr)
            End If
            InsertActivity(ModeData, MasterType.Product, Code, tr)
            If ptr Is Nothing Then tr.Commit()

            Return True
        Catch e As Exception
            If ptr Is Nothing Then tr.Rollback()
            Err.Raise(Err.Number, e.Source, "ProductDAO.SaveData : " & e.Message)
            Return False
        End Try

    End Function

    Public Function CheckExist() As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT ProductID  FROM Product"
            SQL = SQL & " WHERE IsDelete =0 AND ProductCode='" & Trim(Code) & "'"
            If ModeData = DataMode.ModeEdit Then
                SQL = SQL & " AND ProductID <> " & ID
            End If
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            Return dataTable.Rows.Count > 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProductDAO.CheckExist : " & e.Message)
            Return False
        Finally
            dataTable = Nothing
        End Try

    End Function

    Public Function IsSerialNumber(ByVal pProductID As Long) As Integer
        Dim SQL As String
        Dim dataTable As New DataTable()
        IsSerialNumber = 0
        Try
            SQL = "SELECT IsSN  FROM Product"
            SQL = SQL & " WHERE ProductID =" & pProductID
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            For Each dr2 As DataRow In dataTable.Rows
                Return ConvertNullToZero(dr2("IsSN"))
            Next
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProductDAO.IsSerialNumber : " & e.Message)
            Return 0
        Finally
            dataTable = Nothing
        End Try

    End Function

    Public Function CheckIsToUse() As Boolean ''ถูกใช้งานอยู่ ???
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT ProductID  FROM ProductList"
            SQL = SQL & " WHERE IsDelete =0 AND RefID in ( select OrderID from  Orders  WHERE IsDelete =0  " & ")"
            SQL = SQL & " and ProductID=" & ID
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            Return dataTable.Rows.Count > 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProductDAO.CheckNotExist : " & e.Message)
        Finally
            dataTable = Nothing
        End Try

    End Function

    'Public Sub LoadProductUnitBuyDAOS(ByVal pProductID As Long, ByVal pUnitID As Long)
    '    Dim dataTable As New DataTable()
    '    Dim lDAO As New ProductUnitDAO
    '    Try
    '        dataTable = Nothing
    '        ProductUnitBuyDAOs = New List(Of ProductUnitDAO)
    '        dataTable = lDAO.GetDataTable(pProductID, 1, pUnitID)
    '        If dataTable.Rows.Count > 0 Then
    '            For Each dr2 As DataRow In dataTable.Rows
    '                lDAO = New ProductUnitDAO()
    '                lDAO.ModeData = DataMode.ModeEdit
    '                lDAO.ID = Int32.Parse(dr2("ID"))
    '                lDAO.RefID = Int32.Parse(dr2("RefID"))
    '                lDAO.SEQ = ConvertNullToZero(dr2("SEQ"))
    '                lDAO.UnitID = ConvertNullToZero(dr2("UnitID"))
    '                lDAO.Rate = ConvertNullToZero(dr2("Rate"))
    '                lDAO.IsInActive = dr2("IsInActive")
    '                lDAO.Remark = ConvertNullToString(dr2("Remark"))
    '                ProductUnitBuyDAOs.Add(lDAO)
    '            Next
    '        End If
    '    Catch e As Exception
    '        Err.Raise(Err.Number, e.Source, "LoadProductUnitBuyDAOS: " & e.Message)
    '    Finally
    '        lDAO = Nothing
    '        dataTable = Nothing
    '    End Try
    'End Sub

    'Public Sub LoadProductUnitSellDAOS(ByVal pProductID As Long, ByVal pUnitID As Long)
    '    Dim dataTable As New DataTable()
    '    Dim lDAO As New ProductUnitDAO
    '    Try
    '        dataTable = Nothing
    '        ProductUnitSellDAOs = New List(Of ProductUnitDAO)
    '        dataTable = lDAO.GetDataTable(pProductID, 2, pUnitID)
    '        If dataTable.Rows.Count > 0 Then
    '            For Each dr2 As DataRow In dataTable.Rows
    '                lDAO = New ProductUnitDAO()
    '                lDAO.ModeData = DataMode.ModeEdit
    '                lDAO.ID = Int32.Parse(dr2("ID"))
    '                lDAO.RefID = Int32.Parse(dr2("RefID"))
    '                lDAO.SEQ = ConvertNullToZero(dr2("SEQ"))
    '                lDAO.UnitID = ConvertNullToZero(dr2("UnitID"))
    '                lDAO.Rate = ConvertNullToZero(dr2("Rate"))
    '                lDAO.IsInActive = dr2("IsInActive")
    '                lDAO.Remark = ConvertNullToString(dr2("Remark"))
    '                ProductUnitSellDAOs.Add(lDAO)
    '            Next
    '        End If
    '    Catch e As Exception
    '        Err.Raise(Err.Number, e.Source, "LoadProductUnitSellDAOS: " & e.Message)
    '    Finally
    '        lDAO = Nothing
    '        dataTable = Nothing
    '    End Try
    'End Sub

    'Private Sub LoadProductLocationSDAO()
    '    Dim dataTable As New DataTable()
    '    Dim lDAO As New ProductLocationSDAO
    '    Try
    '        dataTable = Nothing
    '        ProductLocationSDAOs = New List(Of ProductLocationSDAO)
    '        dataTable = lDAO.GetDataTable(ID)
    '        If dataTable.Rows.Count > 0 Then
    '            For Each dr2 As DataRow In dataTable.Rows
    '                lDAO = New ProductLocationSDAO()
    '                lDAO.ModeData = DataMode.ModeEdit
    '                lDAO.ID = Int32.Parse(dr2("ID"))
    '                lDAO.RefID = Int32.Parse(dr2("RefID"))
    '                lDAO.SEQ = ConvertNullToZero(dr2("SEQ"))
    '                lDAO.LocationID = ConvertNullToZero(dr2("LocationID "))
    '                lDAO.LocationDTLID = ConvertNullToZero(dr2("LocationDTLID"))
    '                lDAO.KeepMax = ConvertNullToZero(dr2("KeepMax"))
    '                lDAO.KeepMin = ConvertNullToZero(dr2("KeepMin"))
    '                lDAO.IsInActive = dr2("IsInActive")

    '                ProductLocationSDAOs.Add(lDAO)
    '            Next
    '        End If
    '    Catch e As Exception
    '        Err.Raise(Err.Number, e.Source, "LoadProductUnitDAOS: " & e.Message)
    '    Finally
    '        lDAO = Nothing
    '        dataTable = Nothing
    '    End Try
    'End Sub

    Private Sub SaveProductLocationS(ByVal tr As SqlTransaction)
        Dim lstrStayIDList As String = ""
        Dim ProductLocat2 As New ProductLocationSDAO
        Try
            If ProductLocationSDAOs Is Nothing Then
                If ModeData = DataMode.ModeDelete Then
                    'Delete all ref
                    ProductLocat2 = New ProductLocationSDAO
                    ProductLocat2.RefID = ID
                    ProductLocat2.DeleteAllData(tr)
                End If
            ElseIf ProductLocationSDAOs.Count = 0 Then

            Else
                For Each ProductLocat As ProductLocationSDAO In ProductLocationSDAOs
                    ProductLocat.RefID = ID
                    If ModeData = DataMode.ModeDelete Then
                        ProductLocat.ModeData = DataMode.ModeDelete
                    ElseIf ModeData = DataMode.ModeNew Then
                        ProductLocat.ModeData = DataMode.ModeNew
                    ElseIf ModeData = DataMode.ModeEdit Then

                    End If

                    If ProductLocat.SaveData(tr) Then
                        If ModeData = DataMode.ModeEdit Then
                            If ProductLocat.ID > 0 Then
                                lstrStayIDList = IIf(lstrStayIDList = "", ProductLocat.ID, lstrStayIDList & "," & ProductLocat.ID)
                            End If
                        End If
                    End If
                Next
                'Delete Remove Item
                ProductLocat2 = New ProductLocationSDAO
                ProductLocat2.RefID = ID
                If ModeData = DataMode.ModeEdit And lstrStayIDList <> "" Then
                    ProductLocat2.DeleteRemoveData(tr, lstrStayIDList)
                End If
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProductDAO.SaveProductLocationS" & e.Message)
        End Try

    End Sub

    Private Sub SaveProductUnitBuyDAOs(ByVal tr As SqlTransaction)
        Dim lstrStayIDList As String = ""
        Dim ProductUnit2 As New ProductUnitDAO
        Try
            If ProductUnitBuyDAOs Is Nothing Then
                If ModeData = DataMode.ModeDelete Then
                    ProductUnit2 = New ProductUnitDAO
                    ProductUnit2.RefID = ID
                    ProductUnit2.BuyOrSell = 1  ' *** set for use buy or sell
                    ProductUnit2.DeleteAllData(tr)
                End If
            ElseIf ProductUnitBuyDAOs.Count = 0 Then

            Else
                For Each ProductUnit As ProductUnitDAO In ProductUnitBuyDAOs
                    ProductUnit.RefID = ID
                    ProductUnit.BuyOrSell = 1  ' *** set for use buy or sell
                    If ModeData = DataMode.ModeDelete Then
                        ProductUnit.ModeData = DataMode.ModeDelete
                    ElseIf ModeData = DataMode.ModeNew Then
                        ProductUnit.ModeData = DataMode.ModeNew
                    ElseIf ModeData = DataMode.ModeEdit Then

                    End If
                    If ProductUnit.SaveData(tr) Then
                        If ModeData = DataMode.ModeEdit Then
                            If ProductUnit.ID > 0 Then
                                lstrStayIDList = IIf(lstrStayIDList = "", ProductUnit.ID, lstrStayIDList & "," & ProductUnit.ID)
                            End If
                        End If
                    End If
                Next
                'Delete Remove Item
                ProductUnit2 = New ProductUnitDAO
                ProductUnit2.RefID = ID
                ProductUnit2.BuyOrSell = 1  ' *** set for use buy or sell
                If ModeData = DataMode.ModeEdit And lstrStayIDList <> "" Then
                    ProductUnit2.DeleteRemoveData(tr, lstrStayIDList)
                End If

            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProductDAO.SaveProductUnitBuyDAOs" & e.Message)
        End Try

    End Sub

    Private Sub SaveProductUnitSellDAOs(ByVal tr As SqlTransaction)
        Dim lstrStayIDList As String = ""
        Dim ProductUnit2 As New ProductUnitDAO
        Try
            If ProductUnitSellDAOs Is Nothing Then
                If ModeData = DataMode.ModeDelete Then
                    ProductUnit2 = New ProductUnitDAO
                    ProductUnit2.RefID = ID
                    ProductUnit2.BuyOrSell = 2  ' *** set for use buy or sell
                    ProductUnit2.DeleteAllData(tr)
                End If
            ElseIf ProductUnitSellDAOs.Count = 0 Then

            Else
                For Each ProductUnit As ProductUnitDAO In ProductUnitSellDAOs
                    ProductUnit.RefID = ID
                    ProductUnit.BuyOrSell = 2  ' *** set for use buy or sell
                    If ModeData = DataMode.ModeDelete Then
                        ProductUnit.ModeData = DataMode.ModeDelete
                    ElseIf ModeData = DataMode.ModeNew Then
                        ProductUnit.ModeData = DataMode.ModeNew
                    ElseIf ModeData = DataMode.ModeEdit Then

                    End If

                    If ProductUnit.SaveData(tr) Then
                        If ModeData = DataMode.ModeEdit Then
                            If ProductUnit.ID > 0 Then
                                lstrStayIDList = IIf(lstrStayIDList = "", ProductUnit.ID, lstrStayIDList & "," & ProductUnit.ID)
                            End If
                        End If

                    End If
                Next
                'Delete Remove Item
                ProductUnit2 = New ProductUnitDAO
                ProductUnit2.RefID = ID
                ProductUnit2.BuyOrSell = 2  ' *** set for use buy or sell
                If ModeData = DataMode.ModeEdit And lstrStayIDList <> "" Then
                    ProductUnit2.DeleteRemoveData(tr, lstrStayIDList)
                End If
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProductDAO.SaveProductUnitSellDAOs" & e.Message)
        End Try

    End Sub


    Public Sub New()

        mCostType = 0
        mTaxType = 0
        mPriceStandard = 0
        mIsSN = 0
        mIsProductSet = False
        mUnitMainID = 0
        mUnitSecondID = 0
        mProductFomulaID = 0
        mProductCategoryID = 0
        mProductBrandID = 0
        mPrice1 = 0
        mPrice2 = 0
        mPrice3 = 0
        mPrice4 = 0
        mPrice5 = 0
        mPrice6 = 0
        mPriceSale = 0
        mProductGroupID = 0
        mProductTypeID = 0
        mProductGroup1 = 0
        mProductGroup2 = 0
        mProductGroup3 = 0
        mProductGroup4 = 0
        mProductGroup5 = 0
        mProductDimension1 = 0
        mProductDimension2 = 0
        mProductDimension3 = 0
        mProductDimension4 = 0
        mProductDimension5 = 0
        mProductUnitBuyDAOs = Nothing
        mProductUnitSellDAOs = Nothing
        mProductLocationSDAOs = Nothing
        mProductImageS = Nothing
        mProductSubstituteDAOs = Nothing
        mProductSetDAOs = Nothing
        mWeight = ""
        mGeneration = ""
        mSize = ""
        mColor = ""
        mCost = 0
        mProductBrand = Nothing
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class


