<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotify
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotify))
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.GridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.IsClose = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.NotifyLevel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.System = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MenuDisplay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ValueDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Remark = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RefID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RefTable = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UserID = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection1.Images.SetKeyName(0, "Information.png")
        Me.ImageCollection1.Images.SetKeyName(1, "Warning.png")
        Me.ImageCollection1.Images.SetKeyName(2, "Errors.png")
        '
        'GridControl
        '
        Me.GridControl.Dock = DockStyle.Fill
        Me.GridControl.Location = New System.Drawing.Point(0, 0)
        Me.GridControl.MainView = Me.GridView
        Me.GridControl.Name = "GridControl"
        Me.GridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ImageComboBox1, Me.RepositoryItemCheckEdit1})
        Me.GridControl.Size = New System.Drawing.Size(754, 369)
        Me.GridControl.TabIndex = 2
        Me.GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
        '
        'GridView
        '
        Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.IsClose, Me.NotifyLevel, Me.System, Me.MenuDisplay, Me.ValueDate, Me.Remark, Me.RefID, Me.RefTable, Me.UserID})
        Me.GridView.GridControl = Me.GridControl
        Me.GridView.Name = "GridView"
        '
        'IsClose
        '
        Me.IsClose.AppearanceCell.Options.UseTextOptions = True
        Me.IsClose.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.IsClose.AppearanceHeader.Options.UseTextOptions = True
        Me.IsClose.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.IsClose.Caption = "ปิดแจ้งเตือน"
        Me.IsClose.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.IsClose.FieldName = "IsClose"
        Me.IsClose.Name = "IsClose"
        Me.IsClose.Visible = True
        Me.IsClose.VisibleIndex = 0
        Me.IsClose.Width = 70
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.ValueGrayed = False
        '
        'NotifyLevel
        '
        Me.NotifyLevel.AppearanceCell.Options.UseTextOptions = True
        Me.NotifyLevel.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NotifyLevel.ColumnEdit = Me.ImageComboBox1
        Me.NotifyLevel.FieldName = "NotifyLevel"
        Me.NotifyLevel.ImageAlignment = StringAlignment.Center
        Me.NotifyLevel.MaxWidth = 70
        Me.NotifyLevel.Name = "NotifyLevel"
        Me.NotifyLevel.OptionsColumn.ReadOnly = True
        Me.NotifyLevel.OptionsColumn.ShowCaption = False
        Me.NotifyLevel.Visible = True
        Me.NotifyLevel.VisibleIndex = 1
        Me.NotifyLevel.Width = 67
        '
        'ImageComboBox1
        '
        Me.ImageComboBox1.AutoHeight = False
        Me.ImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 1, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 2, 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 3, 2)})
        Me.ImageComboBox1.Name = "ImageComboBox1"
        Me.ImageComboBox1.ReadOnly = True
        Me.ImageComboBox1.SmallImages = Me.ImageCollection1
        '
        'System
        '
        Me.System.AppearanceHeader.Options.UseTextOptions = True
        Me.System.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.System.Caption = "ระบบ"
        Me.System.FieldName = "System"
        Me.System.MaxWidth = 150
        Me.System.MinWidth = 50
        Me.System.Name = "System"
        Me.System.Visible = True
        Me.System.VisibleIndex = 2
        Me.System.Width = 142
        '
        'MenuDisplay
        '
        Me.MenuDisplay.AppearanceHeader.Options.UseTextOptions = True
        Me.MenuDisplay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.MenuDisplay.Caption = "หน้าจอ"
        Me.MenuDisplay.FieldName = "MenuDisplay"
        Me.MenuDisplay.MaxWidth = 150
        Me.MenuDisplay.MinWidth = 50
        Me.MenuDisplay.Name = "MenuDisplay"
        Me.MenuDisplay.Visible = True
        Me.MenuDisplay.VisibleIndex = 3
        Me.MenuDisplay.Width = 142
        '
        'ValueDate
        '
        Me.ValueDate.AppearanceHeader.Options.UseTextOptions = True
        Me.ValueDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ValueDate.Caption = "วันที่"
        Me.ValueDate.FieldName = "ValueDate"
        Me.ValueDate.MaxWidth = 120
        Me.ValueDate.MinWidth = 50
        Me.ValueDate.Name = "ValueDate"
        Me.ValueDate.Visible = True
        Me.ValueDate.VisibleIndex = 4
        Me.ValueDate.Width = 114
        '
        'Remark
        '
        Me.Remark.AppearanceHeader.Options.UseTextOptions = True
        Me.Remark.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Remark.Caption = "ข้อความแจ้งเตือน"
        Me.Remark.FieldName = "Remark"
        Me.Remark.Name = "Remark"
        Me.Remark.Visible = True
        Me.Remark.VisibleIndex = 5
        Me.Remark.Width = 248
        '
        'RefID
        '
        Me.RefID.Caption = "RefID"
        Me.RefID.FieldName = "RefID"
        Me.RefID.Name = "RefID"
        '
        'RefTable
        '
        Me.RefTable.Caption = "RefTable"
        Me.RefTable.FieldName = "RefTable"
        Me.RefTable.Name = "RefTable"
        '
        'UserID
        '
        Me.UserID.Caption = "UserID"
        Me.UserID.FieldName = "UserID"
        Me.UserID.Name = "UserID"
        '
        'frmNotify
        '
        Me.ClientSize = New System.Drawing.Size(754, 369)
        Me.Controls.Add(Me.GridControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmNotify"
        Me.Text = "แจ้งเตือน"
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IsClose As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents NotifyLevel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents System As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuDisplay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ValueDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RefID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RefTable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UserID As DevExpress.XtraGrid.Columns.GridColumn
End Class
