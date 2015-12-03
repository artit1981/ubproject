Option Explicit On

Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Public Class frmTaxAtSellReport
    Inherits iReport
    Private Const mFormName As String = "frmTaxAtSellReport"

    Protected Overrides Sub Print()
        Dim rowHandle As Integer, lOrderID As Long = 0, lTaxNo As String = ""
        Try


            If GridView1.RowCount = 0 Then Exit Sub
            rowHandle = (TryCast(GridControl1.MainView, ColumnView)).FocusedRowHandle

            If rowHandle < 0 Then Exit Sub


            lOrderID = GridView1.GetRowCellDisplayText(rowHandle, "OrderID")
            lTaxNo = GridView1.GetRowCellDisplayText(rowHandle, "TaxNumber")
            If lOrderID > 0 And lTaxNo <> "" Then
                ShowProgress(True, "Loading...")
                PrintTaxAtPay(lOrderID, lTaxNo, ReportDate.EditValue)
            End If
          
        Catch ex As Exception

            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")

        End Try
      
    End Sub

    Protected Overrides Sub ClearAllForm()
        Try
            Dim thisMonth As New Date(DateTime.Today.Year, DateTime.Today.Month, 1)
            Me.DateFrom.EditValue = thisMonth.AddMonths(-1)
            Me.DateTo.EditValue = thisMonth.AddDays(-1)
            Me.ReportDate.EditValue = Now
            SetComboCustomer()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".ClearAllForm : " & e.Message)
        End Try

    End Sub

    Private Sub SetComboCustomer()
        Try
            SetSearchLookCustomer(CustomerID, True, True)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboCustomer : " & e.Message)
        End Try
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Dim lTable As DataTable
        Dim SQL As String, lIndex As Long = 0, lTaxNo As String = ""
        Dim lclsTaxSub As TaxReport

        Dim lTaxList As New List(Of TaxReport)
        Try
            ShowProgress(True, "Loading...")
            SQL = "SELECT Orders.OrderID ,Orders.TaxNumber ,sum(TaxOrder.TaxTotal) as TaxTotal,sum(TaxOrder.TaxAmount) as TaxAmount,Orders.OrderCode  "
            SQL = SQL & " FROM Orders"
            SQL = SQL & " Inner join TaxOrder on TaxOrder.RefOrderID=Orders.OrderID "
            SQL = SQL & " WHERE Orders.IsDelete =0   "
            If ConvertNullToZero(CustomerID.EditValue) > 0 Then
                SQL = SQL & " AND Orders.CustomerID =" & ConvertNullToZero(CustomerID.EditValue)
            End If
            SQL = SQL & " AND Orders.OrderDate Between '" & formatSQLDate(DateFrom.EditValue) & "'"
            SQL = SQL & "                      AND   '" & formatSQLDate(DateTo.EditValue) & "'"
            SQL = SQL & " Group BY Orders.OrderID ,Orders.TaxNumber,Orders.OrderCode "
            SQL = SQL & " ORDER BY Orders.TaxNumber,Orders.OrderCode"

            lTable = gConnection.executeSelectQuery(SQL, Nothing)
            For Each pRow As DataRow In lTable.Rows
                lTaxNo = ConvertNullToString(pRow("TaxNumber"))
                lIndex = lTaxList.FindIndex(Function(m As TaxReport) m.TaxNumber = lTaxNo)
                If lIndex < 0 Then
                    lclsTaxSub = New TaxReport
                    lclsTaxSub.TaxNumber = ConvertNullToString(pRow("TaxNumber"))
                    lclsTaxSub.TaxAmount = ConvertNullToZero(pRow("TaxAmount"))
                    lclsTaxSub.TaxTotal = ConvertNullToZero(pRow("TaxTotal"))
                    lclsTaxSub.OrderCode = ConvertNullToString(pRow("OrderCode"))
                    lclsTaxSub.OrderID = ConvertNullToZero(pRow("OrderID"))
                    lTaxList.Add(lclsTaxSub)
                Else
                    lTaxList.Item(lIndex).OrderID = ConvertNullToZero(pRow("OrderID"))
                    lTaxList.Item(lIndex).OrderCode = lTaxList.Item(lIndex).OrderCode & "," & ConvertNullToString(pRow("OrderCode"))
                    lTaxList.Item(lIndex).TaxAmount = lTaxList.Item(lIndex).TaxAmount + ConvertNullToZero(pRow("TaxAmount"))
                    lTaxList.Item(lIndex).TaxTotal = lTaxList.Item(lIndex).TaxTotal + ConvertNullToZero(pRow("TaxTotal"))
                End If


            Next
            GridControl1.DataSource = lTaxList
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub
End Class

Public Class TaxReport

    Dim mTaxNumber As String
    Dim mTaxTotal As Double
    Dim mTaxAmount As Double
    Dim mOrderCode As String
    Dim mOrderID As Long

    Public Property OrderID() As Long
        Get
            Return mOrderID
        End Get
        Set(ByVal value As Long)
            mOrderID = value
        End Set
    End Property
    Public Property TaxNumber() As String
        Get
            Return mTaxNumber
        End Get
        Set(ByVal value As String)
            mTaxNumber = value
        End Set
    End Property
    Public Property TaxTotal() As Double
        Get
            Return mTaxTotal
        End Get
        Set(ByVal value As Double)
            mTaxTotal = value
        End Set
    End Property
    Public Property TaxAmount() As Double
        Get
            Return mTaxAmount
        End Get
        Set(ByVal value As Double)
            mTaxAmount = value
        End Set
    End Property
    Public Property OrderCode() As String
        Get
            Return mOrderCode
        End Get
        Set(ByVal value As String)
            mOrderCode = value
        End Set
    End Property
End Class