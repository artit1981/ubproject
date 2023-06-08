
Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGauges.Core.Base
Imports DevExpress.XtraTreeMap

Public Class frmDashboardComm
    Private mYearList As String
    Private mMonthList As String
    Private mFromDate As Date
    Private mToDate As Date
    Private mTotalSell As Double = 0, mTotalSellTeam As Double = 0
    'Private mTarget As Double

    Private Sub frmDashboard_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub frmDashboard_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

    End Sub

    Private Sub frmDashboard_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            InitCondition()

            txtPercenTeam.Text = ""
            txtSaleLastYear.Text = ""
            txtTarget.Text = ""
            txtTeam.Text = ""
            txtTotalSell.Text = ""
            'LoadData()

            ' Add a title to the chart and hide the legend.
            Dim chartTitle1 As New ChartTitle With {
                .Text = "Commission",
                .Font = New Drawing.Font("Segoe UI", 11, FontStyle.Bold)
            }
            ChartComm.Titles.Add(chartTitle1)

            chartTitle1 = New ChartTitle With {
                .Text = "Top 5 Sales by Product",
                .Font = New Drawing.Font("Segoe UI", 11, FontStyle.Bold)
            }
            ChartProductTop5.Titles.Add(chartTitle1)

            chartTitle1 = New ChartTitle With {
               .Text = "Top 5 Sales by Channel",
               .Font = New Drawing.Font("Segoe UI", 11, FontStyle.Bold)
           }
            ChartCusGroupTop5.Titles.Add(chartTitle1)

            chartTitle1 = New ChartTitle With {
               .Text = "Actual Sales vs Target",
               .Font = New Drawing.Font("Segoe UI", 11, FontStyle.Bold)
           }
            ChartSellTargetMonthly.Titles.Add(chartTitle1)


            chartTitle1 = New ChartTitle With {
               .Text = "Sales Growth",
               .Font = New Drawing.Font("Segoe UI", 11, FontStyle.Bold)
           }
            ChartSellGrowth.Titles.Add(chartTitle1)


            chartTitle1 = New ChartTitle With {
               .Text = "Target Achievement",
               .Font = New Drawing.Font("Segoe UI", 11, FontStyle.Bold)
           }
            ChartTargetAchieve.Titles.Add(chartTitle1)



        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub SetComboEmployee()
        Try '  
            Dim lSQLEmp As String = ""
            If gPrivilegeID > 1 Then
                lSQLEmp = " and EmpID=" & gEmpID
            End If
            SetComboCheckEmployee(cboCheckedEmployee, lSQLEmp)

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, ".SetComboEmployee : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboTerritory()
        Try '  
            SetComboTerritoryWithSQL(cboCheckedTerritory, "")
            cboCheckedTerritory.EditValue = Long.Parse(6)
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
            InitChartSellLastYear()
            GetSaleTeam()

            '###### CALC TEAM SALE AMOUNT
            txtTeam.Text = mTotalSellTeam.ToString("#,##0.00") & " K"
            If mTotalSell > 0 And mTotalSellTeam > 0 Then
                txtPercenTeam.Text = Decimal.Parse((mTotalSell / mTotalSellTeam) * 100).ToString("#,##0.00") & " %"
            Else
                txtPercenTeam.Text = "NA."
            End If

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
        lYear = IIf(lYear < 2500, lYear + 543, lYear)

        Dim lList As New List(Of Integer)
        For i = 0 To 10
            lList.Add(lYear)
            lYear -= 1
        Next
        cboYear.Properties.DataSource = lList

        lYear = Integer.Parse(GetCurrentDate(Nothing).Year)
        cboYear.EditValue = IIf(lYear < 2500, lYear + 543, lYear)

        Dim items() As CheckedListBoxItem = {
              New CheckedListBoxItem("มกราคม", True), New CheckedListBoxItem("กุมภาพันธ์", True),
              New CheckedListBoxItem("มีนาคม ", True), New CheckedListBoxItem("เมษายน", True),
              New CheckedListBoxItem("พฤษภาคม ", True), New CheckedListBoxItem("มิถุนายน", True),
              New CheckedListBoxItem("กรกฎาคม ", True), New CheckedListBoxItem("สิงหาคม", True),
              New CheckedListBoxItem("กันยายน ", True), New CheckedListBoxItem("ตุลาคม", True),
              New CheckedListBoxItem("พฤศจิกายน", True), New CheckedListBoxItem("ธันวาคม", True)}
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


        mFromDate = New DateTime(IIf(lYearFrom > 2500, lYearFrom - 543, lYearFrom), lMonthFrom, 1)
        mToDate = New DateTime(IIf(lYearTo > 2500, lYearTo - 543, lYearTo), lMonthTo, Date.DaysInMonth(IIf(lYearTo > 2500, lYearTo - 543, lYearTo), lMonthTo))
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
    Private Sub InitChartComm()
        Try
            ChartComm.Series.Clear()

            Dim series1 As New Series("Series 1", ViewType.Doughnut)

            'Comm
            Dim lTotal As Decimal = 0

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
            If dataTable.Select("Commisstion>0 and EmpID in(" & lEmpID & ")").Length > 0 Then

                FilterTable = dataTable.Select("Commisstion>0 and EmpID in(" & lEmpID & ")").CopyToDataTable
                For Each pRow In FilterTable.Rows
                    lTotal += ConvertNullToZero(pRow("Commisstion"))
                Next
            End If

            If lTotal > 0 Then
                lTotal = lTotal / 1000
            End If
            series1.Points.Add(New SeriesPoint("ค่าคอมส่วนตัว", lTotal))

            'Comm Group
            lTotal = 0
            SQL = " EXEC [dbo].[spCommissionGroup]"
            SQL &= " @FromDate = '" & formatSQLDate(mFromDate) & "'"
            SQL &= " ,@ToDate = '" & formatSQLDate(mToDate) & "'"
            SQL &= " WITH RECOMPILE"
            Dim dataTableGroup = gConnection.executeSelectQuery(SQL, Nothing, 180)

            If dataTableGroup.Rows.Count > 0 Then
                Dim lTerritoryID As String = ""
                lTerritoryID = cboCheckedTerritory.EditValue
                If lTerritoryID <> "" Then
                    If dataTableGroup.Select("EmpID in(" & lEmpID & ") and TerritoryID in(" & lTerritoryID & ")").Length > 0 Then
                        FilterTable = dataTableGroup.Select("EmpID in(" & lEmpID & ") and TerritoryID in(" & lTerritoryID & ")").CopyToDataTable
                        For Each pRow In FilterTable.Rows
                            lTotal += ConvertNullToZero(pRow("GroupTotal"))
                            Exit For
                        Next

                    End If
                End If
            End If
            mTotalSellTeam = lTotal

            lTotal = 0
            If dataTableGroup.Rows.Count > 0 Then
                Dim lTerritoryID As String = ""
                lTerritoryID = cboCheckedTerritory.EditValue
                If lTerritoryID <> "" Then
                    If dataTableGroup.Select("Commisstion>0 and TerritoryID in(" & lTerritoryID & ")").Length > 0 Then
                        FilterTable = dataTableGroup.Select("Commisstion>0 and TerritoryID in(" & lTerritoryID & ")").CopyToDataTable
                        For Each pRow In FilterTable.Rows
                            lTotal += ConvertNullToZero(pRow("Commisstion"))
                            Exit For
                        Next

                    End If
                End If


            End If


            If lTotal > 0 Then
                lTotal = lTotal / 1000
            End If
            series1.Points.Add(New SeriesPoint("ค่าคอมทีม", lTotal))


            ' Add the series to the chart.
            ChartComm.Series.Add(series1)

            ' Specify the text pattern of series labels.
            series1.Label.TextPattern = "{VP:P0} ({V:#,##0.000}K)"
            series1.LegendTextPattern = "{A}"

            ' Specify how series points are sorted.
            series1.SeriesPointsSorting = SortingMode.Ascending
            series1.SeriesPointsSortingKey = SeriesPointKey.Argument

            series1.ShowInLegend = True
            '' Specify the behavior of series labels.
            CType(series1.Label, DoughnutSeriesLabel).Position = PieSeriesLabelPosition.Outside

            Dim totalLabel As PieTotalLabel = CType(ChartComm.Series("Series 1").View, DoughnutSeriesView).TotalLabel
            totalLabel.Visible = False
            totalLabel.TextPattern = "Total" & vbLf & "{V:#,##0.000}K".ToString()
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
            ChartSellTargetMonthly.Series.Clear()

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
            mTotalSell = lTotalSell
            'mTarget = lTotalTarget
            txtTotalSell.Text = lTotalSell.ToString("#,##0.00") & " K"
            txtTarget.Text = lTotalTarget.ToString("#,##0.00") & " K"

            If lTotalSell = 0 And lTotalTarget = 0 Then Exit Sub


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
            Diagram.AxisX.Title.Visibility = True
            Diagram.AxisX.Title.Alignment = StringAlignment.Center
            Diagram.AxisX.Title.Text = "Month"
            Diagram.AxisX.Title.TextColor = Color.Gray
            Diagram.AxisX.Title.Font = New Font("Tahoma", 8, FontStyle.Bold)
            Diagram.AxisX.Label.TextPattern = "{A:MMM}"


            seriesSale.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
            seriesTarget.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False


            '' Specify the behavior of series labels.
            CType(seriesSale.Label, BarSeriesLabel).Position = BarSeriesLabelPosition.TopInside
            CType(seriesSale.View, BarSeriesView).BarWidth = 15
            CType(seriesSale.View, BarSeriesView).ColorEach = True


            'CType(seriesTarget.Label, Line3DSeriesLabel).Position = BarSeriesLabelPosition.Top


            ChartSellTargetMonthly.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            ChartSellTargetMonthly.Legend.Font = New Drawing.Font("Segoe UI", 8, FontStyle.Regular)

            ' Add the chart to the form.
            ChartSellTargetMonthly.Dock = DockStyle.Fill


            '################  Chart Target ############### 
            If lTotalSell = 0 Or lTotalTarget = 0 Then Exit Sub

            ChartTargetAchieve.Series.Clear()

            Dim series1 As New Series("Series 1", ViewType.Doughnut)
            Dim lPercentAchieve As Decimal = 0, lPercentNotAchieve As Decimal = 0

            lPercentAchieve = Math.Round((lTotalSell / lTotalTarget) * 100, 2)
            series1.Points.Add(New SeriesPoint("Target Achievement", lPercentAchieve))
            If lTotalSell < lTotalTarget Then

                lPercentNotAchieve = 100 - lPercentAchieve
                series1.Points.Add(New SeriesPoint("Not Achieve", lPercentNotAchieve))


            End If


            ' Add the series to the chart.
            ChartTargetAchieve.Series.Add(series1)

            ' Specify the text pattern of series labels.
            series1.Label.TextPattern = "{V:#,##0.00}%"
            series1.LegendTextPattern = "{A}"

            ' Specify how series points are sorted.
            series1.SeriesPointsSorting = SortingMode.Ascending
            series1.SeriesPointsSortingKey = SeriesPointKey.Argument

            series1.ShowInLegend = True
            '' Specify the behavior of series labels.
            CType(series1.Label, DoughnutSeriesLabel).Position = PieSeriesLabelPosition.Outside

            Dim totalLabel As PieTotalLabel = CType(ChartTargetAchieve.Series("Series 1").View, DoughnutSeriesView).TotalLabel
            totalLabel.Visible = False
            totalLabel.TextPattern = "Total" & vbLf & "{V:#,##0.00}K".ToString()
            totalLabel.Font = New Drawing.Font("Segoe UI", 8, FontStyle.Regular)

            ChartTargetAchieve.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True
            ChartTargetAchieve.Legend.Font = New Drawing.Font("Segoe UI", 8, FontStyle.Regular)
            ChartTargetAchieve.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Center
            ChartTargetAchieve.Legend.AlignmentVertical = LegendAlignmentVertical.BottomOutside
            ' Add the chart to the form.
            ChartTargetAchieve.Dock = DockStyle.Fill
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub InitChartProductTop5()
        Try
            ChartProductTop5.Series.Clear()

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
            ChartCusGroupTop5.Series.Clear()

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
            ChartSellGrowth.Series.Clear()

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
            GridControl1.DataSource = Nothing

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
            If dataTable.Select("EmpID in(" & lEmpID & ") and  OverDays>0").Length > 0 Then
                Dim FilterTable As New DataTable
                FilterTable = dataTable.Select("EmpID in(" & lEmpID & ")  and  OverDays>0").CopyToDataTable

                GridControl1.DataSource = FilterTable
            End If

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub InitChartSellLastYear()
        Try

            Dim lTotalSell As Double = 0


            Dim lEmpID As String = ""
            For Each pVaue In cboCheckedEmployee.Properties.Items.GetCheckedValues()
                lEmpID &= "," & pVaue
            Next
            If lEmpID <> "" Then
                lEmpID = lEmpID.Substring(1)
            End If

            If lEmpID = "" Then Exit Sub

            Dim lPreFromDate As Date = DateSerial(Year(mFromDate) - 1, 1, 1)
            Dim lPreToDate As Date = DateSerial(Year(mToDate) - 1, 12, 31)

            Dim SQL = " EXEC spSellTargetMonthly"
            SQL &= " @FromDate = '" & formatSQLDate(lPreFromDate) & "'"
            SQL &= " ,@ToDate = '" & formatSQLDate(lPreToDate) & "' "
            SQL &= " ,@EmpID = '" & lEmpID & "' "
            SQL &= " WITH RECOMPILE "
            Dim dataTable = gConnection.executeSelectQuery(SQL, Nothing, 180)




            For Each pRow In dataTable.Rows

                lTotalSell += ConvertNullToZero(pRow("TotalAmount"))

            Next
            'mTotalSell = lTotalSell
            'mTarget = lTotalTarget
            txtSaleLastYear.Text = lTotalSell.ToString("#,##0.00") & " K"

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub GetSaleTeam()
        Try


            Dim lTotal As Decimal = 0

            Dim Sql = " EXEC [dbo].[spTotalTeamSell]"
            Sql &= " @FromDate = '" & formatSQLDate(mFromDate) & "'"
            Sql &= " ,@ToDate = '" & formatSQLDate(mToDate) & "'"
            Sql &= " WITH RECOMPILE"
            Dim dataTableGroup = gConnection.executeSelectQuery(SQL, Nothing, 180)

            If dataTableGroup.Rows.Count > 0 Then
                Dim lTerritoryID As String = ""
                lTerritoryID = cboCheckedTerritory.EditValue
                If lTerritoryID <> "" Then
                    If dataTableGroup.Select("TerritoryID in(" & lTerritoryID & ")").Length > 0 Then
                        Dim FilterTable = dataTableGroup.Select("TerritoryID in(" & lTerritoryID & ")").CopyToDataTable
                        For Each pRow In FilterTable.Rows
                            lTotal += ConvertNullToZero(pRow("TotalAmount"))
                        Next

                    End If
                End If
            End If
            mTotalSellTeam = lTotal



        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub
End Class