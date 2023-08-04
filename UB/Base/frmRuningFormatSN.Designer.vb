<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRuningFormatSN
    Inherits iEditForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRuningFormatSN))
        Me.FormatFront = New DevExpress.XtraEditors.TextEdit()
        Me.RunningCount = New DevExpress.XtraEditors.CalcEdit()
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.GeneralTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.chkIsReset = New DevExpress.XtraEditors.CheckEdit()
        Me.FormatYear = New DevExpress.XtraEditors.RadioGroup()
        Me.lblExam = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AdminTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcAdmin1 = New UB.ucAdmin()
        Me.FormChangedComponent1 = New UB.FormChangedComponent(Me.components)
        Me.FormatDate = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FormatMidle = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.FormatFront.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RunningCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.GeneralTabPage.SuspendLayout()
        CType(Me.chkIsReset.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormatYear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AdminTabPage.SuspendLayout()
        CType(Me.FormatDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormatMidle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormatFront
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.FormatFront, "TextChanged")
        Me.FormatFront.EditValue = "รหัสจากหน้าสินค้า"
        Me.FormatFront.EnterMoveNextControl = True
        Me.FormatFront.Location = New System.Drawing.Point(147, 42)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.FormatFront, True)
        Me.FormatFront.Name = "FormatFront"
        Me.FormatFront.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FormatFront.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormatFront.Properties.Appearance.Options.UseBackColor = True
        Me.FormatFront.Properties.Appearance.Options.UseFont = True
        Me.FormatFront.Properties.MaxLength = 50
        Me.FormatFront.Properties.ReadOnly = True
        Me.FormatFront.Properties.ValidateOnEnterKey = True
        Me.FormatFront.Size = New System.Drawing.Size(189, 20)
        Me.FormatFront.TabIndex = 1
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.FormatFront, "Text")
        '
        'RunningCount
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.RunningCount, "TextChanged")
        Me.RunningCount.EnterMoveNextControl = True
        Me.RunningCount.Location = New System.Drawing.Point(147, 155)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.RunningCount, True)
        Me.RunningCount.Name = "RunningCount"
        Me.RunningCount.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RunningCount.Properties.Appearance.Options.UseFont = True
        Me.RunningCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RunningCount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RunningCount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RunningCount.Properties.Mask.EditMask = "n0"
        Me.RunningCount.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.RunningCount.Properties.MaxLength = 10
        Me.RunningCount.Properties.Precision = 0
        Me.RunningCount.Size = New System.Drawing.Size(189, 20)
        Me.RunningCount.TabIndex = 5
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.RunningCount, "Text")
        '
        'btnRefresh
        '
        Me.btnRefresh.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRefresh.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnRefresh, "")
        Me.btnRefresh.ImageOptions.Image = CType(resources.GetObject("btnRefresh.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefresh.Location = New System.Drawing.Point(108, 187)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnRefresh, True)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(21, 21)
        Me.btnRefresh.TabIndex = 219
        Me.btnRefresh.TabStop = False
        Me.btnRefresh.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnRefresh, "")
        '
        'XtraTabControl1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.XtraTabControl1, "")
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 30)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.XtraTabControl1, True)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.GeneralTabPage
        Me.XtraTabControl1.Size = New System.Drawing.Size(647, 276)
        Me.XtraTabControl1.TabIndex = 7
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.GeneralTabPage, Me.AdminTabPage})
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.XtraTabControl1, "")
        '
        'GeneralTabPage
        '
        Me.GeneralTabPage.Appearance.PageClient.BackColor = System.Drawing.Color.LightGray
        Me.GeneralTabPage.Appearance.PageClient.Options.UseBackColor = True
        Me.GeneralTabPage.AutoScroll = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.GeneralTabPage, "")
        Me.GeneralTabPage.Controls.Add(Me.FormatMidle)
        Me.GeneralTabPage.Controls.Add(Me.Label7)
        Me.GeneralTabPage.Controls.Add(Me.TextEdit1)
        Me.GeneralTabPage.Controls.Add(Me.Label2)
        Me.GeneralTabPage.Controls.Add(Me.chkIsReset)
        Me.GeneralTabPage.Controls.Add(Me.btnRefresh)
        Me.GeneralTabPage.Controls.Add(Me.FormatYear)
        Me.GeneralTabPage.Controls.Add(Me.RunningCount)
        Me.GeneralTabPage.Controls.Add(Me.lblExam)
        Me.GeneralTabPage.Controls.Add(Me.Label9)
        Me.GeneralTabPage.Controls.Add(Me.Label6)
        Me.GeneralTabPage.Controls.Add(Me.FormatDate)
        Me.GeneralTabPage.Controls.Add(Me.Label1)
        Me.GeneralTabPage.Controls.Add(Me.FormatFront)
        Me.GeneralTabPage.Controls.Add(Me.Label8)
        Me.GeneralTabPage.Controls.Add(Me.Label5)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.GeneralTabPage, True)
        Me.GeneralTabPage.Name = "GeneralTabPage"
        Me.GeneralTabPage.Size = New System.Drawing.Size(645, 251)
        Me.GeneralTabPage.Text = "ข้อมูลทั่วไป"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.GeneralTabPage, "")
        '
        'chkIsReset
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.chkIsReset, "CheckedChanged")
        Me.chkIsReset.EditValue = True
        Me.chkIsReset.Location = New System.Drawing.Point(403, 42)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.chkIsReset, True)
        Me.chkIsReset.Name = "chkIsReset"
        Me.chkIsReset.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIsReset.Properties.Appearance.Options.UseFont = True
        Me.chkIsReset.Properties.Caption = "เริ่มต้นลำดับใหม่"
        Me.chkIsReset.Size = New System.Drawing.Size(122, 20)
        Me.chkIsReset.TabIndex = 221
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.chkIsReset, "Checked")
        '
        'FormatYear
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.FormatYear, "")
        Me.FormatYear.EditValue = "true"
        Me.FormatYear.Location = New System.Drawing.Point(403, 127)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.FormatYear, True)
        Me.FormatYear.Name = "FormatYear"
        Me.FormatYear.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("EN", "คริสต์ศักราช"), New DevExpress.XtraEditors.Controls.RadioGroupItem("TH", "พุทธศักราช")})
        Me.FormatYear.Size = New System.Drawing.Size(189, 26)
        Me.FormatYear.TabIndex = 3
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.FormatYear, "")
        '
        'lblExam
        '
        Me.lblExam.AutoSize = True
        Me.lblExam.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.lblExam, "")
        Me.lblExam.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblExam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblExam.Location = New System.Drawing.Point(144, 194)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.lblExam, True)
        Me.lblExam.Name = "lblExam"
        Me.lblExam.Size = New System.Drawing.Size(35, 14)
        Me.lblExam.TabIndex = 200
        Me.lblExam.Text = "XXXX"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.lblExam, "")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label9, "")
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(349, 136)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label9, True)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 14)
        Me.Label9.TabIndex = 197
        Me.Label9.Text = "รูปแบบปี"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label9, "")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label1, "")
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(47, 158)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label1, True)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 14)
        Me.Label1.TabIndex = 148
        Me.Label1.Text = "หลักเลข Running"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label1, "")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label8, "")
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(47, 45)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label8, True)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 14)
        Me.Label8.TabIndex = 109
        Me.Label8.Text = "อักขระหน้า"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label8, "")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label5, "")
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(47, 192)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label5, True)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 16)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "ตัวอย่าง : "
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label5, "")
        '
        'AdminTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.AdminTabPage, "")
        Me.AdminTabPage.Controls.Add(Me.UcAdmin1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.AdminTabPage, True)
        Me.AdminTabPage.Name = "AdminTabPage"
        Me.AdminTabPage.Size = New System.Drawing.Size(690, 213)
        Me.AdminTabPage.Text = "ผู้บันทึก"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.AdminTabPage, "")
        '
        'UcAdmin1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.UcAdmin1, "")
        Me.UcAdmin1.Location = New System.Drawing.Point(40, 3)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.UcAdmin1, True)
        Me.UcAdmin1.Name = "UcAdmin1"
        Me.UcAdmin1.Size = New System.Drawing.Size(665, 223)
        Me.UcAdmin1.TabIndex = 0
        Me.UcAdmin1.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcAdmin1, "")
        '
        'FormChangedComponent1
        '
        '
        'FormatDate
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.FormatDate, "TextChanged")
        Me.FormatDate.EnterMoveNextControl = True
        Me.FormatDate.Location = New System.Drawing.Point(147, 129)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.FormatDate, True)
        Me.FormatDate.Name = "FormatDate"
        Me.FormatDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormatDate.Properties.Appearance.Options.UseFont = True
        Me.FormatDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FormatDate.Properties.ImmediatePopup = True
        Me.FormatDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.FormatDate.Properties.UseCtrlScroll = True
        Me.FormatDate.Properties.ValidateOnEnterKey = True
        Me.FormatDate.Size = New System.Drawing.Size(189, 20)
        Me.FormatDate.TabIndex = 2
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.FormatDate, "Text")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label6, "")
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(47, 132)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label6, True)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 14)
        Me.Label6.TabIndex = 194
        Me.Label6.Text = "รูปแบบวัน"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label6, "")
        '
        'TextEdit1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.TextEdit1, "TextChanged")
        Me.TextEdit1.EditValue = "รหัสจากหน้าซัพพลายเออร์"
        Me.TextEdit1.EnterMoveNextControl = True
        Me.TextEdit1.Location = New System.Drawing.Point(147, 68)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.TextEdit1, True)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Properties.MaxLength = 50
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.Properties.ValidateOnEnterKey = True
        Me.TextEdit1.Size = New System.Drawing.Size(189, 20)
        Me.TextEdit1.TabIndex = 222
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.TextEdit1, "Text")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label2, "")
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 71)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label2, True)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 14)
        Me.Label2.TabIndex = 223
        Me.Label2.Text = "อักขระกลาง"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label2, "")
        '
        'FormatMidle
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.FormatMidle, "TextChanged")
        Me.FormatMidle.EnterMoveNextControl = True
        Me.FormatMidle.Location = New System.Drawing.Point(147, 103)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.FormatMidle, True)
        Me.FormatMidle.Name = "FormatMidle"
        Me.FormatMidle.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormatMidle.Properties.Appearance.Options.UseFont = True
        Me.FormatMidle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FormatMidle.Properties.ImmediatePopup = True
        Me.FormatMidle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.FormatMidle.Properties.UseCtrlScroll = True
        Me.FormatMidle.Properties.ValidateOnEnterKey = True
        Me.FormatMidle.Size = New System.Drawing.Size(189, 20)
        Me.FormatMidle.TabIndex = 224
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.FormatMidle, "Text")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label7, "")
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(47, 106)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label7, True)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 14)
        Me.Label7.TabIndex = 225
        Me.Label7.Text = "อักขระคั่น"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label7, "")
        '
        'frmRuningFormatSN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 306)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frmRuningFormatSN"
        Me.Text = "frmRuningFormatSN"
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.FormatFront.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RunningCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.GeneralTabPage.ResumeLayout(False)
        Me.GeneralTabPage.PerformLayout()
        CType(Me.chkIsReset.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormatYear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AdminTabPage.ResumeLayout(False)
        CType(Me.FormatDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormatMidle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents GeneralTabPage As DevExpress.XtraTab.XtraTabPage
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FormatFront As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents AdminTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcAdmin1 As ucAdmin
    Private WithEvents Label9 As System.Windows.Forms.Label
    Private WithEvents lblExam As System.Windows.Forms.Label
    Friend WithEvents RunningCount As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents FormatYear As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents FormChangedComponent1 As FormChangedComponent
    Friend WithEvents chkIsReset As DevExpress.XtraEditors.CheckEdit
    Private WithEvents Label6 As Label
    Friend WithEvents FormatDate As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label2 As Label
    Friend WithEvents FormatMidle As DevExpress.XtraEditors.ComboBoxEdit
    Private WithEvents Label7 As Label
End Class
