Option Explicit On
Imports System.Data.SqlClient

Public Class ShopeeImport
    'Implements iImport
    Private mClassName As String = "ShopeeImport"
    Private mPropertyS As List(Of ShopeeProperty)

    Public Property DataDAOs() As List(Of ShopeeProperty)
        Get
            Return mPropertyS
        End Get
        Set(ByVal Value As List(Of ShopeeProperty))
            mPropertyS = Value
        End Set
    End Property

    'Public Sub LoadFileToGrid(ByVal pDataTable As DataTable, ByRef pBindingSource As BindingSource)
    Public Function LoadFileToGrid(ByVal pDataTable As DataTable) As String
        Try
            Dim rec As ShopeeProperty
            Dim lError As String = "", lErrorList As String = "", lSEQ As Long = 1
            mPropertyS = New List(Of ShopeeProperty)

            If pDataTable.Rows.Count > 0 Then
                For Each dr As DataRow In pDataTable.Rows
                    If ConvertNullToString(dr(6)) <> "" Then '*** ExternalCode
                        rec = New ShopeeProperty
                        rec.IsSelect = True  '' 0
                        rec.OrderDate = dr(0)
                        rec.PayBy = ConvertNullToString(dr(1))
                        rec.OrderAmount = ConvertNullToZero(dr(2))
                        rec.OrderDesc = ConvertNullToZero(dr(3))
                        rec.OrderStatus = ConvertNullToString(dr(4))
                        rec.OrderUnit = ConvertNullToZero(dr(5))
                        rec.ExternalCode = ConvertNullToString(dr(6))
                        rec.InternalCode = ConvertNullToString(dr(7))
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

                        mPropertyS.Add(rec)
                        lSEQ = lSEQ + 1
                    End If
                Next
            End If
            Return lErrorList
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mClassName & ".LoadFileToGrid : " & e.Message)
        End Try
    End Function

    'Public Function CheckIsError(ByVal pGrid As DevExpress.XtraGrid.Views.Grid.GridView) As Boolean
    '    Dim info As New ErrorInfo()
    '    Dim lIsError = False
    '    Try
    '        If pGrid.RowCount > 0 Then
    '            For lRow = 0 To pGrid.RowCount - 1
    '                TryCast(pGrid.GetRow(lRow), ProductProperty).GetError(info)
    '                If info.ErrorText <> "" Then
    '                    lIsError = True
    '                End If
    '            Next
    '        End If
    '        Return lIsError
    '    Catch e As Exception
    '        Err.Raise(Err.Number, e.Source, mClassName & ".CheckIsError : " & e.Message)
    '    Finally
    '    End Try
    'End Function

    'Public Function GetDAOFromGrid(ByVal pGrid As DevExpress.XtraGrid.Views.Grid.GridView)
    '    Dim lRow As Long
    '    Dim rec As ProductProperty

    '    GetDAOFromGrid = False
    '    Try
    '        mProductPropertyS = Nothing
    '        mProductPropertyS = New List(Of ProductProperty)
    '        pProgressBar.Position = 0
    '        If pGrid.RowCount > 0 Then
    '            pProgressBar.Properties.Maximum = pGrid.RowCount
    '            For lRow = 0 To pGrid.RowCount
    '                rec = Nothing
    '                rec = TryCast(pGrid.GetRow(lRow), ProductProperty)
    '                If Not rec Is Nothing AndAlso rec.IsSelect = True Then
    '                    mProductPropertyS.Add(rec)
    '                End If
    '                pProgressBar.Position = lRow
    '                'End If
    '            Next
    '        End If
    '    Catch e As Exception
    '        Err.Raise(Err.Number, e.Source, "frmImport.GetDAOFromGrid : " & e.Message)
    '    Finally
    '        rec = Nothing
    '    End Try
    'End Function

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


    Public Function GetPropertyError(ByVal pData As ShopeeProperty) As String
        Dim lError As String = ""
        'If String.IsNullOrEmpty(pData.IsNew) Then
        '    pData.IsNew = "Y" 'Default Y
        'ElseIf pData.IsNew.ToString.Trim <> "Y" And pData.IsNew.ToString.Trim <> "N" Then
        '    lError = lError & vbNewLine & "ข้อมูล IsNew ไม่ถูกต้อง[Y,N]"
        'End If



        Return lError
    End Function

    Public Sub New()
        'mRunningFormatDAO = New RunningFormatDAO
        'mRunningFormatDAO.InitailData(MasterType.Product, Nothing)
    End Sub
End Class



Public Class ShopeeProperty
    'Implements IDXDataErrorInfo
    Private mClassName As String = "ShopeeProperty"

#Region "Property"
    Private mOrderDate As Date
    Private mPayBy As String
    Private mOrderAmount As Decimal
    Private mOrderDesc As String
    Private mOrderStatus As String
    Private mOrderUnit As Decimal
    Private mExternalCode As String
    Private mInternalCode As String

    Dim mIsSelect As Boolean


    Public Property IsSelect() As Boolean
        Get
            Return mIsSelect
        End Get
        Set(ByVal value As Boolean)
            mIsSelect = value
        End Set
    End Property

    Public Property OrderDate() As Date
        Get
            Return mOrderDate
        End Get
        Set(ByVal value As Date)
            mOrderDate = value
        End Set
    End Property

    Public Property PayBy() As String
        Get
            Return mPayBy
        End Get
        Set(ByVal value As String)
            mPayBy = value
        End Set
    End Property

    Public Property OrderAmount() As Decimal
        Get
            Return mOrderAmount
        End Get
        Set(ByVal value As Decimal)
            mOrderAmount = value
        End Set
    End Property

    Public Property OrderDesc() As String
        Get
            Return mOrderDesc
        End Get
        Set(ByVal value As String)
            mOrderDesc = value
        End Set
    End Property

    Public Property OrderStatus() As String
        Get
            Return mOrderStatus
        End Get
        Set(ByVal value As String)
            mOrderStatus = value
        End Set
    End Property

    Public Property OrderUnit() As Decimal
        Get
            Return mOrderUnit
        End Get
        Set(ByVal value As Decimal)
            mOrderUnit = value
        End Set

    End Property

    Public Property ExternalCode() As String
        Get
            Return mExternalCode
        End Get
        Set(ByVal value As String)
            mExternalCode = value
        End Set
    End Property

    Public Property InternalCode() As String
        Get
            Return mInternalCode
        End Get
        Set(ByVal value As String)
            mInternalCode = value
        End Set
    End Property


    ''Hide
    'Public Property UnitMainID() As Long
    '    Get
    '        Return mUnitMainID
    '    End Get
    '    Set(ByVal value As Long)
    '        mUnitMainID = value
    '    End Set
    'End Property



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
            Else
                lclsDAO.ModeData = DataMode.ModeEdit
                lSuccess = lclsDAO.InitailData(ProductID, 0, "", "", ptr)
            End If

            IsSelect = False   'Re verify --> Is success

            If lSuccess = True Then
                lclsDAO.ImportTXID = pImportID
                lclsDAO.Code = Code
                lclsDAO.NameThai = NameThai
                lclsDAO.NameEng = NameEng
                lclsDAO.Remark = Remark
                lclsDAO.CostType = CostType
                lclsDAO.PriceStandard = Price
                lclsDAO.Price1 = Price1
                lclsDAO.Price2 = Price2
                lclsDAO.Price3 = Price3
                lclsDAO.Price4 = Price4
                lclsDAO.Price5 = Price5
                lclsDAO.Price6 = Price6
                lclsDAO.TaxType = False
                lclsDAO.IsSN = IIf(IsSN = "Yes", 1, 0)
                lclsDAO.UnitMainID = UnitMainID
                lclsDAO.UnitSecondID = UnitMainID
                lclsDAO.ProductCategoryID = ProductCategoryID
                lclsDAO.ProductTypeID = ProductTypeID
                lclsDAO.ProductBrandID = ProductBrandID
                lclsDAO.ProductGroupID = ProductGroup1ID
                lclsDAO.ProductDimension1 = ProductDimension1ID
                lclsDAO.ProductLocationSDAOs = GetLocationDTL(ptr)
                lclsDAO.ProductUnitBuyDAOs = GetUnitDAOs()
                lclsDAO.ProductUnitSellDAOs = lclsDAO.ProductUnitBuyDAOs

                IsSelect = lclsDAO.SaveData(ptr)

            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mClassName & ".SaveData : " & e.Message)
        Finally
            lclsDAO = Nothing
        End Try
    End Sub




#End Region


    Public Sub New()

    End Sub
End Class

