<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucImage_4
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucImage_4))
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.btnCancel1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDelete1 = New DevExpress.XtraEditors.SimpleButton()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.btnAdd1 = New DevExpress.XtraEditors.SimpleButton()
        Me.picPro4 = New DevExpress.XtraEditors.PictureEdit()
        Me.picPro1 = New DevExpress.XtraEditors.PictureEdit()
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl()
        Me.btnCancel4 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDelete4 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd4 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.btnCancel2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDelete2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd2 = New DevExpress.XtraEditors.SimpleButton()
        Me.picPro3 = New DevExpress.XtraEditors.PictureEdit()
        Me.picPro2 = New DevExpress.XtraEditors.PictureEdit()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.btnCancel3 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDelete3 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd3 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl7.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPro4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPro1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl6.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.picPro3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPro2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupControl7
        '
        Me.GroupControl7.Controls.Add(Me.GroupControl3)
        Me.GroupControl7.Controls.Add(Me.picPro4)
        Me.GroupControl7.Controls.Add(Me.picPro1)
        Me.GroupControl7.Controls.Add(Me.GroupControl6)
        Me.GroupControl7.Controls.Add(Me.GroupControl4)
        Me.GroupControl7.Controls.Add(Me.picPro3)
        Me.GroupControl7.Controls.Add(Me.picPro2)
        Me.GroupControl7.Controls.Add(Me.GroupControl5)
        Me.GroupControl7.Location = New System.Drawing.Point(3, 3)
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.Size = New System.Drawing.Size(355, 382)
        Me.GroupControl7.TabIndex = 226
        Me.GroupControl7.Text = "รูปภาพสินค้า"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.btnCancel1)
        Me.GroupControl3.Controls.Add(Me.btnDelete1)
        Me.GroupControl3.Controls.Add(Me.btnAdd1)
        Me.GroupControl3.Location = New System.Drawing.Point(14, 30)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.ShowCaption = False
        Me.GroupControl3.Size = New System.Drawing.Size(150, 30)
        Me.GroupControl3.TabIndex = 217
        Me.GroupControl3.Text = "GroupControl3"
        '
        'btnCancel1
        '
        Me.btnCancel1.Image = CType(resources.GetObject("btnCancel1.Image"), System.Drawing.Image)
        Me.btnCancel1.ImageIndex = 2
        Me.btnCancel1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCancel1.Location = New System.Drawing.Point(80, 5)
        Me.btnCancel1.Name = "btnCancel1"
        Me.btnCancel1.Size = New System.Drawing.Size(30, 20)
        Me.btnCancel1.TabIndex = 4
        Me.btnCancel1.ToolTip = "ยกเลิก"
        '
        'btnDelete1
        '
        Me.btnDelete1.ImageIndex = 1
        Me.btnDelete1.ImageList = Me.ImageCollection1
        Me.btnDelete1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnDelete1.Location = New System.Drawing.Point(41, 5)
        Me.btnDelete1.Name = "btnDelete1"
        Me.btnDelete1.Size = New System.Drawing.Size(30, 20)
        Me.btnDelete1.TabIndex = 3
        Me.btnDelete1.ToolTip = "ลบรูป"
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageSize = New System.Drawing.Size(20, 20)
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection1.Images.SetKeyName(0, "Add.png")
        Me.ImageCollection1.Images.SetKeyName(1, "_active__remove_(delete).png")
        Me.ImageCollection1.Images.SetKeyName(2, "Refresh1.png")
        '
        'btnAdd1
        '
        Me.btnAdd1.ImageIndex = 0
        Me.btnAdd1.ImageList = Me.ImageCollection1
        Me.btnAdd1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAdd1.Location = New System.Drawing.Point(5, 5)
        Me.btnAdd1.Name = "btnAdd1"
        Me.btnAdd1.Size = New System.Drawing.Size(30, 20)
        Me.btnAdd1.TabIndex = 2
        Me.btnAdd1.ToolTip = "เพิ่มรูป"
        '
        'picPro4
        '
        Me.picPro4.Location = New System.Drawing.Point(190, 236)
        Me.picPro4.Name = "picPro4"
        Me.picPro4.Properties.ShowMenu = False
        Me.picPro4.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.picPro4.Size = New System.Drawing.Size(150, 130)
        Me.picPro4.TabIndex = 224
        '
        'picPro1
        '
        Me.picPro1.Location = New System.Drawing.Point(14, 60)
        Me.picPro1.Name = "picPro1"
        Me.picPro1.Properties.ShowMenu = False
        Me.picPro1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.picPro1.Size = New System.Drawing.Size(150, 130)
        Me.picPro1.TabIndex = 218
        '
        'GroupControl6
        '
        Me.GroupControl6.Controls.Add(Me.btnCancel4)
        Me.GroupControl6.Controls.Add(Me.btnDelete4)
        Me.GroupControl6.Controls.Add(Me.btnAdd4)
        Me.GroupControl6.Location = New System.Drawing.Point(190, 206)
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.ShowCaption = False
        Me.GroupControl6.Size = New System.Drawing.Size(150, 30)
        Me.GroupControl6.TabIndex = 223
        Me.GroupControl6.Text = "GroupControl6"
        '
        'btnCancel4
        '
        Me.btnCancel4.Image = CType(resources.GetObject("btnCancel4.Image"), System.Drawing.Image)
        Me.btnCancel4.ImageIndex = 2
        Me.btnCancel4.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCancel4.Location = New System.Drawing.Point(80, 5)
        Me.btnCancel4.Name = "btnCancel4"
        Me.btnCancel4.Size = New System.Drawing.Size(30, 20)
        Me.btnCancel4.TabIndex = 4
        Me.btnCancel4.ToolTip = "ยกเลิก"
        '
        'btnDelete4
        '
        Me.btnDelete4.ImageIndex = 1
        Me.btnDelete4.ImageList = Me.ImageCollection1
        Me.btnDelete4.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnDelete4.Location = New System.Drawing.Point(41, 5)
        Me.btnDelete4.Name = "btnDelete4"
        Me.btnDelete4.Size = New System.Drawing.Size(30, 20)
        Me.btnDelete4.TabIndex = 3
        Me.btnDelete4.ToolTip = "ลบรูป"
        '
        'btnAdd4
        '
        Me.btnAdd4.ImageIndex = 0
        Me.btnAdd4.ImageList = Me.ImageCollection1
        Me.btnAdd4.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAdd4.Location = New System.Drawing.Point(5, 5)
        Me.btnAdd4.Name = "btnAdd4"
        Me.btnAdd4.Size = New System.Drawing.Size(30, 20)
        Me.btnAdd4.TabIndex = 2
        Me.btnAdd4.ToolTip = "เพิ่มรูป"
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.btnCancel2)
        Me.GroupControl4.Controls.Add(Me.btnDelete2)
        Me.GroupControl4.Controls.Add(Me.btnAdd2)
        Me.GroupControl4.Location = New System.Drawing.Point(190, 30)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.ShowCaption = False
        Me.GroupControl4.Size = New System.Drawing.Size(150, 30)
        Me.GroupControl4.TabIndex = 219
        Me.GroupControl4.Text = "GroupControl4"
        '
        'btnCancel2
        '
        Me.btnCancel2.Image = CType(resources.GetObject("btnCancel2.Image"), System.Drawing.Image)
        Me.btnCancel2.ImageIndex = 2
        Me.btnCancel2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCancel2.Location = New System.Drawing.Point(80, 5)
        Me.btnCancel2.Name = "btnCancel2"
        Me.btnCancel2.Size = New System.Drawing.Size(30, 20)
        Me.btnCancel2.TabIndex = 4
        Me.btnCancel2.ToolTip = "ยกเลิก"
        '
        'btnDelete2
        '
        Me.btnDelete2.ImageIndex = 1
        Me.btnDelete2.ImageList = Me.ImageCollection1
        Me.btnDelete2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnDelete2.Location = New System.Drawing.Point(41, 5)
        Me.btnDelete2.Name = "btnDelete2"
        Me.btnDelete2.Size = New System.Drawing.Size(30, 20)
        Me.btnDelete2.TabIndex = 3
        Me.btnDelete2.ToolTip = "ลบรูป"
        '
        'btnAdd2
        '
        Me.btnAdd2.ImageIndex = 0
        Me.btnAdd2.ImageList = Me.ImageCollection1
        Me.btnAdd2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAdd2.Location = New System.Drawing.Point(5, 5)
        Me.btnAdd2.Name = "btnAdd2"
        Me.btnAdd2.Size = New System.Drawing.Size(30, 20)
        Me.btnAdd2.TabIndex = 2
        Me.btnAdd2.ToolTip = "เพิ่มรูป"
        '
        'picPro3
        '
        Me.picPro3.Location = New System.Drawing.Point(14, 237)
        Me.picPro3.Name = "picPro3"
        Me.picPro3.Properties.ShowMenu = False
        Me.picPro3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.picPro3.Size = New System.Drawing.Size(150, 130)
        Me.picPro3.TabIndex = 222
        '
        'picPro2
        '
        Me.picPro2.Location = New System.Drawing.Point(190, 60)
        Me.picPro2.Name = "picPro2"
        Me.picPro2.Properties.ShowMenu = False
        Me.picPro2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.picPro2.Size = New System.Drawing.Size(150, 130)
        Me.picPro2.TabIndex = 220
        '
        'GroupControl5
        '
        Me.GroupControl5.Controls.Add(Me.btnCancel3)
        Me.GroupControl5.Controls.Add(Me.btnDelete3)
        Me.GroupControl5.Controls.Add(Me.btnAdd3)
        Me.GroupControl5.Location = New System.Drawing.Point(14, 207)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.ShowCaption = False
        Me.GroupControl5.Size = New System.Drawing.Size(150, 30)
        Me.GroupControl5.TabIndex = 221
        Me.GroupControl5.Text = "GroupControl5"
        '
        'btnCancel3
        '
        Me.btnCancel3.Image = CType(resources.GetObject("btnCancel3.Image"), System.Drawing.Image)
        Me.btnCancel3.ImageIndex = 2
        Me.btnCancel3.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCancel3.Location = New System.Drawing.Point(80, 5)
        Me.btnCancel3.Name = "btnCancel3"
        Me.btnCancel3.Size = New System.Drawing.Size(30, 20)
        Me.btnCancel3.TabIndex = 4
        Me.btnCancel3.ToolTip = "ยกเลิก"
        '
        'btnDelete3
        '
        Me.btnDelete3.ImageIndex = 1
        Me.btnDelete3.ImageList = Me.ImageCollection1
        Me.btnDelete3.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnDelete3.Location = New System.Drawing.Point(41, 5)
        Me.btnDelete3.Name = "btnDelete3"
        Me.btnDelete3.Size = New System.Drawing.Size(30, 20)
        Me.btnDelete3.TabIndex = 3
        Me.btnDelete3.ToolTip = "ลบรูป"
        '
        'btnAdd3
        '
        Me.btnAdd3.ImageIndex = 0
        Me.btnAdd3.ImageList = Me.ImageCollection1
        Me.btnAdd3.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAdd3.Location = New System.Drawing.Point(5, 5)
        Me.btnAdd3.Name = "btnAdd3"
        Me.btnAdd3.Size = New System.Drawing.Size(30, 20)
        Me.btnAdd3.TabIndex = 2
        Me.btnAdd3.ToolTip = "เพิ่มรูป"
        '
        'ucImage_4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupControl7)
        Me.Name = "ucImage_4"
        Me.Size = New System.Drawing.Size(370, 393)
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl7.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPro4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPro1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl6.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.picPro3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPro2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnCancel1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents btnDelete1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents picPro4 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents picPro1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnCancel4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelete4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnCancel2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelete2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents picPro3 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents picPro2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnCancel3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelete3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd3 As DevExpress.XtraEditors.SimpleButton

End Class
