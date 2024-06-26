﻿Option Explicit On

Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

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
    RefOrderCode = 1024
    ClaimRemark = 2048
    ClaimResult = 4096
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
    'Private mCheckType As Long = 0
    Private mOrderID As List(Of Long)
    Private mIsDelete As Boolean
    Shared mColData As ProColumn
    Shared mIsCheckStock As Boolean
    Shared mIsForCalc As Boolean
    Shared mIsCheckError As Boolean = False
    Private mStockType As String = ""
    Private mCustomerID As Long

    Public Event SelectedProduct(ByRef pProID As Long)

    Public Property CustomerID() As Long
        Get
            Return mCustomerID
        End Get
        Set(ByVal value As Long)
            mCustomerID = value
        End Set
    End Property

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
                                , ByVal pIsDelete As Boolean, ByVal pStockType As String) As Boolean
        Try
            'ControlNavigator1.CustomButtons(0).Enabled = (pMode = DataMode.ModeNew)
            'ControlNavigator1.CustomButtons(1).Enabled = (pMode = DataMode.ModeNew)
            'ControlNavigator1.CustomButtons(2).Enabled = (pMode = DataMode.ModeNew)
            'ControlNavigator1.CustomButtons(3).Enabled = (pMode = DataMode.ModeNew)

            mColData = pColumnData
            mIsReaOnly = pIsReaOnly
            btnFind.Enabled = (pIsReaOnly = False)
            mFormOrder = pFormOrder
            mIsUsePriceSell = pIsUsePriceSell
            mMode = pMode
            mIsCheckError = (pIsReaOnly = False)
            mRefTable = pRefTable
            mOrderID = pRefID


            mStockType = pStockType
            mIsDelete = pIsDelete
            gridView.OptionsView.ShowFooter = pShowFooter
            mIsLoadFromRef = pIsLoadFromRefOrder
            Call LoadData(pRefID, pRefTable, pIsLoadFromRefOrder, pIsDelete, mRefTable)
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

    Public Function ShowControlByDataSource(ByVal pMode As Long, ByVal pProList As List(Of ProductListDAO), ByVal pColumnData As ProColumn, ByVal pIsReaOnly As Boolean _
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

            mStockType = pStockType
            btnFind.Enabled = (pIsReaOnly = False)
            'Copy to BindingSource
            For Each pPro As ProductListDAO In pProList
                rec = New ProductSub
                rec.IsSelect = pPro.IsSelect
                rec.ID = pPro.ID
                rec.RefID = pPro.RefID
                rec.RefOrderCode = pPro.RefOrderCode
                rec.SEQ = pPro.SEQ
                rec.ProductID = pPro.ProductID
                rec.ProductCode = pPro.ProductCode
                rec.ProductName = pPro.ProductName
                rec.ProductNameExt = pPro.ProductNameExt
                rec.LocationDTLID = pPro.LocationDTLID
                rec.LocationDTLID_Old = pPro.LocationDTLID
                rec.ProductListRefID = pPro.ID
                rec.ProductListRefID2 = pPro.ProductListRefID2
                rec.ProductListRefID3 = pPro.ProductListRefID3
                rec.ProductListRefID4 = pPro.ProductListRefID4
                rec.ProductListRefID5 = pPro.ProductListRefID5
                rec.ProductListUnitRef1 = pPro.ProductListUnitRef1
                rec.ProductListUnitRef2 = pPro.ProductListUnitRef2
                rec.ProductListUnitRef3 = pPro.ProductListUnitRef3
                rec.ProductListUnitRef4 = pPro.ProductListUnitRef4
                rec.ProductListUnitRef5 = pPro.ProductListUnitRef5
                rec.ClaimRemark = pPro.ClaimRemark
                rec.ClaimResult = pPro.ClaimResult
                rec.UnitID = pPro.UnitID
                rec.UnitName = pPro.UnitName
                rec.Remark = pPro.Remark
                rec.KeepMin = pPro.KeepMin
                rec.Units = pPro.Units
                rec.AdjustUnit = pPro.AdjustUnit
                rec.RateUnit = pPro.RateUnit
                rec.Price = pPro.Price
                rec.PriceMain = pPro.PriceMain
                rec.Cost = pPro.Cost
                rec.Discount = pPro.Discount
                rec.Total = pPro.Total
                rec.RealPrice = pPro.RealPrice
                If pMode = DataMode.ModeNew Then
                    rec.Units_Old = 0
                    rec.AdjustUnit_Old = 0
                Else
                    rec.Units_Old = pPro.Units
                    rec.AdjustUnit_Old = pPro.AdjustUnit
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
                rec.IsDelete = pPro.IsDelete

                'Load S/N
                rec.IsSN = lclsProduct.IsSerialNumber(pPro.ProductID)
                rec.SNList = pPro.SNList
                If rec.IsSN = 1 Then
                    If IsNothing(rec.SNList) OrElse rec.SNList.Count <= 0 Then
                        dataSN = lclsSN.GetDataTable(pOrderID, rec.ID, rec.ProductID, "", Nothing, False, "", False)
                        rec.SNList = New List(Of SnDAO)
                        For Each dr2 As DataRow In dataSN.Rows
                            lclsSN = New SnDAO
                            lclsSN.SerialNumberID = ConvertNullToZero(dr2("SerialNumberID"))
                            lclsSN.SerialNumberNo = ConvertNullToString(dr2("SerialNumberNo"))
                            lclsSN.Status = ConvertNullToString(dr2("Status"))
                            lclsSN.OrderID = ConvertNullToZero(dr2("OrderID"))
                            lclsSN.ProductID = ConvertNullToZero(dr2("ProductID"))
                            lclsSN.IsDelete = ConvertNullToZero(dr2("IsDelete"))
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
        Dim lIsChangeProduct As Boolean = False, lSNCount As Long = 0, lstrSNNo As String = ""

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
                For Each pProSub As ProductListDAO In bindingSource1
                    If pProSub.ProductID <> 0 And pProSub.IsSelect = True Then
                        lSNCount = 0
                        lDataDAO = New ProductListDAO
                        lDataDAO.ID = pProSub.ID
                        lDataDAO.RefID = pProSub.RefID
                        lDataDAO.ProductID = pProSub.ProductID
                        lDataDAO.ProductCode = pProSub.ProductCode
                        lDataDAO.ProductName = pProSub.ProductName
                        lDataDAO.ProductNameExt = pProSub.ProductNameExt
                        lDataDAO.UnitID = pProSub.UnitID
                        lDataDAO.UnitName = pProSub.UnitName
                        lDataDAO.Units_Old = pProSub.Units_Old
                        lDataDAO.AdjustUnit_Old = pProSub.AdjustUnit_Old
                        lDataDAO.KeepMin = pProSub.KeepMin
                        lDataDAO.Price = pProSub.Price
                        lDataDAO.PriceMain = pProSub.PriceMain
                        lDataDAO.Cost = pProSub.Cost
                        lDataDAO.Discount = pProSub.Discount
                        lDataDAO.Total = pProSub.Total
                        lDataDAO.RealPrice = pProSub.RealPrice
                        lDataDAO.LocationDTLID_Old = pProSub.LocationDTLID_Old
                        lDataDAO.ProductListRefID = pProSub.ProductListRefID
                        lDataDAO.ProductListRefID2 = pProSub.ProductListRefID2
                        lDataDAO.ProductListRefID3 = pProSub.ProductListRefID3
                        lDataDAO.ProductListRefID4 = pProSub.ProductListRefID4
                        lDataDAO.ProductListRefID5 = pProSub.ProductListRefID5
                        lDataDAO.ProductListUnitRef1 = pProSub.ProductListUnitRef1
                        lDataDAO.ProductListUnitRef2 = pProSub.ProductListUnitRef2
                        lDataDAO.ProductListUnitRef3 = pProSub.ProductListUnitRef3
                        lDataDAO.ProductListUnitRef4 = pProSub.ProductListUnitRef4
                        lDataDAO.ProductListUnitRef5 = pProSub.ProductListUnitRef5
                        lDataDAO.ClaimRemark = pProSub.ClaimRemark
                        lDataDAO.ClaimResult = pProSub.ClaimResult
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
                            lDataDAO.LocationDTLID = pProSub.LocationDTLID
                        End If

                        lDataDAO.Remark = pProSub.Remark
                        lDataDAO.SNList = pProSub.SNList
                        lDataDAO.IsSN = pProSub.IsSN
                        lDataDAO.IsShow = pProSub.IsShow
                        lDataDAO.IsMerge = pProSub.IsMerge
                        lDataDAO.IsDelete = pProSub.IsDelete
                        lDataDAO.UnitMainID = pProSub.UnitMainID
                        lDataDAO.AdjustUnit = pProSub.AdjustUnit
                        lDataDAO.RateUnit = pProSub.RateUnit
                        lDataDAO.PriceMain = pProSub.PriceMain
                        If pProSub.UnitID <> pProSub.UnitMainID Then
                            lDataDAO.Units = pProSub.AdjustUnit * pProSub.RateUnit
                            If (lDataDAO.PriceMain * lDataDAO.RateUnit) <> lDataDAO.Price Then 'To adjust price
                                lDataDAO.PriceMain = lDataDAO.Price / lDataDAO.RateUnit
                            End If
                        Else
                            lDataDAO.Units = pProSub.AdjustUnit
                            lDataDAO.PriceMain = lDataDAO.Price 'for if adjust price
                        End If
                        If pProSub.ProductListRefID > 0 Then
                            If pRefTable = MasterType.PurchaseOrder.ToString Then
                                lDataDAO.ProductListUnitRef1 = pProSub.ProductListUnitRef1
                            Else
                                lDataDAO.ProductListUnitRef1 = lDataDAO.Units
                            End If
                        Else
                            lDataDAO.ProductListUnitRef1 = 0
                        End If

                        lDataDAO.SEQ = lRow + 1

                        If pProSub.IsShow = 1 And pProSub.IsDelete = 0 Then
                            mTotal = mTotal + (lDataDAO.AdjustUnit * lDataDAO.Price) - (lDataDAO.Discount * lDataDAO.AdjustUnit)
                        End If

                        If pIsCheckError = True And pProSub.IsShow = 1 And pProSub.IsDelete = 0 Then
                            If lDataDAO.ProductCode = "" Then
                                mIsError = mIsError & vbNewLine & "กรุณาระบุชื่อสินค้า"
                            End If

                            If lDataDAO.UnitName = "" Then
                                mIsError = mIsError & vbNewLine & "กรุณาระบุหน่วย"
                            End If

                            If ConvertNullToZero(lDataDAO.LocationDTLID) <= 0 Then
                                mIsError = mIsError & vbNewLine & "กรุณาระบุตำแหน่งเก็บ"
                            End If

                            '*** Autogen SN
                            If lDataDAO.IsSN = 1 And (pRefTable = MasterType.StockIn.ToString Or pRefTable = MasterType.UpdateStock.ToString _
                                                Or (lIsCheckCreditType = True And mStockType = "I")) Then
                                If IsNothing(lDataDAO.SNList) OrElse lDataDAO.SNList.Count = 0 Then
                                    GenSN(lDataDAO.SNList, mCustomerID, lDataDAO.ProductID, False, -1, lDataDAO.Units, MasterType.StockIn)
                                End If
                            End If



                            'Count SN list exclude delete
                            Dim lSNDup As Boolean = False, lSNList As New List(Of String)
                                If IsNothing(lDataDAO.SNList) = False Then
                                    For Each pRow As SnDAO In lDataDAO.SNList
                                        If pRow.IsDelete = 0 Then
                                            lSNCount = lSNCount + 1
                                            lstrSNNo = pRow.SerialNumberNo

                                            'Check SN no. Duplicate
                                            If lSNList.FindIndex(Function(m As String) m = lstrSNNo) >= 0 Then
                                                lSNDup = True
                                            End If
                                            lSNList.Add(lstrSNNo)
                                        End If
                                    Next
                                End If
                                If lDataDAO.IsSN = 1 And (pRefTable = MasterType.StockIn.ToString Or pRefTable = MasterType.UpdateStock.ToString _
                                                Or (lIsCheckCreditType = True And mStockType = "I")) Then
                                    If IsNothing(lDataDAO.SNList) Then
                                        mIsError = mIsError & vbNewLine & "สินค้า " & lDataDAO.ProductCode & " กรุณาระบุ Serial Number"
                                    ElseIf lSNCount = 0 Then
                                        mIsError = mIsError & vbNewLine & "สินค้า " & lDataDAO.ProductCode & " กรุณาระบุ Serial Number"
                                    ElseIf lDataDAO.SNList.Count > 0 Then
                                        If lSNCount <> Math.Abs(lDataDAO.Units) Then
                                            mIsError = mIsError & vbNewLine & "สินค้า " & lDataDAO.ProductCode & " กรุณาตรวจสอบ Serial Number"
                                        End If
                                    ElseIf lSNDup = True Then
                                        mIsError = mIsError & vbNewLine & "สินค้า " & lDataDAO.ProductCode & " Serial Number ซ้ำ"
                                    Else
                                        Dim lclsSN As New SnDAO
                                        Dim dataSN As New DataTable()
                                        dataSN = lclsSN.GetDataTable(Nothing, 0, lDataDAO.ProductID, "", Nothing, False, "", False)
                                        For Each dr2 As DataRow In dataSN.Rows
                                            lstrSNNo = ConvertNullToString(dr2("SerialNumberNo"))
                                            If lDataDAO.SNList.FindIndex(Function(m As SnDAO) m.SerialNumberNo = lstrSNNo And m.SerialNumberID = 0) >= 0 Then
                                                mIsError = mIsError & vbNewLine & "สินค้า " & lDataDAO.ProductCode & " Serial Number ซ้ำ [" & lstrSNNo & "]"
                                                Exit For
                                            End If
                                        Next
                                    End If
                                ElseIf lDataDAO.IsSN = 1 And (pRefTable = MasterType.SellOrders.ToString Or (lIsCheckCreditType = True And mStockType = "O")) Then

                                    Dim lclsSN As New SnDAO
                                    Dim dataSN As New DataTable()
                                    If IsNothing(lDataDAO.SNList) Then
                                        lDataDAO.SNList = New List(Of SnDAO)
                                    End If
                                    dataSN = lclsSN.GetDataTable(Nothing, 0, lDataDAO.ProductID, "'New'", Nothing, False, lSnIDList, False)
                                    For Each dr2 As DataRow In dataSN.Rows
                                        lstrSNNo = ConvertNullToString(dr2("SerialNumberNo"))
                                        If lSNCount < lDataDAO.Units Then
                                            If lDataDAO.SNList.FindIndex(Function(m As SnDAO) m.SerialNumberNo = lstrSNNo) >= 0 Then
                                                mIsError = mIsError & vbNewLine & "สินค้า " & lDataDAO.ProductCode & " Serial Number ซ้ำ [" & lstrSNNo & "]"
                                            Else
                                                lclsSN = New SnDAO
                                                lclsSN.SerialNumberID = 0
                                                lclsSN.SerialNumberNo = lstrSNNo
                                                lclsSN.Status = "None"
                                                lDataDAO.SNList.Add(lclsSN)
                                                lSNCount = lSNCount + 1
                                                If lSnIDList = "" Then
                                                    lSnIDList = ConvertNullToZero(dr2("SerialNumberID"))
                                                Else
                                                    lSnIDList = lSnIDList & "," & ConvertNullToZero(dr2("SerialNumberID"))
                                                End If
                                            End If
                                        Else
                                            Exit For
                                        End If
                                    Next
                                    If lSNCount <> lDataDAO.Units Then
                                        mIsError = mIsError & vbNewLine & "สินค้า " & lDataDAO.ProductCode & " กรุณาตรวจสอบ Serial Number"
                                    Else
                                        For Each pSN In lDataDAO.SNList
                                            If (pSN.SerialNumberID = 0 Or pMode = DataMode.ModeNew) And pSN.IsDelete = 0 Then
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
                                        lProductListFail.AdjustUnit = lUnitDiff
                                        lProductListFail.IsSelect = True
                                        pProListStockFail.Add(lProductListFail)
                                        info.ErrorType = ErrorType.Critical
                                        mIsError = info.ErrorText
                                    End If
                                End If
                            End If

                            mDataDAOs.Add(lDataDAO)
                        info.ErrorText = ""

                        If mIsError = "" And mMode = DataMode.ModeEdit And mIsCheckError = True Then
                            If lDataDAO.ID = 0 Then
                                mIsError = "PRODUCTCHANGE"
                            ElseIf lDataDAO.LocationDTLID <> lDataDAO.LocationDTLID_Old Then
                                mIsError = "PRODUCTCHANGE"
                            ElseIf lDataDAO.AdjustUnit <> lDataDAO.AdjustUnit_Old Then
                                mIsError = "PRODUCTCHANGE"
                            ElseIf lDataDAO.IsDelete = 1 Then
                                mIsError = "PRODUCTCHANGE"
                            End If
                        End If

                        If pProSub.IsShow = 1 And pProSub.IsDelete = 0 Then
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

    Public Function GetProSubDAOs() As List(Of ProductListDAO)
        Dim lProSubList = New List(Of ProductListDAO)
        Try
            If Not bindingSource1 Is Nothing > 0 Then
                For Each pProSub As ProductListDAO In bindingSource1
                    If pProSub.ProductID <> 0 And pProSub.IsSelect = True And pProSub.IsDelete = 0 Then
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
                         , ByVal pIsDelete As Boolean, ByVal pCheckType As String)
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
                        rec.AdjustUnit_Old = 0
                    Else
                        rec.ID = dr("ID")
                        rec.Units_Old = ConvertNullToZero(dr("Units"))
                        rec.AdjustUnit_Old = ConvertNullToZero(dr("AdjustUnit"))
                    End If
                    If pIsLoadFromRefOrder = True Then
                        rec.ProductListRefID = dr("ID")
                    Else
                        rec.ProductListRefID = 0
                    End If
                    rec.SEQ = ConvertNullToZero(dr("SEQ"))
                    rec.ProductID = ConvertNullToZero(dr("ProductID"))
                    rec.ProductCode = ConvertNullToString(dr("ProductCode"))
                    rec.ProductName = ConvertNullToString(dr("ProductName"))
                    rec.ProductNameExt = ConvertNullToString(dr("ProductNameExt"))
                    rec.LocationDTLID = ConvertNullToZero(dr("LocationDTLID"))
                    rec.LocationDTLID_Old = ConvertNullToZero(dr("LocationDTLID"))
                    rec.UnitID = ConvertNullToZero(dr("UnitID"))
                    rec.UnitName = ConvertNullToString(dr("UnitName"))
                    rec.Remark = ConvertNullToString(dr("Remark"))
                    rec.ClaimRemark = ConvertNullToString(dr("ClaimRemark"))
                    rec.ClaimResult = ConvertNullToString(dr("ClaimResult"))
                    rec.KeepMin = ConvertNullToZero(dr("KeepMin"))
                    rec.Units = ConvertNullToZero(dr("Units"))

                    rec.Price = ConvertNullToZero(dr("Price"))
                    rec.PriceMain = ConvertNullToZero(dr("PriceMain"))
                    rec.Cost = ConvertNullToZero(dr("Cost"))
                    rec.Discount = ConvertNullToZero(dr("Discount"))
                    rec.Total = ConvertNullToZero(dr("Total"))
                    rec.RealPrice = ConvertNullToZero(dr("RealPrice"))
                    rec.IsShow = ConvertNullToZero(dr("IsShow"))
                    rec.IsMerge = ConvertNullToZero(dr("IsMerge"))
                    rec.UnitMainID = ConvertNullToZero(dr("UnitMainID"))
                    rec.AdjustUnit = ConvertNullToZero(dr("AdjustUnit"))
                    rec.RateUnit = ConvertNullToZero(dr("RateUnit"))
                    rec.ModePro = DataMode.ModeEdit
                    rec.IsDelete = ConvertNullToZero(dr("IsDelete"))
                    'Load S/N
                    rec.IsSN = ConvertNullToZero(dr("IsSN"))
                    rec.SNList = New List(Of SnDAO)

                    '*** Stock in not ref sn
                    If pCheckType <> MasterType.StockIn.ToString Or mMode = DataMode.ModeEdit Then
                        dataSN = lclsSN.GetDataTable(pRefID, rec.ID, rec.ProductID, "", Nothing, pIsDelete, "", False)
                        For Each dr2 As DataRow In dataSN.Rows
                            lclsSN = New SnDAO
                            lclsSN.SerialNumberID = ConvertNullToZero(dr2("SerialNumberID"))
                            lclsSN.SerialNumberNo = ConvertNullToString(dr2("SerialNumberNo"))
                            lclsSN.Status = ConvertNullToString(dr2("Status"))
                            lclsSN.OrderID = ConvertNullToZero(dr2("OrderID"))
                            lclsSN.ProductID = ConvertNullToZero(dr2("ProductID"))
                            lclsSN.IsDelete = ConvertNullToZero(dr2("IsDelete"))
                            rec.SNList.Add(lclsSN)
                        Next
                    End If

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
            .Columns("PriceMain").Visible = False
            .Columns("LocationDTLID").Visible = (mColData And ProColumn.LocationDTLID) = ProColumn.LocationDTLID
            .Columns("UnitName").Visible = (mColData And ProColumn.UnitName) = ProColumn.UnitName
            .Columns("Remark").Visible = (mColData And ProColumn.Remark) = ProColumn.Remark
            .Columns("ClaimRemark").Visible = (mColData And ProColumn.ClaimRemark) = ProColumn.ClaimRemark
            .Columns("ClaimResult").Visible = (mColData And ProColumn.ClaimResult) = ProColumn.ClaimResult
            .Columns("KeepMin").Visible = (mColData And ProColumn.KeepMin) = ProColumn.KeepMin
            .Columns("RefOrderCode").Visible = (mColData And ProColumn.RefOrderCode) = ProColumn.RefOrderCode
            If (mColData And ProColumn.Units) = ProColumn.Units Then
                .Columns("AdjustUnit").Visible = True
                .Columns("SN").Visible = True
            Else
                .Columns("AdjustUnit").Visible = False
                .Columns("SN").Visible = False
            End If

            .Columns("Price").Visible = (mColData And ProColumn.Price) = ProColumn.Price
            .Columns("RealPrice").Visible = (mColData And ProColumn.Price) = ProColumn.Price
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
                .Columns("ProductName").OptionsColumn.ReadOnly = True
            End If
            If mMode <> DataMode.ModeNew Then
                Select Case mRefTable
                    Case MasterType.Quotation.ToString, MasterType.Reserve.ToString
                        ''nothing
                    Case Else
                        .Columns("UnitName").OptionsColumn.ReadOnly = True
                        UnitBtn.Buttons(0).Enabled = False
                End Select

                .Columns("LocationDTLID").OptionsColumn.ReadOnly = True
                '.Columns("LocationDTLIDLookUpEdit1").OptionsColumn.ReadOnly = True
                LocationDTLIDLookUpEdit1.ReadOnly = True
            End If
            If mIsLoadFromRef Then
                .Columns("ProductCode").OptionsColumn.ReadOnly = True
                If mRefTable <> MasterType.StockIn.ToString Then
                    If .Columns("LocationDTLID").Visible Then .Columns("LocationDTLID").OptionsColumn.ReadOnly = True
                End If
            End If
            gridView.Columns("IsShow").FilterInfo = New ColumnFilterInfo("[IsShow]=1")
            If mIsDelete = False Then
                gridView.Columns("IsDelete").FilterInfo = New ColumnFilterInfo("[IsDelete]=0")
            End If

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
            End If

            If lstrProductCode <> "" Then
                Return lstrProductCode
            Else
                Dim lfrmFind As New frmFindProduct
                Dim i As Long
                lfrmFind.LookFor = pProductCode
                lfrmFind.Execute(MasterType.Product, mCustomerID)
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
                Dim llngBuyOrSell = IIf(mIsUsePriceSell = True, 2, 1)
                lfrmFind.LookFor = pUnitName
                lfrmFind.Execute(MasterType.UnitBar, lProductID, llngBuyOrSell)

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
                lcls.InitailData(0, mCustomerID, pProCode, "")
            Else
                lcls.InitailData(pllngID, mCustomerID, "", "")
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
                rec.ProductName = lcls.NameThai
                rec.ProductNameExt = ""
                If mIsUsePriceSell = True Then
                    rec.UnitMainID = lcls.UnitMainID
                    rec.Price = lcls.PriceSale
                Else
                    rec.UnitMainID = lcls.UnitMainIDBuy
                    rec.Price = lcls.PriceBuy
                End If
                If mRefTable = MasterType.PurchaseOrder.ToString Then
                    rec.Cost = rec.Price
                Else
                    rec.Cost = lcls.Cost
                End If
                rec.PriceMain = rec.Price
                rec.IsSN = lcls.IsSN
                rec.Remark = ""

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

                If rec.AdjustUnit = 0 Then rec.AdjustUnit = 1
                rec.Units = rec.AdjustUnit * rec.RateUnit
                If rec.ID = 0 Then
                    rec.Units_Old = 0
                    rec.AdjustUnit_Old = 0
                Else
                    rec.Units_Old = rec.Units
                    rec.AdjustUnit_Old = rec.AdjustUnit
                End If
                rec.IsShow = 1
                rec.IsMerge = 0
                rec.IsDelete = 0
                rec.Price = rec.PriceMain * rec.RateUnit
                rec.RealPrice = rec.Price
                If mRefTable = MasterType.StockIn.ToString Then
                    'Set Location
                    Dim lclsProLocat As New ProductLocationSDAO
                    Dim lDataTable As New DataTable
                    lDataTable = lclsProLocat.GetDataTableDTL(rec.ProductID, mRefTable)
                    For Each lDataRow As DataRow In lDataTable.Rows
                        rec.LocationDTLID = lDataRow.Item("LocationDTLID")
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
                            pRec.Units = pRec.AdjustUnit * pRec.RateUnit
                            pRec.Price = pRec.PriceMain * pRec.RateUnit
                        Else
                            Dim rec = New ProductSub
                            rec.UnitID = ConvertNullToZero(dr("UnitID"))
                            rec.UnitName = ConvertNullToString(dr("UnitName"))
                            rec.RateUnit = ConvertNullToZero(dr("Rate"))
                            pRec.Units = pRec.AdjustUnit * pRec.RateUnit
                            pRec.Price = pRec.PriceMain * pRec.RateUnit
                            bindingSource1.Add(rec)
                        End If
                    Else
                        gridView.SetFocusedRowCellValue("UnitID", ConvertNullToZero(dr("UnitID")))
                        gridView.SetFocusedRowCellValue("UnitName", ConvertNullToString(dr("UnitName")))
                        gridView.SetFocusedRowCellValue("RateUnit", ConvertNullToZero(dr("Rate")))
                        gridView.SetFocusedRowCellValue("Units", gridView.GetFocusedRowCellValue("AdjustUnit") * ConvertNullToZero(dr("Rate")))
                        gridView.SetFocusedRowCellValue("Price", gridView.GetFocusedRowCellValue("PriceMain") * ConvertNullToZero(dr("Rate")))
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


    Private Sub CalcToForm()
        If Not mFormOrder Is Nothing Then
            Call mFormOrder.Calculation()
        End If

    End Sub


    Private Sub gridView_ShownEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridView.ShownEditor
        Dim view As GridView = CType(sender, GridView)
        Dim lView As New DataView
        Try
            If view.FocusedColumn.FieldName = "LocationDTLID" AndAlso
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
        ElseIf gridView.FocusedColumn.FieldName = "AdjustUnit" Then
            If ConvertNullToZero(gridView.GetFocusedRowCellValue("IsMerge")) = 1 Then
                e.Valid = False
                e.ErrorText = "กรณีรวมรายการสินค้า ไม่สามารถแก้ไขจำนวนได้"
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

        RaiseEvent SelectedProduct(mlngProductID)
    End Sub

    Private Sub gridView_FocusedColumnChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs) Handles gridView.FocusedColumnChanged
        CalcToForm()
    End Sub

    Private Sub gridView_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gridView.RowUpdated
        CalcToForm()
    End Sub


    Private Sub gridView_RowCountChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridView.RowCountChanged
        If gridView.RowCount > 0 Then
            If Not mFormOrder Is Nothing Then
                Call mFormOrder.Calculation()
            End If
        End If
    End Sub

    Private Sub RepositoryItemButtonSN_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemButtonSN.ButtonClick
        Dim lfrmSN As New frmSN
        lfrmSN.CustomerID = mCustomerID
        Dim rec As ProductSub = TryCast(gridView.GetFocusedRow, ProductSub)
        Dim lclsUnit As New UnitDAO
        If Not rec Is Nothing Then
            If rec.ProductID > 0 And rec.IsSN = 1 Then
                lfrmSN.ProductCodes = rec.ProductCode
                lfrmSN.ProductNames = rec.ProductName
                lfrmSN.UnitNames = rec.UnitName
                lfrmSN.Unit = rec.AdjustUnit
                lfrmSN.UnitMain = rec.Units
                lfrmSN.IsReadOnly = mIsReaOnly
                lfrmSN.ProductIDs = rec.ProductID
                lfrmSN.OrderType = mRefTable
                lfrmSN.StockType = mStockType
                lfrmSN.IsModeDelete = mIsDelete
                lfrmSN.SnList = rec.SNList
                lfrmSN.CustomerID = CustomerID
                If lclsUnit.InitailData(rec.UnitMainID, "") Then
                    lfrmSN.UnitMainNames = lclsUnit.NameThai
                End If

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
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gridView
        view.GridControl.Focus()
        Dim index As Integer = view.FocusedRowHandle
        Dim rec As New ProductSub, rec2 As New ProductSub
        Select Case e.Button.Tag
            Case "Insert"
                bindingSource1.Insert(index, rec)
                gridControl.DataSource = bindingSource1
                gridView.RefreshData()
                gridControl.RefreshDataSource()
            Case "Remove"
                If XtraMessageBox.Show(Me, "ยืนยันการลบรายการสินค้า ใช่หรือไม่", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    If mMode = DataMode.ModeNew Or ConvertNullToZero(gridView.GetRowCellValue(index, "ID")) = 0 Then
                        gridView.DeleteSelectedRows()
                        gridView.RefreshData()
                        gridControl.RefreshDataSource()
                    Else
                        gridView.SetRowCellValue(index, "IsDelete", 1)
                        gridView.RefreshData()
                        gridControl.RefreshDataSource()
                    End If
                End If
            Case "MoveUp"
                If index > 0 Then
                    rec = bindingSource1.Item(index)
                    rec2 = bindingSource1.Item(index - 1)

                    bindingSource1.Item(index) = rec2
                    bindingSource1.Item(index - 1) = rec
                    gridView.RefreshData()
                    gridControl.RefreshDataSource()
                End If
            Case "MoveDown"
                If index < (bindingSource1.Count - 1) Then
                    rec = bindingSource1.Item(index)
                    rec2 = bindingSource1.Item(index + 1)

                    bindingSource1.Item(index) = rec2
                    bindingSource1.Item(index + 1) = rec
                    gridView.RefreshData()
                    gridControl.RefreshDataSource()
                End If

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



    Public Class ProductSub
        Inherits ProductListDAO
        Implements IDXDataErrorInfo

        Public Sub New()
            IsSelect = True
        End Sub

#Region "IDXDataErrorInfo Members"
        Public Sub GetPropertyError(ByVal propertyName As String, ByVal info As ErrorInfo) Implements IDXDataErrorInfo.GetPropertyError

        End Sub

        Public Sub GetError(ByVal info As ErrorInfo) Implements IDXDataErrorInfo.GetError
            Units = RateUnit * AdjustUnit
            'Price = PriceMain * RateUnit
            Total = (AdjustUnit * Price) - (Discount * AdjustUnit)
        End Sub
#End Region

    End Class



    Private Sub RealPriceButtonEdit1_ButtonPressed(sender As Object, e As ButtonPressedEventArgs) Handles RealPriceButtonEdit1.ButtonPressed
        Dim lstrMsg As String
        If e.Button.Index = 0 Then
            lstrMsg = InputBox("ระบุราคาจริง", "ราคาจริง", ConvertNullToString(gridView.GetFocusedRowCellValue("RealPrice"))).Trim
            If IsNumeric(lstrMsg) Then
                gridView.SetFocusedRowCellValue("RealPrice", lstrMsg)
            End If
        End If
    End Sub
End Class
