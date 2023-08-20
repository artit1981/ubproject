Option Explicit On

Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class frmShippingRecordDTL
    Private mTypeID As Integer
    Private miOrderListDAO As List(Of iOrder)


    Public WriteOnly Property TypeID() As Integer
        Set(ByVal value As Integer)
            mTypeID = value
        End Set
    End Property

    Public WriteOnly Property iOrderListDAO() As List(Of iOrder)
        Set(ByVal value As List(Of iOrder))
            miOrderListDAO = value
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
            Dim lcls As New EmployeeDAO
            Dim dataTable As New DataTable()
            dataTable = lcls.GetDataTableForCombo(0, True, " and PositionID=1")
            ShippingEmp.Properties.DataSource = dataTable
            ShippingEmp.Properties.DisplayMember = "NAME"
            ShippingEmp.Properties.ValueMember = "ID"


            ShippingPeriod.Properties.Items.Add("ช่วงเช้าเจ้าแรก")
            ShippingPeriod.Properties.Items.Add("ช่วง 9.00-12.00")
            ShippingPeriod.Properties.Items.Add("ช่วง 13.00-17.00")
            ShippingPeriod.Properties.Items.Add("ทั้งวัน")
            ShippingPeriod.SelectedIndex = 3

            ShippingMethod.Properties.Items.Add("ส่งของ + วางบิล")
            ShippingMethod.Properties.Items.Add("ส่งของ + เก็บเงินสด/โอน")
            ShippingMethod.Properties.Items.Add("ส่งของ + เก็บเช็ค")
            ShippingMethod.Properties.Items.Add("ส่งของ")
            ShippingMethod.Properties.Items.Add("เก็บเงินสด/โอน")
            ShippingMethod.Properties.Items.Add("เก็บเช็ค")
            ShippingMethod.Properties.Items.Add("ส่งใบเสร็จ")
            ShippingMethod.Properties.Items.Add("อื่นๆ ระบุ...")
            ShippingMethod.SelectedIndex = 0

            ShippingStatus.Properties.Items.Add("สำเร็จ")
            ShippingStatus.Properties.Items.Add("ไม่สำเร็จ")
            ShippingStatus.Properties.Items.Add("สำเร็จบางส่วน")
            ShippingStatus.Properties.Items.Add("กำลังดำเนินการ")
            ShippingStatus.SelectedIndex = 0

            AssignDate.EditValue = GetCurrentDate(Nothing)
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try


    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click

        Dim tr As SqlTransaction = Nothing
        Dim lUnits As Long = 0
        Try
            If Verify() Then
                If XtraMessageBox.Show(Me, "ยืนยันการบันทึกข้อมูล", "Assign To", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then

                    If mTypeID = 1 Then
                        tr = gConnection.Connection.BeginTransaction

                        For Each pRow In miOrderListDAO
                            Dim lOrder As New OrderSDAO
                            lOrder.ID = pRow.ID
                            lOrder.ShippingPeriod = ShippingPeriod.EditValue.ToString.Trim
                            lOrder.ShippingMethod = ShippingMethod.EditValue.ToString.Trim
                            lOrder.ShippingStatus = ShippingStatus.EditValue.ToString.Trim
                            lOrder.ShippingRemark = ShippingRemark.Text.Trim
                            lOrder.ShippingEmpID = ShippingEmp.EditValue
                            lOrder.AssignEmpID = gUserID
                            lOrder.AssignDate = AssignDate.EditValue
                            lOrder.UpdateAssignShipping(tr)
                        Next

                        tr.Commit()

                    ElseIf mTypeID = 2 Then
                        For Each pRow In miOrderListDAO
                            Dim lOrder As New Shipping2DAO
                            If lOrder.InitailData(pRow.ID) Then
                                lOrder.ShippingPeriod = ShippingPeriod.EditValue.ToString.Trim
                                lOrder.ShippingMethod = ShippingMethod.EditValue.ToString.Trim
                                lOrder.ShippingStatus = ShippingStatus.EditValue.ToString.Trim
                                lOrder.ShippingRemark = ShippingRemark.Text.Trim
                                lOrder.ShippingEmpID = ShippingEmp.EditValue
                                lOrder.AssignEmpID = gUserID
                                lOrder.AssignDate = AssignDate.EditValue
                                lOrder.ModeData = DataMode.ModeEdit
                                lOrder.SaveData()
                            End If

                        Next
                    End If

                    XtraMessageBox.Show(Me, "บันทึกรายการสำเร็จ", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                End If
            Else
                Me.DialogResult = DialogResult.None
            End If
        Catch ex As Exception
            tr.Rollback()
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Function Verify() As Boolean
        Dim lstrErr As String = ""
        Try


            If ConvertNullToZero(ShippingEmp.EditValue) = 0 Then
                lstrErr = "กรุณาระบุผู้ส่ง" & vbNewLine
                ShippingEmp.Focus()
            End If



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