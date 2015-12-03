<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucSWOT
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.OPPORTUNITY = New DevExpress.XtraEditors.MemoEdit()
        Me.THREAT = New DevExpress.XtraEditors.MemoEdit()
        Me.WEAKNESS = New DevExpress.XtraEditors.MemoEdit()
        Me.STRENGTH = New DevExpress.XtraEditors.MemoEdit()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.OVERVIEW = New DevExpress.XtraEditors.MemoEdit()

        CType(Me.OPPORTUNITY.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.THREAT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WEAKNESS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STRENGTH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OVERVIEW.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OPPORTUNITY
        '
        Me.OPPORTUNITY.EditValue = ""
        Me.OPPORTUNITY.Location = New System.Drawing.Point(116, 290)
        Me.OPPORTUNITY.Name = "OPPORTUNITY"
        Me.OPPORTUNITY.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPPORTUNITY.Properties.Appearance.Options.UseFont = True
        Me.OPPORTUNITY.Properties.MaxLength = 500
        Me.OPPORTUNITY.Size = New System.Drawing.Size(570, 80)
        Me.OPPORTUNITY.TabIndex = 3
        '
        'THREAT
        '
        Me.THREAT.EditValue = ""
        Me.THREAT.Location = New System.Drawing.Point(116, 376)
        Me.THREAT.Name = "THREAT"
        Me.THREAT.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.THREAT.Properties.Appearance.Options.UseFont = True
        Me.THREAT.Properties.MaxLength = 500
        Me.THREAT.Size = New System.Drawing.Size(570, 80)
        Me.THREAT.TabIndex = 4
        '
        'WEAKNESS
        '
        Me.WEAKNESS.EditValue = ""
        Me.WEAKNESS.Location = New System.Drawing.Point(116, 204)
        Me.WEAKNESS.Name = "WEAKNESS"
        Me.WEAKNESS.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WEAKNESS.Properties.Appearance.Options.UseFont = True
        Me.WEAKNESS.Properties.MaxLength = 500
        Me.WEAKNESS.Size = New System.Drawing.Size(570, 80)
        Me.WEAKNESS.TabIndex = 2
        '
        'STRENGTH
        '
        Me.STRENGTH.EditValue = ""
        Me.STRENGTH.Location = New System.Drawing.Point(116, 118)
        Me.STRENGTH.Name = "STRENGTH"
        Me.STRENGTH.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STRENGTH.Properties.Appearance.Options.UseFont = True
        Me.STRENGTH.Properties.MaxLength = 500
        Me.STRENGTH.Size = New System.Drawing.Size(570, 80)
        Me.STRENGTH.TabIndex = 1
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.BackColor = System.Drawing.Color.Transparent
        Me.Label59.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.Location = New System.Drawing.Point(36, 293)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(40, 14)
        Me.Label59.TabIndex = 153
        Me.Label59.Text = "โอกาศ"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.BackColor = System.Drawing.Color.Transparent
        Me.Label58.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(36, 379)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(46, 14)
        Me.Label58.TabIndex = 152
        Me.Label58.Text = "อุปสรรค"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.BackColor = System.Drawing.Color.Transparent
        Me.Label57.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.Location = New System.Drawing.Point(36, 207)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(42, 14)
        Me.Label57.TabIndex = 151
        Me.Label57.Text = "จุดอ่อน"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.BackColor = System.Drawing.Color.Transparent
        Me.Label56.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(36, 121)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(41, 14)
        Me.Label56.TabIndex = 150
        Me.Label56.Text = "จุดแข็ง"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.BackColor = System.Drawing.Color.Transparent
        Me.Label55.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(36, 35)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(64, 14)
        Me.Label55.TabIndex = 149
        Me.Label55.Text = "ข้อมูลทั่วไป"
        '
        'OVERVIEW
        '
        Me.OVERVIEW.EditValue = ""

        Me.OVERVIEW.Location = New System.Drawing.Point(116, 32)
        Me.OVERVIEW.Name = "OVERVIEW"
        Me.OVERVIEW.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OVERVIEW.Properties.Appearance.Options.UseFont = True
        Me.OVERVIEW.Properties.MaxLength = 500
        Me.OVERVIEW.Size = New System.Drawing.Size(570, 80)
        Me.OVERVIEW.TabIndex = 0
        '
        'ucSWOT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.OPPORTUNITY)
        Me.Controls.Add(Me.THREAT)
        Me.Controls.Add(Me.WEAKNESS)
        Me.Controls.Add(Me.STRENGTH)
        Me.Controls.Add(Me.Label59)
        Me.Controls.Add(Me.Label58)
        Me.Controls.Add(Me.Label57)
        Me.Controls.Add(Me.Label56)
        Me.Controls.Add(Me.Label55)
        Me.Controls.Add(Me.OVERVIEW)
        Me.Name = "ucSWOT"
        Me.Size = New System.Drawing.Size(807, 488)
        CType(Me.OPPORTUNITY.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.THREAT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WEAKNESS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STRENGTH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OVERVIEW.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OPPORTUNITY As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents THREAT As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents WEAKNESS As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents STRENGTH As DevExpress.XtraEditors.MemoEdit
    Private WithEvents Label59 As System.Windows.Forms.Label
    Private WithEvents Label58 As System.Windows.Forms.Label
    Private WithEvents Label57 As System.Windows.Forms.Label
    Private WithEvents Label56 As System.Windows.Forms.Label
    Private WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents OVERVIEW As DevExpress.XtraEditors.MemoEdit


End Class
