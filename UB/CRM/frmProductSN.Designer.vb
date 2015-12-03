<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductSN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductSN))
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.GeneralTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.chkAutoRow = New DevExpress.XtraEditors.CheckEdit()
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ProductID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProductCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProductName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.ProductRemark = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IsSN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.ProductBtn = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.PriceCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnBrandRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.btnProductCategory = New DevExpress.XtraEditors.SimpleButton()
        Me.btnProductType = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFind = New DevExpress.XtraEditors.SimpleButton()
        Me.ProductTypeID = New DevExpress.XtraEditors.LookUpEdit()
        Me.ProductCategoryID = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnProductGroup = New DevExpress.XtraEditors.SimpleButton()
        Me.ProductGroupID = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ProductBrandID = New DevExpress.XtraEditors.LookUpEdit()
        Me.FormChangedComponent1 = New UB.FormChangedComponent(Me.components)
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnSNList = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.GeneralTabPage.SuspendLayout()
        CType(Me.chkAutoRow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.ProductTypeID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductCategoryID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductGroupID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBrandID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSNList, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.XtraTabControl1.Size = New System.Drawing.Size(1095, 442)
        Me.XtraTabControl1.TabIndex = 8
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.GeneralTabPage})
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.XtraTabControl1, "")
        '
        'GeneralTabPage
        '
        Me.GeneralTabPage.Appearance.PageClient.BackColor = System.Drawing.Color.LightGray
        Me.GeneralTabPage.Appearance.PageClient.Options.UseBackColor = True
        Me.GeneralTabPage.AutoScroll = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.GeneralTabPage, "")
        Me.GeneralTabPage.Controls.Add(Me.chkAutoRow)
        Me.GeneralTabPage.Controls.Add(Me.gridControl)
        Me.GeneralTabPage.Controls.Add(Me.GroupControl1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.GeneralTabPage, True)
        Me.GeneralTabPage.Name = "GeneralTabPage"
        Me.GeneralTabPage.Size = New System.Drawing.Size(1089, 414)
        Me.GeneralTabPage.Text = "ข้อมูลทั่วไป"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.GeneralTabPage, "")
        '
        'chkAutoRow
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.chkAutoRow, "CheckedChanged")
        Me.chkAutoRow.Location = New System.Drawing.Point(40, 14)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.chkAutoRow, True)
        Me.chkAutoRow.Name = "chkAutoRow"
        Me.chkAutoRow.Properties.Caption = "ปรับความสูงของแถวอัตโนมัติ"
        Me.chkAutoRow.Size = New System.Drawing.Size(173, 19)
        Me.chkAutoRow.TabIndex = 309
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.chkAutoRow, "Checked")
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
        Me.gridControl.Location = New System.Drawing.Point(11, 129)
        Me.gridControl.MainView = Me.gridView
        Me.FormChangedComponent1.SetMonitorForChanges(Me.gridControl, True)
        Me.gridControl.Name = "gridControl"
        Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ProductBtn, Me.PriceCalcEdit1, Me.RepositoryItemMemoEdit1, Me.RepositoryItemCheckEdit1, Me.RepositoryItemButtonEdit1, Me.RepositoryItemCheckEdit2, Me.btnSNList})
        Me.gridControl.Size = New System.Drawing.Size(1068, 278)
        Me.gridControl.TabIndex = 290
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.gridControl, "")
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView, Me.GridView1})
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ProductID, Me.ProductCode, Me.ProductName, Me.ProductRemark, Me.IsSN, Me.GridColumn1})
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
        Me.gridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
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
        Me.ProductCode.MaxWidth = 150
        Me.ProductCode.MinWidth = 80
        Me.ProductCode.Name = "ProductCode"
        Me.ProductCode.OptionsColumn.ReadOnly = True
        Me.ProductCode.OptionsColumn.TabStop = False
        Me.ProductCode.Visible = True
        Me.ProductCode.VisibleIndex = 0
        Me.ProductCode.Width = 100
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
        Me.ProductName.VisibleIndex = 1
        Me.ProductName.Width = 400
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.LinesCount = 2
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        Me.RepositoryItemMemoEdit1.ScrollBars = System.Windows.Forms.ScrollBars.None
        '
        'ProductRemark
        '
        Me.ProductRemark.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProductRemark.AppearanceCell.Options.UseBackColor = True
        Me.ProductRemark.AppearanceHeader.Options.UseTextOptions = True
        Me.ProductRemark.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ProductRemark.Caption = "รายละเอียดสินค้า"
        Me.ProductRemark.FieldName = "ProductRemark"
        Me.ProductRemark.MaxWidth = 400
        Me.ProductRemark.MinWidth = 150
        Me.ProductRemark.Name = "ProductRemark"
        Me.ProductRemark.OptionsColumn.ReadOnly = True
        Me.ProductRemark.OptionsColumn.TabStop = False
        Me.ProductRemark.Visible = True
        Me.ProductRemark.VisibleIndex = 2
        Me.ProductRemark.Width = 150
        '
        'IsSN
        '
        Me.IsSN.AppearanceHeader.Options.UseTextOptions = True
        Me.IsSN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.IsSN.Caption = "S/N"
        Me.IsSN.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.IsSN.FieldName = "IsSN"
        Me.IsSN.MaxWidth = 100
        Me.IsSN.MinWidth = 50
        Me.IsSN.Name = "IsSN"
        Me.IsSN.Visible = True
        Me.IsSN.VisibleIndex = 3
        Me.IsSN.Width = 50
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        Me.RepositoryItemCheckEdit2.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepositoryItemCheckEdit2.ValueChecked = 1
        Me.RepositoryItemCheckEdit2.ValueUnchecked = 0
        '
        'ProductBtn
        '
        Me.ProductBtn.AutoHeight = False
        Me.ProductBtn.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ProductBtn.Name = "ProductBtn"
        Me.ProductBtn.ValidateOnEnterKey = True
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
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gridControl
        Me.GridView1.Name = "GridView1"
        '
        'GroupControl1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.GroupControl1, "")
        Me.GroupControl1.Controls.Add(Me.btnBrandRefresh)
        Me.GroupControl1.Controls.Add(Me.btnProductCategory)
        Me.GroupControl1.Controls.Add(Me.btnProductType)
        Me.GroupControl1.Controls.Add(Me.btnFind)
        Me.GroupControl1.Controls.Add(Me.ProductTypeID)
        Me.GroupControl1.Controls.Add(Me.ProductCategoryID)
        Me.GroupControl1.Controls.Add(Me.btnProductGroup)
        Me.GroupControl1.Controls.Add(Me.ProductGroupID)
        Me.GroupControl1.Controls.Add(Me.Label33)
        Me.GroupControl1.Controls.Add(Me.Label19)
        Me.GroupControl1.Controls.Add(Me.Label18)
        Me.GroupControl1.Controls.Add(Me.Label10)
        Me.GroupControl1.Controls.Add(Me.ProductBrandID)
        Me.GroupControl1.Location = New System.Drawing.Point(29, 39)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.GroupControl1, True)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(710, 84)
        Me.GroupControl1.TabIndex = 307
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.GroupControl1, "")
        '
        'btnBrandRefresh
        '
        Me.btnBrandRefresh.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnBrandRefresh.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnBrandRefresh, "")
        Me.btnBrandRefresh.Image = CType(resources.GetObject("btnBrandRefresh.Image"), System.Drawing.Image)
        Me.btnBrandRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnBrandRefresh.Location = New System.Drawing.Point(612, 49)
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
        Me.btnProductCategory.Image = CType(resources.GetObject("btnProductCategory.Image"), System.Drawing.Image)
        Me.btnProductCategory.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnProductCategory.Location = New System.Drawing.Point(273, 27)
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
        Me.btnProductType.Image = CType(resources.GetObject("btnProductType.Image"), System.Drawing.Image)
        Me.btnProductType.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnProductType.Location = New System.Drawing.Point(273, 49)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnProductType, True)
        Me.btnProductType.Name = "btnProductType"
        Me.btnProductType.Size = New System.Drawing.Size(21, 21)
        Me.btnProductType.TabIndex = 320
        Me.btnProductType.TabStop = False
        Me.btnProductType.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnProductType, "")
        '
        'btnFind
        '
        Me.btnFind.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnFind.Appearance.Options.UseFont = True
        Me.btnFind.Appearance.Options.UseImage = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnFind, "")
        Me.btnFind.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnFind.Location = New System.Drawing.Point(640, 23)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnFind, True)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(63, 32)
        Me.btnFind.TabIndex = 319
        Me.btnFind.TabStop = False
        Me.btnFind.Text = "ค้นหา"
        Me.btnFind.ToolTip = "ค้นหา"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnFind, "")
        '
        'ProductTypeID
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.ProductTypeID, "TextChanged")
        Me.ProductTypeID.Location = New System.Drawing.Point(80, 50)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.ProductTypeID, True)
        Me.ProductTypeID.Name = "ProductTypeID"
        Me.ProductTypeID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductTypeID.Properties.Appearance.Options.UseFont = True
        Me.ProductTypeID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProductTypeID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDCode", 50, "Code"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NameThai", 100, "Name")})
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
        Me.ProductCategoryID.Location = New System.Drawing.Point(80, 27)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.ProductCategoryID, True)
        Me.ProductCategoryID.Name = "ProductCategoryID"
        Me.ProductCategoryID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductCategoryID.Properties.Appearance.Options.UseFont = True
        Me.ProductCategoryID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProductCategoryID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDCode", 50, "Code"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NameThai", 100, "Name")})
        Me.ProductCategoryID.Properties.NullText = ""
        Me.ProductCategoryID.Properties.ShowHeader = False
        Me.ProductCategoryID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProductCategoryID.Size = New System.Drawing.Size(192, 20)
        Me.ProductCategoryID.TabIndex = 1
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.ProductCategoryID, "Text")
        '
        'btnProductGroup
        '
        Me.btnProductGroup.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnProductGroup.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnProductGroup, "")
        Me.btnProductGroup.Image = CType(resources.GetObject("btnProductGroup.Image"), System.Drawing.Image)
        Me.btnProductGroup.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnProductGroup.Location = New System.Drawing.Point(612, 23)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnProductGroup, True)
        Me.btnProductGroup.Name = "btnProductGroup"
        Me.btnProductGroup.Size = New System.Drawing.Size(21, 21)
        Me.btnProductGroup.TabIndex = 316
        Me.btnProductGroup.TabStop = False
        Me.btnProductGroup.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnProductGroup, "")
        '
        'ProductGroupID
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.ProductGroupID, "TextChanged")
        Me.ProductGroupID.Location = New System.Drawing.Point(399, 24)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.ProductGroupID, True)
        Me.ProductGroupID.Name = "ProductGroupID"
        Me.ProductGroupID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductGroupID.Properties.Appearance.Options.UseFont = True
        Me.ProductGroupID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProductGroupID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeThai", 50, "Code"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeEng", "Name", 100, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Remark", "Remark", 100, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
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
        Me.Label33.Location = New System.Drawing.Point(10, 30)
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
        Me.Label19.Location = New System.Drawing.Point(10, 53)
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
        Me.Label18.Location = New System.Drawing.Point(322, 53)
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
        Me.Label10.Location = New System.Drawing.Point(322, 27)
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
        Me.ProductBrandID.Location = New System.Drawing.Point(399, 50)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.ProductBrandID, True)
        Me.ProductBrandID.Name = "ProductBrandID"
        Me.ProductBrandID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductBrandID.Properties.Appearance.Options.UseFont = True
        Me.ProductBrandID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProductBrandID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDCode", 50, "Code"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NameThai", 100, "Name")})
        Me.ProductBrandID.Properties.NullText = ""
        Me.ProductBrandID.Properties.ShowHeader = False
        Me.ProductBrandID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProductBrandID.Size = New System.Drawing.Size(212, 20)
        Me.ProductBrandID.TabIndex = 4
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.ProductBrandID, "Text")
        '
        'FormChangedComponent1
        '
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = " "
        Me.GridColumn1.ColumnEdit = Me.btnSNList
        Me.GridColumn1.MaxWidth = 50
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 4
        Me.GridColumn1.Width = 50
        '
        'btnSNList
        '
        Me.btnSNList.AutoHeight = False
        Me.btnSNList.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.btnSNList.Name = "btnSNList"
        Me.btnSNList.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'frmProductSN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1095, 479)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frmProductSN"
        Me.Text = "แจ้งราคา"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.GeneralTabPage.ResumeLayout(False)
        CType(Me.chkAutoRow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.ProductTypeID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductCategoryID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductGroupID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBrandID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSNList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents FormChangedComponent1 As FormChangedComponent
    Friend WithEvents ProductNames As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents ProductName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PriceCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents ProductBtn As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ProductRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnBrandRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnProductCategory As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnProductType As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents chkAutoRow As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents IsSN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnSNList As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
End Class
