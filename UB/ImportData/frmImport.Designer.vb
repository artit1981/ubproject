<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImport))
        Me.WizardControl1 = New DevExpress.XtraWizard.WizardControl()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.WelcomeWizardPage1 = New DevExpress.XtraWizard.WelcomeWizardPage()
        Me.BrowsPage = New DevExpress.XtraWizard.WizardPage()
        Me.rdoType = New DevExpress.XtraEditors.RadioGroup()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnBrows = New DevExpress.XtraEditors.SimpleButton()
        Me.txtFileName = New DevExpress.XtraEditors.TextEdit()
        Me.CompletionWizardPage1 = New DevExpress.XtraWizard.CompletionWizardPage()
        Me.GridPage = New DevExpress.XtraWizard.WizardPage()
        Me.txtError = New DevExpress.XtraEditors.MemoEdit()
        Me.GridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.WizardControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WizardControl1.SuspendLayout()
        Me.BrowsPage.SuspendLayout()
        CType(Me.rdoType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFileName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridPage.SuspendLayout()
        CType(Me.txtError.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WizardControl1
        '
        Me.WizardControl1.Appearance.AeroWizardTitle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WizardControl1.Appearance.AeroWizardTitle.Options.UseFont = True
        Me.WizardControl1.Appearance.ExteriorPage.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WizardControl1.Appearance.ExteriorPage.Options.UseFont = True
        Me.WizardControl1.Appearance.Page.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WizardControl1.Appearance.Page.Options.UseFont = True
        Me.WizardControl1.Appearance.PageTitle.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WizardControl1.Appearance.PageTitle.Options.UseFont = True
        Me.WizardControl1.Controls.Add(Me.Splitter1)
        Me.WizardControl1.Controls.Add(Me.WelcomeWizardPage1)
        Me.WizardControl1.Controls.Add(Me.BrowsPage)
        Me.WizardControl1.Controls.Add(Me.CompletionWizardPage1)
        Me.WizardControl1.Controls.Add(Me.GridPage)
        Me.WizardControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WizardControl1.ImageOptions.Image = CType(resources.GetObject("WizardControl1.ImageOptions.Image"), System.Drawing.Image)
        Me.WizardControl1.ImageOptions.ImageWidth = 250
        Me.WizardControl1.ImageOptions.Layout = System.Windows.Forms.ImageLayout.None
        Me.WizardControl1.Name = "WizardControl1"
        Me.WizardControl1.Pages.AddRange(New DevExpress.XtraWizard.BaseWizardPage() {Me.WelcomeWizardPage1, Me.BrowsPage, Me.GridPage, Me.CompletionWizardPage1})
        Me.WizardControl1.Size = New System.Drawing.Size(1183, 520)
        Me.WizardControl1.Text = "Import"
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 520)
        Me.Splitter1.TabIndex = 11
        Me.Splitter1.TabStop = False
        '
        'WelcomeWizardPage1
        '
        Me.WelcomeWizardPage1.IntroductionText = "กรุณาเตรียมไฟล์สำหรับใช้ในการ Import ตามรูปแบบที่กำหนดไว้"
        Me.WelcomeWizardPage1.Name = "WelcomeWizardPage1"
        Me.WelcomeWizardPage1.ProceedText = "กด Next เพื่อเริ่มต้นการทำงาน"
        Me.WelcomeWizardPage1.Size = New System.Drawing.Size(901, 388)
        Me.WelcomeWizardPage1.Text = "Import Products"
        '
        'BrowsPage
        '
        Me.BrowsPage.Controls.Add(Me.rdoType)
        Me.BrowsPage.Controls.Add(Me.Label8)
        Me.BrowsPage.Controls.Add(Me.btnBrows)
        Me.BrowsPage.Controls.Add(Me.txtFileName)
        Me.BrowsPage.DescriptionText = ""
        Me.BrowsPage.Name = "BrowsPage"
        Me.BrowsPage.Size = New System.Drawing.Size(1151, 377)
        Me.BrowsPage.Text = "กรุณาเลือกไฟล์สำหรับการ Import"
        '
        'rdoType
        '
        Me.rdoType.EditValue = "I"
        Me.rdoType.EnterMoveNextControl = True
        Me.rdoType.Location = New System.Drawing.Point(87, 96)
        Me.rdoType.Name = "rdoType"
        Me.rdoType.Properties.Columns = 3
        Me.rdoType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("I", "Import"), New DevExpress.XtraEditors.Controls.RadioGroupItem("E", "Export")})
        Me.rdoType.Size = New System.Drawing.Size(245, 25)
        Me.rdoType.TabIndex = 220
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(39, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 14)
        Me.Label8.TabIndex = 219
        Me.Label8.Text = "ชื่อไฟล์"
        '
        'btnBrows
        '
        Me.btnBrows.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnBrows.Appearance.Options.UseFont = True
        Me.btnBrows.ImageOptions.Image = CType(resources.GetObject("btnBrows.ImageOptions.Image"), System.Drawing.Image)
        Me.btnBrows.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnBrows.Location = New System.Drawing.Point(589, 49)
        Me.btnBrows.Name = "btnBrows"
        Me.btnBrows.Size = New System.Drawing.Size(21, 21)
        Me.btnBrows.TabIndex = 218
        Me.btnBrows.TabStop = False
        Me.btnBrows.ToolTip = "Auto ID"
        '
        'txtFileName
        '
        Me.txtFileName.EditValue = ""
        Me.txtFileName.EnterMoveNextControl = True
        Me.txtFileName.Location = New System.Drawing.Point(87, 49)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.txtFileName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtFileName.Properties.Appearance.Options.UseBackColor = True
        Me.txtFileName.Properties.Appearance.Options.UseFont = True
        Me.txtFileName.Properties.MaxLength = 50
        Me.txtFileName.Properties.ReadOnly = True
        Me.txtFileName.Properties.ValidateOnEnterKey = True
        Me.txtFileName.Size = New System.Drawing.Size(496, 20)
        Me.txtFileName.TabIndex = 217
        '
        'CompletionWizardPage1
        '
        Me.CompletionWizardPage1.Name = "CompletionWizardPage1"
        Me.CompletionWizardPage1.Size = New System.Drawing.Size(901, 388)
        '
        'GridPage
        '
        Me.GridPage.Controls.Add(Me.txtError)
        Me.GridPage.Controls.Add(Me.GridControl)
        Me.GridPage.Name = "GridPage"
        Me.GridPage.Size = New System.Drawing.Size(1151, 377)
        Me.GridPage.Text = "กรุณาตรวจสอบข้อมูล, กด Next เพื่อดำเนินการต่อ หรือกด Back เพื่อทำการแก้ไข"
        '
        'txtError
        '
        Me.txtError.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtError.Location = New System.Drawing.Point(0, 262)
        Me.txtError.Name = "txtError"
        Me.txtError.Size = New System.Drawing.Size(1148, 112)
        Me.txtError.TabIndex = 19
        '
        'GridControl
        '
        Me.GridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl.Location = New System.Drawing.Point(0, 0)
        Me.GridControl.MainView = Me.GridView
        Me.GridControl.Name = "GridControl"
        Me.GridControl.Size = New System.Drawing.Size(1148, 256)
        Me.GridControl.TabIndex = 18
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
        Me.GridView.OptionsMenu.EnableColumnMenu = False
        Me.GridView.OptionsMenu.EnableFooterMenu = False
        Me.GridView.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView.OptionsMenu.ShowGroupSortSummaryItems = False
        Me.GridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.GridView.OptionsView.ShowGroupPanel = False
        Me.GridView.OptionsView.ShowViewCaption = True
        '
        'frmImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1183, 520)
        Me.Controls.Add(Me.WizardControl1)
        Me.Name = "frmImport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.WizardControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WizardControl1.ResumeLayout(False)
        Me.BrowsPage.ResumeLayout(False)
        Me.BrowsPage.PerformLayout()
        CType(Me.rdoType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFileName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridPage.ResumeLayout(False)
        CType(Me.txtError.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WizardControl1 As DevExpress.XtraWizard.WizardControl
    Friend WithEvents WelcomeWizardPage1 As DevExpress.XtraWizard.WelcomeWizardPage
    Friend WithEvents BrowsPage As DevExpress.XtraWizard.WizardPage
    Friend WithEvents CompletionWizardPage1 As DevExpress.XtraWizard.CompletionWizardPage
    Friend WithEvents btnBrows As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFileName As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GridPage As DevExpress.XtraWizard.WizardPage
    Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents txtError As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents rdoType As DevExpress.XtraEditors.RadioGroup
End Class
