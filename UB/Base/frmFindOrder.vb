Imports DevExpress.XtraEditors.Controls

Public Class frmFindOrder

#Region "Property"
    Private mCustomerID As Long
    Private mFindCreditOnly As Boolean
    Private mOrderDate As Date
    Private Const mFormName As String = "frmFindOrder"
    Private mSubOrderList As List(Of SubOrder)
    Private mProductSubList As List(Of ProductSubDAO)
    Private mOrderType As MasterType
    Private bindingOrder As BindingSource
    Dim mIsAccept As Boolean = False
    'Private bindingProduct As BindingSource

    Public ReadOnly Property IsAccept() As Boolean
        Get
            Return mIsAccept
        End Get
    End Property
    Public ReadOnly Property GetSubOrderList() As List(Of SubOrder)
        Get
            Return mSubOrderList
        End Get
    End Property
    Public ReadOnly Property GetProductSubList() As List(Of ProductSubDAO)
        Get
            Return mProductSubList
        End Get
    End Property
    Public ReadOnly Property IsGetByProduct() As Boolean
        Get
            Return (CheckProduct.CheckState = CheckState.Checked)
        End Get
    End Property

    Public WriteOnly Property OrderType() As Long
        Set(ByVal value As Long)
            mOrderType = value

        End Set
    End Property
    Public WriteOnly Property CustomerID_() As Long
        Set(ByVal value As Long)
            mCustomerID = value
        End Set
    End Property
    Public WriteOnly Property OrderDate() As Date
        Set(ByVal value As Date)
            mOrderDate = value
        End Set
    End Property
    Public WriteOnly Property FindCreditOnly() As Boolean
        Set(ByVal value As Boolean)
            mFindCreditOnly = value
        End Set
    End Property
 
#End Region

#Region "Load All Order"
    Private Function LoadOrderByCondition() As Boolean
        Try
            bindingOrder = Nothing
            bindingOrder = New BindingSource

            Select Case cboOrderType.EditValue
               
                Case MasterType.Opportunity
                    LoadOpp()
                Case Else
                    LoadOrder(cboOrderType.EditValue)
               
            End Select
            gCustomerID = mCustomerID

            gridView.OptionsView.ShowFooter = False
            gridControl.DataSource = bindingOrder
            GridStyle()

            'If CheckProduct.CheckState = CheckState.Checked Then
            '    LoadProList()
            'End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".LoadOrderByCondition : " & e.Message)
        Finally

        End Try
    End Function

    Private Sub GridStyle()
        With GridView
            'gridView.OptionsBehavior.ReadOnly = True
            .Columns("ID").Visible = False
            '.Columns("CusName").Visible = False
            .Columns("IsSelect").Visible = True
            .Columns("GrandTotal").Visible = True
            .Columns("OrderCode").Visible = True
            .Columns("BillTotal").Visible = False
            .Columns("BillType").Visible = False
            .Columns("Remark").Visible = False
            .Columns("OrderCode").OptionsColumn.ReadOnly = True
            .Columns("GrandTotal").OptionsColumn.ReadOnly = True
            If cboOrderType.EditValue = MasterType.PurchaseOrder Then
                .Columns("CusName").Visible = True
            Else
                .Columns("CusName").Visible = False
            End If
            If mOrderType = MasterType.ReceiptBuy Then
                .Columns("InvoiceSuplierID").Visible = True
            Else
                .Columns("InvoiceSuplierID").Visible = False
            End If
        End With
       
    End Sub




    Private Function LoadOrder(ByVal pOrderType As MasterType) As Boolean
        Dim lcls As New OrderSDAO
        Dim dataTable As New DataTable()
        Dim SQL As String
        Dim rec As SubOrder, lIsOpen As Boolean = True
        Try
             
            SQL = " AND Orders.OrderDate Between '" & formatSQLDate(DateFrom.EditValue) & "' AND '" & formatSQLDate(DateTo.EditValue) & "'"
            If mOrderType = MasterType.Bill Then
                SQL &= " AND Orders.RefBillID=0 "
            End If
            If mOrderType = MasterType.Receipt Then
                SQL &= " AND Orders.RefReceiptID=0 "
            End If
            Select Case mOrderType
                Case MasterType.Asset
                    mCustomerID = 0
                    lIsOpen = False
                Case MasterType.AddCredit, MasterType.AddCreditBuy, MasterType.ReduceCredit, MasterType.ReduceCreditBuy
                    lIsOpen = False
            End Select
           
            lcls.TableID = pOrderType
            dataTable = lcls.GetDataTableForCombo(mOrderType, pOrderType, mCustomerID, DateTo.EditValue, lIsOpen, SQL)
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
                    If mOrderType = MasterType.Receipt Then
                        rec.GrandTotal = ConvertNullToZero(dr("GrandTotal")) - ConvertNullToZero(dr("PayTotal"))
                    Else
                        rec.GrandTotal = ConvertNullToZero(dr("GrandTotal"))
                    End If

                    rec.BillTotal = rec.GrandTotal
                    rec.TableID = pOrderType
                    rec.BillType = cboOrderType.Text

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


    Private Function LoadOpp() As Boolean
        Dim lcls As New OpportunityDAO
        Dim dataTable As New DataTable()
        Dim rec As SubOrder
        Try
            dataTable = lcls.GetDataTableForCombo(mCustomerID, DateTo.EditValue)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    rec = New SubOrder
                    rec.IsSelect = False
                    rec.OrderID = dr("ID")
                    rec.OrderDate = dr("OppStartDate")
                    rec.OrderCode = ConvertNullToString(dr("OppName"))
                    rec.EmpName = ConvertNullToString(dr("EMPNAME"))
                    rec.GrandTotal = 0
                    rec.BillTotal = 0
                    rec.BillType = "โอกาสทางการขาย"
                    rec.TableID = MasterType.Opportunity
                    bindingOrder.Add(rec)
                Next
                Return True
            Else
                Return False
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".LoadOpp : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Function


    Private Sub GetOrderDAOs(ByVal pMultiSelect As Boolean)
        Dim lRow As Long
        Dim lDataDAO As SubOrder
        Try
            mSubOrderList = New List(Of SubOrder)
            If GridView.RowCount > 0 Then
                If pMultiSelect = True Then
                    For lRow = 0 To GridView.RowCount
                        If ConvertNullToZero(GridView.GetRowCellValue(lRow, "OrderID")) <> 0 And GridView.GetRowCellValue(lRow, "IsSelect") = True Then
                            lDataDAO = New SubOrder
                            lDataDAO.IsSelect = True
                            lDataDAO.ID = ConvertNullToZero(GridView.GetRowCellDisplayText(lRow, "ID"))
                            lDataDAO.OrderID = ConvertNullToZero(GridView.GetRowCellDisplayText(lRow, "OrderID"))
                            lDataDAO.OrderCode = ConvertNullToString(GridView.GetRowCellDisplayText(lRow, "OrderCode"))
                            lDataDAO.CusName = ConvertNullToString(GridView.GetRowCellDisplayText(lRow, "CusName"))
                            lDataDAO.EmpName = ConvertNullToString(GridView.GetRowCellDisplayText(lRow, "EmpName"))
                            lDataDAO.BillTotal = ConvertNullToZero(GridView.GetRowCellValue(lRow, "BillTotal"))
                            lDataDAO.GrandTotal = ConvertNullToZero(GridView.GetRowCellValue(lRow, "GrandTotal"))
                            lDataDAO.OrderDate = GridView.GetRowCellValue(lRow, "OrderDate")
                            lDataDAO.Remark = ConvertNullToString(GridView.GetRowCellDisplayText(lRow, "Remark"))
                            lDataDAO.BillType = ConvertNullToString(GridView.GetRowCellDisplayText(lRow, "BillType"))
                            lDataDAO.TableID = ConvertNullToString(GridView.GetRowCellDisplayText(lRow, "TableID"))
                            mSubOrderList.Add(lDataDAO)
                        End If
                    Next
                Else
                    lDataDAO = New SubOrder
                    lDataDAO.IsSelect = True
                    lDataDAO.ID = ConvertNullToZero(GridView.GetFocusedRowCellValue("ID"))
                    lDataDAO.OrderID = ConvertNullToZero(GridView.GetFocusedRowCellValue("OrderID"))
                    lDataDAO.OrderCode = ConvertNullToString(GridView.GetFocusedRowCellValue("OrderCode"))
                    lDataDAO.CusName = ConvertNullToString(GridView.GetFocusedRowCellValue("CusName"))
                    lDataDAO.EmpName = ConvertNullToString(GridView.GetFocusedRowCellValue("EmpName"))
                    lDataDAO.BillTotal = ConvertNullToZero(GridView.GetFocusedRowCellValue("BillTotal"))
                    lDataDAO.GrandTotal = ConvertNullToZero(GridView.GetFocusedRowCellValue("GrandTotal"))
                    lDataDAO.OrderDate = GridView.GetFocusedRowCellValue("OrderDate")
                    lDataDAO.Remark = ConvertNullToString(GridView.GetFocusedRowCellValue("Remark"))
                    lDataDAO.BillType = ConvertNullToString(GridView.GetFocusedRowCellValue("BillType"))
                    lDataDAO.TableID = ConvertNullToZero(GridView.GetFocusedRowCellValue("TableID"))
                    mSubOrderList.Add(lDataDAO)

                End If

            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".GetOrderDAOs : " & e.Message)
        Finally
            lDataDAO = Nothing
        End Try
    End Sub

    Private Sub GetOrder(ByVal pMultiSelect As Boolean)
        Try
            If CheckProduct.CheckState = CheckState.Checked Then
                mProductSubList = UcProductLists1.GetProSubDAOs
            Else
                GetOrderDAOs(pMultiSelect)
            End If

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".GetOrder : " & ex.Message)
        Finally
        End Try
    End Sub

#End Region
    Private Sub GridControl_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl.KeyDown
        If e.KeyData = Keys.Enter Then
            GetOrder(False)
            mIsAccept = True
            Me.Close()
        End If
    End Sub


    Private Sub GridView_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView.DoubleClick
        GetOrder(False)
        mIsAccept = True
        Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Try
            GetOrder(True)
            mIsAccept = True
            Me.Close()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Try
            LoadOrderByCondition()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try
    End Sub

    Private Sub frmFindOrder_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyData = Keys.Escape Then
            mIsAccept = False
            Me.Close()
        End If
    End Sub

    Private Sub frmFindOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cList As OrderTypeList = New OrderTypeList
        Select Case mOrderType
            Case MasterType.Quotation
                cList.Add(New OrderType("โอกาสทางการขาย", MasterType.Opportunity))
                cboOrderType.EditValue = MasterType.Opportunity
            Case MasterType.SellOrders          '***** ถ้ามีเพิ่มการดึงรายการแก้ UpdateRefOrderStatus ด้วย
                cList.Add(New OrderType("ใบเสนอราคา", MasterType.Quotation))
                cList.Add(New OrderType("ใบสั่งจอง", MasterType.Reserve))
                cboOrderType.EditValue = MasterType.Quotation
            Case MasterType.Shiping, MasterType.Borrow
                cList.Add(New OrderType("ใบสั่งขาย", MasterType.SellOrders))
                cboOrderType.EditValue = MasterType.SellOrders
            Case MasterType.Invoice
                cList.Add(New OrderType("ใบสั่งขาย", MasterType.SellOrders))
                cList.Add(New OrderType("ยืมสินค้า (ขาย)", MasterType.Borrow))
                cboOrderType.EditValue = MasterType.SellOrders
            Case MasterType.Reserve              '***** ถ้ามีเพิ่มการดึงรายการแก้ UpdateRefOrderStatus ด้วย
                cList.Add(New OrderType("ใบเสนอราคา", MasterType.Quotation))
                cboOrderType.EditValue = MasterType.Quotation
                'Case MasterType.Bill
                '    cList.Add(New OrderType("ใบกำกับภาษี (ขาย)", MasterType.Invoice))
                '    cList.Add(New OrderType("ใบสั่งขาย", MasterType.SellOrders))
                '    cList.Add(New OrderType("ส่งของ (ขาย)", MasterType.Shiping))
                '    cList.Add(New OrderType("บันทึกลดหนี้", MasterType.ReduceCredit))
                '    cboOrderType.EditValue = MasterType.Invoice
            Case MasterType.AddCredit, MasterType.ReduceCredit
                cList.Add(New OrderType("ใบสั่งขาย", MasterType.SellOrders))
                cList.Add(New OrderType("ใบกำกับภาษี (ขาย)", MasterType.Invoice))
                cList.Add(New OrderType("ใบส่งของ (ขาย)", MasterType.Shiping))
                cboOrderType.EditValue = MasterType.Invoice
            Case MasterType.Receipt, MasterType.Bill
                'cList.Add(New OrderType("ใบสั่งขาย", MasterType.SellOrders))
                cList.Add(New OrderType("ใบกำกับภาษี (ขาย)", MasterType.Invoice))
                cList.Add(New OrderType("ส่งของ (ขาย)", MasterType.Shiping))
                cList.Add(New OrderType("บันทึกเพิ่มหนี้", MasterType.AddCredit))
                cList.Add(New OrderType("บันทึกลดหนี้", MasterType.ReduceCredit))
                cboOrderType.EditValue = MasterType.Invoice
            Case MasterType.ReceiptCut
                cList.Add(New OrderType("ส่งของ (ขาย)", MasterType.Shiping))
                cList.Add(New OrderType("บันทึกลดหนี้", MasterType.ReduceCredit))
                cList.Add(New OrderType("บันทึกเพิ่มหนี้", MasterType.AddCredit))
                cboOrderType.EditValue = MasterType.Shiping
            Case MasterType.StockIn, MasterType.InvoiceBuy, MasterType.ShipingBuy '***** ถ้ามีเพิ่มการดึงรายการแก้ UpdateRefOrderStatus ด้วย
                cList.Add(New OrderType("ใบสั่งซื้อ", MasterType.PurchaseOrder))
                cboOrderType.EditValue = MasterType.PurchaseOrder
            Case MasterType.Claim
                cList.Add(New OrderType("ใบกำกับภาษี (ขาย)", MasterType.Invoice))
                cboOrderType.EditValue = MasterType.Invoice
            Case MasterType.ClaimOut
                cList.Add(New OrderType("ใบกำกับภาษี (ซื้อ)", MasterType.InvoiceBuy))
                cboOrderType.EditValue = MasterType.InvoiceBuy
            Case MasterType.ReceiptBuy
                cList.Add(New OrderType("ใบกำกับภาษี (ซื้อ)", MasterType.InvoiceBuy))
                cList.Add(New OrderType("ส่งของ (ซื้อ)", MasterType.ShipingBuy))
                cList.Add(New OrderType("บันทึกลดหนี้", MasterType.ReduceCreditBuy))
                cList.Add(New OrderType("ตั้งลูกหนี้", MasterType.AddCreditBuy))
                cList.Add(New OrderType("บันทึกค่าใช้จ่ายอื่นๆ", MasterType.Asset))
                cboOrderType.EditValue = MasterType.InvoiceBuy
                'Case MasterType.ReduceCredit
                '    cList.Add(New OrderType("ใบกำกับภาษี (ขาย)", MasterType.Invoice))
                '    cList.Add(New OrderType("ใบส่งของ (ขาย)", MasterType.Shiping))
                '    cboOrderType.EditValue = MasterType.Invoice
            Case MasterType.ReduceCreditBuy, MasterType.AddCreditBuy
                cList.Add(New OrderType("ใบกำกับภาษี (ซื้อ)", MasterType.InvoiceBuy))
                cList.Add(New OrderType("ใบส่งของ (ซื้อ", MasterType.ShipingBuy))
                cboOrderType.EditValue = MasterType.InvoiceBuy
            Case MasterType.Asset
                cList.Add(New OrderType("ใบสั่งซื้อ", MasterType.PurchaseOrder))
                cboOrderType.EditValue = MasterType.PurchaseOrder
        End Select
        DateFrom.EditValue = DateAdd(DateInterval.Month, -1, mOrderDate)
        DateTo.EditValue = mOrderDate

        cboOrderType.Properties.DataSource = cList
        cboOrderType.Properties.DisplayMember = "Name"
        cboOrderType.Properties.ValueMember = "MasterTypes"

        LoadOrderByCondition()
    End Sub
 
    Private Sub CheckProduct_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckProduct.CheckedChanged
        If CheckProduct.CheckState = CheckState.Checked Then
            'LoadProList()
            TabControl1.SelectedTabPage = ProductTabPage
        Else
            TabControl1.SelectedTabPage = OrderTabPage
        End If
    End Sub
     
    Private Sub GridControl_Click(sender As System.Object, e As System.EventArgs) Handles GridControl.Click

    End Sub
End Class

Public Class OrderTypeList
    Inherits System.Collections.CollectionBase

    Default Public Property Item(ByVal index As Integer) As OrderType
        Get
            Return CType(List(index), OrderType)
        End Get
        Set(ByVal Value As OrderType)
            List(index) = Value
        End Set
    End Property

    Public Function Add(ByVal value As OrderType) As Integer
        Return List.Add(value)
    End Function

End Class

Public Class OrderType
    Private _name As String
    Private _MasterType As MasterType

    Public Sub New(ByVal _name As String, ByVal _MasterType As Integer)
        Me._name = _name
        Me._MasterType = _MasterType

    End Sub

    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal Value As String)
            _name = Value
        End Set
    End Property

    Public Property MasterTypes() As Integer
        Get
            Return _MasterType
        End Get
        Set(ByVal Value As Integer)
            _MasterType = Value
        End Set
    End Property

   
End Class
 