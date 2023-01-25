
Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGauges.Core.Base
Imports DevExpress.XtraTreeMap

Public Class frmDashboard

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
                .Text = "Total Sale by Category",
                .Font = New Drawing.Font("Segoe UI", 11, FontStyle.Bold)
            }
            ChartTotalSellByCatalog.Titles.Add(chartTitle1)

            chartTitle1 = New ChartTitle With {
                .Text = "Total Sale and COGS",
                .Font = New Drawing.Font("Segoe UI", 11, FontStyle.Bold)
            }
            ChartTotalSellCOGSByYear.Titles.Add(chartTitle1)

            chartTitle1 = New ChartTitle With {
                .Text = "Total Sale and Profit",
                .Font = New Drawing.Font("Segoe UI", 11, FontStyle.Bold)
            }
            ChartTotalSellProfitByYear.Titles.Add(chartTitle1)

            'chartTitle1 = New ChartTitle With {
            '    .Text = "ยอดขายรวม :" & mTotalSell & " M",
            '    .Font = New Drawing.Font("Segoe UI", 11, FontStyle.Bold)
            '}
            'chartTitle1.Dock = ChartTitleDockStyle.Bottom

            'overdueChart.Titles.Add(chartTitle1)

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

            'ConfigureTreeMapDataAdapter()
            'ConfigureTreeMapColorizer()

            Me.Cursor = Cursors.Default
        Catch ex As Exception

            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub
    Private Sub InitCondition()
        Dim lYear As Integer = GetCurrentDate(Nothing).Year

        lYear = IIf(lYear < 2500, lYear + 543, lYear)

        For i = 0 To 10
            If i <= 2 Then
                Dim lCheckedListBoxItem = New CheckedListBoxItem(lYear, True)
                ListYear.Items.Add(lCheckedListBoxItem)
            Else
                Dim lCheckedListBoxItem = New CheckedListBoxItem(lYear, False)
                ListYear.Items.Add(lCheckedListBoxItem)
            End If

            lYear -= 1
        Next

        Dim items() As CheckedListBoxItem = {
              New CheckedListBoxItem("มกราคม", True), New CheckedListBoxItem("กุมภาพันธ์", True),
              New CheckedListBoxItem("มีนาคม ", True), New CheckedListBoxItem("เมษายน", True),
              New CheckedListBoxItem("พฤษภาคม ", True), New CheckedListBoxItem("มิถุนายน", True),
              New CheckedListBoxItem("กรกฎาคม ", True), New CheckedListBoxItem("สิงหาคม", True),
              New CheckedListBoxItem("กันยายน ", True), New CheckedListBoxItem("ตุลาคม", True),
              New CheckedListBoxItem("พฤศจิกายน", True), New CheckedListBoxItem("ธันวาคม", True)}
        ListMonth.Items.AddRange(items)
    End Sub

    Private Sub GetCondition()
        Dim lYearList As String = ""
        For Each item As Object In ListYear.CheckedItems
            'Dim row As DataRowView = CType(item, DataRowView)
            If lYearList = "" Then
                lYearList = IIf(ConvertNullToZero(item.ToString) > 2500, ConvertNullToZero(item.ToString) - 543, ConvertNullToZero(item.ToString))
            Else
                lYearList += "," & IIf(ConvertNullToZero(item.ToString) > 2500, ConvertNullToZero(item.ToString) - 543, ConvertNullToZero(item.ToString))
            End If
        Next

        Dim lMonthList As String = ""
        For Each item As Object In ListMonth.CheckedItems
            'Dim row As DataRowView = CType(item, DataRowView)
            If lMonthList = "" Then
                lMonthList = GetMonthNumber(item.ToString)
            Else
                lMonthList += "," & GetMonthNumber(item.ToString)
            End If
        Next


        'Init From To Date
        Dim lMonthFrom As Integer, lMonthTo As Integer, lYearFrom As Integer, lYearTo As Integer
        If ListYear.CheckedItems.Count > 0 Then
            lYearTo = ListYear.CheckedItems(0).ToString
            lYearFrom = ListYear.CheckedItems(ListYear.CheckedItems.Count - 1).ToString

            lYearFrom = IIf(lYearFrom > 2500, lYearFrom - 543, lYearFrom)
            lYearTo = IIf(lYearTo > 2500, lYearTo - 543, lYearTo)
        End If

        If ListMonth.CheckedItems.Count > 0 Then
            lMonthFrom = GetMonthNumber(ListMonth.CheckedItems(0).ToString)
            lMonthTo = GetMonthNumber(ListMonth.CheckedItems(ListMonth.CheckedItems.Count - 1).ToString)
        End If


        mFromDate = New DateTime(lYearFrom, lMonthFrom, 1)
        mToDate = New DateTime(lYearTo, lMonthTo, Date.DaysInMonth(lYearTo, lMonthTo))
    End Sub

    Private Function GetMonthNumber(ByVal pMonthName As String) As Integer
        Select Case pMonthName
            Case "มกราคม" : Return 1
            Case "กุมภาพันธ์" : Return 2
            Case "มีนาคม" : Return 3
            Case "เมษายน" : Return 4
            Case "พฤษภาคม" : Return 5
            Case "มิถุนายน" : Return 6
            Case "กรกฎาคม" : Return 7
            Case "สิงหาคม" : Return 8
            Case "กันยายน" : Return 9
            Case "ตุลาคม" : Return 10
            Case "พฤศจิกายน" : Return 11
            Case "ธันวาคม" : Return 12
            Case Else : Return 1
        End Select
    End Function
    Private Sub InitChartTotalSellByCatalog()
        Try
            Dim SQL = " EXEC [dbo].[spTotalSellByCatalog]"
            SQL &= " @FromDate = '" & formatSQLDate(mFromDate) & "'"
            SQL &= " ,@ToDate = '" & formatSQLDate(mToDate) & "'"
            SQL &= " WITH RECOMPILE "
            Dim dataTable = gConnection.executeSelectQuery(SQL, Nothing, 180)

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
            totalLabel.Visible = False
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
            SQL &= " @FromDate = '" & formatSQLDate(mFromDate) & "'"
            SQL &= " ,@ToDate = '" & formatSQLDate(mToDate) & "'"
            SQL &= " WITH RECOMPILE "
            Dim dataTable = gConnection.executeSelectQuery(SQL, Nothing, 180)

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
            Dim SQL = "EXEC [dbo].[spTotalSellByYear]"
            SQL &= " @FromDate = '" & formatSQLDate(mFromDate) & "'"
            SQL &= " ,@ToDate = '" & formatSQLDate(mToDate) & "'"
            SQL &= " WITH RECOMPILE "
            Dim dataTable = gConnection.executeSelectQuery(SQL, Nothing, 180)

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

            Dim SQL = "EXEC [dbo].[spBankBalance]"
            SQL &= " @FromDate = '" & formatSQLDate(mFromDate) & "'"
            SQL &= " ,@ToDate = '" & formatSQLDate(mToDate) & "'"
            SQL &= " WITH RECOMPILE "
            Dim dataTable = gConnection.executeSelectQuery(SQL, Nothing, 180)

            Dim lData As New BankBalance
            Dim infos As New List(Of BankBalance)

            For Each pRow In dataTable.Rows

                lData = New BankBalance With {
                    .Name = pRow("BankCode").ToString,
                    .Group = "ยอดเงินในธนาคาร",
                    .Amount = ConvertNullToZero(pRow("AccountAmount"))
                }
                infos.Add(lData)
                lTotalCash += ConvertNullToZero(pRow("AccountAmount"))
            Next


            Dim adapter As TreeMapFlatDataAdapter = New TreeMapFlatDataAdapter With {.DataSource = infos, .LabelDataMember = "Name", .ValueDataMember = "Amount"}
            adapter.GroupDataMembers.Add("Group")
            BankAccTreeMap.DataAdapter = adapter
            txtCash.Text = lTotalCash.ToString("#,##0.00") & " K"



            BankAccTreeMap.Colorizer = New TreeMapPaletteColorizer With {.ColorizeGroups = False, .Palette = DevExpress.XtraTreeMap.Palette.OfficePalette}
            BankAccTreeMap.LeafTextPattern = "{L} {V} K"
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub InitGridBrand()
        Try
            Dim SQL = "EXEC [dbo].[spTotalSellByBrand]"
            SQL &= " @FromDate = '" & formatSQLDate(mFromDate) & "'"
            SQL &= " ,@ToDate = '" & formatSQLDate(mToDate) & "'"
            SQL &= " WITH RECOMPILE "
            Dim dataTable = gConnection.executeSelectQuery(SQL, Nothing, 180)

            GridControl1.DataSource = dataTable
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub InitOverdueGauge()
        Try
            Dim series1 As New Series("Series 1", ViewType.Pie3D)

            'Overdue
            Dim SQL = "EXEC [dbo].spOverdueTX"
            SQL &= " @FromDate = '" & formatSQLDate(mFromDate) & "'"
            SQL &= " ,@ToDate = '" & formatSQLDate(mToDate) & "'"
            SQL &= " WITH RECOMPILE "
            Dim dataTable = gConnection.executeSelectQuery(SQL, Nothing, 180)

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

                series1.ShowInLegend = False
                '' Specify the behavior of series labels.
                CType(series1.Label, Pie3DSeriesLabel).Position = PieSeriesLabelPosition.Inside

                'Dim totalLabel As PieTotalLabel = CType(overdueChart.Series("Series 1").View, Pie3DSeriesView)
                'totalLabel.Visible = True
                'totalLabel.TextPattern = "Total" & vbLf & "{V:F3}M".ToString()

                overdueChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
                overdueChart.Legend.Font = New Drawing.Font("Segoe UI", 8, FontStyle.Regular)

                txtSellTotal.Text = "ยอดขายรวม :" & mTotalSell & " M"
                'If overdueChart.Titles.Count > 0 Then
                '    overdueChart.Titles(0).Text = "ยอดขายรวม :" & mTotalSell & " M"
                'End If

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

    Private Sub ListMonth_ItemCheck(sender As Object, e As EventArgs) Handles ListMonth.ItemCheck
        If ListMonth.CheckedItems.Count > 0 Then
            LoadData()
        End If
    End Sub

End Class


Public Class BankBalance

    Public Property Name As String
    Public Property Group As String

    Public Property Amount As Double
End Class