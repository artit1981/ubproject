﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockReport
    Inherits iReport

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockReport))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkSelectAllPro = New DevExpress.XtraEditors.CheckEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Product = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ProductBrandID = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.ProductTypeID = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.ReportType = New DevExpress.XtraEditors.RadioGroup()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.chkSelectAllPro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBrandID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductTypeID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(524, 232)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 14)
        Me.Label9.TabIndex = 208
        Me.Label9.Text = "Select /Unselect All"
        '
        'chkSelectAllPro
        '
        Me.chkSelectAllPro.Location = New System.Drawing.Point(525, 249)
        Me.chkSelectAllPro.Name = "chkSelectAllPro"
        Me.chkSelectAllPro.Properties.Caption = ""
        Me.chkSelectAllPro.Size = New System.Drawing.Size(48, 19)
        Me.chkSelectAllPro.TabIndex = 207
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 232)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 14)
        Me.Label8.TabIndex = 206
        Me.Label8.Text = "สินค้า"
        '
        'Product
        '
        Me.Product.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Product.Location = New System.Drawing.Point(133, 232)
        Me.Product.Name = "Product"
        Me.Product.Size = New System.Drawing.Size(377, 292)
        Me.Product.TabIndex = 205
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(326, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 14)
        Me.Label6.TabIndex = 204
        Me.Label6.Text = "ยี่ห้อสินค้า"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(130, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 14)
        Me.Label7.TabIndex = 203
        Me.Label7.Text = "ประเภทสินค้า"
        '
        'ProductBrandID
        '
        Me.ProductBrandID.Location = New System.Drawing.Point(329, 122)
        Me.ProductBrandID.Name = "ProductBrandID"
        Me.ProductBrandID.Size = New System.Drawing.Size(181, 104)
        Me.ProductBrandID.TabIndex = 202
        '
        'ProductTypeID
        '
        Me.ProductTypeID.Location = New System.Drawing.Point(133, 122)
        Me.ProductTypeID.Name = "ProductTypeID"
        Me.ProductTypeID.Size = New System.Drawing.Size(181, 104)
        Me.ProductTypeID.TabIndex = 201
        '
        'ReportType
        '
        Me.ReportType.EditValue = "E"
        Me.ReportType.EnterMoveNextControl = True
        Me.ReportType.Location = New System.Drawing.Point(133, 62)
        Me.ReportType.Name = "ReportType"
        Me.ReportType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("A", "ต้นทุนเฉลี่ยโดยระบบ"), New DevExpress.XtraEditors.Controls.RadioGroupItem("B", "Cost")})
        Me.ReportType.Size = New System.Drawing.Size(377, 26)
        Me.ReportType.TabIndex = 209
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 14)
        Me.Label4.TabIndex = 210
        Me.Label4.Text = "ใช้ราคา"
        '
        'frmStockReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1112, 535)
        Me.Controls.Add(Me.ReportType)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.chkSelectAllPro)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Product)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ProductBrandID)
        Me.Controls.Add(Me.ProductTypeID)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStockReport"
        Me.Text = "รายงานวิเคราะห์ยอดขาย"
        Me.Controls.SetChildIndex(Me.ProductTypeID, 0)
        Me.Controls.SetChildIndex(Me.ProductBrandID, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Product, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.chkSelectAllPro, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.ReportType, 0)
        CType(Me.chkSelectAllPro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBrandID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductTypeID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ProductBrandID As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents ProductTypeID As DevExpress.XtraEditors.CheckedListBoxControl
    Private WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chkSelectAllPro As DevExpress.XtraEditors.CheckEdit
    Private WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Product As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents ReportType As DevExpress.XtraEditors.RadioGroup
    Private WithEvents Label4 As System.Windows.Forms.Label

End Class