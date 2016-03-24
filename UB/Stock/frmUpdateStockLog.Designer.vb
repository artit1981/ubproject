<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateStockLog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdateStockLog))
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.ProductCode = New DevExpress.XtraEditors.TextEdit()
        Me.ProductName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ProductBtn = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.PriceCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection1.Images.SetKeyName(0, "_active__no.png")
        Me.ImageCollection1.Images.SetKeyName(1, "1394817194_stock_insert-slide.png")
        '
        'ProductCode
        '
        Me.ProductCode.EditValue = ""
        Me.ProductCode.EnterMoveNextControl = True
        Me.ProductCode.Location = New System.Drawing.Point(95, 24)
        Me.ProductCode.Name = "ProductCode"
        Me.ProductCode.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.ProductCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ProductCode.Properties.Appearance.Options.UseBackColor = True
        Me.ProductCode.Properties.Appearance.Options.UseFont = True
        Me.ProductCode.Properties.MaxLength = 50
        Me.ProductCode.Properties.ReadOnly = True
        Me.ProductCode.Properties.ValidateOnEnterKey = True
        Me.ProductCode.Size = New System.Drawing.Size(116, 20)
        Me.ProductCode.TabIndex = 0
        '
        'ProductName
        '
        Me.ProductName.EditValue = ""
        Me.ProductName.EnterMoveNextControl = True
        Me.ProductName.Location = New System.Drawing.Point(217, 24)
        Me.ProductName.Name = "ProductName"
        Me.ProductName.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.ProductName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ProductName.Properties.Appearance.Options.UseBackColor = True
        Me.ProductName.Properties.Appearance.Options.UseFont = True
        Me.ProductName.Properties.MaxLength = 50
        Me.ProductName.Properties.ReadOnly = True
        Me.ProductName.Properties.ValidateOnEnterKey = True
        Me.ProductName.Size = New System.Drawing.Size(295, 20)
        Me.ProductName.TabIndex = 325
        Me.ProductName.TabStop = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(9, 28)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(27, 14)
        Me.LabelControl1.TabIndex = 326
        Me.LabelControl1.Text = "สินค้า"
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.Appearance.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.ProductCode)
        Me.GroupControl1.Controls.Add(Me.ProductName)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(624, 59)
        Me.GroupControl1.TabIndex = 333
        Me.GroupControl1.Text = " "
        '
        'gridControl
        '
        Me.gridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gridControl.EmbeddedNavigator.Buttons.Edit.ImageIndex = 0
        Me.gridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gridControl.Location = New System.Drawing.Point(12, 77)
        Me.gridControl.MainView = Me.gridView
        Me.gridControl.Name = "gridControl"
        Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ProductBtn, Me.PriceCalcEdit1})
        Me.gridControl.Size = New System.Drawing.Size(624, 346)
        Me.gridControl.TabIndex = 334
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView, Me.GridView1})
        '
        'gridView
        '
        Me.gridView.GridControl = Me.gridControl
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsBehavior.ReadOnly = True
        Me.gridView.OptionsFind.AlwaysVisible = True
        Me.gridView.OptionsLayout.Columns.AddNewColumns = False
        Me.gridView.OptionsLayout.Columns.RemoveOldColumns = False
        Me.gridView.OptionsMenu.EnableColumnMenu = False
        Me.gridView.OptionsMenu.EnableFooterMenu = False
        Me.gridView.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsNavigation.AutoFocusNewRow = True
        Me.gridView.OptionsNavigation.EnterMoveNextColumn = True
        Me.gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
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
        'GridView1
        '
        Me.GridView1.GridControl = Me.gridControl
        Me.GridView1.Name = "GridView1"
        '
        'frmUpdateStockLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 435)
        Me.Controls.Add(Me.gridControl)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmUpdateStockLog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SerialNumber"
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Private WithEvents ProductCode As DevExpress.XtraEditors.TextEdit
    Private WithEvents ProductName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Private WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Private WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ProductBtn As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents PriceCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
