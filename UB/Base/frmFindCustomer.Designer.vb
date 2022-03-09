<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFindCustomer
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFindCustomer))
        Me.GridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IsSelect = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.Code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CusName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Phone1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Fax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Email1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton()
        Me.CheckAll = New DevExpress.XtraEditors.CheckEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckAll.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl
        '
        Me.GridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl.Location = New System.Drawing.Point(0, 32)
        Me.GridControl.MainView = Me.GridView
        Me.GridControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl.Name = "GridControl"
        Me.GridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GridControl.Size = New System.Drawing.Size(1001, 393)
        Me.GridControl.TabIndex = 18
        Me.GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
        '
        'GridView
        '
        Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ID, Me.IsSelect, Me.Code, Me.CusName, Me.Type, Me.Phone1, Me.Fax, Me.Email1})
        Me.GridView.DetailHeight = 431
        Me.GridView.GridControl = Me.GridControl
        Me.GridView.Name = "GridView"
        Me.GridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView.OptionsFind.AlwaysVisible = True
        Me.GridView.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always
        Me.GridView.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.Panel
        Me.GridView.OptionsLayout.Columns.AddNewColumns = False
        Me.GridView.OptionsLayout.Columns.RemoveOldColumns = False
        Me.GridView.OptionsView.ShowGroupPanel = False
        Me.GridView.OptionsView.ShowViewCaption = True
        '
        'ID
        '
        Me.ID.Caption = "ID"
        Me.ID.FieldName = "ID"
        Me.ID.MinWidth = 23
        Me.ID.Name = "ID"
        Me.ID.Width = 87
        '
        'IsSelect
        '
        Me.IsSelect.Caption = "เลือก"
        Me.IsSelect.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.IsSelect.FieldName = "IsSelect"
        Me.IsSelect.MaxWidth = 93
        Me.IsSelect.MinWidth = 58
        Me.IsSelect.Name = "IsSelect"
        Me.IsSelect.Visible = True
        Me.IsSelect.VisibleIndex = 0
        Me.IsSelect.Width = 58
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepositoryItemCheckEdit1.ValueGrayed = True
        '
        'Code
        '
        Me.Code.Caption = "รหัสลุกค้า"
        Me.Code.FieldName = "Code"
        Me.Code.MaxWidth = 175
        Me.Code.MinWidth = 140
        Me.Code.Name = "Code"
        Me.Code.OptionsColumn.AllowEdit = False
        Me.Code.Visible = True
        Me.Code.VisibleIndex = 1
        Me.Code.Width = 152
        '
        'CusName
        '
        Me.CusName.Caption = "ชื่อ-สกุล"
        Me.CusName.FieldName = "CusName"
        Me.CusName.MinWidth = 233
        Me.CusName.Name = "CusName"
        Me.CusName.OptionsColumn.AllowEdit = False
        Me.CusName.Visible = True
        Me.CusName.VisibleIndex = 2
        Me.CusName.Width = 233
        '
        'Type
        '
        Me.Type.Caption = "ประเภท"
        Me.Type.FieldName = "Type"
        Me.Type.MaxWidth = 117
        Me.Type.MinWidth = 93
        Me.Type.Name = "Type"
        Me.Type.OptionsColumn.AllowEdit = False
        Me.Type.Visible = True
        Me.Type.VisibleIndex = 3
        Me.Type.Width = 93
        '
        'Phone1
        '
        Me.Phone1.Caption = "เบอร์โทร"
        Me.Phone1.FieldName = "Phone1"
        Me.Phone1.MaxWidth = 210
        Me.Phone1.MinWidth = 140
        Me.Phone1.Name = "Phone1"
        Me.Phone1.OptionsColumn.AllowEdit = False
        Me.Phone1.Visible = True
        Me.Phone1.VisibleIndex = 4
        Me.Phone1.Width = 147
        '
        'Fax
        '
        Me.Fax.Caption = "แฟกซ์"
        Me.Fax.FieldName = "Fax"
        Me.Fax.MaxWidth = 210
        Me.Fax.MinWidth = 140
        Me.Fax.Name = "Fax"
        Me.Fax.OptionsColumn.ReadOnly = True
        Me.Fax.Visible = True
        Me.Fax.VisibleIndex = 5
        Me.Fax.Width = 147
        '
        'Email1
        '
        Me.Email1.Caption = "อีเมล"
        Me.Email1.FieldName = "Email1"
        Me.Email1.MaxWidth = 292
        Me.Email1.MinWidth = 140
        Me.Email1.Name = "Email1"
        Me.Email1.OptionsColumn.AllowEdit = False
        Me.Email1.Visible = True
        Me.Email1.VisibleIndex = 6
        Me.Email1.Width = 149
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(902, 437)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(87, 28)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.Text = "Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(771, 437)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(87, 28)
        Me.btnOK.TabIndex = 19
        Me.btnOK.Text = "OK"
        '
        'CheckAll
        '
        Me.CheckAll.Location = New System.Drawing.Point(87, 9)
        Me.CheckAll.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckAll.Name = "CheckAll"
        Me.CheckAll.Properties.Caption = ""
        Me.CheckAll.Size = New System.Drawing.Size(31, 24)
        Me.CheckAll.TabIndex = 301
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 18)
        Me.Label5.TabIndex = 300
        Me.Label5.Text = "Select All"
        '
        'frmFindCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 475)
        Me.Controls.Add(Me.CheckAll)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.GridControl)
        Me.IconOptions.Icon = CType(resources.GetObject("frmFindCustomer.IconOptions.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmFindCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ค้นหา : Ctrl + F"
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckAll.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IsSelect As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CusName As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents bindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Phone1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Email1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Fax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckAll As DevExpress.XtraEditors.CheckEdit
    Private WithEvents Label5 As System.Windows.Forms.Label
End Class
