<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateStock
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdateStock))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnProductType = New DevExpress.XtraEditors.SimpleButton()
        Me.ProductTypeID = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnProductCategory = New DevExpress.XtraEditors.SimpleButton()
        Me.ProductCategoryID = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnProductGroup = New DevExpress.XtraEditors.SimpleButton()
        Me.ProductGroupID = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.btnBrandRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ProductBrandID = New DevExpress.XtraEditors.LookUpEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFind = New DevExpress.XtraEditors.SimpleButton()
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ProductID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProductCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProductName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Location = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Unit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Units = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Edit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.Hist = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonHist = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.LocationDTLID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UnitID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IsSN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UnitBtn = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ProductBtn = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.UnitsSpin = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.PriceCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.LocationDTLIDLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DiscountCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.CostCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.SelectCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.ProductNameBtn = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.TotalEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.btnImage = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.ProductTypeID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductCategoryID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductGroupID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBrandID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonHist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitsSpin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationDTLIDLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiscountCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductNameBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Controls.Add(Me.btnProductType)
        Me.PanelControl2.Controls.Add(Me.ProductTypeID)
        Me.PanelControl2.Controls.Add(Me.btnProductCategory)
        Me.PanelControl2.Controls.Add(Me.ProductCategoryID)
        Me.PanelControl2.Controls.Add(Me.btnProductGroup)
        Me.PanelControl2.Controls.Add(Me.ProductGroupID)
        Me.PanelControl2.Controls.Add(Me.Label33)
        Me.PanelControl2.Controls.Add(Me.btnBrandRefresh)
        Me.PanelControl2.Controls.Add(Me.Label19)
        Me.PanelControl2.Controls.Add(Me.Label18)
        Me.PanelControl2.Controls.Add(Me.Label10)
        Me.PanelControl2.Controls.Add(Me.ProductBrandID)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Controls.Add(Me.btnFind)
        Me.PanelControl2.Location = New System.Drawing.Point(4, 3)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1034, 115)
        Me.PanelControl2.TabIndex = 226
        '
        'btnProductType
        '
        Me.btnProductType.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnProductType.Appearance.Options.UseFont = True
        Me.btnProductType.Image = CType(resources.GetObject("btnProductType.Image"), System.Drawing.Image)
        Me.btnProductType.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnProductType.Location = New System.Drawing.Point(326, 62)
        Me.btnProductType.Name = "btnProductType"
        Me.btnProductType.Size = New System.Drawing.Size(21, 21)
        Me.btnProductType.TabIndex = 249
        Me.btnProductType.TabStop = False
        Me.btnProductType.ToolTip = "Refresh"
        '
        'ProductTypeID
        '
        Me.ProductTypeID.Location = New System.Drawing.Point(115, 63)
        Me.ProductTypeID.Name = "ProductTypeID"
        Me.ProductTypeID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductTypeID.Properties.Appearance.Options.UseFont = True
        Me.ProductTypeID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProductTypeID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDCode", 50, "Code"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NameThai", 100, "Name")})
        Me.ProductTypeID.Properties.NullText = ""
        Me.ProductTypeID.Properties.ShowHeader = False
        Me.ProductTypeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProductTypeID.Size = New System.Drawing.Size(210, 20)
        Me.ProductTypeID.TabIndex = 2
        '
        'btnProductCategory
        '
        Me.btnProductCategory.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnProductCategory.Appearance.Options.UseFont = True
        Me.btnProductCategory.Image = CType(resources.GetObject("btnProductCategory.Image"), System.Drawing.Image)
        Me.btnProductCategory.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnProductCategory.Location = New System.Drawing.Point(326, 10)
        Me.btnProductCategory.Name = "btnProductCategory"
        Me.btnProductCategory.Size = New System.Drawing.Size(21, 21)
        Me.btnProductCategory.TabIndex = 248
        Me.btnProductCategory.TabStop = False
        Me.btnProductCategory.ToolTip = "Refresh"
        '
        'ProductCategoryID
        '
        Me.ProductCategoryID.Location = New System.Drawing.Point(115, 11)
        Me.ProductCategoryID.Name = "ProductCategoryID"
        Me.ProductCategoryID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductCategoryID.Properties.Appearance.Options.UseFont = True
        Me.ProductCategoryID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProductCategoryID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDCode", 50, "Code"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NameThai", 100, "Name")})
        Me.ProductCategoryID.Properties.NullText = ""
        Me.ProductCategoryID.Properties.ShowHeader = False
        Me.ProductCategoryID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProductCategoryID.Size = New System.Drawing.Size(210, 20)
        Me.ProductCategoryID.TabIndex = 0
        '
        'btnProductGroup
        '
        Me.btnProductGroup.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnProductGroup.Appearance.Options.UseFont = True
        Me.btnProductGroup.Image = CType(resources.GetObject("btnProductGroup.Image"), System.Drawing.Image)
        Me.btnProductGroup.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnProductGroup.Location = New System.Drawing.Point(326, 36)
        Me.btnProductGroup.Name = "btnProductGroup"
        Me.btnProductGroup.Size = New System.Drawing.Size(21, 21)
        Me.btnProductGroup.TabIndex = 247
        Me.btnProductGroup.TabStop = False
        Me.btnProductGroup.ToolTip = "Refresh"
        '
        'ProductGroupID
        '
        Me.ProductGroupID.Location = New System.Drawing.Point(115, 37)
        Me.ProductGroupID.Name = "ProductGroupID"
        Me.ProductGroupID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductGroupID.Properties.Appearance.Options.UseFont = True
        Me.ProductGroupID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProductGroupID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeThai", 50, "Code"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeEng", "Name", 100, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Remark", "Remark", 100, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.ProductGroupID.Properties.NullText = ""
        Me.ProductGroupID.Properties.ShowHeader = False
        Me.ProductGroupID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProductGroupID.Size = New System.Drawing.Size(210, 20)
        Me.ProductGroupID.TabIndex = 1
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label33.Location = New System.Drawing.Point(37, 14)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(62, 14)
        Me.Label33.TabIndex = 246
        Me.Label33.Text = "หมวดสินค้า"
        '
        'btnBrandRefresh
        '
        Me.btnBrandRefresh.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnBrandRefresh.Appearance.Options.UseFont = True
        Me.btnBrandRefresh.Image = CType(resources.GetObject("btnBrandRefresh.Image"), System.Drawing.Image)
        Me.btnBrandRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnBrandRefresh.Location = New System.Drawing.Point(326, 89)
        Me.btnBrandRefresh.Name = "btnBrandRefresh"
        Me.btnBrandRefresh.Size = New System.Drawing.Size(21, 21)
        Me.btnBrandRefresh.TabIndex = 245
        Me.btnBrandRefresh.TabStop = False
        Me.btnBrandRefresh.ToolTip = "Refresh"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label19.Location = New System.Drawing.Point(37, 66)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 14)
        Me.Label19.TabIndex = 244
        Me.Label19.Text = "ประเภทสินค้า"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.Location = New System.Drawing.Point(37, 93)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 14)
        Me.Label18.TabIndex = 243
        Me.Label18.Text = "ยี่ห้อสินค้า"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(37, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 14)
        Me.Label10.TabIndex = 242
        Me.Label10.Text = "กลุ่มสินค้า"
        '
        'ProductBrandID
        '
        Me.ProductBrandID.Location = New System.Drawing.Point(115, 90)
        Me.ProductBrandID.Name = "ProductBrandID"
        Me.ProductBrandID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductBrandID.Properties.Appearance.Options.UseFont = True
        Me.ProductBrandID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProductBrandID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDCode", 50, "Code"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NameThai", 100, "Name")})
        Me.ProductBrandID.Properties.NullText = ""
        Me.ProductBrandID.Properties.ShowHeader = False
        Me.ProductBrandID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProductBrandID.Size = New System.Drawing.Size(210, 20)
        Me.ProductBrandID.TabIndex = 3
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Appearance.Options.UseImage = True
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.SimpleButton1.Location = New System.Drawing.Point(386, 71)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(101, 37)
        Me.SimpleButton1.TabIndex = 233
        Me.SimpleButton1.TabStop = False
        Me.SimpleButton1.Text = "ปิดหน้าจอ"
        Me.SimpleButton1.ToolTip = "ปิดหน้าจอ"
        '
        'btnFind
        '
        Me.btnFind.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnFind.Appearance.Options.UseFont = True
        Me.btnFind.Appearance.Options.UseImage = True
        Me.btnFind.Image = CType(resources.GetObject("btnFind.Image"), System.Drawing.Image)
        Me.btnFind.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnFind.Location = New System.Drawing.Point(386, 28)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(101, 37)
        Me.btnFind.TabIndex = 226
        Me.btnFind.TabStop = False
        Me.btnFind.Text = "ค้นหา"
        Me.btnFind.ToolTip = "ค้นหา"
        '
        'gridControl
        '
        Me.gridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gridControl.EmbeddedNavigator.Buttons.Edit.ImageIndex = 0
        Me.gridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gridControl.Location = New System.Drawing.Point(4, 124)
        Me.gridControl.MainView = Me.gridView
        Me.gridControl.Name = "gridControl"
        Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.UnitBtn, Me.ProductBtn, Me.UnitsSpin, Me.PriceCalcEdit1, Me.LocationDTLIDLookUpEdit1, Me.DiscountCalcEdit1, Me.CostCalcEdit1, Me.SelectCheckEdit2, Me.ProductNameBtn, Me.TotalEdit, Me.RepositoryItemButtonEdit, Me.btnImage, Me.RepositoryItemButtonHist})
        Me.gridControl.Size = New System.Drawing.Size(1037, 264)
        Me.gridControl.TabIndex = 301
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ProductID, Me.ProductCode, Me.ProductName, Me.Location, Me.Unit, Me.Units, Me.Edit, Me.Hist, Me.LocationDTLID, Me.UnitID, Me.IsSN})
        Me.gridView.GridControl = Me.gridControl
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsBehavior.ReadOnly = True
        Me.gridView.OptionsDetail.AllowZoomDetail = False
        Me.gridView.OptionsDetail.EnableMasterViewMode = False
        Me.gridView.OptionsDetail.ShowDetailTabs = False
        Me.gridView.OptionsDetail.SmartDetailExpand = False
        Me.gridView.OptionsFind.AlwaysVisible = True
        Me.gridView.OptionsLayout.Columns.AddNewColumns = False
        Me.gridView.OptionsLayout.Columns.RemoveOldColumns = False
        Me.gridView.OptionsMenu.EnableFooterMenu = False
        Me.gridView.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsNavigation.AutoFocusNewRow = True
        Me.gridView.OptionsNavigation.EnterMoveNextColumn = True
        Me.gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.gridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gridView.OptionsView.ShowGroupPanel = False
        '
        'ProductID
        '
        Me.ProductID.Caption = "GridColumn1"
        Me.ProductID.FieldName = "ProductID"
        Me.ProductID.Name = "ProductID"
        '
        'ProductCode
        '
        Me.ProductCode.AppearanceHeader.Options.UseTextOptions = True
        Me.ProductCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ProductCode.Caption = "รหัสสินค้า"
        Me.ProductCode.FieldName = "ProductCode"
        Me.ProductCode.MaxWidth = 160
        Me.ProductCode.MinWidth = 90
        Me.ProductCode.Name = "ProductCode"
        Me.ProductCode.Visible = True
        Me.ProductCode.VisibleIndex = 0
        Me.ProductCode.Width = 92
        '
        'ProductName
        '
        Me.ProductName.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.ProductName.AppearanceCell.Options.UseBackColor = True
        Me.ProductName.AppearanceHeader.Options.UseTextOptions = True
        Me.ProductName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ProductName.Caption = "ชื่อสินค้า"
        Me.ProductName.FieldName = "ProductName"
        Me.ProductName.MinWidth = 140
        Me.ProductName.Name = "ProductName"
        Me.ProductName.OptionsColumn.ReadOnly = True
        Me.ProductName.Visible = True
        Me.ProductName.VisibleIndex = 1
        Me.ProductName.Width = 514
        '
        'Location
        '
        Me.Location.AppearanceHeader.Options.UseTextOptions = True
        Me.Location.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Location.Caption = "ตำแหน่งเก็บ"
        Me.Location.FieldName = "Location"
        Me.Location.MaxWidth = 100
        Me.Location.MinWidth = 70
        Me.Location.Name = "Location"
        Me.Location.Visible = True
        Me.Location.VisibleIndex = 2
        Me.Location.Width = 94
        '
        'Unit
        '
        Me.Unit.AppearanceHeader.Options.UseTextOptions = True
        Me.Unit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Unit.Caption = "หน่วยนับ"
        Me.Unit.FieldName = "Unit"
        Me.Unit.MaxWidth = 90
        Me.Unit.MinWidth = 60
        Me.Unit.Name = "Unit"
        Me.Unit.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowOnlyInEditor
        Me.Unit.Visible = True
        Me.Unit.VisibleIndex = 3
        Me.Unit.Width = 84
        '
        'Units
        '
        Me.Units.AppearanceCell.Options.UseTextOptions = True
        Me.Units.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Units.AppearanceHeader.Options.UseTextOptions = True
        Me.Units.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Units.Caption = "จำนวน"
        Me.Units.DisplayFormat.FormatString = "n0"
        Me.Units.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Units.FieldName = "Units"
        Me.Units.MaxWidth = 100
        Me.Units.MinWidth = 50
        Me.Units.Name = "Units"
        Me.Units.Visible = True
        Me.Units.VisibleIndex = 4
        Me.Units.Width = 94
        '
        'Edit
        '
        Me.Edit.AppearanceHeader.Options.UseTextOptions = True
        Me.Edit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Edit.Caption = "แก้ไข"
        Me.Edit.ColumnEdit = Me.RepositoryItemButtonEdit
        Me.Edit.FieldName = "Edit"
        Me.Edit.MaxWidth = 70
        Me.Edit.MinWidth = 40
        Me.Edit.Name = "Edit"
        Me.Edit.OptionsColumn.ReadOnly = True
        Me.Edit.Visible = True
        Me.Edit.VisibleIndex = 5
        Me.Edit.Width = 60
        '
        'RepositoryItemButtonEdit
        '
        Me.RepositoryItemButtonEdit.AutoHeight = False
        Me.RepositoryItemButtonEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit.Name = "RepositoryItemButtonEdit"
        Me.RepositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'Hist
        '
        Me.Hist.AppearanceHeader.Options.UseTextOptions = True
        Me.Hist.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Hist.Caption = "Hist."
        Me.Hist.ColumnEdit = Me.RepositoryItemButtonHist
        Me.Hist.FieldName = "Hist"
        Me.Hist.MaxWidth = 70
        Me.Hist.MinWidth = 40
        Me.Hist.Name = "Hist"
        Me.Hist.Visible = True
        Me.Hist.VisibleIndex = 6
        Me.Hist.Width = 60
        '
        'RepositoryItemButtonHist
        '
        Me.RepositoryItemButtonHist.AutoHeight = False
        Me.RepositoryItemButtonHist.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonHist.Name = "RepositoryItemButtonHist"
        Me.RepositoryItemButtonHist.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'LocationDTLID
        '
        Me.LocationDTLID.Caption = "LocationDTLID"
        Me.LocationDTLID.FieldName = "LocationDTLID"
        Me.LocationDTLID.Name = "LocationDTLID"
        '
        'UnitID
        '
        Me.UnitID.Caption = "UnitID"
        Me.UnitID.FieldName = "UnitID"
        Me.UnitID.Name = "UnitID"
        '
        'IsSN
        '
        Me.IsSN.Caption = "IsSN"
        Me.IsSN.FieldName = "IsSN"
        Me.IsSN.Name = "IsSN"
        '
        'UnitBtn
        '
        Me.UnitBtn.AutoHeight = False
        Me.UnitBtn.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.UnitBtn.Name = "UnitBtn"
        '
        'ProductBtn
        '
        Me.ProductBtn.AutoHeight = False
        Me.ProductBtn.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ProductBtn.Name = "ProductBtn"
        '
        'UnitsSpin
        '
        Me.UnitsSpin.AutoHeight = False
        Me.UnitsSpin.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.UnitsSpin.EditFormat.FormatString = "n0"
        Me.UnitsSpin.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.UnitsSpin.IsFloatValue = False
        Me.UnitsSpin.Name = "UnitsSpin"
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
        'LocationDTLIDLookUpEdit1
        '
        Me.LocationDTLIDLookUpEdit1.AutoHeight = False
        Me.LocationDTLIDLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LocationDTLIDLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductID", "คลังสินค้า", 25, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationDTL", 40, "ตำแหน่ง"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationDTLID", "Name6", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.LocationDTLIDLookUpEdit1.DisplayMember = "LocationDTL"
        Me.LocationDTLIDLookUpEdit1.Name = "LocationDTLIDLookUpEdit1"
        Me.LocationDTLIDLookUpEdit1.NullText = ""
        Me.LocationDTLIDLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LocationDTLIDLookUpEdit1.ValueMember = "LocationDTLID"
        '
        'DiscountCalcEdit1
        '
        Me.DiscountCalcEdit1.AutoHeight = False
        Me.DiscountCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DiscountCalcEdit1.DisplayFormat.FormatString = "n2"
        Me.DiscountCalcEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.DiscountCalcEdit1.EditFormat.FormatString = "n2"
        Me.DiscountCalcEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.DiscountCalcEdit1.Name = "DiscountCalcEdit1"
        Me.DiscountCalcEdit1.Precision = 2
        '
        'CostCalcEdit1
        '
        Me.CostCalcEdit1.AutoHeight = False
        Me.CostCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CostCalcEdit1.DisplayFormat.FormatString = "n2"
        Me.CostCalcEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CostCalcEdit1.EditFormat.FormatString = "n2"
        Me.CostCalcEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CostCalcEdit1.Name = "CostCalcEdit1"
        '
        'SelectCheckEdit2
        '
        Me.SelectCheckEdit2.AutoHeight = False
        Me.SelectCheckEdit2.Name = "SelectCheckEdit2"
        '
        'ProductNameBtn
        '
        Me.ProductNameBtn.AutoHeight = False
        Me.ProductNameBtn.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "ชื่อสินค้าเพิ่มเติม", Nothing, Nothing, True)})
        Me.ProductNameBtn.Name = "ProductNameBtn"
        '
        'TotalEdit
        '
        Me.TotalEdit.AutoHeight = False
        Me.TotalEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TotalEdit.Name = "TotalEdit"
        '
        'btnImage
        '
        Me.btnImage.Appearance.Image = CType(resources.GetObject("btnImage.Appearance.Image"), System.Drawing.Image)
        Me.btnImage.Appearance.Options.UseImage = True
        Me.btnImage.AutoHeight = False
        Me.btnImage.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("btnImage.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.btnImage.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.btnImage.Name = "btnImage"
        Me.btnImage.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'frmUpdateStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 389)
        Me.Controls.Add(Me.gridControl)
        Me.Controls.Add(Me.PanelControl2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmUpdateStock"
        Me.Text = "อนุมติสต๊อก"
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.ProductTypeID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductCategoryID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductGroupID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBrandID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonHist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitsSpin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationDTLIDLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiscountCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductNameBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnFind As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnProductType As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ProductTypeID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnProductCategory As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ProductCategoryID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnProductGroup As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ProductGroupID As DevExpress.XtraEditors.LookUpEdit
    Private WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents btnBrandRefresh As DevExpress.XtraEditors.SimpleButton
    Private WithEvents Label19 As System.Windows.Forms.Label
    Private WithEvents Label18 As System.Windows.Forms.Label
    Private WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ProductBrandID As DevExpress.XtraEditors.LookUpEdit
    Private WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Private WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ProductID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProductCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProductBtn As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ProductName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Location As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Units As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LocationDTLID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Edit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents UnitID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UnitBtn As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents UnitsSpin As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents PriceCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents LocationDTLIDLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DiscountCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents CostCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents SelectCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ProductNameBtn As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents TotalEdit As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents btnImage As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents Hist As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonHist As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents IsSN As DevExpress.XtraGrid.Columns.GridColumn
End Class
