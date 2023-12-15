Option Explicit On

Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class frmShipping2AddDTL
    Private mIDs As Long

    Public WriteOnly Property IDs() As Long
        Set(ByVal Value As Long)
            mIDs = Value
        End Set
    End Property

    Private Sub frmUpdateStockDTL_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.DialogResult = DialogResult.OK Or Me.DialogResult = DialogResult.Cancel Then
        Else
            e.Cancel = True
        End If
    End Sub


    Private Sub frmUpdateStockDTL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            loadComboEmp()
            loadComboShipping()

            If mIDs > 0 Then
                LoadData()
            Else
                OrderDate.EditValue = GetCurrentDate(Nothing)
                AssignDate.EditValue = GetCurrentDate(Nothing)
            End If
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub loadComboEmp()

        Try
            Dim lcls As New EmployeeDAO
            Dim dataTable As New DataTable()
            dataTable = lcls.GetDataTableForCombo(0, True, "")
            EmpID.Properties.DataSource = dataTable
            EmpID.Properties.DisplayMember = "NAME"
            EmpID.Properties.ValueMember = "ID"

            Dim lclsCus As New CustomerDAO
            Dim dataTableCus As New DataTable()
            lclsCus.TableID = MasterType.Accounts
            dataTableCus = lclsCus.GetDataTableForCombo(True, True, False)
            CustomerID.Properties.DataSource = dataTableCus
            CustomerID.Properties.DisplayMember = "CusName"
            CustomerID.Properties.ValueMember = "CusName"
            CustomerID.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.True
            CustomerID.EditValue = 0

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try

    End Sub

    Private Sub loadComboShipping()
        Try
            Dim lcls As New EmployeeDAO
            Dim dataTable As New DataTable()
            dataTable = lcls.GetDataTableForCombo(0, True, " and PositionID=1")
            ShippingEmp.Properties.DataSource = dataTable
            ShippingEmp.Properties.DisplayMember = "NAME"
            ShippingEmp.Properties.ValueMember = "ID"
            ShippingEmp.EditValue = 0

            ShippingPeriod.Properties.Items.Add("ช่วงเช้าเจ้าแรก")
            ShippingPeriod.Properties.Items.Add("ช่วง 9.00-12.00")
            ShippingPeriod.Properties.Items.Add("ช่วง 13.00-17.00")
            ShippingPeriod.Properties.Items.Add("ทั้งวัน")
            ShippingPeriod.Text = ""
            'ShippingPeriod.SelectedIndex = 3

            ShippingMethod.Properties.Items.Add("ส่งของ + วางบิล")
            ShippingMethod.Properties.Items.Add("ส่งของ + เก็บเงินสด/โอน")
            ShippingMethod.Properties.Items.Add("ส่งของ + เก็บเช็ค")
            ShippingMethod.Properties.Items.Add("ส่งของ")
            ShippingMethod.Properties.Items.Add("เก็บเงินสด/โอน")
            ShippingMethod.Properties.Items.Add("เก็บเช็ค")
            ShippingMethod.Properties.Items.Add("ส่งใบเสร็จ")
            ShippingMethod.Properties.Items.Add("อื่นๆ ระบุ...")
            ShippingMethod.Text = ""
            'ShippingMethod.SelectedIndex = 0

            ShippingStatus.Properties.Items.Add("สำเร็จ")
            ShippingStatus.Properties.Items.Add("ไม่สำเร็จ")
            ShippingStatus.Properties.Items.Add("สำเร็จบางส่วน")
            ShippingStatus.Properties.Items.Add("กำลังดำเนินการ")
            ShippingStatus.Text = ""
            'ShippingStatus.SelectedIndex = 0

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim lOrder As New Shipping2DAO
        Try
            If Verify() Then
                If XtraMessageBox.Show(Me, "ยืนยันการบันทึกข้อมูล", "เพิ่มงานส่งของ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then

                    If mIDs = 0 Then
                        lOrder.ModeData = DataMode.ModeNew
                    Else
                        lOrder.ModeData = DataMode.ModeEdit
                    End If

                    lOrder.OrderID = mIDs
                    lOrder.OrderCode = OrderCode.Text.Trim
                    lOrder.OrderDate = OrderDate.EditValue
                    lOrder.CusName = CustomerID.Text.Trim
                    lOrder.GrandTotal = GrandTotal.EditValue
                    lOrder.ReceiptCode = ReceiptNo.Text.Trim
                    lOrder.BillCode = BillNo.Text.Trim
                    lOrder.EmpID = EmpID.EditValue
                    lOrder.Remark = Remark.Text.Trim

                    'lOrder.ShippingEmpID = ShippingEmp.EditValue
                    'lOrder.ShippingPeriod = ShippingPeriod.Text.Trim
                    'lOrder.ShippingMethod = ShippingMethod.Text.Trim
                    'lOrder.ShippingStatus = ShippingStatus.Text.Trim
                    'lOrder.AssignDate = AssignDate.EditValue
                    'lOrder.AssignEmpID = gUserID
                    lOrder.SaveData()

                    XtraMessageBox.Show(Me, "บันทึกรายการสำเร็จ", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                End If
            Else
                Me.DialogResult = DialogResult.None
            End If
        Catch ex As Exception

            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub LoadData()
        Dim lOrder As New Shipping2DAO

        Try
            If mIDs = 0 Then
                lOrder.ModeData = DataMode.ModeNew
            Else
                lOrder.ModeData = DataMode.ModeEdit
            End If

            If lOrder.InitailData(mIDs) Then
                OrderCode.Text = lOrder.OrderCode
                OrderDate.EditValue = lOrder.OrderDate
                CustomerID.Text = lOrder.CusName
                GrandTotal.EditValue = lOrder.GrandTotal
                ReceiptNo.Text = lOrder.ReceiptCode
                BillNo.Text = lOrder.BillCode
                EmpID.EditValue = lOrder.EmpID
                Remark.Text = lOrder.Remark

                AssignDate.EditValue = lOrder.AssignDate
                ShippingEmp.EditValue = lOrder.ShippingEmpID
                ShippingPeriod.Text = lOrder.ShippingPeriod
                ShippingMethod.Text = lOrder.ShippingMethod
                ShippingStatus.Text = lOrder.ShippingStatus

            End If
        Catch ex As Exception

            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub


    Private Function Verify() As Boolean
        Dim lstrErr As String = ""
        Try

            'If ConvertNullToZero(EmpID.EditValue) = 0 Then
            '    lstrErr = "กรุณาระบุผู้ส่ง" & vbNewLine
            '    EmpID.Focus()
            'End If

            If lstrErr.Trim <> "" Then
                ShowProgress(False, "")
                lstrErr = "พบข้อผิดพลาดกรุณาตรวจสอบ : " & vbNewLine & lstrErr
                XtraMessageBox.Show(Me, lstrErr, "ตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Else
                Return True
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "frmShippingRecordDTL.Verify : " & e.Message)
        End Try
    End Function


End Class