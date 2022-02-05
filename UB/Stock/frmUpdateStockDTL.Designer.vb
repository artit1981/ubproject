<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateStockDTL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdateStockDTL))
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.Units = New DevExpress.XtraEditors.SpinEdit()
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.ProductCode = New DevExpress.XtraEditors.TextEdit()
        Me.ProductName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtLocation = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.lblUnitName = New DevExpress.XtraEditors.LabelControl()
        Me.txtUnitName = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.btnSN = New DevExpress.XtraEditors.SimpleButton()
        Me.lblUpdateStr = New System.Windows.Forms.Label()
        Me.IsSumStock = New DevExpress.XtraEditors.CheckEdit()
        Me.SpinUnit = New DevExpress.XtraEditors.SpinEdit()
        Me.UnitMainName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.UnitRate = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UnitsMain = New DevExpress.XtraEditors.SpinEdit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Units.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnitName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.IsSumStock.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitMainName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitRate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitsMain.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection1.Images.SetKeyName(0, "_active__no.png")
        Me.ImageCollection1.Images.SetKeyName(1, "1394817194_stock_insert-slide.png")
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(268, 81)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(80, 14)
        Me.LabelControl2.TabIndex = 327
        Me.LabelControl2.Text = "จำนวน(ปัจจุบัน)"
        '
        'Units
        '
        Me.Units.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Units.Location = New System.Drawing.Point(367, 78)
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
        Me.Units.Size = New System.Drawing.Size(145, 20)
        Me.Units.TabIndex = 328
        Me.Units.TabStop = False
        '
        'btnOK
        '
        Me.btnOK.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnOK.Appearance.Options.UseFont = True
        Me.btnOK.Appearance.Options.UseImage = True
        Me.btnOK.DialogResult = DialogResult.OK
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
        Me.btnCancel.DialogResult = DialogResult.Cancel
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
        Me.ProductCode.Location = New System.Drawing.Point(95, 24)
        Me.ProductCode.Name = "ProductCode"
        Me.ProductCode.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.ProductCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ProductCode.Properties.Appearance.Options.UseBackColor = True
        Me.ProductCode.Properties.Appearance.Options.UseFont = True
        Me.ProductCode.Properties.MaxLength = 50
        Me.ProductCode.Properties.ReadOnly = True
        Me.ProductCode.Properties.ValidateOnEnterKey = True
        Me.ProductCode.Size = New System.Drawing.Size(116, 20)
        Me.ProductCode.TabIndex = 0
        '
        'ProductName
        '
        Me.ProductName.EditValue = ""
        Me.ProductName.EnterMoveNextControl = True
        Me.ProductName.Location = New System.Drawing.Point(217, 24)
        Me.ProductName.Name = "ProductName"
        Me.ProductName.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.ProductName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ProductName.Properties.Appearance.Options.UseBackColor = True
        Me.ProductName.Properties.Appearance.Options.UseFont = True
        Me.ProductName.Properties.MaxLength = 50
        Me.ProductName.Properties.ReadOnly = True
        Me.ProductName.Properties.ValidateOnEnterKey = True
        Me.ProductName.Size = New System.Drawing.Size(295, 20)
        Me.ProductName.TabIndex = 325
        Me.ProductName.TabStop = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(9, 28)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(27, 14)
        Me.LabelControl1.TabIndex = 326
        Me.LabelControl1.Text = "สินค้า"
        '
        'txtLocation
        '
        Me.txtLocation.EditValue = ""
        Me.txtLocation.EnterMoveNextControl = True
        Me.txtLocation.Location = New System.Drawing.Point(95, 52)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.txtLocation.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLocation.Properties.Appearance.Options.UseBackColor = True
        Me.txtLocation.Properties.Appearance.Options.UseFont = True
        Me.txtLocation.Properties.MaxLength = 50
        Me.txtLocation.Properties.ReadOnly = True
        Me.txtLocation.Properties.ValidateOnEnterKey = True
        Me.txtLocation.Size = New System.Drawing.Size(417, 20)
        Me.txtLocation.TabIndex = 329
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(9, 55)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(39, 14)
        Me.LabelControl3.TabIndex = 330
        Me.LabelControl3.Text = "คลังเก็บ"
        '
        'lblUnitName
        '
        Me.lblUnitName.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitName.Location = New System.Drawing.Point(9, 81)
        Me.lblUnitName.Name = "lblUnitName"
        Me.lblUnitName.Size = New System.Drawing.Size(43, 14)
        Me.lblUnitName.TabIndex = 331
        Me.lblUnitName.Text = "หน่วยนับ"
        '
        'txtUnitName
        '
        Me.txtUnitName.EditValue = ""
        Me.txtUnitName.EnterMoveNextControl = True
        Me.txtUnitName.Location = New System.Drawing.Point(95, 78)
        Me.txtUnitName.Name = "txtUnitName"
        Me.txtUnitName.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.txtUnitName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUnitName.Properties.Appearance.Options.UseBackColor = True
        Me.txtUnitName.Properties.Appearance.Options.UseFont = True
        Me.txtUnitName.Properties.MaxLength = 50
        Me.txtUnitName.Properties.ReadOnly = True
        Me.txtUnitName.Properties.ValidateOnEnterKey = True
        Me.txtUnitName.Size = New System.Drawing.Size(145, 20)
        Me.txtUnitName.TabIndex = 332
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.Appearance.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.UnitsMain)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.UnitRate)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.UnitMainName)
        Me.GroupControl1.Controls.Add(Me.ProductCode)
        Me.GroupControl1.Controls.Add(Me.txtUnitName)
        Me.GroupControl1.Controls.Add(Me.Units)
        Me.GroupControl1.Controls.Add(Me.lblUnitName)
        Me.GroupControl1.Controls.Add(Me.ProductName)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txtLocation)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(525, 163)
        Me.GroupControl1.TabIndex = 333
        Me.GroupControl1.Text = " "
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.Label3)
        Me.GroupControl2.Controls.Add(Me.Label2)
        Me.GroupControl2.Controls.Add(Me.Label1)
        Me.GroupControl2.Controls.Add(Me.LabelControl4)
        Me.GroupControl2.Controls.Add(Me.btnSN)
        Me.GroupControl2.Controls.Add(Me.lblUpdateStr)
        Me.GroupControl2.Controls.Add(Me.IsSumStock)
        Me.GroupControl2.Controls.Add(Me.SpinUnit)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 181)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(525, 142)
        Me.GroupControl2.TabIndex = 334
        Me.GroupControl2.Text = " "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(265, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 14)
        Me.Label1.TabIndex = 329
        Me.Label1.Text = "(สามารถใส่เป็นเลขติดลบได้)"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(9, 39)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(74, 14)
        Me.LabelControl4.TabIndex = 328
        Me.LabelControl4.Text = "จำนวน เพิ่ม/ลด"
        '
        'btnSN
        '
        Me.btnSN.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSN.Appearance.Options.UseFont = True
        Me.btnSN.Appearance.Options.UseImage = True
        Me.btnSN.Image = CType(resources.GetObject("btnSN.Image"), System.Drawing.Image)
        Me.btnSN.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnSN.Location = New System.Drawing.Point(95, 97)
        Me.btnSN.Name = "btnSN"
        Me.btnSN.Size = New System.Drawing.Size(136, 35)
        Me.btnSN.TabIndex = 291
        Me.btnSN.Text = "Serial Number"
        Me.btnSN.ToolTip = "Serial number"
        '
        'lblUpdateStr
        '
        Me.lblUpdateStr.AutoSize = True
        Me.lblUpdateStr.BackColor = System.Drawing.Color.Transparent
        Me.lblUpdateStr.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblUpdateStr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblUpdateStr.Location = New System.Drawing.Point(246, 39)
        Me.lblUpdateStr.Name = "lblUpdateStr"
        Me.lblUpdateStr.Size = New System.Drawing.Size(274, 14)
        Me.lblUpdateStr.TabIndex = 290
        Me.lblUpdateStr.Text = "- จำนวณสินค้าจะถูกเพิ่ม หรือลด ตามจำนวณสินค้าที่ระบุ"
        '
        'IsSumStock
        '
        Me.IsSumStock.EnterMoveNextControl = True
        Me.IsSumStock.Location = New System.Drawing.Point(93, 63)
        Me.IsSumStock.Name = "IsSumStock"
        Me.IsSumStock.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsSumStock.Properties.Appearance.Options.UseFont = True
        Me.IsSumStock.Properties.Caption = "ปรับคลังรวม"
        Me.IsSumStock.Size = New System.Drawing.Size(92, 19)
        Me.IsSumStock.TabIndex = 289
        Me.IsSumStock.TabStop = False
        '
        'SpinUnit
        '
        Me.SpinUnit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinUnit.Location = New System.Drawing.Point(95, 37)
        Me.SpinUnit.Name = "SpinUnit"
        Me.SpinUnit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.SpinUnit.Size = New System.Drawing.Size(100, 20)
        Me.SpinUnit.TabIndex = 1
        '
        'UnitMainName
        '
        Me.UnitMainName.EditValue = ""
        Me.UnitMainName.EnterMoveNextControl = True
        Me.UnitMainName.Location = New System.Drawing.Point(95, 104)
        Me.UnitMainName.Name = "UnitMainName"
        Me.UnitMainName.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.UnitMainName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.UnitMainName.Properties.Appearance.Options.UseBackColor = True
        Me.UnitMainName.Properties.Appearance.Options.UseFont = True
        Me.UnitMainName.Properties.MaxLength = 50
        Me.UnitMainName.Properties.ReadOnly = True
        Me.UnitMainName.Properties.ValidateOnEnterKey = True
        Me.UnitMainName.Size = New System.Drawing.Size(145, 20)
        Me.UnitMainName.TabIndex = 333
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(9, 107)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(50, 14)
        Me.LabelControl5.TabIndex = 334
        Me.LabelControl5.Text = "หน่วยหลัก"
        '
        'UnitRate
        '
        Me.UnitRate.EditValue = ""
        Me.UnitRate.EnterMoveNextControl = True
        Me.UnitRate.Location = New System.Drawing.Point(95, 130)
        Me.UnitRate.Name = "UnitRate"
        Me.UnitRate.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.UnitRate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.UnitRate.Properties.Appearance.Options.UseBackColor = True
        Me.UnitRate.Properties.Appearance.Options.UseFont = True
        Me.UnitRate.Properties.MaxLength = 50
        Me.UnitRate.Properties.ReadOnly = True
        Me.UnitRate.Properties.ValidateOnEnterKey = True
        Me.UnitRate.Size = New System.Drawing.Size(145, 20)
        Me.UnitRate.TabIndex = 335
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(9, 133)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(45, 14)
        Me.LabelControl6.TabIndex = 336
        Me.LabelControl6.Text = "อัตราส่วน"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(268, 133)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(93, 14)
        Me.LabelControl7.TabIndex = 338
        Me.LabelControl7.Text = "จำนวน(หน่วยหลัก)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(246, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(218, 14)
        Me.Label2.TabIndex = 330
        Me.Label2.Text = "- กรณี update หน่วยย่อย ระบบจะ update"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(265, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 14)
        Me.Label3.TabIndex = 331
        Me.Label3.Text = "หน่วยหลักให้อัตโนมัติเสมอ"
        '
        'UnitsMain
        '
        Me.UnitsMain.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UnitsMain.Location = New System.Drawing.Point(367, 130)
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
        Me.UnitsMain.Size = New System.Drawing.Size(145, 20)
        Me.UnitsMain.TabIndex = 339
        Me.UnitsMain.TabStop = False
        '
        'frmUpdateStockDTL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(644, 315)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUpdateStockDTL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Update Stock"
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Units.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnitName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.IsSumStock.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitMainName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitRate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitsMain.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Units As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Private WithEvents ProductCode As DevExpress.XtraEditors.TextEdit
    Private WithEvents ProductName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Private WithEvents txtLocation As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblUnitName As DevExpress.XtraEditors.LabelControl
    Private WithEvents txtUnitName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SpinUnit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents IsSumStock As DevExpress.XtraEditors.CheckEdit
    Private WithEvents lblUpdateStr As System.Windows.Forms.Label
    Friend WithEvents btnSN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents UnitMainName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Private WithEvents UnitRate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents UnitsMain As DevExpress.XtraEditors.SpinEdit
End Class
