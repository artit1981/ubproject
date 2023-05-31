<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformPrice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInformPrice))
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.GeneralTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.chkAutoRow = New DevExpress.XtraEditors.CheckEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddPro = New DevExpress.XtraEditors.SimpleButton()
        Me.txtListCount = New DevExpress.XtraEditors.TextEdit()
        Me.btnMakeOrder = New DevExpress.XtraEditors.SimpleButton()
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ProductID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProductCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProductName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.ProductGuaranteeCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProductRemark = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Subject = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Unit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Promotion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PriceStandard = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Price1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Price2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Price3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Price4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Price5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Price6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CostAdjust = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PriceOnline = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PriceInform = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PriceCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.InformPriceID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PriceInformOld = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Image = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnImage = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ProductBtn = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDateTo = New DevExpress.XtraEditors.DateEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDateFrom = New DevExpress.XtraEditors.DateEdit()
        Me.btnBrandRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.btnProductCategory = New DevExpress.XtraEditors.SimpleButton()
        Me.btnProductType = New DevExpress.XtraEditors.SimpleButton()
        Me.CriterionPrice = New DevExpress.XtraEditors.TextEdit()
        Me.btnFind = New DevExpress.XtraEditors.SimpleButton()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.ProductTypeID = New DevExpress.XtraEditors.LookUpEdit()
        Me.ProductCategoryID = New DevExpress.XtraEditors.LookUpEdit()
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnProductGroup = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCustomerID = New DevExpress.XtraEditors.SimpleButton()
        Me.ProductGroupID = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ProductBrandID = New DevExpress.XtraEditors.LookUpEdit()
        Me.NoteTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcNote1 = New UB.ucNote()
        Me.AttachmentTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcFileAttach1 = New UB.ucFileAttach()
        Me.AdminTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcAdmin1 = New UB.ucAdmin()
        Me.FormChangedComponent1 = New UB.FormChangedComponent(Me.components)
        Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.GeneralTabPage.SuspendLayout()
        CType(Me.chkAutoRow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtListCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.dtpDateTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDateTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDateFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDateFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CriterionPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductTypeID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductCategoryID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductGroupID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBrandID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NoteTabPage.SuspendLayout()
        Me.AttachmentTabPage.SuspendLayout()
        Me.AdminTabPage.SuspendLayout()
        CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraTabControl1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.XtraTabControl1, "")
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.HeaderButtons = DevExpress.XtraTab.TabButtons.None
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 30)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.XtraTabControl1, True)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.GeneralTabPage
        Me.XtraTabControl1.ShowHeaderFocus = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl1.Size = New System.Drawing.Size(1360, 715)
        Me.XtraTabControl1.TabIndex = 8
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.GeneralTabPage, Me.NoteTabPage, Me.AttachmentTabPage, Me.AdminTabPage})
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.XtraTabControl1, "")
        '
        'GeneralTabPage
        '
        Me.GeneralTabPage.Appearance.PageClient.BackColor = System.Drawing.Color.LightGray
        Me.GeneralTabPage.Appearance.PageClient.Options.UseBackColor = True
        Me.GeneralTabPage.AutoScroll = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.GeneralTabPage, "")
        Me.GeneralTabPage.Controls.Add(Me.chkAutoRow)
        Me.GeneralTabPage.Controls.Add(Me.GroupControl2)
        Me.GeneralTabPage.Controls.Add(Me.gridControl)
        Me.GeneralTabPage.Controls.Add(Me.GroupControl1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.GeneralTabPage, True)
        Me.GeneralTabPage.Name = "GeneralTabPage"
        Me.GeneralTabPage.Size = New System.Drawing.Size(1358, 690)
        Me.GeneralTabPage.Text = "ข้อมูลทั่วไป"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.GeneralTabPage, "")
        '
        'chkAutoRow
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.chkAutoRow, "CheckedChanged")
        Me.chkAutoRow.Location = New System.Drawing.Point(33, 180)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.chkAutoRow, True)
        Me.chkAutoRow.Name = "chkAutoRow"
        Me.chkAutoRow.Properties.Caption = "ปรับความสูงของแถวอัตโนมัติ"
        Me.chkAutoRow.Size = New System.Drawing.Size(179, 20)
        Me.chkAutoRow.TabIndex = 309
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.chkAutoRow, "Checked")
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.GroupControl2, "")
        Me.GroupControl2.Controls.Add(Me.btnClear)
        Me.GroupControl2.Controls.Add(Me.Label1)
        Me.GroupControl2.Controls.Add(Me.btnAddPro)
        Me.GroupControl2.Controls.Add(Me.txtListCount)
        Me.GroupControl2.Controls.Add(Me.btnMakeOrder)
        Me.GroupControl2.Location = New System.Drawing.Point(966, 90)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.GroupControl2, True)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(377, 84)
        Me.GroupControl2.TabIndex = 308
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.GroupControl2, "")
        '
        'btnClear
        '
        Me.btnClear.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnClear.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnClear, "")
        Me.btnClear.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnClear.Location = New System.Drawing.Point(92, 40)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnClear, True)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(56, 31)
        Me.btnClear.TabIndex = 298
        Me.btnClear.TabStop = False
        Me.btnClear.Text = "ยกเลิก"
        Me.btnClear.ToolTip = "ยกเลิก"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnClear, "")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label1, "")
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(154, 49)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label1, True)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 14)
        Me.Label1.TabIndex = 297
        Me.Label1.Text = "จำนวน"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label1, "")
        '
        'btnAddPro
        '
        Me.btnAddPro.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnAddPro.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnAddPro, "")
        Me.btnAddPro.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAddPro.Location = New System.Drawing.Point(30, 40)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnAddPro, True)
        Me.btnAddPro.Name = "btnAddPro"
        Me.btnAddPro.Size = New System.Drawing.Size(56, 31)
        Me.btnAddPro.TabIndex = 296
        Me.btnAddPro.TabStop = False
        Me.btnAddPro.Text = "เพิ่มสินค้า"
        Me.btnAddPro.ToolTip = "เพิ่มสินค้า"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnAddPro, "")
        '
        'txtListCount
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtListCount, "TextChanged")
        Me.txtListCount.EditValue = ""
        Me.txtListCount.EnterMoveNextControl = True
        Me.txtListCount.Location = New System.Drawing.Point(200, 46)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.txtListCount, True)
        Me.txtListCount.Name = "txtListCount"
        Me.txtListCount.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.txtListCount.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtListCount.Properties.Appearance.Options.UseBackColor = True
        Me.txtListCount.Properties.Appearance.Options.UseFont = True
        Me.txtListCount.Properties.MaxLength = 50
        Me.txtListCount.Properties.ReadOnly = True
        Me.txtListCount.Properties.ValidateOnEnterKey = True
        Me.txtListCount.Size = New System.Drawing.Size(53, 20)
        Me.txtListCount.TabIndex = 295
        Me.txtListCount.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtListCount, "Text")
        '
        'btnMakeOrder
        '
        Me.btnMakeOrder.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnMakeOrder.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnMakeOrder, "")
        Me.btnMakeOrder.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnMakeOrder.Location = New System.Drawing.Point(259, 40)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnMakeOrder, True)
        Me.btnMakeOrder.Name = "btnMakeOrder"
        Me.btnMakeOrder.Size = New System.Drawing.Size(88, 31)
        Me.btnMakeOrder.TabIndex = 294
        Me.btnMakeOrder.TabStop = False
        Me.btnMakeOrder.Text = "ทำใบเสนอราคา"
        Me.btnMakeOrder.ToolTip = "ทำใบเสนอราคา"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnMakeOrder, "")
        '
        'gridControl
        '
        Me.gridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.gridControl, "")
        Me.gridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gridControl.EmbeddedNavigator.Buttons.Edit.ImageIndex = 0
        Me.gridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gridControl.Location = New System.Drawing.Point(11, 206)
        Me.gridControl.MainView = Me.gridView
        Me.FormChangedComponent1.SetMonitorForChanges(Me.gridControl, True)
        Me.gridControl.Name = "gridControl"
        Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ProductBtn, Me.PriceCalcEdit1, Me.RepositoryItemMemoEdit1, Me.RepositoryItemCheckEdit1, Me.btnImage})
        Me.gridControl.Size = New System.Drawing.Size(1332, 470)
        Me.gridControl.TabIndex = 290
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.gridControl, "")
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView, Me.GridView1})
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ProductID, Me.ProductCode, Me.ProductName, Me.ProductGuaranteeCode, Me.ProductRemark, Me.Subject, Me.Unit, Me.Promotion, Me.PriceStandard, Me.Price1, Me.Price2, Me.Price3, Me.Price4, Me.Price5, Me.Price6, Me.CostAdjust, Me.PriceOnline, Me.PriceInform, Me.InformPriceID, Me.PriceInformOld, Me.Image})
        Me.gridView.GridControl = Me.gridControl
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gridView.OptionsFind.AlwaysVisible = True
        Me.gridView.OptionsLayout.Columns.AddNewColumns = False
        Me.gridView.OptionsLayout.Columns.RemoveOldColumns = False
        Me.gridView.OptionsMenu.EnableColumnMenu = False
        Me.gridView.OptionsMenu.EnableFooterMenu = False
        Me.gridView.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsNavigation.AutoFocusNewRow = True
        Me.gridView.OptionsNavigation.EnterMoveNextColumn = True
        Me.gridView.OptionsSelection.CheckBoxSelectorColumnWidth = 50
        Me.gridView.OptionsSelection.CheckBoxSelectorField = "IsSelect"
        Me.gridView.OptionsSelection.MultiSelect = True
        Me.gridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.gridView.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.[True]
        Me.gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.gridView.OptionsView.ShowGroupPanel = False
        '
        'ProductID
        '
        Me.ProductID.Caption = "GridColumn1"
        Me.ProductID.FieldName = "ProductID"
        Me.ProductID.Name = "ProductID"
        Me.ProductID.OptionsColumn.TabStop = False
        '
        'ProductCode
        '
        Me.ProductCode.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProductCode.AppearanceCell.Options.UseBackColor = True
        Me.ProductCode.AppearanceHeader.Options.UseTextOptions = True
        Me.ProductCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ProductCode.Caption = "รหัสสินค้า"
        Me.ProductCode.FieldName = "ProductCode"
        Me.ProductCode.MaxWidth = 120
        Me.ProductCode.MinWidth = 80
        Me.ProductCode.Name = "ProductCode"
        Me.ProductCode.OptionsColumn.ReadOnly = True
        Me.ProductCode.OptionsColumn.TabStop = False
        Me.ProductCode.Visible = True
        Me.ProductCode.VisibleIndex = 1
        Me.ProductCode.Width = 81
        '
        'ProductName
        '
        Me.ProductName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProductName.AppearanceCell.Options.UseBackColor = True
        Me.ProductName.AppearanceHeader.Options.UseTextOptions = True
        Me.ProductName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ProductName.Caption = "ชื่อสินค้า"
        Me.ProductName.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.ProductName.FieldName = "ProductName"
        Me.ProductName.MinWidth = 150
        Me.ProductName.Name = "ProductName"
        Me.ProductName.OptionsColumn.AllowEdit = False
        Me.ProductName.OptionsColumn.TabStop = False
        Me.ProductName.Visible = True
        Me.ProductName.VisibleIndex = 2
        Me.ProductName.Width = 150
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.LinesCount = 2
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        Me.RepositoryItemMemoEdit1.ScrollBars = System.Windows.Forms.ScrollBars.None
        '
        'ProductGuaranteeCode
        '
        Me.ProductGuaranteeCode.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProductGuaranteeCode.AppearanceCell.Options.UseBackColor = True
        Me.ProductGuaranteeCode.AppearanceHeader.Options.UseTextOptions = True
        Me.ProductGuaranteeCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ProductGuaranteeCode.Caption = "จำนวนวันประกัน"
        Me.ProductGuaranteeCode.FieldName = "ProductGuaranteeCode"
        Me.ProductGuaranteeCode.MaxWidth = 100
        Me.ProductGuaranteeCode.MinWidth = 60
        Me.ProductGuaranteeCode.Name = "ProductGuaranteeCode"
        Me.ProductGuaranteeCode.OptionsColumn.AllowEdit = False
        Me.ProductGuaranteeCode.OptionsColumn.TabStop = False
        Me.ProductGuaranteeCode.Visible = True
        Me.ProductGuaranteeCode.VisibleIndex = 3
        Me.ProductGuaranteeCode.Width = 80
        '
        'ProductRemark
        '
        Me.ProductRemark.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProductRemark.AppearanceCell.Options.UseBackColor = True
        Me.ProductRemark.AppearanceHeader.Options.UseTextOptions = True
        Me.ProductRemark.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ProductRemark.Caption = "รายละเอียดสินค้า"
        Me.ProductRemark.FieldName = "ProductRemark"
        Me.ProductRemark.MinWidth = 200
        Me.ProductRemark.Name = "ProductRemark"
        Me.ProductRemark.OptionsColumn.ReadOnly = True
        Me.ProductRemark.OptionsColumn.TabStop = False
        Me.ProductRemark.Visible = True
        Me.ProductRemark.VisibleIndex = 4
        Me.ProductRemark.Width = 200
        '
        'Subject
        '
        Me.Subject.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Subject.AppearanceCell.Options.UseBackColor = True
        Me.Subject.AppearanceHeader.Options.UseTextOptions = True
        Me.Subject.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Subject.Caption = "โปรโมชัน"
        Me.Subject.FieldName = "Subject"
        Me.Subject.MaxWidth = 200
        Me.Subject.MinWidth = 150
        Me.Subject.Name = "Subject"
        Me.Subject.OptionsColumn.ReadOnly = True
        Me.Subject.OptionsColumn.TabStop = False
        Me.Subject.Visible = True
        Me.Subject.VisibleIndex = 5
        Me.Subject.Width = 150
        '
        'Unit
        '
        Me.Unit.AppearanceCell.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Unit.AppearanceCell.Options.UseBackColor = True
        Me.Unit.AppearanceCell.Options.UseTextOptions = True
        Me.Unit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Unit.AppearanceHeader.Options.UseTextOptions = True
        Me.Unit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Unit.Caption = "ยอดคงเหลือ"
        Me.Unit.DisplayFormat.FormatString = "n0"
        Me.Unit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Unit.FieldName = "Unit"
        Me.Unit.MaxWidth = 70
        Me.Unit.MinWidth = 65
        Me.Unit.Name = "Unit"
        Me.Unit.OptionsColumn.ReadOnly = True
        Me.Unit.OptionsColumn.TabStop = False
        Me.Unit.Visible = True
        Me.Unit.VisibleIndex = 6
        Me.Unit.Width = 65
        '
        'Promotion
        '
        Me.Promotion.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Promotion.AppearanceCell.Options.UseBackColor = True
        Me.Promotion.AppearanceCell.Options.UseTextOptions = True
        Me.Promotion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Promotion.AppearanceHeader.Options.UseTextOptions = True
        Me.Promotion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Promotion.Caption = "Promotion"
        Me.Promotion.DisplayFormat.FormatString = "n2"
        Me.Promotion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Promotion.FieldName = "PricePromotion"
        Me.Promotion.MaxWidth = 70
        Me.Promotion.MinWidth = 50
        Me.Promotion.Name = "Promotion"
        Me.Promotion.OptionsColumn.ReadOnly = True
        Me.Promotion.OptionsColumn.TabStop = False
        Me.Promotion.Visible = True
        Me.Promotion.VisibleIndex = 7
        Me.Promotion.Width = 66
        '
        'PriceStandard
        '
        Me.PriceStandard.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PriceStandard.AppearanceCell.Options.UseBackColor = True
        Me.PriceStandard.AppearanceCell.Options.UseTextOptions = True
        Me.PriceStandard.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.PriceStandard.AppearanceHeader.Options.UseTextOptions = True
        Me.PriceStandard.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PriceStandard.Caption = "ราคามาตรฐาน"
        Me.PriceStandard.DisplayFormat.FormatString = "n2"
        Me.PriceStandard.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PriceStandard.FieldName = "PriceStandard"
        Me.PriceStandard.MaxWidth = 70
        Me.PriceStandard.MinWidth = 50
        Me.PriceStandard.Name = "PriceStandard"
        Me.PriceStandard.OptionsColumn.ReadOnly = True
        Me.PriceStandard.OptionsColumn.TabStop = False
        Me.PriceStandard.Visible = True
        Me.PriceStandard.VisibleIndex = 8
        Me.PriceStandard.Width = 65
        '
        'Price1
        '
        Me.Price1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Price1.AppearanceCell.Options.UseBackColor = True
        Me.Price1.AppearanceCell.Options.UseTextOptions = True
        Me.Price1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Price1.AppearanceHeader.Options.UseTextOptions = True
        Me.Price1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Price1.Caption = "Cost"
        Me.Price1.DisplayFormat.FormatString = "n2"
        Me.Price1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Price1.FieldName = "Price1"
        Me.Price1.MaxWidth = 70
        Me.Price1.MinWidth = 50
        Me.Price1.Name = "Price1"
        Me.Price1.OptionsColumn.ReadOnly = True
        Me.Price1.OptionsColumn.TabStop = False
        Me.Price1.Visible = True
        Me.Price1.VisibleIndex = 9
        Me.Price1.Width = 65
        '
        'Price2
        '
        Me.Price2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Price2.AppearanceCell.Options.UseBackColor = True
        Me.Price2.AppearanceCell.Options.UseTextOptions = True
        Me.Price2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Price2.AppearanceHeader.Options.UseTextOptions = True
        Me.Price2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Price2.Caption = "Cash"
        Me.Price2.DisplayFormat.FormatString = "n2"
        Me.Price2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Price2.FieldName = "Price2"
        Me.Price2.MaxWidth = 70
        Me.Price2.MinWidth = 50
        Me.Price2.Name = "Price2"
        Me.Price2.OptionsColumn.ReadOnly = True
        Me.Price2.OptionsColumn.TabStop = False
        Me.Price2.Visible = True
        Me.Price2.VisibleIndex = 10
        Me.Price2.Width = 65
        '
        'Price3
        '
        Me.Price3.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Price3.AppearanceCell.Options.UseBackColor = True
        Me.Price3.AppearanceCell.Options.UseTextOptions = True
        Me.Price3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Price3.AppearanceHeader.Options.UseTextOptions = True
        Me.Price3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Price3.Caption = "1-3 ชิ้น"
        Me.Price3.DisplayFormat.FormatString = "n2"
        Me.Price3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Price3.FieldName = "Price3"
        Me.Price3.MaxWidth = 70
        Me.Price3.MinWidth = 50
        Me.Price3.Name = "Price3"
        Me.Price3.OptionsColumn.ReadOnly = True
        Me.Price3.OptionsColumn.TabStop = False
        Me.Price3.Visible = True
        Me.Price3.VisibleIndex = 11
        Me.Price3.Width = 65
        '
        'Price4
        '
        Me.Price4.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Price4.AppearanceCell.Options.UseBackColor = True
        Me.Price4.AppearanceCell.Options.UseTextOptions = True
        Me.Price4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Price4.AppearanceHeader.Options.UseTextOptions = True
        Me.Price4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Price4.Caption = "3-6 ชิ้น"
        Me.Price4.DisplayFormat.FormatString = "n2"
        Me.Price4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Price4.FieldName = "Price4"
        Me.Price4.MaxWidth = 70
        Me.Price4.MinWidth = 50
        Me.Price4.Name = "Price4"
        Me.Price4.OptionsColumn.ReadOnly = True
        Me.Price4.OptionsColumn.TabStop = False
        Me.Price4.Visible = True
        Me.Price4.VisibleIndex = 12
        Me.Price4.Width = 65
        '
        'Price5
        '
        Me.Price5.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Price5.AppearanceCell.Options.UseBackColor = True
        Me.Price5.AppearanceCell.Options.UseTextOptions = True
        Me.Price5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Price5.AppearanceHeader.Options.UseTextOptions = True
        Me.Price5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Price5.Caption = "6 ชิ้น"
        Me.Price5.DisplayFormat.FormatString = "n2"
        Me.Price5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Price5.FieldName = "Price5"
        Me.Price5.MaxWidth = 70
        Me.Price5.MinWidth = 50
        Me.Price5.Name = "Price5"
        Me.Price5.OptionsColumn.ReadOnly = True
        Me.Price5.OptionsColumn.TabStop = False
        Me.Price5.Visible = True
        Me.Price5.VisibleIndex = 13
        Me.Price5.Width = 65
        '
        'Price6
        '
        Me.Price6.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Price6.AppearanceCell.Options.UseBackColor = True
        Me.Price6.AppearanceCell.Options.UseTextOptions = True
        Me.Price6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Price6.AppearanceHeader.Options.UseTextOptions = True
        Me.Price6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Price6.Caption = "NV"
        Me.Price6.DisplayFormat.FormatString = "n2"
        Me.Price6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Price6.FieldName = "Price6"
        Me.Price6.MaxWidth = 70
        Me.Price6.MinWidth = 50
        Me.Price6.Name = "Price6"
        Me.Price6.OptionsColumn.ReadOnly = True
        Me.Price6.OptionsColumn.TabStop = False
        Me.Price6.Visible = True
        Me.Price6.VisibleIndex = 14
        Me.Price6.Width = 66
        '
        'CostAdjust
        '
        Me.CostAdjust.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.CostAdjust.AppearanceCell.Options.UseBackColor = True
        Me.CostAdjust.AppearanceCell.Options.UseTextOptions = True
        Me.CostAdjust.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CostAdjust.AppearanceHeader.Options.UseTextOptions = True
        Me.CostAdjust.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CostAdjust.Caption = "ต้นทุน"
        Me.CostAdjust.DisplayFormat.FormatString = "n2"
        Me.CostAdjust.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CostAdjust.FieldName = "CostAdjust"
        Me.CostAdjust.MaxWidth = 100
        Me.CostAdjust.MinWidth = 65
        Me.CostAdjust.Name = "CostAdjust"
        Me.CostAdjust.Width = 65
        '
        'PriceOnline
        '
        Me.PriceOnline.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.PriceOnline.AppearanceCell.Options.UseBackColor = True
        Me.PriceOnline.AppearanceCell.Options.UseTextOptions = True
        Me.PriceOnline.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.PriceOnline.AppearanceHeader.Options.UseTextOptions = True
        Me.PriceOnline.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PriceOnline.Caption = "Online"
        Me.PriceOnline.DisplayFormat.FormatString = "n2"
        Me.PriceOnline.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PriceOnline.FieldName = "PriceOnline"
        Me.PriceOnline.MaxWidth = 100
        Me.PriceOnline.MinWidth = 65
        Me.PriceOnline.Name = "PriceOnline"
        Me.PriceOnline.Visible = True
        Me.PriceOnline.VisibleIndex = 15
        Me.PriceOnline.Width = 66
        '
        'PriceInform
        '
        Me.PriceInform.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.PriceInform.AppearanceCell.Options.UseBackColor = True
        Me.PriceInform.AppearanceCell.Options.UseTextOptions = True
        Me.PriceInform.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.PriceInform.AppearanceHeader.Options.UseTextOptions = True
        Me.PriceInform.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PriceInform.Caption = "ราคาแจ้ง"
        Me.PriceInform.ColumnEdit = Me.PriceCalcEdit1
        Me.PriceInform.DisplayFormat.FormatString = "n2"
        Me.PriceInform.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PriceInform.FieldName = "PriceInform"
        Me.PriceInform.MaxWidth = 100
        Me.PriceInform.MinWidth = 65
        Me.PriceInform.Name = "PriceInform"
        Me.PriceInform.Visible = True
        Me.PriceInform.VisibleIndex = 16
        Me.PriceInform.Width = 65
        '
        'PriceCalcEdit1
        '
        Me.PriceCalcEdit1.AutoHeight = False
        Me.PriceCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PriceCalcEdit1.DisplayFormat.FormatString = "n2"
        Me.PriceCalcEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PriceCalcEdit1.EditFormat.FormatString = "n2"
        Me.PriceCalcEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PriceCalcEdit1.Name = "PriceCalcEdit1"
        Me.PriceCalcEdit1.Precision = 2
        '
        'InformPriceID
        '
        Me.InformPriceID.Caption = "GridColumn1"
        Me.InformPriceID.FieldName = "InformPriceID"
        Me.InformPriceID.Name = "InformPriceID"
        '
        'PriceInformOld
        '
        Me.PriceInformOld.Caption = "GridColumn1"
        Me.PriceInformOld.FieldName = "PriceInformOld"
        Me.PriceInformOld.Name = "PriceInformOld"
        '
        'Image
        '
        Me.Image.Caption = "Image"
        Me.Image.ColumnEdit = Me.btnImage
        Me.Image.FieldName = "Image"
        Me.Image.MaxWidth = 38
        Me.Image.Name = "Image"
        Me.Image.Visible = True
        Me.Image.VisibleIndex = 17
        Me.Image.Width = 28
        '
        'btnImage
        '
        Me.btnImage.AutoHeight = False
        Me.btnImage.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.btnImage.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.btnImage.Name = "btnImage"
        Me.btnImage.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ProductBtn
        '
        Me.ProductBtn.AutoHeight = False
        Me.ProductBtn.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ProductBtn.Name = "ProductBtn"
        Me.ProductBtn.ValidateOnEnterKey = True
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepositoryItemCheckEdit1.ValueChecked = 1
        Me.RepositoryItemCheckEdit1.ValueGrayed = CType(0, Short)
        Me.RepositoryItemCheckEdit1.ValueUnchecked = CType(0, Short)
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gridControl
        Me.GridView1.Name = "GridView1"
        '
        'GroupControl1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.GroupControl1, "")
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.dtpDateTo)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.dtpDateFrom)
        Me.GroupControl1.Controls.Add(Me.btnBrandRefresh)
        Me.GroupControl1.Controls.Add(Me.btnProductCategory)
        Me.GroupControl1.Controls.Add(Me.btnProductType)
        Me.GroupControl1.Controls.Add(Me.CriterionPrice)
        Me.GroupControl1.Controls.Add(Me.btnFind)
        Me.GroupControl1.Controls.Add(Me.Label24)
        Me.GroupControl1.Controls.Add(Me.ProductTypeID)
        Me.GroupControl1.Controls.Add(Me.ProductCategoryID)
        Me.GroupControl1.Controls.Add(Me.CustomerID)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.btnProductGroup)
        Me.GroupControl1.Controls.Add(Me.btnCustomerID)
        Me.GroupControl1.Controls.Add(Me.ProductGroupID)
        Me.GroupControl1.Controls.Add(Me.Label33)
        Me.GroupControl1.Controls.Add(Me.Label19)
        Me.GroupControl1.Controls.Add(Me.Label18)
        Me.GroupControl1.Controls.Add(Me.Label10)
        Me.GroupControl1.Controls.Add(Me.ProductBrandID)
        Me.GroupControl1.Location = New System.Drawing.Point(11, 21)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.GroupControl1, True)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(888, 153)
        Me.GroupControl1.TabIndex = 307
        Me.GroupControl1.Text = "เงื่อนไขการค้นหา"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.GroupControl1, "")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label3, "")
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(262, 69)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label3, True)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 14)
        Me.Label3.TabIndex = 326
        Me.Label3.Text = "ถึง"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label3, "")
        '
        'dtpDateTo
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.dtpDateTo, "TextChanged")
        Me.dtpDateTo.EditValue = New Date(2012, 4, 20, 0, 0, 0, 0)
        Me.dtpDateTo.EnterMoveNextControl = True
        Me.dtpDateTo.Location = New System.Drawing.Point(307, 66)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.dtpDateTo, True)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.dtpDateTo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpDateTo.Properties.Appearance.Options.UseFont = True
        Me.dtpDateTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpDateTo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpDateTo.Properties.DisplayFormat.FormatString = "D"
        Me.dtpDateTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpDateTo.Properties.EditFormat.FormatString = "D"
        Me.dtpDateTo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpDateTo.Properties.MaskSettings.Set("mask", "D")
        Me.dtpDateTo.Size = New System.Drawing.Size(139, 20)
        Me.dtpDateTo.TabIndex = 325
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.dtpDateTo, "Text")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label2, "")
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 69)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label2, True)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 14)
        Me.Label2.TabIndex = 324
        Me.Label2.Text = "วันที่โปรโมชัน"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label2, "")
        '
        'dtpDateFrom
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.dtpDateFrom, "TextChanged")
        Me.dtpDateFrom.EditValue = New Date(2012, 4, 20, 0, 0, 0, 0)
        Me.dtpDateFrom.EnterMoveNextControl = True
        Me.dtpDateFrom.Location = New System.Drawing.Point(101, 66)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.dtpDateFrom, True)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.dtpDateFrom.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpDateFrom.Properties.Appearance.Options.UseFont = True
        Me.dtpDateFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpDateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpDateFrom.Properties.DisplayFormat.FormatString = "D"
        Me.dtpDateFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpDateFrom.Properties.EditFormat.FormatString = "D"
        Me.dtpDateFrom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpDateFrom.Properties.MaskSettings.Set("mask", "D")
        Me.dtpDateFrom.Size = New System.Drawing.Size(139, 20)
        Me.dtpDateFrom.TabIndex = 323
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.dtpDateFrom, "Text")
        '
        'btnBrandRefresh
        '
        Me.btnBrandRefresh.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnBrandRefresh.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnBrandRefresh, "")
        Me.btnBrandRefresh.ImageOptions.Image = CType(resources.GetObject("btnBrandRefresh.ImageOptions.Image"), System.Drawing.Image)
        Me.btnBrandRefresh.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnBrandRefresh.Location = New System.Drawing.Point(623, 123)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnBrandRefresh, True)
        Me.btnBrandRefresh.Name = "btnBrandRefresh"
        Me.btnBrandRefresh.Size = New System.Drawing.Size(21, 21)
        Me.btnBrandRefresh.TabIndex = 322
        Me.btnBrandRefresh.TabStop = False
        Me.btnBrandRefresh.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnBrandRefresh, "")
        '
        'btnProductCategory
        '
        Me.btnProductCategory.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnProductCategory.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnProductCategory, "")
        Me.btnProductCategory.ImageOptions.Image = CType(resources.GetObject("btnProductCategory.ImageOptions.Image"), System.Drawing.Image)
        Me.btnProductCategory.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnProductCategory.Location = New System.Drawing.Point(293, 98)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnProductCategory, True)
        Me.btnProductCategory.Name = "btnProductCategory"
        Me.btnProductCategory.Size = New System.Drawing.Size(21, 21)
        Me.btnProductCategory.TabIndex = 321
        Me.btnProductCategory.TabStop = False
        Me.btnProductCategory.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnProductCategory, "")
        '
        'btnProductType
        '
        Me.btnProductType.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnProductType.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnProductType, "")
        Me.btnProductType.ImageOptions.Image = CType(resources.GetObject("btnProductType.ImageOptions.Image"), System.Drawing.Image)
        Me.btnProductType.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnProductType.Location = New System.Drawing.Point(293, 120)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnProductType, True)
        Me.btnProductType.Name = "btnProductType"
        Me.btnProductType.Size = New System.Drawing.Size(21, 21)
        Me.btnProductType.TabIndex = 320
        Me.btnProductType.TabStop = False
        Me.btnProductType.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnProductType, "")
        '
        'CriterionPrice
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.CriterionPrice, "TextChanged")
        Me.CriterionPrice.EditValue = ""
        Me.CriterionPrice.EnterMoveNextControl = True
        Me.CriterionPrice.Location = New System.Drawing.Point(580, 36)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.CriterionPrice, True)
        Me.CriterionPrice.Name = "CriterionPrice"
        Me.CriterionPrice.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.CriterionPrice.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CriterionPrice.Properties.Appearance.Options.UseBackColor = True
        Me.CriterionPrice.Properties.Appearance.Options.UseFont = True
        Me.CriterionPrice.Properties.MaxLength = 50
        Me.CriterionPrice.Properties.ReadOnly = True
        Me.CriterionPrice.Properties.ValidateOnEnterKey = True
        Me.CriterionPrice.Size = New System.Drawing.Size(289, 20)
        Me.CriterionPrice.TabIndex = 258
        Me.CriterionPrice.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.CriterionPrice, "Text")
        '
        'btnFind
        '
        Me.btnFind.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnFind.Appearance.Options.UseFont = True
        Me.btnFind.Appearance.Options.UseImage = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnFind, "")
        Me.btnFind.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnFind.Location = New System.Drawing.Point(679, 97)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnFind, True)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(63, 32)
        Me.btnFind.TabIndex = 319
        Me.btnFind.TabStop = False
        Me.btnFind.Text = "ค้นหา"
        Me.btnFind.ToolTip = "ค้นหา"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnFind, "")
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label24, "")
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label24.Location = New System.Drawing.Point(519, 38)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label24, True)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(62, 14)
        Me.Label24.TabIndex = 257
        Me.Label24.Text = "เกณฑ์ราคา"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label24, "")
        '
        'ProductTypeID
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.ProductTypeID, "TextChanged")
        Me.ProductTypeID.Location = New System.Drawing.Point(100, 121)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.ProductTypeID, True)
        Me.ProductTypeID.Name = "ProductTypeID"
        Me.ProductTypeID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductTypeID.Properties.Appearance.Options.UseFont = True
        Me.ProductTypeID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProductTypeID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDCode", "Code", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NameThai", "Name", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.ProductTypeID.Properties.NullText = ""
        Me.ProductTypeID.Properties.ShowHeader = False
        Me.ProductTypeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProductTypeID.Size = New System.Drawing.Size(192, 20)
        Me.ProductTypeID.TabIndex = 3
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.ProductTypeID, "Text")
        '
        'ProductCategoryID
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.ProductCategoryID, "TextChanged")
        Me.ProductCategoryID.Location = New System.Drawing.Point(100, 98)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.ProductCategoryID, True)
        Me.ProductCategoryID.Name = "ProductCategoryID"
        Me.ProductCategoryID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductCategoryID.Properties.Appearance.Options.UseFont = True
        Me.ProductCategoryID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProductCategoryID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDCode", "Code", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NameThai", "Name", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.ProductCategoryID.Properties.NullText = ""
        Me.ProductCategoryID.Properties.ShowHeader = False
        Me.ProductCategoryID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProductCategoryID.Size = New System.Drawing.Size(192, 20)
        Me.ProductCategoryID.TabIndex = 1
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.ProductCategoryID, "Text")
        '
        'CustomerID
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.CustomerID, "TextChanged")
        Me.CustomerID.EnterMoveNextControl = True
        Me.CustomerID.Location = New System.Drawing.Point(100, 35)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.CustomerID, True)
        Me.CustomerID.Name = "CustomerID"
        Me.CustomerID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerID.Properties.Appearance.Options.UseFont = True
        Me.CustomerID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CustomerID.Properties.NullText = ""
        Me.CustomerID.Properties.PopupFindMode = DevExpress.XtraEditors.FindMode.Always
        Me.CustomerID.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.CustomerID.Size = New System.Drawing.Size(346, 20)
        Me.CustomerID.TabIndex = 0
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label6, "")
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(19, 38)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label6, True)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 14)
        Me.Label6.TabIndex = 218
        Me.Label6.Text = "ลูกค้า"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label6, "")
        '
        'btnProductGroup
        '
        Me.btnProductGroup.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnProductGroup.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnProductGroup, "")
        Me.btnProductGroup.ImageOptions.Image = CType(resources.GetObject("btnProductGroup.ImageOptions.Image"), System.Drawing.Image)
        Me.btnProductGroup.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnProductGroup.Location = New System.Drawing.Point(623, 97)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnProductGroup, True)
        Me.btnProductGroup.Name = "btnProductGroup"
        Me.btnProductGroup.Size = New System.Drawing.Size(21, 21)
        Me.btnProductGroup.TabIndex = 316
        Me.btnProductGroup.TabStop = False
        Me.btnProductGroup.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnProductGroup, "")
        '
        'btnCustomerID
        '
        Me.btnCustomerID.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCustomerID.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnCustomerID, "")
        Me.btnCustomerID.ImageOptions.Image = CType(resources.GetObject("btnCustomerID.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCustomerID.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCustomerID.Location = New System.Drawing.Point(452, 34)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnCustomerID, True)
        Me.btnCustomerID.Name = "btnCustomerID"
        Me.btnCustomerID.Size = New System.Drawing.Size(28, 22)
        Me.btnCustomerID.TabIndex = 217
        Me.btnCustomerID.TabStop = False
        Me.btnCustomerID.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnCustomerID, "")
        '
        'ProductGroupID
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.ProductGroupID, "TextChanged")
        Me.ProductGroupID.Location = New System.Drawing.Point(409, 98)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.ProductGroupID, True)
        Me.ProductGroupID.Name = "ProductGroupID"
        Me.ProductGroupID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductGroupID.Properties.Appearance.Options.UseFont = True
        Me.ProductGroupID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProductGroupID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeThai", "Code", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeEng", "Name", 100, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Remark", "Remark", 100, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.ProductGroupID.Properties.NullText = ""
        Me.ProductGroupID.Properties.ShowHeader = False
        Me.ProductGroupID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProductGroupID.Size = New System.Drawing.Size(212, 20)
        Me.ProductGroupID.TabIndex = 2
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.ProductGroupID, "Text")
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label33, "")
        Me.Label33.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label33.Location = New System.Drawing.Point(18, 100)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label33, True)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(62, 14)
        Me.Label33.TabIndex = 315
        Me.Label33.Text = "หมวดสินค้า"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label33, "")
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label19, "")
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label19.Location = New System.Drawing.Point(18, 123)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label19, True)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 14)
        Me.Label19.TabIndex = 313
        Me.Label19.Text = "ประเภทสินค้า"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label19, "")
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label18, "")
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.Location = New System.Drawing.Point(333, 127)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label18, True)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 14)
        Me.Label18.TabIndex = 312
        Me.Label18.Text = "ยี่ห้อสินค้า"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label18, "")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label10, "")
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(333, 101)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label10, True)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 14)
        Me.Label10.TabIndex = 311
        Me.Label10.Text = "กลุ่มสินค้า"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label10, "")
        '
        'ProductBrandID
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.ProductBrandID, "TextChanged")
        Me.ProductBrandID.Location = New System.Drawing.Point(409, 124)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.ProductBrandID, True)
        Me.ProductBrandID.Name = "ProductBrandID"
        Me.ProductBrandID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductBrandID.Properties.Appearance.Options.UseFont = True
        Me.ProductBrandID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProductBrandID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDCode", "Code", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NameThai", "Name", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.ProductBrandID.Properties.NullText = ""
        Me.ProductBrandID.Properties.ShowHeader = False
        Me.ProductBrandID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProductBrandID.Size = New System.Drawing.Size(212, 20)
        Me.ProductBrandID.TabIndex = 4
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.ProductBrandID, "Text")
        '
        'NoteTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.NoteTabPage, "")
        Me.NoteTabPage.Controls.Add(Me.UcNote1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.NoteTabPage, True)
        Me.NoteTabPage.Name = "NoteTabPage"
        Me.NoteTabPage.Size = New System.Drawing.Size(1358, 690)
        Me.NoteTabPage.Text = "บันทึกข้อความ"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.NoteTabPage, "")
        '
        'UcNote1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.UcNote1, "")
        Me.UcNote1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcNote1.Location = New System.Drawing.Point(0, 0)
        Me.UcNote1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.UcNote1, True)
        Me.UcNote1.Name = "UcNote1"
        Me.UcNote1.Size = New System.Drawing.Size(1358, 690)
        Me.UcNote1.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcNote1, "")
        '
        'AttachmentTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.AttachmentTabPage, "")
        Me.AttachmentTabPage.Controls.Add(Me.UcFileAttach1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.AttachmentTabPage, True)
        Me.AttachmentTabPage.Name = "AttachmentTabPage"
        Me.AttachmentTabPage.Size = New System.Drawing.Size(1358, 690)
        Me.AttachmentTabPage.Text = "ไฟล์แนบ"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.AttachmentTabPage, "")
        '
        'UcFileAttach1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.UcFileAttach1, "")
        Me.UcFileAttach1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcFileAttach1.Location = New System.Drawing.Point(0, 0)
        Me.UcFileAttach1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.UcFileAttach1, True)
        Me.UcFileAttach1.Name = "UcFileAttach1"
        Me.UcFileAttach1.Size = New System.Drawing.Size(1358, 690)
        Me.UcFileAttach1.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcFileAttach1, "")
        '
        'AdminTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.AdminTabPage, "")
        Me.AdminTabPage.Controls.Add(Me.UcAdmin1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.AdminTabPage, True)
        Me.AdminTabPage.Name = "AdminTabPage"
        Me.AdminTabPage.Size = New System.Drawing.Size(1358, 690)
        Me.AdminTabPage.Text = "ผู้บันทึก"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.AdminTabPage, "")
        '
        'UcAdmin1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.UcAdmin1, "")
        Me.UcAdmin1.Location = New System.Drawing.Point(45, 0)
        Me.UcAdmin1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.UcAdmin1, True)
        Me.UcAdmin1.Name = "UcAdmin1"
        Me.UcAdmin1.Size = New System.Drawing.Size(426, 142)
        Me.UcAdmin1.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcAdmin1, "")
        '
        'FormChangedComponent1
        '
        '
        'frmInformPrice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 745)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmInformPrice"
        Me.Text = "แจ้งราคา"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.GeneralTabPage.ResumeLayout(False)
        CType(Me.chkAutoRow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtListCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.dtpDateTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDateTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDateFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDateFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CriterionPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductTypeID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductCategoryID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductGroupID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBrandID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NoteTabPage.ResumeLayout(False)
        Me.AttachmentTabPage.ResumeLayout(False)
        Me.AdminTabPage.ResumeLayout(False)
        CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents NoteTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents AttachmentTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents AdminTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcNote1 As ucNote
    Friend WithEvents UcFileAttach1 As ucFileAttach
    Friend WithEvents UcAdmin1 As ucAdmin
    Friend WithEvents FormChangedComponent1 As FormChangedComponent
    Friend WithEvents ProductName As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents bindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents GeneralTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnFind As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ProductTypeID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ProductCategoryID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnProductGroup As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ProductGroupID As DevExpress.XtraEditors.LookUpEdit
    Private WithEvents Label33 As System.Windows.Forms.Label
    Private WithEvents Label19 As System.Windows.Forms.Label
    Private WithEvents Label18 As System.Windows.Forms.Label
    Private WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ProductBrandID As DevExpress.XtraEditors.LookUpEdit
    Private WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Private WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ProductID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProductCode As DevExpress.XtraGrid.Columns.GridColumn

    Friend WithEvents Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PriceInform As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PriceCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents ProductBtn As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents CriterionPrice As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label24 As System.Windows.Forms.Label
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
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnCustomerID As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents InformPriceID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProductRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnBrandRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnProductCategory As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnProductType As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAddPro As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtListCount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnMakeOrder As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PriceInformOld As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents chkAutoRow As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents CostAdjust As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Price1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Price2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Price3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Price4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Price5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Price6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PriceStandard As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Image As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnImage As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents Promotion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PriceOnline As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents Label3 As Label
    Friend WithEvents dtpDateTo As DevExpress.XtraEditors.DateEdit
    Private WithEvents Label2 As Label
    Friend WithEvents dtpDateFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ProductGuaranteeCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Subject As DevExpress.XtraGrid.Columns.GridColumn
End Class
