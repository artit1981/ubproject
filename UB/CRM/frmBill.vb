Option Explicit On

Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Public Class frmBill
    Inherits iEditForm
    Private Const mFormName As String = "frmBill"
    Private mcls As New OrderSDAO
    Private mIsFromLoad As Boolean
    Private mMode As DataMode
    Private mOrderType As MasterType
    Private mTaxOrderTotal As Double
#Region "Overrides"
    Protected Overrides Sub OnLoadForm(ByVal pMode As Integer, ByVal pID As Long, ByVal pOrderType As Long, ByVal pclsConvert As iOrder, ByVal pCusID As Long)
        Try
            mOrderType = pOrderType
            mcls.TableID = mOrderType
            mMode = pMode
            mIsFromLoad = True
            InitialCombo()

            LayoutBillMethod.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutbtnShipingMethod.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutPayType.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutCreditBalance.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            PrintPaymantBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            If mOrderType = MasterType.Bill Then
                LayoutBillMethod.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                LayoutbtnShipingMethod.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            ElseIf mOrderType = MasterType.Receipt Then
                LayoutPayType.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                ChequeTabPage.Text = "รายการรับ"
            ElseIf mOrderType = MasterType.ReceiptCut Then
                LayoutPayType.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                VatTabPage.PageEnabled = False
            ElseIf mOrderType = MasterType.ReceiptBuy Then
                LayoutControlItem4.Text = "เจ้าหนี้"
                ChequeTabPage.Text = "รายการจ่าย"
            End If
            Call LoadData(pMode, pID)

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
            Select Case pMode
                Case DataMode.ModeNew
                    ClearForm(GeneralTabPage)
                    ClearForm(UcAdmin1)
                    UcFileAttach1.ClearControl()
                    UcNote1.ClearControl()
                    UcOrderList1.ClearControl()
                    UcCheque1.ClearControl()
                    'Un Lockcontrol
                    OrderCode.Properties.ReadOnly = False
                    OrderDate.Properties.ReadOnly = False
                    CustomerID.Properties.ReadOnly = False

            End Select

            XtraTabControl1.SelectedTabPage = GeneralTabPage
            OrderCode.Select()
            OrderDate.EditValue = GetCurrentDate(Nothing)
            TaxMonthYear.EditValue = OrderDate.EditValue
            PayDate.EditValue = OrderDate.EditValue
            UcAdmin1.CheckInAcive.Enabled = False
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".ClearAllForm : " & e.Message)
        Finally
            mIsFromLoad = False
        End Try
    End Sub

    Protected Overrides Function Save(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        Dim lChequePayAmt As Decimal = 0
        XtraTabControl1.SelectedTabPage = GeneralTabPage
        Try
            Calculation()
            mcls.TableID = mOrderType
            mcls.ID = pID
            mcls.ModeData = pMode
            mcls.Code = OrderCode.Text.Trim
            mcls.OrderDate = OrderDate.EditValue
            mcls.ExpireDate = PayDate.EditValue
            mcls.CustomerID = ConvertNullToZero(CustomerID.EditValue)
            mcls.BillMedthodID = ConvertNullToZero(BillMethod.EditValue)
            mcls.EmpID = ConvertNullToZero(EmpID.EditValue)
            mcls.PayType = PayType.EditValue
            mcls.Remark = Remark.Text.Trim
            mcls.IsInActive = UcAdmin1.CheckInAcive.Checked
            mcls.NoteDAOs = UcNote1.GetNoteDAOs
            mcls.FileAttachs = UcFileAttach1.GetFileAttachs
            mcls.OrderDAOs = UcOrderList1.GetDAOs()
            mcls.Total = ConvertNullToZero(Total.EditValue)
            mcls.DiscountPercen = ConvertNullToZero(DiscountPercen.EditValue)
            mcls.DiscountAmount = ConvertNullToZero(DiscountAmount.EditValue)
            mcls.GrandTotal = ConvertNullToZero(GrandTotal.EditValue)
            mcls.CurrencyID = ConvertNullToZero(cboCurrency.EditValue)
            mcls.ExchangeRate = ConvertNullToZero(Exchange.EditValue)
            mcls.TaxCanYes = IIf(TaxCanYes.Checked = True, "Y", "N")
            mcls.TaxCondition = ConvertNullToString(TaxCondition.EditValue)
            mcls.TaxMonthYear = TaxMonthYear.EditValue
            mcls.TaxNumber = ConvertNullToString(TaxNumber.EditValue)
            mcls.TaxRemark = ConvertNullToString(TaxRemark.EditValue)
            mcls.TaxSection = ConvertNullToString(TaxSection.EditValue)
            mcls.TaxType = ConvertNullToString(TaxType.EditValue)
            mcls.TaxTotal = ConvertNullToZero(TotalTax.EditValue)
            mcls.ChequeDAOs = UcCheque1.GetDAOs(lChequePayAmt)
            mcls.TaxOrderDAOs = GetTaxOrderList()
            If Verify(lChequePayAmt) = True Then
                Call mcls.SaveData()
                    ShowProgress(False, "")
                    If mOrderType = MasterType.ReceiptCut Then
                        XtraMessageBox.Show(Me, "บันทึกรายการสำเร็จ", "บันทึก", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        ShowProgress(False, "")
                    Else
                        If XtraMessageBox.Show(Me, "บันทึกรายการสำเร็จ ต้องการพิมพ์เอกสารหรือไม่ ?", "พิมพ์เอกสาร", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                            modReport.PrintReportOrder(mOrderType, mcls.ID)
                        End If
                    End If

                    PrintPaymantBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    'PrintChequeBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                    Return True
               
            Else
                ShowProgress(False, "")
                XtraMessageBox.Show(Me, "พบข้อผิดพลาดกรุณาตรวจสอบ", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".Save : " & ex.Message)
            Return False
        End Try
    End Function

    Protected Overrides Sub OnClosedForm()
        mcls = Nothing
    End Sub

    Protected Overrides Sub PrintOrder(ByVal pID As Long, ByVal pPrintType As Long)
        Select Case pPrintType
            Case 3
            Case 2
                modReport.PrintPayment(pID)
            Case Else
                modReport.PrintReportOrder(mOrderType, pID)
        End Select
    End Sub

#End Region

#Region "Event"

    Private Sub OrderDate_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles OrderDate.EditValueChanged
        Try
            If mIsFromLoad = False Then
                TaxMonthYear.EditValue = OrderDate.EditValue
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".OrderDate_EditValueChanged : " & ex.Message)
        Finally
        End Try
    End Sub
    Private Sub FormChangedComponent1_FormControlChanged1(ByVal sender As Object, ByVal e As FormChangedEventArgs) Handles FormChangedComponent1.FormControlChanged
        MyBase.CheckFormChanged()
    End Sub


    Private Sub btnCustomerID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomerID.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboCustomer()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub btnEmpID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpID.Click
        Try
            ShowProgress(True, "Loading...")
            SetEmployees()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub btnShipingMethod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShipingMethod.Click
        Try
            ShowProgress(True, "Loading...")
            SetBillMedthod()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub



    Private Sub btnGenID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenID.Click
        Try
            ShowProgress(True, "Loading...")
            OrderCode.EditValue = AutoGenCode(mOrderType)
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub


    Private Sub EmpID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpID.EditValueChanged
        Dim lcls As New EmployeeDAO
        Dim lEmpID As Long
        Try
            Territory.EditValue = ""
            lEmpID = ConvertNullToZero(EmpID.EditValue)
            If lEmpID > 0 Then
                If lcls.InitailData(lEmpID) Then
                    Territory.EditValue = lcls.TerritoryDAOs.NameThai
                End If
            End If
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    Private Sub CustomerID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerID.EditValueChanged
        Dim lCusID As Long
        Try
            lCusID = ConvertNullToZero(CustomerID.EditValue)
            If mIsFromLoad = False Then
                InitialCusInfo(lCusID)
            End If
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub cboCurrency_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCurrency.EditValueChanged
        Try
            InitialCurrency(ConvertNullToZero(cboCurrency.EditValue))

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".cboCurrency_EditValueChanged : " & ex.Message)
        Finally

        End Try
    End Sub
    Private Sub DiscountPercen_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiscountPercen.EditValueChanged
        If mIsFromLoad = False Then
            If DiscountPercen.EditValue > 100 Then
                DiscountPercen.EditValue = 100
            ElseIf DiscountPercen.EditValue < 0 Then
                DiscountPercen.EditValue = 0
            Else

            End If
        End If

    End Sub

    Private Sub DiscountPercen_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DiscountPercen.LostFocus
        If mIsFromLoad = False Then
            If DiscountPercen.EditValue > 100 Then
                DiscountPercen.EditValue = 100
            ElseIf DiscountPercen.EditValue < 0 Then
                DiscountPercen.EditValue = 0
            Else
                DiscountAmount.EditValue = Total.EditValue * (DiscountPercen.EditValue / 100)
                Calculation()
            End If
        End If
    End Sub
    Private Sub DiscountAmount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DiscountAmount.LostFocus
        If mIsFromLoad = False Then
            If DiscountAmount.EditValue = 0 Then
                DiscountPercen.EditValue = 0
            Else
                DiscountPercen.EditValue = (DiscountAmount.EditValue * 100) / Total.EditValue
                Calculation()
            End If
        End If
    End Sub
#End Region

#Region "Private"

    Private Sub InitialCombo()
        Try
            SetBillMedthod()
            SetEmployees()
            SetComboCustomer()
            SetCurrency()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".InitialCombo : " & e.Message)
        End Try
    End Sub

    Private Function LoadData(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        Dim lclsProvince As New ProvinceDAO
        Try
            mcls.TableID = mOrderType

            If pMode = DataMode.ModeNew Then
                OrderCode.EditValue = AutoGenCode(mOrderType)
                TaxNumber.EditValue = AutoGenCode(MasterType.TaxNumber)
                EmpID.EditValue = gEmpID
            ElseIf pMode = DataMode.ModeEdit Then
                If mcls.InitailData(pID) Then

                    OrderCode.EditValue = mcls.Code
                    OrderDate.EditValue = mcls.OrderDate
                    PayDate.EditValue = mcls.ExpireDate
                    PayType.EditValue = mcls.PayType
                    UcAdmin1.CheckInAcive.Checked = mcls.IsInActive
                    UcAdmin1.txtCreateBy.Text = mcls.CreateBy.Trim
                    UcAdmin1.txtCreateTime.Text = mcls.CreateTime
                    UcAdmin1.txtModifiBy.Text = mcls.ModifiedBy.Trim
                    UcAdmin1.txtModifiTime.Text = mcls.ModifiedTime

                    ''FileAttachs
                    UcFileAttach1.ShowControl(mcls.FileAttachs)

                    'Lockcontrol
                    OrderDate.Properties.ReadOnly = True
                    CustomerID.Properties.ReadOnly = True

                    CustomerID.EditValue = mcls.CustomerID
                    BillMethod.EditValue = mcls.BillMedthodID
                    EmpID.EditValue = mcls.EmpID
                    Total.EditValue = FormatNumber(mcls.Total, 2)
                    DiscountPercen.EditValue = FormatNumber(mcls.DiscountPercen, 2)
                    DiscountAmount.EditValue = FormatNumber(mcls.DiscountAmount, 2)
                    TotalAfterDis.EditValue = FormatNumber(Total.EditValue - mcls.DiscountAmount, 2)
                    GrandTotal.EditValue = FormatNumber(mcls.GrandTotal, 2)
                    gGrandAmount = GrandTotal.EditValue
                    cboCurrency.EditValue = mcls.CurrencyID
                    Exchange.EditValue = mcls.ExchangeRate
                    Remark.EditValue = mcls.Remark
                    IIf(mcls.TaxCanYes = "Y", TaxCanYes.Checked, TaxCanNo.Checked)
                    TaxCondition.EditValue = mcls.TaxCondition
                    TaxMonthYear.EditValue = mcls.TaxMonthYear
                    If mcls.TaxNumber = "" Then
                        TaxNumber.EditValue = AutoGenCode(MasterType.TaxNumber)
                    Else
                        TaxNumber.EditValue = mcls.TaxNumber
                    End If


                    TaxRemark.EditValue = mcls.TaxRemark
                    TaxSection.EditValue = mcls.TaxSection
                    TaxType.EditValue = mcls.TaxType
                    TotalTax.EditValue = mcls.TaxTotal
                    ContactName.EditValue = mcls.CustomerDAO.AddressS.ContactName
                    'If mOrderType = MasterType.Receipt Then
                    '    PrintPaymantBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    '    PrintChequeBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    'End If
                End If
            End If
            LoadTaxOrder(pID)
            InitialCusTaxInfo(ConvertNullToZero(CustomerID.EditValue), Nothing)
            gCustomerID = ConvertNullToZero(CustomerID.EditValue)
            UcCheque1.ShowControl(False, pID)
            UcNote1.ShowControl(mcls.TableName, pID)
            UcOrderList1.ShowControl(Nothing, mcls.ID, mcls.OrderDate, mMode <> DataMode.ModeNew, ucOrderList.OrdColumn.BillTotal, False, Me, mOrderType, True)
            'UcOrderList1.ShowControl(Nothing, mcls.ID, mcls.OrderDate, False, ucOrderList.OrdColumn.BillTotal, False, Me, mOrderType, True)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".LoadData : " & ex.Message)
            Return False
        Finally
            lclsProvince = Nothing
        End Try
    End Function

    Private Function Verify(ByVal pChequeAmt As Decimal) As Boolean
        Dim lTotal As Decimal = 0
        Dim lstrErr As String = ""
        Try
            DxErrorProvider1.ClearErrors()
            If Trim(OrderCode.Text) = "" Then
                SetErrorProvider(DxErrorProvider1, OrderCode, "กรุณาระบุเลขที่เอกสาร")
            ElseIf mcls.CheckExist() Then
                SetErrorProvider(DxErrorProvider1, OrderCode, "เลขที่เอกสารซ้ำ")
            End If
            lstrErr = lstrErr & DxErrorProvider1.GetError(OrderCode) & vbNewLine

            If ConvertNullToZero(CustomerID.EditValue) = 0 Then
                If mOrderType = MasterType.ReceiptBuy Then
                    SetErrorProvider(DxErrorProvider1, CustomerID, "กรุณาระบุเจ้าหนี้")
                Else
                    SetErrorProvider(DxErrorProvider1, CustomerID, "กรุณาระบุลูกค้า")
                End If

                lstrErr = lstrErr & DxErrorProvider1.GetError(CustomerID) & vbNewLine
            End If

            Call UcOrderList1.GetDAOs()
            lTotal = UcOrderList1.Totals
            If lTotal = 0 Then
                lstrErr = lstrErr & "ระบุยอดชำระ" & vbNewLine

            End If

            If lstrErr.Trim <> "" Then
                lstrErr = "พบข้อผิดพลาดกรุณาตรวจสอบ : " & vbNewLine & lstrErr
                XtraMessageBox.Show(Me, lstrErr, "ตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Else
                If pChequeAmt > 0 Then
                    If pChequeAmt < mcls.GrandTotal Then
                        If XtraMessageBox.Show(Me, "ยอดชำระ ต่ำกว่ายอดรวม ยืนยันการทำรายการหรือไม่ ?", "ตรวจสอบ", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                            Return True
                        Else
                            Return False
                        End If
                    End If
                End If
                Return True
            End If
            Return DxErrorProvider1.HasErrors = False
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".Verify : " & e.Message)
        End Try
    End Function

    Friend Sub Calculation()
        Try
            If mIsFromLoad = False Then
                UcOrderList1.GetDAOs()
                Total.EditValue = UcOrderList1.Totals

                If Total.EditValue = 0 Then
                    TotalAfterDis.EditValue = 0
                    GrandTotal.EditValue = 0
                    TotalAfterDis.EditValue = 0
                    TotalTax.EditValue = 0
                Else
                    TotalAfterDis.EditValue = Total.EditValue - DiscountAmount.EditValue
                    TotalTax.EditValue = mTaxOrderTotal
                    GrandTotal.EditValue = (TotalAfterDis.EditValue - TotalTax.EditValue) * ConvertNullToZero(Exchange.EditValue)
                End If
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".Calculation : " & e.Message)
        Finally
            gGrandAmount = ConvertNullToZero(GrandTotal.EditValue)

        End Try
    End Sub

    Private Sub InitialCurrency(ByVal plngCurrencyID As Long)
        Dim lcls As CurrencyDAO
        Try
            If plngCurrencyID > 0 And mIsFromLoad = False Then
                lcls = New CurrencyDAO
                If lcls.InitailData(plngCurrencyID) Then
                    Exchange.EditValue = lcls.ExchangeRate
                Else
                    Exchange.EditValue = 1
                End If
                Calculation()
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".InitialCurrency : " & ex.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub


    Private Sub InitialCusInfo(ByVal plngCustomerID As Long)
        Dim lcls As New CustomerDAO
        Dim lclsCredit As CreditBalanceDAO
        Try
            CreditBalance.EditValue = ""
            If mIsFromLoad = False And plngCustomerID > 0 Then
                gCustomerID = plngCustomerID
                lcls = New CustomerDAO
                lcls.InitailData(plngCustomerID)
                InitialCusTaxInfo(plngCustomerID, lcls)
                cboCurrency.EditValue = lcls.CurrencyID
                EmpID.EditValue = lcls.EmpID
                lclsCredit = New CreditBalanceDAO
                lclsCredit.InitailCreditBalance(plngCustomerID)
                CreditBalance.EditValue = lclsCredit.CreditAmount
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".InitialCusInfo : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    Private Sub InitialCusTaxInfo(ByVal plngCustomerID As Long, ByVal pclsCustomer As CustomerDAO)

        Try
            If plngCustomerID > 0 Then
                If pclsCustomer Is Nothing Then
                    pclsCustomer = New CustomerDAO
                    pclsCustomer.InitailData(plngCustomerID)
                End If

                TaxCusname.EditValue = pclsCustomer.CustomerName
                TaxCusAddress.EditValue = pclsCustomer.AddressS.AddressLong
                TaxCusCardID.EditValue = pclsCustomer.HistoryDAO.IdentityCard
                TaxCusTaxNo.EditValue = pclsCustomer.HistoryDAO.TaxID
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".InitialCusTaxInfo : " & e.Message)
        Finally
        End Try
    End Sub

#End Region

#Region "TaxOrder"

    Private Sub LoadTaxOrder(ByVal pRefOrderID As Long)
        Dim lcls As New TaxOrderDAO
        Dim dataTable As New DataTable()
        Try
            'gridView.OptionsBehavior.ReadOnly = mIsReaOnly
            dataTable = lcls.GetDataTable(pRefOrderID, False)
            GridTaxOrder.DataSource = dataTable
            LoadTaxTypeIDLookUp()
            'GridStyle()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".LoadData : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    Private Sub LoadTaxTypeIDLookUp()
        Dim lcls As New MasterDAO
        Dim dataTable As New DataTable()

        Try
            dataTable = lcls.GetDataTable(0, GetMasterTableName(MasterType.TaxType), True, True)
            TaxTypeIDLookUp.DataSource = dataTable

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".LoadTaxTypeIDLookUp : " & e.Message)
        Finally
            dataTable = Nothing
            lcls = Nothing
        End Try
    End Sub

    Private Function GetTaxOrderList() As List(Of TaxOrderDAO)
        Dim lRow As Long
        Dim lDataList = New List(Of TaxOrderDAO)
        Dim lDataDAO As TaxOrderDAO
        Try
            mTaxOrderTotal = 0
            If GridView2.RowCount > 0 And mIsFromLoad = False Then
                For lRow = 0 To GridView2.RowCount
                    If ConvertNullToZero(GridView2.GetRowCellValue(lRow, "TaxTypeID")) > 0 Then
                        lDataDAO = New TaxOrderDAO
                        lDataDAO.TaxOrderID = ConvertNullToZero(GridView2.GetRowCellDisplayText(lRow, "TaxOrderID"))
                        lDataDAO.TaxTypeID = ConvertNullToZero(GridView2.GetRowCellValue(lRow, "TaxTypeID"))
                        lDataDAO.TaxTotal = ConvertNullToZero(GridView2.GetRowCellValue(lRow, "TaxTotal"))
                        lDataDAO.TaxRate = ConvertNullToZero(GridView2.GetRowCellValue(lRow, "TaxRate"))
                        lDataDAO.TaxAmount = ConvertNullToZero(GridView2.GetRowCellValue(lRow, "TaxAmount"))
                        lDataDAO.OtherTax = ConvertNullToString(GridView2.GetRowCellValue(lRow, "OtherTax"))
                        mTaxOrderTotal = mTaxOrderTotal + lDataDAO.TaxAmount
                        lDataList.Add(lDataDAO)
                    End If
                
                Next
                Calculation()
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".GetTaxOrderList : " & e.Message)
        Finally
            lDataDAO = Nothing
        End Try
        Return lDataList
    End Function



    Private Sub TaxTypeIDLookUp_ButtonPressed(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles TaxTypeIDLookUp.ButtonPressed
        'MessageBox.Show(e.Button.Index)
        Dim lstrMsg As String
        If e.Button.Index = 1 Then
            lstrMsg = InputBox("ระบุประเภทเงินได้", "ประเภทเงินได้", ConvertNullToString(GridView2.GetFocusedRowCellValue("OtherTax"))).Trim
            If lstrMsg <> "" Then
                mIsFromLoad = True
                GridView2.SetFocusedRowCellValue("OtherTax", lstrMsg)
                mIsFromLoad = False
            End If
        End If
    End Sub

    Private Sub GridView2_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView2.CellValueChanged
        'If mIsFromLoad = False Then
        '    Dim rowHandle As Long = (TryCast(GridTaxOrder.MainView, ColumnView)).FocusedRowHandle
        '    If GridView2.FocusedColumn.FieldName = "TaxTypeID" Then
        '        'If ConvertNullToZero(GridView2.GetRowCellValue(rowHandle, "TaxTypeID")) = 12 Then
        '        '    TaxTypeIDLookUp.Buttons.Item(1).Enabled = True
        '        'Else
        '        '    TaxTypeIDLookUp.Buttons.Item(1).Enabled = False
        '        '    'Dim lstrMsg As String = InputBox("ระบุประเภทเงินได้", "ประเภทเงินได้", ConvertNullToString(GridView2.GetRowCellValue(rowHandle, "OtherTax"))).Trim
        '        '    'If lstrMsg <> "" Then
        '        '    '    mIsFromLoad = True
        '        '    '    GridView2.SetFocusedRowCellValue("OtherTax", lstrMsg)
        '        '    '    mIsFromLoad = False
        '        '    'End If
        '        'End If

        '    End If
        'End If

        'Call GetTaxOrderList()
    End Sub

    Private Sub GridView2_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GridView2.RowUpdated
       
        Call GetTaxOrderList()
    End Sub


    Private Sub GridView2_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GridView2.ValidatingEditor
        Dim rowHandle As Long = (TryCast(GridTaxOrder.MainView, ColumnView)).FocusedRowHandle
        If Not GridView2.GetFocusedRow Is Nothing Then
            If GridView2.FocusedColumn.FieldName = "TaxRate" Then
                GridView2.SetFocusedRowCellValue("TaxAmount", (e.Value / 100) * ConvertNullToZero(GridView2.GetRowCellValue(rowHandle, "TaxTotal")))

            ElseIf GridView2.FocusedColumn.FieldName = "TaxAmount" Then
                GridView2.SetFocusedRowCellValue("TaxAmount", e.Value * (ConvertNullToZero(GridView2.GetRowCellValue(rowHandle, "TaxRate")) / 100))
                'ElseIf GridView2.FocusedColumn.FieldName = "TaxTypeID" Then
                '    If ConvertNullToZero(GridView2.GetRowCellValue(rowHandle, "TaxTypeID")) = 12 Then
                '        Dim lstrMsg As String = InputBox("ระบุประเภทเงินได้", "ประเภทเงินได้", "").Trim
                '        If lstrMsg <> "" Then

                '        End If
                '    End If

            End If

        End If
    End Sub
    Private Sub XtraTabControl1_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If e.Page Is GeneralTabPage And e.PrevPage Is VatTabPage Then
            Call GetTaxOrderList()
        End If
    End Sub
#End Region

#Region "Set combo"
    Private Sub SetComboCustomer()
        Try
            If mOrderType = MasterType.ReceiptBuy Then
                SetSearchLookAgency(CustomerID)
            Else
                SetSearchLookCustomer(CustomerID, True, False)
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboCustomer : " & e.Message)
        End Try
    End Sub

    Private Sub SetEmployees()
        Try
            SetComboEmployee(EmpID)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetEmployees : " & e.Message)
        End Try
    End Sub

    Private Sub SetBillMedthod()
        Try
            SetComboMasterLook(BillMethod, MasterType.BillMedthod)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetBillMedthod : " & e.Message)
        End Try
    End Sub

    Private Sub SetCurrency()
        Try
            SetLookUpCurrency(cboCurrency)

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetCurrentcy : " & e.Message)
        End Try
    End Sub
#End Region

   
     
End Class