<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucNote
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucNote))
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.repositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.ControlNavigator1 = New DevExpress.XtraEditors.ControlNavigator()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemLookUpEdit1, Me.repositoryItemCalcEdit1, Me.repositoryItemSpinEdit1, Me.repositoryItemTextEdit1})
        Me.gridControl.Size = New System.Drawing.Size(722, 385)
        Me.gridControl.TabIndex = 5
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7})
        Me.gridView.GridControl = Me.gridControl
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gridView.OptionsLayout.Columns.AddNewColumns = False
        Me.gridView.OptionsLayout.Columns.RemoveOldColumns = False
        Me.gridView.OptionsNavigation.AutoFocusNewRow = True
        Me.gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.gridView.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "ข้อความ"
        Me.GridColumn1.FieldName = "Description"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 451
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.BackColor = System.Drawing.SystemColors.Info
        Me.GridColumn2.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn2.Caption = "บันทึกล่าสุดโดย"
        Me.GridColumn2.FieldName = "CreateBy"
        Me.GridColumn2.MaxWidth = 100
        Me.GridColumn2.MinWidth = 50
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.TabStop = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 100
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.BackColor = System.Drawing.SystemColors.Info
        Me.GridColumn3.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn3.Caption = "บันทึกล่าสุดเมื่อ"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.GridColumn3.FieldName = "CreateTime"
        Me.GridColumn3.MaxWidth = 150
        Me.GridColumn3.MinWidth = 50
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.TabStop = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 150
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "GridColumn4"
        Me.GridColumn4.FieldName = "ID"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "GridColumn5"
        Me.GridColumn5.FieldName = "RefID"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "GridColumn6"
        Me.GridColumn6.FieldName = "RefTable"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "GridColumn7"
        Me.GridColumn7.FieldName = "DescriptionORG"
        Me.GridColumn7.Name = "GridColumn7"
        '
        'repositoryItemLookUpEdit1
        '
        Me.repositoryItemLookUpEdit1.AutoHeight = False
        Me.repositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductName", "Product Name")})
        Me.repositoryItemLookUpEdit1.DisplayMember = "ProductName"
        Me.repositoryItemLookUpEdit1.DropDownRows = 10
        Me.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1"
        Me.repositoryItemLookUpEdit1.PopupWidth = 220
        Me.repositoryItemLookUpEdit1.ValueMember = "ProductID"
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
        'ImageCollection1
        '
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection1.Images.SetKeyName(0, "_active__no.png")
        Me.ImageCollection1.Images.SetKeyName(1, "1394817194_stock_insert-slide.png")
        Me.ImageCollection1.Images.SetKeyName(2, "1432214789_Stock Index Up.png")
        Me.ImageCollection1.Images.SetKeyName(3, "1432214798_Stock Index Down.png")
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
        Me.ControlNavigator1.Location = New System.Drawing.Point(0, 386)
        Me.ControlNavigator1.Name = "ControlNavigator1"
        Me.ControlNavigator1.NavigatableControl = Me.gridControl
        Me.ControlNavigator1.Size = New System.Drawing.Size(261, 24)
        Me.ControlNavigator1.TabIndex = 13
        Me.ControlNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
        '
        'ucNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ControlNavigator1)
        Me.Controls.Add(Me.gridControl)
        Me.Name = "ucNote"
        Me.Size = New System.Drawing.Size(722, 410)
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Private WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents repositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Private WithEvents repositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Private WithEvents repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Private WithEvents repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents ControlNavigator1 As DevExpress.XtraEditors.ControlNavigator

End Class
