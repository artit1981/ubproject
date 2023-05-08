Option Explicit On

Public Class frmShippingRecordLog

    Dim mLogTable As DataTable


    Public WriteOnly Property LogTable() As DataTable
        Set(ByVal value As DataTable)
            mLogTable = value
        End Set
    End Property


    Private Sub frmSN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Text = "สรุปงาน"

            LoadData()

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub



    Private Sub LoadData()
        Dim SQL As String = ""
        Dim dataTable As New DataTable()
        Try

            gridControl.DataSource = mLogTable
            gridView.ViewCaption = ""
            'gridView.MoveLastVisible()
            Call GridStyle()

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "frmUpdateStockLog.LoadData : " & e.Message)
        End Try
    End Sub

    Private Sub GridStyle()
        With gridView
            .Columns("ShippingEmp").Width = 100
            .Columns("ShippingEmp").MinWidth = 100
            .Columns("ShippingEmp").MaxWidth = 0
            .Columns("ShippingEmp").Caption = "ผู้ส่ง"


            .Columns("SuccessCount").Caption = "สำเร็จ"
            .Columns("SuccessCount").MinWidth = 50
            .Columns("SuccessCount").MaxWidth = 70
            .Columns("SuccessCount").Width = 50
            .Columns("SuccessCount").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            .Columns("SuccessCount").DisplayFormat.FormatString = "n0"

            .Columns("NotSuccessCount").Caption = "ไม่สำเร็จ"
            .Columns("NotSuccessCount").MinWidth = 50
            .Columns("NotSuccessCount").MaxWidth = 70
            .Columns("NotSuccessCount").Width = 50
            .Columns("NotSuccessCount").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            .Columns("NotSuccessCount").DisplayFormat.FormatString = "n0"

            .Columns("SomeCount").Caption = "สำเร็จบางส่วน"
            .Columns("SomeCount").MinWidth = 50
            .Columns("SomeCount").MaxWidth = 70
            .Columns("SomeCount").Width = 50
            .Columns("SomeCount").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            .Columns("SomeCount").DisplayFormat.FormatString = "n0"

            .Columns("InProcessCount").Caption = "กำลังดำเนินการ"
            .Columns("InProcessCount").MinWidth = 50
            .Columns("InProcessCount").MaxWidth = 70
            .Columns("InProcessCount").Width = 50
            .Columns("InProcessCount").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            .Columns("InProcessCount").DisplayFormat.FormatString = "n0"

        End With
    End Sub
End Class