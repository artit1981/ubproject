
Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGauges.Core.Model
Imports DevExpress.XtraGauges.Win.Gauges.Circular
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraTreeMap

Public Class frmDashboard
    Private mYearList As String
    Private mMonthList As String
    Private mFromDate As Date
    Private mToDate As Date
    Private mTotalSell As Double

    Private Sub frmDashboard_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub frmDashboard_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

    End Sub

    Private Sub frmDashboard_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            InitCondition()
            LoadData()

            ' Add a title to the chart and hide the legend.
            Dim chartTitle1 As New ChartTitle With {
                .Text = "Total Sale by Catagoly",
                .Font = New Drawing.Font("Segoe UI", 12, FontStyle.Bold)
            }
            ChartTotalSellByCatalog.Titles.Add(chartTitle1)

            chartTitle1 = New ChartTitle With {
                .Text = "Total Sale and COGS",
                .Font = New Drawing.Font("Segoe UI", 12, FontStyle.Bold)
            }
            ChartTotalSellCOGSByYear.Titles.Add(chartTitle1)

            chartTitle1 = New ChartTitle With {
                .Text = "Total Sale and Profit",
                .Font = New Drawing.Font("Segoe UI", 12, FontStyle.Bold)
            }
            ChartTotalSellProfitByYear.Titles.Add(chartTitle1)

            chartTitle1 = New ChartTitle With {
                .Text = "ยอดขายรวม :" & mTotalSell & " M",
                .Font = New Drawing.Font("Segoe UI", 12, FontStyle.Bold)
            }
            overdueChart.Titles.Add(chartTitle1)


        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub
    Private Sub LoadData()
        Try

            Me.Cursor = Cursors.WaitCursor

            GetCondition()
            InitChartTotalSellByCatalog()
            InitChartTotalSellCOGSByYear()
            InitChartTotalSellProfitByYear()
            InitChartBankBalance()
            InitGridBrand()
            InitOverdueGauge()
            Me.Cursor = Cursors.Default
        Catch ex As Exception

            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub
    Private Sub InitCondition()
        Dim lYear As Integer = Now.Year


        For i = 0 To 10
            If i <= 1 Then
                Dim lCheckedListBoxItem = New CheckedListBoxItem(lYear, True)
                ListYear.Items.Add(lCheckedListBoxItem)
            Else
                Dim lCheckedListBoxItem = New CheckedListBoxItem(lYear, False)
                ListYear.Items.Add(lCheckedListBoxItem)
            End If

            lYear -= 1
        Next

        Dim items() As CheckedListBoxItem = {
              New CheckedListBoxItem("January", True), New CheckedListBoxItem("February", True),
              New CheckedListBoxItem("March", True), New CheckedListBoxItem("April", True),
              New CheckedListBoxItem("May", True), New CheckedListBoxItem("June", True),
              New CheckedListBoxItem("July", True), New CheckedListBoxItem("August", True),
              New CheckedListBoxItem("September", True), New CheckedListBoxItem("October", True),
              New CheckedListBoxItem("November", True), New CheckedListBoxItem("December", True)}
        ListMonth.Items.AddRange(items)
    End Sub

    Private Sub GetCondition()
        Dim lYearList As String = ""
        For Each item As Object In ListYear.CheckedItems
            'Dim row As DataRowView = CType(item, DataRowView)
            If lYearList = "" Then
                lYearList = ConvertNullToZero(item.ToString)
            Else
                lYearList += "," & ConvertNullToZero(item.ToString)
            End If
        Next
        mYearList = lYearList

        Dim lMonthList As String = ""
        For Each item As Object In ListMonth.CheckedItems
            'Dim row As DataRowView = CType(item, DataRowView)
            If lMonthList = "" Then
                lMonthList = GetMonthNumber(item.ToString)
            Else
                lMonthList += "," & GetMonthNumber(item.ToString)
            End If
        Next
        mMonthList = lMonthList

        'Init From To Date
        Dim lMonthFrom As Integer, lMonthTo As Integer, lYearFrom As Integer, lYearTo As Integer
        If ListYear.CheckedItems.Count > 0 Then
            lYearTo = ListYear.CheckedItems(0).ToString
            lYearFrom = ListYear.CheckedItems(ListYear.CheckedItems.Count - 1).ToString
        End If

        If ListMonth.CheckedItems.Count > 0 Then
            lMonthFrom = GetMonthNumber(ListMonth.CheckedItems(0).ToString)
            lMonthTo = GetMonthNumber(ListMonth.CheckedItems(ListMonth.CheckedItems.Count - 1).ToString)
        End If
        'If Now.Year > 2500 Then
        lYearFrom += 543
        lYearTo += 543
        'End If
        mFromDate = DateSerial(lYearFrom, lMonthFrom, 1)
        mToDate = DateSerial(lYearTo, lMonthTo, Date.DaysInMonth(lYearTo, lMonthTo))
    End Sub

    Private Function GetMonthNumber(ByVal pMonthName As String) As Integer
        Dim lGetMonthNumber As String

        lGetMonthNumber = Month(DateValue("1 " & pMonthName & " 2020"))
        Return Integer.Parse(lGetMonthNumber)

    End Function
    Private Sub InitChartTotalSellByCatalog()
        Try
            Dim SQL = " EXEC [dbo].[spTotalSellByCatalog]"
            SQL &= " @YearList = '" & mYearList & "'"
            SQL &= " ,@MonthList = '" & mMonthList & "'"
            Dim dataTable = gConnection.executeSelectQuery(SQL, Nothing)

            Dim series1 As New Series("Series 1", ViewType.Doughnut)
            For Each pRow In dataTable.Rows
                series1.Points.Add(New SeriesPoint(pRow("ProductCategory").ToString, ConvertNullToZero(pRow("TotalAmount"))))
            Next
            ChartTotalSellByCatalog.Series.Clear()

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

            Dim totalLabel As PieTotalLabel = CType(ChartTotalSellByCatalog.Series("Series 1").View, DoughnutSeriesView).TotalLabel
            totalLabel.Visible = True
            totalLabel.TextPattern = "Total" & vbLf & "{V:F3}M".ToString()

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
            Dim lTotalSell As Double = 0, lTotalCOGS As Double = 0, lTotalProfit As Double = 0, lTotalProfitPercen As Double = 0

            Dim SQL = " EXEC [dbo].[spTotalSellByYear]"
            SQL &= " @YearList = '" & mYearList & "'"
            SQL &= " ,@MonthList = '" & mMonthList & "'"
            Dim dataTable = gConnection.executeSelectQuery(SQL, Nothing)

            Dim seriesSale As New Series("Total Sale", ViewType.Bar)
            Dim seriesCOGS As New Series("Total COGS", ViewType.Bar)
            For Each pRow In dataTable.Rows
                seriesSale.Points.Add(New SeriesPoint(pRow("OrderYear").ToString, ConvertNullToZero(pRow("TotalAmount"))))
                seriesCOGS.Points.Add(New SeriesPoint(pRow("OrderYear").ToString, ConvertNullToZero(pRow("Cost"))))

                lTotalSell += ConvertNullToZero(pRow("TotalAmount"))
                lTotalCOGS += ConvertNullToZero(pRow("Cost"))
                lTotalProfit += ConvertNullToZero(pRow("Profit"))
            Next
            mTotalSell = lTotalSell
            txtTotalSell.Text = lTotalSell.ToString("#,##0.00") & " M"
            txtCOGS.Text = lTotalCOGS.ToString("#,##0.00") & " M"
            txtProfit.Text = lTotalProfit.ToString("#,##0.00") & " M"
            txtProfitPercen.Text = ((lTotalProfit / lTotalSell) * 100).ToString("#,##0.00") & " %"

            ChartTotalSellCOGSByYear.Series.Clear()
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
            SQL &= " @YearList = '" & mYearList & "'"
            SQL &= " ,@MonthList = '" & mMonthList & "'"
            Dim dataTable = gConnection.executeSelectQuery(SQL, Nothing)

            Dim seriesSale As New Series("Total Sale", ViewType.Line)
            Dim seriesProfit As New Series("Total Profit", ViewType.Line)
            For Each pRow In dataTable.Rows
                seriesSale.Points.Add(New SeriesPoint(pRow("OrderYear").ToString, ConvertNullToZero(pRow("TotalAmount"))))
                seriesProfit.Points.Add(New SeriesPoint(pRow("OrderYear").ToString, ConvertNullToZero(pRow("Profit"))))
            Next

            ChartTotalSellProfitByYear.Series.Clear()
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



            ChartTotalSellProfitByYear.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True
            ChartTotalSellProfitByYear.Legend.Font = New Drawing.Font("Segoe UI", 8, FontStyle.Regular)

            ' Add the chart to the form.
            ChartTotalSellProfitByYear.Dock = DockStyle.Fill

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub InitChartBankBalance()
        Try
            Dim lTotalCash As Double = 0

            Dim SQL = " EXEC [dbo].[spBankBalance]"
            SQL &= " @YearList = '" & mYearList & "'"
            SQL &= " ,@MonthList = '" & mMonthList & "'"
            Dim dataTable = gConnection.executeSelectQuery(SQL, Nothing)


            Dim storage As New TreeMapItemStorage()
            BankAccTreeMap.DataAdapter = storage

            Dim BankGroup As TreeMapItem = New TreeMapItem With {.Label = "ยอดเงินในธนาคาร"}

            For Each pRow In dataTable.Rows
                BankGroup.Children.Add(New TreeMapItem With {.Label = pRow("BankCode").ToString, .Value = ConvertNullToZero(pRow("AccountAmount"))})
                lTotalCash += ConvertNullToZero(pRow("AccountAmount"))
            Next

            txtCash.Text = lTotalCash.ToString("#,##0.00") & " M"

            storage.Items.Add(BankGroup)

            BankAccTreeMap.Colorizer = New TreeMapPaletteColorizer With {.ColorizeGroups = False, .Palette = DevExpress.XtraTreeMap.Palette.OfficePalette}
            BankAccTreeMap.LeafTextPattern = "{L} {V} M"
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub InitGridBrand()
        Try
            Dim SQL = " EXEC [dbo].[spTotalSellByBrand]"
            SQL &= " @YearList = '" & mYearList & "'"
            SQL &= " ,@MonthList = '" & mMonthList & "'"
            Dim dataTable = gConnection.executeSelectQuery(SQL, Nothing)

            GridControl1.DataSource = dataTable
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub InitOverdueGauge()
        Try
            Dim series1 As New Series("Series 1", ViewType.Pie3D)

            'Overdue
            Dim SQL = " EXEC [dbo].spOverdueTX"
            SQL &= " @FromDate = '" & formatSQLDate(mFromDate) & "'"
            SQL &= " ,@ToDate = '" & formatSQLDate(mToDate) & "'"
            Dim dataTable = gConnection.executeSelectQuery(SQL, Nothing)

            If dataTable.Rows.Count > 0 Then
                Dim lsumPayTotal = Double.Parse((dataTable.Compute("SUM(PayTotal)", "")))
                lsumPayTotal /= 1000000
                series1.Points.Add(New SeriesPoint("ยอดหนี้คงค้าง", lsumPayTotal))

                'Total sell

                series1.Points.Add(New SeriesPoint("ยอดชำระ", mTotalSell - lsumPayTotal))
                overdueChart.Series.Clear()

                ' Add the series to the chart.
                overdueChart.Series.Add(series1)

                ' Specify the text pattern of series labels.
                series1.Label.TextPattern = "{A} {VP:P0} ({V:F3}M)"
                series1.LegendTextPattern = "{A}"

                ' Specify how series points are sorted.
                series1.SeriesPointsSorting = SortingMode.Ascending
                series1.SeriesPointsSortingKey = SeriesPointKey.Argument

                series1.ShowInLegend = True
                '' Specify the behavior of series labels.
                CType(series1.Label, Pie3DSeriesLabel).Position = PieSeriesLabelPosition.Inside

                'Dim totalLabel As PieTotalLabel = CType(overdueChart.Series("Series 1").View, Pie3DSeriesView)
                'totalLabel.Visible = True
                'totalLabel.TextPattern = "Total" & vbLf & "{V:F3}M".ToString()

                overdueChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
                overdueChart.Legend.Font = New Drawing.Font("Segoe UI", 8, FontStyle.Regular)

                ' Add the chart to the form.
                overdueChart.Dock = DockStyle.Fill
            End If


        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub ListYear_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles ListYear.ItemCheck
        If ListYear.CheckedItems.Count > 0 Then
            LoadData()
        End If
    End Sub

    'Private Sub ListYear_SelectedValueChanged(sender As Object, e As EventArgs) Handles ListYear.SelectedValueChanged
    '    LoadData()
    'End Sub

End Class