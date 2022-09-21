<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBankAccountRec
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
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.GeneralTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SEQ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BankAccountID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BankAccountIDLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.LocationDTLIDLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.Debit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DebitCalcEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.Credit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CreditCalcEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.repositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.KeepMinSpinEdit = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.LocationDTLSearchLookUp1 = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.LocationGrid = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.LocationDTLView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LocationIDComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.LocationDTLLookUp = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemPopupContainerEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
        Me.LocationButtonEdit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemRadioGroup1 = New DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RecordDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RecordDateDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.Remark = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.GeneralTabPage.SuspendLayout()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankAccountIDLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationDTLIDLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DebitCalcEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditCalcEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KeepMinSpinEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationDTLSearchLookUp1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationDTLView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationIDComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationDTLLookUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationButtonEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordDateDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordDateDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 30)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.GeneralTabPage
        Me.XtraTabControl1.Size = New System.Drawing.Size(911, 411)
        Me.XtraTabControl1.TabIndex = 15
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.GeneralTabPage})
        '
        'GeneralTabPage
        '
        Me.GeneralTabPage.Appearance.PageClient.BackColor = System.Drawing.Color.LightGray
        Me.GeneralTabPage.Appearance.PageClient.Options.UseBackColor = True
        Me.GeneralTabPage.AutoScroll = True
        Me.GeneralTabPage.Controls.Add(Me.gridControl)
        Me.GeneralTabPage.Name = "GeneralTabPage"
        Me.GeneralTabPage.Size = New System.Drawing.Size(909, 386)
        Me.GeneralTabPage.Text = "อนุมัติเอกสาร"
        '
        'gridControl
        '
        Me.gridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gridControl.EmbeddedNavigator.Buttons.Edit.ImageIndex = 0
        Me.gridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gridControl.Location = New System.Drawing.Point(11, 3)
        Me.gridControl.MainView = Me.gridView
        Me.gridControl.Name = "gridControl"
        Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.BankAccountIDLookUpEdit, Me.repositoryItemCalcEdit1, Me.repositoryItemSpinEdit1, Me.repositoryItemTextEdit1, Me.KeepMinSpinEdit, Me.LocationDTLIDLookUpEdit1, Me.DebitCalcEdit, Me.CreditCalcEdit, Me.RepositoryItemCheckEdit1, Me.LocationDTLSearchLookUp1, Me.RepositoryItemLookUpEdit1, Me.LocationGrid, Me.LocationIDComboBox, Me.LocationDTLLookUp, Me.RepositoryItemPopupContainerEdit1, Me.LocationButtonEdit, Me.RepositoryItemRadioGroup1, Me.RepositoryItemCheckEdit2, Me.RecordDateDateEdit1, Me.RepositoryItemTextEdit2})
        Me.gridControl.Size = New System.Drawing.Size(828, 359)
        Me.gridControl.TabIndex = 10
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ID, Me.SEQ, Me.RecordDate, Me.BankAccountID, Me.Remark, Me.Debit, Me.Credit})
        Me.gridView.GridControl = Me.gridControl
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gridView.OptionsLayout.Columns.AddNewColumns = False
        Me.gridView.OptionsLayout.Columns.RemoveOldColumns = False
        Me.gridView.OptionsNavigation.AutoFocusNewRow = True
        Me.gridView.OptionsNavigation.EnterMoveNextColumn = True
        Me.gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.gridView.OptionsView.ShowGroupPanel = False
        '
        'ID
        '
        Me.ID.Caption = "ID"
        Me.ID.FieldName = "ID"
        Me.ID.Name = "ID"
        '
        'SEQ
        '
        Me.SEQ.Caption = "SEQ"
        Me.SEQ.FieldName = "SEQ"
        Me.SEQ.Name = "SEQ"
        '
        'BankAccountID
        '
        Me.BankAccountID.Caption = "บัญชี"
        Me.BankAccountID.ColumnEdit = Me.BankAccountIDLookUpEdit
        Me.BankAccountID.FieldName = "BankAccountID"
        Me.BankAccountID.MaxWidth = 200
        Me.BankAccountID.MinWidth = 100
        Me.BankAccountID.Name = "BankAccountID"
        Me.BankAccountID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals
        Me.BankAccountID.Visible = True
        Me.BankAccountID.VisibleIndex = 0
        Me.BankAccountID.Width = 100
        '
        'BankAccountIDLookUpEdit
        '
        Me.BankAccountIDLookUpEdit.AutoHeight = False
        Me.BankAccountIDLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BankAccountIDLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo(" ID", " ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACCNAME", "บัญชี", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BankName", "ธนาคาร")})
        Me.BankAccountIDLookUpEdit.DisplayMember = "ACCNAME"
        Me.BankAccountIDLookUpEdit.DropDownRows = 10
        Me.BankAccountIDLookUpEdit.Name = "BankAccountIDLookUpEdit"
        Me.BankAccountIDLookUpEdit.NullText = ""
        Me.BankAccountIDLookUpEdit.PopupWidth = 220
        Me.BankAccountIDLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BankAccountIDLookUpEdit.ValueMember = "ID"
        '
        'LocationDTLIDLookUpEdit1
        '
        Me.LocationDTLIDLookUpEdit1.AutoHeight = False
        Me.LocationDTLIDLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LocationDTLIDLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationID", "คลังสินค้า", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationDTL", "ตำแหน่ง"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationDTLID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.LocationDTLIDLookUpEdit1.DisplayMember = "LocationDTL"
        Me.LocationDTLIDLookUpEdit1.Name = "LocationDTLIDLookUpEdit1"
        Me.LocationDTLIDLookUpEdit1.NullText = ""
        Me.LocationDTLIDLookUpEdit1.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.LocationDTLIDLookUpEdit1.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.LocationDTLIDLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LocationDTLIDLookUpEdit1.ValueMember = "LocationDTLID"
        '
        'Debit
        '
        Me.Debit.AppearanceHeader.Options.UseTextOptions = True
        Me.Debit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Debit.Caption = "เดบิท"
        Me.Debit.ColumnEdit = Me.DebitCalcEdit
        Me.Debit.DisplayFormat.FormatString = "n2"
        Me.Debit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Debit.FieldName = "Debit"
        Me.Debit.MaxWidth = 200
        Me.Debit.MinWidth = 100
        Me.Debit.Name = "Debit"
        Me.Debit.Visible = True
        Me.Debit.VisibleIndex = 2
        Me.Debit.Width = 158
        '
        'DebitCalcEdit
        '
        Me.DebitCalcEdit.AutoHeight = False
        Me.DebitCalcEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DebitCalcEdit.Name = "DebitCalcEdit"
        '
        'Credit
        '
        Me.Credit.AppearanceHeader.Options.UseTextOptions = True
        Me.Credit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Credit.Caption = "เครดิต"
        Me.Credit.ColumnEdit = Me.CreditCalcEdit
        Me.Credit.DisplayFormat.FormatString = "Numeric ""n2"""
        Me.Credit.FieldName = "Credit"
        Me.Credit.MaxWidth = 200
        Me.Credit.MinWidth = 100
        Me.Credit.Name = "Credit"
        Me.Credit.Visible = True
        Me.Credit.VisibleIndex = 3
        Me.Credit.Width = 150
        '
        'CreditCalcEdit
        '
        Me.CreditCalcEdit.AutoHeight = False
        Me.CreditCalcEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CreditCalcEdit.Name = "CreditCalcEdit"
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
        'KeepMinSpinEdit
        '
        Me.KeepMinSpinEdit.AutoHeight = False
        Me.KeepMinSpinEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.KeepMinSpinEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.KeepMinSpinEdit.Mask.EditMask = "n2"
        Me.KeepMinSpinEdit.Name = "KeepMinSpinEdit"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'LocationDTLSearchLookUp1
        '
        Me.LocationDTLSearchLookUp1.AutoHeight = False
        Me.LocationDTLSearchLookUp1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LocationDTLSearchLookUp1.DisplayMember = "NameThai"
        Me.LocationDTLSearchLookUp1.Name = "LocationDTLSearchLookUp1"
        Me.LocationDTLSearchLookUp1.PopupView = Me.RepositoryItemSearchLookUpEdit1View
        Me.LocationDTLSearchLookUp1.ValueMember = "ID"
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'LocationGrid
        '
        Me.LocationGrid.AutoHeight = False
        Me.LocationGrid.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LocationGrid.DisplayMember = "LocationDTL"
        Me.LocationGrid.Name = "LocationGrid"
        Me.LocationGrid.PopupView = Me.LocationDTLView
        Me.LocationGrid.ValueMember = "LocationDTLID"
        '
        'LocationDTLView
        '
        Me.LocationDTLView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.LocationDTLView.Name = "LocationDTLView"
        Me.LocationDTLView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.LocationDTLView.OptionsView.ShowGroupPanel = False
        '
        'LocationIDComboBox
        '
        Me.LocationIDComboBox.AutoHeight = False
        Me.LocationIDComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LocationIDComboBox.Name = "LocationIDComboBox"
        '
        'LocationDTLLookUp
        '
        Me.LocationDTLLookUp.AutoHeight = False
        Me.LocationDTLLookUp.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LocationDTLLookUp.DisplayMember = "NameThai"
        Me.LocationDTLLookUp.Name = "LocationDTLLookUp"
        Me.LocationDTLLookUp.ValueMember = "ID"
        '
        'RepositoryItemPopupContainerEdit1
        '
        Me.RepositoryItemPopupContainerEdit1.AutoHeight = False
        Me.RepositoryItemPopupContainerEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemPopupContainerEdit1.Name = "RepositoryItemPopupContainerEdit1"
        '
        'LocationButtonEdit
        '
        Me.LocationButtonEdit.AutoHeight = False
        Me.LocationButtonEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.LocationButtonEdit.Name = "LocationButtonEdit"
        '
        'RepositoryItemRadioGroup1
        '
        Me.RepositoryItemRadioGroup1.Name = "RepositoryItemRadioGroup1"
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'RecordDate
        '
        Me.RecordDate.Caption = "วันที่"
        Me.RecordDate.ColumnEdit = Me.RecordDateDateEdit1
        Me.RecordDate.FieldName = "RecordDate"
        Me.RecordDate.Name = "RecordDate"
        Me.RecordDate.Visible = True
        Me.RecordDate.VisibleIndex = 1
        '
        'RecordDateDateEdit1
        '
        Me.RecordDateDateEdit1.AutoHeight = False
        Me.RecordDateDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RecordDateDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RecordDateDateEdit1.Name = "RecordDateDateEdit1"
        '
        'Remark
        '
        Me.Remark.Caption = "รายละเอียด"
        Me.Remark.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.Remark.FieldName = "Remark"
        Me.Remark.Name = "Remark"
        Me.Remark.Visible = True
        Me.Remark.VisibleIndex = 4
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'frmBankAccountRec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 441)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frmBankAccountRec"
        Me.Text = "ผู้อนุมัติ"
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.GeneralTabPage.ResumeLayout(False)
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankAccountIDLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationDTLIDLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DebitCalcEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditCalcEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KeepMinSpinEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationDTLSearchLookUp1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationDTLView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationIDComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationDTLLookUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationButtonEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecordDateDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecordDateDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents GeneralTabPage As DevExpress.XtraTab.XtraTabPage
    Private WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Private WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SEQ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RecordDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RecordDateDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents BankAccountID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents BankAccountIDLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Debit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DebitCalcEdit As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents Credit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CreditCalcEdit As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Private WithEvents repositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Private WithEvents repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Private WithEvents repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents KeepMinSpinEdit As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents LocationDTLIDLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents LocationDTLSearchLookUp1 As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LocationGrid As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents LocationDTLView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LocationIDComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents LocationDTLLookUp As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemPopupContainerEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents LocationButtonEdit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemRadioGroup1 As DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
