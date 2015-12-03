<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccount))
        Me.LeadID = New DevExpress.XtraEditors.TextEdit()
        Me.AccountCode = New DevExpress.XtraEditors.TextEdit()
        Me.btnGenID = New DevExpress.XtraEditors.SimpleButton()
        Me.txtEstimatedBudjet = New DevExpress.XtraEditors.CalcEdit()
        Me.cboBusinessType = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboIndustryType = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboSource = New DevExpress.XtraEditors.LookUpEdit()
        Me.ContactRule = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnRefreshBusinessType = New DevExpress.XtraEditors.SimpleButton()
        Me.Campaign = New DevExpress.XtraEditors.TextEdit()
        Me.txtCompanyName = New DevExpress.XtraEditors.TextEdit()
        Me.btnRefreshSource = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRefreshIndustryType = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRefreshLeadType = New DevExpress.XtraEditors.SimpleButton()
        Me.txtRemark = New DevExpress.XtraEditors.MemoEdit()
        Me.DecisionMakerID = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnDecision = New DevExpress.XtraEditors.SimpleButton()
        Me.cboRating = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtNoOfEmployee = New DevExpress.XtraEditors.CalcEdit()
        Me.txtAnnualRevenue = New DevExpress.XtraEditors.CalcEdit()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.GeneralTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.btnContactPersonID = New DevExpress.XtraEditors.SimpleButton()
        Me.ContactPersonID = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnCompanyType = New DevExpress.XtraEditors.SimpleButton()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.CompanyRelateID = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CusName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Phone1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Fax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Email1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EMPNAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnCompanyRelateID = New DevExpress.XtraEditors.SimpleButton()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.CompanyType = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CreditTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcCreditInfo1 = New UB.ucCreditInfo()
        Me.HiastoryTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcHistory1 = New UB.ucHistory()
        Me.AddressTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcAddress1 = New UB.ucAddress()
        Me.AddressShipPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcAddress2 = New UB.ucAddress()
        Me.SWOTTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcSWOT1 = New UB.ucSWOT()
        Me.NoteTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcNote1 = New UB.ucNote()
        Me.AttachmentTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcFileAttach1 = New UB.ucFileAttach()
        Me.AdminTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcAdmin1 = New UB.ucAdmin()
        Me.FormChangedComponent1 = New UB.FormChangedComponent(Me.components)
        CType(Me.LeadID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstimatedBudjet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBusinessType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboIndustryType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSource.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactRule.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Campaign.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCompanyName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecisionMakerID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRating.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoOfEmployee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAnnualRevenue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.GeneralTabPage.SuspendLayout()
        CType(Me.ContactPersonID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyRelateID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CreditTabPage.SuspendLayout()
        Me.HiastoryTabPage.SuspendLayout()
        Me.AddressTabPage.SuspendLayout()
        Me.AddressShipPage.SuspendLayout()
        Me.SWOTTabPage.SuspendLayout()
        Me.NoteTabPage.SuspendLayout()
        Me.AttachmentTabPage.SuspendLayout()
        Me.AdminTabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'LeadID
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.LeadID, "TextChanged")
        Me.LeadID.EditValue = ""
        Me.LeadID.EnterMoveNextControl = True
        Me.LeadID.Location = New System.Drawing.Point(143, 140)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.LeadID, True)
        Me.LeadID.Name = "LeadID"
        Me.LeadID.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.LeadID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LeadID.Properties.Appearance.Options.UseBackColor = True
        Me.LeadID.Properties.Appearance.Options.UseFont = True
        Me.LeadID.Properties.MaxLength = 50
        Me.LeadID.Properties.ReadOnly = True
        Me.LeadID.Properties.ValidateOnEnterKey = True
        Me.LeadID.Size = New System.Drawing.Size(212, 20)
        Me.LeadID.TabIndex = 212
        Me.LeadID.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.LeadID, "Text")
        '
        'AccountCode
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.AccountCode, "TextChanged")
        Me.AccountCode.EditValue = ""
        Me.AccountCode.EnterMoveNextControl = True
        Me.AccountCode.Location = New System.Drawing.Point(143, 32)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.AccountCode, True)
        Me.AccountCode.Name = "AccountCode"
        Me.AccountCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.AccountCode.Properties.Appearance.Options.UseFont = True
        Me.AccountCode.Properties.MaxLength = 50
        Me.AccountCode.Properties.ValidateOnEnterKey = True
        Me.AccountCode.Size = New System.Drawing.Size(212, 20)
        Me.AccountCode.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.AccountCode, "Text")
        '
        'btnGenID
        '
        Me.btnGenID.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnGenID.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnGenID, "")
        Me.btnGenID.Image = CType(resources.GetObject("btnGenID.Image"), System.Drawing.Image)
        Me.btnGenID.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnGenID.Location = New System.Drawing.Point(357, 32)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnGenID, True)
        Me.btnGenID.Name = "btnGenID"
        Me.btnGenID.Size = New System.Drawing.Size(21, 21)
        Me.btnGenID.TabIndex = 210
        Me.btnGenID.TabStop = False
        Me.btnGenID.ToolTip = "Auto ID"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnGenID, "")
        '
        'txtEstimatedBudjet
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtEstimatedBudjet, "TextChanged")
        Me.txtEstimatedBudjet.EnterMoveNextControl = True
        Me.txtEstimatedBudjet.Location = New System.Drawing.Point(487, 370)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.txtEstimatedBudjet, True)
        Me.txtEstimatedBudjet.Name = "txtEstimatedBudjet"
        Me.txtEstimatedBudjet.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstimatedBudjet.Properties.Appearance.Options.UseFont = True
        Me.txtEstimatedBudjet.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtEstimatedBudjet.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtEstimatedBudjet.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtEstimatedBudjet.Properties.Mask.EditMask = "n"
        Me.txtEstimatedBudjet.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtEstimatedBudjet.Properties.Precision = 2
        Me.txtEstimatedBudjet.Size = New System.Drawing.Size(212, 20)
        Me.txtEstimatedBudjet.TabIndex = 12
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtEstimatedBudjet, "Text")
        '
        'cboBusinessType
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.cboBusinessType, "TextChanged")
        Me.cboBusinessType.EnterMoveNextControl = True
        Me.cboBusinessType.Location = New System.Drawing.Point(487, 287)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.cboBusinessType, True)
        Me.cboBusinessType.Name = "cboBusinessType"
        Me.cboBusinessType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboBusinessType.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBusinessType.Properties.Appearance.Options.UseFont = True
        Me.cboBusinessType.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboBusinessType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboBusinessType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 50, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeThai", 50, "ชื่อข้อความ"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeEng", "", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Center), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Remark", 70, "รายละเอียด")})
        Me.cboBusinessType.Properties.DropDownRows = 10
        Me.cboBusinessType.Properties.ImmediatePopup = True
        Me.cboBusinessType.Properties.NullText = ""
        Me.cboBusinessType.Properties.NullValuePromptShowForEmptyValue = True
        Me.cboBusinessType.Properties.PopupWidth = 300
        Me.cboBusinessType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboBusinessType.Properties.ThrowExceptionOnInvalidLookUpEditValueType = True
        Me.cboBusinessType.Properties.UseCtrlScroll = True
        Me.cboBusinessType.Size = New System.Drawing.Size(212, 20)
        Me.cboBusinessType.TabIndex = 8
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.cboBusinessType, "Text")
        '
        'cboIndustryType
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.cboIndustryType, "TextChanged")
        Me.cboIndustryType.EditValue = ""
        Me.cboIndustryType.EnterMoveNextControl = True
        Me.cboIndustryType.Location = New System.Drawing.Point(143, 287)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.cboIndustryType, True)
        Me.cboIndustryType.Name = "cboIndustryType"
        Me.cboIndustryType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.cboIndustryType.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboIndustryType.Properties.Appearance.Options.UseFont = True
        Me.cboIndustryType.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboIndustryType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboIndustryType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 50, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeThai", 50, "ชื่อข้อความ"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeEng", "", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Center), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Remark", 70, "รายละเอียด")})
        Me.cboIndustryType.Properties.DropDownRows = 10
        Me.cboIndustryType.Properties.ImmediatePopup = True
        Me.cboIndustryType.Properties.NullText = ""
        Me.cboIndustryType.Properties.NullValuePromptShowForEmptyValue = True
        Me.cboIndustryType.Properties.PopupWidth = 300
        Me.cboIndustryType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboIndustryType.Properties.ThrowExceptionOnInvalidLookUpEditValueType = True
        Me.cboIndustryType.Properties.UseCtrlScroll = True
        Me.cboIndustryType.Size = New System.Drawing.Size(212, 20)
        Me.cboIndustryType.TabIndex = 7
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.cboIndustryType, "Text")
        '
        'cboSource
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.cboSource, "TextChanged")
        Me.cboSource.EnterMoveNextControl = True
        Me.cboSource.Location = New System.Drawing.Point(487, 113)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.cboSource, True)
        Me.cboSource.Name = "cboSource"
        Me.cboSource.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboSource.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSource.Properties.Appearance.Options.UseFont = True
        Me.cboSource.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboSource.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSource.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 50, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeThai", 50, "ชื่อข้อความ"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeEng", "", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Center), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Remark", 70, "รายละเอียด")})
        Me.cboSource.Properties.DropDownRows = 10
        Me.cboSource.Properties.ImmediatePopup = True
        Me.cboSource.Properties.NullText = ""
        Me.cboSource.Properties.NullValuePromptShowForEmptyValue = True
        Me.cboSource.Properties.PopupWidth = 300
        Me.cboSource.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboSource.Properties.ThrowExceptionOnInvalidLookUpEditValueType = True
        Me.cboSource.Properties.UseCtrlScroll = True
        Me.cboSource.Size = New System.Drawing.Size(212, 20)
        Me.cboSource.TabIndex = 5
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.cboSource, "Text")
        '
        'ContactRule
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.ContactRule, "TextChanged")
        Me.ContactRule.EnterMoveNextControl = True
        Me.ContactRule.Location = New System.Drawing.Point(143, 113)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.ContactRule, True)
        Me.ContactRule.Name = "ContactRule"
        Me.ContactRule.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ContactRule.Properties.Appearance.Options.UseFont = True
        Me.ContactRule.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ContactRule.Properties.ImmediatePopup = True
        Me.ContactRule.Properties.UseCtrlScroll = True
        Me.ContactRule.Size = New System.Drawing.Size(212, 20)
        Me.ContactRule.TabIndex = 4
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.ContactRule, "Text")
        '
        'btnRefreshBusinessType
        '
        Me.btnRefreshBusinessType.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRefreshBusinessType.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnRefreshBusinessType, "")
        Me.btnRefreshBusinessType.Image = CType(resources.GetObject("btnRefreshBusinessType.Image"), System.Drawing.Image)
        Me.btnRefreshBusinessType.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefreshBusinessType.Location = New System.Drawing.Point(700, 287)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnRefreshBusinessType, True)
        Me.btnRefreshBusinessType.Name = "btnRefreshBusinessType"
        Me.btnRefreshBusinessType.Size = New System.Drawing.Size(21, 21)
        Me.btnRefreshBusinessType.TabIndex = 169
        Me.btnRefreshBusinessType.TabStop = False
        Me.btnRefreshBusinessType.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnRefreshBusinessType, "")
        '
        'Campaign
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Campaign, "TextChanged")
        Me.Campaign.EditValue = ""
        Me.Campaign.EnterMoveNextControl = True
        Me.Campaign.Location = New System.Drawing.Point(487, 140)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Campaign, True)
        Me.Campaign.Name = "Campaign"
        Me.Campaign.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.Campaign.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Campaign.Properties.Appearance.Options.UseBackColor = True
        Me.Campaign.Properties.Appearance.Options.UseFont = True
        Me.Campaign.Properties.MaxLength = 50
        Me.Campaign.Properties.ReadOnly = True
        Me.Campaign.Properties.ValidateOnEnterKey = True
        Me.Campaign.Size = New System.Drawing.Size(212, 20)
        Me.Campaign.TabIndex = 7
        Me.Campaign.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Campaign, "Text")
        '
        'txtCompanyName
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtCompanyName, "TextChanged")
        Me.txtCompanyName.EditValue = ""
        Me.txtCompanyName.EnterMoveNextControl = True
        Me.txtCompanyName.Location = New System.Drawing.Point(143, 59)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.txtCompanyName, True)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCompanyName.Properties.Appearance.Options.UseFont = True
        Me.txtCompanyName.Properties.MaxLength = 100
        Me.txtCompanyName.Properties.ValidateOnEnterKey = True
        Me.txtCompanyName.Size = New System.Drawing.Size(555, 20)
        Me.txtCompanyName.TabIndex = 1
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtCompanyName, "Text")
        '
        'btnRefreshSource
        '
        Me.btnRefreshSource.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRefreshSource.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnRefreshSource, "")
        Me.btnRefreshSource.Image = CType(resources.GetObject("btnRefreshSource.Image"), System.Drawing.Image)
        Me.btnRefreshSource.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefreshSource.Location = New System.Drawing.Point(700, 113)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnRefreshSource, True)
        Me.btnRefreshSource.Name = "btnRefreshSource"
        Me.btnRefreshSource.Size = New System.Drawing.Size(21, 21)
        Me.btnRefreshSource.TabIndex = 149
        Me.btnRefreshSource.TabStop = False
        Me.btnRefreshSource.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnRefreshSource, "")
        '
        'btnRefreshIndustryType
        '
        Me.btnRefreshIndustryType.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRefreshIndustryType.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnRefreshIndustryType, "")
        Me.btnRefreshIndustryType.Image = CType(resources.GetObject("btnRefreshIndustryType.Image"), System.Drawing.Image)
        Me.btnRefreshIndustryType.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefreshIndustryType.Location = New System.Drawing.Point(357, 287)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnRefreshIndustryType, True)
        Me.btnRefreshIndustryType.Name = "btnRefreshIndustryType"
        Me.btnRefreshIndustryType.Size = New System.Drawing.Size(21, 21)
        Me.btnRefreshIndustryType.TabIndex = 135
        Me.btnRefreshIndustryType.TabStop = False
        Me.btnRefreshIndustryType.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnRefreshIndustryType, "")
        '
        'btnRefreshLeadType
        '
        Me.btnRefreshLeadType.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRefreshLeadType.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnRefreshLeadType, "")
        Me.btnRefreshLeadType.Image = CType(resources.GetObject("btnRefreshLeadType.Image"), System.Drawing.Image)
        Me.btnRefreshLeadType.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefreshLeadType.Location = New System.Drawing.Point(357, 113)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnRefreshLeadType, True)
        Me.btnRefreshLeadType.Name = "btnRefreshLeadType"
        Me.btnRefreshLeadType.Size = New System.Drawing.Size(21, 21)
        Me.btnRefreshLeadType.TabIndex = 131
        Me.btnRefreshLeadType.TabStop = False
        Me.btnRefreshLeadType.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnRefreshLeadType, "")
        '
        'txtRemark
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtRemark, "TextChanged")
        Me.txtRemark.EditValue = ""
        Me.txtRemark.EnterMoveNextControl = True
        Me.txtRemark.Location = New System.Drawing.Point(143, 191)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.txtRemark, True)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRemark.Properties.Appearance.Options.UseFont = True
        Me.txtRemark.Properties.MaxLength = 100
        Me.txtRemark.Size = New System.Drawing.Size(556, 67)
        Me.txtRemark.TabIndex = 6
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtRemark, "Text")
        '
        'DecisionMakerID
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.DecisionMakerID, "TextChanged")
        Me.DecisionMakerID.EnterMoveNextControl = True
        Me.DecisionMakerID.Location = New System.Drawing.Point(143, 341)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.DecisionMakerID, True)
        Me.DecisionMakerID.Name = "DecisionMakerID"
        Me.DecisionMakerID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecisionMakerID.Properties.Appearance.Options.UseFont = True
        Me.DecisionMakerID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DecisionMakerID.Properties.NullText = ""
        Me.DecisionMakerID.Properties.PopupFindMode = DevExpress.XtraEditors.FindMode.Always
        Me.DecisionMakerID.Properties.View = Me.GridView1
        Me.DecisionMakerID.Size = New System.Drawing.Size(212, 20)
        Me.DecisionMakerID.TabIndex = 10
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.DecisionMakerID, "Text")
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowViewCaption = True
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "รหัส"
        Me.GridColumn1.FieldName = " ID"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "รหัส"
        Me.GridColumn2.FieldName = "EmpCode"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "ชื่อ - นามสกุล"
        Me.GridColumn3.FieldName = "CusName"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        '
        'btnDecision
        '
        Me.btnDecision.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnDecision.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnDecision, "")
        Me.btnDecision.Image = CType(resources.GetObject("btnDecision.Image"), System.Drawing.Image)
        Me.btnDecision.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnDecision.Location = New System.Drawing.Point(357, 341)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnDecision, True)
        Me.btnDecision.Name = "btnDecision"
        Me.btnDecision.Size = New System.Drawing.Size(21, 21)
        Me.btnDecision.TabIndex = 229
        Me.btnDecision.TabStop = False
        Me.btnDecision.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnDecision, "")
        '
        'cboRating
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.cboRating, "TextChanged")
        Me.cboRating.EditValue = "Nomal"
        Me.cboRating.EnterMoveNextControl = True
        Me.cboRating.Location = New System.Drawing.Point(143, 166)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.cboRating, True)
        Me.cboRating.Name = "cboRating"
        Me.cboRating.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboRating.Properties.Appearance.Options.UseFont = True
        Me.cboRating.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRating.Properties.ImmediatePopup = True
        Me.cboRating.Properties.Items.AddRange(New Object() {"Hot", "Nomal", "Low"})
        Me.cboRating.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboRating.Properties.UseCtrlScroll = True
        Me.cboRating.Size = New System.Drawing.Size(212, 20)
        Me.cboRating.TabIndex = 6
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.cboRating, "Text")
        '
        'txtNoOfEmployee
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtNoOfEmployee, "TextChanged")
        Me.txtNoOfEmployee.EnterMoveNextControl = True
        Me.txtNoOfEmployee.Location = New System.Drawing.Point(487, 341)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.txtNoOfEmployee, True)
        Me.txtNoOfEmployee.Name = "txtNoOfEmployee"
        Me.txtNoOfEmployee.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoOfEmployee.Properties.Appearance.Options.UseFont = True
        Me.txtNoOfEmployee.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtNoOfEmployee.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNoOfEmployee.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNoOfEmployee.Properties.Mask.EditMask = "n0"
        Me.txtNoOfEmployee.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNoOfEmployee.Properties.Precision = 0
        Me.txtNoOfEmployee.Size = New System.Drawing.Size(212, 20)
        Me.txtNoOfEmployee.TabIndex = 10
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtNoOfEmployee, "Text")
        '
        'txtAnnualRevenue
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtAnnualRevenue, "TextChanged")
        Me.txtAnnualRevenue.EnterMoveNextControl = True
        Me.txtAnnualRevenue.Location = New System.Drawing.Point(143, 370)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.txtAnnualRevenue, True)
        Me.txtAnnualRevenue.Name = "txtAnnualRevenue"
        Me.txtAnnualRevenue.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnnualRevenue.Properties.Appearance.Options.UseFont = True
        Me.txtAnnualRevenue.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAnnualRevenue.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAnnualRevenue.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAnnualRevenue.Properties.Mask.EditMask = "n"
        Me.txtAnnualRevenue.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAnnualRevenue.Properties.Precision = 2
        Me.txtAnnualRevenue.Size = New System.Drawing.Size(212, 20)
        Me.txtAnnualRevenue.TabIndex = 11
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtAnnualRevenue, "Text")
        '
        'XtraTabControl1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.XtraTabControl1, "")
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 37)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.XtraTabControl1, True)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.GeneralTabPage
        Me.XtraTabControl1.Size = New System.Drawing.Size(807, 590)
        Me.XtraTabControl1.TabIndex = 6
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.GeneralTabPage, Me.CreditTabPage, Me.HiastoryTabPage, Me.AddressTabPage, Me.AddressShipPage, Me.SWOTTabPage, Me.NoteTabPage, Me.AttachmentTabPage, Me.AdminTabPage})
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.XtraTabControl1, "")
        '
        'GeneralTabPage
        '
        Me.GeneralTabPage.Appearance.PageClient.BackColor = System.Drawing.Color.LightGray
        Me.GeneralTabPage.Appearance.PageClient.Options.UseBackColor = True
        Me.GeneralTabPage.AutoScroll = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.GeneralTabPage, "")
        Me.GeneralTabPage.Controls.Add(Me.btnContactPersonID)
        Me.GeneralTabPage.Controls.Add(Me.ContactPersonID)
        Me.GeneralTabPage.Controls.Add(Me.btnCompanyType)
        Me.GeneralTabPage.Controls.Add(Me.Label27)
        Me.GeneralTabPage.Controls.Add(Me.CompanyRelateID)
        Me.GeneralTabPage.Controls.Add(Me.btnCompanyRelateID)
        Me.GeneralTabPage.Controls.Add(Me.Label25)
        Me.GeneralTabPage.Controls.Add(Me.CompanyType)
        Me.GeneralTabPage.Controls.Add(Me.txtAnnualRevenue)
        Me.GeneralTabPage.Controls.Add(Me.Label10)
        Me.GeneralTabPage.Controls.Add(Me.txtNoOfEmployee)
        Me.GeneralTabPage.Controls.Add(Me.Label24)
        Me.GeneralTabPage.Controls.Add(Me.cboRating)
        Me.GeneralTabPage.Controls.Add(Me.Label9)
        Me.GeneralTabPage.Controls.Add(Me.DecisionMakerID)
        Me.GeneralTabPage.Controls.Add(Me.Label8)
        Me.GeneralTabPage.Controls.Add(Me.btnDecision)
        Me.GeneralTabPage.Controls.Add(Me.Label6)
        Me.GeneralTabPage.Controls.Add(Me.Label2)
        Me.GeneralTabPage.Controls.Add(Me.LeadID)
        Me.GeneralTabPage.Controls.Add(Me.AccountCode)
        Me.GeneralTabPage.Controls.Add(Me.btnGenID)
        Me.GeneralTabPage.Controls.Add(Me.txtEstimatedBudjet)
        Me.GeneralTabPage.Controls.Add(Me.Label26)
        Me.GeneralTabPage.Controls.Add(Me.Label1)
        Me.GeneralTabPage.Controls.Add(Me.cboBusinessType)
        Me.GeneralTabPage.Controls.Add(Me.cboIndustryType)
        Me.GeneralTabPage.Controls.Add(Me.cboSource)
        Me.GeneralTabPage.Controls.Add(Me.ContactRule)
        Me.GeneralTabPage.Controls.Add(Me.btnRefreshBusinessType)
        Me.GeneralTabPage.Controls.Add(Me.Campaign)
        Me.GeneralTabPage.Controls.Add(Me.txtCompanyName)
        Me.GeneralTabPage.Controls.Add(Me.btnRefreshSource)
        Me.GeneralTabPage.Controls.Add(Me.Label15)
        Me.GeneralTabPage.Controls.Add(Me.Label13)
        Me.GeneralTabPage.Controls.Add(Me.btnRefreshIndustryType)
        Me.GeneralTabPage.Controls.Add(Me.btnRefreshLeadType)
        Me.GeneralTabPage.Controls.Add(Me.Label29)
        Me.GeneralTabPage.Controls.Add(Me.Label28)
        Me.GeneralTabPage.Controls.Add(Me.Label21)
        Me.GeneralTabPage.Controls.Add(Me.Label20)
        Me.GeneralTabPage.Controls.Add(Me.Label19)
        Me.GeneralTabPage.Controls.Add(Me.Label18)
        Me.GeneralTabPage.Controls.Add(Me.Label14)
        Me.GeneralTabPage.Controls.Add(Me.Label12)
        Me.GeneralTabPage.Controls.Add(Me.Label5)
        Me.GeneralTabPage.Controls.Add(Me.txtRemark)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.GeneralTabPage, True)
        Me.GeneralTabPage.Name = "GeneralTabPage"
        Me.GeneralTabPage.Size = New System.Drawing.Size(801, 562)
        Me.GeneralTabPage.Text = "ข้อมูลทั่วไป"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.GeneralTabPage, "")
        '
        'btnContactPersonID
        '
        Me.btnContactPersonID.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnContactPersonID.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnContactPersonID, "")
        Me.btnContactPersonID.Image = CType(resources.GetObject("btnContactPersonID.Image"), System.Drawing.Image)
        Me.btnContactPersonID.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnContactPersonID.Location = New System.Drawing.Point(356, 85)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnContactPersonID, True)
        Me.btnContactPersonID.Name = "btnContactPersonID"
        Me.btnContactPersonID.Size = New System.Drawing.Size(21, 21)
        Me.btnContactPersonID.TabIndex = 251
        Me.btnContactPersonID.TabStop = False
        Me.btnContactPersonID.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnContactPersonID, "")
        '
        'ContactPersonID
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.ContactPersonID, "TextChanged")
        Me.ContactPersonID.EnterMoveNextControl = True
        Me.ContactPersonID.Location = New System.Drawing.Point(143, 85)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.ContactPersonID, True)
        Me.ContactPersonID.Name = "ContactPersonID"
        Me.ContactPersonID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactPersonID.Properties.Appearance.Options.UseFont = True
        Me.ContactPersonID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ContactPersonID.Properties.NullText = ""
        Me.ContactPersonID.Properties.PopupFindMode = DevExpress.XtraEditors.FindMode.Always
        Me.ContactPersonID.Properties.View = Me.SearchLookUpEdit1View
        Me.ContactPersonID.Size = New System.Drawing.Size(212, 20)
        Me.ContactPersonID.TabIndex = 3
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.ContactPersonID, "Text")
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12})
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ColumnAutoWidth = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        Me.SearchLookUpEdit1View.OptionsView.ShowViewCaption = True
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "รหัส"
        Me.GridColumn4.FieldName = " ID"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "รหัส"
        Me.GridColumn5.FieldName = "Code"
        Me.GridColumn5.MaxWidth = 100
        Me.GridColumn5.MinWidth = 75
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "ชื่อ - นามสกุล"
        Me.GridColumn6.FieldName = "CusName"
        Me.GridColumn6.MaxWidth = 200
        Me.GridColumn6.MinWidth = 150
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 1
        Me.GridColumn6.Width = 150
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "ประเภทลูกค้า"
        Me.GridColumn8.FieldName = "Type"
        Me.GridColumn8.MaxWidth = 75
        Me.GridColumn8.MinWidth = 50
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 2
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "เบอร์โทร"
        Me.GridColumn9.FieldName = "Phone1"
        Me.GridColumn9.MaxWidth = 85
        Me.GridColumn9.MinWidth = 85
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 3
        Me.GridColumn9.Width = 85
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "เบอร์แฟกซ์"
        Me.GridColumn10.FieldName = "Fax"
        Me.GridColumn10.MaxWidth = 85
        Me.GridColumn10.MinWidth = 85
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 4
        Me.GridColumn10.Width = 85
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "อีเมล์"
        Me.GridColumn11.FieldName = "Email1"
        Me.GridColumn11.MaxWidth = 85
        Me.GridColumn11.MinWidth = 85
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 5
        Me.GridColumn11.Width = 85
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "ผู้รับผิดชอบ"
        Me.GridColumn12.FieldName = "EMPNAME"
        Me.GridColumn12.MaxWidth = 150
        Me.GridColumn12.MinWidth = 120
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 6
        Me.GridColumn12.Width = 120
        '
        'btnCompanyType
        '
        Me.btnCompanyType.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCompanyType.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnCompanyType, "")
        Me.btnCompanyType.Image = CType(resources.GetObject("btnCompanyType.Image"), System.Drawing.Image)
        Me.btnCompanyType.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCompanyType.Location = New System.Drawing.Point(357, 314)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnCompanyType, True)
        Me.btnCompanyType.Name = "btnCompanyType"
        Me.btnCompanyType.Size = New System.Drawing.Size(21, 21)
        Me.btnCompanyType.TabIndex = 247
        Me.btnCompanyType.TabStop = False
        Me.btnCompanyType.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnCompanyType, "")
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label27, "")
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label27.Location = New System.Drawing.Point(395, 317)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label27, True)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(73, 14)
        Me.Label27.TabIndex = 246
        Me.Label27.Text = "บริษัทในเครือ"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label27, "")
        '
        'CompanyRelateID
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.CompanyRelateID, "TextChanged")
        Me.CompanyRelateID.EnterMoveNextControl = True
        Me.CompanyRelateID.Location = New System.Drawing.Point(487, 314)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.CompanyRelateID, True)
        Me.CompanyRelateID.Name = "CompanyRelateID"
        Me.CompanyRelateID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompanyRelateID.Properties.Appearance.Options.UseFont = True
        Me.CompanyRelateID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CompanyRelateID.Properties.NullText = ""
        Me.CompanyRelateID.Properties.PopupFindMode = DevExpress.XtraEditors.FindMode.Always
        Me.CompanyRelateID.Properties.View = Me.GridView2
        Me.CompanyRelateID.Size = New System.Drawing.Size(212, 20)
        Me.CompanyRelateID.TabIndex = 10
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.CompanyRelateID, "Text")
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn7, Me.Code, Me.CusName, Me.Type, Me.Phone1, Me.Fax, Me.Email1, Me.EMPNAME})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowViewCaption = True
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "รหัส"
        Me.GridColumn7.FieldName = " ID"
        Me.GridColumn7.Name = "GridColumn7"
        '
        'Code
        '
        Me.Code.Caption = "รหัส"
        Me.Code.FieldName = "Code"
        Me.Code.MaxWidth = 100
        Me.Code.MinWidth = 75
        Me.Code.Name = "Code"
        Me.Code.Visible = True
        Me.Code.VisibleIndex = 0
        '
        'CusName
        '
        Me.CusName.Caption = "ชื่อ - นามสกุล"
        Me.CusName.FieldName = "CusName"
        Me.CusName.MaxWidth = 200
        Me.CusName.MinWidth = 150
        Me.CusName.Name = "CusName"
        Me.CusName.Visible = True
        Me.CusName.VisibleIndex = 1
        Me.CusName.Width = 150
        '
        'Type
        '
        Me.Type.Caption = "ประเภทลูกค้า"
        Me.Type.FieldName = "Type"
        Me.Type.MaxWidth = 75
        Me.Type.MinWidth = 50
        Me.Type.Name = "Type"
        Me.Type.Visible = True
        Me.Type.VisibleIndex = 2
        '
        'Phone1
        '
        Me.Phone1.Caption = "เบอร์โทร"
        Me.Phone1.FieldName = "Phone1"
        Me.Phone1.MaxWidth = 85
        Me.Phone1.MinWidth = 85
        Me.Phone1.Name = "Phone1"
        Me.Phone1.Visible = True
        Me.Phone1.VisibleIndex = 3
        Me.Phone1.Width = 85
        '
        'Fax
        '
        Me.Fax.Caption = "เบอร์แฟกซ์"
        Me.Fax.FieldName = "Fax"
        Me.Fax.MaxWidth = 85
        Me.Fax.MinWidth = 85
        Me.Fax.Name = "Fax"
        Me.Fax.Visible = True
        Me.Fax.VisibleIndex = 4
        Me.Fax.Width = 85
        '
        'Email1
        '
        Me.Email1.Caption = "อีเมล์"
        Me.Email1.FieldName = "Email1"
        Me.Email1.MaxWidth = 85
        Me.Email1.MinWidth = 85
        Me.Email1.Name = "Email1"
        Me.Email1.Visible = True
        Me.Email1.VisibleIndex = 5
        Me.Email1.Width = 85
        '
        'EMPNAME
        '
        Me.EMPNAME.Caption = "ผู้รับผิดชอบ"
        Me.EMPNAME.FieldName = "EMPNAME"
        Me.EMPNAME.MaxWidth = 150
        Me.EMPNAME.MinWidth = 120
        Me.EMPNAME.Name = "EMPNAME"
        Me.EMPNAME.Visible = True
        Me.EMPNAME.VisibleIndex = 6
        Me.EMPNAME.Width = 120
        '
        'btnCompanyRelateID
        '
        Me.btnCompanyRelateID.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCompanyRelateID.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnCompanyRelateID, "")
        Me.btnCompanyRelateID.Image = CType(resources.GetObject("btnCompanyRelateID.Image"), System.Drawing.Image)
        Me.btnCompanyRelateID.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCompanyRelateID.Location = New System.Drawing.Point(700, 314)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnCompanyRelateID, True)
        Me.btnCompanyRelateID.Name = "btnCompanyRelateID"
        Me.btnCompanyRelateID.Size = New System.Drawing.Size(21, 21)
        Me.btnCompanyRelateID.TabIndex = 245
        Me.btnCompanyRelateID.TabStop = False
        Me.btnCompanyRelateID.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnCompanyRelateID, "")
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label25, "")
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label25.Location = New System.Drawing.Point(40, 317)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label25, True)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(76, 14)
        Me.Label25.TabIndex = 243
        Me.Label25.Text = "ประเภทบริษัท"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label25, "")
        '
        'CompanyType
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.CompanyType, "TextChanged")
        Me.CompanyType.EditValue = ""
        Me.CompanyType.EnterMoveNextControl = True
        Me.CompanyType.Location = New System.Drawing.Point(143, 314)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.CompanyType, True)
        Me.CompanyType.Name = "CompanyType"
        Me.CompanyType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.CompanyType.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompanyType.Properties.Appearance.Options.UseFont = True
        Me.CompanyType.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.CompanyType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CompanyType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 50, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeThai", 50, "ชื่อข้อความ"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeEng", "", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Center), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Remark", 70, "รายละเอียด")})
        Me.CompanyType.Properties.DropDownRows = 10
        Me.CompanyType.Properties.ImmediatePopup = True
        Me.CompanyType.Properties.NullText = ""
        Me.CompanyType.Properties.NullValuePromptShowForEmptyValue = True
        Me.CompanyType.Properties.PopupWidth = 300
        Me.CompanyType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CompanyType.Properties.ThrowExceptionOnInvalidLookUpEditValueType = True
        Me.CompanyType.Properties.UseCtrlScroll = True
        Me.CompanyType.Size = New System.Drawing.Size(212, 20)
        Me.CompanyType.TabIndex = 9
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.CompanyType, "Text")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label10, "")
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(40, 373)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label10, True)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 14)
        Me.Label10.TabIndex = 237
        Me.Label10.Text = "รายได้ประจำปี"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label10, "")
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label24, "")
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label24.Location = New System.Drawing.Point(395, 344)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label24, True)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(80, 14)
        Me.Label24.TabIndex = 235
        Me.Label24.Text = "จำนวนพนักงาน"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label24, "")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label9, "")
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(40, 169)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label9, True)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 14)
        Me.Label9.TabIndex = 233
        Me.Label9.Text = "ระดับความสนใจ"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label9, "")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label8, "")
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(40, 344)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label8, True)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 14)
        Me.Label8.TabIndex = 230
        Me.Label8.Text = "ผู้มีอำนาจตัดสินใจ"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label8, "")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label6, "")
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 88)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label6, True)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 14)
        Me.Label6.TabIndex = 215
        Me.Label6.Text = "ผู้ติดต่อ"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label6, "")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label2, "")
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(40, 62)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label2, True)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 14)
        Me.Label2.TabIndex = 213
        Me.Label2.Text = "ชื่อบริษัท"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label2, "")
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label26, "")
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label26.Location = New System.Drawing.Point(395, 373)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label26, True)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(77, 14)
        Me.Label26.TabIndex = 197
        Me.Label26.Text = "งบประมาณซื้อ"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label26, "")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label1, "")
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(40, 35)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label1, True)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 14)
        Me.Label1.TabIndex = 171
        Me.Label1.Text = "รหัสลูกค้า"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label1, "")
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label15, "")
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(40, 143)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label15, True)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(78, 14)
        Me.Label15.TabIndex = 140
        Me.Label15.Text = "Lead ที่อ้างอิง"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label15, "")
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label13, "")
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(395, 116)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label13, True)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 14)
        Me.Label13.TabIndex = 139
        Me.Label13.Text = "แหล่งที่มา"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label13, "")
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label29, "")
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.DarkGray
        Me.Label29.Location = New System.Drawing.Point(113, 261)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label29, True)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(623, 14)
        Me.Label29.TabIndex = 121
        Me.Label29.Text = "_________________________________________________________________________________" & _
            "_______"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label29, "")
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label28, "")
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.DarkGray
        Me.Label28.Location = New System.Drawing.Point(113, 7)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label28, True)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(623, 14)
        Me.Label28.TabIndex = 120
        Me.Label28.Text = "_________________________________________________________________________________" & _
            "_______"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label28, "")
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label21, "")
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label21.Location = New System.Drawing.Point(395, 287)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label21, True)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(70, 14)
        Me.Label21.TabIndex = 117
        Me.Label21.Text = "ประเภทธุรกิจ"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label21, "")
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label20, "")
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label20.Location = New System.Drawing.Point(40, 290)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label20, True)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(104, 14)
        Me.Label20.TabIndex = 116
        Me.Label20.Text = "ประเภทอุตสาหกรรม"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label20, "")
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label19, "")
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label19.Location = New System.Drawing.Point(34, 265)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label19, True)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(66, 14)
        Me.Label19.TabIndex = 115
        Me.Label19.Text = "ข้อมูลบริษัท"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label19, "")
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label18, "")
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label18.Location = New System.Drawing.Point(34, 11)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label18, True)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 14)
        Me.Label18.TabIndex = 114
        Me.Label18.Text = "ข้อมูลทั่วไป"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label18, "")
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label14, "")
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(395, 143)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label14, True)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 14)
        Me.Label14.TabIndex = 112
        Me.Label14.Text = "แคมเปญ"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label14, "")
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label12, "")
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(40, 116)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label12, True)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 14)
        Me.Label12.TabIndex = 111
        Me.Label12.Text = "บทบาทหน้าที่"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label12, "")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label5, "")
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 214)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label5, True)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 14)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "รายละเอียด"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label5, "")
        '
        'CreditTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.CreditTabPage, "")
        Me.CreditTabPage.Controls.Add(Me.UcCreditInfo1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.CreditTabPage, True)
        Me.CreditTabPage.Name = "CreditTabPage"
        Me.CreditTabPage.Size = New System.Drawing.Size(801, 562)
        Me.CreditTabPage.Text = "ข้อมูลทางการเงิน"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.CreditTabPage, "")
        '
        'UcCreditInfo1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.UcCreditInfo1, "")
        Me.UcCreditInfo1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcCreditInfo1.Location = New System.Drawing.Point(0, 0)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.UcCreditInfo1, True)
        Me.UcCreditInfo1.Name = "UcCreditInfo1"
        Me.UcCreditInfo1.Size = New System.Drawing.Size(801, 562)
        Me.UcCreditInfo1.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcCreditInfo1, "")
        '
        'HiastoryTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.HiastoryTabPage, "")
        Me.HiastoryTabPage.Controls.Add(Me.UcHistory1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.HiastoryTabPage, True)
        Me.HiastoryTabPage.Name = "HiastoryTabPage"
        Me.HiastoryTabPage.Size = New System.Drawing.Size(801, 562)
        Me.HiastoryTabPage.Text = "ข้อมูลส่วนตัว"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.HiastoryTabPage, "")
        '
        'UcHistory1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.UcHistory1, "")
        Me.UcHistory1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcHistory1.Location = New System.Drawing.Point(0, 0)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.UcHistory1, True)
        Me.UcHistory1.Name = "UcHistory1"
        Me.UcHistory1.Size = New System.Drawing.Size(801, 562)
        Me.UcHistory1.TabIndex = 1
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcHistory1, "")
        '
        'AddressTabPage
        '
        Me.AddressTabPage.AutoScroll = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.AddressTabPage, "")
        Me.AddressTabPage.Controls.Add(Me.UcAddress1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.AddressTabPage, True)
        Me.AddressTabPage.Name = "AddressTabPage"
        Me.AddressTabPage.Size = New System.Drawing.Size(801, 562)
        Me.AddressTabPage.Text = "ที่อยู่"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.AddressTabPage, "")
        '
        'UcAddress1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.UcAddress1, "")
        Me.UcAddress1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcAddress1.Location = New System.Drawing.Point(0, 0)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.UcAddress1, True)
        Me.UcAddress1.Name = "UcAddress1"
        Me.UcAddress1.Size = New System.Drawing.Size(801, 562)
        Me.UcAddress1.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcAddress1, "")
        '
        'AddressShipPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.AddressShipPage, "")
        Me.AddressShipPage.Controls.Add(Me.UcAddress2)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.AddressShipPage, True)
        Me.AddressShipPage.Name = "AddressShipPage"
        Me.AddressShipPage.Size = New System.Drawing.Size(801, 562)
        Me.AddressShipPage.Text = "ที่อยู่สำหรับส่งของ"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.AddressShipPage, "")
        '
        'UcAddress2
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.UcAddress2, "")
        Me.UcAddress2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcAddress2.Location = New System.Drawing.Point(0, 0)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.UcAddress2, True)
        Me.UcAddress2.Name = "UcAddress2"
        Me.UcAddress2.Size = New System.Drawing.Size(801, 562)
        Me.UcAddress2.TabIndex = 1
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcAddress2, "")
        '
        'SWOTTabPage
        '
        Me.SWOTTabPage.AutoScroll = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.SWOTTabPage, "")
        Me.SWOTTabPage.Controls.Add(Me.UcSWOT1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.SWOTTabPage, True)
        Me.SWOTTabPage.Name = "SWOTTabPage"
        Me.SWOTTabPage.Size = New System.Drawing.Size(801, 562)
        Me.SWOTTabPage.Text = "SWOT"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.SWOTTabPage, "")
        '
        'UcSWOT1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.UcSWOT1, "")
        Me.UcSWOT1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcSWOT1.Location = New System.Drawing.Point(0, 0)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.UcSWOT1, True)
        Me.UcSWOT1.Name = "UcSWOT1"
        Me.UcSWOT1.Size = New System.Drawing.Size(801, 562)
        Me.UcSWOT1.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcSWOT1, "")
        '
        'NoteTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.NoteTabPage, "")
        Me.NoteTabPage.Controls.Add(Me.UcNote1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.NoteTabPage, True)
        Me.NoteTabPage.Name = "NoteTabPage"
        Me.NoteTabPage.Size = New System.Drawing.Size(801, 562)
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
        Me.UcNote1.Size = New System.Drawing.Size(801, 562)
        Me.UcNote1.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcNote1, "")
        '
        'AttachmentTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.AttachmentTabPage, "")
        Me.AttachmentTabPage.Controls.Add(Me.UcFileAttach1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.AttachmentTabPage, True)
        Me.AttachmentTabPage.Name = "AttachmentTabPage"
        Me.AttachmentTabPage.Size = New System.Drawing.Size(801, 562)
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
        Me.UcFileAttach1.Size = New System.Drawing.Size(801, 562)
        Me.UcFileAttach1.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcFileAttach1, "")
        '
        'AdminTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.AdminTabPage, "")
        Me.AdminTabPage.Controls.Add(Me.UcAdmin1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.AdminTabPage, True)
        Me.AdminTabPage.Name = "AdminTabPage"
        Me.AdminTabPage.Size = New System.Drawing.Size(801, 562)
        Me.AdminTabPage.Text = "ผู้บันทึก"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.AdminTabPage, "")
        '
        'UcAdmin1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.UcAdmin1, "")
        Me.UcAdmin1.Location = New System.Drawing.Point(71, 0)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.UcAdmin1, True)
        Me.UcAdmin1.Name = "UcAdmin1"
        Me.UcAdmin1.Size = New System.Drawing.Size(665, 223)
        Me.UcAdmin1.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcAdmin1, "")
        '
        'FormChangedComponent1
        '
        '
        'frmAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 627)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frmAccount"
        Me.Text = "frmAccount"
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.LeadID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstimatedBudjet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBusinessType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboIndustryType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSource.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactRule.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Campaign.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCompanyName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecisionMakerID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRating.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoOfEmployee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAnnualRevenue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.GeneralTabPage.ResumeLayout(False)
        Me.GeneralTabPage.PerformLayout()
        CType(Me.ContactPersonID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyRelateID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CreditTabPage.ResumeLayout(False)
        Me.HiastoryTabPage.ResumeLayout(False)
        Me.AddressTabPage.ResumeLayout(False)
        Me.AddressShipPage.ResumeLayout(False)
        Me.SWOTTabPage.ResumeLayout(False)
        Me.NoteTabPage.ResumeLayout(False)
        Me.AttachmentTabPage.ResumeLayout(False)
        Me.AdminTabPage.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents GeneralTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LeadID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AccountCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnGenID As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtEstimatedBudjet As DevExpress.XtraEditors.CalcEdit
    Private WithEvents Label26 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents cboBusinessType As DevExpress.XtraEditors.LookUpEdit
    Private WithEvents cboIndustryType As DevExpress.XtraEditors.LookUpEdit
    Private WithEvents cboSource As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ContactRule As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnRefreshBusinessType As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Campaign As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCompanyName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnRefreshSource As DevExpress.XtraEditors.SimpleButton
    Private WithEvents Label15 As System.Windows.Forms.Label
    Private WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnRefreshIndustryType As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRefreshLeadType As DevExpress.XtraEditors.SimpleButton
    Private WithEvents Label29 As System.Windows.Forms.Label
    Private WithEvents Label28 As System.Windows.Forms.Label
    Private WithEvents Label21 As System.Windows.Forms.Label
    Private WithEvents Label20 As System.Windows.Forms.Label
    Private WithEvents Label19 As System.Windows.Forms.Label
    Private WithEvents Label18 As System.Windows.Forms.Label
    Private WithEvents Label14 As System.Windows.Forms.Label
    Private WithEvents Label12 As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRemark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents HiastoryTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcHistory1 As ucHistory
    Friend WithEvents AddressTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcAddress1 As ucAddress
    Friend WithEvents SWOTTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcSWOT1 As ucSWOT
    Friend WithEvents NoteTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcNote1 As ucNote
    Friend WithEvents AttachmentTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcFileAttach1 As ucFileAttach
    Friend WithEvents AdminTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcAdmin1 As ucAdmin
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DecisionMakerID As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnDecision As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboRating As DevExpress.XtraEditors.ComboBoxEdit
    Private WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNoOfEmployee As DevExpress.XtraEditors.CalcEdit
    Private WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtAnnualRevenue As DevExpress.XtraEditors.CalcEdit
    Private WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents FormChangedComponent1 As FormChangedComponent
    Private WithEvents Label25 As System.Windows.Forms.Label
    Private WithEvents CompanyType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnCompanyType As DevExpress.XtraEditors.SimpleButton
    Private WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents CompanyRelateID As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CusName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Phone1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Fax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Email1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EMPNAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCompanyRelateID As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents AddressShipPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcAddress2 As ucAddress
    Friend WithEvents CreditTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ContactPersonID As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnContactPersonID As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents UcCreditInfo1 As ucCreditInfo

   
End Class
