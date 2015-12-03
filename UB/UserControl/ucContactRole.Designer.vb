<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucContactRole
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucContactRole))
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ContactName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NameBtn = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.Email1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Phone1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Fax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ContactRole = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ContactRoleComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.SEQ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ContactID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RateSpinEdit = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.UnitBtn = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemMarqueeProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ContactRoleLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.NameLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ControlNavigator1 = New DevExpress.XtraEditors.ControlNavigator()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NameBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactRoleComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RateSpinEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMarqueeProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactRoleLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NameLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection1.Images.SetKeyName(0, "_active__no.png")
        '
        'gridControl
        '
        Me.gridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gridControl.EmbeddedNavigator.Buttons.Edit.ImageIndex = 0
        Me.gridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gridControl.Location = New System.Drawing.Point(1, 1)
        Me.gridControl.MainView = Me.gridView
        Me.gridControl.Name = "gridControl"
        Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RateSpinEdit, Me.RepositoryItemCheckEdit1, Me.UnitBtn, Me.RepositoryItemMarqueeProgressBar1, Me.RepositoryItemLookUpEdit1, Me.ContactRoleLookUpEdit, Me.NameLookUpEdit, Me.NameBtn, Me.ContactRoleComboBox})
        Me.gridControl.Size = New System.Drawing.Size(822, 383)
        Me.gridControl.TabIndex = 9
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ID, Me.ContactName, Me.Email1, Me.Phone1, Me.Fax, Me.ContactRole, Me.SEQ, Me.ContactID})
        Me.gridView.GridControl = Me.gridControl
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gridView.OptionsLayout.Columns.AddNewColumns = False
        Me.gridView.OptionsLayout.Columns.RemoveOldColumns = False
        Me.gridView.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsNavigation.AutoFocusNewRow = True
        Me.gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.gridView.OptionsView.ShowGroupPanel = False
        '
        'ID
        '
        Me.ID.Caption = "ID"
        Me.ID.FieldName = "ID"
        Me.ID.Name = "ID"
        '
        'ContactName
        '
        Me.ContactName.AppearanceHeader.Options.UseTextOptions = True
        Me.ContactName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ContactName.Caption = "ผู้ติดต่อ"
        Me.ContactName.ColumnEdit = Me.NameBtn
        Me.ContactName.FieldName = "ContactName"
        Me.ContactName.MaxWidth = 250
        Me.ContactName.MinWidth = 200
        Me.ContactName.Name = "ContactName"
        Me.ContactName.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowOnlyInEditor
        Me.ContactName.Visible = True
        Me.ContactName.VisibleIndex = 0
        Me.ContactName.Width = 250
        '
        'NameBtn
        '
        Me.NameBtn.AutoHeight = False
        Me.NameBtn.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.NameBtn.Name = "NameBtn"
        '
        'Email1
        '
        Me.Email1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Email1.AppearanceCell.Options.UseBackColor = True
        Me.Email1.AppearanceHeader.Options.UseTextOptions = True
        Me.Email1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Email1.Caption = "อีเมล์"
        Me.Email1.FieldName = "Email1"
        Me.Email1.MaxWidth = 150
        Me.Email1.MinWidth = 100
        Me.Email1.Name = "Email1"
        Me.Email1.OptionsColumn.AllowEdit = False
        Me.Email1.OptionsColumn.AllowFocus = False
        Me.Email1.OptionsColumn.ReadOnly = True
        Me.Email1.OptionsColumn.TabStop = False
        Me.Email1.Visible = True
        Me.Email1.VisibleIndex = 1
        Me.Email1.Width = 150
        '
        'Phone1
        '
        Me.Phone1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Phone1.AppearanceCell.Options.UseBackColor = True
        Me.Phone1.AppearanceHeader.Options.UseTextOptions = True
        Me.Phone1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Phone1.Caption = "โทรศัพท์"
        Me.Phone1.FieldName = "Phone1"
        Me.Phone1.MaxWidth = 150
        Me.Phone1.MinWidth = 50
        Me.Phone1.Name = "Phone1"
        Me.Phone1.OptionsColumn.AllowEdit = False
        Me.Phone1.OptionsColumn.AllowFocus = False
        Me.Phone1.OptionsColumn.TabStop = False
        Me.Phone1.Visible = True
        Me.Phone1.VisibleIndex = 2
        Me.Phone1.Width = 100
        '
        'Fax
        '
        Me.Fax.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fax.AppearanceCell.Options.UseBackColor = True
        Me.Fax.AppearanceHeader.Options.UseTextOptions = True
        Me.Fax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Fax.Caption = "โทรสาร"
        Me.Fax.FieldName = "Fax"
        Me.Fax.MaxWidth = 150
        Me.Fax.MinWidth = 50
        Me.Fax.Name = "Fax"
        Me.Fax.OptionsColumn.AllowEdit = False
        Me.Fax.OptionsColumn.AllowFocus = False
        Me.Fax.OptionsColumn.TabStop = False
        Me.Fax.Visible = True
        Me.Fax.VisibleIndex = 3
        Me.Fax.Width = 100
        '
        'ContactRole
        '
        Me.ContactRole.AppearanceHeader.Options.UseTextOptions = True
        Me.ContactRole.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ContactRole.Caption = "บทบาทหน้าที่"
        Me.ContactRole.ColumnEdit = Me.ContactRoleComboBox
        Me.ContactRole.FieldName = "ContactRole"
        Me.ContactRole.MaxWidth = 200
        Me.ContactRole.MinWidth = 100
        Me.ContactRole.Name = "ContactRole"
        Me.ContactRole.Visible = True
        Me.ContactRole.VisibleIndex = 4
        Me.ContactRole.Width = 100
        '
        'ContactRoleComboBox
        '
        Me.ContactRoleComboBox.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.ContactRoleComboBox.AutoHeight = False
        Me.ContactRoleComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ContactRoleComboBox.ImmediatePopup = True
        Me.ContactRoleComboBox.Name = "ContactRoleComboBox"
        Me.ContactRoleComboBox.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ContactRoleComboBox.ValidateOnEnterKey = True
        '
        'SEQ
        '
        Me.SEQ.Caption = "SEQ"
        Me.SEQ.FieldName = "SEQ"
        Me.SEQ.Name = "SEQ"
        '
        'ContactID
        '
        Me.ContactID.Caption = "ContactID"
        Me.ContactID.FieldName = "ContactID"
        Me.ContactID.Name = "ContactID"
        '
        'RateSpinEdit
        '
        Me.RateSpinEdit.AutoHeight = False
        Me.RateSpinEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RateSpinEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RateSpinEdit.Mask.EditMask = "n0"
        Me.RateSpinEdit.Name = "RateSpinEdit"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'UnitBtn
        '
        Me.UnitBtn.AutoHeight = False
        Me.UnitBtn.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.UnitBtn.Name = "UnitBtn"
        '
        'RepositoryItemMarqueeProgressBar1
        '
        Me.RepositoryItemMarqueeProgressBar1.Name = "RepositoryItemMarqueeProgressBar1"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'ContactRoleLookUpEdit
        '
        Me.ContactRoleLookUpEdit.AutoHeight = False
        Me.ContactRoleLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ContactRoleLookUpEdit.Name = "ContactRoleLookUpEdit"
        '
        'NameLookUpEdit
        '
        Me.NameLookUpEdit.AutoHeight = False
        Me.NameLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.NameLookUpEdit.Name = "NameLookUpEdit"
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
        Me.ControlNavigator1.Location = New System.Drawing.Point(1, 384)
        Me.ControlNavigator1.Name = "ControlNavigator1"
        Me.ControlNavigator1.NavigatableControl = Me.gridControl
        Me.ControlNavigator1.Size = New System.Drawing.Size(250, 24)
        Me.ControlNavigator1.TabIndex = 12
        Me.ControlNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
        '
        'ucContactRole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ControlNavigator1)
        Me.Controls.Add(Me.gridControl)
        Me.Name = "ucContactRole"
        Me.Size = New System.Drawing.Size(823, 409)
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NameBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactRoleComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RateSpinEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMarqueeProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactRoleLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NameLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Private WithEvents bindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Private WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Private WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ContactName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UnitBtn As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents Email1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RateSpinEdit As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents SEQ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ControlNavigator1 As DevExpress.XtraEditors.ControlNavigator
    Friend WithEvents Phone1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Fax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemMarqueeProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar
    Friend WithEvents ContactRole As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ContactRoleLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents NameLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents NameBtn As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ContactID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ContactRoleComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox

End Class
