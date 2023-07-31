
Option Explicit On
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class frmShippingRecordMain




    Private Sub LoadData()
        Dim lcls As New OrderSDAO
        Dim lList As New List(Of ShippingRecProperty)

        Try
            Dim dataTable = lcls.GetDataTableForShippingRec(dtpDateFrom.EditValue, dtpDateTo.EditValue, False, False, 1)
            For Each pRow In dataTable.Rows
                Dim lRecProperty As New ShippingRecProperty
                lRecProperty.IsSelect = False
                lRecProperty.OrderID = pRow("OrderID")
                lRecProperty.OrderCode = pRow("OrderCode").ToString.Trim
                lRecProperty.OrderDate = pRow("OrderDate")
                lRecProperty.CustomerCode = pRow("CustomerCode").ToString.Trim
                lRecProperty.Customer = pRow("Customer").ToString.Trim
                lRecProperty.OrderStatus = pRow("OrderStatus").ToString.Trim
                lRecProperty.GrandTotal = ConvertNullToZero(pRow("GrandTotal"))
                lRecProperty.ReceiptCode = pRow("ReceiptCode").ToString.Trim
                lRecProperty.BillCode = pRow("BillCode").ToString.Trim
                lRecProperty.EMPNAME = pRow("EMPNAME").ToString.Trim
                lRecProperty.ShippingPeriod = pRow("ShippingPeriod").ToString.Trim
                lRecProperty.ShippingMethod = pRow("ShippingMethod").ToString.Trim
                lRecProperty.ShippingEmp = pRow("ShippingEmp").ToString.Trim
                lRecProperty.ShippingStatus = pRow("ShippingStatus").ToString.Trim
                lRecProperty.ShippingRemark = pRow("ShippingRemark").ToString.Trim
                lList.Add(lRecProperty)
            Next
            GridControl.DataSource = lList

            GridStyle()

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "frmBankAccountRec.LoadData : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    Private Sub GridStyle()
        With GridView

            .Columns("OrderID").Visible = False
            '.Columns("IsSelect").Visible = False

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

            .Columns("BillCode").Caption = "เลขที่บิล"
            .Columns("BillCode").Width = 90
            .Columns("BillCode").MaxWidth = 90
            .Columns("BillCode").OptionsColumn.ReadOnly = True

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

            .Columns("ShippingEmp").Caption = "ชื่อผู้ส่ง"
            .Columns("ShippingEmp").Width = 140
            .Columns("ShippingEmp").MaxWidth = 150
            .Columns("ShippingEmp").OptionsColumn.ReadOnly = True

            .Columns("ShippingStatus").Caption = "สถานะ"
            .Columns("ShippingStatus").Width = 90
            .Columns("ShippingStatus").MaxWidth = 90
            .Columns("ShippingStatus").OptionsColumn.ReadOnly = True

            .Columns("ShippingRemark").Caption = "หมายเหตุ"
            .Columns("ShippingRemark").Width = 110
            .Columns("ShippingRemark").MaxWidth = 120
            .Columns("ShippingRemark").OptionsColumn.ReadOnly = True

        End With
    End Sub


    Private Sub RefreshBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles RefreshBar.ItemClick
        Try
            ShowProgress(True, "Loading...")
            Call LoadData()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub ExitBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ExitBar.ItemClick
        Me.Close()
    End Sub


    Private Sub frmShippingRecordMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            dtpDateFrom.EditValue = New DateTime(GetCurrentDate(Nothing).Year, 1, 1)
            dtpDateTo.EditValue = GetCurrentDate(Nothing)



            Call LoadData()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AssignToBar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles AssignToBar.ItemClick
        Try
            Dim llRow As Long = 0
            Dim lList As New List(Of iOrder)
            For lRow = 0 To GridView.RowCount
                If GridView.GetRowCellValue(lRow, "IsSelect") = True Then
                    Dim liorder As New iOrder With {
                            .ID = GridView.GetRowCellValue(lRow, "OrderID")
                        }
                    lList.Add(liorder)
                End If
            Next
            If lList.Count > 0 Then
                Dim lFrmEdit As New frmShippingRecordDTL
                lFrmEdit.iOrderListDAO = lList
                lFrmEdit.TypeID = 1
                Dim lResult = lFrmEdit.ShowDialog()
                If lResult = DialogResult.OK Then
                    LoadData()
                End If
            End If
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)

        End Try

    End Sub

    Private Sub SummaryBar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles SummaryBar.ItemClick
        Try
            Dim lcls As New OrderSDAO
            Dim dataTable = lcls.GetDataTableForShippingRecSummary(dtpDateFrom.EditValue, dtpDateTo.EditValue)
            Dim lFrmEdit As New frmShippingRecordLog
            lFrmEdit.LogTable = dataTable
            Dim lResult = lFrmEdit.ShowDialog()

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)

        End Try

    End Sub

    Private Sub PrintBar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles PrintBar.ItemClick
        Try

            Dim lFrmEdit As New frmShippingRecReport
            'lFrmEdit.Parent = frmMain
            lFrmEdit.TypeID = 1
            lFrmEdit.Show()

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)

        End Try

    End Sub
End Class



Public Class ShippingRecProperty

    Private mClassName As String = "ShippingRecProperty"

#Region "Property"



    Dim mIsSelect As Boolean

    Public Property IsSelect() As Boolean
        Get
            Return mIsSelect
        End Get
        Set(ByVal value As Boolean)
            mIsSelect = value
        End Set
    End Property

    Private mShippingGroup As String
    Public Property ShippingGroup() As String
        Get
            Return mShippingGroup
        End Get
        Set(ByVal value As String)
            mShippingGroup = value
        End Set
    End Property

    Private mOrderCode As String
    Public Property OrderCode() As String
        Get
            Return mOrderCode
        End Get
        Set(ByVal value As String)
            mOrderCode = value
        End Set
    End Property

    Private mOrderDate As Date
    Public Property OrderDate() As Date
        Get
            Return mOrderDate
        End Get
        Set(ByVal value As Date)
            mOrderDate = value
        End Set
    End Property


    Private mCustomerCode As String
    Public Property CustomerCode() As String
        Get
            Return mCustomerCode
        End Get
        Set(ByVal value As String)
            mCustomerCode = value
        End Set
    End Property

    Private mCustomer As String
    Public Property Customer() As String
        Get
            Return mCustomer
        End Get
        Set(ByVal value As String)
            mCustomer = value
        End Set
    End Property

    Private mOrderStatus As String
    Public Property OrderStatus() As String
        Get
            Return mOrderStatus
        End Get
        Set(ByVal value As String)
            mOrderStatus = value
        End Set
    End Property




    Private mGrandTotal As Decimal
    Public Property GrandTotal() As Decimal
        Get
            Return mGrandTotal
        End Get
        Set(ByVal value As Decimal)
            mGrandTotal = value
        End Set
    End Property



    Dim mReceiptCode As String = ""
    Public Property ReceiptCode() As String
        Get
            Return mReceiptCode
        End Get
        Set(ByVal value As String)
            mReceiptCode = value
        End Set
    End Property
    Dim mBillCode As String = ""
    Public Property BillCode() As String
        Get
            Return mBillCode
        End Get
        Set(ByVal value As String)
            mBillCode = value
        End Set
    End Property

    Dim mEMPNAME As String = ""
    Public Property EMPNAME() As String
        Get
            Return mEMPNAME
        End Get
        Set(ByVal value As String)
            mEMPNAME = value
        End Set
    End Property

    Dim mShippingPeriod As String = ""
    Public Property ShippingPeriod() As String
        Get
            Return mShippingPeriod
        End Get
        Set(ByVal value As String)
            mShippingPeriod = value
        End Set
    End Property

    Dim mShippingMethod As String = ""
    Public Property ShippingMethod() As String
        Get
            Return mShippingMethod
        End Get
        Set(ByVal value As String)
            mShippingMethod = value
        End Set
    End Property


    Dim mShippingEmp As String = ""
    Public Property ShippingEmp() As String
        Get
            Return mShippingEmp
        End Get
        Set(ByVal value As String)
            mShippingEmp = value
        End Set
    End Property


    Dim mShippingStatus As String = ""
    Public Property ShippingStatus() As String
        Get
            Return mShippingStatus
        End Get
        Set(ByVal value As String)
            mShippingStatus = value
        End Set
    End Property

    Dim mShippingRemark As String = ""
    Public Property ShippingRemark() As String
        Get
            Return mShippingRemark
        End Get
        Set(ByVal value As String)
            mShippingRemark = value
        End Set
    End Property

    ''Hide
    Dim mOrderID As Long = 0
    Public Property OrderID() As Long
        Get
            Return mOrderID
        End Get
        Set(ByVal value As Long)
            mOrderID = value
        End Set
    End Property


#End Region



End Class