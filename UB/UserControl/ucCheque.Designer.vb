<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucCheque
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
        Me.ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BankDocType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnBankDocType = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ChequeNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ChequeDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.ChequeDateReceive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ChequeDateDue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ChequeBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCalcEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.ChequePay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ChequeStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ChequeStatusCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.BankAccountID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BankBranch = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BankID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CashType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ChequeDatePass = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ChequeDateStop = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ChequeOwnerEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ChequeOwnerTH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ChequeStep = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ChequeType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Remark = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBankDocType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChequeStatusCombo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemCalcEdit3, Me.ChequeStatusCombo, Me.btnBankDocType})
        Me.gridControl.Size = New System.Drawing.Size(1027, 506)
        Me.gridControl.TabIndex = 7
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ID, Me.BankDocType, Me.ChequeNo, Me.ChequeDate, Me.ChequeDateReceive, Me.ChequeDateDue, Me.ChequeBalance, Me.ChequePay, Me.ChequeStatus, Me.BankAccountID, Me.BankBranch, Me.BankID, Me.CashType, Me.ChequeDatePass, Me.ChequeDateStop, Me.ChequeOwnerEN, Me.ChequeOwnerTH, Me.ChequeStep, Me.ChequeType, Me.Remark})
        Me.gridView.GridControl = Me.gridControl
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gridView.OptionsLayout.Columns.AddNewColumns = False
        Me.gridView.OptionsLayout.Columns.RemoveOldColumns = False
        Me.gridView.OptionsNavigation.AutoFocusNewRow = True
        Me.gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.gridView.OptionsView.ShowGroupPanel = False
        '
        'ID
        '
        Me.ID.Caption = "GridColumn8"
        Me.ID.FieldName = "ID"
        Me.ID.Name = "ID"
        '
        'BankDocType
        '
        Me.BankDocType.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.BankDocType.AppearanceCell.Options.UseBackColor = True
        Me.BankDocType.AppearanceHeader.Options.UseTextOptions = True
        Me.BankDocType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BankDocType.Caption = "ประเภทเอกสาร"
        Me.BankDocType.ColumnEdit = Me.btnBankDocType
        Me.BankDocType.FieldName = "BankDocType"
        Me.BankDocType.MaxWidth = 200
        Me.BankDocType.MinWidth = 100
        Me.BankDocType.Name = "BankDocType"
        Me.BankDocType.Visible = True
        Me.BankDocType.VisibleIndex = 0
        Me.BankDocType.Width = 200
        '
        'btnBankDocType
        '
        Me.btnBankDocType.AutoHeight = False
        Me.btnBankDocType.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.btnBankDocType.Name = "btnBankDocType"
        '
        'ChequeNo
        '
        Me.ChequeNo.AppearanceCell.BackColor = System.Drawing.Color.LightYellow
        Me.ChequeNo.AppearanceCell.Options.UseBackColor = True
        Me.ChequeNo.AppearanceHeader.Options.UseTextOptions = True
        Me.ChequeNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ChequeNo.Caption = "เลขที่เอกสาร"
        Me.ChequeNo.FieldName = "ChequeNo"
        Me.ChequeNo.MinWidth = 200
        Me.ChequeNo.Name = "ChequeNo"
        Me.ChequeNo.OptionsColumn.ReadOnly = True
        Me.ChequeNo.OptionsColumn.TabStop = False
        Me.ChequeNo.Visible = True
        Me.ChequeNo.VisibleIndex = 1
        Me.ChequeNo.Width = 255
        '
        'ChequeDate
        '
        Me.ChequeDate.AppearanceCell.BackColor = System.Drawing.Color.LightYellow
        Me.ChequeDate.AppearanceCell.Options.UseBackColor = True
        Me.ChequeDate.AppearanceHeader.Options.UseTextOptions = True
        Me.ChequeDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ChequeDate.Caption = "วันทำรายการ"
        Me.ChequeDate.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.ChequeDate.DisplayFormat.FormatString = "d"
        Me.ChequeDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ChequeDate.FieldName = "ChequeDate"
        Me.ChequeDate.MaxWidth = 100
        Me.ChequeDate.MinWidth = 90
        Me.ChequeDate.Name = "ChequeDate"
        Me.ChequeDate.OptionsColumn.ReadOnly = True
        Me.ChequeDate.OptionsColumn.TabStop = False
        Me.ChequeDate.Visible = True
        Me.ChequeDate.VisibleIndex = 2
        Me.ChequeDate.Width = 100
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        Me.RepositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'ChequeDateReceive
        '
        Me.ChequeDateReceive.AppearanceCell.BackColor = System.Drawing.Color.LightYellow
        Me.ChequeDateReceive.AppearanceCell.Options.UseBackColor = True
        Me.ChequeDateReceive.AppearanceHeader.Options.UseTextOptions = True
        Me.ChequeDateReceive.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ChequeDateReceive.Caption = "วันที่รับ-จ่าย"
        Me.ChequeDateReceive.DisplayFormat.FormatString = "d"
        Me.ChequeDateReceive.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ChequeDateReceive.FieldName = "ChequeDateReceive"
        Me.ChequeDateReceive.MaxWidth = 100
        Me.ChequeDateReceive.MinWidth = 90
        Me.ChequeDateReceive.Name = "ChequeDateReceive"
        Me.ChequeDateReceive.Visible = True
        Me.ChequeDateReceive.VisibleIndex = 3
        Me.ChequeDateReceive.Width = 100
        '
        'ChequeDateDue
        '
        Me.ChequeDateDue.AppearanceCell.BackColor = System.Drawing.Color.LightYellow
        Me.ChequeDateDue.AppearanceCell.Options.UseBackColor = True
        Me.ChequeDateDue.AppearanceHeader.Options.UseTextOptions = True
        Me.ChequeDateDue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ChequeDateDue.Caption = "วันที่ DUE"
        Me.ChequeDateDue.DisplayFormat.FormatString = "d"
        Me.ChequeDateDue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ChequeDateDue.FieldName = "ChequeDateDue"
        Me.ChequeDateDue.MaxWidth = 100
        Me.ChequeDateDue.MinWidth = 90
        Me.ChequeDateDue.Name = "ChequeDateDue"
        Me.ChequeDateDue.Visible = True
        Me.ChequeDateDue.VisibleIndex = 4
        Me.ChequeDateDue.Width = 90
        '
        'ChequeBalance
        '
        Me.ChequeBalance.AppearanceCell.BackColor = System.Drawing.Color.LightYellow
        Me.ChequeBalance.AppearanceCell.Options.UseBackColor = True
        Me.ChequeBalance.AppearanceHeader.Options.UseTextOptions = True
        Me.ChequeBalance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ChequeBalance.Caption = "จำนวนเงิน"
        Me.ChequeBalance.ColumnEdit = Me.RepositoryItemCalcEdit3
        Me.ChequeBalance.DisplayFormat.FormatString = "n2"
        Me.ChequeBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ChequeBalance.FieldName = "ChequeBalance"
        Me.ChequeBalance.MaxWidth = 150
        Me.ChequeBalance.MinWidth = 100
        Me.ChequeBalance.Name = "ChequeBalance"
        Me.ChequeBalance.OptionsColumn.ReadOnly = True
        Me.ChequeBalance.OptionsColumn.TabStop = False
        Me.ChequeBalance.Visible = True
        Me.ChequeBalance.VisibleIndex = 5
        Me.ChequeBalance.Width = 150
        '
        'RepositoryItemCalcEdit3
        '
        Me.RepositoryItemCalcEdit3.AutoHeight = False
        Me.RepositoryItemCalcEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit3.EditFormat.FormatString = "n2"
        Me.RepositoryItemCalcEdit3.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemCalcEdit3.Name = "RepositoryItemCalcEdit3"
        '
        'ChequePay
        '
        Me.ChequePay.AppearanceCell.BackColor = System.Drawing.Color.LightYellow
        Me.ChequePay.AppearanceCell.Options.UseBackColor = True
        Me.ChequePay.AppearanceCell.Options.UseTextOptions = True
        Me.ChequePay.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ChequePay.AppearanceHeader.Options.UseTextOptions = True
        Me.ChequePay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ChequePay.Caption = "ยอดชำระ"
        Me.ChequePay.DisplayFormat.FormatString = "n2"
        Me.ChequePay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ChequePay.FieldName = "ChequePay"
        Me.ChequePay.MaxWidth = 150
        Me.ChequePay.MinWidth = 100
        Me.ChequePay.Name = "ChequePay"
        Me.ChequePay.OptionsColumn.ReadOnly = True
        Me.ChequePay.OptionsColumn.TabStop = False
        Me.ChequePay.Visible = True
        Me.ChequePay.VisibleIndex = 6
        Me.ChequePay.Width = 150
        '
        'ChequeStatus
        '
        Me.ChequeStatus.Caption = "สถานะ"
        Me.ChequeStatus.ColumnEdit = Me.ChequeStatusCombo
        Me.ChequeStatus.FieldName = "ChequeStatus"
        Me.ChequeStatus.MaxWidth = 180
        Me.ChequeStatus.MinWidth = 100
        Me.ChequeStatus.Name = "ChequeStatus"
        Me.ChequeStatus.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        Me.ChequeStatus.Visible = True
        Me.ChequeStatus.VisibleIndex = 7
        Me.ChequeStatus.Width = 150
        '
        'ChequeStatusCombo
        '
        Me.ChequeStatusCombo.AutoHeight = False
        Me.ChequeStatusCombo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ChequeStatusCombo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ChequeStatusCode", "รหัสสถานะ"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ChequeStatusName", 30, "สถานะ")})
        Me.ChequeStatusCombo.DisplayMember = "ChequeStatusName"
        Me.ChequeStatusCombo.Name = "ChequeStatusCombo"
        Me.ChequeStatusCombo.NullText = ""
        Me.ChequeStatusCombo.ValueMember = "ChequeStatusCode"
        '
        'BankAccountID
        '
        Me.BankAccountID.Caption = "BankAccountID"
        Me.BankAccountID.FieldName = "BankAccountID"
        Me.BankAccountID.Name = "BankAccountID"
        '
        'BankBranch
        '
        Me.BankBranch.Caption = "BankBranch"
        Me.BankBranch.FieldName = "BankBranch"
        Me.BankBranch.Name = "BankBranch"
        '
        'BankID
        '
        Me.BankID.Caption = "BankID"
        Me.BankID.FieldName = "BankID"
        Me.BankID.Name = "BankID"
        '
        'CashType
        '
        Me.CashType.Caption = "CashType"
        Me.CashType.FieldName = "CashType"
        Me.CashType.Name = "CashType"
        '
        'ChequeDatePass
        '
        Me.ChequeDatePass.Caption = "ChequeDatePass"
        Me.ChequeDatePass.FieldName = "ChequeDatePass"
        Me.ChequeDatePass.Name = "ChequeDatePass"
        '
        'ChequeDateStop
        '
        Me.ChequeDateStop.Caption = "ChequeDateStop"
        Me.ChequeDateStop.FieldName = "ChequeDateStop"
        Me.ChequeDateStop.Name = "ChequeDateStop"
        '
        'ChequeOwnerEN
        '
        Me.ChequeOwnerEN.Caption = "ChequeOwnerEN"
        Me.ChequeOwnerEN.FieldName = "ChequeOwnerEN"
        Me.ChequeOwnerEN.Name = "ChequeOwnerEN"
        '
        'ChequeOwnerTH
        '
        Me.ChequeOwnerTH.Caption = "ChequeOwnerTH"
        Me.ChequeOwnerTH.FieldName = "ChequeOwnerTH"
        Me.ChequeOwnerTH.Name = "ChequeOwnerTH"
        '
        'ChequeStep
        '
        Me.ChequeStep.Caption = "ChequeStep"
        Me.ChequeStep.FieldName = "ChequeStep"
        Me.ChequeStep.Name = "ChequeStep"
        '
        'ChequeType
        '
        Me.ChequeType.Caption = "ChequeType"
        Me.ChequeType.FieldName = "ChequeType"
        Me.ChequeType.Name = "ChequeType"
        '
        'Remark
        '
        Me.Remark.Caption = "Remark"
        Me.Remark.FieldName = "Remark"
        Me.Remark.Name = "Remark"
        '
        'ucCheque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gridControl)
        Me.Name = "ucCheque"
        Me.Size = New System.Drawing.Size(1027, 506)
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBankDocType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChequeStatusCombo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Private WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChequeNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChequeDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents ChequeBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents BankDocType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChequePay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChequeStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BankAccountID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BankBranch As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BankID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CashType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChequeDateDue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChequeDatePass As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChequeDateReceive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChequeDateStop As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChequeOwnerEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChequeOwnerTH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChequeStep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChequeType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChequeStatusCombo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnBankDocType As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit

End Class
