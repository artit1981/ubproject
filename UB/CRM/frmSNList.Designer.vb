<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSNList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSNList))
        Me.FormChangedComponent1 = New UB.FormChangedComponent(Me.components)
        Me.DatePanel = New DevExpress.XtraEditors.PanelControl()
        Me.btnFind = New DevExpress.XtraEditors.SimpleButton()
        Me.chkShowDelete = New DevExpress.XtraEditors.CheckEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDateTo = New DevExpress.XtraEditors.DateEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDateFrom = New DevExpress.XtraEditors.DateEdit()
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ProductBtn = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.PriceCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnExportExcel = New DevExpress.XtraEditors.PictureEdit()
        Me.cboRefreshTime = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnExportWord = New DevExpress.XtraEditors.PictureEdit()
        Me.btnExportPDF = New DevExpress.XtraEditors.PictureEdit()
        Me.CheckIsRefresh = New DevExpress.XtraEditors.CheckEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.CheckShowInfo = New DevExpress.XtraEditors.CheckEdit()
        Me.cboStatus = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DatePanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DatePanel.SuspendLayout()
        CType(Me.chkShowDelete.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDateTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDateTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDateFrom.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDateFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.btnExportExcel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRefreshTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExportWord.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExportPDF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckIsRefresh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckShowInfo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DatePanel
        '
        Me.DatePanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DatePanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.DatePanel, "")
        Me.DatePanel.Controls.Add(Me.PanelControl1)
        Me.DatePanel.Controls.Add(Me.btnFind)
        Me.DatePanel.Controls.Add(Me.chkShowDelete)
        Me.DatePanel.Controls.Add(Me.Label3)
        Me.DatePanel.Controls.Add(Me.dtpDateTo)
        Me.DatePanel.Controls.Add(Me.Label2)
        Me.DatePanel.Controls.Add(Me.dtpDateFrom)
        Me.DatePanel.Location = New System.Drawing.Point(0, 39)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.DatePanel, True)
        Me.DatePanel.Name = "DatePanel"
        Me.DatePanel.Size = New System.Drawing.Size(992, 40)
        Me.DatePanel.TabIndex = 292
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.DatePanel, "")
        '
        'btnFind
        '
        Me.btnFind.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnFind.Appearance.Options.UseFont = True
        Me.btnFind.Appearance.Options.UseImage = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnFind, "")
        Me.btnFind.Image = CType(resources.GetObject("btnFind.Image"), System.Drawing.Image)
        Me.btnFind.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnFind.Location = New System.Drawing.Point(396, 7)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnFind, True)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(101, 24)
        Me.btnFind.TabIndex = 293
        Me.btnFind.TabStop = False
        Me.btnFind.Text = "ค้นหา"
        Me.btnFind.ToolTip = "ค้นหา"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnFind, "")
        '
        'chkShowDelete
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.chkShowDelete, "CheckedChanged")
        Me.chkShowDelete.EditValue = True
        Me.chkShowDelete.Location = New System.Drawing.Point(703, 10)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.chkShowDelete, True)
        Me.chkShowDelete.Name = "chkShowDelete"
        Me.chkShowDelete.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowDelete.Properties.Appearance.Options.UseFont = True
        Me.chkShowDelete.Properties.Caption = "แสดงรายการที่ลบ"
        Me.chkShowDelete.Size = New System.Drawing.Size(122, 19)
        Me.chkShowDelete.TabIndex = 123
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.chkShowDelete, "Checked")
        Me.chkShowDelete.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label3, "")
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(222, 11)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label3, True)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 14)
        Me.Label3.TabIndex = 122
        Me.Label3.Text = "ถึง"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label3, "")
        '
        'dtpDateTo
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.dtpDateTo, "TextChanged")
        Me.dtpDateTo.EditValue = New Date(2012, 4, 20, 0, 0, 0, 0)
        Me.dtpDateTo.EnterMoveNextControl = True
        Me.dtpDateTo.Location = New System.Drawing.Point(248, 9)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.dtpDateTo, True)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.dtpDateTo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpDateTo.Properties.Appearance.Options.UseFont = True
        Me.dtpDateTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpDateTo.Properties.DisplayFormat.FormatString = "D"
        Me.dtpDateTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpDateTo.Properties.EditFormat.FormatString = "D"
        Me.dtpDateTo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpDateTo.Properties.Mask.EditMask = "D"
        Me.dtpDateTo.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpDateTo.Size = New System.Drawing.Size(139, 20)
        Me.dtpDateTo.TabIndex = 121
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.dtpDateTo, "Text")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label2, "")
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 13)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label2, True)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 14)
        Me.Label2.TabIndex = 120
        Me.Label2.Text = "วันที่นำเข้า"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label2, "")
        '
        'dtpDateFrom
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.dtpDateFrom, "TextChanged")
        Me.dtpDateFrom.EditValue = New Date(2012, 4, 20, 0, 0, 0, 0)
        Me.dtpDateFrom.EnterMoveNextControl = True
        Me.dtpDateFrom.Location = New System.Drawing.Point(77, 9)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.dtpDateFrom, True)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.dtpDateFrom.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpDateFrom.Properties.Appearance.Options.UseFont = True
        Me.dtpDateFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpDateFrom.Properties.DisplayFormat.FormatString = "D"
        Me.dtpDateFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpDateFrom.Properties.EditFormat.FormatString = "D"
        Me.dtpDateFrom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpDateFrom.Properties.Mask.EditMask = "D"
        Me.dtpDateFrom.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpDateFrom.Size = New System.Drawing.Size(139, 20)
        Me.dtpDateFrom.TabIndex = 2
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.dtpDateFrom, "Text")
        '
        'gridControl
        '
        Me.gridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.gridControl, "")
        Me.gridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gridControl.EmbeddedNavigator.Buttons.Edit.ImageIndex = 0
        Me.gridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gridControl.Location = New System.Drawing.Point(0, 85)
        Me.gridControl.MainView = Me.gridView
        Me.FormChangedComponent1.SetMonitorForChanges(Me.gridControl, True)
        Me.gridControl.Name = "gridControl"
        Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ProductBtn, Me.PriceCalcEdit1})
        Me.gridControl.Size = New System.Drawing.Size(992, 381)
        Me.gridControl.TabIndex = 294
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.gridControl, "")
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView, Me.GridView1})
        '
        'gridView
        '
        Me.gridView.GridControl = Me.gridControl
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsBehavior.ReadOnly = True
        Me.gridView.OptionsFind.AlwaysVisible = True
        Me.gridView.OptionsLayout.Columns.AddNewColumns = False
        Me.gridView.OptionsLayout.Columns.RemoveOldColumns = False
        Me.gridView.OptionsMenu.EnableColumnMenu = False
        Me.gridView.OptionsMenu.EnableFooterMenu = False
        Me.gridView.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsNavigation.AutoFocusNewRow = True
        Me.gridView.OptionsNavigation.EnterMoveNextColumn = True
        Me.gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        '
        'ProductBtn
        '
        Me.ProductBtn.AutoHeight = False
        Me.ProductBtn.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ProductBtn.Name = "ProductBtn"
        Me.ProductBtn.ValidateOnEnterKey = True
        '
        'PriceCalcEdit1
        '
        Me.PriceCalcEdit1.AutoHeight = False
        Me.PriceCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PriceCalcEdit1.DisplayFormat.FormatString = "n2"
        Me.PriceCalcEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PriceCalcEdit1.EditFormat.FormatString = "n2"
        Me.PriceCalcEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PriceCalcEdit1.Name = "PriceCalcEdit1"
        Me.PriceCalcEdit1.Precision = 2
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gridControl
        Me.GridView1.Name = "GridView1"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.PanelControl1, "")
        Me.PanelControl1.Controls.Add(Me.btnExportExcel)
        Me.PanelControl1.Controls.Add(Me.cboRefreshTime)
        Me.PanelControl1.Controls.Add(Me.btnExportWord)
        Me.PanelControl1.Controls.Add(Me.btnExportPDF)
        Me.PanelControl1.Controls.Add(Me.CheckIsRefresh)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.CheckShowInfo)
        Me.PanelControl1.Controls.Add(Me.cboStatus)
        Me.PanelControl1.Controls.Add(Me.Label4)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelControl1.Location = New System.Drawing.Point(862, 0)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.PanelControl1, True)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(130, 40)
        Me.PanelControl1.TabIndex = 295
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.PanelControl1, "")
        '
        'btnExportExcel
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnExportExcel, "")
        Me.btnExportExcel.EditValue = CType(resources.GetObject("btnExportExcel.EditValue"), Object)
        Me.btnExportExcel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExportExcel.Location = New System.Drawing.Point(50, 3)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnExportExcel, True)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnExportExcel.Properties.Appearance.Options.UseBackColor = True
        Me.btnExportExcel.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnExportExcel.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.btnExportExcel.Size = New System.Drawing.Size(22, 22)
        Me.btnExportExcel.TabIndex = 118
        Me.btnExportExcel.ToolTip = "Expor to Excel"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnExportExcel, "")
        '
        'cboRefreshTime
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.cboRefreshTime, "TextChanged")
        Me.cboRefreshTime.EditValue = "5"
        Me.cboRefreshTime.Location = New System.Drawing.Point(282, 3)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.cboRefreshTime, True)
        Me.cboRefreshTime.Name = "cboRefreshTime"
        Me.cboRefreshTime.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRefreshTime.Properties.Appearance.Options.UseFont = True
        Me.cboRefreshTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRefreshTime.Properties.Items.AddRange(New Object() {"1", "5", "10", "30", "60"})
        Me.cboRefreshTime.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboRefreshTime.Size = New System.Drawing.Size(45, 20)
        Me.cboRefreshTime.TabIndex = 114
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.cboRefreshTime, "Text")
        Me.cboRefreshTime.Visible = False
        '
        'btnExportWord
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnExportWord, "")
        Me.btnExportWord.EditValue = CType(resources.GetObject("btnExportWord.EditValue"), Object)
        Me.btnExportWord.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExportWord.Location = New System.Drawing.Point(95, 3)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnExportWord, True)
        Me.btnExportWord.Name = "btnExportWord"
        Me.btnExportWord.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnExportWord.Properties.Appearance.Options.UseBackColor = True
        Me.btnExportWord.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnExportWord.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.btnExportWord.Size = New System.Drawing.Size(22, 22)
        Me.btnExportWord.TabIndex = 121
        Me.btnExportWord.ToolTip = "Export to Word"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnExportWord, "")
        '
        'btnExportPDF
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnExportPDF, "")
        Me.btnExportPDF.EditValue = CType(resources.GetObject("btnExportPDF.EditValue"), Object)
        Me.btnExportPDF.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExportPDF.Location = New System.Drawing.Point(72, 3)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnExportPDF, True)
        Me.btnExportPDF.Name = "btnExportPDF"
        Me.btnExportPDF.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnExportPDF.Properties.Appearance.Options.UseBackColor = True
        Me.btnExportPDF.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnExportPDF.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.btnExportPDF.Size = New System.Drawing.Size(22, 22)
        Me.btnExportPDF.TabIndex = 120
        Me.btnExportPDF.ToolTip = "Export to PDF"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnExportPDF, "")
        '
        'CheckIsRefresh
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.CheckIsRefresh, "CheckedChanged")
        Me.CheckIsRefresh.EditValue = True
        Me.CheckIsRefresh.Location = New System.Drawing.Point(277, 4)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.CheckIsRefresh, True)
        Me.CheckIsRefresh.Name = "CheckIsRefresh"
        Me.CheckIsRefresh.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CheckIsRefresh.Properties.Appearance.Options.UseFont = True
        Me.CheckIsRefresh.Properties.Caption = "Refresh"
        Me.CheckIsRefresh.Size = New System.Drawing.Size(72, 19)
        Me.CheckIsRefresh.TabIndex = 113
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.CheckIsRefresh, "Checked")
        Me.CheckIsRefresh.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label1, "")
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label1, True)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 14)
        Me.Label1.TabIndex = 119
        Me.Label1.Text = "Export :"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label1, "")
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.LabelControl1, "")
        Me.LabelControl1.Location = New System.Drawing.Point(331, 6)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.LabelControl1, True)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl1.TabIndex = 115
        Me.LabelControl1.Text = "วินาที"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.LabelControl1, "")
        Me.LabelControl1.Visible = False
        '
        'CheckShowInfo
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.CheckShowInfo, "CheckedChanged")
        Me.CheckShowInfo.EditValue = True
        Me.CheckShowInfo.Location = New System.Drawing.Point(246, 2)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.CheckShowInfo, True)
        Me.CheckShowInfo.Name = "CheckShowInfo"
        Me.CheckShowInfo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CheckShowInfo.Properties.Appearance.Options.UseFont = True
        Me.CheckShowInfo.Properties.Caption = "Show Information"
        Me.CheckShowInfo.Size = New System.Drawing.Size(126, 19)
        Me.CheckShowInfo.TabIndex = 116
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.CheckShowInfo, "Checked")
        Me.CheckShowInfo.Visible = False
        '
        'cboStatus
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.cboStatus, "TextChanged")
        Me.cboStatus.Location = New System.Drawing.Point(279, 4)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.cboStatus, True)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboStatus.Properties.Appearance.Options.UseFont = True
        Me.cboStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboStatus.Size = New System.Drawing.Size(41, 20)
        Me.cboStatus.TabIndex = 112
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.cboStatus, "Text")
        Me.cboStatus.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label4, "")
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(232, 5)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label4, True)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 14)
        Me.Label4.TabIndex = 111
        Me.Label4.Text = "สถานะ"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label4, "")
        Me.Label4.Visible = False
        '
        'frmSNList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 470)
        Me.Controls.Add(Me.gridControl)
        Me.Controls.Add(Me.DatePanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSNList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ประวัติการซื้อ-ขายสินค้า"
        Me.Controls.SetChildIndex(Me.DatePanel, 0)
        Me.Controls.SetChildIndex(Me.gridControl, 0)
        CType(Me.DatePanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DatePanel.ResumeLayout(False)
        Me.DatePanel.PerformLayout()
        CType(Me.chkShowDelete.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDateTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDateTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDateFrom.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDateFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.btnExportExcel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRefreshTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExportWord.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExportPDF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckIsRefresh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckShowInfo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormChangedComponent1 As FormChangedComponent
    Friend WithEvents ProductName As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents bindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DatePanel As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnFind As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkShowDelete As DevExpress.XtraEditors.CheckEdit
    Private WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpDateTo As DevExpress.XtraEditors.DateEdit
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDateFrom As DevExpress.XtraEditors.DateEdit
    Private WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Private WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ProductBtn As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents PriceCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnExportExcel As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents cboRefreshTime As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnExportWord As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents btnExportPDF As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents CheckIsRefresh As DevExpress.XtraEditors.CheckEdit
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckShowInfo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cboStatus As DevExpress.XtraEditors.ComboBoxEdit
    Private WithEvents Label4 As System.Windows.Forms.Label
End Class
