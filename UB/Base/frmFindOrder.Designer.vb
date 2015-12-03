<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFindOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFindOrder))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.CheckProduct = New DevExpress.XtraEditors.CheckEdit()
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFind = New DevExpress.XtraEditors.SimpleButton()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cboOrderType = New DevExpress.XtraEditors.LookUpEdit()
        Me.DateTo = New DevExpress.XtraEditors.DateEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateFrom = New DevExpress.XtraEditors.DateEdit()
        Me.TabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.OrderTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.IsSelect = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IsSelectCheckEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.เลขที่ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.เลขที่เอกสาร = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.InvoiceSuplierID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CusName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrandTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BillTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.Remark = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BillType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OrderID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TableID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CustomerID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnOrderCode = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ProductTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcProductLists1 = New UB.ucProductLists()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.CheckProduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboOrderType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateFrom.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.OrderTabPage.SuspendLayout()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsSelectCheckEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnOrderCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductTabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.CheckProduct)
        Me.GroupControl1.Controls.Add(Me.btnOK)
        Me.GroupControl1.Controls.Add(Me.btnFind)
        Me.GroupControl1.Controls.Add(Me.Label20)
        Me.GroupControl1.Controls.Add(Me.cboOrderType)
        Me.GroupControl1.Controls.Add(Me.DateTo)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.DateFrom)
        Me.GroupControl1.Location = New System.Drawing.Point(-4, 1)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(931, 98)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "เงื่อนไขการค้นหาข้อมูล"
        '
        'CheckProduct
        '
        Me.CheckProduct.Location = New System.Drawing.Point(384, 70)
        Me.CheckProduct.Name = "CheckProduct"
        Me.CheckProduct.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckProduct.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CheckProduct.Properties.Appearance.Options.UseFont = True
        Me.CheckProduct.Properties.Appearance.Options.UseForeColor = True
        Me.CheckProduct.Properties.Caption = "ค้นหารายการสินค้า"
        Me.CheckProduct.Size = New System.Drawing.Size(147, 19)
        Me.CheckProduct.TabIndex = 249
        Me.CheckProduct.Visible = False
        '
        'btnOK
        '
        Me.btnOK.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnOK.Appearance.Options.UseFont = True
        Me.btnOK.Appearance.Options.UseImage = True
        Me.btnOK.Image = CType(resources.GetObject("btnOK.Image"), System.Drawing.Image)
        Me.btnOK.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnOK.Location = New System.Drawing.Point(764, 65)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(82, 24)
        Me.btnOK.TabIndex = 248
        Me.btnOK.TabStop = False
        Me.btnOK.Text = "ตกลง"
        Me.btnOK.ToolTip = "ตกลง"
        '
        'btnFind
        '
        Me.btnFind.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnFind.Appearance.Options.UseFont = True
        Me.btnFind.Appearance.Options.UseImage = True
        Me.btnFind.Image = CType(resources.GetObject("btnFind.Image"), System.Drawing.Image)
        Me.btnFind.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnFind.Location = New System.Drawing.Point(764, 30)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(82, 24)
        Me.btnFind.TabIndex = 247
        Me.btnFind.TabStop = False
        Me.btnFind.Text = "ค้นหา"
        Me.btnFind.ToolTip = "ค้นหา"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(36, 69)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(81, 14)
        Me.Label20.TabIndex = 246
        Me.Label20.Text = "ประเภทเอกสาร"
        '
        'cboOrderType
        '
        Me.cboOrderType.EnterMoveNextControl = True
        Me.cboOrderType.Location = New System.Drawing.Point(148, 66)
        Me.cboOrderType.Name = "cboOrderType"
        Me.cboOrderType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboOrderType.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOrderType.Properties.Appearance.Options.UseFont = True
        Me.cboOrderType.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboOrderType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboOrderType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", 80, "ประเภท"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MasterTypes", "MasterTypes", 50, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Center)})
        Me.cboOrderType.Properties.DropDownRows = 10
        Me.cboOrderType.Properties.ImmediatePopup = True
        Me.cboOrderType.Properties.NullText = ""
        Me.cboOrderType.Properties.NullValuePromptShowForEmptyValue = True
        Me.cboOrderType.Properties.PopupWidth = 300
        Me.cboOrderType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboOrderType.Properties.ThrowExceptionOnInvalidLookUpEditValueType = True
        Me.cboOrderType.Properties.UseCtrlScroll = True
        Me.cboOrderType.Size = New System.Drawing.Size(193, 20)
        Me.cboOrderType.TabIndex = 245
        '
        'DateTo
        '
        Me.DateTo.EditValue = New Date(2012, 4, 20, 0, 0, 0, 0)
        Me.DateTo.EnterMoveNextControl = True
        Me.DateTo.Location = New System.Drawing.Point(386, 40)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.DateTo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DateTo.Properties.Appearance.Options.UseFont = True
        Me.DateTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateTo.Properties.DisplayFormat.FormatString = "D"
        Me.DateTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateTo.Properties.EditFormat.FormatString = "D"
        Me.DateTo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateTo.Properties.Mask.EditMask = "D"
        Me.DateTo.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateTo.Size = New System.Drawing.Size(207, 20)
        Me.DateTo.TabIndex = 231
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(347, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 14)
        Me.Label2.TabIndex = 230
        Me.Label2.Text = "ถึง"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(36, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 14)
        Me.Label3.TabIndex = 229
        Me.Label3.Text = "วันที่รายการ"
        '
        'DateFrom
        '
        Me.DateFrom.EditValue = New Date(2012, 4, 20, 0, 0, 0, 0)
        Me.DateFrom.EnterMoveNextControl = True
        Me.DateFrom.Location = New System.Drawing.Point(148, 37)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.DateFrom.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DateFrom.Properties.Appearance.Options.UseFont = True
        Me.DateFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateFrom.Properties.DisplayFormat.FormatString = "D"
        Me.DateFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateFrom.Properties.EditFormat.FormatString = "D"
        Me.DateFrom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateFrom.Properties.Mask.EditMask = "D"
        Me.DateFrom.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateFrom.Size = New System.Drawing.Size(193, 20)
        Me.DateFrom.TabIndex = 228
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Location = New System.Drawing.Point(1, 101)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabPage = Me.OrderTabPage
        Me.TabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[False]
        Me.TabControl1.Size = New System.Drawing.Size(926, 370)
        Me.TabControl1.TabIndex = 248
        Me.TabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.OrderTabPage, Me.ProductTabPage})
        '
        'OrderTabPage
        '
        Me.OrderTabPage.Controls.Add(Me.GridControl)
        Me.OrderTabPage.Name = "OrderTabPage"
        Me.OrderTabPage.Size = New System.Drawing.Size(920, 364)
        Me.OrderTabPage.Text = "Orders"
        '
        'GridControl
        '
        Me.GridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl.Location = New System.Drawing.Point(0, 0)
        Me.GridControl.MainView = Me.GridView
        Me.GridControl.Name = "GridControl"
        Me.GridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.IsSelectCheckEdit, Me.RepositoryItemCalcEdit1, Me.btnOrderCode})
        Me.GridControl.Size = New System.Drawing.Size(920, 364)
        Me.GridControl.TabIndex = 20
        Me.GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
        '
        'GridView
        '
        Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.IsSelect, Me.เลขที่, Me.เลขที่เอกสาร, Me.InvoiceSuplierID, Me.GridColumn2, Me.CusName, Me.GridColumn8, Me.GrandTotal, Me.BillTotal, Me.Remark, Me.BillType, Me.OrderID, Me.TableID, Me.CustomerID})
        Me.GridView.GridControl = Me.GridControl
        Me.GridView.Name = "GridView"
        Me.GridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView.OptionsLayout.Columns.AddNewColumns = False
        Me.GridView.OptionsLayout.Columns.RemoveOldColumns = False
        Me.GridView.OptionsMenu.EnableColumnMenu = False
        Me.GridView.OptionsMenu.EnableFooterMenu = False
        Me.GridView.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView.OptionsMenu.ShowGroupSortSummaryItems = False
        Me.GridView.OptionsMenu.ShowGroupSummaryEditorItem = True
        Me.GridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView.OptionsView.ShowFooter = True
        Me.GridView.OptionsView.ShowGroupPanel = False
        Me.GridView.OptionsView.ShowViewCaption = True
        '
        'IsSelect
        '
        Me.IsSelect.AppearanceHeader.Options.UseTextOptions = True
        Me.IsSelect.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.IsSelect.Caption = "เลือก"
        Me.IsSelect.ColumnEdit = Me.IsSelectCheckEdit
        Me.IsSelect.FieldName = "IsSelect"
        Me.IsSelect.MaxWidth = 70
        Me.IsSelect.MinWidth = 50
        Me.IsSelect.Name = "IsSelect"
        Me.IsSelect.ToolTip = "เลือกข้อมูล"
        Me.IsSelect.Visible = True
        Me.IsSelect.VisibleIndex = 0
        Me.IsSelect.Width = 50
        '
        'IsSelectCheckEdit
        '
        Me.IsSelectCheckEdit.AutoHeight = False
        Me.IsSelectCheckEdit.Name = "IsSelectCheckEdit"
        '
        'เลขที่
        '
        Me.เลขที่.Caption = "เลขที่เอกสาร"
        Me.เลขที่.FieldName = "ID"
        Me.เลขที่.MaxWidth = 150
        Me.เลขที่.MinWidth = 80
        Me.เลขที่.Name = "เลขที่"
        Me.เลขที่.Width = 100
        '
        'เลขที่เอกสาร
        '
        Me.เลขที่เอกสาร.AppearanceCell.BackColor = System.Drawing.Color.LightYellow
        Me.เลขที่เอกสาร.AppearanceCell.Options.UseBackColor = True
        Me.เลขที่เอกสาร.AppearanceHeader.Options.UseTextOptions = True
        Me.เลขที่เอกสาร.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.เลขที่เอกสาร.Caption = "เลขที่เอกสาร"
        Me.เลขที่เอกสาร.FieldName = "OrderCode"
        Me.เลขที่เอกสาร.MaxWidth = 150
        Me.เลขที่เอกสาร.MinWidth = 100
        Me.เลขที่เอกสาร.Name = "เลขที่เอกสาร"
        Me.เลขที่เอกสาร.OptionsColumn.AllowEdit = False
        Me.เลขที่เอกสาร.OptionsColumn.ReadOnly = True
        Me.เลขที่เอกสาร.Visible = True
        Me.เลขที่เอกสาร.VisibleIndex = 1
        Me.เลขที่เอกสาร.Width = 100
        '
        'InvoiceSuplierID
        '
        Me.InvoiceSuplierID.AppearanceCell.BackColor = System.Drawing.Color.LightYellow
        Me.InvoiceSuplierID.AppearanceCell.Options.UseBackColor = True
        Me.InvoiceSuplierID.Caption = "ใบกำกับภาษีเจ้าหนี้"
        Me.InvoiceSuplierID.FieldName = "InvoiceSuplierID"
        Me.InvoiceSuplierID.MaxWidth = 150
        Me.InvoiceSuplierID.MinWidth = 100
        Me.InvoiceSuplierID.Name = "InvoiceSuplierID"
        Me.InvoiceSuplierID.OptionsColumn.ReadOnly = True
        Me.InvoiceSuplierID.Visible = True
        Me.InvoiceSuplierID.VisibleIndex = 2
        Me.InvoiceSuplierID.Width = 100
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.BackColor = System.Drawing.Color.LightYellow
        Me.GridColumn2.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "วันที่เอกสาร"
        Me.GridColumn2.DisplayFormat.FormatString = "d"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn2.FieldName = "OrderDate"
        Me.GridColumn2.MaxWidth = 130
        Me.GridColumn2.MinWidth = 90
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 3
        Me.GridColumn2.Width = 100
        '
        'CusName
        '
        Me.CusName.AppearanceCell.BackColor = System.Drawing.Color.LightYellow
        Me.CusName.AppearanceCell.Options.UseBackColor = True
        Me.CusName.AppearanceHeader.Options.UseTextOptions = True
        Me.CusName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CusName.Caption = "ลูกค้า/เจ้าหนี้"
        Me.CusName.FieldName = "CusName"
        Me.CusName.MaxWidth = 250
        Me.CusName.MinWidth = 200
        Me.CusName.Name = "CusName"
        Me.CusName.OptionsColumn.ReadOnly = True
        Me.CusName.Visible = True
        Me.CusName.VisibleIndex = 4
        Me.CusName.Width = 200
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceCell.BackColor = System.Drawing.Color.LightYellow
        Me.GridColumn8.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn8.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn8.Caption = "พนักงาน"
        Me.GridColumn8.FieldName = "EmpName"
        Me.GridColumn8.MaxWidth = 220
        Me.GridColumn8.MinWidth = 100
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 5
        Me.GridColumn8.Width = 200
        '
        'GrandTotal
        '
        Me.GrandTotal.AppearanceCell.BackColor = System.Drawing.Color.LightYellow
        Me.GrandTotal.AppearanceCell.Options.UseBackColor = True
        Me.GrandTotal.AppearanceCell.Options.UseTextOptions = True
        Me.GrandTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GrandTotal.AppearanceHeader.Options.UseTextOptions = True
        Me.GrandTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GrandTotal.Caption = "ยอดรวม"
        Me.GrandTotal.DisplayFormat.FormatString = "n2"
        Me.GrandTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GrandTotal.FieldName = "GrandTotal"
        Me.GrandTotal.MaxWidth = 150
        Me.GrandTotal.MinWidth = 100
        Me.GrandTotal.Name = "GrandTotal"
        Me.GrandTotal.OptionsColumn.ReadOnly = True
        Me.GrandTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GrandTotal", "{0:n2}")})
        Me.GrandTotal.Visible = True
        Me.GrandTotal.VisibleIndex = 6
        Me.GrandTotal.Width = 100
        '
        'BillTotal
        '
        Me.BillTotal.AppearanceCell.Options.UseTextOptions = True
        Me.BillTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.BillTotal.AppearanceHeader.Options.UseTextOptions = True
        Me.BillTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BillTotal.Caption = "ยอดวางบิล"
        Me.BillTotal.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.BillTotal.DisplayFormat.FormatString = "n2"
        Me.BillTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BillTotal.FieldName = "BillTotal"
        Me.BillTotal.MaxWidth = 150
        Me.BillTotal.MinWidth = 100
        Me.BillTotal.Name = "BillTotal"
        Me.BillTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BillTotal", "{0:n2}")})
        Me.BillTotal.Visible = True
        Me.BillTotal.VisibleIndex = 7
        Me.BillTotal.Width = 100
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.DisplayFormat.FormatString = "n2"
        Me.RepositoryItemCalcEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemCalcEdit1.EditFormat.FormatString = "n2"
        Me.RepositoryItemCalcEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'Remark
        '
        Me.Remark.Caption = "รายละเอียด"
        Me.Remark.FieldName = "Remark"
        Me.Remark.MaxWidth = 200
        Me.Remark.MinWidth = 100
        Me.Remark.Name = "Remark"
        Me.Remark.Visible = True
        Me.Remark.VisibleIndex = 8
        Me.Remark.Width = 100
        '
        'BillType
        '
        Me.BillType.AppearanceCell.BackColor = System.Drawing.Color.LightYellow
        Me.BillType.AppearanceCell.Options.UseBackColor = True
        Me.BillType.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.BillType.AppearanceHeader.Options.UseBackColor = True
        Me.BillType.AppearanceHeader.Options.UseTextOptions = True
        Me.BillType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BillType.Caption = "ประเภทเอกสาร"
        Me.BillType.FieldName = "BillType"
        Me.BillType.MaxWidth = 150
        Me.BillType.MinWidth = 100
        Me.BillType.Name = "BillType"
        Me.BillType.OptionsColumn.ReadOnly = True
        Me.BillType.Visible = True
        Me.BillType.VisibleIndex = 9
        Me.BillType.Width = 100
        '
        'OrderID
        '
        Me.OrderID.Caption = "GridColumn5"
        Me.OrderID.FieldName = "OrderID"
        Me.OrderID.Name = "OrderID"
        '
        'TableID
        '
        Me.TableID.Caption = "GridColumn5"
        Me.TableID.FieldName = "TableID"
        Me.TableID.Name = "TableID"
        '
        'CustomerID
        '
        Me.CustomerID.Caption = "GridColumn1"
        Me.CustomerID.FieldName = "CustomerID"
        Me.CustomerID.Name = "CustomerID"
        '
        'btnOrderCode
        '
        Me.btnOrderCode.AutoHeight = False
        Me.btnOrderCode.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.btnOrderCode.Name = "btnOrderCode"
        '
        'ProductTabPage
        '
        Me.ProductTabPage.Controls.Add(Me.UcProductLists1)
        Me.ProductTabPage.Name = "ProductTabPage"
        Me.ProductTabPage.Size = New System.Drawing.Size(920, 364)
        Me.ProductTabPage.Text = "Products"
        '
        'UcProductLists1
        '
        Me.UcProductLists1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcProductLists1.Location = New System.Drawing.Point(0, 0)
        Me.UcProductLists1.Name = "UcProductLists1"
        Me.UcProductLists1.Size = New System.Drawing.Size(920, 364)
        Me.UcProductLists1.TabIndex = 0
        '
        'frmFindOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 471)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmFindOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmFindOrder"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.CheckProduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboOrderType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateFrom.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.OrderTabPage.ResumeLayout(False)
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsSelectCheckEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnOrderCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductTabPage.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents DateTo As DevExpress.XtraEditors.DateEdit
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateFrom As DevExpress.XtraEditors.DateEdit
    Private WithEvents Label20 As System.Windows.Forms.Label
    Private WithEvents cboOrderType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnFind As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents OrderTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ProductTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcProductLists1 As ucProductLists
    Friend WithEvents CheckProduct As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
    Private WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IsSelect As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IsSelectCheckEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents เลขที่ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents เลขที่เอกสาร As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnOrderCode As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CusName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GrandTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BillTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents Remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BillType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OrderID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TableID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents InvoiceSuplierID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CustomerID As DevExpress.XtraGrid.Columns.GridColumn
End Class
