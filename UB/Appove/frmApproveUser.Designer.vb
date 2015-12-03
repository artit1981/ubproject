<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmApproveUser
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
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.GeneralTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcApproveUser1 = New ucApproveUser()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.UcApproveUser2 = New ucApproveUser()
        Me.NoteTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcNote1 = New ucNote()
        Me.AttachmentTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcFileAttach1 = New ucFileAttach()
        Me.AdminTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcAdmin1 = New ucAdmin()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.GeneralTabPage.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.NoteTabPage.SuspendLayout()
        Me.AttachmentTabPage.SuspendLayout()
        Me.AdminTabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 37)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.GeneralTabPage
        Me.XtraTabControl1.Size = New System.Drawing.Size(911, 404)
        Me.XtraTabControl1.TabIndex = 15
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.GeneralTabPage, Me.XtraTabPage1, Me.NoteTabPage, Me.AttachmentTabPage, Me.AdminTabPage})
        '
        'GeneralTabPage
        '
        Me.GeneralTabPage.Appearance.PageClient.BackColor = System.Drawing.Color.LightGray
        Me.GeneralTabPage.Appearance.PageClient.Options.UseBackColor = True
        Me.GeneralTabPage.AutoScroll = True
        Me.GeneralTabPage.Controls.Add(Me.UcApproveUser1)
        Me.GeneralTabPage.Name = "GeneralTabPage"
        Me.GeneralTabPage.Size = New System.Drawing.Size(905, 378)
        Me.GeneralTabPage.Text = "อนุมัติเอกสาร"
        '
        'UcApproveUser1
        '
        Me.UcApproveUser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcApproveUser1.Location = New System.Drawing.Point(0, 0)
        Me.UcApproveUser1.Name = "UcApproveUser1"
        Me.UcApproveUser1.Size = New System.Drawing.Size(905, 378)
        Me.UcApproveUser1.TabIndex = 0
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.UcApproveUser2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(905, 564)
        Me.XtraTabPage1.Text = "อนุมัติวงเงิน"
        '
        'UcApproveUser2
        '
        Me.UcApproveUser2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcApproveUser2.Location = New System.Drawing.Point(0, 0)
        Me.UcApproveUser2.Name = "UcApproveUser2"
        Me.UcApproveUser2.Size = New System.Drawing.Size(905, 564)
        Me.UcApproveUser2.TabIndex = 0
        '
        'NoteTabPage
        '
        Me.NoteTabPage.Controls.Add(Me.UcNote1)
        Me.NoteTabPage.Name = "NoteTabPage"
        Me.NoteTabPage.Size = New System.Drawing.Size(905, 564)
        Me.NoteTabPage.Text = "บันทึกข้อความ"
        '
        'UcNote1
        '
        Me.UcNote1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcNote1.Location = New System.Drawing.Point(0, 0)
        Me.UcNote1.Name = "UcNote1"
        Me.UcNote1.Size = New System.Drawing.Size(905, 564)
        Me.UcNote1.TabIndex = 0
        '
        'AttachmentTabPage
        '
        Me.AttachmentTabPage.Controls.Add(Me.UcFileAttach1)
        Me.AttachmentTabPage.Name = "AttachmentTabPage"
        Me.AttachmentTabPage.Size = New System.Drawing.Size(905, 564)
        Me.AttachmentTabPage.Text = "ไฟล์แนบ"
        '
        'UcFileAttach1
        '
        Me.UcFileAttach1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcFileAttach1.Location = New System.Drawing.Point(0, 0)
        Me.UcFileAttach1.Name = "UcFileAttach1"
        Me.UcFileAttach1.Size = New System.Drawing.Size(905, 564)
        Me.UcFileAttach1.TabIndex = 0
        '
        'AdminTabPage
        '
        Me.AdminTabPage.Controls.Add(Me.UcAdmin1)
        Me.AdminTabPage.Name = "AdminTabPage"
        Me.AdminTabPage.Size = New System.Drawing.Size(905, 564)
        Me.AdminTabPage.Text = "ผู้บันทึก"
        '
        'UcAdmin1
        '
        Me.UcAdmin1.Location = New System.Drawing.Point(71, 0)
        Me.UcAdmin1.Name = "UcAdmin1"
        Me.UcAdmin1.Size = New System.Drawing.Size(665, 223)
        Me.UcAdmin1.TabIndex = 0
        '
        'frmApproveUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 441)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frmApproveUser"
        Me.Text = "ผู้อนุมัติ"
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.GeneralTabPage.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.NoteTabPage.ResumeLayout(False)
        Me.AttachmentTabPage.ResumeLayout(False)
        Me.AdminTabPage.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents GeneralTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents NoteTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcNote1 As ucNote
    Friend WithEvents AttachmentTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcFileAttach1 As ucFileAttach
    Friend WithEvents AdminTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcAdmin1 As ucAdmin
    Friend WithEvents UcApproveUser1 As ucApproveUser
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcApproveUser2 As ucApproveUser
End Class
