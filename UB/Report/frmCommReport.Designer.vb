<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCommReport
    Inherits iReport

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCommReport))
        Me.DateFrom = New DevExpress.XtraEditors.DateEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkSelectAllPro = New DevExpress.XtraEditors.CheckEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Product = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ProductBrandID = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.ProductTypeID = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkSelectAll = New DevExpress.XtraEditors.CheckEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ReportType = New DevExpress.XtraEditors.RadioGroup()
        Me.chkInvoice = New DevExpress.XtraEditors.CheckEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkShiping = New DevExpress.XtraEditors.CheckEdit()
        Me.DateTo = New DevExpress.XtraEditors.DateEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblEmp = New System.Windows.Forms.Label()
        Me.Employee = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VatType = New DevExpress.XtraEditors.RadioGroup()
        Me.Label36 = New System.Windows.Forms.Label()
        CType(Me.DateFrom.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSelectAllPro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBrandID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductTypeID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSelectAll.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkInvoice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkShiping.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Employee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VatType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateFrom
        '
        Me.DateFrom.EditValue = New Date(2012, 4, 20, 0, 0, 0, 0)
        Me.DateFrom.EnterMoveNextControl = True
        Me.DateFrom.Location = New System.Drawing.Point(137, 123)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.DateFrom.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DateFrom.Properties.Appearance.Options.UseFont = True
        Me.DateFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateFrom.Properties.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.DateFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.DateFrom.Properties.EditFormat.FormatString = "dd MMMM yyyy"
        Me.DateFrom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.DateFrom.Properties.Mask.EditMask = "dd MMMM yyyy"
        Me.DateFrom.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateFrom.Size = New System.Drawing.Size(149, 20)
        Me.DateFrom.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(528, 509)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 14)
        Me.Label9.TabIndex = 208
        Me.Label9.Text = "Select /Unselect All"
        '
        'chkSelectAllPro
        '
        Me.chkSelectAllPro.Location = New System.Drawing.Point(529, 526)
        Me.chkSelectAllPro.Name = "chkSelectAllPro"
        Me.chkSelectAllPro.Properties.Caption = ""
        Me.chkSelectAllPro.Size = New System.Drawing.Size(48, 19)
        Me.chkSelectAllPro.TabIndex = 207
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(22, 509)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 14)
        Me.Label8.TabIndex = 206
        Me.Label8.Text = "สินค้า"
        '
        'Product
        '
        Me.Product.Location = New System.Drawing.Point(137, 509)
        Me.Product.Name = "Product"
        Me.Product.Size = New System.Drawing.Size(377, 140)
        Me.Product.TabIndex = 205
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(330, 382)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 14)
        Me.Label6.TabIndex = 204
        Me.Label6.Text = "ยี่ห้อสินค้า"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(134, 382)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 14)
        Me.Label7.TabIndex = 203
        Me.Label7.Text = "ประเภทสินค้า"
        '
        'ProductBrandID
        '
        Me.ProductBrandID.Location = New System.Drawing.Point(333, 399)
        Me.ProductBrandID.Name = "ProductBrandID"
        Me.ProductBrandID.Size = New System.Drawing.Size(181, 104)
        Me.ProductBrandID.TabIndex = 202
        '
        'ProductTypeID
        '
        Me.ProductTypeID.Location = New System.Drawing.Point(137, 399)
        Me.ProductTypeID.Name = "ProductTypeID"
        Me.ProductTypeID.Size = New System.Drawing.Size(181, 104)
        Me.ProductTypeID.TabIndex = 201
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(528, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 14)
        Me.Label5.TabIndex = 200
        Me.Label5.Text = "Select /Unselect All"
        '
        'chkSelectAll
        '
        Me.chkSelectAll.Location = New System.Drawing.Point(528, 241)
        Me.chkSelectAll.Name = "chkSelectAll"
        Me.chkSelectAll.Properties.Caption = ""
        Me.chkSelectAll.Size = New System.Drawing.Size(48, 19)
        Me.chkSelectAll.TabIndex = 199
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 14)
        Me.Label2.TabIndex = 198
        Me.Label2.Text = "ประเภทรายงาน"
        '
        'ReportType
        '
        Me.ReportType.EditValue = 1
        Me.ReportType.EnterMoveNextControl = True
        Me.ReportType.Location = New System.Drawing.Point(137, 43)
        Me.ReportType.Name = "ReportType"
        Me.ReportType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "วิเคราะห์ยอดขายแยกตามลูกค้า"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "วิเคราะห์ยอดขายแยกตามพนักงานขาย")})
        Me.ReportType.Size = New System.Drawing.Size(377, 66)
        Me.ReportType.TabIndex = 197
        '
        'chkInvoice
        '
        Me.chkInvoice.EditValue = True
        Me.chkInvoice.Location = New System.Drawing.Point(293, 149)
        Me.chkInvoice.Name = "chkInvoice"
        Me.chkInvoice.Properties.Caption = "ใบกำกับภาษี"
        Me.chkInvoice.Size = New System.Drawing.Size(175, 19)
        Me.chkInvoice.TabIndex = 196
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 14)
        Me.Label4.TabIndex = 195
        Me.Label4.Text = "การคำนวณคอมมิชชัน"
        '
        'chkShiping
        '
        Me.chkShiping.EditValue = True
        Me.chkShiping.Location = New System.Drawing.Point(135, 149)
        Me.chkShiping.Name = "chkShiping"
        Me.chkShiping.Properties.Caption = "ใบส่งของ"
        Me.chkShiping.Size = New System.Drawing.Size(152, 19)
        Me.chkShiping.TabIndex = 194
        '
        'DateTo
        '
        Me.DateTo.EditValue = New Date(2012, 4, 20, 0, 0, 0, 0)
        Me.DateTo.EnterMoveNextControl = True
        Me.DateTo.Location = New System.Drawing.Point(320, 123)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.DateTo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DateTo.Properties.Appearance.Options.UseFont = True
        Me.DateTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateTo.Properties.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.DateTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.DateTo.Properties.EditFormat.FormatString = "dd MMMM yyyy"
        Me.DateTo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.DateTo.Properties.Mask.EditMask = "dd MMMM yyyy"
        Me.DateTo.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateTo.Size = New System.Drawing.Size(148, 20)
        Me.DateTo.TabIndex = 193
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(292, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 14)
        Me.Label3.TabIndex = 192
        Me.Label3.Text = "ถึง"
        '
        'lblEmp
        '
        Me.lblEmp.AutoSize = True
        Me.lblEmp.BackColor = System.Drawing.Color.Transparent
        Me.lblEmp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblEmp.Location = New System.Drawing.Point(22, 224)
        Me.lblEmp.Name = "lblEmp"
        Me.lblEmp.Size = New System.Drawing.Size(67, 14)
        Me.lblEmp.TabIndex = 190
        Me.lblEmp.Text = "พนักงานขาย"
        '
        'Employee
        '
        Me.Employee.CheckOnClick = True
        Me.Employee.Location = New System.Drawing.Point(137, 223)
        Me.Employee.Name = "Employee"
        Me.Employee.Size = New System.Drawing.Size(377, 148)
        Me.Employee.TabIndex = 189
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 14)
        Me.Label1.TabIndex = 173
        Me.Label1.Text = "รายการ"
        '
        'VatType
        '
        Me.VatType.EditValue = "E"
        Me.VatType.EnterMoveNextControl = True
        Me.VatType.Location = New System.Drawing.Point(137, 178)
        Me.VatType.Name = "VatType"
        Me.VatType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("E", "ยอดขายไม่รวม Vat"), New DevExpress.XtraEditors.Controls.RadioGroupItem("I", "ยอดขายรวม Vat")})
        Me.VatType.Size = New System.Drawing.Size(377, 26)
        Me.VatType.TabIndex = 172
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label36.Location = New System.Drawing.Point(21, 126)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(66, 14)
        Me.Label36.TabIndex = 171
        Me.Label36.Text = "รายงานวันที่"
        '
        'frmCommReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1112, 742)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.chkSelectAllPro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DateFrom)
        Me.Controls.Add(Me.Product)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.VatType)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProductBrandID)
        Me.Controls.Add(Me.Employee)
        Me.Controls.Add(Me.ProductTypeID)
        Me.Controls.Add(Me.lblEmp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chkSelectAll)
        Me.Controls.Add(Me.DateTo)
        Me.Controls.Add(Me.chkShiping)
        Me.Controls.Add(Me.ReportType)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chkInvoice)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCommReport"
        Me.Text = "รายงานวิเคราะห์ยอดขาย"
        Me.Controls.SetChildIndex(Me.chkInvoice, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.ReportType, 0)
        Me.Controls.SetChildIndex(Me.chkShiping, 0)
        Me.Controls.SetChildIndex(Me.DateTo, 0)
        Me.Controls.SetChildIndex(Me.chkSelectAll, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.lblEmp, 0)
        Me.Controls.SetChildIndex(Me.ProductTypeID, 0)
        Me.Controls.SetChildIndex(Me.Employee, 0)
        Me.Controls.SetChildIndex(Me.ProductBrandID, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.VatType, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label36, 0)
        Me.Controls.SetChildIndex(Me.Product, 0)
        Me.Controls.SetChildIndex(Me.DateFrom, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.chkSelectAllPro, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        CType(Me.DateFrom.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSelectAllPro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBrandID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductTypeID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSelectAll.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkInvoice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkShiping.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Employee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VatType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateFrom As DevExpress.XtraEditors.DateEdit
    Private WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents VatType As DevExpress.XtraEditors.RadioGroup
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents lblEmp As System.Windows.Forms.Label
    Friend WithEvents Employee As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents DateTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents chkInvoice As DevExpress.XtraEditors.CheckEdit
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkShiping As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ReportType As DevExpress.XtraEditors.RadioGroup
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkSelectAll As DevExpress.XtraEditors.CheckEdit
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ProductBrandID As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents ProductTypeID As DevExpress.XtraEditors.CheckedListBoxControl
    Private WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chkSelectAllPro As DevExpress.XtraEditors.CheckEdit
    Private WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Product As DevExpress.XtraEditors.CheckedListBoxControl

End Class
