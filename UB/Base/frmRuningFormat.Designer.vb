<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRuningFormat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRuningFormat))
        Me.FormatFront = New DevExpress.XtraEditors.TextEdit()
        Me.Program = New DevExpress.XtraEditors.TextEdit()
        Me.Menus = New DevExpress.XtraEditors.TextEdit()
        Me.FormatDate = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.RunningCount = New DevExpress.XtraEditors.CalcEdit()
        Me.FormatMidle = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.GeneralTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupCondition = New DevExpress.XtraEditors.GroupControl()
        Me.btnLocation = New DevExpress.XtraEditors.SimpleButton()
        Me.LocationDTLID = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.LastNo = New DevExpress.XtraEditors.CalcEdit()
        Me.FormatYear = New DevExpress.XtraEditors.RadioGroup()
        Me.lblExam = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NoteTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcNote1 = New UB.ucNote()
        Me.AdminTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcAdmin1 = New UB.ucAdmin()
        Me.FormChangedComponent1 = New UB.FormChangedComponent(Me.components)
        Me.chkIsReset = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.FormatFront.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Program.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormatDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RunningCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormatMidle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.GeneralTabPage.SuspendLayout()
        CType(Me.GroupCondition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupCondition.SuspendLayout()
        CType(Me.LocationDTLID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LastNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormatYear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NoteTabPage.SuspendLayout()
        Me.AdminTabPage.SuspendLayout()
        CType(Me.chkIsReset.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormatFront
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.FormatFront, "TextChanged")
        Me.FormatFront.EditValue = ""
        Me.FormatFront.EnterMoveNextControl = True
        Me.FormatFront.Location = New System.Drawing.Point(138, 89)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.FormatFront, True)
        Me.FormatFront.Name = "FormatFront"
        Me.FormatFront.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormatFront.Properties.Appearance.Options.UseFont = True
        Me.FormatFront.Properties.MaxLength = 50
        Me.FormatFront.Properties.ValidateOnEnterKey = True
        Me.FormatFront.Size = New System.Drawing.Size(189, 20)
        Me.FormatFront.TabIndex = 1
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.FormatFront, "Text")
        '
        'Program
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Program, "TextChanged")
        Me.Program.EditValue = ""
        Me.Program.EnterMoveNextControl = True
        Me.Program.Location = New System.Drawing.Point(138, 24)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Program, True)
        Me.Program.Name = "Program"
        Me.Program.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.Program.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Program.Properties.Appearance.Options.UseBackColor = True
        Me.Program.Properties.Appearance.Options.UseFont = True
        Me.Program.Properties.MaxLength = 50
        Me.Program.Properties.ReadOnly = True
        Me.Program.Properties.ValidateOnEnterKey = True
        Me.Program.Size = New System.Drawing.Size(189, 20)
        Me.Program.TabIndex = 190
        Me.Program.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Program, "Text")
        '
        'Menus
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Menus, "TextChanged")
        Me.Menus.EditValue = ""
        Me.Menus.EnterMoveNextControl = True
        Me.Menus.Location = New System.Drawing.Point(385, 24)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Menus, True)
        Me.Menus.Name = "Menus"
        Me.Menus.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.Menus.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Menus.Properties.Appearance.Options.UseBackColor = True
        Me.Menus.Properties.Appearance.Options.UseFont = True
        Me.Menus.Properties.MaxLength = 50
        Me.Menus.Properties.ReadOnly = True
        Me.Menus.Properties.ValidateOnEnterKey = True
        Me.Menus.Size = New System.Drawing.Size(189, 20)
        Me.Menus.TabIndex = 191
        Me.Menus.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Menus, "Text")
        '
        'FormatDate
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.FormatDate, "TextChanged")
        Me.FormatDate.EnterMoveNextControl = True
        Me.FormatDate.Location = New System.Drawing.Point(138, 116)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.FormatDate, True)
        Me.FormatDate.Name = "FormatDate"
        Me.FormatDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormatDate.Properties.Appearance.Options.UseFont = True
        Me.FormatDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FormatDate.Properties.ImmediatePopup = True
        Me.FormatDate.Properties.NullValuePromptShowForEmptyValue = True
        Me.FormatDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.FormatDate.Properties.UseCtrlScroll = True
        Me.FormatDate.Properties.ValidateOnEnterKey = True
        Me.FormatDate.Size = New System.Drawing.Size(189, 20)
        Me.FormatDate.TabIndex = 2
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.FormatDate, "Text")
        '
        'RunningCount
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.RunningCount, "TextChanged")
        Me.RunningCount.EnterMoveNextControl = True
        Me.RunningCount.Location = New System.Drawing.Point(138, 170)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.RunningCount, True)
        Me.RunningCount.Name = "RunningCount"
        Me.RunningCount.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RunningCount.Properties.Appearance.Options.UseFont = True
        Me.RunningCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RunningCount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RunningCount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RunningCount.Properties.Mask.EditMask = "n0"
        Me.RunningCount.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.RunningCount.Properties.MaxLength = 10
        Me.RunningCount.Properties.Precision = 0
        Me.RunningCount.Size = New System.Drawing.Size(189, 20)
        Me.RunningCount.TabIndex = 5
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.RunningCount, "Text")
        '
        'FormatMidle
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.FormatMidle, "TextChanged")
        Me.FormatMidle.EnterMoveNextControl = True
        Me.FormatMidle.Location = New System.Drawing.Point(138, 143)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.FormatMidle, True)
        Me.FormatMidle.Name = "FormatMidle"
        Me.FormatMidle.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormatMidle.Properties.Appearance.Options.UseFont = True
        Me.FormatMidle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FormatMidle.Properties.ImmediatePopup = True
        Me.FormatMidle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.FormatMidle.Properties.UseCtrlScroll = True
        Me.FormatMidle.Properties.ValidateOnEnterKey = True
        Me.FormatMidle.Size = New System.Drawing.Size(189, 20)
        Me.FormatMidle.TabIndex = 4
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.FormatMidle, "Text")
        '
        'btnRefresh
        '
        Me.btnRefresh.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRefresh.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnRefresh, "")
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefresh.Location = New System.Drawing.Point(99, 208)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnRefresh, True)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(21, 21)
        Me.btnRefresh.TabIndex = 219
        Me.btnRefresh.TabStop = False
        Me.btnRefresh.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnRefresh, "")
        '
        'XtraTabControl1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.XtraTabControl1, "")
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 37)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.XtraTabControl1, True)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.GeneralTabPage
        Me.XtraTabControl1.Size = New System.Drawing.Size(698, 383)
        Me.XtraTabControl1.TabIndex = 7
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.GeneralTabPage, Me.NoteTabPage, Me.AdminTabPage})
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.XtraTabControl1, "")
        '
        'GeneralTabPage
        '
        Me.GeneralTabPage.Appearance.PageClient.BackColor = System.Drawing.Color.LightGray
        Me.GeneralTabPage.Appearance.PageClient.Options.UseBackColor = True
        Me.GeneralTabPage.AutoScroll = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.GeneralTabPage, "")
        Me.GeneralTabPage.Controls.Add(Me.chkIsReset)
        Me.GeneralTabPage.Controls.Add(Me.GroupCondition)
        Me.GeneralTabPage.Controls.Add(Me.LastNo)
        Me.GeneralTabPage.Controls.Add(Me.btnRefresh)
        Me.GeneralTabPage.Controls.Add(Me.FormatYear)
        Me.GeneralTabPage.Controls.Add(Me.FormatMidle)
        Me.GeneralTabPage.Controls.Add(Me.RunningCount)
        Me.GeneralTabPage.Controls.Add(Me.lblExam)
        Me.GeneralTabPage.Controls.Add(Me.Label4)
        Me.GeneralTabPage.Controls.Add(Me.Label9)
        Me.GeneralTabPage.Controls.Add(Me.Label7)
        Me.GeneralTabPage.Controls.Add(Me.Label6)
        Me.GeneralTabPage.Controls.Add(Me.FormatDate)
        Me.GeneralTabPage.Controls.Add(Me.Label3)
        Me.GeneralTabPage.Controls.Add(Me.Menus)
        Me.GeneralTabPage.Controls.Add(Me.Program)
        Me.GeneralTabPage.Controls.Add(Me.Label10)
        Me.GeneralTabPage.Controls.Add(Me.Label1)
        Me.GeneralTabPage.Controls.Add(Me.FormatFront)
        Me.GeneralTabPage.Controls.Add(Me.Label8)
        Me.GeneralTabPage.Controls.Add(Me.Label5)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.GeneralTabPage, True)
        Me.GeneralTabPage.Name = "GeneralTabPage"
        Me.GeneralTabPage.Size = New System.Drawing.Size(692, 355)
        Me.GeneralTabPage.Text = "ข้อมูลทั่วไป"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.GeneralTabPage, "")
        '
        'GroupCondition
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.GroupCondition, "")
        Me.GroupCondition.Controls.Add(Me.btnLocation)
        Me.GroupCondition.Controls.Add(Me.LocationDTLID)
        Me.GroupCondition.Controls.Add(Me.Label33)
        Me.GroupCondition.Location = New System.Drawing.Point(41, 245)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.GroupCondition, True)
        Me.GroupCondition.Name = "GroupCondition"
        Me.GroupCondition.Size = New System.Drawing.Size(533, 100)
        Me.GroupCondition.TabIndex = 220
        Me.GroupCondition.Text = "กำหนดค่าอื่นๆ"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.GroupCondition, "")
        '
        'btnLocation
        '
        Me.btnLocation.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnLocation.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnLocation, "")
        Me.btnLocation.Image = CType(resources.GetObject("btnLocation.Image"), System.Drawing.Image)
        Me.btnLocation.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnLocation.Location = New System.Drawing.Point(276, 26)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnLocation, True)
        Me.btnLocation.Name = "btnLocation"
        Me.btnLocation.Size = New System.Drawing.Size(21, 21)
        Me.btnLocation.TabIndex = 238
        Me.btnLocation.TabStop = False
        Me.btnLocation.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnLocation, "")
        '
        'LocationDTLID
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.LocationDTLID, "TextChanged")
        Me.LocationDTLID.Location = New System.Drawing.Point(66, 27)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.LocationDTLID, True)
        Me.LocationDTLID.Name = "LocationDTLID"
        Me.LocationDTLID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocationDTLID.Properties.Appearance.Options.UseFont = True
        Me.LocationDTLID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LocationDTLID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationDTLID", "LocationDTLID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Location", 100, "คลัง"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationDTL", 150, "สถานที่เก็บ")})
        Me.LocationDTLID.Properties.NullText = ""
        Me.LocationDTLID.Properties.ShowHeader = False
        Me.LocationDTLID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LocationDTLID.Size = New System.Drawing.Size(210, 20)
        Me.LocationDTLID.TabIndex = 236
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.LocationDTLID, "Text")
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label33, "")
        Me.Label33.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label33.Location = New System.Drawing.Point(15, 30)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label33, True)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(45, 14)
        Me.Label33.TabIndex = 237
        Me.Label33.Text = "คลังรวม"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label33, "")
        '
        'LastNo
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.LastNo, "TextChanged")
        Me.LastNo.Location = New System.Drawing.Point(138, 52)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.LastNo, True)
        Me.LastNo.Name = "LastNo"
        Me.LastNo.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.LastNo.Properties.Appearance.Options.UseBackColor = True
        Me.LastNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LastNo.Properties.DisplayFormat.FormatString = "n0"
        Me.LastNo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.LastNo.Properties.EditFormat.FormatString = "n0"
        Me.LastNo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.LastNo.Properties.ReadOnly = True
        Me.LastNo.Size = New System.Drawing.Size(189, 20)
        Me.LastNo.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.LastNo, "Text")
        '
        'FormatYear
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.FormatYear, "")
        Me.FormatYear.EditValue = "true"
        Me.FormatYear.Location = New System.Drawing.Point(385, 116)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.FormatYear, True)
        Me.FormatYear.Name = "FormatYear"
        Me.FormatYear.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("EN", "คริสต์ศักราช"), New DevExpress.XtraEditors.Controls.RadioGroupItem("TH", "พุทธศักราช")})
        Me.FormatYear.Size = New System.Drawing.Size(189, 21)
        Me.FormatYear.TabIndex = 3
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.FormatYear, "")
        '
        'lblExam
        '
        Me.lblExam.AutoSize = True
        Me.lblExam.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.lblExam, "")
        Me.lblExam.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblExam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblExam.Location = New System.Drawing.Point(135, 215)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.lblExam, True)
        Me.lblExam.Name = "lblExam"
        Me.lblExam.Size = New System.Drawing.Size(35, 14)
        Me.lblExam.TabIndex = 200
        Me.lblExam.Text = "XXXX"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.lblExam, "")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label4, "")
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 54)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label4, True)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 14)
        Me.Label4.TabIndex = 198
        Me.Label4.Text = "Running ล่าสุด"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label4, "")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label9, "")
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(331, 119)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label9, True)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 14)
        Me.Label9.TabIndex = 197
        Me.Label9.Text = "ปีศักราช"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label9, "")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label7, "")
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(38, 146)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label7, True)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 14)
        Me.Label7.TabIndex = 195
        Me.Label7.Text = "อักขระคั่น"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label7, "")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label6, "")
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 119)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label6, True)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 14)
        Me.Label6.TabIndex = 194
        Me.Label6.Text = "วัน เดือน ปี"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label6, "")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label3, "")
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(354, 27)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label3, True)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 14)
        Me.Label3.TabIndex = 192
        Me.Label3.Text = "เมนู"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label3, "")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label10, "")
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(38, 27)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label10, True)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 14)
        Me.Label10.TabIndex = 187
        Me.Label10.Text = "ระบบ"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label10, "")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label1, "")
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(38, 173)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label1, True)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 14)
        Me.Label1.TabIndex = 148
        Me.Label1.Text = "หลักเลข Running"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label1, "")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label8, "")
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(38, 92)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label8, True)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 14)
        Me.Label8.TabIndex = 109
        Me.Label8.Text = "อักขระหน้า"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label8, "")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label5, "")
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 213)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label5, True)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 16)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "ตัวอย่าง : "
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label5, "")
        '
        'NoteTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.NoteTabPage, "")
        Me.NoteTabPage.Controls.Add(Me.UcNote1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.NoteTabPage, True)
        Me.NoteTabPage.Name = "NoteTabPage"
        Me.NoteTabPage.Size = New System.Drawing.Size(692, 355)
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
        Me.UcNote1.Size = New System.Drawing.Size(692, 355)
        Me.UcNote1.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcNote1, "")
        '
        'AdminTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.AdminTabPage, "")
        Me.AdminTabPage.Controls.Add(Me.UcAdmin1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.AdminTabPage, True)
        Me.AdminTabPage.Name = "AdminTabPage"
        Me.AdminTabPage.Size = New System.Drawing.Size(692, 355)
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
        Me.UcAdmin1.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcAdmin1, "")
        '
        'FormChangedComponent1
        '
        '
        'chkIsReset
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.chkIsReset, "CheckedChanged")
        Me.chkIsReset.EditValue = True
        Me.chkIsReset.Location = New System.Drawing.Point(355, 53)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.chkIsReset, True)
        Me.chkIsReset.Name = "chkIsReset"
        Me.chkIsReset.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIsReset.Properties.Appearance.Options.UseFont = True
        Me.chkIsReset.Properties.Caption = "เริ่มต้นลำดับใหม่"
        Me.chkIsReset.Size = New System.Drawing.Size(122, 19)
        Me.chkIsReset.TabIndex = 221
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.chkIsReset, "Checked")
        '
        'frmRuningFormat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 420)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frmRuningFormat"
        Me.Text = "frmRuningFormat"
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.FormatFront.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Program.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormatDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RunningCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormatMidle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.GeneralTabPage.ResumeLayout(False)
        Me.GeneralTabPage.PerformLayout()
        CType(Me.GroupCondition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupCondition.ResumeLayout(False)
        Me.GroupCondition.PerformLayout()
        CType(Me.LocationDTLID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LastNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormatYear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NoteTabPage.ResumeLayout(False)
        Me.AdminTabPage.ResumeLayout(False)
        CType(Me.chkIsReset.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents GeneralTabPage As DevExpress.XtraTab.XtraTabPage
    Private WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FormatFront As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NoteTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcNote1 As ucNote
    Friend WithEvents AdminTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcAdmin1 As ucAdmin
    Private WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Menus As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Program As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label9 As System.Windows.Forms.Label
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents FormatDate As DevExpress.XtraEditors.ComboBoxEdit
    Private WithEvents lblExam As System.Windows.Forms.Label
    Friend WithEvents RunningCount As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents FormatMidle As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents FormatYear As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents FormChangedComponent1 As FormChangedComponent
    Friend WithEvents LastNo As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents GroupCondition As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnLocation As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LocationDTLID As DevExpress.XtraEditors.LookUpEdit
    Private WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents chkIsReset As DevExpress.XtraEditors.CheckEdit

End Class
