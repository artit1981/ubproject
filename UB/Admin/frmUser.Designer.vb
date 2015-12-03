<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUser))
        Me.EmpployeeName = New DevExpress.XtraEditors.TextEdit()
        Me.Password_Confirm = New DevExpress.XtraEditors.TextEdit()
        Me.PrivilegeID = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnRefreshPrivilege = New DevExpress.XtraEditors.SimpleButton()
        Me.Password = New DevExpress.XtraEditors.TextEdit()
        Me.UserName = New DevExpress.XtraEditors.TextEdit()
        Me.Remark = New DevExpress.XtraEditors.MemoEdit()
        Me.btnRefreshEmp = New DevExpress.XtraEditors.SimpleButton()
        Me.CheckInAcive = New DevExpress.XtraEditors.CheckEdit()
        Me.EmpID = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.GeneralTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NoteTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcNote1 = New ucNote()
        Me.AttachmentTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcFileAttach1 = New ucFileAttach()
        Me.FormChangedComponent1 = New FormChangedComponent(Me.components)

        CType(Me.EmpployeeName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Password_Confirm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrivilegeID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Password.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Remark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckInAcive.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.GeneralTabPage.SuspendLayout()
        Me.NoteTabPage.SuspendLayout()
        Me.AttachmentTabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'EmpployeeName
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.EmpployeeName, "TextChanged")
        Me.EmpployeeName.EditValue = ""
        Me.EmpployeeName.EnterMoveNextControl = True
        Me.EmpployeeName.Location = New System.Drawing.Point(363, 115)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.EmpployeeName, True)
        Me.EmpployeeName.Name = "EmpployeeName"
        Me.EmpployeeName.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.EmpployeeName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.EmpployeeName.Properties.Appearance.Options.UseBackColor = True
        Me.EmpployeeName.Properties.Appearance.Options.UseFont = True
        Me.EmpployeeName.Properties.MaxLength = 100
        Me.EmpployeeName.Properties.ReadOnly = True
        Me.EmpployeeName.Properties.ValidateOnEnterKey = True
        Me.EmpployeeName.Size = New System.Drawing.Size(268, 21)
        Me.EmpployeeName.TabIndex = 198
        Me.EmpployeeName.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.EmpployeeName, "Text")
        '
        'Password_Confirm
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Password_Confirm, "TextChanged")
        Me.Password_Confirm.EditValue = ""
        Me.Password_Confirm.EnterMoveNextControl = True
        Me.Password_Confirm.Location = New System.Drawing.Point(146, 88)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Password_Confirm, True)
        Me.Password_Confirm.Name = "Password_Confirm"
        Me.Password_Confirm.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Password_Confirm.Properties.Appearance.Options.UseFont = True
        Me.Password_Confirm.Properties.MaxLength = 50
        Me.Password_Confirm.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password_Confirm.Properties.ValidateOnEnterKey = True
        Me.Password_Confirm.Size = New System.Drawing.Size(189, 21)
        Me.Password_Confirm.TabIndex = 2
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Password_Confirm, "Text")
        '
        'PrivilegeID
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.PrivilegeID, "TextChanged")
        Me.PrivilegeID.EnterMoveNextControl = True
        Me.PrivilegeID.Location = New System.Drawing.Point(146, 142)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.PrivilegeID, True)
        Me.PrivilegeID.Name = "PrivilegeID"
        Me.PrivilegeID.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.PrivilegeID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrivilegeID.Properties.Appearance.Options.UseFont = True
        Me.PrivilegeID.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.PrivilegeID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PrivilegeID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 50, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PrivilegeCode", 30, "ชื่อกลุ่มสิทธิ"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Remark", 70, "รายละเอียด")})
        Me.PrivilegeID.Properties.DropDownRows = 10
        Me.PrivilegeID.Properties.NullText = ""
        Me.PrivilegeID.Properties.NullValuePromptShowForEmptyValue = True
        Me.PrivilegeID.Properties.PopupWidth = 300
        Me.PrivilegeID.Size = New System.Drawing.Size(189, 21)
        Me.PrivilegeID.TabIndex = 4
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.PrivilegeID, "Text")
        '
        'btnRefreshPrivilege
        '
        Me.btnRefreshPrivilege.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRefreshPrivilege.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnRefreshPrivilege, "")
        Me.btnRefreshPrivilege.Image = CType(resources.GetObject("btnRefreshPrivilege.Image"), System.Drawing.Image)
        Me.btnRefreshPrivilege.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefreshPrivilege.Location = New System.Drawing.Point(336, 142)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnRefreshPrivilege, True)
        Me.btnRefreshPrivilege.Name = "btnRefreshPrivilege"
        Me.btnRefreshPrivilege.Size = New System.Drawing.Size(21, 21)
        Me.btnRefreshPrivilege.TabIndex = 169
        Me.btnRefreshPrivilege.TabStop = False
        Me.btnRefreshPrivilege.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnRefreshPrivilege, "")
        '
        'Password
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Password, "TextChanged")
        Me.Password.EditValue = ""
        Me.Password.EnterMoveNextControl = True
        Me.Password.Location = New System.Drawing.Point(146, 61)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Password, True)
        Me.Password.Name = "Password"
        Me.Password.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Password.Properties.Appearance.Options.UseFont = True
        Me.Password.Properties.MaxLength = 50
        Me.Password.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Properties.ValidateOnEnterKey = True
        Me.Password.Size = New System.Drawing.Size(189, 21)
        Me.Password.TabIndex = 1
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Password, "Text")
        '
        'UserName
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.UserName, "TextChanged")
        Me.UserName.EditValue = ""
        Me.UserName.EnterMoveNextControl = True
        Me.UserName.Location = New System.Drawing.Point(146, 34)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.UserName, True)
        Me.UserName.Name = "UserName"
        Me.UserName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.UserName.Properties.Appearance.Options.UseFont = True
        Me.UserName.Properties.MaxLength = 100
        Me.UserName.Properties.ValidateOnEnterKey = True
        Me.UserName.Size = New System.Drawing.Size(189, 21)
        Me.UserName.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UserName, "Text")
        '
        'Remark
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Remark, "TextChanged")
        Me.Remark.EditValue = ""
        Me.Remark.EnterMoveNextControl = True

        Me.Remark.Location = New System.Drawing.Point(146, 169)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Remark, True)
        Me.Remark.Name = "Remark"
        Me.Remark.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Remark.Properties.Appearance.Options.UseFont = True
        Me.Remark.Properties.MaxLength = 100
        Me.Remark.Size = New System.Drawing.Size(485, 80)
        Me.Remark.TabIndex = 5
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Remark, "Text")
        '
        'btnRefreshEmp
        '
        Me.btnRefreshEmp.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRefreshEmp.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnRefreshEmp, "")
        Me.btnRefreshEmp.Image = CType(resources.GetObject("btnRefreshEmp.Image"), System.Drawing.Image)
        Me.btnRefreshEmp.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefreshEmp.Location = New System.Drawing.Point(336, 115)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnRefreshEmp, True)
        Me.btnRefreshEmp.Name = "btnRefreshEmp"
        Me.btnRefreshEmp.Size = New System.Drawing.Size(21, 21)
        Me.btnRefreshEmp.TabIndex = 202
        Me.btnRefreshEmp.TabStop = False
        Me.btnRefreshEmp.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnRefreshEmp, "")
        '
        'CheckInAcive
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.CheckInAcive, "CheckedChanged")

        Me.CheckInAcive.Location = New System.Drawing.Point(361, 32)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.CheckInAcive, True)
        Me.CheckInAcive.Name = "CheckInAcive"
        Me.CheckInAcive.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckInAcive.Properties.Appearance.Options.UseFont = True
        Me.CheckInAcive.Properties.Caption = "ระงับการใช้งาน"
        Me.CheckInAcive.Size = New System.Drawing.Size(108, 19)
        Me.CheckInAcive.TabIndex = 6
        Me.CheckInAcive.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.CheckInAcive, "Checked")
        '
        'EmpID
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.EmpID, "TextChanged")
        Me.EmpID.EnterMoveNextControl = True

        Me.EmpID.Location = New System.Drawing.Point(146, 115)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.EmpID, True)
        Me.EmpID.Name = "EmpID"
        Me.EmpID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpID.Properties.Appearance.Options.UseFont = True
        Me.EmpID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EmpID.Properties.NullText = ""
        Me.EmpID.Properties.View = Me.SearchLookUpEdit1View
        Me.EmpID.Size = New System.Drawing.Size(189, 21)
        Me.EmpID.TabIndex = 3
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.EmpID, "Text")
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn5, Me.GridColumn6})
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
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
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 37)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.XtraTabControl1, True)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.GeneralTabPage
        Me.XtraTabControl1.Size = New System.Drawing.Size(864, 495)
        Me.XtraTabControl1.TabIndex = 6
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.GeneralTabPage, Me.NoteTabPage, Me.AttachmentTabPage})
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.XtraTabControl1, "")
        '
        'GeneralTabPage
        '
        Me.GeneralTabPage.Appearance.PageClient.BackColor = System.Drawing.Color.LightGray
        Me.GeneralTabPage.Appearance.PageClient.Options.UseBackColor = True
        Me.GeneralTabPage.AutoScroll = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.GeneralTabPage, "")
        Me.GeneralTabPage.Controls.Add(Me.CheckInAcive)
        Me.GeneralTabPage.Controls.Add(Me.EmpID)
        Me.GeneralTabPage.Controls.Add(Me.Label10)
        Me.GeneralTabPage.Controls.Add(Me.btnRefreshEmp)
        Me.GeneralTabPage.Controls.Add(Me.Label2)
        Me.GeneralTabPage.Controls.Add(Me.Label7)
        Me.GeneralTabPage.Controls.Add(Me.EmpployeeName)
        Me.GeneralTabPage.Controls.Add(Me.Password_Confirm)
        Me.GeneralTabPage.Controls.Add(Me.PrivilegeID)
        Me.GeneralTabPage.Controls.Add(Me.btnRefreshPrivilege)
        Me.GeneralTabPage.Controls.Add(Me.Password)
        Me.GeneralTabPage.Controls.Add(Me.UserName)
        Me.GeneralTabPage.Controls.Add(Me.Label21)
        Me.GeneralTabPage.Controls.Add(Me.Label8)
        Me.GeneralTabPage.Controls.Add(Me.Label4)
        Me.GeneralTabPage.Controls.Add(Me.Remark)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.GeneralTabPage, True)
        Me.GeneralTabPage.Name = "GeneralTabPage"
        Me.GeneralTabPage.Size = New System.Drawing.Size(858, 469)
        Me.GeneralTabPage.Text = "ข้อมูลทั่วไป"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.GeneralTabPage, "")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label10, "")
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(44, 118)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label10, True)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 14)
        Me.Label10.TabIndex = 203
        Me.Label10.Text = "รหัสพนักงาน"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label10, "")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label2, "")
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(44, 91)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label2, True)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 14)
        Me.Label2.TabIndex = 201
        Me.Label2.Text = "ยืนยันรหัสผ่าน"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label2, "")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label7, "")
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(47, 172)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label7, True)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 14)
        Me.Label7.TabIndex = 200
        Me.Label7.Text = "รายละเอียด"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label7, "")
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label21, "")
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(44, 145)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label21, True)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(100, 14)
        Me.Label21.TabIndex = 117
        Me.Label21.Text = "กลุ่มสิทธิการใช้งาน"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label21, "")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label8, "")
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(44, 64)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label8, True)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 14)
        Me.Label8.TabIndex = 109
        Me.Label8.Text = "รหัสผ่าน"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label8, "")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label4, "")
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(44, 37)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label4, True)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 14)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "ชื่อเข้าระบบ"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label4, "")
        '
        'NoteTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.NoteTabPage, "")
        Me.NoteTabPage.Controls.Add(Me.UcNote1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.NoteTabPage, True)
        Me.NoteTabPage.Name = "NoteTabPage"
        Me.NoteTabPage.Size = New System.Drawing.Size(858, 469)
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
        Me.UcNote1.Size = New System.Drawing.Size(858, 469)
        Me.UcNote1.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcNote1, "")
        '
        'AttachmentTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.AttachmentTabPage, "")
        Me.AttachmentTabPage.Controls.Add(Me.UcFileAttach1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.AttachmentTabPage, True)
        Me.AttachmentTabPage.Name = "AttachmentTabPage"
        Me.AttachmentTabPage.Size = New System.Drawing.Size(858, 469)
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
        Me.UcFileAttach1.Size = New System.Drawing.Size(858, 469)
        Me.UcFileAttach1.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcFileAttach1, "")
        '
        'FormChangedComponent1
        '
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 532)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frmUser"
        Me.Text = "frmUser"
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.EmpployeeName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Password_Confirm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrivilegeID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Password.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Remark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckInAcive.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.GeneralTabPage.ResumeLayout(False)
        Me.GeneralTabPage.PerformLayout()
        Me.NoteTabPage.ResumeLayout(False)
        Me.AttachmentTabPage.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents GeneralTabPage As DevExpress.XtraTab.XtraTabPage
    Private WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents EmpployeeName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Password_Confirm As DevExpress.XtraEditors.TextEdit
    Private WithEvents PrivilegeID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnRefreshPrivilege As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Password As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UserName As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label21 As System.Windows.Forms.Label
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Remark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents NoteTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcNote1 As ucNote
    Friend WithEvents AttachmentTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcFileAttach1 As ucFileAttach
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents EmpID As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnRefreshEmp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CheckInAcive As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents FormChangedComponent1 As FormChangedComponent


End Class
