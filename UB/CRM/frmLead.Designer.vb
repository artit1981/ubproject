<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLead
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLead))
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.GeneralTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CustomerID = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CusName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Phone1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Fax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Email1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EMPNAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnCustomerID = New DevExpress.XtraEditors.SimpleButton()
        Me.cboTerritory = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboBusinessType = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboIndustryType = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboCampaign = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboSource = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtCapital = New DevExpress.XtraEditors.CalcEdit()
        Me.txtEstimatedBudjet = New DevExpress.XtraEditors.CalcEdit()
        Me.txtAnnualRevenue = New DevExpress.XtraEditors.CalcEdit()
        Me.txtNoOfEmployee = New DevExpress.XtraEditors.CalcEdit()
        Me.txtBuyingTimeFrame = New DevExpress.XtraEditors.CalcEdit()
        Me.cboLeadType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnRefreshTerritory = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRefreshBusinessType = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDisqualifyStatus = New DevExpress.XtraEditors.TextEdit()
        Me.txtLeadStatus = New DevExpress.XtraEditors.TextEdit()
        Me.txtEmp = New DevExpress.XtraEditors.TextEdit()
        Me.txtPosition = New DevExpress.XtraEditors.TextEdit()
        Me.dtpEsttablishedDate = New DevExpress.XtraEditors.DateEdit()
        Me.txtCOMPANYNAME = New DevExpress.XtraEditors.TextEdit()
        Me.btnRefreshSource = New DevExpress.XtraEditors.SimpleButton()
        Me.txtLASTNAME = New DevExpress.XtraEditors.TextEdit()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnRefreshIndustryType = New DevExpress.XtraEditors.SimpleButton()
        Me.cboRating = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnRefreshCampaign = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRefreshLeadType = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRefreshTitle = New DevExpress.XtraEditors.SimpleButton()
        Me.txtFIRSTNAME = New DevExpress.XtraEditors.TextEdit()
        Me.cboTITLE = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtSUBJECT = New DevExpress.XtraEditors.TextEdit()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRemark = New DevExpress.XtraEditors.MemoEdit()
        Me.AddressTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcAddress1 = New ucAddress()
        Me.ProductTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcProductLists1 = New ucProductLists()
        Me.SWOTTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcSWOT1 = New ucSWOT()
        Me.NoteTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcNote1 = New ucNote()
        Me.AttachmentTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcFileAttach1 = New ucFileAttach()
        Me.AdminTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcAdmin1 = New ucAdmin()
        Me.MemoEdit4 = New DevExpress.XtraEditors.MemoEdit()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.FormChangedComponent1 = New FormChangedComponent(Me.components)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.GeneralTabPage.SuspendLayout()
        CType(Me.CustomerID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTerritory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBusinessType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboIndustryType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCampaign.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSource.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCapital.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstimatedBudjet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAnnualRevenue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoOfEmployee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBuyingTimeFrame.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLeadType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisqualifyStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLeadStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPosition.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpEsttablishedDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpEsttablishedDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCOMPANYNAME.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLASTNAME.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRating.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFIRSTNAME.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTITLE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSUBJECT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AddressTabPage.SuspendLayout()
        Me.ProductTabPage.SuspendLayout()
        Me.SWOTTabPage.SuspendLayout()
        Me.NoteTabPage.SuspendLayout()
        Me.AttachmentTabPage.SuspendLayout()
        Me.AdminTabPage.SuspendLayout()
        CType(Me.MemoEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraTabControl1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.XtraTabControl1, "")
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.HeaderButtons = DevExpress.XtraTab.TabButtons.None
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 37)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.XtraTabControl1, True)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.GeneralTabPage
        Me.XtraTabControl1.Size = New System.Drawing.Size(849, 537)
        Me.XtraTabControl1.TabIndex = 4
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.GeneralTabPage, Me.AddressTabPage, Me.ProductTabPage, Me.SWOTTabPage, Me.NoteTabPage, Me.AttachmentTabPage, Me.AdminTabPage})
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.XtraTabControl1, "")
        '
        'GeneralTabPage
        '
        Me.GeneralTabPage.Appearance.PageClient.BackColor = System.Drawing.Color.LightGray
        Me.GeneralTabPage.Appearance.PageClient.Options.UseBackColor = True
        Me.GeneralTabPage.AutoScroll = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.GeneralTabPage, "")
        Me.GeneralTabPage.Controls.Add(Me.Label1)
        Me.GeneralTabPage.Controls.Add(Me.CustomerID)
        Me.GeneralTabPage.Controls.Add(Me.btnCustomerID)
        Me.GeneralTabPage.Controls.Add(Me.cboTerritory)
        Me.GeneralTabPage.Controls.Add(Me.cboBusinessType)
        Me.GeneralTabPage.Controls.Add(Me.cboIndustryType)
        Me.GeneralTabPage.Controls.Add(Me.cboCampaign)
        Me.GeneralTabPage.Controls.Add(Me.cboSource)
        Me.GeneralTabPage.Controls.Add(Me.txtCapital)
        Me.GeneralTabPage.Controls.Add(Me.txtEstimatedBudjet)
        Me.GeneralTabPage.Controls.Add(Me.txtAnnualRevenue)
        Me.GeneralTabPage.Controls.Add(Me.txtNoOfEmployee)
        Me.GeneralTabPage.Controls.Add(Me.txtBuyingTimeFrame)
        Me.GeneralTabPage.Controls.Add(Me.cboLeadType)
        Me.GeneralTabPage.Controls.Add(Me.btnRefreshTerritory)
        Me.GeneralTabPage.Controls.Add(Me.btnRefreshBusinessType)
        Me.GeneralTabPage.Controls.Add(Me.txtDisqualifyStatus)
        Me.GeneralTabPage.Controls.Add(Me.txtLeadStatus)
        Me.GeneralTabPage.Controls.Add(Me.txtEmp)
        Me.GeneralTabPage.Controls.Add(Me.txtPosition)
        Me.GeneralTabPage.Controls.Add(Me.dtpEsttablishedDate)
        Me.GeneralTabPage.Controls.Add(Me.txtCOMPANYNAME)
        Me.GeneralTabPage.Controls.Add(Me.btnRefreshSource)
        Me.GeneralTabPage.Controls.Add(Me.txtLASTNAME)
        Me.GeneralTabPage.Controls.Add(Me.Label33)
        Me.GeneralTabPage.Controls.Add(Me.Label27)
        Me.GeneralTabPage.Controls.Add(Me.Label25)
        Me.GeneralTabPage.Controls.Add(Me.Label23)
        Me.GeneralTabPage.Controls.Add(Me.Label22)
        Me.GeneralTabPage.Controls.Add(Me.Label17)
        Me.GeneralTabPage.Controls.Add(Me.Label15)
        Me.GeneralTabPage.Controls.Add(Me.Label13)
        Me.GeneralTabPage.Controls.Add(Me.Label10)
        Me.GeneralTabPage.Controls.Add(Me.Label9)
        Me.GeneralTabPage.Controls.Add(Me.btnRefreshIndustryType)
        Me.GeneralTabPage.Controls.Add(Me.cboRating)
        Me.GeneralTabPage.Controls.Add(Me.btnRefreshCampaign)
        Me.GeneralTabPage.Controls.Add(Me.btnRefreshLeadType)
        Me.GeneralTabPage.Controls.Add(Me.btnRefreshTitle)
        Me.GeneralTabPage.Controls.Add(Me.txtFIRSTNAME)
        Me.GeneralTabPage.Controls.Add(Me.cboTITLE)
        Me.GeneralTabPage.Controls.Add(Me.txtSUBJECT)
        Me.GeneralTabPage.Controls.Add(Me.Label32)
        Me.GeneralTabPage.Controls.Add(Me.Label30)
        Me.GeneralTabPage.Controls.Add(Me.Label31)
        Me.GeneralTabPage.Controls.Add(Me.Label29)
        Me.GeneralTabPage.Controls.Add(Me.Label28)
        Me.GeneralTabPage.Controls.Add(Me.Label26)
        Me.GeneralTabPage.Controls.Add(Me.Label24)
        Me.GeneralTabPage.Controls.Add(Me.Label21)
        Me.GeneralTabPage.Controls.Add(Me.Label20)
        Me.GeneralTabPage.Controls.Add(Me.Label19)
        Me.GeneralTabPage.Controls.Add(Me.Label18)
        Me.GeneralTabPage.Controls.Add(Me.Label16)
        Me.GeneralTabPage.Controls.Add(Me.Label14)
        Me.GeneralTabPage.Controls.Add(Me.Label12)
        Me.GeneralTabPage.Controls.Add(Me.Label11)
        Me.GeneralTabPage.Controls.Add(Me.Label8)
        Me.GeneralTabPage.Controls.Add(Me.Label4)
        Me.GeneralTabPage.Controls.Add(Me.Label5)
        Me.GeneralTabPage.Controls.Add(Me.Label6)
        Me.GeneralTabPage.Controls.Add(Me.txtRemark)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.GeneralTabPage, True)
        Me.GeneralTabPage.Name = "GeneralTabPage"
        Me.GeneralTabPage.Size = New System.Drawing.Size(843, 509)
        Me.GeneralTabPage.Text = "ข้อมูลทั่วไป"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.GeneralTabPage, "")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label1, "")
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 278)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label1, True)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 14)
        Me.Label1.TabIndex = 220
        Me.Label1.Text = "บริษัทในเครือ"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label1, "")
        '
        'CustomerID
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.CustomerID, "TextChanged")
        Me.CustomerID.EnterMoveNextControl = True
        Me.CustomerID.Location = New System.Drawing.Point(143, 275)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.CustomerID, True)
        Me.CustomerID.Name = "CustomerID"
        Me.CustomerID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerID.Properties.Appearance.Options.UseFont = True
        Me.CustomerID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CustomerID.Properties.NullText = ""
        Me.CustomerID.Properties.PopupFindMode = DevExpress.XtraEditors.FindMode.Always
        Me.CustomerID.Properties.View = Me.SearchLookUpEdit1View
        Me.CustomerID.Size = New System.Drawing.Size(213, 20)
        Me.CustomerID.TabIndex = 10
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.CustomerID, "Text")
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.Code, Me.CusName, Me.Type, Me.Phone1, Me.Fax, Me.Email1, Me.EMPNAME})
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
        'btnCustomerID
        '
        Me.btnCustomerID.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCustomerID.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnCustomerID, "")
        Me.btnCustomerID.Image = CType(resources.GetObject("btnCustomerID.Image"), System.Drawing.Image)
        Me.btnCustomerID.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCustomerID.Location = New System.Drawing.Point(358, 275)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnCustomerID, True)
        Me.btnCustomerID.Name = "btnCustomerID"
        Me.btnCustomerID.Size = New System.Drawing.Size(21, 21)
        Me.btnCustomerID.TabIndex = 219
        Me.btnCustomerID.TabStop = False
        Me.btnCustomerID.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnCustomerID, "")
        '
        'cboTerritory
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.cboTerritory, "TextChanged")
        Me.cboTerritory.EnterMoveNextControl = True
        Me.cboTerritory.Location = New System.Drawing.Point(143, 461)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.cboTerritory, True)
        Me.cboTerritory.Name = "cboTerritory"
        Me.cboTerritory.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboTerritory.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTerritory.Properties.Appearance.Options.UseFont = True
        Me.cboTerritory.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboTerritory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTerritory.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 50, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TerritoryCode", 50, "รหัสทีมขาย"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NameThai", 70, "ชื่อทีมขาย")})
        Me.cboTerritory.Properties.DropDownRows = 10
        Me.cboTerritory.Properties.ImmediatePopup = True
        Me.cboTerritory.Properties.NullText = ""
        Me.cboTerritory.Properties.NullValuePromptShowForEmptyValue = True
        Me.cboTerritory.Properties.PopupWidth = 300
        Me.cboTerritory.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboTerritory.Properties.ThrowExceptionOnInvalidLookUpEditValueType = True
        Me.cboTerritory.Properties.UseCtrlScroll = True
        Me.cboTerritory.Size = New System.Drawing.Size(212, 20)
        Me.cboTerritory.TabIndex = 20
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.cboTerritory, "Text")
        '
        'cboBusinessType
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.cboBusinessType, "TextChanged")
        Me.cboBusinessType.EnterMoveNextControl = True
        Me.cboBusinessType.Location = New System.Drawing.Point(144, 356)
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
        Me.cboBusinessType.TabIndex = 14
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.cboBusinessType, "Text")
        '
        'cboIndustryType
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.cboIndustryType, "TextChanged")
        Me.cboIndustryType.EditValue = ""
        Me.cboIndustryType.EnterMoveNextControl = True
        Me.cboIndustryType.Location = New System.Drawing.Point(144, 329)
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
        Me.cboIndustryType.TabIndex = 12
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.cboIndustryType, "Text")
        '
        'cboCampaign
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.cboCampaign, "TextChanged")
        Me.cboCampaign.Enabled = False
        Me.cboCampaign.EnterMoveNextControl = True
        Me.cboCampaign.Location = New System.Drawing.Point(144, 144)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.cboCampaign, True)
        Me.cboCampaign.Name = "cboCampaign"
        Me.cboCampaign.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboCampaign.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCampaign.Properties.Appearance.Options.UseFont = True
        Me.cboCampaign.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboCampaign.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCampaign.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 50, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeThai", 50, "ชื่อข้อความ"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeEng", "", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Center), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Remark", 70, "รายละเอียด")})
        Me.cboCampaign.Properties.DropDownRows = 10
        Me.cboCampaign.Properties.NullText = ""
        Me.cboCampaign.Properties.NullValuePromptShowForEmptyValue = True
        Me.cboCampaign.Properties.PopupWidth = 300
        Me.cboCampaign.Size = New System.Drawing.Size(212, 20)
        Me.cboCampaign.TabIndex = 6
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.cboCampaign, "Text")
        '
        'cboSource
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.cboSource, "TextChanged")
        Me.cboSource.EnterMoveNextControl = True
        Me.cboSource.Location = New System.Drawing.Point(489, 117)
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
        'txtCapital
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtCapital, "TextChanged")
        Me.txtCapital.EnterMoveNextControl = True
        Me.txtCapital.Location = New System.Drawing.Point(489, 410)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.txtCapital, True)
        Me.txtCapital.Name = "txtCapital"
        Me.txtCapital.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCapital.Properties.Appearance.Options.UseFont = True
        Me.txtCapital.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCapital.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCapital.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCapital.Properties.Mask.EditMask = "n"
        Me.txtCapital.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCapital.Properties.Precision = 2
        Me.txtCapital.Size = New System.Drawing.Size(212, 20)
        Me.txtCapital.TabIndex = 19
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtCapital, "Text")
        '
        'txtEstimatedBudjet
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtEstimatedBudjet, "TextChanged")
        Me.txtEstimatedBudjet.EnterMoveNextControl = True
        Me.txtEstimatedBudjet.Location = New System.Drawing.Point(489, 383)
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
        Me.txtEstimatedBudjet.TabIndex = 17
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtEstimatedBudjet, "Text")
        '
        'txtAnnualRevenue
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtAnnualRevenue, "TextChanged")
        Me.txtAnnualRevenue.EnterMoveNextControl = True
        Me.txtAnnualRevenue.Location = New System.Drawing.Point(144, 410)
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
        Me.txtAnnualRevenue.TabIndex = 18
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtAnnualRevenue, "Text")
        '
        'txtNoOfEmployee
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtNoOfEmployee, "TextChanged")
        Me.txtNoOfEmployee.EnterMoveNextControl = True
        Me.txtNoOfEmployee.Location = New System.Drawing.Point(144, 383)
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
        Me.txtNoOfEmployee.TabIndex = 16
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtNoOfEmployee, "Text")
        '
        'txtBuyingTimeFrame
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtBuyingTimeFrame, "TextChanged")
        Me.txtBuyingTimeFrame.EnterMoveNextControl = True
        Me.txtBuyingTimeFrame.Location = New System.Drawing.Point(489, 356)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.txtBuyingTimeFrame, True)
        Me.txtBuyingTimeFrame.Name = "txtBuyingTimeFrame"
        Me.txtBuyingTimeFrame.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuyingTimeFrame.Properties.Appearance.Options.UseFont = True
        Me.txtBuyingTimeFrame.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtBuyingTimeFrame.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBuyingTimeFrame.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBuyingTimeFrame.Properties.Mask.EditMask = "n0"
        Me.txtBuyingTimeFrame.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtBuyingTimeFrame.Properties.Precision = 0
        Me.txtBuyingTimeFrame.Size = New System.Drawing.Size(212, 20)
        Me.txtBuyingTimeFrame.TabIndex = 15
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtBuyingTimeFrame, "Text")
        '
        'cboLeadType
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.cboLeadType, "TextChanged")
        Me.cboLeadType.EnterMoveNextControl = True
        Me.cboLeadType.Location = New System.Drawing.Point(144, 117)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.cboLeadType, True)
        Me.cboLeadType.Name = "cboLeadType"
        Me.cboLeadType.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboLeadType.Properties.Appearance.Options.UseFont = True
        Me.cboLeadType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboLeadType.Properties.ImmediatePopup = True
        Me.cboLeadType.Properties.UseCtrlScroll = True
        Me.cboLeadType.Properties.ValidateOnEnterKey = True
        Me.cboLeadType.Size = New System.Drawing.Size(212, 20)
        Me.cboLeadType.TabIndex = 4
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.cboLeadType, "Text")
        '
        'btnRefreshTerritory
        '
        Me.btnRefreshTerritory.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRefreshTerritory.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnRefreshTerritory, "")
        Me.btnRefreshTerritory.Image = CType(resources.GetObject("btnRefreshTerritory.Image"), System.Drawing.Image)
        Me.btnRefreshTerritory.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefreshTerritory.Location = New System.Drawing.Point(358, 461)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnRefreshTerritory, True)
        Me.btnRefreshTerritory.Name = "btnRefreshTerritory"
        Me.btnRefreshTerritory.Size = New System.Drawing.Size(21, 21)
        Me.btnRefreshTerritory.TabIndex = 170
        Me.btnRefreshTerritory.TabStop = False
        Me.btnRefreshTerritory.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnRefreshTerritory, "")
        '
        'btnRefreshBusinessType
        '
        Me.btnRefreshBusinessType.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRefreshBusinessType.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnRefreshBusinessType, "")
        Me.btnRefreshBusinessType.Image = CType(resources.GetObject("btnRefreshBusinessType.Image"), System.Drawing.Image)
        Me.btnRefreshBusinessType.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefreshBusinessType.Location = New System.Drawing.Point(358, 356)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnRefreshBusinessType, True)
        Me.btnRefreshBusinessType.Name = "btnRefreshBusinessType"
        Me.btnRefreshBusinessType.Size = New System.Drawing.Size(21, 21)
        Me.btnRefreshBusinessType.TabIndex = 169
        Me.btnRefreshBusinessType.TabStop = False
        Me.btnRefreshBusinessType.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnRefreshBusinessType, "")
        '
        'txtDisqualifyStatus
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtDisqualifyStatus, "TextChanged")
        Me.txtDisqualifyStatus.EditValue = ""
        Me.txtDisqualifyStatus.EnterMoveNextControl = True
        Me.txtDisqualifyStatus.Location = New System.Drawing.Point(489, 171)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.txtDisqualifyStatus, True)
        Me.txtDisqualifyStatus.Name = "txtDisqualifyStatus"
        Me.txtDisqualifyStatus.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.txtDisqualifyStatus.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDisqualifyStatus.Properties.Appearance.Options.UseBackColor = True
        Me.txtDisqualifyStatus.Properties.Appearance.Options.UseFont = True
        Me.txtDisqualifyStatus.Properties.MaxLength = 50
        Me.txtDisqualifyStatus.Properties.ReadOnly = True
        Me.txtDisqualifyStatus.Properties.ValidateOnEnterKey = True
        Me.txtDisqualifyStatus.Size = New System.Drawing.Size(212, 20)
        Me.txtDisqualifyStatus.TabIndex = 165
        Me.txtDisqualifyStatus.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtDisqualifyStatus, "Text")
        '
        'txtLeadStatus
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtLeadStatus, "TextChanged")
        Me.txtLeadStatus.EditValue = ""
        Me.txtLeadStatus.EnterMoveNextControl = True
        Me.txtLeadStatus.Location = New System.Drawing.Point(489, 144)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.txtLeadStatus, True)
        Me.txtLeadStatus.Name = "txtLeadStatus"
        Me.txtLeadStatus.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.txtLeadStatus.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLeadStatus.Properties.Appearance.Options.UseBackColor = True
        Me.txtLeadStatus.Properties.Appearance.Options.UseFont = True
        Me.txtLeadStatus.Properties.MaxLength = 50
        Me.txtLeadStatus.Properties.ReadOnly = True
        Me.txtLeadStatus.Properties.ValidateOnEnterKey = True
        Me.txtLeadStatus.Size = New System.Drawing.Size(212, 20)
        Me.txtLeadStatus.TabIndex = 7
        Me.txtLeadStatus.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtLeadStatus, "Text")
        '
        'txtEmp
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtEmp, "TextChanged")
        Me.txtEmp.EditValue = ""
        Me.txtEmp.EnterMoveNextControl = True
        Me.txtEmp.Location = New System.Drawing.Point(489, 461)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.txtEmp, True)
        Me.txtEmp.Name = "txtEmp"
        Me.txtEmp.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.txtEmp.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtEmp.Properties.Appearance.Options.UseBackColor = True
        Me.txtEmp.Properties.Appearance.Options.UseFont = True
        Me.txtEmp.Properties.MaxLength = 50
        Me.txtEmp.Properties.ReadOnly = True
        Me.txtEmp.Properties.ValidateOnEnterKey = True
        Me.txtEmp.Size = New System.Drawing.Size(212, 20)
        Me.txtEmp.TabIndex = 163
        Me.txtEmp.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtEmp, "Text")
        '
        'txtPosition
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtPosition, "TextChanged")
        Me.txtPosition.EditValue = ""
        Me.txtPosition.EnterMoveNextControl = True
        Me.txtPosition.Location = New System.Drawing.Point(489, 302)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.txtPosition, True)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPosition.Properties.Appearance.Options.UseFont = True
        Me.txtPosition.Properties.MaxLength = 50
        Me.txtPosition.Properties.ValidateOnEnterKey = True
        Me.txtPosition.Size = New System.Drawing.Size(212, 20)
        Me.txtPosition.TabIndex = 11
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtPosition, "Text")
        '
        'dtpEsttablishedDate
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.dtpEsttablishedDate, "TextChanged")
        Me.dtpEsttablishedDate.EditValue = New Date(2012, 4, 20, 0, 0, 0, 0)
        Me.dtpEsttablishedDate.EnterMoveNextControl = True
        Me.dtpEsttablishedDate.Location = New System.Drawing.Point(489, 329)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.dtpEsttablishedDate, True)
        Me.dtpEsttablishedDate.Name = "dtpEsttablishedDate"
        Me.dtpEsttablishedDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.dtpEsttablishedDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpEsttablishedDate.Properties.Appearance.Options.UseFont = True
        Me.dtpEsttablishedDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpEsttablishedDate.Properties.DisplayFormat.FormatString = "D"
        Me.dtpEsttablishedDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpEsttablishedDate.Properties.EditFormat.FormatString = "D"
        Me.dtpEsttablishedDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpEsttablishedDate.Properties.Mask.EditMask = "D"
        Me.dtpEsttablishedDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpEsttablishedDate.Size = New System.Drawing.Size(212, 20)
        Me.dtpEsttablishedDate.TabIndex = 13
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.dtpEsttablishedDate, "Text")
        '
        'txtCOMPANYNAME
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtCOMPANYNAME, "TextChanged")
        Me.txtCOMPANYNAME.EditValue = ""
        Me.txtCOMPANYNAME.EnterMoveNextControl = True
        Me.txtCOMPANYNAME.Location = New System.Drawing.Point(144, 302)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.txtCOMPANYNAME, True)
        Me.txtCOMPANYNAME.Name = "txtCOMPANYNAME"
        Me.txtCOMPANYNAME.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCOMPANYNAME.Properties.Appearance.Options.UseFont = True
        Me.txtCOMPANYNAME.Properties.MaxLength = 50
        Me.txtCOMPANYNAME.Properties.ValidateOnEnterKey = True
        Me.txtCOMPANYNAME.Size = New System.Drawing.Size(212, 20)
        Me.txtCOMPANYNAME.TabIndex = 10
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtCOMPANYNAME, "Text")
        '
        'btnRefreshSource
        '
        Me.btnRefreshSource.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRefreshSource.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnRefreshSource, "")
        Me.btnRefreshSource.Image = CType(resources.GetObject("btnRefreshSource.Image"), System.Drawing.Image)
        Me.btnRefreshSource.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefreshSource.Location = New System.Drawing.Point(703, 117)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnRefreshSource, True)
        Me.btnRefreshSource.Name = "btnRefreshSource"
        Me.btnRefreshSource.Size = New System.Drawing.Size(21, 21)
        Me.btnRefreshSource.TabIndex = 149
        Me.btnRefreshSource.TabStop = False
        Me.btnRefreshSource.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnRefreshSource, "")
        '
        'txtLASTNAME
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtLASTNAME, "TextChanged")
        Me.txtLASTNAME.EditValue = ""
        Me.txtLASTNAME.EnterMoveNextControl = True
        Me.txtLASTNAME.Location = New System.Drawing.Point(489, 90)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.txtLASTNAME, True)
        Me.txtLASTNAME.Name = "txtLASTNAME"
        Me.txtLASTNAME.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLASTNAME.Properties.Appearance.Options.UseFont = True
        Me.txtLASTNAME.Properties.MaxLength = 100
        Me.txtLASTNAME.Properties.ValidateOnEnterKey = True
        Me.txtLASTNAME.Size = New System.Drawing.Size(212, 20)
        Me.txtLASTNAME.TabIndex = 3
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtLASTNAME, "Text")
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label33, "")
        Me.Label33.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label33.Location = New System.Drawing.Point(393, 464)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label33, True)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(64, 14)
        Me.Label33.TabIndex = 146
        Me.Label33.Text = "ผู้รับผิดชอบ"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label33, "")
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label27, "")
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label27.Location = New System.Drawing.Point(393, 412)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label27, True)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(53, 14)
        Me.Label27.TabIndex = 145
        Me.Label27.Text = "เงินลงทุน"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label27, "")
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label25, "")
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label25.Location = New System.Drawing.Point(393, 386)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label25, True)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(62, 14)
        Me.Label25.TabIndex = 144
        Me.Label25.Text = "งบประมาณ"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label25, "")
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label23, "")
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label23.Location = New System.Drawing.Point(393, 360)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label23, True)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(90, 14)
        Me.Label23.TabIndex = 143
        Me.Label23.Text = "ระยะเวลาซื้อ(วัน)"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label23, "")
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label22, "")
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label22.Location = New System.Drawing.Point(393, 333)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label22, True)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(56, 14)
        Me.Label22.TabIndex = 142
        Me.Label22.Text = "วันที่ก่อตั้ง"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label22, "")
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label17, "")
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.Location = New System.Drawing.Point(393, 173)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label17, True)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(94, 14)
        Me.Label17.TabIndex = 141
        Me.Label17.Text = "เงื่อนไขการยกเลิก"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label17, "")
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label15, "")
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(393, 148)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label15, True)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 14)
        Me.Label15.TabIndex = 140
        Me.Label15.Text = "สถานะ"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label15, "")
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label13, "")
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(393, 120)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label13, True)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 14)
        Me.Label13.TabIndex = 139
        Me.Label13.Text = "แหล่งที่มา"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label13, "")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label10, "")
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(393, 305)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label10, True)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 14)
        Me.Label10.TabIndex = 138
        Me.Label10.Text = "ตำแหน่งงาน"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label10, "")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label9, "")
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(393, 93)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label9, True)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 14)
        Me.Label9.TabIndex = 137
        Me.Label9.Text = "นามสกุล"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label9, "")
        '
        'btnRefreshIndustryType
        '
        Me.btnRefreshIndustryType.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRefreshIndustryType.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnRefreshIndustryType, "")
        Me.btnRefreshIndustryType.Image = CType(resources.GetObject("btnRefreshIndustryType.Image"), System.Drawing.Image)
        Me.btnRefreshIndustryType.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefreshIndustryType.Location = New System.Drawing.Point(358, 329)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnRefreshIndustryType, True)
        Me.btnRefreshIndustryType.Name = "btnRefreshIndustryType"
        Me.btnRefreshIndustryType.Size = New System.Drawing.Size(21, 21)
        Me.btnRefreshIndustryType.TabIndex = 135
        Me.btnRefreshIndustryType.TabStop = False
        Me.btnRefreshIndustryType.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnRefreshIndustryType, "")
        '
        'cboRating
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.cboRating, "TextChanged")
        Me.cboRating.EditValue = "Nomal"
        Me.cboRating.EnterMoveNextControl = True
        Me.cboRating.Location = New System.Drawing.Point(144, 171)
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
        Me.cboRating.TabIndex = 8
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.cboRating, "Text")
        '
        'btnRefreshCampaign
        '
        Me.btnRefreshCampaign.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRefreshCampaign.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnRefreshCampaign, "")
        Me.btnRefreshCampaign.Enabled = False
        Me.btnRefreshCampaign.Image = CType(resources.GetObject("btnRefreshCampaign.Image"), System.Drawing.Image)
        Me.btnRefreshCampaign.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefreshCampaign.Location = New System.Drawing.Point(358, 144)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnRefreshCampaign, True)
        Me.btnRefreshCampaign.Name = "btnRefreshCampaign"
        Me.btnRefreshCampaign.Size = New System.Drawing.Size(21, 21)
        Me.btnRefreshCampaign.TabIndex = 133
        Me.btnRefreshCampaign.TabStop = False
        Me.btnRefreshCampaign.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnRefreshCampaign, "")
        '
        'btnRefreshLeadType
        '
        Me.btnRefreshLeadType.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRefreshLeadType.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnRefreshLeadType, "")
        Me.btnRefreshLeadType.Image = CType(resources.GetObject("btnRefreshLeadType.Image"), System.Drawing.Image)
        Me.btnRefreshLeadType.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefreshLeadType.Location = New System.Drawing.Point(358, 117)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnRefreshLeadType, True)
        Me.btnRefreshLeadType.Name = "btnRefreshLeadType"
        Me.btnRefreshLeadType.Size = New System.Drawing.Size(21, 21)
        Me.btnRefreshLeadType.TabIndex = 131
        Me.btnRefreshLeadType.TabStop = False
        Me.btnRefreshLeadType.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnRefreshLeadType, "")
        '
        'btnRefreshTitle
        '
        Me.btnRefreshTitle.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRefreshTitle.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnRefreshTitle, "")
        Me.btnRefreshTitle.Image = CType(resources.GetObject("btnRefreshTitle.Image"), System.Drawing.Image)
        Me.btnRefreshTitle.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefreshTitle.Location = New System.Drawing.Point(358, 63)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnRefreshTitle, True)
        Me.btnRefreshTitle.Name = "btnRefreshTitle"
        Me.btnRefreshTitle.Size = New System.Drawing.Size(21, 21)
        Me.btnRefreshTitle.TabIndex = 129
        Me.btnRefreshTitle.TabStop = False
        Me.btnRefreshTitle.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnRefreshTitle, "")
        '
        'txtFIRSTNAME
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtFIRSTNAME, "TextChanged")
        Me.txtFIRSTNAME.EditValue = ""
        Me.txtFIRSTNAME.EnterMoveNextControl = True
        Me.txtFIRSTNAME.Location = New System.Drawing.Point(144, 90)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.txtFIRSTNAME, True)
        Me.txtFIRSTNAME.Name = "txtFIRSTNAME"
        Me.txtFIRSTNAME.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtFIRSTNAME.Properties.Appearance.Options.UseFont = True
        Me.txtFIRSTNAME.Properties.MaxLength = 100
        Me.txtFIRSTNAME.Properties.ValidateOnEnterKey = True
        Me.txtFIRSTNAME.Size = New System.Drawing.Size(212, 20)
        Me.txtFIRSTNAME.TabIndex = 2
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtFIRSTNAME, "Text")
        '
        'cboTITLE
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.cboTITLE, "TextChanged")
        Me.cboTITLE.EnterMoveNextControl = True
        Me.cboTITLE.Location = New System.Drawing.Point(144, 63)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.cboTITLE, True)
        Me.cboTITLE.Name = "cboTITLE"
        Me.cboTITLE.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboTITLE.Properties.Appearance.Options.UseFont = True
        Me.cboTITLE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTITLE.Properties.ImmediatePopup = True
        Me.cboTITLE.Properties.UseCtrlScroll = True
        Me.cboTITLE.Properties.ValidateOnEnterKey = True
        Me.cboTITLE.Size = New System.Drawing.Size(212, 20)
        Me.cboTITLE.TabIndex = 1
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.cboTITLE, "Text")
        '
        'txtSUBJECT
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtSUBJECT, "TextChanged")
        Me.txtSUBJECT.EditValue = ""
        Me.txtSUBJECT.EnterMoveNextControl = True
        Me.txtSUBJECT.Location = New System.Drawing.Point(144, 36)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.txtSUBJECT, True)
        Me.txtSUBJECT.Name = "txtSUBJECT"
        Me.txtSUBJECT.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSUBJECT.Properties.Appearance.Options.UseFont = True
        Me.txtSUBJECT.Properties.MaxLength = 100
        Me.txtSUBJECT.Properties.ValidateOnEnterKey = True
        Me.txtSUBJECT.Size = New System.Drawing.Size(557, 20)
        Me.txtSUBJECT.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtSUBJECT, "Text")
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label32, "")
        Me.Label32.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label32.Location = New System.Drawing.Point(42, 464)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label32, True)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(43, 14)
        Me.Label32.TabIndex = 124
        Me.Label32.Text = "ทีมขาย"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label32, "")
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label30, "")
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.DarkGray
        Me.Label30.Location = New System.Drawing.Point(90, 439)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label30, True)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(623, 14)
        Me.Label30.TabIndex = 123
        Me.Label30.Text = "_________________________________________________________________________________" & _
            "_______"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label30, "")
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label31, "")
        Me.Label31.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label31.Location = New System.Drawing.Point(34, 439)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label31, True)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(60, 14)
        Me.Label31.TabIndex = 122
        Me.Label31.Text = "ข้อมูลธุรกิจ"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label31, "")
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label29, "")
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.DarkGray
        Me.Label29.Location = New System.Drawing.Point(104, 255)
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
        Me.Label28.Location = New System.Drawing.Point(104, 11)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label28, True)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(623, 14)
        Me.Label28.TabIndex = 120
        Me.Label28.Text = "_________________________________________________________________________________" & _
            "_______"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label28, "")
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label26, "")
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label26.Location = New System.Drawing.Point(42, 412)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label26, True)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(77, 14)
        Me.Label26.TabIndex = 119
        Me.Label26.Text = "รายได้ประจำปี"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label26, "")
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label24, "")
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label24.Location = New System.Drawing.Point(42, 386)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label24, True)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(80, 14)
        Me.Label24.TabIndex = 118
        Me.Label24.Text = "จำนวนพนักงาน"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label24, "")
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label21, "")
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label21.Location = New System.Drawing.Point(42, 360)
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
        Me.Label20.Location = New System.Drawing.Point(42, 333)
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
        Me.Label19.Location = New System.Drawing.Point(34, 255)
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
        Me.Label18.Location = New System.Drawing.Point(34, 15)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label18, True)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 14)
        Me.Label18.TabIndex = 114
        Me.Label18.Text = "ข้อมูลทั่วไป"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label18, "")
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label16, "")
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(42, 174)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label16, True)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 14)
        Me.Label16.TabIndex = 113
        Me.Label16.Text = "ระดับความสนใจ"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label16, "")
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label14, "")
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(42, 147)
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
        Me.Label12.Location = New System.Drawing.Point(42, 120)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label12, True)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 14)
        Me.Label12.TabIndex = 111
        Me.Label12.Text = "ประเภทการเพิ่ม"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label12, "")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label11, "")
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(42, 305)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label11, True)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 14)
        Me.Label11.TabIndex = 110
        Me.Label11.Text = "ชื่อบริษัท"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label11, "")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label8, "")
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(42, 93)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label8, True)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 14)
        Me.Label8.TabIndex = 109
        Me.Label8.Text = "ชื่อ"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label8, "")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label4, "")
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(42, 39)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label4, True)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 14)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "หัวเรื่อง"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label4, "")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label5, "")
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(42, 201)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label5, True)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 14)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "รายละเอียด"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label5, "")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label6, "")
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(42, 66)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label6, True)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 14)
        Me.Label6.TabIndex = 106
        Me.Label6.Text = "คำนำหน้า"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label6, "")
        '
        'txtRemark
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtRemark, "TextChanged")
        Me.txtRemark.EditValue = ""
        Me.txtRemark.EnterMoveNextControl = True
        Me.txtRemark.Location = New System.Drawing.Point(144, 198)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.txtRemark, True)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRemark.Properties.Appearance.Options.UseFont = True
        Me.txtRemark.Properties.MaxLength = 100
        Me.txtRemark.Size = New System.Drawing.Size(557, 54)
        Me.txtRemark.TabIndex = 9
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtRemark, "Text")
        '
        'AddressTabPage
        '
        Me.AddressTabPage.AutoScroll = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.AddressTabPage, "")
        Me.AddressTabPage.Controls.Add(Me.UcAddress1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.AddressTabPage, True)
        Me.AddressTabPage.Name = "AddressTabPage"
        Me.AddressTabPage.Size = New System.Drawing.Size(843, 509)
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
        Me.UcAddress1.Size = New System.Drawing.Size(843, 509)
        Me.UcAddress1.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcAddress1, "")
        '
        'ProductTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.ProductTabPage, "")
        Me.ProductTabPage.Controls.Add(Me.UcProductLists1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.ProductTabPage, True)
        Me.ProductTabPage.Name = "ProductTabPage"
        Me.ProductTabPage.Size = New System.Drawing.Size(843, 509)
        Me.ProductTabPage.Text = "สินค้า"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.ProductTabPage, "")
        '
        'UcProductLists1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.UcProductLists1, "")
        Me.UcProductLists1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcProductLists1.Location = New System.Drawing.Point(0, 0)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.UcProductLists1, True)
        Me.UcProductLists1.Name = "UcProductLists1"
        Me.UcProductLists1.Size = New System.Drawing.Size(843, 509)
        Me.UcProductLists1.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcProductLists1, "")
        '
        'SWOTTabPage
        '
        Me.SWOTTabPage.AutoScroll = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.SWOTTabPage, "")
        Me.SWOTTabPage.Controls.Add(Me.UcSWOT1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.SWOTTabPage, True)
        Me.SWOTTabPage.Name = "SWOTTabPage"
        Me.SWOTTabPage.Size = New System.Drawing.Size(843, 509)
        Me.SWOTTabPage.Text = "SWOT"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.SWOTTabPage, "")
        '
        'UcSWOT1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.UcSWOT1, "")
        Me.UcSWOT1.Location = New System.Drawing.Point(29, 3)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.UcSWOT1, True)
        Me.UcSWOT1.Name = "UcSWOT1"
        Me.UcSWOT1.Size = New System.Drawing.Size(807, 488)
        Me.UcSWOT1.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcSWOT1, "")
        '
        'NoteTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.NoteTabPage, "")
        Me.NoteTabPage.Controls.Add(Me.UcNote1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.NoteTabPage, True)
        Me.NoteTabPage.Name = "NoteTabPage"
        Me.NoteTabPage.Size = New System.Drawing.Size(843, 509)
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
        Me.UcNote1.Size = New System.Drawing.Size(843, 509)
        Me.UcNote1.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcNote1, "")
        '
        'AttachmentTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.AttachmentTabPage, "")
        Me.AttachmentTabPage.Controls.Add(Me.UcFileAttach1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.AttachmentTabPage, True)
        Me.AttachmentTabPage.Name = "AttachmentTabPage"
        Me.AttachmentTabPage.Size = New System.Drawing.Size(843, 509)
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
        Me.UcFileAttach1.Size = New System.Drawing.Size(843, 509)
        Me.UcFileAttach1.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcFileAttach1, "")
        '
        'AdminTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.AdminTabPage, "")
        Me.AdminTabPage.Controls.Add(Me.UcAdmin1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.AdminTabPage, True)
        Me.AdminTabPage.Name = "AdminTabPage"
        Me.AdminTabPage.Size = New System.Drawing.Size(843, 509)
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
        'MemoEdit4
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.MemoEdit4, "TextChanged")
        Me.MemoEdit4.EditValue = ""
        Me.MemoEdit4.Location = New System.Drawing.Point(143, 284)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.MemoEdit4, True)
        Me.MemoEdit4.Name = "MemoEdit4"
        Me.MemoEdit4.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemoEdit4.Properties.Appearance.Options.UseFont = True
        Me.MemoEdit4.Properties.MaxLength = 500
        Me.MemoEdit4.Size = New System.Drawing.Size(570, 80)
        Me.MemoEdit4.TabIndex = 145
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.MemoEdit4, "Text")
        '
        'Bar2
        '
        Me.Bar2.BarName = "Custom 3"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 1
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.Text = "Custom 3"
        '
        'FormChangedComponent1
        '
        '
        'frmLead
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 574)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frmLead"
        Me.Text = "frmLead"
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.GeneralTabPage.ResumeLayout(False)
        Me.GeneralTabPage.PerformLayout()
        CType(Me.CustomerID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTerritory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBusinessType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboIndustryType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCampaign.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSource.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCapital.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstimatedBudjet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAnnualRevenue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoOfEmployee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBuyingTimeFrame.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLeadType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisqualifyStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLeadStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPosition.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpEsttablishedDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpEsttablishedDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCOMPANYNAME.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLASTNAME.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRating.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFIRSTNAME.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTITLE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSUBJECT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AddressTabPage.ResumeLayout(False)
        Me.ProductTabPage.ResumeLayout(False)
        Me.SWOTTabPage.ResumeLayout(False)
        Me.NoteTabPage.ResumeLayout(False)
        Me.AttachmentTabPage.ResumeLayout(False)
        Me.AdminTabPage.ResumeLayout(False)
        CType(Me.MemoEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents GeneralTabPage As DevExpress.XtraTab.XtraTabPage
    Private WithEvents Label32 As System.Windows.Forms.Label
    Private WithEvents Label30 As System.Windows.Forms.Label
    Private WithEvents Label31 As System.Windows.Forms.Label
    Private WithEvents Label29 As System.Windows.Forms.Label
    Private WithEvents Label28 As System.Windows.Forms.Label
    Private WithEvents Label26 As System.Windows.Forms.Label
    Private WithEvents Label24 As System.Windows.Forms.Label
    Private WithEvents Label21 As System.Windows.Forms.Label
    Private WithEvents Label20 As System.Windows.Forms.Label
    Private WithEvents Label19 As System.Windows.Forms.Label
    Private WithEvents Label18 As System.Windows.Forms.Label
    Private WithEvents Label16 As System.Windows.Forms.Label
    Private WithEvents Label14 As System.Windows.Forms.Label
    Private WithEvents Label12 As System.Windows.Forms.Label
    Private WithEvents Label11 As System.Windows.Forms.Label
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSUBJECT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboTITLE As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnRefreshTitle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFIRSTNAME As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnRefreshLeadType As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRefreshIndustryType As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboRating As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnRefreshCampaign As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtRemark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtPosition As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtpEsttablishedDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtCOMPANYNAME As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnRefreshSource As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtLASTNAME As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label33 As System.Windows.Forms.Label
    Private WithEvents Label27 As System.Windows.Forms.Label
    Private WithEvents Label25 As System.Windows.Forms.Label
    Private WithEvents Label23 As System.Windows.Forms.Label
    Private WithEvents Label22 As System.Windows.Forms.Label
    Private WithEvents Label17 As System.Windows.Forms.Label
    Private WithEvents Label15 As System.Windows.Forms.Label
    Private WithEvents Label13 As System.Windows.Forms.Label
    Private WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtEmp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnRefreshTerritory As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRefreshBusinessType As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDisqualifyStatus As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLeadStatus As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SWOTTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents MemoEdit4 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents AttachmentTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents AdminTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents AddressTabPage As DevExpress.XtraTab.XtraTabPage

    Friend WithEvents UcFileAttach1 As ucFileAttach
    Friend WithEvents UcAddress1 As ucAddress
    Friend WithEvents cboLeadType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtBuyingTimeFrame As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents txtCapital As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents txtEstimatedBudjet As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents txtAnnualRevenue As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents txtNoOfEmployee As DevExpress.XtraEditors.CalcEdit
    Private WithEvents cboSource As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents UcAdmin1 As ucAdmin
    Friend WithEvents UcSWOT1 As ucSWOT
    Private WithEvents cboBusinessType As DevExpress.XtraEditors.LookUpEdit
    Private WithEvents cboIndustryType As DevExpress.XtraEditors.LookUpEdit
    Private WithEvents cboCampaign As DevExpress.XtraEditors.LookUpEdit
    Private WithEvents cboTerritory As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents NoteTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcNote1 As ucNote
    Friend WithEvents ProductTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcProductLists1 As ucProductLists
    Friend WithEvents FormChangedComponent1 As FormChangedComponent
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CustomerID As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CusName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Phone1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Fax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Email1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EMPNAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCustomerID As DevExpress.XtraEditors.SimpleButton



End Class
