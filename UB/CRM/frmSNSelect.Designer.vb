<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSNSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSNSelect))
        Me.OrderID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SerialNumberID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProductID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SerialNumberNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.Units = New DevExpress.XtraEditors.SpinEdit()
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.ProductCode = New DevExpress.XtraEditors.TextEdit()
        Me.ProductName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Units.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OrderID
        '
        Me.OrderID.Caption = "GridColumn1"
        Me.OrderID.FieldName = "OrderID"
        Me.OrderID.Name = "OrderID"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.SerialNumberID, Me.OrderID, Me.ProductID, Me.SerialNumberNo, Me.Status})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsHint.ShowColumnHeaderHints = False
        Me.GridView1.OptionsHint.ShowFooterHints = False
        Me.GridView1.OptionsMenu.EnableColumnMenu = False
        Me.GridView1.OptionsMenu.EnableFooterMenu = False
        Me.GridView1.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = " "
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GridColumn1.FieldName = "IsSelect"
        Me.GridColumn1.MaxWidth = 50
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 50
        '
        'SerialNumberID
        '
        Me.SerialNumberID.Caption = "GridColumn1"
        Me.SerialNumberID.FieldName = "SerialNumberID"
        Me.SerialNumberID.Name = "SerialNumberID"
        '
        'ProductID
        '
        Me.ProductID.Caption = "GridColumn1"
        Me.ProductID.FieldName = "ProductID"
        Me.ProductID.Name = "ProductID"
        '
        'SerialNumberNo
        '
        Me.SerialNumberNo.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.SerialNumberNo.AppearanceCell.Options.UseBackColor = True
        Me.SerialNumberNo.AppearanceHeader.Options.UseTextOptions = True
        Me.SerialNumberNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SerialNumberNo.Caption = "Serial Number"
        Me.SerialNumberNo.FieldName = "SerialNumberNo"
        Me.SerialNumberNo.MinWidth = 200
        Me.SerialNumberNo.Name = "SerialNumberNo"
        Me.SerialNumberNo.Visible = True
        Me.SerialNumberNo.VisibleIndex = 1
        Me.SerialNumberNo.Width = 200
        '
        'Status
        '
        Me.Status.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Status.AppearanceCell.Options.UseBackColor = True
        Me.Status.AppearanceCell.Options.UseTextOptions = True
        Me.Status.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Status.AppearanceHeader.Options.UseTextOptions = True
        Me.Status.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Status.Caption = "Status"
        Me.Status.FieldName = "Status"
        Me.Status.MaxWidth = 100
        Me.Status.MinWidth = 50
        Me.Status.Name = "Status"
        Me.Status.OptionsColumn.ReadOnly = True
        Me.Status.Visible = True
        Me.Status.VisibleIndex = 2
        Me.Status.Width = 100
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(3, 88)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(633, 335)
        Me.GridControl1.TabIndex = 319
        Me.GridControl1.TabStop = False
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection1.Images.SetKeyName(0, "_active__no.png")
        Me.ImageCollection1.Images.SetKeyName(1, "1394817194_stock_insert-slide.png")
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(25, 57)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl2.TabIndex = 327
        Me.LabelControl2.Text = "จำนวน"
        '
        'Units
        '
        Me.Units.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Units.Location = New System.Drawing.Point(86, 53)
        Me.Units.Name = "Units"
        Me.Units.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.Units.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Units.Properties.Appearance.Options.UseBackColor = True
        Me.Units.Properties.Appearance.Options.UseFont = True
        Me.Units.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Units.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.Units.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Units.Properties.MaxLength = 50
        Me.Units.Properties.ReadOnly = True
        Me.Units.Properties.ValidateOnEnterKey = True
        Me.Units.Size = New System.Drawing.Size(125, 20)
        Me.Units.TabIndex = 328
        Me.Units.TabStop = False
        '
        'btnOK
        '
        Me.btnOK.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnOK.Appearance.Options.UseFont = True
        Me.btnOK.Appearance.Options.UseImage = True
        Me.btnOK.Image = CType(resources.GetObject("btnOK.Image"), System.Drawing.Image)
        Me.btnOK.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnOK.Location = New System.Drawing.Point(554, 12)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(82, 31)
        Me.btnOK.TabIndex = 6
        Me.btnOK.Text = "ตกลง"
        Me.btnOK.ToolTip = "ตกลง"
        '
        'btnCancel
        '
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.Appearance.Options.UseImage = True
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnCancel.Location = New System.Drawing.Point(554, 51)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(82, 31)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "ยกเลิก"
        Me.btnCancel.ToolTip = "ยกเลิก"
        '
        'ProductCode
        '
        Me.ProductCode.EditValue = ""
        Me.ProductCode.EnterMoveNextControl = True
        Me.ProductCode.Location = New System.Drawing.Point(86, 25)
        Me.ProductCode.Name = "ProductCode"
        Me.ProductCode.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.ProductCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ProductCode.Properties.Appearance.Options.UseBackColor = True
        Me.ProductCode.Properties.Appearance.Options.UseFont = True
        Me.ProductCode.Properties.MaxLength = 50
        Me.ProductCode.Properties.ReadOnly = True
        Me.ProductCode.Properties.ValidateOnEnterKey = True
        Me.ProductCode.Size = New System.Drawing.Size(125, 20)
        Me.ProductCode.TabIndex = 0
        '
        'ProductName
        '
        Me.ProductName.EditValue = ""
        Me.ProductName.EnterMoveNextControl = True
        Me.ProductName.Location = New System.Drawing.Point(250, 26)
        Me.ProductName.Name = "ProductName"
        Me.ProductName.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.ProductName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ProductName.Properties.Appearance.Options.UseBackColor = True
        Me.ProductName.Properties.Appearance.Options.UseFont = True
        Me.ProductName.Properties.MaxLength = 50
        Me.ProductName.Properties.ReadOnly = True
        Me.ProductName.Properties.ValidateOnEnterKey = True
        Me.ProductName.Size = New System.Drawing.Size(272, 20)
        Me.ProductName.TabIndex = 325
        Me.ProductName.TabStop = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(25, 29)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl1.TabIndex = 326
        Me.LabelControl1.Text = "สินค้า"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'frmSNSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(648, 435)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.ProductName)
        Me.Controls.Add(Me.ProductCode)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.Units)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSNSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SerialNumber"
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Units.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OrderID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SerialNumberNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SerialNumberID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProductID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Units As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Private WithEvents ProductCode As DevExpress.XtraEditors.TextEdit
    Private WithEvents ProductName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
