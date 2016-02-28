<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProvince
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProvince))
        Me.txtNameEng = New DevExpress.XtraEditors.TextEdit()
        Me.txtNameThai = New DevExpress.XtraEditors.TextEdit()
        Me.txtCode = New DevExpress.XtraEditors.TextEdit()
        Me.txtRemark = New DevExpress.XtraEditors.MemoEdit()
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.cboGeo = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.cboGeoView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.GeneralTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AdminTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcAdmin1 = New UB.ucAdmin()
        Me.FormChangedComponent1 = New UB.FormChangedComponent(Me.components)
        CType(Me.txtNameEng.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNameThai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGeo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGeoView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.GeneralTabPage.SuspendLayout()
        Me.AdminTabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNameEng
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtNameEng, "TextChanged")
        Me.txtNameEng.EditValue = ""
        Me.txtNameEng.EnterMoveNextControl = True
        Me.txtNameEng.Location = New System.Drawing.Point(148, 73)
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
        Me.txtNameThai.Location = New System.Drawing.Point(148, 47)
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
        'txtCode
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtCode, "TextChanged")
        Me.txtCode.EditValue = ""
        Me.txtCode.EnterMoveNextControl = True
        Me.txtCode.Location = New System.Drawing.Point(148, 309)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.txtCode, True)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCode.Properties.Appearance.Options.UseFont = True
        Me.txtCode.Properties.MaxLength = 20
        Me.txtCode.Properties.ValidateOnEnterKey = True
        Me.txtCode.Size = New System.Drawing.Size(155, 20)
        Me.txtCode.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtCode, "Text")
        Me.txtCode.Visible = False
        '
        'txtRemark
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtRemark, "TextChanged")
        Me.txtRemark.EditValue = ""
        Me.txtRemark.EnterMoveNextControl = True
        Me.txtRemark.Location = New System.Drawing.Point(148, 100)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.txtRemark, True)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRemark.Properties.Appearance.Options.UseFont = True
        Me.txtRemark.Properties.MaxLength = 100
        Me.txtRemark.Size = New System.Drawing.Size(273, 92)
        Me.txtRemark.TabIndex = 3
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtRemark, "Text")
        '
        'btnRefresh
        '
        Me.btnRefresh.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRefresh.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnRefresh, "")
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefresh.Location = New System.Drawing.Point(423, 283)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnRefresh, True)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(21, 21)
        Me.btnRefresh.TabIndex = 186
        Me.btnRefresh.TabStop = False
        Me.btnRefresh.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnRefresh, "")
        Me.btnRefresh.Visible = False
        '
        'cboGeo
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.cboGeo, "TextChanged")
        Me.cboGeo.EnterMoveNextControl = True
        Me.cboGeo.Location = New System.Drawing.Point(148, 283)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.cboGeo, True)
        Me.cboGeo.Name = "cboGeo"
        Me.cboGeo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGeo.Properties.Appearance.Options.UseFont = True
        Me.cboGeo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboGeo.Properties.NullText = ""
        Me.cboGeo.Properties.ValidateOnEnterKey = True
        Me.cboGeo.Properties.View = Me.cboGeoView
        Me.cboGeo.Size = New System.Drawing.Size(273, 20)
        Me.cboGeo.TabIndex = 2
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.cboGeo, "Text")
        Me.cboGeo.Visible = False
        '
        'cboGeoView
        '
        Me.cboGeoView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ID, Me.NAME})
        Me.cboGeoView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.cboGeoView.Name = "cboGeoView"
        Me.cboGeoView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.cboGeoView.OptionsView.ShowGroupPanel = False
        '
        'ID
        '
        Me.ID.Caption = "GridColumn1"
        Me.ID.FieldName = "ID"
        Me.ID.Name = "ID"
        '
        'NAME
        '
        Me.NAME.Caption = "ภาค"
        Me.NAME.FieldName = "NAME"
        Me.NAME.Name = "NAME"
        Me.NAME.Visible = True
        Me.NAME.VisibleIndex = 0
        '
        'XtraTabControl1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.XtraTabControl1, "")
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 37)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.XtraTabControl1, True)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.GeneralTabPage
        Me.XtraTabControl1.Size = New System.Drawing.Size(816, 447)
        Me.XtraTabControl1.TabIndex = 6
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.GeneralTabPage, Me.AdminTabPage})
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.XtraTabControl1, "")
        '
        'GeneralTabPage
        '
        Me.GeneralTabPage.Appearance.PageClient.BackColor = System.Drawing.Color.LightGray
        Me.GeneralTabPage.Appearance.PageClient.Options.UseBackColor = True
        Me.GeneralTabPage.AutoScroll = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.GeneralTabPage, "")
        Me.GeneralTabPage.Controls.Add(Me.cboGeo)
        Me.GeneralTabPage.Controls.Add(Me.Label10)
        Me.GeneralTabPage.Controls.Add(Me.btnRefresh)
        Me.GeneralTabPage.Controls.Add(Me.Label1)
        Me.GeneralTabPage.Controls.Add(Me.txtNameEng)
        Me.GeneralTabPage.Controls.Add(Me.txtNameThai)
        Me.GeneralTabPage.Controls.Add(Me.txtCode)
        Me.GeneralTabPage.Controls.Add(Me.Label8)
        Me.GeneralTabPage.Controls.Add(Me.Label4)
        Me.GeneralTabPage.Controls.Add(Me.Label5)
        Me.GeneralTabPage.Controls.Add(Me.txtRemark)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.GeneralTabPage, True)
        Me.GeneralTabPage.Name = "GeneralTabPage"
        Me.GeneralTabPage.Size = New System.Drawing.Size(810, 419)
        Me.GeneralTabPage.Text = "ข้อมูลทั่วไป"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.GeneralTabPage, "")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label10, "")
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(46, 286)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label10, True)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 14)
        Me.Label10.TabIndex = 187
        Me.Label10.Text = "ภาค"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label10, "")
        Me.Label10.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label1, "")
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(46, 50)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label1, True)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 14)
        Me.Label1.TabIndex = 148
        Me.Label1.Text = "จังหวัด"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label1, "")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label8, "")
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(46, 82)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label8, True)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 14)
        Me.Label8.TabIndex = 109
        Me.Label8.Text = "จังหวัด (Eng)"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label8, "")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label4, "")
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(46, 312)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label4, True)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 14)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "รหัส"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label4, "")
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label5, "")
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 109)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label5, True)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 14)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "รายละเอียด"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label5, "")
        '
        'AdminTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.AdminTabPage, "")
        Me.AdminTabPage.Controls.Add(Me.UcAdmin1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.AdminTabPage, True)
        Me.AdminTabPage.Name = "AdminTabPage"
        Me.AdminTabPage.Size = New System.Drawing.Size(810, 419)
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
        'frmProvince
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 484)
        Me.Controls.Add(Me.XtraTabControl1)
        'Me.NAME = "frmProvince"
        Me.Text = "frmProvince"
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.txtNameEng.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNameThai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGeo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGeoView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.GeneralTabPage.ResumeLayout(False)
        Me.GeneralTabPage.PerformLayout()
        Me.AdminTabPage.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents GeneralTabPage As DevExpress.XtraTab.XtraTabPage
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNameEng As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNameThai As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRemark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents AdminTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcAdmin1 As ucAdmin
    Private WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboGeo As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents cboGeoView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FormChangedComponent1 As FormChangedComponent
    Friend WithEvents ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NAME As DevExpress.XtraGrid.Columns.GridColumn

End Class
