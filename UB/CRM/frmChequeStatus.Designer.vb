<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChequeStatus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChequeStatus))
        Me.UcCheque1 = New UB.ucCheque()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.ChequeDateTo = New DevExpress.XtraEditors.DateEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ChequeDateFrom = New DevExpress.XtraEditors.DateEdit()
        Me.BankID = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NameThai = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnFind = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.ChequeDateTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChequeDateTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChequeDateFrom.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChequeDateFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UcCheque1
        '
        Me.UcCheque1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcCheque1.Location = New System.Drawing.Point(12, 118)
        Me.UcCheque1.Name = "UcCheque1"
        Me.UcCheque1.Size = New System.Drawing.Size(650, 270)
        Me.UcCheque1.TabIndex = 4
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.btnFind)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.ChequeDateTo)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.ChequeDateFrom)
        Me.GroupControl1.Controls.Add(Me.BankID)
        Me.GroupControl1.Controls.Add(Me.Label10)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 43)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(650, 69)
        Me.GroupControl1.TabIndex = 5
        Me.GroupControl1.Text = "GroupControl1"
        '
        'ChequeDateTo
        '
        Me.ChequeDateTo.EditValue = New Date(2012, 4, 20, 0, 0, 0, 0)
        Me.ChequeDateTo.EnterMoveNextControl = True
        Me.ChequeDateTo.Location = New System.Drawing.Point(281, 37)
        Me.ChequeDateTo.Name = "ChequeDateTo"
        Me.ChequeDateTo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChequeDateTo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ChequeDateTo.Properties.Appearance.Options.UseFont = True
        Me.ChequeDateTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ChequeDateTo.Properties.DisplayFormat.FormatString = "D"
        Me.ChequeDateTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ChequeDateTo.Properties.EditFormat.FormatString = "D"
        Me.ChequeDateTo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ChequeDateTo.Properties.Mask.EditMask = "D"
        Me.ChequeDateTo.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ChequeDateTo.Size = New System.Drawing.Size(143, 20)
        Me.ChequeDateTo.TabIndex = 130
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 14)
        Me.Label3.TabIndex = 129
        Me.Label3.Text = "วันที่ทำเช็ค"
        '
        'ChequeDateFrom
        '
        Me.ChequeDateFrom.EditValue = New Date(2012, 4, 20, 0, 0, 0, 0)
        Me.ChequeDateFrom.EnterMoveNextControl = True
        Me.ChequeDateFrom.Location = New System.Drawing.Point(112, 37)
        Me.ChequeDateFrom.Name = "ChequeDateFrom"
        Me.ChequeDateFrom.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChequeDateFrom.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ChequeDateFrom.Properties.Appearance.Options.UseFont = True
        Me.ChequeDateFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ChequeDateFrom.Properties.DisplayFormat.FormatString = "D"
        Me.ChequeDateFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ChequeDateFrom.Properties.EditFormat.FormatString = "D"
        Me.ChequeDateFrom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ChequeDateFrom.Properties.Mask.EditMask = "D"
        Me.ChequeDateFrom.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ChequeDateFrom.Size = New System.Drawing.Size(143, 20)
        Me.ChequeDateFrom.TabIndex = 128
        '
        'BankID
        '
        Me.BankID.EnterMoveNextControl = True
        Me.BankID.Location = New System.Drawing.Point(112, 10)
        Me.BankID.Name = "BankID"
        Me.BankID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BankID.Properties.Appearance.Options.UseFont = True
        Me.BankID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BankID.Properties.NullText = ""
        Me.BankID.Properties.PopupFindMode = DevExpress.XtraEditors.FindMode.Always
        Me.BankID.Properties.View = Me.SearchLookUpEdit1View
        Me.BankID.Size = New System.Drawing.Size(312, 20)
        Me.BankID.TabIndex = 126
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.Code, Me.NameThai})
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
        Me.Code.Caption = "รหัสธนาคาร"
        Me.Code.FieldName = "Code"
        Me.Code.MaxWidth = 100
        Me.Code.MinWidth = 75
        Me.Code.Name = "Code"
        Me.Code.Visible = True
        Me.Code.VisibleIndex = 0
        '
        'NameThai
        '
        Me.NameThai.Caption = "ชื่อธนาคาร"
        Me.NameThai.FieldName = "NameThai"
        Me.NameThai.MinWidth = 200
        Me.NameThai.Name = "NameThai"
        Me.NameThai.Visible = True
        Me.NameThai.VisibleIndex = 1
        Me.NameThai.Width = 200
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(19, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 14)
        Me.Label10.TabIndex = 127
        Me.Label10.Text = "ธนาคาร"
        '
        'btnFind
        '
        Me.btnFind.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnFind.Appearance.Options.UseFont = True
        Me.btnFind.Appearance.Options.UseImage = True
        Me.btnFind.Image = CType(resources.GetObject("btnFind.Image"), System.Drawing.Image)
        Me.btnFind.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnFind.Location = New System.Drawing.Point(466, 22)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(101, 24)
        Me.btnFind.TabIndex = 295
        Me.btnFind.TabStop = False
        Me.btnFind.Text = "ค้นหา"
        Me.btnFind.ToolTip = "ค้นหา"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(261, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 14)
        Me.Label1.TabIndex = 294
        Me.Label1.Text = "ถึง"
        '
        'frmChequeStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 388)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.UcCheque1)
        Me.Name = "frmChequeStatus"
        Me.Text = "บันทึกเช็ค"
        Me.Controls.SetChildIndex(Me.UcCheque1, 0)
        Me.Controls.SetChildIndex(Me.GroupControl1, 0)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.ChequeDateTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChequeDateTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChequeDateFrom.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChequeDateFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcCheque1 As ucCheque
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BankID As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NameThai As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ChequeDateFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ChequeDateTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnFind As DevExpress.XtraEditors.SimpleButton
    Private WithEvents Label1 As System.Windows.Forms.Label
End Class
