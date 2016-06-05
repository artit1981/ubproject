<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBill
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBill))
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.GeneralTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.TotalTax = New DevExpress.XtraEditors.CalcEdit()
        Me.DiscountAmount = New DevExpress.XtraEditors.CalcEdit()
        Me.GrandTotal = New DevExpress.XtraEditors.CalcEdit()
        Me.Exchange = New DevExpress.XtraEditors.CalcEdit()
        Me.cboCurrency = New DevExpress.XtraEditors.LookUpEdit()
        Me.TotalAfterDis = New DevExpress.XtraEditors.CalcEdit()
        Me.DiscountPercen = New DevExpress.XtraEditors.CalcEdit()
        Me.Total = New DevExpress.XtraEditors.CalcEdit()
        Me.UcOrderList1 = New UB.ucOrderList()
        Me.CreditBalance = New DevExpress.XtraEditors.CalcEdit()
        Me.PayType = New DevExpress.XtraEditors.RadioGroup()
        Me.ContactName = New DevExpress.XtraEditors.TextEdit()
        Me.PayDate = New DevExpress.XtraEditors.DateEdit()
        Me.btnShipingMethod = New DevExpress.XtraEditors.SimpleButton()
        Me.BillMethod = New DevExpress.XtraEditors.LookUpEdit()
        Me.OrderCode = New DevExpress.XtraEditors.TextEdit()
        Me.btnGenID = New DevExpress.XtraEditors.SimpleButton()
        Me.OrderDate = New DevExpress.XtraEditors.DateEdit()
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
        Me.btnCustomerID = New DevExpress.XtraEditors.SimpleButton()
        Me.Territory = New DevExpress.XtraEditors.TextEdit()
        Me.EmpID = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnEmpID = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutOrderCode = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutGenID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SplitterItem1 = New DevExpress.XtraLayout.SplitterItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutbtnCustomerID = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutBillMethod = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutbtnShipingMethod = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutPayType = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SplitterItem2 = New DevExpress.XtraLayout.SplitterItem()
        Me.LayoutCreditBalance = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.VatTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.TaxGroup = New DevExpress.XtraEditors.GroupControl()
        Me.GridTaxOrder = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
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
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
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
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.TaxMonthYear = New DevExpress.XtraEditors.DateEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TaxCanNo = New System.Windows.Forms.RadioButton()
        Me.TaxCanYes = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.TaxRemark = New DevExpress.XtraEditors.TextEdit()
        Me.ChequeTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcCheque1 = New UB.ucCheque()
        Me.RemarkTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.Remark = New DevExpress.XtraEditors.MemoEdit()
        Me.NoteTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcNote1 = New UB.ucNote()
        Me.AttachmentTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcFileAttach1 = New UB.ucFileAttach()
        Me.AdminTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcAdmin1 = New UB.ucAdmin()
        Me.FormChangedComponent1 = New UB.FormChangedComponent(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
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
        Me.txtPay = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtTotal = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtUnits = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.GeneralTabPage.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.TotalTax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiscountAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrandTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Exchange.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCurrency.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalAfterDis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiscountPercen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Total.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditBalance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillMethod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Territory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutOrderCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutGenID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutbtnCustomerID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutBillMethod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutbtnShipingMethod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutPayType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitterItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutCreditBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VatTabPage.SuspendLayout()
        CType(Me.TaxGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TaxGroup.SuspendLayout()
        CType(Me.GridTaxOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxTypeIDLookUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxSection.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxCondition.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxCusCardID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxCusTaxNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxCusAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxCusname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TaxMonthYear.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxMonthYear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ChequeTabPage.SuspendLayout()
        Me.RemarkTabPage.SuspendLayout()
        CType(Me.Remark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NoteTabPage.SuspendLayout()
        Me.AttachmentTabPage.SuspendLayout()
        Me.AdminTabPage.SuspendLayout()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.CalcEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.txtGrandTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.txtVat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.txtDiscount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.txtPay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.txtUnits.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraTabControl1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.XtraTabControl1, "")
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.HeaderButtons = DevExpress.XtraTab.TabButtons.None
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 37)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.XtraTabControl1, True)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.GeneralTabPage
        Me.XtraTabControl1.ShowHeaderFocus = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl1.Size = New System.Drawing.Size(1158, 517)
        Me.XtraTabControl1.TabIndex = 10
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.GeneralTabPage, Me.VatTabPage, Me.ChequeTabPage, Me.RemarkTabPage, Me.NoteTabPage, Me.AttachmentTabPage, Me.AdminTabPage})
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.XtraTabControl1, "")
        '
        'GeneralTabPage
        '
        Me.GeneralTabPage.Appearance.PageClient.BackColor = System.Drawing.Color.LightGray
        Me.GeneralTabPage.Appearance.PageClient.Options.UseBackColor = True
        Me.GeneralTabPage.AutoScroll = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.GeneralTabPage, "")
        Me.GeneralTabPage.Controls.Add(Me.LayoutControl1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.GeneralTabPage, True)
        Me.GeneralTabPage.Name = "GeneralTabPage"
        Me.GeneralTabPage.Size = New System.Drawing.Size(1152, 489)
        Me.GeneralTabPage.Text = "ข้อมูลทั่วไป"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.GeneralTabPage, "")
        '
        'LayoutControl1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.LayoutControl1, "")
        Me.LayoutControl1.Controls.Add(Me.TotalTax)
        Me.LayoutControl1.Controls.Add(Me.DiscountAmount)
        Me.LayoutControl1.Controls.Add(Me.GrandTotal)
        Me.LayoutControl1.Controls.Add(Me.Exchange)
        Me.LayoutControl1.Controls.Add(Me.cboCurrency)
        Me.LayoutControl1.Controls.Add(Me.TotalAfterDis)
        Me.LayoutControl1.Controls.Add(Me.DiscountPercen)
        Me.LayoutControl1.Controls.Add(Me.Total)
        Me.LayoutControl1.Controls.Add(Me.UcOrderList1)
        Me.LayoutControl1.Controls.Add(Me.CreditBalance)
        Me.LayoutControl1.Controls.Add(Me.PayType)
        Me.LayoutControl1.Controls.Add(Me.ContactName)
        Me.LayoutControl1.Controls.Add(Me.PayDate)
        Me.LayoutControl1.Controls.Add(Me.btnShipingMethod)
        Me.LayoutControl1.Controls.Add(Me.BillMethod)
        Me.LayoutControl1.Controls.Add(Me.OrderCode)
        Me.LayoutControl1.Controls.Add(Me.btnGenID)
        Me.LayoutControl1.Controls.Add(Me.OrderDate)
        Me.LayoutControl1.Controls.Add(Me.CustomerID)
        Me.LayoutControl1.Controls.Add(Me.btnCustomerID)
        Me.LayoutControl1.Controls.Add(Me.Territory)
        Me.LayoutControl1.Controls.Add(Me.EmpID)
        Me.LayoutControl1.Controls.Add(Me.btnEmpID)
        Me.LayoutControl1.Location = New System.Drawing.Point(20, 12)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.LayoutControl1, True)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(560, 214, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(806, 408)
        Me.LayoutControl1.TabIndex = 306
        Me.LayoutControl1.Text = "LayoutControl1"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.LayoutControl1, "")
        '
        'TotalTax
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.TotalTax, "TextChanged")
        Me.TotalTax.EnterMoveNextControl = True
        Me.TotalTax.Location = New System.Drawing.Point(625, 352)
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
        Me.TotalTax.Size = New System.Drawing.Size(169, 20)
        Me.TotalTax.StyleController = Me.LayoutControl1
        Me.TotalTax.TabIndex = 308
        Me.TotalTax.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.TotalTax, "Text")
        '
        'DiscountAmount
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.DiscountAmount, "TextChanged")
        Me.DiscountAmount.EnterMoveNextControl = True
        Me.DiscountAmount.Location = New System.Drawing.Point(389, 328)
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
        Me.DiscountAmount.Size = New System.Drawing.Size(143, 20)
        Me.DiscountAmount.StyleController = Me.LayoutControl1
        Me.DiscountAmount.TabIndex = 307
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.DiscountAmount, "Text")
        '
        'GrandTotal
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.GrandTotal, "TextChanged")
        Me.GrandTotal.EnterMoveNextControl = True
        Me.GrandTotal.Location = New System.Drawing.Point(625, 376)
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
        Me.GrandTotal.Size = New System.Drawing.Size(169, 20)
        Me.GrandTotal.StyleController = Me.LayoutControl1
        Me.GrandTotal.TabIndex = 307
        Me.GrandTotal.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.GrandTotal, "Text")
        '
        'Exchange
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Exchange, "TextChanged")
        Me.Exchange.EnterMoveNextControl = True
        Me.Exchange.Location = New System.Drawing.Point(389, 376)
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
        Me.Exchange.Size = New System.Drawing.Size(143, 20)
        Me.Exchange.StyleController = Me.LayoutControl1
        Me.Exchange.TabIndex = 317
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Exchange, "Text")
        '
        'cboCurrency
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.cboCurrency, "TextChanged")
        Me.cboCurrency.EditValue = "0"
        Me.cboCurrency.EnterMoveNextControl = True
        Me.cboCurrency.Location = New System.Drawing.Point(174, 376)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.cboCurrency, True)
        Me.cboCurrency.Name = "cboCurrency"
        Me.cboCurrency.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboCurrency.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCurrency.Properties.Appearance.Options.UseFont = True
        Me.cboCurrency.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboCurrency.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCurrency.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 50, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", 50, "สกุลเงิน"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ExchangeRate", "อัตราแลกเปลี่ยน", 40, DevExpress.Utils.FormatType.Numeric, "n2", True, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NameThai", "", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Center)})
        Me.cboCurrency.Properties.DropDownRows = 10
        Me.cboCurrency.Properties.ImmediatePopup = True
        Me.cboCurrency.Properties.NullText = ""
        Me.cboCurrency.Properties.NullValuePromptShowForEmptyValue = True
        Me.cboCurrency.Properties.PopupWidth = 300
        Me.cboCurrency.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboCurrency.Properties.ThrowExceptionOnInvalidLookUpEditValueType = True
        Me.cboCurrency.Properties.UseCtrlScroll = True
        Me.cboCurrency.Size = New System.Drawing.Size(122, 20)
        Me.cboCurrency.StyleController = Me.LayoutControl1
        Me.cboCurrency.TabIndex = 307
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.cboCurrency, "Text")
        '
        'TotalAfterDis
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.TotalAfterDis, "TextChanged")
        Me.TotalAfterDis.EnterMoveNextControl = True
        Me.TotalAfterDis.Location = New System.Drawing.Point(625, 328)
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
        Me.TotalAfterDis.Size = New System.Drawing.Size(169, 20)
        Me.TotalAfterDis.StyleController = Me.LayoutControl1
        Me.TotalAfterDis.TabIndex = 307
        Me.TotalAfterDis.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.TotalAfterDis, "Text")
        '
        'DiscountPercen
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.DiscountPercen, "TextChanged")
        Me.DiscountPercen.EnterMoveNextControl = True
        Me.DiscountPercen.Location = New System.Drawing.Point(174, 328)
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
        Me.DiscountPercen.Size = New System.Drawing.Size(122, 20)
        Me.DiscountPercen.StyleController = Me.LayoutControl1
        Me.DiscountPercen.TabIndex = 307
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.DiscountPercen, "Text")
        '
        'Total
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Total, "TextChanged")
        Me.Total.EnterMoveNextControl = True
        Me.Total.Location = New System.Drawing.Point(625, 304)
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
        Me.Total.Size = New System.Drawing.Size(169, 20)
        Me.Total.StyleController = Me.LayoutControl1
        Me.Total.TabIndex = 307
        Me.Total.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Total, "Text")
        '
        'UcOrderList1
        '
        Me.UcOrderList1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.UcOrderList1, "")
        Me.UcOrderList1.Location = New System.Drawing.Point(12, 168)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.UcOrderList1, True)
        Me.UcOrderList1.Name = "UcOrderList1"
        Me.UcOrderList1.Size = New System.Drawing.Size(782, 132)
        Me.UcOrderList1.TabIndex = 304
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcOrderList1, "")
        '
        'CreditBalance
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.CreditBalance, "TextChanged")
        Me.CreditBalance.EnterMoveNextControl = True
        Me.CreditBalance.Location = New System.Drawing.Point(525, 36)
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
        Me.CreditBalance.Size = New System.Drawing.Size(269, 20)
        Me.CreditBalance.StyleController = Me.LayoutControl1
        Me.CreditBalance.TabIndex = 307
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.CreditBalance, "Text")
        '
        'PayType
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.PayType, "")
        Me.PayType.EditValue = "CASH"
        Me.PayType.EnterMoveNextControl = True
        Me.PayType.Location = New System.Drawing.Point(101, 108)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.PayType, True)
        Me.PayType.Name = "PayType"
        Me.PayType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("CASH", "พิมพ์ใบเสร็จ และชำระ"), New DevExpress.XtraEditors.Controls.RadioGroupItem("CREDIT", "พิมพ์ใบเสร็จค้างชำระ")})
        Me.PayType.Size = New System.Drawing.Size(291, 46)
        Me.PayType.StyleController = Me.LayoutControl1
        Me.PayType.TabIndex = 305
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.PayType, "")
        '
        'ContactName
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.ContactName, "TextChanged")
        Me.ContactName.EditValue = ""
        Me.ContactName.EnterMoveNextControl = True
        Me.ContactName.Location = New System.Drawing.Point(525, 108)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.ContactName, True)
        Me.ContactName.Name = "ContactName"
        Me.ContactName.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.ContactName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ContactName.Properties.Appearance.Options.UseBackColor = True
        Me.ContactName.Properties.Appearance.Options.UseFont = True
        Me.ContactName.Properties.MaxLength = 50
        Me.ContactName.Properties.ReadOnly = True
        Me.ContactName.Properties.ValidateOnEnterKey = True
        Me.ContactName.Size = New System.Drawing.Size(269, 20)
        Me.ContactName.StyleController = Me.LayoutControl1
        Me.ContactName.TabIndex = 6
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.ContactName, "Text")
        '
        'PayDate
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.PayDate, "TextChanged")
        Me.PayDate.EditValue = New Date(2012, 4, 20, 0, 0, 0, 0)
        Me.PayDate.EnterMoveNextControl = True
        Me.PayDate.Location = New System.Drawing.Point(525, 60)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.PayDate, True)
        Me.PayDate.Name = "PayDate"
        Me.PayDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.PayDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PayDate.Properties.Appearance.Options.UseFont = True
        Me.PayDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PayDate.Properties.DisplayFormat.FormatString = "D"
        Me.PayDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PayDate.Properties.EditFormat.FormatString = "D"
        Me.PayDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PayDate.Properties.Mask.EditMask = "D"
        Me.PayDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.PayDate.Size = New System.Drawing.Size(269, 20)
        Me.PayDate.StyleController = Me.LayoutControl1
        Me.PayDate.TabIndex = 3
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.PayDate, "Text")
        '
        'btnShipingMethod
        '
        Me.btnShipingMethod.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnShipingMethod.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnShipingMethod, "")
        Me.btnShipingMethod.Image = CType(resources.GetObject("btnShipingMethod.Image"), System.Drawing.Image)
        Me.btnShipingMethod.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnShipingMethod.Location = New System.Drawing.Point(401, 90)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnShipingMethod, True)
        Me.btnShipingMethod.Name = "btnShipingMethod"
        Me.btnShipingMethod.Size = New System.Drawing.Size(26, 22)
        Me.btnShipingMethod.StyleController = Me.LayoutControl1
        Me.btnShipingMethod.TabIndex = 297
        Me.btnShipingMethod.TabStop = False
        Me.btnShipingMethod.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnShipingMethod, "")
        '
        'BillMethod
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.BillMethod, "TextChanged")
        Me.BillMethod.EnterMoveNextControl = True
        Me.BillMethod.Location = New System.Drawing.Point(101, 84)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.BillMethod, True)
        Me.BillMethod.Name = "BillMethod"
        Me.BillMethod.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.BillMethod.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BillMethod.Properties.Appearance.Options.UseFont = True
        Me.BillMethod.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.BillMethod.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BillMethod.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 50, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeThai", 50, "การวางบิล"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeEng", "CodeEng", 50, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Center), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Remark", "รายละเอียด", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Far)})
        Me.BillMethod.Properties.DropDownRows = 10
        Me.BillMethod.Properties.ImmediatePopup = True
        Me.BillMethod.Properties.NullText = ""
        Me.BillMethod.Properties.NullValuePromptShowForEmptyValue = True
        Me.BillMethod.Properties.PopupWidth = 300
        Me.BillMethod.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BillMethod.Properties.ThrowExceptionOnInvalidLookUpEditValueType = True
        Me.BillMethod.Properties.UseCtrlScroll = True
        Me.BillMethod.Size = New System.Drawing.Size(291, 20)
        Me.BillMethod.StyleController = Me.LayoutControl1
        Me.BillMethod.TabIndex = 5
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.BillMethod, "Text")
        '
        'OrderCode
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.OrderCode, "TextChanged")
        Me.OrderCode.EditValue = ""
        Me.OrderCode.EnterMoveNextControl = True
        Me.OrderCode.Location = New System.Drawing.Point(101, 12)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.OrderCode, True)
        Me.OrderCode.Name = "OrderCode"
        Me.OrderCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.OrderCode.Properties.Appearance.Options.UseFont = True
        Me.OrderCode.Properties.MaxLength = 50
        Me.OrderCode.Properties.ValidateOnEnterKey = True
        Me.OrderCode.Size = New System.Drawing.Size(291, 20)
        Me.OrderCode.StyleController = Me.LayoutControl1
        Me.OrderCode.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.OrderCode, "Text")
        '
        'btnGenID
        '
        Me.btnGenID.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnGenID.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnGenID, "")
        Me.btnGenID.Image = CType(resources.GetObject("btnGenID.Image"), System.Drawing.Image)
        Me.btnGenID.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnGenID.Location = New System.Drawing.Point(401, 12)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnGenID, True)
        Me.btnGenID.Name = "btnGenID"
        Me.btnGenID.Size = New System.Drawing.Size(26, 22)
        Me.btnGenID.StyleController = Me.LayoutControl1
        Me.btnGenID.TabIndex = 241
        Me.btnGenID.TabStop = False
        Me.btnGenID.ToolTip = "Auto ID"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnGenID, "")
        '
        'OrderDate
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.OrderDate, "TextChanged")
        Me.OrderDate.EditValue = New Date(2012, 4, 20, 0, 0, 0, 0)
        Me.OrderDate.EnterMoveNextControl = True
        Me.OrderDate.Location = New System.Drawing.Point(525, 12)
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
        Me.OrderDate.Size = New System.Drawing.Size(269, 20)
        Me.OrderDate.StyleController = Me.LayoutControl1
        Me.OrderDate.TabIndex = 1
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.OrderDate, "Text")
        '
        'CustomerID
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.CustomerID, "TextChanged")
        Me.CustomerID.EnterMoveNextControl = True
        Me.CustomerID.Location = New System.Drawing.Point(101, 36)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.CustomerID, True)
        Me.CustomerID.Name = "CustomerID"
        Me.CustomerID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerID.Properties.Appearance.Options.UseFont = True
        Me.CustomerID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CustomerID.Properties.NullText = ""
        Me.CustomerID.Properties.PopupFindMode = DevExpress.XtraEditors.FindMode.Always
        Me.CustomerID.Properties.View = Me.SearchLookUpEdit1View
        Me.CustomerID.Size = New System.Drawing.Size(291, 20)
        Me.CustomerID.StyleController = Me.LayoutControl1
        Me.CustomerID.TabIndex = 2
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
        'btnCustomerID
        '
        Me.btnCustomerID.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCustomerID.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnCustomerID, "")
        Me.btnCustomerID.Image = CType(resources.GetObject("btnCustomerID.Image"), System.Drawing.Image)
        Me.btnCustomerID.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCustomerID.Location = New System.Drawing.Point(401, 38)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnCustomerID, True)
        Me.btnCustomerID.Name = "btnCustomerID"
        Me.btnCustomerID.Size = New System.Drawing.Size(26, 22)
        Me.btnCustomerID.StyleController = Me.LayoutControl1
        Me.btnCustomerID.TabIndex = 3
        Me.btnCustomerID.TabStop = False
        Me.btnCustomerID.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnCustomerID, "")
        '
        'Territory
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Territory, "TextChanged")
        Me.Territory.EditValue = ""
        Me.Territory.EnterMoveNextControl = True
        Me.Territory.Location = New System.Drawing.Point(525, 84)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Territory, True)
        Me.Territory.Name = "Territory"
        Me.Territory.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.Territory.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Territory.Properties.Appearance.Options.UseBackColor = True
        Me.Territory.Properties.Appearance.Options.UseFont = True
        Me.Territory.Properties.MaxLength = 50
        Me.Territory.Properties.ReadOnly = True
        Me.Territory.Properties.ValidateOnEnterKey = True
        Me.Territory.Size = New System.Drawing.Size(269, 20)
        Me.Territory.StyleController = Me.LayoutControl1
        Me.Territory.TabIndex = 259
        Me.Territory.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Territory, "Text")
        '
        'EmpID
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.EmpID, "TextChanged")
        Me.EmpID.EnterMoveNextControl = True
        Me.EmpID.Location = New System.Drawing.Point(101, 60)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.EmpID, True)
        Me.EmpID.Name = "EmpID"
        Me.EmpID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpID.Properties.Appearance.Options.UseFont = True
        Me.EmpID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EmpID.Properties.NullText = ""
        Me.EmpID.Properties.View = Me.GridView1
        Me.EmpID.Size = New System.Drawing.Size(291, 20)
        Me.EmpID.StyleController = Me.LayoutControl1
        Me.EmpID.TabIndex = 4
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
        'btnEmpID
        '
        Me.btnEmpID.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnEmpID.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnEmpID, "")
        Me.btnEmpID.Image = CType(resources.GetObject("btnEmpID.Image"), System.Drawing.Image)
        Me.btnEmpID.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEmpID.Location = New System.Drawing.Point(401, 64)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnEmpID, True)
        Me.btnEmpID.Name = "btnEmpID"
        Me.btnEmpID.Size = New System.Drawing.Size(26, 22)
        Me.btnEmpID.StyleController = Me.LayoutControl1
        Me.btnEmpID.TabIndex = 249
        Me.btnEmpID.TabStop = False
        Me.btnEmpID.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnEmpID, "")
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutOrderCode, Me.LayoutGenID, Me.LayoutControlItem3, Me.SplitterItem1, Me.LayoutControlItem4, Me.LayoutbtnCustomerID, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutBillMethod, Me.LayoutbtnShipingMethod, Me.LayoutPayType, Me.LayoutControlItem13, Me.SplitterItem2, Me.LayoutCreditBalance, Me.EmptySpaceItem1, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem5, Me.EmptySpaceItem2, Me.EmptySpaceItem3, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem14, Me.LayoutControlItem15, Me.EmptySpaceItem4, Me.LayoutControlItem16, Me.EmptySpaceItem5, Me.EmptySpaceItem6})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(806, 408)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutOrderCode
        '
        Me.LayoutOrderCode.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LayoutOrderCode.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutOrderCode.Control = Me.OrderCode
        Me.LayoutOrderCode.CustomizationFormText = "เลขที่เอกสาร"
        Me.LayoutOrderCode.Location = New System.Drawing.Point(0, 0)
        Me.LayoutOrderCode.Name = "LayoutOrderCode"
        Me.LayoutOrderCode.Size = New System.Drawing.Size(384, 24)
        Me.LayoutOrderCode.Text = "เลขที่เอกสาร"
        Me.LayoutOrderCode.TextSize = New System.Drawing.Size(86, 13)
        '
        'LayoutGenID
        '
        Me.LayoutGenID.Control = Me.btnGenID
        Me.LayoutGenID.CustomizationFormText = "LayoutGenID"
        Me.LayoutGenID.Location = New System.Drawing.Point(389, 0)
        Me.LayoutGenID.Name = "LayoutGenID"
        Me.LayoutGenID.Size = New System.Drawing.Size(30, 26)
        Me.LayoutGenID.Text = "LayoutGenID"
        Me.LayoutGenID.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutGenID.TextToControlDistance = 0
        Me.LayoutGenID.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.OrderDate
        Me.LayoutControlItem3.CustomizationFormText = "วันที่เอกสาร"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(424, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(362, 24)
        Me.LayoutControlItem3.Text = "วันที่เอกสาร"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(86, 13)
        '
        'SplitterItem1
        '
        Me.SplitterItem1.AllowHotTrack = True
        Me.SplitterItem1.CustomizationFormText = "SplitterItem1"
        Me.SplitterItem1.Location = New System.Drawing.Point(419, 0)
        Me.SplitterItem1.Name = "SplitterItem1"
        Me.SplitterItem1.Size = New System.Drawing.Size(5, 146)
        Me.SplitterItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LayoutControlItem4.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem4.Control = Me.CustomerID
        Me.LayoutControlItem4.CustomizationFormText = "ลูกค้า"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(384, 24)
        Me.LayoutControlItem4.Text = "ลูกค้า"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(86, 13)
        '
        'LayoutbtnCustomerID
        '
        Me.LayoutbtnCustomerID.Control = Me.btnCustomerID
        Me.LayoutbtnCustomerID.CustomizationFormText = "LayoutbtnCustomerID"
        Me.LayoutbtnCustomerID.Location = New System.Drawing.Point(389, 26)
        Me.LayoutbtnCustomerID.Name = "LayoutbtnCustomerID"
        Me.LayoutbtnCustomerID.Size = New System.Drawing.Size(30, 26)
        Me.LayoutbtnCustomerID.Text = "LayoutbtnCustomerID"
        Me.LayoutbtnCustomerID.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutbtnCustomerID.TextToControlDistance = 0
        Me.LayoutbtnCustomerID.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.EmpID
        Me.LayoutControlItem6.CustomizationFormText = "พนักงาน"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(384, 24)
        Me.LayoutControlItem6.Text = "พนักงาน"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(86, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.btnEmpID
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(389, 52)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(30, 26)
        Me.LayoutControlItem7.Text = "LayoutControlItem7"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextToControlDistance = 0
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.PayDate
        Me.LayoutControlItem8.CustomizationFormText = "วันนัดชำระ"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(424, 48)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(362, 24)
        Me.LayoutControlItem8.Text = "วันนัดชำระ"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(86, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.Territory
        Me.LayoutControlItem9.CustomizationFormText = "ทีมขาย"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(424, 72)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(362, 24)
        Me.LayoutControlItem9.Text = "ทีมขาย"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(86, 13)
        '
        'LayoutBillMethod
        '
        Me.LayoutBillMethod.Control = Me.BillMethod
        Me.LayoutBillMethod.CustomizationFormText = "วิธีการวางบิล"
        Me.LayoutBillMethod.Location = New System.Drawing.Point(0, 72)
        Me.LayoutBillMethod.Name = "LayoutBillMethod"
        Me.LayoutBillMethod.Size = New System.Drawing.Size(384, 24)
        Me.LayoutBillMethod.Text = "วิธีการวางบิล"
        Me.LayoutBillMethod.TextSize = New System.Drawing.Size(86, 13)
        '
        'LayoutbtnShipingMethod
        '
        Me.LayoutbtnShipingMethod.Control = Me.btnShipingMethod
        Me.LayoutbtnShipingMethod.CustomizationFormText = "LayoutbtnShipingMethod"
        Me.LayoutbtnShipingMethod.Location = New System.Drawing.Point(389, 78)
        Me.LayoutbtnShipingMethod.Name = "LayoutbtnShipingMethod"
        Me.LayoutbtnShipingMethod.Size = New System.Drawing.Size(30, 26)
        Me.LayoutbtnShipingMethod.Text = "LayoutbtnShipingMethod"
        Me.LayoutbtnShipingMethod.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutbtnShipingMethod.TextToControlDistance = 0
        Me.LayoutbtnShipingMethod.TextVisible = False
        '
        'LayoutPayType
        '
        Me.LayoutPayType.Control = Me.PayType
        Me.LayoutPayType.CustomizationFormText = "ประเภทรายการ"
        Me.LayoutPayType.Location = New System.Drawing.Point(0, 96)
        Me.LayoutPayType.MaxSize = New System.Drawing.Size(384, 50)
        Me.LayoutPayType.MinSize = New System.Drawing.Size(384, 50)
        Me.LayoutPayType.Name = "LayoutPayType"
        Me.LayoutPayType.Size = New System.Drawing.Size(384, 50)
        Me.LayoutPayType.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutPayType.Text = "ประเภทรายการ"
        Me.LayoutPayType.TextSize = New System.Drawing.Size(86, 13)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.ContactName
        Me.LayoutControlItem13.CustomizationFormText = "ชื่อผู้ติดต่อ"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(424, 96)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(362, 50)
        Me.LayoutControlItem13.Text = "ชื่อผู้ติดต่อ"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(86, 13)
        '
        'SplitterItem2
        '
        Me.SplitterItem2.AllowHotTrack = True
        Me.SplitterItem2.CustomizationFormText = "SplitterItem2"
        Me.SplitterItem2.Location = New System.Drawing.Point(384, 0)
        Me.SplitterItem2.Name = "SplitterItem2"
        Me.SplitterItem2.Size = New System.Drawing.Size(5, 146)
        Me.SplitterItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutCreditBalance
        '
        Me.LayoutCreditBalance.Control = Me.CreditBalance
        Me.LayoutCreditBalance.CustomizationFormText = "ยอดหนี้"
        Me.LayoutCreditBalance.Location = New System.Drawing.Point(424, 24)
        Me.LayoutCreditBalance.Name = "LayoutCreditBalance"
        Me.LayoutCreditBalance.Size = New System.Drawing.Size(362, 24)
        Me.LayoutCreditBalance.Text = "ยอดหนี้"
        Me.LayoutCreditBalance.TextSize = New System.Drawing.Size(86, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 146)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(786, 10)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.UcOrderList1
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 156)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(786, 136)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.Total
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(524, 292)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(262, 24)
        Me.LayoutControlItem2.Text = "ยอดรวม"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(86, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.DiscountPercen
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(73, 316)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(215, 24)
        Me.LayoutControlItem5.Text = "ส่วนลด %"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(86, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 292)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(524, 24)
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 316)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(73, 24)
        Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.TotalAfterDis
        Me.LayoutControlItem10.CustomizationFormText = "ยอดหลังหักส่วนลด"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(524, 316)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(262, 24)
        Me.LayoutControlItem10.Text = "ยอดหลังหักส่วนลด"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(86, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cboCurrency
        Me.LayoutControlItem11.CustomizationFormText = "สกุลเงิน"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(73, 364)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(215, 24)
        Me.LayoutControlItem11.Text = "สกุลเงิน"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(86, 13)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.Exchange
        Me.LayoutControlItem12.CustomizationFormText = "อัตราแลกเปลี่ยน"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(288, 364)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(236, 24)
        Me.LayoutControlItem12.Text = "อัตราแลกเปลี่ยน"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(86, 13)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.GrandTotal
        Me.LayoutControlItem14.CustomizationFormText = "ยอดรวมทั้งสิ้น"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(524, 364)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(262, 24)
        Me.LayoutControlItem14.Text = "ยอดรวมทั้งสิ้น"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(86, 13)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.DiscountAmount
        Me.LayoutControlItem15.CustomizationFormText = "ส่วนลด"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(288, 316)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(236, 24)
        Me.LayoutControlItem15.Text = "ส่วนลด"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(86, 13)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 364)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(73, 24)
        Me.EmptySpaceItem4.Text = "EmptySpaceItem4"
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.TotalTax
        Me.LayoutControlItem16.CustomizationFormText = "หัก ภาษี"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(524, 340)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(262, 24)
        Me.LayoutControlItem16.Text = "หัก ภาษี"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(86, 13)
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.CustomizationFormText = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(0, 340)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(524, 24)
        Me.EmptySpaceItem5.Text = "EmptySpaceItem5"
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem6
        '
        Me.EmptySpaceItem6.AllowHotTrack = False
        Me.EmptySpaceItem6.CustomizationFormText = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Location = New System.Drawing.Point(389, 104)
        Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Size = New System.Drawing.Size(30, 42)
        Me.EmptySpaceItem6.Text = "EmptySpaceItem6"
        Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
        '
        'VatTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.VatTabPage, "")
        Me.VatTabPage.Controls.Add(Me.TaxGroup)
        Me.VatTabPage.Controls.Add(Me.GroupControl1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.VatTabPage, True)
        Me.VatTabPage.Name = "VatTabPage"
        Me.VatTabPage.Size = New System.Drawing.Size(1152, 489)
        Me.VatTabPage.Text = "การยื่นภาษี"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.VatTabPage, "")
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
        Me.TaxGroup.Location = New System.Drawing.Point(30, 115)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.TaxGroup, True)
        Me.TaxGroup.Name = "TaxGroup"
        Me.TaxGroup.Size = New System.Drawing.Size(787, 367)
        Me.TaxGroup.TabIndex = 1
        Me.TaxGroup.Text = "รายละเอียดการหักภาษี ณ ที่จ่าย"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.TaxGroup, "")
        '
        'GridTaxOrder
        '
        Me.GridTaxOrder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.GridTaxOrder, "")
        Me.GridTaxOrder.Location = New System.Drawing.Point(26, 196)
        Me.GridTaxOrder.MainView = Me.GridView2
        Me.FormChangedComponent1.SetMonitorForChanges(Me.GridTaxOrder, True)
        Me.GridTaxOrder.Name = "GridTaxOrder"
        Me.GridTaxOrder.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.TaxTypeIDLookUp, Me.RepositoryItemCalcEdit1, Me.RepositoryItemSpinEdit1, Me.RepositoryItemTextEdit1, Me.RepositoryItemCalcEdit2, Me.RepositoryItemButtonEdit1})
        Me.GridTaxOrder.Size = New System.Drawing.Size(742, 166)
        Me.GridTaxOrder.TabIndex = 281
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.GridTaxOrder, "")
        Me.GridTaxOrder.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.TaxTypeID, Me.TaxTotal, Me.TaxRate, Me.TaxAmount, Me.TaxOrderID, Me.OtherTax})
        Me.GridView2.GridControl = Me.GridTaxOrder
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView2.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView2.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'TaxTypeID
        '
        Me.TaxTypeID.Caption = "ประเภทเงินได้"
        Me.TaxTypeID.ColumnEdit = Me.TaxTypeIDLookUp
        Me.TaxTypeID.FieldName = "TaxTypeID"
        Me.TaxTypeID.MinWidth = 100
        Me.TaxTypeID.Name = "TaxTypeID"
        Me.TaxTypeID.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.TaxTypeID.Visible = True
        Me.TaxTypeID.VisibleIndex = 0
        Me.TaxTypeID.Width = 150
        '
        'TaxTypeIDLookUp
        '
        Me.TaxTypeIDLookUp.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.TaxTypeIDLookUp.AutoHeight = False
        Me.TaxTypeIDLookUp.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TaxTypeIDLookUp.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "Name1", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeThai", "Name2"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeEng", "Name3", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Remark", "Name4", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.TaxTypeIDLookUp.DisplayMember = "CodeThai"
        Me.TaxTypeIDLookUp.Name = "TaxTypeIDLookUp"
        Me.TaxTypeIDLookUp.NullText = ""
        Me.TaxTypeIDLookUp.NullValuePromptShowForEmptyValue = True
        Me.TaxTypeIDLookUp.ShowFooter = False
        Me.TaxTypeIDLookUp.ShowHeader = False
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
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
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
        Me.TaxCusCardID.EditValue = ""
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
        Me.TaxCusTaxNo.EditValue = ""
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
        Me.TaxCusAddress.EditValue = ""
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
        Me.TaxCusname.EditValue = ""
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
        Me.TaxNumber.EditValue = ""
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
        'GroupControl1
        '
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.GroupControl1, "")
        Me.GroupControl1.Controls.Add(Me.TaxMonthYear)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.TaxCanNo)
        Me.GroupControl1.Controls.Add(Me.TaxCanYes)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.Label36)
        Me.GroupControl1.Controls.Add(Me.TaxRemark)
        Me.GroupControl1.Location = New System.Drawing.Point(30, 17)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.GroupControl1, True)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(787, 92)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "การยื่นภาษี"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.GroupControl1, "")
        '
        'TaxMonthYear
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.TaxMonthYear, "TextChanged")
        Me.TaxMonthYear.EditValue = New Date(2013, 10, 8, 23, 38, 26, 0)
        Me.TaxMonthYear.Location = New System.Drawing.Point(398, 54)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.TaxMonthYear, True)
        Me.TaxMonthYear.Name = "TaxMonthYear"
        Me.TaxMonthYear.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TaxMonthYear.Properties.DisplayFormat.FormatString = "MM/yyyy"
        Me.TaxMonthYear.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.TaxMonthYear.Properties.Mask.EditMask = "MM/yyyy"
        Me.TaxMonthYear.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TaxMonthYear.Size = New System.Drawing.Size(140, 20)
        Me.TaxMonthYear.TabIndex = 176
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.TaxMonthYear, "Text")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label2, "")
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(289, 57)
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
        Me.TaxRemark.EditValue = ""
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
        'ChequeTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.ChequeTabPage, "")
        Me.ChequeTabPage.Controls.Add(Me.UcCheque1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.ChequeTabPage, True)
        Me.ChequeTabPage.Name = "ChequeTabPage"
        Me.ChequeTabPage.Size = New System.Drawing.Size(1152, 489)
        Me.ChequeTabPage.Text = "รายการรับ"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.ChequeTabPage, "")
        '
        'UcCheque1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.UcCheque1, "")
        Me.UcCheque1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcCheque1.Location = New System.Drawing.Point(0, 0)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.UcCheque1, True)
        Me.UcCheque1.Name = "UcCheque1"
        Me.UcCheque1.Size = New System.Drawing.Size(1152, 489)
        Me.UcCheque1.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcCheque1, "")
        '
        'RemarkTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.RemarkTabPage, "")
        Me.RemarkTabPage.Controls.Add(Me.Remark)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.RemarkTabPage, True)
        Me.RemarkTabPage.Name = "RemarkTabPage"
        Me.RemarkTabPage.Size = New System.Drawing.Size(1152, 489)
        Me.RemarkTabPage.Text = "รายละเอียด"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.RemarkTabPage, "")
        '
        'Remark
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Remark, "TextChanged")
        Me.Remark.EditValue = ""
        Me.Remark.EnterMoveNextControl = True
        Me.Remark.Location = New System.Drawing.Point(47, 27)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Remark, True)
        Me.Remark.Name = "Remark"
        Me.Remark.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Remark.Properties.Appearance.Options.UseFont = True
        Me.Remark.Properties.MaxLength = 100
        Me.Remark.Size = New System.Drawing.Size(689, 289)
        Me.Remark.StyleController = Me.LayoutControl1
        Me.Remark.TabIndex = 8
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Remark, "Text")
        '
        'NoteTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.NoteTabPage, "")
        Me.NoteTabPage.Controls.Add(Me.UcNote1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.NoteTabPage, True)
        Me.NoteTabPage.Name = "NoteTabPage"
        Me.NoteTabPage.Size = New System.Drawing.Size(1152, 489)
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
        Me.UcNote1.Size = New System.Drawing.Size(1152, 489)
        Me.UcNote1.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcNote1, "")
        '
        'AttachmentTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.AttachmentTabPage, "")
        Me.AttachmentTabPage.Controls.Add(Me.UcFileAttach1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.AttachmentTabPage, True)
        Me.AttachmentTabPage.Name = "AttachmentTabPage"
        Me.AttachmentTabPage.Size = New System.Drawing.Size(1152, 489)
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
        Me.UcFileAttach1.Size = New System.Drawing.Size(1152, 489)
        Me.UcFileAttach1.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcFileAttach1, "")
        '
        'AdminTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.AdminTabPage, "")
        Me.AdminTabPage.Controls.Add(Me.UcAdmin1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.AdminTabPage, True)
        Me.AdminTabPage.Name = "AdminTabPage"
        Me.AdminTabPage.Size = New System.Drawing.Size(1152, 489)
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
        'FormChangedComponent1
        '
        '
        'DockPanel1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.DockPanel1, "")
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel1.ID = New System.Guid("2ace0086-e3d4-4c3b-ab06-a10af7f3a79a")
        Me.DockPanel1.Location = New System.Drawing.Point(867, 37)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.DockPanel1, True)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(291, 200)
        Me.DockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel1.SavedIndex = 0
        Me.DockPanel1.Size = New System.Drawing.Size(291, 517)
        Me.DockPanel1.Text = "Order Information"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.DockPanel1, "")
        Me.DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
        '
        'DockPanel1_Container
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.DockPanel1_Container, "")
        Me.DockPanel1_Container.Controls.Add(Me.PanelControl1)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.DockPanel1_Container, True)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(283, 490)
        Me.DockPanel1_Container.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.DockPanel1_Container, "")
        '
        'PanelControl1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.PanelControl1, "")
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.PanelControl1, True)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(283, 490)
        Me.PanelControl1.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.PanelControl1, "")
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.PanelControl2, "")
        Me.PanelControl2.Controls.Add(Me.CalcEdit1)
        Me.PanelControl2.Controls.Add(Me.btnCalc)
        Me.PanelControl2.Controls.Add(Me.Panel6)
        Me.PanelControl2.Controls.Add(Me.Panel5)
        Me.PanelControl2.Controls.Add(Me.Panel4)
        Me.PanelControl2.Controls.Add(Me.Panel3)
        Me.PanelControl2.Controls.Add(Me.Panel2)
        Me.PanelControl2.Controls.Add(Me.Panel1)
        Me.PanelControl2.Location = New System.Drawing.Point(4, 5)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.PanelControl2, True)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(279, 390)
        Me.PanelControl2.TabIndex = 13
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.PanelControl2, "")
        '
        'CalcEdit1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.CalcEdit1, "TextChanged")
        Me.CalcEdit1.Location = New System.Drawing.Point(116, 265)
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
        Me.btnCalc.Location = New System.Drawing.Point(12, 258)
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
        Me.Panel6.Location = New System.Drawing.Point(12, 164)
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
        Me.Panel5.Location = New System.Drawing.Point(12, 126)
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
        Me.Panel4.Location = New System.Drawing.Point(12, 91)
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
        Me.Panel3.BackColor = System.Drawing.Color.OliveDrab
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Panel3, "")
        Me.Panel3.Controls.Add(Me.txtPay)
        Me.Panel3.Controls.Add(Me.LabelControl3)
        Me.Panel3.Location = New System.Drawing.Point(12, 206)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Panel3, True)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(255, 36)
        Me.Panel3.TabIndex = 18
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Panel3, "")
        '
        'txtPay
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtPay, "TextChanged")
        Me.txtPay.EditValue = "0.00"
        Me.txtPay.Location = New System.Drawing.Point(84, 3)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.txtPay, True)
        Me.txtPay.Name = "txtPay"
        Me.txtPay.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtPay.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPay.Properties.Appearance.Options.UseBackColor = True
        Me.txtPay.Properties.Appearance.Options.UseFont = True
        Me.txtPay.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPay.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPay.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtPay.Size = New System.Drawing.Size(166, 28)
        Me.txtPay.TabIndex = 12
        Me.txtPay.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtPay, "Text")
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
        Me.LabelControl3.Size = New System.Drawing.Size(51, 14)
        Me.LabelControl3.TabIndex = 11
        Me.LabelControl3.Text = "ยอดชำระ"
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
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.HiddenPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
        '
        'frmBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1158, 554)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frmBill"
        Me.Text = "frmBill"
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.GeneralTabPage.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.TotalTax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiscountAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrandTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Exchange.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCurrency.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalAfterDis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiscountPercen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Total.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditBalance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillMethod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Territory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutOrderCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutGenID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutbtnCustomerID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutBillMethod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutbtnShipingMethod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutPayType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitterItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutCreditBalance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VatTabPage.ResumeLayout(False)
        CType(Me.TaxGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TaxGroup.ResumeLayout(False)
        Me.TaxGroup.PerformLayout()
        CType(Me.GridTaxOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxTypeIDLookUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxSection.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxCondition.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxCusCardID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxCusTaxNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxCusAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxCusname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.TaxMonthYear.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxMonthYear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ChequeTabPage.ResumeLayout(False)
        Me.RemarkTabPage.ResumeLayout(False)
        CType(Me.Remark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NoteTabPage.ResumeLayout(False)
        Me.AttachmentTabPage.ResumeLayout(False)
        Me.AdminTabPage.ResumeLayout(False)
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
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
        CType(Me.txtPay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txtUnits.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents GeneralTabPage As DevExpress.XtraTab.XtraTabPage
    Private WithEvents BillMethod As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnShipingMethod As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ContactName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Territory As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EmpID As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnEmpID As DevExpress.XtraEditors.SimpleButton
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
    Friend WithEvents NoteTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcNote1 As ucNote
    Friend WithEvents AttachmentTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcFileAttach1 As ucFileAttach
    Friend WithEvents AdminTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcAdmin1 As ucAdmin
    Friend WithEvents PayDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents FormChangedComponent1 As FormChangedComponent
    Friend WithEvents UcOrderList1 As ucOrderList
    Friend WithEvents PayType As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutOrderCode As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutGenID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SplitterItem1 As DevExpress.XtraLayout.SplitterItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutbtnCustomerID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutBillMethod As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutbtnShipingMethod As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutPayType As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SplitterItem2 As DevExpress.XtraLayout.SplitterItem
    Friend WithEvents CreditBalance As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LayoutCreditBalance As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents RemarkTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Remark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Total As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DiscountPercen As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents TotalAfterDis As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboCurrency As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Exchange As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GrandTotal As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DiscountAmount As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents VatTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TaxGroup As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TaxRemark As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TaxMonthYear As DevExpress.XtraEditors.DateEdit
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TaxCanNo As System.Windows.Forms.RadioButton
    Friend WithEvents TaxCanYes As System.Windows.Forms.RadioButton
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Label36 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TaxNumber As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TaxType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents TaxCusCardID As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TaxCusTaxNo As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TaxCusAddress As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TaxCusname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TaxSection As DevExpress.XtraEditors.ComboBoxEdit
    Private WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TaxCondition As DevExpress.XtraEditors.ComboBoxEdit
    Private WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TotalTax As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents ChequeTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcCheque1 As ucCheque
    Friend WithEvents GridTaxOrder As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TaxTypeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TaxTypeIDLookUp As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents TaxTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents TaxRate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents TaxAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents TaxOrderID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents OtherTax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
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
    Friend WithEvents txtPay As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtUnits As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
