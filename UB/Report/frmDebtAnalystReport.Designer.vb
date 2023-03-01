<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDebtAnalystReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDebtAnalystReport))
        Me.DateFrom = New DevExpress.XtraEditors.DateEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ReportType = New DevExpress.XtraEditors.RadioGroup()
        Me.chkInvoice = New DevExpress.XtraEditors.CheckEdit()
        Me.chkShiping = New DevExpress.XtraEditors.CheckEdit()
        Me.DateTo = New DevExpress.XtraEditors.DateEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblEmp = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.chkBorrow = New DevExpress.XtraEditors.CheckEdit()
        Me.DateAsOf = New DevExpress.XtraEditors.DateEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkRedue = New DevExpress.XtraEditors.CheckEdit()
        Me.chkAddCre = New DevExpress.XtraEditors.CheckEdit()
        Me.UcMoverItem1 = New UB.ucMoverItem()
        Me.chkInvoiceOnline = New DevExpress.XtraEditors.CheckEdit()
        Me.chkInvoiceAbb = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.DateFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkInvoice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkShiping.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkBorrow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateAsOf.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateAsOf.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkRedue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAddCre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkInvoiceOnline.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkInvoiceAbb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateFrom
        '
        Me.DateFrom.EditValue = New Date(2012, 4, 20, 0, 0, 0, 0)
        Me.DateFrom.EnterMoveNextControl = True
        Me.DateFrom.Location = New System.Drawing.Point(137, 148)
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
        Me.ReportType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, " วิเคราะห์ลูกหนี้"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "วิเคราะห์เจ้าหนี้")})
        Me.ReportType.Size = New System.Drawing.Size(502, 66)
        Me.ReportType.TabIndex = 197
        '
        'chkInvoice
        '
        Me.chkInvoice.EditValue = True
        Me.chkInvoice.Location = New System.Drawing.Point(137, 175)
        Me.chkInvoice.Name = "chkInvoice"
        Me.chkInvoice.Properties.Caption = "ใบกำกับภาษี"
        Me.chkInvoice.Size = New System.Drawing.Size(95, 20)
        Me.chkInvoice.TabIndex = 196
        '
        'chkShiping
        '
        Me.chkShiping.EditValue = True
        Me.chkShiping.Location = New System.Drawing.Point(508, 173)
        Me.chkShiping.Name = "chkShiping"
        Me.chkShiping.Properties.Caption = "ใบส่งของ"
        Me.chkShiping.Size = New System.Drawing.Size(131, 20)
        Me.chkShiping.TabIndex = 194
        '
        'DateTo
        '
        Me.DateTo.EditValue = New Date(2012, 4, 20, 0, 0, 0, 0)
        Me.DateTo.EnterMoveNextControl = True
        Me.DateTo.Location = New System.Drawing.Point(320, 148)
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
        Me.Label3.Location = New System.Drawing.Point(292, 151)
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
        Me.lblEmp.Location = New System.Drawing.Point(22, 238)
        Me.lblEmp.Name = "lblEmp"
        Me.lblEmp.Size = New System.Drawing.Size(73, 14)
        Me.lblEmp.TabIndex = 190
        Me.lblEmp.Text = "ลูกหนี้/เจ้าหนี้"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 14)
        Me.Label1.TabIndex = 173
        Me.Label1.Text = "รายการ"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label36.Location = New System.Drawing.Point(21, 151)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(66, 14)
        Me.Label36.TabIndex = 171
        Me.Label36.Text = "รายงานวันที่"
        '
        'chkBorrow
        '
        Me.chkBorrow.EditValue = True
        Me.chkBorrow.Location = New System.Drawing.Point(371, 200)
        Me.chkBorrow.Name = "chkBorrow"
        Me.chkBorrow.Properties.Caption = "ใบยืมสินค้า"
        Me.chkBorrow.Size = New System.Drawing.Size(152, 20)
        Me.chkBorrow.TabIndex = 209
        '
        'DateAsOf
        '
        Me.DateAsOf.EditValue = New Date(2012, 4, 20, 0, 0, 0, 0)
        Me.DateAsOf.EnterMoveNextControl = True
        Me.DateAsOf.Location = New System.Drawing.Point(137, 122)
        Me.DateAsOf.Name = "DateAsOf"
        Me.DateAsOf.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.DateAsOf.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DateAsOf.Properties.Appearance.Options.UseFont = True
        Me.DateAsOf.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateAsOf.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateAsOf.Properties.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.DateAsOf.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.DateAsOf.Properties.EditFormat.FormatString = "dd MMMM yyyy"
        Me.DateAsOf.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.DateAsOf.Properties.Mask.EditMask = "dd MMMM yyyy"
        Me.DateAsOf.Size = New System.Drawing.Size(149, 20)
        Me.DateAsOf.TabIndex = 210
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 14)
        Me.Label4.TabIndex = 211
        Me.Label4.Text = "วันแยกอายุหนี้"
        '
        'chkRedue
        '
        Me.chkRedue.EditValue = True
        Me.chkRedue.Location = New System.Drawing.Point(137, 200)
        Me.chkRedue.Name = "chkRedue"
        Me.chkRedue.Properties.Caption = "ใบลดหนี้"
        Me.chkRedue.Size = New System.Drawing.Size(128, 20)
        Me.chkRedue.TabIndex = 212
        '
        'chkAddCre
        '
        Me.chkAddCre.EditValue = True
        Me.chkAddCre.Location = New System.Drawing.Point(234, 200)
        Me.chkAddCre.Name = "chkAddCre"
        Me.chkAddCre.Properties.Caption = "ใบเพิ่มหนี้"
        Me.chkAddCre.Size = New System.Drawing.Size(78, 20)
        Me.chkAddCre.TabIndex = 213
        '
        'UcMoverItem1
        '
        Me.UcMoverItem1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UcMoverItem1.Location = New System.Drawing.Point(139, 238)
        Me.UcMoverItem1.Name = "UcMoverItem1"
        Me.UcMoverItem1.Size = New System.Drawing.Size(500, 199)
        Me.UcMoverItem1.TabIndex = 214
        '
        'chkInvoiceOnline
        '
        Me.chkInvoiceOnline.EditValue = True
        Me.chkInvoiceOnline.Location = New System.Drawing.Point(234, 175)
        Me.chkInvoiceOnline.Name = "chkInvoiceOnline"
        Me.chkInvoiceOnline.Properties.Caption = "ใบกำกับภาษีออนไลน์"
        Me.chkInvoiceOnline.Size = New System.Drawing.Size(131, 20)
        Me.chkInvoiceOnline.TabIndex = 215
        '
        'chkInvoiceAbb
        '
        Me.chkInvoiceAbb.EditValue = True
        Me.chkInvoiceAbb.Location = New System.Drawing.Point(371, 175)
        Me.chkInvoiceAbb.Name = "chkInvoiceAbb"
        Me.chkInvoiceAbb.Properties.Caption = "ใบกำกับภาษีอย่างย่อ"
        Me.chkInvoiceAbb.Size = New System.Drawing.Size(131, 20)
        Me.chkInvoiceAbb.TabIndex = 216
        '
        'frmDebtAnalystReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(889, 442)
        Me.Controls.Add(Me.chkInvoiceAbb)
        Me.Controls.Add(Me.chkInvoiceOnline)
        Me.Controls.Add(Me.UcMoverItem1)
        Me.Controls.Add(Me.chkAddCre)
        Me.Controls.Add(Me.chkRedue)
        Me.Controls.Add(Me.DateAsOf)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chkBorrow)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateFrom)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblEmp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTo)
        Me.Controls.Add(Me.chkShiping)
        Me.Controls.Add(Me.ReportType)
        Me.Controls.Add(Me.chkInvoice)
        Me.IconOptions.Icon = CType(resources.GetObject("frmDebtAnalystReport.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "frmDebtAnalystReport"
        Me.Text = "รายงานวิเคราะห์ยอดขาย"
        Me.Controls.SetChildIndex(Me.chkInvoice, 0)
        Me.Controls.SetChildIndex(Me.ReportType, 0)
        Me.Controls.SetChildIndex(Me.chkShiping, 0)
        Me.Controls.SetChildIndex(Me.DateTo, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.lblEmp, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label36, 0)
        Me.Controls.SetChildIndex(Me.DateFrom, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.chkBorrow, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.DateAsOf, 0)
        Me.Controls.SetChildIndex(Me.chkRedue, 0)
        Me.Controls.SetChildIndex(Me.chkAddCre, 0)
        Me.Controls.SetChildIndex(Me.UcMoverItem1, 0)
        Me.Controls.SetChildIndex(Me.chkInvoiceOnline, 0)
        Me.Controls.SetChildIndex(Me.chkInvoiceAbb, 0)
        CType(Me.DateFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkInvoice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkShiping.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkBorrow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateAsOf.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateAsOf.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkRedue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAddCre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkInvoiceOnline.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkInvoiceAbb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateFrom As DevExpress.XtraEditors.DateEdit
    Private WithEvents Label36 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents lblEmp As System.Windows.Forms.Label
    Friend WithEvents DateTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents chkInvoice As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkShiping As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ReportType As DevExpress.XtraEditors.RadioGroup
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkBorrow As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents DateAsOf As DevExpress.XtraEditors.DateEdit
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkRedue As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkAddCre As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents UcMoverItem1 As UB.ucMoverItem
    Friend WithEvents chkInvoiceOnline As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkInvoiceAbb As DevExpress.XtraEditors.CheckEdit
End Class
