Option Explicit On
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmSellOrderHis
    Inherits iEditForm

    Private Const mFormName As String = "frmSellOrderHis"
    'Private mcls As New InformPriceDAO
    Private mIsFromLoad As Boolean
    'Private mMode As DataMode
    'Private mProductList As New List(Of ProductListDAO)
    'Private mOrderType As MasterType

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

            Dim lOrderList As New List(Of Long)
            lOrderList.Add(0)
            UcProductLists1.ShowControl(pMode, lOrderList, "", 0, False, True, Nothing, True, "", False, False, "")
            UcCustomer1.ShowControl(0, 0, False)
            ExportPrivilege()

            'CheckOrders.Checked = True
            CheckInvoice.Checked = True
            CheckQuotation.Checked = True
            CheckShiping.Checked = True
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
        Dim lstrProList As String = ""
        Dim lstrCusList As String = ""
        Dim lToCont As Boolean = False
        Dim lTimeout As Long = 0
        Try
            lstrOrderType = InitialOrderType()
            lstrCusList = InitialCustomerList()
            lstrProList = InitialProList()

            lToCont = True

            'SQL = " select Orders.OrderID "
            'SQL = SQL & " from Orders"
            'SQL = SQL & " WHERE Orders.OrderDate between '" & formatSQLDate(dtpDateFrom.EditValue) & "'" & "  and '" & formatSQLDate(dtpDateTo.EditValue) & "'"
            'SQL = SQL & "  AND Orders.TableID in (" & lstrOrderType & ")"
            'If chkShowDelete.Checked = False Then
            '    SQL &=  "  AND Orders.IsDelete = 0"
            '    SQL &=  "  AND Orders.IsCancel = 0"
            'End If
            'dataTable = gConnection.executeSelectQuery(SQL, Nothing)

            'If dataTable.Rows.Count > 1000 Then
            '    If XtraMessageBox.Show(Me, "พบข้อมูลประวัติตามเงื่อนไขมีจำนวนมาก อาจทำให้การโหลดข้อมูลช้า ยืนยันทำรายการต่อใช่หรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            '        lToCont = True
            '    End If
            'Else
            '    lToCont = True
            'End If
            If lToCont = True Then
                SQL = " select Orders.OrderDate,Orders.OrderCode ,Menu.MenuDisplay "
                SQL &=  " ,CASE WHEN Customer.CompanyName <>'' THEN Customer.CompanyName ELSE Customer.Title + Customer.Firstname + ' ' + Customer.LastName END Customer "
                SQL &=  " ,Product.ProductCode,Product.ProductName,Product.Remark"
                SQL &=  " ,ProductList.Units,ProductList.Price ,Orders.IsDelete,Orders.OrderStatus"
                'SQL = SQL & " ,Product_LocationDTL.IDCode as Location "
                SQL &=  " from Orders"
                SQL &=  " inner join ProductList on Orders.OrderID=ProductList.RefID"
                SQL &=  " inner join Product on Product.ProductID= ProductList.ProductID"
                SQL &=  " left outer join Menu on Orders.TableID=Menu.MenuID"
                'SQL = SQL & " inner join Product_LocationDTL on Product_LocationDTL.LocationDTLID=ProductList.LocationDTLID"
                SQL &=  " left outer join Customer ON Orders.CustomerID=Customer.CustomerID  "
                SQL &=  " WHERE Orders.OrderDate between '" & formatSQLDate(dtpDateFrom.EditValue) & "'" & "  and '" & formatSQLDate(dtpDateTo.EditValue) & "'"
                SQL &=  "  AND Orders.TableID in (" & lstrOrderType & ")"
                If chkShowDelete.Checked = False Then
                    SQL &=  "  AND Orders.IsDelete = 0"
                    SQL &=  "  AND Orders.IsCancel = 0"
                    SQL &=  "  AND ProductList.IsDelete = 0"
                End If
                SQL &=  "  AND ProductList.IsShow = 1"
                SQL &=  "  AND Orders.CustomerID in (" & lstrCusList & ")"
                SQL &=  "  AND ProductList.ProductID in (" & lstrProList & ")"
                SQL &=  " ORDER BY  Orders.OrderID,Product.ProductName"
                dataTable = gConnection.executeSelectQuery(SQL, Nothing)

                If dataTable.Rows.Count > 0 Then
                    gridControl.DataSource = dataTable
                    gridView.ViewCaption = ""
                    gridView.MoveLastVisible()
                    Call GridStyle()
                Else
                    gridControl.DataSource = Nothing
                End If
            End If




        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".LoadData : " & ex.Message)
            Return False
        Finally
        End Try
    End Function


    Private Function InitialOrderType() As String
        Dim lstrOrderType As String = "0"
        Try
            If CheckOrders.Checked = True Then
                lstrOrderType = lstrOrderType & "," & MasterType.SellOrders
            End If
            If CheckInvoice.Checked = True Then
                lstrOrderType = lstrOrderType & "," & MasterType.Invoice
            End If
            If CheckInvoiceOnline.Checked = True Then
                lstrOrderType = lstrOrderType & "," & MasterType.InvoiceOnline
            End If
            If CheckQuotation.Checked = True Then
                lstrOrderType = lstrOrderType & "," & MasterType.Quotation
            End If
            If CheckShiping.Checked = True Then
                lstrOrderType = lstrOrderType & "," & MasterType.Shiping
            End If
            Return lstrOrderType
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".InitialOrderType : " & ex.Message)
            Return False
        Finally

        End Try
    End Function

    Private Function InitialCustomerList() As String
        Dim lstrCustomerList As String = "0"
        Dim lCustomerList As New List(Of CustomerListDAO)
        Try
            lCustomerList = UcCustomer1.GetDAOs()
            For Each pcls As CustomerListDAO In lCustomerList
                If lstrCustomerList = "" Then
                    lstrCustomerList = pcls.CustomerID
                Else
                    lstrCustomerList = lstrCustomerList & "," & pcls.CustomerID
                End If
            Next
            Return lstrCustomerList
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".InitialCustomerList : " & ex.Message)
            Return False
        Finally

        End Try
    End Function

    Private Function InitialProList() As String
        Dim lstrList As String = "0"
        Dim lProList As New List(Of ProductListDAO)
        Try
            lProList = UcProductLists1.GetDAOs(False, False, False, Nothing, False, 0, False, "", DataMode.ModeNew, "")
            For Each pcls As ProductListDAO In lProList
                If lstrList = "" Then
                    lstrList = pcls.ProductID
                Else
                    lstrList = lstrList & "," & pcls.ProductID
                End If
            Next
            Return lstrList
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".InitialProList : " & ex.Message)
            Return False
        Finally

        End Try
    End Function


    Private Function ExportPrivilege() As Boolean
        Dim lcls As New PrivilegeDAO
        Dim lIsEnable As Boolean
        Try

            If lcls.InitailData(gPrivilegeID, MasterType.OrderSellHisExp) Then

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

            '.Columns("OrderID").Caption = "รหัส"
            '.Columns("OrderID").Width = 50

            .Columns("OrderCode").Caption = "เลขที่"
            .Columns("OrderCode").Width = 100
            .Columns("MenuDisplay").Caption = "รายการ"
            .Columns("MenuDisplay").Width = 90
            .Columns("OrderDate").Caption = "วันที่"
            .Columns("OrderDate").Width = 50
            .Columns("ProductCode").Caption = "รหัสสินค้า"
            .Columns("ProductCode").Width = 100
            .Columns("ProductName").Caption = "ชื่อสินค้า"
            .Columns("ProductName").Width = 200
            .Columns("Remark").Caption = "รายละเอียดสินค้า"
            .Columns("Units").Caption = "จำนวน"
            .Columns("Units").Width = 50
            .Columns("Units").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            .Columns("Units").DisplayFormat.FormatString = "n0"
            .Columns("IsDelete").Caption = "Delete"
            .Columns("IsDelete").Width = 10
            .Columns("Customer").Width = 150
            .Columns("Customer").Caption = "ลูกค้า"
            .Columns("Price").Caption = "ราคาขาย"
            .Columns("Price").Width = 50
            .Columns("Price").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            .Columns("Price").DisplayFormat.FormatString = "n2"
            '.Columns("Location").Width = 100
            '.Columns("Location").Caption = "คลังในรายการ"
            .Columns("OrderStatus").Width = 60
            .Columns("OrderStatus").Caption = "สถานะ"
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
            lfrm.InitialForm("OrderSellHistory", gridControl)
            lfrm.ShowDialog()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try
    End Sub

    Private Sub CheckAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckAll.CheckedChanged
        Dim lCheck As Boolean = False
        lCheck = CheckAll.Checked
        CheckOrders.Checked = lCheck
        CheckInvoice.Checked = lCheck
        CheckQuotation.Checked = lCheck
        CheckShiping.Checked = lCheck
    End Sub

End Class