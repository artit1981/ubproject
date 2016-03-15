<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSN))
        Me.OrderID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SerialNumberID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProductID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SerialNumberNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IsDelete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RunningCount = New DevExpress.XtraEditors.CalcEdit()
        Me.FormatMidle = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.FormatFront = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.ProductName = New DevExpress.XtraEditors.TextEdit()
        Me.SNNo = New DevExpress.XtraEditors.TextEdit()
        Me.ProductCode = New DevExpress.XtraEditors.TextEdit()
        Me.btnGenID = New DevExpress.XtraEditors.SimpleButton()
        Me.ControlNavigator1 = New DevExpress.XtraEditors.ControlNavigator()
        Me.SNType = New DevExpress.XtraEditors.RadioGroup()
        Me.StartNo = New DevExpress.XtraEditors.CalcEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLoadSN = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.SnLast = New DevExpress.XtraEditors.TextEdit()
        Me.btnPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.lblProcode = New System.Windows.Forms.Label()
        Me.Units = New DevExpress.XtraEditors.SpinEdit()
        Me.btnFind = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSelectSN = New DevExpress.XtraEditors.SimpleButton()
        Me.UnitsMain = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.UnitName = New DevExpress.XtraEditors.TextEdit()
        Me.UnitMainName = New DevExpress.XtraEditors.TextEdit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RunningCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormatMidle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormatFront.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SNNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SNType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SnLast.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Units.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitsMain.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitMainName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.SerialNumberID, Me.OrderID, Me.ProductID, Me.SerialNumberNo, Me.Status, Me.IsDelete})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView1.OptionsFilter.AllowFilterEditor = False
        Me.GridView1.OptionsFilter.AllowFilterIncrementalSearch = False
        Me.GridView1.OptionsFilter.AllowMRUFilterList = False
        Me.GridView1.OptionsFilter.AllowMultiSelectInCheckedFilterPopup = False
        Me.GridView1.OptionsFilter.FilterEditorUseMenuForOperandsAndOperators = False
        Me.GridView1.OptionsFilter.ShowAllTableValuesInCheckedFilterPopup = False
        Me.GridView1.OptionsFind.AllowFindPanel = False
        Me.GridView1.OptionsFind.ShowFindButton = False
        Me.GridView1.OptionsHint.ShowColumnHeaderHints = False
        Me.GridView1.OptionsHint.ShowFooterHints = False
        Me.GridView1.OptionsMenu.EnableColumnMenu = False
        Me.GridView1.OptionsMenu.EnableFooterMenu = False
        Me.GridView1.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView1.OptionsMenu.ShowAutoFilterRowItem = False
        Me.GridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.GridView1.OptionsView.ShowGroupPanel = False
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
        Me.SerialNumberNo.VisibleIndex = 0
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
        Me.Status.VisibleIndex = 1
        Me.Status.Width = 100
        '
        'IsDelete
        '
        Me.IsDelete.Caption = "GridColumn1"
        Me.IsDelete.FieldName = "IsDelete"
        Me.IsDelete.Name = "IsDelete"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(3, 182)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(641, 228)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(305, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 14)
        Me.Label1.TabIndex = 334
        Me.Label1.Text = "หลักเลข Running"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(233, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 14)
        Me.Label7.TabIndex = 333
        Me.Label7.Text = "อักขระคั่น"
        '
        'RunningCount
        '
        Me.RunningCount.EnterMoveNextControl = True
        Me.RunningCount.Location = New System.Drawing.Point(305, 150)
        Me.RunningCount.Name = "RunningCount"
        Me.RunningCount.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RunningCount.Properties.Appearance.Options.UseFont = True
        Me.RunningCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RunningCount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RunningCount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RunningCount.Properties.Mask.EditMask = "n0"
        Me.RunningCount.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.RunningCount.Properties.MaxLength = 10
        Me.RunningCount.Properties.Precision = 0
        Me.RunningCount.Size = New System.Drawing.Size(95, 20)
        Me.RunningCount.TabIndex = 3
        '
        'FormatMidle
        '
        Me.FormatMidle.EnterMoveNextControl = True
        Me.FormatMidle.Location = New System.Drawing.Point(233, 150)
        Me.FormatMidle.Name = "FormatMidle"
        Me.FormatMidle.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormatMidle.Properties.Appearance.Options.UseFont = True
        Me.FormatMidle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FormatMidle.Properties.ImmediatePopup = True
        Me.FormatMidle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.FormatMidle.Properties.UseCtrlScroll = True
        Me.FormatMidle.Properties.ValidateOnEnterKey = True
        Me.FormatMidle.Size = New System.Drawing.Size(66, 20)
        Me.FormatMidle.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(152, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 14)
        Me.Label8.TabIndex = 329
        Me.Label8.Text = "อักขระหน้า"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(25, 57)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl2.TabIndex = 327
        Me.LabelControl2.Text = "จำนวน"
        '
        'FormatFront
        '
        Me.FormatFront.EditValue = ""
        Me.FormatFront.EnterMoveNextControl = True
        Me.FormatFront.Location = New System.Drawing.Point(152, 150)
        Me.FormatFront.Name = "FormatFront"
        Me.FormatFront.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormatFront.Properties.Appearance.Options.UseFont = True
        Me.FormatFront.Properties.MaxLength = 50
        Me.FormatFront.Properties.ValidateOnEnterKey = True
        Me.FormatFront.Size = New System.Drawing.Size(75, 20)
        Me.FormatFront.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(25, 29)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl1.TabIndex = 326
        Me.LabelControl1.Text = "สินค้า"
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
        'SNNo
        '
        Me.SNNo.EditValue = ""
        Me.SNNo.Location = New System.Drawing.Point(152, 112)
        Me.SNNo.Name = "SNNo"
        Me.SNNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SNNo.Properties.Appearance.Options.UseFont = True
        Me.SNNo.Properties.MaxLength = 50
        Me.SNNo.Properties.ValidateOnEnterKey = True
        Me.SNNo.Size = New System.Drawing.Size(307, 20)
        Me.SNNo.TabIndex = 1
        Me.SNNo.ToolTip = "ยิงบาร์โค้ด หรือพิมพ์รหัสแล้ว Enter"
        Me.SNNo.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
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
        'btnGenID
        '
        Me.btnGenID.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnGenID.Appearance.Options.UseFont = True
        Me.btnGenID.Image = CType(resources.GetObject("btnGenID.Image"), System.Drawing.Image)
        Me.btnGenID.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnGenID.Location = New System.Drawing.Point(465, 150)
        Me.btnGenID.Name = "btnGenID"
        Me.btnGenID.Size = New System.Drawing.Size(88, 23)
        Me.btnGenID.TabIndex = 5
        Me.btnGenID.Text = "Gen S/N"
        Me.btnGenID.ToolTip = "Auto Gen S/N"
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
        Me.ControlNavigator1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.ControlNavigator1.CustomButtons.AddRange(New DevExpress.XtraEditors.NavigatorCustomButton() {New DevExpress.XtraEditors.NavigatorCustomButton(8, 0, True, True, "Remove", "Remove")})
        Me.ControlNavigator1.Location = New System.Drawing.Point(3, 411)
        Me.ControlNavigator1.Name = "ControlNavigator1"
        Me.ControlNavigator1.NavigatableControl = Me.GridControl1
        Me.ControlNavigator1.Size = New System.Drawing.Size(250, 24)
        Me.ControlNavigator1.TabIndex = 320
        Me.ControlNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
        '
        'SNType
        '
        Me.SNType.EditValue = "M"
        Me.SNType.EnterMoveNextControl = True
        Me.SNType.Location = New System.Drawing.Point(25, 115)
        Me.SNType.Name = "SNType"
        Me.SNType.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.SNType.Properties.Appearance.Options.UseBackColor = True
        Me.SNType.Properties.Columns = 1
        Me.SNType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("M", "ระบุ S/N"), New DevExpress.XtraEditors.Controls.RadioGroupItem("A", "สร้าง S/N อัตโนมัติ")})
        Me.SNType.Size = New System.Drawing.Size(121, 55)
        Me.SNType.TabIndex = 323
        '
        'StartNo
        '
        Me.StartNo.EnterMoveNextControl = True
        Me.StartNo.Location = New System.Drawing.Point(406, 150)
        Me.StartNo.Name = "StartNo"
        Me.StartNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartNo.Properties.Appearance.Options.UseFont = True
        Me.StartNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StartNo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.StartNo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.StartNo.Properties.Mask.EditMask = "n0"
        Me.StartNo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.StartNo.Properties.MaxLength = 10
        Me.StartNo.Properties.Precision = 0
        Me.StartNo.Size = New System.Drawing.Size(53, 20)
        Me.StartNo.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(406, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 14)
        Me.Label2.TabIndex = 336
        Me.Label2.Text = "เลขเริ่มต้น"
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
        'btnLoadSN
        '
        Me.btnLoadSN.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnLoadSN.Appearance.Options.UseFont = True
        Me.btnLoadSN.Image = CType(resources.GetObject("btnLoadSN.Image"), System.Drawing.Image)
        Me.btnLoadSN.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnLoadSN.Location = New System.Drawing.Point(465, 101)
        Me.btnLoadSN.Name = "btnLoadSN"
        Me.btnLoadSN.Size = New System.Drawing.Size(88, 23)
        Me.btnLoadSN.TabIndex = 337
        Me.btnLoadSN.Text = "Load S/N"
        Me.btnLoadSN.ToolTip = "Auto Gen S/N"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(250, 57)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl3.TabIndex = 338
        Me.LabelControl3.Text = "S/N ล่าสุด"
        '
        'SnLast
        '
        Me.SnLast.EditValue = ""
        Me.SnLast.EnterMoveNextControl = True
        Me.SnLast.Location = New System.Drawing.Point(305, 53)
        Me.SnLast.Name = "SnLast"
        Me.SnLast.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.SnLast.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SnLast.Properties.Appearance.Options.UseBackColor = True
        Me.SnLast.Properties.Appearance.Options.UseFont = True
        Me.SnLast.Properties.MaxLength = 50
        Me.SnLast.Properties.ReadOnly = True
        Me.SnLast.Properties.ValidateOnEnterKey = True
        Me.SnLast.Size = New System.Drawing.Size(217, 20)
        Me.SnLast.TabIndex = 339
        Me.SnLast.TabStop = False
        '
        'btnPrint
        '
        Me.btnPrint.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPrint.Appearance.Options.UseFont = True
        Me.btnPrint.Appearance.Options.UseImage = True
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnPrint.Location = New System.Drawing.Point(554, 11)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(82, 31)
        Me.btnPrint.TabIndex = 340
        Me.btnPrint.Text = "พิมพ์"
        Me.btnPrint.ToolTip = "พิมพ์บาร์โค้ด"
        '
        'lblProcode
        '
        Me.lblProcode.AutoSize = True
        Me.lblProcode.BackColor = System.Drawing.Color.Transparent
        Me.lblProcode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblProcode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblProcode.Location = New System.Drawing.Point(87, 8)
        Me.lblProcode.Name = "lblProcode"
        Me.lblProcode.Size = New System.Drawing.Size(100, 14)
        Me.lblProcode.TabIndex = 341
        Me.lblProcode.Text = "กรุณาระบุรหัสสินค้า"
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
        Me.Units.Size = New System.Drawing.Size(60, 20)
        Me.Units.TabIndex = 328
        Me.Units.TabStop = False
        '
        'btnFind
        '
        Me.btnFind.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnFind.Appearance.Options.UseFont = True
        Me.btnFind.Appearance.Options.UseImage = True
        Me.btnFind.Image = CType(resources.GetObject("btnFind.Image"), System.Drawing.Image)
        Me.btnFind.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnFind.Location = New System.Drawing.Point(213, 23)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(27, 24)
        Me.btnFind.TabIndex = 342
        Me.btnFind.TabStop = False
        Me.btnFind.ToolTip = "ค้นหา"
        '
        'btnSelectSN
        '
        Me.btnSelectSN.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSelectSN.Appearance.Options.UseFont = True
        Me.btnSelectSN.Image = CType(resources.GetObject("btnSelectSN.Image"), System.Drawing.Image)
        Me.btnSelectSN.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnSelectSN.Location = New System.Drawing.Point(465, 126)
        Me.btnSelectSN.Name = "btnSelectSN"
        Me.btnSelectSN.Size = New System.Drawing.Size(88, 23)
        Me.btnSelectSN.TabIndex = 343
        Me.btnSelectSN.Text = "Select S/N"
        Me.btnSelectSN.ToolTip = "Auto Gen S/N"
        '
        'UnitsMain
        '
        Me.UnitsMain.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UnitsMain.Location = New System.Drawing.Point(151, 53)
        Me.UnitsMain.Name = "UnitsMain"
        Me.UnitsMain.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.UnitsMain.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.UnitsMain.Properties.Appearance.Options.UseBackColor = True
        Me.UnitsMain.Properties.Appearance.Options.UseFont = True
        Me.UnitsMain.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.UnitsMain.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.UnitsMain.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.UnitsMain.Properties.MaxLength = 50
        Me.UnitsMain.Properties.ReadOnly = True
        Me.UnitsMain.Properties.ValidateOnEnterKey = True
        Me.UnitsMain.Size = New System.Drawing.Size(60, 20)
        Me.UnitsMain.TabIndex = 344
        Me.UnitsMain.TabStop = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(25, 85)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl4.TabIndex = 345
        Me.LabelControl4.Text = "หน่วย"
        '
        'UnitName
        '
        Me.UnitName.EditValue = ""
        Me.UnitName.EnterMoveNextControl = True
        Me.UnitName.Location = New System.Drawing.Point(86, 81)
        Me.UnitName.Name = "UnitName"
        Me.UnitName.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.UnitName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.UnitName.Properties.Appearance.Options.UseBackColor = True
        Me.UnitName.Properties.Appearance.Options.UseFont = True
        Me.UnitName.Properties.MaxLength = 50
        Me.UnitName.Properties.ReadOnly = True
        Me.UnitName.Properties.ValidateOnEnterKey = True
        Me.UnitName.Size = New System.Drawing.Size(60, 20)
        Me.UnitName.TabIndex = 346
        '
        'UnitMainName
        '
        Me.UnitMainName.EditValue = ""
        Me.UnitMainName.EnterMoveNextControl = True
        Me.UnitMainName.Location = New System.Drawing.Point(151, 81)
        Me.UnitMainName.Name = "UnitMainName"
        Me.UnitMainName.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.UnitMainName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.UnitMainName.Properties.Appearance.Options.UseBackColor = True
        Me.UnitMainName.Properties.Appearance.Options.UseFont = True
        Me.UnitMainName.Properties.MaxLength = 50
        Me.UnitMainName.Properties.ReadOnly = True
        Me.UnitMainName.Properties.ValidateOnEnterKey = True
        Me.UnitMainName.Size = New System.Drawing.Size(60, 20)
        Me.UnitMainName.TabIndex = 347
        '
        'frmSN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(647, 435)
        Me.Controls.Add(Me.UnitMainName)
        Me.Controls.Add(Me.UnitName)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.UnitsMain)
        Me.Controls.Add(Me.btnSelectSN)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.lblProcode)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.SnLast)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.btnLoadSN)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.StartNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.RunningCount)
        Me.Controls.Add(Me.FormatMidle)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.FormatFront)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.ProductName)
        Me.Controls.Add(Me.SNNo)
        Me.Controls.Add(Me.ProductCode)
        Me.Controls.Add(Me.btnGenID)
        Me.Controls.Add(Me.ControlNavigator1)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.SNType)
        Me.Controls.Add(Me.Units)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SerialNumber"
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RunningCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormatMidle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormatFront.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SNNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SNType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SnLast.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Units.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitsMain.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitMainName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents RunningCount As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents FormatMidle As DevExpress.XtraEditors.ComboBoxEdit
    Private WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents FormatFront As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SNNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnGenID As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ControlNavigator1 As DevExpress.XtraEditors.ControlNavigator
    Friend WithEvents SNType As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents StartNo As DevExpress.XtraEditors.CalcEdit
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents ProductName As DevExpress.XtraEditors.TextEdit
    Private WithEvents ProductCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLoadSN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Private WithEvents SnLast As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
    Private WithEvents lblProcode As System.Windows.Forms.Label
    Friend WithEvents Units As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents btnFind As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSelectSN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents IsDelete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UnitsMain As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Private WithEvents UnitName As DevExpress.XtraEditors.TextEdit
    Private WithEvents UnitMainName As DevExpress.XtraEditors.TextEdit
End Class
