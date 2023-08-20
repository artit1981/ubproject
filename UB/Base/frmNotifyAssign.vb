
Public Class frmNotifyAssign
    Private mData As List(Of ShippingRecProperty)
    Public WriteOnly Property TableData() As List(Of ShippingRecProperty)
        Set(ByVal value As List(Of ShippingRecProperty))
            mData = value
        End Set
    End Property

    Private mMenuID As Integer
    Public WriteOnly Property MenuID() As Integer
        Set(ByVal value As Integer)
            mMenuID = value
        End Set
    End Property


    Private Sub frmNotify_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmNotify_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim lcls As New ActivityDAO
        Try
            If mMenuID = MasterType.NotiNotAssign Then
                InsertActivity(DataMode.ModeOpen, MasterType.NotiNotAssign, "", Nothing)
                lcls.SaveActivityLog(MasterType.NotiNotAssign, "", Nothing)
                gIsNotifiNotAssign = True
            Else
                InsertActivity(DataMode.ModeOpen, MasterType.NotiNotSuccess, "", Nothing)
                lcls.SaveActivityLog(MasterType.NotiNotSuccess, "", Nothing)
                gIsNotifiNotSuccess = True
            End If

            GridControl.DataSource = mData
            GridStyle()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub GridStyle()
        With GridView

            .Columns("OrderID").Visible = False
            .Columns("IsSelect").Visible = False


            .Columns("ShippingGroup").Caption = "หน้าจอ"
            .Columns("ShippingGroup").Width = 100
            .Columns("ShippingGroup").MaxWidth = 120
            .Columns("ShippingGroup").OptionsColumn.ReadOnly = True

            .Columns("OrderCode").Caption = "เลขที่"
            .Columns("OrderCode").Width = 100
            .Columns("OrderCode").MaxWidth = 120
            .Columns("OrderCode").OptionsColumn.ReadOnly = True

            .Columns("OrderDate").Caption = "วันที่"
            .Columns("OrderDate").Width = 80
            .Columns("OrderDate").MaxWidth = 90
            .Columns("OrderDate").OptionsColumn.ReadOnly = True

            .Columns("CustomerCode").Caption = "รหัสลูกค้า"
            .Columns("CustomerCode").Width = 90
            .Columns("CustomerCode").MinWidth = 90
            .Columns("CustomerCode").MaxWidth = 160
            .Columns("CustomerCode").OptionsColumn.ReadOnly = True

            .Columns("Customer").Caption = "ลูกค้า"
            .Columns("Customer").OptionsColumn.ReadOnly = True
            .Columns("Customer").Width = 200
            .Columns("Customer").MaxWidth = 0

            .Columns("OrderStatus").Caption = "สถานะ"
            .Columns("OrderStatus").Width = 70
            .Columns("OrderStatus").MaxWidth = 70
            .Columns("OrderStatus").OptionsColumn.ReadOnly = True

            .Columns("GrandTotal").Caption = "ยอดรวม"
            .Columns("GrandTotal").Width = 110
            .Columns("GrandTotal").MaxWidth = 120
            .Columns("GrandTotal").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            .Columns("GrandTotal").DisplayFormat.FormatString = "n2"
            .Columns("GrandTotal").OptionsColumn.ReadOnly = True

            .Columns("ReceiptCode").Caption = "เลขที่ใบเสร็จ"
            .Columns("ReceiptCode").Width = 90
            .Columns("ReceiptCode").MaxWidth = 90
            .Columns("ReceiptCode").OptionsColumn.ReadOnly = True
            .Columns("ReceiptCode").Visible = False

            .Columns("BillCode").Caption = "เลขที่บิล"
            .Columns("BillCode").Width = 90
            .Columns("BillCode").MaxWidth = 90
            .Columns("BillCode").OptionsColumn.ReadOnly = True
            .Columns("BillCode").Visible = False

            .Columns("EMPNAME").Caption = "ผู้รับผิดชอบ"
            .Columns("EMPNAME").Width = 140
            .Columns("EMPNAME").MaxWidth = 150
            .Columns("EMPNAME").OptionsColumn.ReadOnly = True

            .Columns("ShippingPeriod").Caption = "กำหนดเวลาส่ง"
            .Columns("ShippingPeriod").Width = 90
            .Columns("ShippingPeriod").MaxWidth = 90
            .Columns("ShippingPeriod").OptionsColumn.ReadOnly = True


            .Columns("ShippingMethod").Caption = "ลักษณะงาน"
            .Columns("ShippingMethod").Width = 90
            .Columns("ShippingMethod").MaxWidth = 90
            .Columns("ShippingMethod").OptionsColumn.ReadOnly = True
            .Columns("ShippingMethod").Visible = False

            .Columns("ShippingEmp").Caption = "ชื่อผู้ส่ง"
            .Columns("ShippingEmp").Width = 140
            .Columns("ShippingEmp").MaxWidth = 150
            .Columns("ShippingEmp").OptionsColumn.ReadOnly = True


            .Columns("ShippingStatus").Caption = "สถานะ"
            .Columns("ShippingStatus").Width = 90
            .Columns("ShippingStatus").MaxWidth = 90
            .Columns("ShippingStatus").OptionsColumn.ReadOnly = True
            .Columns("ShippingStatus").Visible = False

            .Columns("ShippingRemark").Caption = "หมายเหตุ"
            .Columns("ShippingRemark").Width = 110
            .Columns("ShippingRemark").MaxWidth = 120
            .Columns("ShippingRemark").OptionsColumn.ReadOnly = True

            .Columns("AssignDate").Caption = "วันที่ Assign"
            .Columns("AssignDate").Width = 90
            .Columns("AssignDate").MaxWidth = 100
            .Columns("AssignDate").OptionsColumn.ReadOnly = True

            If mMenuID = MasterType.NotiNotAssign Then
                .Columns("ShippingPeriod").Visible = False
                .Columns("ShippingEmp").Visible = False
                .Columns("ShippingRemark").Visible = False
                .Columns("AssignDate").Visible = False
            End If
        End With
    End Sub
End Class