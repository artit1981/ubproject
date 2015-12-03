<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProgress
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
        Me.progressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
        Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.progressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'progressBarControl1
        '
        Me.progressBarControl1.Location = New System.Drawing.Point(24, 41)
        Me.progressBarControl1.Name = "progressBarControl1"
        Me.progressBarControl1.Properties.ShowTitle = True
        Me.progressBarControl1.Size = New System.Drawing.Size(429, 17)
        Me.progressBarControl1.TabIndex = 1
        '
        'labelControl1
        '
        Me.labelControl1.AllowHtmlString = True
        Me.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.labelControl1.Location = New System.Drawing.Point(24, 12)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.Size = New System.Drawing.Size(49, 14)
        Me.labelControl1.TabIndex = 2
        Me.labelControl1.Text = "Loading..."
        '
        'frmProgress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 80)
        Me.Controls.Add(Me.labelControl1)
        Me.Controls.Add(Me.progressBarControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProgress"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmProgress"
        CType(Me.progressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents progressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
    Private WithEvents labelControl1 As DevExpress.XtraEditors.LabelControl
End Class
