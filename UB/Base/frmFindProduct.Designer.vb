﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFindProduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFindProduct))
        Me.GridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ProductID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IsSelect = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.ProductCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProductName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PriceStandard = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.GridControl.Location = New System.Drawing.Point(0, 26)
        Me.GridControl.MainView = Me.GridView
        Me.GridControl.Name = "GridControl"
        Me.GridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GridControl.Size = New System.Drawing.Size(858, 390)
        Me.GridControl.TabIndex = 18
        Me.GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
        '
        'GridView
        '
        Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ProductID, Me.IsSelect, Me.ProductCode, Me.ProductName, Me.PriceStandard, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.GridView.GridControl = Me.GridControl
        Me.GridView.Name = "GridView"
        Me.GridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView.OptionsFind.AlwaysVisible = True
        Me.GridView.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always
        Me.GridView.OptionsLayout.Columns.AddNewColumns = False
        Me.GridView.OptionsLayout.Columns.RemoveOldColumns = False
        Me.GridView.OptionsView.ShowGroupPanel = False
        Me.GridView.OptionsView.ShowViewCaption = True
        '
        'ProductID
        '
        Me.ProductID.Caption = "ID"
        Me.ProductID.FieldName = "ProductID"
        Me.ProductID.Name = "ProductID"
        '
        'IsSelect
        '
        Me.IsSelect.Caption = "เลือก"
        Me.IsSelect.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.IsSelect.FieldName = "IsSelect"
        Me.IsSelect.MaxWidth = 80
        Me.IsSelect.Name = "IsSelect"
        Me.IsSelect.Visible = True
        Me.IsSelect.VisibleIndex = 0
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'ProductCode
        '
        Me.ProductCode.Caption = "รหัสสินค้า"
        Me.ProductCode.FieldName = "ProductCode"
        Me.ProductCode.MaxWidth = 200
        Me.ProductCode.MinWidth = 200
        Me.ProductCode.Name = "ProductCode"
        Me.ProductCode.OptionsColumn.AllowEdit = False
        Me.ProductCode.Visible = True
        Me.ProductCode.VisibleIndex = 1
        Me.ProductCode.Width = 200
        '
        'ProductName
        '
        Me.ProductName.Caption = "ชื่อสินค้า"
        Me.ProductName.FieldName = "ProductName"
        Me.ProductName.MaxWidth = 600
        Me.ProductName.MinWidth = 300
        Me.ProductName.Name = "ProductName"
        Me.ProductName.OptionsColumn.AllowEdit = False
        Me.ProductName.Visible = True
        Me.ProductName.VisibleIndex = 2
        Me.ProductName.Width = 500
        '
        'PriceStandard
        '
        Me.PriceStandard.Caption = "ราคา"
        Me.PriceStandard.DisplayFormat.FormatString = "n2"
        Me.PriceStandard.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PriceStandard.FieldName = "PriceStandard"
        Me.PriceStandard.MaxWidth = 300
        Me.PriceStandard.MinWidth = 100
        Me.PriceStandard.Name = "PriceStandard"
        Me.PriceStandard.OptionsColumn.AllowEdit = False
        Me.PriceStandard.Visible = True
        Me.PriceStandard.VisibleIndex = 3
        Me.PriceStandard.Width = 200
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "GridColumn1"
        Me.GridColumn1.FieldName = "Price1"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "GridColumn2"
        Me.GridColumn2.FieldName = "Price2"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "GridColumn3"
        Me.GridColumn3.FieldName = "Price3"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "GridColumn4"
        Me.GridColumn4.FieldName = "PriceInform"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(773, 422)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.Text = "Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(661, 422)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 19
        Me.btnOK.Text = "OK"
        '
        'CheckAll
        '
        Me.CheckAll.Location = New System.Drawing.Point(75, 7)
        Me.CheckAll.Name = "CheckAll"
        Me.CheckAll.Properties.Caption = ""
        Me.CheckAll.Size = New System.Drawing.Size(27, 19)
        Me.CheckAll.TabIndex = 303
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 14)
        Me.Label5.TabIndex = 302
        Me.Label5.Text = "Select All"
        '
        'frmFindProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 453)
        Me.Controls.Add(Me.CheckAll)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.GridControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmFindProduct"
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
    Friend WithEvents ProductID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IsSelect As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ProductCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProductName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PriceStandard As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents bindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CheckAll As DevExpress.XtraEditors.CheckEdit
    Private WithEvents Label5 As System.Windows.Forms.Label
End Class
