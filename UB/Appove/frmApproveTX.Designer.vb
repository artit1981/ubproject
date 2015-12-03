<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmApproveTX
    Inherits iEditForm

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
        Me.UcApproveTX1 = New ucApproveTX()
        Me.SuspendLayout()
        '
        'UcApproveTX1
        '
        Me.UcApproveTX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcApproveTX1.Location = New System.Drawing.Point(0, 0)
        Me.UcApproveTX1.Name = "UcApproveTX1"
        Me.UcApproveTX1.Size = New System.Drawing.Size(905, 489)
        Me.UcApproveTX1.TabIndex = 0
        '
        'frmApproveTX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 489)
        Me.Controls.Add(Me.UcApproveTX1)
        Me.Name = "frmApproveTX"
        Me.Text = "frmApproveTX"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcApproveTX1 As ucApproveTX
End Class
