Option Explicit On
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmOrderHis2
    Inherits iEditForm

    Private Const mFormName As String = "frmOrderHis2"
    Private mIsFromLoad As Boolean
#Region "Overrides"
    Protected Overrides Sub OnLoadForm(ByVal pMode As Integer, ByVal pID As Long, ByVal pOrderType As Long, ByVal pclsConvert As iOrder, ByVal pCusID As Long)
        Try
            SaveBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Addbar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            PrintPaymantBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            PrintBar2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            chkShowDelete.Checked = False

            mIsFromLoad = True
            dtpDateFrom.EditValue = DateAdd(DateInterval.Month, -1, GetCurrentDate(Nothing))
            dtpDateTo.EditValue = GetCurrentDate(Nothing)
            ExportPrivilege()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".OnLoadForm : " & e.Message)
        Finally
            mIsFromLoad = False
        End Try
    End Sub

    Protected Overrides Sub ClearAllForm(ByVal pMode As Integer)
        Try
            mIsFromLoad = True
            MyBase.ClearAllForm(pMode)


        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".ClearAllForm : " & e.Message)
        Finally
            mIsFromLoad = False
        End Try
    End Sub

    Protected Overrides Function Save(ByVal pMode As Integer, ByVal pID As Long) As Boolean

        Try

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".Save : " & ex.Message)
            Return False
        End Try
    End Function

    Protected Overrides Sub OnClosedForm()
        'mcls = Nothing

    End Sub
#End Region

#Region "Event"


#End Region

#Region "Private"


    Private Function LoadData() As Boolean
        Dim SQL As String = ""
        Dim dataTable As New DataTable()
        Dim lstrOrderType As String = ""
        Dim lTimeout As Long = 0
        Try
            lstrOrderType = InitialOrderType()


            SQL = " select Orders.OrderID,Cheque.ChequeDateReceive  ,Cheque.ChequePay as OrderTotal,BankAccountCode,Orders.OrderDate ,Orders.OrderCode   "
            SQL &=  " ,CASE WHEN Customer.CompanyName <>'' THEN Customer.CompanyName ELSE Customer.Title + Customer.Firstname + ' ' + Customer.LastName END Customer "
            SQL &=  " ,Orders.GrandTotal as ReceiptTotal "
            SQL &=  " ,isnull(Orders.DiscountAmount,0)+ isnull(TaxOrder.TaxAmount,0) DiscountAmount"
            SQL &=  " ,Receipt.OrderCode AS ReceiptCode,Receipt.OrderDate as ReceiptDate,BankDocType,ChequeNo,Orders.IsDelete"
            SQL &=  " ,case when Receipt.ModifiedTime is not null then Receipt.ModifiedTime else Receipt.CreateTime end CreateTime"
            SQL &=  " from Orders"
            'SQL = SQL & " left outer join Menu on Orders.TableID=Menu.MenuID"
            SQL &=  " inner join Customer ON Orders.CustomerID=Customer.CustomerID  "
            SQL &=  " LEFT OUTER JOIN Orders AS Receipt ON Orders.RefReceiptID=Receipt.OrderID and Receipt.IsDelete=0 " 'and Receipt.TableID in(" & MasterType.Receipt & "," & MasterType.ReceiptCut & ")"
            SQL &=  " LEFT OUTER JOIN Cheque  ON Cheque.RefOrderID=Receipt.OrderID  "
            'SQL = SQL & " LEFT OUTER JOIN OrdersDetail  ON OrdersDetail.BillID=Receipt.OrderID and OrdersDetail.OrderID=Orders.OrderID  and OrdersDetail.IsDelete=0  "
            SQL &=  " LEFT OUTER JOIN TaxOrder  ON TaxOrder.RefOrderID=Receipt.OrderID   "
            SQL &=  " LEFT OUTER JOIN BankAccount  ON BankAccount.BankAccountID=Cheque.BankAccountID   "
            SQL &=  " WHERE Orders.OrderDate between '" & formatSQLDate(dtpDateFrom.EditValue) & "'" & "  and '" & formatSQLDate(dtpDateTo.EditValue) & "'"
            SQL &=  "  AND Orders.TableID in (" & lstrOrderType & ")"

            If chkShowDelete.Checked = False Then
                SQL &=  "  AND Orders.IsDelete = 0"
                SQL &=  "  AND Orders.IsCancel = 0"
            End If
            SQL &=  " ORDER BY  Orders.OrderID,Orders.OrderDate"


            dataTable = gConnection.executeSelectQuery(SQL, Nothing)

            If dataTable.Rows.Count > 0 Then
                gridControl.DataSource = dataTable
                GridView.ViewCaption = ""
                GridView.MoveLastVisible()
                Call GridStyle()
            Else
                gridControl.DataSource = Nothing
            End If



        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".LoadData : " & ex.Message)
            Return False
        Finally
            'lcls = Nothing
            'dataTable = Nothing
        End Try
    End Function


    Private Function InitialOrderType() As String
        Dim lstrOrderType As String = "0"
        Try


            If CheckInvoice.Checked = True Then
                lstrOrderType = lstrOrderType & "," & MasterType.Invoice
            End If
            If CheckInvoiceOnline.Checked = True Then
                lstrOrderType = lstrOrderType & "," & MasterType.InvoiceOnline
            End If
            If CheckInvoiceAbb.Checked = True Then
                lstrOrderType = lstrOrderType & "," & MasterType.InvoiceAbb
            End If
            If CheckInvoiceBuy.Checked = True Then
                lstrOrderType = lstrOrderType & "," & MasterType.InvoiceBuy
            End If

            If CheckReceiptCut.Checked = True Then
                lstrOrderType = lstrOrderType & "," & MasterType.ReceiptCut
            End If
            If CheckReduceCredit.Checked = True Then
                lstrOrderType = lstrOrderType & "," & MasterType.ReduceCredit
            End If
            If CheckReduceCreditBuy.Checked = True Then
                lstrOrderType = lstrOrderType & "," & MasterType.ReduceCreditBuy
            End If

            If CheckShiping.Checked = True Then
                lstrOrderType = lstrOrderType & "," & MasterType.Shiping
            End If
            If CheckShipingBuy.Checked = True Then
                lstrOrderType = lstrOrderType & "," & MasterType.ShipingBuy
            End If

            Return lstrOrderType
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".InitialOrderType : " & ex.Message)
            Return False
        Finally

        End Try
    End Function

    Private Function ExportPrivilege() As Boolean
        Dim lcls As New PrivilegeDAO
        Dim lIsEnable As Boolean
        Try

            If lcls.InitailData(gPrivilegeID, MasterType.OrderHisExport) Then

                PanelControl1.Visible = (lcls.PrivilegeData And Privilege.Visible) = Privilege.Visible
                lIsEnable = (lcls.PrivilegeData And Privilege.Enable) = Privilege.Enable
                btnExportExcel.Enabled = lIsEnable

            Else
                btnExportExcel.Enabled = False
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".ExportPrivilege : " & ex.Message)
            Return False
        Finally
            lcls = Nothing
        End Try
    End Function

    Private Sub GridStyle()
        With gridView

            .Columns("IsDelete").Visible = False
            .Columns("OrderID").Visible = False
            .Columns("OrderID").Caption = "รหัส"
            .Columns("OrderID").Width = 50

            .Columns("OrderCode").Caption = "ใบกำกับ-ใบส่งของ"
            .Columns("OrderCode").Width = 100
            '.Columns("MenuDisplay").Caption = "รายการ"
            '.Columns("MenuDisplay").Width = 90
            .Columns("ChequeDateReceive").Caption = "วันที่ชำระ"
            .Columns("ChequeDateReceive").Width = 100

            .Columns("OrderDate").Caption = "วันที่ใบกำกับ-ใบส่งของ"
            .Columns("OrderDate").Width = 100

            .Columns("BankAccountCode").Width = 150
            .Columns("BankAccountCode").Caption = "เลขบัญชี"

            .Columns("Customer").Width = 150
            .Columns("Customer").MaxWidth = 0
            .Columns("Customer").MinWidth = 150
            .Columns("Customer").Caption = "ลูกค้า/เจ้าหนี้"

            .Columns("OrderTotal").Caption = "ยอดชำระ"
            .Columns("OrderTotal").Width = 100
            .Columns("OrderTotal").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            .Columns("OrderTotal").DisplayFormat.FormatString = "n2"


            .Columns("ReceiptTotal").Caption = "ยอดรวมบิล"
            .Columns("ReceiptTotal").Width = 100
            .Columns("ReceiptTotal").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            .Columns("ReceiptTotal").DisplayFormat.FormatString = "n2"

            .Columns("DiscountAmount").Caption = "ยอดหัก"
            .Columns("DiscountAmount").Width = 100
            .Columns("DiscountAmount").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            .Columns("DiscountAmount").DisplayFormat.FormatString = "n2"

            .Columns("ReceiptCode").Width = 100
            .Columns("ReceiptCode").Caption = "เลขที่ใบเสร็จ"

            .Columns("CreateTime").Width = 150
            .Columns("CreateTime").Caption = "วันสร้าง/แก้ไข"
            .Columns("CreateTime").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            .Columns("CreateTime").DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"

            .Columns("ReceiptDate").Caption = "วันที่ใบเสร็จ"
            .Columns("ReceiptDate").Width = 100

            .Columns("BankDocType").Width = 100
            .Columns("BankDocType").Caption = "ชำระโดย"

            .Columns("ChequeNo").Width = 100
            .Columns("ChequeNo").Caption = "เลขที่เช็ค-เอกสาร"
        End With
    End Sub

#End Region

    Private Sub GridView_RowStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles gridView.RowStyle
        Dim lData As Integer = 0
        If DatePanel.Visible = True Then
            If (e.RowHandle >= 0) Then

                lData = GridView.GetRowCellValue(e.RowHandle, GridView.Columns("IsDelete"))
                If lData = 1 Then
                    e.Appearance.BackColor = Color.WhiteSmoke
                    e.Appearance.ForeColor = Color.Red
                End If

            End If
        End If

    End Sub


    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Try
            ShowProgress(True, "Loading...")
            LoadData()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub btnExportExcel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExportExcel.Click
        Try
            Dim lfrm As New frmPreExport
            lfrm.InitialForm("OrderHistory", gridControl)
            lfrm.ShowDialog()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try
    End Sub

    Private Sub CheckAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckAll.CheckedChanged
        Dim lCheck As Boolean = False

        lCheck = CheckAll.Checked


        CheckInvoice.Checked = lCheck
        CheckInvoiceBuy.Checked = lCheck

        CheckReceiptCut.Checked = lCheck
        CheckReduceCredit.Checked = lCheck
        CheckReduceCreditBuy.Checked = lCheck

        CheckShiping.Checked = lCheck
        CheckShipingBuy.Checked = lCheck

    End Sub


End Class