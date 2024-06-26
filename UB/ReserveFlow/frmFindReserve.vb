﻿Imports DevExpress.XtraEditors

Public Class frmFindReserve

#Region "Property"
    Private Const mFormName As String = "frmFindReserve"
    Private mOrderDate As Date
    Private mProductSubList As List(Of ProductListDAO)
    Private bindingOrder As BindingSource
    Private mIsAccept As Boolean = False
    Private mFormLoad As Boolean
    Private mOrderIDList As List(Of Long)

    Public ReadOnly Property IsAccept() As Boolean
        Get
            Return mIsAccept
        End Get
    End Property

    Public WriteOnly Property OrderDate() As Date
        Set(ByVal value As Date)
            mOrderDate = value
        End Set
    End Property

#End Region

#Region "Load All Order"
    Private Function LoadOrderByCondition() As Boolean
        Try
            bindingOrder = Nothing
            bindingOrder = New BindingSource
            LoadOrder()
            GridView.OptionsView.ShowFooter = False
            GridControl.DataSource = bindingOrder
            GridStyle()

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".LoadOrderByCondition : " & e.Message)
        Finally

        End Try
    End Function

    Private Sub GridStyle()
        With GridView
            .Columns("ID").Visible = False
            .Columns("CusName").Visible = True
            .Columns("EMPNAME").Visible = True
            .Columns("IsSelect").Visible = True
            .Columns("GrandTotal").Visible = True
            .Columns("OrderCode").Visible = True
            .Columns("BillTotal").Visible = False
            .Columns("BillType").Visible = False
            .Columns("Remark").Visible = True
            .Columns("InvoiceSuplierID").Visible = False
        End With

    End Sub


    Private Function LoadOrder() As Boolean
        Dim lcls As New OrderSDAO
        Dim dataTable As New DataTable()
        Dim SQL As String
        Dim rec As SubOrder
        Try

            SQL = " AND Orders.OrderDate Between '" & formatSQLDate(DateFrom.EditValue) & "' AND '" & formatSQLDate(DateTo.EditValue) & "'"
            SQL &= " AND Orders.MakePOStatus in('Ordering','Waiting') "
            'SQL &= " AND Orders.OrderID in ( "
            'SQL &= "       select RefID from ProductList where RefTable='Reserve'  and IsDelete =0"
            'SQL &= "            AND ProductList.ProductListID not in( select p2.ProductListRefID from ProductList p2 "
            'SQL &= "            WHERE p2.IsDelete =0  "
            'SQL &= "            AND p2.RefTable in('PurchaseOrder','CancelPO' ) and p2.ProductListRefID > 0)"
            'SQL &= "   )     "

            lcls.TableID = MasterType.Reserve
            dataTable = lcls.GetDataTableForCombo(MasterType.Reserve, MasterType.Reserve, 0, DateTo.EditValue, False, SQL)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    rec = New SubOrder
                    rec.IsSelect = False
                    rec.OrderID = dr("ID")
                    rec.OrderDate = dr("OrderDate")
                    rec.OrderCode = ConvertNullToString(dr("Code"))
                    rec.EmpName = ConvertNullToString(dr("EMPNAME"))
                    rec.CusName = ConvertNullToString(dr("Customer"))
                    rec.InvoiceSuplierID = ConvertNullToString(dr("InvoiceSuplierID"))
                    rec.GrandTotal = ConvertNullToZero(dr("GrandTotal"))
                    rec.CustomerID = ConvertNullToZero(dr("CustomerID"))
                    rec.BillTotal = rec.GrandTotal
                    rec.TableID = MasterType.Reserve
                    bindingOrder.Add(rec)
                Next
                Return True
            Else
                Return False
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".LoadOrder : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Function


    Private Sub GetProList()
        Dim lProductSubList As New List(Of ProductListDAO)
        Dim rec As New ProductListDAO, lIndex As Long, llngProID As Long, lIsGroupDupProduct As Integer, lUnitID As Long
        Dim lRefOrderID As Long, lCanNotMerge As Boolean = False
        Try
            mOrderIDList = New List(Of Long)
            mProductSubList = New List(Of ProductListDAO)
            lProductSubList = UcProductLists1.GetDAOs(False, False, False, Nothing, False, 0, False, "", DataMode.ModeNew, "")
            lProductSubList.Sort(Function(x, y) x.RefID.CompareTo(y.RefID))

            For Each pProLIst As ProductListDAO In lProductSubList
                llngProID = pProLIst.ProductID
                lUnitID = pProLIst.UnitID
                lIndex = mProductSubList.FindIndex(Function(m As ProductListDAO) m.ProductID = llngProID And m.IsShow = 1 And m.UnitID = lUnitID)
                If lIndex < 0 Or lIsGroupDupProduct = 1 Or pProLIst.IsShow = 0 Or lCanNotMerge = True Then
                    rec = New ProductListDAO
                    rec.IsSelect = True
                    rec.ID = pProLIst.ID
                    rec.SEQ = 0
                    rec.IsSN = pProLIst.IsSN
                    rec.ProductID = pProLIst.ProductID
                    rec.ProductCode = pProLIst.ProductCode
                    rec.ProductName = pProLIst.ProductName
                    rec.ProductNameExt = pProLIst.ProductNameExt
                    rec.LocationDTLID = pProLIst.LocationDTLID
                    rec.UnitID = pProLIst.UnitID
                    rec.UnitName = pProLIst.UnitName
                    rec.Remark = pProLIst.Remark
                    rec.KeepMin = pProLIst.KeepMin
                    rec.Units = pProLIst.Units
                    rec.Price = pProLIst.Price
                    rec.RealPrice = pProLIst.RealPrice
                    rec.PriceMain = pProLIst.PriceMain
                    rec.Cost = pProLIst.Cost
                    rec.Discount = pProLIst.Discount
                    rec.Total = pProLIst.Total
                    rec.ModePro = DataMode.ModeNew
                    rec.IsShow = pProLIst.IsShow
                    rec.SNList = pProLIst.SNList
                    rec.UnitMainID = pProLIst.UnitMainID
                    rec.AdjustUnit = pProLIst.AdjustUnit
                    rec.RateUnit = pProLIst.RateUnit
                    rec.IsMerge = 0
                    rec.ProductListRefID = pProLIst.ID
                    rec.ProductListRefID2 = 0
                    rec.ProductListRefID3 = 0
                    rec.ProductListRefID4 = 0
                    rec.ProductListRefID5 = 0
                    rec.ProductListUnitRef1 = pProLIst.Units
                    rec.ProductListUnitRef2 = 0
                    rec.ProductListUnitRef3 = 0
                    rec.ProductListUnitRef4 = 0
                    rec.ProductListUnitRef5 = 0
                    mProductSubList.Add(rec)
                    lRefOrderID = pProLIst.RefID
                    If mOrderIDList.FindIndex(Function(m As Long) m = lRefOrderID) < 0 Then
                        mOrderIDList.Add(lRefOrderID)
                    End If
                Else
                    If lIsGroupDupProduct = 0 Then
                        If XtraMessageBox.Show(Me, "มีข้อมูลสินค้าซ้ำต้องการรวมรายการหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                            lIsGroupDupProduct = 2
                        Else
                            lIsGroupDupProduct = 1
                            rec = New ProductListDAO
                            rec.IsSelect = True
                            rec.ID = pProLIst.ID
                            rec.SEQ = 0
                            rec.IsSN = pProLIst.IsSN
                            rec.SNList = pProLIst.SNList
                            rec.ProductID = pProLIst.ProductID
                            rec.ProductCode = pProLIst.ProductCode
                            rec.ProductName = pProLIst.ProductName
                            rec.ProductNameExt = pProLIst.ProductNameExt
                            rec.LocationDTLID = pProLIst.LocationDTLID
                            rec.UnitID = pProLIst.UnitID
                            rec.UnitName = pProLIst.UnitName
                            rec.Remark = pProLIst.Remark
                            rec.KeepMin = pProLIst.KeepMin
                            rec.Units = pProLIst.Units
                            rec.Price = pProLIst.Price
                            rec.RealPrice = pProLIst.RealPrice
                            rec.PriceMain = pProLIst.PriceMain
                            rec.Cost = pProLIst.Cost
                            rec.Discount = pProLIst.Discount
                            rec.Total = pProLIst.Total
                            rec.UnitMainID = pProLIst.UnitMainID
                            rec.AdjustUnit = pProLIst.AdjustUnit
                            rec.RateUnit = pProLIst.RateUnit
                            rec.ModePro = DataMode.ModeNew
                            rec.IsShow = 1
                            rec.IsMerge = 0
                            rec.ProductListRefID = pProLIst.ID
                            rec.ProductListRefID2 = 0
                            rec.ProductListRefID3 = 0
                            rec.ProductListRefID4 = 0
                            rec.ProductListRefID5 = 0
                            rec.ProductListUnitRef1 = pProLIst.Units
                            rec.ProductListUnitRef2 = 0
                            rec.ProductListUnitRef3 = 0
                            rec.ProductListUnitRef4 = 0
                            rec.ProductListUnitRef5 = 0
                            mProductSubList.Add(rec)
                            lRefOrderID = pProLIst.RefID
                            If mOrderIDList.FindIndex(Function(m As Long) m = lRefOrderID) < 0 Then
                                mOrderIDList.Add(lRefOrderID)
                            End If
                        End If
                    End If
                    If lIsGroupDupProduct = 2 Then
                        mProductSubList.Item(lIndex).Units = mProductSubList.Item(lIndex).Units + pProLIst.Units
                        mProductSubList.Item(lIndex).AdjustUnit = mProductSubList.Item(lIndex).AdjustUnit + pProLIst.AdjustUnit
                        mProductSubList.Item(lIndex).Discount = mProductSubList.Item(lIndex).Discount + pProLIst.Discount
                        mProductSubList.Item(lIndex).Total = mProductSubList.Item(lIndex).Total + pProLIst.Total
                        If IsNothing(pProLIst.SNList) = False Then
                            For Each pSN As SnDAO In pProLIst.SNList
                                mProductSubList.Item(lIndex).SNList.Add(pSN)
                            Next
                        End If

                        mProductSubList.Item(lIndex).IsMerge = 1
                        If mProductSubList.Item(lIndex).ProductListRefID2 = 0 Then
                            mProductSubList.Item(lIndex).ProductListRefID2 = pProLIst.ID
                            mProductSubList.Item(lIndex).ProductListUnitRef2 = pProLIst.Units
                        ElseIf mProductSubList.Item(lIndex).ProductListRefID3 = 0 Then
                            mProductSubList.Item(lIndex).ProductListRefID3 = pProLIst.ID
                            mProductSubList.Item(lIndex).ProductListUnitRef3 = pProLIst.Units
                        ElseIf mProductSubList.Item(lIndex).ProductListRefID4 = 0 Then
                            mProductSubList.Item(lIndex).ProductListRefID4 = pProLIst.ID
                            mProductSubList.Item(lIndex).ProductListUnitRef4 = pProLIst.Units
                        Else
                            mProductSubList.Item(lIndex).ProductListRefID5 = pProLIst.ID
                            mProductSubList.Item(lIndex).ProductListUnitRef5 = pProLIst.Units
                            lCanNotMerge = True   'Ref slot full
                        End If
                        lRefOrderID = pProLIst.RefID
                        If mOrderIDList.FindIndex(Function(m As Long) m = lRefOrderID) < 0 Then
                            mOrderIDList.Add(lRefOrderID)
                        End If

                    End If
                End If
            Next

            'ReCalc Price
            Dim lPrice As Decimal = 0
            If mProductSubList.Count > 0 Then
                For Each pProSub In mProductSubList
                    lPrice = LoadlastPrice(pProSub.ProductID, False)
                    pProSub.Price = lPrice
                    If pProSub.UnitID <> pProSub.UnitMainID Then
                        pProSub.PriceMain = lPrice / pProSub.RateUnit
                    Else
                        pProSub.PriceMain = lPrice
                    End If
                Next
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".GetProList : " & e.Message)
        Finally

        End Try
    End Sub


#End Region


    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Try
            LoadOrderByCondition()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try
    End Sub

    Private Sub frmFindOrder_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyData = Keys.Escape Then
            mIsAccept = False
            Me.Close()
        End If
    End Sub

    Private Sub frmFindOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mFormLoad = True
        DateFrom.EditValue = DateAdd(DateInterval.Month, -3, GetCurrentDate(Nothing))
        DateTo.EditValue = GetCurrentDate(Nothing)
        Me.Text = "สร้างใบสั่งซื้อ"


        SetSearchLookAgency(cboCustomerID)
        LoadOrderByCondition()
        mFormLoad = False
    End Sub

    Private Sub GridView_CellValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView.CellValueChanging

        If e.Column.FieldName = "IsSelect" Then
            ShowProgress(True, "Loading...")
            LoadProListData(e.RowHandle, e.Value)
            ShowProgress(False, "")
        End If

    End Sub

    Private Sub LoadProListData(ByVal pIndex As Long, ByVal pIsSelect As Boolean)
        Dim lcls As New ProductListDAO
        'Dim lclsSN As New SnDAO, dataSN As New DataTable()
        Dim dataTable As New DataTable()
        Dim lProList As New List(Of ProductListDAO)
        Dim rec As New ProductListDAO, lIndex As Long = 0, lToSelect As Boolean = False
        Dim lSnIndex As Long = 0, lNotRefUnit As Long = 0, lEachUnit As Long = 0

        Try
            mOrderIDList = New List(Of Long)

            If Not bindingOrder Is Nothing Then
                'mdtCus.Rows.Clear()
                For Each pOrder As SubOrder In bindingOrder
                    lToSelect = False ''Reset
                    If pIndex = lIndex And pIsSelect = True Then
                        lToSelect = True
                    ElseIf pIndex = lIndex And pIsSelect = False Then
                        lToSelect = False
                    ElseIf pOrder.IsSelect = True Then
                        lToSelect = True
                    End If

                    If lToSelect = True Then
                        mOrderIDList.Add(pOrder.OrderID)
                    End If
                    lIndex = lIndex + 1
                Next
            End If

            If mOrderIDList.Count > 0 Then
                dataTable = lcls.GetDataTable(mOrderIDList, "Reserve", Nothing, False, "", False, MasterType.MakePO, True)
                If dataTable.Rows.Count > 0 Then
                    For Each dr As DataRow In dataTable.Rows
                        lEachUnit = 0
                        lNotRefUnit = 0

                        Call GetUnitNotRef(dr("RefID"), "'Reserve'", "'PurchaseOrder','CancelPO'" _
                                                  , MasterType.PurchaseOrder & "," & MasterType.CancelPO, Nothing, dr("ID"), dr("ProductID"), lNotRefUnit)
                        If lNotRefUnit > 0 Then
                            rec = New ProductListDAO
                            rec.IsSelect = False
                            rec.ID = dr("ID")
                            rec.ProductListRefID = dr("ID")
                            rec.SEQ = ConvertNullToZero(dr("SEQ"))
                            rec.RefID = ConvertNullToZero(dr("RefID"))
                            rec.ProductID = ConvertNullToZero(dr("ProductID"))
                            rec.ProductCode = ConvertNullToString(dr("ProductCode"))
                            rec.ProductName = ConvertNullToString(dr("ProductName"))
                            rec.ProductNameExt = ConvertNullToString(dr("ProductNameExt"))
                            rec.LocationDTLID = ConvertNullToZero(dr("LocationDTLID"))
                            rec.LocationDTLID_Old = ConvertNullToZero(dr("LocationDTLID"))
                            rec.UnitID = ConvertNullToZero(dr("UnitID"))
                            rec.UnitName = ConvertNullToString(dr("UnitName"))
                            rec.Remark = ConvertNullToString(dr("Remark"))
                            rec.KeepMin = ConvertNullToZero(dr("KeepMin"))
                            rec.PriceMain = ConvertNullToZero(dr("PriceMain"))
                            rec.Price = ConvertNullToZero(dr("Price"))
                            rec.RealPrice = ConvertNullToZero(dr("RealPrice"))
                            rec.Cost = ConvertNullToZero(dr("Cost"))
                            rec.Discount = ConvertNullToZero(dr("Discount"))
                            rec.IsShow = ConvertNullToZero(dr("IsShow"))
                            rec.IsMerge = ConvertNullToZero(dr("IsMerge"))
                            rec.UnitMainID = ConvertNullToZero(dr("UnitMainIDBuy"))
                            rec.RateUnit = ConvertNullToZero(dr("RateUnit"))
                            rec.ModePro = DataMode.ModeEdit
                            'Load S/N
                            rec.IsSN = ConvertNullToZero(dr("IsSN"))

                            ''ถูกดึงไปแล้วบางส่วน
                            lEachUnit = lNotRefUnit
                            If lEachUnit < ConvertNullToZero(dr("Units")) Then
                                rec.Units = lEachUnit
                                rec.AdjustUnit = lEachUnit / rec.RateUnit
                                rec.Total = (rec.AdjustUnit * rec.Price) - (rec.AdjustUnit * rec.Discount)
                            Else
                                rec.Units = ConvertNullToZero(dr("Units"))
                                rec.AdjustUnit = ConvertNullToZero(dr("AdjustUnit"))
                                rec.Total = ConvertNullToZero(dr("Total"))
                            End If

                            lProList.Add(rec)
                        End If
                    Next
                End If
            End If

            Dim lColData As ProColumn = ProColumn.IsSelect + ProColumn.Units + ProColumn.Price + ProColumn.UnitName + ProColumn.Total + ProColumn.Discount + ProColumn.Remark
            UcProductLists1.ShowControlByDataSource(DataMode.ModeNew, lProList, lColData, True, Nothing, MasterType.MakePO.ToString, True, mOrderIDList, True, True, "")
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".LoadProListData : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    Private Function LoadlastPrice(ByVal pProID As Long, ByVal pIsSetText As Boolean) As Decimal
        Dim SQL As String = ""
        Dim dataTable As New DataTable()
        Dim lLastPrice As Decimal = 0
        Try
            Dim lCusID As Long = ConvertNullToZero(cboCustomerID.EditValue)

            If pIsSetText = True Then
                txtSupLast.Text = ""
                txtDateLast.Text = ""
                txtPriceLast.Text = ""
                txtQtyLast.Text = ""
                txtSupPrice1.Text = ""
                txtDateLow1.Text = ""
                txtPriceLow1.Text = ""
                txtQtyLow1.Text = ""
                txtSupPrice2.Text = ""
                txtDateLow2.Text = ""
                txtPriceLow2.Text = ""
                txtQtyLow2.Text = ""
                txtSupPrice3.Text = ""
                txtDateLow3.Text = ""
                txtPriceLow3.Text = ""
                txtQtyLow3.Text = ""
            End If

            If pProID > 0 And mFormLoad = False Then
                SQL = "SELECT top 3  Orders.OrderDate ,CASE WHEN ProductList.UnitID=ProductList.UnitMainID THEN ProductList.Price ELSE ProductList.Price/ProductList.RateUnit END Price "
                SQL &= " ,ProductList.Units,CASE WHEN Customer.CompanyName <>'' THEN Customer.CompanyName ELSE Customer.Title + Customer.Firstname + ' ' + Customer.LastName END Customer "
                SQL &= " FROM Orders  "
                SQL &= " INNER JOIN Customer ON Orders.CustomerID=Customer.CustomerID  "
                SQL &= " INNER JOIN ProductList ON Orders.OrderID=ProductList.RefID and ProductList.IsDelete =0  "
                SQL &= " WHERE Orders.IsDelete =0 AND Orders.IsCancel = 0  "
                SQL &= " and Orders.TableID =" & MasterType.PurchaseOrder
                SQL &= " AND Orders.IsInActive = 0 AND Orders.IsCancel= 0 AND ProductList.ProductID =" & pProID
                If lCusID > 0 Then
                    SQL &= " and Orders.CustomerID =" & lCusID
                End If
                SQL &= " ORDER BY Orders.OrderID desc "
                dataTable = New DataTable()
                dataTable = gConnection.executeSelectQuery(SQL, Nothing)
                Dim i As Integer = 1
                If dataTable.Rows.Count > 0 Then
                    For Each dr As DataRow In dataTable.Rows
                        If pIsSetText = True Then
                            Select Case i
                                Case 1
                                    txtSupPrice1.Text = ConvertNullToString(dr("Customer"))
                                    txtDateLow1.Text = Format(dr("OrderDate"), "dd/MM/yy")
                                    txtPriceLow1.Text = Format(ConvertNullToZero(dr("Price")), "#,##0.00")
                                    txtQtyLow1.Text = Format(ConvertNullToZero(dr("Units")), "#,##0")
                                    lLastPrice = ConvertNullToZero(dr("Price"))
                                Case 2
                                    txtSupPrice2.Text = ConvertNullToString(dr("Customer"))
                                    txtDateLow2.Text = Format(dr("OrderDate"), "dd/MM/yy")
                                    txtPriceLow2.Text = Format(ConvertNullToZero(dr("Price")), "#,##0.00")
                                    txtQtyLow2.Text = Format(ConvertNullToZero(dr("Units")), "#,##0")
                                Case 3
                                    txtSupPrice3.Text = ConvertNullToString(dr("Customer"))
                                    txtDateLow3.Text = Format(dr("OrderDate"), "dd/MM/yy")
                                    txtPriceLow3.Text = Format(ConvertNullToZero(dr("Price")), "#,##0.00")
                                    txtQtyLow3.Text = Format(ConvertNullToZero(dr("Units")), "#,##0")
                            End Select
                            i = i + 1
                        Else
                            lLastPrice = ConvertNullToZero(dr("Price"))
                            Exit For
                        End If
                    Next
                End If

                'Lower Price
                SQL = "SELECT top 1  OrderDate ,Price,Units,Customer "
                SQL &= " FROM ("
                SQL &= "SELECT Orders.OrderDate ,CASE WHEN ProductList.UnitID=ProductList.UnitMainID THEN ProductList.Price ELSE ProductList.Price/ProductList.RateUnit END Price "
                SQL &= " ,ProductList.Units,CASE WHEN Customer.CompanyName <>'' THEN Customer.CompanyName ELSE Customer.Title + Customer.Firstname + ' ' + Customer.LastName END Customer "
                SQL &= " FROM Orders  "
                SQL &= " INNER JOIN Customer ON Orders.CustomerID=Customer.CustomerID  "
                SQL &= " INNER JOIN ProductList ON Orders.OrderID=ProductList.RefID and ProductList.IsDelete =0  "
                SQL &= " WHERE Orders.IsDelete =0 AND Orders.IsCancel = 0  "
                SQL &= " and Orders.TableID =" & MasterType.PurchaseOrder
                SQL &= " AND Orders.IsInActive = 0 AND Orders.IsCancel= 0 AND ProductList.ProductID =" & pProID
                If lCusID > 0 Then
                    SQL &= " and Orders.CustomerID =" & lCusID
                End If
                SQL &= " ) AS TMP "
                SQL &= " ORDER BY Price "
                dataTable = New DataTable()
                dataTable = gConnection.executeSelectQuery(SQL, Nothing)
                If dataTable.Rows.Count > 0 And pIsSetText = True Then
                    For Each dr As DataRow In dataTable.Rows
                        If pIsSetText = True Then
                            txtSupLast.Text = ConvertNullToString(dr("Customer"))
                            txtDateLast.Text = Format(dr("OrderDate"), "dd/MM/yy")
                            txtPriceLast.Text = Format(ConvertNullToZero(dr("Price")), "#,##0.00")
                            txtQtyLast.Text = Format(ConvertNullToZero(dr("Units")), "#,##0")
                            Exit For
                        End If
                    Next
                End If
            End If


            If lLastPrice > 0 Then
                Return lLastPrice
            Else 'Find inform price
                If lCusID > 0 Then
                    Dim lclsInformBuy As New InformPriceBuyDAO
                    If lclsInformBuy.InitailData(lCusID, pProID) Then
                        Return lclsInformBuy.PriceBuy
                    End If
                Else
                    Return 0
                End If
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".LoadLastPrice : " & e.Message)
        Finally

        End Try
    End Function


    'Private Function LoadLowerPrice(ByVal pProID As Long, ByVal pIsSetText As Boolean) As Decimal
    '    Dim SQL As String = ""
    '    Dim dataTable As New DataTable()
    '    Dim lLastPrice As Decimal = 0, lLowPrice As Decimal = 0
    '    Try
    '        If pIsSetText = True Then
    '            txtSupLast.Text = ""
    '            txtDateLast.Text = ""
    '            txtPriceLast.Text = ""
    '            txtQtyLast.Text = ""
    '            txtSupPrice1.Text = ""
    '            txtDateLow1.Text = ""
    '            txtPriceLow1.Text = ""
    '            txtQtyLow1.Text = ""
    '            txtSupPrice2.Text = ""
    '            txtDateLow2.Text = ""
    '            txtPriceLow2.Text = ""
    '            txtQtyLow2.Text = ""
    '            txtSupPrice3.Text = ""
    '            txtDateLow3.Text = ""
    '            txtPriceLow3.Text = ""
    '            txtQtyLow3.Text = ""
    '        End If

    '        If pProID > 0 And mFormLoad = False Then

    '            SQL = "SELECT top 1  Orders.OrderID AS ID, Orders.OrderCode ,Orders.OrderDate ,ProductList.Price,ProductList.Units "
    '            SQL &=  " ,CASE WHEN Customer.CompanyName <>'' THEN Customer.CompanyName ELSE Customer.Title + Customer.Firstname + ' ' + Customer.LastName END Customer "
    '            SQL &=  " FROM Orders  "
    '            SQL &=  " INNER JOIN Customer ON Orders.CustomerID=Customer.CustomerID  "
    '            SQL &=  " INNER JOIN ProductList ON Orders.OrderID=ProductList.RefID and ProductList.IsDelete =0  "
    '            SQL &=  " WHERE Orders.IsDelete =0 AND Orders.IsCancel = 0  "
    '            SQL &=  " and Orders.TableID =" & MasterType.PurchaseOrder
    '            SQL &=  "  AND Orders.IsInActive = 0 AND Orders.IsCancel= 0 AND ProductList.ProductID =" & pProID
    '            SQL &=  " ORDER BY Orders.OrderID desc "
    '            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
    '            If dataTable.Rows.Count > 0 Then
    '                For Each dr As DataRow In dataTable.Rows
    '                    txtSupLast.Text = ConvertNullToString(dr("Customer"))
    '                    txtDateLast.Text = Format(dr("OrderDate"), "dd/MM/yy")
    '                    txtPriceLast.Text = Format(ConvertNullToZero(dr("Price")), "#,##0.00")
    '                    txtQtyLast.Text = Format(ConvertNullToZero(dr("Units")), "#,##0")
    '                    lLastPrice = ConvertNullToZero(dr("Price"))
    '                Next
    '            End If

    '            SQL = "SELECT top 3  Orders.OrderDate ,ProductList.Price,ProductList.Units "
    '            SQL &=  " ,CASE WHEN Customer.CompanyName <>'' THEN Customer.CompanyName ELSE Customer.Title + Customer.Firstname + ' ' + Customer.LastName END Customer "
    '            SQL &=  " FROM Orders  "
    '            SQL &=  " INNER JOIN Customer ON Orders.CustomerID=Customer.CustomerID  "
    '            SQL &=  " INNER JOIN ProductList ON Orders.OrderID=ProductList.RefID and ProductList.IsDelete =0  "
    '            SQL &=  " WHERE Orders.IsDelete =0 AND Orders.IsCancel = 0  "
    '            SQL &=  " and Orders.TableID =" & MasterType.PurchaseOrder
    '            SQL &=  " AND Orders.IsInActive = 0 AND Orders.IsCancel= 0 AND ProductList.ProductID =" & pProID
    '            If pIsSetText = False Then
    '                SQL &=  " and Orders.CustomerID =" & ConvertNullToZero(cboCustomerID.EditValue)
    '            End If
    '            SQL &=  " group BY Orders.OrderDate ,ProductList.Price,ProductList.Units"
    '            SQL &=  " ,Customer.CompanyName,Customer.Title, Customer.Firstname, Customer.LastName"
    '            SQL &=  " ORDER BY ProductList.Price   "
    '            dataTable = New DataTable()
    '            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
    '            Dim i As Integer = 1
    '            If dataTable.Rows.Count > 0 Then
    '                For Each dr As DataRow In dataTable.Rows
    '                    If pIsSetText = True Then
    '                        Select Case i
    '                            Case 1
    '                                txtSupPrice1.Text = ConvertNullToString(dr("Customer"))
    '                                txtDateLow1.Text = Format(dr("OrderDate"), "dd/MM/yy")
    '                                txtPriceLow1.Text = Format(ConvertNullToZero(dr("Price")), "#,##0.00")
    '                                txtQtyLow1.Text = Format(ConvertNullToZero(dr("Units")), "#,##0")
    '                            Case 2
    '                                txtSupPrice2.Text = ConvertNullToString(dr("Customer"))
    '                                txtDateLow2.Text = Format(dr("OrderDate"), "dd/MM/yy")
    '                                txtPriceLow2.Text = Format(ConvertNullToZero(dr("Price")), "#,##0.00")
    '                                txtQtyLow2.Text = Format(ConvertNullToZero(dr("Units")), "#,##0")
    '                            Case 3
    '                                txtSupPrice3.Text = ConvertNullToString(dr("Customer"))
    '                                txtDateLow3.Text = Format(dr("OrderDate"), "dd/MM/yy")
    '                                txtPriceLow3.Text = Format(ConvertNullToZero(dr("Price")), "#,##0.00")
    '                                txtQtyLow3.Text = Format(ConvertNullToZero(dr("Units")), "#,##0")
    '                        End Select
    '                        i = i + 1
    '                    Else 'If pIsSetText = True Then
    '                        lLowPrice = ConvertNullToZero(dr("Price"))  '**Return Lower Price
    '                    End If
    '                Next
    '            End If
    '        End If
    '        If lLowPrice > 0 Then
    '            Return lLowPrice
    '        Else
    '            Return lLastPrice
    '        End If
    '    Catch e As Exception
    '        Err.Raise(Err.Number, e.Source, mFormName & ".LoadLowerPrice : " & e.Message)
    '    Finally

    '    End Try
    'End Function


    Private Sub UcProductLists1_SelectedProduct(ByRef pProID As Long) Handles UcProductLists1.SelectedProduct
        Try
            LoadlastPrice(pProID, True)
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try
    End Sub

    Private Sub btnMakeOrder_Click(sender As System.Object, e As System.EventArgs) Handles btnMakeOrder.Click
        Try
            If ConvertNullToZero(cboCustomerID.EditValue) = 0 Then
                XtraMessageBox.Show(Me, "กรุณาระบุเจ้าหนี้", "ตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cboCustomerID.Focus()
            Else
                If XtraMessageBox.Show(Me, "ยืนยันสร้างใบสั่งซื้อ", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    GetProList()
                    If mProductSubList.Count > 0 Then
                        ShowProgress(True, "Loading...")
                        Dim lFormEdit As New frmOrderS
                        With lFormEdit
                            .OrderType = MasterType.MakePO
                            .Caption = "ใบสั่งซื้อ"
                            .MdiParent = frmMain
                            .ModeData = DataMode.ModeNew
                            .IDs = 0
                            .ProductList = mProductSubList
                            .CusID = ConvertNullToZero(cboCustomerID.EditValue)
                            .RefReserveIDList = mOrderIDList
                            .Show()
                        End With

                        mIsAccept = True
                        ShowProgress(False, "")
                        Me.Close()
                    End If


                End If
            End If

        Catch ex As Exception
            ShowProgress(False, "")
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try
    End Sub


    Private Sub btnCancelPO_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelPO.Click
        Try
            If ConvertNullToZero(cboCustomerID.EditValue) = 0 Then
                XtraMessageBox.Show(Me, "กรุณาระบุเจ้าหนี้", "ตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cboCustomerID.Focus()
            Else
                If XtraMessageBox.Show(Me, "ยืนยันยกเลิกการสั่งซื้อ", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    GetProList()
                    If mProductSubList.Count > 0 Then
                        ShowProgress(True, "Loading...")
                        Dim lFormEdit As New frmOrderS
                        With lFormEdit
                            .OrderType = MasterType.CancelPO
                            .Caption = "ยกเลิกการสั่งซื้อ"
                            .MdiParent = frmMain
                            .ModeData = DataMode.ModeNew
                            .IDs = 0
                            .ProductList = mProductSubList
                            .CusID = ConvertNullToZero(cboCustomerID.EditValue)
                            .RefReserveIDList = mOrderIDList
                            .Show()
                        End With

                        mIsAccept = True
                        ShowProgress(False, "")
                        Me.Close()
                    End If


                End If
            End If

        Catch ex As Exception
            ShowProgress(False, "")
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try
    End Sub
End Class

