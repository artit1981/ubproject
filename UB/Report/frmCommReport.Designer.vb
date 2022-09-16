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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ReportType = New DevExpress.XtraEditors.RadioGroup()
        Me.chkInvoice = New DevExpress.XtraEditors.CheckEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkShiping = New DevExpress.XtraEditors.CheckEdit()
        Me.DateTo = New DevExpress.XtraEditors.DateEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblEmp = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VatType = New DevExpress.XtraEditors.RadioGroup()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.UcMoverItem1 = New UB.ucMoverItem()
        Me.chkShowPO = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.DateFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkInvoice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkShiping.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VatType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkShowPO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateFrom.Properties.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.DateFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.DateFrom.Properties.EditFormat.FormatString = "dd MMMM yyyy"
        Me.DateFrom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.DateFrom.Properties.Mask.EditMask = "dd MMMM yyyy"
        Me.DateFrom.Size = New System.Drawing.Size(149, 20)
        Me.DateFrom.TabIndex = 4
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
        Me.ReportType.Size = New System.Drawing.Size(331, 66)
        Me.ReportType.TabIndex = 197
        '
        'chkInvoice
        '
        Me.chkInvoice.EditValue = True
        Me.chkInvoice.Location = New System.Drawing.Point(293, 149)
        Me.chkInvoice.Name = "chkInvoice"
        Me.chkInvoice.Properties.Caption = "ใบกำกับภาษี"
        Me.chkInvoice.Size = New System.Drawing.Size(175, 20)
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
        Me.chkShiping.Size = New System.Drawing.Size(152, 20)
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
        Me.DateTo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateTo.Properties.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.DateTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.DateTo.Properties.EditFormat.FormatString = "dd MMMM yyyy"
        Me.DateTo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.DateTo.Properties.Mask.EditMask = "dd MMMM yyyy"
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
        Me.VatType.Size = New System.Drawing.Size(500, 26)
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
        'UcMoverItem1
        '
        Me.UcMoverItem1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UcMoverItem1.Location = New System.Drawing.Point(137, 210)
        Me.UcMoverItem1.Name = "UcMoverItem1"
        Me.UcMoverItem1.Size = New System.Drawing.Size(500, 274)
        Me.UcMoverItem1.TabIndex = 199
        '
        'chkShowPO
        '
        Me.chkShowPO.Location = New System.Drawing.Point(462, 149)
        Me.chkShowPO.Name = "chkShowPO"
        Me.chkShowPO.Properties.Caption = "แสดงเลขใบสั่งซื้อ"
        Me.chkShowPO.Size = New System.Drawing.Size(175, 20)
        Me.chkShowPO.TabIndex = 200
        '
        'frmCommReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1112, 490)
        Me.Controls.Add(Me.chkShowPO)
        Me.Controls.Add(Me.UcMoverItem1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateFrom)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.VatType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblEmp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTo)
        Me.Controls.Add(Me.chkShiping)
        Me.Controls.Add(Me.ReportType)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chkInvoice)
        Me.IconOptions.Icon = CType(resources.GetObject("frmCommReport.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "frmCommReport"
        Me.Text = "รายงานวิเคราะห์ยอดขาย"
        Me.Controls.SetChildIndex(Me.chkInvoice, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.ReportType, 0)
        Me.Controls.SetChildIndex(Me.chkShiping, 0)
        Me.Controls.SetChildIndex(Me.DateTo, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.lblEmp, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.VatType, 0)
        Me.Controls.SetChildIndex(Me.Label36, 0)
        Me.Controls.SetChildIndex(Me.DateFrom, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.UcMoverItem1, 0)
        Me.Controls.SetChildIndex(Me.chkShowPO, 0)
        CType(Me.DateFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkInvoice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkShiping.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VatType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkShowPO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateFrom As DevExpress.XtraEditors.DateEdit
    Private WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents VatType As DevExpress.XtraEditors.RadioGroup
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents lblEmp As System.Windows.Forms.Label
    Friend WithEvents DateTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents chkInvoice As DevExpress.XtraEditors.CheckEdit
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkShiping As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ReportType As DevExpress.XtraEditors.RadioGroup
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents UcMoverItem1 As UB.ucMoverItem
    Friend WithEvents chkShowPO As DevExpress.XtraEditors.CheckEdit
End Class
