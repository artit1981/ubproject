
Imports DevExpress.XtraCharts

Public Class frmDashboard
    Private mcls As clsNotifi

    Private Sub frmNotify_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub frmNotify_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

    End Sub

    Private Sub frmNotify_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            InitChartTotalSellByCatalog()
            InitChartTotalSellCOGSByYear()
            InitChartTotalSellProfitByYear()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub InitChartTotalSellByCatalog()
        Try
            Dim SQL = " EXEC [dbo].[spTotalSellByCatalog]"
            SQL &= " @YearList = '2021,2022'"
            SQL &= " ,@MonthList = '1,2,3,4,5,6'"
            Dim dataTable = gConnection.executeSelectQuery(SQL, Nothing)

            Dim series1 As New Series("Series 1", ViewType.Doughnut)
            For Each pRow In dataTable.Rows
                series1.Points.Add(New SeriesPoint(pRow("ProductCategory").ToString, ConvertNullToZero(pRow("TotalAmount"))))
            Next

            ' Add the series to the chart.
            ChartTotalSellByCatalog.Series.Add(series1)

            ' Specify the text pattern of series labels.
            series1.Label.TextPattern = "{VP:P0} ({V:F3}M)"
            series1.LegendTextPattern = "{A}"

            ' Specify how series points are sorted.
            series1.SeriesPointsSorting = SortingMode.Ascending
            series1.SeriesPointsSortingKey = SeriesPointKey.Argument

            series1.ShowInLegend = True
            '' Specify the behavior of series labels.
            CType(series1.Label, DoughnutSeriesLabel).Position = PieSeriesLabelPosition.Outside

            ' Add a title to the chart and hide the legend.
            Dim chartTitle1 As New ChartTitle With {
                .Text = "Total Sale by Catagoly",
                .Font = New Drawing.Font("Segoe UI", 12, FontStyle.Bold)
            }
            ChartTotalSellByCatalog.Titles.Add(chartTitle1)
            ChartTotalSellByCatalog.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True
            ChartTotalSellByCatalog.Legend.Font = New Drawing.Font("Segoe UI", 8, FontStyle.Regular)

            ' Add the chart to the form.
            ChartTotalSellByCatalog.Dock = DockStyle.Fill

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub InitChartTotalSellCOGSByYear()
        Try
            Dim SQL = " EXEC [dbo].[spTotalSellByYear]"
            SQL &= " @YearList = '2020,2021,2022'"
            SQL &= " ,@MonthList = '1,2,3,4,5,6,7,8,9,10,11,12'"
            Dim dataTable = gConnection.executeSelectQuery(SQL, Nothing)

            Dim seriesSale As New Series("Total Sale", ViewType.Bar)
            Dim seriesCOGS As New Series("Total COGS", ViewType.Bar)
            For Each pRow In dataTable.Rows
                seriesSale.Points.Add(New SeriesPoint(pRow("OrderYear").ToString, ConvertNullToZero(pRow("TotalAmount"))))
                seriesCOGS.Points.Add(New SeriesPoint(pRow("OrderYear").ToString, ConvertNullToZero(pRow("Cost"))))
            Next

            ' Add the series to the chart.
            ChartTotalSellCOGSByYear.Series.Add(seriesSale)
            ChartTotalSellCOGSByYear.Series.Add(seriesCOGS)

            ' Specify the text pattern of series labels.
            seriesSale.Label.TextPattern = "{V:#,##0.000,M}"
            seriesCOGS.Label.TextPattern = "{V:#,##0.000,M}"

            seriesSale.ArgumentScaleType = ScaleType.Numerical
            seriesSale.ValueScaleType = ScaleType.Numerical

            seriesCOGS.ArgumentScaleType = ScaleType.Numerical
            seriesCOGS.ValueScaleType = ScaleType.Numerical

            Dim xAxisOptions As NumericScaleOptions = CType(ChartTotalSellCOGSByYear.Diagram, XYDiagram).AxisX.NumericScaleOptions
            xAxisOptions.ScaleMode = ScaleMode.Manual
            xAxisOptions.GridSpacing = 1
            xAxisOptions.GridAlignment = NumericGridAlignment.Ones
            xAxisOptions.AggregateFunction = AggregateFunction.None

            Dim diagram As XYDiagram = CType(ChartTotalSellCOGSByYear.Diagram, XYDiagram)
            ' Customize the appearance of the X-axis title.
            diagram.AxisX.Title.Visible = True
            diagram.AxisX.Title.Alignment = StringAlignment.Center
            diagram.AxisX.Title.Text = "Year"
            diagram.AxisX.Title.TextColor = Color.Gray
            diagram.AxisX.Title.Font = New Font("Tahoma", 8, FontStyle.Bold)

            'xAxisOptions.GridOffset = 100
            'Dim yAxisOptions As NumericScaleOptions = CType(ChartTotalSellCOGSByYear.Diagram, XYDiagram).AxisX.NumericScaleOptions
            'yAxisOptions.MeasureUnit = NumericMeasureUnit.Ones
            ''yAxisOptions.GridSpacing = 500
            ''series1.LegendTextPattern = "{A}"

            seriesSale.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
            seriesCOGS.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True

            ' Specify how series points are sorted.
            'series1.SeriesPointsSorting = SortingMode.Ascending
            'series1.SeriesPointsSortingKey = SeriesPointKey.Argument

            'series1.ShowInLegend = True
            '' Specify the behavior of series labels.
            CType(seriesSale.Label, BarSeriesLabel).Position = BarSeriesLabelPosition.Top
            CType(seriesCOGS.Label, BarSeriesLabel).Position = BarSeriesLabelPosition.Top

            ' Add a title to the chart and hide the legend.
            Dim chartTitle1 As New ChartTitle With {
                .Text = "Total Sale and COGS",
                .Font = New Drawing.Font("Segoe UI", 12, FontStyle.Bold)
            }
            ChartTotalSellCOGSByYear.Titles.Add(chartTitle1)
            ChartTotalSellCOGSByYear.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True
            ChartTotalSellCOGSByYear.Legend.Font = New Drawing.Font("Segoe UI", 8, FontStyle.Regular)

            ' Add the chart to the form.
            ChartTotalSellCOGSByYear.Dock = DockStyle.Fill

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub InitChartTotalSellProfitByYear()
        Try
            Dim SQL = " EXEC [dbo].[spTotalSellByYear]"
            SQL &= " @YearList = '2020,2021,2022'"
            SQL &= " ,@MonthList = '1,2,3,4,5,6,7,8,9,10,11,12'"
            Dim dataTable = gConnection.executeSelectQuery(SQL, Nothing)

            Dim seriesSale As New Series("Total Sale", ViewType.Line)
            Dim seriesProfit As New Series("Total Profit", ViewType.Line)
            For Each pRow In dataTable.Rows
                seriesSale.Points.Add(New SeriesPoint(pRow("OrderYear").ToString, ConvertNullToZero(pRow("TotalAmount"))))
                seriesProfit.Points.Add(New SeriesPoint(pRow("OrderYear").ToString, ConvertNullToZero(pRow("Profit"))))
            Next

            ' Add the series to the chart.
            ChartTotalSellProfitByYear.Series.Add(seriesSale)
            ChartTotalSellProfitByYear.Series.Add(seriesProfit)

            ' Specify the text pattern of series labels.
            seriesSale.Label.TextPattern = "{V:#,##0.000,M}"
            seriesProfit.Label.TextPattern = "{V:#,##0.000,M}"

            seriesSale.ArgumentScaleType = ScaleType.Numerical
            seriesSale.ValueScaleType = ScaleType.Numerical

            seriesProfit.ArgumentScaleType = ScaleType.Numerical
            seriesProfit.ValueScaleType = ScaleType.Numerical

            CType(seriesProfit.View, LineSeriesView).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True
            'CType(seriesProfit.View, LineSeriesView).LineMarkerOptions.Size = 20
            'CType(seriesProfit.View, LineSeriesView).LineMarkerOptions.Kind = MarkerKind.
            'CType(seriesProfit.View, LineSeriesView).LineStyle.DashStyle = DashStyle.Dash

            CType(seriesSale.View, LineSeriesView).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True
            'CType(seriesSale.View, LineSeriesView).LineMarkerOptions.Size = 20
            'CType(seriesSale.View, LineSeriesView).LineMarkerOptions.Kind = MarkerKind.Triangle
            'CType(seriesSale.View, LineSeriesView).LineStyle.DashStyle = DashStyle.Dash

            Dim xAxisOptions As NumericScaleOptions = CType(ChartTotalSellProfitByYear.Diagram, XYDiagram).AxisX.NumericScaleOptions
            xAxisOptions.ScaleMode = ScaleMode.Manual
            xAxisOptions.GridSpacing = 1
            xAxisOptions.GridAlignment = NumericGridAlignment.Ones
            xAxisOptions.AggregateFunction = AggregateFunction.None

            Dim diagram As XYDiagram = CType(ChartTotalSellProfitByYear.Diagram, XYDiagram)
            ' Customize the appearance of the X-axis title.
            diagram.AxisX.Title.Visible = True
            diagram.AxisX.Title.Alignment = StringAlignment.Center
            diagram.AxisX.Title.Text = "Year"
            diagram.AxisX.Title.TextColor = Color.Gray
            diagram.AxisX.Title.Font = New Font("Tahoma", 8, FontStyle.Bold)

            CType(ChartTotalSellProfitByYear.Diagram, XYDiagram).AxisY.Interlaced = True
            CType(ChartTotalSellProfitByYear.Diagram, XYDiagram).AxisY.InterlacedColor = Color.FromArgb(20, 60, 60, 60)
            CType(ChartTotalSellProfitByYear.Diagram, XYDiagram).AxisX.NumericScaleOptions.AutoGrid = False
            CType(ChartTotalSellProfitByYear.Diagram, XYDiagram).AxisX.NumericScaleOptions.GridSpacing = 1


            ' Add a title to the chart and hide the legend.
            Dim chartTitle1 As New ChartTitle With {
                .Text = "Total Sale and Profit",
                .Font = New Drawing.Font("Segoe UI", 12, FontStyle.Bold)
            }
            ChartTotalSellProfitByYear.Titles.Add(chartTitle1)
            ChartTotalSellProfitByYear.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True
            ChartTotalSellProfitByYear.Legend.Font = New Drawing.Font("Segoe UI", 8, FontStyle.Regular)

            ' Add the chart to the form.
            ChartTotalSellProfitByYear.Dock = DockStyle.Fill

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub
End Class