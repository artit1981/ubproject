<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDealReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDealReport))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OrderType2 = New DevExpress.XtraEditors.RadioGroup()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OrderType = New DevExpress.XtraEditors.RadioGroup()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.OrderDate = New DevExpress.XtraEditors.DateEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.OrderType2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.OrderType2)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.OrderType)
        Me.GroupControl1.Controls.Add(Me.Label36)
        Me.GroupControl1.Controls.Add(Me.OrderDate)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 57)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(554, 261)
        Me.GroupControl1.TabIndex = 5
        Me.GroupControl1.Text = "เงื่อนไข"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(47, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(379, 14)
        Me.Label2.TabIndex = 175
        Me.Label2.Text = "- แสดงรายการใบกำกับภาษีของปีก่อนหน้า ที่ได้ระบุในช่อง ""รายงานประชำปี"""
        '
        'OrderType2
        '
        Me.OrderType2.EditValue = "S"
        Me.OrderType2.EnterMoveNextControl = True
        Me.OrderType2.Location = New System.Drawing.Point(131, 129)
        Me.OrderType2.Name = "OrderType2"
        Me.OrderType2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderType2.Properties.Appearance.Options.UseFont = True
        Me.OrderType2.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("S", "รายการชำระ"), New DevExpress.XtraEditors.Controls.RadioGroupItem("B", "รายการค้างชำระ")})
        Me.OrderType2.Size = New System.Drawing.Size(218, 50)
        Me.OrderType2.TabIndex = 174
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 14)
        Me.Label1.TabIndex = 173
        Me.Label1.Text = "ประเภทรายงาน"
        '
        'OrderType
        '
        Me.OrderType.EditValue = "S"
        Me.OrderType.EnterMoveNextControl = True
        Me.OrderType.Location = New System.Drawing.Point(131, 73)
        Me.OrderType.Name = "OrderType"
        Me.OrderType.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderType.Properties.Appearance.Options.UseFont = True
        Me.OrderType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("S", "รายการขาย"), New DevExpress.XtraEditors.Controls.RadioGroupItem("B", "รายการซื้อ")})
        Me.OrderType.Size = New System.Drawing.Size(218, 50)
        Me.OrderType.TabIndex = 172
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label36.Location = New System.Drawing.Point(25, 44)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(83, 14)
        Me.Label36.TabIndex = 171
        Me.Label36.Text = "รายงานประจำปี"
        '
        'OrderDate
        '
        Me.OrderDate.EditValue = New Date(2012, 4, 20, 0, 0, 0, 0)
        Me.OrderDate.EnterMoveNextControl = True
        Me.OrderDate.Location = New System.Drawing.Point(131, 41)
        Me.OrderDate.Name = "OrderDate"
        Me.OrderDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.OrderDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.OrderDate.Properties.Appearance.Options.UseFont = True
        Me.OrderDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrderDate.Properties.DisplayFormat.FormatString = "yyyy"
        Me.OrderDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.OrderDate.Properties.EditFormat.FormatString = "yyyy"
        Me.OrderDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.OrderDate.Properties.Mask.EditMask = "yyyy"
        Me.OrderDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.OrderDate.Size = New System.Drawing.Size(169, 20)
        Me.OrderDate.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(47, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 14)
        Me.Label3.TabIndex = 176
        Me.Label3.Text = "- แสดงรายการใบกำกับภาษีที่มี Vat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(25, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 14)
        Me.Label4.TabIndex = 177
        Me.Label4.Text = "*** เงื่อนไขการแสดงรายงาน"
        '
        'frmDealReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(873, 616)
        Me.Controls.Add(Me.GroupControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDealReport"
        Me.Text = "รายงานการรับ/จ่ายชำระหนี้"
        Me.Controls.SetChildIndex(Me.GroupControl1, 0)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.OrderType2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Private WithEvents Label36 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OrderType As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents OrderDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents OrderType2 As DevExpress.XtraEditors.RadioGroup
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label

End Class
