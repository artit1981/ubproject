<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployee))
        Me.PositionID = New DevExpress.XtraEditors.LookUpEdit()
        Me.WorkingStatus = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtDepartment = New DevExpress.XtraEditors.TextEdit()
        Me.StartDate = New DevExpress.XtraEditors.DateEdit()
        Me.LastName = New DevExpress.XtraEditors.TextEdit()
        Me.btnRefreshPosition = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRefreshTerritory = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRefreshPrefix = New DevExpress.XtraEditors.SimpleButton()
        Me.Firstname = New DevExpress.XtraEditors.TextEdit()
        Me.Title = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.EmpCode = New DevExpress.XtraEditors.TextEdit()
        Me.Remark = New DevExpress.XtraEditors.MemoEdit()
        Me.LastNameEng = New DevExpress.XtraEditors.TextEdit()
        Me.btnRefreshPrefixEng = New DevExpress.XtraEditors.SimpleButton()
        Me.FirstnameEng = New DevExpress.XtraEditors.TextEdit()
        Me.TitleEng = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.NickName = New DevExpress.XtraEditors.TextEdit()
        Me.TerritoryID = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtDepartmenOwoner = New DevExpress.XtraEditors.TextEdit()
        Me.cboEmpGroup = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnRefreshEmpG = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.GeneralTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.CommissionID = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnRefreshCommissionID = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupPrivilege = New DevExpress.XtraEditors.GroupControl()
        Me.ViewLevel = New DevExpress.XtraEditors.RadioGroup()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Commission = New DevExpress.XtraEditors.CalcEdit()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnGenID = New DevExpress.XtraEditors.SimpleButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SWOTTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcHistory1 = New UB.ucHistory()
        Me.AddressTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcAddress1 = New UB.ucAddress()
        Me.NoteTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcNote1 = New UB.ucNote()
        Me.AttachmentTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcFileAttach1 = New UB.ucFileAttach()
        Me.AdminTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcAdmin1 = New UB.ucAdmin()
        Me.FormChangedComponent1 = New UB.FormChangedComponent(Me.components)
        CType(Me.PositionID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkingStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDepartment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LastName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Firstname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Title.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Remark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LastNameEng.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FirstnameEng.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitleEng.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NickName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TerritoryID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDepartmenOwoner.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEmpGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.GeneralTabPage.SuspendLayout()
        CType(Me.CommissionID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupPrivilege, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPrivilege.SuspendLayout()
        CType(Me.ViewLevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Commission.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SWOTTabPage.SuspendLayout()
        Me.AddressTabPage.SuspendLayout()
        Me.NoteTabPage.SuspendLayout()
        Me.AttachmentTabPage.SuspendLayout()
        Me.AdminTabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'PositionID
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.PositionID, "TextChanged")
        Me.PositionID.EditValue = ""
        Me.PositionID.Location = New System.Drawing.Point(144, 297)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.PositionID, True)
        Me.PositionID.Name = "PositionID"
        Me.PositionID.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.PositionID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PositionID.Properties.Appearance.Options.UseFont = True
        Me.PositionID.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.PositionID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PositionID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 50, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDCode", "รหัสตำแหน่ง", 10, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NameThai", "ตำแหน่ง", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.PositionID.Properties.DropDownRows = 10
        Me.PositionID.Properties.NullText = ""
        Me.PositionID.Properties.PopupWidth = 300
        Me.PositionID.Size = New System.Drawing.Size(189, 20)
        Me.PositionID.TabIndex = 12
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.PositionID, "Text")
        '
        'WorkingStatus
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.WorkingStatus, "TextChanged")
        Me.WorkingStatus.EnterMoveNextControl = True
        Me.WorkingStatus.Location = New System.Drawing.Point(144, 270)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.WorkingStatus, True)
        Me.WorkingStatus.Name = "WorkingStatus"
        Me.WorkingStatus.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.WorkingStatus.Properties.Appearance.Options.UseFont = True
        Me.WorkingStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.WorkingStatus.Size = New System.Drawing.Size(189, 20)
        Me.WorkingStatus.TabIndex = 11
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.WorkingStatus, "Text")
        '
        'txtDepartment
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtDepartment, "TextChanged")
        Me.txtDepartment.EditValue = ""
        Me.txtDepartment.EnterMoveNextControl = True
        Me.txtDepartment.Location = New System.Drawing.Point(474, 297)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.txtDepartment, True)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.txtDepartment.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDepartment.Properties.Appearance.Options.UseBackColor = True
        Me.txtDepartment.Properties.Appearance.Options.UseFont = True
        Me.txtDepartment.Properties.MaxLength = 50
        Me.txtDepartment.Properties.ReadOnly = True
        Me.txtDepartment.Properties.ValidateOnEnterKey = True
        Me.txtDepartment.Size = New System.Drawing.Size(189, 20)
        Me.txtDepartment.TabIndex = 163
        Me.txtDepartment.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtDepartment, "Text")
        '
        'StartDate
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.StartDate, "TextChanged")
        Me.StartDate.EditValue = New Date(2012, 4, 20, 0, 0, 0, 0)
        Me.StartDate.EnterMoveNextControl = True
        Me.StartDate.Location = New System.Drawing.Point(144, 243)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.StartDate, True)
        Me.StartDate.Name = "StartDate"
        Me.StartDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.StartDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.StartDate.Properties.Appearance.Options.UseFont = True
        Me.StartDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StartDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.StartDate.Properties.DisplayFormat.FormatString = "D"
        Me.StartDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.StartDate.Properties.EditFormat.FormatString = "D"
        Me.StartDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.StartDate.Properties.Mask.EditMask = "D"
        Me.StartDate.Size = New System.Drawing.Size(189, 20)
        Me.StartDate.TabIndex = 9
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.StartDate, "Text")
        '
        'LastName
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.LastName, "TextChanged")
        Me.LastName.EditValue = ""
        Me.LastName.EnterMoveNextControl = True
        Me.LastName.Location = New System.Drawing.Point(474, 75)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.LastName, True)
        Me.LastName.Name = "LastName"
        Me.LastName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LastName.Properties.Appearance.Options.UseFont = True
        Me.LastName.Properties.MaxLength = 50
        Me.LastName.Properties.ValidateOnEnterKey = True
        Me.LastName.Size = New System.Drawing.Size(189, 20)
        Me.LastName.TabIndex = 3
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.LastName, "Text")
        '
        'btnRefreshPosition
        '
        Me.btnRefreshPosition.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRefreshPosition.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnRefreshPosition, "")
        Me.btnRefreshPosition.ImageOptions.Image = CType(resources.GetObject("btnRefreshPosition.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRefreshPosition.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefreshPosition.Location = New System.Drawing.Point(335, 297)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnRefreshPosition, True)
        Me.btnRefreshPosition.Name = "btnRefreshPosition"
        Me.btnRefreshPosition.Size = New System.Drawing.Size(21, 21)
        Me.btnRefreshPosition.TabIndex = 135
        Me.btnRefreshPosition.TabStop = False
        Me.btnRefreshPosition.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnRefreshPosition, "")
        '
        'btnRefreshTerritory
        '
        Me.btnRefreshTerritory.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRefreshTerritory.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnRefreshTerritory, "")
        Me.btnRefreshTerritory.ImageOptions.Image = CType(resources.GetObject("btnRefreshTerritory.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRefreshTerritory.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefreshTerritory.Location = New System.Drawing.Point(630, 68)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnRefreshTerritory, True)
        Me.btnRefreshTerritory.Name = "btnRefreshTerritory"
        Me.btnRefreshTerritory.Size = New System.Drawing.Size(21, 21)
        Me.btnRefreshTerritory.TabIndex = 131
        Me.btnRefreshTerritory.TabStop = False
        Me.btnRefreshTerritory.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnRefreshTerritory, "")
        '
        'btnRefreshPrefix
        '
        Me.btnRefreshPrefix.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRefreshPrefix.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnRefreshPrefix, "")
        Me.btnRefreshPrefix.ImageOptions.Image = CType(resources.GetObject("btnRefreshPrefix.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRefreshPrefix.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefreshPrefix.Location = New System.Drawing.Point(237, 75)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnRefreshPrefix, True)
        Me.btnRefreshPrefix.Name = "btnRefreshPrefix"
        Me.btnRefreshPrefix.Size = New System.Drawing.Size(21, 21)
        Me.btnRefreshPrefix.TabIndex = 129
        Me.btnRefreshPrefix.TabStop = False
        Me.btnRefreshPrefix.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnRefreshPrefix, "")
        '
        'Firstname
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Firstname, "TextChanged")
        Me.Firstname.EditValue = ""
        Me.Firstname.EnterMoveNextControl = True
        Me.Firstname.Location = New System.Drawing.Point(260, 75)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Firstname, True)
        Me.Firstname.Name = "Firstname"
        Me.Firstname.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Firstname.Properties.Appearance.Options.UseFont = True
        Me.Firstname.Properties.MaxLength = 50
        Me.Firstname.Properties.ValidateOnEnterKey = True
        Me.Firstname.Size = New System.Drawing.Size(189, 20)
        Me.Firstname.TabIndex = 2
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Firstname, "Text")
        '
        'Title
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Title, "TextChanged")
        Me.Title.EnterMoveNextControl = True
        Me.Title.Location = New System.Drawing.Point(144, 75)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Title, True)
        Me.Title.Name = "Title"
        Me.Title.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Title.Properties.Appearance.Options.UseFont = True
        Me.Title.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Title.Size = New System.Drawing.Size(93, 20)
        Me.Title.TabIndex = 1
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Title, "Text")
        '
        'EmpCode
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.EmpCode, "TextChanged")
        Me.EmpCode.EditValue = ""
        Me.EmpCode.EnterMoveNextControl = True
        Me.EmpCode.Location = New System.Drawing.Point(144, 48)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.EmpCode, True)
        Me.EmpCode.Name = "EmpCode"
        Me.EmpCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.EmpCode.Properties.Appearance.Options.UseFont = True
        Me.EmpCode.Properties.MaxLength = 100
        Me.EmpCode.Properties.ValidateOnEnterKey = True
        Me.EmpCode.Size = New System.Drawing.Size(280, 20)
        Me.EmpCode.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.EmpCode, "Text")
        '
        'Remark
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Remark, "TextChanged")
        Me.Remark.EditValue = ""
        Me.Remark.EnterMoveNextControl = True
        Me.Remark.Location = New System.Drawing.Point(144, 156)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Remark, True)
        Me.Remark.Name = "Remark"
        Me.Remark.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Remark.Properties.Appearance.Options.UseFont = True
        Me.Remark.Properties.MaxLength = 100
        Me.Remark.Size = New System.Drawing.Size(519, 54)
        Me.Remark.TabIndex = 8
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Remark, "Text")
        '
        'LastNameEng
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.LastNameEng, "TextChanged")
        Me.LastNameEng.EditValue = ""
        Me.LastNameEng.EnterMoveNextControl = True
        Me.LastNameEng.Location = New System.Drawing.Point(474, 102)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.LastNameEng, True)
        Me.LastNameEng.Name = "LastNameEng"
        Me.LastNameEng.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LastNameEng.Properties.Appearance.Options.UseFont = True
        Me.LastNameEng.Properties.MaxLength = 50
        Me.LastNameEng.Properties.ValidateOnEnterKey = True
        Me.LastNameEng.Size = New System.Drawing.Size(189, 20)
        Me.LastNameEng.TabIndex = 6
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.LastNameEng, "Text")
        '
        'btnRefreshPrefixEng
        '
        Me.btnRefreshPrefixEng.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRefreshPrefixEng.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnRefreshPrefixEng, "")
        Me.btnRefreshPrefixEng.ImageOptions.Image = CType(resources.GetObject("btnRefreshPrefixEng.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRefreshPrefixEng.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefreshPrefixEng.Location = New System.Drawing.Point(237, 102)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnRefreshPrefixEng, True)
        Me.btnRefreshPrefixEng.Name = "btnRefreshPrefixEng"
        Me.btnRefreshPrefixEng.Size = New System.Drawing.Size(21, 21)
        Me.btnRefreshPrefixEng.TabIndex = 191
        Me.btnRefreshPrefixEng.TabStop = False
        Me.btnRefreshPrefixEng.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnRefreshPrefixEng, "")
        '
        'FirstnameEng
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.FirstnameEng, "TextChanged")
        Me.FirstnameEng.EditValue = ""
        Me.FirstnameEng.EnterMoveNextControl = True
        Me.FirstnameEng.Location = New System.Drawing.Point(260, 102)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.FirstnameEng, True)
        Me.FirstnameEng.Name = "FirstnameEng"
        Me.FirstnameEng.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FirstnameEng.Properties.Appearance.Options.UseFont = True
        Me.FirstnameEng.Properties.MaxLength = 50
        Me.FirstnameEng.Properties.ValidateOnEnterKey = True
        Me.FirstnameEng.Size = New System.Drawing.Size(189, 20)
        Me.FirstnameEng.TabIndex = 5
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.FirstnameEng, "Text")
        '
        'TitleEng
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.TitleEng, "TextChanged")
        Me.TitleEng.EnterMoveNextControl = True
        Me.TitleEng.Location = New System.Drawing.Point(144, 102)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.TitleEng, True)
        Me.TitleEng.Name = "TitleEng"
        Me.TitleEng.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TitleEng.Properties.Appearance.Options.UseFont = True
        Me.TitleEng.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TitleEng.Size = New System.Drawing.Size(93, 20)
        Me.TitleEng.TabIndex = 4
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.TitleEng, "Text")
        '
        'NickName
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.NickName, "TextChanged")
        Me.NickName.EditValue = ""
        Me.NickName.EnterMoveNextControl = True
        Me.NickName.Location = New System.Drawing.Point(144, 129)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.NickName, True)
        Me.NickName.Name = "NickName"
        Me.NickName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.NickName.Properties.Appearance.Options.UseFont = True
        Me.NickName.Properties.MaxLength = 50
        Me.NickName.Properties.ValidateOnEnterKey = True
        Me.NickName.Size = New System.Drawing.Size(305, 20)
        Me.NickName.TabIndex = 7
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.NickName, "Text")
        '
        'TerritoryID
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.TerritoryID, "TextChanged")
        Me.TerritoryID.EditValue = ""
        Me.TerritoryID.Location = New System.Drawing.Point(439, 68)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.TerritoryID, True)
        Me.TerritoryID.Name = "TerritoryID"
        Me.TerritoryID.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.TerritoryID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TerritoryID.Properties.Appearance.Options.UseFont = True
        Me.TerritoryID.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.TerritoryID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TerritoryID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 50, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TerritoryCode", "รหัสทีมขาย", 30, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NameThai", "ชื่อทีมขาย", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.TerritoryID.Properties.DropDownRows = 10
        Me.TerritoryID.Properties.NullText = ""
        Me.TerritoryID.Properties.PopupWidth = 300
        Me.TerritoryID.Size = New System.Drawing.Size(189, 20)
        Me.TerritoryID.TabIndex = 12
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.TerritoryID, "Text")
        '
        'txtDepartmenOwoner
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtDepartmenOwoner, "TextChanged")
        Me.txtDepartmenOwoner.EditValue = ""
        Me.txtDepartmenOwoner.EnterMoveNextControl = True
        Me.txtDepartmenOwoner.Location = New System.Drawing.Point(439, 29)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.txtDepartmenOwoner, True)
        Me.txtDepartmenOwoner.Name = "txtDepartmenOwoner"
        Me.txtDepartmenOwoner.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.txtDepartmenOwoner.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDepartmenOwoner.Properties.Appearance.Options.UseBackColor = True
        Me.txtDepartmenOwoner.Properties.Appearance.Options.UseFont = True
        Me.txtDepartmenOwoner.Properties.MaxLength = 100
        Me.txtDepartmenOwoner.Properties.ReadOnly = True
        Me.txtDepartmenOwoner.Properties.ValidateOnEnterKey = True
        Me.txtDepartmenOwoner.Size = New System.Drawing.Size(189, 20)
        Me.txtDepartmenOwoner.TabIndex = 198
        Me.txtDepartmenOwoner.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtDepartmenOwoner, "Text")
        '
        'cboEmpGroup
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.cboEmpGroup, "TextChanged")
        Me.cboEmpGroup.Location = New System.Drawing.Point(109, 29)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.cboEmpGroup, True)
        Me.cboEmpGroup.Name = "cboEmpGroup"
        Me.cboEmpGroup.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboEmpGroup.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEmpGroup.Properties.Appearance.Options.UseFont = True
        Me.cboEmpGroup.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboEmpGroup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboEmpGroup.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 50, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeThai", "ชื่อข้อความ", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeEng", "", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Remark", "รายละเอียด", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboEmpGroup.Properties.DropDownRows = 10
        Me.cboEmpGroup.Properties.NullText = ""
        Me.cboEmpGroup.Properties.PopupWidth = 300
        Me.cboEmpGroup.Size = New System.Drawing.Size(189, 20)
        Me.cboEmpGroup.TabIndex = 13
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.cboEmpGroup, "Text")
        '
        'btnRefreshEmpG
        '
        Me.btnRefreshEmpG.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRefreshEmpG.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnRefreshEmpG, "")
        Me.btnRefreshEmpG.ImageOptions.Image = CType(resources.GetObject("btnRefreshEmpG.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRefreshEmpG.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefreshEmpG.Location = New System.Drawing.Point(300, 30)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnRefreshEmpG, True)
        Me.btnRefreshEmpG.Name = "btnRefreshEmpG"
        Me.btnRefreshEmpG.Size = New System.Drawing.Size(21, 21)
        Me.btnRefreshEmpG.TabIndex = 204
        Me.btnRefreshEmpG.TabStop = False
        Me.btnRefreshEmpG.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnRefreshEmpG, "")
        '
        'XtraTabControl1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.XtraTabControl1, "")
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 30)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.XtraTabControl1, True)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.GeneralTabPage
        Me.XtraTabControl1.Size = New System.Drawing.Size(809, 547)
        Me.XtraTabControl1.TabIndex = 5
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.GeneralTabPage, Me.SWOTTabPage, Me.AddressTabPage, Me.NoteTabPage, Me.AttachmentTabPage, Me.AdminTabPage})
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.XtraTabControl1, "")
        '
        'GeneralTabPage
        '
        Me.GeneralTabPage.Appearance.PageClient.BackColor = System.Drawing.Color.LightGray
        Me.GeneralTabPage.Appearance.PageClient.Options.UseBackColor = True
        Me.GeneralTabPage.AutoScroll = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.GeneralTabPage, "")
        Me.GeneralTabPage.Controls.Add(Me.CommissionID)
        Me.GeneralTabPage.Controls.Add(Me.btnRefreshCommissionID)
        Me.GeneralTabPage.Controls.Add(Me.GroupPrivilege)
        Me.GeneralTabPage.Controls.Add(Me.Commission)
        Me.GeneralTabPage.Controls.Add(Me.Label17)
        Me.GeneralTabPage.Controls.Add(Me.btnGenID)
        Me.GeneralTabPage.Controls.Add(Me.Label7)
        Me.GeneralTabPage.Controls.Add(Me.Label3)
        Me.GeneralTabPage.Controls.Add(Me.NickName)
        Me.GeneralTabPage.Controls.Add(Me.LastNameEng)
        Me.GeneralTabPage.Controls.Add(Me.btnRefreshPrefixEng)
        Me.GeneralTabPage.Controls.Add(Me.FirstnameEng)
        Me.GeneralTabPage.Controls.Add(Me.TitleEng)
        Me.GeneralTabPage.Controls.Add(Me.Label1)
        Me.GeneralTabPage.Controls.Add(Me.PositionID)
        Me.GeneralTabPage.Controls.Add(Me.WorkingStatus)
        Me.GeneralTabPage.Controls.Add(Me.txtDepartment)
        Me.GeneralTabPage.Controls.Add(Me.StartDate)
        Me.GeneralTabPage.Controls.Add(Me.LastName)
        Me.GeneralTabPage.Controls.Add(Me.Label22)
        Me.GeneralTabPage.Controls.Add(Me.Label10)
        Me.GeneralTabPage.Controls.Add(Me.btnRefreshPosition)
        Me.GeneralTabPage.Controls.Add(Me.btnRefreshPrefix)
        Me.GeneralTabPage.Controls.Add(Me.Firstname)
        Me.GeneralTabPage.Controls.Add(Me.Title)
        Me.GeneralTabPage.Controls.Add(Me.EmpCode)
        Me.GeneralTabPage.Controls.Add(Me.Label29)
        Me.GeneralTabPage.Controls.Add(Me.Label28)
        Me.GeneralTabPage.Controls.Add(Me.Label19)
        Me.GeneralTabPage.Controls.Add(Me.Label18)
        Me.GeneralTabPage.Controls.Add(Me.Label12)
        Me.GeneralTabPage.Controls.Add(Me.Label8)
        Me.GeneralTabPage.Controls.Add(Me.Label4)
        Me.GeneralTabPage.Controls.Add(Me.Label6)
        Me.GeneralTabPage.Controls.Add(Me.Remark)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.GeneralTabPage, True)
        Me.GeneralTabPage.Name = "GeneralTabPage"
        Me.GeneralTabPage.Size = New System.Drawing.Size(807, 522)
        Me.GeneralTabPage.Text = "ข้อมูลทั่วไป"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.GeneralTabPage, "")
        '
        'CommissionID
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.CommissionID, "TextChanged")
        Me.CommissionID.EditValue = ""
        Me.CommissionID.Location = New System.Drawing.Point(474, 243)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.CommissionID, True)
        Me.CommissionID.Name = "CommissionID"
        Me.CommissionID.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.CommissionID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommissionID.Properties.Appearance.Options.UseFont = True
        Me.CommissionID.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.CommissionID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CommissionID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CommissionID", "CommissionID", 50, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Subject", "คอมมิชชัน", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.CommissionID.Properties.DropDownRows = 10
        Me.CommissionID.Properties.NullText = ""
        Me.CommissionID.Properties.PopupWidth = 300
        Me.CommissionID.Size = New System.Drawing.Size(189, 20)
        Me.CommissionID.TabIndex = 10
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.CommissionID, "Text")
        '
        'btnRefreshCommissionID
        '
        Me.btnRefreshCommissionID.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRefreshCommissionID.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnRefreshCommissionID, "")
        Me.btnRefreshCommissionID.ImageOptions.Image = CType(resources.GetObject("btnRefreshCommissionID.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRefreshCommissionID.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefreshCommissionID.Location = New System.Drawing.Point(665, 243)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnRefreshCommissionID, True)
        Me.btnRefreshCommissionID.Name = "btnRefreshCommissionID"
        Me.btnRefreshCommissionID.Size = New System.Drawing.Size(21, 21)
        Me.btnRefreshCommissionID.TabIndex = 11
        Me.btnRefreshCommissionID.TabStop = False
        Me.btnRefreshCommissionID.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnRefreshCommissionID, "")
        '
        'GroupPrivilege
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.GroupPrivilege, "")
        Me.GroupPrivilege.Controls.Add(Me.ViewLevel)
        Me.GroupPrivilege.Controls.Add(Me.Label9)
        Me.GroupPrivilege.Controls.Add(Me.TerritoryID)
        Me.GroupPrivilege.Controls.Add(Me.Label20)
        Me.GroupPrivilege.Controls.Add(Me.btnRefreshEmpG)
        Me.GroupPrivilege.Controls.Add(Me.btnRefreshTerritory)
        Me.GroupPrivilege.Controls.Add(Me.cboEmpGroup)
        Me.GroupPrivilege.Controls.Add(Me.Label2)
        Me.GroupPrivilege.Controls.Add(Me.txtDepartmenOwoner)
        Me.GroupPrivilege.Controls.Add(Me.Label5)
        Me.GroupPrivilege.Location = New System.Drawing.Point(35, 324)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.GroupPrivilege, True)
        Me.GroupPrivilege.Name = "GroupPrivilege"
        Me.GroupPrivilege.Size = New System.Drawing.Size(668, 136)
        Me.GroupPrivilege.TabIndex = 219
        Me.GroupPrivilege.Text = "กำหนดสิทธ์ได้ที่ กำหนดทีมขาย/ผู้รับผิดชอบ"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.GroupPrivilege, "")
        '
        'ViewLevel
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.ViewLevel, "")
        Me.ViewLevel.EditValue = CType(1, Short)
        Me.ViewLevel.Location = New System.Drawing.Point(109, 54)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.ViewLevel, True)
        Me.ViewLevel.Name = "ViewLevel"
        Me.ViewLevel.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(1, Short), "เฉพาะลูกค้าที่ดูแล"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(2, Short), "ตามทีมขาย"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(3, Short), "ทั้งหมด")})
        Me.ViewLevel.Size = New System.Drawing.Size(189, 71)
        Me.ViewLevel.TabIndex = 14
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.ViewLevel, "")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label9, "")
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(9, 70)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label9, True)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 14)
        Me.Label9.TabIndex = 214
        Me.Label9.Text = "สิทธิในลูกค้า"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label9, "")
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label20, "")
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label20.Location = New System.Drawing.Point(360, 73)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label20, True)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(43, 14)
        Me.Label20.TabIndex = 116
        Me.Label20.Text = "ทีมขาย"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label20, "")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label2, "")
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(9, 32)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label2, True)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 14)
        Me.Label2.TabIndex = 201
        Me.Label2.Text = "กลุ่มพนักงาน"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label2, "")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label5, "")
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(360, 32)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label5, True)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 14)
        Me.Label5.TabIndex = 199
        Me.Label5.Text = "หัวหน้าเขต"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label5, "")
        '
        'Commission
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Commission, "TextChanged")
        Me.Commission.EnterMoveNextControl = True
        Me.Commission.Location = New System.Drawing.Point(464, 3)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Commission, True)
        Me.Commission.Name = "Commission"
        Me.Commission.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Commission.Properties.Appearance.Options.UseFont = True
        Me.Commission.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Commission.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Commission.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Commission.Properties.Mask.EditMask = "n2"
        Me.Commission.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Commission.Properties.Precision = 2
        Me.Commission.Size = New System.Drawing.Size(189, 20)
        Me.Commission.TabIndex = 10
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Commission, "Text")
        Me.Commission.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label17, "")
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.Location = New System.Drawing.Point(393, 246)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label17, True)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 14)
        Me.Label17.TabIndex = 218
        Me.Label17.Text = "คอมมิชชัน"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label17, "")
        '
        'btnGenID
        '
        Me.btnGenID.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnGenID.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnGenID, "")
        Me.btnGenID.ImageOptions.Image = CType(resources.GetObject("btnGenID.ImageOptions.Image"), System.Drawing.Image)
        Me.btnGenID.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnGenID.Location = New System.Drawing.Point(428, 48)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnGenID, True)
        Me.btnGenID.Name = "btnGenID"
        Me.btnGenID.Size = New System.Drawing.Size(21, 21)
        Me.btnGenID.TabIndex = 211
        Me.btnGenID.TabStop = False
        Me.btnGenID.ToolTip = "Auto ID"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnGenID, "")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label7, "")
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(42, 160)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label7, True)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 14)
        Me.Label7.TabIndex = 200
        Me.Label7.Text = "รายละเอียด"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label7, "")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label3, "")
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(393, 300)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label3, True)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 14)
        Me.Label3.TabIndex = 196
        Me.Label3.Text = "แผนก"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label3, "")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label1, "")
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 105)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label1, True)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 14)
        Me.Label1.TabIndex = 188
        Me.Label1.Text = "ชื่อ (Eng)"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label1, "")
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label22, "")
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label22.Location = New System.Drawing.Point(42, 246)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label22, True)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(55, 14)
        Me.Label22.TabIndex = 142
        Me.Label22.Text = "วันเริ่มงาน"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label22, "")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label10, "")
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(42, 300)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label10, True)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 14)
        Me.Label10.TabIndex = 138
        Me.Label10.Text = "ตำแหน่งงาน"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label10, "")
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label29, "")
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.DarkGray
        Me.Label29.Location = New System.Drawing.Point(122, 217)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label29, True)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(581, 14)
        Me.Label29.TabIndex = 121
        Me.Label29.Text = "_________________________________________________________________________________" &
    "_"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label29, "")
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label28, "")
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.DarkGray
        Me.Label28.Location = New System.Drawing.Point(104, 22)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label28, True)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(623, 14)
        Me.Label28.TabIndex = 120
        Me.Label28.Text = "_________________________________________________________________________________" &
    "_______"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label28, "")
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label19, "")
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label19.Location = New System.Drawing.Point(34, 220)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label19, True)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(87, 14)
        Me.Label19.TabIndex = 115
        Me.Label19.Text = "ข้อมูลการทำงาน"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label19, "")
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label18, "")
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label18.Location = New System.Drawing.Point(34, 26)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label18, True)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 14)
        Me.Label18.TabIndex = 114
        Me.Label18.Text = "ข้อมูลทั่วไป"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label18, "")
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label12, "")
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(42, 132)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label12, True)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 14)
        Me.Label12.TabIndex = 111
        Me.Label12.Text = "ชื่อเล่น"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label12, "")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label8, "")
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(42, 78)
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
        Me.Label4.Location = New System.Drawing.Point(42, 51)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label4, True)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 14)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "รหัสพนักงาน"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label4, "")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label6, "")
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(42, 273)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label6, True)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 14)
        Me.Label6.TabIndex = 106
        Me.Label6.Text = "สถานะการทำงาน"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label6, "")
        '
        'SWOTTabPage
        '
        Me.SWOTTabPage.AutoScroll = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.SWOTTabPage, "")
        Me.SWOTTabPage.Controls.Add(Me.UcHistory1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.SWOTTabPage, True)
        Me.SWOTTabPage.Name = "SWOTTabPage"
        Me.SWOTTabPage.Size = New System.Drawing.Size(807, 522)
        Me.SWOTTabPage.Text = "ข้อมูลส่วนตัว"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.SWOTTabPage, "")
        '
        'UcHistory1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.UcHistory1, "")
        Me.UcHistory1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcHistory1.Location = New System.Drawing.Point(0, 0)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.UcHistory1, True)
        Me.UcHistory1.Name = "UcHistory1"
        Me.UcHistory1.Size = New System.Drawing.Size(807, 522)
        Me.UcHistory1.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcHistory1, "")
        '
        'AddressTabPage
        '
        Me.AddressTabPage.AutoScroll = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.AddressTabPage, "")
        Me.AddressTabPage.Controls.Add(Me.UcAddress1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.AddressTabPage, True)
        Me.AddressTabPage.Name = "AddressTabPage"
        Me.AddressTabPage.Size = New System.Drawing.Size(807, 522)
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
        Me.UcAddress1.Size = New System.Drawing.Size(807, 522)
        Me.UcAddress1.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcAddress1, "")
        '
        'NoteTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.NoteTabPage, "")
        Me.NoteTabPage.Controls.Add(Me.UcNote1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.NoteTabPage, True)
        Me.NoteTabPage.Name = "NoteTabPage"
        Me.NoteTabPage.Size = New System.Drawing.Size(807, 522)
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
        Me.UcNote1.Size = New System.Drawing.Size(807, 522)
        Me.UcNote1.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcNote1, "")
        '
        'AttachmentTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.AttachmentTabPage, "")
        Me.AttachmentTabPage.Controls.Add(Me.UcFileAttach1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.AttachmentTabPage, True)
        Me.AttachmentTabPage.Name = "AttachmentTabPage"
        Me.AttachmentTabPage.Size = New System.Drawing.Size(807, 522)
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
        Me.UcFileAttach1.Size = New System.Drawing.Size(807, 522)
        Me.UcFileAttach1.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcFileAttach1, "")
        '
        'AdminTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.AdminTabPage, "")
        Me.AdminTabPage.Controls.Add(Me.UcAdmin1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.AdminTabPage, True)
        Me.AdminTabPage.Name = "AdminTabPage"
        Me.AdminTabPage.Size = New System.Drawing.Size(807, 522)
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
        'frmEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 577)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frmEmployee"
        Me.Text = "frmEmployee"
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.PositionID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkingStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDepartment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LastName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Firstname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Title.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Remark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LastNameEng.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FirstnameEng.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitleEng.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NickName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TerritoryID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDepartmenOwoner.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEmpGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.GeneralTabPage.ResumeLayout(False)
        Me.GeneralTabPage.PerformLayout()
        CType(Me.CommissionID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupPrivilege, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPrivilege.ResumeLayout(False)
        Me.GroupPrivilege.PerformLayout()
        CType(Me.ViewLevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Commission.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SWOTTabPage.ResumeLayout(False)
        Me.AddressTabPage.ResumeLayout(False)
        Me.NoteTabPage.ResumeLayout(False)
        Me.AttachmentTabPage.ResumeLayout(False)
        Me.AdminTabPage.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents GeneralTabPage As DevExpress.XtraTab.XtraTabPage
    Private WithEvents PositionID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents WorkingStatus As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtDepartment As DevExpress.XtraEditors.TextEdit
    Friend WithEvents StartDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LastName As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label22 As System.Windows.Forms.Label
    Private WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnRefreshPosition As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRefreshTerritory As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRefreshPrefix As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Firstname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Title As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents EmpCode As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label29 As System.Windows.Forms.Label
    Private WithEvents Label28 As System.Windows.Forms.Label
    Private WithEvents Label20 As System.Windows.Forms.Label
    Private WithEvents Label19 As System.Windows.Forms.Label
    Private WithEvents Label18 As System.Windows.Forms.Label
    Private WithEvents Label12 As System.Windows.Forms.Label
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Remark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents AddressTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcAddress1 As ucAddress
    Friend WithEvents SWOTTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents NoteTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcNote1 As ucNote
    Friend WithEvents AttachmentTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcFileAttach1 As ucFileAttach
    Friend WithEvents AdminTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcAdmin1 As ucAdmin
    Friend WithEvents LastNameEng As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnRefreshPrefixEng As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents FirstnameEng As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TitleEng As DevExpress.XtraEditors.ComboBoxEdit
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NickName As DevExpress.XtraEditors.TextEdit
    Private WithEvents TerritoryID As DevExpress.XtraEditors.LookUpEdit
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDepartmenOwoner As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents UcHistory1 As ucHistory
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents cboEmpGroup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnRefreshEmpG As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents FormChangedComponent1 As FormChangedComponent

    Friend WithEvents btnGenID As DevExpress.XtraEditors.SimpleButton
    Private WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ViewLevel As DevExpress.XtraEditors.RadioGroup
    Private WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupPrivilege As DevExpress.XtraEditors.GroupControl
    Private WithEvents CommissionID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnRefreshCommissionID As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Commission As DevExpress.XtraEditors.CalcEdit
End Class
