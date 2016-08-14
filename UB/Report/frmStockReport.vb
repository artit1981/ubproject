Option Explicit On
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraEditors
Imports System.Data.SqlClient

Public Class frmStockReport
    Inherits iReport
    Private Const mFormName As String = "frmStockReport"

    Protected Overrides Sub Print()
        Try
            PrintReport()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".Print : " & e.Message)
        End Try
    End Sub

    Protected Overrides Sub ClearAllForm()
        Try
            ReportType.EditValue = "A"
            SetComboProductType("", ProductTypeID)
            SetComboProductBrand("", ProductBrandID)

            ProductTypeID.CheckAll()
            ProductBrandID.CheckAll()
            SetComboProduct()
 
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".ClearAllForm : " & e.Message)
        End Try

    End Sub

    Private Sub SetComboProduct()
        Dim dataTable As New DataTable()
        Dim lcls As New ProductDAO
        Dim lSQL As String = "", sQN As String = ""

        Try
            'ProductType
            For Each item As Object In ProductTypeID.CheckedItems
                Dim row As DataRowView = CType(item, DataRowView)
                If sQN = "" Then
                    sQN = ConvertNullToString(row(0))
                Else
                    sQN = sQN & "," & ConvertNullToZero(row(0))
                End If
            Next
            If sQN <> "" Then
                lSQL = " and Product.ProductTypeID in (" & sQN & ") "
            End If




            'ProductBrand
            sQN = ""
            For Each item As Object In ProductBrandID.CheckedItems
                Dim row As DataRowView = CType(item, DataRowView)
                If sQN = "" Then
                    sQN = ConvertNullToString(row(0))
                Else
                    sQN = sQN & "," & ConvertNullToZero(row(0))
                End If
            Next
            If sQN <> "" Then
                lSQL = lSQL & " and Product.ProductBrandID in (" & sQN & ") "
            End If


            'Product
            dataTable = Nothing
            dataTable = lcls.GetDataTableForCombo(0, 0, True, "", lSQL)
            UcMoverItem1.ShowControl(dataTable, "ID", "ProductName")
            
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboProduct : " & e.Message)
        Finally
            dataTable = Nothing
        End Try

    End Sub

    Private Sub PrintReport()
        Dim report As New XtraReport
        Dim lclsReport As New TmpOrderDAO
        Try
            'Set company header
            BuildCompanyAddress(lclsReport)

            lclsReport.Header1 = "รายงานมูลค่าสต๊อกคลังสินค้า"
            report = New rptStockReport

            lclsReport.Header2 = "" 
            lclsReport.Header3 = ""
            lclsReport.SaveData()

            Dim lTableOrder As New DataTable
            Dim SQL As String


            'Build Product List
            Dim lProductList As String = UcMoverItem1.GetSelectItem

            'Clear Tmp
            SQL = " DELETE FROM TmpTax WHERE UserID=" & gUserID
            gConnection.executeInsertQuery(SQL, Nothing)

            SQL = " INSERT INTO TmpTax (UserID,SEQ,TaxTotal1,TaxText1,TaxText2,TaxText3,TaxText4,TaxTotal2,TaxTotal3 )"
            SQL &= " select " & gUserID & ",0,a.ProductID,b.ProductCode,left(b.ProductName,100),c.NameThai,d.CodeThai ,a.Units "
            If ReportType.EditValue = "A" Then
                SQL &= ",Cost.Cost"
            Else
                SQL &= ",b.Price1"
            End If
            SQL &= " from Product_Stock a"
            SQL &= " left outer join Product b on a.ProductID=b.ProductID"
            SQL &= " left outer join Product_LocationDTL c on a.LocationDTLID=c.LocationDTLID"
            SQL &= " left outer join Product_Unit d on a.UnitID=d.UnitID"
            SQL &= " left outer join Product_CostAVG Cost on Cost.ProductID=a.ProductID and Cost.IsDelete=0"
            SQL &= " where  1=1 "
            If lProductList <> "" Then
                SQL = SQL & " and a.ProductID in(" & lProductList & ")"
            End If
            gConnection.executeInsertQuery(SQL, Nothing)


            SQL = " SELECT UserID FROM TmpTax WHERE UserID=" & gUserID

            lTableOrder = gConnection.executeSelectQuery(SQL, Nothing)
            If lTableOrder.Rows.Count > 0 Then
                ExecuteReportComm(report)
            Else
                ShowProgress(False, "")
                XtraMessageBox.Show(Me, "ไม่พบรายการ", "รายงาน", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".PrintReport : " & ex.Message)
        Finally
        End Try
    End Sub

 

    Private Sub ProductBrandID_LostFocus(sender As Object, e As System.EventArgs) Handles ProductBrandID.LostFocus
        SetComboProduct()
    End Sub

    Private Sub ProductTypeID_LostFocus(sender As Object, e As System.EventArgs) Handles ProductTypeID.LostFocus
        SetComboProduct()
    End Sub
 
End Class
