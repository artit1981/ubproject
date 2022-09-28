
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
    Private mProductList As List(Of ProductListDAO)
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
            LayoutPO_2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
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
            LayoutStockType2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
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

            LayoutCampaign.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutbtnCampaign.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never

            'Claim
            LayoutClaimRemark.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutClaimRemark2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutClaimResult.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutClaimResult2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never

            mFormName = mOrderType.ToString
            Select Case mOrderType
                Case MasterType.Quotation, MasterType.Quotation2
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
                    LayoutPO_2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
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
                    LayoutPO_2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutExpireDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutExpireDate2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutStockType.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutStockType2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutInvoiceSuplierID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutInvoiceSuplierID2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                Case MasterType.Shiping
                    OptionSubItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    MakeOrderBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
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
                    LayoutPO.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutPO_2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
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
                    LayoutPledge1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutPledge3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutPledge4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    PledgeTabPage.PageEnabled = True

                Case MasterType.Reserve
                    LayoutShipingDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutShipingDate2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutExpireDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutExpireDate2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutPO.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutPO_2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                Case MasterType.Invoice, MasterType.Borrow, MasterType.InvoiceOnline
                    OptionSubItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    MakeOrderBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    LayoutShipingDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutShipingDate2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutPO.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutPO_2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutPayType.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutPayType2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutExpireDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutExpireDate2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutPayType.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutPayType2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    If mOrderType = MasterType.Invoice Or mOrderType = MasterType.InvoiceOnline Then
                        LayoutCampaign.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                        LayoutbtnCampaign.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    End If

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
                    LayoutPO_2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutExpireDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutExpireDate2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutCreditBalance.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    LayoutCreditBalance2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    LayoutCreditRuleID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    LayoutbtnCreditRuleID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    LayoutInvoiceSuplierID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutInvoiceSuplierID2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutStockType.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutStockType2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutInvoiceSuplierID.Text = "เอกสารอ้างอิงเจ้าหนี้"
                Case MasterType.Claim, MasterType.Expose, MasterType.ClaimOut, MasterType.ClaimResult
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
                    LayoutClaimRemark.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutClaimRemark2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutClaimResult.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutClaimResult2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayouShipingBy.Text = "วิธีการส่งเคลม"
                    TaxGroup1.Enabled = False
                Case MasterType.ClaimReturn
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
                    LayoutClaimRemark.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutClaimRemark2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutClaimResult.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutClaimResult2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayouShipingBy.Text = "วิธีการส่งเคลม"
                    LayoutRefPO.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutRefPO.Text = "เลขที่รับเคลม"
                    LayoutRefPO1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    TaxGroup1.Enabled = False
                    LayoutStockType.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    LayoutStockType2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            End Select
            LayoutControl1.AllowCustomization = False
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
                    UcNote2.ClearControl()
                    UcProductLists1.ClearControl()
                    UcPledge1.ClearControl()

                    OrderDate.Properties.ReadOnly = False

            End Select
            XtraTabControl1.SelectedTabPage = GeneralTabPage
            OrderCode.Select()
            TaxMonthYear.EditValue = OrderDate.EditValue
            'default

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
            If mcls.IsCancel = False And IsCancel.CheckState = CheckState.Checked Then
                mcls.IsChangeCancel = True
            ElseIf mcls.IsCancel = True And IsCancel.CheckState = CheckState.Unchecked Then
                mcls.IsChangeCancel = True
            End If
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
            mcls.ClaimRemark = ConvertNullToString(ClaimRemark.EditValue)
            mcls.ClaimResult = ConvertNullToString(ClaimResult.EditValue)
            mcls.QuotationRemarkID = ConvertNullToZero(QuotationRemark.EditValue)
            mcls.CampaignID = ConvertNullToZero(Campaign.EditValue)
            If TaxCanYes.Checked = True Then
                mcls.TaxCanYes = "Y"
            Else
                mcls.TaxCanYes = "N"
            End If
            mcls.IsNotPass = chkNotPass.Checked
            mcls.NoteDAOs = UcNote1.GetNoteDAOs
            mcls.NoteProductDAOs = UcNote2.GetNoteDAOs
            mcls.FileAttachs = UcFileAttach1.GetFileAttachs
            mcls.IsMakePO = mIsMakePO



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
                If XtraMessageBox.Show(Me, "สินค้าในสต๊อกไม่เพียงพอ ต้องการทำรายการใบสั่งจองหรือไม่" & vbNewLine & UcProductLists1.IsError, "สต๊อกหมด", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    MakeReserve(lProListStockFail)
                End If
                Return False
            End If

            mcls.PledgeDAOs = UcPledge1.GetDAOs()

            If Verify() = True Then

                Call mcls.SaveData()
                ShowProgress(False, "")
                If (mcls.OrderStatus = EnumStatus.WaitApprove.ToString) Then

                    XtraMessageBox.Show(Me, "บันทึกรายการสำเร็จ รอการอนุมัติ", "Approve", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Else
                    Select Case mOrderType
                        Case MasterType.SellOrders, MasterType.Invoice, MasterType.InvoiceOnline, MasterType.Shiping, MasterType.Reserve, MasterType.PurchaseOrder _
                            , MasterType.Quotation, MasterType.Claim, MasterType.ClaimOut, MasterType.ReduceCredit, MasterType.ReduceCreditBuy _
                            , MasterType.Borrow, MasterType.Expose, MasterType.ClaimReturn
                            If XtraMessageBox.Show(Me, "บันทึกรายการสำเร็จ ต้องการพิมพ์เอกสารหรือไม่ ?", "พิมพ์เอกสาร", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                                modReport.PrintReportOrder(mOrderType, mcls.ID)
                            End If
                        Case Else
                            XtraMessageBox.Show(Me, "บันทึกรายการสำเร็จ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                            ShowProgress(False, "")
                    End Select
                End If
                Return True
            End If
        Catch ex As Exception
            If Err.Number = -1 Then
                XtraMessageBox.Show("Serial Number บางรายการถุก Close แล้ว ไม่สามารถทำรายการได้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Err.Raise(Err.Number, ex.Source, mFormName & ".Save : " & ex.Message)
            End If

            Return False
        End Try
    End Function


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

    Private Sub btnCampaign_Click(sender As Object, e As System.EventArgs) Handles btnCampaign.Click
        SetComboCampaign(False)
    End Sub

    Private Sub Exchange_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Exchange.EditValueChanged
        Calculation()
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




    Private Sub btnCalc_Click(sender As System.Object, e As System.EventArgs) Handles btnCalc.Click
        CalcEdit1.ShowPopup()
        CalcEdit1.Focus()
    End Sub
#End Region

#Region "Private"
    Private Sub ShowFindOrder()
        Dim lfrm As New frmFindOrder
        Dim lSubOrderList As New List(Of SubOrder)
        Dim lOrderList As New List(Of Long), lIsInitProduct As Boolean
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
                        lIsInitProduct = False
                        mProductList = lfrm.GetProductSubList
                    Else
                        lIsInitProduct = True
                        mProductList = New List(Of ProductListDAO)
                    End If


                    lSubOrderList = lfrm.GetSubOrderList
                    If Not lSubOrderList Is Nothing Then
                        If lSubOrderList.Count > 0 Then
                            mIsGroupDupProduct = 0
                            txtRefOrder.Text = ""
                            mRefOrderID = New List(Of Long)

                            For Each rec As SubOrder In lSubOrderList
                                mRefOrderID.Add(rec.OrderID)
                                InitialRefOrder(rec.OrderID, "", lIsInitProduct)
                            Next
                            ShowProductListBySource(mMode, mProductList, mRefOrderID)
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
                    Case MasterType.Invoice, MasterType.InvoiceOnline
                        If InitialOrder(pRefOrderID, pRefOrderCode.Trim, pInitProduct, MasterType.SellOrders) Then Return True
                        If InitialOrder(pRefOrderID, pRefOrderCode.Trim, pInitProduct, MasterType.Borrow) Then Return True
                    Case MasterType.Shiping, MasterType.Borrow
                        InitialOrder(pRefOrderID, pRefOrderCode.Trim, pInitProduct, MasterType.SellOrders)
                    Case MasterType.AddCredit, MasterType.ReduceCredit
                        If InitialOrder(pRefOrderID, pRefOrderCode.Trim, pInitProduct, MasterType.SellOrders) Then Return True
                        If InitialOrder(pRefOrderID, pRefOrderCode.Trim, pInitProduct, MasterType.Shiping) Then Return True
                        If InitialOrder(pRefOrderID, pRefOrderCode.Trim, pInitProduct, MasterType.Invoice) Then Return True
                        If InitialOrder(pRefOrderID, pRefOrderCode.Trim, pInitProduct, MasterType.InvoiceOnline) Then Return True
                        InitialOrder(pRefOrderID, pRefOrderCode.Trim, pInitProduct, MasterType.ClaimResult)
                    Case MasterType.Reserve
                        InitialOrder(pRefOrderID, pRefOrderCode.Trim, pInitProduct, MasterType.Quotation)
                    Case MasterType.InvoiceBuy, MasterType.ShipingBuy
                        InitialOrder(pRefOrderID, pRefOrderCode.Trim, pInitProduct, MasterType.PurchaseOrder)
                    Case MasterType.Claim
                        If InitialOrder(pRefOrderID, pRefOrderCode.Trim, pInitProduct, MasterType.Invoice) Then Return True
                        If InitialOrder(pRefOrderID, pRefOrderCode.Trim, pInitProduct, MasterType.InvoiceOnline) Then Return True
                        InitialOrder(pRefOrderID, pRefOrderCode.Trim, pInitProduct, MasterType.Shiping)
                    Case MasterType.ClaimOut
                        InitialOrder(pRefOrderID, pRefOrderCode.Trim, pInitProduct, MasterType.Claim)
                    Case MasterType.ClaimResult
                        InitialOrder(pRefOrderID, pRefOrderCode.Trim, pInitProduct, MasterType.ClaimOut)
                    Case MasterType.ClaimReturn
                        InitialOrder(pRefOrderID, pRefOrderCode.Trim, pInitProduct, MasterType.ClaimResult)
                    Case MasterType.ReduceCreditBuy, MasterType.AddCreditBuy
                        If InitialOrder(pRefOrderID, pRefOrderCode.Trim, pInitProduct, MasterType.InvoiceBuy) Then Return True
                        If InitialOrder(pRefOrderID, pRefOrderCode.Trim, pInitProduct, MasterType.ShipingBuy) Then Return True
                    Case MasterType.Expose
                        InitialOrder(pRefOrderID, pRefOrderCode.Trim, pInitProduct, MasterType.Claim)
                    Case MasterType.Asset
                        InitialOrder(pRefOrderID, pRefOrderCode.Trim, pInitProduct, MasterType.PurchaseOrder)

                End Select

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

                    If txtRefOrder.Text = "" Then
                        txtRefOrder.Text = lcls.Subject
                    Else
                        txtRefOrder.Text = txtRefOrder.Text & ", " & lcls.Subject
                    End If
                    If pInitProduct Then
                        gCustomerID = ConvertNullToZero(CustomerID.EditValue)
                        LoadProList(plngOppID, MasterType.Opportunity)

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
                        If mMode = DataMode.ModeNew Then
                            UcNote2.ShowControl(lcls.TableName & "_PRO", plngOrderID, mRefOrderID.Count > 0)  'Product Remark
                        End If
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
        Dim rec As New ProductListDAO, lIndex As Long
        Dim dataTable As New DataTable()
        Dim llngProID As Long, llngUnitID As Long
        Dim lOrderList As New List(Of Long)
        Dim lIsSell As Boolean, lNotRefUnits As Long = 0
        Dim lCalcUnit As Long, lCalcAdjustUnit As Long, lCalcTotal As Long, lCanNotMerge As Boolean = False

        lIsSell = CheckIsSell(mOrderType)
        lOrderList.Add(pOrderID)
        Try
            Dim lIsConfirm As Boolean = False
            If pTableID = MasterType.ReduceCredit Or pTableID = MasterType.AddCredit Then
                lIsConfirm = False
            End If

            dataTable = lcls.GetDataTable(lOrderList, pTableID.ToString, Nothing, lIsConfirm, "", False, mOrderType, True)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    llngProID = ConvertNullToZero(dr("ProductID"))
                    llngUnitID = ConvertNullToZero(dr("UnitID"))

                    Call GetRefOrderStatus(pOrderID, mOrderType, mcls.ID, dr("ID"), llngProID, Nothing, mMode, lNotRefUnits, ConvertNullToZero(dr("Units")))

                    If lNotRefUnits > 0 Then
                        If lNotRefUnits < ConvertNullToZero(dr("Units")) Then
                            lCalcUnit = lNotRefUnits
                            lCalcAdjustUnit = lNotRefUnits / ConvertNullToZero(dr("RateUnit"))
                            lCalcTotal = (lNotRefUnits * ConvertNullToZero(dr("PriceMain"))) - (lCalcAdjustUnit * ConvertNullToZero(dr("Discount")))
                        Else
                            lCalcUnit = ConvertNullToZero(dr("Units"))
                            lCalcAdjustUnit = ConvertNullToZero(dr("AdjustUnit"))
                            lCalcTotal = ConvertNullToZero(dr("Total"))
                        End If

                        lIndex = mProductList.FindIndex(Function(m As ProductListDAO) m.ProductID = llngProID And m.IsShow = 1 And m.UnitID = llngUnitID)

                        If lIndex < 0 Or mIsGroupDupProduct = 1 Or ConvertNullToZero(dr("IsShow")) = 0 Or lCanNotMerge = True Then
                            rec = New ProductListDAO
                            rec.IsSelect = True
                            rec.ID = ConvertNullToZero(dr("ID"))
                            rec.SEQ = 0
                            rec.IsSN = ConvertNullToZero(dr("IsSN"))
                            rec.RefID = ConvertNullToZero(dr("RefID"))
                            rec.ProductID = ConvertNullToZero(dr("ProductID"))
                            rec.ProductCode = ConvertNullToString(dr("ProductCode"))
                            rec.ProductName = ConvertNullToString(dr("ProductName"))
                            rec.ProductNameExt = ConvertNullToString(dr("ProductNameExt"))
                            rec.LocationDTLID = ConvertNullToZero(dr("LocationDTLID"))
                            rec.UnitID = ConvertNullToZero(dr("UnitID"))
                            If lIsSell = True Then
                                rec.UnitMainID = ConvertNullToZero(dr("UnitMainIDSell"))
                            Else
                                rec.UnitMainID = ConvertNullToZero(dr("UnitMainIDBuy"))
                            End If
                            rec.UnitName = ConvertNullToString(dr("UnitName"))
                            rec.Remark = ConvertNullToString(dr("Remark"))
                            rec.KeepMin = ConvertNullToZero(dr("KeepMin"))
                            rec.RateUnit = ConvertNullToZero(dr("RateUnit"))
                            rec.Price = ConvertNullToZero(dr("Price"))
                            rec.PriceMain = ConvertNullToZero(dr("PriceMain"))
                            rec.Cost = ConvertNullToZero(dr("Cost"))
                            rec.Discount = ConvertNullToZero(dr("Discount"))
                            rec.IsShow = ConvertNullToZero(dr("IsShow"))
                            rec.ClaimRemark = ConvertNullToString(dr("ClaimRemark"))
                            rec.ClaimResult = ConvertNullToString(dr("ClaimResult"))


                            'Recalc
                            rec.Units = lCalcUnit
                            rec.AdjustUnit = lCalcAdjustUnit
                            rec.Total = lCalcTotal
                            rec.ProductListRefID = ConvertNullToZero(dr("ID"))
                            rec.ProductListRefID2 = 0
                            rec.ProductListRefID3 = 0
                            rec.ProductListRefID4 = 0
                            rec.ProductListRefID5 = 0
                            rec.ProductListUnitRef1 = lCalcUnit
                            rec.ProductListUnitRef2 = 0
                            rec.ProductListUnitRef3 = 0
                            rec.ProductListUnitRef4 = 0
                            rec.ProductListUnitRef5 = 0
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
                                If XtraMessageBox.Show(Me, "มีข้อมูลสินค้าซ้ำต้องการรวมรายการหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                                    mIsGroupDupProduct = 2
                                Else
                                    mIsGroupDupProduct = 1
                                    rec = New ProductListDAO
                                    rec.IsSelect = True
                                    rec.IsSN = ConvertNullToZero(dr("IsSN"))
                                    rec.SEQ = 0
                                    rec.ID = ConvertNullToZero(dr("ID"))
                                    rec.RefID = ConvertNullToZero(dr("RefID"))
                                    rec.ProductID = ConvertNullToZero(dr("ProductID"))
                                    rec.ProductCode = ConvertNullToString(dr("ProductCode"))
                                    rec.ProductName = ConvertNullToString(dr("ProductName"))
                                    rec.ProductNameExt = ConvertNullToString(dr("ProductNameExt"))
                                    rec.LocationDTLID = ConvertNullToZero(dr("LocationDTLID"))
                                    rec.UnitID = ConvertNullToZero(dr("UnitID"))
                                    If lIsSell = True Then
                                        rec.UnitMainID = ConvertNullToZero(dr("UnitMainIDSell"))
                                    Else
                                        rec.UnitMainID = ConvertNullToZero(dr("UnitMainIDBuy"))
                                    End If
                                    rec.UnitName = ConvertNullToString(dr("UnitName"))
                                    rec.Remark = ConvertNullToString(dr("Remark"))
                                    rec.KeepMin = ConvertNullToZero(dr("KeepMin"))
                                    rec.RateUnit = ConvertNullToZero(dr("RateUnit"))
                                    rec.Price = ConvertNullToZero(dr("Price"))
                                    rec.PriceMain = ConvertNullToZero(dr("PriceMain"))
                                    rec.Cost = ConvertNullToZero(dr("Cost"))
                                    rec.Discount = ConvertNullToZero(dr("Discount"))
                                    'Recalc
                                    rec.Units = lCalcUnit
                                    rec.AdjustUnit = lCalcAdjustUnit
                                    rec.Total = lCalcTotal

                                    rec.ModePro = DataMode.ModeNew
                                    rec.IsShow = 1
                                    rec.IsMerge = 0
                                    rec.ProductListRefID = ConvertNullToZero(dr("ID"))
                                    rec.ProductListRefID2 = 0
                                    rec.ProductListRefID3 = 0
                                    rec.ProductListRefID4 = 0
                                    rec.ProductListRefID5 = 0
                                    rec.ProductListUnitRef1 = lCalcUnit
                                    rec.ProductListUnitRef2 = 0
                                    rec.ProductListUnitRef3 = 0
                                    rec.ProductListUnitRef4 = 0
                                    rec.ProductListUnitRef5 = 0

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
                                mProductList.Item(lIndex).Units = mProductList.Item(lIndex).Units + lCalcUnit
                                mProductList.Item(lIndex).AdjustUnit = mProductList.Item(lIndex).AdjustUnit + lCalcAdjustUnit
                                mProductList.Item(lIndex).Total = mProductList.Item(lIndex).Total + lCalcTotal

                                If ConvertNullToZero(dr("IsSN")) = 1 Then
                                    For Each pSN As SnDAO In LoadSN(lOrderList, dr("ID"), dr("ProductID"))
                                        mProductList.Item(lIndex).SNList.Add(pSN)
                                    Next
                                End If
                                If mProductList.Item(lIndex).ProductListRefID2 = 0 Then
                                    mProductList.Item(lIndex).ProductListRefID2 = ConvertNullToZero(dr("ID"))
                                    mProductList.Item(lIndex).ProductListUnitRef2 = ConvertNullToZero(dr("Units"))
                                ElseIf mProductList.Item(lIndex).ProductListRefID3 = 0 Then
                                    mProductList.Item(lIndex).ProductListRefID3 = ConvertNullToZero(dr("ID"))
                                    mProductList.Item(lIndex).ProductListUnitRef3 = ConvertNullToZero(dr("Units"))
                                ElseIf mProductList.Item(lIndex).ProductListRefID4 = 0 Then
                                    mProductList.Item(lIndex).ProductListRefID4 = ConvertNullToZero(dr("ID"))
                                    mProductList.Item(lIndex).ProductListUnitRef4 = ConvertNullToZero(dr("Units"))
                                Else
                                    mProductList.Item(lIndex).ProductListRefID5 = ConvertNullToZero(dr("ID"))
                                    mProductList.Item(lIndex).ProductListUnitRef5 = ConvertNullToZero(dr("Units"))

                                    lCanNotMerge = True   'Ref slot full
                                End If
                                mProductList.Item(lIndex).IsMerge = 1
                            End If
                        End If
                    End If 'If lNotRefUnits > 0 Then
                Next
            End If 'If dataTable.Rows.Count > 0 Then

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".LoadProList : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Function



    Private Sub InitialCombo()
        Try
            SetCreditRole()
            SetVatType()
            SetEmployees()
            SetComboCustomer()
            SetComboShipingByID()
            SetComboShipingMethodeID()
            SetCurrency()
            SetComboShipingRuleID()
            SetComboQuoRemarkID()
            SetComboCampaign(mMode = DataMode.ModeEdit)
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
                    'Calculation()
                End If
            ElseIf pMode = DataMode.ModeConvert Then
                Call LoadConvert(pID)
                Calculation()
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
                                SaveBar.Enabled = (mcls.OrderStatus = EnumStatus.Open.ToString Or mcls.OrderStatus = EnumStatus.Approve.ToString _
                                                   Or mcls.OrderStatus = EnumStatus.Cancel.ToString Or mcls.OrderStatus = EnumStatus.Waiting.ToString _
                                                   Or mcls.OrderStatus = EnumStatus.Receive.ToString Or mcls.OrderStatus = EnumStatus.WaitApprove.ToString) And mcls.IsDelete = False

                                If mcls.MakePOStatus = EnumStatus.Ordered.ToString Then
                                    SaveBar.Enabled = False
                                End If
                                If mcls.MakePOStatus = EnumStatus.Ordering.ToString Then
                                    If gUserID = 5 Or gUserID = 8 Then
                                        SaveBar.Enabled = True
                                    Else
                                        SaveBar.Enabled = False
                                    End If
                                End If

                        End Select

                        PrintBar2.Enabled = (mcls.IsDelete = False) And (mcls.OrderStatus <> EnumStatus.WaitApprove.ToString)


                        'Ref order
                        txtRefOrder.Text = mcls.GetToRefOrderCode(pID, Nothing)
                        mRefOrderID = mcls.RefToOrderID

                        If mOrderType = MasterType.ClaimReturn Then
                            Dim lclsOrder As New OrderSDAO
                            For Each pRefID In mRefOrderID
                                txtRefPO.Text = lclsOrder.GetToRefOrderCode(pRefID, Nothing)
                                Exit For
                            Next
                        End If

                        If mOrderType = MasterType.PurchaseOrder Or mOrderType = MasterType.CancelPO Then
                            txtRefPO.Text = GetToRefReserveCode(pID, Nothing, mcls.RefToReserveID)
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
                    Campaign.EditValue = mcls.CampaignID
                    ClaimRemark.EditValue = mcls.ClaimRemark
                    ClaimResult.EditValue = mcls.ClaimResult
                    If mcls.TaxCanYes = "Y" Then
                        TaxCanYes.Checked = True
                    Else
                        TaxCanNo.Checked = True
                    End If
                End If
            End If

            If pMode <> DataMode.ModeConvert Then
                InitialIsEditVat(mcls.IsEditVat)
                UcNote1.ShowControl(mcls.TableName, pID)
                UcNote2.ShowControl(mcls.TableName & "_PRO", pID)  'Product Remark
                ShowProductList(mMode)
                LoadTaxOrder(pID)
                InitialCusTaxInfo(ConvertNullToZero(CustomerID.EditValue), Nothing)
                UcPledge1.ShowControl(mcls.ID, False)
                CancelRemark.Properties.ReadOnly = (IsCancel.EditValue = False)
            End If

            'Total panel
            Dim lUnits As Long = 0
            If mMode = DataMode.ModeEdit Or pMode = DataMode.ModeConvert Then
                lUnits = UcProductLists1.GetDAOs(False, True, mOrderType = MasterType.SellOrders, Nothing, True, 0, False, "", 0, mcls.StockType).Count
            End If
            InitialTotalPanel(lUnits)
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
            ElseIf mcls.OrderStatus = EnumStatus.Open.ToString Or mcls.OrderStatus = EnumStatus.Approve.ToString Then
                lIsReadOnly = False
            ElseIf mOrderType = MasterType.PurchaseOrder And mcls.OrderStatus = EnumStatus.Waiting.ToString Then
                If gUserID = 5 Or gUserID = 8 Or gUserName = "Aoae" Then
                    lIsReadOnly = False
                Else
                    lIsReadOnly = True
                End If
            Else
                lIsReadOnly = True
            End If
            If IsNothing(ProductList) Then
                UcProductLists1.ShowControl(pMode, lOrderList, mcls.TableName, lColData, lIsReadOnly, False, Me, True, mcls.TableName, False, mcls.IsDelete, mcls.StockType)
            Else
                UcProductLists1.ShowControlByDataSource(pMode, ProductList, lColData, lIsReadOnly, Me, mOrderType.ToString, lBuyOrSell, lOrderList, False, mIsMakePO, mcls.StockType)
            End If


        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".ShowProductList : " & ex.Message)
            Return False
        Finally
        End Try
    End Function

    Private Function ShowProductListBySource(ByVal pMode As Integer, ByVal pSource As List(Of ProductListDAO), ByRef pOrderID As List(Of Long)) As Boolean
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

                UcProductLists1.ShowControl(mMode, lOrderList, mclsConvert.TableName, GetColData, False, True, Me, True, mcls.TableName, False, False, mcls.StockType)
                UcNote1.ShowControl(mclsConvert.TableName, mclsConvert.ID)
                UcNote2.ShowControl(mclsConvert.TableName & "_PRO", mclsConvert.ID)
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
            If lstrErr.Trim = "PRODUCTCHANGE" Then
                ShowProgress(False, "")
                Dim lfrm As New frmOrderDTL
                lfrm.ProList = mcls.ProductDAOs
                lfrm.ShowDialog()
                If lfrm.IsSave = True Then
                    Return True
                Else
                    Return False
                End If
            ElseIf lstrErr.Trim <> "" Then
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
        Dim lUnits As Long = 0
        Try
            If mIsFromLoad = False Then
                lUnits = UcProductLists1.GetDAOs(False, True, mOrderType = MasterType.SellOrders, Nothing, True, 0, False, "", 0, mcls.StockType).Count
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
                    InitialTotalPanel(lUnits)
                End If
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".Calculation : " & e.Message)
        Finally
        End Try
    End Sub


    Private Sub InitialTotalPanel(ByVal pUnits As Long)
        Try
            txtUnits.EditValue = FormatNumber(pUnits, 0)
            txtTotal.EditValue = FormatNumber(Total.EditValue, 2)
            txtPledge.EditValue = FormatNumber(PledgeTotal.EditValue, 2)
            txtDiscount.EditValue = FormatNumber(DiscountAmount.EditValue, 2)
            txtVat.EditValue = FormatNumber(VatAmount.EditValue, 2)
            txtGrandTotal.EditValue = FormatNumber(GrandTotal.EditValue, 2)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".InitialTotalPanel : " & ex.Message)
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
                    InitialVatType(ConvertNullToZero(VatTypeID.EditValue))
                    CreditRuleID.EditValue = lcls.CreditRuleID
                    SendBy.EditValue = lcls.SendBy
                    EmpID.EditValue = lcls.EmpID
                    cboCurrency.EditValue = lcls.CurrencyID
                    InitialCurrency(ConvertNullToZero(cboCurrency.EditValue))
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
            If mOrderType = MasterType.Claim Or mOrderType = MasterType.ClaimOut Then
                lColData = ProColumn.Units + ProColumn.Price + ProColumn.UnitName + ProColumn.Total + ProColumn.Discount + ProColumn.ClaimRemark
            ElseIf mOrderType = MasterType.ClaimReturn Or mOrderType = MasterType.ClaimResult Then
                lColData = ProColumn.Units + ProColumn.Price + ProColumn.UnitName + ProColumn.Total + ProColumn.Discount + ProColumn.ClaimResult
            Else
                lColData = ProColumn.Units + ProColumn.Price + ProColumn.UnitName + ProColumn.Total + ProColumn.Discount
            End If

            Return lColData
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".GetColData : " & ex.Message)
            Return 0
        Finally
        End Try
    End Function

    Private Sub MakeReserve(ByVal pProList As List(Of ProductListDAO))

        Try
            ShowProgress(True, "Loading...")


            Dim lFormEdit As New frmOrderS
            With lFormEdit
                .OrderType = MasterType.Reserve
                .Caption = "ใบสั่งจอง"
                .MdiParent = frmMain
                .ModeData = DataMode.ModeNew
                .IDs = 0
                .ProductList = pProList
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
#End Region

#Region "Set combo"
    Private Sub SetComboCampaign(ByVal pLoadAll As Boolean)
        Try

            SetSearchLookCampaign(Campaign, OrderDate.EditValue, OrderDate.EditValue, pLoadAll)

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboCampaign : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboCustomer()
        Try
            Select Case mOrderType
                Case MasterType.InvoiceBuy, MasterType.AddCreditBuy, MasterType.ReduceCreditBuy, MasterType.ClaimOut, MasterType.PurchaseOrder _
                    , MasterType.ShipingBuy, MasterType.MakePO, MasterType.CancelPO, MasterType.ClaimResult
                    SetSearchLookAgency(CustomerID)
                Case Else
                    If mOrderType = MasterType.Asset Then
                        SetSearchLookCustomer(CustomerID, True, True)
                    Else
                        SetSearchLookCustomer(CustomerID, True, False)
                    End If
            End Select

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


#End Region


#Region "TaxOrder"

    Private Sub LoadTaxOrder(ByVal pRefOrderID As Long)
        Dim lcls As New TaxOrderDAO
        Dim dataTable As New DataTable()
        Try
            If TaxGroup.Enabled = True Then
                dataTable = lcls.GetDataTable(pRefOrderID, False)
                GridTaxOrder.DataSource = dataTable
                LoadTaxTypeIDLookUp()
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

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        mRefOrderID = New List(Of Long)
        ' Add any initialization after the InitializeComponent() call.

    End Sub



End Class