<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucProductLocation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucProductLocation))
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SEQ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LocationID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LocationIDLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.LocationDTLID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LocationDTLIDLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.KeepMin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.KeepMinCalcEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.KeepMax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.KeepMaxCalcEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.IsMain = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IsInActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.KeepMinSpinEdit = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.LocationDTLSearchLookUp1 = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.LocationGrid = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.LocationDTLView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LocationIDComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.LocationDTLLookUp = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemPopupContainerEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
        Me.LocationButtonEdit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemRadioGroup1 = New DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ControlNavigator1 = New DevExpress.XtraEditors.ControlNavigator()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationIDLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationDTLIDLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KeepMinCalcEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KeepMaxCalcEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KeepMinSpinEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationDTLSearchLookUp1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationDTLView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationIDComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationDTLLookUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationButtonEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridControl
        '
        Me.gridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gridControl.EmbeddedNavigator.Buttons.Edit.ImageIndex = 0
        Me.gridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gridControl.Location = New System.Drawing.Point(0, 0)
        Me.gridControl.MainView = Me.gridView
        Me.gridControl.Name = "gridControl"
        Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LocationIDLookUpEdit, Me.repositoryItemCalcEdit1, Me.repositoryItemSpinEdit1, Me.repositoryItemTextEdit1, Me.KeepMinSpinEdit, Me.LocationDTLIDLookUpEdit1, Me.KeepMinCalcEdit, Me.KeepMaxCalcEdit, Me.RepositoryItemCheckEdit1, Me.LocationDTLSearchLookUp1, Me.RepositoryItemLookUpEdit1, Me.LocationGrid, Me.LocationIDComboBox, Me.LocationDTLLookUp, Me.RepositoryItemPopupContainerEdit1, Me.LocationButtonEdit, Me.RepositoryItemRadioGroup1, Me.RepositoryItemCheckEdit2})
        Me.gridControl.Size = New System.Drawing.Size(828, 359)
        Me.gridControl.TabIndex = 9
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ID, Me.SEQ, Me.LocationID, Me.LocationDTLID, Me.KeepMin, Me.KeepMax, Me.IsMain, Me.IsInActive})
        Me.gridView.GridControl = Me.gridControl
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gridView.OptionsLayout.Columns.AddNewColumns = False
        Me.gridView.OptionsLayout.Columns.RemoveOldColumns = False
        Me.gridView.OptionsNavigation.AutoFocusNewRow = True
        Me.gridView.OptionsNavigation.EnterMoveNextColumn = True
        Me.gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.gridView.OptionsView.ShowGroupPanel = False
        '
        'ID
        '
        Me.ID.Caption = "ID"
        Me.ID.FieldName = "ID"
        Me.ID.Name = "ID"
        '
        'SEQ
        '
        Me.SEQ.Caption = "SEQ"
        Me.SEQ.FieldName = "SEQ"
        Me.SEQ.Name = "SEQ"
        '
        'LocationID
        '
        Me.LocationID.Caption = "คลังสินค้า"
        Me.LocationID.ColumnEdit = Me.LocationIDLookUpEdit
        Me.LocationID.FieldName = "LocationID"
        Me.LocationID.MaxWidth = 200
        Me.LocationID.MinWidth = 100
        Me.LocationID.Name = "LocationID"
        Me.LocationID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals
        Me.LocationID.Visible = True
        Me.LocationID.VisibleIndex = 0
        Me.LocationID.Width = 100
        '
        'LocationIDLookUpEdit
        '
        Me.LocationIDLookUpEdit.AutoHeight = False
        Me.LocationIDLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LocationIDLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo(" ID", " ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDCode", "รหัสคลัง"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NameThai", 50, "ชื่อคลัง")})
        Me.LocationIDLookUpEdit.DisplayMember = "NameThai"
        Me.LocationIDLookUpEdit.DropDownRows = 10
        Me.LocationIDLookUpEdit.Name = "LocationIDLookUpEdit"
        Me.LocationIDLookUpEdit.NullText = ""
        Me.LocationIDLookUpEdit.PopupWidth = 220
        Me.LocationIDLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LocationIDLookUpEdit.ValueMember = "ID"
        '
        'LocationDTLID
        '
        Me.LocationDTLID.Caption = "ตำแหน่งเก็บ สินค้า"
        Me.LocationDTLID.ColumnEdit = Me.LocationDTLIDLookUpEdit1
        Me.LocationDTLID.FieldName = "LocationDTLID"
        Me.LocationDTLID.MinWidth = 200
        Me.LocationDTLID.Name = "LocationDTLID"
        Me.LocationDTLID.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.LocationDTLID.Visible = True
        Me.LocationDTLID.VisibleIndex = 1
        Me.LocationDTLID.Width = 254
        '
        'LocationDTLIDLookUpEdit1
        '
        Me.LocationDTLIDLookUpEdit1.AutoHeight = False
        Me.LocationDTLIDLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LocationDTLIDLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationID", "คลังสินค้า", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationDTL", "ตำแหน่ง"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationDTLID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.LocationDTLIDLookUpEdit1.DisplayMember = "LocationDTL"
        Me.LocationDTLIDLookUpEdit1.Name = "LocationDTLIDLookUpEdit1"
        Me.LocationDTLIDLookUpEdit1.NullText = ""
        Me.LocationDTLIDLookUpEdit1.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.LocationDTLIDLookUpEdit1.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.LocationDTLIDLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LocationDTLIDLookUpEdit1.ValueMember = "LocationDTLID"
        '
        'KeepMin
        '
        Me.KeepMin.AppearanceHeader.Options.UseTextOptions = True
        Me.KeepMin.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.KeepMin.Caption = "จัดเก็บต่ำสุด"
        Me.KeepMin.ColumnEdit = Me.KeepMinCalcEdit
        Me.KeepMin.DisplayFormat.FormatString = "n2"
        Me.KeepMin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.KeepMin.FieldName = "KeepMin"
        Me.KeepMin.MaxWidth = 200
        Me.KeepMin.MinWidth = 100
        Me.KeepMin.Name = "KeepMin"
        Me.KeepMin.Visible = True
        Me.KeepMin.VisibleIndex = 2
        Me.KeepMin.Width = 158
        '
        'KeepMinCalcEdit
        '
        Me.KeepMinCalcEdit.AutoHeight = False
        Me.KeepMinCalcEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.KeepMinCalcEdit.Name = "KeepMinCalcEdit"
        '
        'KeepMax
        '
        Me.KeepMax.AppearanceHeader.Options.UseTextOptions = True
        Me.KeepMax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.KeepMax.Caption = "จัดเก็บสูงสุด"
        Me.KeepMax.ColumnEdit = Me.KeepMaxCalcEdit
        Me.KeepMax.DisplayFormat.FormatString = "Numeric ""n2"""
        Me.KeepMax.FieldName = "KeepMax"
        Me.KeepMax.MaxWidth = 200
        Me.KeepMax.MinWidth = 100
        Me.KeepMax.Name = "KeepMax"
        Me.KeepMax.Visible = True
        Me.KeepMax.VisibleIndex = 3
        Me.KeepMax.Width = 150
        '
        'KeepMaxCalcEdit
        '
        Me.KeepMaxCalcEdit.AutoHeight = False
        Me.KeepMaxCalcEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.KeepMaxCalcEdit.Name = "KeepMaxCalcEdit"
        '
        'IsMain
        '
        Me.IsMain.AppearanceCell.Options.UseTextOptions = True
        Me.IsMain.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.IsMain.AppearanceHeader.Options.UseTextOptions = True
        Me.IsMain.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.IsMain.Caption = "คลังหลัก"
        Me.IsMain.FieldName = "IsMain"
        Me.IsMain.MaxWidth = 150
        Me.IsMain.MinWidth = 100
        Me.IsMain.Name = "IsMain"
        Me.IsMain.Visible = True
        Me.IsMain.VisibleIndex = 4
        Me.IsMain.Width = 100
        '
        'IsInActive
        '
        Me.IsInActive.AppearanceCell.Options.UseTextOptions = True
        Me.IsInActive.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.IsInActive.AppearanceHeader.Options.UseTextOptions = True
        Me.IsInActive.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.IsInActive.Caption = "ระงับการใช้งาน"
        Me.IsInActive.FieldName = "IsInActive"
        Me.IsInActive.MaxWidth = 120
        Me.IsInActive.MinWidth = 100
        Me.IsInActive.Name = "IsInActive"
        Me.IsInActive.Visible = True
        Me.IsInActive.VisibleIndex = 5
        Me.IsInActive.Width = 100
        '
        'repositoryItemCalcEdit1
        '
        Me.repositoryItemCalcEdit1.AutoHeight = False
        Me.repositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repositoryItemCalcEdit1.Mask.EditMask = "c"
        Me.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1"
        '
        'repositoryItemSpinEdit1
        '
        Me.repositoryItemSpinEdit1.AutoHeight = False
        Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.repositoryItemSpinEdit1.IsFloatValue = False
        Me.repositoryItemSpinEdit1.Mask.EditMask = "N00"
        Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
        '
        'repositoryItemTextEdit1
        '
        Me.repositoryItemTextEdit1.AutoHeight = False
        Me.repositoryItemTextEdit1.Mask.EditMask = "p"
        Me.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
        '
        'KeepMinSpinEdit
        '
        Me.KeepMinSpinEdit.AutoHeight = False
        Me.KeepMinSpinEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.KeepMinSpinEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.KeepMinSpinEdit.Mask.EditMask = "n2"
        Me.KeepMinSpinEdit.Name = "KeepMinSpinEdit"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'LocationDTLSearchLookUp1
        '
        Me.LocationDTLSearchLookUp1.AutoHeight = False
        Me.LocationDTLSearchLookUp1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LocationDTLSearchLookUp1.DisplayMember = "NameThai"
        Me.LocationDTLSearchLookUp1.Name = "LocationDTLSearchLookUp1"
        Me.LocationDTLSearchLookUp1.ValueMember = "ID"
        Me.LocationDTLSearchLookUp1.View = Me.RepositoryItemSearchLookUpEdit1View
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'LocationGrid
        '
        Me.LocationGrid.AutoHeight = False
        Me.LocationGrid.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LocationGrid.DisplayMember = "LocationDTL"
        Me.LocationGrid.Name = "LocationGrid"
        Me.LocationGrid.ValueMember = "LocationDTLID"
        Me.LocationGrid.View = Me.LocationDTLView
        '
        'LocationDTLView
        '
        Me.LocationDTLView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.LocationDTLView.Name = "LocationDTLView"
        Me.LocationDTLView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.LocationDTLView.OptionsView.ShowGroupPanel = False
        '
        'LocationIDComboBox
        '
        Me.LocationIDComboBox.AutoHeight = False
        Me.LocationIDComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LocationIDComboBox.Name = "LocationIDComboBox"
        '
        'LocationDTLLookUp
        '
        Me.LocationDTLLookUp.AutoHeight = False
        Me.LocationDTLLookUp.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LocationDTLLookUp.DisplayMember = "NameThai"
        Me.LocationDTLLookUp.Name = "LocationDTLLookUp"
        Me.LocationDTLLookUp.ValueMember = "ID"
        '
        'RepositoryItemPopupContainerEdit1
        '
        Me.RepositoryItemPopupContainerEdit1.AutoHeight = False
        Me.RepositoryItemPopupContainerEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemPopupContainerEdit1.Name = "RepositoryItemPopupContainerEdit1"
        '
        'LocationButtonEdit
        '
        Me.LocationButtonEdit.AutoHeight = False
        Me.LocationButtonEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.LocationButtonEdit.Name = "LocationButtonEdit"
        '
        'RepositoryItemRadioGroup1
        '
        Me.RepositoryItemRadioGroup1.Name = "RepositoryItemRadioGroup1"
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
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
        Me.ControlNavigator1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.ControlNavigator1.Location = New System.Drawing.Point(2, 359)
        Me.ControlNavigator1.Name = "ControlNavigator1"
        Me.ControlNavigator1.NavigatableControl = Me.gridControl
        Me.ControlNavigator1.Size = New System.Drawing.Size(250, 24)
        Me.ControlNavigator1.TabIndex = 10
        Me.ControlNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection1.Images.SetKeyName(0, "_active__no.png")
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelControl1.Location = New System.Drawing.Point(273, 361)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(373, 16)
        Me.LabelControl1.TabIndex = 11
        Me.LabelControl1.Text = "* กรณีเป็นคลังหลัก ให้ระบุ Y , คลังรองให้ใส่ตัวเลข 1,2,3,... ตามลำดับ"
        '
        'ucProductLocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.ControlNavigator1)
        Me.Controls.Add(Me.gridControl)
        Me.Name = "ucProductLocation"
        Me.Size = New System.Drawing.Size(828, 383)
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationIDLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationDTLIDLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KeepMinCalcEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KeepMaxCalcEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KeepMinSpinEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationDTLSearchLookUp1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationDTLView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationIDComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationDTLLookUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationButtonEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Private WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LocationDTLID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents LocationIDLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LocationDTLIDLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents KeepMin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KeepMinCalcEdit As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents KeepMax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KeepMaxCalcEdit As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents IsInActive As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents repositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Private WithEvents repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Private WithEvents repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents KeepMinSpinEdit As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SEQ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Private WithEvents bindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents LocationDTLSearchLookUp1 As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LocationGrid As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents LocationDTLView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LocationDTLLookUp As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LocationIDComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemPopupContainerEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents LocationButtonEdit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents LocationID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ControlNavigator1 As DevExpress.XtraEditors.ControlNavigator
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents RepositoryItemRadioGroup1 As DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
    Friend WithEvents IsMain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl

End Class
