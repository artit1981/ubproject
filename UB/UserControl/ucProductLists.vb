Option Explicit On

Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraGrid.Columns

Public Enum ProColumn
    UnitName = 1
    Remark = 2
    Units = 4
    Price = 8
    Total = 16
    LocationDTLID = 32
    Discount = 64
    Cost = 128
    IsSelect = 256
    KeepMin = 512
End Enum

Public Class ucProductLists
    Private mIsError As String
    Private mTotal As Double
    Private mDataDAOs As List(Of ProductListDAO)
    Private mlngProductID As Long
    Private mclone As DataTable
    Private mIsReaOnly As Boolean
    Private mIsLoadFromRef As Boolean
    Private mNotVerifyEditor As Boolean
    Private mFormOrder As frmOrderS
    Private mMode As DataMode
    Private mIsUsePriceSell As Boolean
    Private mRefTable As String
    Private mCheckType As Long = 0
    Private mOrderID As List(Of Long)
    Shared mColData As ProColumn
    Shared mIsCheckStock As Boolean
    Shared mIsForCalc As Boolean
    Shared mIsCheckError As Boolean = False
    Private mStockType As String = ""

    Public Event SelectedProduct(ByRef pProID As Long)

    Public ReadOnly Property IsError() As String
        Get
            Return mIsError
        End Get
    End Property
    Public ReadOnly Property Totals() As Double
        Get
            Return mTotal
        End Get
    End Property


    Public Function ShowControl(ByVal pMode As Long, ByVal pRefID As List(Of Long), ByVal pRefTable As String, ByVal pColumnData As ProColumn _
                                , ByVal pIsReaOnly As Boolean, ByVal pShowFooter As Boolean, ByVal pFormOrder As frmOrderS _
                                , ByVal pIsUsePriceSell As Boolean, ByVal mParentTable As String, ByVal pIsLoadFromRefOrder As Boolean _
                                , ByVal pIsDelete As Boolean, ByVal pCheckType As Long, ByVal pStockType As String) As Boolean
        Try
            mColData = pColumnData
            mIsReaOnly = pIsReaOnly
            mFormOrder = pFormOrder
            mIsUsePriceSell = pIsUsePriceSell
            mMode = pMode
            mIsCheckError = (pIsReaOnly = False)
            mRefTable = pRefTable
            mOrderID = pRefID
            mCheckType = pCheckType
            mStockType = pStockType
            gridView.OptionsView.ShowFooter = pShowFooter
            mIsLoadFromRef = pIsLoadFromRefOrder
            Call LoadData(pRefID, pRefTable, pIsLoadFromRefOrder, pIsDelete, pCheckType)
            If (mColData And ProColumn.LocationDTLID) = ProColumn.LocationDTLID Then
                LoadDataLocationDTL()
            End If
            If mParentTable <> "" Then
                mRefTable = mParentTable
            End If
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucProductLists.ShowControl : " & e.Message)
            Return False
        End Try
    End Function

    Public Function ShowControlByDataSource(ByVal pMode As Long, ByVal pProList As List(Of ProductSubDAO), ByVal pColumnData As ProColumn, ByVal pIsReaOnly As Boolean _
                                            , ByVal pFormOrder As frmOrderS, ByVal pRefTable As String, ByVal pIsUsePriceSell As Boolean _
                                             , ByVal pOrderID As List(Of Long), ByVal pIsLoadFromRefOrder As Boolean, ByVal pIsMakePO As Boolean, ByVal pStockType As String) As Boolean
        Dim rec As ProductSub
        Dim lclsProduct As New ProductDAO
        Dim lclsSN As New SnDAO, dataSN As New DataTable()
        Try
            mMode = pMode
            mColData = pColumnData
            mIsReaOnly = pIsReaOnly
            mFormOrder = pFormOrder
            mIsCheckError = (pIsReaOnly = False)
            mIsUsePriceSell = pIsUsePriceSell
            mRefTable = pRefTable
            mIsLoadFromRef = pIsLoadFromRefOrder
            mOrderID = pOrderID
            bindingSource1.Clear()
            bindingSource1.DataSource = GetType(ProductSub)
            DxErrorProvider1.DataSource = bindingSource1
            DxErrorProvider1.ContainerControl = Me
            mCheckType = 0
            mStockType = pStockType

            'Copy to BindingSource
            For Each pPro As ProductSubDAO In pProList
                rec = New ProductSub
                rec.IsSelect = pPro.IsSelect
                rec.ID = pPro.ID
                rec.SEQ = pPro.SEQ
                rec.ProductID = pPro.ProductID
                rec.ProductCode = pPro.ProductCode
                rec.ProductNames = pPro.ProductNames
                rec.ProductNameExt = pPro.ProductNameExt
                rec.LocationDTLID = pPro.LocationDTLID
                rec.LocationDTLID_Old = pPro.LocationDTLID
                rec.ProductListRefID = pPro.ID
                rec.UnitID = pPro.UnitID
                rec.UnitName = pPro.UnitName
                rec.Remark = pPro.Remark
                rec.KeepMin = pPro.KeepMin
                rec.Units = pPro.Units
                rec.AdjustUnit = pPro.AdjustUnit
                rec.RateUnit = pPro.RateUnit
                rec.Price = pPro.Price
                rec.Cost = pPro.Cost
                rec.Discount = pPro.Discount
                rec.Total = pPro.Total
                If pMode = DataMode.ModeNew Then
                    rec.Units_Old = 0
                Else
                    rec.Units_Old = pPro.Units
                End If

                rec.ModePro = pPro.ModePro
                If pIsLoadFromRefOrder = True Or pIsMakePO = True Then
                    rec.ProductListRefID = pPro.ID
                Else
                    rec.ProductListRefID = 0
                End If
                rec.IsShow = pPro.IsShow
                rec.IsMerge = pPro.IsMerge
                rec.UnitMainID = pPro.UnitMainID
                'Load S/N
                rec.IsSN = lclsProduct.IsSerialNumber(pPro.ProductID)
                rec.SNList = pPro.SNList
                If rec.IsSN = 1 Then
                    If IsNothing(rec.SNList) OrElse rec.SNList.Count <= 0 Then
                        dataSN = lclsSN.GetDataTable(pOrderID, rec.ID, rec.ProductID, "", Nothing, False, "")
                        rec.SNList = New List(Of SnDAO)
                        For Each dr2 As DataRow In dataSN.Rows
                            lclsSN = New SnDAO
                            lclsSN.SerialNumberID = ConvertNullToZero(dr2("SerialNumberID"))
                            lclsSN.SerialNumberNo = ConvertNullToString(dr2("SerialNumberNo"))
                            lclsSN.Status = ConvertNullToString(dr2("Status"))
                            lclsSN.OrderID = ConvertNullToZero(dr2("OrderID"))
                            lclsSN.ProductID = ConvertNullToZero(dr2("ProductID"))
                            rec.SNList.Add(lclsSN)
                        Next
                    End If
                End If

                bindingSource1.Add(rec)
            Next

            gridControl.DataSource = bindingSource1
            GridStyle()
            If (mColData And ProColumn.LocationDTLID) = ProColumn.LocationDTLID Then
                LoadDataLocationDTL()
            End If
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucProductLists.ShowControlByDataSource : " & e.Message)
            Return False
        End Try
    End Function

    Public Function GetDAOs(ByVal pCheckSotck As Boolean, ByVal pIsCheckError As Boolean, ByVal pStockSum As Boolean _
                            , ByRef pProListStockFail As List(Of ProductListDAO), ByVal pIsForCalc As Boolean, ByVal pLocationDtlID As Long _
                            , ByVal pIsSetLocation As Boolean, ByVal pRefTable As String, ByVal pMode As Integer, pStockType As String) As List(Of ProductListDAO)
        Dim lRow As Long
        Dim lDataDAO As ProductListDAO
        Dim info As New ErrorInfo()
        Dim lProductListFail As ProductListDAO
        Dim lUnitDiff As Long
        Dim lSnIDList As String = "" ' กันกรณีขายสินค้าเดี่ยวกันใน 1 บิล จะตัด SN ซ้ำเพราะ DB ยังไม่ Commit
        pProListStockFail = New List(Of ProductListDAO)
        Try
            mDataDAOs = New List(Of ProductListDAO)
            mIsError = ""
            mTotal = 0
            mIsCheckError = pIsCheckError
            mIsCheckStock = pCheckSotck
            mIsForCalc = pIsForCalc
            mNotVerifyEditor = True
            mStockType = pStockType

            Dim lIsCheckCreditType As Boolean = False
            Select Case pRefTable
                Case MasterType.ReduceCredit.ToString, MasterType.ReduceCreditBuy.ToString, MasterType.AddCreditBuy.ToString, MasterType.AddCredit.ToString
                    lIsCheckCreditType = True
            End Select

            If Not bindingSource1 Is Nothing > 0 Then
                lRow = 0
                For Each pProSub As ProductSubDAO In bindingSource1
                    If pProSub.ProductID <> 0 And pProSub.IsSelect = True Then
                        lDataDAO = New ProductListDAO
                        lDataDAO.ID = pProSub.ID
                        lDataDAO.ProductID = pProSub.ProductID
                        lDataDAO.ProductCode = pProSub.ProductCode
                        lDataDAO.ProductName = pProSub.ProductNames
                        lDataDAO.ProductNameExt = pProSub.ProductNameExt
                        lDataDAO.UnitID = pProSub.UnitID
                        lDataDAO.UnitName = pProSub.UnitName
                        lDataDAO.Units_Old = pProSub.Units_Old
                        lDataDAO.KeepMin = pProSub.KeepMin
                        lDataDAO.Price = pProSub.Price
                        lDataDAO.Cost = pProSub.Cost
                        lDataDAO.Discount = pProSub.Discount
                        lDataDAO.Total = pProSub.Total
                        lDataDAO.LocationDTLID_Old = pProSub.LocationDTLID_Old
                        lDataDAO.ProductListRefID = pProSub.ProductListRefID
                        If pLocationDtlID > 0 Then
                            lDataDAO.LocationDTLID = pLocationDtlID
                        ElseIf pIsSetLocation = True Then
                            'Set Location
                            Dim lclsProLocat As New ProductLocationSDAO
                            Dim lDataTable As New DataTable
                            lDataTable = lclsProLocat.GetDataTableDTL(lDataDAO.ProductID, pRefTable)
                            For Each lDataRow As DataRow In lDataTable.Rows
                                lDataDAO.LocationDTLID = lDataRow.Item("LocationDTLID")
                                Exit For
                            Next

                        Else
                            lDataDAO.LocationDTLID = ConvertNullToZero(gridView.GetRowCellValue(lRow, "LocationDTLID"))
                        End If

                        lDataDAO.Remark = pProSub.Remark
                        lDataDAO.SNList = pProSub.SNList
                        lDataDAO.IsSN = pProSub.IsSN
                        lDataDAO.IsShow = pProSub.IsShow
                        lDataDAO.IsMerge = pProSub.IsMerge
                        lDataDAO.UnitMainID = pProSub.UnitMainID
                        lDataDAO.AdjustUnit = pProSub.AdjustUnit
                        lDataDAO.RateUnit = pProSub.RateUnit
                        If pProSub.UnitID <> pProSub.UnitMainID Then
                            lDataDAO.Units = pProSub.AdjustUnit * pProSub.RateUnit
                        Else
                            lDataDAO.Units = pProSub.AdjustUnit
                        End If
                        lDataDAO.SEQ = lRow + 1

                        If pProSub.IsShow = 1 Then
                            mTotal = mTotal + (lDataDAO.Units * lDataDAO.Price) - (lDataDAO.Discount * lDataDAO.Units)
                        End If



                        If pIsCheckError = True And pProSub.IsShow = 1 Then
                            If lDataDAO.ProductCode = "" Then
                                mIsError = mIsError & vbNewLine & "กรุณาระบุชื่อสินค้า"
                            End If

                            If lDataDAO.UnitName = "" Then
                                mIsError = mIsError & vbNewLine & "กรุณาระบุหน่วย"
                            End If

                            If ConvertNullToZero(lDataDAO.LocationDTLID) <= 0 Then
                                mIsError = mIsError & vbNewLine & "กรุณาระบุตำแหน่งเก็บ"
                            End If
                            
                            If lDataDAO.IsSN = 1 And (pRefTable = MasterType.StockIn.ToString Or pRefTable = MasterType.UpdateStock.ToString _
                                                Or (lIsCheckCreditType = True And mStockType = "I")) Then
                                If IsNothing(lDataDAO.SNList) Then
                                    mIsError = mIsError & vbNewLine & "สินค้า " & lDataDAO.ProductCode & " กรุณาระบุ Serial Number"
                                ElseIf lDataDAO.SNList.Count = 0 Then
                                    mIsError = mIsError & vbNewLine & "สินค้า " & lDataDAO.ProductCode & " กรุณาระบุ Serial Number"
                                ElseIf lDataDAO.SNList.Count > 0 Then
                                    If lDataDAO.SNList.Count <> Math.Abs(lDataDAO.Units) Then
                                        mIsError = mIsError & vbNewLine & "สินค้า " & lDataDAO.ProductCode & " กรุณาตรวจสอบ Serial Number"
                                    End If
                                End If

                                'If pRefTable = MasterType.UpdateStock.ToString Then
                                '    If lDataDAO.Units < 0 Then
                                '        mIsError = mIsError & vbNewLine & "สินค้า " & lDataDAO.ProductCode & " รายการปรับยอดสินค้า Serial Number ยังไม่สามารถปรับยอดติดลบได้"
                                '    End If
                                'End If
                            ElseIf lDataDAO.IsSN = 1 And (pRefTable = MasterType.SellOrders.ToString Or (lIsCheckCreditType = True And mStockType = "O")) Then

                                Dim lclsSN As New SnDAO
                                Dim dataSN As New DataTable()
                                If IsNothing(lDataDAO.SNList) Then
                                    lDataDAO.SNList = New List(Of SnDAO)
                                End If
                                dataSN = lclsSN.GetDataTable(Nothing, 0, lDataDAO.ProductID, "'New'", Nothing, False, lSnIDList)
                                For Each dr2 As DataRow In dataSN.Rows
                                    If lDataDAO.SNList.Count < lDataDAO.Units Then
                                        If CheckSN(lDataDAO.SNList, ConvertNullToString(dr2("SerialNumberNo"))) <> "" Then
                                            mIsError = mIsError & vbNewLine & "สินค้า " & lDataDAO.ProductCode & " Serial Number ซ้ำ [" _
                                                & ConvertNullToString(dr2("SerialNumberNo")) & "]"
                                        End If
                                        lclsSN = New SnDAO
                                        lclsSN.SerialNumberID = 0
                                        lclsSN.SerialNumberNo = ConvertNullToString(dr2("SerialNumberNo"))
                                        lclsSN.Status = "None"
                                        lDataDAO.SNList.Add(lclsSN)
                                        If lSnIDList = "" Then
                                            lSnIDList = ConvertNullToZero(dr2("SerialNumberID"))
                                        Else
                                            lSnIDList = lSnIDList & "," & ConvertNullToZero(dr2("SerialNumberID"))
                                        End If
                                    Else
                                        Exit For
                                    End If
                                Next
                                If lDataDAO.SNList.Count <> lDataDAO.Units Then
                                    mIsError = mIsError & vbNewLine & "สินค้า " & lDataDAO.ProductCode & " กรุณาตรวจสอบ Serial Number"
                                Else
                                    For Each pSN In lDataDAO.SNList
                                        If pSN.SerialNumberID = 0 Or pMode = DataMode.ModeNew Then
                                            lclsSN = New SnDAO
                                            If lclsSN.CheckSNIsExist(lDataDAO.ProductID, pSN.SerialNumberNo, "'New'", Nothing) = False Then
                                                mIsError = mIsError & vbNewLine & "SN " & pSN.SerialNumberNo & " โดน Close ไปแล้ว"
                                            End If
                                        End If
                                    Next
                                End If
                            End If


                            If pCheckSotck = True Then
                                If pMode = DataMode.ModeNew Then
                                    lUnitDiff = lDataDAO.Units
                                Else
                                    lUnitDiff = lDataDAO.Units - lDataDAO.Units_Old
                                End If

                                '*** lUnitDiff use 2 way
                                info.ErrorText = CheckStock(lDataDAO.ProductID, lDataDAO.UnitMainID, lDataDAO.LocationDTLID, lUnitDiff, pStockSum, lUnitDiff)

                                If info.ErrorText <> "" Then
                                    lProductListFail = lDataDAO
                                    lProductListFail.Units = lUnitDiff
                                    pProListStockFail.Add(lProductListFail)
                                    info.ErrorType = ErrorType.Critical
                                    mIsError = info.ErrorText
                                End If
                            End If
                        End If

                        mDataDAOs.Add(lDataDAO)
                        info.ErrorText = ""

                        If pProSub.IsShow = 1 Then
                            lRow = lRow + 1
                        End If

                    End If
                Next
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucProductLists.GetDAOs : " & e.Message)
        Finally
            lDataDAO = Nothing
            mIsForCalc = False
        End Try
        Return mDataDAOs
    End Function


    Private Function CheckSN(ByVal pSNList As List(Of SnDAO), ByVal pSNNo As String) As String
        
        CheckSN = ""
        Try

            For Each pSN As SnDAO In pSNList
                If pSNNo = pSN.SerialNumberNo Then
                    Return pSNNo
                End If
            Next

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucProductLists.CheckSN : " & e.Message)
        End Try
    End Function


    Public Function GetProSubDAOs() As List(Of ProductSubDAO)
        Dim lProSubList = New List(Of ProductSubDAO)
        Try
            If Not bindingSource1 Is Nothing > 0 Then
                For Each pProSub As ProductSubDAO In bindingSource1
                    If pProSub.ProductID <> 0 And pProSub.IsSelect = True Then
                        lProSubList.Add(pProSub)
                    End If
                Next
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucProductLists.GetProSubDAOs : " & e.Message)
        Finally

        End Try
        Return lProSubList
    End Function

    Public Sub ClearControl()
        Try
            bindingSource1.Clear()
            bindingSource1.DataSource = GetType(ProductSub)
            gridControl.DataSource = bindingSource1
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucProductLists.ClearAll : " & e.Message)
        End Try
    End Sub

    Private Sub LoadData(ByVal pRefID As List(Of Long), ByVal pRefTable As String, ByVal pIsLoadFromRefOrder As Boolean _
                         , ByVal pIsDelete As Boolean, ByVal pCheckType As Long)
        Dim lcls As New ProductListDAO
        Dim lclsSN As New SnDAO, dataSN As New DataTable()
        Dim dataTable As New DataTable()
        Dim rec As ProductSub
        Try
            bindingSource1 = New BindingSource
            bindingSource1.DataSource = GetType(ProductSub)
            dataTable = lcls.GetDataTable(pRefID, pRefTable, Nothing, pIsLoadFromRefOrder, "", pIsDelete, pCheckType, True)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    rec = New ProductSub
                    rec.IsSelect = True
                    If mMode = DataMode.ModeNew Then
                        rec.ID = 0
                        rec.Units_Old = 0
                    Else
                        rec.ID = dr("ID")
                        rec.Units_Old = ConvertNullToZero(dr("Units"))
                    End If
                    If pIsLoadFromRefOrder = True Then
                        rec.ProductListRefID = dr("ID")
                    Else
                        rec.ProductListRefID = 0
                    End If
                    rec.SEQ = ConvertNullToZero(dr("SEQ"))
                    rec.ProductID = ConvertNullToZero(dr("ProductID"))
                    rec.ProductCode = ConvertNullToString(dr("ProductCode"))
                    rec.ProductNames = ConvertNullToString(dr("ProductName"))
                    rec.ProductNameExt = ConvertNullToString(dr("ProductNameExt"))
                    rec.LocationDTLID = ConvertNullToZero(dr("LocationDTLID"))
                    rec.LocationDTLID_Old = ConvertNullToZero(dr("LocationDTLID"))
                    rec.UnitID = ConvertNullToZero(dr("UnitID"))
                    rec.UnitName = ConvertNullToString(dr("UnitName"))
                    rec.Remark = ConvertNullToString(dr("Remark"))
                    rec.KeepMin = ConvertNullToZero(dr("KeepMin"))
                    rec.Units = ConvertNullToZero(dr("Units"))

                    rec.Price = ConvertNullToZero(dr("Price"))
                    rec.Cost = ConvertNullToZero(dr("Cost"))
                    rec.Discount = ConvertNullToZero(dr("Discount"))
                    rec.Total = ConvertNullToZero(dr("Total"))
                    rec.IsShow = ConvertNullToZero(dr("IsShow"))
                    rec.IsMerge = ConvertNullToZero(dr("IsMerge"))
                    rec.UnitMainID = ConvertNullToZero(dr("UnitMainID"))
                    rec.AdjustUnit = ConvertNullToZero(dr("AdjustUnit"))
                    rec.RateUnit = ConvertNullToZero(dr("RateUnit"))
                    rec.ModePro = DataMode.ModeEdit

                    'Load S/N
                    rec.IsSN = ConvertNullToZero(dr("IsSN"))
                    dataSN = lclsSN.GetDataTable(pRefID, rec.ID, rec.ProductID, "", Nothing, pIsDelete, "")
                    rec.SNList = New List(Of SnDAO)
                    For Each dr2 As DataRow In dataSN.Rows
                        lclsSN = New SnDAO
                        lclsSN.SerialNumberID = ConvertNullToZero(dr2("SerialNumberID"))
                        lclsSN.SerialNumberNo = ConvertNullToString(dr2("SerialNumberNo"))
                        lclsSN.Status = ConvertNullToString(dr2("Status"))
                        lclsSN.OrderID = ConvertNullToZero(dr2("OrderID"))
                        lclsSN.ProductID = ConvertNullToZero(dr2("ProductID"))
                        rec.SNList.Add(lclsSN)
                    Next

                    bindingSource1.Add(rec)
                Next
            End If
            DxErrorProvider1.DataSource = bindingSource1
            DxErrorProvider1.ContainerControl = Me
            gridControl.DataSource = bindingSource1
            GridStyle()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucProductLists.LoadData : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub


    Private Sub GridStyle()
        With gridView
            .Columns("ID").Visible = False
            .Columns("SEQ").Visible = False
            .Columns("ProductID").Visible = False
            .Columns("UnitID").Visible = False
            .Columns("ProductListRefID").Visible = False
            .Columns("LocationDTLID").Visible = (mColData And ProColumn.LocationDTLID) = ProColumn.LocationDTLID
            .Columns("UnitName").Visible = (mColData And ProColumn.UnitName) = ProColumn.UnitName
            .Columns("Remark").Visible = (mColData And ProColumn.Remark) = ProColumn.Remark
            .Columns("KeepMin").Visible = (mColData And ProColumn.KeepMin) = ProColumn.KeepMin
            If (mColData And ProColumn.Units) = ProColumn.Units Then
                .Columns("AdjustUnit").Visible = True
                .Columns("SN").Visible = True
            Else
                .Columns("AdjustUnit").Visible = False
                .Columns("SN").Visible = False
            End If

            .Columns("Price").Visible = (mColData And ProColumn.Price) = ProColumn.Price
            .Columns("Cost").Visible = (mColData And ProColumn.Cost) = ProColumn.Cost
            .Columns("Total").Visible = (mColData And ProColumn.Total) = ProColumn.Total
            .Columns("Discount").Visible = (mColData And ProColumn.Discount) = ProColumn.Discount
            .Columns("IsSelect").Visible = (mColData And ProColumn.IsSelect) = ProColumn.IsSelect
            If mIsReaOnly = True Then
                gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False
                gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False
                If .Columns("LocationDTLID").Visible Then .Columns("LocationDTLID").OptionsColumn.ReadOnly = True
                If .Columns("UnitName").Visible Then .Columns("UnitName").OptionsColumn.ReadOnly = True
                If .Columns("Remark").Visible Then .Columns("Remark").OptionsColumn.ReadOnly = True
                If .Columns("Units").Visible Then .Columns("Units").OptionsColumn.ReadOnly = True
                If .Columns("KeepMin").Visible Then .Columns("KeepMin").OptionsColumn.ReadOnly = True
                If .Columns("Price").Visible Then .Columns("Price").OptionsColumn.ReadOnly = True
                If .Columns("Cost").Visible Then .Columns("Cost").OptionsColumn.ReadOnly = True
                If .Columns("Total").Visible Then .Columns("Total").OptionsColumn.ReadOnly = True
                If .Columns("Discount").Visible Then .Columns("Discount").OptionsColumn.ReadOnly = True
                .Columns("ProductCode").OptionsColumn.ReadOnly = True
                .Columns("ProductNames").OptionsColumn.ReadOnly = True
            End If
            If mMode <> DataMode.ModeNew Then
                .Columns("UnitName").OptionsColumn.ReadOnly = True
            End If
            If mIsLoadFromRef Then
                'Select Case mRefTable
                '    Case MasterType.SellOrders.ToString, MasterType.Borrow.ToString, MasterType.Shiping.ToString, MasterType.Invoice.ToString
                '        If .Columns("Units").Visible Then .Columns("Units").OptionsColumn.ReadOnly = True
                'End Select

                .Columns("ProductCode").OptionsColumn.ReadOnly = True
                If mCheckType <> MasterType.StockIn Then
                    If .Columns("LocationDTLID").Visible Then .Columns("LocationDTLID").OptionsColumn.ReadOnly = True
                End If

            End If
            gridView.Columns("IsShow").FilterInfo = New ColumnFilterInfo("[IsShow]=1  ")
        End With
    End Sub

    Private Function LoadDataProduct(ByVal pProductCode As String, ByVal pAutoAdd As Boolean) As String

        Dim lstrProductCode As String = ""
        LoadDataProduct = ""
        Try
            If pProductCode = "" Then
                lstrProductCode = ""
            Else
                lstrProductCode = LoadDataTableProduct(0, pProductCode, pAutoAdd)
                'If lstrProductCode <> "" Then LoadDataUnit("", True, True)
            End If

            If lstrProductCode <> "" Then
                Return lstrProductCode
            Else
                Dim lfrmFind As New frmFindProduct
                Dim i As Long
                lfrmFind.LookFor = pProductCode
                lfrmFind.Execute(MasterType.Product, gCustomerID)
                If lfrmFind.IsAccept Then
 
                If lfrmFind.GetDataKey.Count <= 0 Then
                    Return ""
                Else
                    For i = 1 To lfrmFind.GetDataKey.Count
                        If ConvertNullToZero(lfrmFind.GetDataKey(i)) = 0 Then
                            Return ""
                        Else
                            If i > 1 Then pAutoAdd = True
                            lstrProductCode = LoadDataTableProduct(ConvertNullToZero(lfrmFind.GetDataKey(i)), "", pAutoAdd)
                                'If lstrProductCode <> "" Then LoadDataUnit("", True, True)
                        End If
                    Next
                    Return lstrProductCode
                    lfrmFind = Nothing
                    End If
                End If
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucProductLists.LoadDataProduct : " & e.Message)
        Finally

        End Try
    End Function

    Private Function LoadDataUnit(ByVal pUnitName As String, ByVal pAutoAdd As Boolean, ByVal pFindFromProid As Boolean) As String
        Dim lProductID As Long
        Dim lstrUnitName As String
        LoadDataUnit = ""
        Try
            Dim rec As ProductSub = TryCast(gridView.GetFocusedRow, ProductSub)
            If rec Is Nothing Then
                Return ""
            Else
                lProductID = rec.ProductID
                If lProductID <= 0 Then
                    Return ""
                End If
            End If

            If pUnitName = "" And pFindFromProid = False Then
                lstrUnitName = ""
            Else
                lstrUnitName = LoadDataTableUnit(0, pUnitName, pAutoAdd, lProductID, rec)
            End If

            Dim lfrmFind As New frmFindData
            If lstrUnitName <> "" Then
                Return lstrUnitName
            ElseIf pFindFromProid = False Then
                lfrmFind.LookFor = pUnitName
                lfrmFind.Execute(MasterType.UnitBar, lProductID)

                If ConvertNullToZero(lfrmFind.LookFor) = 0 Then
                    Return ""
                Else
                    lstrUnitName = LoadDataTableUnit(lfrmFind.LookFor, "", pAutoAdd, lProductID, rec)
                    If lstrUnitName <> "" Then
                        Return lstrUnitName
                    End If
                End If
                lfrmFind = Nothing
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucProductLists.LoadDataUnit : " & e.Message)
        Finally

        End Try
    End Function

    Private Sub LoadDataLocationDTL()
        Dim lcls As New ProductLocationSDAO
        Dim dataTable As New DataTable()

        Try
            dataTable = lcls.GetDataTableDTL(0, "")
            LocationDTLIDLookUpEdit1.DataSource = dataTable
            mclone = dataTable
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucProductLists.LoadDataLocationDTL : " & e.Message)
        Finally
            dataTable = Nothing
            lcls = Nothing
        End Try
    End Sub


    Private Function LoadDataTableProduct(ByVal pllngID As Long, ByVal pProCode As String, ByVal pAutoAdd As Boolean) As String
        Dim lcls As New ProductDAO
        Dim lclsUnit As New ProductUnitDAO
        Dim llngBuyOrSell As Integer = 0
        Dim llIndex As Long
        Dim dataTable As New DataTable()
        LoadDataTableProduct = ""
        Try
            If pProCode <> "" Then
                lcls.InitailData(0, gCustomerID, pProCode, "")
            Else
                lcls.InitailData(pllngID, gCustomerID, "", "")
            End If

            If lcls.ID > 0 Then
                Dim rec As ProductSub
                rec = TryCast(gridView.GetFocusedRow, ProductSub)
                If rec Is Nothing Or pAutoAdd = True Then
                    rec = New ProductSub
                    llIndex = 0
                    rec.ModePro = DataMode.ModeNew
                Else
                    llIndex = 1
                End If
                mlngProductID = lcls.ID
                rec.ProductID = lcls.ID
                rec.ProductCode = lcls.Code
                rec.ProductNames = lcls.NameThai
                rec.ProductNameExt = ""
                rec.UnitMainID = lcls.UnitMainID
                If mIsUsePriceSell = True Then
                    rec.Price = lcls.PriceSale
                Else
                    rec.Price = lcls.PriceBuy
                End If
                If mRefTable = MasterType.PurchaseOrder.ToString Then
                    rec.Cost = rec.Price
                Else
                    rec.Cost = lcls.Cost
                End If
                rec.IsSN = lcls.IsSN
                rec.Remark = ""
                If rec.Units = 0 Then rec.Units = 1
                If rec.ID = 0 Then
                    rec.Units_Old = 0
                Else
                    rec.Units_Old = rec.Units
                End If
                rec.IsShow = 1
                rec.IsMerge = 0

                'Set Unitname
                llngBuyOrSell = IIf(mIsUsePriceSell = True, 2, 1)
                dataTable = lclsUnit.GetDataTable(rec.ProductID, llngBuyOrSell)
                If dataTable.Rows.Count > 0 Then
                    For Each dr As DataRow In dataTable.Rows
                        rec.UnitID = ConvertNullToZero(dr("UnitID"))
                        rec.UnitName = ConvertNullToString(dr("UnitName"))
                        rec.RateUnit = ConvertNullToZero(dr("Rate"))
                        Exit For
                    Next
                End If


                If llIndex = 0 Then
                    bindingSource1.Add(rec)

                End If

                gridControl.DataSource = bindingSource1
                gridView.RefreshData()
                gridControl.RefreshDataSource()
                Return lcls.Code
            Else
                Return ""
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucProductLists.LoadDataTableProduct : " & e.Message)
        Finally
            lcls = Nothing
        End Try

    End Function


    Private Function LoadDataTableUnit(ByVal pllngID As Long, ByVal pUnitName As String, ByVal pAutoAdd As Boolean, ByVal pProductID As Long, ByRef pRec As ProductSub) As String
        Dim lcls As New ProductUnitDAO
        Dim dataTable As New DataTable()
        Dim llngBuyOrSell As Integer

        LoadDataTableUnit = ""
        Try
            llngBuyOrSell = IIf(mIsUsePriceSell = True, 2, 1)
            If pUnitName <> "" Then
                dataTable = lcls.GetDataTable(pProductID, llngBuyOrSell, 0, pUnitName)
            Else
                dataTable = lcls.GetDataTable(pProductID, llngBuyOrSell, pllngID, "")
            End If

            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    If pAutoAdd Then
                        If Not pRec Is Nothing Then
                            pRec.UnitID = ConvertNullToZero(dr("UnitID"))
                            pRec.UnitName = ConvertNullToString(dr("UnitName"))
                            pRec.RateUnit = ConvertNullToZero(dr("Rate"))
                        Else
                            Dim rec = New ProductSub
                            rec.UnitID = ConvertNullToZero(dr("UnitID"))
                            rec.UnitName = ConvertNullToString(dr("UnitName"))
                            rec.RateUnit = ConvertNullToZero(dr("Rate"))
                            bindingSource1.Add(rec)
                        End If
                    Else
                        gridView.SetFocusedRowCellValue("UnitID", ConvertNullToZero(dr("UnitID")))
                        gridView.SetFocusedRowCellValue("UnitName", ConvertNullToString(dr("UnitName")))
                        gridView.SetFocusedRowCellValue("RateUnit", ConvertNullToString(dr("Rate")))
                    End If

                    Return ConvertNullToString(dr("UnitName"))
                    Exit For
                Next
            Else
                Return ""
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucProductLists.LoadDataTableUnit : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Function



    Private Sub gridView_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gridView.CellValueChanged
        If e.Column.FieldName = "ProductID" Then
            mlngProductID = e.Value
            gridView.SetRowCellValue(e.RowHandle, "LocationDTLID", 0)
        End If
        CalcToForm()
    End Sub


    Private Sub gridView_CellValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gridView.CellValueChanging
        Dim lIndex As Long = 0
        If e.Column.FieldName = "IsSelect" Then
            If ConvertNullToZero(gridView.GetRowCellValue(e.RowHandle, "IsMerge")) = 1 Then
                If Not bindingSource1 Is Nothing > 0 Then
                    For Each pProSub As ProductSubDAO In bindingSource1
                        If pProSub.ProductID = ConvertNullToZero(gridView.GetRowCellValue(e.RowHandle, "ProductID")) Then
                            If pProSub.IsShow = 0 Then
                                pProSub.IsSelect = e.Value
                            End If
                        End If
                        lIndex = lIndex + 1
                    Next
                End If
            End If
        End If
    End Sub

    Private Sub CalcToForm()
        If Not mFormOrder Is Nothing Then
            Call mFormOrder.Calculation()
        End If

    End Sub


    Private Sub gridView_ShownEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridView.ShownEditor
        Dim view As GridView = CType(sender, GridView)
        Dim lView As New DataView
        Try
            If view.FocusedColumn.FieldName = "LocationDTLID" AndAlso _
          TypeOf view.ActiveEditor Is LookUpEdit AndAlso mlngProductID > 0 Then
                Dim edit As LookUpEdit = CType(view.ActiveEditor, LookUpEdit)
                lView = New DataView(mclone)
                lView.RowFilter = "[ProductID] = " + mlngProductID.ToString
                edit.Properties.DataSource = lView
                edit.ItemIndex = 0
            End If
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
       
    End Sub


    Private Sub gridView_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gridView.InvalidRowException
        e.ExceptionMode = ExceptionMode.NoAction
    End Sub

    Private Sub gridView_ShowingEditor(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles gridView.ShowingEditor
        If sender.FocusedColumn.FieldName = "ProductCode" Then
            If sender.GetRowCellValue(sender.FocusedRowHandle, "ModePro") = DataMode.ModeEdit Then
                e.Cancel = True
            End If
        End If

    End Sub

    Private Sub gridView_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles gridView.ValidatingEditor

        If mIsCheckError = False Or mIsForCalc = True Then Exit Sub
        If gridView.FocusedColumn.FieldName = "UnitName" Then
            If e.Value = "" Then
                'e.Valid = False
                'e.ErrorText = "กรุณาระบุข้อมูล"
            Else
                Dim lValue As String = LoadDataUnit(e.Value, False, False)
                If lValue = "" Then
                    e.Valid = False
                    e.ErrorText = "ไม่พบข้อมูล"
                Else
                    e.Value = lValue
                End If
            End If

        ElseIf gridView.FocusedColumn.FieldName = "ProductCode" Then
            If e.Value = "" Then
              
            Else
                Dim lValue As String = LoadDataProduct(e.Value, False)
                If lValue = "" Then
                    e.Valid = False
                    e.ErrorText = "ไม่พบข้อมูล"
                Else
                    e.Value = lValue
                End If
            End If

        End If

    End Sub


    Private Sub UnitBtn_ButtonPressed(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles UnitBtn.ButtonPressed
        If mIsReaOnly = True Then
        Else
            LoadDataUnit("", True, False)
        End If
    End Sub

    Private Sub ProductBtn_ButtonPressed(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ProductBtn.ButtonPressed
        If mIsReaOnly = True Or mIsLoadFromRef = True Then
        Else
            LoadDataProduct("", False)
        End If

    End Sub

    Private Sub ProductNameBtn_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ProductNameBtn.ButtonClick
        Dim lstrMsg As String
        Dim rec As ProductSub = TryCast(gridView.GetFocusedRow, ProductSub)
        If Not rec Is Nothing Then
            If rec.ProductID > 0 Then
                lstrMsg = InputBox("ระบุชื่อสินค้าเพิ่มเติม เพื่อใช้สำหรับแสดงในเอกสาร", "ชื่อสินค้า", rec.ProductNameExt).Trim
                If lstrMsg <> "" Then
                    rec.ProductNameExt = lstrMsg
                End If
            End If
        End If
    End Sub

    Private Sub gridView_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged

        Dim View As GridView = sender
        If View.RowCount = 0 Then Exit Sub
        Dim rowHandle As Long = (TryCast(gridControl.MainView, ColumnView)).FocusedRowHandle

        If rowHandle < 0 Then Exit Sub
        mlngProductID = ConvertNullToZero(gridView.GetRowCellValue(rowHandle, "ProductID"))
        If ConvertNullToZero(gridView.GetRowCellValue(rowHandle, "IsMerge")) = 1 Then
            ControlNavigator1.Buttons.Remove.Enabled = False
        Else
            ControlNavigator1.Buttons.Remove.Enabled = True
        End If
        RaiseEvent SelectedProduct(mlngProductID)
    End Sub

    Private Sub gridView_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gridView.RowUpdated
        CalcToForm()
    End Sub

    Public Class ProductSub
        Inherits ProductSubDAO
        Implements IDXDataErrorInfo

        Public Sub New()
            IsSelect = True
        End Sub

#Region "IDXDataErrorInfo Members"
        Public Sub GetPropertyError(ByVal propertyName As String, ByVal info As ErrorInfo) Implements IDXDataErrorInfo.GetPropertyError
            'If mIsForCalc = False Then
            '    If (mIsCheckError And ProductID > 0) Then
            '        If propertyName = "ProductCode" AndAlso String.IsNullOrEmpty(ProductCode) Then
            '            info.ErrorText = String.Format("กรุณาระบุชื่อสินค้า", propertyName)
            '            info.ErrorType = ErrorType.Critical
            '        End If
            '        If propertyName = "UnitName" AndAlso String.IsNullOrEmpty(UnitName) Then
            '            info.ErrorText = String.Format("กรุณาระบุหน่วย", propertyName)
            '            info.ErrorType = ErrorType.Critical
            '        End If
            '        'If propertyName = "Units" AndAlso ConvertNullToZero(Units) <= 0 Then
            '        '    info.ErrorText = String.Format("กรุณาระบุจำนวน", propertyName)
            '        '    info.ErrorType = ErrorType.Critical
            '        'End If
            '        If (mColData And ProColumn.LocationDTLID) = ProColumn.LocationDTLID Then
            '            If propertyName = "LocationDTLID" AndAlso ConvertNullToZero(LocationDTLID) <= 0 Then
            '                info.ErrorText = String.Format("กรุณาระบุตำแหน่งเก็บ", propertyName)
            '                info.ErrorType = ErrorType.Critical
            '            End If
            '        End If
            '    End If
            'End If
        End Sub


        Public Sub GetError(ByVal info As ErrorInfo) Implements IDXDataErrorInfo.GetError
            'Dim propertyInfo As New ErrorInfo()
            'If mIsForCalc = False Then
            '    If (mIsCheckError And ProductID > 0) Then
            '        GetPropertyError("ProductCode", propertyInfo)

            '        If propertyInfo.ErrorText = "" Then
            '            If (mColData And ProColumn.UnitName) = ProColumn.UnitName Then
            '                GetPropertyError("UnitName", propertyInfo)
            '            End If
            '        End If

            '        If propertyInfo.ErrorText = "" Then
            '            If (mColData And ProColumn.LocationDTLID) = ProColumn.LocationDTLID Then
            '                GetPropertyError("LocationDTLID", propertyInfo)
            '            End If
            '        End If
            '        'If propertyInfo.ErrorText = "" Then
            '        '    If (mColData And ProColumn.Units) = ProColumn.Units Then
            '        '        GetPropertyError("Units", propertyInfo)
            '        '    End If
            '        '    'If mIsCheckStock = True And propertyInfo.ErrorText <> "" Then
            '        '    '    info.ErrorText = CheckStock(ProductID, UnitID, LocationDTLID, Units)
            '        '    '    info.ErrorType = ErrorType.Critical
            '        '    '    propertyInfo.ErrorText = info.ErrorText
            '        '    '    propertyInfo.ErrorType = ErrorType.Critical
            '        '    'End If

            '        'End If

            '        If propertyInfo.ErrorText <> "" Then
            '            info.ErrorText = propertyInfo.ErrorText
            '        Else

            '        End If
            '    End If
            'End If
            Total = (Units * Price) - (Discount * Units)

            'If mIsCheckStock = True And IsSelect = True Then
            '    info.ErrorText = CheckStock(ProductID, UnitID, LocationDTLID, Units)
            '    If info.ErrorText <> "" Then info.ErrorType = ErrorType.Warning
            'End If

        End Sub
#End Region

    End Class

    Private Sub gridView_RowCountChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridView.RowCountChanged
        If gridView.RowCount > 0 Then
            If Not mFormOrder Is Nothing Then
                Call mFormOrder.Calculation()
            End If

        End If
    End Sub

    Private Sub RepositoryItemButtonSN_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemButtonSN.ButtonClick
        Dim lfrmSN As New frmSN
        Dim rec As ProductSub = TryCast(gridView.GetFocusedRow, ProductSub)
        If Not rec Is Nothing Then
            If rec.ProductID > 0 And rec.IsSN = 1 Then
                lfrmSN.ProductCodes = rec.ProductCode
                lfrmSN.ProductNames = rec.ProductNames
                lfrmSN.Unit = rec.Units
                lfrmSN.IsReadOnly = mIsReaOnly
                lfrmSN.ProductIDs = rec.ProductID
                lfrmSN.OrderType = mRefTable
                lfrmSN.StockType = mStockType
                lfrmSN.SnList = rec.SNList
                lfrmSN.ShowDialog()
                If mIsReaOnly = False Then
                    rec.SNList = lfrmSN.SnList
                    gridView.SetFocusedRowCellValue("SNList", lfrmSN.SnList)
                End If



            End If
        End If
    End Sub
 
    Private Sub btnFind_Click(sender As System.Object, e As System.EventArgs) Handles btnFind.Click
        LoadDataProduct("", True)
    End Sub

    Private Sub ControlNavigator1_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles ControlNavigator1.ButtonClick
        Select Case e.Button.Tag
            Case "Insert"
                Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gridView
                view.GridControl.Focus()
                Dim index As Integer = view.FocusedRowHandle
                Dim rec As New ProductSub
                bindingSource1.Insert(index, rec)
                gridControl.DataSource = bindingSource1
                gridView.RefreshData()
                gridControl.RefreshDataSource()
        End Select

    End Sub

    Private Sub btnImage_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnImage.ButtonClick
        Dim lfrmView As New frmViewImage
        Dim lclsProduct As ProductDAO
        Dim rec As ProductSub = TryCast(gridView.GetFocusedRow, ProductSub)
        Try
            If Not rec Is Nothing Then
                If rec.ProductID > 0 Then
                    lclsProduct = New ProductDAO
                    lclsProduct.ID = rec.ProductID
                    lfrmView.LoadFrom(lclsProduct.ProductImageS(Nothing))
                    lfrmView.ShowDialog()
                End If
            End If
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try
    End Sub
End Class
