Option Explicit On

Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI

Public Class frmShippingRecReport
    Inherits iReport
    Private Const mFormName As String = "frmShippingRecReport"
    Private mTypeID As Integer

    Public WriteOnly Property TypeID() As Integer
        Set(ByVal value As Integer)
            mTypeID = value
        End Set
    End Property

    Protected Overrides Sub Print()
        Try
            PrintReport()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".Print : " & e.Message)
        End Try
    End Sub

    Protected Overrides Sub ClearAllForm()
        Try
            dtpDateFrom.EditValue = New DateTime(GetCurrentDate(Nothing).Year, 1, 1)
            dtpDateTo.EditValue = GetCurrentDate(Nothing)

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".ClearAllForm : " & e.Message)
        End Try

    End Sub

    Private Sub PrintReport()
        Dim lSeq As Long = 1
        Dim lclsReport As New TmpOrderDAO
        Try
            Dim report = New rptShippingRec

            lclsReport.Header1 = "รายงานบันทึกส่งของ"

            lclsReport.Header2 = "วันที่ " & Format(dtpDateFrom.EditValue, "dd MMMMM yyyy") & " ถึง " & Format(dtpDateTo.EditValue, "dd MMMMM yyyy")

            lclsReport.SaveData()

            Dim dataTable As New DataTable
            If mTypeID = 1 Then
                Dim lcls As New OrderSDAO
                dataTable = lcls.GetDataTableForShippingRec(dtpDateFrom.EditValue, dtpDateTo.EditValue, True, False, 1)
            ElseIf mTypeID = 2 Then
                Dim lcls As New Shipping2DAO
                dataTable = lcls.GetDataTable(dtpDateFrom.EditValue, dtpDateTo.EditValue)
            End If

            If dataTable.Rows.Count > 0 Then
                Dim SQL As String


                SQL = " DELETE FROM TmpTax WHERE UserID=" & gUserID
                gConnection.executeInsertQuery(SQL, Nothing)

                For Each pRow As DataRow In dataTable.Rows

                    SQL = " INSERT INTO TmpTax (UserID,SEQ,[TaxText1],[TaxText2],[TaxText3],[TaxText4],[TaxText5],[TaxText6] "
                    SQL &= " ,[TaxDate1],[TaxText7],[TaxAmount1],[TaxText8],[TaxText9] "
                    SQL &= "  )"
                    SQL &= " VALUES ( " & gUserID
                    SQL &= " ," & lSeq
                    SQL &= " ,'" & ConvertNullToString(pRow("ShippingEmp")) & "'"
                    SQL &= " ,'" & ConvertNullToString(pRow("ShippingMethod")) & "'"
                    SQL &= " ,'" & ConvertNullToString(pRow("ShippingPeriod")) & "'"
                    SQL &= " ,'" & ConvertNullToString(pRow("ShippingStatus")) & "'"
                    SQL &= " ,'" & ConvertNullToString(pRow("ShippingRemark")) & "'"
                    SQL &= " ,'" & ConvertNullToString(pRow("OrderCode")) & "'"
                    SQL &= " ,'" & formatSQLDate(pRow("OrderDate")) & "'"
                    SQL &= " ,'" & ConvertNullToString(pRow("Customer")) & "'"
                    SQL &= " ," & ConvertNullToZero(pRow("GrandTotal"))
                    SQL &= " ,'" & ConvertNullToString(pRow("BillCode")) & "'"
                    SQL &= " ,'" & ConvertNullToString(pRow("ReceiptCode")) & "'"
                    SQL &= " ) "

                    gConnection.executeInsertQuery(SQL, Nothing)

                    lSeq += 1
                Next
                Dim lfrmReport As New frmPreReport
                lfrmReport.InitialForm(MasterType.ShippingRecord, 0, "", GetCurrentDate(Nothing), 0, Nothing, "", Nothing, report)
                lfrmReport.ShowDialog()
            Else
                ShowProgress(False, "")
                XtraMessageBox.Show(Me, "ไม่พบข้อมูลบันทึกส่งของ", "บันทึกส่งของ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".PrintReport : " & ex.Message)
        Finally
        End Try
    End Sub

End Class
