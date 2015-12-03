<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaster))
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.GeneralTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.txtEng = New DevExpress.XtraEditors.TextEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.MenuBar = New DevExpress.XtraBars.Bar()
        Me.AddBar = New DevExpress.XtraBars.BarButtonItem()
        Me.EditBar = New DevExpress.XtraBars.BarButtonItem()
        Me.DeleteBar = New DevExpress.XtraBars.BarButtonItem()
        Me.SaveBar = New DevExpress.XtraBars.BarButtonItem()
        Me.RefreshBar = New DevExpress.XtraBars.BarButtonItem()
        Me.ExitBar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.cboFind = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.txtFind = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtRemark = New DevExpress.XtraEditors.MemoEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtThai = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AdminTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.CheckInAcive = New DevExpress.XtraEditors.CheckEdit()
        Me.txtModifiTime = New DevExpress.XtraEditors.TextEdit()
        Me.txtCreateTime = New DevExpress.XtraEditors.TextEdit()
        Me.txtModifiBy = New DevExpress.XtraEditors.TextEdit()
        Me.txtCreateBy = New DevExpress.XtraEditors.TextEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.FindBar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.GridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.GeneralTabPage.SuspendLayout()
        CType(Me.txtEng.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtThai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AdminTabPage.SuspendLayout()
        CType(Me.CheckInAcive.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtModifiTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCreateTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtModifiBy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCreateBy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(12, 46)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.GeneralTabPage
        Me.XtraTabControl1.Size = New System.Drawing.Size(780, 187)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.GeneralTabPage, Me.AdminTabPage})
        '
        'GeneralTabPage
        '
        Me.GeneralTabPage.Controls.Add(Me.txtEng)
        Me.GeneralTabPage.Controls.Add(Me.txtRemark)
        Me.GeneralTabPage.Controls.Add(Me.Label1)
        Me.GeneralTabPage.Controls.Add(Me.Label6)
        Me.GeneralTabPage.Controls.Add(Me.txtThai)
        Me.GeneralTabPage.Controls.Add(Me.Label4)
        Me.GeneralTabPage.Name = "GeneralTabPage"
        Me.GeneralTabPage.Size = New System.Drawing.Size(774, 159)
        Me.GeneralTabPage.Text = "ข้อมูลทั่วไป"
        '
        'txtEng
        '
        Me.txtEng.EditValue = ""
        Me.txtEng.EnterMoveNextControl = True
        Me.txtEng.Location = New System.Drawing.Point(151, 47)
        Me.txtEng.MenuManager = Me.BarManager1
        Me.txtEng.Name = "txtEng"
        Me.txtEng.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtEng.Properties.Appearance.Options.UseFont = True
        Me.txtEng.Properties.MaxLength = 50
        Me.txtEng.Properties.ValidateOnEnterKey = True
        Me.txtEng.Size = New System.Drawing.Size(399, 20)
        Me.txtEng.TabIndex = 1
        '
        'BarManager1
        '
        Me.BarManager1.AllowCustomization = False
        Me.BarManager1.AllowQuickCustomization = False
        Me.BarManager1.AllowShowToolbarsPopup = False
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.MenuBar})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Images = Me.ImageList1
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.AddBar, Me.EditBar, Me.DeleteBar, Me.RefreshBar, Me.BarButtonItem7, Me.ExitBar, Me.BarStaticItem1, Me.cboFind, Me.txtFind, Me.BarButtonItem1, Me.SaveBar})
        Me.BarManager1.MaxItemId = 24
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemComboBox1, Me.RepositoryItemTextEdit2})
        '
        'MenuBar
        '
        Me.MenuBar.BarName = "Menu"
        Me.MenuBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top
        Me.MenuBar.DockCol = 0
        Me.MenuBar.DockRow = 0
        Me.MenuBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.MenuBar.FloatLocation = New System.Drawing.Point(258, 150)
        Me.MenuBar.FloatSize = New System.Drawing.Size(270, 40)
        Me.MenuBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.AddBar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.EditBar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.DeleteBar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.SaveBar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.RefreshBar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.ExitBar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.MenuBar.OptionsBar.AllowQuickCustomization = False
        Me.MenuBar.Text = "Menu"
        '
        'AddBar
        '
        Me.AddBar.Border = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.AddBar.Caption = "เพิ่ม (F2)"
        Me.AddBar.Id = 8
        Me.AddBar.ImageIndex = 0
        Me.AddBar.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2)
        Me.AddBar.Name = "AddBar"
        '
        'EditBar
        '
        Me.EditBar.Border = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.EditBar.Caption = "แก้ไข (F3)"
        Me.EditBar.Id = 9
        Me.EditBar.ImageIndex = 1
        Me.EditBar.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3)
        Me.EditBar.Name = "EditBar"
        Me.EditBar.ShortcutKeyDisplayString = "F3"
        '
        'DeleteBar
        '
        Me.DeleteBar.Border = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.DeleteBar.Caption = "ลบ"
        Me.DeleteBar.Id = 10
        Me.DeleteBar.ImageIndex = 2
        Me.DeleteBar.Name = "DeleteBar"
        '
        'SaveBar
        '
        Me.SaveBar.Border = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.SaveBar.Caption = "บันทึก (F4)"
        Me.SaveBar.Id = 23
        Me.SaveBar.ImageIndex = 7
        Me.SaveBar.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F4)
        Me.SaveBar.Name = "SaveBar"
        Me.SaveBar.ShortcutKeyDisplayString = "F3"
        '
        'RefreshBar
        '
        Me.RefreshBar.Border = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.RefreshBar.Caption = "Refresh (F5)"
        Me.RefreshBar.Id = 11
        Me.RefreshBar.ImageIndex = 3
        Me.RefreshBar.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5)
        Me.RefreshBar.Name = "RefreshBar"
        '
        'ExitBar
        '
        Me.ExitBar.Border = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.ExitBar.Caption = "ปิดหน้าจอ (Esc)"
        Me.ExitBar.Id = 17
        Me.ExitBar.ImageIndex = 6
        Me.ExitBar.Name = "ExitBar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(804, 35)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 608)
        Me.barDockControlBottom.Size = New System.Drawing.Size(804, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 35)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 573)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(804, 35)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 573)
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Add.png")
        Me.ImageList1.Images.SetKeyName(1, "Edit.png")
        Me.ImageList1.Images.SetKeyName(2, "_active__remove_(delete).png")
        Me.ImageList1.Images.SetKeyName(3, "Refresh.png")
        Me.ImageList1.Images.SetKeyName(4, "_active__find.gif")
        Me.ImageList1.Images.SetKeyName(5, "pege_setup.gif")
        Me.ImageList1.Images.SetKeyName(6, "_active__exit.png")
        Me.ImageList1.Images.SetKeyName(7, "_active__save.png")
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Q"
        Me.BarButtonItem7.Id = 15
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "ค้นหาโดย"
        Me.BarStaticItem1.Id = 19
        Me.BarStaticItem1.Name = "BarStaticItem1"
        Me.BarStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'cboFind
        '
        Me.cboFind.Caption = "BarEditItem1"
        Me.cboFind.Edit = Me.RepositoryItemComboBox1
        Me.cboFind.Id = 20
        Me.cboFind.Name = "cboFind"
        Me.cboFind.Width = 150
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'txtFind
        '
        Me.txtFind.Caption = "."
        Me.txtFind.Edit = Me.RepositoryItemTextEdit2
        Me.txtFind.Id = 21
        Me.txtFind.Name = "txtFind"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 22
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'txtRemark
        '
        Me.txtRemark.EditValue = ""
        Me.txtRemark.Location = New System.Drawing.Point(151, 74)
        Me.txtRemark.MenuManager = Me.BarManager1
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRemark.Properties.Appearance.Options.UseFont = True
        Me.txtRemark.Properties.MaxLength = 500
        Me.txtRemark.Size = New System.Drawing.Size(607, 82)
        Me.txtRemark.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 14)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "รายละเอียด"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 14)
        Me.Label6.TabIndex = 130
        Me.Label6.Text = "ชื่อข้อความ (Eng)"
        '
        'txtThai
        '
        Me.txtThai.EditValue = ""
        Me.txtThai.EnterMoveNextControl = True
        Me.txtThai.Location = New System.Drawing.Point(151, 20)
        Me.txtThai.MenuManager = Me.BarManager1
        Me.txtThai.Name = "txtThai"
        Me.txtThai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtThai.Properties.Appearance.Options.UseFont = True
        Me.txtThai.Properties.MaxLength = 50
        Me.txtThai.Properties.ValidateOnEnterKey = True
        Me.txtThai.Size = New System.Drawing.Size(399, 20)
        Me.txtThai.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(34, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 14)
        Me.Label4.TabIndex = 109
        Me.Label4.Text = "ชื่อข้อความ"
        '
        'AdminTabPage
        '
        Me.AdminTabPage.Controls.Add(Me.CheckInAcive)
        Me.AdminTabPage.Controls.Add(Me.txtModifiTime)
        Me.AdminTabPage.Controls.Add(Me.txtCreateTime)
        Me.AdminTabPage.Controls.Add(Me.txtModifiBy)
        Me.AdminTabPage.Controls.Add(Me.txtCreateBy)
        Me.AdminTabPage.Controls.Add(Me.Label7)
        Me.AdminTabPage.Controls.Add(Me.Label3)
        Me.AdminTabPage.Controls.Add(Me.Label2)
        Me.AdminTabPage.Controls.Add(Me.Label36)
        Me.AdminTabPage.Name = "AdminTabPage"
        Me.AdminTabPage.Size = New System.Drawing.Size(774, 159)
        Me.AdminTabPage.Text = "ผู้บันทึก"
        '
        'CheckInAcive
        '
        Me.CheckInAcive.Location = New System.Drawing.Point(118, 124)
        Me.CheckInAcive.MenuManager = Me.BarManager1
        Me.CheckInAcive.Name = "CheckInAcive"
        Me.CheckInAcive.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckInAcive.Properties.Appearance.Options.UseFont = True
        Me.CheckInAcive.Properties.Caption = "ระงับการใช้งาน"
        Me.CheckInAcive.Size = New System.Drawing.Size(108, 19)
        Me.CheckInAcive.TabIndex = 178
        '
        'txtModifiTime
        '
        Me.txtModifiTime.EditValue = ""
        Me.txtModifiTime.EnterMoveNextControl = True
        Me.txtModifiTime.Location = New System.Drawing.Point(369, 73)
        Me.txtModifiTime.MenuManager = Me.BarManager1
        Me.txtModifiTime.Name = "txtModifiTime"
        Me.txtModifiTime.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.txtModifiTime.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtModifiTime.Properties.Appearance.Options.UseBackColor = True
        Me.txtModifiTime.Properties.Appearance.Options.UseFont = True
        Me.txtModifiTime.Properties.MaxLength = 50
        Me.txtModifiTime.Properties.ReadOnly = True
        Me.txtModifiTime.Properties.ValidateOnEnterKey = True
        Me.txtModifiTime.Size = New System.Drawing.Size(160, 20)
        Me.txtModifiTime.TabIndex = 177
        '
        'txtCreateTime
        '
        Me.txtCreateTime.EditValue = ""
        Me.txtCreateTime.EnterMoveNextControl = True
        Me.txtCreateTime.Location = New System.Drawing.Point(369, 34)
        Me.txtCreateTime.MenuManager = Me.BarManager1
        Me.txtCreateTime.Name = "txtCreateTime"
        Me.txtCreateTime.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.txtCreateTime.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCreateTime.Properties.Appearance.Options.UseBackColor = True
        Me.txtCreateTime.Properties.Appearance.Options.UseFont = True
        Me.txtCreateTime.Properties.MaxLength = 50
        Me.txtCreateTime.Properties.ReadOnly = True
        Me.txtCreateTime.Properties.ValidateOnEnterKey = True
        Me.txtCreateTime.Size = New System.Drawing.Size(160, 20)
        Me.txtCreateTime.TabIndex = 176
        '
        'txtModifiBy
        '
        Me.txtModifiBy.EditValue = ""
        Me.txtModifiBy.EnterMoveNextControl = True
        Me.txtModifiBy.Location = New System.Drawing.Point(120, 73)
        Me.txtModifiBy.MenuManager = Me.BarManager1
        Me.txtModifiBy.Name = "txtModifiBy"
        Me.txtModifiBy.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.txtModifiBy.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtModifiBy.Properties.Appearance.Options.UseBackColor = True
        Me.txtModifiBy.Properties.Appearance.Options.UseFont = True
        Me.txtModifiBy.Properties.MaxLength = 50
        Me.txtModifiBy.Properties.ReadOnly = True
        Me.txtModifiBy.Properties.ValidateOnEnterKey = True
        Me.txtModifiBy.Size = New System.Drawing.Size(160, 20)
        Me.txtModifiBy.TabIndex = 175
        '
        'txtCreateBy
        '
        Me.txtCreateBy.EditValue = ""
        Me.txtCreateBy.EnterMoveNextControl = True
        Me.txtCreateBy.Location = New System.Drawing.Point(120, 34)
        Me.txtCreateBy.MenuManager = Me.BarManager1
        Me.txtCreateBy.Name = "txtCreateBy"
        Me.txtCreateBy.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.txtCreateBy.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCreateBy.Properties.Appearance.Options.UseBackColor = True
        Me.txtCreateBy.Properties.Appearance.Options.UseFont = True
        Me.txtCreateBy.Properties.MaxLength = 50
        Me.txtCreateBy.Properties.ReadOnly = True
        Me.txtCreateBy.Properties.ValidateOnEnterKey = True
        Me.txtCreateBy.Size = New System.Drawing.Size(160, 20)
        Me.txtCreateBy.TabIndex = 174
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(300, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 14)
        Me.Label7.TabIndex = 173
        Me.Label7.Text = "แก้ไขเมื่อ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 14)
        Me.Label3.TabIndex = 172
        Me.Label3.Text = "แก้ไขล่าสุดโดย"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(300, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 14)
        Me.Label2.TabIndex = 171
        Me.Label2.Text = "สร้างเมื่อ"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label36.Location = New System.Drawing.Point(23, 37)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(38, 14)
        Me.Label36.TabIndex = 170
        Me.Label36.Text = "ผู้สร้าง"
        '
        'FindBar
        '
        Me.FindBar.Caption = "ค้นหา"
        Me.FindBar.Id = 16
        Me.FindBar.ImageIndex = 4
        Me.FindBar.Name = "FindBar"
        '
        'BarSubItem2
        '
        Me.BarSubItem2.Id = 14
        Me.BarSubItem2.ImageIndex = 5
        Me.BarSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7)})
        Me.BarSubItem2.Name = "BarSubItem2"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Refresh"
        Me.BarButtonItem2.Id = 11
        Me.BarButtonItem2.ImageIndex = 3
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Refresh"
        Me.BarButtonItem3.Id = 11
        Me.BarButtonItem3.ImageIndex = 3
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'GridControl
        '
        Me.GridControl.Location = New System.Drawing.Point(13, 239)
        Me.GridControl.MainView = Me.GridView
        Me.GridControl.MenuManager = Me.BarManager1
        Me.GridControl.Name = "GridControl"
        Me.GridControl.Size = New System.Drawing.Size(779, 357)
        Me.GridControl.TabIndex = 5
        Me.GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
        '
        'GridView
        '
        Me.GridView.GridControl = Me.GridControl
        Me.GridView.Name = "GridView"
        Me.GridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView.OptionsBehavior.Editable = False
        Me.GridView.OptionsBehavior.ReadOnly = True
        Me.GridView.OptionsLayout.Columns.AddNewColumns = False
        Me.GridView.OptionsLayout.Columns.RemoveOldColumns = False
        Me.GridView.OptionsView.ColumnAutoWidth = False
        Me.GridView.OptionsView.ShowGroupPanel = False
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(118, 124)
        Me.CheckEdit1.MenuManager = Me.BarManager1
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Caption = "ระงับการใช้งาน"
        Me.CheckEdit1.Size = New System.Drawing.Size(108, 19)
        Me.CheckEdit1.TabIndex = 178
        '
        'frmMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 608)
        Me.Controls.Add(Me.GridControl)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMaster"
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.GeneralTabPage.ResumeLayout(False)
        Me.GeneralTabPage.PerformLayout()
        CType(Me.txtEng.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtThai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AdminTabPage.ResumeLayout(False)
        Me.AdminTabPage.PerformLayout()
        CType(Me.CheckInAcive.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtModifiTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCreateTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtModifiBy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCreateBy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents GeneralTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents AdminTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents MenuBar As DevExpress.XtraBars.Bar
    Friend WithEvents AddBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents EditBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DeleteBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RefreshBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ExitBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents cboFind As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents txtFind As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents FindBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem2 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents SaveBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtThai As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckInAcive As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtModifiTime As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCreateTime As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtModifiBy As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCreateBy As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtEng As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRemark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit

End Class
