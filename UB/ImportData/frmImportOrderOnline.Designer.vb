<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmImportOrderOnline
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImportOrderOnline))
        Me.WizardControl1 = New DevExpress.XtraWizard.WizardControl()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.BrowsPage = New DevExpress.XtraWizard.WizardPage()
        Me.RadioCompany = New DevExpress.XtraEditors.RadioGroup()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnBrows = New DevExpress.XtraEditors.SimpleButton()
        Me.txtFileName = New DevExpress.XtraEditors.TextEdit()
        Me.GridPage = New DevExpress.XtraWizard.WizardPage()
        Me.txtError = New DevExpress.XtraEditors.MemoEdit()
        Me.GridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CompletionWizardPage1 = New DevExpress.XtraWizard.CompletionWizardPage()
        Me.lblError = New System.Windows.Forms.Label()
        CType(Me.WizardControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WizardControl1.SuspendLayout()
        Me.BrowsPage.SuspendLayout()
        CType(Me.RadioCompany.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.WizardControl1.Controls.Add(Me.BrowsPage)
        Me.WizardControl1.Controls.Add(Me.GridPage)
        Me.WizardControl1.Controls.Add(Me.CompletionWizardPage1)
        Me.WizardControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WizardControl1.ImageOptions.Image = CType(resources.GetObject("WizardControl1.ImageOptions.Image"), System.Drawing.Image)
        Me.WizardControl1.ImageOptions.ImageWidth = 250
        Me.WizardControl1.ImageOptions.Layout = System.Windows.Forms.ImageLayout.None
        Me.WizardControl1.Name = "WizardControl1"
        Me.WizardControl1.Pages.AddRange(New DevExpress.XtraWizard.BaseWizardPage() {Me.BrowsPage, Me.GridPage, Me.CompletionWizardPage1})
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
        'BrowsPage
        '
        Me.BrowsPage.Controls.Add(Me.lblError)
        Me.BrowsPage.Controls.Add(Me.RadioCompany)
        Me.BrowsPage.Controls.Add(Me.Label19)
        Me.BrowsPage.Controls.Add(Me.Label8)
        Me.BrowsPage.Controls.Add(Me.btnBrows)
        Me.BrowsPage.Controls.Add(Me.txtFileName)
        Me.BrowsPage.DescriptionText = ""
        Me.BrowsPage.Name = "BrowsPage"
        Me.BrowsPage.Size = New System.Drawing.Size(1151, 377)
        Me.BrowsPage.Text = "กรุณาเลือกไฟล์สำหรับการ Import"
        '
        'RadioCompany
        '
        Me.RadioCompany.EditValue = "Shopee"
        Me.RadioCompany.Location = New System.Drawing.Point(101, 46)
        Me.RadioCompany.Name = "RadioCompany"
        Me.RadioCompany.Properties.Columns = 2
        Me.RadioCompany.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("Shopee", "Shopee"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Lazada", "Lazada")})
        Me.RadioCompany.Size = New System.Drawing.Size(496, 30)
        Me.RadioCompany.TabIndex = 360
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label19.Location = New System.Drawing.Point(46, 53)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(38, 14)
        Me.Label19.TabIndex = 359
        Me.Label19.Text = "บริษัท"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(46, 103)
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
        Me.btnBrows.Location = New System.Drawing.Point(603, 100)
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
        Me.txtFileName.Location = New System.Drawing.Point(101, 100)
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
        'GridPage
        '
        Me.GridPage.Controls.Add(Me.txtError)
        Me.GridPage.Controls.Add(Me.GridControl)
        Me.GridPage.Name = "GridPage"
        Me.GridPage.Size = New System.Drawing.Size(1151, 377)
        Me.GridPage.Text = "กรุณาตรวจสอบข้อมูล, กด Next เพื่อทำรายการตัดรับชำระ หรือกด Back เพื่อทำการ Import" &
    " File อีกครั้ง"
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
        'CompletionWizardPage1
        '
        Me.CompletionWizardPage1.Name = "CompletionWizardPage1"
        Me.CompletionWizardPage1.Size = New System.Drawing.Size(901, 388)
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.BackColor = System.Drawing.Color.Transparent
        Me.lblError.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblError.Location = New System.Drawing.Point(98, 142)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(33, 14)
        Me.lblError.TabIndex = 361
        Me.lblError.Text = "Error"
        '
        'frmImportOrderOnline
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1183, 520)
        Me.Controls.Add(Me.WizardControl1)
        Me.Name = "frmImportOrderOnline"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.WizardControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WizardControl1.ResumeLayout(False)
        Me.BrowsPage.ResumeLayout(False)
        Me.BrowsPage.PerformLayout()
        CType(Me.RadioCompany.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFileName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridPage.ResumeLayout(False)
        CType(Me.txtError.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WizardControl1 As DevExpress.XtraWizard.WizardControl
    Friend WithEvents BrowsPage As DevExpress.XtraWizard.WizardPage
    Friend WithEvents btnBrows As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFileName As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GridPage As DevExpress.XtraWizard.WizardPage
    Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents txtError As DevExpress.XtraEditors.MemoEdit
    Private WithEvents Label19 As Label
    Friend WithEvents RadioCompany As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents CompletionWizardPage1 As DevExpress.XtraWizard.CompletionWizardPage
    Private WithEvents lblError As Label
End Class
