﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductCategory
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
        Me.components = New System.ComponentModel.Container()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.GeneralTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProductBrandID = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.ProductTypeID = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.ProductGroupID = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNameEng = New DevExpress.XtraEditors.TextEdit()
        Me.txtNameThai = New DevExpress.XtraEditors.TextEdit()
        Me.IDCode = New DevExpress.XtraEditors.TextEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Remark = New DevExpress.XtraEditors.MemoEdit()
        Me.NoteTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcNote1 = New ucNote()
        Me.AttachmentTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcFileAttach1 = New ucFileAttach()
        Me.AdminTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcAdmin1 = New ucAdmin()
        Me.FormChangedComponent1 = New FormChangedComponent(Me.components)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.GeneralTabPage.SuspendLayout()
        CType(Me.ProductBrandID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductTypeID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductGroupID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNameEng.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNameThai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Remark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NoteTabPage.SuspendLayout()
        Me.AttachmentTabPage.SuspendLayout()
        Me.AdminTabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'XtraTabControl1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.XtraTabControl1, "")
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 37)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.XtraTabControl1, True)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.GeneralTabPage
        Me.XtraTabControl1.Size = New System.Drawing.Size(784, 436)
        Me.XtraTabControl1.TabIndex = 8
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.GeneralTabPage, Me.NoteTabPage, Me.AttachmentTabPage, Me.AdminTabPage})
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.XtraTabControl1, "")
        '
        'GeneralTabPage
        '
        Me.GeneralTabPage.Appearance.PageClient.BackColor = System.Drawing.Color.LightGray
        Me.GeneralTabPage.Appearance.PageClient.Options.UseBackColor = True
        Me.GeneralTabPage.AutoScroll = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.GeneralTabPage, "")
        Me.GeneralTabPage.Controls.Add(Me.Label6)
        Me.GeneralTabPage.Controls.Add(Me.Label3)
        Me.GeneralTabPage.Controls.Add(Me.Label2)
        Me.GeneralTabPage.Controls.Add(Me.ProductBrandID)
        Me.GeneralTabPage.Controls.Add(Me.ProductTypeID)
        Me.GeneralTabPage.Controls.Add(Me.ProductGroupID)
        Me.GeneralTabPage.Controls.Add(Me.Label1)
        Me.GeneralTabPage.Controls.Add(Me.txtNameEng)
        Me.GeneralTabPage.Controls.Add(Me.txtNameThai)
        Me.GeneralTabPage.Controls.Add(Me.IDCode)
        Me.GeneralTabPage.Controls.Add(Me.Label8)
        Me.GeneralTabPage.Controls.Add(Me.Label4)
        Me.GeneralTabPage.Controls.Add(Me.Label5)
        Me.GeneralTabPage.Controls.Add(Me.Remark)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.GeneralTabPage, True)
        Me.GeneralTabPage.Name = "GeneralTabPage"
        Me.GeneralTabPage.Size = New System.Drawing.Size(778, 408)
        Me.GeneralTabPage.Text = "ข้อมูลทั่วไป"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.GeneralTabPage, "")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label6, "")
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(550, 215)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label6, True)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 14)
        Me.Label6.TabIndex = 193
        Me.Label6.Text = "ยี่ห้อสินค้า"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label6, "")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label3, "")
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(354, 215)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label3, True)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 14)
        Me.Label3.TabIndex = 192
        Me.Label3.Text = "ประเภทสินค้า"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label3, "")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label2, "")
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(158, 215)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label2, True)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 14)
        Me.Label2.TabIndex = 191
        Me.Label2.Text = "กลุ่มสินค้า"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label2, "")
        '
        'ProductBrandID
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.ProductBrandID, "")
        Me.ProductBrandID.Location = New System.Drawing.Point(553, 232)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.ProductBrandID, True)
        Me.ProductBrandID.Name = "ProductBrandID"
        Me.ProductBrandID.Size = New System.Drawing.Size(181, 157)
        Me.ProductBrandID.TabIndex = 190
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.ProductBrandID, "")
        '
        'ProductTypeID
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.ProductTypeID, "")
        Me.ProductTypeID.Location = New System.Drawing.Point(357, 232)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.ProductTypeID, True)
        Me.ProductTypeID.Name = "ProductTypeID"
        Me.ProductTypeID.Size = New System.Drawing.Size(181, 157)
        Me.ProductTypeID.TabIndex = 189
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.ProductTypeID, "")
        '
        'ProductGroupID
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.ProductGroupID, "")
        Me.ProductGroupID.Location = New System.Drawing.Point(161, 232)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.ProductGroupID, True)
        Me.ProductGroupID.Name = "ProductGroupID"
        Me.ProductGroupID.Size = New System.Drawing.Size(181, 157)
        Me.ProductGroupID.TabIndex = 188
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.ProductGroupID, "")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label1, "")
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(46, 69)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label1, True)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 14)
        Me.Label1.TabIndex = 148
        Me.Label1.Text = "ชื่อหมวดสินค้า"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label1, "")
        '
        'txtNameEng
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtNameEng, "TextChanged")
        Me.txtNameEng.EditValue = ""
        Me.txtNameEng.EnterMoveNextControl = True
        Me.txtNameEng.Location = New System.Drawing.Point(161, 92)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.txtNameEng, True)
        Me.txtNameEng.Name = "txtNameEng"
        Me.txtNameEng.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtNameEng.Properties.Appearance.Options.UseFont = True
        Me.txtNameEng.Properties.MaxLength = 50
        Me.txtNameEng.Properties.ValidateOnEnterKey = True
        Me.txtNameEng.Size = New System.Drawing.Size(273, 20)
        Me.txtNameEng.TabIndex = 3
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtNameEng, "Text")
        '
        'txtNameThai
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtNameThai, "TextChanged")
        Me.txtNameThai.EditValue = ""
        Me.txtNameThai.EnterMoveNextControl = True
        Me.txtNameThai.Location = New System.Drawing.Point(161, 66)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.txtNameThai, True)
        Me.txtNameThai.Name = "txtNameThai"
        Me.txtNameThai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtNameThai.Properties.Appearance.Options.UseFont = True
        Me.txtNameThai.Properties.MaxLength = 50
        Me.txtNameThai.Properties.ValidateOnEnterKey = True
        Me.txtNameThai.Size = New System.Drawing.Size(273, 20)
        Me.txtNameThai.TabIndex = 1
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtNameThai, "Text")
        '
        'IDCode
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.IDCode, "TextChanged")
        Me.IDCode.EditValue = ""
        Me.IDCode.EnterMoveNextControl = True
        Me.IDCode.Location = New System.Drawing.Point(161, 39)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.IDCode, True)
        Me.IDCode.Name = "IDCode"
        Me.IDCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.IDCode.Properties.Appearance.Options.UseFont = True
        Me.IDCode.Properties.MaxLength = 20
        Me.IDCode.Properties.ValidateOnEnterKey = True
        Me.IDCode.Size = New System.Drawing.Size(155, 20)
        Me.IDCode.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.IDCode, "Text")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label8, "")
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(46, 95)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label8, True)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 14)
        Me.Label8.TabIndex = 109
        Me.Label8.Text = "ชื่อหมวดสินค้า (Eng)"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label8, "")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label4, "")
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(46, 42)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label4, True)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 14)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "รหัสหมวดสินค้า"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label4, "")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label5, "")
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 120)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label5, True)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 14)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "รายละเอียด"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label5, "")
        '
        'Remark
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Remark, "TextChanged")
        Me.Remark.EditValue = ""
        Me.Remark.EnterMoveNextControl = True
        Me.Remark.Location = New System.Drawing.Point(161, 118)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Remark, True)
        Me.Remark.Name = "Remark"
        Me.Remark.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Remark.Properties.Appearance.Options.UseFont = True
        Me.Remark.Properties.MaxLength = 100
        Me.Remark.Size = New System.Drawing.Size(273, 86)
        Me.Remark.TabIndex = 4
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Remark, "Text")
        '
        'NoteTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.NoteTabPage, "")
        Me.NoteTabPage.Controls.Add(Me.UcNote1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.NoteTabPage, True)
        Me.NoteTabPage.Name = "NoteTabPage"
        Me.NoteTabPage.Size = New System.Drawing.Size(778, 408)
        Me.NoteTabPage.Text = "บันทึกข้อความ"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.NoteTabPage, "")
        '
        'UcNote1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.UcNote1, "")
        Me.UcNote1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcNote1.Location = New System.Drawing.Point(0, 0)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.UcNote1, True)
        Me.UcNote1.Name = "UcNote1"
        Me.UcNote1.Size = New System.Drawing.Size(778, 408)
        Me.UcNote1.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcNote1, "")
        '
        'AttachmentTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.AttachmentTabPage, "")
        Me.AttachmentTabPage.Controls.Add(Me.UcFileAttach1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.AttachmentTabPage, True)
        Me.AttachmentTabPage.Name = "AttachmentTabPage"
        Me.AttachmentTabPage.Size = New System.Drawing.Size(778, 408)
        Me.AttachmentTabPage.Text = "ไฟล์แนบ"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.AttachmentTabPage, "")
        '
        'UcFileAttach1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.UcFileAttach1, "")
        Me.UcFileAttach1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcFileAttach1.Location = New System.Drawing.Point(0, 0)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.UcFileAttach1, True)
        Me.UcFileAttach1.Name = "UcFileAttach1"
        Me.UcFileAttach1.Size = New System.Drawing.Size(778, 408)
        Me.UcFileAttach1.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcFileAttach1, "")
        '
        'AdminTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.AdminTabPage, "")
        Me.AdminTabPage.Controls.Add(Me.UcAdmin1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.AdminTabPage, True)
        Me.AdminTabPage.Name = "AdminTabPage"
        Me.AdminTabPage.Size = New System.Drawing.Size(778, 408)
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
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcAdmin1, "")
        '
        'FormChangedComponent1
        '
        '
        'frmProductCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 473)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frmProductCategory"
        Me.Text = "frmProductCategory"
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.GeneralTabPage.ResumeLayout(False)
        Me.GeneralTabPage.PerformLayout()
        CType(Me.ProductBrandID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductTypeID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductGroupID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNameEng.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNameThai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Remark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NoteTabPage.ResumeLayout(False)
        Me.AttachmentTabPage.ResumeLayout(False)
        Me.AdminTabPage.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents GeneralTabPage As DevExpress.XtraTab.XtraTabPage
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNameEng As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNameThai As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IDCode As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Remark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents NoteTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcNote1 As ucNote
    Friend WithEvents AttachmentTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcFileAttach1 As ucFileAttach
    Friend WithEvents AdminTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcAdmin1 As ucAdmin
    Friend WithEvents FormChangedComponent1 As FormChangedComponent
    Friend WithEvents ProductTypeID As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents ProductGroupID As DevExpress.XtraEditors.CheckedListBoxControl
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ProductBrandID As DevExpress.XtraEditors.CheckedListBoxControl
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
End Class
