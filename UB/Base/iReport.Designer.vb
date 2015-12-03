<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(iReport))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.PrintBar2 = New DevExpress.XtraBars.BarButtonItem()
        Me.ExitBar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.MakeOrderBar = New DevExpress.XtraBars.BarButtonItem()
        Me.PrintBar = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Add.png")
        Me.ImageList1.Images.SetKeyName(1, "_active__save.png")
        Me.ImageList1.Images.SetKeyName(2, "save_apply copy.png")
        Me.ImageList1.Images.SetKeyName(3, "pege_setup.gif")
        Me.ImageList1.Images.SetKeyName(4, "_active__exit.png")
        Me.ImageList1.Images.SetKeyName(5, "printE.gif")
        '
        'BarManager1
        '
        Me.BarManager1.AllowCustomization = False
        Me.BarManager1.AllowQuickCustomization = False
        Me.BarManager1.AllowShowToolbarsPopup = False
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Images = Me.ImageList1
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ExitBar, Me.PrintBar2, Me.MakeOrderBar})
        Me.BarManager1.MaxItemId = 8
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.FloatLocation = New System.Drawing.Point(379, 152)
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.PrintBar2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.ExitBar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.Text = "Tools"
        '
        'PrintBar2
        '
        Me.PrintBar2.Caption = "พิมพ์"
        Me.PrintBar2.Id = 6
        Me.PrintBar2.ImageIndex = 5
        Me.PrintBar2.Name = "PrintBar2"
        '
        'ExitBar
        '
        Me.ExitBar.Border = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.ExitBar.Caption = "ปิดหน้าจอ (Esc)"
        Me.ExitBar.Id = 3
        Me.ExitBar.ImageIndex = 4
        Me.ExitBar.Name = "ExitBar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(870, 37)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 616)
        Me.barDockControlBottom.Size = New System.Drawing.Size(870, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 37)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 579)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(870, 37)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 579)
        '
        'MakeOrderBar
        '
        Me.MakeOrderBar.Caption = "Make Order"
        Me.MakeOrderBar.Id = 7
        Me.MakeOrderBar.Name = "MakeOrderBar"
        Me.MakeOrderBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'PrintBar
        '
        Me.PrintBar.Border = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.PrintBar.Caption = "พิมพ์"
        Me.PrintBar.Id = 28
        Me.PrintBar.ImageIndex = 7
        Me.PrintBar.Name = "PrintBar"
        '
        'iReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 616)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.KeyPreview = True
        Me.Name = "iReport"
        Me.Text = "iEditForm"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Private WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents ExitBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PrintBar2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PrintBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MakeOrderBar As DevExpress.XtraBars.BarButtonItem
End Class
