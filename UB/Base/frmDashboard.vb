
Imports DevExpress.XtraCharts

Public Class frmDashboard
    Private mcls As clsNotifi

    Private Sub frmNotify_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub frmNotify_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

    End Sub

    Private Sub frmNotify_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            Dim series1 As New Series("Series 1", ViewType.Doughnut3D)




            SQL = " EXEC [dbo].[spTotalSellByCatalog]"
            SQL = SQL & " @FromDate = '2022-01-01'"
            SQL = SQL & " ,@ToDate = '2022-05-01'"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)

            For Each pRow In dataTable.Rows
                series1.Points.Add(New SeriesPoint(pRow("ProductCategory").ToString, ConvertNullToZero(pRow("TotalAmount"))))
            Next

            ' Add the series to the chart.
            ChartTotalSellByCatalog.Series.Add(series1)

            ' Specify the text pattern of series labels.
            series1.Label.TextPattern = "{VP:P0} ({V:F2}M)"
            series1.LegendTextPattern = "{A}"

            ' Specify how series points are sorted.
            series1.SeriesPointsSorting = SortingMode.Ascending
            series1.SeriesPointsSortingKey = SeriesPointKey.Argument

            series1.ShowInLegend = True
            '' Specify the behavior of series labels.
            CType(series1.Label, Doughnut3DSeriesLabel).Position = PieSeriesLabelPosition.TwoColumns

            ' Add a title to the chart and hide the legend.
            Dim chartTitle1 As New ChartTitle()
            chartTitle1.Text = "Total Sale by Catagoly"
            ChartTotalSellByCatalog.Titles.Add(chartTitle1)
            ChartTotalSellByCatalog.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True


            ' Add the chart to the form.
            ChartTotalSellByCatalog.Dock = DockStyle.Fill

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub
End Class