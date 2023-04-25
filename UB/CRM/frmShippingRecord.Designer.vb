<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmShippingRecord
    Inherits iEditForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShippingRecord))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnAssign = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFind = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDateTo = New DevExpress.XtraEditors.DateEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDateFrom = New DevExpress.XtraEditors.DateEdit()
        Me.GridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.dtpDateTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDateTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDateFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDateFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.btnAssign)
        Me.GroupControl1.Controls.Add(Me.btnFind)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.dtpDateTo)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.dtpDateFrom)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 50)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1313, 78)
        Me.GroupControl1.TabIndex = 16
        Me.GroupControl1.Text = "Filter data"
        '
        'btnAssign
        '
        Me.btnAssign.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnAssign.Appearance.Options.UseFont = True
        Me.btnAssign.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAssign.Location = New System.Drawing.Point(635, 37)
        Me.btnAssign.Name = "btnAssign"
        Me.btnAssign.Size = New System.Drawing.Size(102, 23)
        Me.btnAssign.TabIndex = 296
        Me.btnAssign.TabStop = False
        Me.btnAssign.Text = "Assign To"
        Me.btnAssign.ToolTip = "Assign To"
        '
        'btnFind
        '
        Me.btnFind.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnFind.Appearance.Options.UseFont = True
        Me.btnFind.Appearance.Options.UseImage = True
        Me.btnFind.ImageOptions.Image = CType(resources.GetObject("btnFind.ImageOptions.Image"), System.Drawing.Image)
        Me.btnFind.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnFind.Location = New System.Drawing.Point(407, 36)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(101, 24)
        Me.btnFind.TabIndex = 295
        Me.btnFind.TabStop = False
        Me.btnFind.Text = "โหลดข้อมูล"
        Me.btnFind.ToolTip = "โหลดข้อมูล"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(227, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 14)
        Me.Label1.TabIndex = 294
        Me.Label1.Text = "ถึง"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.EditValue = New Date(2012, 4, 20, 0, 0, 0, 0)
        Me.dtpDateTo.EnterMoveNextControl = True
        Me.dtpDateTo.Location = New System.Drawing.Point(247, 38)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.dtpDateTo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpDateTo.Properties.Appearance.Options.UseFont = True
        Me.dtpDateTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpDateTo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpDateTo.Properties.DisplayFormat.FormatString = "D"
        Me.dtpDateTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpDateTo.Properties.EditFormat.FormatString = "D"
        Me.dtpDateTo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpDateTo.Properties.MaskSettings.Set("mask", "D")
        Me.dtpDateTo.Size = New System.Drawing.Size(143, 20)
        Me.dtpDateTo.TabIndex = 130
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 14)
        Me.Label3.TabIndex = 129
        Me.Label3.Text = "วันที่"
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.EditValue = New Date(2012, 4, 20, 0, 0, 0, 0)
        Me.dtpDateFrom.EnterMoveNextControl = True
        Me.dtpDateFrom.Location = New System.Drawing.Point(78, 38)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.dtpDateFrom.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpDateFrom.Properties.Appearance.Options.UseFont = True
        Me.dtpDateFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpDateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpDateFrom.Properties.DisplayFormat.FormatString = "D"
        Me.dtpDateFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpDateFrom.Properties.EditFormat.FormatString = "D"
        Me.dtpDateFrom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpDateFrom.Properties.MaskSettings.Set("mask", "D")
        Me.dtpDateFrom.Size = New System.Drawing.Size(143, 20)
        Me.dtpDateFrom.TabIndex = 128
        '
        'GridControl
        '
        Me.GridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl.Location = New System.Drawing.Point(12, 134)
        Me.GridControl.MainView = Me.GridView
        Me.GridControl.Name = "GridControl"
        Me.GridControl.Size = New System.Drawing.Size(1313, 422)
        Me.GridControl.TabIndex = 18
        Me.GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
        '
        'GridView
        '
        Me.GridView.GridControl = Me.GridControl
        Me.GridView.Name = "GridView"
        Me.GridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView.OptionsFind.AlwaysVisible = True
        Me.GridView.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.Panel
        Me.GridView.OptionsLayout.Columns.AddNewColumns = False
        Me.GridView.OptionsLayout.Columns.RemoveOldColumns = False
        Me.GridView.OptionsSelection.CheckBoxSelectorColumnWidth = 50
        Me.GridView.OptionsSelection.CheckBoxSelectorField = "IsSelect"
        Me.GridView.OptionsSelection.MultiSelect = True
        Me.GridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.GridView.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView.OptionsView.ShowViewCaption = True
        '
        'frmShippingRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1337, 563)
        Me.Controls.Add(Me.GridControl)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "frmShippingRecord"
        Me.Text = "บันทึกส่งของ"
        Me.Controls.SetChildIndex(Me.GroupControl1, 0)
        Me.Controls.SetChildIndex(Me.GridControl, 0)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.dtpDateTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDateTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDateFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDateFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnFind As DevExpress.XtraEditors.SimpleButton
    Private WithEvents Label1 As Label
    Friend WithEvents dtpDateTo As DevExpress.XtraEditors.DateEdit
    Private WithEvents Label3 As Label
    Friend WithEvents dtpDateFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnAssign As DevExpress.XtraEditors.SimpleButton
End Class
