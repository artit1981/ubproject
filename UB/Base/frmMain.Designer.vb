Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraBars.Ribbon


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim GalleryItemGroup1 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
        Me.ribbonMain = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.appMenu = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
        Me.ImageMenu = New DevExpress.Utils.ImageCollection(Me.components)
        Me.rgbiSkins = New DevExpress.XtraBars.RibbonGalleryBarItem()
        Me.LeadBar = New DevExpress.XtraBars.BarButtonItem()
        Me.PrefixBar = New DevExpress.XtraBars.BarButtonItem()
        Me.LeadTypeBar = New DevExpress.XtraBars.BarButtonItem()
        Me.SourceBar = New DevExpress.XtraBars.BarButtonItem()
        Me.PrivilegeBar = New DevExpress.XtraBars.BarButtonItem()
        Me.DepartmentBar = New DevExpress.XtraBars.BarButtonItem()
        Me.PositionBar = New DevExpress.XtraBars.BarButtonItem()
        Me.IndustryTypeBar = New DevExpress.XtraBars.BarButtonItem()
        Me.BusinessTypeBar = New DevExpress.XtraBars.BarButtonItem()
        Me.TerritoryBar = New DevExpress.XtraBars.BarButtonItem()
        Me.EmployeeBar = New DevExpress.XtraBars.BarButtonItem()
        Me.UserBar = New DevExpress.XtraBars.BarButtonItem()
        Me.lblCompany = New DevExpress.XtraBars.BarStaticItem()
        Me.lblUser = New DevExpress.XtraBars.BarStaticItem()
        Me.lblVersion = New DevExpress.XtraBars.BarStaticItem()
        Me.lblEmp = New DevExpress.XtraBars.BarStaticItem()
        Me.ActivityBar = New DevExpress.XtraBars.BarButtonItem()
        Me.UnitBar = New DevExpress.XtraBars.BarButtonItem()
        Me.ProductGroupBar = New DevExpress.XtraBars.BarButtonItem()
        Me.ProductDimensionBar = New DevExpress.XtraBars.BarButtonItem()
        Me.ProductCategoryBar = New DevExpress.XtraBars.BarButtonItem()
        Me.ProductBrandBar = New DevExpress.XtraBars.BarButtonItem()
        Me.ProductTypeBar = New DevExpress.XtraBars.BarButtonItem()
        Me.EmpGroupBar = New DevExpress.XtraBars.BarButtonItem()
        Me.LocationBar = New DevExpress.XtraBars.BarButtonItem()
        Me.ProductBar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.ContactRoleBar = New DevExpress.XtraBars.BarButtonItem()
        Me.CreditRuleBar = New DevExpress.XtraBars.BarButtonItem()
        Me.CurrencyBar = New DevExpress.XtraBars.BarButtonItem()
        Me.ContactBar = New DevExpress.XtraBars.BarButtonItem()
        Me.AccountsBar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.RunningBar = New DevExpress.XtraBars.BarButtonItem()
        Me.VerifyCusBar = New DevExpress.XtraBars.BarButtonItem()
        Me.OpportunityBar = New DevExpress.XtraBars.BarButtonItem()
        Me.OpportunityTypeBar = New DevExpress.XtraBars.BarButtonItem()
        Me.OpportunityStageBar = New DevExpress.XtraBars.BarButtonItem()
        Me.VatTypeBar = New DevExpress.XtraBars.BarButtonItem()
        Me.OrderBar = New DevExpress.XtraBars.BarButtonItem()
        Me.QuotationBar = New DevExpress.XtraBars.BarButtonItem()
        Me.CriterionPriceBar = New DevExpress.XtraBars.BarButtonItem()
        Me.InformPriceBar = New DevExpress.XtraBars.BarButtonItem()
        Me.CompanyTypeBar = New DevExpress.XtraBars.BarButtonItem()
        Me.StockInBar = New DevExpress.XtraBars.BarButtonItem()
        Me.ShipingMethodyBar = New DevExpress.XtraBars.BarButtonItem()
        Me.ShipingByBar = New DevExpress.XtraBars.BarButtonItem()
        Me.InvoiceBar = New DevExpress.XtraBars.BarButtonItem()
        Me.ShipingBar = New DevExpress.XtraBars.BarButtonItem()
        Me.BillMethodBar = New DevExpress.XtraBars.BarButtonItem()
        Me.BillBar = New DevExpress.XtraBars.BarButtonItem()
        Me.CheckStockBar = New DevExpress.XtraBars.BarButtonItem()
        Me.AgencyBar = New DevExpress.XtraBars.BarButtonItem()
        Me.OrderInBar = New DevExpress.XtraBars.BarButtonItem()
        Me.CompanyBar = New DevExpress.XtraBars.BarButtonItem()
        Me.ApproveUserBar = New DevExpress.XtraBars.BarButtonItem()
        Me.ApproveTXBar = New DevExpress.XtraBars.BarButtonItem()
        Me.CreditGroupBar = New DevExpress.XtraBars.BarButtonItem()
        Me.AddCreditBar = New DevExpress.XtraBars.BarButtonItem()
        Me.ReserveBar = New DevExpress.XtraBars.BarButtonItem()
        Me.ReceiptBar = New DevExpress.XtraBars.BarButtonItem()
        Me.ReduceCreditBar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonGroup1 = New DevExpress.XtraBars.BarButtonGroup()
        Me.AssetBar = New DevExpress.XtraBars.BarButtonItem()
        Me.InformPriceBuyBar = New DevExpress.XtraBars.BarButtonItem()
        Me.ShipingRuleBar = New DevExpress.XtraBars.BarButtonItem()
        Me.AddCreditBuyBar = New DevExpress.XtraBars.BarButtonItem()
        Me.ReduceCreditBuyBar = New DevExpress.XtraBars.BarButtonItem()
        Me.InvoiceBuyBar = New DevExpress.XtraBars.BarButtonItem()
        Me.ReportTaxSellBar = New DevExpress.XtraBars.BarButtonItem()
        Me.TaxTypeBar = New DevExpress.XtraBars.BarButtonItem()
        Me.CustomerZoneBar = New DevExpress.XtraBars.BarButtonItem()
        Me.CustomerGroupBar = New DevExpress.XtraBars.BarButtonItem()
        Me.ClaimBar = New DevExpress.XtraBars.BarButtonItem()
        Me.ClaimOutBar = New DevExpress.XtraBars.BarButtonItem()
        Me.UpdateStockBar = New DevExpress.XtraBars.BarButtonItem()
        Me.ReceiptBuyBar = New DevExpress.XtraBars.BarButtonItem()
        Me.BankAccounBar = New DevExpress.XtraBars.BarButtonItem()
        Me.OrderHisBar = New DevExpress.XtraBars.BarButtonItem()
        Me.BorrowBar = New DevExpress.XtraBars.BarButtonItem()
        Me.ShipingBuyBar = New DevExpress.XtraBars.BarButtonItem()
        Me.RecordChequeBar = New DevExpress.XtraBars.BarButtonItem()
        Me.ReceiptCutBar = New DevExpress.XtraBars.BarButtonItem()
        Me.ReportSellAnalyzeBar = New DevExpress.XtraBars.BarButtonItem()
        Me.UpdateSNBar = New DevExpress.XtraBars.BarButtonItem()
        Me.ReportTaxAtSellBar = New DevExpress.XtraBars.BarButtonItem()
        Me.ReportSNBar = New DevExpress.XtraBars.BarButtonItem()
        Me.ExposeBar = New DevExpress.XtraBars.BarButtonItem()
        Me.OrderSNHisBar = New DevExpress.XtraBars.BarButtonItem()
        Me.MakePOBar = New DevExpress.XtraBars.BarButtonItem()
        Me.CancelPOBar = New DevExpress.XtraBars.BarButtonItem()
        Me.QuotationRemarkBar = New DevExpress.XtraBars.BarButtonItem()
        Me.InformPriceProBar = New DevExpress.XtraBars.BarButtonItem()
        Me.CampaignBar = New DevExpress.XtraBars.BarButtonItem()
        Me.ReportDealBar = New DevExpress.XtraBars.BarButtonItem()
        Me.UpdateSNStatusBar = New DevExpress.XtraBars.BarButtonItem()
        Me.BankBar = New DevExpress.XtraBars.BarButtonItem()
        Me.OrderSellHisBar = New DevExpress.XtraBars.BarButtonItem()
        Me.ProvinceBar = New DevExpress.XtraBars.BarButtonItem()
        Me.lblDatabase = New DevExpress.XtraBars.BarStaticItem()
        Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.homeRibbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.fileRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup8 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup18 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup24 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup28 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup35 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ProductRibbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup25 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup29 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.BuyRibbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup12 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup13 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup21 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup20 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup32 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup27 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup33 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.SaleRibbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup10 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.SaleRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup11 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup14 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup19 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup26 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ChequeRibbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup30 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ApproveRibbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup16 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup17 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.AdminRibbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup15 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup9 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ReportRibbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup23 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup31 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.helpRibbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.helpRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ViewRibbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.skinsRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.RepositoryItemMarqueeProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.ribbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.MenuNavBarControl = New DevExpress.XtraNavBar.NavBarControl()
        Me.MenuNavBarGroup = New DevExpress.XtraNavBar.NavBarGroup()
        Me.AdminBar = New DevExpress.XtraNavBar.NavBarItem()
        Me.CrmBar = New DevExpress.XtraNavBar.NavBarItem()
        Me.AccountBar = New DevExpress.XtraNavBar.NavBarItem()
        Me.ExitBar = New DevExpress.XtraNavBar.NavBarItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        CType(Me.ribbonMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.appMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMarqueeProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuNavBarControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonMain
        '
        Me.ribbonMain.ApplicationButtonDropDownControl = Me.appMenu
        Me.ribbonMain.ApplicationButtonText = Nothing
        Me.ribbonMain.ExpandCollapseItem.Id = 0
        Me.ribbonMain.Images = Me.ImageMenu
        Me.ribbonMain.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonMain.ExpandCollapseItem, Me.rgbiSkins, Me.LeadBar, Me.PrefixBar, Me.LeadTypeBar, Me.SourceBar, Me.PrivilegeBar, Me.DepartmentBar, Me.PositionBar, Me.IndustryTypeBar, Me.BusinessTypeBar, Me.TerritoryBar, Me.EmployeeBar, Me.UserBar, Me.lblCompany, Me.lblUser, Me.lblVersion, Me.lblEmp, Me.ActivityBar, Me.UnitBar, Me.ProductGroupBar, Me.ProductDimensionBar, Me.ProductCategoryBar, Me.ProductBrandBar, Me.ProductTypeBar, Me.EmpGroupBar, Me.LocationBar, Me.ProductBar, Me.BarButtonItem1, Me.BarButtonItem2, Me.ContactRoleBar, Me.CreditRuleBar, Me.CurrencyBar, Me.ContactBar, Me.AccountsBar, Me.BarButtonItem4, Me.BarButtonItem5, Me.RunningBar, Me.VerifyCusBar, Me.OpportunityBar, Me.OpportunityTypeBar, Me.OpportunityStageBar, Me.VatTypeBar, Me.OrderBar, Me.QuotationBar, Me.CriterionPriceBar, Me.InformPriceBar, Me.CompanyTypeBar, Me.StockInBar, Me.ShipingMethodyBar, Me.ShipingByBar, Me.InvoiceBar, Me.ShipingBar, Me.BillMethodBar, Me.BillBar, Me.CheckStockBar, Me.AgencyBar, Me.OrderInBar, Me.CompanyBar, Me.ApproveUserBar, Me.ApproveTXBar, Me.CreditGroupBar, Me.AddCreditBar, Me.ReserveBar, Me.ReceiptBar, Me.ReduceCreditBar, Me.BarButtonGroup1, Me.AssetBar, Me.InformPriceBuyBar, Me.ShipingRuleBar, Me.AddCreditBuyBar, Me.ReduceCreditBuyBar, Me.InvoiceBuyBar, Me.ReportTaxSellBar, Me.TaxTypeBar, Me.CustomerZoneBar, Me.CustomerGroupBar, Me.ClaimBar, Me.ClaimOutBar, Me.UpdateStockBar, Me.ReceiptBuyBar, Me.BankAccounBar, Me.OrderHisBar, Me.BorrowBar, Me.ShipingBuyBar, Me.RecordChequeBar, Me.ReceiptCutBar, Me.ReportSellAnalyzeBar, Me.UpdateSNBar, Me.ReportTaxAtSellBar, Me.ReportSNBar, Me.ExposeBar, Me.OrderSNHisBar, Me.MakePOBar, Me.CancelPOBar, Me.QuotationRemarkBar, Me.InformPriceProBar, Me.CampaignBar, Me.ReportDealBar, Me.UpdateSNStatusBar, Me.BankBar, Me.OrderSellHisBar, Me.ProvinceBar, Me.lblDatabase})
        Me.ribbonMain.LargeImages = Me.imageCollection1
        Me.ribbonMain.Location = New System.Drawing.Point(0, 0)
        Me.ribbonMain.MaxItemId = 188
        Me.ribbonMain.Name = "ribbonMain"
        Me.ribbonMain.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.homeRibbonPage, Me.ProductRibbonPage, Me.BuyRibbonPage, Me.SaleRibbonPage, Me.ChequeRibbonPage, Me.ApproveRibbonPage, Me.AdminRibbonPage, Me.ReportRibbonPage, Me.helpRibbonPage, Me.ViewRibbonPage})
        Me.ribbonMain.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemProgressBar1, Me.RepositoryItemMarqueeProgressBar1, Me.RepositoryItemTextEdit1})
        Me.ribbonMain.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.ribbonMain.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonMain.ShowToolbarCustomizeItem = False
        Me.ribbonMain.Size = New System.Drawing.Size(1235, 144)
        Me.ribbonMain.StatusBar = Me.ribbonStatusBar
        Me.ribbonMain.Toolbar.ShowCustomizeItem = False
        '
        'appMenu
        '
        Me.appMenu.AllowRibbonQATMenu = False
        Me.appMenu.Name = "appMenu"
        Me.appMenu.Ribbon = Me.ribbonMain
        '
        'ImageMenu
        '
        Me.ImageMenu.ImageSize = New System.Drawing.Size(40, 40)
        Me.ImageMenu.ImageStream = CType(resources.GetObject("ImageMenu.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageMenu.Images.SetKeyName(0, "Door.png")
        Me.ImageMenu.Images.SetKeyName(1, "user_comment.png")
        Me.ImageMenu.Images.SetKeyName(2, "Windows-Security.ico")
        Me.ImageMenu.Images.SetKeyName(3, "Voice.png")
        Me.ImageMenu.Images.SetKeyName(4, "Wordpad.png")
        '
        'rgbiSkins
        '
        Me.rgbiSkins.Caption = "RibbonGalleryBarItem1"
        '
        '
        '
        GalleryItemGroup1.Caption = "Group1"
        Me.rgbiSkins.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {GalleryItemGroup1})
        Me.rgbiSkins.Id = 62
        Me.rgbiSkins.Name = "rgbiSkins"
        '
        'LeadBar
        '
        Me.LeadBar.Caption = "Leads"
        Me.LeadBar.Id = 64
        Me.LeadBar.ItemAppearance.Normal.Options.UseImage = True
        Me.LeadBar.LargeImageIndex = 1
        Me.LeadBar.Name = "LeadBar"
        '
        'PrefixBar
        '
        Me.PrefixBar.Caption = "คำนำชื่อ"
        Me.PrefixBar.DropDownEnabled = False
        Me.PrefixBar.Id = 65
        Me.PrefixBar.Name = "PrefixBar"
        '
        'LeadTypeBar
        '
        Me.LeadTypeBar.Caption = "ประเภทการเพิ่ม"
        Me.LeadTypeBar.Id = 68
        Me.LeadTypeBar.Name = "LeadTypeBar"
        '
        'SourceBar
        '
        Me.SourceBar.Caption = "แหล่งที่มา"
        Me.SourceBar.Id = 69
        Me.SourceBar.Name = "SourceBar"
        '
        'PrivilegeBar
        '
        Me.PrivilegeBar.Caption = "กำหนดสิทธิ"
        Me.PrivilegeBar.Id = 70
        Me.PrivilegeBar.Name = "PrivilegeBar"
        '
        'DepartmentBar
        '
        Me.DepartmentBar.Caption = "แผนก"
        Me.DepartmentBar.Id = 71
        Me.DepartmentBar.Name = "DepartmentBar"
        '
        'PositionBar
        '
        Me.PositionBar.Caption = "ตำแหน่ง"
        Me.PositionBar.Id = 72
        Me.PositionBar.Name = "PositionBar"
        '
        'IndustryTypeBar
        '
        Me.IndustryTypeBar.Caption = "ประเภทอุตสาหกรรม"
        Me.IndustryTypeBar.Id = 73
        Me.IndustryTypeBar.Name = "IndustryTypeBar"
        '
        'BusinessTypeBar
        '
        Me.BusinessTypeBar.Caption = "ประเภทธุรกิจ"
        Me.BusinessTypeBar.Id = 74
        Me.BusinessTypeBar.Name = "BusinessTypeBar"
        '
        'TerritoryBar
        '
        Me.TerritoryBar.Caption = "ทีมขาย"
        Me.TerritoryBar.Id = 75
        Me.TerritoryBar.Name = "TerritoryBar"
        '
        'EmployeeBar
        '
        Me.EmployeeBar.Caption = "พนักงาน"
        Me.EmployeeBar.Id = 76
        Me.EmployeeBar.Name = "EmployeeBar"
        '
        'UserBar
        '
        Me.UserBar.Caption = "ผู้ใช้งานระบบ"
        Me.UserBar.Id = 77
        Me.UserBar.Name = "UserBar"
        '
        'lblCompany
        '
        Me.lblCompany.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.lblCompany.Caption = "บริษัท"
        Me.lblCompany.Id = 80
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.TextAlignment = System.Drawing.StringAlignment.Near
        Me.lblCompany.Width = 150
        '
        'lblUser
        '
        Me.lblUser.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.lblUser.Caption = "ผู้ใช้งาน"
        Me.lblUser.Id = 81
        Me.lblUser.Name = "lblUser"
        Me.lblUser.TextAlignment = System.Drawing.StringAlignment.Near
        Me.lblUser.Width = 120
        '
        'lblVersion
        '
        Me.lblVersion.Caption = "Version"
        Me.lblVersion.Id = 84
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.TextAlignment = System.Drawing.StringAlignment.Near
        Me.lblVersion.Width = 100
        '
        'lblEmp
        '
        Me.lblEmp.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.lblEmp.Caption = "พนักงาน"
        Me.lblEmp.Id = 85
        Me.lblEmp.Name = "lblEmp"
        Me.lblEmp.TextAlignment = System.Drawing.StringAlignment.Near
        Me.lblEmp.Width = 150
        '
        'ActivityBar
        '
        Me.ActivityBar.Caption = "การใช้งานระบบ"
        Me.ActivityBar.Id = 86
        Me.ActivityBar.Name = "ActivityBar"
        '
        'UnitBar
        '
        Me.UnitBar.Caption = "หน่วยนับ"
        Me.UnitBar.Id = 87
        Me.UnitBar.Name = "UnitBar"
        '
        'ProductGroupBar
        '
        Me.ProductGroupBar.Caption = "กลุ่มสินค้า"
        Me.ProductGroupBar.Id = 88
        Me.ProductGroupBar.Name = "ProductGroupBar"
        '
        'ProductDimensionBar
        '
        Me.ProductDimensionBar.Caption = "มิติสินค้า"
        Me.ProductDimensionBar.Id = 89
        Me.ProductDimensionBar.Name = "ProductDimensionBar"
        '
        'ProductCategoryBar
        '
        Me.ProductCategoryBar.Caption = "หมวดสินค้า"
        Me.ProductCategoryBar.Id = 90
        Me.ProductCategoryBar.Name = "ProductCategoryBar"
        '
        'ProductBrandBar
        '
        Me.ProductBrandBar.Caption = "ยี่ห้อสินค้า"
        Me.ProductBrandBar.Id = 91
        Me.ProductBrandBar.Name = "ProductBrandBar"
        '
        'ProductTypeBar
        '
        Me.ProductTypeBar.Caption = "ประเภทสินค้า"
        Me.ProductTypeBar.Id = 92
        Me.ProductTypeBar.Name = "ProductTypeBar"
        '
        'EmpGroupBar
        '
        Me.EmpGroupBar.Caption = "กลุ่มพนักงาน"
        Me.EmpGroupBar.Id = 93
        Me.EmpGroupBar.Name = "EmpGroupBar"
        '
        'LocationBar
        '
        Me.LocationBar.Caption = "คลังสินค้า"
        Me.LocationBar.Id = 94
        Me.LocationBar.Name = "LocationBar"
        '
        'ProductBar
        '
        Me.ProductBar.Caption = "สินค้า"
        Me.ProductBar.Id = 95
        Me.ProductBar.Name = "ProductBar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 97
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "BarButtonItem2"
        Me.BarButtonItem2.Id = 98
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'ContactRoleBar
        '
        Me.ContactRoleBar.Caption = "บทบาทหน้าที่"
        Me.ContactRoleBar.Id = 99
        Me.ContactRoleBar.Name = "ContactRoleBar"
        '
        'CreditRuleBar
        '
        Me.CreditRuleBar.Caption = "รหัสเครดิต"
        Me.CreditRuleBar.Id = 100
        Me.CreditRuleBar.Name = "CreditRuleBar"
        '
        'CurrencyBar
        '
        Me.CurrencyBar.Caption = "สกุลเงิน"
        Me.CurrencyBar.Id = 101
        Me.CurrencyBar.Name = "CurrencyBar"
        '
        'ContactBar
        '
        Me.ContactBar.Caption = "Contacts"
        Me.ContactBar.Id = 102
        Me.ContactBar.LargeImageIndex = 2
        Me.ContactBar.Name = "ContactBar"
        '
        'AccountsBar
        '
        Me.AccountsBar.Caption = "Accounts"
        Me.AccountsBar.Id = 103
        Me.AccountsBar.LargeImageIndex = 3
        Me.AccountsBar.Name = "AccountsBar"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "BarButtonItem4"
        Me.BarButtonItem4.Id = 106
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "BarButtonItem5"
        Me.BarButtonItem5.Id = 107
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'RunningBar
        '
        Me.RunningBar.Caption = "Running Format"
        Me.RunningBar.Id = 108
        Me.RunningBar.Name = "RunningBar"
        '
        'VerifyCusBar
        '
        Me.VerifyCusBar.Caption = "Verify Customer"
        Me.VerifyCusBar.Id = 109
        Me.VerifyCusBar.Name = "VerifyCusBar"
        '
        'OpportunityBar
        '
        Me.OpportunityBar.Caption = "โอกาสทางการขาย"
        Me.OpportunityBar.Id = 110
        Me.OpportunityBar.Name = "OpportunityBar"
        '
        'OpportunityTypeBar
        '
        Me.OpportunityTypeBar.Caption = "ประเภทโอกาสทางการขาย"
        Me.OpportunityTypeBar.Id = 111
        Me.OpportunityTypeBar.Name = "OpportunityTypeBar"
        '
        'OpportunityStageBar
        '
        Me.OpportunityStageBar.Caption = "ช่วงโอกาสทางการขาย"
        Me.OpportunityStageBar.Id = 113
        Me.OpportunityStageBar.Name = "OpportunityStageBar"
        '
        'VatTypeBar
        '
        Me.VatTypeBar.Caption = "รูปแบบภาษี"
        Me.VatTypeBar.Id = 114
        Me.VatTypeBar.Name = "VatTypeBar"
        '
        'OrderBar
        '
        Me.OrderBar.Caption = "ใบสั่งขาย"
        Me.OrderBar.Id = 115
        Me.OrderBar.Name = "OrderBar"
        '
        'QuotationBar
        '
        Me.QuotationBar.Caption = "ใบเสนอราคา"
        Me.QuotationBar.Id = 116
        Me.QuotationBar.Name = "QuotationBar"
        '
        'CriterionPriceBar
        '
        Me.CriterionPriceBar.Caption = "เกณฑ์ราคา"
        Me.CriterionPriceBar.Id = 117
        Me.CriterionPriceBar.Name = "CriterionPriceBar"
        '
        'InformPriceBar
        '
        Me.InformPriceBar.Caption = "ระบบแจ้งราคา"
        Me.InformPriceBar.Id = 124
        Me.InformPriceBar.Name = "InformPriceBar"
        '
        'CompanyTypeBar
        '
        Me.CompanyTypeBar.Caption = "ประเภทบริษัท"
        Me.CompanyTypeBar.Id = 125
        Me.CompanyTypeBar.Name = "CompanyTypeBar"
        '
        'StockInBar
        '
        Me.StockInBar.Caption = "นำสินค้าเข้าระบบ"
        Me.StockInBar.Id = 126
        Me.StockInBar.Name = "StockInBar"
        '
        'ShipingMethodyBar
        '
        Me.ShipingMethodyBar.Caption = "วิธีการขนส่ง"
        Me.ShipingMethodyBar.Id = 127
        Me.ShipingMethodyBar.Name = "ShipingMethodyBar"
        '
        'ShipingByBar
        '
        Me.ShipingByBar.Caption = "ขนส่งโดย"
        Me.ShipingByBar.Id = 128
        Me.ShipingByBar.Name = "ShipingByBar"
        '
        'InvoiceBar
        '
        Me.InvoiceBar.Caption = "ใบกำกับภาษี"
        Me.InvoiceBar.Id = 129
        Me.InvoiceBar.Name = "InvoiceBar"
        '
        'ShipingBar
        '
        Me.ShipingBar.Caption = "ใบส่งของ"
        Me.ShipingBar.Id = 130
        Me.ShipingBar.Name = "ShipingBar"
        Me.ShipingBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'BillMethodBar
        '
        Me.BillMethodBar.Caption = "วิธีการวางบิล"
        Me.BillMethodBar.Id = 131
        Me.BillMethodBar.Name = "BillMethodBar"
        '
        'BillBar
        '
        Me.BillBar.Caption = "ใบวางบิล"
        Me.BillBar.Id = 132
        Me.BillBar.Name = "BillBar"
        '
        'CheckStockBar
        '
        Me.CheckStockBar.Caption = "ตรวจสอบสต๊อก"
        Me.CheckStockBar.Id = 133
        Me.CheckStockBar.Name = "CheckStockBar"
        '
        'AgencyBar
        '
        Me.AgencyBar.Caption = "เจ้าหนี้"
        Me.AgencyBar.Id = 135
        Me.AgencyBar.LargeImageIndex = 4
        Me.AgencyBar.Name = "AgencyBar"
        '
        'OrderInBar
        '
        Me.OrderInBar.Caption = "ใบสั่งซื้อ"
        Me.OrderInBar.Id = 136
        Me.OrderInBar.Name = "OrderInBar"
        '
        'CompanyBar
        '
        Me.CompanyBar.Caption = "บริษัท"
        Me.CompanyBar.Id = 138
        Me.CompanyBar.Name = "CompanyBar"
        '
        'ApproveUserBar
        '
        Me.ApproveUserBar.Caption = "ผู้อนุมัติ"
        Me.ApproveUserBar.Id = 139
        Me.ApproveUserBar.Name = "ApproveUserBar"
        '
        'ApproveTXBar
        '
        Me.ApproveTXBar.Caption = "อนุมัติรายการ"
        Me.ApproveTXBar.Id = 140
        Me.ApproveTXBar.Name = "ApproveTXBar"
        '
        'CreditGroupBar
        '
        Me.CreditGroupBar.Caption = "กลุ่มวงเงิน"
        Me.CreditGroupBar.Id = 141
        Me.CreditGroupBar.Name = "CreditGroupBar"
        '
        'AddCreditBar
        '
        Me.AddCreditBar.Caption = "บันทึกเพิ่มหนี้"
        Me.AddCreditBar.Id = 142
        Me.AddCreditBar.Name = "AddCreditBar"
        '
        'ReserveBar
        '
        Me.ReserveBar.Caption = "ใบสั่งจอง"
        Me.ReserveBar.Id = 143
        Me.ReserveBar.Name = "ReserveBar"
        '
        'ReceiptBar
        '
        Me.ReceiptBar.Caption = "ใบเสร็จรับเงิน /ชำระเงิน"
        Me.ReceiptBar.Id = 144
        Me.ReceiptBar.Name = "ReceiptBar"
        '
        'ReduceCreditBar
        '
        Me.ReduceCreditBar.Caption = "บันทึกลดหนี้"
        Me.ReduceCreditBar.Id = 145
        Me.ReduceCreditBar.Name = "ReduceCreditBar"
        '
        'BarButtonGroup1
        '
        Me.BarButtonGroup1.Caption = "BarButtonGroup1"
        Me.BarButtonGroup1.Id = 146
        Me.BarButtonGroup1.Name = "BarButtonGroup1"
        '
        'AssetBar
        '
        Me.AssetBar.Caption = "บันทึกค่าใช้จ่ายอื่นๆ"
        Me.AssetBar.Id = 147
        Me.AssetBar.Name = "AssetBar"
        '
        'InformPriceBuyBar
        '
        Me.InformPriceBuyBar.Caption = "ระบบแจ้งราคาซื้อ"
        Me.InformPriceBuyBar.Id = 148
        Me.InformPriceBuyBar.Name = "InformPriceBuyBar"
        '
        'ShipingRuleBar
        '
        Me.ShipingRuleBar.Caption = "เงื่อนไขการขนส่ง"
        Me.ShipingRuleBar.Id = 149
        Me.ShipingRuleBar.Name = "ShipingRuleBar"
        '
        'AddCreditBuyBar
        '
        Me.AddCreditBuyBar.Caption = "บันทึกเพิ่มหนี้"
        Me.AddCreditBuyBar.Id = 150
        Me.AddCreditBuyBar.Name = "AddCreditBuyBar"
        '
        'ReduceCreditBuyBar
        '
        Me.ReduceCreditBuyBar.Caption = "บันทึกลดหนี้"
        Me.ReduceCreditBuyBar.Id = 151
        Me.ReduceCreditBuyBar.Name = "ReduceCreditBuyBar"
        '
        'InvoiceBuyBar
        '
        Me.InvoiceBuyBar.Caption = "ใบกำกับภาษี(ซื้อ)"
        Me.InvoiceBuyBar.Id = 152
        Me.InvoiceBuyBar.Name = "InvoiceBuyBar"
        '
        'ReportTaxSellBar
        '
        Me.ReportTaxSellBar.Caption = "รายงานภาษี"
        Me.ReportTaxSellBar.Id = 153
        Me.ReportTaxSellBar.Name = "ReportTaxSellBar"
        '
        'TaxTypeBar
        '
        Me.TaxTypeBar.Caption = "ประเภทเงินได้ที่จ่าย"
        Me.TaxTypeBar.Id = 154
        Me.TaxTypeBar.Name = "TaxTypeBar"
        '
        'CustomerZoneBar
        '
        Me.CustomerZoneBar.Caption = "เขตลูกค้า"
        Me.CustomerZoneBar.Id = 155
        Me.CustomerZoneBar.Name = "CustomerZoneBar"
        '
        'CustomerGroupBar
        '
        Me.CustomerGroupBar.Caption = "กลุ่มลูกค้า"
        Me.CustomerGroupBar.Id = 156
        Me.CustomerGroupBar.Name = "CustomerGroupBar"
        '
        'ClaimBar
        '
        Me.ClaimBar.Caption = "รับแจ้งเคลม"
        Me.ClaimBar.Id = 157
        Me.ClaimBar.Name = "ClaimBar"
        '
        'ClaimOutBar
        '
        Me.ClaimOutBar.Caption = "แจ้งเคลม Supplier "
        Me.ClaimOutBar.Id = 158
        Me.ClaimOutBar.Name = "ClaimOutBar"
        '
        'UpdateStockBar
        '
        Me.UpdateStockBar.Caption = "ปรับยอดสินค้า"
        Me.UpdateStockBar.Id = 159
        Me.UpdateStockBar.Name = "UpdateStockBar"
        '
        'ReceiptBuyBar
        '
        Me.ReceiptBuyBar.Caption = "ใบเสร็จรับเงิน /ชำระเงิน(ซื้อ)"
        Me.ReceiptBuyBar.Id = 160
        Me.ReceiptBuyBar.Name = "ReceiptBuyBar"
        '
        'BankAccounBar
        '
        Me.BankAccounBar.Caption = "บัญชีธนาคาร"
        Me.BankAccounBar.Id = 161
        Me.BankAccounBar.Name = "BankAccounBar"
        '
        'OrderHisBar
        '
        Me.OrderHisBar.Caption = "ประวัติการซื้อ-ขายสินค้า"
        Me.OrderHisBar.Id = 162
        Me.OrderHisBar.Name = "OrderHisBar"
        '
        'BorrowBar
        '
        Me.BorrowBar.Caption = "ยืมสินค้า"
        Me.BorrowBar.Id = 163
        Me.BorrowBar.Name = "BorrowBar"
        '
        'ShipingBuyBar
        '
        Me.ShipingBuyBar.Caption = "ใบส่งของ(ซื้อ)"
        Me.ShipingBuyBar.Id = 164
        Me.ShipingBuyBar.Name = "ShipingBuyBar"
        '
        'RecordChequeBar
        '
        Me.RecordChequeBar.Caption = "บันทึกเช็ค"
        Me.RecordChequeBar.Id = 165
        Me.RecordChequeBar.Name = "RecordChequeBar"
        '
        'ReceiptCutBar
        '
        Me.ReceiptCutBar.Caption = "ตัดรับชำระ"
        Me.ReceiptCutBar.Id = 167
        Me.ReceiptCutBar.Name = "ReceiptCutBar"
        '
        'ReportSellAnalyzeBar
        '
        Me.ReportSellAnalyzeBar.Caption = "วิเคราะห์ยอดขาย"
        Me.ReportSellAnalyzeBar.Id = 168
        Me.ReportSellAnalyzeBar.Name = "ReportSellAnalyzeBar"
        '
        'UpdateSNBar
        '
        Me.UpdateSNBar.Caption = "สินค้า S/N"
        Me.UpdateSNBar.Id = 170
        Me.UpdateSNBar.Name = "UpdateSNBar"
        '
        'ReportTaxAtSellBar
        '
        Me.ReportTaxAtSellBar.Caption = "ภาษีหัก ณ ที่จ่าย"
        Me.ReportTaxAtSellBar.Id = 171
        Me.ReportTaxAtSellBar.Name = "ReportTaxAtSellBar"
        '
        'ReportSNBar
        '
        Me.ReportSNBar.Caption = "พิมพ์บาร์โค้ด"
        Me.ReportSNBar.Id = 172
        Me.ReportSNBar.Name = "ReportSNBar"
        '
        'ExposeBar
        '
        Me.ExposeBar.Caption = "ทำรายการเบิก"
        Me.ExposeBar.Id = 173
        Me.ExposeBar.Name = "ExposeBar"
        '
        'OrderSNHisBar
        '
        Me.OrderSNHisBar.Caption = "ตรวจสอบสินค้า SN"
        Me.OrderSNHisBar.Id = 174
        Me.OrderSNHisBar.Name = "OrderSNHisBar"
        '
        'MakePOBar
        '
        Me.MakePOBar.Caption = "สร้างใบสั่งซื้อ"
        Me.MakePOBar.Id = 175
        Me.MakePOBar.Name = "MakePOBar"
        '
        'CancelPOBar
        '
        Me.CancelPOBar.Caption = "ยกเลิกใบสั่งซื้อ"
        Me.CancelPOBar.Id = 176
        Me.CancelPOBar.Name = "CancelPOBar"
        '
        'QuotationRemarkBar
        '
        Me.QuotationRemarkBar.Caption = "หมายเหตุใบเสนอราคา"
        Me.QuotationRemarkBar.Id = 177
        Me.QuotationRemarkBar.Name = "QuotationRemarkBar"
        '
        'InformPriceProBar
        '
        Me.InformPriceProBar.Caption = "กำหนดราคาสินค้า"
        Me.InformPriceProBar.Id = 178
        Me.InformPriceProBar.Name = "InformPriceProBar"
        '
        'CampaignBar
        '
        Me.CampaignBar.Caption = "โปรโมชั่น"
        Me.CampaignBar.Id = 179
        Me.CampaignBar.Name = "CampaignBar"
        '
        'ReportDealBar
        '
        Me.ReportDealBar.Caption = "รายงานการรับ/จ่ายชำระหนี้"
        Me.ReportDealBar.Id = 180
        Me.ReportDealBar.Name = "ReportDealBar"
        '
        'UpdateSNStatusBar
        '
        Me.UpdateSNStatusBar.Caption = "แก้ไขสถานะ SN"
        Me.UpdateSNStatusBar.Id = 181
        Me.UpdateSNStatusBar.Name = "UpdateSNStatusBar"
        '
        'BankBar
        '
        Me.BankBar.Caption = "ข้อมูลธนาคาร"
        Me.BankBar.Id = 182
        Me.BankBar.Name = "BankBar"
        '
        'OrderSellHisBar
        '
        Me.OrderSellHisBar.Caption = "ประวัติการขาย"
        Me.OrderSellHisBar.Id = 183
        Me.OrderSellHisBar.Name = "OrderSellHisBar"
        '
        'ProvinceBar
        '
        Me.ProvinceBar.Caption = "จังหวัด"
        Me.ProvinceBar.Id = 185
        Me.ProvinceBar.Name = "ProvinceBar"
        '
        'lblDatabase
        '
        Me.lblDatabase.Caption = "Database"
        Me.lblDatabase.Id = 187
        Me.lblDatabase.Name = "lblDatabase"
        Me.lblDatabase.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'imageCollection1
        '
        Me.imageCollection1.ImageSize = New System.Drawing.Size(50, 50)
        Me.imageCollection1.ImageStream = CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.imageCollection1.Images.SetKeyName(0, "Users.png")
        Me.imageCollection1.Images.SetKeyName(1, "Leads.gif")
        Me.imageCollection1.Images.SetKeyName(2, "Contact.png")
        Me.imageCollection1.Images.SetKeyName(3, "dsuiext.04.ico")
        Me.imageCollection1.Images.SetKeyName(4, "Redshop-icon-supplier.png")
        '
        'homeRibbonPage
        '
        Me.homeRibbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.fileRibbonPageGroup, Me.RibbonPageGroup2, Me.RibbonPageGroup3, Me.RibbonPageGroup4, Me.RibbonPageGroup8, Me.RibbonPageGroup18, Me.RibbonPageGroup24, Me.RibbonPageGroup28, Me.RibbonPageGroup35})
        Me.homeRibbonPage.Name = "homeRibbonPage"
        Me.homeRibbonPage.Text = "กำหนดข้อมูลเริ่มต้น"
        '
        'fileRibbonPageGroup
        '
        Me.fileRibbonPageGroup.ItemLinks.Add(Me.PrefixBar)
        Me.fileRibbonPageGroup.Name = "fileRibbonPageGroup"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.DepartmentBar)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.PositionBar)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.TerritoryBar)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.IndustryTypeBar)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BusinessTypeBar)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.CompanyTypeBar)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.CustomerZoneBar)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.CustomerGroupBar)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.EmployeeBar)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.EmpGroupBar)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        '
        'RibbonPageGroup8
        '
        Me.RibbonPageGroup8.ItemLinks.Add(Me.CurrencyBar)
        Me.RibbonPageGroup8.ItemLinks.Add(Me.CreditRuleBar)
        Me.RibbonPageGroup8.ItemLinks.Add(Me.VatTypeBar)
        Me.RibbonPageGroup8.Name = "RibbonPageGroup8"
        '
        'RibbonPageGroup18
        '
        Me.RibbonPageGroup18.ItemLinks.Add(Me.CreditGroupBar)
        Me.RibbonPageGroup18.Name = "RibbonPageGroup18"
        '
        'RibbonPageGroup24
        '
        Me.RibbonPageGroup24.ItemLinks.Add(Me.TaxTypeBar)
        Me.RibbonPageGroup24.Name = "RibbonPageGroup24"
        '
        'RibbonPageGroup28
        '
        Me.RibbonPageGroup28.ItemLinks.Add(Me.BankBar)
        Me.RibbonPageGroup28.ItemLinks.Add(Me.BankAccounBar)
        Me.RibbonPageGroup28.Name = "RibbonPageGroup28"
        '
        'RibbonPageGroup35
        '
        Me.RibbonPageGroup35.ItemLinks.Add(Me.ProvinceBar)
        Me.RibbonPageGroup35.Name = "RibbonPageGroup35"
        '
        'ProductRibbonPage
        '
        Me.ProductRibbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup6, Me.RibbonPageGroup7, Me.RibbonPageGroup25, Me.RibbonPageGroup29})
        Me.ProductRibbonPage.Name = "ProductRibbonPage"
        Me.ProductRibbonPage.Text = "สินค้า"
        '
        'RibbonPageGroup6
        '
        Me.RibbonPageGroup6.ItemLinks.Add(Me.UnitBar)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.ProductGroupBar)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.ProductDimensionBar)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.ProductCategoryBar)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.ProductTypeBar)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.ProductBrandBar)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.LocationBar)
        Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
        '
        'RibbonPageGroup7
        '
        Me.RibbonPageGroup7.ItemLinks.Add(Me.ProductBar)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.UpdateSNBar)
        Me.RibbonPageGroup7.Name = "RibbonPageGroup7"
        '
        'RibbonPageGroup25
        '
        Me.RibbonPageGroup25.ItemLinks.Add(Me.StockInBar)
        Me.RibbonPageGroup25.ItemLinks.Add(Me.UpdateStockBar)
        Me.RibbonPageGroup25.ItemLinks.Add(Me.CheckStockBar)
        Me.RibbonPageGroup25.Name = "RibbonPageGroup25"
        '
        'RibbonPageGroup29
        '
        Me.RibbonPageGroup29.ItemLinks.Add(Me.OrderHisBar)
        Me.RibbonPageGroup29.ItemLinks.Add(Me.OrderSNHisBar)
        Me.RibbonPageGroup29.ItemLinks.Add(Me.UpdateSNStatusBar)
        Me.RibbonPageGroup29.Name = "RibbonPageGroup29"
        '
        'BuyRibbonPage
        '
        Me.BuyRibbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup12, Me.RibbonPageGroup13, Me.RibbonPageGroup21, Me.RibbonPageGroup20, Me.RibbonPageGroup32, Me.RibbonPageGroup27, Me.RibbonPageGroup33})
        Me.BuyRibbonPage.Name = "BuyRibbonPage"
        Me.BuyRibbonPage.Text = "ฝ่ายซื้อ"
        '
        'RibbonPageGroup12
        '
        Me.RibbonPageGroup12.ItemLinks.Add(Me.AgencyBar)
        Me.RibbonPageGroup12.Name = "RibbonPageGroup12"
        '
        'RibbonPageGroup13
        '
        Me.RibbonPageGroup13.ItemLinks.Add(Me.AssetBar)
        Me.RibbonPageGroup13.ItemLinks.Add(Me.InformPriceBuyBar)
        Me.RibbonPageGroup13.Name = "RibbonPageGroup13"
        '
        'RibbonPageGroup21
        '
        Me.RibbonPageGroup21.ItemLinks.Add(Me.OrderInBar)
        Me.RibbonPageGroup21.ItemLinks.Add(Me.InvoiceBuyBar)
        Me.RibbonPageGroup21.ItemLinks.Add(Me.ShipingBuyBar)
        Me.RibbonPageGroup21.Name = "RibbonPageGroup21"
        '
        'RibbonPageGroup20
        '
        Me.RibbonPageGroup20.ItemLinks.Add(Me.AddCreditBuyBar)
        Me.RibbonPageGroup20.ItemLinks.Add(Me.ReduceCreditBuyBar)
        Me.RibbonPageGroup20.Name = "RibbonPageGroup20"
        '
        'RibbonPageGroup32
        '
        Me.RibbonPageGroup32.ItemLinks.Add(Me.ReceiptBuyBar)
        Me.RibbonPageGroup32.Name = "RibbonPageGroup32"
        '
        'RibbonPageGroup27
        '
        Me.RibbonPageGroup27.ItemLinks.Add(Me.ClaimOutBar)
        Me.RibbonPageGroup27.Name = "RibbonPageGroup27"
        '
        'RibbonPageGroup33
        '
        Me.RibbonPageGroup33.ItemLinks.Add(Me.MakePOBar)
        Me.RibbonPageGroup33.ItemLinks.Add(Me.CancelPOBar)
        Me.RibbonPageGroup33.Name = "RibbonPageGroup33"
        '
        'SaleRibbonPage
        '
        Me.SaleRibbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup10, Me.SaleRibbonPageGroup, Me.RibbonPageGroup11, Me.RibbonPageGroup14, Me.RibbonPageGroup19, Me.RibbonPageGroup26})
        Me.SaleRibbonPage.Name = "SaleRibbonPage"
        Me.SaleRibbonPage.Text = "ฝ่ายขาย"
        '
        'RibbonPageGroup10
        '
        Me.RibbonPageGroup10.ItemLinks.Add(Me.LeadTypeBar)
        Me.RibbonPageGroup10.ItemLinks.Add(Me.SourceBar)
        Me.RibbonPageGroup10.ItemLinks.Add(Me.ContactRoleBar)
        Me.RibbonPageGroup10.ItemLinks.Add(Me.CriterionPriceBar)
        Me.RibbonPageGroup10.ItemLinks.Add(Me.OpportunityTypeBar)
        Me.RibbonPageGroup10.ItemLinks.Add(Me.OpportunityStageBar)
        Me.RibbonPageGroup10.ItemLinks.Add(Me.ShipingMethodyBar, True)
        Me.RibbonPageGroup10.ItemLinks.Add(Me.ShipingByBar)
        Me.RibbonPageGroup10.ItemLinks.Add(Me.ShipingRuleBar)
        Me.RibbonPageGroup10.ItemLinks.Add(Me.BillMethodBar)
        Me.RibbonPageGroup10.ItemLinks.Add(Me.QuotationRemarkBar)
        Me.RibbonPageGroup10.Name = "RibbonPageGroup10"
        '
        'SaleRibbonPageGroup
        '
        Me.SaleRibbonPageGroup.ItemLinks.Add(Me.LeadBar)
        Me.SaleRibbonPageGroup.ItemLinks.Add(Me.ContactBar)
        Me.SaleRibbonPageGroup.ItemLinks.Add(Me.AccountsBar)
        Me.SaleRibbonPageGroup.ItemLinks.Add(Me.VerifyCusBar)
        Me.SaleRibbonPageGroup.ItemLinks.Add(Me.InformPriceBar)
        Me.SaleRibbonPageGroup.ItemLinks.Add(Me.InformPriceProBar)
        Me.SaleRibbonPageGroup.ItemLinks.Add(Me.OrderSellHisBar)
        Me.SaleRibbonPageGroup.Name = "SaleRibbonPageGroup"
        '
        'RibbonPageGroup11
        '
        Me.RibbonPageGroup11.ItemLinks.Add(Me.OpportunityBar)
        Me.RibbonPageGroup11.ItemLinks.Add(Me.ReserveBar)
        Me.RibbonPageGroup11.ItemLinks.Add(Me.QuotationBar)
        Me.RibbonPageGroup11.ItemLinks.Add(Me.OrderBar)
        Me.RibbonPageGroup11.ItemLinks.Add(Me.BorrowBar)
        Me.RibbonPageGroup11.ItemLinks.Add(Me.InvoiceBar)
        Me.RibbonPageGroup11.ItemLinks.Add(Me.ShipingBar)
        Me.RibbonPageGroup11.ItemLinks.Add(Me.CampaignBar)
        Me.RibbonPageGroup11.Name = "RibbonPageGroup11"
        '
        'RibbonPageGroup14
        '
        Me.RibbonPageGroup14.ItemLinks.Add(Me.AddCreditBar)
        Me.RibbonPageGroup14.ItemLinks.Add(Me.ReduceCreditBar)
        Me.RibbonPageGroup14.Name = "RibbonPageGroup14"
        '
        'RibbonPageGroup19
        '
        Me.RibbonPageGroup19.ItemLinks.Add(Me.BillBar)
        Me.RibbonPageGroup19.ItemLinks.Add(Me.ReceiptBar)
        Me.RibbonPageGroup19.ItemLinks.Add(Me.ReceiptCutBar)
        Me.RibbonPageGroup19.Name = "RibbonPageGroup19"
        '
        'RibbonPageGroup26
        '
        Me.RibbonPageGroup26.ItemLinks.Add(Me.ClaimBar)
        Me.RibbonPageGroup26.ItemLinks.Add(Me.ExposeBar)
        Me.RibbonPageGroup26.Name = "RibbonPageGroup26"
        '
        'ChequeRibbonPage
        '
        Me.ChequeRibbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup30})
        Me.ChequeRibbonPage.Name = "ChequeRibbonPage"
        Me.ChequeRibbonPage.Text = "เช็ค"
        '
        'RibbonPageGroup30
        '
        Me.RibbonPageGroup30.ItemLinks.Add(Me.RecordChequeBar)
        Me.RibbonPageGroup30.Name = "RibbonPageGroup30"
        '
        'ApproveRibbonPage
        '
        Me.ApproveRibbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup16, Me.RibbonPageGroup17})
        Me.ApproveRibbonPage.Name = "ApproveRibbonPage"
        Me.ApproveRibbonPage.Text = "อนุมัติเอกสาร"
        '
        'RibbonPageGroup16
        '
        Me.RibbonPageGroup16.ItemLinks.Add(Me.ApproveUserBar)
        Me.RibbonPageGroup16.Name = "RibbonPageGroup16"
        '
        'RibbonPageGroup17
        '
        Me.RibbonPageGroup17.ItemLinks.Add(Me.ApproveTXBar)
        Me.RibbonPageGroup17.Name = "RibbonPageGroup17"
        '
        'AdminRibbonPage
        '
        Me.AdminRibbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup15, Me.RibbonPageGroup1, Me.RibbonPageGroup5, Me.RibbonPageGroup9})
        Me.AdminRibbonPage.Name = "AdminRibbonPage"
        Me.AdminRibbonPage.Text = "จัดการระบบ"
        '
        'RibbonPageGroup15
        '
        Me.RibbonPageGroup15.ItemLinks.Add(Me.CompanyBar)
        Me.RibbonPageGroup15.Name = "RibbonPageGroup15"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.UserBar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.PrivilegeBar)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.ItemLinks.Add(Me.ActivityBar)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        '
        'RibbonPageGroup9
        '
        Me.RibbonPageGroup9.ItemLinks.Add(Me.RunningBar)
        Me.RibbonPageGroup9.Name = "RibbonPageGroup9"
        '
        'ReportRibbonPage
        '
        Me.ReportRibbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup23, Me.RibbonPageGroup31})
        Me.ReportRibbonPage.Name = "ReportRibbonPage"
        Me.ReportRibbonPage.Text = "รายงาน"
        '
        'RibbonPageGroup23
        '
        Me.RibbonPageGroup23.ItemLinks.Add(Me.ReportTaxSellBar)
        Me.RibbonPageGroup23.ItemLinks.Add(Me.ReportTaxAtSellBar)
        Me.RibbonPageGroup23.Name = "RibbonPageGroup23"
        Me.RibbonPageGroup23.Text = "ภาษี"
        '
        'RibbonPageGroup31
        '
        Me.RibbonPageGroup31.ItemLinks.Add(Me.ReportSellAnalyzeBar)
        Me.RibbonPageGroup31.ItemLinks.Add(Me.ReportSNBar)
        Me.RibbonPageGroup31.ItemLinks.Add(Me.ReportDealBar)
        Me.RibbonPageGroup31.Name = "RibbonPageGroup31"
        Me.RibbonPageGroup31.Text = "ฝ่ายขาย"
        '
        'helpRibbonPage
        '
        Me.helpRibbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.helpRibbonPageGroup})
        Me.helpRibbonPage.Name = "helpRibbonPage"
        Me.helpRibbonPage.Text = "Help"
        '
        'helpRibbonPageGroup
        '
        Me.helpRibbonPageGroup.Name = "helpRibbonPageGroup"
        Me.helpRibbonPageGroup.Text = "Help"
        '
        'ViewRibbonPage
        '
        Me.ViewRibbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.skinsRibbonPageGroup})
        Me.ViewRibbonPage.Name = "ViewRibbonPage"
        Me.ViewRibbonPage.Text = "View"
        '
        'skinsRibbonPageGroup
        '
        Me.skinsRibbonPageGroup.ItemLinks.Add(Me.rgbiSkins)
        Me.skinsRibbonPageGroup.Name = "skinsRibbonPageGroup"
        Me.skinsRibbonPageGroup.ShowCaptionButton = False
        Me.skinsRibbonPageGroup.Text = "Skins"
        '
        'RepositoryItemProgressBar1
        '
        Me.RepositoryItemProgressBar1.Name = "RepositoryItemProgressBar1"
        '
        'RepositoryItemMarqueeProgressBar1
        '
        Me.RepositoryItemMarqueeProgressBar1.MarqueeAnimationSpeed = 50
        Me.RepositoryItemMarqueeProgressBar1.Name = "RepositoryItemMarqueeProgressBar1"
        Me.RepositoryItemMarqueeProgressBar1.ProgressAnimationMode = DevExpress.Utils.Drawing.ProgressAnimationMode.Cycle
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.ReadOnly = True
        '
        'ribbonStatusBar
        '
        Me.ribbonStatusBar.ItemLinks.Add(Me.lblVersion)
        Me.ribbonStatusBar.ItemLinks.Add(Me.lblCompany)
        Me.ribbonStatusBar.ItemLinks.Add(Me.lblUser, True)
        Me.ribbonStatusBar.ItemLinks.Add(Me.lblEmp, True)
        Me.ribbonStatusBar.ItemLinks.Add(Me.lblDatabase, True)
        Me.ribbonStatusBar.Location = New System.Drawing.Point(0, 639)
        Me.ribbonStatusBar.Name = "ribbonStatusBar"
        Me.ribbonStatusBar.Ribbon = Me.ribbonMain
        Me.ribbonStatusBar.Size = New System.Drawing.Size(1235, 31)
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.AllowDragDrop = DevExpress.Utils.DefaultBoolean.[False]
        Me.XtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeaderAndOnMouseHover
        Me.XtraTabbedMdiManager1.HeaderButtons = CType(((DevExpress.XtraTab.TabButtons.Prev Or DevExpress.XtraTab.TabButtons.[Next]) _
            Or DevExpress.XtraTab.TabButtons.Close), DevExpress.XtraTab.TabButtons)
        Me.XtraTabbedMdiManager1.HeaderButtonsShowMode = DevExpress.XtraTab.TabButtonShowMode.WhenNeeded
        Me.XtraTabbedMdiManager1.MdiParent = Me
        Me.XtraTabbedMdiManager1.SetNextMdiChildMode = DevExpress.XtraTabbedMdi.SetNextMdiChildMode.Windows
        Me.XtraTabbedMdiManager1.ShowHeaderFocus = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabbedMdiManager1.TabPageWidth = 120
        Me.XtraTabbedMdiManager1.UseDocumentSelector = DevExpress.Utils.DefaultBoolean.[True]
        '
        'MenuNavBarControl
        '
        Me.MenuNavBarControl.ActiveGroup = Me.MenuNavBarGroup
        Me.MenuNavBarControl.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuNavBarControl.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.MenuNavBarGroup})
        Me.MenuNavBarControl.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.AdminBar, Me.CrmBar, Me.AccountBar, Me.ExitBar})
        Me.MenuNavBarControl.LargeImages = Me.ImageMenu
        Me.MenuNavBarControl.Location = New System.Drawing.Point(0, 144)
        Me.MenuNavBarControl.Name = "MenuNavBarControl"
        Me.MenuNavBarControl.OptionsNavPane.ExpandedWidth = 60
        Me.MenuNavBarControl.Size = New System.Drawing.Size(60, 495)
        Me.MenuNavBarControl.SmallImages = Me.ImageMenu
        Me.MenuNavBarControl.TabIndex = 9
        Me.MenuNavBarControl.Text = "NavBarControl1"
        '
        'MenuNavBarGroup
        '
        Me.MenuNavBarGroup.Caption = ""
        Me.MenuNavBarGroup.Expanded = True
        Me.MenuNavBarGroup.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsList
        Me.MenuNavBarGroup.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.AdminBar), New DevExpress.XtraNavBar.NavBarItemLink(Me.CrmBar), New DevExpress.XtraNavBar.NavBarItemLink(Me.AccountBar), New DevExpress.XtraNavBar.NavBarItemLink(Me.ExitBar)})
        Me.MenuNavBarGroup.Name = "MenuNavBarGroup"
        '
        'AdminBar
        '
        Me.AdminBar.Caption = "0000"
        Me.AdminBar.Enabled = False
        Me.AdminBar.LargeImageIndex = 2
        Me.AdminBar.Name = "AdminBar"
        Me.AdminBar.SmallImageIndex = 2
        '
        'CrmBar
        '
        Me.CrmBar.Caption = ""
        Me.CrmBar.Name = "CrmBar"
        Me.CrmBar.SmallImageIndex = 3
        '
        'AccountBar
        '
        Me.AccountBar.Caption = ""
        Me.AccountBar.Enabled = False
        Me.AccountBar.Name = "AccountBar"
        Me.AccountBar.SmallImageIndex = 4
        '
        'ExitBar
        '
        Me.ExitBar.Caption = ""
        Me.ExitBar.Name = "ExitBar"
        Me.ExitBar.SmallImageIndex = 0
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Id = -1
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Id = -1
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1235, 670)
        Me.Controls.Add(Me.MenuNavBarControl)
        Me.Controls.Add(Me.ribbonStatusBar)
        Me.Controls.Add(Me.ribbonMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Ribbon = Me.ribbonMain
        Me.StatusBar = Me.ribbonStatusBar
        Me.Text = "Unique Business Center"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ribbonMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.appMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMarqueeProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuNavBarControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents ribbonMain As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents homeRibbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents fileRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents skinsRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents helpRibbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents helpRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents appMenu As DevExpress.XtraBars.Ribbon.ApplicationMenu
    Private WithEvents ribbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents rgbiSkins As DevExpress.XtraBars.RibbonGalleryBarItem
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents MenuNavBarControl As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents MenuNavBarGroup As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents LeadBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SaleRibbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents SaleRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents imageCollection1 As DevExpress.Utils.ImageCollection
    Private WithEvents ImageMenu As DevExpress.Utils.ImageCollection
    Friend WithEvents PrefixBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ViewRibbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RepositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents LeadTypeBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SourceBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents AdminBar As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents CrmBar As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents AccountBar As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents ExitBar As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents PrivilegeBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents AdminRibbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents DepartmentBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents PositionBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents IndustryTypeBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BusinessTypeBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents TerritoryBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents EmployeeBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents UserBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemMarqueeProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents lblCompany As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lblUser As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lblVersion As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lblEmp As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents ActivityBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents UnitBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ProductGroupBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ProductDimensionBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ProductCategoryBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ProductBrandBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ProductTypeBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents EmpGroupBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LocationBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ProductRibbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents ProductBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ContactRoleBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents CreditRuleBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup8 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents CurrencyBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ContactBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents AccountsBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RunningBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup9 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents VerifyCusBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents OpportunityBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents OpportunityTypeBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup10 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup11 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents OpportunityStageBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents VatTypeBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents OrderBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents QuotationBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup7 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents CriterionPriceBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents InformPriceBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents CompanyTypeBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents StockInBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ShipingMethodyBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ShipingByBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents InvoiceBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ShipingBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BillMethodBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BillBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents CheckStockBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents AgencyBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BuyRibbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup12 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents OrderInBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup13 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup14 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents CompanyBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup15 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ApproveRibbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents ApproveUserBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup16 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ApproveTXBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup17 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents CreditGroupBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup18 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents AddCreditBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ReserveBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ReceiptBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ReduceCreditBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonGroup1 As DevExpress.XtraBars.BarButtonGroup
    Friend WithEvents AssetBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents InformPriceBuyBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup19 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ShipingRuleBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents AddCreditBuyBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ReduceCreditBuyBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup20 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents InvoiceBuyBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup21 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ReportTaxSellBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ReportRibbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup23 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents TaxTypeBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup24 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents CustomerZoneBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents CustomerGroupBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ClaimBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ClaimOutBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup27 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup26 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents UpdateStockBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup25 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ReceiptBuyBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BankAccounBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup28 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents OrderHisBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup29 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BorrowBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ShipingBuyBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RecordChequeBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ChequeRibbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup30 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ReceiptCutBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup31 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ReportSellAnalyzeBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup32 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents UpdateSNBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ReportTaxAtSellBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ReportSNBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ExposeBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents OrderSNHisBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MakePOBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup33 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents CancelPOBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents QuotationRemarkBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents InformPriceProBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents CampaignBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ReportDealBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents UpdateSNStatusBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BankBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents OrderSellHisBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ProvinceBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup35 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents lblDatabase As DevExpress.XtraBars.BarStaticItem

End Class
