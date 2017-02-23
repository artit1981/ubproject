<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderS
    Inherits iEditForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrderS))
        Me.FormChangedComponent1 = New UB.FormChangedComponent(Me.components)
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.GeneralTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.ClaimResult = New DevExpress.XtraEditors.RadioGroup()
        Me.ClaimRemark = New DevExpress.XtraEditors.MemoEdit()
        Me.XtraTabControl2 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.UcProductLists1 = New UB.ucProductLists()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.UcNote2 = New UB.ucNote()
        Me.Campaign = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CampaignID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Subject = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.StartDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnCampaign = New DevExpress.XtraEditors.SimpleButton()
        Me.chkNotPass = New DevExpress.XtraEditors.CheckEdit()
        Me.btnQuotationRemark = New DevExpress.XtraEditors.SimpleButton()
        Me.QuotationRemark = New DevExpress.XtraEditors.LookUpEdit()
        Me.chkIsEditVat = New DevExpress.XtraEditors.CheckEdit()
        Me.txtRefPO = New DevExpress.XtraEditors.TextEdit()
        Me.StockType = New DevExpress.XtraEditors.RadioGroup()
        Me.Institute = New DevExpress.XtraEditors.TextEdit()
        Me.InvoiceSuplierID = New DevExpress.XtraEditors.TextEdit()
        Me.GrandTotal = New DevExpress.XtraEditors.CalcEdit()
        Me.TotalTax = New DevExpress.XtraEditors.CalcEdit()
        Me.ShipingRuleID = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnShipingRuleID = New DevExpress.XtraEditors.SimpleButton()
        Me.PledgeTotal = New DevExpress.XtraEditors.CalcEdit()
        Me.TotalAfterPledge = New DevExpress.XtraEditors.CalcEdit()
        Me.CreditBalance = New DevExpress.XtraEditors.CalcEdit()
        Me.PayType = New DevExpress.XtraEditors.RadioGroup()
        Me.CancelRemark = New DevExpress.XtraEditors.MemoEdit()
        Me.btnRefOrder = New DevExpress.XtraEditors.SimpleButton()
        Me.ShipingBy = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnShipingBy = New DevExpress.XtraEditors.SimpleButton()
        Me.btnShipingMethod = New DevExpress.XtraEditors.SimpleButton()
        Me.ShipingMethod = New DevExpress.XtraEditors.LookUpEdit()
        Me.IsCancel = New DevExpress.XtraEditors.CheckEdit()
        Me.PO = New DevExpress.XtraEditors.TextEdit()
        Me.ShipingDate = New DevExpress.XtraEditors.DateEdit()
        Me.txtRefOrder = New DevExpress.XtraEditors.TextEdit()
        Me.btnRefreshCurrency = New DevExpress.XtraEditors.SimpleButton()
        Me.Exchange = New DevExpress.XtraEditors.CalcEdit()
        Me.btnCustomerID = New DevExpress.XtraEditors.SimpleButton()
        Me.CreditRuleID = New DevExpress.XtraEditors.LookUpEdit()
        Me.OrderCode = New DevExpress.XtraEditors.TextEdit()
        Me.CustomerID = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CusName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Phone1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Fax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Email1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EMPNAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboCurrency = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnGenID = New DevExpress.XtraEditors.SimpleButton()
        Me.VatPercen = New DevExpress.XtraEditors.CalcEdit()
        Me.VatAmount = New DevExpress.XtraEditors.CalcEdit()
        Me.SendBy = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnCreditRuleID = New DevExpress.XtraEditors.SimpleButton()
        Me.OrderDate = New DevExpress.XtraEditors.DateEdit()
        Me.VatTypeID = New DevExpress.XtraEditors.LookUpEdit()
        Me.QuotationDays = New DevExpress.XtraEditors.CalcEdit()
        Me.btnEmpID = New DevExpress.XtraEditors.SimpleButton()
        Me.TotalAfterDis = New DevExpress.XtraEditors.CalcEdit()
        Me.EmpID = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ExpireDate = New DevExpress.XtraEditors.DateEdit()
        Me.btnVatTypeID = New DevExpress.XtraEditors.SimpleButton()
        Me.DiscountAmount = New DevExpress.XtraEditors.CalcEdit()
        Me.OrderStatus = New DevExpress.XtraEditors.TextEdit()
        Me.Total = New DevExpress.XtraEditors.CalcEdit()
        Me.DiscountPercen = New DevExpress.XtraEditors.CalcEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutbtnGenID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutbtnCustomerID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutCreditRuleID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutCode = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutCustomerID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutbtnCreditRuleID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.SimpleSeparator2 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.LayoutOrderDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutbtnEmpID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutExpireDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutQuotationDays = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutSendBy = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutOrderStatus = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleSeparator4 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlRefOrder = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutShipingDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutPO = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutShipingMethod = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutbtnShipingMethod = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutClaimRemark2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.SimpleSeparator3 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.SimpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.LayoutOrderDate2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlRefOrder2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutQuotationDays2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutShipingDate2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutPO_2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutExpireDate2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutSendBy2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutOrderStatus2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutIsCancel2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutIsCancel = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutCancelRemark = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutPayType = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutPayType2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutCreditBalance2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutCreditBalance = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutPledge1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutPledge4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutPledge3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayouShipingBy = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutbtnShipingBy = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutShipingRuleID2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutShipingRuleID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutTotalTax = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutGrandTotal = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutInvoiceSuplierID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutInvoiceSuplierID2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutInstitute = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem10 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutStockType = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutRefPO = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutStockType2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutRefPO1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutQuotationRemark = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutbtnQuotationRemark = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutNotPass = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutbtnCampaign = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutCampaign = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SplitterItem1 = New DevExpress.XtraLayout.SplitterItem()
        Me.LayoutControlProduct = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutClaimRemark = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem9 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutClaimResult = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutClaimResult2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.PledgeTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcPledge1 = New UB.ucPledge()
        Me.TaxTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.TaxGroup = New DevExpress.XtraEditors.GroupControl()
        Me.GridTaxOrder = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TaxTypeID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TaxTypeIDLookUp = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.TaxTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.TaxRate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.TaxAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCalcEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.TaxOrderID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OtherTax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.TaxSection = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TaxCondition = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TaxCusCardID = New DevExpress.XtraEditors.TextEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TaxCusTaxNo = New DevExpress.XtraEditors.TextEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TaxCusAddress = New DevExpress.XtraEditors.TextEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TaxCusname = New DevExpress.XtraEditors.TextEdit()
        Me.TaxType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.TaxNumber = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TaxGroup1 = New DevExpress.XtraEditors.GroupControl()
        Me.TaxMonthYear = New DevExpress.XtraEditors.DateEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TaxCanNo = New System.Windows.Forms.RadioButton()
        Me.TaxCanYes = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.TaxRemark = New DevExpress.XtraEditors.TextEdit()
        Me.RemarkTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.Remark = New DevExpress.XtraEditors.MemoEdit()
        Me.NoteTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcNote1 = New UB.ucNote()
        Me.AttachmentTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcFileAttach1 = New UB.ucFileAttach()
        Me.AdminTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcAdmin1 = New UB.ucAdmin()
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.CalcEdit1 = New DevExpress.XtraEditors.CalcEdit()
        Me.btnCalc = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtGrandTotal = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtVat = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtDiscount = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtPledge = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtTotal = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtUnits = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.EmptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.object_67cb764d_4f5f_4a35_8c33_e0a331ccd483 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutPO2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem12 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.GeneralTabPage.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.ClaimResult.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClaimRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl2.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.Campaign.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkNotPass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuotationRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkIsEditVat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRefPO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Institute.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceSuplierID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrandTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalTax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipingRuleID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PledgeTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalAfterPledge.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditBalance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CancelRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipingBy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipingMethod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsCancel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipingDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipingDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRefOrder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Exchange.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditRuleID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCurrency.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VatPercen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VatAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SendBy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VatTypeID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuotationDays.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalAfterDis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpireDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpireDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiscountAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Total.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiscountPercen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutbtnGenID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutbtnCustomerID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutCreditRuleID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutCustomerID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutbtnCreditRuleID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutOrderDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutbtnEmpID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutExpireDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutQuotationDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutSendBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutOrderStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlRefOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutShipingDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutShipingMethod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutbtnShipingMethod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutClaimRemark2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutOrderDate2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlRefOrder2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutQuotationDays2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutShipingDate2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutPO_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutExpireDate2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutSendBy2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutOrderStatus2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutIsCancel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutIsCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutCancelRemark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutPayType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutPayType2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutCreditBalance2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutCreditBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutPledge1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutPledge4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutPledge3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayouShipingBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutbtnShipingBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutShipingRuleID2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutShipingRuleID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutTotalTax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutGrandTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutInvoiceSuplierID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutInvoiceSuplierID2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutInstitute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutStockType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutRefPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutStockType2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutRefPO1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutQuotationRemark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutbtnQuotationRemark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutNotPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutbtnCampaign, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutCampaign, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutClaimRemark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutClaimResult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutClaimResult2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PledgeTabPage.SuspendLayout()
        Me.TaxTabPage.SuspendLayout()
        CType(Me.TaxGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TaxGroup.SuspendLayout()
        CType(Me.GridTaxOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxTypeIDLookUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxSection.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxCondition.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxCusCardID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxCusTaxNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxCusAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxCusname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TaxGroup1.SuspendLayout()
        CType(Me.TaxMonthYear.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxMonthYear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RemarkTabPage.SuspendLayout()
        CType(Me.Remark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NoteTabPage.SuspendLayout()
        Me.AttachmentTabPage.SuspendLayout()
        Me.AdminTabPage.SuspendLayout()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.CalcEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.txtGrandTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.txtVat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.txtDiscount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.txtPledge.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.txtUnits.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.object_67cb764d_4f5f_4a35_8c33_e0a331ccd483, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutPO2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormChangedComponent1
        '
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.XtraTabControl1, "")
        Me.XtraTabControl1.HeaderButtons = DevExpress.XtraTab.TabButtons.None
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 37)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.XtraTabControl1, True)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.GeneralTabPage
        Me.XtraTabControl1.ShowHeaderFocus = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl1.Size = New System.Drawing.Size(927, 754)
        Me.XtraTabControl1.TabIndex = 8
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.GeneralTabPage, Me.PledgeTabPage, Me.TaxTabPage, Me.RemarkTabPage, Me.NoteTabPage, Me.AttachmentTabPage, Me.AdminTabPage})
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.XtraTabControl1, "")
        '
        'GeneralTabPage
        '
        Me.GeneralTabPage.AllowTouchScroll = True
        Me.GeneralTabPage.Appearance.PageClient.BackColor = System.Drawing.Color.LightGray
        Me.GeneralTabPage.Appearance.PageClient.Options.UseBackColor = True
        Me.GeneralTabPage.AutoScroll = True
        Me.GeneralTabPage.AutoScrollMinSize = New System.Drawing.Size(0, 5)
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.GeneralTabPage, "")
        Me.GeneralTabPage.Controls.Add(Me.LayoutControl1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.GeneralTabPage, True)
        Me.GeneralTabPage.Name = "GeneralTabPage"
        Me.GeneralTabPage.ScrollBarSmallChange = 50
        Me.GeneralTabPage.Size = New System.Drawing.Size(921, 726)
        Me.GeneralTabPage.Text = "ข้อมูลทั่วไป"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.GeneralTabPage, "")
        '
        'LayoutControl1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.LayoutControl1, "")
        Me.LayoutControl1.Controls.Add(Me.ClaimResult)
        Me.LayoutControl1.Controls.Add(Me.ClaimRemark)
        Me.LayoutControl1.Controls.Add(Me.XtraTabControl2)
        Me.LayoutControl1.Controls.Add(Me.Campaign)
        Me.LayoutControl1.Controls.Add(Me.btnCampaign)
        Me.LayoutControl1.Controls.Add(Me.chkNotPass)
        Me.LayoutControl1.Controls.Add(Me.btnQuotationRemark)
        Me.LayoutControl1.Controls.Add(Me.QuotationRemark)
        Me.LayoutControl1.Controls.Add(Me.chkIsEditVat)
        Me.LayoutControl1.Controls.Add(Me.txtRefPO)
        Me.LayoutControl1.Controls.Add(Me.StockType)
        Me.LayoutControl1.Controls.Add(Me.Institute)
        Me.LayoutControl1.Controls.Add(Me.InvoiceSuplierID)
        Me.LayoutControl1.Controls.Add(Me.GrandTotal)
        Me.LayoutControl1.Controls.Add(Me.TotalTax)
        Me.LayoutControl1.Controls.Add(Me.ShipingRuleID)
        Me.LayoutControl1.Controls.Add(Me.btnShipingRuleID)
        Me.LayoutControl1.Controls.Add(Me.PledgeTotal)
        Me.LayoutControl1.Controls.Add(Me.TotalAfterPledge)
        Me.LayoutControl1.Controls.Add(Me.CreditBalance)
        Me.LayoutControl1.Controls.Add(Me.PayType)
        Me.LayoutControl1.Controls.Add(Me.CancelRemark)
        Me.LayoutControl1.Controls.Add(Me.btnRefOrder)
        Me.LayoutControl1.Controls.Add(Me.ShipingBy)
        Me.LayoutControl1.Controls.Add(Me.btnShipingBy)
        Me.LayoutControl1.Controls.Add(Me.btnShipingMethod)
        Me.LayoutControl1.Controls.Add(Me.ShipingMethod)
        Me.LayoutControl1.Controls.Add(Me.IsCancel)
        Me.LayoutControl1.Controls.Add(Me.PO)
        Me.LayoutControl1.Controls.Add(Me.ShipingDate)
        Me.LayoutControl1.Controls.Add(Me.txtRefOrder)
        Me.LayoutControl1.Controls.Add(Me.btnRefreshCurrency)
        Me.LayoutControl1.Controls.Add(Me.Exchange)
        Me.LayoutControl1.Controls.Add(Me.btnCustomerID)
        Me.LayoutControl1.Controls.Add(Me.CreditRuleID)
        Me.LayoutControl1.Controls.Add(Me.OrderCode)
        Me.LayoutControl1.Controls.Add(Me.CustomerID)
        Me.LayoutControl1.Controls.Add(Me.cboCurrency)
        Me.LayoutControl1.Controls.Add(Me.btnGenID)
        Me.LayoutControl1.Controls.Add(Me.VatPercen)
        Me.LayoutControl1.Controls.Add(Me.VatAmount)
        Me.LayoutControl1.Controls.Add(Me.SendBy)
        Me.LayoutControl1.Controls.Add(Me.btnCreditRuleID)
        Me.LayoutControl1.Controls.Add(Me.OrderDate)
        Me.LayoutControl1.Controls.Add(Me.VatTypeID)
        Me.LayoutControl1.Controls.Add(Me.QuotationDays)
        Me.LayoutControl1.Controls.Add(Me.btnEmpID)
        Me.LayoutControl1.Controls.Add(Me.TotalAfterDis)
        Me.LayoutControl1.Controls.Add(Me.EmpID)
        Me.LayoutControl1.Controls.Add(Me.ExpireDate)
        Me.LayoutControl1.Controls.Add(Me.btnVatTypeID)
        Me.LayoutControl1.Controls.Add(Me.DiscountAmount)
        Me.LayoutControl1.Controls.Add(Me.OrderStatus)
        Me.LayoutControl1.Controls.Add(Me.Total)
        Me.LayoutControl1.Controls.Add(Me.DiscountPercen)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.LayoutControl1, True)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(598, 404, 280, 347)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(921, 726)
        Me.LayoutControl1.TabIndex = 9
        Me.LayoutControl1.Text = "LayoutControl1"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.LayoutControl1, "")
        '
        'ClaimResult
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.ClaimResult, "")
        Me.ClaimResult.EditValue = "Y"
        Me.ClaimResult.EnterMoveNextControl = True
        Me.ClaimResult.Location = New System.Drawing.Point(117, 298)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.ClaimResult, True)
        Me.ClaimResult.Name = "ClaimResult"
        Me.ClaimResult.Properties.Columns = 3
        Me.ClaimResult.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("Y", "ได้"), New DevExpress.XtraEditors.Controls.RadioGroupItem("N", "ไม่ได้")})
        Me.ClaimResult.Size = New System.Drawing.Size(308, 25)
        Me.ClaimResult.StyleController = Me.LayoutControl1
        Me.ClaimResult.TabIndex = 13
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.ClaimResult, "")
        '
        'ClaimRemark
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.ClaimRemark, "TextChanged")
        Me.ClaimRemark.EnterMoveNextControl = True
        Me.ClaimRemark.Location = New System.Drawing.Point(117, 327)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.ClaimRemark, True)
        Me.ClaimRemark.Name = "ClaimRemark"
        Me.ClaimRemark.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ClaimRemark.Properties.Appearance.Options.UseFont = True
        Me.ClaimRemark.Properties.MaxLength = 100
        Me.ClaimRemark.Size = New System.Drawing.Size(308, 34)
        Me.ClaimRemark.StyleController = Me.LayoutControl1
        Me.ClaimRemark.TabIndex = 320
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.ClaimRemark, "Text")
        '
        'XtraTabControl2
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.XtraTabControl2, "")
        Me.XtraTabControl2.Location = New System.Drawing.Point(12, 379)
        Me.XtraTabControl2.MinimumSize = New System.Drawing.Size(0, 50)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.XtraTabControl2, True)
        Me.XtraTabControl2.Name = "XtraTabControl2"
        Me.XtraTabControl2.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl2.Size = New System.Drawing.Size(891, 154)
        Me.XtraTabControl2.TabIndex = 319
        Me.XtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.XtraTabControl2, "")
        '
        'XtraTabPage1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.XtraTabPage1, "")
        Me.XtraTabPage1.Controls.Add(Me.UcProductLists1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.XtraTabPage1, True)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(885, 126)
        Me.XtraTabPage1.Text = "สินค้า"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.XtraTabPage1, "")
        '
        'UcProductLists1
        '
        Me.UcProductLists1.AutoScroll = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.UcProductLists1, "")
        Me.UcProductLists1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcProductLists1.Location = New System.Drawing.Point(0, 0)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.UcProductLists1, True)
        Me.UcProductLists1.Name = "UcProductLists1"
        Me.UcProductLists1.Size = New System.Drawing.Size(885, 126)
        Me.UcProductLists1.TabIndex = 21
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcProductLists1, "")
        '
        'XtraTabPage2
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.XtraTabPage2, "")
        Me.XtraTabPage2.Controls.Add(Me.UcNote2)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.XtraTabPage2, True)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(885, 126)
        Me.XtraTabPage2.Text = "หมายเหตุ"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.XtraTabPage2, "")
        '
        'UcNote2
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.UcNote2, "")
        Me.UcNote2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcNote2.Location = New System.Drawing.Point(0, 0)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.UcNote2, True)
        Me.UcNote2.Name = "UcNote2"
        Me.UcNote2.Size = New System.Drawing.Size(885, 126)
        Me.UcNote2.TabIndex = 1
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcNote2, "")
        '
        'Campaign
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Campaign, "TextChanged")
        Me.Campaign.EnterMoveNextControl = True
        Me.Campaign.Location = New System.Drawing.Point(117, 274)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Campaign, True)
        Me.Campaign.Name = "Campaign"
        Me.Campaign.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Campaign.Properties.Appearance.Options.UseFont = True
        Me.Campaign.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Campaign.Properties.NullText = ""
        Me.Campaign.Properties.PopupFindMode = DevExpress.XtraEditors.FindMode.Always
        Me.Campaign.Properties.View = Me.GridView2
        Me.Campaign.Size = New System.Drawing.Size(308, 20)
        Me.Campaign.StyleController = Me.LayoutControl1
        Me.Campaign.TabIndex = 9
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Campaign, "Text")
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.CampaignID, Me.Subject, Me.StartDate, Me.GridColumn9, Me.GridColumn10})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowViewCaption = True
        '
        'CampaignID
        '
        Me.CampaignID.Caption = "รหัส"
        Me.CampaignID.FieldName = "CampaignID"
        Me.CampaignID.Name = "CampaignID"
        '
        'Subject
        '
        Me.Subject.Caption = "ชื่อโปรโมชั่น"
        Me.Subject.FieldName = "Subject"
        Me.Subject.MaxWidth = 200
        Me.Subject.MinWidth = 150
        Me.Subject.Name = "Subject"
        Me.Subject.Visible = True
        Me.Subject.VisibleIndex = 0
        Me.Subject.Width = 150
        '
        'StartDate
        '
        Me.StartDate.Caption = "วันที่เริ่มต้น"
        Me.StartDate.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.StartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.StartDate.FieldName = "StartDate"
        Me.StartDate.MaxWidth = 80
        Me.StartDate.MinWidth = 50
        Me.StartDate.Name = "StartDate"
        Me.StartDate.Visible = True
        Me.StartDate.VisibleIndex = 1
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "วันที่สิ้นสุด"
        Me.GridColumn9.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.GridColumn9.FieldName = "ExpireDate"
        Me.GridColumn9.MaxWidth = 80
        Me.GridColumn9.MinWidth = 50
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 2
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "สถานะ"
        Me.GridColumn10.FieldName = "CampaignStatus"
        Me.GridColumn10.MaxWidth = 100
        Me.GridColumn10.MinWidth = 85
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 3
        Me.GridColumn10.Width = 85
        '
        'btnCampaign
        '
        Me.btnCampaign.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCampaign.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnCampaign, "")
        Me.btnCampaign.Image = CType(resources.GetObject("btnCampaign.Image"), System.Drawing.Image)
        Me.btnCampaign.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCampaign.Location = New System.Drawing.Point(431, 274)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnCampaign, True)
        Me.btnCampaign.Name = "btnCampaign"
        Me.btnCampaign.Size = New System.Drawing.Size(26, 22)
        Me.btnCampaign.StyleController = Me.LayoutControl1
        Me.btnCampaign.TabIndex = 318
        Me.btnCampaign.TabStop = False
        Me.btnCampaign.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnCampaign, "")
        '
        'chkNotPass
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.chkNotPass, "CheckedChanged")
        Me.chkNotPass.EnterMoveNextControl = True
        Me.chkNotPass.Location = New System.Drawing.Point(12, 179)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.chkNotPass, True)
        Me.chkNotPass.Name = "chkNotPass"
        Me.chkNotPass.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNotPass.Properties.Appearance.Options.UseFont = True
        Me.chkNotPass.Properties.Caption = "ไม่ผ่าน"
        Me.chkNotPass.Size = New System.Drawing.Size(104, 19)
        Me.chkNotPass.StyleController = Me.LayoutControl1
        Me.chkNotPass.TabIndex = 13
        Me.chkNotPass.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.chkNotPass, "Checked")
        '
        'btnQuotationRemark
        '
        Me.btnQuotationRemark.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnQuotationRemark.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnQuotationRemark, "")
        Me.btnQuotationRemark.Image = CType(resources.GetObject("btnQuotationRemark.Image"), System.Drawing.Image)
        Me.btnQuotationRemark.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnQuotationRemark.Location = New System.Drawing.Point(431, 248)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnQuotationRemark, True)
        Me.btnQuotationRemark.Name = "btnQuotationRemark"
        Me.btnQuotationRemark.Size = New System.Drawing.Size(26, 22)
        Me.btnQuotationRemark.StyleController = Me.LayoutControl1
        Me.btnQuotationRemark.TabIndex = 305
        Me.btnQuotationRemark.TabStop = False
        Me.btnQuotationRemark.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnQuotationRemark, "")
        '
        'QuotationRemark
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.QuotationRemark, "TextChanged")
        Me.QuotationRemark.EnterMoveNextControl = True
        Me.QuotationRemark.Location = New System.Drawing.Point(117, 250)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.QuotationRemark, True)
        Me.QuotationRemark.Name = "QuotationRemark"
        Me.QuotationRemark.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.QuotationRemark.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuotationRemark.Properties.Appearance.Options.UseFont = True
        Me.QuotationRemark.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.QuotationRemark.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.QuotationRemark.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 50, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeThai", 50, "ชื่อข้อความ"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeEng", "", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Center), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Remark", 70, "รายละเอียด")})
        Me.QuotationRemark.Properties.DropDownRows = 10
        Me.QuotationRemark.Properties.NullText = ""
        Me.QuotationRemark.Properties.NullValuePromptShowForEmptyValue = True
        Me.QuotationRemark.Properties.PopupWidth = 300
        Me.QuotationRemark.Size = New System.Drawing.Size(308, 20)
        Me.QuotationRemark.StyleController = Me.LayoutControl1
        Me.QuotationRemark.TabIndex = 20
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.QuotationRemark, "Text")
        '
        'chkIsEditVat
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.chkIsEditVat, "CheckedChanged")
        Me.chkIsEditVat.EnterMoveNextControl = True
        Me.chkIsEditVat.Location = New System.Drawing.Point(592, 612)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.chkIsEditVat, True)
        Me.chkIsEditVat.Name = "chkIsEditVat"
        Me.chkIsEditVat.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIsEditVat.Properties.Appearance.Options.UseFont = True
        Me.chkIsEditVat.Properties.Caption = ""
        Me.chkIsEditVat.Size = New System.Drawing.Size(19, 19)
        Me.chkIsEditVat.StyleController = Me.LayoutControl1
        Me.chkIsEditVat.TabIndex = 12
        Me.chkIsEditVat.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.chkIsEditVat, "Checked")
        '
        'txtRefPO
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtRefPO, "TextChanged")
        Me.txtRefPO.EnterMoveNextControl = True
        Me.txtRefPO.Location = New System.Drawing.Point(568, 257)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.txtRefPO, True)
        Me.txtRefPO.Name = "txtRefPO"
        Me.txtRefPO.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.txtRefPO.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRefPO.Properties.Appearance.Options.UseBackColor = True
        Me.txtRefPO.Properties.Appearance.Options.UseFont = True
        Me.txtRefPO.Properties.MaxLength = 50
        Me.txtRefPO.Properties.ReadOnly = True
        Me.txtRefPO.Properties.ValidateOnEnterKey = True
        Me.txtRefPO.Size = New System.Drawing.Size(303, 20)
        Me.txtRefPO.StyleController = Me.LayoutControl1
        Me.txtRefPO.TabIndex = 17
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtRefPO, "Text")
        '
        'StockType
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.StockType, "")
        Me.StockType.EditValue = "N"
        Me.StockType.EnterMoveNextControl = True
        Me.StockType.Location = New System.Drawing.Point(568, 305)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.StockType, True)
        Me.StockType.Name = "StockType"
        Me.StockType.Properties.Columns = 3
        Me.StockType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("N", "ไม่ตัดสต็อก"), New DevExpress.XtraEditors.Controls.RadioGroupItem("O", "ตัดสต็อก"), New DevExpress.XtraEditors.Controls.RadioGroupItem("I", "คืนสต็อก")})
        Me.StockType.Size = New System.Drawing.Size(303, 25)
        Me.StockType.StyleController = Me.LayoutControl1
        Me.StockType.TabIndex = 10
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.StockType, "")
        '
        'Institute
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Institute, "TextChanged")
        Me.Institute.EditValue = ""
        Me.Institute.EnterMoveNextControl = True
        Me.Institute.Location = New System.Drawing.Point(117, 60)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Institute, True)
        Me.Institute.Name = "Institute"
        Me.Institute.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Institute.Properties.Appearance.Options.UseFont = True
        Me.Institute.Properties.MaxLength = 100
        Me.Institute.Properties.ValidateOnEnterKey = True
        Me.Institute.Size = New System.Drawing.Size(308, 20)
        Me.Institute.StyleController = Me.LayoutControl1
        Me.Institute.TabIndex = 10
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Institute, "Text")
        '
        'InvoiceSuplierID
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.InvoiceSuplierID, "TextChanged")
        Me.InvoiceSuplierID.EnterMoveNextControl = True
        Me.InvoiceSuplierID.Location = New System.Drawing.Point(568, 60)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.InvoiceSuplierID, True)
        Me.InvoiceSuplierID.Name = "InvoiceSuplierID"
        Me.InvoiceSuplierID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.InvoiceSuplierID.Properties.Appearance.Options.UseFont = True
        Me.InvoiceSuplierID.Properties.MaxLength = 50
        Me.InvoiceSuplierID.Properties.ValidateOnEnterKey = True
        Me.InvoiceSuplierID.Size = New System.Drawing.Size(303, 20)
        Me.InvoiceSuplierID.StyleController = Me.LayoutControl1
        Me.InvoiceSuplierID.TabIndex = 15
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.InvoiceSuplierID, "Text")
        '
        'GrandTotal
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.GrandTotal, "TextChanged")
        Me.GrandTotal.EnterMoveNextControl = True
        Me.GrandTotal.Location = New System.Drawing.Point(697, 660)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.GrandTotal, True)
        Me.GrandTotal.Name = "GrandTotal"
        Me.GrandTotal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GrandTotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrandTotal.Properties.Appearance.Options.UseBackColor = True
        Me.GrandTotal.Properties.Appearance.Options.UseFont = True
        Me.GrandTotal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GrandTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GrandTotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GrandTotal.Properties.Mask.EditMask = "n2"
        Me.GrandTotal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.GrandTotal.Properties.Precision = 2
        Me.GrandTotal.Properties.ReadOnly = True
        Me.GrandTotal.Size = New System.Drawing.Size(206, 20)
        Me.GrandTotal.StyleController = Me.LayoutControl1
        Me.GrandTotal.TabIndex = 281
        Me.GrandTotal.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.GrandTotal, "Text")
        '
        'TotalTax
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.TotalTax, "TextChanged")
        Me.TotalTax.EnterMoveNextControl = True
        Me.TotalTax.Location = New System.Drawing.Point(697, 636)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.TotalTax, True)
        Me.TotalTax.Name = "TotalTax"
        Me.TotalTax.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TotalTax.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalTax.Properties.Appearance.Options.UseBackColor = True
        Me.TotalTax.Properties.Appearance.Options.UseFont = True
        Me.TotalTax.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TotalTax.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TotalTax.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TotalTax.Properties.Mask.EditMask = "n2"
        Me.TotalTax.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TotalTax.Properties.Precision = 2
        Me.TotalTax.Properties.ReadOnly = True
        Me.TotalTax.Size = New System.Drawing.Size(206, 20)
        Me.TotalTax.StyleController = Me.LayoutControl1
        Me.TotalTax.TabIndex = 309
        Me.TotalTax.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.TotalTax, "Text")
        '
        'ShipingRuleID
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.ShipingRuleID, "TextChanged")
        Me.ShipingRuleID.EnterMoveNextControl = True
        Me.ShipingRuleID.Location = New System.Drawing.Point(117, 226)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.ShipingRuleID, True)
        Me.ShipingRuleID.Name = "ShipingRuleID"
        Me.ShipingRuleID.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.ShipingRuleID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShipingRuleID.Properties.Appearance.Options.UseFont = True
        Me.ShipingRuleID.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.ShipingRuleID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ShipingRuleID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 50, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeThai", 50, "ชื่อข้อความ"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeEng", "", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Center), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Remark", 70, "รายละเอียด")})
        Me.ShipingRuleID.Properties.DropDownRows = 10
        Me.ShipingRuleID.Properties.NullText = ""
        Me.ShipingRuleID.Properties.NullValuePromptShowForEmptyValue = True
        Me.ShipingRuleID.Properties.PopupWidth = 300
        Me.ShipingRuleID.Size = New System.Drawing.Size(308, 20)
        Me.ShipingRuleID.StyleController = Me.LayoutControl1
        Me.ShipingRuleID.TabIndex = 19
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.ShipingRuleID, "Text")
        '
        'btnShipingRuleID
        '
        Me.btnShipingRuleID.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnShipingRuleID.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnShipingRuleID, "")
        Me.btnShipingRuleID.Image = CType(resources.GetObject("btnShipingRuleID.Image"), System.Drawing.Image)
        Me.btnShipingRuleID.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnShipingRuleID.Location = New System.Drawing.Point(431, 224)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnShipingRuleID, True)
        Me.btnShipingRuleID.Name = "btnShipingRuleID"
        Me.btnShipingRuleID.Size = New System.Drawing.Size(26, 20)
        Me.btnShipingRuleID.StyleController = Me.LayoutControl1
        Me.btnShipingRuleID.TabIndex = 304
        Me.btnShipingRuleID.TabStop = False
        Me.btnShipingRuleID.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnShipingRuleID, "")
        '
        'PledgeTotal
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.PledgeTotal, "TextChanged")
        Me.PledgeTotal.EnterMoveNextControl = True
        Me.PledgeTotal.Location = New System.Drawing.Point(424, 562)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.PledgeTotal, True)
        Me.PledgeTotal.Name = "PledgeTotal"
        Me.PledgeTotal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PledgeTotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PledgeTotal.Properties.Appearance.Options.UseBackColor = True
        Me.PledgeTotal.Properties.Appearance.Options.UseFont = True
        Me.PledgeTotal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PledgeTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PledgeTotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PledgeTotal.Properties.Mask.EditMask = "n2"
        Me.PledgeTotal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.PledgeTotal.Properties.Precision = 2
        Me.PledgeTotal.Properties.ReadOnly = True
        Me.PledgeTotal.Size = New System.Drawing.Size(164, 20)
        Me.PledgeTotal.StyleController = Me.LayoutControl1
        Me.PledgeTotal.TabIndex = 280
        Me.PledgeTotal.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.PledgeTotal, "Text")
        '
        'TotalAfterPledge
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.TotalAfterPledge, "TextChanged")
        Me.TotalAfterPledge.EnterMoveNextControl = True
        Me.TotalAfterPledge.Location = New System.Drawing.Point(697, 562)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.TotalAfterPledge, True)
        Me.TotalAfterPledge.Name = "TotalAfterPledge"
        Me.TotalAfterPledge.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TotalAfterPledge.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalAfterPledge.Properties.Appearance.Options.UseBackColor = True
        Me.TotalAfterPledge.Properties.Appearance.Options.UseFont = True
        Me.TotalAfterPledge.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TotalAfterPledge.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TotalAfterPledge.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TotalAfterPledge.Properties.Mask.EditMask = "n2"
        Me.TotalAfterPledge.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TotalAfterPledge.Properties.Precision = 2
        Me.TotalAfterPledge.Properties.ReadOnly = True
        Me.TotalAfterPledge.Size = New System.Drawing.Size(206, 20)
        Me.TotalAfterPledge.StyleController = Me.LayoutControl1
        Me.TotalAfterPledge.TabIndex = 279
        Me.TotalAfterPledge.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.TotalAfterPledge, "Text")
        '
        'CreditBalance
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.CreditBalance, "TextChanged")
        Me.CreditBalance.EnterMoveNextControl = True
        Me.CreditBalance.Location = New System.Drawing.Point(568, 36)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.CreditBalance, True)
        Me.CreditBalance.Name = "CreditBalance"
        Me.CreditBalance.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.CreditBalance.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreditBalance.Properties.Appearance.Options.UseBackColor = True
        Me.CreditBalance.Properties.Appearance.Options.UseFont = True
        Me.CreditBalance.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CreditBalance.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CreditBalance.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CreditBalance.Properties.Mask.EditMask = "n0"
        Me.CreditBalance.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.CreditBalance.Properties.Precision = 0
        Me.CreditBalance.Properties.ReadOnly = True
        Me.CreditBalance.Size = New System.Drawing.Size(303, 20)
        Me.CreditBalance.StyleController = Me.LayoutControl1
        Me.CreditBalance.TabIndex = 10
        Me.CreditBalance.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.CreditBalance, "Text")
        '
        'PayType
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.PayType, "")
        Me.PayType.EditValue = "CREDIT"
        Me.PayType.EnterMoveNextControl = True
        Me.PayType.Location = New System.Drawing.Point(568, 132)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.PayType, True)
        Me.PayType.Name = "PayType"
        Me.PayType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("CASH", "เงินสด"), New DevExpress.XtraEditors.Controls.RadioGroupItem("CREDIT", "เงินเชื่อ")})
        Me.PayType.Size = New System.Drawing.Size(303, 25)
        Me.PayType.StyleController = Me.LayoutControl1
        Me.PayType.TabIndex = 8
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.PayType, "")
        '
        'CancelRemark
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.CancelRemark, "TextChanged")
        Me.CancelRemark.EnterMoveNextControl = True
        Me.CancelRemark.Location = New System.Drawing.Point(120, 156)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.CancelRemark, True)
        Me.CancelRemark.Name = "CancelRemark"
        Me.CancelRemark.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CancelRemark.Properties.Appearance.Options.UseFont = True
        Me.CancelRemark.Properties.MaxLength = 100
        Me.CancelRemark.Size = New System.Drawing.Size(305, 42)
        Me.CancelRemark.StyleController = Me.LayoutControl1
        Me.CancelRemark.TabIndex = 12
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.CancelRemark, "Text")
        '
        'btnRefOrder
        '
        Me.btnRefOrder.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRefOrder.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnRefOrder, "")
        Me.btnRefOrder.Image = CType(resources.GetObject("btnRefOrder.Image"), System.Drawing.Image)
        Me.btnRefOrder.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefOrder.Location = New System.Drawing.Point(877, 233)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnRefOrder, True)
        Me.btnRefOrder.Name = "btnRefOrder"
        Me.btnRefOrder.Size = New System.Drawing.Size(26, 22)
        Me.btnRefOrder.StyleController = Me.LayoutControl1
        Me.btnRefOrder.TabIndex = 16
        Me.btnRefOrder.TabStop = False
        Me.btnRefOrder.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnRefOrder, "")
        '
        'ShipingBy
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.ShipingBy, "TextChanged")
        Me.ShipingBy.EnterMoveNextControl = True
        Me.ShipingBy.Location = New System.Drawing.Point(568, 281)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.ShipingBy, True)
        Me.ShipingBy.Name = "ShipingBy"
        Me.ShipingBy.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.ShipingBy.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShipingBy.Properties.Appearance.Options.UseFont = True
        Me.ShipingBy.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.ShipingBy.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ShipingBy.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 50, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeThai", 50, "ชื่อข้อความ"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeEng", "", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Center), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Remark", 70, "รายละเอียด")})
        Me.ShipingBy.Properties.DropDownRows = 10
        Me.ShipingBy.Properties.NullText = ""
        Me.ShipingBy.Properties.NullValuePromptShowForEmptyValue = True
        Me.ShipingBy.Properties.PopupWidth = 300
        Me.ShipingBy.Size = New System.Drawing.Size(303, 20)
        Me.ShipingBy.StyleController = Me.LayoutControl1
        Me.ShipingBy.TabIndex = 18
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.ShipingBy, "Text")
        '
        'btnShipingBy
        '
        Me.btnShipingBy.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnShipingBy.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnShipingBy, "")
        Me.btnShipingBy.Image = CType(resources.GetObject("btnShipingBy.Image"), System.Drawing.Image)
        Me.btnShipingBy.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnShipingBy.Location = New System.Drawing.Point(877, 283)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnShipingBy, True)
        Me.btnShipingBy.Name = "btnShipingBy"
        Me.btnShipingBy.Size = New System.Drawing.Size(26, 22)
        Me.btnShipingBy.StyleController = Me.LayoutControl1
        Me.btnShipingBy.TabIndex = 304
        Me.btnShipingBy.TabStop = False
        Me.btnShipingBy.ToolTip = "Refresh1"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnShipingBy, "")
        '
        'btnShipingMethod
        '
        Me.btnShipingMethod.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnShipingMethod.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnShipingMethod, "")
        Me.btnShipingMethod.Image = CType(resources.GetObject("btnShipingMethod.Image"), System.Drawing.Image)
        Me.btnShipingMethod.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnShipingMethod.Location = New System.Drawing.Point(431, 200)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnShipingMethod, True)
        Me.btnShipingMethod.Name = "btnShipingMethod"
        Me.btnShipingMethod.Size = New System.Drawing.Size(26, 20)
        Me.btnShipingMethod.StyleController = Me.LayoutControl1
        Me.btnShipingMethod.TabIndex = 303
        Me.btnShipingMethod.TabStop = False
        Me.btnShipingMethod.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnShipingMethod, "")
        '
        'ShipingMethod
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.ShipingMethod, "TextChanged")
        Me.ShipingMethod.EnterMoveNextControl = True
        Me.ShipingMethod.Location = New System.Drawing.Point(117, 202)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.ShipingMethod, True)
        Me.ShipingMethod.Name = "ShipingMethod"
        Me.ShipingMethod.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.ShipingMethod.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShipingMethod.Properties.Appearance.Options.UseFont = True
        Me.ShipingMethod.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.ShipingMethod.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ShipingMethod.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 50, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeThai", 50, "ชื่อข้อความ"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeEng", "", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Center), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Remark", 70, "รายละเอียด")})
        Me.ShipingMethod.Properties.DropDownRows = 10
        Me.ShipingMethod.Properties.NullText = ""
        Me.ShipingMethod.Properties.NullValuePromptShowForEmptyValue = True
        Me.ShipingMethod.Properties.PopupWidth = 300
        Me.ShipingMethod.Size = New System.Drawing.Size(308, 20)
        Me.ShipingMethod.StyleController = Me.LayoutControl1
        Me.ShipingMethod.TabIndex = 17
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.ShipingMethod, "Text")
        '
        'IsCancel
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.IsCancel, "CheckedChanged")
        Me.IsCancel.EnterMoveNextControl = True
        Me.IsCancel.Location = New System.Drawing.Point(12, 156)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.IsCancel, True)
        Me.IsCancel.Name = "IsCancel"
        Me.IsCancel.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsCancel.Properties.Appearance.Options.UseFont = True
        Me.IsCancel.Properties.Caption = "ยกเลิก"
        Me.IsCancel.Size = New System.Drawing.Size(104, 19)
        Me.IsCancel.StyleController = Me.LayoutControl1
        Me.IsCancel.TabIndex = 11
        Me.IsCancel.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.IsCancel, "Checked")
        '
        'PO
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.PO, "TextChanged")
        Me.PO.EnterMoveNextControl = True
        Me.PO.Location = New System.Drawing.Point(568, 209)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.PO, True)
        Me.PO.Name = "PO"
        Me.PO.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PO.Properties.Appearance.Options.UseFont = True
        Me.PO.Properties.MaxLength = 50
        Me.PO.Properties.ValidateOnEnterKey = True
        Me.PO.Size = New System.Drawing.Size(303, 20)
        Me.PO.StyleController = Me.LayoutControl1
        Me.PO.TabIndex = 14
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.PO, "Text")
        '
        'ShipingDate
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.ShipingDate, "TextChanged")
        Me.ShipingDate.EditValue = New Date(2012, 4, 20, 0, 0, 0, 0)
        Me.ShipingDate.EnterMoveNextControl = True
        Me.ShipingDate.Location = New System.Drawing.Point(568, 108)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.ShipingDate, True)
        Me.ShipingDate.Name = "ShipingDate"
        Me.ShipingDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.ShipingDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ShipingDate.Properties.Appearance.Options.UseFont = True
        Me.ShipingDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ShipingDate.Properties.DisplayFormat.FormatString = "D"
        Me.ShipingDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ShipingDate.Properties.EditFormat.FormatString = "D"
        Me.ShipingDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ShipingDate.Properties.Mask.EditMask = "D"
        Me.ShipingDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ShipingDate.Size = New System.Drawing.Size(303, 20)
        Me.ShipingDate.StyleController = Me.LayoutControl1
        Me.ShipingDate.TabIndex = 7
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.ShipingDate, "Text")
        '
        'txtRefOrder
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtRefOrder, "TextChanged")
        Me.txtRefOrder.EnterMoveNextControl = True
        Me.txtRefOrder.Location = New System.Drawing.Point(568, 233)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.txtRefOrder, True)
        Me.txtRefOrder.Name = "txtRefOrder"
        Me.txtRefOrder.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtRefOrder.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRefOrder.Properties.Appearance.Options.UseBackColor = True
        Me.txtRefOrder.Properties.Appearance.Options.UseFont = True
        Me.txtRefOrder.Properties.MaxLength = 50
        Me.txtRefOrder.Properties.ValidateOnEnterKey = True
        Me.txtRefOrder.Size = New System.Drawing.Size(303, 20)
        Me.txtRefOrder.StyleController = Me.LayoutControl1
        Me.txtRefOrder.TabIndex = 16
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtRefOrder, "Text")
        '
        'btnRefreshCurrency
        '
        Me.btnRefreshCurrency.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRefreshCurrency.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnRefreshCurrency, "")
        Me.btnRefreshCurrency.Image = CType(resources.GetObject("btnRefreshCurrency.Image"), System.Drawing.Image)
        Me.btnRefreshCurrency.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefreshCurrency.Location = New System.Drawing.Point(288, 660)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnRefreshCurrency, True)
        Me.btnRefreshCurrency.Name = "btnRefreshCurrency"
        Me.btnRefreshCurrency.Size = New System.Drawing.Size(26, 22)
        Me.btnRefreshCurrency.StyleController = Me.LayoutControl1
        Me.btnRefreshCurrency.TabIndex = 315
        Me.btnRefreshCurrency.TabStop = False
        Me.btnRefreshCurrency.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnRefreshCurrency, "")
        '
        'Exchange
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Exchange, "TextChanged")
        Me.Exchange.EnterMoveNextControl = True
        Me.Exchange.Location = New System.Drawing.Point(423, 660)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Exchange, True)
        Me.Exchange.Name = "Exchange"
        Me.Exchange.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exchange.Properties.Appearance.Options.UseFont = True
        Me.Exchange.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Exchange.Properties.DisplayFormat.FormatString = "n2"
        Me.Exchange.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Exchange.Properties.EditFormat.FormatString = "n2"
        Me.Exchange.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Exchange.Properties.Mask.EditMask = "n2"
        Me.Exchange.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Exchange.Properties.Precision = 2
        Me.Exchange.Size = New System.Drawing.Size(165, 20)
        Me.Exchange.StyleController = Me.LayoutControl1
        Me.Exchange.TabIndex = 316
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Exchange, "Text")
        '
        'btnCustomerID
        '
        Me.btnCustomerID.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCustomerID.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnCustomerID, "")
        Me.btnCustomerID.Image = CType(resources.GetObject("btnCustomerID.Image"), System.Drawing.Image)
        Me.btnCustomerID.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCustomerID.Location = New System.Drawing.Point(431, 38)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnCustomerID, True)
        Me.btnCustomerID.Name = "btnCustomerID"
        Me.btnCustomerID.Size = New System.Drawing.Size(26, 20)
        Me.btnCustomerID.StyleController = Me.LayoutControl1
        Me.btnCustomerID.TabIndex = 217
        Me.btnCustomerID.TabStop = False
        Me.btnCustomerID.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnCustomerID, "")
        '
        'CreditRuleID
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.CreditRuleID, "TextChanged")
        Me.CreditRuleID.EnterMoveNextControl = True
        Me.CreditRuleID.Location = New System.Drawing.Point(117, 84)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.CreditRuleID, True)
        Me.CreditRuleID.Name = "CreditRuleID"
        Me.CreditRuleID.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.CreditRuleID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreditRuleID.Properties.Appearance.Options.UseFont = True
        Me.CreditRuleID.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.CreditRuleID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CreditRuleID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 50, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CreditRoleCode", 30, "รหัสเครดิต"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NameThai", "ชื่อเครดิต", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Center), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CreditDay", "จำนวนวัน", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Far)})
        Me.CreditRuleID.Properties.DropDownRows = 10
        Me.CreditRuleID.Properties.ImmediatePopup = True
        Me.CreditRuleID.Properties.NullText = ""
        Me.CreditRuleID.Properties.NullValuePromptShowForEmptyValue = True
        Me.CreditRuleID.Properties.PopupWidth = 300
        Me.CreditRuleID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CreditRuleID.Properties.ThrowExceptionOnInvalidLookUpEditValueType = True
        Me.CreditRuleID.Properties.UseCtrlScroll = True
        Me.CreditRuleID.Size = New System.Drawing.Size(308, 20)
        Me.CreditRuleID.StyleController = Me.LayoutControl1
        Me.CreditRuleID.TabIndex = 4
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.CreditRuleID, "Text")
        '
        'OrderCode
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.OrderCode, "TextChanged")
        Me.OrderCode.EnterMoveNextControl = True
        Me.OrderCode.Location = New System.Drawing.Point(117, 12)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.OrderCode, True)
        Me.OrderCode.Name = "OrderCode"
        Me.OrderCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.OrderCode.Properties.Appearance.Options.UseFont = True
        Me.OrderCode.Properties.MaxLength = 50
        Me.OrderCode.Properties.ValidateOnEnterKey = True
        Me.OrderCode.Size = New System.Drawing.Size(308, 20)
        Me.OrderCode.StyleController = Me.LayoutControl1
        Me.OrderCode.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.OrderCode, "Text")
        '
        'CustomerID
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.CustomerID, "TextChanged")
        Me.CustomerID.EnterMoveNextControl = True
        Me.CustomerID.Location = New System.Drawing.Point(117, 36)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.CustomerID, True)
        Me.CustomerID.Name = "CustomerID"
        Me.CustomerID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerID.Properties.Appearance.Options.UseFont = True
        Me.CustomerID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CustomerID.Properties.NullText = ""
        Me.CustomerID.Properties.PopupFindMode = DevExpress.XtraEditors.FindMode.Always
        Me.CustomerID.Properties.View = Me.SearchLookUpEdit1View
        Me.CustomerID.Size = New System.Drawing.Size(308, 20)
        Me.CustomerID.StyleController = Me.LayoutControl1
        Me.CustomerID.TabIndex = 1
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.CustomerID, "Text")
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.Code, Me.CusName, Me.Type, Me.Phone1, Me.Fax, Me.Email1, Me.EMPNAME})
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ColumnAutoWidth = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        Me.SearchLookUpEdit1View.OptionsView.ShowViewCaption = True
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "รหัส"
        Me.GridColumn4.FieldName = " ID"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'Code
        '
        Me.Code.Caption = "รหัส"
        Me.Code.FieldName = "Code"
        Me.Code.MaxWidth = 100
        Me.Code.MinWidth = 75
        Me.Code.Name = "Code"
        Me.Code.Visible = True
        Me.Code.VisibleIndex = 0
        '
        'CusName
        '
        Me.CusName.Caption = "ชื่อ - นามสกุล"
        Me.CusName.FieldName = "CusName"
        Me.CusName.MaxWidth = 200
        Me.CusName.MinWidth = 150
        Me.CusName.Name = "CusName"
        Me.CusName.Visible = True
        Me.CusName.VisibleIndex = 1
        Me.CusName.Width = 150
        '
        'Type
        '
        Me.Type.Caption = "ประเภทลูกค้า"
        Me.Type.FieldName = "Type"
        Me.Type.MaxWidth = 75
        Me.Type.MinWidth = 50
        Me.Type.Name = "Type"
        Me.Type.Visible = True
        Me.Type.VisibleIndex = 2
        '
        'Phone1
        '
        Me.Phone1.Caption = "เบอร์โทร"
        Me.Phone1.FieldName = "Phone1"
        Me.Phone1.MaxWidth = 85
        Me.Phone1.MinWidth = 85
        Me.Phone1.Name = "Phone1"
        Me.Phone1.Visible = True
        Me.Phone1.VisibleIndex = 3
        Me.Phone1.Width = 85
        '
        'Fax
        '
        Me.Fax.Caption = "เบอร์แฟกซ์"
        Me.Fax.FieldName = "Fax"
        Me.Fax.MaxWidth = 85
        Me.Fax.MinWidth = 85
        Me.Fax.Name = "Fax"
        Me.Fax.Visible = True
        Me.Fax.VisibleIndex = 4
        Me.Fax.Width = 85
        '
        'Email1
        '
        Me.Email1.Caption = "อีเมล์"
        Me.Email1.FieldName = "Email1"
        Me.Email1.MaxWidth = 85
        Me.Email1.MinWidth = 85
        Me.Email1.Name = "Email1"
        Me.Email1.Visible = True
        Me.Email1.VisibleIndex = 5
        Me.Email1.Width = 85
        '
        'EMPNAME
        '
        Me.EMPNAME.Caption = "ผู้รับผิดชอบ"
        Me.EMPNAME.FieldName = "EMPNAME"
        Me.EMPNAME.MaxWidth = 150
        Me.EMPNAME.MinWidth = 120
        Me.EMPNAME.Name = "EMPNAME"
        Me.EMPNAME.Visible = True
        Me.EMPNAME.VisibleIndex = 6
        Me.EMPNAME.Width = 120
        '
        'cboCurrency
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.cboCurrency, "TextChanged")
        Me.cboCurrency.EditValue = CType(0, Short)
        Me.cboCurrency.EnterMoveNextControl = True
        Me.cboCurrency.Location = New System.Drawing.Point(117, 660)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.cboCurrency, True)
        Me.cboCurrency.Name = "cboCurrency"
        Me.cboCurrency.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboCurrency.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCurrency.Properties.Appearance.Options.UseFont = True
        Me.cboCurrency.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboCurrency.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCurrency.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 50, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", 50, "สกุลเงิน"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NameThai", "", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Center), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ExchangeRate", "อัตราแลกเปลี่ยน", 40, DevExpress.Utils.FormatType.Numeric, "n2", True, DevExpress.Utils.HorzAlignment.Far)})
        Me.cboCurrency.Properties.DropDownRows = 10
        Me.cboCurrency.Properties.ImmediatePopup = True
        Me.cboCurrency.Properties.NullValuePromptShowForEmptyValue = True
        Me.cboCurrency.Properties.PopupWidth = 300
        Me.cboCurrency.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboCurrency.Properties.ThrowExceptionOnInvalidLookUpEditValueType = True
        Me.cboCurrency.Properties.UseCtrlScroll = True
        Me.cboCurrency.Size = New System.Drawing.Size(167, 20)
        Me.cboCurrency.StyleController = Me.LayoutControl1
        Me.cboCurrency.TabIndex = 23
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.cboCurrency, "Text")
        '
        'btnGenID
        '
        Me.btnGenID.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnGenID.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnGenID, "")
        Me.btnGenID.Image = CType(resources.GetObject("btnGenID.Image"), System.Drawing.Image)
        Me.btnGenID.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnGenID.Location = New System.Drawing.Point(431, 12)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnGenID, True)
        Me.btnGenID.Name = "btnGenID"
        Me.btnGenID.Size = New System.Drawing.Size(26, 22)
        Me.btnGenID.StyleController = Me.LayoutControl1
        Me.btnGenID.TabIndex = 241
        Me.btnGenID.TabStop = False
        Me.btnGenID.ToolTip = "Auto ID"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnGenID, "")
        '
        'VatPercen
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.VatPercen, "TextChanged")
        Me.VatPercen.EnterMoveNextControl = True
        Me.VatPercen.Location = New System.Drawing.Point(423, 612)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.VatPercen, True)
        Me.VatPercen.Name = "VatPercen"
        Me.VatPercen.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VatPercen.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VatPercen.Properties.Appearance.Options.UseBackColor = True
        Me.VatPercen.Properties.Appearance.Options.UseFont = True
        Me.VatPercen.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.VatPercen.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VatPercen.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VatPercen.Properties.Mask.EditMask = "n2"
        Me.VatPercen.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.VatPercen.Properties.Precision = 2
        Me.VatPercen.Properties.ReadOnly = True
        Me.VatPercen.Size = New System.Drawing.Size(165, 20)
        Me.VatPercen.StyleController = Me.LayoutControl1
        Me.VatPercen.TabIndex = 282
        Me.VatPercen.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.VatPercen, "Text")
        '
        'VatAmount
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.VatAmount, "TextChanged")
        Me.VatAmount.EnterMoveNextControl = True
        Me.VatAmount.Location = New System.Drawing.Point(720, 612)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.VatAmount, True)
        Me.VatAmount.Name = "VatAmount"
        Me.VatAmount.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.VatAmount.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VatAmount.Properties.Appearance.Options.UseBackColor = True
        Me.VatAmount.Properties.Appearance.Options.UseFont = True
        Me.VatAmount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.VatAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VatAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VatAmount.Properties.Mask.EditMask = "n2"
        Me.VatAmount.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.VatAmount.Properties.Precision = 2
        Me.VatAmount.Size = New System.Drawing.Size(183, 20)
        Me.VatAmount.StyleController = Me.LayoutControl1
        Me.VatAmount.TabIndex = 280
        Me.VatAmount.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.VatAmount, "Text")
        '
        'SendBy
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.SendBy, "TextChanged")
        Me.SendBy.EnterMoveNextControl = True
        Me.SendBy.Location = New System.Drawing.Point(568, 185)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.SendBy, True)
        Me.SendBy.Name = "SendBy"
        Me.SendBy.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SendBy.Properties.Appearance.Options.UseFont = True
        Me.SendBy.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SendBy.Properties.ImmediatePopup = True
        Me.SendBy.Properties.Items.AddRange(New Object() {"ลุกค้ารับเอง", "บริษัทจัดส่งให้"})
        Me.SendBy.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.SendBy.Properties.UseCtrlScroll = True
        Me.SendBy.Size = New System.Drawing.Size(303, 20)
        Me.SendBy.StyleController = Me.LayoutControl1
        Me.SendBy.TabIndex = 13
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.SendBy, "Text")
        '
        'btnCreditRuleID
        '
        Me.btnCreditRuleID.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCreditRuleID.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnCreditRuleID, "")
        Me.btnCreditRuleID.Image = CType(resources.GetObject("btnCreditRuleID.Image"), System.Drawing.Image)
        Me.btnCreditRuleID.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCreditRuleID.Location = New System.Drawing.Point(431, 86)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnCreditRuleID, True)
        Me.btnCreditRuleID.Name = "btnCreditRuleID"
        Me.btnCreditRuleID.Size = New System.Drawing.Size(26, 22)
        Me.btnCreditRuleID.StyleController = Me.LayoutControl1
        Me.btnCreditRuleID.TabIndex = 245
        Me.btnCreditRuleID.TabStop = False
        Me.btnCreditRuleID.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnCreditRuleID, "")
        '
        'OrderDate
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.OrderDate, "TextChanged")
        Me.OrderDate.EditValue = New Date(2012, 4, 20, 0, 0, 0, 0)
        Me.OrderDate.EnterMoveNextControl = True
        Me.OrderDate.Location = New System.Drawing.Point(568, 12)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.OrderDate, True)
        Me.OrderDate.Name = "OrderDate"
        Me.OrderDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.OrderDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.OrderDate.Properties.Appearance.Options.UseFont = True
        Me.OrderDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrderDate.Properties.DisplayFormat.FormatString = "D"
        Me.OrderDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.OrderDate.Properties.EditFormat.FormatString = "D"
        Me.OrderDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.OrderDate.Properties.Mask.EditMask = "D"
        Me.OrderDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.OrderDate.Size = New System.Drawing.Size(303, 20)
        Me.OrderDate.StyleController = Me.LayoutControl1
        Me.OrderDate.TabIndex = 2
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.OrderDate, "Text")
        '
        'VatTypeID
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.VatTypeID, "TextChanged")
        Me.VatTypeID.EnterMoveNextControl = True
        Me.VatTypeID.Location = New System.Drawing.Point(117, 612)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.VatTypeID, True)
        Me.VatTypeID.Name = "VatTypeID"
        Me.VatTypeID.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.VatTypeID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VatTypeID.Properties.Appearance.Options.UseFont = True
        Me.VatTypeID.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.VatTypeID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.VatTypeID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 50, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", 30, "รหัสภาษี"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NameThai", "ชื่อรูปแบบภาษี", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Center), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("VatRate", "อัตราภาษี (%)", 20, DevExpress.Utils.FormatType.Numeric, "n2", True, DevExpress.Utils.HorzAlignment.Far)})
        Me.VatTypeID.Properties.DropDownRows = 10
        Me.VatTypeID.Properties.ImmediatePopup = True
        Me.VatTypeID.Properties.NullText = ""
        Me.VatTypeID.Properties.NullValuePromptShowForEmptyValue = True
        Me.VatTypeID.Properties.PopupWidth = 300
        Me.VatTypeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.VatTypeID.Properties.ThrowExceptionOnInvalidLookUpEditValueType = True
        Me.VatTypeID.Properties.UseCtrlScroll = True
        Me.VatTypeID.Size = New System.Drawing.Size(167, 20)
        Me.VatTypeID.StyleController = Me.LayoutControl1
        Me.VatTypeID.TabIndex = 22
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.VatTypeID, "Text")
        '
        'QuotationDays
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.QuotationDays, "TextChanged")
        Me.QuotationDays.EnterMoveNextControl = True
        Me.QuotationDays.Location = New System.Drawing.Point(568, 161)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.QuotationDays, True)
        Me.QuotationDays.Name = "QuotationDays"
        Me.QuotationDays.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuotationDays.Properties.Appearance.Options.UseFont = True
        Me.QuotationDays.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.QuotationDays.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.QuotationDays.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.QuotationDays.Properties.Mask.EditMask = "n0"
        Me.QuotationDays.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.QuotationDays.Properties.Precision = 0
        Me.QuotationDays.Size = New System.Drawing.Size(303, 20)
        Me.QuotationDays.StyleController = Me.LayoutControl1
        Me.QuotationDays.TabIndex = 10
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.QuotationDays, "Text")
        '
        'btnEmpID
        '
        Me.btnEmpID.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnEmpID.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnEmpID, "")
        Me.btnEmpID.Image = CType(resources.GetObject("btnEmpID.Image"), System.Drawing.Image)
        Me.btnEmpID.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEmpID.Location = New System.Drawing.Point(431, 112)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnEmpID, True)
        Me.btnEmpID.Name = "btnEmpID"
        Me.btnEmpID.Size = New System.Drawing.Size(26, 22)
        Me.btnEmpID.StyleController = Me.LayoutControl1
        Me.btnEmpID.TabIndex = 284
        Me.btnEmpID.TabStop = False
        Me.btnEmpID.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnEmpID, "")
        '
        'TotalAfterDis
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.TotalAfterDis, "TextChanged")
        Me.TotalAfterDis.EnterMoveNextControl = True
        Me.TotalAfterDis.Location = New System.Drawing.Point(697, 587)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.TotalAfterDis, True)
        Me.TotalAfterDis.Name = "TotalAfterDis"
        Me.TotalAfterDis.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TotalAfterDis.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalAfterDis.Properties.Appearance.Options.UseBackColor = True
        Me.TotalAfterDis.Properties.Appearance.Options.UseFont = True
        Me.TotalAfterDis.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TotalAfterDis.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TotalAfterDis.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TotalAfterDis.Properties.Mask.EditMask = "n2"
        Me.TotalAfterDis.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TotalAfterDis.Properties.Precision = 2
        Me.TotalAfterDis.Properties.ReadOnly = True
        Me.TotalAfterDis.Size = New System.Drawing.Size(206, 20)
        Me.TotalAfterDis.StyleController = Me.LayoutControl1
        Me.TotalAfterDis.TabIndex = 279
        Me.TotalAfterDis.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.TotalAfterDis, "Text")
        '
        'EmpID
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.EmpID, "TextChanged")
        Me.EmpID.EnterMoveNextControl = True
        Me.EmpID.Location = New System.Drawing.Point(117, 108)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.EmpID, True)
        Me.EmpID.Name = "EmpID"
        Me.EmpID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpID.Properties.Appearance.Options.UseFont = True
        Me.EmpID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EmpID.Properties.NullText = ""
        Me.EmpID.Properties.View = Me.GridView1
        Me.EmpID.Size = New System.Drawing.Size(308, 20)
        Me.EmpID.StyleController = Me.LayoutControl1
        Me.EmpID.TabIndex = 6
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.EmpID, "Text")
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn5, Me.GridColumn6})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "รหัส"
        Me.GridColumn1.FieldName = " ID"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "รหัส"
        Me.GridColumn5.FieldName = "EmpCode"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "ชื่อ - นามสกุล"
        Me.GridColumn6.FieldName = "NAME"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 1
        '
        'ExpireDate
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.ExpireDate, "TextChanged")
        Me.ExpireDate.EditValue = New Date(2012, 4, 20, 0, 0, 0, 0)
        Me.ExpireDate.EnterMoveNextControl = True
        Me.ExpireDate.Location = New System.Drawing.Point(568, 84)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.ExpireDate, True)
        Me.ExpireDate.Name = "ExpireDate"
        Me.ExpireDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.ExpireDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ExpireDate.Properties.Appearance.Options.UseFont = True
        Me.ExpireDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ExpireDate.Properties.DisplayFormat.FormatString = "D"
        Me.ExpireDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ExpireDate.Properties.EditFormat.FormatString = "D"
        Me.ExpireDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ExpireDate.Properties.Mask.EditMask = "D"
        Me.ExpireDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ExpireDate.Size = New System.Drawing.Size(303, 20)
        Me.ExpireDate.StyleController = Me.LayoutControl1
        Me.ExpireDate.TabIndex = 5
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.ExpireDate, "Text")
        '
        'btnVatTypeID
        '
        Me.btnVatTypeID.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnVatTypeID.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnVatTypeID, "")
        Me.btnVatTypeID.Image = CType(resources.GetObject("btnVatTypeID.Image"), System.Drawing.Image)
        Me.btnVatTypeID.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnVatTypeID.Location = New System.Drawing.Point(288, 612)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnVatTypeID, True)
        Me.btnVatTypeID.Name = "btnVatTypeID"
        Me.btnVatTypeID.Size = New System.Drawing.Size(26, 22)
        Me.btnVatTypeID.StyleController = Me.LayoutControl1
        Me.btnVatTypeID.TabIndex = 149
        Me.btnVatTypeID.TabStop = False
        Me.btnVatTypeID.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnVatTypeID, "")
        '
        'DiscountAmount
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.DiscountAmount, "TextChanged")
        Me.DiscountAmount.EnterMoveNextControl = True
        Me.DiscountAmount.Location = New System.Drawing.Point(423, 587)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.DiscountAmount, True)
        Me.DiscountAmount.Name = "DiscountAmount"
        Me.DiscountAmount.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscountAmount.Properties.Appearance.Options.UseFont = True
        Me.DiscountAmount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DiscountAmount.Properties.DisplayFormat.FormatString = "n2"
        Me.DiscountAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.DiscountAmount.Properties.EditFormat.FormatString = "n2"
        Me.DiscountAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.DiscountAmount.Properties.Mask.EditMask = "n2"
        Me.DiscountAmount.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.DiscountAmount.Properties.Precision = 2
        Me.DiscountAmount.Size = New System.Drawing.Size(165, 20)
        Me.DiscountAmount.StyleController = Me.LayoutControl1
        Me.DiscountAmount.TabIndex = 21
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.DiscountAmount, "Text")
        '
        'OrderStatus
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.OrderStatus, "TextChanged")
        Me.OrderStatus.EnterMoveNextControl = True
        Me.OrderStatus.Location = New System.Drawing.Point(117, 132)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.OrderStatus, True)
        Me.OrderStatus.Name = "OrderStatus"
        Me.OrderStatus.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.OrderStatus.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.OrderStatus.Properties.Appearance.Options.UseBackColor = True
        Me.OrderStatus.Properties.Appearance.Options.UseFont = True
        Me.OrderStatus.Properties.MaxLength = 50
        Me.OrderStatus.Properties.ReadOnly = True
        Me.OrderStatus.Properties.ValidateOnEnterKey = True
        Me.OrderStatus.Size = New System.Drawing.Size(308, 20)
        Me.OrderStatus.StyleController = Me.LayoutControl1
        Me.OrderStatus.TabIndex = 9
        Me.OrderStatus.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.OrderStatus, "Text")
        '
        'Total
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Total, "TextChanged")
        Me.Total.EnterMoveNextControl = True
        Me.Total.Location = New System.Drawing.Point(697, 537)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Total, True)
        Me.Total.Name = "Total"
        Me.Total.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Total.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.Properties.Appearance.Options.UseBackColor = True
        Me.Total.Properties.Appearance.Options.UseFont = True
        Me.Total.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Total.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Total.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Total.Properties.Mask.EditMask = "n2"
        Me.Total.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Total.Properties.Precision = 2
        Me.Total.Properties.ReadOnly = True
        Me.Total.Size = New System.Drawing.Size(206, 20)
        Me.Total.StyleController = Me.LayoutControl1
        Me.Total.TabIndex = 278
        Me.Total.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Total, "Text")
        '
        'DiscountPercen
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.DiscountPercen, "TextChanged")
        Me.DiscountPercen.EnterMoveNextControl = True
        Me.DiscountPercen.Location = New System.Drawing.Point(117, 587)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.DiscountPercen, True)
        Me.DiscountPercen.Name = "DiscountPercen"
        Me.DiscountPercen.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscountPercen.Properties.Appearance.Options.UseFont = True
        Me.DiscountPercen.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DiscountPercen.Properties.DisplayFormat.FormatString = "n2"
        Me.DiscountPercen.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.DiscountPercen.Properties.EditFormat.FormatString = "n2"
        Me.DiscountPercen.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.DiscountPercen.Properties.Mask.EditMask = "n2"
        Me.DiscountPercen.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.DiscountPercen.Properties.Precision = 2
        Me.DiscountPercen.Size = New System.Drawing.Size(167, 20)
        Me.DiscountPercen.StyleController = Me.LayoutControl1
        Me.DiscountPercen.TabIndex = 20
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.DiscountPercen, "Text")
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutbtnGenID, Me.LayoutbtnCustomerID, Me.LayoutCreditRuleID, Me.LayoutCode, Me.LayoutCustomerID, Me.LayoutbtnCreditRuleID, Me.EmptySpaceItem4, Me.SimpleSeparator2, Me.LayoutOrderDate, Me.LayoutbtnEmpID, Me.LayoutControlItem9, Me.LayoutExpireDate, Me.LayoutQuotationDays, Me.LayoutSendBy, Me.LayoutOrderStatus, Me.LayoutControlItem17, Me.SimpleSeparator4, Me.EmptySpaceItem5, Me.LayoutControlItem18, Me.LayoutControlItem19, Me.LayoutControlItem20, Me.LayoutControlItem21, Me.LayoutControlItem22, Me.LayoutControlItem23, Me.LayoutControlItem24, Me.LayoutControlItem25, Me.LayoutControlItem26, Me.LayoutControlItem27, Me.EmptySpaceItem6, Me.LayoutControlRefOrder, Me.LayoutShipingDate, Me.LayoutPO, Me.LayoutShipingMethod, Me.LayoutbtnShipingMethod, Me.LayoutClaimRemark2, Me.SimpleSeparator3, Me.SimpleSeparator1, Me.LayoutOrderDate2, Me.LayoutControlRefOrder2, Me.LayoutQuotationDays2, Me.LayoutShipingDate2, Me.LayoutPO_2, Me.LayoutExpireDate2, Me.LayoutSendBy2, Me.LayoutOrderStatus2, Me.LayoutIsCancel2, Me.LayoutIsCancel, Me.LayoutCancelRemark, Me.LayoutPayType, Me.LayoutPayType2, Me.LayoutCreditBalance2, Me.LayoutCreditBalance, Me.LayoutPledge1, Me.LayoutPledge4, Me.LayoutPledge3, Me.LayouShipingBy, Me.LayoutbtnShipingBy, Me.LayoutShipingRuleID2, Me.LayoutShipingRuleID, Me.LayoutTotalTax, Me.LayoutGrandTotal, Me.LayoutInvoiceSuplierID, Me.LayoutInvoiceSuplierID2, Me.LayoutInstitute, Me.EmptySpaceItem10, Me.LayoutStockType, Me.LayoutRefPO, Me.LayoutStockType2, Me.LayoutRefPO1, Me.LayoutControlItem2, Me.LayoutQuotationRemark, Me.LayoutbtnQuotationRemark, Me.LayoutNotPass, Me.LayoutbtnCampaign, Me.LayoutCampaign, Me.SplitterItem1, Me.LayoutControlProduct, Me.LayoutClaimRemark, Me.EmptySpaceItem1, Me.EmptySpaceItem3, Me.EmptySpaceItem2, Me.EmptySpaceItem9, Me.LayoutClaimResult, Me.LayoutClaimResult2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(921, 726)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutbtnGenID
        '
        Me.LayoutbtnGenID.Control = Me.btnGenID
        Me.LayoutbtnGenID.CustomizationFormText = "LayoutbtnGenID"
        Me.LayoutbtnGenID.Location = New System.Drawing.Point(419, 0)
        Me.LayoutbtnGenID.MaxSize = New System.Drawing.Size(30, 26)
        Me.LayoutbtnGenID.MinSize = New System.Drawing.Size(30, 26)
        Me.LayoutbtnGenID.Name = "LayoutbtnGenID"
        Me.LayoutbtnGenID.Size = New System.Drawing.Size(30, 26)
        Me.LayoutbtnGenID.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutbtnGenID.Text = "LayoutbtnGenID"
        Me.LayoutbtnGenID.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutbtnGenID.TextToControlDistance = 0
        Me.LayoutbtnGenID.TextVisible = False
        '
        'LayoutbtnCustomerID
        '
        Me.LayoutbtnCustomerID.Control = Me.btnCustomerID
        Me.LayoutbtnCustomerID.CustomizationFormText = "LayoutbtnCustomerID"
        Me.LayoutbtnCustomerID.Location = New System.Drawing.Point(419, 26)
        Me.LayoutbtnCustomerID.MaxSize = New System.Drawing.Size(30, 24)
        Me.LayoutbtnCustomerID.MinSize = New System.Drawing.Size(30, 24)
        Me.LayoutbtnCustomerID.Name = "LayoutbtnCustomerID"
        Me.LayoutbtnCustomerID.Size = New System.Drawing.Size(30, 24)
        Me.LayoutbtnCustomerID.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutbtnCustomerID.Text = "LayoutbtnCustomerID"
        Me.LayoutbtnCustomerID.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutbtnCustomerID.TextToControlDistance = 0
        Me.LayoutbtnCustomerID.TextVisible = False
        '
        'LayoutCreditRuleID
        '
        Me.LayoutCreditRuleID.Control = Me.CreditRuleID
        Me.LayoutCreditRuleID.CustomizationFormText = "เงื่อนไขการชำระเงิน"
        Me.LayoutCreditRuleID.Location = New System.Drawing.Point(0, 72)
        Me.LayoutCreditRuleID.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayoutCreditRuleID.MinSize = New System.Drawing.Size(159, 24)
        Me.LayoutCreditRuleID.Name = "LayoutCreditRuleID"
        Me.LayoutCreditRuleID.Size = New System.Drawing.Size(417, 24)
        Me.LayoutCreditRuleID.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutCreditRuleID.Text = "เงื่อนไขการชำระเงิน"
        Me.LayoutCreditRuleID.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutCode
        '
        Me.LayoutCode.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LayoutCode.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutCode.Control = Me.OrderCode
        Me.LayoutCode.CustomizationFormText = "เลขที่เอกสาร"
        Me.LayoutCode.Location = New System.Drawing.Point(0, 0)
        Me.LayoutCode.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayoutCode.MinSize = New System.Drawing.Size(159, 24)
        Me.LayoutCode.Name = "LayoutCode"
        Me.LayoutCode.Size = New System.Drawing.Size(417, 24)
        Me.LayoutCode.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutCode.Text = "เลขที่เอกสาร"
        Me.LayoutCode.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutCustomerID
        '
        Me.LayoutCustomerID.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LayoutCustomerID.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutCustomerID.Control = Me.CustomerID
        Me.LayoutCustomerID.CustomizationFormText = "ลูกค้า"
        Me.LayoutCustomerID.Location = New System.Drawing.Point(0, 24)
        Me.LayoutCustomerID.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayoutCustomerID.MinSize = New System.Drawing.Size(159, 24)
        Me.LayoutCustomerID.Name = "LayoutCustomerID"
        Me.LayoutCustomerID.Size = New System.Drawing.Size(417, 24)
        Me.LayoutCustomerID.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutCustomerID.Text = "ลูกค้า"
        Me.LayoutCustomerID.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutbtnCreditRuleID
        '
        Me.LayoutbtnCreditRuleID.Control = Me.btnCreditRuleID
        Me.LayoutbtnCreditRuleID.CustomizationFormText = "LayoutbtnCreditRuleID"
        Me.LayoutbtnCreditRuleID.Location = New System.Drawing.Point(419, 74)
        Me.LayoutbtnCreditRuleID.MaxSize = New System.Drawing.Size(30, 26)
        Me.LayoutbtnCreditRuleID.MinSize = New System.Drawing.Size(30, 26)
        Me.LayoutbtnCreditRuleID.Name = "LayoutbtnCreditRuleID"
        Me.LayoutbtnCreditRuleID.Size = New System.Drawing.Size(30, 26)
        Me.LayoutbtnCreditRuleID.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutbtnCreditRuleID.Text = "LayoutbtnCreditRuleID"
        Me.LayoutbtnCreditRuleID.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutbtnCreditRuleID.TextToControlDistance = 0
        Me.LayoutbtnCreditRuleID.TextVisible = False
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 353)
        Me.EmptySpaceItem4.MaxSize = New System.Drawing.Size(417, 12)
        Me.EmptySpaceItem4.MinSize = New System.Drawing.Size(417, 12)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(417, 12)
        Me.EmptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem4.Text = "EmptySpaceItem4"
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'SimpleSeparator2
        '
        Me.SimpleSeparator2.AllowHotTrack = False
        Me.SimpleSeparator2.CustomizationFormText = "SimpleSeparator2"
        Me.SimpleSeparator2.Location = New System.Drawing.Point(449, 0)
        Me.SimpleSeparator2.Name = "SimpleSeparator2"
        Me.SimpleSeparator2.Size = New System.Drawing.Size(2, 365)
        Me.SimpleSeparator2.Text = "SimpleSeparator2"
        '
        'LayoutOrderDate
        '
        Me.LayoutOrderDate.Control = Me.OrderDate
        Me.LayoutOrderDate.CustomizationFormText = "วันที่เอกสาร"
        Me.LayoutOrderDate.Location = New System.Drawing.Point(451, 0)
        Me.LayoutOrderDate.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayoutOrderDate.MinSize = New System.Drawing.Size(159, 24)
        Me.LayoutOrderDate.Name = "LayoutOrderDate"
        Me.LayoutOrderDate.Size = New System.Drawing.Size(412, 24)
        Me.LayoutOrderDate.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutOrderDate.Text = "วันที่เอกสาร"
        Me.LayoutOrderDate.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutbtnEmpID
        '
        Me.LayoutbtnEmpID.Control = Me.btnEmpID
        Me.LayoutbtnEmpID.CustomizationFormText = "LayoutbtnEmpID"
        Me.LayoutbtnEmpID.Location = New System.Drawing.Point(419, 100)
        Me.LayoutbtnEmpID.MaxSize = New System.Drawing.Size(30, 26)
        Me.LayoutbtnEmpID.MinSize = New System.Drawing.Size(30, 26)
        Me.LayoutbtnEmpID.Name = "LayoutbtnEmpID"
        Me.LayoutbtnEmpID.Size = New System.Drawing.Size(30, 26)
        Me.LayoutbtnEmpID.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutbtnEmpID.Text = "LayoutbtnEmpID"
        Me.LayoutbtnEmpID.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutbtnEmpID.TextToControlDistance = 0
        Me.LayoutbtnEmpID.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.EmpID
        Me.LayoutControlItem9.CustomizationFormText = "พนักงาน"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(159, 24)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(417, 24)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.Text = "พนักงาน"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutExpireDate
        '
        Me.LayoutExpireDate.Control = Me.ExpireDate
        Me.LayoutExpireDate.CustomizationFormText = "วันที่ครบกำหนด"
        Me.LayoutExpireDate.Location = New System.Drawing.Point(451, 72)
        Me.LayoutExpireDate.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayoutExpireDate.MinSize = New System.Drawing.Size(159, 24)
        Me.LayoutExpireDate.Name = "LayoutExpireDate"
        Me.LayoutExpireDate.Size = New System.Drawing.Size(412, 24)
        Me.LayoutExpireDate.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutExpireDate.Text = "วันที่ครบกำหนด"
        Me.LayoutExpireDate.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutQuotationDays
        '
        Me.LayoutQuotationDays.Control = Me.QuotationDays
        Me.LayoutQuotationDays.CustomizationFormText = "ยืนราคา(วัน)"
        Me.LayoutQuotationDays.Location = New System.Drawing.Point(451, 149)
        Me.LayoutQuotationDays.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayoutQuotationDays.MinSize = New System.Drawing.Size(159, 24)
        Me.LayoutQuotationDays.Name = "LayoutQuotationDays"
        Me.LayoutQuotationDays.Size = New System.Drawing.Size(412, 24)
        Me.LayoutQuotationDays.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutQuotationDays.Text = "ยืนราคา(วัน)"
        Me.LayoutQuotationDays.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutSendBy
        '
        Me.LayoutSendBy.Control = Me.SendBy
        Me.LayoutSendBy.CustomizationFormText = "การส่งมอบ"
        Me.LayoutSendBy.Location = New System.Drawing.Point(451, 173)
        Me.LayoutSendBy.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayoutSendBy.MinSize = New System.Drawing.Size(159, 24)
        Me.LayoutSendBy.Name = "LayoutSendBy"
        Me.LayoutSendBy.Size = New System.Drawing.Size(412, 24)
        Me.LayoutSendBy.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutSendBy.Text = "การส่งมอบ"
        Me.LayoutSendBy.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutOrderStatus
        '
        Me.LayoutOrderStatus.Control = Me.OrderStatus
        Me.LayoutOrderStatus.CustomizationFormText = "สถานะ"
        Me.LayoutOrderStatus.Location = New System.Drawing.Point(0, 120)
        Me.LayoutOrderStatus.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayoutOrderStatus.MinSize = New System.Drawing.Size(159, 24)
        Me.LayoutOrderStatus.Name = "LayoutOrderStatus"
        Me.LayoutOrderStatus.Size = New System.Drawing.Size(417, 24)
        Me.LayoutOrderStatus.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutOrderStatus.Text = "สถานะ"
        Me.LayoutOrderStatus.TextSize = New System.Drawing.Size(102, 13)
        Me.LayoutOrderStatus.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.Total
        Me.LayoutControlItem17.CustomizationFormText = "ยอดรวม"
        Me.LayoutControlItem17.Location = New System.Drawing.Point(580, 525)
        Me.LayoutControlItem17.MaxSize = New System.Drawing.Size(315, 25)
        Me.LayoutControlItem17.MinSize = New System.Drawing.Size(315, 25)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(315, 25)
        Me.LayoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem17.Text = "ยอดรวม"
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(102, 13)
        '
        'SimpleSeparator4
        '
        Me.SimpleSeparator4.AllowHotTrack = False
        Me.SimpleSeparator4.CustomizationFormText = "SimpleSeparator4"
        Me.SimpleSeparator4.Location = New System.Drawing.Point(0, 365)
        Me.SimpleSeparator4.Name = "SimpleSeparator4"
        Me.SimpleSeparator4.Size = New System.Drawing.Size(895, 2)
        Me.SimpleSeparator4.Text = "SimpleSeparator4"
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.CustomizationFormText = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(0, 525)
        Me.EmptySpaceItem5.MaxSize = New System.Drawing.Size(0, 25)
        Me.EmptySpaceItem5.MinSize = New System.Drawing.Size(104, 25)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(580, 25)
        Me.EmptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem5.Text = "EmptySpaceItem5"
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.DiscountPercen
        Me.LayoutControlItem18.CustomizationFormText = "ส่วนลด %"
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 575)
        Me.LayoutControlItem18.MaxSize = New System.Drawing.Size(276, 25)
        Me.LayoutControlItem18.MinSize = New System.Drawing.Size(276, 25)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(276, 25)
        Me.LayoutControlItem18.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem18.Text = "ส่วนลด %"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.DiscountAmount
        Me.LayoutControlItem19.CustomizationFormText = "ส่วนลด"
        Me.LayoutControlItem19.Location = New System.Drawing.Point(306, 575)
        Me.LayoutControlItem19.MaxSize = New System.Drawing.Size(274, 25)
        Me.LayoutControlItem19.MinSize = New System.Drawing.Size(274, 25)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(274, 25)
        Me.LayoutControlItem19.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem19.Text = "ส่วนลด"
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.TotalAfterDis
        Me.LayoutControlItem20.CustomizationFormText = "ยอดหลังหักส่วนลด"
        Me.LayoutControlItem20.Location = New System.Drawing.Point(580, 575)
        Me.LayoutControlItem20.MaxSize = New System.Drawing.Size(315, 25)
        Me.LayoutControlItem20.MinSize = New System.Drawing.Size(315, 25)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(315, 25)
        Me.LayoutControlItem20.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem20.Text = "ยอดหลังหักส่วนลด"
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LayoutControlItem21.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem21.Control = Me.VatTypeID
        Me.LayoutControlItem21.CustomizationFormText = "รูปแบบภาษี *"
        Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 600)
        Me.LayoutControlItem21.MaxSize = New System.Drawing.Size(276, 26)
        Me.LayoutControlItem21.MinSize = New System.Drawing.Size(276, 26)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(276, 48)
        Me.LayoutControlItem21.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem21.Text = "รูปแบบภาษี"
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.btnVatTypeID
        Me.LayoutControlItem22.CustomizationFormText = "LayoutControlItem22"
        Me.LayoutControlItem22.Location = New System.Drawing.Point(276, 600)
        Me.LayoutControlItem22.MaxSize = New System.Drawing.Size(30, 26)
        Me.LayoutControlItem22.MinSize = New System.Drawing.Size(30, 26)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(30, 48)
        Me.LayoutControlItem22.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem22.Text = "LayoutControlItem22"
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem22.TextToControlDistance = 0
        Me.LayoutControlItem22.TextVisible = False
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.VatPercen
        Me.LayoutControlItem23.CustomizationFormText = "อัตรา %"
        Me.LayoutControlItem23.Location = New System.Drawing.Point(306, 600)
        Me.LayoutControlItem23.MaxSize = New System.Drawing.Size(274, 26)
        Me.LayoutControlItem23.MinSize = New System.Drawing.Size(274, 26)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(274, 48)
        Me.LayoutControlItem23.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem23.Text = "อัตรา %"
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.VatAmount
        Me.LayoutControlItem24.CustomizationFormText = "ยอดภาษี"
        Me.LayoutControlItem24.Location = New System.Drawing.Point(603, 600)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(292, 24)
        Me.LayoutControlItem24.Text = "ยอดภาษี"
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.cboCurrency
        Me.LayoutControlItem25.CustomizationFormText = "สกุลเงิน"
        Me.LayoutControlItem25.Location = New System.Drawing.Point(0, 648)
        Me.LayoutControlItem25.MaxSize = New System.Drawing.Size(276, 26)
        Me.LayoutControlItem25.MinSize = New System.Drawing.Size(276, 26)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(276, 26)
        Me.LayoutControlItem25.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem25.Text = "สกุลเงิน"
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.btnRefreshCurrency
        Me.LayoutControlItem26.CustomizationFormText = "LayoutControlItem26"
        Me.LayoutControlItem26.Location = New System.Drawing.Point(276, 648)
        Me.LayoutControlItem26.MaxSize = New System.Drawing.Size(30, 26)
        Me.LayoutControlItem26.MinSize = New System.Drawing.Size(30, 26)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(30, 26)
        Me.LayoutControlItem26.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem26.Text = "LayoutControlItem26"
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem26.TextToControlDistance = 0
        Me.LayoutControlItem26.TextVisible = False
        '
        'LayoutControlItem27
        '
        Me.LayoutControlItem27.Control = Me.Exchange
        Me.LayoutControlItem27.CustomizationFormText = "อัตราแลกเปลี่ยน"
        Me.LayoutControlItem27.Location = New System.Drawing.Point(306, 648)
        Me.LayoutControlItem27.MaxSize = New System.Drawing.Size(274, 26)
        Me.LayoutControlItem27.MinSize = New System.Drawing.Size(274, 26)
        Me.LayoutControlItem27.Name = "LayoutControlItem27"
        Me.LayoutControlItem27.Size = New System.Drawing.Size(274, 26)
        Me.LayoutControlItem27.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem27.Text = "อัตราแลกเปลี่ยน"
        Me.LayoutControlItem27.TextSize = New System.Drawing.Size(102, 13)
        '
        'EmptySpaceItem6
        '
        Me.EmptySpaceItem6.AllowHotTrack = False
        Me.EmptySpaceItem6.CustomizationFormText = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Location = New System.Drawing.Point(276, 575)
        Me.EmptySpaceItem6.MaxSize = New System.Drawing.Size(30, 25)
        Me.EmptySpaceItem6.MinSize = New System.Drawing.Size(30, 25)
        Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Size = New System.Drawing.Size(30, 25)
        Me.EmptySpaceItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem6.Text = "EmptySpaceItem6"
        Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlRefOrder
        '
        Me.LayoutControlRefOrder.Control = Me.txtRefOrder
        Me.LayoutControlRefOrder.CustomizationFormText = "เอกสารอ้างอิง"
        Me.LayoutControlRefOrder.Location = New System.Drawing.Point(451, 221)
        Me.LayoutControlRefOrder.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayoutControlRefOrder.MinSize = New System.Drawing.Size(159, 24)
        Me.LayoutControlRefOrder.Name = "LayoutControlRefOrder"
        Me.LayoutControlRefOrder.Size = New System.Drawing.Size(412, 24)
        Me.LayoutControlRefOrder.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlRefOrder.Text = "เอกสารอ้างอิง"
        Me.LayoutControlRefOrder.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutShipingDate
        '
        Me.LayoutShipingDate.Control = Me.ShipingDate
        Me.LayoutShipingDate.CustomizationFormText = "วันที่ส่งของ"
        Me.LayoutShipingDate.Location = New System.Drawing.Point(451, 96)
        Me.LayoutShipingDate.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayoutShipingDate.MinSize = New System.Drawing.Size(159, 24)
        Me.LayoutShipingDate.Name = "LayoutShipingDate"
        Me.LayoutShipingDate.Size = New System.Drawing.Size(412, 24)
        Me.LayoutShipingDate.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutShipingDate.Text = "วันที่ส่งของ"
        Me.LayoutShipingDate.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutPO
        '
        Me.LayoutPO.Control = Me.PO
        Me.LayoutPO.CustomizationFormText = "เลขที่ใบสั่งซื้อ"
        Me.LayoutPO.Location = New System.Drawing.Point(451, 197)
        Me.LayoutPO.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayoutPO.MinSize = New System.Drawing.Size(159, 24)
        Me.LayoutPO.Name = "LayoutPO"
        Me.LayoutPO.Size = New System.Drawing.Size(412, 24)
        Me.LayoutPO.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutPO.Text = "เลขที่ใบสั่งซื้อ"
        Me.LayoutPO.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutShipingMethod
        '
        Me.LayoutShipingMethod.Control = Me.ShipingMethod
        Me.LayoutShipingMethod.CustomizationFormText = "วิธีการขนส่ง"
        Me.LayoutShipingMethod.Location = New System.Drawing.Point(0, 190)
        Me.LayoutShipingMethod.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayoutShipingMethod.MinSize = New System.Drawing.Size(159, 24)
        Me.LayoutShipingMethod.Name = "LayoutShipingMethod"
        Me.LayoutShipingMethod.Size = New System.Drawing.Size(417, 24)
        Me.LayoutShipingMethod.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutShipingMethod.Text = "วิธีการขนส่ง"
        Me.LayoutShipingMethod.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutbtnShipingMethod
        '
        Me.LayoutbtnShipingMethod.Control = Me.btnShipingMethod
        Me.LayoutbtnShipingMethod.CustomizationFormText = "LayoutbtnShipingMethod"
        Me.LayoutbtnShipingMethod.Location = New System.Drawing.Point(419, 188)
        Me.LayoutbtnShipingMethod.MaxSize = New System.Drawing.Size(30, 24)
        Me.LayoutbtnShipingMethod.MinSize = New System.Drawing.Size(30, 24)
        Me.LayoutbtnShipingMethod.Name = "LayoutbtnShipingMethod"
        Me.LayoutbtnShipingMethod.Size = New System.Drawing.Size(30, 24)
        Me.LayoutbtnShipingMethod.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutbtnShipingMethod.Text = "LayoutbtnShipingMethod"
        Me.LayoutbtnShipingMethod.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutbtnShipingMethod.TextToControlDistance = 0
        Me.LayoutbtnShipingMethod.TextVisible = False
        '
        'LayoutClaimRemark2
        '
        Me.LayoutClaimRemark2.AllowHotTrack = False
        Me.LayoutClaimRemark2.CustomizationFormText = "EmptySpaceItem2"
        Me.LayoutClaimRemark2.Location = New System.Drawing.Point(419, 317)
        Me.LayoutClaimRemark2.MaxSize = New System.Drawing.Size(30, 38)
        Me.LayoutClaimRemark2.MinSize = New System.Drawing.Size(30, 38)
        Me.LayoutClaimRemark2.Name = "LayoutClaimRemark2"
        Me.LayoutClaimRemark2.Size = New System.Drawing.Size(30, 38)
        Me.LayoutClaimRemark2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutClaimRemark2.Text = "LayoutClaimRemark2"
        Me.LayoutClaimRemark2.TextSize = New System.Drawing.Size(0, 0)
        '
        'SimpleSeparator3
        '
        Me.SimpleSeparator3.AllowHotTrack = False
        Me.SimpleSeparator3.CustomizationFormText = "SimpleSeparator3"
        Me.SimpleSeparator3.Location = New System.Drawing.Point(863, 0)
        Me.SimpleSeparator3.Name = "SimpleSeparator3"
        Me.SimpleSeparator3.Size = New System.Drawing.Size(2, 365)
        Me.SimpleSeparator3.Text = "SimpleSeparator3"
        '
        'SimpleSeparator1
        '
        Me.SimpleSeparator1.AllowHotTrack = False
        Me.SimpleSeparator1.CustomizationFormText = "SimpleSeparator1"
        Me.SimpleSeparator1.Location = New System.Drawing.Point(417, 0)
        Me.SimpleSeparator1.Name = "SimpleSeparator1"
        Me.SimpleSeparator1.Size = New System.Drawing.Size(2, 365)
        Me.SimpleSeparator1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.SimpleSeparator1.Text = "SimpleSeparator1"
        '
        'LayoutOrderDate2
        '
        Me.LayoutOrderDate2.AllowHotTrack = False
        Me.LayoutOrderDate2.CustomizationFormText = "LayoutOrderDate2"
        Me.LayoutOrderDate2.Location = New System.Drawing.Point(865, 0)
        Me.LayoutOrderDate2.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayoutOrderDate2.MinSize = New System.Drawing.Size(10, 24)
        Me.LayoutOrderDate2.Name = "LayoutOrderDate2"
        Me.LayoutOrderDate2.Size = New System.Drawing.Size(30, 24)
        Me.LayoutOrderDate2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutOrderDate2.Text = "1"
        Me.LayoutOrderDate2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlRefOrder2
        '
        Me.LayoutControlRefOrder2.Control = Me.btnRefOrder
        Me.LayoutControlRefOrder2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlRefOrder2.Location = New System.Drawing.Point(865, 221)
        Me.LayoutControlRefOrder2.MaxSize = New System.Drawing.Size(30, 26)
        Me.LayoutControlRefOrder2.MinSize = New System.Drawing.Size(30, 26)
        Me.LayoutControlRefOrder2.Name = "LayoutControlRefOrder2"
        Me.LayoutControlRefOrder2.Size = New System.Drawing.Size(30, 26)
        Me.LayoutControlRefOrder2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlRefOrder2.Text = "LayoutControlRefOrder2"
        Me.LayoutControlRefOrder2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlRefOrder2.TextToControlDistance = 0
        Me.LayoutControlRefOrder2.TextVisible = False
        '
        'LayoutQuotationDays2
        '
        Me.LayoutQuotationDays2.AllowHotTrack = False
        Me.LayoutQuotationDays2.CustomizationFormText = "LayoutQuotationDays2"
        Me.LayoutQuotationDays2.Location = New System.Drawing.Point(865, 149)
        Me.LayoutQuotationDays2.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayoutQuotationDays2.MinSize = New System.Drawing.Size(10, 24)
        Me.LayoutQuotationDays2.Name = "LayoutQuotationDays2"
        Me.LayoutQuotationDays2.Size = New System.Drawing.Size(30, 24)
        Me.LayoutQuotationDays2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutQuotationDays2.Text = "4"
        Me.LayoutQuotationDays2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutShipingDate2
        '
        Me.LayoutShipingDate2.AllowHotTrack = False
        Me.LayoutShipingDate2.CustomizationFormText = "LayoutShipingDate2"
        Me.LayoutShipingDate2.Location = New System.Drawing.Point(865, 96)
        Me.LayoutShipingDate2.MaxSize = New System.Drawing.Size(30, 24)
        Me.LayoutShipingDate2.MinSize = New System.Drawing.Size(30, 24)
        Me.LayoutShipingDate2.Name = "LayoutShipingDate2"
        Me.LayoutShipingDate2.Size = New System.Drawing.Size(30, 24)
        Me.LayoutShipingDate2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutShipingDate2.Text = "3"
        Me.LayoutShipingDate2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutPO_2
        '
        Me.LayoutPO_2.AllowHotTrack = False
        Me.LayoutPO_2.CustomizationFormText = "LayoutPO2"
        Me.LayoutPO_2.Location = New System.Drawing.Point(865, 197)
        Me.LayoutPO_2.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayoutPO_2.MinSize = New System.Drawing.Size(10, 24)
        Me.LayoutPO_2.Name = "LayoutPO_2"
        Me.LayoutPO_2.Size = New System.Drawing.Size(30, 24)
        Me.LayoutPO_2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutPO_2.Text = "6"
        Me.LayoutPO_2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutExpireDate2
        '
        Me.LayoutExpireDate2.AllowHotTrack = False
        Me.LayoutExpireDate2.CustomizationFormText = "LayoutExpireDate2"
        Me.LayoutExpireDate2.Location = New System.Drawing.Point(865, 72)
        Me.LayoutExpireDate2.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayoutExpireDate2.MinSize = New System.Drawing.Size(10, 24)
        Me.LayoutExpireDate2.Name = "LayoutExpireDate2"
        Me.LayoutExpireDate2.Size = New System.Drawing.Size(30, 24)
        Me.LayoutExpireDate2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutExpireDate2.Text = "2"
        Me.LayoutExpireDate2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutSendBy2
        '
        Me.LayoutSendBy2.AllowHotTrack = False
        Me.LayoutSendBy2.CustomizationFormText = "LayoutSendBy2"
        Me.LayoutSendBy2.Location = New System.Drawing.Point(865, 173)
        Me.LayoutSendBy2.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayoutSendBy2.MinSize = New System.Drawing.Size(10, 24)
        Me.LayoutSendBy2.Name = "LayoutSendBy2"
        Me.LayoutSendBy2.Size = New System.Drawing.Size(30, 24)
        Me.LayoutSendBy2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutSendBy2.Text = "5"
        Me.LayoutSendBy2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutOrderStatus2
        '
        Me.LayoutOrderStatus2.AllowHotTrack = False
        Me.LayoutOrderStatus2.CustomizationFormText = "LayoutOrderStatus2"
        Me.LayoutOrderStatus2.Location = New System.Drawing.Point(419, 126)
        Me.LayoutOrderStatus2.MaxSize = New System.Drawing.Size(30, 17)
        Me.LayoutOrderStatus2.MinSize = New System.Drawing.Size(30, 17)
        Me.LayoutOrderStatus2.Name = "LayoutOrderStatus2"
        Me.LayoutOrderStatus2.Size = New System.Drawing.Size(30, 17)
        Me.LayoutOrderStatus2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutOrderStatus2.Text = "LayoutOrderStatus2"
        Me.LayoutOrderStatus2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutOrderStatus2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutIsCancel2
        '
        Me.LayoutIsCancel2.AllowHotTrack = False
        Me.LayoutIsCancel2.CustomizationFormText = "EmptySpaceItem10"
        Me.LayoutIsCancel2.Location = New System.Drawing.Point(419, 143)
        Me.LayoutIsCancel2.MaxSize = New System.Drawing.Size(30, 45)
        Me.LayoutIsCancel2.MinSize = New System.Drawing.Size(30, 45)
        Me.LayoutIsCancel2.Name = "LayoutIsCancel2"
        Me.LayoutIsCancel2.Size = New System.Drawing.Size(30, 45)
        Me.LayoutIsCancel2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutIsCancel2.Text = "LayoutIsCancel2"
        Me.LayoutIsCancel2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutIsCancel
        '
        Me.LayoutIsCancel.Control = Me.IsCancel
        Me.LayoutIsCancel.CustomizationFormText = "LayoutIsCancel"
        Me.LayoutIsCancel.Location = New System.Drawing.Point(0, 144)
        Me.LayoutIsCancel.MaxSize = New System.Drawing.Size(0, 23)
        Me.LayoutIsCancel.MinSize = New System.Drawing.Size(59, 23)
        Me.LayoutIsCancel.Name = "LayoutIsCancel"
        Me.LayoutIsCancel.Size = New System.Drawing.Size(108, 23)
        Me.LayoutIsCancel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutIsCancel.Text = "LayoutIsCancel"
        Me.LayoutIsCancel.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutIsCancel.TextToControlDistance = 0
        Me.LayoutIsCancel.TextVisible = False
        '
        'LayoutCancelRemark
        '
        Me.LayoutCancelRemark.Control = Me.CancelRemark
        Me.LayoutCancelRemark.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutCancelRemark.Location = New System.Drawing.Point(108, 144)
        Me.LayoutCancelRemark.MaxSize = New System.Drawing.Size(309, 46)
        Me.LayoutCancelRemark.MinSize = New System.Drawing.Size(309, 46)
        Me.LayoutCancelRemark.Name = "LayoutCancelRemark"
        Me.LayoutCancelRemark.Size = New System.Drawing.Size(309, 46)
        Me.LayoutCancelRemark.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutCancelRemark.Text = "LayoutCancelRemark"
        Me.LayoutCancelRemark.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutCancelRemark.TextToControlDistance = 0
        Me.LayoutCancelRemark.TextVisible = False
        '
        'LayoutPayType
        '
        Me.LayoutPayType.Control = Me.PayType
        Me.LayoutPayType.CustomizationFormText = "ประเภทการขาย"
        Me.LayoutPayType.Location = New System.Drawing.Point(451, 120)
        Me.LayoutPayType.MaxSize = New System.Drawing.Size(0, 29)
        Me.LayoutPayType.MinSize = New System.Drawing.Size(159, 29)
        Me.LayoutPayType.Name = "LayoutPayType"
        Me.LayoutPayType.Size = New System.Drawing.Size(412, 29)
        Me.LayoutPayType.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutPayType.Text = "ประเภทการขาย"
        Me.LayoutPayType.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutPayType2
        '
        Me.LayoutPayType2.AllowHotTrack = False
        Me.LayoutPayType2.CustomizationFormText = "LayoutPayType2"
        Me.LayoutPayType2.Location = New System.Drawing.Point(865, 120)
        Me.LayoutPayType2.MaxSize = New System.Drawing.Size(0, 29)
        Me.LayoutPayType2.MinSize = New System.Drawing.Size(10, 29)
        Me.LayoutPayType2.Name = "LayoutPayType2"
        Me.LayoutPayType2.Size = New System.Drawing.Size(30, 29)
        Me.LayoutPayType2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutPayType2.Text = "LayoutPayType2"
        Me.LayoutPayType2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutCreditBalance2
        '
        Me.LayoutCreditBalance2.AllowHotTrack = False
        Me.LayoutCreditBalance2.CustomizationFormText = "LayoutCreditBalance2"
        Me.LayoutCreditBalance2.Location = New System.Drawing.Point(865, 24)
        Me.LayoutCreditBalance2.MaxSize = New System.Drawing.Size(30, 24)
        Me.LayoutCreditBalance2.MinSize = New System.Drawing.Size(30, 24)
        Me.LayoutCreditBalance2.Name = "LayoutCreditBalance2"
        Me.LayoutCreditBalance2.Size = New System.Drawing.Size(30, 24)
        Me.LayoutCreditBalance2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutCreditBalance2.Text = "LayoutCreditBalance2"
        Me.LayoutCreditBalance2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutCreditBalance
        '
        Me.LayoutCreditBalance.Control = Me.CreditBalance
        Me.LayoutCreditBalance.CustomizationFormText = "ยอดหนี้"
        Me.LayoutCreditBalance.Location = New System.Drawing.Point(451, 24)
        Me.LayoutCreditBalance.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayoutCreditBalance.MinSize = New System.Drawing.Size(159, 24)
        Me.LayoutCreditBalance.Name = "LayoutCreditBalance"
        Me.LayoutCreditBalance.Size = New System.Drawing.Size(412, 24)
        Me.LayoutCreditBalance.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutCreditBalance.Text = "ยอดหนี้"
        Me.LayoutCreditBalance.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutPledge1
        '
        Me.LayoutPledge1.AllowHotTrack = False
        Me.LayoutPledge1.CustomizationFormText = "LayoutPledge1"
        Me.LayoutPledge1.Location = New System.Drawing.Point(0, 550)
        Me.LayoutPledge1.MaxSize = New System.Drawing.Size(307, 25)
        Me.LayoutPledge1.MinSize = New System.Drawing.Size(307, 25)
        Me.LayoutPledge1.Name = "LayoutPledge1"
        Me.LayoutPledge1.Size = New System.Drawing.Size(307, 25)
        Me.LayoutPledge1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutPledge1.Text = "LayoutPledge1"
        Me.LayoutPledge1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutPledge4
        '
        Me.LayoutPledge4.Control = Me.TotalAfterPledge
        Me.LayoutPledge4.CustomizationFormText = "LayoutPledge4"
        Me.LayoutPledge4.Location = New System.Drawing.Point(580, 550)
        Me.LayoutPledge4.MaxSize = New System.Drawing.Size(315, 25)
        Me.LayoutPledge4.MinSize = New System.Drawing.Size(315, 25)
        Me.LayoutPledge4.Name = "LayoutPledge4"
        Me.LayoutPledge4.Size = New System.Drawing.Size(315, 25)
        Me.LayoutPledge4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutPledge4.Text = "ยอดหลังหักมัดจำ"
        Me.LayoutPledge4.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutPledge3
        '
        Me.LayoutPledge3.Control = Me.PledgeTotal
        Me.LayoutPledge3.CustomizationFormText = "LayoutPledge3"
        Me.LayoutPledge3.Location = New System.Drawing.Point(307, 550)
        Me.LayoutPledge3.MaxSize = New System.Drawing.Size(273, 25)
        Me.LayoutPledge3.MinSize = New System.Drawing.Size(273, 25)
        Me.LayoutPledge3.Name = "LayoutPledge3"
        Me.LayoutPledge3.Size = New System.Drawing.Size(273, 25)
        Me.LayoutPledge3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutPledge3.Text = "มัดจำ"
        Me.LayoutPledge3.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayouShipingBy
        '
        Me.LayouShipingBy.Control = Me.ShipingBy
        Me.LayouShipingBy.CustomizationFormText = "ขนส่งโดย"
        Me.LayouShipingBy.Location = New System.Drawing.Point(451, 269)
        Me.LayouShipingBy.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayouShipingBy.MinSize = New System.Drawing.Size(159, 24)
        Me.LayouShipingBy.Name = "LayouShipingBy"
        Me.LayouShipingBy.Size = New System.Drawing.Size(412, 24)
        Me.LayouShipingBy.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayouShipingBy.Text = "ขนส่งโดย"
        Me.LayouShipingBy.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutbtnShipingBy
        '
        Me.LayoutbtnShipingBy.Control = Me.btnShipingBy
        Me.LayoutbtnShipingBy.CustomizationFormText = "LayoutbtnShipingBy"
        Me.LayoutbtnShipingBy.Location = New System.Drawing.Point(865, 271)
        Me.LayoutbtnShipingBy.MaxSize = New System.Drawing.Size(30, 26)
        Me.LayoutbtnShipingBy.MinSize = New System.Drawing.Size(30, 26)
        Me.LayoutbtnShipingBy.Name = "LayoutbtnShipingBy"
        Me.LayoutbtnShipingBy.Size = New System.Drawing.Size(30, 26)
        Me.LayoutbtnShipingBy.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutbtnShipingBy.Text = "LayoutbtnShipingBy"
        Me.LayoutbtnShipingBy.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutbtnShipingBy.TextToControlDistance = 0
        Me.LayoutbtnShipingBy.TextVisible = False
        '
        'LayoutShipingRuleID2
        '
        Me.LayoutShipingRuleID2.Control = Me.btnShipingRuleID
        Me.LayoutShipingRuleID2.CustomizationFormText = "LayoutShipingRuleID2"
        Me.LayoutShipingRuleID2.Location = New System.Drawing.Point(419, 212)
        Me.LayoutShipingRuleID2.MaxSize = New System.Drawing.Size(30, 24)
        Me.LayoutShipingRuleID2.MinSize = New System.Drawing.Size(30, 24)
        Me.LayoutShipingRuleID2.Name = "LayoutShipingRuleID2"
        Me.LayoutShipingRuleID2.Size = New System.Drawing.Size(30, 24)
        Me.LayoutShipingRuleID2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutShipingRuleID2.Text = "LayoutShipingRuleID2"
        Me.LayoutShipingRuleID2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutShipingRuleID2.TextToControlDistance = 0
        Me.LayoutShipingRuleID2.TextVisible = False
        '
        'LayoutShipingRuleID
        '
        Me.LayoutShipingRuleID.Control = Me.ShipingRuleID
        Me.LayoutShipingRuleID.CustomizationFormText = "เงื่อนไขการขนส่ง"
        Me.LayoutShipingRuleID.Location = New System.Drawing.Point(0, 214)
        Me.LayoutShipingRuleID.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayoutShipingRuleID.MinSize = New System.Drawing.Size(159, 24)
        Me.LayoutShipingRuleID.Name = "LayoutShipingRuleID"
        Me.LayoutShipingRuleID.Size = New System.Drawing.Size(417, 24)
        Me.LayoutShipingRuleID.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutShipingRuleID.Text = "เงื่อนไขการขนส่ง"
        Me.LayoutShipingRuleID.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutTotalTax
        '
        Me.LayoutTotalTax.Control = Me.TotalTax
        Me.LayoutTotalTax.CustomizationFormText = "หักภาษี"
        Me.LayoutTotalTax.Location = New System.Drawing.Point(580, 624)
        Me.LayoutTotalTax.MaxSize = New System.Drawing.Size(315, 24)
        Me.LayoutTotalTax.MinSize = New System.Drawing.Size(315, 24)
        Me.LayoutTotalTax.Name = "LayoutTotalTax"
        Me.LayoutTotalTax.Size = New System.Drawing.Size(315, 24)
        Me.LayoutTotalTax.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutTotalTax.Text = "หักภาษี"
        Me.LayoutTotalTax.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutGrandTotal
        '
        Me.LayoutGrandTotal.Control = Me.GrandTotal
        Me.LayoutGrandTotal.CustomizationFormText = "ยอดรวมทั้งสิ้น"
        Me.LayoutGrandTotal.Location = New System.Drawing.Point(580, 648)
        Me.LayoutGrandTotal.MaxSize = New System.Drawing.Size(315, 26)
        Me.LayoutGrandTotal.MinSize = New System.Drawing.Size(315, 26)
        Me.LayoutGrandTotal.Name = "LayoutGrandTotal"
        Me.LayoutGrandTotal.Size = New System.Drawing.Size(315, 26)
        Me.LayoutGrandTotal.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutGrandTotal.Text = "ยอดรวมทั้งสิ้น"
        Me.LayoutGrandTotal.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutInvoiceSuplierID
        '
        Me.LayoutInvoiceSuplierID.Control = Me.InvoiceSuplierID
        Me.LayoutInvoiceSuplierID.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutInvoiceSuplierID.Location = New System.Drawing.Point(451, 48)
        Me.LayoutInvoiceSuplierID.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayoutInvoiceSuplierID.MinSize = New System.Drawing.Size(159, 24)
        Me.LayoutInvoiceSuplierID.Name = "LayoutInvoiceSuplierID"
        Me.LayoutInvoiceSuplierID.Size = New System.Drawing.Size(412, 24)
        Me.LayoutInvoiceSuplierID.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutInvoiceSuplierID.Text = "ใบกำกับภาษีเจ้าหนี้"
        Me.LayoutInvoiceSuplierID.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutInvoiceSuplierID2
        '
        Me.LayoutInvoiceSuplierID2.AllowHotTrack = False
        Me.LayoutInvoiceSuplierID2.CustomizationFormText = "LayoutInvoiceSuplierID2"
        Me.LayoutInvoiceSuplierID2.Location = New System.Drawing.Point(865, 48)
        Me.LayoutInvoiceSuplierID2.MaxSize = New System.Drawing.Size(30, 24)
        Me.LayoutInvoiceSuplierID2.MinSize = New System.Drawing.Size(30, 24)
        Me.LayoutInvoiceSuplierID2.Name = "LayoutInvoiceSuplierID2"
        Me.LayoutInvoiceSuplierID2.Size = New System.Drawing.Size(30, 24)
        Me.LayoutInvoiceSuplierID2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutInvoiceSuplierID2.Text = "LayoutInvoiceSuplierID2"
        Me.LayoutInvoiceSuplierID2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutInstitute
        '
        Me.LayoutInstitute.Control = Me.Institute
        Me.LayoutInstitute.CustomizationFormText = "หน่วยงาน"
        Me.LayoutInstitute.Location = New System.Drawing.Point(0, 48)
        Me.LayoutInstitute.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayoutInstitute.MinSize = New System.Drawing.Size(159, 24)
        Me.LayoutInstitute.Name = "LayoutInstitute"
        Me.LayoutInstitute.Size = New System.Drawing.Size(417, 24)
        Me.LayoutInstitute.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutInstitute.Text = "หน่วยงาน"
        Me.LayoutInstitute.TextSize = New System.Drawing.Size(102, 13)
        '
        'EmptySpaceItem10
        '
        Me.EmptySpaceItem10.AllowHotTrack = False
        Me.EmptySpaceItem10.CustomizationFormText = "EmptySpaceItem10"
        Me.EmptySpaceItem10.Location = New System.Drawing.Point(419, 50)
        Me.EmptySpaceItem10.MaxSize = New System.Drawing.Size(30, 24)
        Me.EmptySpaceItem10.MinSize = New System.Drawing.Size(30, 24)
        Me.EmptySpaceItem10.Name = "EmptySpaceItem10"
        Me.EmptySpaceItem10.Size = New System.Drawing.Size(30, 24)
        Me.EmptySpaceItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem10.Text = "EmptySpaceItem10"
        Me.EmptySpaceItem10.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutStockType
        '
        Me.LayoutStockType.Control = Me.StockType
        Me.LayoutStockType.CustomizationFormText = "การตัดสต๊อก"
        Me.LayoutStockType.Location = New System.Drawing.Point(451, 293)
        Me.LayoutStockType.MaxSize = New System.Drawing.Size(0, 29)
        Me.LayoutStockType.MinSize = New System.Drawing.Size(159, 29)
        Me.LayoutStockType.Name = "LayoutStockType"
        Me.LayoutStockType.Size = New System.Drawing.Size(412, 29)
        Me.LayoutStockType.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutStockType.Text = "การตัดสต๊อก"
        Me.LayoutStockType.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutRefPO
        '
        Me.LayoutRefPO.Control = Me.txtRefPO
        Me.LayoutRefPO.CustomizationFormText = "LayoutRefPO"
        Me.LayoutRefPO.Location = New System.Drawing.Point(451, 245)
        Me.LayoutRefPO.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayoutRefPO.MinSize = New System.Drawing.Size(159, 24)
        Me.LayoutRefPO.Name = "LayoutRefPO"
        Me.LayoutRefPO.Size = New System.Drawing.Size(412, 24)
        Me.LayoutRefPO.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutRefPO.Text = "อ้างอิงใบสั่งจอง"
        Me.LayoutRefPO.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutStockType2
        '
        Me.LayoutStockType2.AllowHotTrack = False
        Me.LayoutStockType2.CustomizationFormText = "EmptySpaceItem8"
        Me.LayoutStockType2.Location = New System.Drawing.Point(865, 297)
        Me.LayoutStockType2.MaxSize = New System.Drawing.Size(30, 26)
        Me.LayoutStockType2.MinSize = New System.Drawing.Size(30, 26)
        Me.LayoutStockType2.Name = "LayoutStockType2"
        Me.LayoutStockType2.Size = New System.Drawing.Size(30, 26)
        Me.LayoutStockType2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutStockType2.Text = "LayoutStockType2"
        Me.LayoutStockType2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutRefPO1
        '
        Me.LayoutRefPO1.AllowHotTrack = False
        Me.LayoutRefPO1.CustomizationFormText = "LayoutRefPO1"
        Me.LayoutRefPO1.Location = New System.Drawing.Point(865, 247)
        Me.LayoutRefPO1.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayoutRefPO1.MinSize = New System.Drawing.Size(10, 24)
        Me.LayoutRefPO1.Name = "LayoutRefPO1"
        Me.LayoutRefPO1.Size = New System.Drawing.Size(30, 24)
        Me.LayoutRefPO1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutRefPO1.Text = "LayoutRefPO1"
        Me.LayoutRefPO1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.chkIsEditVat
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(580, 600)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(23, 24)
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutQuotationRemark
        '
        Me.LayoutQuotationRemark.Control = Me.QuotationRemark
        Me.LayoutQuotationRemark.CustomizationFormText = "หมายเหตุใบเสนอราคา"
        Me.LayoutQuotationRemark.Location = New System.Drawing.Point(0, 238)
        Me.LayoutQuotationRemark.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayoutQuotationRemark.MinSize = New System.Drawing.Size(159, 24)
        Me.LayoutQuotationRemark.Name = "LayoutQuotationRemark"
        Me.LayoutQuotationRemark.Size = New System.Drawing.Size(417, 24)
        Me.LayoutQuotationRemark.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutQuotationRemark.Text = "หมายเหตุใบเสนอราคา"
        Me.LayoutQuotationRemark.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutbtnQuotationRemark
        '
        Me.LayoutbtnQuotationRemark.Control = Me.btnQuotationRemark
        Me.LayoutbtnQuotationRemark.CustomizationFormText = "LayoutbtnQuotationRemark"
        Me.LayoutbtnQuotationRemark.Location = New System.Drawing.Point(419, 236)
        Me.LayoutbtnQuotationRemark.Name = "LayoutbtnQuotationRemark"
        Me.LayoutbtnQuotationRemark.Size = New System.Drawing.Size(30, 26)
        Me.LayoutbtnQuotationRemark.Text = "LayoutbtnQuotationRemark"
        Me.LayoutbtnQuotationRemark.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutbtnQuotationRemark.TextToControlDistance = 0
        Me.LayoutbtnQuotationRemark.TextVisible = False
        '
        'LayoutNotPass
        '
        Me.LayoutNotPass.Control = Me.chkNotPass
        Me.LayoutNotPass.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutNotPass.Location = New System.Drawing.Point(0, 167)
        Me.LayoutNotPass.Name = "LayoutNotPass"
        Me.LayoutNotPass.Size = New System.Drawing.Size(108, 23)
        Me.LayoutNotPass.Text = "LayoutNotPass"
        Me.LayoutNotPass.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutNotPass.TextToControlDistance = 0
        Me.LayoutNotPass.TextVisible = False
        '
        'LayoutbtnCampaign
        '
        Me.LayoutbtnCampaign.Control = Me.btnCampaign
        Me.LayoutbtnCampaign.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutbtnCampaign.Location = New System.Drawing.Point(419, 262)
        Me.LayoutbtnCampaign.MaxSize = New System.Drawing.Size(30, 26)
        Me.LayoutbtnCampaign.MinSize = New System.Drawing.Size(30, 26)
        Me.LayoutbtnCampaign.Name = "LayoutbtnCampaign"
        Me.LayoutbtnCampaign.Size = New System.Drawing.Size(30, 26)
        Me.LayoutbtnCampaign.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutbtnCampaign.Text = "LayoutbtnCampaign"
        Me.LayoutbtnCampaign.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutbtnCampaign.TextToControlDistance = 0
        Me.LayoutbtnCampaign.TextVisible = False
        '
        'LayoutCampaign
        '
        Me.LayoutCampaign.Control = Me.Campaign
        Me.LayoutCampaign.CustomizationFormText = "Campaign"
        Me.LayoutCampaign.Location = New System.Drawing.Point(0, 262)
        Me.LayoutCampaign.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayoutCampaign.MinSize = New System.Drawing.Size(159, 24)
        Me.LayoutCampaign.Name = "LayoutCampaign"
        Me.LayoutCampaign.Size = New System.Drawing.Size(417, 24)
        Me.LayoutCampaign.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutCampaign.Text = "Campaign"
        Me.LayoutCampaign.TextSize = New System.Drawing.Size(102, 13)
        '
        'SplitterItem1
        '
        Me.SplitterItem1.AllowHotTrack = True
        Me.SplitterItem1.CustomizationFormText = "SplitterItem1"
        Me.SplitterItem1.Location = New System.Drawing.Point(895, 0)
        Me.SplitterItem1.Name = "SplitterItem1"
        Me.SplitterItem1.Size = New System.Drawing.Size(6, 674)
        '
        'LayoutControlProduct
        '
        Me.LayoutControlProduct.Control = Me.XtraTabControl2
        Me.LayoutControlProduct.CustomizationFormText = "LayoutControlProduct"
        Me.LayoutControlProduct.Location = New System.Drawing.Point(0, 367)
        Me.LayoutControlProduct.MinSize = New System.Drawing.Size(104, 150)
        Me.LayoutControlProduct.Name = "LayoutControlProduct"
        Me.LayoutControlProduct.Size = New System.Drawing.Size(895, 158)
        Me.LayoutControlProduct.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlProduct.Text = "LayoutControlProduct"
        Me.LayoutControlProduct.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlProduct.TextToControlDistance = 0
        Me.LayoutControlProduct.TextVisible = False
        '
        'LayoutClaimRemark
        '
        Me.LayoutClaimRemark.Control = Me.ClaimRemark
        Me.LayoutClaimRemark.CustomizationFormText = "อาการ/สาเหตุ"
        Me.LayoutClaimRemark.Location = New System.Drawing.Point(0, 315)
        Me.LayoutClaimRemark.MaxSize = New System.Drawing.Size(0, 38)
        Me.LayoutClaimRemark.MinSize = New System.Drawing.Size(119, 38)
        Me.LayoutClaimRemark.Name = "LayoutClaimRemark"
        Me.LayoutClaimRemark.Size = New System.Drawing.Size(417, 38)
        Me.LayoutClaimRemark.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutClaimRemark.Text = "อาการ/สาเหตุ"
        Me.LayoutClaimRemark.TextSize = New System.Drawing.Size(102, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 674)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(901, 32)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(419, 355)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(30, 10)
        Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(451, 322)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(412, 43)
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem9
        '
        Me.EmptySpaceItem9.AllowHotTrack = False
        Me.EmptySpaceItem9.CustomizationFormText = "EmptySpaceItem9"
        Me.EmptySpaceItem9.Location = New System.Drawing.Point(865, 323)
        Me.EmptySpaceItem9.Name = "EmptySpaceItem9"
        Me.EmptySpaceItem9.Size = New System.Drawing.Size(30, 42)
        Me.EmptySpaceItem9.Text = "EmptySpaceItem9"
        Me.EmptySpaceItem9.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutClaimResult
        '
        Me.LayoutClaimResult.Control = Me.ClaimResult
        Me.LayoutClaimResult.CustomizationFormText = "ผลการเคลม"
        Me.LayoutClaimResult.Location = New System.Drawing.Point(0, 286)
        Me.LayoutClaimResult.MaxSize = New System.Drawing.Size(0, 29)
        Me.LayoutClaimResult.MinSize = New System.Drawing.Size(159, 29)
        Me.LayoutClaimResult.Name = "LayoutClaimResult"
        Me.LayoutClaimResult.Size = New System.Drawing.Size(417, 29)
        Me.LayoutClaimResult.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutClaimResult.Text = "ผลการเคลม"
        Me.LayoutClaimResult.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutClaimResult2
        '
        Me.LayoutClaimResult2.AllowHotTrack = False
        Me.LayoutClaimResult2.CustomizationFormText = "LayoutClaimResult2"
        Me.LayoutClaimResult2.Location = New System.Drawing.Point(419, 288)
        Me.LayoutClaimResult2.MaxSize = New System.Drawing.Size(30, 29)
        Me.LayoutClaimResult2.MinSize = New System.Drawing.Size(30, 29)
        Me.LayoutClaimResult2.Name = "LayoutClaimResult2"
        Me.LayoutClaimResult2.Size = New System.Drawing.Size(30, 29)
        Me.LayoutClaimResult2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutClaimResult2.Text = "LayoutClaimResult2"
        Me.LayoutClaimResult2.TextSize = New System.Drawing.Size(0, 0)
        '
        'PledgeTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.PledgeTabPage, "")
        Me.PledgeTabPage.Controls.Add(Me.UcPledge1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.PledgeTabPage, True)
        Me.PledgeTabPage.Name = "PledgeTabPage"
        Me.PledgeTabPage.Size = New System.Drawing.Size(921, 726)
        Me.PledgeTabPage.Text = "รายการมัดจำ"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.PledgeTabPage, "")
        '
        'UcPledge1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.UcPledge1, "")
        Me.UcPledge1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcPledge1.Location = New System.Drawing.Point(0, 0)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.UcPledge1, True)
        Me.UcPledge1.Name = "UcPledge1"
        Me.UcPledge1.Size = New System.Drawing.Size(921, 726)
        Me.UcPledge1.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcPledge1, "")
        '
        'TaxTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.TaxTabPage, "")
        Me.TaxTabPage.Controls.Add(Me.TaxGroup)
        Me.TaxTabPage.Controls.Add(Me.TaxGroup1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.TaxTabPage, True)
        Me.TaxTabPage.Name = "TaxTabPage"
        Me.TaxTabPage.Size = New System.Drawing.Size(921, 726)
        Me.TaxTabPage.Text = "การยื่นภาษี"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.TaxTabPage, "")
        '
        'TaxGroup
        '
        Me.TaxGroup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TaxGroup.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaxGroup.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.TaxGroup, "")
        Me.TaxGroup.Controls.Add(Me.GridTaxOrder)
        Me.TaxGroup.Controls.Add(Me.TaxSection)
        Me.TaxGroup.Controls.Add(Me.Label10)
        Me.TaxGroup.Controls.Add(Me.TaxCondition)
        Me.TaxGroup.Controls.Add(Me.Label9)
        Me.TaxGroup.Controls.Add(Me.TaxCusCardID)
        Me.TaxGroup.Controls.Add(Me.Label8)
        Me.TaxGroup.Controls.Add(Me.TaxCusTaxNo)
        Me.TaxGroup.Controls.Add(Me.Label7)
        Me.TaxGroup.Controls.Add(Me.TaxCusAddress)
        Me.TaxGroup.Controls.Add(Me.Label6)
        Me.TaxGroup.Controls.Add(Me.Label5)
        Me.TaxGroup.Controls.Add(Me.TaxCusname)
        Me.TaxGroup.Controls.Add(Me.TaxType)
        Me.TaxGroup.Controls.Add(Me.TaxNumber)
        Me.TaxGroup.Controls.Add(Me.Label4)
        Me.TaxGroup.Controls.Add(Me.Label3)
        Me.TaxGroup.Location = New System.Drawing.Point(45, 141)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.TaxGroup, True)
        Me.TaxGroup.Name = "TaxGroup"
        Me.TaxGroup.Size = New System.Drawing.Size(787, 391)
        Me.TaxGroup.TabIndex = 2
        Me.TaxGroup.Text = "รายละเอียดการหักภาษี ณ ที่จ่าย"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.TaxGroup, "")
        '
        'GridTaxOrder
        '
        Me.GridTaxOrder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.GridTaxOrder, "")
        Me.GridTaxOrder.Location = New System.Drawing.Point(26, 196)
        Me.GridTaxOrder.MainView = Me.GridView3
        Me.FormChangedComponent1.SetMonitorForChanges(Me.GridTaxOrder, True)
        Me.GridTaxOrder.Name = "GridTaxOrder"
        Me.GridTaxOrder.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.TaxTypeIDLookUp, Me.RepositoryItemCalcEdit1, Me.RepositoryItemSpinEdit1, Me.RepositoryItemTextEdit1, Me.RepositoryItemCalcEdit2})
        Me.GridTaxOrder.Size = New System.Drawing.Size(742, 190)
        Me.GridTaxOrder.TabIndex = 281
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.GridTaxOrder, "")
        Me.GridTaxOrder.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.TaxTypeID, Me.TaxTotal, Me.TaxRate, Me.TaxAmount, Me.TaxOrderID, Me.OtherTax})
        Me.GridView3.GridControl = Me.GridTaxOrder
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView3.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView3.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView3.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'TaxTypeID
        '
        Me.TaxTypeID.Caption = "ประเภทเงินได้"
        Me.TaxTypeID.ColumnEdit = Me.TaxTypeIDLookUp
        Me.TaxTypeID.FieldName = "TaxTypeID"
        Me.TaxTypeID.MinWidth = 150
        Me.TaxTypeID.Name = "TaxTypeID"
        Me.TaxTypeID.Visible = True
        Me.TaxTypeID.VisibleIndex = 0
        Me.TaxTypeID.Width = 150
        '
        'TaxTypeIDLookUp
        '
        Me.TaxTypeIDLookUp.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.TaxTypeIDLookUp.AutoHeight = False
        Me.TaxTypeIDLookUp.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TaxTypeIDLookUp.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "Name1", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeThai", "Name2"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeEng", "Name3", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Remark", "Name4", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.TaxTypeIDLookUp.DisplayMember = "CodeThai"
        Me.TaxTypeIDLookUp.Name = "TaxTypeIDLookUp"
        Me.TaxTypeIDLookUp.NullText = ""
        Me.TaxTypeIDLookUp.NullValuePromptShowForEmptyValue = True
        Me.TaxTypeIDLookUp.ShowFooter = False
        Me.TaxTypeIDLookUp.ShowHeader = False
        Me.TaxTypeIDLookUp.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TaxTypeIDLookUp.ValueMember = "ID"
        '
        'TaxTotal
        '
        Me.TaxTotal.Caption = "จำนวนเงิน"
        Me.TaxTotal.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.TaxTotal.DisplayFormat.FormatString = "n2"
        Me.TaxTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TaxTotal.FieldName = "TaxTotal"
        Me.TaxTotal.GroupFormat.FormatString = "n2"
        Me.TaxTotal.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TaxTotal.MaxWidth = 100
        Me.TaxTotal.Name = "TaxTotal"
        Me.TaxTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.TaxTotal.Visible = True
        Me.TaxTotal.VisibleIndex = 1
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.DisplayFormat.FormatString = "n2"
        Me.RepositoryItemCalcEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemCalcEdit1.EditFormat.FormatString = "n2"
        Me.RepositoryItemCalcEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'TaxRate
        '
        Me.TaxRate.Caption = "อัตราภาษี %"
        Me.TaxRate.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.TaxRate.DisplayFormat.FormatString = "n2"
        Me.TaxRate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TaxRate.FieldName = "TaxRate"
        Me.TaxRate.GroupFormat.FormatString = "n2"
        Me.TaxRate.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TaxRate.MaxWidth = 80
        Me.TaxRate.Name = "TaxRate"
        Me.TaxRate.Visible = True
        Me.TaxRate.VisibleIndex = 2
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemSpinEdit1.DisplayFormat.FormatString = "n2"
        Me.RepositoryItemSpinEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemSpinEdit1.EditFormat.FormatString = "n2"
        Me.RepositoryItemSpinEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'TaxAmount
        '
        Me.TaxAmount.Caption = "มูลค่าภาษี"
        Me.TaxAmount.ColumnEdit = Me.RepositoryItemCalcEdit2
        Me.TaxAmount.DisplayFormat.FormatString = "n2"
        Me.TaxAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TaxAmount.FieldName = "TaxAmount"
        Me.TaxAmount.GroupFormat.FormatString = "n2"
        Me.TaxAmount.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TaxAmount.MaxWidth = 100
        Me.TaxAmount.Name = "TaxAmount"
        Me.TaxAmount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.TaxAmount.Visible = True
        Me.TaxAmount.VisibleIndex = 3
        '
        'RepositoryItemCalcEdit2
        '
        Me.RepositoryItemCalcEdit2.AutoHeight = False
        Me.RepositoryItemCalcEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit2.DisplayFormat.FormatString = "n2"
        Me.RepositoryItemCalcEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemCalcEdit2.EditFormat.FormatString = "n2"
        Me.RepositoryItemCalcEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemCalcEdit2.Name = "RepositoryItemCalcEdit2"
        '
        'TaxOrderID
        '
        Me.TaxOrderID.Caption = "TaxOrderID"
        Me.TaxOrderID.FieldName = "TaxOrderID"
        Me.TaxOrderID.Name = "TaxOrderID"
        '
        'OtherTax
        '
        Me.OtherTax.Caption = "GridColumn2"
        Me.OtherTax.FieldName = "OtherTax"
        Me.OtherTax.Name = "OtherTax"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'TaxSection
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.TaxSection, "TextChanged")
        Me.TaxSection.EditValue = "มาตรา 69 ทวิ"
        Me.TaxSection.EnterMoveNextControl = True
        Me.TaxSection.Location = New System.Drawing.Point(390, 170)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.TaxSection, True)
        Me.TaxSection.Name = "TaxSection"
        Me.TaxSection.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TaxSection.Properties.Appearance.Options.UseFont = True
        Me.TaxSection.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TaxSection.Properties.ImmediatePopup = True
        Me.TaxSection.Properties.Items.AddRange(New Object() {"มาตรา 2 เตรส", "มาตรา 65 จัตวา", "มาตรา 69 ทวิ"})
        Me.TaxSection.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.TaxSection.Properties.UseCtrlScroll = True
        Me.TaxSection.Size = New System.Drawing.Size(158, 20)
        Me.TaxSection.TabIndex = 271
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.TaxSection, "Text")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label10, "")
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(292, 173)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label10, True)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 14)
        Me.Label10.TabIndex = 270
        Me.Label10.Text = "ตามมาตรา"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label10, "")
        '
        'TaxCondition
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.TaxCondition, "TextChanged")
        Me.TaxCondition.EditValue = "หัก ณ ที่จ่าย"
        Me.TaxCondition.EnterMoveNextControl = True
        Me.TaxCondition.Location = New System.Drawing.Point(132, 170)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.TaxCondition, True)
        Me.TaxCondition.Name = "TaxCondition"
        Me.TaxCondition.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TaxCondition.Properties.Appearance.Options.UseFont = True
        Me.TaxCondition.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TaxCondition.Properties.ImmediatePopup = True
        Me.TaxCondition.Properties.Items.AddRange(New Object() {"หัก ณ ที่จ่าย", "ออกภาษีให้"})
        Me.TaxCondition.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.TaxCondition.Properties.UseCtrlScroll = True
        Me.TaxCondition.Size = New System.Drawing.Size(154, 20)
        Me.TaxCondition.TabIndex = 269
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.TaxCondition, "Text")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label9, "")
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(23, 173)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label9, True)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 14)
        Me.Label9.TabIndex = 268
        Me.Label9.Text = "เงื่อนไขการหัก"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label9, "")
        '
        'TaxCusCardID
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.TaxCusCardID, "TextChanged")
        Me.TaxCusCardID.EnterMoveNextControl = True
        Me.TaxCusCardID.Location = New System.Drawing.Point(390, 143)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.TaxCusCardID, True)
        Me.TaxCusCardID.Name = "TaxCusCardID"
        Me.TaxCusCardID.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.TaxCusCardID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TaxCusCardID.Properties.Appearance.Options.UseBackColor = True
        Me.TaxCusCardID.Properties.Appearance.Options.UseFont = True
        Me.TaxCusCardID.Properties.MaxLength = 50
        Me.TaxCusCardID.Properties.ReadOnly = True
        Me.TaxCusCardID.Properties.ValidateOnEnterKey = True
        Me.TaxCusCardID.Size = New System.Drawing.Size(158, 20)
        Me.TaxCusCardID.StyleController = Me.LayoutControl1
        Me.TaxCusCardID.TabIndex = 267
        Me.TaxCusCardID.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.TaxCusCardID, "Text")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label8, "")
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(292, 146)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label8, True)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 14)
        Me.Label8.TabIndex = 266
        Me.Label8.Text = "เลขบัตรประชาชน"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label8, "")
        '
        'TaxCusTaxNo
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.TaxCusTaxNo, "TextChanged")
        Me.TaxCusTaxNo.EnterMoveNextControl = True
        Me.TaxCusTaxNo.Location = New System.Drawing.Point(132, 143)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.TaxCusTaxNo, True)
        Me.TaxCusTaxNo.Name = "TaxCusTaxNo"
        Me.TaxCusTaxNo.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.TaxCusTaxNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TaxCusTaxNo.Properties.Appearance.Options.UseBackColor = True
        Me.TaxCusTaxNo.Properties.Appearance.Options.UseFont = True
        Me.TaxCusTaxNo.Properties.MaxLength = 50
        Me.TaxCusTaxNo.Properties.ReadOnly = True
        Me.TaxCusTaxNo.Properties.ValidateOnEnterKey = True
        Me.TaxCusTaxNo.Size = New System.Drawing.Size(154, 20)
        Me.TaxCusTaxNo.StyleController = Me.LayoutControl1
        Me.TaxCusTaxNo.TabIndex = 265
        Me.TaxCusTaxNo.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.TaxCusTaxNo, "Text")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label7, "")
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 146)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label7, True)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 14)
        Me.Label7.TabIndex = 264
        Me.Label7.Text = "เลขผู้เสียภาษี"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label7, "")
        '
        'TaxCusAddress
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.TaxCusAddress, "TextChanged")
        Me.TaxCusAddress.EnterMoveNextControl = True
        Me.TaxCusAddress.Location = New System.Drawing.Point(132, 116)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.TaxCusAddress, True)
        Me.TaxCusAddress.Name = "TaxCusAddress"
        Me.TaxCusAddress.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.TaxCusAddress.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TaxCusAddress.Properties.Appearance.Options.UseBackColor = True
        Me.TaxCusAddress.Properties.Appearance.Options.UseFont = True
        Me.TaxCusAddress.Properties.MaxLength = 50
        Me.TaxCusAddress.Properties.ReadOnly = True
        Me.TaxCusAddress.Properties.ValidateOnEnterKey = True
        Me.TaxCusAddress.Size = New System.Drawing.Size(416, 20)
        Me.TaxCusAddress.StyleController = Me.LayoutControl1
        Me.TaxCusAddress.TabIndex = 263
        Me.TaxCusAddress.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.TaxCusAddress, "Text")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label6, "")
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 119)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label6, True)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 14)
        Me.Label6.TabIndex = 262
        Me.Label6.Text = "ที่อยู่"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label6, "")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label5, "")
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 92)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label5, True)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 14)
        Me.Label5.TabIndex = 261
        Me.Label5.Text = "ผู้ถูกหัก"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label5, "")
        '
        'TaxCusname
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.TaxCusname, "TextChanged")
        Me.TaxCusname.EnterMoveNextControl = True
        Me.TaxCusname.Location = New System.Drawing.Point(132, 89)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.TaxCusname, True)
        Me.TaxCusname.Name = "TaxCusname"
        Me.TaxCusname.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.TaxCusname.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TaxCusname.Properties.Appearance.Options.UseBackColor = True
        Me.TaxCusname.Properties.Appearance.Options.UseFont = True
        Me.TaxCusname.Properties.MaxLength = 50
        Me.TaxCusname.Properties.ReadOnly = True
        Me.TaxCusname.Properties.ValidateOnEnterKey = True
        Me.TaxCusname.Size = New System.Drawing.Size(416, 20)
        Me.TaxCusname.StyleController = Me.LayoutControl1
        Me.TaxCusname.TabIndex = 260
        Me.TaxCusname.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.TaxCusname, "Text")
        '
        'TaxType
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.TaxType, "TextChanged")
        Me.TaxType.EditValue = "ใบภาษีหัก ณ ที่จ่าย บริษัทถูกหัก ไม่นำส่งแต่ไว้ตรวจสอบรายการ"
        Me.TaxType.EnterMoveNextControl = True
        Me.TaxType.Location = New System.Drawing.Point(132, 37)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.TaxType, True)
        Me.TaxType.Name = "TaxType"
        Me.TaxType.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TaxType.Properties.Appearance.Options.UseFont = True
        Me.TaxType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TaxType.Properties.ImmediatePopup = True
        Me.TaxType.Properties.Items.AddRange(New Object() {"ใบภาษีหัก ณ ที่จ่าย บริษัทถูกหัก ไม่นำส่งแต่ไว้ตรวจสอบรายการ", "ใบภาษีหัก ณ ที่จ่าย บุคคลธรรมดาถูกหัก ไม่ต้องนำส่ง"})
        Me.TaxType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.TaxType.Properties.UseCtrlScroll = True
        Me.TaxType.Size = New System.Drawing.Size(416, 20)
        Me.TaxType.TabIndex = 176
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.TaxType, "Text")
        '
        'TaxNumber
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.TaxNumber, "TextChanged")
        Me.TaxNumber.EnterMoveNextControl = True
        Me.TaxNumber.Location = New System.Drawing.Point(132, 62)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.TaxNumber, True)
        Me.TaxNumber.Name = "TaxNumber"
        Me.TaxNumber.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TaxNumber.Properties.Appearance.Options.UseFont = True
        Me.TaxNumber.Properties.MaxLength = 50
        Me.TaxNumber.Properties.ValidateOnEnterKey = True
        Me.TaxNumber.Size = New System.Drawing.Size(416, 20)
        Me.TaxNumber.StyleController = Me.LayoutControl1
        Me.TaxNumber.TabIndex = 175
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.TaxNumber, "Text")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label4, "")
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 65)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label4, True)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 14)
        Me.Label4.TabIndex = 174
        Me.Label4.Text = "เลขที่"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label4, "")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label3, "")
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 40)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label3, True)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 14)
        Me.Label3.TabIndex = 173
        Me.Label3.Text = "ประเภทภาษี"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label3, "")
        '
        'TaxGroup1
        '
        Me.TaxGroup1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaxGroup1.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.TaxGroup1, "")
        Me.TaxGroup1.Controls.Add(Me.TaxMonthYear)
        Me.TaxGroup1.Controls.Add(Me.Label2)
        Me.TaxGroup1.Controls.Add(Me.TaxCanNo)
        Me.TaxGroup1.Controls.Add(Me.TaxCanYes)
        Me.TaxGroup1.Controls.Add(Me.Label1)
        Me.TaxGroup1.Controls.Add(Me.Label36)
        Me.TaxGroup1.Controls.Add(Me.TaxRemark)
        Me.TaxGroup1.Location = New System.Drawing.Point(45, 16)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.TaxGroup1, True)
        Me.TaxGroup1.Name = "TaxGroup1"
        Me.TaxGroup1.Size = New System.Drawing.Size(787, 119)
        Me.TaxGroup1.TabIndex = 1
        Me.TaxGroup1.Text = "การยื่นภาษี"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.TaxGroup1, "")
        '
        'TaxMonthYear
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.TaxMonthYear, "TextChanged")
        Me.TaxMonthYear.EditValue = New Date(2013, 10, 8, 23, 38, 26, 0)
        Me.TaxMonthYear.Location = New System.Drawing.Point(132, 82)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.TaxMonthYear, True)
        Me.TaxMonthYear.Name = "TaxMonthYear"
        Me.TaxMonthYear.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TaxMonthYear.Properties.DisplayFormat.FormatString = "MM/yyyy"
        Me.TaxMonthYear.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.TaxMonthYear.Properties.Mask.EditMask = "MM/yyyy"
        Me.TaxMonthYear.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TaxMonthYear.Size = New System.Drawing.Size(113, 20)
        Me.TaxMonthYear.TabIndex = 176
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.TaxMonthYear, "Text")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label2, "")
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 85)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label2, True)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 14)
        Me.Label2.TabIndex = 175
        Me.Label2.Text = "ยื่นภาษี (เดือน/ปี)"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label2, "")
        '
        'TaxCanNo
        '
        Me.TaxCanNo.AutoSize = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.TaxCanNo, "")
        Me.TaxCanNo.Location = New System.Drawing.Point(194, 56)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.TaxCanNo, True)
        Me.TaxCanNo.Name = "TaxCanNo"
        Me.TaxCanNo.Size = New System.Drawing.Size(51, 17)
        Me.TaxCanNo.TabIndex = 174
        Me.TaxCanNo.Text = "ไม่ได้"
        Me.TaxCanNo.UseVisualStyleBackColor = True
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.TaxCanNo, "")
        '
        'TaxCanYes
        '
        Me.TaxCanYes.AutoSize = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.TaxCanYes, "")
        Me.TaxCanYes.Checked = True
        Me.TaxCanYes.Location = New System.Drawing.Point(132, 56)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.TaxCanYes, True)
        Me.TaxCanYes.Name = "TaxCanYes"
        Me.TaxCanYes.Size = New System.Drawing.Size(38, 17)
        Me.TaxCanYes.TabIndex = 173
        Me.TaxCanYes.TabStop = True
        Me.TaxCanYes.Text = "ได้"
        Me.TaxCanYes.UseVisualStyleBackColor = True
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.TaxCanYes, "")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label1, "")
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 57)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label1, True)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 14)
        Me.Label1.TabIndex = 172
        Me.Label1.Text = "ขอคืนภาษี"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label1, "")
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label36, "")
        Me.Label36.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label36.Location = New System.Drawing.Point(23, 32)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label36, True)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(62, 14)
        Me.Label36.TabIndex = 171
        Me.Label36.Text = "รายละเอียด"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label36, "")
        '
        'TaxRemark
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.TaxRemark, "TextChanged")
        Me.TaxRemark.EnterMoveNextControl = True
        Me.TaxRemark.Location = New System.Drawing.Point(132, 29)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.TaxRemark, True)
        Me.TaxRemark.Name = "TaxRemark"
        Me.TaxRemark.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TaxRemark.Properties.Appearance.Options.UseFont = True
        Me.TaxRemark.Properties.MaxLength = 50
        Me.TaxRemark.Properties.ValidateOnEnterKey = True
        Me.TaxRemark.Size = New System.Drawing.Size(406, 20)
        Me.TaxRemark.StyleController = Me.LayoutControl1
        Me.TaxRemark.TabIndex = 1
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.TaxRemark, "Text")
        '
        'RemarkTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.RemarkTabPage, "")
        Me.RemarkTabPage.Controls.Add(Me.Remark)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.RemarkTabPage, True)
        Me.RemarkTabPage.Name = "RemarkTabPage"
        Me.RemarkTabPage.Size = New System.Drawing.Size(921, 726)
        Me.RemarkTabPage.Text = "รายละเอียด"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.RemarkTabPage, "")
        '
        'Remark
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Remark, "TextChanged")
        Me.Remark.EnterMoveNextControl = True
        Me.Remark.Location = New System.Drawing.Point(11, 14)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Remark, True)
        Me.Remark.Name = "Remark"
        Me.Remark.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Remark.Properties.Appearance.Options.UseFont = True
        Me.Remark.Properties.MaxLength = 500
        Me.Remark.Size = New System.Drawing.Size(883, 277)
        Me.Remark.TabIndex = 9
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Remark, "Text")
        '
        'NoteTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.NoteTabPage, "")
        Me.NoteTabPage.Controls.Add(Me.UcNote1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.NoteTabPage, True)
        Me.NoteTabPage.Name = "NoteTabPage"
        Me.NoteTabPage.Size = New System.Drawing.Size(921, 726)
        Me.NoteTabPage.Text = "บันทึกข้อความ"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.NoteTabPage, "")
        '
        'UcNote1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.UcNote1, "")
        Me.UcNote1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcNote1.Location = New System.Drawing.Point(0, 0)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.UcNote1, True)
        Me.UcNote1.Name = "UcNote1"
        Me.UcNote1.Size = New System.Drawing.Size(921, 726)
        Me.UcNote1.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcNote1, "")
        '
        'AttachmentTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.AttachmentTabPage, "")
        Me.AttachmentTabPage.Controls.Add(Me.UcFileAttach1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.AttachmentTabPage, True)
        Me.AttachmentTabPage.Name = "AttachmentTabPage"
        Me.AttachmentTabPage.Size = New System.Drawing.Size(921, 726)
        Me.AttachmentTabPage.Text = "ไฟล์แนบ"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.AttachmentTabPage, "")
        '
        'UcFileAttach1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.UcFileAttach1, "")
        Me.UcFileAttach1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcFileAttach1.Location = New System.Drawing.Point(0, 0)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.UcFileAttach1, True)
        Me.UcFileAttach1.Name = "UcFileAttach1"
        Me.UcFileAttach1.Size = New System.Drawing.Size(921, 726)
        Me.UcFileAttach1.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcFileAttach1, "")
        '
        'AdminTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.AdminTabPage, "")
        Me.AdminTabPage.Controls.Add(Me.UcAdmin1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.AdminTabPage, True)
        Me.AdminTabPage.Name = "AdminTabPage"
        Me.AdminTabPage.Size = New System.Drawing.Size(921, 726)
        Me.AdminTabPage.Text = "ผู้บันทึก"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.AdminTabPage, "")
        '
        'UcAdmin1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.UcAdmin1, "")
        Me.UcAdmin1.Location = New System.Drawing.Point(71, 0)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.UcAdmin1, True)
        Me.UcAdmin1.Name = "UcAdmin1"
        Me.UcAdmin1.Size = New System.Drawing.Size(665, 223)
        Me.UcAdmin1.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcAdmin1, "")
        '
        'DockPanel1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.DockPanel1, "")
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel1.ID = New System.Guid("a7f23336-9ebd-4f72-ba02-b27dcac124bf")
        Me.DockPanel1.Location = New System.Drawing.Point(753, 37)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.DockPanel1, True)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.AllowDockAsTabbedDocument = False
        Me.DockPanel1.Options.AllowDockBottom = False
        Me.DockPanel1.Options.AllowDockFill = False
        Me.DockPanel1.Options.AllowDockLeft = False
        Me.DockPanel1.Options.AllowDockTop = False
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(296, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(296, 713)
        Me.DockPanel1.Text = "Order Information"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.DockPanel1, "")
        '
        'DockPanel1_Container
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.DockPanel1_Container, "")
        Me.DockPanel1_Container.Controls.Add(Me.PanelControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.DockPanel1_Container, True)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(288, 686)
        Me.DockPanel1_Container.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.DockPanel1_Container, "")
        '
        'PanelControl2
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.PanelControl2, "")
        Me.PanelControl2.Controls.Add(Me.PanelControl1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.PanelControl2, True)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(288, 686)
        Me.PanelControl2.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.PanelControl2, "")
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.PanelControl1, "")
        Me.PanelControl1.Controls.Add(Me.CalcEdit1)
        Me.PanelControl1.Controls.Add(Me.btnCalc)
        Me.PanelControl1.Controls.Add(Me.Panel6)
        Me.PanelControl1.Controls.Add(Me.Panel5)
        Me.PanelControl1.Controls.Add(Me.Panel4)
        Me.PanelControl1.Controls.Add(Me.Panel3)
        Me.PanelControl1.Controls.Add(Me.Panel2)
        Me.PanelControl1.Controls.Add(Me.Panel1)
        Me.PanelControl1.Location = New System.Drawing.Point(2, 7)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.PanelControl1, True)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(279, 301)
        Me.PanelControl1.TabIndex = 12
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.PanelControl1, "")
        '
        'CalcEdit1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.CalcEdit1, "TextChanged")
        Me.CalcEdit1.Location = New System.Drawing.Point(116, 255)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.CalcEdit1, True)
        Me.CalcEdit1.Name = "CalcEdit1"
        Me.CalcEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalcEdit1.Properties.Appearance.Options.UseFont = True
        Me.CalcEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CalcEdit1.Properties.DisplayFormat.FormatString = "n2"
        Me.CalcEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.CalcEdit1.Properties.EditFormat.FormatString = "n2"
        Me.CalcEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.CalcEdit1.Properties.ValidateOnEnterKey = True
        Me.CalcEdit1.Size = New System.Drawing.Size(151, 30)
        Me.CalcEdit1.TabIndex = 23
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.CalcEdit1, "Text")
        '
        'btnCalc
        '
        Me.btnCalc.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnCalc, "")
        Me.btnCalc.Image = CType(resources.GetObject("btnCalc.Image"), System.Drawing.Image)
        Me.btnCalc.Location = New System.Drawing.Point(12, 248)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnCalc, True)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(98, 44)
        Me.btnCalc.TabIndex = 22
        Me.btnCalc.TabStop = False
        Me.btnCalc.Text = "Calculator"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnCalc, "")
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel6.BackgroundImage = CType(resources.GetObject("Panel6.BackgroundImage"), System.Drawing.Image)
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Panel6, "")
        Me.Panel6.Controls.Add(Me.txtGrandTotal)
        Me.Panel6.Controls.Add(Me.LabelControl6)
        Me.Panel6.Location = New System.Drawing.Point(12, 198)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Panel6, True)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(255, 36)
        Me.Panel6.TabIndex = 21
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Panel6, "")
        '
        'txtGrandTotal
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtGrandTotal, "TextChanged")
        Me.txtGrandTotal.EditValue = "0.00"
        Me.txtGrandTotal.Location = New System.Drawing.Point(84, 3)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.txtGrandTotal, True)
        Me.txtGrandTotal.Name = "txtGrandTotal"
        Me.txtGrandTotal.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtGrandTotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrandTotal.Properties.Appearance.Options.UseBackColor = True
        Me.txtGrandTotal.Properties.Appearance.Options.UseFont = True
        Me.txtGrandTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtGrandTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtGrandTotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtGrandTotal.Size = New System.Drawing.Size(166, 28)
        Me.txtGrandTotal.TabIndex = 12
        Me.txtGrandTotal.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtGrandTotal, "Text")
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.White
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.LabelControl6, "")
        Me.LabelControl6.Location = New System.Drawing.Point(3, 12)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.LabelControl6, True)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(52, 14)
        Me.LabelControl6.TabIndex = 11
        Me.LabelControl6.Text = "รวมทั้งสิ้น"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.LabelControl6, "")
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel5.BackgroundImage = CType(resources.GetObject("Panel5.BackgroundImage"), System.Drawing.Image)
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Panel5, "")
        Me.Panel5.Controls.Add(Me.txtVat)
        Me.Panel5.Controls.Add(Me.LabelControl5)
        Me.Panel5.Location = New System.Drawing.Point(12, 160)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Panel5, True)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(255, 36)
        Me.Panel5.TabIndex = 20
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Panel5, "")
        '
        'txtVat
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtVat, "TextChanged")
        Me.txtVat.EditValue = "0.00"
        Me.txtVat.Location = New System.Drawing.Point(84, 3)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.txtVat, True)
        Me.txtVat.Name = "txtVat"
        Me.txtVat.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtVat.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVat.Properties.Appearance.Options.UseBackColor = True
        Me.txtVat.Properties.Appearance.Options.UseFont = True
        Me.txtVat.Properties.Appearance.Options.UseTextOptions = True
        Me.txtVat.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtVat.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtVat.Size = New System.Drawing.Size(166, 28)
        Me.txtVat.TabIndex = 12
        Me.txtVat.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtVat, "Text")
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.White
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.LabelControl5, "")
        Me.LabelControl5.Location = New System.Drawing.Point(3, 12)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.LabelControl5, True)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(23, 14)
        Me.LabelControl5.TabIndex = 11
        Me.LabelControl5.Text = "ภาษี"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.LabelControl5, "")
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Panel4, "")
        Me.Panel4.Controls.Add(Me.txtDiscount)
        Me.Panel4.Controls.Add(Me.LabelControl4)
        Me.Panel4.Location = New System.Drawing.Point(12, 126)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Panel4, True)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(255, 36)
        Me.Panel4.TabIndex = 19
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Panel4, "")
        '
        'txtDiscount
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtDiscount, "TextChanged")
        Me.txtDiscount.EditValue = "0.00"
        Me.txtDiscount.Location = New System.Drawing.Point(84, 3)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.txtDiscount, True)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtDiscount.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.Properties.Appearance.Options.UseBackColor = True
        Me.txtDiscount.Properties.Appearance.Options.UseFont = True
        Me.txtDiscount.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDiscount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDiscount.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtDiscount.Size = New System.Drawing.Size(166, 28)
        Me.txtDiscount.TabIndex = 12
        Me.txtDiscount.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtDiscount, "Text")
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.White
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.LabelControl4, "")
        Me.LabelControl4.Location = New System.Drawing.Point(3, 12)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.LabelControl4, True)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(38, 14)
        Me.LabelControl4.TabIndex = 11
        Me.LabelControl4.Text = "ส่วนลด"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.LabelControl4, "")
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Panel3, "")
        Me.Panel3.Controls.Add(Me.txtPledge)
        Me.Panel3.Controls.Add(Me.LabelControl3)
        Me.Panel3.Location = New System.Drawing.Point(12, 90)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Panel3, True)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(255, 36)
        Me.Panel3.TabIndex = 18
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Panel3, "")
        '
        'txtPledge
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtPledge, "TextChanged")
        Me.txtPledge.EditValue = "0.00"
        Me.txtPledge.Location = New System.Drawing.Point(84, 3)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.txtPledge, True)
        Me.txtPledge.Name = "txtPledge"
        Me.txtPledge.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtPledge.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPledge.Properties.Appearance.Options.UseBackColor = True
        Me.txtPledge.Properties.Appearance.Options.UseFont = True
        Me.txtPledge.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPledge.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPledge.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtPledge.Size = New System.Drawing.Size(166, 28)
        Me.txtPledge.TabIndex = 12
        Me.txtPledge.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtPledge, "Text")
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.White
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.LabelControl3, "")
        Me.LabelControl3.Location = New System.Drawing.Point(3, 12)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.LabelControl3, True)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(29, 14)
        Me.LabelControl3.TabIndex = 11
        Me.LabelControl3.Text = "มัดจำ"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.LabelControl3, "")
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Panel2, "")
        Me.Panel2.Controls.Add(Me.txtTotal)
        Me.Panel2.Controls.Add(Me.LabelControl2)
        Me.Panel2.Location = New System.Drawing.Point(12, 56)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Panel2, True)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(255, 36)
        Me.Panel2.TabIndex = 17
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Panel2, "")
        '
        'txtTotal
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtTotal, "TextChanged")
        Me.txtTotal.EditValue = "0.00"
        Me.txtTotal.Location = New System.Drawing.Point(84, 3)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.txtTotal, True)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtTotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotal.Properties.Appearance.Options.UseFont = True
        Me.txtTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtTotal.Size = New System.Drawing.Size(166, 28)
        Me.txtTotal.TabIndex = 12
        Me.txtTotal.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtTotal, "Text")
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.White
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.LabelControl2, "")
        Me.LabelControl2.Location = New System.Drawing.Point(3, 12)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.LabelControl2, True)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(44, 14)
        Me.LabelControl2.TabIndex = 11
        Me.LabelControl2.Text = "ยอดรวม"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.LabelControl2, "")
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Panel1, "")
        Me.Panel1.Controls.Add(Me.txtUnits)
        Me.Panel1.Controls.Add(Me.LabelControl1)
        Me.Panel1.Location = New System.Drawing.Point(12, 14)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Panel1, True)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(255, 36)
        Me.Panel1.TabIndex = 16
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Panel1, "")
        '
        'txtUnits
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtUnits, "TextChanged")
        Me.txtUnits.EditValue = "0.00"
        Me.txtUnits.Location = New System.Drawing.Point(84, 3)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.txtUnits, True)
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtUnits.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnits.Properties.Appearance.Options.UseBackColor = True
        Me.txtUnits.Properties.Appearance.Options.UseFont = True
        Me.txtUnits.Properties.Appearance.Options.UseTextOptions = True
        Me.txtUnits.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtUnits.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtUnits.Size = New System.Drawing.Size(166, 28)
        Me.txtUnits.TabIndex = 12
        Me.txtUnits.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtUnits, "Text")
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.LabelControl1, "")
        Me.LabelControl1.Location = New System.Drawing.Point(3, 12)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.LabelControl1, True)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(75, 14)
        Me.LabelControl1.TabIndex = 11
        Me.LabelControl1.Text = "จำนวนรายการ"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.LabelControl1, "")
        '
        'EmptySpaceItem7
        '
        Me.EmptySpaceItem7.AllowHotTrack = False
        Me.EmptySpaceItem7.CustomizationFormText = "EmptySpaceItem7"
        Me.EmptySpaceItem7.Location = New System.Drawing.Point(976, 339)
        Me.EmptySpaceItem7.Name = "EmptySpaceItem7"
        Me.EmptySpaceItem7.Size = New System.Drawing.Size(10, 100)
        Me.EmptySpaceItem7.Text = "EmptySpaceItem7"
        Me.EmptySpaceItem7.TextSize = New System.Drawing.Size(0, 0)
        '
        'object_67cb764d_4f5f_4a35_8c33_e0a331ccd483
        '
        Me.object_67cb764d_4f5f_4a35_8c33_e0a331ccd483.CustomizationFormText = "Item "
        Me.object_67cb764d_4f5f_4a35_8c33_e0a331ccd483.Location = New System.Drawing.Point(373, 104)
        Me.object_67cb764d_4f5f_4a35_8c33_e0a331ccd483.Name = "object_67cb764d_4f5f_4a35_8c33_e0a331ccd483"
        Me.object_67cb764d_4f5f_4a35_8c33_e0a331ccd483.Size = New System.Drawing.Size(30, 31)
        Me.object_67cb764d_4f5f_4a35_8c33_e0a331ccd483.Text = "Item "
        Me.object_67cb764d_4f5f_4a35_8c33_e0a331ccd483.TextSize = New System.Drawing.Size(0, 0)
        Me.object_67cb764d_4f5f_4a35_8c33_e0a331ccd483.TextToControlDistance = 0
        Me.object_67cb764d_4f5f_4a35_8c33_e0a331ccd483.TextVisible = False
        '
        'LayoutPO2
        '
        Me.LayoutPO2.AllowHotTrack = False
        Me.LayoutPO2.CustomizationFormText = "LayoutPO2"
        Me.LayoutPO2.Location = New System.Drawing.Point(865, 200)
        Me.LayoutPO2.MaxSize = New System.Drawing.Size(30, 22)
        Me.LayoutPO2.MinSize = New System.Drawing.Size(30, 22)
        Me.LayoutPO2.Name = "LayoutPO2"
        Me.LayoutPO2.Size = New System.Drawing.Size(30, 22)
        Me.LayoutPO2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutPO2.Text = "6"
        Me.LayoutPO2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem12
        '
        Me.EmptySpaceItem12.AllowHotTrack = False
        Me.EmptySpaceItem12.CustomizationFormText = "LayoutPO2"
        Me.EmptySpaceItem12.Location = New System.Drawing.Point(865, 200)
        Me.EmptySpaceItem12.MaxSize = New System.Drawing.Size(30, 22)
        Me.EmptySpaceItem12.MinSize = New System.Drawing.Size(30, 22)
        Me.EmptySpaceItem12.Name = "LayoutPO2"
        Me.EmptySpaceItem12.Size = New System.Drawing.Size(30, 22)
        Me.EmptySpaceItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem12.Text = "6"
        Me.EmptySpaceItem12.TextSize = New System.Drawing.Size(0, 0)
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
        '
        'frmOrderS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1049, 750)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "frmOrderS"
        Me.Text = "frmQuotation"
        Me.Controls.SetChildIndex(Me.DockPanel1, 0)
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.GeneralTabPage.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.ClaimResult.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClaimRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl2.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.Campaign.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkNotPass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuotationRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkIsEditVat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRefPO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Institute.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceSuplierID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrandTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalTax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipingRuleID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PledgeTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalAfterPledge.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditBalance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CancelRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipingBy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipingMethod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsCancel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipingDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipingDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRefOrder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Exchange.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditRuleID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCurrency.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VatPercen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VatAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SendBy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VatTypeID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuotationDays.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalAfterDis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpireDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpireDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiscountAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Total.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiscountPercen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutbtnGenID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutbtnCustomerID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutCreditRuleID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutCustomerID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutbtnCreditRuleID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutOrderDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutbtnEmpID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutExpireDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutQuotationDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutSendBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutOrderStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlRefOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutShipingDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutShipingMethod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutbtnShipingMethod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutClaimRemark2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutOrderDate2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlRefOrder2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutQuotationDays2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutShipingDate2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutPO_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutExpireDate2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutSendBy2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutOrderStatus2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutIsCancel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutIsCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutCancelRemark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutPayType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutPayType2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutCreditBalance2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutCreditBalance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutPledge1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutPledge4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutPledge3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayouShipingBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutbtnShipingBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutShipingRuleID2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutShipingRuleID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutTotalTax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutGrandTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutInvoiceSuplierID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutInvoiceSuplierID2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutInstitute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutStockType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutRefPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutStockType2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutRefPO1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutQuotationRemark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutbtnQuotationRemark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutNotPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutbtnCampaign, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutCampaign, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutClaimRemark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutClaimResult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutClaimResult2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PledgeTabPage.ResumeLayout(False)
        Me.TaxTabPage.ResumeLayout(False)
        CType(Me.TaxGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TaxGroup.ResumeLayout(False)
        Me.TaxGroup.PerformLayout()
        CType(Me.GridTaxOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxTypeIDLookUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxSection.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxCondition.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxCusCardID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxCusTaxNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxCusAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxCusname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TaxGroup1.ResumeLayout(False)
        Me.TaxGroup1.PerformLayout()
        CType(Me.TaxMonthYear.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxMonthYear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RemarkTabPage.ResumeLayout(False)
        CType(Me.Remark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NoteTabPage.ResumeLayout(False)
        Me.AttachmentTabPage.ResumeLayout(False)
        Me.AdminTabPage.ResumeLayout(False)
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.CalcEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.txtGrandTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.txtVat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.txtDiscount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.txtPledge.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txtUnits.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.object_67cb764d_4f5f_4a35_8c33_e0a331ccd483, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutPO2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormChangedComponent1 As FormChangedComponent

    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents GeneralTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnEmpID As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents VatPercen As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents GrandTotal As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents VatAmount As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents TotalAfterDis As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents Total As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents OrderStatus As DevExpress.XtraEditors.TextEdit
    Private WithEvents VatTypeID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DiscountAmount As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents EmpID As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DiscountPercen As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents btnCreditRuleID As DevExpress.XtraEditors.SimpleButton
    Private WithEvents CreditRuleID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents OrderCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnGenID As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CustomerID As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CusName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Phone1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Fax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Email1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EMPNAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCustomerID As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OrderDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnVatTypeID As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Remark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents NoteTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcNote1 As ucNote
    Friend WithEvents AttachmentTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcFileAttach1 As ucFileAttach
    Friend WithEvents AdminTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcAdmin1 As ucAdmin
    Friend WithEvents ExpireDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents QuotationDays As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents SendBy As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnRefreshCurrency As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Exchange As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents cboCurrency As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents SimpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents LayoutbtnGenID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutbtnCustomerID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutCreditRuleID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutCode As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutCustomerID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutbtnCreditRuleID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SimpleSeparator2 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents LayoutOrderDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutbtnEmpID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutExpireDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutQuotationDays As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutSendBy As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutOrderStatus As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleSeparator4 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents object_67cb764d_4f5f_4a35_8c33_e0a331ccd483 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtRefOrder As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlRefOrder As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ShipingDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutShipingDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents PO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutPO As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CancelRemark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents IsCancel As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutIsCancel As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnShipingMethod As DevExpress.XtraEditors.SimpleButton
    Private WithEvents ShipingMethod As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutShipingMethod As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutbtnShipingMethod As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutClaimRemark2 As DevExpress.XtraLayout.EmptySpaceItem
    Private WithEvents ShipingBy As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnShipingBy As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayouShipingBy As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutbtnShipingBy As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnRefOrder As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutStockType2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SimpleSeparator3 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents LayoutOrderDate2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlRefOrder2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutQuotationDays2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutShipingDate2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutPO_2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutExpireDate2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutSendBy2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutOrderStatus2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutIsCancel2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutCancelRemark As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents PayType As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LayoutPayType As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutPayType2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutCreditBalance2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents CreditBalance As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LayoutCreditBalance As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents PledgeTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcPledge1 As ucPledge
    Friend WithEvents PledgeTotal As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents TotalAfterPledge As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LayoutPledge1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutPledge4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutPledge3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents RemarkTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TaxTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TaxGroup1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TaxMonthYear As DevExpress.XtraEditors.DateEdit
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TaxCanNo As System.Windows.Forms.RadioButton
    Friend WithEvents TaxCanYes As System.Windows.Forms.RadioButton
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents TaxRemark As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnShipingRuleID As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutShipingRuleID2 As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents ShipingRuleID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutShipingRuleID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TaxGroup As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridTaxOrder As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TaxTypeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TaxTypeIDLookUp As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents TaxTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents TaxRate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents TaxAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents TaxOrderID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OtherTax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents TaxSection As DevExpress.XtraEditors.ComboBoxEdit
    Private WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TaxCondition As DevExpress.XtraEditors.ComboBoxEdit
    Private WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TaxCusCardID As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TaxCusTaxNo As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TaxCusAddress As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TaxCusname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TaxType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents TaxNumber As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TotalTax As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LayoutTotalTax As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutGrandTotal As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents InvoiceSuplierID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutInvoiceSuplierID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutInvoiceSuplierID2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents Institute As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutInstitute As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem10 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents StockType As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LayoutStockType As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtRefPO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutRefPO As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutPO2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem12 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutRefPO1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents chkIsEditVat As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnQuotationRemark As DevExpress.XtraEditors.SimpleButton
    Private WithEvents QuotationRemark As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutQuotationRemark As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutbtnQuotationRemark As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkNotPass As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutNotPass As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnCampaign As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutbtnCampaign As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Campaign As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CampaignID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Subject As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutCampaign As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SplitterItem1 As DevExpress.XtraLayout.SplitterItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents CalcEdit1 As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents btnCalc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents txtGrandTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txtVat As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txtDiscount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtPledge As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtUnits As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabControl2 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcProductLists1 As UB.ucProductLists
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LayoutControlProduct As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents UcNote2 As UB.ucNote
    Friend WithEvents ClaimRemark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutClaimRemark As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem9 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents ClaimResult As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LayoutClaimResult As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutClaimResult2 As DevExpress.XtraLayout.EmptySpaceItem
End Class
