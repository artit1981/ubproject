Option Explicit On
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class frmSNList
    Inherits iEditForm

    Private Const mFormName As String = "frmSNList"
    Private mIsFromLoad As Boolean

#Region "Overrides"
    Protected Overrides Sub OnLoadForm(ByVal pMode As Integer, ByVal pID As Long, ByVal pOrderType As Long, ByVal pclsConvert As iOrder, ByVal pCusID As Long)
        Try
            SaveBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            PrintBar2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Addbar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            PrintPaymantBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            chkShowDelete.Checked = False

            mIsFromLoad = True
            dtpDateFrom.EditValue = DateAdd(DateInterval.Month, -3, Now)
            dtpDateTo.EditValue = Now
            LoadData()

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".OnLoadForm : " & e.Message)
        Finally
            mIsFromLoad = False
        End Try
    End Sub

    Protected Overrides Sub ClearAllForm(ByVal pMode As Integer)
        Try
            mIsFromLoad = True
            MyBase.ClearAllForm(pMode)


        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".ClearAllForm : " & e.Message)
        Finally
            mIsFromLoad = False
        End Try
    End Sub

    Protected Overrides Function Save(ByVal pMode As Integer, ByVal pID As Long) As Boolean

        Try

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".Save : " & ex.Message)
            Return False
        End Try
    End Function

    Protected Overrides Sub OnClosedForm()
        'mcls = Nothing

    End Sub
#End Region

#Region "Event"


#End Region

#Region "Private"


    Private Function LoadData() As Boolean
        Dim SQL As String = ""
        Dim dataTable As New DataTable()
        Try

            SQL = "  select Product.ProductCode,Product.ProductName,SerialNumber.SerialNumberNo"
            SQL = SQL & "  ,Orders.OrderCode as InCode,Orders.OrderDate as InDate"
            SQL = SQL & "  ,sell.OrderCode as OutCode,sell.OrderDate as OutDate,SerialNumber.Status"
            SQL = SQL & "  "
            SQL = SQL & "  from SerialNumber"
            SQL = SQL & "  inner join Orders on Orders.OrderID=SerialNumber.OrderID and Orders.TableID in(40,69)"
            SQL = SQL & "  inner join Product on Product.ProductID=SerialNumber.ProductID and Product.IsDelete=0"
            SQL = SQL & "  left outer join SerialNumber as sellsn on sellsn.SerialNumberNo=SerialNumber.SerialNumberNo "
            SQL = SQL & "  and sellsn.IsDelete=0 and sellsn.OrderID in (select OrderID from Orders where TableID in(34,54,55,61,62) and Orders.IsDelete=0)"
            SQL = SQL & "  and sellsn.ProductID=Product.ProductID"
            SQL = SQL & "  left outer join Orders as sell on sell.OrderID=sellsn.OrderID   and sell.IsDelete=0"
            SQL = SQL & "  where SerialNumber.IsDelete=0 and Orders.IsDelete=0 "
            SQL = SQL & " and Orders.OrderDate between '" & formatSQLDate(dtpDateFrom.EditValue) & "'" & "  and '" & formatSQLDate(dtpDateTo.EditValue) & "'"
            'If chkShowDelete.Checked = False Then
            '    SQL = SQL & "  AND Orders.IsDelete = 0"
            '    SQL = SQL & "  AND Orders.IsCancel = 0"
            'End If
            SQL = SQL & " order by Product.ProductCode,SerialNumber.SerialNumberNo "
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)

            If dataTable.Rows.Count > 0 Then
                gridControl.DataSource = dataTable
                gridView.ViewCaption = ""
                gridView.MoveLastVisible()
                Call GridStyle()
            Else
                gridControl.DataSource = Nothing
            End If


        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".LoadData : " & ex.Message)
            Return False
        Finally
            'lcls = Nothing
            'dataTable = Nothing
        End Try
    End Function

    Private Sub GridStyle()
        With gridView
            .Columns("ProductCode").Caption = "รหัสสินค้า"
            .Columns("ProductCode").Width = 80
            .Columns("ProductName").Caption = "ชื่อสินค้า"
            .Columns("ProductName").Width = 150
            .Columns("SerialNumberNo").Caption = "Serial Number"
            .Columns("SerialNumberNo").Width = 100
            .Columns("InCode").Caption = "เลขที่นำเข้า"
            .Columns("InCode").Width = 80
            .Columns("InDate").Caption = "วันที่นำเข้า"
            .Columns("InDate").Width = 50
            .Columns("OutCode").Caption = "เลขที่ขาย"
            .Columns("OutCode").Width = 80
            .Columns("OutDate").Caption = "วันที่ขาย"
            .Columns("OutDate").Width = 50
            .Columns("Status").Width = 40
            .Columns("Status").Caption = "สถานะ"
        End With
    End Sub

#End Region

    'Private Sub GridView_RowStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles gridView.RowStyle
    '    Dim lData As Integer = 0
    '    If DatePanel.Visible = True Then
    '        If (e.RowHandle >= 0) Then

    '            lData = GridView.GetRowCellValue(e.RowHandle, GridView.Columns("IsDelete"))
    '            If lData = 1 Then
    '                e.Appearance.BackColor = Color.WhiteSmoke
    '                e.Appearance.ForeColor = Color.Red
    '            End If

    '        End If
    '    End If

    'End Sub


    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Try
            ShowProgress(True, "Loading...")
            LoadData()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub btnExportExcel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExportExcel.Click
        Try
            ShowProgress(True, "Exporting...")
            gridControl.ExportToXlsx("C:\SerialNumberHistory.xlsx")
            Process.Start("C:\SerialNumberHistory.xlsx")
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub btnExportPDF_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExportPDF.Click
        Try
            ShowProgress(True, "Exporting...")
            gridControl.ExportToPdf("C:\SerialNumberHistory.pdf")
            Process.Start("C:\SerialNumberHistory.pdf")
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub btnExportWord_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExportWord.Click
        Try
            ShowProgress(True, "Exporting...")
            gridControl.ExportToRtf("C:\SerialNumberHistory.rtf")
            Process.Start("C:\SerialNumberHistory.rtf")
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub
End Class