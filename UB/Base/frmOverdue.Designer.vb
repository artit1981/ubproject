<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOverdue
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOverdue))
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.GridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.MenuDisplay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OrderCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PayTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ExpireDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl.Location = New System.Drawing.Point(0, 0)
        Me.GridControl.MainView = Me.GridView
        Me.GridControl.Name = "GridControl"
        Me.GridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ImageComboBox1, Me.RepositoryItemCheckEdit1})
        Me.GridControl.Size = New System.Drawing.Size(1086, 540)
        Me.GridControl.TabIndex = 2
        Me.GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
        '
        'GridView
        '
        Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MenuDisplay, Me.OrderCode, Me.GridColumn1, Me.PayTotal, Me.ExpireDate, Me.GridColumn2})
        Me.GridView.GridControl = Me.GridControl
        Me.GridView.Name = "GridView"
        Me.GridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView.OptionsBehavior.ReadOnly = True
        Me.GridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        '
        'MenuDisplay
        '
        Me.MenuDisplay.AppearanceHeader.Options.UseTextOptions = True
        Me.MenuDisplay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.MenuDisplay.Caption = "หน้าจอ"
        Me.MenuDisplay.FieldName = "MenuDisplay"
        Me.MenuDisplay.MaxWidth = 250
        Me.MenuDisplay.MinWidth = 50
        Me.MenuDisplay.Name = "MenuDisplay"
        Me.MenuDisplay.Visible = True
        Me.MenuDisplay.VisibleIndex = 0
        Me.MenuDisplay.Width = 246
        '
        'OrderCode
        '
        Me.OrderCode.AppearanceHeader.Options.UseTextOptions = True
        Me.OrderCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.OrderCode.Caption = "เลขที่"
        Me.OrderCode.FieldName = "OrderCode"
        Me.OrderCode.MaxWidth = 250
        Me.OrderCode.MinWidth = 100
        Me.OrderCode.Name = "OrderCode"
        Me.OrderCode.Visible = True
        Me.OrderCode.VisibleIndex = 1
        Me.OrderCode.Width = 246
        '
        'PayTotal
        '
        Me.PayTotal.AppearanceCell.Options.UseTextOptions = True
        Me.PayTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.PayTotal.AppearanceHeader.Options.UseTextOptions = True
        Me.PayTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PayTotal.Caption = "ยอดรวม"
        Me.PayTotal.DisplayFormat.FormatString = "n2"
        Me.PayTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PayTotal.FieldName = "PayTotal"
        Me.PayTotal.MaxWidth = 150
        Me.PayTotal.MinWidth = 100
        Me.PayTotal.Name = "PayTotal"
        Me.PayTotal.Visible = True
        Me.PayTotal.VisibleIndex = 3
        Me.PayTotal.Width = 148
        '
        'ExpireDate
        '
        Me.ExpireDate.AppearanceCell.Options.UseTextOptions = True
        Me.ExpireDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ExpireDate.AppearanceHeader.Options.UseTextOptions = True
        Me.ExpireDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ExpireDate.Caption = "Due Date"
        Me.ExpireDate.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.ExpireDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ExpireDate.FieldName = "ExpireDate"
        Me.ExpireDate.MaxWidth = 200
        Me.ExpireDate.MinWidth = 100
        Me.ExpireDate.Name = "ExpireDate"
        Me.ExpireDate.Visible = True
        Me.ExpireDate.VisibleIndex = 4
        Me.ExpireDate.Width = 197
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
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.ValueGrayed = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "ลูกค้า"
        Me.GridColumn1.FieldName = "Customer"
        Me.GridColumn1.MaxWidth = 500
        Me.GridColumn1.MinWidth = 150
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        Me.GridColumn1.Width = 150
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "ผู้รับผิดชอบ"
        Me.GridColumn2.FieldName = "EMPNAME"
        Me.GridColumn2.MaxWidth = 500
        Me.GridColumn2.MinWidth = 120
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 5
        Me.GridColumn2.Width = 150
        '
        'frmOverdue
        '
        Me.ClientSize = New System.Drawing.Size(1086, 540)
        Me.Controls.Add(Me.GridControl)
        Me.KeyPreview = True
        Me.Name = "frmOverdue"
        Me.Text = "แจ้งเตือน"
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents OrderCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuDisplay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ExpireDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PayTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
End Class
