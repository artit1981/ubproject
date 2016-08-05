<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.txtLogin = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPassword = New DevExpress.XtraEditors.TextEdit()
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.DBServerName = New DevExpress.XtraEditors.TextEdit()
        Me.DatabaseName = New DevExpress.XtraEditors.TextEdit()
        Me.chSetup = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.NavBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
        Me.NavBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroupControlContainer1 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDBPass = New DevExpress.XtraEditors.TextEdit()
        Me.txtDBUser = New DevExpress.XtraEditors.TextEdit()
        Me.txtResult = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        CType(Me.txtLogin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBServerName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chSetup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavBarControl1.SuspendLayout()
        Me.NavBarGroupControlContainer1.SuspendLayout()
        CType(Me.txtDBPass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDBUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtResult.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtLogin
        '
        Me.txtLogin.EnterMoveNextControl = True
        Me.txtLogin.Location = New System.Drawing.Point(118, 28)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogin.Properties.Appearance.Options.UseFont = True
        Me.txtLogin.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Red
        Me.txtLogin.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtLogin.Properties.MaxLength = 50
        Me.txtLogin.Size = New System.Drawing.Size(180, 20)
        Me.txtLogin.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(33, 31)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(58, 14)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "ชื่อเข้าระบบ"
        '
        'txtPassword
        '
        Me.txtPassword.EnterMoveNextControl = True
        Me.txtPassword.Location = New System.Drawing.Point(118, 66)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Properties.Appearance.Options.UseFont = True
        Me.txtPassword.Properties.MaxLength = 50
        Me.txtPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(180, 20)
        Me.txtPassword.TabIndex = 1
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(118, 105)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(199, 105)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        '
        'DBServerName
        '
        Me.DBServerName.EnterMoveNextControl = True
        Me.DBServerName.Location = New System.Drawing.Point(102, 9)
        Me.DBServerName.Name = "DBServerName"
        Me.DBServerName.Size = New System.Drawing.Size(180, 20)
        Me.DBServerName.TabIndex = 1
        '
        'DatabaseName
        '
        Me.DatabaseName.EnterMoveNextControl = True
        Me.DatabaseName.Location = New System.Drawing.Point(102, 31)
        Me.DatabaseName.Name = "DatabaseName"
        Me.DatabaseName.Size = New System.Drawing.Size(180, 20)
        Me.DatabaseName.TabIndex = 8
        '
        'chSetup
        '
        Me.chSetup.Location = New System.Drawing.Point(31, 129)
        Me.chSetup.Name = "chSetup"
        Me.chSetup.Properties.Caption = "Setup Connection"
        Me.chSetup.Size = New System.Drawing.Size(129, 19)
        Me.chSetup.TabIndex = 7
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(33, 69)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(40, 14)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "รหัสผ่าน"
        '
        'NavBarControl1
        '
        Me.NavBarControl1.ActiveGroup = Me.NavBarGroup1
        Me.NavBarControl1.Controls.Add(Me.NavBarGroupControlContainer1)
        Me.NavBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavBarGroup1})
        Me.NavBarControl1.Location = New System.Drawing.Point(12, 154)
        Me.NavBarControl1.Name = "NavBarControl1"
        Me.NavBarControl1.OptionsNavPane.ExpandedWidth = 225
        Me.NavBarControl1.Size = New System.Drawing.Size(316, 188)
        Me.NavBarControl1.TabIndex = 6
        Me.NavBarControl1.Text = "NavBarControl1"
        '
        'NavBarGroup1
        '
        Me.NavBarGroup1.Caption = ""
        Me.NavBarGroup1.ControlContainer = Me.NavBarGroupControlContainer1
        Me.NavBarGroup1.Expanded = True
        Me.NavBarGroup1.GroupClientHeight = 153
        Me.NavBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.NavBarGroup1.Name = "NavBarGroup1"
        '
        'NavBarGroupControlContainer1
        '
        Me.NavBarGroupControlContainer1.Controls.Add(Me.LabelControl6)
        Me.NavBarGroupControlContainer1.Controls.Add(Me.LabelControl5)
        Me.NavBarGroupControlContainer1.Controls.Add(Me.txtDBPass)
        Me.NavBarGroupControlContainer1.Controls.Add(Me.txtDBUser)
        Me.NavBarGroupControlContainer1.Controls.Add(Me.txtResult)
        Me.NavBarGroupControlContainer1.Controls.Add(Me.DatabaseName)
        Me.NavBarGroupControlContainer1.Controls.Add(Me.LabelControl4)
        Me.NavBarGroupControlContainer1.Controls.Add(Me.LabelControl3)
        Me.NavBarGroupControlContainer1.Controls.Add(Me.DBServerName)
        Me.NavBarGroupControlContainer1.Name = "NavBarGroupControlContainer1"
        Me.NavBarGroupControlContainer1.Size = New System.Drawing.Size(308, 146)
        Me.NavBarGroupControlContainer1.TabIndex = 0
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(17, 78)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl6.TabIndex = 14
        Me.LabelControl6.Text = "DB Pass"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(17, 56)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl5.TabIndex = 13
        Me.LabelControl5.Text = "DB User"
        '
        'txtDBPass
        '
        Me.txtDBPass.EnterMoveNextControl = True
        Me.txtDBPass.Location = New System.Drawing.Point(102, 75)
        Me.txtDBPass.Name = "txtDBPass"
        Me.txtDBPass.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtDBPass.Size = New System.Drawing.Size(180, 20)
        Me.txtDBPass.TabIndex = 12
        '
        'txtDBUser
        '
        Me.txtDBUser.EnterMoveNextControl = True
        Me.txtDBUser.Location = New System.Drawing.Point(102, 53)
        Me.txtDBUser.Name = "txtDBUser"
        Me.txtDBUser.Size = New System.Drawing.Size(180, 20)
        Me.txtDBUser.TabIndex = 11
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(17, 99)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtResult.Properties.Appearance.Options.UseBackColor = True
        Me.txtResult.Properties.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(265, 44)
        Me.txtResult.TabIndex = 10
        Me.txtResult.TabStop = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(17, 34)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl4.TabIndex = 7
        Me.LabelControl4.Text = "Database"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(17, 12)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "Server Name"
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(342, 315)
        Me.Controls.Add(Me.chSetup)
        Me.Controls.Add(Me.NavBarControl1)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.txtLogin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBServerName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chSetup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavBarControl1.ResumeLayout(False)
        Me.NavBarGroupControlContainer1.ResumeLayout(False)
        Me.NavBarGroupControlContainer1.PerformLayout()
        CType(Me.txtDBPass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDBUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtResult.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLogin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl

    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents NavBarControl1 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NavBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroupControlContainer1 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents DBServerName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DatabaseName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chSetup As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtResult As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDBPass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDBUser As DevExpress.XtraEditors.TextEdit
End Class
