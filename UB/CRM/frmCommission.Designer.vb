<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCommission
    Inherits iEditForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCommission))
        Me.FormChangedComponent1 = New UB.FormChangedComponent(Me.components)
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.GeneralTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.ControlNavigator1 = New DevExpress.XtraEditors.ControlNavigator()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CommissionDtlID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CommissionID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SEQ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AmountFrom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AmountFromSpinEdit = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.AmountEnd = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AmountEndSpinEdit = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.ComPercen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ComPercenSpinEdit = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.ComAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ComAmountSpinEdit = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.IsChange = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IsDelete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CommissionType = New DevExpress.XtraEditors.RadioGroup()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ExpireDate = New DevExpress.XtraEditors.DateEdit()
        Me.StartDate = New DevExpress.XtraEditors.DateEdit()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Subject = New DevExpress.XtraEditors.TextEdit()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Remark = New DevExpress.XtraEditors.MemoEdit()
        Me.NoteTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcNote1 = New UB.ucNote()
        Me.AdminTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcAdmin1 = New UB.ucAdmin()
        Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.TerritoryID = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label20 = New System.Windows.Forms.Label()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.GeneralTabPage.SuspendLayout()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmountFromSpinEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmountEndSpinEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComPercenSpinEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComAmountSpinEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommissionType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpireDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpireDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Subject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Remark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NoteTabPage.SuspendLayout()
        Me.AdminTabPage.SuspendLayout()
        CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TerritoryID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormChangedComponent1
        '
        '
        'XtraTabControl1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.XtraTabControl1, "")
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.HeaderButtons = DevExpress.XtraTab.TabButtons.None
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 30)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.XtraTabControl1, True)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.GeneralTabPage
        Me.XtraTabControl1.Size = New System.Drawing.Size(858, 594)
        Me.XtraTabControl1.TabIndex = 5
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.GeneralTabPage, Me.NoteTabPage, Me.AdminTabPage})
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.XtraTabControl1, "")
        '
        'GeneralTabPage
        '
        Me.GeneralTabPage.Appearance.PageClient.BackColor = System.Drawing.Color.LightGray
        Me.GeneralTabPage.Appearance.PageClient.Options.UseBackColor = True
        Me.GeneralTabPage.AutoScroll = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.GeneralTabPage, "")
        Me.GeneralTabPage.Controls.Add(Me.TerritoryID)
        Me.GeneralTabPage.Controls.Add(Me.Label20)
        Me.GeneralTabPage.Controls.Add(Me.ControlNavigator1)
        Me.GeneralTabPage.Controls.Add(Me.gridControl)
        Me.GeneralTabPage.Controls.Add(Me.CommissionType)
        Me.GeneralTabPage.Controls.Add(Me.Label10)
        Me.GeneralTabPage.Controls.Add(Me.ExpireDate)
        Me.GeneralTabPage.Controls.Add(Me.StartDate)
        Me.GeneralTabPage.Controls.Add(Me.Label22)
        Me.GeneralTabPage.Controls.Add(Me.Subject)
        Me.GeneralTabPage.Controls.Add(Me.Label16)
        Me.GeneralTabPage.Controls.Add(Me.Label4)
        Me.GeneralTabPage.Controls.Add(Me.Label5)
        Me.GeneralTabPage.Controls.Add(Me.Remark)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.GeneralTabPage, True)
        Me.GeneralTabPage.Name = "GeneralTabPage"
        Me.GeneralTabPage.Size = New System.Drawing.Size(856, 569)
        Me.GeneralTabPage.Text = "ข้อมูลทั่วไป"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.GeneralTabPage, "")
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
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.ControlNavigator1, "")
        Me.ControlNavigator1.CustomButtons.AddRange(New DevExpress.XtraEditors.NavigatorCustomButton() {New DevExpress.XtraEditors.NavigatorCustomButton(6, 0, True, True, "Remove", "Remove"), New DevExpress.XtraEditors.NavigatorCustomButton(7, 1, True, False, "Insert", "Insert"), New DevExpress.XtraEditors.NavigatorCustomButton(-1, 2, True, True, "Move Up", "MoveUp"), New DevExpress.XtraEditors.NavigatorCustomButton(-1, 3, True, True, "Move Down", "MoveDown")})
        Me.ControlNavigator1.Location = New System.Drawing.Point(48, 534)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.ControlNavigator1, True)
        Me.ControlNavigator1.Name = "ControlNavigator1"
        Me.ControlNavigator1.NavigatableControl = Me.gridControl
        Me.ControlNavigator1.Size = New System.Drawing.Size(261, 24)
        Me.ControlNavigator1.TabIndex = 248
        Me.ControlNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.ControlNavigator1, "")
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection1.Images.SetKeyName(0, "_active__no.png")
        Me.ImageCollection1.Images.SetKeyName(1, "1394817194_stock_insert-slide.png")
        Me.ImageCollection1.Images.SetKeyName(2, "1432214789_Stock Index Up.png")
        Me.ImageCollection1.Images.SetKeyName(3, "1432214798_Stock Index Down.png")
        '
        'gridControl
        '
        Me.gridControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.gridControl, "")
        Me.gridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gridControl.EmbeddedNavigator.Buttons.Edit.ImageIndex = 0
        Me.gridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gridControl.Location = New System.Drawing.Point(48, 214)
        Me.gridControl.MainView = Me.gridView
        Me.FormChangedComponent1.SetMonitorForChanges(Me.gridControl, True)
        Me.gridControl.Name = "gridControl"
        Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.AmountFromSpinEdit, Me.AmountEndSpinEdit, Me.ComPercenSpinEdit, Me.ComAmountSpinEdit})
        Me.gridControl.Size = New System.Drawing.Size(721, 314)
        Me.gridControl.TabIndex = 247
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.gridControl, "")
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.gridView.Appearance.FooterPanel.Options.UseFont = True
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.CommissionDtlID, Me.CommissionID, Me.SEQ, Me.AmountFrom, Me.AmountEnd, Me.ComPercen, Me.ComAmount, Me.IsChange, Me.GridColumn2, Me.IsDelete})
        Me.gridView.GridControl = Me.gridControl
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsLayout.Columns.AddNewColumns = False
        Me.gridView.OptionsLayout.Columns.RemoveOldColumns = False
        Me.gridView.OptionsMenu.EnableFooterMenu = False
        Me.gridView.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsNavigation.AutoFocusNewRow = True
        Me.gridView.OptionsNavigation.EnterMoveNextColumn = True
        Me.gridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.gridView.OptionsView.ShowFooter = True
        Me.gridView.OptionsView.ShowGroupPanel = False
        '
        'CommissionDtlID
        '
        Me.CommissionDtlID.Caption = "ID"
        Me.CommissionDtlID.FieldName = "CommissionDtlID"
        Me.CommissionDtlID.Name = "CommissionDtlID"
        '
        'CommissionID
        '
        Me.CommissionID.Caption = "GridColumn3"
        Me.CommissionID.FieldName = "CommissionID"
        Me.CommissionID.Name = "CommissionID"
        '
        'SEQ
        '
        Me.SEQ.AppearanceCell.Options.UseTextOptions = True
        Me.SEQ.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SEQ.AppearanceHeader.Options.UseTextOptions = True
        Me.SEQ.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SEQ.Caption = "ลำดับ"
        Me.SEQ.DisplayFormat.FormatString = "n0"
        Me.SEQ.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SEQ.FieldName = "SEQ"
        Me.SEQ.Name = "SEQ"
        Me.SEQ.OptionsColumn.ReadOnly = True
        Me.SEQ.Visible = True
        Me.SEQ.VisibleIndex = 0
        '
        'AmountFrom
        '
        Me.AmountFrom.AppearanceHeader.Options.UseTextOptions = True
        Me.AmountFrom.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.AmountFrom.Caption = "ตั้งแต่"
        Me.AmountFrom.ColumnEdit = Me.AmountFromSpinEdit
        Me.AmountFrom.DisplayFormat.FormatString = "n2"
        Me.AmountFrom.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.AmountFrom.FieldName = "AmountFrom"
        Me.AmountFrom.MaxWidth = 200
        Me.AmountFrom.MinWidth = 200
        Me.AmountFrom.Name = "AmountFrom"
        Me.AmountFrom.Visible = True
        Me.AmountFrom.VisibleIndex = 1
        Me.AmountFrom.Width = 200
        '
        'AmountFromSpinEdit
        '
        Me.AmountFromSpinEdit.AutoHeight = False
        Me.AmountFromSpinEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AmountFromSpinEdit.DisplayFormat.FormatString = "n2"
        Me.AmountFromSpinEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.AmountFromSpinEdit.EditFormat.FormatString = "n2"
        Me.AmountFromSpinEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.AmountFromSpinEdit.Name = "AmountFromSpinEdit"
        '
        'AmountEnd
        '
        Me.AmountEnd.AppearanceHeader.Options.UseTextOptions = True
        Me.AmountEnd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.AmountEnd.Caption = "สิ้นสุด"
        Me.AmountEnd.ColumnEdit = Me.AmountEndSpinEdit
        Me.AmountEnd.DisplayFormat.FormatString = "n2"
        Me.AmountEnd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.AmountEnd.FieldName = "AmountEnd"
        Me.AmountEnd.MaxWidth = 200
        Me.AmountEnd.MinWidth = 200
        Me.AmountEnd.Name = "AmountEnd"
        Me.AmountEnd.Visible = True
        Me.AmountEnd.VisibleIndex = 2
        Me.AmountEnd.Width = 200
        '
        'AmountEndSpinEdit
        '
        Me.AmountEndSpinEdit.AutoHeight = False
        Me.AmountEndSpinEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AmountEndSpinEdit.DisplayFormat.FormatString = "n2"
        Me.AmountEndSpinEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.AmountEndSpinEdit.EditFormat.FormatString = "n2"
        Me.AmountEndSpinEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.AmountEndSpinEdit.Name = "AmountEndSpinEdit"
        '
        'ComPercen
        '
        Me.ComPercen.AppearanceHeader.Options.UseTextOptions = True
        Me.ComPercen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ComPercen.Caption = "อัตรา %"
        Me.ComPercen.ColumnEdit = Me.ComPercenSpinEdit
        Me.ComPercen.DisplayFormat.FormatString = "n2"
        Me.ComPercen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ComPercen.FieldName = "ComPercen"
        Me.ComPercen.MaxWidth = 150
        Me.ComPercen.MinWidth = 100
        Me.ComPercen.Name = "ComPercen"
        Me.ComPercen.Visible = True
        Me.ComPercen.VisibleIndex = 3
        Me.ComPercen.Width = 100
        '
        'ComPercenSpinEdit
        '
        Me.ComPercenSpinEdit.AutoHeight = False
        Me.ComPercenSpinEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComPercenSpinEdit.DisplayFormat.FormatString = "n2"
        Me.ComPercenSpinEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ComPercenSpinEdit.EditFormat.FormatString = "n2"
        Me.ComPercenSpinEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ComPercenSpinEdit.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ComPercenSpinEdit.Name = "ComPercenSpinEdit"
        '
        'ComAmount
        '
        Me.ComAmount.AppearanceHeader.Options.UseTextOptions = True
        Me.ComAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ComAmount.Caption = "อัตรา(บาท)"
        Me.ComAmount.ColumnEdit = Me.ComAmountSpinEdit
        Me.ComAmount.DisplayFormat.FormatString = "n2"
        Me.ComAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ComAmount.FieldName = "ComAmount"
        Me.ComAmount.MinWidth = 120
        Me.ComAmount.Name = "ComAmount"
        Me.ComAmount.Visible = True
        Me.ComAmount.VisibleIndex = 4
        Me.ComAmount.Width = 150
        '
        'ComAmountSpinEdit
        '
        Me.ComAmountSpinEdit.AutoHeight = False
        Me.ComAmountSpinEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComAmountSpinEdit.DisplayFormat.FormatString = "n2"
        Me.ComAmountSpinEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ComAmountSpinEdit.EditFormat.FormatString = "n2"
        Me.ComAmountSpinEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ComAmountSpinEdit.Name = "ComAmountSpinEdit"
        '
        'IsChange
        '
        Me.IsChange.Caption = "GridColumn1"
        Me.IsChange.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.IsChange.FieldName = "IsChange"
        Me.IsChange.Name = "IsChange"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "GridColumn1"
        Me.GridColumn2.FieldName = "ModeData"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'IsDelete
        '
        Me.IsDelete.Caption = "GridColumn2"
        Me.IsDelete.FieldName = "IsDelete"
        Me.IsDelete.Name = "IsDelete"
        '
        'CommissionType
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.CommissionType, "")
        Me.CommissionType.EditValue = 1
        Me.CommissionType.EnterMoveNextControl = True
        Me.CommissionType.Location = New System.Drawing.Point(183, 142)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.CommissionType, True)
        Me.CommissionType.Name = "CommissionType"
        Me.CommissionType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "%"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "จำนวน (บาท)")})
        Me.CommissionType.Size = New System.Drawing.Size(587, 30)
        Me.CommissionType.TabIndex = 246
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.CommissionType, "")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label10, "")
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(45, 149)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label10, True)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 14)
        Me.Label10.TabIndex = 233
        Me.Label10.Text = "การคิดคอมมิชชั่น"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label10, "")
        '
        'ExpireDate
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.ExpireDate, "TextChanged")
        Me.ExpireDate.EditValue = New Date(2012, 4, 20, 0, 0, 0, 0)
        Me.ExpireDate.EnterMoveNextControl = True
        Me.ExpireDate.Location = New System.Drawing.Point(557, 43)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.ExpireDate, True)
        Me.ExpireDate.Name = "ExpireDate"
        Me.ExpireDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.ExpireDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ExpireDate.Properties.Appearance.Options.UseFont = True
        Me.ExpireDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ExpireDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ExpireDate.Properties.DisplayFormat.FormatString = "D"
        Me.ExpireDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ExpireDate.Properties.EditFormat.FormatString = "D"
        Me.ExpireDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ExpireDate.Properties.Mask.EditMask = "D"
        Me.ExpireDate.Size = New System.Drawing.Size(212, 20)
        Me.ExpireDate.TabIndex = 7
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.ExpireDate, "Text")
        '
        'StartDate
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.StartDate, "TextChanged")
        Me.StartDate.EditValue = New Date(2012, 4, 20, 0, 0, 0, 0)
        Me.StartDate.EnterMoveNextControl = True
        Me.StartDate.Location = New System.Drawing.Point(183, 43)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.StartDate, True)
        Me.StartDate.Name = "StartDate"
        Me.StartDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.StartDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.StartDate.Properties.Appearance.Options.UseFont = True
        Me.StartDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StartDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.StartDate.Properties.DisplayFormat.FormatString = "D"
        Me.StartDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.StartDate.Properties.EditFormat.FormatString = "D"
        Me.StartDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.StartDate.Properties.Mask.EditMask = "D"
        Me.StartDate.Size = New System.Drawing.Size(212, 20)
        Me.StartDate.TabIndex = 5
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.StartDate, "Text")
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label22, "")
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label22.Location = New System.Drawing.Point(43, 46)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label22, True)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(59, 14)
        Me.Label22.TabIndex = 142
        Me.Label22.Text = "วันที่เริ่มต้น"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label22, "")
        '
        'Subject
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Subject, "TextChanged")
        Me.Subject.EditValue = ""
        Me.Subject.EnterMoveNextControl = True
        Me.Subject.Location = New System.Drawing.Point(183, 17)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Subject, True)
        Me.Subject.Name = "Subject"
        Me.Subject.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Subject.Properties.Appearance.Options.UseFont = True
        Me.Subject.Properties.MaxLength = 100
        Me.Subject.Properties.ValidateOnEnterKey = True
        Me.Subject.Size = New System.Drawing.Size(586, 20)
        Me.Subject.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Subject, "Text")
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label16, "")
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(472, 46)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label16, True)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(57, 14)
        Me.Label16.TabIndex = 113
        Me.Label16.Text = "วันที่สิ้นสุด"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label16, "")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label4, "")
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(43, 20)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label4, True)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 14)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "ชื่อคอมมิชชั่น"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label4, "")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label5, "")
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(43, 72)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label5, True)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 14)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "รายละเอียด"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label5, "")
        '
        'Remark
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Remark, "TextChanged")
        Me.Remark.EditValue = ""
        Me.Remark.EnterMoveNextControl = True
        Me.Remark.Location = New System.Drawing.Point(183, 69)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Remark, True)
        Me.Remark.Name = "Remark"
        Me.Remark.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Remark.Properties.Appearance.Options.UseFont = True
        Me.Remark.Properties.MaxLength = 100
        Me.Remark.Size = New System.Drawing.Size(587, 67)
        Me.Remark.TabIndex = 10
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Remark, "Text")
        '
        'NoteTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.NoteTabPage, "")
        Me.NoteTabPage.Controls.Add(Me.UcNote1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.NoteTabPage, True)
        Me.NoteTabPage.Name = "NoteTabPage"
        Me.NoteTabPage.Size = New System.Drawing.Size(856, 569)
        Me.NoteTabPage.Text = "บันทึกข้อความ"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.NoteTabPage, "")
        '
        'UcNote1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.UcNote1, "")
        Me.UcNote1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcNote1.Location = New System.Drawing.Point(0, 0)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.UcNote1, True)
        Me.UcNote1.Name = "UcNote1"
        Me.UcNote1.Size = New System.Drawing.Size(856, 569)
        Me.UcNote1.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcNote1, "")
        '
        'AdminTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.AdminTabPage, "")
        Me.AdminTabPage.Controls.Add(Me.UcAdmin1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.AdminTabPage, True)
        Me.AdminTabPage.Name = "AdminTabPage"
        Me.AdminTabPage.Size = New System.Drawing.Size(856, 569)
        Me.AdminTabPage.Text = "ผู้บันทึก"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.AdminTabPage, "")
        '
        'UcAdmin1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.UcAdmin1, "")
        Me.UcAdmin1.Location = New System.Drawing.Point(71, 0)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.UcAdmin1, True)
        Me.UcAdmin1.Name = "UcAdmin1"
        Me.UcAdmin1.Size = New System.Drawing.Size(665, 223)
        Me.UcAdmin1.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcAdmin1, "")
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'TerritoryID
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.TerritoryID, "TextChanged")
        Me.TerritoryID.EditValue = ""
        Me.TerritoryID.Location = New System.Drawing.Point(183, 178)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.TerritoryID, True)
        Me.TerritoryID.Name = "TerritoryID"
        Me.TerritoryID.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.TerritoryID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TerritoryID.Properties.Appearance.Options.UseFont = True
        Me.TerritoryID.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.TerritoryID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TerritoryID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 50, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TerritoryCode", "รหัสทีมขาย", 30, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NameThai", "ชื่อทีมขาย", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.TerritoryID.Properties.DropDownRows = 10
        Me.TerritoryID.Properties.NullText = ""
        Me.TerritoryID.Properties.PopupWidth = 300
        Me.TerritoryID.Size = New System.Drawing.Size(189, 20)
        Me.TerritoryID.TabIndex = 249
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.TerritoryID, "Text")
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label20, "")
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label20.Location = New System.Drawing.Point(45, 181)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label20, True)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(23, 14)
        Me.Label20.TabIndex = 250
        Me.Label20.Text = "ทีม"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label20, "")
        '
        'frmCommission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 624)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frmCommission"
        Me.Text = "frmCommission"
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.GeneralTabPage.ResumeLayout(False)
        Me.GeneralTabPage.PerformLayout()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmountFromSpinEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmountEndSpinEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComPercenSpinEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComAmountSpinEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommissionType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpireDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpireDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Subject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Remark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NoteTabPage.ResumeLayout(False)
        Me.AdminTabPage.ResumeLayout(False)
        CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TerritoryID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FormChangedComponent1 As FormChangedComponent

    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents GeneralTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Subject As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Remark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents NoteTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcNote1 As ucNote
    Friend WithEvents AdminTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcAdmin1 As ucAdmin
    Private WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CommissionType As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents ExpireDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents StartDate As DevExpress.XtraEditors.DateEdit
    Private WithEvents Label22 As Label
    Private WithEvents Label16 As Label
    Private WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Private WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CommissionDtlID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AmountFrom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AmountEnd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IsChange As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IsDelete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents ControlNavigator1 As DevExpress.XtraEditors.ControlNavigator
    Friend WithEvents SEQ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CommissionID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ComPercen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ComAmount As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents bindingSource1 As BindingSource
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents AmountFromSpinEdit As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents AmountEndSpinEdit As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents ComPercenSpinEdit As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents ComAmountSpinEdit As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Private WithEvents TerritoryID As DevExpress.XtraEditors.LookUpEdit
    Private WithEvents Label20 As Label
End Class
