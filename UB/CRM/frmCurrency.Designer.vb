﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCurrency
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
        Me.ExchangeRate = New DevExpress.XtraEditors.CalcEdit()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNameEng = New DevExpress.XtraEditors.TextEdit()
        Me.txtNameThai = New DevExpress.XtraEditors.TextEdit()
        Me.txtCode = New DevExpress.XtraEditors.TextEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRemark = New DevExpress.XtraEditors.MemoEdit()
        Me.NoteTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcNote1 = New ucNote()
        Me.AttachmentTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcFileAttach1 = New ucFileAttach()
        Me.AdminTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcAdmin1 = New ucAdmin()
        Me.CreditAmount = New DevExpress.XtraEditors.CalcEdit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.GeneralTabPage.SuspendLayout()
        CType(Me.ExchangeRate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNameEng.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNameThai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NoteTabPage.SuspendLayout()
        Me.AttachmentTabPage.SuspendLayout()
        Me.AdminTabPage.SuspendLayout()
        CType(Me.CreditAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.GeneralTabPage
        Me.XtraTabControl1.Size = New System.Drawing.Size(746, 486)
        Me.XtraTabControl1.TabIndex = 9
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.GeneralTabPage, Me.NoteTabPage, Me.AttachmentTabPage, Me.AdminTabPage})
        '
        'GeneralTabPage
        '
        Me.GeneralTabPage.Appearance.PageClient.BackColor = System.Drawing.Color.LightGray
        Me.GeneralTabPage.Appearance.PageClient.Options.UseBackColor = True
        Me.GeneralTabPage.AutoScroll = True
        Me.GeneralTabPage.Controls.Add(Me.ExchangeRate)
        Me.GeneralTabPage.Controls.Add(Me.Label23)
        Me.GeneralTabPage.Controls.Add(Me.Label1)
        Me.GeneralTabPage.Controls.Add(Me.txtNameEng)
        Me.GeneralTabPage.Controls.Add(Me.txtNameThai)
        Me.GeneralTabPage.Controls.Add(Me.txtCode)
        Me.GeneralTabPage.Controls.Add(Me.Label8)
        Me.GeneralTabPage.Controls.Add(Me.Label4)
        Me.GeneralTabPage.Controls.Add(Me.Label5)
        Me.GeneralTabPage.Controls.Add(Me.txtRemark)
        Me.GeneralTabPage.Name = "GeneralTabPage"
        Me.GeneralTabPage.Size = New System.Drawing.Size(740, 460)
        Me.GeneralTabPage.Text = "ข้อมูลทั่วไป"
        '
        'ExchangeRate
        '
        Me.ExchangeRate.EnterMoveNextControl = True
        Me.ExchangeRate.Location = New System.Drawing.Point(154, 92)
        Me.ExchangeRate.Name = "ExchangeRate"
        Me.ExchangeRate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExchangeRate.Properties.Appearance.Options.UseFont = True
        Me.ExchangeRate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ExchangeRate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ExchangeRate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ExchangeRate.Properties.Mask.EditMask = "n0"
        Me.ExchangeRate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.ExchangeRate.Properties.Precision = 0
        Me.ExchangeRate.Size = New System.Drawing.Size(273, 21)
        Me.ExchangeRate.TabIndex = 2
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label23.Location = New System.Drawing.Point(46, 95)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(86, 14)
        Me.Label23.TabIndex = 211
        Me.Label23.Text = "อัตราแลกเปลี่ยน"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(46, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 14)
        Me.Label1.TabIndex = 148
        Me.Label1.Text = "ชื่อสกุลเงิน"
        '
        'txtNameEng
        '
        Me.txtNameEng.EditValue = ""
        Me.txtNameEng.EnterMoveNextControl = True
        Me.txtNameEng.Location = New System.Drawing.Point(154, 120)
        Me.txtNameEng.Name = "txtNameEng"
        Me.txtNameEng.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtNameEng.Properties.Appearance.Options.UseFont = True
        Me.txtNameEng.Properties.MaxLength = 50
        Me.txtNameEng.Properties.ValidateOnEnterKey = True
        Me.txtNameEng.Size = New System.Drawing.Size(273, 21)
        Me.txtNameEng.TabIndex = 3
        '
        'txtNameThai
        '
        Me.txtNameThai.EditValue = ""
        Me.txtNameThai.EnterMoveNextControl = True
        Me.txtNameThai.Location = New System.Drawing.Point(154, 66)
        Me.txtNameThai.Name = "txtNameThai"
        Me.txtNameThai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtNameThai.Properties.Appearance.Options.UseFont = True
        Me.txtNameThai.Properties.MaxLength = 50
        Me.txtNameThai.Properties.ValidateOnEnterKey = True
        Me.txtNameThai.Size = New System.Drawing.Size(273, 21)
        Me.txtNameThai.TabIndex = 1
        '
        'txtCode
        '
        Me.txtCode.EditValue = ""
        Me.txtCode.EnterMoveNextControl = True
        Me.txtCode.Location = New System.Drawing.Point(154, 39)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCode.Properties.Appearance.Options.UseFont = True
        Me.txtCode.Properties.MaxLength = 20
        Me.txtCode.Properties.ValidateOnEnterKey = True
        Me.txtCode.Size = New System.Drawing.Size(155, 21)
        Me.txtCode.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(46, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 14)
        Me.Label8.TabIndex = 109
        Me.Label8.Text = "ชื่อสกุลเงิน (Eng)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(46, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 14)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "รหัสสกุลเงิน"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 14)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "รายละเอียด"
        '
        'txtRemark
        '
        Me.txtRemark.EditValue = ""
        Me.txtRemark.EnterMoveNextControl = True
        Me.txtRemark.Location = New System.Drawing.Point(154, 147)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRemark.Properties.Appearance.Options.UseFont = True
        Me.txtRemark.Properties.MaxLength = 100
        Me.txtRemark.Size = New System.Drawing.Size(273, 92)
        Me.txtRemark.TabIndex = 4
        '
        'NoteTabPage
        '
        Me.NoteTabPage.Controls.Add(Me.UcNote1)
        Me.NoteTabPage.Name = "NoteTabPage"
        Me.NoteTabPage.Size = New System.Drawing.Size(740, 460)
        Me.NoteTabPage.Text = "บันทึกข้อความ"
        '
        'UcNote1
        '
        Me.UcNote1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcNote1.Location = New System.Drawing.Point(0, 0)
        Me.UcNote1.Name = "UcNote1"
        Me.UcNote1.Size = New System.Drawing.Size(740, 460)
        Me.UcNote1.TabIndex = 0
        '
        'AttachmentTabPage
        '
        Me.AttachmentTabPage.Controls.Add(Me.UcFileAttach1)
        Me.AttachmentTabPage.Name = "AttachmentTabPage"
        Me.AttachmentTabPage.Size = New System.Drawing.Size(769, 403)
        Me.AttachmentTabPage.Text = "ไฟล์แนบ"
        '
        'UcFileAttach1
        '
        Me.UcFileAttach1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcFileAttach1.Location = New System.Drawing.Point(0, 0)
        Me.UcFileAttach1.Name = "UcFileAttach1"
        Me.UcFileAttach1.Size = New System.Drawing.Size(769, 403)
        Me.UcFileAttach1.TabIndex = 0
        '
        'AdminTabPage
        '
        Me.AdminTabPage.Controls.Add(Me.UcAdmin1)
        Me.AdminTabPage.Name = "AdminTabPage"
        Me.AdminTabPage.Size = New System.Drawing.Size(769, 403)
        Me.AdminTabPage.Text = "ผู้บันทึก"
        '
        'UcAdmin1
        '
        Me.UcAdmin1.Location = New System.Drawing.Point(40, 3)
        Me.UcAdmin1.Name = "UcAdmin1"
        Me.UcAdmin1.Size = New System.Drawing.Size(665, 223)
        Me.UcAdmin1.TabIndex = 0
        Me.UcAdmin1.TabStop = False
        '
        'CreditAmount
        '
        Me.CreditAmount.EnterMoveNextControl = True
        Me.CreditAmount.Location = New System.Drawing.Point(154, 92)
        Me.CreditAmount.Name = "CreditAmount"
        Me.CreditAmount.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreditAmount.Properties.Appearance.Options.UseFont = True
        Me.CreditAmount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CreditAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CreditAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CreditAmount.Properties.Mask.EditMask = "n0"
        Me.CreditAmount.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.CreditAmount.Properties.Precision = 0
        Me.CreditAmount.Size = New System.Drawing.Size(273, 21)
        Me.CreditAmount.TabIndex = 2
        '
        'frmCurrency
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 486)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frmCurrency"
        Me.Text = "frmCurrency"
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.GeneralTabPage.ResumeLayout(False)
        Me.GeneralTabPage.PerformLayout()
        CType(Me.ExchangeRate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNameEng.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNameThai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NoteTabPage.ResumeLayout(False)
        Me.AttachmentTabPage.ResumeLayout(False)
        Me.AdminTabPage.ResumeLayout(False)
        CType(Me.CreditAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents GeneralTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ExchangeRate As DevExpress.XtraEditors.CalcEdit
    Private WithEvents Label23 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNameEng As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNameThai As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRemark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents NoteTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcNote1 As ucNote
    Friend WithEvents AttachmentTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcFileAttach1 As ucFileAttach
    Friend WithEvents AdminTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcAdmin1 As ucAdmin
    Friend WithEvents CreditAmount As DevExpress.XtraEditors.CalcEdit
End Class
