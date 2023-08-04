<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockIn))
        Me.FormChangedComponent1 = New UB.FormChangedComponent(Me.components)
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.GeneralTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.IsSumStock = New DevExpress.XtraEditors.CheckEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblUpdateStr = New System.Windows.Forms.Label()
        Me.UcProductLists1 = New UB.ucProductLists()
        Me.LocationDTLID = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnLocation = New DevExpress.XtraEditors.SimpleButton()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.lblRefOrder = New System.Windows.Forms.Label()
        Me.btnRefOrder = New DevExpress.XtraEditors.SimpleButton()
        Me.txtRefOrder = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Remark = New DevExpress.XtraEditors.MemoEdit()
        Me.EmpID = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnEmpID = New DevExpress.XtraEditors.SimpleButton()
        Me.OrderCode = New DevExpress.XtraEditors.TextEdit()
        Me.btnGenID = New DevExpress.XtraEditors.SimpleButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OrderDate = New DevExpress.XtraEditors.DateEdit()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.NoteTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcNote1 = New UB.ucNote()
        Me.AttachmentTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcFileAttach1 = New UB.ucFileAttach()
        Me.AdminTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UcAdmin1 = New UB.ucAdmin()
        Me.CustomerID = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CusName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.Type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Phone1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Fax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Email1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EMPNAME = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.GeneralTabPage.SuspendLayout()
        CType(Me.IsSumStock.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationDTLID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRefOrder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Remark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NoteTabPage.SuspendLayout()
        Me.AttachmentTabPage.SuspendLayout()
        Me.AdminTabPage.SuspendLayout()
        CType(Me.CustomerID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormChangedComponent1
        '
        '
        'XtraTabControl1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.XtraTabControl1, "")
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.HeaderButtons = DevExpress.XtraTab.TabButtons.None
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 30)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.XtraTabControl1, True)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.GeneralTabPage
        Me.XtraTabControl1.Size = New System.Drawing.Size(921, 469)
        Me.XtraTabControl1.TabIndex = 5
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.GeneralTabPage, Me.NoteTabPage, Me.AttachmentTabPage, Me.AdminTabPage})
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.XtraTabControl1, "")
        '
        'GeneralTabPage
        '
        Me.GeneralTabPage.Appearance.PageClient.BackColor = System.Drawing.Color.LightGray
        Me.GeneralTabPage.Appearance.PageClient.Options.UseBackColor = True
        Me.GeneralTabPage.AutoScroll = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.GeneralTabPage, "")
        Me.GeneralTabPage.Controls.Add(Me.CustomerID)
        Me.GeneralTabPage.Controls.Add(Me.IsSumStock)
        Me.GeneralTabPage.Controls.Add(Me.Label2)
        Me.GeneralTabPage.Controls.Add(Me.lblUpdateStr)
        Me.GeneralTabPage.Controls.Add(Me.UcProductLists1)
        Me.GeneralTabPage.Controls.Add(Me.LocationDTLID)
        Me.GeneralTabPage.Controls.Add(Me.btnLocation)
        Me.GeneralTabPage.Controls.Add(Me.Label33)
        Me.GeneralTabPage.Controls.Add(Me.lblRefOrder)
        Me.GeneralTabPage.Controls.Add(Me.btnRefOrder)
        Me.GeneralTabPage.Controls.Add(Me.txtRefOrder)
        Me.GeneralTabPage.Controls.Add(Me.Label5)
        Me.GeneralTabPage.Controls.Add(Me.Remark)
        Me.GeneralTabPage.Controls.Add(Me.EmpID)
        Me.GeneralTabPage.Controls.Add(Me.Label21)
        Me.GeneralTabPage.Controls.Add(Me.btnEmpID)
        Me.GeneralTabPage.Controls.Add(Me.OrderCode)
        Me.GeneralTabPage.Controls.Add(Me.btnGenID)
        Me.GeneralTabPage.Controls.Add(Me.Label4)
        Me.GeneralTabPage.Controls.Add(Me.OrderDate)
        Me.GeneralTabPage.Controls.Add(Me.Label22)
        Me.GeneralTabPage.Controls.Add(Me.Label3)
        Me.GeneralTabPage.Controls.Add(Me.Label1)
        Me.GeneralTabPage.Controls.Add(Me.Label28)
        Me.GeneralTabPage.Controls.Add(Me.Label18)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.GeneralTabPage, True)
        Me.GeneralTabPage.Name = "GeneralTabPage"
        Me.GeneralTabPage.Size = New System.Drawing.Size(919, 444)
        Me.GeneralTabPage.Text = "ข้อมูลทั่วไป"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.GeneralTabPage, "")
        '
        'IsSumStock
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.IsSumStock, "CheckedChanged")
        Me.IsSumStock.EnterMoveNextControl = True
        Me.IsSumStock.Location = New System.Drawing.Point(93, 154)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.IsSumStock, True)
        Me.IsSumStock.Name = "IsSumStock"
        Me.IsSumStock.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsSumStock.Properties.Appearance.Options.UseFont = True
        Me.IsSumStock.Properties.Caption = "ปรับคลังรวม"
        Me.IsSumStock.Size = New System.Drawing.Size(92, 20)
        Me.IsSumStock.TabIndex = 288
        Me.IsSumStock.TabStop = False
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.IsSumStock, "Checked")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label2, "")
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(454, 96)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label2, True)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 14)
        Me.Label2.TabIndex = 287
        Me.Label2.Text = "เจ้าหนี้"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label2, "")
        '
        'lblUpdateStr
        '
        Me.lblUpdateStr.AutoSize = True
        Me.lblUpdateStr.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.lblUpdateStr, "")
        Me.lblUpdateStr.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblUpdateStr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblUpdateStr.Location = New System.Drawing.Point(318, 163)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.lblUpdateStr, True)
        Me.lblUpdateStr.Name = "lblUpdateStr"
        Me.lblUpdateStr.Size = New System.Drawing.Size(409, 14)
        Me.lblUpdateStr.TabIndex = 285
        Me.lblUpdateStr.Text = "จำนวณสินค้าจะถูกเพิ่ม หรือลด ตามจำนวณสินค้าที่ระบุ (สามารถใส่เป็นเลขติดลบได้)"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.lblUpdateStr, "")
        '
        'UcProductLists1
        '
        Me.UcProductLists1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.UcProductLists1, "")
        Me.UcProductLists1.Location = New System.Drawing.Point(37, 180)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.UcProductLists1, True)
        Me.UcProductLists1.Name = "UcProductLists1"
        Me.UcProductLists1.Size = New System.Drawing.Size(688, 256)
        Me.UcProductLists1.TabIndex = 7
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcProductLists1, "")
        '
        'LocationDTLID
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.LocationDTLID, "TextChanged")
        Me.LocationDTLID.Location = New System.Drawing.Point(124, 180)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.LocationDTLID, True)
        Me.LocationDTLID.Name = "LocationDTLID"
        Me.LocationDTLID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocationDTLID.Properties.Appearance.Options.UseFont = True
        Me.LocationDTLID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LocationDTLID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NameThai", "Name", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.LocationDTLID.Properties.NullText = ""
        Me.LocationDTLID.Properties.ShowHeader = False
        Me.LocationDTLID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LocationDTLID.Size = New System.Drawing.Size(210, 20)
        Me.LocationDTLID.TabIndex = 6
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.LocationDTLID, "Text")
        Me.LocationDTLID.Visible = False
        '
        'btnLocation
        '
        Me.btnLocation.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnLocation.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnLocation, "")
        Me.btnLocation.ImageOptions.Image = CType(resources.GetObject("btnLocation.ImageOptions.Image"), System.Drawing.Image)
        Me.btnLocation.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnLocation.Location = New System.Drawing.Point(335, 180)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnLocation, True)
        Me.btnLocation.Name = "btnLocation"
        Me.btnLocation.Size = New System.Drawing.Size(21, 21)
        Me.btnLocation.TabIndex = 284
        Me.btnLocation.TabStop = False
        Me.btnLocation.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnLocation, "")
        Me.btnLocation.Visible = False
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label33, "")
        Me.Label33.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label33.Location = New System.Drawing.Point(56, 183)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label33, True)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(62, 14)
        Me.Label33.TabIndex = 283
        Me.Label33.Text = "กำหนดคลัง"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label33, "")
        Me.Label33.Visible = False
        '
        'lblRefOrder
        '
        Me.lblRefOrder.AutoSize = True
        Me.lblRefOrder.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.lblRefOrder, "")
        Me.lblRefOrder.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblRefOrder.Location = New System.Drawing.Point(454, 70)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.lblRefOrder, True)
        Me.lblRefOrder.Name = "lblRefOrder"
        Me.lblRefOrder.Size = New System.Drawing.Size(23, 14)
        Me.lblRefOrder.TabIndex = 281
        Me.lblRefOrder.Text = "PO"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.lblRefOrder, "")
        '
        'btnRefOrder
        '
        Me.btnRefOrder.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRefOrder.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnRefOrder, "")
        Me.btnRefOrder.ImageOptions.Image = CType(resources.GetObject("btnRefOrder.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRefOrder.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefOrder.Location = New System.Drawing.Point(723, 66)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnRefOrder, True)
        Me.btnRefOrder.Name = "btnRefOrder"
        Me.btnRefOrder.Size = New System.Drawing.Size(26, 22)
        Me.btnRefOrder.TabIndex = 4
        Me.btnRefOrder.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnRefOrder, "")
        '
        'txtRefOrder
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.txtRefOrder, "TextChanged")
        Me.txtRefOrder.EditValue = ""
        Me.txtRefOrder.EnterMoveNextControl = True
        Me.txtRefOrder.Location = New System.Drawing.Point(505, 67)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.txtRefOrder, True)
        Me.txtRefOrder.Name = "txtRefOrder"
        Me.txtRefOrder.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtRefOrder.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRefOrder.Properties.Appearance.Options.UseBackColor = True
        Me.txtRefOrder.Properties.Appearance.Options.UseFont = True
        Me.txtRefOrder.Properties.MaxLength = 50
        Me.txtRefOrder.Properties.ValidateOnEnterKey = True
        Me.txtRefOrder.Size = New System.Drawing.Size(212, 20)
        Me.txtRefOrder.TabIndex = 3
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.txtRefOrder, "Text")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label5, "")
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(47, 97)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label5, True)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 14)
        Me.Label5.TabIndex = 255
        Me.Label5.Text = "รายละเอียด"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label5, "")
        '
        'Remark
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Remark, "TextChanged")
        Me.Remark.EditValue = ""
        Me.Remark.EnterMoveNextControl = True
        Me.Remark.Location = New System.Drawing.Point(160, 94)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Remark, True)
        Me.Remark.Name = "Remark"
        Me.Remark.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Remark.Properties.Appearance.Options.UseFont = True
        Me.Remark.Properties.MaxLength = 100
        Me.Remark.Size = New System.Drawing.Size(234, 54)
        Me.Remark.TabIndex = 5
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Remark, "Text")
        '
        'EmpID
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.EmpID, "TextChanged")
        Me.EmpID.EnterMoveNextControl = True
        Me.EmpID.Location = New System.Drawing.Point(160, 67)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.EmpID, True)
        Me.EmpID.Name = "EmpID"
        Me.EmpID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpID.Properties.Appearance.Options.UseFont = True
        Me.EmpID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EmpID.Properties.NullText = ""
        Me.EmpID.Properties.PopupView = Me.GridView1
        Me.EmpID.Size = New System.Drawing.Size(212, 20)
        Me.EmpID.TabIndex = 2
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.EmpID, "Text")
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
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label21, "")
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(47, 70)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label21, True)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(47, 14)
        Me.Label21.TabIndex = 253
        Me.Label21.Text = "พนักงาน"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label21, "")
        '
        'btnEmpID
        '
        Me.btnEmpID.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnEmpID.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnEmpID, "")
        Me.btnEmpID.ImageOptions.Image = CType(resources.GetObject("btnEmpID.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEmpID.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEmpID.Location = New System.Drawing.Point(374, 67)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnEmpID, True)
        Me.btnEmpID.Name = "btnEmpID"
        Me.btnEmpID.Size = New System.Drawing.Size(21, 21)
        Me.btnEmpID.TabIndex = 252
        Me.btnEmpID.TabStop = False
        Me.btnEmpID.ToolTip = "Refresh"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnEmpID, "")
        '
        'OrderCode
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.OrderCode, "TextChanged")
        Me.OrderCode.EditValue = ""
        Me.OrderCode.EnterMoveNextControl = True
        Me.OrderCode.Location = New System.Drawing.Point(160, 40)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.OrderCode, True)
        Me.OrderCode.Name = "OrderCode"
        Me.OrderCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.OrderCode.Properties.Appearance.Options.UseFont = True
        Me.OrderCode.Properties.MaxLength = 50
        Me.OrderCode.Properties.ValidateOnEnterKey = True
        Me.OrderCode.Size = New System.Drawing.Size(212, 20)
        Me.OrderCode.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.OrderCode, "Text")
        '
        'btnGenID
        '
        Me.btnGenID.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnGenID.Appearance.Options.UseFont = True
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.btnGenID, "")
        Me.btnGenID.ImageOptions.Image = CType(resources.GetObject("btnGenID.ImageOptions.Image"), System.Drawing.Image)
        Me.btnGenID.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnGenID.Location = New System.Drawing.Point(373, 40)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.btnGenID, True)
        Me.btnGenID.Name = "btnGenID"
        Me.btnGenID.Size = New System.Drawing.Size(21, 21)
        Me.btnGenID.TabIndex = 246
        Me.btnGenID.TabStop = False
        Me.btnGenID.ToolTip = "Auto ID"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.btnGenID, "")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label4, "")
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(48, 43)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label4, True)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 14)
        Me.Label4.TabIndex = 245
        Me.Label4.Text = "เลขที่เอกสาร"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label4, "")
        '
        'OrderDate
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.OrderDate, "TextChanged")
        Me.OrderDate.EditValue = New Date(2012, 4, 20, 0, 0, 0, 0)
        Me.OrderDate.EnterMoveNextControl = True
        Me.OrderDate.Location = New System.Drawing.Point(505, 40)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.OrderDate, True)
        Me.OrderDate.Name = "OrderDate"
        Me.OrderDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.OrderDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.OrderDate.Properties.Appearance.Options.UseFont = True
        Me.OrderDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrderDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.OrderDate.Properties.DisplayFormat.FormatString = "D"
        Me.OrderDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.OrderDate.Properties.EditFormat.FormatString = "D"
        Me.OrderDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.OrderDate.Properties.Mask.EditMask = "D"
        Me.OrderDate.Size = New System.Drawing.Size(212, 20)
        Me.OrderDate.TabIndex = 1
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.OrderDate, "Text")
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label22, "")
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label22.Location = New System.Drawing.Point(454, 43)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label22, True)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(29, 14)
        Me.Label22.TabIndex = 244
        Me.Label22.Text = "วันที่"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label22, "")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label3, "")
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(79, 154)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label3, True)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(658, 14)
        Me.Label3.TabIndex = 231
        Me.Label3.Text = "_________________________________________________________________________________" &
    "____________"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label3, "")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label1, "")
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(34, 155)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label1, True)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 14)
        Me.Label1.TabIndex = 230
        Me.Label1.Text = "สินค้า"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label1, "")
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label28, "")
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.DarkGray
        Me.Label28.Location = New System.Drawing.Point(104, 11)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label28, True)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(623, 14)
        Me.Label28.TabIndex = 120
        Me.Label28.Text = "_________________________________________________________________________________" &
    "_______"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label28, "")
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.Label18, "")
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label18.Location = New System.Drawing.Point(34, 15)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.Label18, True)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 14)
        Me.Label18.TabIndex = 114
        Me.Label18.Text = "ข้อมูลทั่วไป"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.Label18, "")
        '
        'NoteTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.NoteTabPage, "")
        Me.NoteTabPage.Controls.Add(Me.UcNote1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.NoteTabPage, True)
        Me.NoteTabPage.Name = "NoteTabPage"
        Me.NoteTabPage.Size = New System.Drawing.Size(919, 437)
        Me.NoteTabPage.Text = "บันทึกข้อความ"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.NoteTabPage, "")
        '
        'UcNote1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.UcNote1, "")
        Me.UcNote1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcNote1.Location = New System.Drawing.Point(0, 0)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.UcNote1, True)
        Me.UcNote1.Name = "UcNote1"
        Me.UcNote1.Size = New System.Drawing.Size(919, 437)
        Me.UcNote1.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcNote1, "")
        '
        'AttachmentTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.AttachmentTabPage, "")
        Me.AttachmentTabPage.Controls.Add(Me.UcFileAttach1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.AttachmentTabPage, True)
        Me.AttachmentTabPage.Name = "AttachmentTabPage"
        Me.AttachmentTabPage.Size = New System.Drawing.Size(919, 437)
        Me.AttachmentTabPage.Text = "ไฟล์แนบ"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.AttachmentTabPage, "")
        '
        'UcFileAttach1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.UcFileAttach1, "")
        Me.UcFileAttach1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcFileAttach1.Location = New System.Drawing.Point(0, 0)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.UcFileAttach1, True)
        Me.UcFileAttach1.Name = "UcFileAttach1"
        Me.UcFileAttach1.Size = New System.Drawing.Size(919, 437)
        Me.UcFileAttach1.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcFileAttach1, "")
        '
        'AdminTabPage
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.AdminTabPage, "")
        Me.AdminTabPage.Controls.Add(Me.UcAdmin1)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.AdminTabPage, True)
        Me.AdminTabPage.Name = "AdminTabPage"
        Me.AdminTabPage.Size = New System.Drawing.Size(919, 437)
        Me.AdminTabPage.Text = "ผู้บันทึก"
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.AdminTabPage, "")
        '
        'UcAdmin1
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.UcAdmin1, "")
        Me.UcAdmin1.Location = New System.Drawing.Point(71, 0)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.UcAdmin1, True)
        Me.UcAdmin1.Name = "UcAdmin1"
        Me.UcAdmin1.Size = New System.Drawing.Size(665, 223)
        Me.UcAdmin1.TabIndex = 0
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.UcAdmin1, "")
        '
        'CustomerID
        '
        Me.FormChangedComponent1.SetChangeEventToMonitor(Me.CustomerID, "TextChanged")
        Me.CustomerID.EnterMoveNextControl = True
        Me.CustomerID.Location = New System.Drawing.Point(505, 94)
        Me.FormChangedComponent1.SetMonitorForChanges(Me.CustomerID, True)
        Me.CustomerID.Name = "CustomerID"
        Me.CustomerID.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.CustomerID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerID.Properties.Appearance.Options.UseBackColor = True
        Me.CustomerID.Properties.Appearance.Options.UseFont = True
        Me.CustomerID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CustomerID.Properties.NullText = ""
        Me.CustomerID.Properties.PopupFindMode = DevExpress.XtraEditors.FindMode.Always
        Me.CustomerID.Properties.PopupFormSize = New System.Drawing.Size(800, 0)
        Me.CustomerID.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.CustomerID.Properties.ReadOnly = True
        Me.CustomerID.Properties.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1})
        Me.CustomerID.Size = New System.Drawing.Size(212, 20)
        Me.CustomerID.TabIndex = 290
        Me.FormChangedComponent1.SetValueNameToMonitor(Me.CustomerID, "Text")
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.Code, Me.CusName, Me.Type, Me.Phone1, Me.Fax, Me.Email1, Me.EMPNAME})
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ColumnAutoWidth = False
        Me.SearchLookUpEdit1View.OptionsView.RowAutoHeight = True
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
        Me.Code.Caption = "รหัส"
        Me.Code.FieldName = "Code"
        Me.Code.MaxWidth = 100
        Me.Code.MinWidth = 75
        Me.Code.Name = "Code"
        Me.Code.Visible = True
        Me.Code.VisibleIndex = 0
        '
        'CusName
        '
        Me.CusName.Caption = "ชื่อ - นามสกุล"
        Me.CusName.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.CusName.FieldName = "CusName"
        Me.CusName.MinWidth = 150
        Me.CusName.Name = "CusName"
        Me.CusName.Visible = True
        Me.CusName.VisibleIndex = 1
        Me.CusName.Width = 250
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        Me.RepositoryItemMemoEdit1.WordWrap = False
        '
        'Type
        '
        Me.Type.Caption = "ประเภทลูกค้า"
        Me.Type.FieldName = "Type"
        Me.Type.MaxWidth = 75
        Me.Type.MinWidth = 50
        Me.Type.Name = "Type"
        Me.Type.Visible = True
        Me.Type.VisibleIndex = 2
        '
        'Phone1
        '
        Me.Phone1.Caption = "เบอร์โทร"
        Me.Phone1.FieldName = "Phone1"
        Me.Phone1.MaxWidth = 85
        Me.Phone1.MinWidth = 85
        Me.Phone1.Name = "Phone1"
        Me.Phone1.Visible = True
        Me.Phone1.VisibleIndex = 3
        Me.Phone1.Width = 85
        '
        'Fax
        '
        Me.Fax.Caption = "เบอร์แฟกซ์"
        Me.Fax.FieldName = "Fax"
        Me.Fax.MaxWidth = 85
        Me.Fax.MinWidth = 85
        Me.Fax.Name = "Fax"
        Me.Fax.Visible = True
        Me.Fax.VisibleIndex = 4
        Me.Fax.Width = 85
        '
        'Email1
        '
        Me.Email1.Caption = "อีเมล์"
        Me.Email1.FieldName = "Email1"
        Me.Email1.MaxWidth = 85
        Me.Email1.MinWidth = 85
        Me.Email1.Name = "Email1"
        Me.Email1.Visible = True
        Me.Email1.VisibleIndex = 5
        Me.Email1.Width = 85
        '
        'EMPNAME
        '
        Me.EMPNAME.Caption = "ผู้รับผิดชอบ"
        Me.EMPNAME.FieldName = "EMPNAME"
        Me.EMPNAME.MaxWidth = 150
        Me.EMPNAME.MinWidth = 120
        Me.EMPNAME.Name = "EMPNAME"
        Me.EMPNAME.Visible = True
        Me.EMPNAME.VisibleIndex = 6
        Me.EMPNAME.Width = 120
        '
        'frmStockIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 499)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frmStockIn"
        Me.Text = "frmStockIn"
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.GeneralTabPage.ResumeLayout(False)
        Me.GeneralTabPage.PerformLayout()
        CType(Me.IsSumStock.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationDTLID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRefOrder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Remark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NoteTabPage.ResumeLayout(False)
        Me.AttachmentTabPage.ResumeLayout(False)
        Me.AdminTabPage.ResumeLayout(False)
        CType(Me.CustomerID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FormChangedComponent1 As FormChangedComponent
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents GeneralTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcProductLists1 As ucProductLists
    Private WithEvents Label28 As System.Windows.Forms.Label
    Private WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents NoteTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcNote1 As ucNote
    Friend WithEvents AttachmentTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcFileAttach1 As ucFileAttach
    Friend WithEvents AdminTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents UcAdmin1 As ucAdmin
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OrderCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnGenID As DevExpress.XtraEditors.SimpleButton
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents OrderDate As DevExpress.XtraEditors.DateEdit
    Private WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents EmpID As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btnEmpID As DevExpress.XtraEditors.SimpleButton
    Private WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Remark As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btnRefOrder As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtRefOrder As DevExpress.XtraEditors.TextEdit
    Private WithEvents lblRefOrder As System.Windows.Forms.Label
    Friend WithEvents btnLocation As DevExpress.XtraEditors.SimpleButton
    Private WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents LocationDTLID As DevExpress.XtraEditors.LookUpEdit
    Private WithEvents lblUpdateStr As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents IsSumStock As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CustomerID As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CusName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Phone1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Fax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Email1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EMPNAME As DevExpress.XtraGrid.Columns.GridColumn
End Class
