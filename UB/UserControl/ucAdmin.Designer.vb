<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucAdmin
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
        Me.CheckInAcive = New DevExpress.XtraEditors.CheckEdit()
        Me.txtModifiTime = New DevExpress.XtraEditors.TextEdit()
        Me.txtCreateTime = New DevExpress.XtraEditors.TextEdit()
        Me.txtModifiBy = New DevExpress.XtraEditors.TextEdit()
        Me.txtCreateBy = New DevExpress.XtraEditors.TextEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()

        CType(Me.CheckInAcive.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtModifiTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCreateTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtModifiBy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCreateBy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckInAcive
        '

        Me.CheckInAcive.Location = New System.Drawing.Point(114, 159)
        Me.CheckInAcive.Name = "CheckInAcive"
        Me.CheckInAcive.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckInAcive.Properties.Appearance.Options.UseFont = True
        Me.CheckInAcive.Properties.Caption = "ระงับการใช้งาน"
        Me.CheckInAcive.Size = New System.Drawing.Size(108, 19)
        Me.CheckInAcive.TabIndex = 4
        '
        'txtModifiTime
        '
        Me.txtModifiTime.EditValue = ""
        Me.txtModifiTime.EnterMoveNextControl = True

        Me.txtModifiTime.Location = New System.Drawing.Point(429, 108)
        Me.txtModifiTime.Name = "txtModifiTime"
        Me.txtModifiTime.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.txtModifiTime.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtModifiTime.Properties.Appearance.Options.UseBackColor = True
        Me.txtModifiTime.Properties.Appearance.Options.UseFont = True
        Me.txtModifiTime.Properties.MaxLength = 50
        Me.txtModifiTime.Properties.ReadOnly = True
        Me.txtModifiTime.Properties.ValidateOnEnterKey = True
        Me.txtModifiTime.Size = New System.Drawing.Size(189, 21)
        Me.txtModifiTime.TabIndex = 3
        '
        'txtCreateTime
        '
        Me.txtCreateTime.EditValue = ""
        Me.txtCreateTime.EnterMoveNextControl = True

        Me.txtCreateTime.Location = New System.Drawing.Point(429, 69)
        Me.txtCreateTime.Name = "txtCreateTime"
        Me.txtCreateTime.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.txtCreateTime.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCreateTime.Properties.Appearance.Options.UseBackColor = True
        Me.txtCreateTime.Properties.Appearance.Options.UseFont = True
        Me.txtCreateTime.Properties.MaxLength = 50
        Me.txtCreateTime.Properties.ReadOnly = True
        Me.txtCreateTime.Properties.ValidateOnEnterKey = True
        Me.txtCreateTime.Size = New System.Drawing.Size(189, 21)
        Me.txtCreateTime.TabIndex = 1
        '
        'txtModifiBy
        '
        Me.txtModifiBy.EditValue = ""
        Me.txtModifiBy.EnterMoveNextControl = True

        Me.txtModifiBy.Location = New System.Drawing.Point(116, 112)
        Me.txtModifiBy.Name = "txtModifiBy"
        Me.txtModifiBy.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.txtModifiBy.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtModifiBy.Properties.Appearance.Options.UseBackColor = True
        Me.txtModifiBy.Properties.Appearance.Options.UseFont = True
        Me.txtModifiBy.Properties.MaxLength = 50
        Me.txtModifiBy.Properties.ReadOnly = True
        Me.txtModifiBy.Properties.ValidateOnEnterKey = True
        Me.txtModifiBy.Size = New System.Drawing.Size(189, 21)
        Me.txtModifiBy.TabIndex = 2
        '
        'txtCreateBy
        '
        Me.txtCreateBy.EditValue = ""
        Me.txtCreateBy.EnterMoveNextControl = True

        Me.txtCreateBy.Location = New System.Drawing.Point(116, 69)
        Me.txtCreateBy.Name = "txtCreateBy"
        Me.txtCreateBy.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.txtCreateBy.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCreateBy.Properties.Appearance.Options.UseBackColor = True
        Me.txtCreateBy.Properties.Appearance.Options.UseFont = True
        Me.txtCreateBy.Properties.MaxLength = 50
        Me.txtCreateBy.Properties.ReadOnly = True
        Me.txtCreateBy.Properties.ValidateOnEnterKey = True
        Me.txtCreateBy.Size = New System.Drawing.Size(189, 21)
        Me.txtCreateBy.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(367, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 14)
        Me.Label7.TabIndex = 173
        Me.Label7.Text = "แก้ไขเมื่อ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 14)
        Me.Label3.TabIndex = 172
        Me.Label3.Text = "แก้ไขล่าสุดโดย"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(367, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 14)
        Me.Label2.TabIndex = 171
        Me.Label2.Text = "สร้างเมื่อ"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label36.Location = New System.Drawing.Point(19, 72)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(38, 14)
        Me.Label36.TabIndex = 170
        Me.Label36.Text = "ผู้สร้าง"
        '
        '
        'ucAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CheckInAcive)
        Me.Controls.Add(Me.txtModifiTime)
        Me.Controls.Add(Me.txtCreateTime)
        Me.Controls.Add(Me.txtModifiBy)
        Me.Controls.Add(Me.txtCreateBy)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label36)
        Me.Name = "ucAdmin"
        Me.Size = New System.Drawing.Size(665, 223)
        CType(Me.CheckInAcive.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtModifiTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCreateTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtModifiBy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCreateBy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckInAcive As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtModifiTime As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCreateTime As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtModifiBy As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCreateBy As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Label36 As System.Windows.Forms.Label


End Class
