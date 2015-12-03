<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucOrderList
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.GridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.IsSelect = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IsSelectCheckEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.เลขที่ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.เลขที่เอกสาร = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnOrderCode = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrandTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BillTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.Remark = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BillType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OrderID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TableID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.ControlNavigator1 = New DevExpress.XtraEditors.ControlNavigator()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsSelectCheckEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnOrderCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl
        '
        Me.GridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl.Location = New System.Drawing.Point(0, 0)
        Me.GridControl.MainView = Me.GridView
        Me.GridControl.Name = "GridControl"
        Me.GridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.IsSelectCheckEdit, Me.RepositoryItemCalcEdit1, Me.btnOrderCode})
        Me.GridControl.Size = New System.Drawing.Size(814, 388)
        Me.GridControl.TabIndex = 19
        Me.GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
        '
        'GridView
        '
        Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.IsSelect, Me.เลขที่, Me.เลขที่เอกสาร, Me.GridColumn2, Me.GridColumn3, Me.GridColumn8, Me.GrandTotal, Me.BillTotal, Me.Remark, Me.BillType, Me.OrderID, Me.TableID})
        Me.GridView.GridControl = Me.GridControl
        Me.GridView.Name = "GridView"
        Me.GridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView.OptionsLayout.Columns.AddNewColumns = False
        Me.GridView.OptionsLayout.Columns.RemoveOldColumns = False
        Me.GridView.OptionsMenu.EnableColumnMenu = False
        Me.GridView.OptionsMenu.EnableFooterMenu = False
        Me.GridView.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView.OptionsMenu.ShowGroupSortSummaryItems = False
        Me.GridView.OptionsMenu.ShowGroupSummaryEditorItem = True
        Me.GridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView.OptionsView.ShowFooter = True
        Me.GridView.OptionsView.ShowGroupPanel = False
        Me.GridView.OptionsView.ShowViewCaption = True
        '
        'IsSelect
        '
        Me.IsSelect.AppearanceHeader.Options.UseTextOptions = True
        Me.IsSelect.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.IsSelect.Caption = "เลือก"
        Me.IsSelect.ColumnEdit = Me.IsSelectCheckEdit
        Me.IsSelect.FieldName = "IsSelect"
        Me.IsSelect.MaxWidth = 70
        Me.IsSelect.MinWidth = 50
        Me.IsSelect.Name = "IsSelect"
        Me.IsSelect.ToolTip = "เลือกข้อมูล"
        Me.IsSelect.Visible = True
        Me.IsSelect.VisibleIndex = 0
        Me.IsSelect.Width = 50
        '
        'IsSelectCheckEdit
        '
        Me.IsSelectCheckEdit.AutoHeight = False
        Me.IsSelectCheckEdit.Name = "IsSelectCheckEdit"
        '
        'เลขที่
        '
        Me.เลขที่.Caption = "เลขที่เอกสาร"
        Me.เลขที่.FieldName = "ID"
        Me.เลขที่.MaxWidth = 150
        Me.เลขที่.MinWidth = 80
        Me.เลขที่.Name = "เลขที่"
        Me.เลขที่.Width = 100
        '
        'เลขที่เอกสาร
        '
        Me.เลขที่เอกสาร.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.เลขที่เอกสาร.AppearanceCell.Options.UseBackColor = True
        Me.เลขที่เอกสาร.AppearanceHeader.Options.UseTextOptions = True
        Me.เลขที่เอกสาร.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.เลขที่เอกสาร.Caption = "เลขที่เอกสาร"
        Me.เลขที่เอกสาร.ColumnEdit = Me.btnOrderCode
        Me.เลขที่เอกสาร.FieldName = "OrderCode"
        Me.เลขที่เอกสาร.MaxWidth = 150
        Me.เลขที่เอกสาร.MinWidth = 100
        Me.เลขที่เอกสาร.Name = "เลขที่เอกสาร"
        Me.เลขที่เอกสาร.Visible = True
        Me.เลขที่เอกสาร.VisibleIndex = 1
        Me.เลขที่เอกสาร.Width = 100
        '
        'btnOrderCode
        '
        Me.btnOrderCode.AutoHeight = False
        Me.btnOrderCode.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.btnOrderCode.Name = "btnOrderCode"
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.GridColumn2.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "วันที่เอกสาร"
        Me.GridColumn2.DisplayFormat.FormatString = "d"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn2.FieldName = "OrderDate"
        Me.GridColumn2.MaxWidth = 130
        Me.GridColumn2.MinWidth = 90
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 100
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn3.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "ลูกค้า"
        Me.GridColumn3.FieldName = "CusName"
        Me.GridColumn3.MaxWidth = 250
        Me.GridColumn3.MinWidth = 200
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Width = 200
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn8.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn8.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn8.Caption = "พนักงาน"
        Me.GridColumn8.FieldName = "EmpName"
        Me.GridColumn8.MaxWidth = 220
        Me.GridColumn8.MinWidth = 100
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 3
        Me.GridColumn8.Width = 200
        '
        'GrandTotal
        '
        Me.GrandTotal.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GrandTotal.AppearanceCell.Options.UseBackColor = True
        Me.GrandTotal.AppearanceCell.Options.UseTextOptions = True
        Me.GrandTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GrandTotal.AppearanceHeader.Options.UseTextOptions = True
        Me.GrandTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GrandTotal.Caption = "ยอดรวม"
        Me.GrandTotal.DisplayFormat.FormatString = "n2"
        Me.GrandTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GrandTotal.FieldName = "GrandTotal"
        Me.GrandTotal.MaxWidth = 150
        Me.GrandTotal.MinWidth = 100
        Me.GrandTotal.Name = "GrandTotal"
        Me.GrandTotal.OptionsColumn.ReadOnly = True
        Me.GrandTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GrandTotal", "{0:n2}")})
        Me.GrandTotal.Visible = True
        Me.GrandTotal.VisibleIndex = 4
        Me.GrandTotal.Width = 100
        '
        'BillTotal
        '
        Me.BillTotal.AppearanceCell.Options.UseTextOptions = True
        Me.BillTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.BillTotal.AppearanceHeader.Options.UseTextOptions = True
        Me.BillTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BillTotal.Caption = "ยอดวางบิล"
        Me.BillTotal.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.BillTotal.DisplayFormat.FormatString = "n2"
        Me.BillTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BillTotal.FieldName = "BillTotal"
        Me.BillTotal.MaxWidth = 150
        Me.BillTotal.MinWidth = 100
        Me.BillTotal.Name = "BillTotal"
        Me.BillTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BillTotal", "{0:n2}")})
        Me.BillTotal.Visible = True
        Me.BillTotal.VisibleIndex = 5
        Me.BillTotal.Width = 100
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.DisplayFormat.FormatString = "n2"
        Me.RepositoryItemCalcEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemCalcEdit1.EditFormat.FormatString = "n2"
        Me.RepositoryItemCalcEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'Remark
        '
        Me.Remark.Caption = "รายละเอียด"
        Me.Remark.FieldName = "Remark"
        Me.Remark.MaxWidth = 200
        Me.Remark.MinWidth = 100
        Me.Remark.Name = "Remark"
        Me.Remark.Visible = True
        Me.Remark.VisibleIndex = 6
        Me.Remark.Width = 100
        '
        'BillType
        '
        Me.BillType.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BillType.AppearanceCell.Options.UseBackColor = True
        Me.BillType.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.BillType.AppearanceHeader.Options.UseBackColor = True
        Me.BillType.AppearanceHeader.Options.UseTextOptions = True
        Me.BillType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BillType.Caption = "ประเภทเอกสาร"
        Me.BillType.FieldName = "BillType"
        Me.BillType.MaxWidth = 150
        Me.BillType.MinWidth = 100
        Me.BillType.Name = "BillType"
        Me.BillType.OptionsColumn.ReadOnly = True
        Me.BillType.Visible = True
        Me.BillType.VisibleIndex = 7
        Me.BillType.Width = 100
        '
        'OrderID
        '
        Me.OrderID.Caption = "GridColumn5"
        Me.OrderID.FieldName = "OrderID"
        Me.OrderID.Name = "OrderID"
        '
        'TableID
        '
        Me.TableID.Caption = "GridColumn5"
        Me.TableID.FieldName = "TableID"
        Me.TableID.Name = "TableID"
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
        Me.ControlNavigator1.Buttons.Remove.Hint = "ลบข้อมูล"
        Me.ControlNavigator1.Buttons.Remove.ImageIndex = 0
        Me.ControlNavigator1.Buttons.Remove.Tag = " ลบข้อมูล"
        Me.ControlNavigator1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.ControlNavigator1.Location = New System.Drawing.Point(0, 388)
        Me.ControlNavigator1.Name = "ControlNavigator1"
        Me.ControlNavigator1.NavigatableControl = Me.GridControl
        Me.ControlNavigator1.Size = New System.Drawing.Size(250, 24)
        Me.ControlNavigator1.TabIndex = 20
        Me.ControlNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
        '
        'ucOrderList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ControlNavigator1)
        Me.Controls.Add(Me.GridControl)
        Me.Name = "ucOrderList"
        Me.Size = New System.Drawing.Size(814, 412)
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsSelectCheckEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnOrderCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
    Private WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IsSelect As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IsSelectCheckEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents เลขที่ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents เลขที่เอกสาร As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GrandTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents ControlNavigator1 As DevExpress.XtraEditors.ControlNavigator
    Friend WithEvents BillTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BillType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OrderID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TableID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnOrderCode As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit

End Class
