﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPreExport))
        Me.rdoCondition = New DevExpress.XtraEditors.RadioGroup()
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.txtBrows = New DevExpress.XtraEditors.ButtonEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.chkDate = New System.Windows.Forms.CheckBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.chkPrintCopy = New System.Windows.Forms.CheckBox()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.cboBarcode = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.rdoCondition.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBrows.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.cboBarcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rdoCondition
        '
        Me.rdoCondition.EditValue = CType(1, Short)
        Me.rdoCondition.Location = New System.Drawing.Point(26, 20)
        Me.rdoCondition.Name = "rdoCondition"
        Me.rdoCondition.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoCondition.Properties.Appearance.Options.UseFont = True
        Me.rdoCondition.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(1, Short), "ดูตัวอย่างรายงาน"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(2, Short), "พิมพ์โดยเลือกเครื่องปริ้นท์"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(3, Short), "พิมพ์โดยไม่เลือกเครื่องปริ้นท์"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(4, Short), "Export to PDF"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(5, Short), "Export to Excel")})
        Me.rdoCondition.Size = New System.Drawing.Size(321, 160)
        Me.rdoCondition.TabIndex = 0
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(366, 32)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "ตกลง"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(366, 72)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "ยกเลิก"
        '
        'txtBrows
        '
        Me.txtBrows.EditValue = ""
        Me.txtBrows.Location = New System.Drawing.Point(26, 191)
        Me.txtBrows.Name = "txtBrows"
        Me.txtBrows.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtBrows.Size = New System.Drawing.Size(321, 20)
        Me.txtBrows.TabIndex = 4
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.Appearance.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.chkDate)
        Me.GroupControl1.Location = New System.Drawing.Point(26, 271)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(321, 48)
        Me.GroupControl1.TabIndex = 5
        Me.GroupControl1.Text = "เงื่อนไขอื่นๆ"
        '
        'chkDate
        '
        Me.chkDate.AutoSize = True
        Me.chkDate.Checked = True
        Me.chkDate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDate.Location = New System.Drawing.Point(16, 25)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.Size = New System.Drawing.Size(72, 17)
        Me.chkDate.TabIndex = 0
        Me.chkDate.Text = "แสดงวันที่"
        Me.chkDate.UseVisualStyleBackColor = True
        '
        'GroupControl2
        '
        Me.GroupControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.Appearance.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.chkPrintCopy)
        Me.GroupControl2.Location = New System.Drawing.Point(26, 217)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(321, 48)
        Me.GroupControl2.TabIndex = 6
        Me.GroupControl2.Text = "รายการเคลม"
        '
        'chkPrintCopy
        '
        Me.chkPrintCopy.AutoSize = True
        Me.chkPrintCopy.Checked = True
        Me.chkPrintCopy.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPrintCopy.Location = New System.Drawing.Point(16, 25)
        Me.chkPrintCopy.Name = "chkPrintCopy"
        Me.chkPrintCopy.Size = New System.Drawing.Size(101, 17)
        Me.chkPrintCopy.TabIndex = 0
        Me.chkPrintCopy.Text = "พิมพ์สำเนาลูกค้า"
        Me.chkPrintCopy.UseVisualStyleBackColor = True
        '
        'GroupControl3
        '
        Me.GroupControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl3.Appearance.Options.UseFont = True
        Me.GroupControl3.Controls.Add(Me.cboBarcode)
        Me.GroupControl3.Controls.Add(Me.LabelControl1)
        Me.GroupControl3.Location = New System.Drawing.Point(453, 242)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(321, 56)
        Me.GroupControl3.TabIndex = 344
        Me.GroupControl3.Text = "พิมพ์บาร์โค้ด"
        Me.GroupControl3.Visible = False
        '
        'cboBarcode
        '
        Me.cboBarcode.EditValue = "Code 93"
        Me.cboBarcode.Location = New System.Drawing.Point(67, 24)
        Me.cboBarcode.Name = "cboBarcode"
        Me.cboBarcode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboBarcode.Properties.Items.AddRange(New Object() {"Code 39", "Code 93", "Code 128"})
        Me.cboBarcode.Size = New System.Drawing.Size(249, 20)
        Me.cboBarcode.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(16, 25)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "บาร์โค้ด"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(453, 101)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(201, 110)
        Me.PictureEdit1.TabIndex = 345
        '
        'frmPreReport
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(450, 338)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.txtBrows)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.rdoCondition)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPreReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เงื่อนไขการออกรายงาน"
        CType(Me.rdoCondition.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBrows.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.cboBarcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rdoCondition As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtBrows As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkDate As System.Windows.Forms.CheckBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkPrintCopy As System.Windows.Forms.CheckBox
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cboBarcode As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
End Class
