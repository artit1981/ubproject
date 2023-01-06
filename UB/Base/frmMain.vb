Imports System.Deployment.Application
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraEditors

Public Class frmMain
    'Constant for english language
    Private Const _ENGLISH As String = "ENGL"
    'Constant for thai language
    Private Const _THAI As String = "THAI"
    'Public WithEvents backgroundWorker1 As System.ComponentModel.BackgroundWorker
    'Private fprogress As frmProgress = Nothing
#Region "Show form"
    Private Sub SetMenuPrivilege()
        Try
            Dim lcls As New MenuADO
            Dim dataTable As New DataTable()
            SetBarControl("", False, False)

            dataTable = lcls.GetDataTable
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    Call SetPrivilege(dr("MenuName").ToString, dr("MenuID"))
                Next
            End If
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub SetPrivilege(ByVal pMenuName As String, ByVal pMenuID As Long)
        Try
            Dim lcls As New PrivilegeDAO
            Dim lIsVisible As Boolean, lIsEnable As Boolean
            If lcls.InitailData(gPrivilegeID, pMenuID) Then
                lIsVisible = (lcls.PrivilegeData And Privilege.Visible) = Privilege.Visible
                lIsEnable = (lcls.PrivilegeData And Privilege.Enable) = Privilege.Enable
                SetBarControl(pMenuName, lIsVisible, lIsEnable)
            End If
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Public Sub SetBarControl(ByVal pMenu As String, ByVal pIsvisible As Boolean, ByRef pIsEnable As Boolean)
        For Each ctrControl1 As DevExpress.XtraBars.Ribbon.RibbonPage In ribbonMain.Pages
            For Each ctrControl2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup In ctrControl1.Groups

                For Each ctrControl3 As DevExpress.XtraBars.BarButtonItemLink In ctrControl2.ItemLinks
                    Dim ctrControl4 As DevExpress.XtraBars.BarButtonItem = ctrControl3.Item
                    If Object.ReferenceEquals(ctrControl4.[GetType](), GetType(DevExpress.XtraBars.BarButtonItem)) Then
                        If pMenu = "" Then
                            DirectCast(ctrControl4, DevExpress.XtraBars.BarButtonItem).Enabled = False
                        ElseIf pMenu.ToUpper = ctrControl4.Name.ToUpper Then
                            DirectCast(ctrControl4, DevExpress.XtraBars.BarButtonItem).Enabled = pIsEnable
                            DirectCast(ctrControl4, DevExpress.XtraBars.BarButtonItem).Visibility = IIf(pIsvisible = True, DevExpress.XtraBars.BarItemVisibility.Always, DevExpress.XtraBars.BarItemVisibility.Never)
                        End If

                    End If
                Next

            Next

        Next


        'For Each ctrControl As DevExpress.XtraBars.BarButtonItem In pParent.Ribbon.Controls
        '    If Object.ReferenceEquals(ctrControl.[GetType](), GetType(DevExpress.XtraBars.BarButtonItem)) Then
        '        If pMenu = "" Then
        '            DirectCast(ctrControl, DevExpress.XtraBars.BarButtonItem).Enabled = False
        '        ElseIf pMenu.ToUpper = ctrControl.Name.ToUpper Then
        '            DirectCast(ctrControl, DevExpress.XtraBars.BarButtonItem).Enabled = pIsEnable
        '            DirectCast(ctrControl, DevExpress.XtraBars.BarButtonItem).Visibility = IIf(pIsvisible = True, DevExpress.XtraBars.BarItemVisibility.Always, DevExpress.XtraBars.BarItemVisibility.Never)
        '        End If

        '    End If

        'Next
    End Sub

    Private Sub ShowMaster(ByVal pMasterType As MasterType)
        Try
            ShowProgress(True, "Loading...")
            Dim lcls As New MasterControl
            lcls.Execute(pMasterType)
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub


    Private Sub ShowDataOnControl(ByRef pcls As iControl, ByVal pOrderType As Integer)
        Try
            ShowProgress(True, "Loading...")
            pcls.Execute(pOrderType)
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

#End Region


    Sub New()
        frmSplash.Show()
        InitializeComponent()
        Me.InitSkinGallery()
        SetMenuPrivilege()
        ChangeLanguage()

    End Sub


    Private Sub InitSkinGallery()
        SkinHelper.InitSkinGallery(rgbiSkins, True)
    End Sub

    Private Sub frmMain_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        AppConfigFileSettings.UpdateAppSettings("SkinName", UserLookAndFeel.Default.SkinName)
        AppConfigFileSettings.UpdateAppSettings("OpenTab", ribbonMain.SelectedPage.Name)
        InsertActivity(DataMode.ModeLogOut, 0, "", Nothing)
        System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Select Case gOpenTab
                Case "SaleRibbonPage"
                    ribbonMain.SelectedPage = SaleRibbonPage
                Case "ProductRibbonPage"
                    ribbonMain.SelectedPage = ProductRibbonPage
                Case "AdminRibbonPage"
                    ribbonMain.SelectedPage = AdminRibbonPage
                Case "BuyRibbonPage"
                    ribbonMain.SelectedPage = BuyRibbonPage
                Case "ApproveRibbonPage"
                    ribbonMain.SelectedPage = ApproveRibbonPage
                Case "ReportRibbonPage"
                    ribbonMain.SelectedPage = ReportRibbonPage
                Case "ChequeRibbonPage"
                    ribbonMain.SelectedPage = ChequeRibbonPage
                Case Else
                    ribbonMain.SelectedPage = homeRibbonPage
            End Select


            'ribbonMain.Minimized = True
            If (ApplicationDeployment.IsNetworkDeployed) Then
                lblVersion.Caption = "Version : " & ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString
            Else
                lblVersion.Caption = "Version : " & Application.ProductVersion
            End If

            lblDatabase.Caption = gDBServerName & "\" & gDatabaseName
            lblUser.Caption = gUserName
            lblEmp.Caption = gEmpName
            lblCompany.Caption = gCompanyName


            ShowNotifi(True)
            ShowOverdue(True)
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            frmSplash.Hide()
        End Try


    End Sub

#Region "ItemClick"
    Private Sub LeadBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles LeadBar.ItemClick
        Dim lcls As New LeadControl
        ShowDataOnControl(lcls, MasterType.Lead)
        InsertActivity(DataMode.ModeOpen, MasterType.Lead, "", Nothing)
    End Sub

    Private Sub PrefixBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles PrefixBar.ItemClick
        ShowMaster(MasterType.Prefix)
        InsertActivity(DataMode.ModeOpen, MasterType.Prefix, "", Nothing)
    End Sub

    Private Sub LeadTypeBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles LeadTypeBar.ItemClick
        ShowMaster(MasterType.LeadType)
        InsertActivity(DataMode.ModeOpen, MasterType.LeadType, "", Nothing)
    End Sub

    Private Sub SourceBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles SourceBar.ItemClick
        ShowMaster(MasterType.Source)
        InsertActivity(DataMode.ModeOpen, MasterType.Source, "", Nothing)
    End Sub

    Private Sub ExitBar_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles ExitBar.LinkClicked
        Me.Close()
        'Application.Exit()
    End Sub

    Private Sub PrivilegeBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles PrivilegeBar.ItemClick
        Dim lcls As New PrevilegeControl
        ShowDataOnControl(lcls, MasterType.Privilege)
        InsertActivity(DataMode.ModeOpen, MasterType.Privilege, "", Nothing)
    End Sub

    Private Sub DepartmentBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles DepartmentBar.ItemClick
        Dim lcls As New DepartmentControl
        ShowDataOnControl(lcls, MasterType.Department)
        InsertActivity(DataMode.ModeOpen, MasterType.Department, "", Nothing)
    End Sub

    Private Sub PositionBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles PositionBar.ItemClick
        Dim lcls As New PositionControl
        ShowDataOnControl(lcls, MasterType.Position)
        InsertActivity(DataMode.ModeOpen, MasterType.Position, "", Nothing)
    End Sub

    Private Sub IndustryTypeBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles IndustryTypeBar.ItemClick
        ShowMaster(MasterType.IndustryType)
        InsertActivity(DataMode.ModeOpen, MasterType.IndustryType, "", Nothing)
    End Sub

    Private Sub BusinessTypeBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BusinessTypeBar.ItemClick
        ShowMaster(MasterType.BusinessType)
        InsertActivity(DataMode.ModeOpen, MasterType.BusinessType, "", Nothing)
    End Sub

    Private Sub TerritoryBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles TerritoryBar.ItemClick
        Dim lcls As New TerritoryControl
        ShowDataOnControl(lcls, MasterType.Territory)
        InsertActivity(DataMode.ModeOpen, MasterType.Territory, "", Nothing)
    End Sub

    Private Sub EmployeeBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles EmployeeBar.ItemClick
        Dim lcls As New EmployeeControl
        ShowDataOnControl(lcls, MasterType.Employee)
        InsertActivity(DataMode.ModeOpen, MasterType.Employee, "", Nothing)
    End Sub

    Private Sub UserBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles UserBar.ItemClick
        Dim lcls As New UserControl
        ShowDataOnControl(lcls, MasterType.User)
        InsertActivity(DataMode.ModeOpen, MasterType.User, "", Nothing)
    End Sub


    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub ActivityBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ActivityBar.ItemClick
        InsertActivity(DataMode.ModeOpen, MasterType.ActivityBar, "", Nothing)
        frmActivityLog.MdiParent = Me
        frmActivityLog.Show()
    End Sub

    Private Sub UnitBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles UnitBar.ItemClick
        Dim lcls As New UnitControl
        ShowDataOnControl(lcls, MasterType.UnitBar)
        InsertActivity(DataMode.ModeOpen, MasterType.UnitBar, "", Nothing)
    End Sub

    Private Sub ProductGroupBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ProductGroupBar.ItemClick
        ShowMaster(MasterType.ProductGroup)
        InsertActivity(DataMode.ModeOpen, MasterType.ProductGroup, "", Nothing)
    End Sub

    Private Sub ProductDimensionBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ProductDimensionBar.ItemClick
        ShowMaster(MasterType.ProductDimension)
        InsertActivity(DataMode.ModeOpen, MasterType.ProductDimension, "", Nothing)
    End Sub

    Private Sub ProductCategoryBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ProductCategoryBar.ItemClick
        Dim lcls As New ProductCategoryControl
        ShowDataOnControl(lcls, MasterType.ProductCategory)
        InsertActivity(DataMode.ModeOpen, MasterType.ProductCategory, "", Nothing)
    End Sub

    Private Sub ProductBrandBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ProductBrandBar.ItemClick
        Dim lcls As New ProductBrandControl
        ShowDataOnControl(lcls, MasterType.ProductBrand)
        InsertActivity(DataMode.ModeOpen, MasterType.ProductBrand, "", Nothing)
    End Sub

    Private Sub ProductTypeBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ProductTypeBar.ItemClick
        Dim lcls As New ProductTypeControl
        ShowDataOnControl(lcls, MasterType.ProductType)
        InsertActivity(DataMode.ModeOpen, MasterType.ProductType, "", Nothing)
    End Sub

    Private Sub EmpGroupBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles EmpGroupBar.ItemClick
        ShowMaster(MasterType.EmpGroup)
        InsertActivity(DataMode.ModeOpen, MasterType.EmpGroup, "", Nothing)
    End Sub

    Private Sub LocationBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles LocationBar.ItemClick
        Dim lcls As New LocationControl
        ShowDataOnControl(lcls, MasterType.Location)
        InsertActivity(DataMode.ModeOpen, MasterType.Location, "", Nothing)
    End Sub

    Private Sub ProductBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ProductBar.ItemClick
        Dim lcls As New ProductControl
        ShowDataOnControl(lcls, MasterType.Product)
        InsertActivity(DataMode.ModeOpen, MasterType.Product, "", Nothing)
    End Sub

    Private Sub ContactRoleBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ContactRoleBar.ItemClick
        ShowMaster(MasterType.ContactRole)
        InsertActivity(DataMode.ModeOpen, MasterType.ContactRole, "", Nothing)
    End Sub

    Private Sub CreditRuleBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CreditRuleBar.ItemClick
        Dim lcls As New CreditRoleControl
        ShowDataOnControl(lcls, MasterType.ContactRole)
        InsertActivity(DataMode.ModeOpen, MasterType.ContactRole, "", Nothing)
    End Sub

    Private Sub CurrencyBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CurrencyBar.ItemClick
        Dim lcls As New CurrencyControl
        ShowDataOnControl(lcls, MasterType.Currency)
        InsertActivity(DataMode.ModeOpen, MasterType.Currency, "", Nothing)
    End Sub

    Private Sub ContactBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ContactBar.ItemClick
        Dim lcls As New ContactControl
        ShowDataOnControl(lcls, MasterType.Contacts)
        InsertActivity(DataMode.ModeOpen, MasterType.Contacts, "", Nothing)
    End Sub

    Private Sub AccountsBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles AccountsBar.ItemClick
        Dim lcls As New AccountControl
        ShowDataOnControl(lcls, MasterType.Accounts)
        InsertActivity(DataMode.ModeOpen, MasterType.Accounts, "", Nothing)
    End Sub

    Private Sub RunningBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles RunningBar.ItemClick
        Dim lcls As New RunnignFormatControl
        ShowDataOnControl(lcls, MasterType.RunningFormat)
        InsertActivity(DataMode.ModeOpen, MasterType.RunningFormat, "", Nothing)
    End Sub

    Private Sub VerifyCusBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles VerifyCusBar.ItemClick
        frmVerifyCustomer.Show()
    End Sub

    Private Sub OpportunityTypeBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles OpportunityTypeBar.ItemClick
        ShowMaster(MasterType.OpportunityType)
        InsertActivity(DataMode.ModeOpen, MasterType.OpportunityType, "", Nothing)
    End Sub

    Private Sub OpportunityStageBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles OpportunityStageBar.ItemClick
        Dim lcls As New OpportunityStageControl
        ShowDataOnControl(lcls, MasterType.OpportunityStage)
        InsertActivity(DataMode.ModeOpen, MasterType.OpportunityStage, "", Nothing)
    End Sub

    Private Sub OpportunityBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles OpportunityBar.ItemClick
        Dim lcls As New OpportunityControl
        ShowDataOnControl(lcls, MasterType.Opportunity)
        InsertActivity(DataMode.ModeOpen, MasterType.Opportunity, "", Nothing)
    End Sub

    Private Sub VatTypeBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles VatTypeBar.ItemClick
        Dim lcls As New VatTypeControl
        ShowDataOnControl(lcls, MasterType.VatType)
        InsertActivity(DataMode.ModeOpen, MasterType.VatType, "", Nothing)
    End Sub

    Private Sub OrderBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles OrderBar.ItemClick
        Dim lcls As New OrderControl
        ShowDataOnControl(lcls, MasterType.SellOrders)
        InsertActivity(DataMode.ModeOpen, MasterType.SellOrders, "", Nothing)
    End Sub

    Private Sub QuotationBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles QuotationBar.ItemClick
        Dim lcls As New OrderControl
        ShowDataOnControl(lcls, MasterType.Quotation)
        InsertActivity(DataMode.ModeOpen, MasterType.Quotation, "", Nothing)
    End Sub

    Private Sub CriterionPriceBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CriterionPriceBar.ItemClick
        ShowMaster(MasterType.CriterionPrice)
        InsertActivity(DataMode.ModeOpen, MasterType.CriterionPrice, "", Nothing)
    End Sub

    Private Sub InformPriceBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles InformPriceBar.ItemClick
        Dim lcls As New InformPriceControl
        ShowDataOnControl(lcls, MasterType.InformPrice)
        InsertActivity(DataMode.ModeOpen, MasterType.InformPrice, "", Nothing)
    End Sub


    Private Sub CompanyTypeBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CompanyTypeBar.ItemClick
        ShowMaster(MasterType.CompanyType)
        InsertActivity(DataMode.ModeOpen, MasterType.CompanyType, "", Nothing)
    End Sub

    Private Sub StockInBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles StockInBar.ItemClick
        Dim lcls As New OrderControl
        ShowDataOnControl(lcls, MasterType.StockIn)
        InsertActivity(DataMode.ModeOpen, MasterType.StockIn, "", Nothing)
    End Sub

    Private Sub ShipingMethodyBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ShipingMethodyBar.ItemClick
        ShowMaster(MasterType.ShipingMethod)
        InsertActivity(DataMode.ModeOpen, MasterType.ShipingMethod, "", Nothing)
    End Sub

    Private Sub ShipingByBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ShipingByBar.ItemClick
        ShowMaster(MasterType.ShipingBy)
        InsertActivity(DataMode.ModeOpen, MasterType.ShipingBy, "", Nothing)
    End Sub

    Private Sub BillMethodBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BillMethodBar.ItemClick
        ShowMaster(MasterType.BillMedthod)
        InsertActivity(DataMode.ModeOpen, MasterType.BillMedthod, "", Nothing)
    End Sub

    Private Sub BillBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BillBar.ItemClick
        Dim lcls As New OrderControl
        ShowDataOnControl(lcls, MasterType.Bill)
        InsertActivity(DataMode.ModeOpen, MasterType.Bill, "", Nothing)
    End Sub

    Private Sub InvoiceBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles InvoiceBar.ItemClick
        Dim lcls As New OrderControl
        ShowDataOnControl(lcls, MasterType.Invoice)
        InsertActivity(DataMode.ModeOpen, MasterType.Invoice, "", Nothing)
    End Sub

    Private Sub ShipingBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ShipingBar.ItemClick
        Dim lcls As New OrderControl
        ShowDataOnControl(lcls, MasterType.Shiping)
        InsertActivity(DataMode.ModeOpen, MasterType.Shiping, "", Nothing)
    End Sub

    Private Sub CheckStockBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CheckStockBar.ItemClick
        frmCheckStock.MdiParent = Me
        frmCheckStock.Show()
    End Sub

    Private Sub AgencyBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles AgencyBar.ItemClick
        Dim lcls As New AgencyControl
        ShowDataOnControl(lcls, MasterType.Agency)
        InsertActivity(DataMode.ModeOpen, MasterType.Agency, "", Nothing)
    End Sub

    Private Sub OrderInBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles OrderInBar.ItemClick
        Dim lcls As New OrderControl
        ShowDataOnControl(lcls, MasterType.PurchaseOrder)
        InsertActivity(DataMode.ModeOpen, MasterType.PurchaseOrder, "", Nothing)
    End Sub



    Private Sub CompanyBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CompanyBar.ItemClick
        Dim lcls As New CompanyControl
        ShowDataOnControl(lcls, MasterType.Company)
        InsertActivity(DataMode.ModeOpen, MasterType.Company, "", Nothing)
    End Sub

    Private Sub ApproveUserBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ApproveUserBar.ItemClick
        Dim lFormEdit As frmApproveUser
        Try
            ShowProgress(True, "Loading...")
            lFormEdit = New frmApproveUser
            With lFormEdit
                .Caption = "ผู้อนุมัติ"
                .MdiParent = Me
                .ModeData = DataMode.ModeEdit
                .IDs = 1
                .Show()
                ShowProgress(False, "")
            End With
            InsertActivity(DataMode.ModeOpen, MasterType.ApproveUser, "", Nothing)
        Catch ex As Exception
            ShowProgress(False, "")
            Err.Raise(Err.Number, ex.Source, "CreditRoleControl.ShowForm : " & ex.Message)
        End Try

    End Sub

    Private Sub ApproveTXBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ApproveTXBar.ItemClick
        Dim lFormEdit As frmApproveTX
        Try
            ShowProgress(True, "Loading...")
            lFormEdit = New frmApproveTX
            With lFormEdit
                .Caption = "อนุมัติรายการ"
                .MdiParent = Me
                .ModeData = DataMode.ModeNew
                .IDs = 1
                .Show()
                ShowProgress(False, "")
            End With
            InsertActivity(DataMode.ModeOpen, MasterType.ApproveTX, "", Nothing)
        Catch ex As Exception
            ShowProgress(False, "")
            Err.Raise(Err.Number, ex.Source, "CreditRoleControl.ShowForm : " & ex.Message)
        End Try
    End Sub

    Private Sub CreditGroupBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CreditGroupBar.ItemClick
        Dim lcls As New CreditGroupControl
        ShowDataOnControl(lcls, MasterType.CreditGroup)
        InsertActivity(DataMode.ModeOpen, MasterType.CreditGroup, "", Nothing)
    End Sub

    Private Sub AddCreditBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles AddCreditBar.ItemClick
        Dim lcls As New OrderControl
        ShowDataOnControl(lcls, MasterType.AddCredit)
        InsertActivity(DataMode.ModeOpen, MasterType.AddCredit, "", Nothing)
    End Sub

    Private Sub ReserveBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ReserveBar.ItemClick
        Dim lcls As New OrderControl
        ShowDataOnControl(lcls, MasterType.Reserve)
        InsertActivity(DataMode.ModeOpen, MasterType.Reserve, "", Nothing)
    End Sub

#End Region

    Private Sub ReceiptBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ReceiptBar.ItemClick
        Dim lcls As New OrderControl
        ShowDataOnControl(lcls, MasterType.Receipt)
        InsertActivity(DataMode.ModeOpen, MasterType.Receipt, "", Nothing)
    End Sub

    Private Sub InformPriceBuyBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles InformPriceBuyBar.ItemClick
        Dim lcls As New InformPriceBuyControl
        ShowDataOnControl(lcls, MasterType.InformPriceBuy)
        InsertActivity(DataMode.ModeOpen, MasterType.InformPriceBuy, "", Nothing)

    End Sub

    Private Sub ReduceCreditBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ReduceCreditBar.ItemClick
        Dim lcls As New OrderControl
        ShowDataOnControl(lcls, MasterType.ReduceCredit)
        InsertActivity(DataMode.ModeOpen, MasterType.ReduceCredit, "", Nothing)
    End Sub

    Private Sub AssetBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles AssetBar.ItemClick
        Dim lcls As New OrderControl
        ShowDataOnControl(lcls, MasterType.Asset)
        InsertActivity(DataMode.ModeOpen, MasterType.Asset, "", Nothing)
    End Sub

    Private Sub ShipingRuleBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ShipingRuleBar.ItemClick
        ShowMaster(MasterType.ShipingRule)
        InsertActivity(DataMode.ModeOpen, MasterType.ShipingRule, "", Nothing)
    End Sub

    Private Sub AddCreditBuyBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles AddCreditBuyBar.ItemClick
        Dim lcls As New OrderControl
        ShowDataOnControl(lcls, MasterType.AddCreditBuy)
        InsertActivity(DataMode.ModeOpen, MasterType.AddCreditBuy, "", Nothing)
    End Sub

    Private Sub ReduceCreditBuyBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ReduceCreditBuyBar.ItemClick
        Dim lcls As New OrderControl
        ShowDataOnControl(lcls, MasterType.ReduceCreditBuy)
        InsertActivity(DataMode.ModeOpen, MasterType.ReduceCreditBuy, "", Nothing)
    End Sub

    Private Sub InvoiceBuyBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles InvoiceBuyBar.ItemClick
        Dim lcls As New OrderControl
        ShowDataOnControl(lcls, MasterType.InvoiceBuy)
        InsertActivity(DataMode.ModeOpen, MasterType.InvoiceBuy, "", Nothing)
    End Sub

    Private Sub ReportTaxSellBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ReportTaxSellBar.ItemClick
        frmTaxReport.MdiParent = Me
        frmTaxReport.Show()
        InsertActivity(DataMode.ModeOpen, MasterType.ReportTaxSell, "", Nothing)
    End Sub

    Private Sub TaxTypeBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles TaxTypeBar.ItemClick
        ShowMaster(MasterType.TaxType)
        InsertActivity(DataMode.ModeOpen, MasterType.TaxType, "", Nothing)
    End Sub

    Private Sub CustomerZoneBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CustomerZoneBar.ItemClick
        ShowMaster(MasterType.CustomerZone)
        InsertActivity(DataMode.ModeOpen, MasterType.CustomerZone, "", Nothing)
    End Sub

    Private Sub CustomerGroupBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CustomerGroupBar.ItemClick
        ShowMaster(MasterType.CustomerGroup)
        InsertActivity(DataMode.ModeOpen, MasterType.CustomerGroup, "", Nothing)
    End Sub
    Private Sub QuotationRemarkBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles QuotationRemarkBar.ItemClick
        ShowMaster(MasterType.QuotationRemark)
        InsertActivity(DataMode.ModeOpen, MasterType.QuotationRemark, "", Nothing)
    End Sub
    Private Sub ClaimBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ClaimBar.ItemClick
        Dim lcls As New OrderControl
        ShowDataOnControl(lcls, MasterType.Claim)
        InsertActivity(DataMode.ModeOpen, MasterType.Claim, "", Nothing)
    End Sub

    Private Sub ClaimOutBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ClaimOutBar.ItemClick
        Dim lcls As New OrderControl
        ShowDataOnControl(lcls, MasterType.ClaimOut)
        InsertActivity(DataMode.ModeOpen, MasterType.ClaimOut, "", Nothing)
    End Sub

    Private Sub BankAccounBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BankAccounBar.ItemClick
        Dim lcls As New BankAccountControl
        ShowDataOnControl(lcls, MasterType.BankAccount)
        InsertActivity(DataMode.ModeOpen, MasterType.BankAccount, "", Nothing)
    End Sub

    Private Sub OrderHisBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles OrderHisBar.ItemClick
        Try

            Dim lFormEdit As New frmOrderHis
            With lFormEdit
                .Show()
                InsertActivity(DataMode.ModeOpen, MasterType.OrderHis, "", Nothing)
            End With

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub ReceiptBuyBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ReceiptBuyBar.ItemClick
        Dim lcls As New OrderControl
        ShowDataOnControl(lcls, MasterType.ReceiptBuy)
        InsertActivity(DataMode.ModeOpen, MasterType.ReceiptBuy, "", Nothing)
    End Sub

    Private Sub ShipingBuyBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ShipingBuyBar.ItemClick
        Dim lcls As New OrderControl
        ShowDataOnControl(lcls, MasterType.ShipingBuy)
        InsertActivity(DataMode.ModeOpen, MasterType.ShipingBuy, "", Nothing)
    End Sub

    Private Sub BorrowBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BorrowBar.ItemClick
        Dim lcls As New OrderControl
        ShowDataOnControl(lcls, MasterType.Borrow)
        InsertActivity(DataMode.ModeOpen, MasterType.Borrow, "", Nothing)
    End Sub

    Private Sub RecordChequeBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles RecordChequeBar.ItemClick
        Try

            Dim lFormEdit As New frmChequeStatus
            With lFormEdit
                .MdiParent = Me
                .Show()
                InsertActivity(DataMode.ModeOpen, MasterType.RecordCheque, "", Nothing)
            End With

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub BankAccountRecordBar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BankAccountRecordBar.ItemClick
        Try

            Dim lFormEdit As New frmBankAccountRec
            With lFormEdit
                .MdiParent = Me
                .Show()
                InsertActivity(DataMode.ModeOpen, MasterType.BankAccountRecord, "", Nothing)
            End With

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub ReceiptCutBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ReceiptCutBar.ItemClick
        Dim lcls As New OrderControl
        ShowDataOnControl(lcls, MasterType.ReceiptCut)
        InsertActivity(DataMode.ModeOpen, MasterType.ReceiptCut, "", Nothing)
    End Sub

    Private Sub ReportSellAnalyzeBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ReportSellAnalyzeBar.ItemClick
        frmCommReport.MdiParent = Me
        frmCommReport.Show()
        InsertActivity(DataMode.ModeOpen, MasterType.ReportSellAnalyze, "", Nothing)
    End Sub

    Private Sub UpdateDatabar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try

            modUpdateData.MoveStockIn()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally

        End Try
    End Sub

    Private Sub UpdateSNBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles UpdateSNBar.ItemClick
        ShowProgress(True, "Loading...")
        frmProductSN.MdiParent = Me
        frmProductSN.Show()
        ShowProgress(False, "")
        InsertActivity(DataMode.ModeOpen, MasterType.UpdateSN, "", Nothing)
    End Sub

    Private Sub ReportTaxAtSellBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ReportTaxAtSellBar.ItemClick
        frmTaxAtSellReport.MdiParent = Me
        frmTaxAtSellReport.Show()
        InsertActivity(DataMode.ModeOpen, MasterType.ReportTaxAtSell, "", Nothing)
    End Sub

    Private Sub ReportSNBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ReportSNBar.ItemClick
        frmSN.MdiParent = Me
        frmSN.IsModePrint = True
        frmSN.Show()
        InsertActivity(DataMode.ModeOpen, MasterType.ReportSN, "", Nothing)
    End Sub

    Private Sub ExposeBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ExposeBar.ItemClick
        Dim lcls As New OrderControl
        ShowDataOnControl(lcls, MasterType.Expose)
        InsertActivity(DataMode.ModeOpen, MasterType.Expose, "", Nothing)
    End Sub

    Private Sub OrderSNHisBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles OrderSNHisBar.ItemClick
        Try

            Dim lFormEdit As New frmSNList
            With lFormEdit
                .Show()
                InsertActivity(DataMode.ModeOpen, MasterType.OrderSNHis, "", Nothing)
            End With

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub MakePOBar_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles MakePOBar.ItemClick
        Dim lFormEdit As New frmFindReserve
        lFormEdit.MdiParent = Me
        lFormEdit.Show()
        InsertActivity(DataMode.ModeOpen, MasterType.MakePO, "", Nothing)
    End Sub

    Private Sub CancelPOBar_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CancelPOBar.ItemClick
        Dim lcls As New OrderControl
        ShowDataOnControl(lcls, MasterType.CancelPO)
        InsertActivity(DataMode.ModeOpen, MasterType.CancelPO, "", Nothing)
    End Sub


    Private Sub InformPriceProBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles InformPriceProBar.ItemClick
        Dim lFormEdit As frmInformPricePro
        Try
            lFormEdit = New frmInformPricePro
            With lFormEdit
                '.Caption = mCaption
                '.MdiParent = Me
                .ModeData = DataMode.ModeEdit
                .Show()
            End With
            InsertActivity(DataMode.ModeOpen, MasterType.InformPricePro, "", Nothing)
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub CampaignBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CampaignBar.ItemClick
        Dim lcls As New CampaignControl
        ShowDataOnControl(lcls, MasterType.Campaign)
        InsertActivity(DataMode.ModeOpen, MasterType.Campaign, "", Nothing)
    End Sub

    Private Sub ReportDealBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ReportDealBar.ItemClick
        frmDealReport.MdiParent = Me
        frmDealReport.Show()
        InsertActivity(DataMode.ModeOpen, MasterType.ReportDeal, "", Nothing)
    End Sub

    Private Sub UpdateSNStatusBar_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles UpdateSNStatusBar.ItemClick
        frmSNUpdateStatus.MdiParent = Me
        frmSNUpdateStatus.Show()
        InsertActivity(DataMode.ModeOpen, MasterType.UpdateSNStatus, "", Nothing)

    End Sub

    Private Sub BankBar_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BankBar.ItemClick
        Dim lcls As New BankControl
        ShowDataOnControl(lcls, MasterType.Bank)
        InsertActivity(DataMode.ModeOpen, MasterType.Bank, "", Nothing)
    End Sub

    Private Sub OrderSellHisBar_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles OrderSellHisBar.ItemClick
        frmSellOrderHis.MdiParent = Me
        frmSellOrderHis.Show()
        InsertActivity(DataMode.ModeOpen, MasterType.OrderSellHis, "", Nothing)
    End Sub


    'Private Sub ApproveStockBar_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs)
    '    frmUpdateStock.MdiParent = Me
    '    frmUpdateStock.Show()
    '    InsertActivity(DataMode.ModeOpen, MasterType.ApproveStock, "", Nothing)
    'End Sub

    Private Sub ProvinceBar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ProvinceBar.ItemClick
        Dim lcls As New ProvinceControl
        ShowDataOnControl(lcls, MasterType.Province)
        InsertActivity(DataMode.ModeOpen, MasterType.Province, "", Nothing)
    End Sub

    Private Sub UpdateStockBar_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles UpdateStockBar.ItemClick
        frmUpdateStock.MdiParent = Me
        frmUpdateStock.Show()
        InsertActivity(DataMode.ModeOpen, MasterType.UpdateStock, "", Nothing)
    End Sub

    Private Sub ReportDebtAnalystBar_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ReportDebtAnalystBar.ItemClick
        frmDebtAnalystReport.MdiParent = Me
        frmDebtAnalystReport.Show()
        InsertActivity(DataMode.ModeOpen, MasterType.ReportDebtAnalyst, "", Nothing)
    End Sub

    Private Sub StockReportBar_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles StockReportBar.ItemClick
        frmStockReport.MdiParent = Me
        frmStockReport.Show()
        InsertActivity(DataMode.ModeOpen, MasterType.ReportStock, "", Nothing)
    End Sub

    Private Sub ClaimResultBar_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ClaimResultBar.ItemClick
        Dim lcls As New OrderControl
        ShowDataOnControl(lcls, MasterType.ClaimResult)
        InsertActivity(DataMode.ModeOpen, MasterType.ClaimResult, "", Nothing)
    End Sub


    Private Sub ClaimReturnBar_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ClaimReturnBar.ItemClick
        Dim lcls As New OrderControl
        ShowDataOnControl(lcls, MasterType.ClaimReturn)
        InsertActivity(DataMode.ModeOpen, MasterType.ClaimReturn, "", Nothing)
    End Sub

    Private Sub Quotation2Bar_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Quotation2Bar.ItemClick
        Dim lcls As New OrderControl
        ShowDataOnControl(lcls, MasterType.Quotation2)
        InsertActivity(DataMode.ModeOpen, MasterType.Quotation2, "", Nothing)
    End Sub

    Private Sub NotifyBar_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles NotifyBar.ItemClick
        Try
            ShowNotifi(False)
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub


    Private Sub ShowNotifi(ByVal pIsChkCount As Boolean)
        Try
            Dim mcls As New clsNotifi
            Dim lcls As New PrivilegeDAO
            Dim lIsVisible As Boolean, lIsEnable As Boolean
            If lcls.InitailData(gPrivilegeID, MasterType.Notifi) Then
                lIsVisible = (lcls.PrivilegeData And Privilege.Visible) = Privilege.Visible
                lIsEnable = (lcls.PrivilegeData And Privilege.Enable) = Privilege.Enable
                If (lIsVisible = False) Or (lIsEnable = False) Then
                    Exit Sub
                End If
            Else
                Exit Sub
            End If


            If pIsChkCount Then
                Dim lclsNotifi As List(Of clsNotifi)

                mcls.InitialNotifi()
                lclsNotifi = mcls.GetNotifiList(gUserID)
                If lclsNotifi.Count > 0 Then
                    pIsChkCount = True
                Else
                    pIsChkCount = False
                End If
            Else
                pIsChkCount = True
            End If

            If pIsChkCount Then
                Dim mCtlForm = New frmNotify
                With mCtlForm
                    .Text = "ข้อความแจ้งเตือน"
                    .MdiParent = Me
                    .Show()
                End With
                InsertActivity(DataMode.ModeOpen, MasterType.Notifi, "", Nothing)
            End If


        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try
    End Sub

    Private Sub ShowOverdue(ByVal pShowMsg As Boolean)
        Try
            Dim mcls As New clsNotifi
            Dim lcls As New PrivilegeDAO
            Dim lIsVisible As Boolean, lIsEnable As Boolean
            If lcls.InitailData(gPrivilegeID, MasterType.Overdue) Then
                lIsVisible = (lcls.PrivilegeData And Privilege.Visible) = Privilege.Visible
                lIsEnable = (lcls.PrivilegeData And Privilege.Enable) = Privilege.Enable
                If (lIsVisible = False) Or (lIsEnable = False) Then
                    Exit Sub
                End If
            Else
                Exit Sub
            End If


            Dim lOverdueTable = mcls.LoadExpireOrder()
            If lOverdueTable.Rows.Count > 0 Then
                If pShowMsg = True Then
                    If XtraMessageBox.Show(Me, "ขณะนี้มีบิล Overdue " & lOverdueTable.Rows.Count & " รายการ ต้องการเปิดดูข้อมูลหรือไม่", "Overdue", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                        Dim mCtlForm = New frmOverdue
                        With mCtlForm
                            .Text = "Overdue"
                            .MdiParent = Me
                            .OverdueData = lOverdueTable
                            .Show()
                        End With
                    End If
                Else
                    Dim mCtlForm = New frmOverdue
                    With mCtlForm
                        .Text = "Overdue"
                        .MdiParent = Me
                        .OverdueData = lOverdueTable
                        .Show()
                    End With
                End If

            End If
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try
    End Sub


    Private Sub ReceiptHisBar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ReceiptHisBar.ItemClick
        Try

            Dim lFormEdit As New frmOrderHis2
            With lFormEdit
                .Show()
                InsertActivity(DataMode.ModeOpen, MasterType.OrderHis2, "", Nothing)
            End With

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub OverdueBar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles OverdueBar.ItemClick
        Try
            ShowOverdue(False)
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub CashItemBar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CashItemBar.ItemClick
        ShowMaster(MasterType.CashItem)
        InsertActivity(DataMode.ModeOpen, MasterType.CashItem, "", Nothing)
    End Sub

    Private Sub CashRecordBar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CashRecordBar.ItemClick
        Try

            Dim lFormEdit As New frmCashRecord
            With lFormEdit
                .MdiParent = Me
                .Show()
                InsertActivity(DataMode.ModeOpen, MasterType.CashRecord, "", Nothing)
            End With

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub DashboardBar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DashboardBar.ItemClick
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim mCtlForm = New frmDashboard
            With mCtlForm
                .Text = "Dashboard"
                .MdiParent = Me
                .Show()
            End With
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try

    End Sub

    Private Sub InvoiceOnlineBar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles InvoiceOnlineBar.ItemClick
        Dim lcls As New OrderControl
        ShowDataOnControl(lcls, MasterType.InvoiceOnline)
        InsertActivity(DataMode.ModeOpen, MasterType.InvoiceOnline, "", Nothing)
    End Sub

    Private Sub CommissionBar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CommissionBar.ItemClick
        Dim lcls As New CommissionControl
        ShowDataOnControl(lcls, MasterType.Commission)
        InsertActivity(DataMode.ModeOpen, MasterType.Commission, "", Nothing)
    End Sub

    Private Sub CommissionReportBar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CommissionReportBar.ItemClick
        frmCommissionReport.MdiParent = Me
        frmCommissionReport.Show()
    End Sub
End Class
