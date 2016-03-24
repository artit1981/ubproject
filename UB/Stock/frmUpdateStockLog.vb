Option Explicit On

Imports DevExpress.XtraEditors
Imports System.Data.SqlClient

Public Class frmUpdateStockLog

    Dim mProductListDAO As ProductListDAO


    Public WriteOnly Property ProductListDAO() As ProductListDAO
        Set(ByVal value As ProductListDAO)
            mProductListDAO = value
        End Set
    End Property


    Private Sub frmSN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Text = "Update stock history"
            ProductCode.EditValue = mProductListDAO.ProductCode
            ProductName.EditValue = mProductListDAO.ProductName

            LoadData()

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LoadData()
        Dim SQL As String = ""
        Dim dataTable As New DataTable()
        Try
            If Not mProductListDAO Is Nothing Then
                SQL = " select Product_LocationDTL.IDCode as Location,Product_Unit.CodeThai AS UnitName "
                SQL = SQL & "  ,Product_Stock_Log.Units,Product_Stock_Log.OrderBy,Product_Stock_Log.LogTime  "
                SQL = SQL & " from Product_Stock_Log"
                SQL = SQL & " inner join Product on Product.ProductID= Product_Stock_Log.ProductID"
                SQL = SQL & " inner join Product_LocationDTL on Product_LocationDTL.LocationDTLID=Product_Stock_Log.LocationDTLID"
                SQL = SQL & " left outer join Product_Unit on Product_Unit.UnitID=Product_Stock_Log.UnitID   "
                SQL = SQL & " WHERE Product_Stock_Log.OrderCode='UpdateStock'"
                SQL = SQL & " AND Product_Stock_Log.ProductID=" & mProductListDAO.ProductID
                If mProductListDAO.UnitID > 0 Then
                    SQL = SQL & " AND Product_Stock_Log.UnitID=" & mProductListDAO.UnitID
                End If
                If mProductListDAO.LocationDTLID > 0 Then
                    SQL = SQL & " AND Product_Stock_Log.LocationDTLID=" & mProductListDAO.LocationDTLID
                End If
                SQL = SQL & " Order By Product_Stock_Log.LogTime Desc "
                dataTable = gConnection.executeSelectQuery(SQL, Nothing)

                If dataTable.Rows.Count > 0 Then
                    gridControl.DataSource = dataTable
                    gridView.ViewCaption = ""
                    gridView.MoveLastVisible()
                    Call GridStyle()
                Else
                    gridControl.DataSource = Nothing
                End If
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "frmUpdateStockLog.LoadData : " & e.Message)
        End Try
    End Sub

    Private Sub GridStyle()
        With gridView
            .Columns("Location").Width = 100
            .Columns("Location").MinWidth = 100
            .Columns("Location").MaxWidth = 200
            .Columns("Location").Caption = "คลังเก็บ"

            .Columns("UnitName").Width = 100
            .Columns("UnitName").MinWidth = 100
            .Columns("UnitName").MaxWidth = 200
            .Columns("UnitName").Caption = "หน่วยนับ"

            .Columns("Units").Caption = "จำนวน"
            .Columns("Units").MinWidth = 50
            .Columns("Units").MaxWidth = 70
            .Columns("Units").Width = 50
            .Columns("Units").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            .Columns("Units").DisplayFormat.FormatString = "n0"

            .Columns("OrderBy").Caption = "ผู้แก้ไข"
            .Columns("OrderBy").Width = 100

            .Columns("LogTime").Caption = "เวลาแก้ไข"
            .Columns("LogTime").Width = 150
            .Columns("LogTime").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            .Columns("LogTime").DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"

        End With
    End Sub
End Class