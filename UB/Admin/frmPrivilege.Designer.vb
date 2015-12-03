<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrivilege
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
        Me.GridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupDisplay = New DevExpress.XtraEditors.GroupControl()
        Me.CheckEnable = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckVisible = New DevExpress.XtraEditors.CheckEdit()
        Me.GroupEvent = New DevExpress.XtraEditors.GroupControl()
        Me.CheckPrint = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckDelete = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckAdd = New DevExpress.XtraEditors.CheckEdit()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.GeneralTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.txtRemark = New DevExpress.XtraEditors.MemoEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtThai = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AdminTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.CheckInAcive = New DevExpress.XtraEditors.CheckEdit()
        Me.txtModifiTime = New DevExpress.XtraEditors.TextEdit()
        Me.txtCreateTime = New DevExpress.XtraEditors.TextEdit()
        Me.txtModifiBy = New DevExpress.XtraEditors.TextEdit()
        Me.txtCreateBy = New DevExpress.XtraEditors.TextEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.GroupAction = New DevExpress.XtraEditors.GroupControl()
        Me.CheckConvert = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckAssign = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckCopy = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckCreateQuick = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckImport = New DevExpress.XtraEditors.CheckEdit()
        Me.btnSelectAll = New DevExpress.XtraEditors.SimpleButton()
        Me.btnUnAll = New DevExpress.XtraEditors.SimpleButton()
        Me.FormChangedComponent1 = New FormChangedComponent(Me.components)
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupDisplay.SuspendLayout()
        CType(Me.CheckEnable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckVisible.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupEvent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupEvent.SuspendLayout()
        CType(Me.CheckPrint.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckDelete.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckAdd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.GeneralTabPage.SuspendLayout()
        CType(Me.txtRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtThai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AdminTabPage.SuspendLayout()
        CType(Me.CheckInAcive.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtModifiTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCreateTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtModifiBy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCreateBy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupAction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupAction.SuspendLayout()
        CType(Me.CheckConvert.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckAssign.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckCopy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckCreateQuick.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckImport.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl
        '
        Me.GridControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.GridControl, "")
        Me.GridControl.Location = New System.Drawing.Point(12, 165)
        Me.GridControl.MainView = Me.GridView
        Me.FormChangedComponent1.SetMonitorForChanges(Me.GridControl, True)
        Me.GridControl.Name = "GridControl"
        Me.GridControl.Size = New System.Drawing.Size(325, 328)
        Me.GridControl.TabIndex = 17
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.GridControl, "")
        Me.GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
        '
        'GridView
        '
        Me.GridView.Appearance.FocusedCell.BackColor = System.Drawing.Color.AliceBlue
        Me.GridView.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView.GridControl = Me.GridControl
        Me.GridView.Name = "GridView"
        Me.GridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView.OptionsBehavior.Editable = False
        Me.GridView.OptionsBehavior.ReadOnly = True
        Me.GridView.OptionsLayout.Columns.AddNewColumns = False
        Me.GridView.OptionsLayout.Columns.RemoveOldColumns = False
        Me.GridView.OptionsView.ShowColumnHeaders = False
        '
        'GroupDisplay
        '
        Me.GroupDisplay.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.GroupDisplay, "")
        Me.GroupDisplay.Controls.Add(Me.CheckEnable)
        Me.GroupDisplay.Controls.Add(Me.CheckVisible)
        Me.GroupDisplay.Location = New System.Drawing.Point(349, 172)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.GroupDisplay, True)
        Me.GroupDisplay.Name = "GroupDisplay"
        Me.GroupDisplay.Size = New System.Drawing.Size(596, 55)
        Me.GroupDisplay.TabIndex = 18
        Me.GroupDisplay.Text = "Display [Menu]"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.GroupDisplay, "")
        '
        'CheckEnable
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.CheckEnable, "CheckedChanged")
        Me.CheckEnable.Location = New System.Drawing.Point(119, 25)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.CheckEnable, True)
        Me.CheckEnable.Name = "CheckEnable"
        Me.CheckEnable.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEnable.Properties.Appearance.Options.UseFont = True
        Me.CheckEnable.Properties.Caption = "Enable"
        Me.CheckEnable.Size = New System.Drawing.Size(70, 19)
        Me.CheckEnable.TabIndex = 11
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.CheckEnable, "Checked")
        '
        'CheckVisible
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.CheckVisible, "CheckedChanged")
        Me.CheckVisible.Location = New System.Drawing.Point(16, 25)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.CheckVisible, True)
        Me.CheckVisible.Name = "CheckVisible"
        Me.CheckVisible.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckVisible.Properties.Appearance.Options.UseFont = True
        Me.CheckVisible.Properties.Caption = "Visible"
        Me.CheckVisible.Size = New System.Drawing.Size(70, 19)
        Me.CheckVisible.TabIndex = 10
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.CheckVisible, "Checked")
        '
        'GroupEvent
        '
        Me.GroupEvent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.GroupEvent, "")
        Me.GroupEvent.Controls.Add(Me.CheckPrint)
        Me.GroupEvent.Controls.Add(Me.CheckDelete)
        Me.GroupEvent.Controls.Add(Me.CheckEdit)
        Me.GroupEvent.Controls.Add(Me.CheckAdd)
        Me.GroupEvent.Location = New System.Drawing.Point(349, 245)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.GroupEvent, True)
        Me.GroupEvent.Name = "GroupEvent"
        Me.GroupEvent.Size = New System.Drawing.Size(596, 55)
        Me.GroupEvent.TabIndex = 19
        Me.GroupEvent.Text = "Events"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.GroupEvent, "")
        '
        'CheckPrint
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.CheckPrint, "CheckedChanged")
        Me.CheckPrint.Location = New System.Drawing.Point(335, 25)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.CheckPrint, True)
        Me.CheckPrint.Name = "CheckPrint"
        Me.CheckPrint.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckPrint.Properties.Appearance.Options.UseFont = True
        Me.CheckPrint.Properties.Caption = "Print"
        Me.CheckPrint.Size = New System.Drawing.Size(70, 19)
        Me.CheckPrint.TabIndex = 13
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.CheckPrint, "Checked")
        '
        'CheckDelete
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.CheckDelete, "CheckedChanged")
        Me.CheckDelete.Location = New System.Drawing.Point(229, 25)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.CheckDelete, True)
        Me.CheckDelete.Name = "CheckDelete"
        Me.CheckDelete.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckDelete.Properties.Appearance.Options.UseFont = True
        Me.CheckDelete.Properties.Caption = "Delete"
        Me.CheckDelete.Size = New System.Drawing.Size(70, 19)
        Me.CheckDelete.TabIndex = 12
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.CheckDelete, "Checked")
        '
        'CheckEdit
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.CheckEdit, "CheckedChanged")
        Me.CheckEdit.Location = New System.Drawing.Point(119, 25)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.CheckEdit, True)
        Me.CheckEdit.Name = "CheckEdit"
        Me.CheckEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit.Properties.Caption = "Edit"
        Me.CheckEdit.Size = New System.Drawing.Size(70, 19)
        Me.CheckEdit.TabIndex = 11
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.CheckEdit, "Checked")
        '
        'CheckAdd
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.CheckAdd, "CheckedChanged")
        Me.CheckAdd.Location = New System.Drawing.Point(16, 25)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.CheckAdd, True)
        Me.CheckAdd.Name = "CheckAdd"
        Me.CheckAdd.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckAdd.Properties.Appearance.Options.UseFont = True
        Me.CheckAdd.Properties.Caption = "Add"
        Me.CheckAdd.Size = New System.Drawing.Size(70, 19)
        Me.CheckAdd.TabIndex = 10
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.CheckAdd, "Checked")
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.XtraTabControl1, "")
        Me.XtraTabControl1.Location = New System.Drawing.Point(1, 37)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.XtraTabControl1, True)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.GeneralTabPage
        Me.XtraTabControl1.Size = New System.Drawing.Size(956, 127)
        Me.XtraTabControl1.TabIndex = 20
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.GeneralTabPage, Me.AdminTabPage})
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.XtraTabControl1, "")
        '
        'GeneralTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.GeneralTabPage, "")
        Me.GeneralTabPage.Controls.Add(Me.txtRemark)
        Me.GeneralTabPage.Controls.Add(Me.Label1)
        Me.GeneralTabPage.Controls.Add(Me.txtThai)
        Me.GeneralTabPage.Controls.Add(Me.Label4)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.GeneralTabPage, True)
        Me.GeneralTabPage.Name = "GeneralTabPage"
        Me.GeneralTabPage.Size = New System.Drawing.Size(950, 99)
        Me.GeneralTabPage.Text = "General"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.GeneralTabPage, "")
        '
        'txtRemark
        '
        Me.txtRemark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtRemark, "TextChanged")
        Me.txtRemark.EditValue = ""
        Me.txtRemark.Location = New System.Drawing.Point(151, 47)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.txtRemark, True)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRemark.Properties.Appearance.Options.UseFont = True
        Me.txtRemark.Properties.MaxLength = 100
        Me.txtRemark.Size = New System.Drawing.Size(781, 45)
        Me.txtRemark.TabIndex = 137
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtRemark, "Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label1, "")
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 50)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label1, True)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 14)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "รายละเอียด"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label1, "")
        '
        'txtThai
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtThai, "TextChanged")
        Me.txtThai.EditValue = ""
        Me.txtThai.EnterMoveNextControl = True
        Me.txtThai.Location = New System.Drawing.Point(151, 16)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.txtThai, True)
        Me.txtThai.Name = "txtThai"
        Me.txtThai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtThai.Properties.Appearance.Options.UseFont = True
        Me.txtThai.Properties.MaxLength = 50
        Me.txtThai.Properties.ValidateOnEnterKey = True
        Me.txtThai.Size = New System.Drawing.Size(214, 20)
        Me.txtThai.TabIndex = 129
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtThai, "Text")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label4, "")
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 23)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label4, True)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 14)
        Me.Label4.TabIndex = 109
        Me.Label4.Text = "ชื่อกลุ่มสิทธิ *"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label4, "")
        '
        'AdminTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.AdminTabPage, "")
        Me.AdminTabPage.Controls.Add(Me.CheckInAcive)
        Me.AdminTabPage.Controls.Add(Me.txtModifiTime)
        Me.AdminTabPage.Controls.Add(Me.txtCreateTime)
        Me.AdminTabPage.Controls.Add(Me.txtModifiBy)
        Me.AdminTabPage.Controls.Add(Me.txtCreateBy)
        Me.AdminTabPage.Controls.Add(Me.Label7)
        Me.AdminTabPage.Controls.Add(Me.Label3)
        Me.AdminTabPage.Controls.Add(Me.Label2)
        Me.AdminTabPage.Controls.Add(Me.Label36)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.AdminTabPage, True)
        Me.AdminTabPage.Name = "AdminTabPage"
        Me.AdminTabPage.Size = New System.Drawing.Size(950, 99)
        Me.AdminTabPage.Text = "Administrator"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.AdminTabPage, "")
        '
        'CheckInAcive
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.CheckInAcive, "CheckedChanged")
        Me.CheckInAcive.Location = New System.Drawing.Point(153, 75)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.CheckInAcive, True)
        Me.CheckInAcive.Name = "CheckInAcive"
        Me.CheckInAcive.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckInAcive.Properties.Appearance.Options.UseFont = True
        Me.CheckInAcive.Properties.Caption = "ระงับการใช้งาน"
        Me.CheckInAcive.Size = New System.Drawing.Size(108, 19)
        Me.CheckInAcive.TabIndex = 187
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.CheckInAcive, "Checked")
        '
        'txtModifiTime
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtModifiTime, "TextChanged")
        Me.txtModifiTime.EditValue = ""
        Me.txtModifiTime.EnterMoveNextControl = True
        Me.txtModifiTime.Location = New System.Drawing.Point(431, 48)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.txtModifiTime, True)
        Me.txtModifiTime.Name = "txtModifiTime"
        Me.txtModifiTime.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.txtModifiTime.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtModifiTime.Properties.Appearance.Options.UseBackColor = True
        Me.txtModifiTime.Properties.Appearance.Options.UseFont = True
        Me.txtModifiTime.Properties.MaxLength = 50
        Me.txtModifiTime.Properties.ReadOnly = True
        Me.txtModifiTime.Properties.ValidateOnEnterKey = True
        Me.txtModifiTime.Size = New System.Drawing.Size(160, 20)
        Me.txtModifiTime.TabIndex = 186
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtModifiTime, "Text")
        '
        'txtCreateTime
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtCreateTime, "TextChanged")
        Me.txtCreateTime.EditValue = ""
        Me.txtCreateTime.EnterMoveNextControl = True
        Me.txtCreateTime.Location = New System.Drawing.Point(431, 13)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.txtCreateTime, True)
        Me.txtCreateTime.Name = "txtCreateTime"
        Me.txtCreateTime.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.txtCreateTime.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCreateTime.Properties.Appearance.Options.UseBackColor = True
        Me.txtCreateTime.Properties.Appearance.Options.UseFont = True
        Me.txtCreateTime.Properties.MaxLength = 50
        Me.txtCreateTime.Properties.ReadOnly = True
        Me.txtCreateTime.Properties.ValidateOnEnterKey = True
        Me.txtCreateTime.Size = New System.Drawing.Size(160, 20)
        Me.txtCreateTime.TabIndex = 185
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtCreateTime, "Text")
        '
        'txtModifiBy
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtModifiBy, "TextChanged")
        Me.txtModifiBy.EditValue = ""
        Me.txtModifiBy.EnterMoveNextControl = True
        Me.txtModifiBy.Location = New System.Drawing.Point(155, 48)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.txtModifiBy, True)
        Me.txtModifiBy.Name = "txtModifiBy"
        Me.txtModifiBy.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.txtModifiBy.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtModifiBy.Properties.Appearance.Options.UseBackColor = True
        Me.txtModifiBy.Properties.Appearance.Options.UseFont = True
        Me.txtModifiBy.Properties.MaxLength = 50
        Me.txtModifiBy.Properties.ReadOnly = True
        Me.txtModifiBy.Properties.ValidateOnEnterKey = True
        Me.txtModifiBy.Size = New System.Drawing.Size(160, 20)
        Me.txtModifiBy.TabIndex = 184
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtModifiBy, "Text")
        '
        'txtCreateBy
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtCreateBy, "TextChanged")
        Me.txtCreateBy.EditValue = ""
        Me.txtCreateBy.EnterMoveNextControl = True
        Me.txtCreateBy.Location = New System.Drawing.Point(155, 13)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.txtCreateBy, True)
        Me.txtCreateBy.Name = "txtCreateBy"
        Me.txtCreateBy.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.txtCreateBy.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCreateBy.Properties.Appearance.Options.UseBackColor = True
        Me.txtCreateBy.Properties.Appearance.Options.UseFont = True
        Me.txtCreateBy.Properties.MaxLength = 50
        Me.txtCreateBy.Properties.ReadOnly = True
        Me.txtCreateBy.Properties.ValidateOnEnterKey = True
        Me.txtCreateBy.Size = New System.Drawing.Size(160, 20)
        Me.txtCreateBy.TabIndex = 183
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtCreateBy, "Text")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label7, "")
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(364, 51)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label7, True)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 14)
        Me.Label7.TabIndex = 182
        Me.Label7.Text = "แก้ไขเมื่อ"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label7, "")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label3, "")
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(68, 51)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label3, True)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 14)
        Me.Label3.TabIndex = 181
        Me.Label3.Text = "แก้ไขล่าสุดโดย"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label3, "")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label2, "")
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(364, 16)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label2, True)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 14)
        Me.Label2.TabIndex = 180
        Me.Label2.Text = "สร้างเมื่อ"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label2, "")
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label36, "")
        Me.Label36.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label36.Location = New System.Drawing.Point(68, 16)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label36, True)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(38, 14)
        Me.Label36.TabIndex = 179
        Me.Label36.Text = "ผู้สร้าง"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label36, "")
        '
        'GroupAction
        '
        Me.GroupAction.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.GroupAction, "")
        Me.GroupAction.Controls.Add(Me.CheckConvert)
        Me.GroupAction.Controls.Add(Me.CheckAssign)
        Me.GroupAction.Controls.Add(Me.CheckCopy)
        Me.GroupAction.Controls.Add(Me.CheckCreateQuick)
        Me.GroupAction.Controls.Add(Me.CheckImport)
        Me.GroupAction.Location = New System.Drawing.Point(349, 319)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.GroupAction, True)
        Me.GroupAction.Name = "GroupAction"
        Me.GroupAction.Size = New System.Drawing.Size(596, 55)
        Me.GroupAction.TabIndex = 20
        Me.GroupAction.Text = "Action"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.GroupAction, "")
        '
        'CheckConvert
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.CheckConvert, "CheckedChanged")
        Me.CheckConvert.Location = New System.Drawing.Point(439, 25)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.CheckConvert, True)
        Me.CheckConvert.Name = "CheckConvert"
        Me.CheckConvert.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckConvert.Properties.Appearance.Options.UseFont = True
        Me.CheckConvert.Properties.Caption = "Convert"
        Me.CheckConvert.Size = New System.Drawing.Size(70, 19)
        Me.CheckConvert.TabIndex = 14
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.CheckConvert, "Checked")
        '
        'CheckAssign
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.CheckAssign, "CheckedChanged")
        Me.CheckAssign.Location = New System.Drawing.Point(335, 25)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.CheckAssign, True)
        Me.CheckAssign.Name = "CheckAssign"
        Me.CheckAssign.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckAssign.Properties.Appearance.Options.UseFont = True
        Me.CheckAssign.Properties.Caption = "Assign"
        Me.CheckAssign.Size = New System.Drawing.Size(70, 19)
        Me.CheckAssign.TabIndex = 13
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.CheckAssign, "Checked")
        '
        'CheckCopy
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.CheckCopy, "CheckedChanged")
        Me.CheckCopy.Location = New System.Drawing.Point(229, 25)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.CheckCopy, True)
        Me.CheckCopy.Name = "CheckCopy"
        Me.CheckCopy.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckCopy.Properties.Appearance.Options.UseFont = True
        Me.CheckCopy.Properties.Caption = "Copy"
        Me.CheckCopy.Size = New System.Drawing.Size(70, 19)
        Me.CheckCopy.TabIndex = 12
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.CheckCopy, "Checked")
        '
        'CheckCreateQuick
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.CheckCreateQuick, "CheckedChanged")
        Me.CheckCreateQuick.Location = New System.Drawing.Point(119, 25)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.CheckCreateQuick, True)
        Me.CheckCreateQuick.Name = "CheckCreateQuick"
        Me.CheckCreateQuick.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckCreateQuick.Properties.Appearance.Options.UseFont = True
        Me.CheckCreateQuick.Properties.Caption = "Create Quick"
        Me.CheckCreateQuick.Size = New System.Drawing.Size(104, 19)
        Me.CheckCreateQuick.TabIndex = 11
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.CheckCreateQuick, "Checked")
        '
        'CheckImport
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.CheckImport, "CheckedChanged")
        Me.CheckImport.Location = New System.Drawing.Point(16, 25)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.CheckImport, True)
        Me.CheckImport.Name = "CheckImport"
        Me.CheckImport.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckImport.Properties.Appearance.Options.UseFont = True
        Me.CheckImport.Properties.Caption = "Import"
        Me.CheckImport.Size = New System.Drawing.Size(70, 19)
        Me.CheckImport.TabIndex = 10
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.CheckImport, "Checked")
        '
        'btnSelectAll
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnSelectAll, "")
        Me.btnSelectAll.Location = New System.Drawing.Point(367, 399)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnSelectAll, True)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(82, 23)
        Me.btnSelectAll.TabIndex = 21
        Me.btnSelectAll.Text = "Select All"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnSelectAll, "")
        '
        'btnUnAll
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnUnAll, "")
        Me.btnUnAll.Location = New System.Drawing.Point(490, 399)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnUnAll, True)
        Me.btnUnAll.Name = "btnUnAll"
        Me.btnUnAll.Size = New System.Drawing.Size(82, 23)
        Me.btnUnAll.TabIndex = 22
        Me.btnUnAll.Text = "Unselect All"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnUnAll, "")
        '
        'FormChangedComponent1
        '
        '
        'frmPrivilege
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 494)
        Me.Controls.Add(Me.btnUnAll)
        Me.Controls.Add(Me.btnSelectAll)
        Me.Controls.Add(Me.GroupAction)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.GroupEvent)
        Me.Controls.Add(Me.GroupDisplay)
        Me.Controls.Add(Me.GridControl)
        Me.Name = "frmPrivilege"
        Me.Text = "frmPrivilege"
        Me.Controls.SetChildIndex(Me.GridControl, 0)
        Me.Controls.SetChildIndex(Me.GroupDisplay, 0)
        Me.Controls.SetChildIndex(Me.GroupEvent, 0)
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        Me.Controls.SetChildIndex(Me.GroupAction, 0)
        Me.Controls.SetChildIndex(Me.btnSelectAll, 0)
        Me.Controls.SetChildIndex(Me.btnUnAll, 0)
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupDisplay.ResumeLayout(False)
        CType(Me.CheckEnable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckVisible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupEvent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupEvent.ResumeLayout(False)
        CType(Me.CheckPrint.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckDelete.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckAdd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.GeneralTabPage.ResumeLayout(False)
        Me.GeneralTabPage.PerformLayout()
        CType(Me.txtRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtThai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AdminTabPage.ResumeLayout(False)
        Me.AdminTabPage.PerformLayout()
        CType(Me.CheckInAcive.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtModifiTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCreateTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtModifiBy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCreateBy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupAction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupAction.ResumeLayout(False)
        CType(Me.CheckConvert.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckAssign.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckCopy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckCreateQuick.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckImport.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupDisplay As DevExpress.XtraEditors.GroupControl
    Friend WithEvents CheckEnable As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckVisible As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GroupEvent As DevExpress.XtraEditors.GroupControl
    Friend WithEvents CheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckAdd As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents GeneralTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtRemark As DevExpress.XtraEditors.MemoEdit
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtThai As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AdminTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents CheckPrint As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckDelete As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GroupAction As DevExpress.XtraEditors.GroupControl
    Friend WithEvents CheckConvert As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckAssign As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckCopy As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckCreateQuick As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckImport As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnSelectAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnUnAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CheckInAcive As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtModifiTime As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCreateTime As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtModifiBy As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCreateBy As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents FormChangedComponent1 As FormChangedComponent

End Class
