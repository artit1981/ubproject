Option Explicit On

Public Class OrderControl
    Implements iControl
    Private WithEvents mCtlForm As frmControls
    Private mCaption As String = "Fail !"
    Private mCHECKSUM_AGG As Long
    Private mOrderType As MasterType


    Public Sub Execute(ByVal pOrderType As Integer) Implements iControl.Execute
        Try
            mOrderType = pOrderType
            mCtlForm = New frmControls
            SetFormByOrderType()
            mCtlForm.Show()
            Call LoadData()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try
    End Sub

    Private Sub SetFormByOrderType()
        Dim lMakeOrderCation As String = ""
        Dim lFilterCol As FilterBy

        mCtlForm.DatePanel.Visible = True
        Select Case mOrderType
            Case MasterType.SellOrders
                lMakeOrderCation = "สร้างใบส่งของ"
                lFilterCol = FilterBy.Code + FilterBy.CustomerCode + FilterBy.Customer + FilterBy.EmpName + FilterBy.PO
            Case MasterType.Quotation
                lMakeOrderCation = "สร้างใบสั่งขาย"
                lFilterCol = FilterBy.Code + FilterBy.CustomerCode + FilterBy.Customer + FilterBy.EmpName
            Case MasterType.Bill
                lFilterCol = FilterBy.Code + FilterBy.CustomerCode + FilterBy.Customer + FilterBy.EmpName
            Case MasterType.Invoice
                lFilterCol = FilterBy.Code + FilterBy.CustomerCode + FilterBy.Customer + FilterBy.EmpName + FilterBy.PO
            Case MasterType.InvoiceOnline
                lFilterCol = FilterBy.Code + FilterBy.CustomerCode + FilterBy.Customer + FilterBy.EmpName + FilterBy.PO
            Case MasterType.InvoiceAbb
                lFilterCol = FilterBy.Code + FilterBy.CustomerCode + FilterBy.Customer + FilterBy.EmpName + FilterBy.PO
            Case MasterType.Borrow
                lFilterCol = FilterBy.Code + FilterBy.CustomerCode + FilterBy.Customer + FilterBy.EmpName + FilterBy.PO
            Case MasterType.PurchaseOrder
                lFilterCol = FilterBy.Code + FilterBy.CustomerCode + FilterBy.Agency + FilterBy.EmpName
            Case MasterType.CancelPO
                lFilterCol = FilterBy.Code + FilterBy.CustomerCode + FilterBy.Agency + FilterBy.EmpName
            Case MasterType.Reserve
                lMakeOrderCation = "สร้างใบสั่งขาย"
                lFilterCol = FilterBy.Code + FilterBy.CustomerCode + FilterBy.Customer + FilterBy.EmpName + FilterBy.PO
            Case MasterType.Shiping
                lFilterCol = FilterBy.Code + FilterBy.CustomerCode + FilterBy.Customer + FilterBy.EmpName + FilterBy.PO
            Case MasterType.AddCredit
                lFilterCol = FilterBy.Code + FilterBy.CustomerCode + FilterBy.Customer + FilterBy.EmpName + FilterBy.PO
            Case MasterType.Receipt
                lFilterCol = FilterBy.Code + FilterBy.CustomerCode + FilterBy.Customer + FilterBy.EmpName
            Case MasterType.ReceiptCut
                lFilterCol = FilterBy.Code + FilterBy.CustomerCode + FilterBy.Customer + FilterBy.EmpName
            Case MasterType.InvoiceBuy
                lFilterCol = FilterBy.Code + FilterBy.CustomerCode + FilterBy.Agency + FilterBy.EmpName
            Case MasterType.ShipingBuy
                lFilterCol = FilterBy.Code + FilterBy.CustomerCode + FilterBy.Agency + FilterBy.EmpName
            Case MasterType.ReceiptBuy
                lFilterCol = FilterBy.Code + FilterBy.CustomerCode + FilterBy.Agency + FilterBy.EmpName
            Case MasterType.Asset
                lFilterCol = FilterBy.Code + FilterBy.CustomerCode + FilterBy.Agency + FilterBy.EmpName
            Case MasterType.ReduceCredit
                lFilterCol = FilterBy.Code + FilterBy.CustomerCode + FilterBy.Customer + FilterBy.EmpName + FilterBy.PO
            Case MasterType.AddCreditBuy
                lFilterCol = FilterBy.Code + FilterBy.CustomerCode + FilterBy.Agency + FilterBy.EmpName + FilterBy.PO
            Case MasterType.ReduceCreditBuy
                lFilterCol = FilterBy.Code + FilterBy.CustomerCode + FilterBy.Agency + FilterBy.EmpName + FilterBy.PO
            Case MasterType.ClaimOut
                lFilterCol = FilterBy.Code + FilterBy.CustomerCode + FilterBy.Agency + FilterBy.EmpName
            Case MasterType.Claim
                lFilterCol = FilterBy.Code + FilterBy.CustomerCode + FilterBy.Customer + FilterBy.EmpName
            Case MasterType.StockIn
                lFilterCol = FilterBy.Code + FilterBy.CustomerCode + FilterBy.EmpName
            Case MasterType.UpdateStock
                lFilterCol = FilterBy.Code + FilterBy.CustomerCode + FilterBy.EmpName
            Case MasterType.ClaimResult
                lFilterCol = FilterBy.Code + FilterBy.CustomerCode + FilterBy.Agency + FilterBy.EmpName
            Case MasterType.ClaimReturn
                lFilterCol = FilterBy.Code + FilterBy.CustomerCode + FilterBy.Customer + FilterBy.EmpName
            Case MasterType.Quotation2
                lFilterCol = FilterBy.Code + FilterBy.CustomerCode + FilterBy.Customer + FilterBy.EmpName
        End Select

        Call InitialFilterCon(mCtlForm.cboFindIn, lFilterCol)
        mCaption = GetCaption(mOrderType)

        With mCtlForm
            .Text = mCaption
            .MdiParent = frmMain
            .OptionBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            If lMakeOrderCation <> "" Then
                .MakeOrderBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                .MakeOrderBar.Caption = lMakeOrderCation
            End If
            If mOrderType = MasterType.SellOrders Then
                .MakeInvoiceBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                .MakeInvoiceOnlineBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                .MakeInvoiceAbbBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            End If
            Call SetControlMenuPrivilege(mCtlForm, mOrderType)
        End With

    End Sub

    Private Function GetCaption(ByVal pOrderType As MasterType) As String
        Dim lCaption As String

        Select Case pOrderType
            Case MasterType.SellOrders
                lCaption = "ใบสั่งขาย"
            Case MasterType.Quotation
                lCaption = "ใบเสนอราคา"
            Case MasterType.Bill
                lCaption = "ใบวางบิล"
            Case MasterType.Invoice
                lCaption = "ใบกำกับภาษี(ขาย)"
            Case MasterType.InvoiceOnline
                lCaption = "ใบกำกับภาษีออนไลน์"
            Case MasterType.InvoiceAbb
                lCaption = "ใบกำกับภาษีอย่างย่อ"
            Case MasterType.Borrow
                lCaption = "ยืมสินค้า (ขาย)"
            Case MasterType.PurchaseOrder
                lCaption = "ใบสั่งซื้อ"
            Case MasterType.CancelPO
                lCaption = "ยกเลิกการสั่งซื้อ"
            Case MasterType.Reserve
                lCaption = "ใบสั่งจอง"
            Case MasterType.Shiping
                lCaption = "ใบส่งของ"
            Case MasterType.AddCredit
                lCaption = "ตั้งลูกหนี้"
            Case MasterType.Receipt
                lCaption = "ใบเสร็จรับเงิน /ชำระเงิน"
            Case MasterType.ReceiptCut
                lCaption = "ตัดรับชำระ"
            Case MasterType.InvoiceBuy
                lCaption = "ใบกำกับภาษี(ซื้อ)"
            Case MasterType.ShipingBuy
                lCaption = "ใบส่งของ(ซื้อ)"
            Case MasterType.ReceiptBuy
                lCaption = "ใบเสร็จรับเงิน /ชำระเงิน(ซื้อ)"
            Case MasterType.Asset
                lCaption = "บันทึกค่าใช้จ่ายอื่นๆ"
            Case MasterType.ReduceCredit
                lCaption = "บันทึกลดหนี้"
            Case MasterType.AddCreditBuy
                lCaption = "ตั้งลูกหนี้"
            Case MasterType.ReduceCreditBuy
                lCaption = "บันทึกลดหนี้"
            Case MasterType.ClaimOut
                lCaption = "แจ้งเคลม Supplier"
            Case MasterType.Claim
                lCaption = "รับแจ้งเคลม"
            Case MasterType.StockIn
                lCaption = "นำสินค้าเข้าระบบ"
            Case MasterType.UpdateStock
                lCaption = "ปรับยอดสินค้า"
            Case MasterType.ClaimResult
                lCaption = "ผลการเคลม Supplier"
            Case MasterType.ClaimReturn
                lCaption = "เคลม(ส่งคืน)"
            Case MasterType.Quotation2
                lCaption = "ใบเสนอราคาคู่เทียบ"
            Case Else
                lCaption = "N/A"
        End Select

        Return lCaption

    End Function

    Private Sub LoadData()
        Dim SQL As String = ""
        Dim dataTable As New DataTable()
        Dim lcls As New OrderSDAO
        Dim lIsActiveOnly As Boolean = True

        lcls.TableID = mOrderType
        Try
            If mCtlForm.DatePanel.Visible = True Then
                SQL = " and Orders.OrderDate between '" & formatSQLDate(mCtlForm.dtpDateFrom.EditValue) & "'" & "  and '" & formatSQLDate(mCtlForm.dtpDateTo.EditValue) & "'"
                If mCtlForm.chkShowDelete.Checked = True Then
                    lIsActiveOnly = False
                Else
                    lIsActiveOnly = True
                End If
            End If
            dataTable = lcls.GetDataTable(mOrderType, 0, lIsActiveOnly, SQL)

            If dataTable.Rows.Count > 0 Then
                mCtlForm.GridControl.DataSource = dataTable
                mCtlForm.GridView.ViewCaption = mCaption
                mCtlForm.GridView.MoveLastVisible()
                Call GridStyle()


            Else
                mCtlForm.GridControl.DataSource = Nothing
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "OrderControl.LoadData : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Sub


    Private Sub GridStyle()
        With mCtlForm.GridView
            Select Case mOrderType
                Case MasterType.SellOrders
                    .Columns("InvoiceCode").Caption = "เลขที่ใบกำกับภาษี"
                    .Columns("InvoiceCode").Width = 90
                    .Columns("InvoiceCode").MaxWidth = 90
                    .Columns("ReceiptCode").Caption = "เลขที่ใบเสร็จ"
                    .Columns("ReceiptCode").Width = 90
                    .Columns("ReceiptCode").MaxWidth = 90
                    .Columns("BillCode").Caption = "เลขที่บิล"
                    .Columns("BillCode").Width = 90
                    .Columns("BillCode").MaxWidth = 90
                    .Columns("ShipingCode").Caption = "เลขที่ใบส่งของ"
                    .Columns("ShipingCode").Width = 90
                    .Columns("ShipingCode").MaxWidth = 90
                Case MasterType.Invoice, MasterType.Shiping, MasterType.InvoiceOnline, MasterType.InvoiceAbb
                    .Columns("ReceiptCode").Caption = "เลขที่ใบเสร็จ"
                    .Columns("ReceiptCode").Width = 90
                    .Columns("ReceiptCode").MaxWidth = 100
                    .Columns("BillCode").Caption = "เลขที่บิล"
                    .Columns("BillCode").Width = 90
                    .Columns("BillCode").MaxWidth = 100
                Case MasterType.Quotation
                    .Columns("ExpireDate").Caption = "วันครบกำหนด"
                    .Columns("ExpireDate").Width = 80
                    .Columns("ExpireDate").MaxWidth = 90
                    .Columns("RefCode").Caption = "ปิดรายการโดย"
                    .Columns("RefCode").Width = 90
                    .Columns("RefCode").MaxWidth = 100
                Case MasterType.StockIn
                    .Columns("PO").Caption = "PO"
                    .Columns("PO").Width = 150
                    .Columns("PO").MaxWidth = 300
                Case MasterType.InvoiceBuy, MasterType.ShipingBuy, MasterType.ReduceCreditBuy, MasterType.AddCredit, MasterType.ReduceCredit, MasterType.AddCreditBuy
                    .Columns("InvoiceSuplierID").Caption = "เลขที่ใบกำกับภาษีเจ้าหนี้"
                    .Columns("InvoiceSuplierID").Width = 100
                    .Columns("InvoiceSuplierID").MaxWidth = 120
            End Select
            Select Case mOrderType
                Case MasterType.SellOrders, MasterType.AddCredit, MasterType.ReduceCredit, MasterType.Shiping, MasterType.Reserve, MasterType.Invoice, MasterType.Borrow, MasterType.InvoiceOnline, MasterType.InvoiceAbb, MasterType.AddCreditBuy, MasterType.ReduceCreditBuy
                    .Columns("PO").Caption = "เลขคำสั่งซื้อ"
                    .Columns("PO").Width = 100
                    .Columns("PO").MaxWidth = 120
            End Select
            Select Case mOrderType
                Case MasterType.PurchaseOrder, MasterType.Asset, MasterType.InvoiceBuy, MasterType.AddCreditBuy, MasterType.ReduceCreditBuy, MasterType.ClaimOut, MasterType.ReceiptBuy, MasterType.ShipingBuy, MasterType.CancelPO
                    .Columns("Customer").Caption = "เจ้าหนี้"
                    .Columns("CustomerCode").Caption = "รหัสเจ้าหนี้"
                Case Else
                    .Columns("Customer").Caption = "ลูกค้า"
                    .Columns("CustomerCode").Caption = "รหัสลูกค้า"
            End Select
            .Columns("CustomerCode").Width = 120
            .Columns("CustomerCode").MinWidth = 100
            .Columns("CustomerCode").MaxWidth = 160

            Select Case mOrderType
                Case MasterType.Bill, MasterType.Receipt, MasterType.ReceiptBuy, MasterType.ReceiptCut
                    .Columns("OrderStatus").Visible = False
                Case MasterType.StockIn, MasterType.UpdateStock
                    .Columns("Customer").Visible = False
                    .Columns("OrderStatus").Visible = False
                    .Columns("GrandTotal").Visible = False
                Case Else
                    .Columns("OrderStatus").Caption = "สถานะ"
                    .Columns("OrderStatus").Width = 70
                    .Columns("OrderStatus").MaxWidth = 70
            End Select
            If mOrderType = MasterType.Reserve Then
                .Columns("MakePOStatus").Caption = "สร้างใบสั่งซื้อ"
                .Columns("MakePOStatus").Width = 80
                .Columns("MakePOStatus").MaxWidth = 80
                .Columns("POCode").Caption = "เลขใบสั่งซื้อ"
                .Columns("POCode").Width = 100
                .Columns("POCode").MaxWidth = 120
            End If
            .Columns("IsDelete").Visible = False
            .Columns("IsCancel").Visible = False
            .Columns("ChequeID").Visible = False
            .Columns("IsNotPass").Visible = False
            .Columns("ID").Visible = False
            .Columns("Code").Caption = "เลขที่"
            .Columns("Code").Width = 100
            .Columns("Code").MaxWidth = 120
            .Columns("OrderDate").Caption = "วันที่"
            .Columns("OrderDate").Width = 80
            .Columns("OrderDate").MaxWidth = 90

            .Columns("GrandTotal").Caption = "ยอดรวม"
            .Columns("GrandTotal").Width = 110
            .Columns("GrandTotal").MaxWidth = 120
            .Columns("GrandTotal").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            .Columns("GrandTotal").DisplayFormat.FormatString = "n2"
            .Columns("EMPNAME").Caption = "ผู้รับผิดชอบ"
            .Columns("EMPNAME").Width = 150
            .Columns("EMPNAME").MaxWidth = 160
            .Columns("ModifiedTime").Caption = "แก้ไขล่าสุด"
            .Columns("ModifiedTime").Width = 100
            .Columns("ModifiedTime").MaxWidth = 120
            .Columns("ModifiedTime").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        End With
    End Sub


    Private Sub mCtlForm_AddNew() Handles mCtlForm.AddNew
        Try
            Call ShowForm(DataMode.ModeNew, 0)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "OrderControl.mCtlForm_AddNew : " & ex.Message)
        End Try
    End Sub

    Private Sub ShowForm(ByVal pMode As Integer, ByVal pID As Long)

        Try
            Select Case mOrderType
                Case MasterType.Bill, MasterType.Receipt, MasterType.ReceiptBuy, MasterType.ReceiptCut
                    Dim lFormEdit As New frmBill
                    With lFormEdit
                        .OrderType = mOrderType
                        .Caption = mCaption
                        .MdiParent = frmMain
                        .ModeData = pMode
                        .IDs = pID
                        .Show()
                    End With
                Case MasterType.StockIn, MasterType.UpdateStock
                    Dim lFormEdit As New frmStockIn
                    With lFormEdit
                        .OrderType = mOrderType
                        .Caption = mCaption
                        .MdiParent = frmMain
                        .ModeData = pMode
                        .IDs = pID
                        .Show()
                    End With
                Case Else
                    Dim lFormEdit As New frmOrderS
                    With lFormEdit
                        .OrderType = mOrderType
                        .Caption = mCaption
                        .MdiParent = frmMain
                        .ModeData = pMode
                        .IDs = pID
                        .Show()
                    End With
            End Select


        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "OrderControl.ShowForm : " & ex.Message)
        End Try
    End Sub

    Private Sub mCtlForm_CHeckRefresh() Handles mCtlForm.CHeckRefresh
        Dim lcls As New OrderSDAO
        Dim lCurrent As Long
        Try
            lcls.TableID = mOrderType
            lCurrent = lcls.CHECKSUM_AGG
            If mCHECKSUM_AGG <> lCurrent Then
                LoadData()
                mCHECKSUM_AGG = lCurrent
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "OrderControl.mCtlForm_CHeckRefresh : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    Private Sub mCtlForm_Copy(ByVal pID As Long) Handles mCtlForm.Copy
        Try
            Call ShowForm(DataMode.ModeCopy, pID)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "OrderControl.mCtlForm_Copy : " & ex.Message)
        End Try
    End Sub



    Private Sub mCtlForm_Delete(ByRef pID As Long) Handles mCtlForm.Delete
        Dim lcls As New OrderSDAO
        lcls.TableID = mOrderType
        Try
            If lcls.InitailData(pID) Then
                If lcls.CheckIsToUse = False Then  ''ถูกใช้งานอยู่ ???
                    If lcls.TableID = MasterType.StockIn Or (((lcls.TableID = MasterType.ReduceCredit) Or (lcls.TableID = MasterType.AddCredit) _
                    Or (lcls.TableID = MasterType.ReduceCreditBuy) Or (lcls.TableID = MasterType.AddCreditBuy)) And lcls.StockType = "I") Then
                        If lcls.CheckSNIsClose(lcls.ID, lcls.TableName, Nothing, Nothing) Then
                            pID = 1
                            Exit Sub
                        End If
                    End If


                    lcls.ID = pID
                    lcls.ModeData = DataMode.ModeDelete
                    If lcls.SaveData() Then
                        Call LoadData()
                    End If
                Else
                    pID = 0
                End If
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "OrderControl.mCtlForm_D.elete : " & ex.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    Private Sub mCtlForm_Edit(ByVal pID As Long) Handles mCtlForm.Edit
        Try
            Call ShowForm(DataMode.ModeEdit, pID)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "OrderControl.mCtlForm_Edit : " & ex.Message)
        End Try
    End Sub

    Private Sub mCtlForm_Import() Handles mCtlForm.Import
        frmImport.Show()
    End Sub

    Private Sub mCtlForm_InitDetail(ByVal pID As Long) Handles mCtlForm.InitDetail
        'Dim lclsLeadDAO As New LeadDAO

        'Try
        '    If lclsLeadDAO.InitailData(pID) Then

        '        mCtlForm.UcInfo1.Init(lclsLeadDAO.GetInfoHtml, Nothing)
        '    End If
        'Catch ex As Exception
        '    Err.Raise(Err.Number, ex.Source, "OrderControl.mCtlForm_InitDetail : " & ex.Message)
        'Finally
        '    lclsLeadDAO = Nothing
        'End Try
    End Sub

    Private Sub mCtlForm_InitStatus(ByVal pID As Long) Handles mCtlForm.InitStatus
        Dim lcls As New OrderSDAO
        Try
            lcls.TableID = mOrderType
            If lcls.InitailData(pID) Then
                If mCtlForm.MakeOrderBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
                    mCtlForm.MakeOrderBar.Enabled = (lcls.OrderStatus = EnumStatus.Open.ToString Or lcls.OrderStatus = EnumStatus.Approve.ToString Or lcls.OrderStatus = EnumStatus.Receive.ToString Or lcls.OrderStatus = EnumStatus.Waiting.ToString)
                    mCtlForm.MakeInvoiceAbbBar.Enabled = (lcls.OrderStatus = EnumStatus.Open.ToString Or lcls.OrderStatus = EnumStatus.Approve.ToString Or lcls.OrderStatus = EnumStatus.Receive.ToString Or lcls.OrderStatus = EnumStatus.Waiting.ToString)
                    mCtlForm.MakeInvoiceBar.Enabled = (lcls.OrderStatus = EnumStatus.Open.ToString Or lcls.OrderStatus = EnumStatus.Approve.ToString Or lcls.OrderStatus = EnumStatus.Receive.ToString Or lcls.OrderStatus = EnumStatus.Waiting.ToString)
                    mCtlForm.MakeInvoiceOnlineBar.Enabled = (lcls.OrderStatus = EnumStatus.Open.ToString Or lcls.OrderStatus = EnumStatus.Approve.ToString Or lcls.OrderStatus = EnumStatus.Receive.ToString Or lcls.OrderStatus = EnumStatus.Waiting.ToString)
                End If

                If mOrderType = MasterType.UpdateStock Then
                    mCtlForm.DeleteBar.Enabled = False
                Else
                    mCtlForm.DeleteBar.Enabled = (lcls.OrderStatus = EnumStatus.Open.ToString Or lcls.OrderStatus = EnumStatus.Waiting.ToString _
                                                  Or lcls.OrderStatus = EnumStatus.Approve.ToString) And lcls.IsDelete = False
                End If

            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "OrderControl.mCtlForm_InitStatus : " & ex.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    Private Sub mCtlForm_MakeOrder(ByVal pID As Long, ByVal pOrderType As Integer) Handles mCtlForm.MakeOrder
        Try
            Dim lFormEdit As New frmOrderS
            lFormEdit.MdiParent = frmMain
            lFormEdit.IDs = pID
            lFormEdit.ModeData = DataMode.ModeConvert

            If pOrderType = 0 Then
                Select Case mOrderType
                    Case MasterType.SellOrders
                        lFormEdit.OrderType = MasterType.Shiping
                        lFormEdit.Caption = GetCaption(MasterType.Shiping)
                    Case MasterType.Quotation, MasterType.Reserve
                        lFormEdit.OrderType = MasterType.SellOrders
                        lFormEdit.Caption = GetCaption(MasterType.SellOrders)
                End Select
            Else
                lFormEdit.OrderType = pOrderType
                lFormEdit.Caption = GetCaption(pOrderType)
            End If


            lFormEdit.Show()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "OrderControl.mCtlForm_MakeOrder : " & e.Message)
        End Try
    End Sub

    Private Sub mCtlForm_RefreshFind() Handles mCtlForm.RefreshFind
        Try
            Dim findText As String = mCtlForm.GridView.FindFilterText
            Dim lstrCon As String = InitialFilterMapping(mCtlForm.cboFindIn.SelectedItem)  'Call Global function
            mCtlForm.GridView.OptionsFind.FindFilterColumns = lstrCon
            mCtlForm.GridView.ApplyFindFilter(String.Empty)
            mCtlForm.GridView.ApplyFindFilter(findText)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "OrderControl.mCtlForm_ReLoad : " & ex.Message)
        End Try
    End Sub

    Private Sub mCtlForm_ReLoad() Handles mCtlForm.ReLoad
        Try
            Call LoadData()
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "OrderControl.mCtlForm_ReLoad : " & ex.Message)
        End Try
    End Sub


    'Private Function CheckSNIsClose(ByVal pOrderID As Long, ByVal pTableName As String) As Boolean
    '    Dim lSNTable As New DataTable
    '    Dim lclsOrder As New OrderSDAO
    '    Dim lProductDAOs As New List(Of ProductListDAO)
    '    Dim lOrderList As New List(Of Long), lclsSN As New SnDAO
    '    Dim lstrSNError As String = ""
    '    Try

    '        lProductDAOs = lclsOrder.BuildProductList(pOrderID, pTableName, Nothing)
    '        For Each pProList As ProductListDAO In lProductDAOs
    '            lOrderList = New List(Of Long)
    '            lOrderList.Add(pOrderID)

    '            lclsSN = New SnDAO
    '            lSNTable = lclsSN.GetDataTable(lOrderList, pProList.ID, pProList.ProductID, "", Nothing, False, "")
    '            lclsSN = Nothing
    '            For Each dr2 As DataRow In lSNTable.Rows
    '                lclsSN = New SnDAO
    '                If lclsSN.CheckSNIsExist(pProList.ProductID, ConvertNullToString(dr2("SerialNumberNo")), "'New'", Nothing) = False Then
    '                    If lstrSNError = "" Then
    '                        lstrSNError = ConvertNullToString(dr2("SerialNumberNo"))
    '                    Else
    '                        lstrSNError = lstrSNError & ", " & ConvertNullToString(dr2("SerialNumberNo"))
    '                    End If
    '                    Exit For
    '                End If
    '            Next
    '        Next
    '        If lstrSNError = "" Then
    '            Return False
    '        Else
    '            'XtraMessageBox.Show(Me, "Serial Number บางรายการถุก Close แล้ว" & vbNewLine & lstrSNError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
    '            Return True
    '        End If

    '    Catch ex As Exception
    '        Err.Raise(Err.Number, ex.Source, "OrderControl.CheckBeforeDelete : " & ex.Message)
    '    End Try
    'End Function
End Class
