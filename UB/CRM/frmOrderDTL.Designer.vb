<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderDTL
    Inherits UB.iEditForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ProductID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IsSelect = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProductCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProductName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.PriceStandard = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Price1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Price2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Price3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Unit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PriceInform = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PriceCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.Discount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DiscountCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.DiscountOld = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PriceInformOld = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.InformPriceID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Image = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnImage = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ProductBtn = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiscountCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.gridControl)
        Me.PanelControl1.Location = New System.Drawing.Point(21, 58)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(601, 269)
        Me.PanelControl1.TabIndex = 0
        '
        'gridControl
        '
        Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gridControl.EmbeddedNavigator.Buttons.Edit.ImageIndex = 0
        Me.gridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gridControl.Location = New System.Drawing.Point(2, 2)
        Me.gridControl.MainView = Me.gridView
        Me.gridControl.Name = "gridControl"
        Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ProductBtn, Me.PriceCalcEdit1, Me.DiscountCalcEdit1, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemMemoEdit1, Me.btnImage})
        Me.gridControl.Size = New System.Drawing.Size(597, 265)
        Me.gridControl.TabIndex = 291
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ProductID, Me.IsSelect, Me.ProductCode, Me.ProductName, Me.PriceStandard, Me.Price1, Me.Price2, Me.Price3, Me.Unit, Me.PriceInform, Me.Discount, Me.DiscountOld, Me.PriceInformOld, Me.InformPriceID, Me.Image})
        Me.gridView.GridControl = Me.gridControl
        Me.gridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", Me.Price1, "")})
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
        Me.gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.gridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gridView.OptionsView.ShowGroupPanel = False
        '
        'ProductID
        '
        Me.ProductID.Caption = "GridColumn1"
        Me.ProductID.FieldName = "ProductID"
        Me.ProductID.Name = "ProductID"
        Me.ProductID.OptionsColumn.TabStop = False
        '
        'IsSelect
        '
        Me.IsSelect.AppearanceCell.Options.UseTextOptions = True
        Me.IsSelect.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.IsSelect.AppearanceHeader.Options.UseTextOptions = True
        Me.IsSelect.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.IsSelect.Caption = "เลือก"
        Me.IsSelect.FieldName = "IsSelect"
        Me.IsSelect.MaxWidth = 50
        Me.IsSelect.Name = "IsSelect"
        Me.IsSelect.UnboundType = DevExpress.Data.UnboundColumnType.[Boolean]
        Me.IsSelect.Width = 50
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
        Me.ProductCode.Width = 80
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
        Me.ProductName.MaxWidth = 250
        Me.ProductName.MinWidth = 200
        Me.ProductName.Name = "ProductName"
        Me.ProductName.OptionsColumn.ReadOnly = True
        Me.ProductName.OptionsColumn.TabStop = False
        Me.ProductName.Visible = True
        Me.ProductName.VisibleIndex = 1
        Me.ProductName.Width = 200
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'PriceStandard
        '
        Me.PriceStandard.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PriceStandard.AppearanceCell.Options.UseBackColor = True
        Me.PriceStandard.AppearanceCell.Options.UseTextOptions = True
        Me.PriceStandard.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.PriceStandard.AppearanceHeader.Options.UseTextOptions = True
        Me.PriceStandard.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PriceStandard.Caption = "ราคามาตรฐาน"
        Me.PriceStandard.DisplayFormat.FormatString = "n2"
        Me.PriceStandard.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PriceStandard.FieldName = "PriceStandard"
        Me.PriceStandard.MaxWidth = 150
        Me.PriceStandard.MinWidth = 100
        Me.PriceStandard.Name = "PriceStandard"
        Me.PriceStandard.OptionsColumn.ReadOnly = True
        Me.PriceStandard.OptionsColumn.TabStop = False
        Me.PriceStandard.Visible = True
        Me.PriceStandard.VisibleIndex = 2
        Me.PriceStandard.Width = 100
        '
        'Price1
        '
        Me.Price1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Price1.AppearanceCell.Options.UseBackColor = True
        Me.Price1.AppearanceCell.Options.UseTextOptions = True
        Me.Price1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Price1.AppearanceHeader.Options.UseTextOptions = True
        Me.Price1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Price1.Caption = "ราคา 1"
        Me.Price1.DisplayFormat.FormatString = "n2"
        Me.Price1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Price1.FieldName = "Price1"
        Me.Price1.MaxWidth = 150
        Me.Price1.MinWidth = 100
        Me.Price1.Name = "Price1"
        Me.Price1.OptionsColumn.AllowEdit = False
        Me.Price1.OptionsColumn.ReadOnly = True
        Me.Price1.OptionsColumn.TabStop = False
        Me.Price1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:#,##0 .00; ( #,##0.00 ); """"""""}")})
        Me.Price1.Visible = True
        Me.Price1.VisibleIndex = 3
        Me.Price1.Width = 100
        '
        'Price2
        '
        Me.Price2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Price2.AppearanceCell.Options.UseBackColor = True
        Me.Price2.AppearanceCell.Options.UseTextOptions = True
        Me.Price2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Price2.AppearanceHeader.Options.UseTextOptions = True
        Me.Price2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Price2.Caption = "ราคา 2"
        Me.Price2.DisplayFormat.FormatString = "n2"
        Me.Price2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Price2.FieldName = "Price2"
        Me.Price2.MaxWidth = 150
        Me.Price2.MinWidth = 100
        Me.Price2.Name = "Price2"
        Me.Price2.OptionsColumn.ReadOnly = True
        Me.Price2.OptionsColumn.TabStop = False
        Me.Price2.Visible = True
        Me.Price2.VisibleIndex = 4
        Me.Price2.Width = 100
        '
        'Price3
        '
        Me.Price3.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Price3.AppearanceCell.Options.UseBackColor = True
        Me.Price3.AppearanceCell.Options.UseTextOptions = True
        Me.Price3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Price3.AppearanceHeader.Options.UseTextOptions = True
        Me.Price3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Price3.Caption = "ราคา 3"
        Me.Price3.DisplayFormat.FormatString = "n2"
        Me.Price3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Price3.FieldName = "Price3"
        Me.Price3.MaxWidth = 150
        Me.Price3.MinWidth = 100
        Me.Price3.Name = "Price3"
        Me.Price3.OptionsColumn.ReadOnly = True
        Me.Price3.OptionsColumn.TabStop = False
        Me.Price3.Visible = True
        Me.Price3.VisibleIndex = 5
        Me.Price3.Width = 100
        '
        'Unit
        '
        Me.Unit.AppearanceCell.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Unit.AppearanceCell.Options.UseBackColor = True
        Me.Unit.AppearanceCell.Options.UseTextOptions = True
        Me.Unit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Unit.AppearanceHeader.Options.UseTextOptions = True
        Me.Unit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Unit.Caption = "ยอดคงเหลือ"
        Me.Unit.DisplayFormat.FormatString = "n0"
        Me.Unit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Unit.FieldName = "Unit"
        Me.Unit.MaxWidth = 150
        Me.Unit.MinWidth = 100
        Me.Unit.Name = "Unit"
        Me.Unit.OptionsColumn.TabStop = False
        Me.Unit.Visible = True
        Me.Unit.VisibleIndex = 6
        Me.Unit.Width = 100
        '
        'PriceInform
        '
        Me.PriceInform.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.PriceInform.AppearanceCell.Options.UseBackColor = True
        Me.PriceInform.AppearanceCell.Options.UseTextOptions = True
        Me.PriceInform.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.PriceInform.AppearanceHeader.Options.UseTextOptions = True
        Me.PriceInform.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PriceInform.Caption = "ราคาแจ้ง"
        Me.PriceInform.ColumnEdit = Me.PriceCalcEdit1
        Me.PriceInform.DisplayFormat.FormatString = "n2"
        Me.PriceInform.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PriceInform.FieldName = "PriceInform"
        Me.PriceInform.MaxWidth = 150
        Me.PriceInform.MinWidth = 100
        Me.PriceInform.Name = "PriceInform"
        Me.PriceInform.Visible = True
        Me.PriceInform.VisibleIndex = 7
        Me.PriceInform.Width = 100
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
        Me.Discount.AppearanceCell.Options.UseTextOptions = True
        Me.Discount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Discount.AppearanceHeader.Options.UseTextOptions = True
        Me.Discount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Discount.Caption = "ส่วนลด"
        Me.Discount.ColumnEdit = Me.DiscountCalcEdit1
        Me.Discount.DisplayFormat.FormatString = "n2"
        Me.Discount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Discount.FieldName = "Discount"
        Me.Discount.MaxWidth = 150
        Me.Discount.MinWidth = 100
        Me.Discount.Name = "Discount"
        Me.Discount.Visible = True
        Me.Discount.VisibleIndex = 8
        Me.Discount.Width = 100
        '
        'DiscountCalcEdit1
        '
        Me.DiscountCalcEdit1.AutoHeight = False
        Me.DiscountCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DiscountCalcEdit1.Name = "DiscountCalcEdit1"
        '
        'DiscountOld
        '
        Me.DiscountOld.Caption = "DiscountOld"
        Me.DiscountOld.FieldName = "DiscountOld"
        Me.DiscountOld.Name = "DiscountOld"
        '
        'PriceInformOld
        '
        Me.PriceInformOld.Caption = "PriceInformOld"
        Me.PriceInformOld.FieldName = "PriceInformOld"
        Me.PriceInformOld.Name = "PriceInformOld"
        '
        'InformPriceID
        '
        Me.InformPriceID.Caption = "InformPriceID"
        Me.InformPriceID.FieldName = "InformPriceID"
        Me.InformPriceID.Name = "InformPriceID"
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
        Me.Image.VisibleIndex = 9
        Me.Image.Width = 38
        '
        'btnImage
        '
        Me.btnImage.AutoHeight = False
        Me.btnImage.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.btnImage.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.btnImage.Name = "btnImage"
        Me.btnImage.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ProductBtn
        '
        Me.ProductBtn.AutoHeight = False
        Me.ProductBtn.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ProductBtn.Name = "ProductBtn"
        Me.ProductBtn.ValidateOnEnterKey = True
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        '
        'frmOrderDTL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 396)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmOrderDTL"
        Me.Text = "frmOrderDTL"
        Me.Controls.SetChildIndex(Me.PanelControl1, 0)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiscountCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Private WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Private WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ProductID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IsSelect As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProductCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProductName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents PriceStandard As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Price1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Price2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Price3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PriceInform As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PriceCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents Discount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DiscountCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents DiscountOld As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PriceInformOld As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents InformPriceID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Image As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnImage As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ProductBtn As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
End Class
