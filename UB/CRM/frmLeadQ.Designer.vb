<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLeadQ
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLeadQ))
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.Email1 = New DevExpress.XtraEditors.TextEdit()
        Me.Phone1 = New DevExpress.XtraEditors.TextEdit()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txtCOMPANYNAME = New DevExpress.XtraEditors.TextEdit()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboLeadType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtLASTNAME = New DevExpress.XtraEditors.TextEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboRating = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnRefreshLeadType = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRefreshTitle = New DevExpress.XtraEditors.SimpleButton()
        Me.txtFIRSTNAME = New DevExpress.XtraEditors.TextEdit()
        Me.cboTITLE = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtSUBJECT = New DevExpress.XtraEditors.TextEdit()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()

        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.Email1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Phone1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCOMPANYNAME.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLeadType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLASTNAME.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRating.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFIRSTNAME.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTITLE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSUBJECT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(4, 5)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage2
        Me.XtraTabControl1.Size = New System.Drawing.Size(470, 312)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage2})
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.Email1)
        Me.XtraTabPage2.Controls.Add(Me.Phone1)
        Me.XtraTabPage2.Controls.Add(Me.Label48)
        Me.XtraTabPage2.Controls.Add(Me.Label47)
        Me.XtraTabPage2.Controls.Add(Me.txtCOMPANYNAME)
        Me.XtraTabPage2.Controls.Add(Me.Label11)
        Me.XtraTabPage2.Controls.Add(Me.cboLeadType)
        Me.XtraTabPage2.Controls.Add(Me.txtLASTNAME)
        Me.XtraTabPage2.Controls.Add(Me.Label9)
        Me.XtraTabPage2.Controls.Add(Me.cboRating)
        Me.XtraTabPage2.Controls.Add(Me.btnRefreshLeadType)
        Me.XtraTabPage2.Controls.Add(Me.btnRefreshTitle)
        Me.XtraTabPage2.Controls.Add(Me.txtFIRSTNAME)
        Me.XtraTabPage2.Controls.Add(Me.cboTITLE)
        Me.XtraTabPage2.Controls.Add(Me.txtSUBJECT)
        Me.XtraTabPage2.Controls.Add(Me.Label16)
        Me.XtraTabPage2.Controls.Add(Me.Label12)
        Me.XtraTabPage2.Controls.Add(Me.Label8)
        Me.XtraTabPage2.Controls.Add(Me.Label4)
        Me.XtraTabPage2.Controls.Add(Me.Label6)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(464, 286)
        Me.XtraTabPage2.Text = "Quick Create"
        '
        'Email1
        '
        Me.Email1.EditValue = ""
        Me.Email1.EnterMoveNextControl = True
        Me.Email1.Location = New System.Drawing.Point(129, 186)
        Me.Email1.Name = "Email1"
        Me.Email1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Email1.Properties.Appearance.Options.UseFont = True
        Me.Email1.Properties.MaxLength = 50
        Me.Email1.Properties.ValidateOnEnterKey = True
        Me.Email1.Size = New System.Drawing.Size(286, 21)
        Me.Email1.TabIndex = 6
        '
        'Phone1
        '
        Me.Phone1.EditValue = ""
        Me.Phone1.EnterMoveNextControl = True
        Me.Phone1.Location = New System.Drawing.Point(129, 159)
        Me.Phone1.Name = "Phone1"
        Me.Phone1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Phone1.Properties.Appearance.Options.UseFont = True
        Me.Phone1.Properties.MaxLength = 50
        Me.Phone1.Properties.ValidateOnEnterKey = True
        Me.Phone1.Size = New System.Drawing.Size(286, 21)
        Me.Phone1.TabIndex = 5
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.BackColor = System.Drawing.Color.Transparent
        Me.Label48.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label48.Location = New System.Drawing.Point(27, 189)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(32, 14)
        Me.Label48.TabIndex = 247
        Me.Label48.Text = "อีเมล์"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.BackColor = System.Drawing.Color.Transparent
        Me.Label47.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label47.Location = New System.Drawing.Point(27, 162)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(74, 14)
        Me.Label47.TabIndex = 245
        Me.Label47.Text = "เบอร์โทรศัพท์"
        '
        'txtCOMPANYNAME
        '
        Me.txtCOMPANYNAME.EditValue = ""
        Me.txtCOMPANYNAME.EnterMoveNextControl = True
        Me.txtCOMPANYNAME.Location = New System.Drawing.Point(129, 132)
        Me.txtCOMPANYNAME.Name = "txtCOMPANYNAME"
        Me.txtCOMPANYNAME.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCOMPANYNAME.Properties.Appearance.Options.UseFont = True
        Me.txtCOMPANYNAME.Properties.MaxLength = 50
        Me.txtCOMPANYNAME.Properties.ValidateOnEnterKey = True
        Me.txtCOMPANYNAME.Size = New System.Drawing.Size(286, 21)
        Me.txtCOMPANYNAME.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(27, 135)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 14)
        Me.Label11.TabIndex = 153
        Me.Label11.Text = "ชื่อบริษัท"
        '
        'cboLeadType
        '
        Me.cboLeadType.EnterMoveNextControl = True
        Me.cboLeadType.Location = New System.Drawing.Point(129, 212)
        Me.cboLeadType.Name = "cboLeadType"
        Me.cboLeadType.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboLeadType.Properties.Appearance.Options.UseFont = True
        Me.cboLeadType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboLeadType.Properties.ImmediatePopup = True
        Me.cboLeadType.Properties.UseCtrlScroll = True
        Me.cboLeadType.Properties.ValidateOnEnterKey = True
        Me.cboLeadType.Size = New System.Drawing.Size(286, 21)
        Me.cboLeadType.TabIndex = 7
        '
        'txtLASTNAME
        '
        Me.txtLASTNAME.EditValue = ""
        Me.txtLASTNAME.EnterMoveNextControl = True
        Me.txtLASTNAME.Location = New System.Drawing.Point(129, 105)
        Me.txtLASTNAME.Name = "txtLASTNAME"
        Me.txtLASTNAME.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLASTNAME.Properties.Appearance.Options.UseFont = True
        Me.txtLASTNAME.Properties.MaxLength = 50
        Me.txtLASTNAME.Properties.ValidateOnEnterKey = True
        Me.txtLASTNAME.Size = New System.Drawing.Size(286, 21)
        Me.txtLASTNAME.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(27, 108)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 14)
        Me.Label9.TabIndex = 151
        Me.Label9.Text = "นามสกุล"
        '
        'cboRating
        '
        Me.cboRating.EditValue = "Nomal"
        Me.cboRating.EnterMoveNextControl = True

        Me.cboRating.Location = New System.Drawing.Point(129, 239)
        Me.cboRating.Name = "cboRating"
        Me.cboRating.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboRating.Properties.Appearance.Options.UseFont = True
        Me.cboRating.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRating.Properties.ImmediatePopup = True
        Me.cboRating.Properties.Items.AddRange(New Object() {"Hot", "Nomal", "Low"})
        Me.cboRating.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboRating.Properties.UseCtrlScroll = True
        Me.cboRating.Size = New System.Drawing.Size(286, 21)
        Me.cboRating.TabIndex = 8
        '
        'btnRefreshLeadType
        '
        Me.btnRefreshLeadType.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRefreshLeadType.Appearance.Options.UseFont = True

        Me.btnRefreshLeadType.Image = CType(resources.GetObject("btnRefreshLeadType.Image"), System.Drawing.Image)
        Me.btnRefreshLeadType.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefreshLeadType.Location = New System.Drawing.Point(417, 212)
        Me.btnRefreshLeadType.Name = "btnRefreshLeadType"
        Me.btnRefreshLeadType.Size = New System.Drawing.Size(21, 21)
        Me.btnRefreshLeadType.TabIndex = 150
        Me.btnRefreshLeadType.TabStop = False
        Me.btnRefreshLeadType.ToolTip = "Refresh"
        '
        'btnRefreshTitle
        '
        Me.btnRefreshTitle.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRefreshTitle.Appearance.Options.UseFont = True

        Me.btnRefreshTitle.Image = CType(resources.GetObject("btnRefreshTitle.Image"), System.Drawing.Image)
        Me.btnRefreshTitle.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefreshTitle.Location = New System.Drawing.Point(417, 51)
        Me.btnRefreshTitle.Name = "btnRefreshTitle"
        Me.btnRefreshTitle.Size = New System.Drawing.Size(21, 21)
        Me.btnRefreshTitle.TabIndex = 149
        Me.btnRefreshTitle.TabStop = False
        Me.btnRefreshTitle.ToolTip = "Refresh"
        '
        'txtFIRSTNAME
        '
        Me.txtFIRSTNAME.EditValue = ""
        Me.txtFIRSTNAME.EnterMoveNextControl = True

        Me.txtFIRSTNAME.Location = New System.Drawing.Point(129, 78)
        Me.txtFIRSTNAME.Name = "txtFIRSTNAME"
        Me.txtFIRSTNAME.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtFIRSTNAME.Properties.Appearance.Options.UseFont = True
        Me.txtFIRSTNAME.Properties.MaxLength = 50
        Me.txtFIRSTNAME.Properties.ValidateOnEnterKey = True
        Me.txtFIRSTNAME.Size = New System.Drawing.Size(286, 21)
        Me.txtFIRSTNAME.TabIndex = 2
        '
        'cboTITLE
        '
        Me.cboTITLE.EnterMoveNextControl = True

        Me.cboTITLE.Location = New System.Drawing.Point(129, 51)
        Me.cboTITLE.Name = "cboTITLE"
        Me.cboTITLE.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboTITLE.Properties.Appearance.Options.UseFont = True
        Me.cboTITLE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTITLE.Properties.ImmediatePopup = True
        Me.cboTITLE.Properties.UseCtrlScroll = True
        Me.cboTITLE.Properties.ValidateOnEnterKey = True
        Me.cboTITLE.Size = New System.Drawing.Size(286, 21)
        Me.cboTITLE.TabIndex = 1
        '
        'txtSUBJECT
        '
        Me.txtSUBJECT.EditValue = ""
        Me.txtSUBJECT.EnterMoveNextControl = True

        Me.txtSUBJECT.Location = New System.Drawing.Point(129, 24)
        Me.txtSUBJECT.Name = "txtSUBJECT"
        Me.txtSUBJECT.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSUBJECT.Properties.Appearance.Options.UseFont = True
        Me.txtSUBJECT.Properties.MaxLength = 100
        Me.txtSUBJECT.Properties.ValidateOnEnterKey = True
        Me.txtSUBJECT.Size = New System.Drawing.Size(286, 21)
        Me.txtSUBJECT.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(27, 242)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 14)
        Me.Label16.TabIndex = 148
        Me.Label16.Text = "ระดับความสนใจ"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(27, 215)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 14)
        Me.Label12.TabIndex = 147
        Me.Label12.Text = "ประเภทการเพิ่ม"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(27, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 14)
        Me.Label8.TabIndex = 146
        Me.Label8.Text = "ชื่อ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(27, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 14)
        Me.Label4.TabIndex = 145
        Me.Label4.Text = "หัวเรื่อง"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 14)
        Me.Label6.TabIndex = 144
        Me.Label6.Text = "คำนำหน้า"
        '
        'btnOK
        '

        Me.btnOK.Location = New System.Drawing.Point(285, 335)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 9
        Me.btnOK.Text = "OK"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(394, 335)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        '
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'frmLeadQ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 377)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLeadQ"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmLeadQ"
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.Email1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Phone1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCOMPANYNAME.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLeadType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLASTNAME.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRating.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFIRSTNAME.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTITLE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSUBJECT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboLeadType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtLASTNAME As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboRating As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnRefreshLeadType As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRefreshTitle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFIRSTNAME As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboTITLE As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtSUBJECT As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label16 As System.Windows.Forms.Label
    Private WithEvents Label12 As System.Windows.Forms.Label
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCOMPANYNAME As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label11 As System.Windows.Forms.Label
    Private WithEvents Email1 As DevExpress.XtraEditors.TextEdit
    Private WithEvents Phone1 As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label48 As System.Windows.Forms.Label
    Private WithEvents Label47 As System.Windows.Forms.Label

    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
End Class
