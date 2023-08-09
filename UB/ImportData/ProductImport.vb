Option Explicit On
Imports System.Data.SqlClient

Public Class ProductImport
    'Implements iImport
    Private mClassName As String = "ProductImport"
    Private mRunningFormatDAO As RunningFormatDAO
    Private mProductPropertyS As List(Of ProductProperty)

    Public Property DataDAOs() As List(Of ProductProperty)
        Get
            Return mProductPropertyS
        End Get
        Set(ByVal Value As List(Of ProductProperty))
            mProductPropertyS = Value
        End Set
    End Property

    'Public Sub LoadFileToGrid(ByVal pDataTable As DataTable, ByRef pBindingSource As BindingSource)
    Public Function LoadFileToGrid(ByVal pDataTable As DataTable) As String
        Try
            Dim rec As ProductProperty
            Dim lError As String = "", lErrorList As String = "", lSEQ As Long = 1
            mProductPropertyS = New List(Of ProductProperty)

            If pDataTable.Rows.Count > 0 Then
                For Each dr As DataRow In pDataTable.Rows
                    If ConvertNullToString(dr(1)) <> "" Then
                        rec = New ProductProperty
                        rec.IsSelect = True  '' 0
                        rec.Code = ConvertNullToString(dr(0))
                        rec.NameThai = ConvertNullToString(dr(1))
                        rec.NameEng = ConvertNullToString(dr(2))
                        rec.CostType = ProductCostDAO.CostTypes.Average
                        rec.Price = ConvertNullToZero(dr(3))
                        'rec.IsSN = "No"
                        rec.UnitMain = ConvertNullToString(dr(4), True, 50)

                        rec.ProductCategory = ConvertNullToString(dr(5), True, 50)
                        rec.ProductBrand = ConvertNullToString(dr(6), True, 50)
                        rec.ProductType = ConvertNullToString(dr(7), True, 50)
                        rec.ProductGroup1 = ConvertNullToString(dr(8), True, 50)
                        rec.ProductDimension1 = ConvertNullToString(dr(9), True, 50)
                        rec.LocationMain = ConvertNullToString(dr(10), True, 50)
                        rec.LocationSub = ConvertNullToString(dr(11), True, 50)
                        rec.Weight = ConvertNullToString(dr(12), True, 50)
                        rec.Size = ConvertNullToString(dr(13), True, 50)
                        rec.Generation = ConvertNullToString(dr(14), True, 50)
                        rec.Color = ConvertNullToString(dr(15), True, 50)
                        rec.sku1 = ConvertNullToString(dr(16), True, 50)
                        rec.sku2 = ConvertNullToString(dr(17), True, 50)
                        rec.sku3 = ConvertNullToString(dr(18), True, 50)
                        rec.sku4 = ConvertNullToString(dr(19), True, 50)
                        rec.sku5 = ConvertNullToString(dr(20), True, 50)

                        rec.Remark = ConvertNullToString(dr(21), True, 500)
                        rec.Price1 = ConvertNullToZero(dr(22))
                        rec.Price2 = ConvertNullToZero(dr(23))
                        rec.Price3 = ConvertNullToZero(dr(24))
                        rec.Price4 = ConvertNullToZero(dr(25))
                        rec.Price5 = ConvertNullToZero(dr(26))
                        rec.Price6 = ConvertNullToZero(dr(27))
                        rec.IsNew = ConvertNullToString(dr(28))
                        lError = GetPropertyError(rec)
                        If lError <> "" Then
                            If lErrorList = "" Then
                                lErrorList = "******** Import Error *********"
                                lErrorList = lErrorList & vbNewLine & " Row : " & lSEQ & lError
                            Else
                                lErrorList = lErrorList & vbNewLine & " Row : " & lSEQ & lError
                            End If
                            rec.IsSelect = False
                        End If

                        mProductPropertyS.Add(rec)
                        lSEQ += 1
                    End If
                Next
            End If
            Return lErrorList
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mClassName & ".LoadFileToGrid : " & e.Message)
        End Try
    End Function

    Public Function LoadDataExport() As DataTable
        Try

            Dim lcls As New ProductDAO

            Return lcls.GetDataTableExport(0, True)

            'Dim rec As ProductProperty
            'Dim lError As String = "", lErrorList As String = "", lSEQ As Long = 1
            'mProductPropertyS = New List(Of ProductProperty)


            'If pDataTable.Rows.Count > 0 Then
            '    For Each dr As DataRow In pDataTable.Rows
            '        If ConvertNullToString(dr(1)) <> "" Then
            '            rec = New ProductProperty
            '            rec.IsSelect = True  '' 0
            '            rec.Code = ConvertNullToString(dr(0))
            '            rec.NameThai = ConvertNullToString(dr(1))
            '            rec.NameEng = ConvertNullToString(dr(2))
            '            rec.CostType = ProductCostDAO.CostTypes.Average
            '            rec.Price = ConvertNullToZero(dr(3))
            '            rec.IsSN = "No"
            '            rec.UnitMain = ConvertNullToString(dr(4), True, 50)

            '            rec.ProductCategory = ConvertNullToString(dr(5), True, 50)
            '            rec.ProductBrand = ConvertNullToString(dr(6), True, 50)
            '            rec.ProductType = ConvertNullToString(dr(7), True, 50)
            '            rec.ProductGroup1 = ConvertNullToString(dr(8), True, 50)
            '            rec.ProductDimension1 = ConvertNullToString(dr(9), True, 50)
            '            rec.LocationMain = ConvertNullToString(dr(10), True, 50)
            '            rec.LocationSub = ConvertNullToString(dr(11), True, 50)
            '            rec.Weight = ConvertNullToString(dr(12), True, 50)
            '            rec.Size = ConvertNullToString(dr(13), True, 50)
            '            rec.Generation = ConvertNullToString(dr(14), True, 50)
            '            rec.Color = ConvertNullToString(dr(15), True, 50)
            '            rec.sku1 = ConvertNullToString(dr(16), True, 50)
            '            rec.sku2 = ConvertNullToString(dr(17), True, 50)
            '            rec.sku3 = ConvertNullToString(dr(18), True, 50)
            '            rec.sku4 = ConvertNullToString(dr(19), True, 50)
            '            rec.sku5 = ConvertNullToString(dr(20), True, 50)

            '            rec.Remark = ConvertNullToString(dr(21), True, 500)
            '            rec.Price1 = ConvertNullToZero(dr(22))
            '            rec.Price2 = ConvertNullToZero(dr(23))
            '            rec.Price3 = ConvertNullToZero(dr(24))
            '            rec.Price4 = ConvertNullToZero(dr(25))
            '            rec.Price5 = ConvertNullToZero(dr(26))
            '            rec.Price6 = ConvertNullToZero(dr(27))
            '            rec.IsNew = ConvertNullToString(dr(28))
            '            lError = GetPropertyError(rec)
            '            If lError <> "" Then
            '                If lErrorList = "" Then
            '                    lErrorList = "******** Import Error *********"
            '                    lErrorList = lErrorList & vbNewLine & " Row : " & lSEQ & lError
            '                Else
            '                    lErrorList = lErrorList & vbNewLine & " Row : " & lSEQ & lError
            '                End If
            '                rec.IsSelect = False
            '            End If

            '            mProductPropertyS.Add(rec)
            '            lSEQ += 1
            '        End If
            '    Next
            'End If
            'Return lErrorList
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mClassName & ".LoadFileToGrid : " & e.Message)
        End Try
    End Function

    Public Function ImportData() As Long()
        Dim lRow As Long = 0
        Dim tr As SqlTransaction = Nothing
        Dim lclsLog As New ImportLog
        Dim lImportID As Long
        Dim lCount(1) As Long
        lCount(0) = 0 'All
        lCount(1) = 0 'Success

        Try
            If mProductPropertyS.Count > 0 Then
                tr = gConnection.Connection.BeginTransaction

                'Save Import log
                lclsLog.TableID = MasterType.Product
                Call lclsLog.SaveData(tr)
                lImportID = lclsLog.ImportTXID

                'Begin import
                lCount(0) = mProductPropertyS.Count
                For Each clsProperty As ProductProperty In mProductPropertyS
                    If clsProperty.IsSelect = True Then
                        clsProperty.SaveData(tr, lImportID)
                        If clsProperty.IsSelect = True Then
                            lCount(1) = lCount(1) + 1
                        End If
                    End If

                Next
                InsertActivity(DataMode.ModeImport, MasterType.Product, "", tr)
                tr.Commit()

            End If
            Return lCount
        Catch e As Exception
            tr.Rollback()
            Err.Raise(Err.Number, e.Source, mClassName & ".ImportData : " & e.Message)
        Finally
            lclsLog = Nothing
        End Try
    End Function


#Region "Verify"
    Private Function CheckUnitFromCode(ByVal pCode As String) As Long
        Dim lcls As New UnitDAO

        Try
            If lcls.InitailData(0, pCode) Then
                Return lcls.ID
            Else
                Return 0
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mClassName & ".CheckUnitFromCode : " & e.Message)
        Finally
            lcls = Nothing

        End Try
    End Function

    Private Function CheckBrandfromCode(ByVal pCode As String) As Long
        Dim lcls As New ProductBrandDAO

        Try
            If lcls.InitailData(0, Nothing, pCode) Then
                Return lcls.ID
            Else
                Return 0
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mClassName & ".CheckBrandfromCode : " & e.Message)
        Finally
            lcls = Nothing

        End Try
    End Function

    Private Function CheckTypeFromCode(ByVal pCode As String) As Long
        Dim lcls As New ProductTypeDAO

        Try
            If lcls.InitailData(0, Nothing, pCode) Then
                Return lcls.ID
            Else
                Return 0
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mClassName & ".CheckTypeFromCode : " & e.Message)
        Finally
            lcls = Nothing

        End Try

    End Function

    Private Function CheckProCategFromCode(ByVal pCode As String) As Long
        Dim lcls As New ProductCategoryDAO

        Try
            If lcls.InitailData(0, Nothing, pCode) Then
                Return lcls.ID
            Else
                Return 0
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mClassName & ".CheckProCategFromCode : " & e.Message)
        Finally
            lcls = Nothing

        End Try

    End Function

    Private Function CheckDataMasterFromCode(ByVal pCode As String, ByVal pMasterType As Long) As Long
        Dim lcls As New MasterDAO

        Try
            If lcls.InitailData(0, pMasterType, pCode) Then
                Return lcls.ID
            Else
                Return 0
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mClassName & ".CheckDataMaster : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Function

    Private Function CheckLocationDTL(ByVal pName As String) As Long
        Dim lcls As New LocationDTLDAO

        Try
            If lcls.InitailData(0, pName) Then
                Return lcls.ID
            Else
                Return 0
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mClassName & ".CheckLocationDTL : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Function


    Private Function CheckProCodeCheckExist(ByVal pProCode As String) As Boolean
        Dim lcls As New ProductDAO

        Try
            If pProCode <> "อัตโนมัติ" Then
                lcls.ModeData = DataMode.ModeNew
                lcls.Code = pProCode
                Return lcls.CheckExist()
            Else
                Return False
            End If


        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mClassName & ".CheckProCodeCheckExist : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Function

    Private Function CheckProCodeeExist(ByVal pProCode As String) As Long
        Dim lcls As New ProductDAO

        Try
            If lcls.InitailData(0, 0, pProCode, "") Then
                Return lcls.ID
            Else
                Return 0
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mClassName & ".CheckProNameExist : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Function
#End Region

    Public Function GetPropertyError(ByVal pData As ProductProperty) As String
        Dim lError As String = ""
        If String.IsNullOrEmpty(pData.IsNew) Then
            pData.IsNew = "Y" 'Default Y
        ElseIf pData.IsNew.ToString.Trim <> "Y" And pData.IsNew.ToString.Trim <> "N" Then
            lError = lError & vbNewLine & "ข้อมูล IsNew ไม่ถูกต้อง[Y,N]"
        End If

        If String.IsNullOrEmpty(pData.Code) Then
            lError = lError & vbNewLine & "กรุณาระบุข้อมูลรหัสสินค้า"
        Else
            If pData.IsNew = "Y" Then
                If CheckProCodeCheckExist(pData.Code) Then
                    lError = lError & vbNewLine & "รหัสสินค้าซ้ำ"
                End If
            Else
                pData.ProductID = CheckProCodeeExist(pData.Code)
                If pData.ProductID = 0 Then
                    lError = lError & vbNewLine & "ไม่พบรหัสสินค้า : " & pData.Code
                End If
            End If
        End If

        If String.IsNullOrEmpty(pData.NameThai) And pData.IsNew.ToString.Trim = "Y" Then
            lError = lError & vbNewLine & "กรุณาระบุชื่อสินค้า"
        End If

        If ConvertNullToZero(pData.Price) <= 0 And pData.IsNew.ToString.Trim = "Y" Then
            lError = lError & vbNewLine & "กรุณาระบุราคา"
        End If


        If String.IsNullOrEmpty(pData.IsSN) Then
            pData.IsSN = "No" 'Default No
        End If



        If String.IsNullOrEmpty(pData.UnitMain) And pData.IsNew.ToString.Trim = "Y" Then
            lError = lError & vbNewLine & "กรุณาระบุข้อมูลหน่วยนับหลัก"
        ElseIf String.IsNullOrEmpty(pData.UnitMain) And pData.IsNew.ToString.Trim = "N" Then
            pData.UnitMainID = 0
        Else
            pData.UnitMainID = CheckUnitFromCode(pData.UnitMain)
            If pData.UnitMainID = 0 Then
                lError = lError & vbNewLine & "ไม่พบหน่วยนับหลักในระบบ"
            End If
        End If

        If ConvertNullToString(pData.ProductCategory) <> "" Then
            pData.ProductCategoryID = CheckProCategFromCode(pData.ProductCategory)
            If pData.ProductCategoryID <= 0 Then
                lError = lError & vbNewLine & "ไม่พบหมวดสินค้าในระบบ"
            End If
        Else
            pData.ProductCategoryID = 0
        End If


        If ConvertNullToString(pData.ProductBrand) <> "" Then
            pData.ProductBrandID = CheckBrandfromCode(pData.ProductBrand)
            If pData.ProductBrandID <= 0 Then
                lError = lError & vbNewLine & "ไม่พบยี่ห้อสินค้าในระบบ"
            End If
        Else
            pData.ProductBrandID = 0
        End If

        If ConvertNullToString(pData.ProductType) <> "" Then
            pData.ProductTypeID = CheckTypeFromCode(pData.ProductType)
            If pData.ProductTypeID <= 0 Then
                lError = lError & vbNewLine & "ไม่พบประเภทสินค้าในระบบ"
            End If
        Else
            pData.ProductTypeID = 0
        End If

        If ConvertNullToString(pData.ProductGroup1) <> "" Then
            pData.ProductGroup1ID = CheckDataMasterFromCode(pData.ProductGroup1, MasterType.ProductGroup)
            If pData.ProductGroup1ID <= 0 Then
                lError = lError & vbNewLine & "ไม่พบกลุ่มสินค้าในระบบ"
            End If
        Else
            pData.ProductGroup1ID = 0
        End If


        If ConvertNullToString(pData.ProductDimension1) <> "" Then
            pData.ProductDimension1ID = CheckDataMasterFromCode(pData.ProductDimension1, MasterType.ProductDimension)
            If pData.ProductDimension1ID <= 0 Then
                lError = lError & vbNewLine & "ไม่พบมิติสินค้าในระบบ"
            End If
        Else
            pData.ProductDimension1ID = 0
        End If

        If ConvertNullToString(pData.LocationMain) <> "" Then
            pData.LocationMainID = CheckLocationDTL(pData.LocationMain)
            If pData.LocationMainID <= 0 Then
                lError = lError & vbNewLine & "ไม่พบตำแหน่งเก็บสินค้าในระบบ : " & pData.LocationMain
            End If
        Else
            pData.LocationMainID = 0
        End If

        If ConvertNullToString(pData.LocationSub) <> "" Then
            pData.LocationSubID = CheckLocationDTL(pData.LocationSub)
            If pData.LocationSubID <= 0 Then
                lError = lError & vbNewLine & "ไม่พบตำแหน่งเก็บสินค้าในระบบ : " & pData.LocationSub
            End If
        Else
            pData.LocationSubID = 0
        End If

        Return lError
    End Function

    Public Sub New()
        mRunningFormatDAO = New RunningFormatDAO
        mRunningFormatDAO.InitailData(MasterType.Product, Nothing)
    End Sub
End Class



Public Class ProductProperty
    'Implements IDXDataErrorInfo
    Private mClassName As String = "ProductProperty"

#Region "Property"
    Private mCode As String
    Private mNameThai As String
    Private mNameEng As String
    Private mCostType As ProductCostDAO.CostTypes
    Private mPrice As Decimal
    Private mIsSN As String
    Private mUnitMain As String
    Private mProductCategory As String
    Private mProductBrand As String
    Private mProductType As String
    Private mLocationMain As String
    Private mProductGroup1 As String
    Private mProductDimension1 As String
    Private mRemark As String
    Dim mUnitMainID As Long
    Dim mProductCategoryID As Long
    Dim mProductBrandID As Long
    Dim mProductTypeID As Long
    Dim mProductGroup1ID As Long
    Dim mProductDimension1ID As Long
    Dim mLocationMainID As Long
    Dim mVerifyStep1 As Boolean
    Dim mIsSelect As Boolean
    Dim mPrice1 As Decimal
    Dim mPrice2 As Decimal
    Dim mPrice3 As Decimal
    Dim mPrice4 As Decimal
    Dim mPrice5 As Decimal
    Dim mPrice6 As Decimal
    Dim mIsNew As String
    Dim mProductID As Long
    Dim mLocationSub As String
    Dim mLocationSubID As Long

    Public Property IsSelect() As Boolean
        Get
            Return mIsSelect
        End Get
        Set(ByVal value As Boolean)
            mIsSelect = value
        End Set
    End Property

    Public Property Code() As String
        Get
            Return mCode
        End Get
        Set(ByVal value As String)
            mCode = value
        End Set
    End Property

    Public Property NameThai() As String
        Get
            Return mNameThai
        End Get
        Set(ByVal value As String)
            mNameThai = value
        End Set
    End Property

    Public Property NameEng() As String
        Get
            Return mNameEng
        End Get
        Set(ByVal value As String)
            mNameEng = value
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

    Public Property Price() As Decimal
        Get
            Return mPrice
        End Get
        Set(ByVal value As Decimal)
            mPrice = value
        End Set

    End Property

    Public Property IsSN() As String
        Get
            Return mIsSN
        End Get
        Set(ByVal value As String)
            mIsSN = value
        End Set
    End Property

    Public Property UnitMain() As String
        Get
            Return mUnitMain
        End Get
        Set(ByVal value As String)
            mUnitMain = value
        End Set
    End Property


    Public Property ProductCategory() As String
        Get
            Return mProductCategory
        End Get
        Set(ByVal value As String)
            mProductCategory = value
        End Set
    End Property

    Public Property ProductBrand() As String
        Get
            Return mProductBrand
        End Get
        Set(ByVal value As String)
            mProductBrand = value
        End Set
    End Property

    Public Property ProductType() As String
        Get
            Return mProductType
        End Get
        Set(ByVal value As String)
            mProductType = value
        End Set
    End Property

    Public Property ProductGroup1() As String
        Get
            Return mProductGroup1
        End Get
        Set(ByVal value As String)
            mProductGroup1 = value
        End Set
    End Property
    Public Property ProductDimension1() As String
        Get
            Return mProductDimension1
        End Get
        Set(ByVal value As String)
            mProductDimension1 = value
        End Set
    End Property

    Public Property LocationMain() As String
        Get
            Return mLocationMain
        End Get
        Set(ByVal value As String)
            mLocationMain = value
        End Set
    End Property

    Public Property LocationSub() As String
        Get
            Return mLocationSub
        End Get
        Set(ByVal value As String)
            mLocationSub = value
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


    Public Property IsNew() As String
        Get
            Return mIsNew
        End Get
        Set(ByVal value As String)
            mIsNew = value
        End Set

    End Property

    ''Hide
    Public Property UnitMainID() As Long
        Get
            Return mUnitMainID
        End Get
        Set(ByVal value As Long)
            mUnitMainID = value
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

    Public Property ProductTypeID() As Long
        Get
            Return mProductTypeID
        End Get
        Set(ByVal value As Long)
            mProductTypeID = value
        End Set
    End Property

    Public Property ProductGroup1ID() As Long
        Get
            Return mProductGroup1ID
        End Get
        Set(ByVal value As Long)
            mProductGroup1ID = value
        End Set
    End Property

    Public Property ProductDimension1ID() As Long
        Get
            Return mProductDimension1ID
        End Get
        Set(ByVal value As Long)
            mProductDimension1ID = value
        End Set
    End Property

    Public Property LocationMainID() As Long
        Get
            Return mLocationMainID
        End Get
        Set(ByVal value As Long)
            mLocationMainID = value
        End Set
    End Property

    Public Property LocationSubID() As Long
        Get
            Return mLocationSubID
        End Get
        Set(ByVal value As Long)
            mLocationSubID = value
        End Set
    End Property


    Public Property ProductID() As Long
        Get
            Return mProductID
        End Get
        Set(ByVal value As Long)
            mProductID = value
        End Set
    End Property

    Dim mColor As String = ""
    Public Property Color() As String
        Get
            Return mColor
        End Get
        Set(ByVal value As String)
            mColor = value
        End Set
    End Property
    Dim mGeneration As String = ""
    Public Property Generation() As String
        Get
            Return mGeneration
        End Get
        Set(ByVal value As String)
            mGeneration = value
        End Set
    End Property

    Dim mSize As String = ""
    Public Property Size() As String
        Get
            Return mSize
        End Get
        Set(ByVal value As String)
            mSize = value
        End Set
    End Property
    Dim mWeight As String = ""
    Public Property Weight() As String
        Get
            Return mWeight
        End Get
        Set(ByVal value As String)
            mWeight = value
        End Set

    End Property

    Dim msku1 As String = ""
    Public Property sku1() As String
        Get
            Return msku1
        End Get
        Set(ByVal value As String)
            msku1 = value
        End Set
    End Property

    Dim msku2 As String = ""
    Public Property sku2() As String
        Get
            Return msku2
        End Get
        Set(ByVal value As String)
            msku2 = value
        End Set
    End Property

    Dim msku3 As String = ""
    Public Property sku3() As String
        Get
            Return msku3
        End Get
        Set(ByVal value As String)
            msku3 = value
        End Set
    End Property

    Dim msku4 As String = ""
    Public Property sku4() As String
        Get
            Return msku4
        End Get
        Set(ByVal value As String)
            msku4 = value
        End Set
    End Property

    Dim msku5 As String = ""
    Public Property sku5() As String
        Get
            Return msku5
        End Get
        Set(ByVal value As String)
            msku5 = value
        End Set
    End Property

#End Region



#Region "Save Product"
    Public Sub SaveData(ByRef ptr As SqlTransaction, ByVal pImportID As Long)
        Dim lclsDAO As New ProductDAO
        Dim lSuccess As Boolean = False
        Try
            If IsNew = "Y" Then
                lclsDAO.ModeData = DataMode.ModeNew
                If Code.Trim = "" Then
                    Code = AutoGenCode(MasterType.Product, ptr)
                    lSuccess = True
                Else
                    lSuccess = True
                End If
                lclsDAO.TaxType = False
                lclsDAO.IsSN = IIf(IsSN = "Yes", 1, 0)
                lclsDAO.CostType = CostType
            Else
                lclsDAO.ModeData = DataMode.ModeEdit
                lSuccess = lclsDAO.InitailData(ProductID, 0, "", "", ptr)
            End If

            IsSelect = False   'Re verify --> Is success

            If lSuccess = True Then
                lclsDAO.ImportTXID = pImportID
                lclsDAO.Code = Code
                If NameThai.Trim <> "" Then lclsDAO.NameThai = NameThai
                If NameEng.Trim <> "" Then lclsDAO.NameEng = NameEng
                If Remark.Trim <> "" Then lclsDAO.Remark = Remark

                If Price > 0 Then lclsDAO.PriceStandard = Price
                If Price1 > 0 Then lclsDAO.Price1 = Price1
                If Price2 > 0 Then lclsDAO.Price2 = Price2
                If Price3 > 0 Then lclsDAO.Price3 = Price3
                If Price4 > 0 Then lclsDAO.Price4 = Price4
                If Price5 > 0 Then lclsDAO.Price5 = Price5
                If Price6 > 0 Then lclsDAO.Price6 = Price6

                If UnitMainID > 0 Then lclsDAO.UnitMainID = UnitMainID
                If UnitMainID > 0 Then lclsDAO.UnitMainIDBuy = UnitMainID
                If UnitMainID > 0 Then lclsDAO.UnitSecondID = UnitMainID
                If ProductCategoryID > 0 Then lclsDAO.ProductCategoryID = ProductCategoryID
                If ProductTypeID > 0 Then lclsDAO.ProductTypeID = ProductTypeID
                If ProductBrandID > 0 Then lclsDAO.ProductBrandID = ProductBrandID
                If ProductGroup1ID > 0 Then lclsDAO.ProductGroupID = ProductGroup1ID
                If ProductDimension1ID > 0 Then lclsDAO.ProductDimension1 = ProductDimension1ID
                lclsDAO.ProductLocationSDAOs = GetLocationDTL(ptr)
                lclsDAO.ProductUnitBuyDAOs = GetUnitDAOs()
                lclsDAO.ProductUnitSellDAOs = lclsDAO.ProductUnitBuyDAOs

                If Weight.Trim <> "" Then lclsDAO.Weight = Weight
                If Size.Trim <> "" Then lclsDAO.Size = Size
                If Generation.Trim <> "" Then lclsDAO.Generation = Generation
                If Color.Trim <> "" Then lclsDAO.Color = Color

                If sku1.Trim <> "" Then lclsDAO.sku1 = sku1
                If sku2.Trim <> "" Then lclsDAO.sku2 = sku2
                If sku3.Trim <> "" Then lclsDAO.sku3 = sku3
                If sku4.Trim <> "" Then lclsDAO.sku4 = sku4
                If sku5.Trim <> "" Then lclsDAO.sku5 = sku5

                IsSelect = lclsDAO.SaveData(ptr)

            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mClassName & ".SaveData : " & e.Message)
        Finally
            lclsDAO = Nothing
        End Try
    End Sub

    Private Function GetLocationDTL(ByRef ptr As SqlTransaction) As List(Of ProductLocationSDAO)
        Dim lDataDAOs = New List(Of ProductLocationSDAO)
        Dim lDataDAO As ProductLocationSDAO
        Dim lLocationDTL As LocationDTLDAO
        Try

            If LocationMainID > 0 Then
                lDataDAO = New ProductLocationSDAO
                lLocationDTL = New LocationDTLDAO
                lDataDAO.ID = 0
                lDataDAO.SEQ = 1
                If lLocationDTL.InitailData(LocationMainID, , ptr) Then
                    lDataDAO.LocationID = lLocationDTL.RefID
                End If
                lDataDAO.LocationDTLID = LocationMainID
                lDataDAO.KeepMax = 0
                lDataDAO.KeepMin = 0
                lDataDAO.IsMain = "Y"
                lDataDAO.IsInActive = False
                lDataDAOs.Add(lDataDAO)
            End If

            If LocationSubID > 0 Then
                lDataDAO = New ProductLocationSDAO
                lLocationDTL = New LocationDTLDAO
                lDataDAO.ID = 0
                lDataDAO.SEQ = 2
                If lLocationDTL.InitailData(LocationSubID, , ptr) Then
                    lDataDAO.LocationID = lLocationDTL.RefID
                End If
                lDataDAO.LocationDTLID = LocationSubID
                lDataDAO.KeepMax = 0
                lDataDAO.KeepMin = 0
                lDataDAO.IsMain = 1
                lDataDAO.IsInActive = False
                lDataDAOs.Add(lDataDAO)
            End If
            Return lDataDAOs
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mClassName & ".GetLocationDTL : " & e.Message)
        Finally
            lDataDAO = Nothing
            lLocationDTL = Nothing

        End Try

    End Function


    Public Function GetUnitDAOs() As List(Of ProductUnitDAO)
        Dim lUnitDAOs = New List(Of ProductUnitDAO)
        Dim lDataDAO As ProductUnitDAO
        Try
            If UnitMainID > 0 Then
                lDataDAO = New ProductUnitDAO
                lDataDAO.ID = 0
                lDataDAO.UnitID = UnitMainID
                lDataDAO.SEQ = 1
                lDataDAO.Rate = 1
                lDataDAO.IsInActive = False
                lDataDAO.Remark = ""
                lUnitDAOs.Add(lDataDAO)
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mClassName & ".GetUnitDAOs : " & e.Message)
        Finally
            lDataDAO = Nothing
        End Try
        Return lUnitDAOs
    End Function

#End Region


    Public Sub New()
        mVerifyStep1 = False
        mIsSelect = True
        mCode = ""
        mNameThai = ""
        mNameEng = ""
        mCostType = ProductCostDAO.CostTypes.Average
        mPrice = 0
        mIsSN = ""
        mUnitMain = ""
        mProductCategory = ""
        mProductBrand = ""
        mProductType = ""
        mLocationMain = ""
        mLocationSub = ""
        mProductGroup1 = ""
        mProductDimension1 = ""
        mRemark = ""
        mUnitMainID = 0
        mProductCategoryID = 0
        mProductBrandID = 0
        mProductTypeID = 0
        mProductGroup1ID = 0
        mProductDimension1ID = 0
        mLocationMainID = 0
        mLocationSubID = 0
        mIsNew = "Y"
        mProductID = 0
    End Sub
End Class

