﻿
Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGauges.Core.Base
Imports DevExpress.XtraTreeMap

Public Class frmDashboardComm
    Private mYearList As String
    Private mMonthList As String
    Private mFromDate As Date
    Private mToDate As Date
    'Private mTotalSell As Double

    Private Sub frmDashboard_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub frmDashboard_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

    End Sub

    Private Sub frmDashboard_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            InitCondition()
            'LoadData()

            '' Add a title to the chart and hide the legend.
            'Dim chartTitle1 As New ChartTitle With {
            '    .Text = "Total Sale by Catagoly",
            '    .Font = New Drawing.Font("Segoe UI", 11, FontStyle.Bold)
            '}
            'ChartTotalSellByCatalog.Titles.Add(chartTitle1)

            'chartTitle1 = New ChartTitle With {
            '    .Text = "Total Sale and COGS",
            '    .Font = New Drawing.Font("Segoe UI", 11, FontStyle.Bold)
            '}
            'ChartTotalSellCOGSByYear.Titles.Add(chartTitle1)

            'chartTitle1 = New ChartTitle With {
            '    .Text = "Total Sale and Profit",
            '    .Font = New Drawing.Font("Segoe UI", 11, FontStyle.Bold)
            '}
            'ChartTotalSellProfitByYear.Titles.Add(chartTitle1)


        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub SetComboEmployee()
        Try '  
            SetComboCheckEmployee(cboCheckedEmployee)

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, ".SetComboEmployee : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboTerritory()
        Try '  
            SetComboTerritoryWithSQL(cboCheckedTerritory, " and [CommissionID]>0 ")
            cboCheckedTerritory.EditValue = Integer.Parse(6)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, ".SetComboTerritory : " & e.Message)
        End Try
    End Sub


    Private Sub LoadData()
        Try

            Me.Cursor = Cursors.WaitCursor

            GetCondition()
            InitChartComm()
            InitChartSellTargetMonthly()
            InitChartProductTop5()
            InitChartCusGroupTop5()
            InitChartSellGrowth()
            InitGridOverDue()
            'InitChartTotalSellCOGSByYear()
            'InitChartTotalSellProfitByYear()
            'InitChartBankBalance()
            'InitGridBrand()
            'InitOverdueGauge()
            Me.Cursor = Cursors.Default
        Catch ex As Exception

            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub
    Private Sub InitCondition()
        SetComboEmployee()
        cboCheckedEmployee.CheckAll()

        SetComboTerritory()

        Dim lYear As Integer = GetCurrentDate(Nothing).Year

        Dim lList As New List(Of Integer)
        For i = 0 To 10
            lList.Add(lYear)
            lYear -= 1
        Next
        cboYear.Properties.DataSource = lList
        cboYear.EditValue = Integer.Parse(GetCurrentDate(Nothing).Year)

        Dim items() As CheckedListBoxItem = {
              New CheckedListBoxItem("January", True), New CheckedListBoxItem("February", True),
              New CheckedListBoxItem("March", True), New CheckedListBoxItem("April", True),
              New CheckedListBoxItem("May", True), New CheckedListBoxItem("June", True),
              New CheckedListBoxItem("July", True), New CheckedListBoxItem("August", True),
              New CheckedListBoxItem("September", True), New CheckedListBoxItem("October", True),
              New CheckedListBoxItem("November", True), New CheckedListBoxItem("December", True)}
        cboMonth.Properties.Items.AddRange(items)
    End Sub

    Private Sub GetCondition()
        Dim lYearList As String = ""

        mYearList = cboYear.EditValue

        Dim lMonthList As String = ""
        For Each item As Object In cboMonth.Properties.Items.GetCheckedValues()
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

        Dim lArr = mYearList.Split(",")
        If lArr.Length > 0 Then
            lYearTo = lArr(0)
            lYearFrom = lArr(lArr.Length - 1)
        Else
            lYearTo = lYearList
            lYearFrom = lYearList
        End If

        lArr = lMonthList.Split(",")
        If lArr.Length > 0 Then
            lMonthFrom = lArr(0)
            lMonthTo = lArr(lArr.Length - 1)
        Else
            lMonthFrom = lMonthList
            lMonthTo = lMonthList
        End If

        'If cboYear.Properties.GetCheckedItems.Count > 0 Then
        '    lYearTo = cboYear.Properties.GetCheckedItems(0).ToString
        '    lYearFrom = cboYear.Properties.GetCheckedItems(cboYear.Properties.GetCheckedItems.Count - 1).ToString
        'End If

        'If cboMonth.Properties.GetCheckedItems.Count > 0 Then
        '    lMonthFrom = GetMonthNumber(cboMonth.Properties.GetCheckedItems(0).ToString)
        '    lMonthTo = GetMonthNumber(cboMonth.Properties.GetCheckedItems(cboMonth.Properties.GetCheckedItems.Count - 1).ToString)
        'End If


        mFromDate = New DateTime(lYearFrom, lMonthFrom, 1)
        mToDate = New DateTime(lYearTo, lMonthTo, Date.DaysInMonth(lYearTo, lMonthTo))
    End Sub

    Private Function GetMonthNumber(ByVal pMonthName As String) As Integer
        Dim lGetMonthNumber As String

        lGetMonthNumber = Month(DateValue("1 " & pMonthName & " 2020"))
        Return Integer.Parse(lGetMonthNumber)

    End Function
    Private Sub InitChartComm()
        Try
            Dim series1 As New Series("Series 1", ViewType.Doughnut)

            'Comm
            Dim SQL = " EXEC [dbo].[spCommission]"
            SQL &= " @FromDate = '" & formatSQLDate(mFromDate) & "'"
            SQL &= " ,@ToDate = '" & formatSQLDate(mToDate) & "'"
            SQL &= " WITH RECOMPILE"
            Dim dataTable = gConnection.executeSelectQuery(SQL, Nothing, 180)

            If dataTable.Rows.Count = 0 Then Exit Sub

            Dim lEmpID As String = ""
            For Each pVaue In cboCheckedEmployee.Properties.Items.GetCheckedValues()
                lEmpID &= "," & pVaue
            Next
            If lEmpID <> "" Then
                lEmpID = lEmpID.Substring(1)
            End If

            If lEmpID = "" Then Exit Sub
            Dim FilterTable As New DataTable
            FilterTable = dataTable.Select("Commisstion>0 and EmpID in(" & lEmpID & ")").CopyToDataTable

            Dim lTotal As Decimal = 0
            For Each pRow In FilterTable.Rows
                lTotal += ConvertNullToZero(pRow("Commisstion"))
            Next
            series1.Points.Add(New SeriesPoint("ค่าคอมส่วนตัว", lTotal))

            'Comm Group
            SQL = " EXEC [dbo].[spCommissionGroup]"
            SQL &= " @FromDate = '" & formatSQLDate(mFromDate) & "'"
            SQL &= " ,@ToDate = '" & formatSQLDate(mToDate) & "'"
            SQL &= " WITH RECOMPILE"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing, 180)

            lEmpID = cboCheckedTerritory.EditValue
            If lEmpID = "" Then Exit Sub
            FilterTable = New DataTable
            FilterTable = dataTable.Select("Commisstion>0 and TerritoryID in(" & lEmpID & ")").CopyToDataTable

            lTotal = 0
            For Each pRow In FilterTable.Rows
                lTotal += ConvertNullToZero(pRow("EmpComm"))
            Next

            series1.Points.Add(New SeriesPoint("ค่าคอมทีม", lTotal))


            ChartComm.Series.Clear()

            ' Add the series to the chart.
            ChartComm.Series.Add(series1)

            ' Specify the text pattern of series labels.
            series1.Label.TextPattern = "{VP:P0} ({V:#,##0.000}M)"
            series1.LegendTextPattern = "{A}"

            ' Specify how series points are sorted.
            series1.SeriesPointsSorting = SortingMode.Ascending
            series1.SeriesPointsSortingKey = SeriesPointKey.Argument

            series1.ShowInLegend = True
            '' Specify the behavior of series labels.
            CType(series1.Label, DoughnutSeriesLabel).Position = PieSeriesLabelPosition.Outside

            Dim totalLabel As PieTotalLabel = CType(ChartComm.Series("Series 1").View, DoughnutSeriesView).TotalLabel
            totalLabel.Visible = False
            totalLabel.TextPattern = "Total" & vbLf & "{V:#,##0.000}M".ToString()
            totalLabel.Font = New Drawing.Font("Segoe UI", 8, FontStyle.Regular)

            ChartComm.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True
            ChartComm.Legend.Font = New Drawing.Font("Segoe UI", 8, FontStyle.Regular)

            ' Add the chart to the form.
            ChartComm.Dock = DockStyle.Fill

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        LoadData()
    End Sub

    'Private Sub cboCheckedEmployee_EditValueChanged(sender As Object, e As EventArgs) Handles cboCheckedEmployee.EditValueChanged
    '    LoadData()
    'End Sub

    Private Sub InitChartSellTargetMonthly()
        Try
            Dim lTotalSell As Double = 0, lTotalTarget As Double = 0


            Dim lEmpID As String = ""
            For Each pVaue In cboCheckedEmployee.Properties.Items.GetCheckedValues()
                lEmpID &= "," & pVaue
            Next
            If lEmpID <> "" Then
                lEmpID = lEmpID.Substring(1)
            End If

            If lEmpID = "" Then Exit Sub

            Dim SQL = " EXEC spSellTargetMonthly"
            SQL &= " @FromDate = '" & formatSQLDate(mFromDate) & "'"
            SQL &= " ,@ToDate = '" & formatSQLDate(mToDate) & "' "
            SQL &= " ,@EmpID = '" & lEmpID & "' "
            SQL &= " WITH RECOMPILE "
            Dim dataTable = gConnection.executeSelectQuery(SQL, Nothing, 180)

            Dim seriesSale As New Series("Actual Sale", ViewType.Bar)
            Dim seriesTarget As New Series("Target", ViewType.Line)


            For Each pRow In dataTable.Rows
                seriesSale.Points.Add(New SeriesPoint(DateSerial(pRow("OrderYear"), pRow("Ordermonth"), 1), ConvertNullToZero(pRow("TotalAmount"))))
                seriesTarget.Points.Add(New SeriesPoint(DateSerial(pRow("OrderYear"), pRow("Ordermonth"), 1), ConvertNullToZero(pRow("TargetPerMonth"))))

                lTotalSell += ConvertNullToZero(pRow("TotalAmount"))
                lTotalTarget += ConvertNullToZero(pRow("TargetPerMonth"))
            Next
            'mTotalSell = lTotalSell
            txtTotalSell.Text = lTotalSell.ToString("#,##0.00") & " K"
            txtTarget.Text = lTotalTarget.ToString("#,##0.00") & " K"

            ChartSellTargetMonthly.Series.Clear()
            ' Add the series to the chart.
            ChartSellTargetMonthly.Series.Add(seriesSale)
            ChartSellTargetMonthly.Series.Add(seriesTarget)

            ' Specify the text pattern of series labels.
            seriesSale.Label.TextPattern = "{V:#,##0.000,K}"
            seriesTarget.Label.TextPattern = "{V:#,##0.000,K}"


            seriesSale.ArgumentScaleType = ScaleType.DateTime
            seriesSale.ValueScaleType = ScaleType.Numerical

            seriesTarget.ArgumentScaleType = ScaleType.DateTime
            seriesTarget.ValueScaleType = ScaleType.Numerical

            Dim xAxisOptions As DateTimeScaleOptions = CType(ChartSellTargetMonthly.Diagram, XYDiagram).AxisX.DateTimeScaleOptions
            xAxisOptions.ScaleMode = ScaleMode.Manual
            xAxisOptions.GridSpacing = 1
            xAxisOptions.GridAlignment = DateTimeGridAlignment.Month
            xAxisOptions.AggregateFunction = AggregateFunction.None

            Dim Diagram As XYDiagram = CType(ChartSellTargetMonthly.Diagram, XYDiagram)
            ' Customize the appearance of the X-axis title.
            Diagram.AxisX.Title.Visible = True
            Diagram.AxisX.Title.Alignment = StringAlignment.Center
            Diagram.AxisX.Title.Text = "Month"
            Diagram.AxisX.Title.TextColor = Color.Gray
            Diagram.AxisX.Title.Font = New Font("Tahoma", 8, FontStyle.Bold)
            Diagram.AxisX.Label.TextPattern = "{A:MMM}"
            'xAxisOptions.GridOffset = 100
            'Dim yAxisOptions As NumericScaleOptions = CType(ChartTotalSellCOGSByYear.Diagram, XYDiagram).AxisX.NumericScaleOptions
            'yAxisOptions.MeasureUnit = NumericMeasureUnit.Ones
            ''yAxisOptions.GridSpacing = 500
            ''series1.LegendTextPattern = "{A}"

            seriesSale.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
            seriesTarget.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False

            ' Specify how series points are sorted.
            'series1.SeriesPointsSorting = SortingMode.Ascending
            'series1.SeriesPointsSortingKey = SeriesPointKey.Argument

            'series1.ShowInLegend = True
            '' Specify the behavior of series labels.
            CType(seriesSale.Label, BarSeriesLabel).Position = BarSeriesLabelPosition.TopInside
            CType(seriesSale.View, BarSeriesView).BarWidth = 15
            CType(seriesSale.View, BarSeriesView).ColorEach = True


            'CType(seriesTarget.Label, Line3DSeriesLabel).Position = BarSeriesLabelPosition.Top


            ChartSellTargetMonthly.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            ChartSellTargetMonthly.Legend.Font = New Drawing.Font("Segoe UI", 8, FontStyle.Regular)

            ' Add the chart to the form.
            ChartSellTargetMonthly.Dock = DockStyle.Fill

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub InitChartProductTop5()
        Try
            Dim lEmpID As String = ""
            For Each pVaue In cboCheckedEmployee.Properties.Items.GetCheckedValues()
                lEmpID &= "," & pVaue
            Next
            If lEmpID <> "" Then
                lEmpID = lEmpID.Substring(1)
            End If

            If lEmpID = "" Then Exit Sub

            Dim SQL = " EXEC [dbo].[spTotalSellByProduct]"
            SQL &= " @FromDate = '" & formatSQLDate(mFromDate) & "'"
            SQL &= " ,@ToDate = '" & formatSQLDate(mToDate) & "'"
            SQL &= " ,@EmpID = '" & lEmpID & "' "
            SQL &= " WITH RECOMPILE "
            Dim dataTable = gConnection.executeSelectQuery(SQL, Nothing, 180)

            Dim series1 As New Series("Series 1", ViewType.Doughnut)
            For Each pRow In dataTable.Rows
                series1.Points.Add(New SeriesPoint(pRow("ProductName").ToString, ConvertNullToZero(pRow("TotalAmount"))))
            Next
            ChartProductTop5.Series.Clear()

            ' Add the series to the chart.
            ChartProductTop5.Series.Add(series1)

            ' Specify the text pattern of series labels.
            series1.Label.TextPattern = "{VP:P0} ({V:#,##0.000}K)"
            series1.LegendTextPattern = "{A}"

            ' Specify how series points are sorted.
            series1.SeriesPointsSorting = SortingMode.Ascending
            series1.SeriesPointsSortingKey = SeriesPointKey.Argument

            series1.ShowInLegend = True
            '' Specify the behavior of series labels.
            CType(series1.Label, DoughnutSeriesLabel).Position = PieSeriesLabelPosition.Outside

            Dim totalLabel As PieTotalLabel = CType(ChartProductTop5.Series("Series 1").View, DoughnutSeriesView).TotalLabel
            totalLabel.Visible = False


            ChartProductTop5.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True
            ChartProductTop5.Legend.Font = New Drawing.Font("Segoe UI", 8, FontStyle.Regular)

            ' Add the chart to the form.
            ChartProductTop5.Dock = DockStyle.Fill

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub InitChartCusGroupTop5()
        Try
            Dim lEmpID As String = ""
            For Each pVaue In cboCheckedEmployee.Properties.Items.GetCheckedValues()
                lEmpID &= "," & pVaue
            Next
            If lEmpID <> "" Then
                lEmpID = lEmpID.Substring(1)
            End If

            If lEmpID = "" Then Exit Sub

            Dim SQL = " EXEC [dbo].[spTotalSellByCusGroup]"
            SQL &= " @FromDate = '" & formatSQLDate(mFromDate) & "'"
            SQL &= " ,@ToDate = '" & formatSQLDate(mToDate) & "'"
            SQL &= " ,@EmpID = '" & lEmpID & "' "
            SQL &= " WITH RECOMPILE "
            Dim dataTable = gConnection.executeSelectQuery(SQL, Nothing, 180)

            Dim series1 As New Series("Series 1", ViewType.Doughnut)
            For Each pRow In dataTable.Rows
                series1.Points.Add(New SeriesPoint(pRow("CustomerGroup").ToString, ConvertNullToZero(pRow("TotalAmount"))))
            Next
            ChartCusGroupTop5.Series.Clear()

            ' Add the series to the chart.
            ChartCusGroupTop5.Series.Add(series1)

            ' Specify the text pattern of series labels.
            series1.Label.TextPattern = "{VP:P0} ({V:#,##0.000}K)"
            series1.LegendTextPattern = "{A}"

            ' Specify how series points are sorted.
            series1.SeriesPointsSorting = SortingMode.Ascending
            series1.SeriesPointsSortingKey = SeriesPointKey.Argument

            series1.ShowInLegend = True
            '' Specify the behavior of series labels.
            CType(series1.Label, DoughnutSeriesLabel).Position = PieSeriesLabelPosition.Outside

            Dim totalLabel As PieTotalLabel = CType(ChartCusGroupTop5.Series("Series 1").View, DoughnutSeriesView).TotalLabel
            totalLabel.Visible = False


            ChartCusGroupTop5.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True
            ChartCusGroupTop5.Legend.Font = New Drawing.Font("Segoe UI", 8, FontStyle.Regular)

            ' Add the chart to the form.
            ChartCusGroupTop5.Dock = DockStyle.Fill

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub InitChartSellGrowth()
        Try
            Dim lTotalSell As Double = 0, lTotalCOGS As Double = 0, lTotalProfit As Double = 0, lTotalProfitPercen As Double = 0


            Dim lEmpID As String = ""
            For Each pVaue In cboCheckedEmployee.Properties.Items.GetCheckedValues()
                lEmpID &= "," & pVaue
            Next
            If lEmpID <> "" Then
                lEmpID = lEmpID.Substring(1)
            End If

            If lEmpID = "" Then Exit Sub

            Dim SQL = " EXEC spSellGrowth"
            SQL &= " @FromDate = '" & formatSQLDate(mFromDate) & "'"
            SQL &= " ,@ToDate = '" & formatSQLDate(mToDate) & "' "
            SQL &= " ,@EmpID = '" & lEmpID & "' "
            SQL &= " WITH RECOMPILE "
            Dim dataTable = gConnection.executeSelectQuery(SQL, Nothing, 180)

            Dim seriesSale As New Series("Sales Growth", ViewType.Bar)

            For Each pRow In dataTable.Rows
                seriesSale.Points.Add(New SeriesPoint(DateSerial(pRow("OrderYear"), pRow("Ordermonth"), 1), ConvertNullToZero(pRow("GrowthRate"))))

            Next
            'mTotalSell = lTotalSell


            ChartSellGrowth.Series.Clear()
            ' Add the series to the chart.
            ChartSellGrowth.Series.Add(seriesSale)

            ' Specify the text pattern of series labels.
            seriesSale.Label.TextPattern = "{V:#,##0}% "


            seriesSale.ArgumentScaleType = ScaleType.DateTime
            seriesSale.ValueScaleType = ScaleType.Numerical



            Dim xAxisOptions As DateTimeScaleOptions = CType(ChartSellGrowth.Diagram, XYDiagram).AxisX.DateTimeScaleOptions
            xAxisOptions.ScaleMode = ScaleMode.Manual
            xAxisOptions.GridSpacing = 1
            xAxisOptions.GridAlignment = DateTimeGridAlignment.Month
            xAxisOptions.AggregateFunction = AggregateFunction.None

            Dim Diagram As XYDiagram = CType(ChartSellGrowth.Diagram, XYDiagram)
            ' Customize the appearance of the X-axis title.
            Diagram.AxisX.Title.Visible = True
            Diagram.AxisX.Title.Alignment = StringAlignment.Center
            Diagram.AxisX.Title.Text = "Month"
            Diagram.AxisX.Title.TextColor = Color.Gray
            Diagram.AxisX.Title.Font = New Font("Tahoma", 8, FontStyle.Bold)
            Diagram.AxisX.Label.TextPattern = "{A:MMM}"
            'xAxisOptions.GridOffset = 100
            'Dim yAxisOptions As NumericScaleOptions = CType(ChartTotalSellCOGSByYear.Diagram, XYDiagram).AxisX.NumericScaleOptions
            'yAxisOptions.MeasureUnit = NumericMeasureUnit.Ones
            ''yAxisOptions.GridSpacing = 500
            ''series1.LegendTextPattern = "{A}"

            seriesSale.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True


            ' Specify how series points are sorted.
            'series1.SeriesPointsSorting = SortingMode.Ascending
            'series1.SeriesPointsSortingKey = SeriesPointKey.Argument

            'series1.ShowInLegend = True
            '' Specify the behavior of series labels.
            CType(seriesSale.Label, BarSeriesLabel).Position = BarSeriesLabelPosition.TopInside
            CType(seriesSale.View, BarSeriesView).BarWidth = 15
            CType(seriesSale.View, BarSeriesView).ColorEach = True


            'CType(seriesTarget.Label, Line3DSeriesLabel).Position = BarSeriesLabelPosition.Top


            ChartSellGrowth.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            ChartSellGrowth.Legend.Font = New Drawing.Font("Segoe UI", 8, FontStyle.Regular)

            ' Add the chart to the form.
            ChartSellGrowth.Dock = DockStyle.Fill

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub InitGridOverDue()
        Try
            Dim SQL = "EXEC [dbo].[spOverdueTX]"
            SQL &= " @FromDate = '" & formatSQLDate(mFromDate) & "'"
            SQL &= " ,@ToDate = '" & formatSQLDate(mToDate) & "'"
            SQL &= " WITH RECOMPILE "
            Dim dataTable = gConnection.executeSelectQuery(SQL, Nothing, 180)

            If dataTable.Rows.Count = 0 Then Exit Sub

            Dim lEmpID As String = ""
            For Each pVaue In cboCheckedEmployee.Properties.Items.GetCheckedValues()
                lEmpID &= "," & pVaue
            Next
            If lEmpID <> "" Then
                lEmpID = lEmpID.Substring(1)
            End If

            If lEmpID = "" Then Exit Sub
            Dim FilterTable As New DataTable
            FilterTable = dataTable.Select("EmpID in(" & lEmpID & ")").CopyToDataTable

            GridControl1.DataSource = FilterTable
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

End Class