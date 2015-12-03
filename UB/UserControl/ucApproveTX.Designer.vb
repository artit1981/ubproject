<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucApproveTX
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
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.OrderType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OrderCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OrderAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OrderBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Remark = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ApproveStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ApproveComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OrderID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OrderTable = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApproveComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridControl
        '
        Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gridControl.EmbeddedNavigator.Buttons.Edit.ImageIndex = 0
        Me.gridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gridControl.Location = New System.Drawing.Point(0, 0)
        Me.gridControl.MainView = Me.gridView
        Me.gridControl.Name = "gridControl"
        Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ApproveComboBox})
        Me.gridControl.Size = New System.Drawing.Size(1023, 457)
        Me.gridControl.TabIndex = 18
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ApproveStatus, Me.OrderType, Me.OrderCode, Me.OrderDate, Me.OrderAmount, Me.OrderBy, Me.Remark, Me.ID, Me.OrderID, Me.OrderTable})
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
        'OrderType
        '
        Me.OrderType.AppearanceCell.BackColor = System.Drawing.Color.LightYellow
        Me.OrderType.AppearanceCell.Options.UseBackColor = True
        Me.OrderType.AppearanceHeader.Options.UseTextOptions = True
        Me.OrderType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.OrderType.Caption = "ประเภทเอกสาร"
        Me.OrderType.FieldName = "OrderType"
        Me.OrderType.MaxWidth = 180
        Me.OrderType.MinWidth = 120
        Me.OrderType.Name = "OrderType"
        Me.OrderType.OptionsColumn.AllowEdit = False
        Me.OrderType.OptionsColumn.AllowFocus = False
        Me.OrderType.OptionsColumn.ReadOnly = True
        Me.OrderType.OptionsColumn.TabStop = False
        Me.OrderType.Visible = True
        Me.OrderType.VisibleIndex = 1
        Me.OrderType.Width = 166
        '
        'OrderCode
        '
        Me.OrderCode.AppearanceCell.BackColor = System.Drawing.Color.LightYellow
        Me.OrderCode.AppearanceCell.Options.UseBackColor = True
        Me.OrderCode.AppearanceHeader.Options.UseTextOptions = True
        Me.OrderCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.OrderCode.Caption = "เลขที่เอกสาร"
        Me.OrderCode.FieldName = "OrderCode"
        Me.OrderCode.MaxWidth = 180
        Me.OrderCode.MinWidth = 120
        Me.OrderCode.Name = "OrderCode"
        Me.OrderCode.OptionsColumn.AllowEdit = False
        Me.OrderCode.OptionsColumn.AllowFocus = False
        Me.OrderCode.OptionsColumn.ReadOnly = True
        Me.OrderCode.OptionsColumn.TabStop = False
        Me.OrderCode.Visible = True
        Me.OrderCode.VisibleIndex = 2
        Me.OrderCode.Width = 166
        '
        'OrderDate
        '
        Me.OrderDate.AppearanceCell.BackColor = System.Drawing.Color.LightYellow
        Me.OrderDate.AppearanceCell.Options.UseBackColor = True
        Me.OrderDate.AppearanceHeader.Options.UseTextOptions = True
        Me.OrderDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.OrderDate.Caption = "วันที่เอกสาร"
        Me.OrderDate.FieldName = "OrderDate"
        Me.OrderDate.MaxWidth = 120
        Me.OrderDate.MinWidth = 100
        Me.OrderDate.Name = "OrderDate"
        Me.OrderDate.OptionsColumn.AllowEdit = False
        Me.OrderDate.OptionsColumn.AllowFocus = False
        Me.OrderDate.OptionsColumn.TabStop = False
        Me.OrderDate.Visible = True
        Me.OrderDate.VisibleIndex = 3
        Me.OrderDate.Width = 120
        '
        'OrderAmount
        '
        Me.OrderAmount.AppearanceCell.BackColor = System.Drawing.Color.LightYellow
        Me.OrderAmount.AppearanceCell.Options.UseBackColor = True
        Me.OrderAmount.AppearanceCell.Options.UseTextOptions = True
        Me.OrderAmount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.OrderAmount.AppearanceHeader.Options.UseTextOptions = True
        Me.OrderAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.OrderAmount.Caption = "ยอดรวม"
        Me.OrderAmount.DisplayFormat.FormatString = "n2"
        Me.OrderAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.OrderAmount.FieldName = "OrderAmount"
        Me.OrderAmount.MaxWidth = 140
        Me.OrderAmount.MinWidth = 100
        Me.OrderAmount.Name = "OrderAmount"
        Me.OrderAmount.OptionsColumn.AllowEdit = False
        Me.OrderAmount.OptionsColumn.ReadOnly = True
        Me.OrderAmount.OptionsColumn.TabStop = False
        Me.OrderAmount.Visible = True
        Me.OrderAmount.VisibleIndex = 4
        Me.OrderAmount.Width = 138
        '
        'OrderBy
        '
        Me.OrderBy.AppearanceCell.BackColor = System.Drawing.Color.LightYellow
        Me.OrderBy.AppearanceCell.Options.UseBackColor = True
        Me.OrderBy.AppearanceHeader.Options.UseTextOptions = True
        Me.OrderBy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.OrderBy.Caption = "ผู้ทำรายการ"
        Me.OrderBy.FieldName = "OrderBy"
        Me.OrderBy.MinWidth = 120
        Me.OrderBy.Name = "OrderBy"
        Me.OrderBy.OptionsColumn.AllowEdit = False
        Me.OrderBy.OptionsColumn.ReadOnly = True
        Me.OrderBy.Width = 120
        '
        'Remark
        '
        Me.Remark.AppearanceCell.BackColor = System.Drawing.Color.LightYellow
        Me.Remark.AppearanceCell.Options.UseBackColor = True
        Me.Remark.AppearanceHeader.Options.UseTextOptions = True
        Me.Remark.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Remark.Caption = "หมายเหตุ"
        Me.Remark.FieldName = "Remark"
        Me.Remark.MinWidth = 100
        Me.Remark.Name = "Remark"
        Me.Remark.OptionsColumn.AllowEdit = False
        Me.Remark.OptionsColumn.ReadOnly = True
        Me.Remark.OptionsColumn.TabStop = False
        Me.Remark.Visible = True
        Me.Remark.VisibleIndex = 5
        Me.Remark.Width = 212
        '
        'ApproveStatus
        '
        Me.ApproveStatus.AppearanceHeader.Options.UseTextOptions = True
        Me.ApproveStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ApproveStatus.Caption = "สถานะอนุมัติ"
        Me.ApproveStatus.ColumnEdit = Me.ApproveComboBox
        Me.ApproveStatus.FieldName = "ApproveStatus"
        Me.ApproveStatus.MaxWidth = 130
        Me.ApproveStatus.MinWidth = 120
        Me.ApproveStatus.Name = "ApproveStatus"
        Me.ApproveStatus.ToolTip = "อนุมัติรายการ"
        Me.ApproveStatus.Visible = True
        Me.ApproveStatus.VisibleIndex = 0
        Me.ApproveStatus.Width = 120
        '
        'ApproveComboBox
        '
        Me.ApproveComboBox.AutoHeight = False
        Me.ApproveComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ApproveComboBox.Items.AddRange(New Object() {"Wait Approve", "Approve", "Not Approve"})
        Me.ApproveComboBox.Name = "ApproveComboBox"
        '
        'ID
        '
        Me.ID.Caption = "ID"
        Me.ID.FieldName = "ID"
        Me.ID.Name = "ID"
        '
        'OrderID
        '
        Me.OrderID.Caption = "ApproveUserDtlID"
        Me.OrderID.FieldName = "OrderID"
        Me.OrderID.Name = "OrderID"
        '
        'OrderTable
        '
        Me.OrderTable.Caption = "GridColumn1"
        Me.OrderTable.FieldName = "OrderTable"
        Me.OrderTable.Name = "OrderTable"
        '
        'ucApproveTX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gridControl)
        Me.Name = "ucApproveTX"
        Me.Size = New System.Drawing.Size(1023, 457)
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApproveComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Private WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OrderType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OrderCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OrderDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OrderAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ApproveStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OrderID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OrderBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ApproveComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents OrderTable As DevExpress.XtraGrid.Columns.GridColumn

End Class
