<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTaxReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTaxReport))
        Me.OrderDate = New DevExpress.XtraEditors.DateEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OrderType = New DevExpress.XtraEditors.RadioGroup()
        Me.Label36 = New System.Windows.Forms.Label()
        CType(Me.OrderDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.OrderType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.OrderDate.Properties.DisplayFormat.FormatString = "MMMM/yyyy"
        Me.OrderDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.OrderDate.Properties.EditFormat.FormatString = "MMMM/yyyy"
        Me.OrderDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.OrderDate.Properties.Mask.EditMask = "MMMM/yyyy"
        Me.OrderDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.OrderDate.Size = New System.Drawing.Size(169, 20)
        Me.OrderDate.TabIndex = 4
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.OrderType)
        Me.GroupControl1.Controls.Add(Me.Label36)
        Me.GroupControl1.Controls.Add(Me.OrderDate)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 57)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(554, 169)
        Me.GroupControl1.TabIndex = 5
        Me.GroupControl1.Text = "เงื่อนไข"
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
        Me.OrderType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("S", "รายการขาย"), New DevExpress.XtraEditors.Controls.RadioGroupItem("B", "รายการซื้อ")})
        Me.OrderType.Size = New System.Drawing.Size(314, 26)
        Me.OrderType.TabIndex = 172
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label36.Location = New System.Drawing.Point(25, 44)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(100, 14)
        Me.Label36.TabIndex = 171
        Me.Label36.Text = "รายงานประจำเดือน"
        '
        'frmTaxReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(873, 616)
        Me.Controls.Add(Me.GroupControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTaxReport"
        Me.Text = "รายงานภาษี"
        Me.Controls.SetChildIndex(Me.GroupControl1, 0)
        CType(Me.OrderDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.OrderType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OrderDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Private WithEvents Label36 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OrderType As DevExpress.XtraEditors.RadioGroup

End Class
