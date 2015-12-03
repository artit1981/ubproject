<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucApproveUser
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
        Me.ControlNavigator2 = New DevExpress.XtraEditors.ControlNavigator()
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.EmpID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EmpName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NameBtn = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.PositionName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Email1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Phone1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ApproveAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ApproveCalcEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.Remark = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IsCancel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IsCancelCheckEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.SEQ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ApproveUserDtlID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ApproveType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ModeData = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RateSpinEdit = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.UnitBtn = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemMarqueeProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ContactRoleLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.NameLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ContactRoleComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NameBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApproveCalcEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsCancelCheckEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RateSpinEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMarqueeProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactRoleLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NameLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactRoleComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ControlNavigator2
        '
        Me.ControlNavigator2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ControlNavigator2.Buttons.Append.Visible = False
        Me.ControlNavigator2.Buttons.CancelEdit.Visible = False
        Me.ControlNavigator2.Buttons.Edit.Visible = False
        Me.ControlNavigator2.Buttons.EndEdit.Visible = False
        Me.ControlNavigator2.Buttons.Remove.Hint = "ลบข้อมูล"
        Me.ControlNavigator2.Buttons.Remove.ImageIndex = 0
        Me.ControlNavigator2.Buttons.Remove.Tag = " ลบข้อมูล"
        Me.ControlNavigator2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.ControlNavigator2.Location = New System.Drawing.Point(0, 317)
        Me.ControlNavigator2.Name = "ControlNavigator2"
        Me.ControlNavigator2.NavigatableControl = Me.gridControl
        Me.ControlNavigator2.Size = New System.Drawing.Size(190, 24)
        Me.ControlNavigator2.TabIndex = 18
        Me.ControlNavigator2.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
        '
        'gridControl
        '
        Me.gridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gridControl.EmbeddedNavigator.Buttons.Edit.ImageIndex = 0
        Me.gridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gridControl.Location = New System.Drawing.Point(3, 3)
        Me.gridControl.MainView = Me.gridView
        Me.gridControl.Name = "gridControl"
        Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RateSpinEdit, Me.RepositoryItemCheckEdit1, Me.UnitBtn, Me.RepositoryItemMarqueeProgressBar1, Me.RepositoryItemLookUpEdit1, Me.ContactRoleLookUpEdit, Me.NameLookUpEdit, Me.NameBtn, Me.ContactRoleComboBox, Me.ApproveCalcEdit, Me.IsCancelCheckEdit})
        Me.gridControl.Size = New System.Drawing.Size(880, 315)
        Me.gridControl.TabIndex = 17
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.EmpID, Me.EmpName, Me.PositionName, Me.Email1, Me.Phone1, Me.ApproveAmount, Me.Remark, Me.IsCancel, Me.SEQ, Me.ApproveUserDtlID, Me.ApproveType, Me.ModeData})
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
        'EmpID
        '
        Me.EmpID.Caption = "ID"
        Me.EmpID.FieldName = "EmpID"
        Me.EmpID.Name = "EmpID"
        '
        'EmpName
        '
        Me.EmpName.AppearanceHeader.Options.UseTextOptions = True
        Me.EmpName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmpName.Caption = "ผู้อนุมัติ"
        Me.EmpName.ColumnEdit = Me.NameBtn
        Me.EmpName.FieldName = "EmpName"
        Me.EmpName.MaxWidth = 200
        Me.EmpName.MinWidth = 150
        Me.EmpName.Name = "EmpName"
        Me.EmpName.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowOnlyInEditor
        Me.EmpName.Visible = True
        Me.EmpName.VisibleIndex = 0
        Me.EmpName.Width = 200
        '
        'NameBtn
        '
        Me.NameBtn.AutoHeight = False
        Me.NameBtn.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.NameBtn.Name = "NameBtn"
        '
        'PositionName
        '
        Me.PositionName.AppearanceCell.BackColor = System.Drawing.Color.LightYellow
        Me.PositionName.AppearanceCell.Options.UseBackColor = True
        Me.PositionName.AppearanceHeader.Options.UseTextOptions = True
        Me.PositionName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PositionName.Caption = "ตำแหน่ง"
        Me.PositionName.FieldName = "PositionName"
        Me.PositionName.MaxWidth = 200
        Me.PositionName.MinWidth = 120
        Me.PositionName.Name = "PositionName"
        Me.PositionName.OptionsColumn.AllowEdit = False
        Me.PositionName.OptionsColumn.AllowFocus = False
        Me.PositionName.OptionsColumn.ReadOnly = True
        Me.PositionName.OptionsColumn.TabStop = False
        Me.PositionName.Visible = True
        Me.PositionName.VisibleIndex = 1
        Me.PositionName.Width = 120
        '
        'Email1
        '
        Me.Email1.AppearanceCell.BackColor = System.Drawing.Color.LightYellow
        Me.Email1.AppearanceCell.Options.UseBackColor = True
        Me.Email1.AppearanceHeader.Options.UseTextOptions = True
        Me.Email1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Email1.Caption = "อีเมล์"
        Me.Email1.FieldName = "Email1"
        Me.Email1.MaxWidth = 120
        Me.Email1.MinWidth = 100
        Me.Email1.Name = "Email1"
        Me.Email1.OptionsColumn.AllowEdit = False
        Me.Email1.OptionsColumn.AllowFocus = False
        Me.Email1.OptionsColumn.ReadOnly = True
        Me.Email1.OptionsColumn.TabStop = False
        Me.Email1.Visible = True
        Me.Email1.VisibleIndex = 2
        Me.Email1.Width = 120
        '
        'Phone1
        '
        Me.Phone1.AppearanceCell.BackColor = System.Drawing.Color.LightYellow
        Me.Phone1.AppearanceCell.Options.UseBackColor = True
        Me.Phone1.AppearanceHeader.Options.UseTextOptions = True
        Me.Phone1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Phone1.Caption = "โทรศัพท์"
        Me.Phone1.FieldName = "Phone1"
        Me.Phone1.MaxWidth = 120
        Me.Phone1.MinWidth = 100
        Me.Phone1.Name = "Phone1"
        Me.Phone1.OptionsColumn.AllowEdit = False
        Me.Phone1.OptionsColumn.AllowFocus = False
        Me.Phone1.OptionsColumn.TabStop = False
        Me.Phone1.Visible = True
        Me.Phone1.VisibleIndex = 3
        Me.Phone1.Width = 100
        '
        'ApproveAmount
        '
        Me.ApproveAmount.AppearanceHeader.Options.UseTextOptions = True
        Me.ApproveAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ApproveAmount.Caption = "วงเงินอนุมัติ"
        Me.ApproveAmount.ColumnEdit = Me.ApproveCalcEdit
        Me.ApproveAmount.DisplayFormat.FormatString = "n2"
        Me.ApproveAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ApproveAmount.FieldName = "ApproveAmount"
        Me.ApproveAmount.MaxWidth = 130
        Me.ApproveAmount.MinWidth = 100
        Me.ApproveAmount.Name = "ApproveAmount"
        Me.ApproveAmount.Visible = True
        Me.ApproveAmount.VisibleIndex = 4
        Me.ApproveAmount.Width = 100
        '
        'ApproveCalcEdit
        '
        Me.ApproveCalcEdit.AutoHeight = False
        Me.ApproveCalcEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ApproveCalcEdit.DisplayFormat.FormatString = "n2"
        Me.ApproveCalcEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ApproveCalcEdit.EditFormat.FormatString = "n2"
        Me.ApproveCalcEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ApproveCalcEdit.Name = "ApproveCalcEdit"
        '
        'Remark
        '
        Me.Remark.AppearanceHeader.Options.UseTextOptions = True
        Me.Remark.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Remark.Caption = "หมายเหตุ"
        Me.Remark.FieldName = "Remark"
        Me.Remark.MaxWidth = 200
        Me.Remark.MinWidth = 100
        Me.Remark.Name = "Remark"
        Me.Remark.Visible = True
        Me.Remark.VisibleIndex = 5
        Me.Remark.Width = 100
        '
        'IsCancel
        '
        Me.IsCancel.AppearanceHeader.Options.UseTextOptions = True
        Me.IsCancel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.IsCancel.Caption = "ระงับการใช้งาน"
        Me.IsCancel.ColumnEdit = Me.IsCancelCheckEdit
        Me.IsCancel.FieldName = "IsCancel"
        Me.IsCancel.MaxWidth = 70
        Me.IsCancel.Name = "IsCancel"
        Me.IsCancel.ToolTip = "ระงับการใช้งาน"
        Me.IsCancel.Visible = True
        Me.IsCancel.VisibleIndex = 6
        Me.IsCancel.Width = 50
        '
        'IsCancelCheckEdit
        '
        Me.IsCancelCheckEdit.AutoHeight = False
        Me.IsCancelCheckEdit.Name = "IsCancelCheckEdit"
        '
        'SEQ
        '
        Me.SEQ.Caption = "SEQ"
        Me.SEQ.FieldName = "SEQ"
        Me.SEQ.Name = "SEQ"
        '
        'ApproveUserDtlID
        '
        Me.ApproveUserDtlID.Caption = "ApproveUserDtlID"
        Me.ApproveUserDtlID.FieldName = "ApproveUserDtlID"
        Me.ApproveUserDtlID.Name = "ApproveUserDtlID"
        '
        'ApproveType
        '
        Me.ApproveType.Caption = "ApproveType"
        Me.ApproveType.FieldName = "ApproveType"
        Me.ApproveType.Name = "ApproveType"
        '
        'ModeData
        '
        Me.ModeData.Caption = "ModeData"
        Me.ModeData.FieldName = "ModeData"
        Me.ModeData.Name = "ModeData"
        '
        'RateSpinEdit
        '
        Me.RateSpinEdit.AutoHeight = False
        Me.RateSpinEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RateSpinEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RateSpinEdit.Mask.EditMask = "n0"
        Me.RateSpinEdit.Name = "RateSpinEdit"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'UnitBtn
        '
        Me.UnitBtn.AutoHeight = False
        Me.UnitBtn.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.UnitBtn.Name = "UnitBtn"
        '
        'RepositoryItemMarqueeProgressBar1
        '
        Me.RepositoryItemMarqueeProgressBar1.Name = "RepositoryItemMarqueeProgressBar1"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'ContactRoleLookUpEdit
        '
        Me.ContactRoleLookUpEdit.AutoHeight = False
        Me.ContactRoleLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ContactRoleLookUpEdit.Name = "ContactRoleLookUpEdit"
        '
        'NameLookUpEdit
        '
        Me.NameLookUpEdit.AutoHeight = False
        Me.NameLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.NameLookUpEdit.Name = "NameLookUpEdit"
        '
        'ContactRoleComboBox
        '
        Me.ContactRoleComboBox.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.ContactRoleComboBox.AutoHeight = False
        Me.ContactRoleComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ContactRoleComboBox.ImmediatePopup = True
        Me.ContactRoleComboBox.Name = "ContactRoleComboBox"
        Me.ContactRoleComboBox.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ContactRoleComboBox.ValidateOnEnterKey = True
        '
        'ucApproveUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ControlNavigator2)
        Me.Controls.Add(Me.gridControl)
        Me.Name = "ucApproveUser"
        Me.Size = New System.Drawing.Size(886, 344)
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NameBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApproveCalcEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsCancelCheckEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RateSpinEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMarqueeProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactRoleLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NameLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactRoleComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ControlNavigator2 As DevExpress.XtraEditors.ControlNavigator
    Private WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Private WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents EmpID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmpName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NameBtn As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents PositionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Email1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Phone1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SEQ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RateSpinEdit As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents UnitBtn As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemMarqueeProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ContactRoleLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents NameLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ContactRoleComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents ApproveAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ApproveCalcEdit As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents ApproveUserDtlID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IsCancel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IsCancelCheckEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ApproveType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ModeData As DevExpress.XtraGrid.Columns.GridColumn

End Class
