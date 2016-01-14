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
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.btnSN = New DevExpress.XtraEditors.SimpleButton()
        Me.lblUpdateStr = New System.Windows.Forms.Label()
        Me.IsSumStock = New DevExpress.XtraEditors.CheckEdit()
        Me.SpinUnit = New DevExpress.XtraEditors.SpinEdit()
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
        Me.LabelControl2.Location = New System.Drawing.Point(9, 82)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(80, 14)
        Me.LabelControl2.TabIndex = 327
        Me.LabelControl2.Text = "จำนวน(ปัจจุบัน)"
        '
        'Units
        '
        Me.Units.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Units.Location = New System.Drawing.Point(95, 78)
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
        Me.Units.Size = New System.Drawing.Size(116, 20)
        Me.Units.TabIndex = 328
        Me.Units.TabStop = False
        '
        'btnOK
        '
        Me.btnOK.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnOK.Appearance.Options.UseFont = True
        Me.btnOK.Appearance.Options.UseImage = True
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
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
        Me.txtLocation.Size = New System.Drawing.Size(172, 20)
        Me.txtLocation.TabIndex = 329
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(9, 59)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(39, 14)
        Me.LabelControl3.TabIndex = 330
        Me.LabelControl3.Text = "คลังเก็บ"
        '
        'lblUnitName
        '
        Me.lblUnitName.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitName.Location = New System.Drawing.Point(286, 56)
        Me.lblUnitName.Name = "lblUnitName"
        Me.lblUnitName.Size = New System.Drawing.Size(43, 14)
        Me.lblUnitName.TabIndex = 331
        Me.lblUnitName.Text = "หน่วยนับ"
        '
        'txtUnitName
        '
        Me.txtUnitName.EditValue = ""
        Me.txtUnitName.EnterMoveNextControl = True
        Me.txtUnitName.Location = New System.Drawing.Point(331, 52)
        Me.txtUnitName.Name = "txtUnitName"
        Me.txtUnitName.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.txtUnitName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUnitName.Properties.Appearance.Options.UseBackColor = True
        Me.txtUnitName.Properties.Appearance.Options.UseFont = True
        Me.txtUnitName.Properties.MaxLength = 50
        Me.txtUnitName.Properties.ReadOnly = True
        Me.txtUnitName.Properties.ValidateOnEnterKey = True
        Me.txtUnitName.Size = New System.Drawing.Size(181, 20)
        Me.txtUnitName.TabIndex = 332
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.Appearance.Options.UseFont = True
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
        Me.GroupControl1.Size = New System.Drawing.Size(525, 124)
        Me.GroupControl1.TabIndex = 333
        Me.GroupControl1.Text = "GroupControl1"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.LabelControl4)
        Me.GroupControl2.Controls.Add(Me.btnSN)
        Me.GroupControl2.Controls.Add(Me.lblUpdateStr)
        Me.GroupControl2.Controls.Add(Me.IsSumStock)
        Me.GroupControl2.Controls.Add(Me.SpinUnit)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 151)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(525, 147)
        Me.GroupControl2.TabIndex = 334
        Me.GroupControl2.Text = "GroupControl2"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(30, 50)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(80, 14)
        Me.LabelControl4.TabIndex = 328
        Me.LabelControl4.Text = "จำนวน(ปัจจุบัน)"
        '
        'btnSN
        '
        Me.btnSN.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSN.Appearance.Options.UseFont = True
        Me.btnSN.Appearance.Options.UseImage = True
        Me.btnSN.Image = CType(resources.GetObject("btnSN.Image"), System.Drawing.Image)
        Me.btnSN.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnSN.Location = New System.Drawing.Point(167, 113)
        Me.btnSN.Name = "btnSN"
        Me.btnSN.Size = New System.Drawing.Size(82, 31)
        Me.btnSN.TabIndex = 291
        Me.btnSN.Text = "ตกลง"
        Me.btnSN.ToolTip = "ตกลง"
        '
        'lblUpdateStr
        '
        Me.lblUpdateStr.AutoSize = True
        Me.lblUpdateStr.BackColor = System.Drawing.Color.Transparent
        Me.lblUpdateStr.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblUpdateStr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblUpdateStr.Location = New System.Drawing.Point(273, 54)
        Me.lblUpdateStr.Name = "lblUpdateStr"
        Me.lblUpdateStr.Size = New System.Drawing.Size(409, 14)
        Me.lblUpdateStr.TabIndex = 290
        Me.lblUpdateStr.Text = "จำนวณสินค้าจะถูกเพิ่ม หรือลด ตามจำนวณสินค้าที่ระบุ (สามารถใส่เป็นเลขติดลบได้)"
        '
        'IsSumStock
        '
        Me.IsSumStock.EnterMoveNextControl = True
        Me.IsSumStock.Location = New System.Drawing.Point(18, 123)
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
        Me.SpinUnit.Location = New System.Drawing.Point(167, 48)
        Me.SpinUnit.Name = "SpinUnit"
        Me.SpinUnit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.SpinUnit.Size = New System.Drawing.Size(100, 20)
        Me.SpinUnit.TabIndex = 1
        '
        'frmUpdateStockDTL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(648, 435)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmUpdateStockDTL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SerialNumber"
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
End Class
