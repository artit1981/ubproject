<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActivityLog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmActivityLog))
        Me.SplitControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboMenu = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnRefreshMenu = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EndDate = New DevExpress.XtraEditors.DateEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StartDate = New DevExpress.XtraEditors.DateEdit()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cboUser = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnRefreshUser = New DevExpress.XtraEditors.SimpleButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.SplitControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cboMenu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EndDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EndDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitControl1
        '
        Me.SplitControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitControl1.Name = "SplitControl1"
        Me.SplitControl1.Panel1.Controls.Add(Me.GroupControl1)
        Me.SplitControl1.Panel1.Controls.Add(Me.Label10)
        Me.SplitControl1.Panel1.Text = "Panel1"
        Me.SplitControl1.Panel2.Controls.Add(Me.GridControl)
        Me.SplitControl1.Panel2.Text = "Panel2"
        Me.SplitControl1.Size = New System.Drawing.Size(862, 662)
        Me.SplitControl1.SplitterPosition = 241
        Me.SplitControl1.TabIndex = 19
        Me.SplitControl1.Text = "SplitContainerControl1"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.btnOK)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.cboMenu)
        Me.GroupControl1.Controls.Add(Me.btnRefreshMenu)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.EndDate)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.StartDate)
        Me.GroupControl1.Controls.Add(Me.Label22)
        Me.GroupControl1.Controls.Add(Me.cboUser)
        Me.GroupControl1.Controls.Add(Me.btnRefreshUser)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 37)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(219, 193)
        Me.GroupControl1.TabIndex = 202
        Me.GroupControl1.Text = "เงื่อนไขการค้นหา"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.ImageIndex = 2
        Me.btnOK.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnOK.Location = New System.Drawing.Point(140, 155)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(46, 25)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        Me.btnOK.ToolTip = "OK"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 14)
        Me.Label3.TabIndex = 210
        Me.Label3.Text = "หน้าจอ"
        '
        'cboMenu
        '
        Me.cboMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboMenu.EditValue = ""
        Me.cboMenu.Location = New System.Drawing.Point(57, 117)
        Me.cboMenu.Name = "cboMenu"
        Me.cboMenu.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.cboMenu.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMenu.Properties.Appearance.Options.UseFont = True
        Me.cboMenu.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboMenu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMenu.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MenuID", "MenuID", 50, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MenuDisplay", 50, "ชื่อเมนู")})
        Me.cboMenu.Properties.DropDownRows = 10
        Me.cboMenu.Properties.NullText = ""
        Me.cboMenu.Properties.NullValuePromptShowForEmptyValue = True
        Me.cboMenu.Properties.PopupWidth = 300
        Me.cboMenu.Size = New System.Drawing.Size(129, 20)
        Me.cboMenu.TabIndex = 3
        '
        'btnRefreshMenu
        '
        Me.btnRefreshMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefreshMenu.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRefreshMenu.Appearance.Options.UseFont = True
        Me.btnRefreshMenu.Image = CType(resources.GetObject("btnRefreshMenu.Image"), System.Drawing.Image)
        Me.btnRefreshMenu.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefreshMenu.Location = New System.Drawing.Point(188, 117)
        Me.btnRefreshMenu.Name = "btnRefreshMenu"
        Me.btnRefreshMenu.Size = New System.Drawing.Size(22, 21)
        Me.btnRefreshMenu.TabIndex = 208
        Me.btnRefreshMenu.TabStop = False
        Me.btnRefreshMenu.ToolTip = "Refresh"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 14)
        Me.Label2.TabIndex = 207
        Me.Label2.Text = "ผู้ใช้งาน"
        '
        'EndDate
        '
        Me.EndDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EndDate.EditValue = New Date(2012, 4, 20, 0, 0, 0, 0)
        Me.EndDate.EnterMoveNextControl = True
        Me.EndDate.Location = New System.Drawing.Point(57, 63)
        Me.EndDate.Name = "EndDate"
        Me.EndDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.EndDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.EndDate.Properties.Appearance.Options.UseFont = True
        Me.EndDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EndDate.Properties.EditFormat.FormatString = "D"
        Me.EndDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.EndDate.Properties.Mask.EditMask = "mm."
        Me.EndDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.EndDate.Size = New System.Drawing.Size(129, 20)
        Me.EndDate.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 14)
        Me.Label1.TabIndex = 205
        Me.Label1.Text = "วันสิ้นสุด"
        '
        'StartDate
        '
        Me.StartDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartDate.EditValue = New Date(2012, 4, 20, 0, 0, 0, 0)
        Me.StartDate.EnterMoveNextControl = True
        Me.StartDate.Location = New System.Drawing.Point(57, 35)
        Me.StartDate.Name = "StartDate"
        Me.StartDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.StartDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.StartDate.Properties.Appearance.Options.UseFont = True
        Me.StartDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StartDate.Properties.EditFormat.FormatString = "D"
        Me.StartDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.StartDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.StartDate.Size = New System.Drawing.Size(129, 20)
        Me.StartDate.TabIndex = 0
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label22.Location = New System.Drawing.Point(5, 38)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(50, 14)
        Me.Label22.TabIndex = 203
        Me.Label22.Text = "วันเริ่มต้น"
        '
        'cboUser
        '
        Me.cboUser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboUser.EditValue = ""
        Me.cboUser.Location = New System.Drawing.Point(57, 90)
        Me.cboUser.Name = "cboUser"
        Me.cboUser.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.cboUser.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUser.Properties.Appearance.Options.UseFont = True
        Me.cboUser.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboUser.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboUser.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 50, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserName", 40, "ชื่อเข้าระบบ"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmpName", "ชื่อพนักงาน", 40, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Center), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Remark", 70, "รายละเอียด")})
        Me.cboUser.Properties.DropDownRows = 10
        Me.cboUser.Properties.NullText = ""
        Me.cboUser.Properties.NullValuePromptShowForEmptyValue = True
        Me.cboUser.Properties.PopupWidth = 300
        Me.cboUser.Size = New System.Drawing.Size(129, 20)
        Me.cboUser.TabIndex = 2
        '
        'btnRefreshUser
        '
        Me.btnRefreshUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefreshUser.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRefreshUser.Appearance.Options.UseFont = True
        Me.btnRefreshUser.Image = CType(resources.GetObject("btnRefreshUser.Image"), System.Drawing.Image)
        Me.btnRefreshUser.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefreshUser.Location = New System.Drawing.Point(188, 90)
        Me.btnRefreshUser.Name = "btnRefreshUser"
        Me.btnRefreshUser.Size = New System.Drawing.Size(22, 21)
        Me.btnRefreshUser.TabIndex = 201
        Me.btnRefreshUser.TabStop = False
        Me.btnRefreshUser.ToolTip = "Refresh"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(-99, 162)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 14)
        Me.Label10.TabIndex = 190
        Me.Label10.Text = "หัวหน้าแผนก"
        '
        'GridControl
        '
        Me.GridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl.Location = New System.Drawing.Point(0, 0)
        Me.GridControl.MainView = Me.GridView
        Me.GridControl.Name = "GridControl"
        Me.GridControl.Size = New System.Drawing.Size(616, 662)
        Me.GridControl.TabIndex = 17
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
        Me.GridView.OptionsView.ShowViewCaption = True
        '
        'frmActivityLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 662)
        Me.Controls.Add(Me.SplitControl1)
        Me.KeyPreview = True
        Me.Name = "frmActivityLog"
        Me.Text = "frmActivityLog"
        CType(Me.SplitControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitControl1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cboMenu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EndDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EndDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents cboMenu As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnRefreshMenu As DevExpress.XtraEditors.SimpleButton
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents EndDate As DevExpress.XtraEditors.DateEdit
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StartDate As DevExpress.XtraEditors.DateEdit
    Private WithEvents Label22 As System.Windows.Forms.Label
    Private WithEvents cboUser As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnRefreshUser As DevExpress.XtraEditors.SimpleButton
End Class
