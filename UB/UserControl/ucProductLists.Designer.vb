<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucProductLists
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucProductLists))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.IsSelect = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SelectCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProductID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProductCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProductBtn = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ProductNames = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProductNameBtn = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.LocationDTLID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LocationDTLIDLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.UnitName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UnitBtn = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.KeepMin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UnitsSpin = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.Units = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AdjustUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Cost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CostCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.Price = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PriceCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.Discount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DiscountCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.Total = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TotalEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.Remark = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SEQ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UnitID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ModePro = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProductNameExt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Units_Old = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LocationDTLID_Old = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProductListRefID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonSN = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.SNList = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IsSN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IsShow = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IsMerge = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Image = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnImage = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.UnitMainID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RateUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IsDelete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PriceMain = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ControlNavigator1 = New DevExpress.XtraEditors.ControlNavigator()
        Me.btnFind = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductNameBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationDTLIDLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitsSpin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiscountCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonSN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection1.Images.SetKeyName(0, "_active__no.png")
        Me.ImageCollection1.Images.SetKeyName(1, "1394817194_stock_insert-slide.png")
        Me.ImageCollection1.Images.SetKeyName(2, "1432214789_Stock Index Up.png")
        Me.ImageCollection1.Images.SetKeyName(3, "1432214798_Stock Index Down.png")
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'gridControl
        '
        Me.gridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gridControl.EmbeddedNavigator.Buttons.Edit.ImageIndex = 0
        Me.gridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gridControl.Location = New System.Drawing.Point(0, 26)
        Me.gridControl.MainView = Me.gridView
        Me.gridControl.Name = "gridControl"
        Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.UnitBtn, Me.ProductBtn, Me.UnitsSpin, Me.PriceCalcEdit1, Me.LocationDTLIDLookUpEdit1, Me.DiscountCalcEdit1, Me.CostCalcEdit1, Me.SelectCheckEdit2, Me.ProductNameBtn, Me.TotalEdit, Me.RepositoryItemButtonSN, Me.btnImage})
        Me.gridControl.Size = New System.Drawing.Size(1075, 387)
        Me.gridControl.TabIndex = 9
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.IsSelect, Me.ID, Me.ProductID, Me.ProductCode, Me.ProductNames, Me.LocationDTLID, Me.UnitName, Me.KeepMin, Me.Units, Me.AdjustUnit, Me.Cost, Me.Price, Me.Discount, Me.Total, Me.Remark, Me.SEQ, Me.UnitID, Me.ModePro, Me.ProductNameExt, Me.Units_Old, Me.LocationDTLID_Old, Me.ProductListRefID, Me.SN, Me.SNList, Me.IsSN, Me.IsShow, Me.IsMerge, Me.Image, Me.UnitMainID, Me.RateUnit, Me.IsDelete, Me.PriceMain})
        Me.gridView.GridControl = Me.gridControl
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gridView.OptionsDetail.AllowZoomDetail = False
        Me.gridView.OptionsDetail.EnableMasterViewMode = False
        Me.gridView.OptionsDetail.ShowDetailTabs = False
        Me.gridView.OptionsDetail.SmartDetailExpand = False
        Me.gridView.OptionsLayout.Columns.AddNewColumns = False
        Me.gridView.OptionsLayout.Columns.RemoveOldColumns = False
        Me.gridView.OptionsMenu.EnableColumnMenu = False
        Me.gridView.OptionsMenu.EnableFooterMenu = False
        Me.gridView.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsNavigation.AutoFocusNewRow = True
        Me.gridView.OptionsNavigation.EnterMoveNextColumn = True
        Me.gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.gridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gridView.OptionsView.ShowGroupPanel = False
        '
        'IsSelect
        '
        Me.IsSelect.AppearanceCell.Options.UseTextOptions = True
        Me.IsSelect.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.IsSelect.AppearanceHeader.Options.UseTextOptions = True
        Me.IsSelect.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.IsSelect.Caption = "เลือก"
        Me.IsSelect.ColumnEdit = Me.SelectCheckEdit2
        Me.IsSelect.FieldName = "IsSelect"
        Me.IsSelect.MaxWidth = 50
        Me.IsSelect.MinWidth = 40
        Me.IsSelect.Name = "IsSelect"
        Me.IsSelect.Visible = True
        Me.IsSelect.VisibleIndex = 0
        Me.IsSelect.Width = 41
        '
        'SelectCheckEdit2
        '
        Me.SelectCheckEdit2.AutoHeight = False
        Me.SelectCheckEdit2.Name = "SelectCheckEdit2"
        '
        'ID
        '
        Me.ID.Caption = "ID"
        Me.ID.FieldName = "ID"
        Me.ID.Name = "ID"
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
        Me.ProductCode.ColumnEdit = Me.ProductBtn
        Me.ProductCode.FieldName = "ProductCode"
        Me.ProductCode.MaxWidth = 160
        Me.ProductCode.MinWidth = 90
        Me.ProductCode.Name = "ProductCode"
        Me.ProductCode.Visible = True
        Me.ProductCode.VisibleIndex = 1
        Me.ProductCode.Width = 91
        '
        'ProductBtn
        '
        Me.ProductBtn.AutoHeight = False
        Me.ProductBtn.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ProductBtn.Name = "ProductBtn"
        '
        'ProductNames
        '
        Me.ProductNames.AppearanceCell.BackColor = System.Drawing.Color.LightYellow
        Me.ProductNames.AppearanceCell.Options.UseBackColor = True
        Me.ProductNames.AppearanceHeader.Options.UseTextOptions = True
        Me.ProductNames.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ProductNames.Caption = "ชื่อสินค้า"
        Me.ProductNames.ColumnEdit = Me.ProductNameBtn
        Me.ProductNames.FieldName = "ProductNames"
        Me.ProductNames.MinWidth = 140
        Me.ProductNames.Name = "ProductNames"
        Me.ProductNames.OptionsColumn.ReadOnly = True
        Me.ProductNames.Visible = True
        Me.ProductNames.VisibleIndex = 2
        Me.ProductNames.Width = 182
        '
        'ProductNameBtn
        '
        Me.ProductNameBtn.AutoHeight = False
        Me.ProductNameBtn.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "ชื่อสินค้าเพิ่มเติม", Nothing, Nothing, True)})
        Me.ProductNameBtn.Name = "ProductNameBtn"
        '
        'LocationDTLID
        '
        Me.LocationDTLID.AppearanceHeader.Options.UseTextOptions = True
        Me.LocationDTLID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LocationDTLID.Caption = "ตำแหน่งเก็บ"
        Me.LocationDTLID.ColumnEdit = Me.LocationDTLIDLookUpEdit1
        Me.LocationDTLID.FieldName = "LocationDTLID"
        Me.LocationDTLID.MaxWidth = 100
        Me.LocationDTLID.MinWidth = 70
        Me.LocationDTLID.Name = "LocationDTLID"
        Me.LocationDTLID.Visible = True
        Me.LocationDTLID.VisibleIndex = 3
        Me.LocationDTLID.Width = 100
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
        'UnitName
        '
        Me.UnitName.AppearanceHeader.Options.UseTextOptions = True
        Me.UnitName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.UnitName.Caption = "หน่วยนับ"
        Me.UnitName.ColumnEdit = Me.UnitBtn
        Me.UnitName.FieldName = "UnitName"
        Me.UnitName.MaxWidth = 90
        Me.UnitName.MinWidth = 60
        Me.UnitName.Name = "UnitName"
        Me.UnitName.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowOnlyInEditor
        Me.UnitName.Visible = True
        Me.UnitName.VisibleIndex = 4
        Me.UnitName.Width = 90
        '
        'UnitBtn
        '
        Me.UnitBtn.AutoHeight = False
        Me.UnitBtn.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.UnitBtn.Name = "UnitBtn"
        '
        'KeepMin
        '
        Me.KeepMin.AppearanceCell.Options.UseTextOptions = True
        Me.KeepMin.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.KeepMin.AppearanceHeader.Options.UseTextOptions = True
        Me.KeepMin.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.KeepMin.Caption = "จำนวนต่ำสุด"
        Me.KeepMin.ColumnEdit = Me.UnitsSpin
        Me.KeepMin.DisplayFormat.FormatString = "n0"
        Me.KeepMin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.KeepMin.FieldName = "KeepMin"
        Me.KeepMin.MaxWidth = 120
        Me.KeepMin.MinWidth = 50
        Me.KeepMin.Name = "KeepMin"
        Me.KeepMin.ToolTip = "จำนวนต่ำสุด"
        Me.KeepMin.Visible = True
        Me.KeepMin.VisibleIndex = 5
        Me.KeepMin.Width = 50
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
        'Units
        '
        Me.Units.Caption = "Units"
        Me.Units.FieldName = "Units"
        Me.Units.Name = "Units"
        '
        'AdjustUnit
        '
        Me.AdjustUnit.AppearanceHeader.Options.UseTextOptions = True
        Me.AdjustUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.AdjustUnit.Caption = "จำนวน"
        Me.AdjustUnit.ColumnEdit = Me.UnitsSpin
        Me.AdjustUnit.DisplayFormat.FormatString = "n0"
        Me.AdjustUnit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.AdjustUnit.FieldName = "AdjustUnit"
        Me.AdjustUnit.MaxWidth = 100
        Me.AdjustUnit.MinWidth = 50
        Me.AdjustUnit.Name = "AdjustUnit"
        Me.AdjustUnit.Visible = True
        Me.AdjustUnit.VisibleIndex = 6
        Me.AdjustUnit.Width = 62
        '
        'Cost
        '
        Me.Cost.AppearanceHeader.Options.UseTextOptions = True
        Me.Cost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Cost.Caption = "ต้นทุน"
        Me.Cost.ColumnEdit = Me.CostCalcEdit1
        Me.Cost.DisplayFormat.FormatString = "n2"
        Me.Cost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Cost.FieldName = "Cost"
        Me.Cost.MaxWidth = 120
        Me.Cost.MinWidth = 90
        Me.Cost.Name = "Cost"
        Me.Cost.Visible = True
        Me.Cost.VisibleIndex = 7
        Me.Cost.Width = 91
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
        'Price
        '
        Me.Price.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.Price.AppearanceCell.Options.UseBackColor = True
        Me.Price.AppearanceCell.Options.UseTextOptions = True
        Me.Price.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Price.AppearanceHeader.Options.UseTextOptions = True
        Me.Price.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Price.Caption = "ราคา"
        Me.Price.ColumnEdit = Me.PriceCalcEdit1
        Me.Price.DisplayFormat.FormatString = "n2"
        Me.Price.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Price.FieldName = "Price"
        Me.Price.MaxWidth = 120
        Me.Price.MinWidth = 80
        Me.Price.Name = "Price"
        Me.Price.Visible = True
        Me.Price.VisibleIndex = 8
        Me.Price.Width = 101
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
        'Discount
        '
        Me.Discount.AppearanceHeader.Options.UseTextOptions = True
        Me.Discount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Discount.Caption = "ส่วนลด/หน่วย"
        Me.Discount.ColumnEdit = Me.DiscountCalcEdit1
        Me.Discount.DisplayFormat.FormatString = "n2"
        Me.Discount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Discount.FieldName = "Discount"
        Me.Discount.MaxWidth = 100
        Me.Discount.MinWidth = 60
        Me.Discount.Name = "Discount"
        Me.Discount.Visible = True
        Me.Discount.VisibleIndex = 9
        Me.Discount.Width = 71
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
        'Total
        '
        Me.Total.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Total.AppearanceCell.Options.UseBackColor = True
        Me.Total.AppearanceCell.Options.UseTextOptions = True
        Me.Total.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Total.AppearanceHeader.Options.UseTextOptions = True
        Me.Total.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Total.Caption = "จำนวนเงิน"
        Me.Total.ColumnEdit = Me.TotalEdit
        Me.Total.DisplayFormat.FormatString = "n2"
        Me.Total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Total.FieldName = "Total"
        Me.Total.MaxWidth = 150
        Me.Total.MinWidth = 80
        Me.Total.Name = "Total"
        Me.Total.OptionsColumn.AllowEdit = False
        Me.Total.OptionsColumn.ReadOnly = True
        Me.Total.OptionsColumn.TabStop = False
        Me.Total.Visible = True
        Me.Total.VisibleIndex = 10
        Me.Total.Width = 101
        '
        'TotalEdit
        '
        Me.TotalEdit.AutoHeight = False
        Me.TotalEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TotalEdit.Name = "TotalEdit"
        '
        'Remark
        '
        Me.Remark.AppearanceHeader.Options.UseTextOptions = True
        Me.Remark.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Remark.Caption = "รายละเอียด"
        Me.Remark.FieldName = "Remark"
        Me.Remark.MinWidth = 50
        Me.Remark.Name = "Remark"
        Me.Remark.Visible = True
        Me.Remark.VisibleIndex = 11
        Me.Remark.Width = 50
        '
        'SEQ
        '
        Me.SEQ.Caption = "SEQ"
        Me.SEQ.FieldName = "SEQ"
        Me.SEQ.Name = "SEQ"
        '
        'UnitID
        '
        Me.UnitID.Caption = "GridColumn2"
        Me.UnitID.FieldName = "UnitID"
        Me.UnitID.Name = "UnitID"
        '
        'ModePro
        '
        Me.ModePro.Caption = "ModePro"
        Me.ModePro.FieldName = "ModePro"
        Me.ModePro.Name = "ModePro"
        '
        'ProductNameExt
        '
        Me.ProductNameExt.Caption = "GridColumn1"
        Me.ProductNameExt.FieldName = "ProductNameExt"
        Me.ProductNameExt.Name = "ProductNameExt"
        '
        'Units_Old
        '
        Me.Units_Old.Caption = "GridColumn1"
        Me.Units_Old.FieldName = "Units_Old"
        Me.Units_Old.Name = "Units_Old"
        '
        'LocationDTLID_Old
        '
        Me.LocationDTLID_Old.Caption = "LocationDTLID_Old"
        Me.LocationDTLID_Old.FieldName = "LocationDTLID_Old"
        Me.LocationDTLID_Old.Name = "LocationDTLID_Old"
        '
        'ProductListRefID
        '
        Me.ProductListRefID.Caption = "GridColumn1"
        Me.ProductListRefID.FieldName = "ProductListRefID"
        Me.ProductListRefID.Name = "ProductListRefID"
        '
        'SN
        '
        Me.SN.AppearanceHeader.Options.UseTextOptions = True
        Me.SN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SN.Caption = "S/N"
        Me.SN.ColumnEdit = Me.RepositoryItemButtonSN
        Me.SN.FieldName = "SN"
        Me.SN.MaxWidth = 30
        Me.SN.Name = "SN"
        Me.SN.OptionsColumn.ReadOnly = True
        Me.SN.Visible = True
        Me.SN.VisibleIndex = 12
        Me.SN.Width = 23
        '
        'RepositoryItemButtonSN
        '
        Me.RepositoryItemButtonSN.AutoHeight = False
        Me.RepositoryItemButtonSN.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonSN.Name = "RepositoryItemButtonSN"
        Me.RepositoryItemButtonSN.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'SNList
        '
        Me.SNList.Caption = "SNList"
        Me.SNList.FieldName = "SNList"
        Me.SNList.Name = "SNList"
        '
        'IsSN
        '
        Me.IsSN.Caption = "IsSN"
        Me.IsSN.FieldName = "IsSN"
        Me.IsSN.Name = "IsSN"
        '
        'IsShow
        '
        Me.IsShow.Caption = "IsShow"
        Me.IsShow.FieldName = "IsShow"
        Me.IsShow.MaxWidth = 20
        Me.IsShow.Name = "IsShow"
        Me.IsShow.Width = 20
        '
        'IsMerge
        '
        Me.IsMerge.Caption = "GridColumn1"
        Me.IsMerge.FieldName = "IsMerge"
        Me.IsMerge.MaxWidth = 20
        Me.IsMerge.Name = "IsMerge"
        Me.IsMerge.Width = 20
        '
        'Image
        '
        Me.Image.AppearanceHeader.Options.UseTextOptions = True
        Me.Image.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Image.Caption = "Image"
        Me.Image.ColumnEdit = Me.btnImage
        Me.Image.FieldName = "Image"
        Me.Image.MaxWidth = 38
        Me.Image.MinWidth = 30
        Me.Image.Name = "Image"
        Me.Image.Visible = True
        Me.Image.VisibleIndex = 13
        Me.Image.Width = 38
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
        'UnitMainID
        '
        Me.UnitMainID.Caption = "UnitMainID"
        Me.UnitMainID.FieldName = "UnitMainID"
        Me.UnitMainID.Name = "UnitMainID"
        '
        'RateUnit
        '
        Me.RateUnit.Caption = "RateUnit"
        Me.RateUnit.FieldName = "RateUnit"
        Me.RateUnit.Name = "RateUnit"
        '
        'IsDelete
        '
        Me.IsDelete.Caption = "IsDelete"
        Me.IsDelete.FieldName = "IsDelete"
        Me.IsDelete.Name = "IsDelete"
        '
        'PriceMain
        '
        Me.PriceMain.Caption = "PriceMain"
        Me.PriceMain.FieldName = "PriceMain"
        Me.PriceMain.Name = "PriceMain"
        '
        'ControlNavigator1
        '
        Me.ControlNavigator1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ControlNavigator1.Buttons.Append.Visible = False
        Me.ControlNavigator1.Buttons.CancelEdit.Visible = False
        Me.ControlNavigator1.Buttons.Edit.Visible = False
        Me.ControlNavigator1.Buttons.EndEdit.Visible = False
        Me.ControlNavigator1.Buttons.ImageList = Me.ImageCollection1
        Me.ControlNavigator1.Buttons.Remove.Hint = "ลบข้อมูล"
        Me.ControlNavigator1.Buttons.Remove.ImageIndex = 0
        Me.ControlNavigator1.Buttons.Remove.Tag = " ลบข้อมูล"
        Me.ControlNavigator1.Buttons.Remove.Visible = False
        Me.ControlNavigator1.CustomButtons.AddRange(New DevExpress.XtraEditors.NavigatorCustomButton() {New DevExpress.XtraEditors.NavigatorCustomButton(6, 0, True, True, "Remove", "Remove"), New DevExpress.XtraEditors.NavigatorCustomButton(7, 1, True, True, "Insert", "Insert"), New DevExpress.XtraEditors.NavigatorCustomButton(-1, 2, True, True, "Move Up", "MoveUp"), New DevExpress.XtraEditors.NavigatorCustomButton(-1, 3, True, True, "Move Down", "MoveDown")})
        Me.ControlNavigator1.Location = New System.Drawing.Point(0, 413)
        Me.ControlNavigator1.Name = "ControlNavigator1"
        Me.ControlNavigator1.NavigatableControl = Me.gridControl
        Me.ControlNavigator1.Size = New System.Drawing.Size(261, 24)
        Me.ControlNavigator1.TabIndex = 12
        Me.ControlNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
        '
        'btnFind
        '
        Me.btnFind.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnFind.Appearance.Options.UseFont = True
        Me.btnFind.Appearance.Options.UseImage = True
        Me.btnFind.Image = CType(resources.GetObject("btnFind.Image"), System.Drawing.Image)
        Me.btnFind.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnFind.Location = New System.Drawing.Point(3, 1)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(102, 24)
        Me.btnFind.TabIndex = 249
        Me.btnFind.TabStop = False
        Me.btnFind.Text = "เพิ่มสินค้า"
        Me.btnFind.ToolTip = "เพิ่มสินค้า"
        '
        'ucProductLists
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.ControlNavigator1)
        Me.Controls.Add(Me.gridControl)
        Me.Name = "ucProductLists"
        Me.Size = New System.Drawing.Size(1075, 437)
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductNameBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationDTLIDLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitsSpin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiscountCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonSN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Private WithEvents bindingSource1 As System.Windows.Forms.BindingSource
    Private WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Private WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UnitName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UnitBtn As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SEQ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UnitID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ControlNavigator1 As DevExpress.XtraEditors.ControlNavigator
    Friend WithEvents ProductID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProductCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProductNames As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProductBtn As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents AdjustUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UnitsSpin As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents Price As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PriceCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents Total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LocationDTLID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LocationDTLIDLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Discount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DiscountCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents Cost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CostCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents IsSelect As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SelectCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ModePro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KeepMin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProductNameExt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProductNameBtn As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents TotalEdit As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents Units_Old As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LocationDTLID_Old As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProductListRefID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonSN As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents SNList As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IsSN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IsShow As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IsMerge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnFind As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Image As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnImage As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents Units As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UnitMainID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RateUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IsDelete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PriceMain As DevExpress.XtraGrid.Columns.GridColumn

End Class
