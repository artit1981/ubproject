<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCommissionReport
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCommissionReport))
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupConn = New DevExpress.XtraEditors.GroupControl()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDateTo = New DevExpress.XtraEditors.DateEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDateFrom = New DevExpress.XtraEditors.DateEdit()
        Me.rdoCondition = New DevExpress.XtraEditors.RadioGroup()
        Me.cboCheckedEmployee = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnExportExcel = New DevExpress.XtraEditors.PictureEdit()
        Me.cboRefreshTime = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.CheckIsRefresh = New DevExpress.XtraEditors.CheckEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.CheckShowInfo = New DevExpress.XtraEditors.CheckEdit()
        Me.cboStatus = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFind = New DevExpress.XtraEditors.SimpleButton()
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ProductBtn = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.PriceCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cboCheckedTerritory = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.cboCheckedCommission = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GroupConn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupConn.SuspendLayout()
        CType(Me.dtpDateTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDateTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDateFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDateFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdoCondition.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCheckedEmployee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.btnExportExcel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRefreshTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckIsRefresh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckShowInfo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCheckedTerritory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCheckedCommission.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Controls.Add(Me.GroupConn)
        Me.PanelControl2.Controls.Add(Me.PanelControl1)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Controls.Add(Me.btnFind)
        Me.PanelControl2.Location = New System.Drawing.Point(4, 3)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(958, 189)
        Me.PanelControl2.TabIndex = 226
        '
        'GroupConn
        '
        Me.GroupConn.Controls.Add(Me.Label5)
        Me.GroupConn.Controls.Add(Me.cboCheckedCommission)
        Me.GroupConn.Controls.Add(Me.cboCheckedTerritory)
        Me.GroupConn.Controls.Add(Me.Label3)
        Me.GroupConn.Controls.Add(Me.dtpDateTo)
        Me.GroupConn.Controls.Add(Me.Label2)
        Me.GroupConn.Controls.Add(Me.dtpDateFrom)
        Me.GroupConn.Controls.Add(Me.rdoCondition)
        Me.GroupConn.Controls.Add(Me.cboCheckedEmployee)
        Me.GroupConn.Location = New System.Drawing.Point(17, 12)
        Me.GroupConn.Name = "GroupConn"
        Me.GroupConn.Size = New System.Drawing.Size(448, 167)
        Me.GroupConn.TabIndex = 298
        Me.GroupConn.Text = "เงื่อนไข"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(245, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 14)
        Me.Label3.TabIndex = 301
        Me.Label3.Text = "ถึง"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.EditValue = New Date(2012, 4, 20, 0, 0, 0, 0)
        Me.dtpDateTo.EnterMoveNextControl = True
        Me.dtpDateTo.Location = New System.Drawing.Point(271, 37)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.dtpDateTo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpDateTo.Properties.Appearance.Options.UseFont = True
        Me.dtpDateTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpDateTo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpDateTo.Properties.DisplayFormat.FormatString = "D"
        Me.dtpDateTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpDateTo.Properties.EditFormat.FormatString = "D"
        Me.dtpDateTo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpDateTo.Properties.MaskSettings.Set("mask", "D")
        Me.dtpDateTo.Size = New System.Drawing.Size(139, 20)
        Me.dtpDateTo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 14)
        Me.Label2.TabIndex = 299
        Me.Label2.Text = "ช่วงวันที่"
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.EditValue = New Date(2012, 4, 20, 0, 0, 0, 0)
        Me.dtpDateFrom.EnterMoveNextControl = True
        Me.dtpDateFrom.Location = New System.Drawing.Point(96, 37)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.dtpDateFrom.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpDateFrom.Properties.Appearance.Options.UseFont = True
        Me.dtpDateFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpDateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpDateFrom.Properties.DisplayFormat.FormatString = "D"
        Me.dtpDateFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpDateFrom.Properties.EditFormat.FormatString = "D"
        Me.dtpDateFrom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpDateFrom.Properties.MaskSettings.Set("mask", "D")
        Me.dtpDateFrom.Size = New System.Drawing.Size(139, 20)
        Me.dtpDateFrom.TabIndex = 0
        '
        'rdoCondition
        '
        Me.rdoCondition.EditValue = CType(1, Short)
        Me.rdoCondition.Location = New System.Drawing.Point(15, 103)
        Me.rdoCondition.Name = "rdoCondition"
        Me.rdoCondition.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rdoCondition.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoCondition.Properties.Appearance.Options.UseBackColor = True
        Me.rdoCondition.Properties.Appearance.Options.UseFont = True
        Me.rdoCondition.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rdoCondition.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(1, Short), "บุคคล"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(2, Short), "ทีม")})
        Me.rdoCondition.Size = New System.Drawing.Size(75, 56)
        Me.rdoCondition.TabIndex = 3
        '
        'cboCheckedEmployee
        '
        Me.cboCheckedEmployee.Location = New System.Drawing.Point(96, 110)
        Me.cboCheckedEmployee.Name = "cboCheckedEmployee"
        Me.cboCheckedEmployee.Properties.AllowMultiSelect = True
        Me.cboCheckedEmployee.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCheckedEmployee.Properties.DropDownRows = 20
        Me.cboCheckedEmployee.Properties.IncrementalSearch = True
        Me.cboCheckedEmployee.Size = New System.Drawing.Size(314, 20)
        Me.cboCheckedEmployee.TabIndex = 4
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.btnExportExcel)
        Me.PanelControl1.Controls.Add(Me.cboRefreshTime)
        Me.PanelControl1.Controls.Add(Me.CheckIsRefresh)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.CheckShowInfo)
        Me.PanelControl1.Controls.Add(Me.cboStatus)
        Me.PanelControl1.Controls.Add(Me.Label4)
        Me.PanelControl1.Location = New System.Drawing.Point(835, 139)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(123, 40)
        Me.PanelControl1.TabIndex = 295
        '
        'btnExportExcel
        '
        Me.btnExportExcel.EditValue = CType(resources.GetObject("btnExportExcel.EditValue"), Object)
        Me.btnExportExcel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExportExcel.Location = New System.Drawing.Point(60, 4)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnExportExcel.Properties.Appearance.Options.UseBackColor = True
        Me.btnExportExcel.Size = New System.Drawing.Size(58, 33)
        Me.btnExportExcel.TabIndex = 118
        Me.btnExportExcel.ToolTip = "Expor to File"
        Me.btnExportExcel.ToolTipTitle = "Expor to File"
        '
        'cboRefreshTime
        '
        Me.cboRefreshTime.EditValue = "5"
        Me.cboRefreshTime.Location = New System.Drawing.Point(282, 3)
        Me.cboRefreshTime.Name = "cboRefreshTime"
        Me.cboRefreshTime.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRefreshTime.Properties.Appearance.Options.UseFont = True
        Me.cboRefreshTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRefreshTime.Properties.Items.AddRange(New Object() {"1", "5", "10", "30", "60"})
        Me.cboRefreshTime.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboRefreshTime.Size = New System.Drawing.Size(45, 20)
        Me.cboRefreshTime.TabIndex = 114
        Me.cboRefreshTime.Visible = False
        '
        'CheckIsRefresh
        '
        Me.CheckIsRefresh.EditValue = True
        Me.CheckIsRefresh.Location = New System.Drawing.Point(277, 4)
        Me.CheckIsRefresh.Name = "CheckIsRefresh"
        Me.CheckIsRefresh.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CheckIsRefresh.Properties.Appearance.Options.UseFont = True
        Me.CheckIsRefresh.Properties.Caption = "Refresh"
        Me.CheckIsRefresh.Size = New System.Drawing.Size(72, 20)
        Me.CheckIsRefresh.TabIndex = 113
        Me.CheckIsRefresh.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 14)
        Me.Label1.TabIndex = 119
        Me.Label1.Text = "Export :"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(331, 6)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl1.TabIndex = 115
        Me.LabelControl1.Text = "วินาที"
        Me.LabelControl1.Visible = False
        '
        'CheckShowInfo
        '
        Me.CheckShowInfo.EditValue = True
        Me.CheckShowInfo.Location = New System.Drawing.Point(246, 2)
        Me.CheckShowInfo.Name = "CheckShowInfo"
        Me.CheckShowInfo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CheckShowInfo.Properties.Appearance.Options.UseFont = True
        Me.CheckShowInfo.Properties.Caption = "Show Information"
        Me.CheckShowInfo.Size = New System.Drawing.Size(126, 20)
        Me.CheckShowInfo.TabIndex = 116
        Me.CheckShowInfo.Visible = False
        '
        'cboStatus
        '
        Me.cboStatus.Location = New System.Drawing.Point(279, 4)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboStatus.Properties.Appearance.Options.UseFont = True
        Me.cboStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboStatus.Size = New System.Drawing.Size(41, 20)
        Me.cboStatus.TabIndex = 112
        Me.cboStatus.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(232, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 14)
        Me.Label4.TabIndex = 111
        Me.Label4.Text = "สถานะ"
        Me.Label4.Visible = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Appearance.Options.UseImage = True
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.SimpleButton1.Location = New System.Drawing.Point(498, 62)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(101, 37)
        Me.SimpleButton1.TabIndex = 7
        Me.SimpleButton1.TabStop = False
        Me.SimpleButton1.Text = "ปิดหน้าจอ"
        Me.SimpleButton1.ToolTip = "ปิดหน้าจอ"
        '
        'btnFind
        '
        Me.btnFind.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnFind.Appearance.Options.UseFont = True
        Me.btnFind.Appearance.Options.UseImage = True
        Me.btnFind.ImageOptions.Image = CType(resources.GetObject("btnFind.ImageOptions.Image"), System.Drawing.Image)
        Me.btnFind.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnFind.Location = New System.Drawing.Point(498, 12)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(101, 37)
        Me.btnFind.TabIndex = 6
        Me.btnFind.TabStop = False
        Me.btnFind.Text = "ค้นหา"
        Me.btnFind.ToolTip = "ค้นหา"
        '
        'gridControl
        '
        Me.gridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gridControl.EmbeddedNavigator.Buttons.Edit.ImageIndex = 0
        Me.gridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gridControl.Location = New System.Drawing.Point(4, 198)
        Me.gridControl.MainView = Me.gridView
        Me.gridControl.Name = "gridControl"
        Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ProductBtn, Me.PriceCalcEdit1})
        Me.gridControl.Size = New System.Drawing.Size(958, 235)
        Me.gridControl.TabIndex = 295
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
        Me.gridView.OptionsView.ShowGroupPanel = False
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
        'cboCheckedTerritory
        '
        Me.cboCheckedTerritory.Location = New System.Drawing.Point(96, 136)
        Me.cboCheckedTerritory.Name = "cboCheckedTerritory"
        Me.cboCheckedTerritory.Properties.AllowMultiSelect = True
        Me.cboCheckedTerritory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCheckedTerritory.Properties.DropDownRows = 20
        Me.cboCheckedTerritory.Properties.IncrementalSearch = True
        Me.cboCheckedTerritory.Size = New System.Drawing.Size(314, 20)
        Me.cboCheckedTerritory.TabIndex = 5
        '
        'cboCheckedCommission
        '
        Me.cboCheckedCommission.Location = New System.Drawing.Point(96, 74)
        Me.cboCheckedCommission.Name = "cboCheckedCommission"
        Me.cboCheckedCommission.Properties.AllowMultiSelect = True
        Me.cboCheckedCommission.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCheckedCommission.Properties.DropDownRows = 20
        Me.cboCheckedCommission.Properties.IncrementalSearch = True
        Me.cboCheckedCommission.Size = New System.Drawing.Size(314, 20)
        Me.cboCheckedCommission.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 14)
        Me.Label5.TabIndex = 304
        Me.Label5.Text = "คอมมิชชัน"
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'frmCommissionReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 437)
        Me.Controls.Add(Me.gridControl)
        Me.Controls.Add(Me.PanelControl2)
        Me.IconOptions.Icon = CType(resources.GetObject("frmCommissionReport.IconOptions.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmCommissionReport"
        Me.Text = "Commission Report"
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.GroupConn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupConn.ResumeLayout(False)
        Me.GroupConn.PerformLayout()
        CType(Me.dtpDateTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDateTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDateFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDateFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdoCondition.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCheckedEmployee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.btnExportExcel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRefreshTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckIsRefresh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckShowInfo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCheckedTerritory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCheckedCommission.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnFind As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Private WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Private WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ProductBtn As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents PriceCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnExportExcel As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents cboRefreshTime As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents CheckIsRefresh As DevExpress.XtraEditors.CheckEdit
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckShowInfo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cboStatus As DevExpress.XtraEditors.ComboBoxEdit
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboCheckedEmployee As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents rdoCondition As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents GroupConn As DevExpress.XtraEditors.GroupControl
    Private WithEvents Label3 As Label
    Friend WithEvents dtpDateTo As DevExpress.XtraEditors.DateEdit
    Private WithEvents Label2 As Label
    Friend WithEvents dtpDateFrom As DevExpress.XtraEditors.DateEdit
    Private WithEvents Label5 As Label
    Friend WithEvents cboCheckedCommission As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents cboCheckedTerritory As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
End Class
