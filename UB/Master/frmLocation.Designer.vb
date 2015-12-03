<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLocation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLocation))
        Me.btnRefreshEmpID = New DevExpress.XtraEditors.SimpleButton()
        Me.txtNameEng = New DevExpress.XtraEditors.TextEdit()
        Me.txtNameThai = New DevExpress.XtraEditors.TextEdit()
        Me.IDCode = New DevExpress.XtraEditors.TextEdit()
        Me.Remark = New DevExpress.XtraEditors.MemoEdit()
        Me.PrivilegeBy = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnRefreshEmpGroupID = New DevExpress.XtraEditors.SimpleButton()
        Me.EmpGroupID = New DevExpress.XtraEditors.LookUpEdit()
        Me.EmpID = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.GeneralTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.KeepTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.lblKeepError = New System.Windows.Forms.Label()
        Me.UcLocationDTL1 = New ucLocationDTL()
        Me.AddressTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcAddress1 = New ucAddress()
        Me.NoteTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcNote1 = New ucNote()
        Me.AttachmentTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcFileAttach1 = New ucFileAttach()
        Me.AdminTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcAdmin1 = New ucAdmin()
        Me.FormChangedComponent1 = New FormChangedComponent(Me.components)
        CType(Me.txtNameEng.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNameThai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Remark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrivilegeBy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpGroupID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.GeneralTabPage.SuspendLayout()
        Me.KeepTabPage.SuspendLayout()
        Me.AddressTabPage.SuspendLayout()
        Me.NoteTabPage.SuspendLayout()
        Me.AttachmentTabPage.SuspendLayout()
        Me.AdminTabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRefreshEmpID
        '
        Me.btnRefreshEmpID.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRefreshEmpID.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnRefreshEmpID, "")
        Me.btnRefreshEmpID.Image = CType(resources.GetObject("btnRefreshEmpID.Image"), System.Drawing.Image)
        Me.btnRefreshEmpID.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefreshEmpID.Location = New System.Drawing.Point(423, 120)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnRefreshEmpID, True)
        Me.btnRefreshEmpID.Name = "btnRefreshEmpID"
        Me.btnRefreshEmpID.Size = New System.Drawing.Size(21, 21)
        Me.btnRefreshEmpID.TabIndex = 186
        Me.btnRefreshEmpID.TabStop = False
        Me.btnRefreshEmpID.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnRefreshEmpID, "")
        '
        'txtNameEng
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtNameEng, "TextChanged")
        Me.txtNameEng.EditValue = ""
        Me.txtNameEng.EnterMoveNextControl = True
        Me.txtNameEng.Location = New System.Drawing.Point(148, 93)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.txtNameEng, True)
        Me.txtNameEng.Name = "txtNameEng"
        Me.txtNameEng.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtNameEng.Properties.Appearance.Options.UseFont = True
        Me.txtNameEng.Properties.MaxLength = 50
        Me.txtNameEng.Properties.ValidateOnEnterKey = True
        Me.txtNameEng.Size = New System.Drawing.Size(273, 20)
        Me.txtNameEng.TabIndex = 2
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtNameEng, "Text")
        '
        'txtNameThai
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtNameThai, "TextChanged")
        Me.txtNameThai.EditValue = ""
        Me.txtNameThai.EnterMoveNextControl = True
        Me.txtNameThai.Location = New System.Drawing.Point(148, 66)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.txtNameThai, True)
        Me.txtNameThai.Name = "txtNameThai"
        Me.txtNameThai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtNameThai.Properties.Appearance.Options.UseFont = True
        Me.txtNameThai.Properties.MaxLength = 50
        Me.txtNameThai.Properties.ValidateOnEnterKey = True
        Me.txtNameThai.Size = New System.Drawing.Size(273, 20)
        Me.txtNameThai.TabIndex = 1
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtNameThai, "Text")
        '
        'IDCode
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.IDCode, "TextChanged")
        Me.IDCode.EditValue = ""
        Me.IDCode.EnterMoveNextControl = True
        Me.IDCode.Location = New System.Drawing.Point(148, 39)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.IDCode, True)
        Me.IDCode.Name = "IDCode"
        Me.IDCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.IDCode.Properties.Appearance.Options.UseFont = True
        Me.IDCode.Properties.MaxLength = 20
        Me.IDCode.Properties.ValidateOnEnterKey = True
        Me.IDCode.Size = New System.Drawing.Size(155, 20)
        Me.IDCode.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.IDCode, "Text")
        '
        'Remark
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Remark, "TextChanged")
        Me.Remark.EditValue = ""
        Me.Remark.EnterMoveNextControl = True
        Me.Remark.Location = New System.Drawing.Point(148, 201)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Remark, True)
        Me.Remark.Name = "Remark"
        Me.Remark.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Remark.Properties.Appearance.Options.UseFont = True
        Me.Remark.Properties.MaxLength = 100
        Me.Remark.Size = New System.Drawing.Size(273, 92)
        Me.Remark.TabIndex = 6
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Remark, "Text")
        '
        'PrivilegeBy
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.PrivilegeBy, "TextChanged")
        Me.PrivilegeBy.EditValue = "ใช้ได้ทุกกลุ่มพนักงาน"
        Me.PrivilegeBy.EnterMoveNextControl = True
        Me.PrivilegeBy.Location = New System.Drawing.Point(148, 147)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.PrivilegeBy, True)
        Me.PrivilegeBy.Name = "PrivilegeBy"
        Me.PrivilegeBy.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PrivilegeBy.Properties.Appearance.Options.UseFont = True
        Me.PrivilegeBy.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PrivilegeBy.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.PrivilegeBy.Size = New System.Drawing.Size(273, 20)
        Me.PrivilegeBy.TabIndex = 4
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.PrivilegeBy, "Text")
        '
        'btnRefreshEmpGroupID
        '
        Me.btnRefreshEmpGroupID.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRefreshEmpGroupID.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnRefreshEmpGroupID, "")
        Me.btnRefreshEmpGroupID.Image = CType(resources.GetObject("btnRefreshEmpGroupID.Image"), System.Drawing.Image)
        Me.btnRefreshEmpGroupID.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefreshEmpGroupID.Location = New System.Drawing.Point(423, 174)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnRefreshEmpGroupID, True)
        Me.btnRefreshEmpGroupID.Name = "btnRefreshEmpGroupID"
        Me.btnRefreshEmpGroupID.Size = New System.Drawing.Size(21, 21)
        Me.btnRefreshEmpGroupID.TabIndex = 195
        Me.btnRefreshEmpGroupID.TabStop = False
        Me.btnRefreshEmpGroupID.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnRefreshEmpGroupID, "")
        '
        'EmpGroupID
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.EmpGroupID, "TextChanged")
        Me.EmpGroupID.EnterMoveNextControl = True
        Me.EmpGroupID.Location = New System.Drawing.Point(148, 175)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.EmpGroupID, True)
        Me.EmpGroupID.Name = "EmpGroupID"
        Me.EmpGroupID.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.EmpGroupID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpGroupID.Properties.Appearance.Options.UseFont = True
        Me.EmpGroupID.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.EmpGroupID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EmpGroupID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 50, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeThai", 50, "ชื่อข้อความ"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeEng", "", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Center), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Remark", 70, "รายละเอียด")})
        Me.EmpGroupID.Properties.DropDownRows = 10
        Me.EmpGroupID.Properties.NullText = ""
        Me.EmpGroupID.Properties.NullValuePromptShowForEmptyValue = True
        Me.EmpGroupID.Properties.PopupWidth = 300
        Me.EmpGroupID.Size = New System.Drawing.Size(273, 20)
        Me.EmpGroupID.TabIndex = 5
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.EmpGroupID, "Text")
        '
        'EmpID
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.EmpID, "TextChanged")
        Me.EmpID.EnterMoveNextControl = True
        Me.EmpID.Location = New System.Drawing.Point(148, 120)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.EmpID, True)
        Me.EmpID.Name = "EmpID"
        Me.EmpID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpID.Properties.Appearance.Options.UseFont = True
        Me.EmpID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EmpID.Properties.NullText = ""
        Me.EmpID.Properties.PopupFindMode = DevExpress.XtraEditors.FindMode.Always
        Me.EmpID.Properties.View = Me.SearchLookUpEdit1View
        Me.EmpID.Size = New System.Drawing.Size(273, 20)
        Me.EmpID.TabIndex = 3
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.EmpID, "Text")
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn5, Me.GridColumn6})
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
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
        Me.GridColumn5.FieldName = "EmpCode"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "ชื่อ - นามสกุล"
        Me.GridColumn6.FieldName = "NAME"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 1
        '
        'XtraTabControl1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.XtraTabControl1, "")
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 37)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.XtraTabControl1, True)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.GeneralTabPage
        Me.XtraTabControl1.Size = New System.Drawing.Size(858, 456)
        Me.XtraTabControl1.TabIndex = 7
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.GeneralTabPage, Me.KeepTabPage, Me.AddressTabPage, Me.NoteTabPage, Me.AttachmentTabPage, Me.AdminTabPage})
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.XtraTabControl1, "")
        '
        'GeneralTabPage
        '
        Me.GeneralTabPage.Appearance.PageClient.BackColor = System.Drawing.Color.LightGray
        Me.GeneralTabPage.Appearance.PageClient.Options.UseBackColor = True
        Me.GeneralTabPage.AutoScroll = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.GeneralTabPage, "")
        Me.GeneralTabPage.Controls.Add(Me.EmpGroupID)
        Me.GeneralTabPage.Controls.Add(Me.btnRefreshEmpGroupID)
        Me.GeneralTabPage.Controls.Add(Me.Label20)
        Me.GeneralTabPage.Controls.Add(Me.PrivilegeBy)
        Me.GeneralTabPage.Controls.Add(Me.Label16)
        Me.GeneralTabPage.Controls.Add(Me.EmpID)
        Me.GeneralTabPage.Controls.Add(Me.Label10)
        Me.GeneralTabPage.Controls.Add(Me.btnRefreshEmpID)
        Me.GeneralTabPage.Controls.Add(Me.Label1)
        Me.GeneralTabPage.Controls.Add(Me.txtNameEng)
        Me.GeneralTabPage.Controls.Add(Me.txtNameThai)
        Me.GeneralTabPage.Controls.Add(Me.IDCode)
        Me.GeneralTabPage.Controls.Add(Me.Label8)
        Me.GeneralTabPage.Controls.Add(Me.Label4)
        Me.GeneralTabPage.Controls.Add(Me.Label5)
        Me.GeneralTabPage.Controls.Add(Me.Remark)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.GeneralTabPage, True)
        Me.GeneralTabPage.Name = "GeneralTabPage"
        Me.GeneralTabPage.Size = New System.Drawing.Size(852, 428)
        Me.GeneralTabPage.Text = "ข้อมูลทั่วไป"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.GeneralTabPage, "")
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label20, "")
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label20.Location = New System.Drawing.Point(46, 178)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label20, True)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(68, 14)
        Me.Label20.TabIndex = 193
        Me.Label20.Tag = "กลุ่มพนักงาน"
        Me.Label20.Text = "กลุ่มพนักงาน"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label20, "")
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label16, "")
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(46, 150)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label16, True)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 14)
        Me.Label16.TabIndex = 191
        Me.Label16.Text = "สิทธิ์การใช้งาน"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label16, "")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label10, "")
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(46, 123)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label10, True)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 14)
        Me.Label10.TabIndex = 187
        Me.Label10.Text = "ผู้ดูแล"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label10, "")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label1, "")
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(46, 69)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label1, True)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 14)
        Me.Label1.TabIndex = 148
        Me.Label1.Text = "ชื่อคลัง"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label1, "")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label8, "")
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(46, 96)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label8, True)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 14)
        Me.Label8.TabIndex = 109
        Me.Label8.Text = "ชื่อคลัง (Eng)"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label8, "")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label4, "")
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(46, 42)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label4, True)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 14)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "รหัสคลัง"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label4, "")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label5, "")
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 204)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label5, True)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 14)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "รายละเอียด"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label5, "")
        '
        'KeepTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.KeepTabPage, "")
        Me.KeepTabPage.Controls.Add(Me.lblKeepError)
        Me.KeepTabPage.Controls.Add(Me.UcLocationDTL1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.KeepTabPage, True)
        Me.KeepTabPage.Name = "KeepTabPage"
        Me.KeepTabPage.Size = New System.Drawing.Size(852, 428)
        Me.KeepTabPage.Text = "ตำแหน่งเก็บ"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.KeepTabPage, "")
        '
        'lblKeepError
        '
        Me.lblKeepError.AutoSize = True
        Me.lblKeepError.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.lblKeepError, "")
        Me.lblKeepError.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblKeepError.ForeColor = System.Drawing.Color.Red
        Me.lblKeepError.Location = New System.Drawing.Point(5, 3)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.lblKeepError, True)
        Me.lblKeepError.Name = "lblKeepError"
        Me.lblKeepError.Size = New System.Drawing.Size(47, 14)
        Me.lblKeepError.TabIndex = 109
        Me.lblKeepError.Text = "รหัสคลัง"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.lblKeepError, "")
        '
        'UcLocationDTL1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.UcLocationDTL1, "")
        Me.UcLocationDTL1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcLocationDTL1.Location = New System.Drawing.Point(0, 0)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.UcLocationDTL1, True)
        Me.UcLocationDTL1.Name = "UcLocationDTL1"
        Me.UcLocationDTL1.Size = New System.Drawing.Size(852, 428)
        Me.UcLocationDTL1.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcLocationDTL1, "")
        '
        'AddressTabPage
        '
        Me.AddressTabPage.AutoScroll = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.AddressTabPage, "")
        Me.AddressTabPage.Controls.Add(Me.UcAddress1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.AddressTabPage, True)
        Me.AddressTabPage.Name = "AddressTabPage"
        Me.AddressTabPage.Size = New System.Drawing.Size(852, 428)
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
        Me.UcAddress1.Size = New System.Drawing.Size(852, 428)
        Me.UcAddress1.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcAddress1, "")
        '
        'NoteTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.NoteTabPage, "")
        Me.NoteTabPage.Controls.Add(Me.UcNote1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.NoteTabPage, True)
        Me.NoteTabPage.Name = "NoteTabPage"
        Me.NoteTabPage.Size = New System.Drawing.Size(852, 428)
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
        Me.UcNote1.Size = New System.Drawing.Size(852, 428)
        Me.UcNote1.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcNote1, "")
        '
        'AttachmentTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.AttachmentTabPage, "")
        Me.AttachmentTabPage.Controls.Add(Me.UcFileAttach1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.AttachmentTabPage, True)
        Me.AttachmentTabPage.Name = "AttachmentTabPage"
        Me.AttachmentTabPage.Size = New System.Drawing.Size(852, 428)
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
        Me.UcFileAttach1.Size = New System.Drawing.Size(852, 428)
        Me.UcFileAttach1.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcFileAttach1, "")
        '
        'AdminTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.AdminTabPage, "")
        Me.AdminTabPage.Controls.Add(Me.UcAdmin1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.AdminTabPage, True)
        Me.AdminTabPage.Name = "AdminTabPage"
        Me.AdminTabPage.Size = New System.Drawing.Size(852, 428)
        Me.AdminTabPage.Text = "ผู้บันทึก"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.AdminTabPage, "")
        '
        'UcAdmin1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.UcAdmin1, "")
        Me.UcAdmin1.Location = New System.Drawing.Point(40, 3)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.UcAdmin1, True)
        Me.UcAdmin1.Name = "UcAdmin1"
        Me.UcAdmin1.Size = New System.Drawing.Size(665, 223)
        Me.UcAdmin1.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcAdmin1, "")
        '
        'FormChangedComponent1
        '
        '
        'frmLocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 493)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frmLocation"
        Me.Text = "frmLocation"
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.txtNameEng.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNameThai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Remark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrivilegeBy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpGroupID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.GeneralTabPage.ResumeLayout(False)
        Me.GeneralTabPage.PerformLayout()
        Me.KeepTabPage.ResumeLayout(False)
        Me.KeepTabPage.PerformLayout()
        Me.AddressTabPage.ResumeLayout(False)
        Me.NoteTabPage.ResumeLayout(False)
        Me.AttachmentTabPage.ResumeLayout(False)
        Me.AdminTabPage.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents GeneralTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents EmpID As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnRefreshEmpID As DevExpress.XtraEditors.SimpleButton
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNameEng As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNameThai As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IDCode As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Remark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents NoteTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcNote1 As ucNote
    Friend WithEvents AttachmentTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcFileAttach1 As ucFileAttach
    Friend WithEvents AdminTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcAdmin1 As ucAdmin
    Friend WithEvents AddressTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcAddress1 As ucAddress
    Friend WithEvents PrivilegeBy As DevExpress.XtraEditors.ComboBoxEdit
    Private WithEvents Label16 As System.Windows.Forms.Label
    Private WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btnRefreshEmpGroupID As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents KeepTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcLocationDTL1 As ucLocationDTL
    Private WithEvents lblKeepError As System.Windows.Forms.Label
    Private WithEvents EmpGroupID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents FormChangedComponent1 As FormChangedComponent

   
End Class
