<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucProductUnit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucProductUnit))
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UnitCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UnitBtn = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.UnitName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Rate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RateSpinEdit = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.Remark = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SEQ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IsInActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.UnitID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.ControlNavigator1 = New DevExpress.XtraEditors.ControlNavigator()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RateSpinEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RateSpinEdit, Me.RepositoryItemCheckEdit1, Me.UnitBtn})
        Me.gridControl.Size = New System.Drawing.Size(793, 372)
        Me.gridControl.TabIndex = 8
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ID, Me.UnitCode, Me.UnitName, Me.Rate, Me.Remark, Me.SEQ, Me.IsInActive, Me.UnitID})
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
        'UnitCode
        '
        Me.UnitCode.Caption = "รหัสหน่วยนับ"
        Me.UnitCode.ColumnEdit = Me.UnitBtn
        Me.UnitCode.FieldName = "UnitCode"
        Me.UnitCode.MaxWidth = 100
        Me.UnitCode.MinWidth = 100
        Me.UnitCode.Name = "UnitCode"
        Me.UnitCode.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowOnlyInEditor
        Me.UnitCode.Visible = True
        Me.UnitCode.VisibleIndex = 0
        Me.UnitCode.Width = 100
        '
        'UnitBtn
        '
        Me.UnitBtn.AutoHeight = False
        Me.UnitBtn.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.UnitBtn.Name = "UnitBtn"
        '
        'UnitName
        '
        Me.UnitName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UnitName.AppearanceCell.Options.UseBackColor = True
        Me.UnitName.Caption = "ชื่อหน่วยนับ"
        Me.UnitName.FieldName = "UnitName"
        Me.UnitName.MaxWidth = 250
        Me.UnitName.MinWidth = 200
        Me.UnitName.Name = "UnitName"
        Me.UnitName.OptionsColumn.AllowEdit = False
        Me.UnitName.OptionsColumn.AllowFocus = False
        Me.UnitName.OptionsColumn.ReadOnly = True
        Me.UnitName.OptionsColumn.TabStop = False
        Me.UnitName.Visible = True
        Me.UnitName.VisibleIndex = 1
        Me.UnitName.Width = 200
        '
        'Rate
        '
        Me.Rate.Caption = "อัตราส่วน"
        Me.Rate.ColumnEdit = Me.RateSpinEdit
        Me.Rate.DisplayFormat.FormatString = "n0"
        Me.Rate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Rate.FieldName = "Rate"
        Me.Rate.MaxWidth = 150
        Me.Rate.MinWidth = 100
        Me.Rate.Name = "Rate"
        Me.Rate.Visible = True
        Me.Rate.VisibleIndex = 2
        Me.Rate.Width = 101
        '
        'RateSpinEdit
        '
        Me.RateSpinEdit.AutoHeight = False
        Me.RateSpinEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RateSpinEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RateSpinEdit.Mask.EditMask = "n0"
        Me.RateSpinEdit.Name = "RateSpinEdit"
        '
        'Remark
        '
        Me.Remark.Caption = "รายละเอียด"
        Me.Remark.FieldName = "Remark"
        Me.Remark.MinWidth = 10
        Me.Remark.Name = "Remark"
        Me.Remark.Visible = True
        Me.Remark.VisibleIndex = 3
        Me.Remark.Width = 300
        '
        'SEQ
        '
        Me.SEQ.Caption = "SEQ"
        Me.SEQ.FieldName = "SEQ"
        Me.SEQ.Name = "SEQ"
        '
        'IsInActive
        '
        Me.IsInActive.Caption = "ระงับการใช้งาน"
        Me.IsInActive.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.IsInActive.FieldName = "IsInActive"
        Me.IsInActive.MaxWidth = 100
        Me.IsInActive.MinWidth = 100
        Me.IsInActive.Name = "IsInActive"
        Me.IsInActive.OptionsColumn.TabStop = False
        Me.IsInActive.Visible = True
        Me.IsInActive.VisibleIndex = 4
        Me.IsInActive.Width = 100
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'UnitID
        '
        Me.UnitID.Caption = "GridColumn2"
        Me.UnitID.FieldName = "UnitID"
        Me.UnitID.Name = "UnitID"
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
        Me.ControlNavigator1.Location = New System.Drawing.Point(0, 372)
        Me.ControlNavigator1.Name = "ControlNavigator1"
        Me.ControlNavigator1.NavigatableControl = Me.gridControl
        Me.ControlNavigator1.Size = New System.Drawing.Size(250, 24)
        Me.ControlNavigator1.TabIndex = 11
        Me.ControlNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
        '
        'ucProductUnit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ControlNavigator1)
        Me.Controls.Add(Me.gridControl)
        Me.Name = "ucProductUnit"
        Me.Size = New System.Drawing.Size(793, 396)
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RateSpinEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Private WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UnitCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Rate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RateSpinEdit As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IsInActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents SEQ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Private WithEvents bindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents UnitBtn As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents UnitName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UnitID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents ControlNavigator1 As DevExpress.XtraEditors.ControlNavigator

End Class
