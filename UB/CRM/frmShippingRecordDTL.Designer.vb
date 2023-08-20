<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmShippingRecordDTL
    Inherits DevExpress.XtraEditors.XtraForm

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShippingRecordDTL))
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.ShippingRemark = New DevExpress.XtraEditors.MemoEdit()
        Me.ShippingEmp = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ShippingMethod = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ShippingPeriod = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ShippingStatus = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.กำหนดเวลาส่ง = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.AssignDate = New DevExpress.XtraEditors.DateEdit()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.ShippingRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShippingEmp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShippingMethod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShippingPeriod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShippingStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.กำหนดเวลาส่ง, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssignDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssignDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection1.Images.SetKeyName(0, "_active__no.png")
        Me.ImageCollection1.Images.SetKeyName(1, "1394817194_stock_insert-slide.png")
        '
        'btnOK
        '
        Me.btnOK.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnOK.Appearance.Options.UseFont = True
        Me.btnOK.Appearance.Options.UseImage = True
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.ImageOptions.Image = CType(resources.GetObject("btnOK.ImageOptions.Image"), System.Drawing.Image)
        Me.btnOK.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnOK.Location = New System.Drawing.Point(554, 12)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(82, 31)
        Me.btnOK.TabIndex = 6
        Me.btnOK.Text = "ตกลง"
        Me.btnOK.ToolTip = "ตกลง"
        '
        'btnCancel
        '
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.Appearance.Options.UseImage = True
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.ImageOptions.Image = CType(resources.GetObject("btnCancel.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCancel.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnCancel.Location = New System.Drawing.Point(554, 51)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(82, 31)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "ยกเลิก"
        Me.btnCancel.ToolTip = "ยกเลิก"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.AssignDate)
        Me.LayoutControl1.Controls.Add(Me.ShippingRemark)
        Me.LayoutControl1.Controls.Add(Me.ShippingEmp)
        Me.LayoutControl1.Controls.Add(Me.ShippingMethod)
        Me.LayoutControl1.Controls.Add(Me.ShippingPeriod)
        Me.LayoutControl1.Controls.Add(Me.ShippingStatus)
        Me.LayoutControl1.Location = New System.Drawing.Point(16, 2)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(532, 223)
        Me.LayoutControl1.TabIndex = 334
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'ShippingRemark
        '
        Me.ShippingRemark.EnterMoveNextControl = True
        Me.ShippingRemark.Location = New System.Drawing.Point(90, 132)
        Me.ShippingRemark.Name = "ShippingRemark"
        Me.ShippingRemark.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ShippingRemark.Properties.Appearance.Options.UseFont = True
        Me.ShippingRemark.Properties.MaxLength = 100
        Me.ShippingRemark.Size = New System.Drawing.Size(430, 69)
        Me.ShippingRemark.StyleController = Me.LayoutControl1
        Me.ShippingRemark.TabIndex = 321
        '
        'ShippingEmp
        '
        Me.ShippingEmp.EnterMoveNextControl = True
        Me.ShippingEmp.Location = New System.Drawing.Point(90, 36)
        Me.ShippingEmp.Name = "ShippingEmp"
        Me.ShippingEmp.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShippingEmp.Properties.Appearance.Options.UseFont = True
        Me.ShippingEmp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ShippingEmp.Properties.NullText = ""
        Me.ShippingEmp.Properties.PopupView = Me.GridView1
        Me.ShippingEmp.Size = New System.Drawing.Size(430, 20)
        Me.ShippingEmp.StyleController = Me.LayoutControl1
        Me.ShippingEmp.TabIndex = 7
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn5, Me.GridColumn6})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "รหัส"
        Me.GridColumn1.FieldName = " ID"
        Me.GridColumn1.Name = "GridColumn1"
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
        'ShippingMethod
        '
        Me.ShippingMethod.EditValue = CType(0, Short)
        Me.ShippingMethod.Location = New System.Drawing.Point(90, 84)
        Me.ShippingMethod.Name = "ShippingMethod"
        Me.ShippingMethod.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.ShippingMethod.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShippingMethod.Properties.Appearance.Options.UseFont = True
        Me.ShippingMethod.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ShippingMethod.Properties.ImmediatePopup = True
        Me.ShippingMethod.Properties.NullText = "[EditValue is null]"
        Me.ShippingMethod.Properties.PopupFormSize = New System.Drawing.Size(300, 0)
        Me.ShippingMethod.Properties.PopupSizeable = True
        Me.ShippingMethod.Size = New System.Drawing.Size(430, 20)
        Me.ShippingMethod.StyleController = Me.LayoutControl1
        Me.ShippingMethod.TabIndex = 25
        '
        'ShippingPeriod
        '
        Me.ShippingPeriod.EditValue = CType(0, Short)
        Me.ShippingPeriod.Location = New System.Drawing.Point(90, 60)
        Me.ShippingPeriod.Name = "ShippingPeriod"
        Me.ShippingPeriod.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.ShippingPeriod.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShippingPeriod.Properties.Appearance.Options.UseFont = True
        Me.ShippingPeriod.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ShippingPeriod.Properties.ImmediatePopup = True
        Me.ShippingPeriod.Properties.NullText = "[EditValue is null]"
        Me.ShippingPeriod.Properties.PopupFormSize = New System.Drawing.Size(300, 0)
        Me.ShippingPeriod.Properties.PopupSizeable = True
        Me.ShippingPeriod.Size = New System.Drawing.Size(430, 20)
        Me.ShippingPeriod.StyleController = Me.LayoutControl1
        Me.ShippingPeriod.TabIndex = 24
        '
        'ShippingStatus
        '
        Me.ShippingStatus.EditValue = CType(0, Short)
        Me.ShippingStatus.Location = New System.Drawing.Point(90, 108)
        Me.ShippingStatus.Name = "ShippingStatus"
        Me.ShippingStatus.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.ShippingStatus.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShippingStatus.Properties.Appearance.Options.UseFont = True
        Me.ShippingStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ShippingStatus.Properties.ImmediatePopup = True
        Me.ShippingStatus.Properties.NullText = "[EditValue is null]"
        Me.ShippingStatus.Properties.PopupFormSize = New System.Drawing.Size(300, 0)
        Me.ShippingStatus.Properties.PopupSizeable = True
        Me.ShippingStatus.Size = New System.Drawing.Size(430, 20)
        Me.ShippingStatus.StyleController = Me.LayoutControl1
        Me.ShippingStatus.TabIndex = 26
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.กำหนดเวลาส่ง, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.EmptySpaceItem1, Me.LayoutControlItem2})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(532, 223)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.ShippingEmp
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(512, 24)
        Me.LayoutControlItem1.Text = "ผู้ส่ง"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(66, 13)
        '
        'กำหนดเวลาส่ง
        '
        Me.กำหนดเวลาส่ง.Control = Me.ShippingPeriod
        Me.กำหนดเวลาส่ง.Location = New System.Drawing.Point(0, 48)
        Me.กำหนดเวลาส่ง.Name = "กำหนดเวลาส่ง"
        Me.กำหนดเวลาส่ง.Size = New System.Drawing.Size(512, 24)
        Me.กำหนดเวลาส่ง.TextSize = New System.Drawing.Size(66, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.ShippingMethod
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(512, 24)
        Me.LayoutControlItem3.Text = "ลักษณะงาน"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(66, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.ShippingStatus
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(512, 24)
        Me.LayoutControlItem4.Text = "สถานะ"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(66, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.ShippingRemark
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(512, 73)
        Me.LayoutControlItem5.Text = "หมายเหตุ"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(66, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 193)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(512, 10)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'AssignDate
        '
        Me.AssignDate.EditValue = Nothing
        Me.AssignDate.Location = New System.Drawing.Point(90, 12)
        Me.AssignDate.Name = "AssignDate"
        Me.AssignDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AssignDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AssignDate.Size = New System.Drawing.Size(430, 20)
        Me.AssignDate.StyleController = Me.LayoutControl1
        Me.AssignDate.TabIndex = 336
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.AssignDate
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(512, 24)
        Me.LayoutControlItem2.Text = "วันที่ Assign"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(66, 13)
        '
        'frmShippingRecordDTL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(644, 237)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.Icon = CType(resources.GetObject("frmShippingRecordDTL.IconOptions.Icon"), System.Drawing.Icon)
        Me.IconOptions.Image = CType(resources.GetObject("frmShippingRecordDTL.IconOptions.Image"), System.Drawing.Image)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmShippingRecordDTL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Assign To"
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.ShippingRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShippingEmp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShippingMethod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShippingPeriod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShippingStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.กำหนดเวลาส่ง, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssignDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssignDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ShippingEmp As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents กำหนดเวลาส่ง As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ShippingRemark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ShippingMethod As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ShippingPeriod As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ShippingStatus As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents AssignDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
End Class
