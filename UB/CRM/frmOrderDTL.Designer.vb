<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderDTL
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrderDTL))
        Me.btnFind = New DevExpress.XtraEditors.SimpleButton()
        Me.ProductName = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutProductName = New DevExpress.XtraLayout.LayoutControlItem()
        Me.UnitMainID = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView14 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn43 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn44 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CodeEng = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn45 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.ProductName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutProductName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitMainID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFind
        '
        Me.btnFind.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnFind.Appearance.Options.UseFont = True
        Me.btnFind.Appearance.Options.UseImage = True
        Me.btnFind.Image = CType(resources.GetObject("btnFind.Image"), System.Drawing.Image)
        Me.btnFind.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnFind.Location = New System.Drawing.Point(425, 12)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(34, 30)
        Me.btnFind.StyleController = Me.LayoutControl1
        Me.btnFind.TabIndex = 343
        Me.btnFind.TabStop = False
        Me.btnFind.ToolTip = "ค้นหา"
        '
        'ProductName
        '
        Me.ProductName.EditValue = ""
        Me.ProductName.EnterMoveNextControl = True
        Me.ProductName.Location = New System.Drawing.Point(112, 36)
        Me.ProductName.Name = "ProductName"
        Me.ProductName.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.ProductName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ProductName.Properties.Appearance.Options.UseBackColor = True
        Me.ProductName.Properties.Appearance.Options.UseFont = True
        Me.ProductName.Properties.MaxLength = 50
        Me.ProductName.Properties.ReadOnly = True
        Me.ProductName.Properties.ValidateOnEnterKey = True
        Me.ProductName.Size = New System.Drawing.Size(309, 20)
        Me.ProductName.StyleController = Me.LayoutControl1
        Me.ProductName.TabIndex = 344
        Me.ProductName.TabStop = False
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.UnitMainID)
        Me.LayoutControl1.Controls.Add(Me.ProductName)
        Me.LayoutControl1.Controls.Add(Me.btnFind)
        Me.LayoutControl1.Location = New System.Drawing.Point(22, 12)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(471, 219)
        Me.LayoutControl1.TabIndex = 1
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutProductName, Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(471, 219)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.btnFind
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(413, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(38, 199)
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutProductName
        '
        Me.LayoutProductName.Control = Me.ProductName
        Me.LayoutProductName.CustomizationFormText = "ชื่อสินค้า"
        Me.LayoutProductName.Location = New System.Drawing.Point(0, 24)
        Me.LayoutProductName.Name = "LayoutProductName"
        Me.LayoutProductName.Size = New System.Drawing.Size(413, 175)
        Me.LayoutProductName.Text = "ชื่อสินค้า"
        Me.LayoutProductName.TextSize = New System.Drawing.Size(96, 13)
        '
        'UnitMainID
        '
        Me.UnitMainID.EnterMoveNextControl = True
        Me.UnitMainID.Location = New System.Drawing.Point(112, 12)
        Me.UnitMainID.Name = "UnitMainID"
        Me.UnitMainID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnitMainID.Properties.Appearance.Options.UseFont = True
        Me.UnitMainID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UnitMainID.Properties.NullText = ""
        Me.UnitMainID.Properties.View = Me.GridView14
        Me.UnitMainID.Size = New System.Drawing.Size(309, 20)
        Me.UnitMainID.StyleController = Me.LayoutControl1
        Me.UnitMainID.TabIndex = 14
        '
        'GridView14
        '
        Me.GridView14.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn43, Me.GridColumn44, Me.CodeEng, Me.GridColumn45})
        Me.GridView14.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView14.Name = "GridView14"
        Me.GridView14.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView14.OptionsView.ShowGroupPanel = False
        '
        'GridColumn43
        '
        Me.GridColumn43.Caption = "รหัสหน่วยนับ"
        Me.GridColumn43.FieldName = " ID"
        Me.GridColumn43.Name = "GridColumn43"
        '
        'GridColumn44
        '
        Me.GridColumn44.Caption = "ชื่อหน่วยนับ"
        Me.GridColumn44.FieldName = "CodeThai"
        Me.GridColumn44.Name = "GridColumn44"
        Me.GridColumn44.Visible = True
        Me.GridColumn44.VisibleIndex = 0
        '
        'CodeEng
        '
        Me.CodeEng.Caption = "GridColumn46"
        Me.CodeEng.Name = "CodeEng"
        '
        'GridColumn45
        '
        Me.GridColumn45.Caption = "รายละเอียด"
        Me.GridColumn45.FieldName = "Remark "
        Me.GridColumn45.Name = "GridColumn45"
        Me.GridColumn45.Visible = True
        Me.GridColumn45.VisibleIndex = 1
        Me.GridColumn45.Width = 100
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.UnitMainID
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(413, 24)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(96, 13)
        '
        'frmOrderDTL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 396)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmOrderDTL"
        Me.Text = "frmOrderDTL"
        CType(Me.ProductName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutProductName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitMainID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnFind As DevExpress.XtraEditors.SimpleButton
    Private WithEvents ProductName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutProductName As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents UnitMainID As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView14 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn43 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn44 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CodeEng As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn45 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
End Class
