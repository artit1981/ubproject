﻿
Option Explicit On
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Public Class frmOrderS
    Inherits iEditForm
    Private mFormName As String = "Error"
    Private mcls As New OrderSDAO
    Private mclsConvert As iOrder
    Private mVatType As String
    Private mIsFromLoad As Boolean
    Private mMode As DataMode
    Private mRefOrderID As List(Of Long)
    Private mRefReserveID As List(Of Long)
    Private mOrderType As MasterType
    Private mTaxOrderTotal As Double
    Private mCustomerID As Long
    Private mProductList As List(Of ProductSubDAO)
    Private mIsGroupDupProduct As Integer = 0 '0 none ,1=yes,2=no
    Private mIsMakePO As Boolean = False
#Region "Overrides"
    Protected Overrides Sub OnLoadForm(ByVal pMode As Integer, ByVal pID As Long, ByVal pOrderType As Long, ByVal pclsConvert As iOrder, ByVal pCusID As Long)
        Try
            mMode = pMode
            mOrderType = pOrderType
            If mOrderType = MasterType.MakePO Then 'Convert for make po
                mIsMakePO = True
                mOrderType = MasterType.PurchaseOrder
                mProductList = ProductList
            ElseIf mOrderType = MasterType.CancelPO Then 'Convert for make po
                mIsMakePO = True
                mOrderType = MasterType.CancelPO
                mProductList = ProductList
            End If
            mclsConvert = pclsConvert
            mIsFromLoad = True
            mcls = New OrderSDAO
            mcls.TableID = mOrderType
            mCustomerID = pCusID
            OptionSubItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            MakeOrderBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

            '*****
            'mOrderType = MasterType.Quotation
            'Qua
            LayoutQuotationDays.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutQuotationDays2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutSendBy.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutSendBy2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutExpireDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutExpireDate2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            'Order
            LayoutShipingDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutShipingDate2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutPO.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            c.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutPayType.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutPayType2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never

            'Shiping
            'LayoutContactName
            LayoutShipingMethod.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutbtnShipingMethod.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayouShipingBy.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutbtnShipingBy.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutShipingRuleID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutShipingRuleID2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never

            ''OrderIn
            'LayoutAgencyID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            'LayoutbtnAgencyID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never

            'Cus
            LayoutCustomerID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LayoutbtnCustomerID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LayoutCreditBalance.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LayoutCreditBalance2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always

            LayoutCreditRuleID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LayoutbtnCreditRuleID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always

            'Pledge
            LayoutPledge1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutPledge3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutPledge4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            PledgeTabPage.PageEnabled = False

            LayoutPayType.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutPayType2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never

            LayoutInvoiceSuplierID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutInvoiceSuplierID2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never

            LayoutStockType.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            TaxGroup.Enabled = False

            'Make PO
            LayoutRefPO.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutRefPO1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never

            'quo remark
            LayoutQuotationRemark.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutbtnQuotationRemark.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never

            'quo ispass
            chkNotPass.Visible = False
            LayoutNotPass.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never

            mFormName = mOrderType.ToString
            Select Case mOrderType
                Case MasterType.Quotation
                    LayoutQuotationDays.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutQuotationDays2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutSendBy.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutSendBy2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutExpireDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutExpireDate2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutShipingRuleID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutShipingRuleID2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutPayType.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutPayType2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutShipingDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutShipingDate2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutShipingMethod.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutbtnShipingMethod.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutQuotationRemark.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutbtnQuotationRemark.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    chkNotPass.Visible = True
                    LayoutNotPass.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                Case MasterType.SellOrders
                    MakeOrderBar.Caption = "Make Invoice & Shiping"
                    LayoutShipingDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutShipingDate2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutPO.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    c.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutPayType.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutPayType2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutExpireDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutExpireDate2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutPledge1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutPledge3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutPledge4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    PledgeTabPage.PageEnabled = True
                Case MasterType.AddCredit, MasterType.ReduceCredit
                    OptionSubItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    MakeOrderBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    LayoutPO.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    c.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutExpireDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutExpireDate2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutStockType.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                Case MasterType.Shiping
                    OptionSubItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    MakeOrderBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    'LayoutCreditRuleID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    'LayoutbtnCreditRuleID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    LayoutExpireDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutExpireDate2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutShipingDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutShipingDate2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutShipingMethod.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutbtnShipingMethod.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayouShipingBy.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutbtnShipingBy.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutPayType.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutPayType2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutShipingRuleID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutShipingRuleID2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                Case MasterType.Asset

                    TaxGroup.Enabled = True
                    LayoutInvoiceSuplierID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutInvoiceSuplierID2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutInvoiceSuplierID.Text = "เอกสารอ้างอิงเจ้าหนี้"

                    OptionSubItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    MakeOrderBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    LayoutCreditBalance.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    LayoutCreditBalance2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    LayoutCreditRuleID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    LayoutbtnCreditRuleID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                Case MasterType.MakePO, MasterType.PurchaseOrder, MasterType.CancelPO
                    LayoutExpireDate.Text = "วันของเข้า"
                    LayoutExpireDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutExpireDate2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    OptionSubItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    MakeOrderBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    LayoutCreditBalance.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    LayoutCreditBalance2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    LayoutCreditRuleID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    LayoutbtnCreditRuleID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    LayoutRefPO.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutRefPO1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutControlRefOrder.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    LayoutControlRefOrder2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                Case MasterType.Reserve
                    LayoutShipingDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutShipingDate2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutExpireDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutExpireDate2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutPO.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    c.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                Case MasterType.Invoice, MasterType.Borrow
                    OptionSubItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    MakeOrderBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    LayoutShipingDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutShipingDate2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutPO.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    c.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutPayType.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutPayType2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutExpireDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutExpireDate2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutPayType.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutPayType2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                Case MasterType.InvoiceBuy
                    OptionSubItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    MakeOrderBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    LayoutShipingDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutShipingDate2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutPayType.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutPayType2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutExpireDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutExpireDate2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutInvoiceSuplierID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutInvoiceSuplierID2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutCreditBalance.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    LayoutCreditBalance2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                Case MasterType.ShipingBuy
                    OptionSubItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    MakeOrderBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    'LayoutCreditRuleID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    'LayoutbtnCreditRuleID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    LayoutExpireDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutExpireDate2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutShipingDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutShipingDate2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutShipingMethod.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutbtnShipingMethod.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayouShipingBy.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutbtnShipingBy.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutPayType.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutPayType2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutShipingRuleID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutShipingRuleID2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutInvoiceSuplierID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutInvoiceSuplierID2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutInvoiceSuplierID.Text = "เอกสารอ้างอิงเจ้าหนี้"
                Case MasterType.AddCreditBuy, MasterType.ReduceCreditBuy
                    OptionSubItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    MakeOrderBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    LayoutPO.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    c.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutExpireDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutExpireDate2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutCreditBalance.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    LayoutCreditBalance2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    LayoutCreditRuleID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    LayoutbtnCreditRuleID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    LayoutInvoiceSuplierID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutInvoiceSuplierID2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutStockType.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutInvoiceSuplierID.Text = "เอกสารอ้างอิงเจ้าหนี้"
                Case MasterType.Claim, MasterType.Expose
                    OptionSubItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    MakeOrderBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    LayoutExpireDate.Text = "วันได้รับสินค้าคืน"
                    LayoutExpireDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutExpireDate2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutCreditBalance.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    LayoutCreditBalance2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    LayoutCreditRuleID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    LayoutbtnCreditRuleID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    LayouShipingBy.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutbtnShipingBy.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayouShipingBy.Text = "วิธีการส่งเคลม"
                    TaxGroup1.Enabled = False
                Case MasterType.ClaimOut
                    OptionSubItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    MakeOrderBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    LayoutExpireDate.Text = "วันได้รับสินค้าคืน"
                    LayoutExpireDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutExpireDate2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    'LayoutAgencyID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    'LayoutbtnAgencyID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    'LayoutCustomerID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    'LayoutbtnCustomerID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    LayoutCreditBalance.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    LayoutCreditBalance2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    LayoutCreditRuleID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    LayoutbtnCreditRuleID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    TaxGroup1.Enabled = False
            End Select

            InitialCombo()
            Call LoadData(pMode, pID)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".OnLoadForm : " & e.Message)
        Finally
            mIsFromLoad = False
        End Try

        If mCustomerID > 0 And mMode = DataMode.ModeNew Then
            CustomerID.EditValue = mCustomerID
        End If
        '*****

    End Sub

    Protected Overrides Sub ClearAllForm(ByVal pMode As Integer)
        Try
            mIsFromLoad = True
            MyBase.ClearAllForm(pMode)
            Select Case pMode
                Case DataMode.ModeNew, DataMode.ModeCopy
                    ClearForm(GeneralTabPage)
                    ClearForm(LayoutControl1)
                    ClearForm(UcAdmin1)
                    UcFileAttach1.ClearControl()
                    UcNote1.ClearControl()
                    UcProductLists1.ClearControl()
                    UcPledge1.ClearControl()
                    'OrderCode.Properties.ReadOnly = False
                    OrderDate.Properties.ReadOnly = False
                    'CustomerID.Properties.ReadOnly = False
            End Select
            XtraTabControl1.SelectedTabPage = GeneralTabPage
            OrderCode.Select()
            TaxMonthYear.EditValue = OrderDate.EditValue
            'default
            'ExpireDate.EditValue = DateAdd(DateInterval.Month, 1, GetCurrentDate(Nothing))
            ShipingDate.EditValue = OrderDate.EditValue
            UcAdmin1.CheckInAcive.Enabled = False
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".ClearAllForm : " & e.Message)
        Finally
            mIsFromLoad = False
        End Try
    End Sub

    Protected Overrides Function Save(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        Dim lProListStockFail As List(Of ProductListDAO) = Nothing
        XtraTabControl1.SelectedTabPage = GeneralTabPage
        OrderCode.Focus()
        Try
            Calculation()
            mcls.ID = pID
            mcls.ModeData = pMode
            mcls.Code = OrderCode.Text.Trim
            mcls.OrderDate = OrderDate.EditValue
            mcls.ExpireDate = ExpireDate.EditValue
            mcls.ShipingDate = ShipingDate.EditValue
            mcls.CustomerID = ConvertNullToZero(CustomerID.EditValue)
            mcls.EmpID = ConvertNullToZero(EmpID.EditValue)
            mcls.CurrencyID = ConvertNullToZero(cboCurrency.EditValue)
            mcls.ExchangeRate = ConvertNullToZero(Exchange.EditValue)
            mcls.RefToOrderID = mRefOrderID
            mcls.RefToReserveID = mRefReserveID
            mcls.QuotationDays = ConvertNullToZero(QuotationDays.EditValue)
            mcls.CreditRuleID = ConvertNullToZero(CreditRuleID.GetColumnValue("ID"))
            mcls.VatTypeID = ConvertNullToZero(VatTypeID.GetColumnValue("ID"))
            mcls.OrderStatus = OrderStatus.EditValue
            mcls.PO = PO.Text.Trim
            mcls.PayType = PayType.EditValue
            mcls.ShipingMethodID = ConvertNullToZero(ShipingMethod.GetColumnValue("ID"))
            mcls.ShipingByID = ConvertNullToZero(ShipingBy.GetColumnValue("ID"))
            mcls.ShipingRuleID = ConvertNullToZero(ShipingRuleID.GetColumnValue("ID"))
            mcls.CancelRemark = CancelRemark.EditValue
            mcls.IsCancel = IsCancel.EditValue
            mcls.IsEditVat = chkIsEditVat.EditValue
            mcls.PledgeTotal = ConvertNullToZero(PledgeTotal.EditValue)
            mcls.Total = ConvertNullToZero(Total.EditValue)
            mcls.DiscountPercen = ConvertNullToZero(DiscountPercen.EditValue)
            mcls.DiscountAmount = ConvertNullToZero(DiscountAmount.EditValue)
            mcls.VatPercen = ConvertNullToZero(VatPercen.EditValue)
            mcls.VatAmount = ConvertNullToZero(VatAmount.EditValue)
            mcls.GrandTotal = ConvertNullToZero(GrandTotal.EditValue)
            mcls.Remark = Remark.Text.Trim
            mcls.SendBy = SendBy.Text.Trim
            mcls.IsInActive = UcAdmin1.CheckInAcive.Checked
            mcls.TaxTotal = ConvertNullToZero(TotalTax.EditValue)
            mcls.TaxMonthYear = TaxMonthYear.EditValue
            mcls.TaxRemark = ConvertNullToString(TaxRemark.EditValue)
            mcls.InvoiceSuplierID = ConvertNullToString(InvoiceSuplierID.EditValue)
            mcls.Institute = ConvertNullToString(Institute.EditValue)
            mcls.StockType = StockType.EditValue
            mcls.QuotationRemarkID = ConvertNullToZero(QuotationRemark.EditValue)
            If TaxCanYes.Checked = True Then
                mcls.TaxCanYes = "Y"
            Else
                mcls.TaxCanYes = "N"
            End If
            mcls.IsNotPass = chkNotPass.Checked
            mcls.NoteDAOs = UcNote1.GetNoteDAOs
            mcls.FileAttachs = UcFileAttach1.GetFileAttachs
            mcls.IsMakePO = mIsMakePO

            'Check Approve stock
            Dim lIsApproveStock As Boolean = (CheckIsUseStock(mcls.TableID, Nothing, mcls.StockType, Nothing) > 0)
            If lIsApproveStock And CheckIsWaitApproveStock() Then
                ShowProgress(False, "")
                XtraMessageBox.Show(Me, "ไม่สามารถทำรายการได้ เนื่องจากระบบมีการคำนวนสต๊อกใหม่ กรุณาทำการอนุมัติสต๊อก ", "Approve", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
                Return False
            End If

            If TaxGroup.Enabled = True Then
                mcls.TaxOrderDAOs = GetTaxOrderList()
            End If

            'Check Stock ?
            Dim lIsCheckStock As Boolean = False
            If mOrderType = MasterType.SellOrders Or (mOrderType = MasterType.ReduceCredit And mcls.StockType = "O") Or (mOrderType = MasterType.ReduceCreditBuy And mcls.StockType = "O") Then
                lIsCheckStock = True
            Else
                lIsCheckStock = False
            End If
             
            mcls.ProductDAOs = UcProductLists1.GetDAOs(lIsCheckStock, True, mOrderType = MasterType.SellOrders, lProListStockFail, False, 0, True, mOrderType.ToString, pMode, mcls.StockType)
            'Stock fail to Reserve
            If lProListStockFail.Count > 0 Then
                ShowProgress(False, "")
                If XtraMessageBox.Show(Me, "สินค้าในสต๊อกไม่เพียงพอ ต้องการทำรายการใบสั่งจองหรือไม่", "สต๊อกหมด", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    MakeReserve(lProListStockFail)
                End If
                Return False
            End If

            mcls.PledgeDAOs = UcPledge1.GetDAOs()
           

            'mcls.TaxOrderDAOs = GetTaxOrderList()
            If Verify() = True Then

                Call mcls.SaveData()
                ShowProgress(False, "")
                'If mcls.ModeData = DataMode.ModeNew And (mcls.OrderStatus = EnumStatus.Open.ToString Or mcls.OrderStatus = EnumStatus.Approve.ToString) Then
                '    If XtraMessageBox.Show(Me, "ต้องการพิมพ์เอกสารหรือไม่ ?", "พิมพ์เอกสาร", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                '        modReport.PrintOrder(mcls.ID)
                '    End If
                If mcls.ModeData = DataMode.ModeNew And (mcls.OrderStatus = EnumStatus.WaitApprove.ToString) Then
                    'ShowProgress(False, "")
                    XtraMessageBox.Show(Me, "บันทึกรายการสำเร็จ รอการอนุมัติ", "Approve", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    'If XtraMessageBox.Show(Me, "บันทึกรายการสำเร็จ รอการอนุมัติ ต้องการพิมพ์เอกสารหรือไม่ ?", "พิมพ์เอกสาร", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    '    modReport.PrintReportOrder(mOrderType, mcls.ID)
                    'End If
                Else
                    'XtraMessageBox.Show(Me, "บันทึกรายการสำเร็จ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    'ShowProgress(False, "")
                    Select Case mOrderType
                        Case MasterType.SellOrders, MasterType.Invoice, MasterType.Shiping, MasterType.Reserve, MasterType.PurchaseOrder _
                            , MasterType.Quotation, MasterType.Claim, MasterType.ClaimOut, MasterType.ReduceCredit, MasterType.ReduceCreditBuy, MasterType.Borrow, MasterType.Expose
                            If XtraMessageBox.Show(Me, "บันทึกรายการสำเร็จ ต้องการพิมพ์เอกสารหรือไม่ ?", "พิมพ์เอกสาร", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                                modReport.PrintReportOrder(mOrderType, mcls.ID)
                            End If
                    End Select
                End If
                Return True
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".Save : " & ex.Message)
            Return False
        End Try
    End Function

    'Protected Overrides Sub CloseReserve(ByVal pID As Long)
    '    Dim Sql As String = ""
    '    Try
    '        If XtraMessageBox.Show(Me, "ต้องการปิดสถานะการสร้างใบสั่งซื้อใช่หรือไม่ [Ordered]", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
    '            Sql = " UPDATE Orders SET "
    '            Sql = Sql & " where OrderID=" & pID
    '            gConnection.executeInsertQuery(Sql, Nothing)
    '            XtraMessageBox.Show(Me, "บันทึกรายการสำเร็จ", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    '        End If

    '    Catch ex As Exception
    '        ShowErrorMsg(False, ex.Message)
    '    Finally
    '        'ShowProgress(False, "")
    '    End Try
    'End Sub
    Protected Overrides Sub MakeOrder(ByVal pID As Long)
        Dim lFormEdit As frmOrderS = Nothing
        Try
            lFormEdit = New frmOrderS
            If (mOrderType And MasterType.Quotation) = MasterType.Quotation Then
                lFormEdit.OrderType = MasterType.SellOrders
                lFormEdit.Caption = "ใบสั่งขาย"
            ElseIf (mOrderType And MasterType.Reserve) = MasterType.Reserve Then
                lFormEdit.OrderType = MasterType.SellOrders
                lFormEdit.Caption = "ใบสั่งขาย"
            ElseIf (mOrderType And MasterType.SellOrders) = MasterType.SellOrders Then
                lFormEdit.OrderType = MasterType.Invoice
                lFormEdit.Caption = "ใบกำกับภาษี (ขาย)"
            End If
            With lFormEdit
                .MdiParent = frmMain
                .ModeData = DataMode.ModeConvert
                .IDs = pID
                .clsConvert = mcls
                .Show()
            End With
            'End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".MakeOrder : " & e.Message)
        End Try
    End Sub

    Protected Overrides Sub OnClosedForm()
        mcls = Nothing
    End Sub

    Protected Overrides Sub PrintOrder(ByVal pID As Long, ByVal pPrintType As Long) '1=Order, 2=Payment, 3=Cheque)
        modReport.PrintReportOrder(mOrderType, pID)
    End Sub

#End Region

#Region "Event"

    Private Sub OrderDate_EditValueChanged(sender As Object, e As System.EventArgs) Handles OrderDate.EditValueChanged
        Try
            If mIsFromLoad = False Then
                TaxMonthYear.EditValue = OrderDate.EditValue
                CalcExpireDate()
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".OrderDate_EditValueChanged : " & ex.Message)
        Finally
        End Try
    End Sub

    Private Sub FormChangedComponent1_FormControlChanged1(ByVal sender As Object, ByVal e As FormChangedEventArgs) Handles FormChangedComponent1.FormControlChanged
        MyBase.CheckFormChanged()
    End Sub

    Private Sub CreditRuleID_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CreditRuleID.EditValueChanged
        Try
            If LayoutCreditRuleID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always Then
                InitialCreditRule(ConvertNullToZero(CreditRuleID.EditValue))
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".CreditRuleID_EditValueChanged : " & ex.Message)
        Finally

        End Try
    End Sub

    Private Sub btnShipingBy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShipingBy.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboShipingByID()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub btnShipingMethod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShipingMethod.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboShipingMethodeID()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub btnCustomerID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomerID.Click
        Try
            ShowProgress(True, "Loading...")
            Select Case mOrderType
                Case MasterType.InvoiceBuy, MasterType.AddCreditBuy, MasterType.ReduceCreditBuy, MasterType.ClaimOut, MasterType.PurchaseOrder, MasterType.ShipingBuy, MasterType.MakePO, MasterType.CancelPO
                    SetComboAgency()
                Case Else
                    SetComboCustomer()
            End Select

            'SetComboCustomer()
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

    Private Sub btnCreditRuleID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreditRuleID.Click
        Try
            ShowProgress(True, "Loading...")
            SetCreditRole()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub btnVatTypeID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVatTypeID.Click
        Try
            ShowProgress(True, "Loading...")
            SetVatType()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try

    End Sub
 
    Private Sub IsCancel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IsCancel.CheckedChanged
        If (IsCancel.EditValue = True) Or (chkNotPass.EditValue = True) Then
            CancelRemark.Properties.ReadOnly = False
        Else
            CancelRemark.Properties.ReadOnly = True
        End If
    End Sub

    Private Sub VatTypeID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VatTypeID.EditValueChanged
        Try
            InitialVatType(ConvertNullToZero(VatTypeID.EditValue))

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".VatTypeID_EditValueChanged : " & ex.Message)
        Finally
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

    Private Sub DiscountPercen_Layout(ByVal sender As Object, ByVal e As System.Windows.Forms.LayoutEventArgs) Handles DiscountPercen.Layout

    End Sub

    Private Sub DiscountPercen_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DiscountPercen.LostFocus
        If mIsFromLoad = False Then
            If DiscountPercen.EditValue > 100 Then
                DiscountPercen.EditValue = 100
            ElseIf DiscountPercen.EditValue < 0 Then
                DiscountPercen.EditValue = 0
            Else
                DiscountAmount.EditValue = TotalAfterPledge.EditValue * (DiscountPercen.EditValue / 100)
                Calculation()
            End If
        End If
    End Sub

    Private Sub GeneralTabPage_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GeneralTabPage.GotFocus
        Calculation()
    End Sub

    Private Sub DiscountAmount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DiscountAmount.LostFocus
        If mIsFromLoad = False Then
            If DiscountAmount.EditValue = 0 Then
                DiscountPercen.EditValue = 0
            Else
                DiscountPercen.EditValue = (DiscountAmount.EditValue * 100) / TotalAfterPledge.EditValue
                Calculation()
            End If
        End If
    End Sub
 

    Private Sub btnRefreshCurrency_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshCurrency.Click
        SetLookUpCurrency(cboCurrency)
    End Sub

    Private Sub btnShipingRuleID_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnShipingRuleID.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboShipingRuleID()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub CustomerID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerID.EditValueChanged
        Dim lCusID As Long
        lCusID = ConvertNullToZero(CustomerID.EditValue)
        If mIsFromLoad = False Then

            InitialCusInfo(lCusID)
            InitialRefOrder(0, "", False)
        End If
        'OppID.Properties.ReadOnly = Not (lCusID > 0 And mMode <> DataMode.ModeEdit)
        btnRefOrder.Enabled = (lCusID > 0 And mMode <> DataMode.ModeEdit)
    End Sub

    Private Sub cboCurrency_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCurrency.EditValueChanged
        Try
            InitialCurrency(ConvertNullToZero(cboCurrency.EditValue))

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".cboCurrency_EditValueChanged : " & ex.Message)
        Finally

        End Try
    End Sub

    Private Sub btnRefOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefOrder.Click
        Try
            ShowFindOrder()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try
    End Sub


    Private Sub txtRefOrder_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRefOrder.KeyPress
        Try
            If e.KeyChar = ChrW(Keys.Enter) And btnRefOrder.Enabled = True Then
                If txtRefOrder.Text.Trim <> "" Then
                    ShowProgress(True, "Loading...")
                    If InitialRefOrder(0, txtRefOrder.Text.Trim, True) = False Then
                        ShowFindOrder()
                    End If
                End If
            End If
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try

    End Sub

#End Region

#Region "Private"
    Private Sub ShowFindOrder()
        Dim lfrm As New frmFindOrder
        Dim lSubOrderList As New List(Of SubOrder)
        Dim bindingSource1 As New BindingSource
        Dim lOrderList As New List(Of Long)
        lOrderList.Add(mcls.ID)

        Try
            If ConvertNullToZero(CustomerID.EditValue) = 0 Then
                SetErrorProvider(DxErrorProvider1, CustomerID, "กรุณาระบุลูกค้า")
            Else
                lfrm.CustomerID_ = ConvertNullToZero(CustomerID.EditValue)
                lfrm.OrderDate = OrderDate.EditValue
                lfrm.Text = "ค้นหารายการ : ลูกค้า " & CustomerID.Text
                lfrm.OrderType = mOrderType
                ShowProgress(False, "")
                lfrm.ShowDialog()
                If lfrm.IsAccept Then
                    If lfrm.IsGetByProduct = True Then
                        ShowProductListBySource(mMode, lfrm.GetProductSubList, lOrderList)
                    Else
                        lSubOrderList = lfrm.GetSubOrderList
                        If Not lSubOrderList Is Nothing Then
                            If lSubOrderList.Count > 0 Then
                                'Initial new list
                                mProductList = New List(Of ProductSubDAO)
                                mIsGroupDupProduct = 0
                                txtRefOrder.Text = ""
                                mRefOrderID = New List(Of Long)

                                For Each rec As SubOrder In lSubOrderList
                                    mRefOrderID.Add(rec.OrderID)
                                    InitialRefOrder(rec.OrderID, "", True)
                                Next
                                ShowProductListBySource(mMode, mProductList, mRefOrderID)
                                Calculation()
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".ShowFindOrder : " & ex.Message)
        Finally
        End Try
    End Sub

    Private Function InitialRefOrder(ByVal pRefOrderID As Long, ByVal pRefOrderCode As String, ByVal pInitProduct As Boolean) As Boolean
        Try
            If (pRefOrderID > 0 Or pRefOrderCode.Trim <> "") And mIsFromLoad = False Then
                If pInitProduct Then
                    UcProductLists1.ClearControl()
                End If

                Select Case mOrderType
                    Case MasterType.Quotation
                        InitialOpportunity(pRefOrderID, pRefOrderCode.Trim, pInitProduct)
                    Case MasterType.SellOrders
                        If InitialOrder(pRefOrderID, pRefOrderCode.Trim, pInitProduct, MasterType.Reserve) Then Return True
                        If InitialOrder(pRefOrderID, pRefOrderCode.Trim, pInitProduct, MasterType.Quotation) Then Return True
                    Case MasterType.Invoice
                        If InitialOrder(pRefOrderID, pRefOrderCode.Trim, pInitProduct, MasterType.SellOrders) Then Return True
                        If InitialOrder(pRefOrderID, pRefOrderCode.Trim, pInitProduct, MasterType.Borrow) Then Return True
                    Case MasterType.Shiping, MasterType.Borrow
                        InitialOrder(pRefOrderID, pRefOrderCode.Trim, pInitProduct, MasterType.SellOrders)
                    Case MasterType.AddCredit, MasterType.ReduceCredit
                        If InitialOrder(pRefOrderID, pRefOrderCode.Trim, pInitProduct, MasterType.SellOrders) Then Return True
                        If InitialOrder(pRefOrderID, pRefOrderCode.Trim, pInitProduct, MasterType.Shiping) Then Return True
                        InitialOrder(pRefOrderID, pRefOrderCode.Trim, pInitProduct, MasterType.Invoice)
                    Case MasterType.Reserve
                        InitialOrder(pRefOrderID, pRefOrderCode.Trim, pInitProduct, MasterType.Quotation)
                    Case MasterType.InvoiceBuy, MasterType.ShipingBuy
                        InitialOrder(pRefOrderID, pRefOrderCode.Trim, pInitProduct, MasterType.PurchaseOrder)
                    Case MasterType.Claim
                        InitialOrder(pRefOrderID, pRefOrderCode.Trim, pInitProduct, MasterType.Invoice)
                    Case MasterType.ClaimOut
                        InitialOrder(pRefOrderID, pRefOrderCode.Trim, pInitProduct, MasterType.InvoiceBuy)
                    Case MasterType.ReduceCreditBuy, MasterType.AddCreditBuy
                        If InitialOrder(pRefOrderID, pRefOrderCode.Trim, pInitProduct, MasterType.InvoiceBuy) Then Return True
                        If InitialOrder(pRefOrderID, pRefOrderCode.Trim, pInitProduct, MasterType.ShipingBuy) Then Return True
                    Case MasterType.Expose
                        InitialOrder(pRefOrderID, pRefOrderCode.Trim, pInitProduct, MasterType.Claim)
                    Case MasterType.Asset
                        InitialOrder(pRefOrderID, pRefOrderCode.Trim, pInitProduct, MasterType.PurchaseOrder)

                End Select
                'ElseIf pRefOrderID > 0 And mIsMakePO = True And mOrderType = MasterType.PurchaseOrder Then
                '    InitialOrder(pRefOrderID, pRefOrderCode.Trim, pInitProduct, MasterType.Reserve)
            ElseIf pRefOrderID = 0 And pRefOrderCode.Trim = "" And mIsFromLoad = False Then
                txtRefOrder.Text = ""
                If pInitProduct Then
                    UcProductLists1.ClearControl()
                End If
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".InitialRefOrder : " & ex.Message)
        Finally
        End Try
    End Function


    Private Function InitialRefReserve(ByVal pRefOrderID As Long, ByVal pRefOrderCode As String, ByVal pInitProduct As Boolean) As Boolean
           Dim lcls As OrderSDAO
        Try
            If (pRefOrderID > 0 Or pRefOrderCode.Trim <> "") Then
                lcls = New OrderSDAO
                lcls.TableID = MasterType.Reserve

                If lcls.InitailData(pRefOrderID, pRefOrderCode.Trim) = True Then
                    If txtRefPO.Text = "" Then
                        txtRefPO.Text = lcls.Code
                    Else
                        txtRefPO.Text = txtRefPO.Text & ", " & lcls.Code
                    End If
                   
                    Return True
                Else
                    Return False
                End If
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".InitialRefReserve : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Function

    Private Function InitialOpportunity(ByVal plngOppID As Long, ByVal pstrOrderCode As String, ByVal pInitProduct As Boolean) As Boolean
        Dim lcls As OpportunityDAO

        Try
            If (plngOppID > 0 Or pstrOrderCode.Trim <> "") And mIsFromLoad = False Then
                lcls = New OpportunityDAO
                If lcls.InitailData(plngOppID, pstrOrderCode.Trim) = True Then
                    'txtRefOrder.Text = lcls.Subject
                    If txtRefOrder.Text = "" Then
                        txtRefOrder.Text = lcls.Subject
                    Else
                        txtRefOrder.Text = txtRefOrder.Text & ", " & lcls.Subject
                    End If
                    If pInitProduct Then
                        gCustomerID = ConvertNullToZero(CustomerID.EditValue)
                        LoadProList(plngOppID, MasterType.Opportunity)
                        'UcProductLists1.ShowControl(mMode, lcls.ID, lcls.TableName, GetColData, False, True, Me, True, mOrderType.ToString)
                        'Calculation()
                    End If
                    Return True
                End If
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".InitialOpportunity : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Function

    Private Function InitialOrder(ByVal plngOrderID As Long, ByVal pstrOrderCode As String, ByVal pInitProduct As Boolean, ByVal pOrderType As Integer) As Boolean
        Dim lcls As OrderSDAO
        Try
            If (plngOrderID > 0 Or pstrOrderCode.Trim <> "") Then
                lcls = New OrderSDAO
                lcls.TableID = pOrderType
                'ShipingDate.EditValue = Nothing
                If lcls.InitailData(plngOrderID, pstrOrderCode.Trim) = True Then
                    If txtRefOrder.Text = "" Then
                        txtRefOrder.Text = lcls.Code
                    Else
                        txtRefOrder.Text = txtRefOrder.Text & ", " & lcls.Code
                    End If
                    DiscountPercen.EditValue = FormatNumber(lcls.DiscountPercen, 2)
                    DiscountAmount.EditValue = FormatNumber(lcls.DiscountAmount, 2)
                    Institute.EditValue = lcls.Institute
                    PO.EditValue = lcls.PO
                    If LayoutShipingDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always Then
                        ShipingDate.EditValue = lcls.ShipingDate
                    End If
                    If pInitProduct Then
                        gCustomerID = ConvertNullToZero(CustomerID.EditValue)
                        LoadProList(plngOrderID, pOrderType)
                    End If
                    Return True
                Else
                    Return False
                End If
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".InitialOrder : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Function

    Private Function LoadProList(ByVal pOrderID As Long, ByVal pTableID As MasterType) As Boolean
        Dim lcls As New ProductListDAO
        Dim rec As New ProductSubDAO, lIndex As Long
        Dim dataTable As New DataTable()

        Dim llngProID As Long
        Dim lOrderList As New List(Of Long)
        lOrderList.Add(pOrderID)
        Try
            Dim lIsConfirm As Boolean = True
            If pTableID = MasterType.ReduceCredit Or pTableID = MasterType.AddCredit Then
                lIsConfirm = False
            End If

            dataTable = lcls.GetDataTable(lOrderList, pTableID.ToString, Nothing, lIsConfirm, "", False, mOrderType, True)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    llngProID = ConvertNullToZero(dr("ProductID"))
                    lIndex = mProductList.FindIndex(Function(m As ProductSubDAO) m.ProductID = llngProID And m.IsShow = 1)
                    If lIndex < 0 Or mIsGroupDupProduct = 1 Or ConvertNullToZero(dr("IsShow")) = 0 Then
                        rec = New ProductSubDAO
                        rec.IsSelect = True
                        rec.ID = ConvertNullToZero(dr("ID"))
                        rec.SEQ = 0
                        rec.IsSN = ConvertNullToZero(dr("IsSN"))
                        rec.ProductID = ConvertNullToZero(dr("ProductID"))
                        rec.ProductCode = ConvertNullToString(dr("ProductCode"))
                        rec.ProductNames = ConvertNullToString(dr("ProductName"))
                        rec.ProductNameExt = ConvertNullToString(dr("ProductNameExt"))
                        rec.LocationDTLID = ConvertNullToZero(dr("LocationDTLID"))
                        rec.UnitID = ConvertNullToZero(dr("UnitID"))
                        rec.UnitMainID = ConvertNullToZero(dr("UnitMainID"))
                        rec.UnitName = ConvertNullToString(dr("UnitName"))
                        rec.Remark = ConvertNullToString(dr("Remark"))
                        rec.KeepMin = ConvertNullToZero(dr("KeepMin"))
                        rec.Units = ConvertNullToZero(dr("Units"))
                        rec.AdjustUnit = ConvertNullToZero(dr("AdjustUnit"))
                        rec.RateUnit = ConvertNullToZero(dr("RateUnit"))
                        rec.Price = ConvertNullToZero(dr("Price"))
                        rec.Cost = ConvertNullToZero(dr("Cost"))
                        rec.Discount = ConvertNullToZero(dr("Discount"))
                        rec.Total = ConvertNullToZero(dr("Total"))
                        rec.IsShow = ConvertNullToZero(dr("IsShow"))
                     
                    If rec.IsSN = 1 Then
                        rec.SNList = New List(Of SnDAO)
                        For Each pSN As SnDAO In LoadSN(lOrderList, dr("ID"), dr("ProductID"))
                            rec.SNList.Add(pSN)
                        Next
                    End If
                    rec.IsMerge = 0
                    rec.ModePro = DataMode.ModeNew
                    mProductList.Add(rec)
                    Else
                    If mIsGroupDupProduct = 0 Then
                        If XtraMessageBox.Show(Me, "มีข้อมูลสินค้าซ้ำต้องการรวมรายการหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                            mIsGroupDupProduct = 2
                        Else
                            mIsGroupDupProduct = 1
                            rec = New ProductSubDAO
                            rec.IsSelect = True
                            rec.IsSN = ConvertNullToZero(dr("IsSN"))
                            rec.SEQ = 0
                            rec.ID = ConvertNullToZero(dr("ID"))
                            rec.ProductID = ConvertNullToZero(dr("ProductID"))
                            rec.ProductCode = ConvertNullToString(dr("ProductCode"))
                            rec.ProductNames = ConvertNullToString(dr("ProductName"))
                            rec.ProductNameExt = ConvertNullToString(dr("ProductNameExt"))
                            rec.LocationDTLID = ConvertNullToZero(dr("LocationDTLID"))
                            rec.UnitID = ConvertNullToZero(dr("UnitID"))
                            rec.UnitMainID = ConvertNullToZero(dr("UnitMainID"))
                            rec.UnitName = ConvertNullToString(dr("UnitName"))
                            rec.Remark = ConvertNullToString(dr("Remark"))
                            rec.KeepMin = ConvertNullToZero(dr("KeepMin"))
                            rec.Units = ConvertNullToZero(dr("Units"))
                            rec.AdjustUnit = ConvertNullToZero(dr("AdjustUnit"))
                            rec.RateUnit = ConvertNullToZero(dr("RateUnit"))
                            rec.Price = ConvertNullToZero(dr("Price"))
                            rec.Cost = ConvertNullToZero(dr("Cost"))
                            rec.Discount = ConvertNullToZero(dr("Discount"))
                            rec.Total = ConvertNullToZero(dr("Total"))
                            rec.ModePro = DataMode.ModeNew
                            rec.IsShow = 1
                            rec.IsMerge = 0
                            If rec.IsSN = 1 Then
                                rec.SNList = New List(Of SnDAO)
                                For Each pSN As SnDAO In LoadSN(lOrderList, dr("ID"), dr("ProductID"))
                                    rec.SNList.Add(pSN)
                                Next
                            End If
                            mProductList.Add(rec)
                        End If
                    End If
                    If mIsGroupDupProduct = 2 Then
                        'mProductList.Item(lIndex).ID = 0
                        mProductList.Item(lIndex).Units = mProductList.Item(lIndex).Units + ConvertNullToZero(dr("Units"))
                        mProductList.Item(lIndex).Discount = mProductList.Item(lIndex).Discount + ConvertNullToZero(dr("Discount"))
                        mProductList.Item(lIndex).Total = mProductList.Item(lIndex).Total + ConvertNullToZero(dr("Total"))
                        If ConvertNullToZero(dr("IsSN")) = 1 Then
                            For Each pSN As SnDAO In LoadSN(lOrderList, dr("ID"), dr("ProductID"))
                                mProductList.Item(lIndex).SNList.Add(pSN)
                            Next
                        End If

                        mProductList.Item(lIndex).IsMerge = 1
                            'rec = New ProductSubDAO
                            'rec.IsSelect = True
                            'rec.IsSN = ConvertNullToZero(dr("IsSN"))
                            'rec.SEQ = 0
                            'rec.ID = ConvertNullToZero(dr("ID"))
                            'rec.ProductID = ConvertNullToZero(dr("ProductID"))
                            'rec.ProductCode = ConvertNullToString(dr("ProductCode"))
                            'rec.ProductNames = ConvertNullToString(dr("ProductName"))
                            'rec.ProductNameExt = ConvertNullToString(dr("ProductNameExt"))
                            'rec.LocationDTLID = ConvertNullToZero(dr("LocationDTLID"))
                            'rec.UnitID = ConvertNullToZero(dr("UnitID"))
                            'rec.UnitMainID = ConvertNullToZero(dr("UnitMainID"))
                            'rec.UnitName = ConvertNullToString(dr("UnitName"))
                            'rec.Remark = ConvertNullToString(dr("Remark"))
                            'rec.KeepMin = ConvertNullToZero(dr("KeepMin"))
                            'rec.Units = ConvertNullToZero(dr("Units"))
                            'rec.AdjustUnit = ConvertNullToZero(dr("AdjustUnit"))
                            'rec.RateUnit = ConvertNullToZero(dr("RateUnit"))
                            'rec.Price = ConvertNullToZero(dr("Price"))
                            'rec.Cost = ConvertNullToZero(dr("Cost"))
                            'rec.Discount = ConvertNullToZero(dr("Discount"))
                            'rec.Total = ConvertNullToZero(dr("Total"))
                            'rec.ModePro = DataMode.ModeNew
                            'rec.IsShow = 0

                            'rec.IsMerge = 1
                            'mProductList.Add(rec)
                    End If
                    End If
                Next
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".LoadProList : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Function


    Private Function LoadSN(ByVal pOrderID As List(Of Long), ByVal pProListID As Long, ByVal pProID As Long) As List(Of SnDAO)
        Dim lclsSN As New SnDAO, dataSN As New DataTable()
        Dim lSNList As New List(Of SnDAO)
        LoadSN = Nothing
        Try
            dataSN = lclsSN.GetDataTable(pOrderID, pProListID, pProID, "", Nothing, True, "")
            For Each dr2 As DataRow In dataSN.Rows
                lclsSN = New SnDAO
                lclsSN.SerialNumberID = 0
                lclsSN.SerialNumberNo = ConvertNullToString(dr2("SerialNumberNo"))
                lclsSN.Status = ConvertNullToString(dr2("Status"))
                lclsSN.OrderID = ConvertNullToZero(dr2("OrderID"))
                lclsSN.ProductID = ConvertNullToZero(dr2("ProductID"))
                lSNList.Add(lclsSN)
            Next
            Return lSNList
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".LoadSN : " & e.Message)
        Finally
        End Try
    End Function

    Private Sub InitialCombo()
        Try
            SetCreditRole()
            SetVatType()
            SetEmployees()
            Select Case mOrderType
                Case MasterType.InvoiceBuy, MasterType.AddCreditBuy, MasterType.ReduceCreditBuy, MasterType.ClaimOut, MasterType.PurchaseOrder, MasterType.ShipingBuy, MasterType.MakePO, MasterType.CancelPO
                    SetComboAgency()
                Case Else
                    SetComboCustomer()
            End Select


            SetComboShipingByID()
            SetComboShipingMethodeID()

            SetCurrency()
            SetComboShipingRuleID()
            SetComboQuoRemarkID()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".InitialCombo : " & e.Message)
        End Try
    End Sub

    Private Function LoadData(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        Try

            MakeOrderBar.Enabled = False  'Set First Time
            If pMode = DataMode.ModeNew Then
                OrderStatus.EditValue = EnumStatus.Open.ToString
                OrderCode.EditValue = AutoGenCode(mOrderType)
                EmpID.EditValue = gEmpID

                If mIsMakePO Then
                    mRefReserveID = New List(Of Long)
                    For Each pOrderID As Long In RefReserveIDList
                        mRefReserveID.Add(pOrderID)
                        InitialRefReserve(pOrderID, "", False)
                    Next
                    Calculation()
                End If
            ElseIf pMode = DataMode.ModeConvert Then
                Call LoadConvert(pID)
                MyBase.SetMode = DataMode.ModeNew
            ElseIf pMode = DataMode.ModeEdit Or pMode = DataMode.ModeCopy Then
                If mcls.InitailData(pID) Then
                    If pMode = DataMode.ModeEdit Then
                        OrderCode.EditValue = mcls.Code
                        OrderDate.EditValue = mcls.OrderDate
                        ExpireDate.EditValue = mcls.ExpireDate
                        ShipingDate.EditValue = mcls.ShipingDate
                        OrderStatus.EditValue = mcls.OrderStatus
                        IsCancel.EditValue = mcls.IsCancel
                        chkIsEditVat.EditValue = mcls.IsEditVat
                        chkNotPass.EditValue = mcls.IsNotPass
                        StockType.EditValue = mcls.StockType
                        CancelRemark.EditValue = mcls.CancelRemark
                        PO.EditValue = mcls.PO
                        UcAdmin1.CheckInAcive.Checked = mcls.IsInActive
                        UcAdmin1.txtCreateBy.Text = mcls.CreateBy.Trim
                        UcAdmin1.txtCreateTime.Text = mcls.CreateTime
                        UcAdmin1.txtModifiBy.Text = mcls.ModifiedBy.Trim
                        UcAdmin1.txtModifiTime.Text = mcls.ModifiedTime

                        UcFileAttach1.ShowControl(mcls.FileAttachs)
                        txtRefOrder.Properties.ReadOnly = True
                        btnRefOrder.Enabled = False
                        MakeOrderBar.Enabled = (mcls.OrderStatus = EnumStatus.Open.ToString Or mcls.OrderStatus = EnumStatus.Approve.ToString Or mcls.OrderStatus = EnumStatus.Cancel.ToString Or mcls.OrderStatus = EnumStatus.Waiting.ToString Or mcls.OrderStatus = EnumStatus.Receive.ToString) And mcls.IsDelete = False

                        Select Case mOrderType
                            Case MasterType.InvoiceBuy, MasterType.ShipingBuy
                                SaveBar.Enabled = True
                            Case Else
                                SaveBar.Enabled = (mcls.OrderStatus = EnumStatus.Open.ToString Or mcls.OrderStatus = EnumStatus.Approve.ToString Or mcls.OrderStatus = EnumStatus.Cancel.ToString Or mcls.OrderStatus = EnumStatus.Waiting.ToString Or mcls.OrderStatus = EnumStatus.Receive.ToString) And mcls.IsDelete = False

                        End Select
                        PrintBar2.Enabled = (mcls.IsDelete = False)

                        'Ref order
                        txtRefOrder.Text = mcls.GetToRefOrderCode(pID, Nothing)
                        mRefOrderID = mcls.RefToOrderID
                        If mOrderType = MasterType.PurchaseOrder Or mOrderType = MasterType.CancelPO Then
                            txtRefPO.Text = mcls.GetToRefReserveCode(pID, Nothing)
                            mRefReserveID = mcls.RefToReserveID
                        End If
                    Else  '*** Copy
                        MyBase.SetMode = DataMode.ModeNew
                        mMode = DataMode.ModeNew
                        IsCancel.EditValue = False
                        OrderStatus.EditValue = EnumStatus.Open.ToString
                        OrderCode.EditValue = AutoGenCode(mOrderType)
                    End If
                    PayType.EditValue = mcls.PayType
                    CustomerID.EditValue = mcls.CustomerID
                    EmpID.EditValue = mcls.EmpID
                    PO.EditValue = mcls.PO
                    QuotationDays.EditValue = mcls.QuotationDays
                    CreditRuleID.EditValue = mcls.CreditRuleID
                    VatTypeID.EditValue = mcls.VatTypeID
                    ShipingMethod.EditValue = mcls.ShipingMethodID
                    ShipingBy.EditValue = mcls.ShipingByID
                    ShipingRuleID.EditValue = mcls.ShipingRuleID
                    cboCurrency.EditValue = mcls.CurrencyID
                    Exchange.EditValue = mcls.ExchangeRate
                    mIsFromLoad = False
                    InitialVatType(ConvertNullToZero(VatTypeID.EditValue)) '' Initial
                    mIsFromLoad = True
                    SendBy.EditValue = mcls.SendBy
                    Remark.EditValue = mcls.Remark
                    Total.EditValue = FormatNumber(mcls.Total, 2)
                    DiscountPercen.EditValue = FormatNumber(mcls.DiscountPercen, 2)
                    DiscountAmount.EditValue = FormatNumber(mcls.DiscountAmount, 2)
                    TotalAfterDis.EditValue = FormatNumber(Total.EditValue - mcls.DiscountAmount, 2)
                    VatPercen.EditValue = FormatNumber(mcls.VatPercen, 2)
                    VatAmount.EditValue = FormatNumber(mcls.VatAmount, 2)
                    PledgeTotal.EditValue = FormatNumber(mcls.PledgeTotal, 2)
                    TotalAfterPledge.EditValue = Total.EditValue - PledgeTotal.EditValue
                    GrandTotal.EditValue = FormatNumber(mcls.GrandTotal, 2)
                    TotalTax.EditValue = mcls.TaxTotal
                    TaxMonthYear.EditValue = mcls.TaxMonthYear
                    TaxRemark.EditValue = mcls.TaxRemark
                    InvoiceSuplierID.EditValue = mcls.InvoiceSuplierID
                    Institute.EditValue = mcls.Institute
                    QuotationRemark.EditValue = mcls.QuotationRemarkID
                    If mcls.TaxCanYes = "Y" Then
                        TaxCanYes.Checked = True
                    Else
                        TaxCanNo.Checked = True
                    End If
                End If
            End If
            InitialIsEditVat(mcls.IsEditVat)
            UcNote1.ShowControl(mcls.TableName, pID)
            ShowProductList(mMode)
            LoadTaxOrder(pID)
            InitialCusTaxInfo(ConvertNullToZero(CustomerID.EditValue), Nothing)
            UcPledge1.ShowControl(mcls.ID, False)
            CancelRemark.Properties.ReadOnly = (IsCancel.EditValue = False)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".LoadData : " & ex.Message)
            Return False
        Finally
        End Try
    End Function

    Private Function ShowProductList(ByVal pMode As Integer) As Boolean
        Try
            Dim lIsReadOnly As Boolean
            Dim lColData As ProColumn = GetColData()
            Dim lBuyOrSell As Boolean = CheckIsSell(mOrderType)
            Dim lOrderList As New List(Of Long)
            lOrderList.Add(mcls.ID)
            gCustomerID = ConvertNullToZero(CustomerID.EditValue)
            If mMode = DataMode.ModeNew Then
                lIsReadOnly = False
            ElseIf mcls.IsDelete = True Then
                lIsReadOnly = True
            ElseIf mcls.OrderStatus = EnumStatus.Open.ToString Or mcls.OrderStatus = EnumStatus.Approve.ToString Or mcls.OrderStatus = EnumStatus.Waiting.ToString Then
                lIsReadOnly = False
            Else
                lIsReadOnly = True
            End If
            If IsNothing(ProductList) Then
                UcProductLists1.ShowControl(pMode, lOrderList, mcls.TableName, lColData, lIsReadOnly, False, Me, True, mcls.TableName, False, mcls.IsDelete, 0, mcls.StockType)
            Else
                UcProductLists1.ShowControlByDataSource(pMode, ProductList, lColData, lIsReadOnly, Me, mOrderType.ToString, lBuyOrSell, lOrderList, False, mIsMakePO, mcls.StockType)
            End If


        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".ShowProductList : " & ex.Message)
            Return False
        Finally
        End Try
    End Function

    Private Function ShowProductListBySource(ByVal pMode As Integer, ByVal pSource As List(Of ProductSubDAO), ByRef pOrderID As List(Of Long)) As Boolean
        Try
            Dim lBuyOrSell As Boolean = CheckIsSell(mOrderType)
            Dim lColData As ProColumn = GetColData()
           
            gCustomerID = ConvertNullToZero(CustomerID.EditValue)
            UcProductLists1.ShowControlByDataSource(pMode, pSource, lColData, False, Me, mOrderType.ToString, lBuyOrSell, pOrderID, True, mIsMakePO, mcls.StockType)
            Calculation()
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".ShowProductListBySource : " & ex.Message)
            Return False
        Finally
        End Try
    End Function

    Private Function LoadConvert(ByVal pID As Long) As Boolean

        Try
            MyBase.SetMode = DataMode.ModeNew
            mMode = DataMode.ModeNew
            OrderCode.EditValue = AutoGenCode(mOrderType)
            IsCancel.EditValue = False
            OrderStatus.EditValue = EnumStatus.Open.ToString
            CustomerID.Properties.ReadOnly = True
            If IsNothing(mclsConvert) Then
                mclsConvert = New OrderSDAO
            End If
            If mclsConvert.InitailData(pID) Then
                ShipingMethod.EditValue = mcls.ShipingMethodID
                ShipingBy.EditValue = mcls.ShipingByID
                ShipingRuleID.EditValue = mcls.ShipingRuleID
                ShipingDate.EditValue = mcls.ShipingDate
                CustomerID.EditValue = mclsConvert.CustomerID
                Institute.EditValue = mclsConvert.Institute
                EmpID.EditValue = mclsConvert.EmpID
                CreditRuleID.EditValue = mclsConvert.CreditRuleID
                VatTypeID.EditValue = mclsConvert.VatTypeID
                cboCurrency.EditValue = mclsConvert.CurrencyID
                Total.EditValue = mclsConvert.Total
                DiscountPercen.EditValue = mclsConvert.DiscountPercen
                DiscountAmount.EditValue = mclsConvert.DiscountAmount
                VatPercen.EditValue = mclsConvert.VatPercen
                VatAmount.EditValue = mclsConvert.VatAmount
                PledgeTotal.EditValue = mclsConvert.PledgeTotal
                TotalAfterPledge.EditValue = Total.EditValue - PledgeTotal.EditValue
                GrandTotal.EditValue = mclsConvert.GrandTotal
                Remark.EditValue = mclsConvert.Remark
                SendBy.EditValue = mclsConvert.SendBy
                PayType.EditValue = mclsConvert.PayType
                PO.EditValue = mclsConvert.PO
                gCustomerID = ConvertNullToZero(CustomerID.EditValue)
                Dim lOrderList As New List(Of Long)
                lOrderList.Add(mclsConvert.ID)

                UcProductLists1.ShowControl(mMode, lOrderList, mclsConvert.TableName, GetColData, False, True, Me, True, mcls.TableName, False, False, 0, mcls.StockType)
                UcNote1.ShowControl(mclsConvert.TableName, mclsConvert.ID)
                InitialRefOrder(pID, "", False)
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".LoadConvert : " & ex.Message)
            Return False
        Finally

        End Try
    End Function

    Private Function Verify() As Boolean
        Dim lstrErr As String = ""
        Try
            DxErrorProvider1.ClearErrors()
            If Trim(OrderCode.Text) = "" Then
                SetErrorProvider(DxErrorProvider1, OrderCode, "กรุณาระบุเลขที่เอกสาร")
            ElseIf mcls.CheckExist() Then
                SetErrorProvider(DxErrorProvider1, OrderCode, "เลขที่เอกสารซ้ำ")
            End If
            lstrErr = lstrErr & DxErrorProvider1.GetError(OrderCode) & vbNewLine

            If LayoutCustomerID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always Then
                If ConvertNullToZero(CustomerID.EditValue) = 0 Then
                    SetErrorProvider(DxErrorProvider1, CustomerID, "กรุณาระบุลูกค้า/เจ้าหนี้")
                    lstrErr = lstrErr & DxErrorProvider1.GetError(CustomerID) & vbNewLine
                End If
            End If

 
            If ConvertNullToZero(VatTypeID.EditValue) = 0 Then
                SetErrorProvider(DxErrorProvider1, VatTypeID, "กรุณาระบุรูปแบบภาษี")
                lstrErr = lstrErr & DxErrorProvider1.GetError(VatTypeID) & vbNewLine
            End If
 
            'Sum Stock
            If mOrderType = MasterType.SellOrders Then
                Dim lclsStock As New ProductStockDAO
                If lclsStock.CheckSumStock(Nothing, True) = False Then
                    lstrErr = lstrErr & "กรุณาระบุคลังรวม (หน้า running format)" & vbNewLine
                End If
            End If

            lstrErr = lstrErr & UcProductLists1.IsError
            If lstrErr.Trim <> "" Then
                ShowProgress(False, "")
                lstrErr = "พบข้อผิดพลาดกรุณาตรวจสอบ : " & vbNewLine & lstrErr
                XtraMessageBox.Show(Me, lstrErr, "ตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Else
                Return True
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".Verify : " & e.Message)
        End Try
    End Function

    Friend Sub Calculation()
        Dim lTotal As Decimal = 0
        Dim lVatAmt As Decimal = 0

        Try
            If mIsFromLoad = False Then
                UcProductLists1.GetDAOs(False, True, mOrderType = MasterType.SellOrders, Nothing, True, 0, False, "", 0, mcls.StockType)
                Total.EditValue = UcProductLists1.Totals

                UcPledge1.GetDAOs()
                PledgeTotal.EditValue = UcPledge1.Totals

                If Total.EditValue = 0 Then
                    TotalAfterDis.EditValue = 0
                    GrandTotal.EditValue = 0
                    TotalAfterPledge.EditValue = 0
                    TotalTax.EditValue = 0
                    VatAmount.EditValue = 0
                Else
                    'DiscountAmount.EditValue = Total.EditValue * (DiscountPercen.EditValue / 100)

                    Select Case mVatType
                        Case "E"
                            TotalAfterPledge.EditValue = Total.EditValue - PledgeTotal.EditValue
                            TotalAfterDis.EditValue = TotalAfterPledge.EditValue - DiscountAmount.EditValue
                            lVatAmt = TotalAfterDis.EditValue * (VatPercen.EditValue / 100)
                          
                        Case "I"
                            lTotal = Total.EditValue * (100 / (100 + VatPercen.EditValue))
                            Total.EditValue = lTotal
                            TotalAfterPledge.EditValue = lTotal - PledgeTotal.EditValue
                            TotalAfterDis.EditValue = TotalAfterPledge.EditValue - DiscountAmount.EditValue
                            lVatAmt = TotalAfterDis.EditValue * (VatPercen.EditValue / 100)
                        Case "N"
                            TotalAfterPledge.EditValue = Total.EditValue - PledgeTotal.EditValue
                            TotalAfterDis.EditValue = TotalAfterPledge.EditValue - DiscountAmount.EditValue
                            lVatAmt = 0
                    End Select

                    If chkIsEditVat.CheckState = CheckState.Unchecked Then
                        VatAmount.EditValue = lVatAmt
                    End If

                GrandTotal.EditValue = TotalAfterDis.EditValue + VatAmount.EditValue
                TotalTax.EditValue = mTaxOrderTotal
                GrandTotal.EditValue = (GrandTotal.EditValue - TotalTax.EditValue) * ConvertNullToZero(Exchange.EditValue)
            End If
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".Calculation : " & e.Message)
        Finally
        End Try
    End Sub

    Private Sub InitialVatType(ByVal plngVatTypeID As Long)
        Dim lcls As VatTypeDAO
        Try
            If plngVatTypeID > 0 And mIsFromLoad = False Then
                lcls = New VatTypeDAO
                If lcls.InitailData(plngVatTypeID, "") Then
                    VatPercen.EditValue = lcls.VatRate
                    mVatType = lcls.VatType
                Else
                    mVatType = ""
                    VatPercen.EditValue = 0
                End If
                Calculation()
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".InitialVatType : " & ex.Message)
        Finally
            lcls = Nothing
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

    Private Sub InitialCreditRule(ByVal plngCreditRule As Long)
        Dim lcls As CreditRoleDAO, llngCreditDays As Long = 0
        Try
            If mOrderType <> MasterType.Quotation Then
                If plngCreditRule > 0 Then
                    lcls = New CreditRoleDAO
                    If lcls.InitailData(plngCreditRule, "") Then
                        llngCreditDays = lcls.CreditDay
                    End If
                    ExpireDate.EditValue = DateAdd(DateInterval.Day, llngCreditDays, OrderDate.EditValue)
                Else
                    ExpireDate.EditValue = OrderDate.EditValue
                End If
            End If
           
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".InitialCreditRule : " & ex.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    Private Sub InitialCusInfo(ByVal plngCustomerID As Long)
        Dim lcls As CustomerDAO
        Dim lclsCredit As CreditBalanceDAO
        Try
            CreditBalance.EditValue = ""
            If mIsFromLoad = False Then
                If plngCustomerID > 0 Then
                    lcls = New CustomerDAO
                    lcls.InitailData(plngCustomerID)
                    InitialCusTaxInfo(plngCustomerID, lcls)
                    VatTypeID.EditValue = lcls.VatTypeID
                    CreditRuleID.EditValue = lcls.CreditRuleID
                    SendBy.EditValue = lcls.SendBy
                    EmpID.EditValue = lcls.EmpID
                    cboCurrency.EditValue = lcls.CurrencyID
                  
                    lclsCredit = New CreditBalanceDAO
                    lclsCredit.InitailCreditBalance(plngCustomerID)
                    CreditBalance.EditValue = lclsCredit.CreditAmount
                    gCustomerID = plngCustomerID
                Else
                    CreditBalance.Text = ""
                    gCustomerID = 0
                End If

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


    Private Sub InitialIsEditVat(ByVal pIsEdit As Boolean)
        If pIsEdit = True Then
            VatAmount.Properties.ReadOnly = False
            VatAmount.Properties.Appearance.BackColor = Color.White
        Else
            VatAmount.Properties.ReadOnly = True
            VatAmount.Properties.Appearance.BackColor = Color.LightYellow
        End If
    End Sub

    Private Function GetColData() As ProColumn
        Try
            Dim lColData As ProColumn = 0
            lColData = ProColumn.Units + ProColumn.Price + ProColumn.UnitName + ProColumn.Total + ProColumn.Discount
            Return lColData
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".GetColData : " & ex.Message)
            Return 0
        Finally
        End Try
    End Function

    Private Sub MakeReserve(ByVal pProList As List(Of ProductListDAO))
        Dim lcls As ProductSubDAO
        Dim lProductList As New List(Of ProductSubDAO)
        Try
            ShowProgress(True, "Loading...")

            For Each pProID As ProductListDAO In pProList
                lcls = New ProductSubDAO
                lcls.IsSelect = True
                lcls.Cost = pProID.Cost
                lcls.ID = pProID.ID
                lcls.LocationDTLID = pProID.LocationDTLID
                lcls.Price = pProID.Price
                lcls.ProductCode = pProID.ProductCode
                lcls.ProductID = pProID.ProductID
                lcls.ProductNameExt = pProID.ProductNameExt
                lcls.ProductNames = pProID.ProductName
                lcls.Remark = pProID.Remark
                lcls.SEQ = pProID.SEQ
                lcls.Total = pProID.Total
                lcls.UnitID = pProID.UnitID
                lcls.UnitName = pProID.UnitName
                lcls.Units = pProID.Units
                lcls.Units_Old = pProID.Units_Old
                lProductList.Add(lcls)
            Next

            Dim lFormEdit As New frmOrderS
            With lFormEdit
                .OrderType = MasterType.Reserve
                .Caption = "ใบสั่งจอง"
                .MdiParent = frmMain
                .ModeData = DataMode.ModeNew
                .IDs = 0
                .ProductList = lProductList
                .CusID = ConvertNullToZero(CustomerID.EditValue)
                .Show()
            End With
        Catch ex As Exception
            ShowProgress(False, "")
            Err.Raise(Err.Number, ex.Source, mFormName & ".GetColData : " & ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub
#End Region

#Region "Set combo"
    Private Sub SetComboCustomer()
        Try
            If mOrderType = MasterType.Asset Then
                SetSearchLookCustomer(CustomerID, True, True)
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

    Private Sub SetCreditRole()
        Try
            SetLookUpCreditRole(CreditRuleID)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetCreditRole : " & e.Message)
        End Try
    End Sub

    Private Sub SetVatType()
        Try
            SetLookUpVatType(VatTypeID)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetVatType : " & e.Message)
        End Try
    End Sub

    Private Sub SetCurrency()
        Try
            SetLookUpCurrency(cboCurrency)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetCurrentcy : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboShipingByID()
        Try
            SetComboMasterLook(ShipingBy, MasterType.ShipingBy)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboShipingByID : " & e.Message)
        End Try
    End Sub
    Private Sub SetComboQuoRemarkID()
        Try
            SetComboMasterLook(QuotationRemark, MasterType.QuotationRemark)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboQuoRemarkID : " & e.Message)
        End Try
    End Sub
    Private Sub SetComboShipingRuleID()
        Try
            SetComboMasterLook(ShipingRuleID, MasterType.ShipingRule)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboShipingRuleID : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboShipingMethodeID()
        Try
            SetComboMasterLook(ShipingMethod, MasterType.ShipingMethod)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboShipingMethodeID : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboAgency()
        Try
            SetSearchLookAgency(CustomerID)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboAgency : " & e.Message)
        End Try
    End Sub
#End Region


#Region "TaxOrder"

    Private Sub LoadTaxOrder(ByVal pRefOrderID As Long)
        Dim lcls As New TaxOrderDAO
        Dim dataTable As New DataTable()
        Try
            If TaxGroup.Enabled = True Then
                'gridView.OptionsBehavior.ReadOnly = mIsReaOnly
                dataTable = lcls.GetDataTable(pRefOrderID, False)
                GridTaxOrder.DataSource = dataTable
                LoadTaxTypeIDLookUp()
                'GridStyle()
            End If

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
            If GridView3.RowCount > 0 And mIsFromLoad = False And TaxGroup.Enabled = True Then
                For lRow = 0 To GridView3.RowCount
                    If ConvertNullToZero(GridView3.GetRowCellValue(lRow, "TaxTypeID")) > 0 Then
                        lDataDAO = New TaxOrderDAO
                        lDataDAO.TaxOrderID = ConvertNullToZero(GridView3.GetRowCellDisplayText(lRow, "TaxOrderID"))
                        lDataDAO.TaxTypeID = ConvertNullToZero(GridView3.GetRowCellValue(lRow, "TaxTypeID"))
                        lDataDAO.TaxTotal = ConvertNullToZero(GridView3.GetRowCellValue(lRow, "TaxTotal"))
                        lDataDAO.TaxRate = ConvertNullToZero(GridView3.GetRowCellValue(lRow, "TaxRate"))
                        lDataDAO.TaxAmount = ConvertNullToZero(GridView3.GetRowCellValue(lRow, "TaxAmount"))
                        lDataDAO.OtherTax = ConvertNullToString(GridView3.GetRowCellValue(lRow, "OtherTax"))
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


    Private Sub GridView3_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView3.CellValueChanged
        If mIsFromLoad = False And TaxGroup.Enabled = True Then
            Dim rowHandle As Long = (TryCast(GridTaxOrder.MainView, ColumnView)).FocusedRowHandle
            If GridView3.FocusedColumn.FieldName = "TaxTypeID" Then
                If ConvertNullToZero(GridView3.GetRowCellValue(rowHandle, "TaxTypeID")) = 12 Then
                    Dim lstrMsg As String = InputBox("ระบุประเภทเงินได้", "ประเภทเงินได้", ConvertNullToString(GridView3.GetRowCellValue(rowHandle, "OtherTax"))).Trim
                    If lstrMsg <> "" Then
                        mIsFromLoad = True
                        GridView3.SetFocusedRowCellValue("OtherTax", lstrMsg)
                        mIsFromLoad = False
                    End If
                End If

            End If
        End If

        Call GetTaxOrderList()
    End Sub

    Private Sub GridView3_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GridView3.RowUpdated

        Call GetTaxOrderList()
    End Sub


    Private Sub GridView3_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GridView3.ValidatingEditor
        Dim rowHandle As Long = (TryCast(GridTaxOrder.MainView, ColumnView)).FocusedRowHandle
        If Not GridView3.GetFocusedRow Is Nothing Then
            If GridView3.FocusedColumn.FieldName = "TaxRate" Then
                GridView3.SetFocusedRowCellValue("TaxAmount", (e.Value / 100) * ConvertNullToZero(GridView3.GetRowCellValue(rowHandle, "TaxTotal")))

            ElseIf GridView3.FocusedColumn.FieldName = "TaxAmount" Then
                GridView3.SetFocusedRowCellValue("TaxAmount", e.Value * (ConvertNullToZero(GridView3.GetRowCellValue(rowHandle, "TaxRate")) / 100))
                'ElseIf GridView3.FocusedColumn.FieldName = "TaxTypeID" Then
                '    If ConvertNullToZero(GridView3.GetRowCellValue(rowHandle, "TaxTypeID")) = 12 Then
                '        Dim lstrMsg As String = InputBox("ระบุประเภทเงินได้", "ประเภทเงินได้", "").Trim
                '        If lstrMsg <> "" Then

                '        End If
                '    End If

            End If

        End If
    End Sub
    Private Sub XtraTabControl1_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If e.Page Is GeneralTabPage And e.PrevPage Is TaxTabPage Then
            Call GetTaxOrderList()
        ElseIf XtraTabControl1.SelectedTabPage Is GeneralTabPage Then
            Calculation()
        End If
    End Sub
#End Region


     
    Private Sub Exchange_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Exchange.EditValueChanged
        Calculation()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        mRefOrderID = New List(Of Long)
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub VatAmount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles VatAmount.LostFocus
        If mIsFromLoad = False Then
         
                Calculation()

        End If
    End Sub
 

    Private Sub chkIsEditVat_CheckedChanged(sender As Object, e As System.EventArgs) Handles chkIsEditVat.CheckedChanged
        If mIsFromLoad = False Then
            InitialIsEditVat(chkIsEditVat.CheckState = CheckState.Checked)
        End If
    End Sub
 
    Private Sub btnQuotationRemark_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnQuotationRemark.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboQuoRemarkID()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub chkNotPass_CheckedChanged(sender As Object, e As System.EventArgs) Handles chkNotPass.CheckedChanged
        If (IsCancel.EditValue = True) Or (chkNotPass.EditValue = True) Then
            CancelRemark.Properties.ReadOnly = False
        Else
            CancelRemark.Properties.ReadOnly = True
        End If
    End Sub

    
    Private Sub QuotationDays_EditValueChanged(sender As Object, e As System.EventArgs) Handles QuotationDays.EditValueChanged
        CalcExpireDate()
    End Sub

    Private Sub CalcExpireDate()
        Dim lQuotationDay As Long = ConvertNullToZero(QuotationDays.EditValue)
        If mIsFromLoad = False And mOrderType = MasterType.Quotation Then
            If lQuotationDay > 0 Then
                ExpireDate.EditValue = DateAdd(DateInterval.Day, lQuotationDay - 1, OrderDate.EditValue)
            Else
                ExpireDate.EditValue = GetCurrentDate(Nothing)
            End If
        End If
    End Sub
End Class