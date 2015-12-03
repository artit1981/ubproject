<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmApproveStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmApproveStock))
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.chkIsDiff = New DevExpress.XtraEditors.CheckEdit()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.lblRemark = New System.Windows.Forms.Label()
        Me.btnSetStock = New DevExpress.XtraEditors.SimpleButton()
        Me.rdoStockUse = New DevExpress.XtraEditors.RadioGroup()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnExportExcel = New DevExpress.XtraEditors.PictureEdit()
        Me.cboRefreshTime = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.CheckIsRefresh = New DevExpress.XtraEditors.CheckEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.CheckShowInfo = New DevExpress.XtraEditors.CheckEdit()
        Me.cboStatus = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnProductType = New DevExpress.XtraEditors.SimpleButton()
        Me.ProductTypeID = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnProductCategory = New DevExpress.XtraEditors.SimpleButton()
        Me.ProductCategoryID = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnProductGroup = New DevExpress.XtraEditors.SimpleButton()
        Me.ProductGroupID = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.btnBrandRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ProductBrandID = New DevExpress.XtraEditors.LookUpEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFind = New DevExpress.XtraEditors.SimpleButton()
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ProductBtn = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.PriceCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.chkIsDiff.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.rdoStockUse.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.btnExportExcel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRefreshTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckIsRefresh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckShowInfo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductTypeID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductCategoryID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductGroupID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBrandID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Controls.Add(Me.chkIsDiff)
        Me.PanelControl2.Controls.Add(Me.PanelControl3)
        Me.PanelControl2.Controls.Add(Me.PanelControl1)
        Me.PanelControl2.Controls.Add(Me.btnProductType)
        Me.PanelControl2.Controls.Add(Me.ProductTypeID)
        Me.PanelControl2.Controls.Add(Me.btnProductCategory)
        Me.PanelControl2.Controls.Add(Me.ProductCategoryID)
        Me.PanelControl2.Controls.Add(Me.btnProductGroup)
        Me.PanelControl2.Controls.Add(Me.ProductGroupID)
        Me.PanelControl2.Controls.Add(Me.Label33)
        Me.PanelControl2.Controls.Add(Me.btnBrandRefresh)
        Me.PanelControl2.Controls.Add(Me.Label19)
        Me.PanelControl2.Controls.Add(Me.Label18)
        Me.PanelControl2.Controls.Add(Me.Label10)
        Me.PanelControl2.Controls.Add(Me.ProductBrandID)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Controls.Add(Me.btnFind)
        Me.PanelControl2.Location = New System.Drawing.Point(4, 3)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1017, 115)
        Me.PanelControl2.TabIndex = 226
        '
        'chkIsDiff
        '
        Me.chkIsDiff.EditValue = True
        Me.chkIsDiff.Location = New System.Drawing.Point(358, 5)
        Me.chkIsDiff.Name = "chkIsDiff"
        Me.chkIsDiff.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIsDiff.Properties.Appearance.Options.UseFont = True
        Me.chkIsDiff.Properties.Caption = "แสดงเฉพาะรายการที่แตกต่าง"
        Me.chkIsDiff.Size = New System.Drawing.Size(184, 19)
        Me.chkIsDiff.TabIndex = 300
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.lblRemark)
        Me.PanelControl3.Controls.Add(Me.btnSetStock)
        Me.PanelControl3.Controls.Add(Me.rdoStockUse)
        Me.PanelControl3.Location = New System.Drawing.Point(548, 12)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(320, 95)
        Me.PanelControl3.TabIndex = 299
        '
        'lblRemark
        '
        Me.lblRemark.AutoSize = True
        Me.lblRemark.BackColor = System.Drawing.Color.Transparent
        Me.lblRemark.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblRemark.ForeColor = System.Drawing.Color.Blue
        Me.lblRemark.Location = New System.Drawing.Point(5, 15)
        Me.lblRemark.Name = "lblRemark"
        Me.lblRemark.Size = New System.Drawing.Size(29, 16)
        Me.lblRemark.TabIndex = 298
        Me.lblRemark.Text = "N/A"
        '
        'btnSetStock
        '
        Me.btnSetStock.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSetStock.Appearance.Options.UseFont = True
        Me.btnSetStock.Appearance.Options.UseImage = True
        Me.btnSetStock.Image = CType(resources.GetObject("btnSetStock.Image"), System.Drawing.Image)
        Me.btnSetStock.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnSetStock.Location = New System.Drawing.Point(220, 50)
        Me.btnSetStock.Name = "btnSetStock"
        Me.btnSetStock.Size = New System.Drawing.Size(83, 37)
        Me.btnSetStock.TabIndex = 297
        Me.btnSetStock.TabStop = False
        Me.btnSetStock.Text = "อนุมัติ"
        Me.btnSetStock.ToolTip = "อนุมัติ"
        '
        'rdoStockUse
        '
        Me.rdoStockUse.EditValue = CType(1, Short)
        Me.rdoStockUse.Location = New System.Drawing.Point(5, 42)
        Me.rdoStockUse.Name = "rdoStockUse"
        Me.rdoStockUse.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoStockUse.Properties.Appearance.Options.UseFont = True
        Me.rdoStockUse.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(1, Short), "ใช้สต๊อกจากการคำนวณใหม่"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(2, Short), "ใช้สต๊อกเดิม")})
        Me.rdoStockUse.Size = New System.Drawing.Size(209, 45)
        Me.rdoStockUse.TabIndex = 296
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.btnExportExcel)
        Me.PanelControl1.Controls.Add(Me.cboRefreshTime)
        Me.PanelControl1.Controls.Add(Me.CheckIsRefresh)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.CheckShowInfo)
        Me.PanelControl1.Controls.Add(Me.cboStatus)
        Me.PanelControl1.Controls.Add(Me.Label4)
        Me.PanelControl1.Location = New System.Drawing.Point(894, 71)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(123, 40)
        Me.PanelControl1.TabIndex = 295
        '
        'btnExportExcel
        '
        Me.btnExportExcel.EditValue = CType(resources.GetObject("btnExportExcel.EditValue"), Object)
        Me.btnExportExcel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExportExcel.Location = New System.Drawing.Point(60, 4)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnExportExcel.Properties.Appearance.Options.UseBackColor = True
        Me.btnExportExcel.Size = New System.Drawing.Size(58, 33)
        Me.btnExportExcel.TabIndex = 118
        Me.btnExportExcel.ToolTip = "Expor to File"
        Me.btnExportExcel.ToolTipTitle = "Expor to File"
        '
        'cboRefreshTime
        '
        Me.cboRefreshTime.EditValue = "5"
        Me.cboRefreshTime.Location = New System.Drawing.Point(282, 3)
        Me.cboRefreshTime.Name = "cboRefreshTime"
        Me.cboRefreshTime.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRefreshTime.Properties.Appearance.Options.UseFont = True
        Me.cboRefreshTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRefreshTime.Properties.Items.AddRange(New Object() {"1", "5", "10", "30", "60"})
        Me.cboRefreshTime.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboRefreshTime.Size = New System.Drawing.Size(45, 20)
        Me.cboRefreshTime.TabIndex = 114
        Me.cboRefreshTime.Visible = False
        '
        'CheckIsRefresh
        '
        Me.CheckIsRefresh.EditValue = True
        Me.CheckIsRefresh.Location = New System.Drawing.Point(277, 4)
        Me.CheckIsRefresh.Name = "CheckIsRefresh"
        Me.CheckIsRefresh.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CheckIsRefresh.Properties.Appearance.Options.UseFont = True
        Me.CheckIsRefresh.Properties.Caption = "Refresh"
        Me.CheckIsRefresh.Size = New System.Drawing.Size(72, 19)
        Me.CheckIsRefresh.TabIndex = 113
        Me.CheckIsRefresh.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 14)
        Me.Label1.TabIndex = 119
        Me.Label1.Text = "Export :"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(331, 6)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl1.TabIndex = 115
        Me.LabelControl1.Text = "วินาที"
        Me.LabelControl1.Visible = False
        '
        'CheckShowInfo
        '
        Me.CheckShowInfo.EditValue = True
        Me.CheckShowInfo.Location = New System.Drawing.Point(246, 2)
        Me.CheckShowInfo.Name = "CheckShowInfo"
        Me.CheckShowInfo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CheckShowInfo.Properties.Appearance.Options.UseFont = True
        Me.CheckShowInfo.Properties.Caption = "Show Information"
        Me.CheckShowInfo.Size = New System.Drawing.Size(126, 19)
        Me.CheckShowInfo.TabIndex = 116
        Me.CheckShowInfo.Visible = False
        '
        'cboStatus
        '
        Me.cboStatus.Location = New System.Drawing.Point(279, 4)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboStatus.Properties.Appearance.Options.UseFont = True
        Me.cboStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboStatus.Size = New System.Drawing.Size(41, 20)
        Me.cboStatus.TabIndex = 112
        Me.cboStatus.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(232, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 14)
        Me.Label4.TabIndex = 111
        Me.Label4.Text = "สถานะ"
        Me.Label4.Visible = False
        '
        'btnProductType
        '
        Me.btnProductType.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnProductType.Appearance.Options.UseFont = True
        Me.btnProductType.Image = CType(resources.GetObject("btnProductType.Image"), System.Drawing.Image)
        Me.btnProductType.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnProductType.Location = New System.Drawing.Point(326, 62)
        Me.btnProductType.Name = "btnProductType"
        Me.btnProductType.Size = New System.Drawing.Size(21, 21)
        Me.btnProductType.TabIndex = 249
        Me.btnProductType.TabStop = False
        Me.btnProductType.ToolTip = "Refresh"
        '
        'ProductTypeID
        '
        Me.ProductTypeID.Location = New System.Drawing.Point(115, 63)
        Me.ProductTypeID.Name = "ProductTypeID"
        Me.ProductTypeID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductTypeID.Properties.Appearance.Options.UseFont = True
        Me.ProductTypeID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProductTypeID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDCode", 50, "Code"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NameThai", 100, "Name")})
        Me.ProductTypeID.Properties.NullText = ""
        Me.ProductTypeID.Properties.ShowHeader = False
        Me.ProductTypeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProductTypeID.Size = New System.Drawing.Size(210, 20)
        Me.ProductTypeID.TabIndex = 2
        '
        'btnProductCategory
        '
        Me.btnProductCategory.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnProductCategory.Appearance.Options.UseFont = True
        Me.btnProductCategory.Image = CType(resources.GetObject("btnProductCategory.Image"), System.Drawing.Image)
        Me.btnProductCategory.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnProductCategory.Location = New System.Drawing.Point(326, 10)
        Me.btnProductCategory.Name = "btnProductCategory"
        Me.btnProductCategory.Size = New System.Drawing.Size(21, 21)
        Me.btnProductCategory.TabIndex = 248
        Me.btnProductCategory.TabStop = False
        Me.btnProductCategory.ToolTip = "Refresh"
        '
        'ProductCategoryID
        '
        Me.ProductCategoryID.Location = New System.Drawing.Point(115, 11)
        Me.ProductCategoryID.Name = "ProductCategoryID"
        Me.ProductCategoryID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductCategoryID.Properties.Appearance.Options.UseFont = True
        Me.ProductCategoryID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProductCategoryID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDCode", 50, "Code"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NameThai", 100, "Name")})
        Me.ProductCategoryID.Properties.NullText = ""
        Me.ProductCategoryID.Properties.ShowHeader = False
        Me.ProductCategoryID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProductCategoryID.Size = New System.Drawing.Size(210, 20)
        Me.ProductCategoryID.TabIndex = 0
        '
        'btnProductGroup
        '
        Me.btnProductGroup.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnProductGroup.Appearance.Options.UseFont = True
        Me.btnProductGroup.Image = CType(resources.GetObject("btnProductGroup.Image"), System.Drawing.Image)
        Me.btnProductGroup.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnProductGroup.Location = New System.Drawing.Point(326, 36)
        Me.btnProductGroup.Name = "btnProductGroup"
        Me.btnProductGroup.Size = New System.Drawing.Size(21, 21)
        Me.btnProductGroup.TabIndex = 247
        Me.btnProductGroup.TabStop = False
        Me.btnProductGroup.ToolTip = "Refresh"
        '
        'ProductGroupID
        '
        Me.ProductGroupID.Location = New System.Drawing.Point(115, 37)
        Me.ProductGroupID.Name = "ProductGroupID"
        Me.ProductGroupID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductGroupID.Properties.Appearance.Options.UseFont = True
        Me.ProductGroupID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProductGroupID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeThai", 50, "Code"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeEng", "Name", 100, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Remark", "Remark", 100, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.ProductGroupID.Properties.NullText = ""
        Me.ProductGroupID.Properties.ShowHeader = False
        Me.ProductGroupID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProductGroupID.Size = New System.Drawing.Size(210, 20)
        Me.ProductGroupID.TabIndex = 1
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label33.Location = New System.Drawing.Point(37, 14)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(62, 14)
        Me.Label33.TabIndex = 246
        Me.Label33.Text = "หมวดสินค้า"
        '
        'btnBrandRefresh
        '
        Me.btnBrandRefresh.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnBrandRefresh.Appearance.Options.UseFont = True
        Me.btnBrandRefresh.Image = CType(resources.GetObject("btnBrandRefresh.Image"), System.Drawing.Image)
        Me.btnBrandRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnBrandRefresh.Location = New System.Drawing.Point(326, 89)
        Me.btnBrandRefresh.Name = "btnBrandRefresh"
        Me.btnBrandRefresh.Size = New System.Drawing.Size(21, 21)
        Me.btnBrandRefresh.TabIndex = 245
        Me.btnBrandRefresh.TabStop = False
        Me.btnBrandRefresh.ToolTip = "Refresh"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label19.Location = New System.Drawing.Point(37, 66)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 14)
        Me.Label19.TabIndex = 244
        Me.Label19.Text = "ประเภทสินค้า"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.Location = New System.Drawing.Point(37, 93)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 14)
        Me.Label18.TabIndex = 243
        Me.Label18.Text = "ยี่ห้อสินค้า"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(37, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 14)
        Me.Label10.TabIndex = 242
        Me.Label10.Text = "กลุ่มสินค้า"
        '
        'ProductBrandID
        '
        Me.ProductBrandID.Location = New System.Drawing.Point(115, 90)
        Me.ProductBrandID.Name = "ProductBrandID"
        Me.ProductBrandID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductBrandID.Properties.Appearance.Options.UseFont = True
        Me.ProductBrandID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProductBrandID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDCode", 50, "Code"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NameThai", 100, "Name")})
        Me.ProductBrandID.Properties.NullText = ""
        Me.ProductBrandID.Properties.ShowHeader = False
        Me.ProductBrandID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProductBrandID.Size = New System.Drawing.Size(210, 20)
        Me.ProductBrandID.TabIndex = 3
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Appearance.Options.UseImage = True
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.SimpleButton1.Location = New System.Drawing.Point(386, 71)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(101, 37)
        Me.SimpleButton1.TabIndex = 233
        Me.SimpleButton1.TabStop = False
        Me.SimpleButton1.Text = "ปิดหน้าจอ"
        Me.SimpleButton1.ToolTip = "ปิดหน้าจอ"
        '
        'btnFind
        '
        Me.btnFind.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnFind.Appearance.Options.UseFont = True
        Me.btnFind.Appearance.Options.UseImage = True
        Me.btnFind.Image = CType(resources.GetObject("btnFind.Image"), System.Drawing.Image)
        Me.btnFind.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnFind.Location = New System.Drawing.Point(386, 28)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(101, 37)
        Me.btnFind.TabIndex = 226
        Me.btnFind.TabStop = False
        Me.btnFind.Text = "ค้นหา"
        Me.btnFind.ToolTip = "ค้นหา"
        '
        'gridControl
        '
        Me.gridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gridControl.EmbeddedNavigator.Buttons.Edit.ImageIndex = 0
        Me.gridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gridControl.Location = New System.Drawing.Point(4, 124)
        Me.gridControl.MainView = Me.gridView
        Me.gridControl.Name = "gridControl"
        Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ProductBtn, Me.PriceCalcEdit1})
        Me.gridControl.Size = New System.Drawing.Size(1017, 387)
        Me.gridControl.TabIndex = 295
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView, Me.GridView1})
        '
        'gridView
        '
        Me.gridView.GridControl = Me.gridControl
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsBehavior.ReadOnly = True
        Me.gridView.OptionsFind.AlwaysVisible = True
        Me.gridView.OptionsLayout.Columns.AddNewColumns = False
        Me.gridView.OptionsLayout.Columns.RemoveOldColumns = False
        Me.gridView.OptionsMenu.EnableColumnMenu = False
        Me.gridView.OptionsMenu.EnableFooterMenu = False
        Me.gridView.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsNavigation.AutoFocusNewRow = True
        Me.gridView.OptionsNavigation.EnterMoveNextColumn = True
        Me.gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.gridView.OptionsView.ShowGroupPanel = False
        '
        'ProductBtn
        '
        Me.ProductBtn.AutoHeight = False
        Me.ProductBtn.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ProductBtn.Name = "ProductBtn"
        Me.ProductBtn.ValidateOnEnterKey = True
        '
        'PriceCalcEdit1
        '
        Me.PriceCalcEdit1.AutoHeight = False
        Me.PriceCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PriceCalcEdit1.DisplayFormat.FormatString = "n2"
        Me.PriceCalcEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PriceCalcEdit1.EditFormat.FormatString = "n2"
        Me.PriceCalcEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PriceCalcEdit1.Name = "PriceCalcEdit1"
        Me.PriceCalcEdit1.Precision = 2
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gridControl
        Me.GridView1.Name = "GridView1"
        '
        'frmApproveStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 515)
        Me.Controls.Add(Me.gridControl)
        Me.Controls.Add(Me.PanelControl2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmApproveStock"
        Me.Text = "อนุมติสต๊อก"
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.chkIsDiff.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.rdoStockUse.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.btnExportExcel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRefreshTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckIsRefresh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckShowInfo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductTypeID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductCategoryID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductGroupID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBrandID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnFind As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnProductType As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ProductTypeID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnProductCategory As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ProductCategoryID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnProductGroup As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ProductGroupID As DevExpress.XtraEditors.LookUpEdit
    Private WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents btnBrandRefresh As DevExpress.XtraEditors.SimpleButton
    Private WithEvents Label19 As System.Windows.Forms.Label
    Private WithEvents Label18 As System.Windows.Forms.Label
    Private WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ProductBrandID As DevExpress.XtraEditors.LookUpEdit
    Private WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Private WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ProductBtn As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents PriceCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnExportExcel As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents cboRefreshTime As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents CheckIsRefresh As DevExpress.XtraEditors.CheckEdit
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckShowInfo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cboStatus As DevExpress.XtraEditors.ComboBoxEdit
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSetStock As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents rdoStockUse As DevExpress.XtraEditors.RadioGroup
    Private WithEvents lblRemark As System.Windows.Forms.Label
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents chkIsDiff As DevExpress.XtraEditors.CheckEdit
End Class
