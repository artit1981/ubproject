<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class rptInvoiceAbb
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel29 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel39 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel37 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel38 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TmpOrders1 = New UB.TmpOrders()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.Number2Dit = New DevExpress.XtraReports.UI.FormattingRule()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLine5 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Total = New DevExpress.XtraReports.UI.FormattingRule()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.ProName = New DevExpress.XtraReports.UI.CalculatedField()
        Me.Total_Dis = New DevExpress.XtraReports.UI.CalculatedField()
        Me.TmpProductListTableAdapter = New UB.TmpOrdersTableAdapters.TmpProductListTableAdapter()
        Me.CalSEQ = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CalUnitSum = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CompanyTaxCal = New DevExpress.XtraReports.UI.CalculatedField()
        Me.XrCrossBandBox2 = New DevExpress.XtraReports.UI.XRCrossBandBox()
        CType(Me.TmpOrders1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel3, Me.XrLabel2, Me.XrLabel13, Me.XrLabel12})
        Me.Detail.HeightF = 16.70658!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.CanGrow = False
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TmpProductList.Total")})
        Me.XrLabel3.Font = New System.Drawing.Font("Angsana New", 11.0!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(216.3823!, 0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(75.86966!, 16.70658!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel3.TextFormatString = "{0:N2}"
        '
        'XrLabel2
        '
        Me.XrLabel2.CanGrow = False
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TmpProductList.Price")})
        Me.XrLabel2.Font = New System.Drawing.Font("Angsana New", 11.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(165.0382!, 0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(51.34409!, 16.70658!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel2.TextFormatString = "{0:N2}"
        '
        'XrLabel13
        '
        Me.XrLabel13.CanGrow = False
        Me.XrLabel13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TmpProductList.Units", "{0:#,#}")})
        Me.XrLabel13.Font = New System.Drawing.Font("Angsana New", 11.0!)
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(136.9431!, 0!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(28.09518!, 16.70658!)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "XrLabel13"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel12
        '
        Me.XrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TmpProductList.ProName")})
        Me.XrLabel12.Font = New System.Drawing.Font("Angsana New", 11.0!)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(1.747873!, 0!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(135.1952!, 16.70658!)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "XrLabel12"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 53.125!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel17
        '
        Me.XrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TmpOrders.Employee")})
        Me.XrLabel17.Font = New System.Drawing.Font("Angsana New", 12.0!)
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(79.01389!, 146.162!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(213.2382!, 21.14815!)
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.Text = "XrLabel17"
        '
        'XrLabel14
        '
        Me.XrLabel14.CanGrow = False
        Me.XrLabel14.Font = New System.Drawing.Font("Angsana New", 11.0!)
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(1.747873!, 2.000003!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(112.5862!, 18.90276!)
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.Text = "รวมเป็นเงิน"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel29, Me.XrLabel26, Me.XrLabel25, Me.XrLabel24, Me.XrLine3, Me.XrLabel1, Me.XrLabel20, Me.XrLabel17, Me.XrLabel22, Me.XrLabel28, Me.XrLabel27, Me.XrLabel15, Me.XrLine1, Me.XrLabel21, Me.XrLabel9, Me.XrLabel8, Me.XrLabel39, Me.XrLabel37, Me.XrLabel38, Me.XrLabel6})
        Me.PageHeader.Font = New System.Drawing.Font("Cordia New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PageHeader.HeightF = 233.6032!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.StylePriority.UseFont = False
        '
        'XrLabel29
        '
        Me.XrLabel29.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TmpOrders.PO")})
        Me.XrLabel29.Font = New System.Drawing.Font("Angsana New", 12.0!)
        Me.XrLabel29.LocationFloat = New DevExpress.Utils.PointFloat(79.0141!, 188.4583!)
        Me.XrLabel29.Name = "XrLabel29"
        Me.XrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel29.SizeF = New System.Drawing.SizeF(213.238!, 21.14813!)
        Me.XrLabel29.StylePriority.UseFont = False
        '
        'XrLabel26
        '
        Me.XrLabel26.CanGrow = False
        Me.XrLabel26.Font = New System.Drawing.Font("Angsana New", 12.0!)
        Me.XrLabel26.LocationFloat = New DevExpress.Utils.PointFloat(1.041664!, 188.4583!)
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel26.SizeF = New System.Drawing.SizeF(85.26389!, 21.14815!)
        Me.XrLabel26.StylePriority.UseFont = False
        Me.XrLabel26.Text = "เลขที่ใบสั่งซื้อ :"
        '
        'XrLabel25
        '
        Me.XrLabel25.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TmpOrders.RefOrderCode")})
        Me.XrLabel25.Font = New System.Drawing.Font("Angsana New", 12.0!)
        Me.XrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(79.01389!, 167.3101!)
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel25.SizeF = New System.Drawing.SizeF(213.238!, 21.14813!)
        Me.XrLabel25.StylePriority.UseFont = False
        '
        'XrLabel24
        '
        Me.XrLabel24.CanGrow = False
        Me.XrLabel24.Font = New System.Drawing.Font("Angsana New", 12.0!)
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(1.041667!, 167.3102!)
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(85.26389!, 21.14815!)
        Me.XrLabel24.StylePriority.UseFont = False
        Me.XrLabel24.Text = "เลขที่ใบสั่งขาย :"
        '
        'XrLine3
        '
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(2.454243!, 231.6032!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(290.504!, 2.0!)
        '
        'XrLabel1
        '
        Me.XrLabel1.CanGrow = False
        Me.XrLabel1.Font = New System.Drawing.Font("Angsana New", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(215.3408!, 211.6065!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(75.86966!, 18.4342!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "รวมเงิน"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel20
        '
        Me.XrLabel20.CanGrow = False
        Me.XrLabel20.Font = New System.Drawing.Font("Angsana New", 12.0!)
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(1.041667!, 146.162!)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(74.84722!, 21.14815!)
        Me.XrLabel20.StylePriority.UseFont = False
        Me.XrLabel20.Text = "พนักงานขาย :"
        '
        'XrLabel22
        '
        Me.XrLabel22.CanGrow = False
        Me.XrLabel22.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TmpOrders.CompanyTaxCal")})
        Me.XrLabel22.Font = New System.Drawing.Font("Cordia New", 9.0!)
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(1.747873!, 49.00001!)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(291.2104!, 15.00001!)
        Me.XrLabel22.StylePriority.UseFont = False
        Me.XrLabel22.StylePriority.UseTextAlignment = False
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel28
        '
        Me.XrLabel28.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TmpOrders.CompanyAddress")})
        Me.XrLabel28.Font = New System.Drawing.Font("Cordia New", 9.0!)
        Me.XrLabel28.LocationFloat = New DevExpress.Utils.PointFloat(1.747862!, 33.00001!)
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel28.SizeF = New System.Drawing.SizeF(291.2104!, 16.0!)
        Me.XrLabel28.StylePriority.UseFont = False
        Me.XrLabel28.StylePriority.UseTextAlignment = False
        Me.XrLabel28.Text = "XrLabel27"
        Me.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel27
        '
        Me.XrLabel27.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TmpOrders.Company")})
        Me.XrLabel27.Font = New System.Drawing.Font("Cordia New", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(1.747862!, 10.00001!)
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel27.SizeF = New System.Drawing.SizeF(291.2104!, 23.0!)
        Me.XrLabel27.StylePriority.UseFont = False
        Me.XrLabel27.StylePriority.UseTextAlignment = False
        Me.XrLabel27.Text = "XrLabel26"
        Me.XrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel15
        '
        Me.XrLabel15.BorderColor = System.Drawing.Color.Navy
        Me.XrLabel15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TmpOrders.Header1")})
        Me.XrLabel15.Font = New System.Drawing.Font("Angsana New", 13.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(1.041667!, 74.41669!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(291.2104!, 27.94442!)
        Me.XrLabel15.StylePriority.UseBorderColor = False
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "XrLabel15"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(2.454233!, 209.6065!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(290.5041!, 2.0!)
        '
        'XrLabel21
        '
        Me.XrLabel21.CanGrow = False
        Me.XrLabel21.Font = New System.Drawing.Font("Angsana New", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(163.9967!, 211.6065!)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(51.34409!, 18.4342!)
        Me.XrLabel21.StylePriority.UseFont = False
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        Me.XrLabel21.Text = "หน่วยละ"
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel9
        '
        Me.XrLabel9.CanGrow = False
        Me.XrLabel9.Font = New System.Drawing.Font("Angsana New", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(127.4844!, 211.6065!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(36.51233!, 18.4342!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "จำนวน"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel8
        '
        Me.XrLabel8.CanGrow = False
        Me.XrLabel8.Font = New System.Drawing.Font("Angsana New", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(3.160427!, 211.6065!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(124.3239!, 18.43422!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "รายการ"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel39
        '
        Me.XrLabel39.CanGrow = False
        Me.XrLabel39.Font = New System.Drawing.Font("Angsana New", 12.0!)
        Me.XrLabel39.LocationFloat = New DevExpress.Utils.PointFloat(1.747873!, 125.0139!)
        Me.XrLabel39.Name = "XrLabel39"
        Me.XrLabel39.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel39.SizeF = New System.Drawing.SizeF(52.62499!, 21.14816!)
        Me.XrLabel39.StylePriority.UseFont = False
        Me.XrLabel39.Text = "วันที่ :"
        '
        'XrLabel37
        '
        Me.XrLabel37.CanGrow = False
        Me.XrLabel37.Font = New System.Drawing.Font("Angsana New", 12.0!)
        Me.XrLabel37.LocationFloat = New DevExpress.Utils.PointFloat(1.747873!, 102.3611!)
        Me.XrLabel37.Name = "XrLabel37"
        Me.XrLabel37.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel37.SizeF = New System.Drawing.SizeF(36.65276!, 22.65276!)
        Me.XrLabel37.StylePriority.UseFont = False
        Me.XrLabel37.Text = "เลขที่ :"
        '
        'XrLabel38
        '
        Me.XrLabel38.CanGrow = False
        Me.XrLabel38.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TmpOrders.OrderCode")})
        Me.XrLabel38.Font = New System.Drawing.Font("Angsana New", 12.0!)
        Me.XrLabel38.LocationFloat = New DevExpress.Utils.PointFloat(79.01389!, 102.3611!)
        Me.XrLabel38.Name = "XrLabel38"
        Me.XrLabel38.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel38.SizeF = New System.Drawing.SizeF(211.4902!, 22.65276!)
        Me.XrLabel38.StylePriority.UseFont = False
        Me.XrLabel38.Text = "XrLabel3"
        '
        'XrLabel6
        '
        Me.XrLabel6.CanGrow = False
        Me.XrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TmpOrders.OrderDate", "{0:dd/MM/yy}")})
        Me.XrLabel6.Font = New System.Drawing.Font("Angsana New", 12.0!)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(79.01389!, 125.0139!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(211.4902!, 21.14817!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.Text = "XrLabel6"
        '
        'TmpOrders1
        '
        Me.TmpOrders1.DataSetName = "TmpOrders"
        Me.TmpOrders1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PageFooter
        '
        Me.PageFooter.HeightF = 2.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'Number2Dit
        '
        Me.Number2Dit.Formatting.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.Number2Dit.Name = "Number2Dit"
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine5, Me.XrLabel23, Me.XrLabel19, Me.XrLabel18, Me.XrLabel16, Me.XrLine2, Me.XrLabel11, Me.XrLabel10, Me.XrLabel7, Me.XrLabel5, Me.XrLine4, Me.XrLabel4, Me.XrLabel14})
        Me.ReportFooter.HeightF = 108.0!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrLine5
        '
        Me.XrLine5.LocationFloat = New DevExpress.Utils.PointFloat(1.041667!, 98.51379!)
        Me.XrLine5.Name = "XrLine5"
        Me.XrLine5.SizeF = New System.Drawing.SizeF(290.5042!, 2.0!)
        '
        'XrLabel23
        '
        Me.XrLabel23.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TmpOrders.VatAmount")})
        Me.XrLabel23.Font = New System.Drawing.Font("Angsana New", 11.0!)
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(178.188!, 79.61104!)
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel23.SizeF = New System.Drawing.SizeF(113.3578!, 18.90276!)
        Me.XrLabel23.StylePriority.UseFont = False
        Me.XrLabel23.StylePriority.UseTextAlignment = False
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrLabel23.TextFormatString = "{0:N2}"
        '
        'XrLabel19
        '
        Me.XrLabel19.CanGrow = False
        Me.XrLabel19.Font = New System.Drawing.Font("Angsana New", 11.0!)
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(2.454058!, 79.61104!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(112.5862!, 18.90276!)
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.Text = "ภาษีมูลค่าเพิ่ม"
        '
        'XrLabel18
        '
        Me.XrLabel18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TmpOrders.GrandTotal")})
        Me.XrLabel18.Font = New System.Drawing.Font("Angsana New", 11.0!)
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(178.188!, 60.70828!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(113.3578!, 18.90276!)
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrLabel18.TextFormatString = "{0:N2}"
        '
        'XrLabel16
        '
        Me.XrLabel16.CanGrow = False
        Me.XrLabel16.Font = New System.Drawing.Font("Angsana New", 11.0!)
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(2.454058!, 60.70828!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(112.5862!, 18.90276!)
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.Text = "รวมมูลค่าสินค้า"
        '
        'XrLine2
        '
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(1.747862!, 58.70826!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(290.5042!, 2.0!)
        '
        'XrLabel11
        '
        Me.XrLabel11.CanGrow = False
        Me.XrLabel11.Font = New System.Drawing.Font("Angsana New", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(1.041667!, 39.80552!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(112.5862!, 18.90276!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.Text = "รวมทั้งสิ้น"
        '
        'XrLabel10
        '
        Me.XrLabel10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TmpOrders.Total_Dis")})
        Me.XrLabel10.Font = New System.Drawing.Font("Angsana New", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(178.8942!, 39.80552!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(114.0641!, 18.90276!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrLabel10.TextFormatString = "{0:N2}"
        '
        'XrLabel7
        '
        Me.XrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TmpOrders.DiscountAmount")})
        Me.XrLabel7.Font = New System.Drawing.Font("Angsana New", 11.0!)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(178.8942!, 20.90276!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(113.3578!, 18.90276!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrLabel7.TextFormatString = "{0:N2}"
        '
        'XrLabel5
        '
        Me.XrLabel5.CanGrow = False
        Me.XrLabel5.Font = New System.Drawing.Font("Angsana New", 11.0!)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(1.747873!, 20.90276!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(112.5862!, 18.90276!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.Text = "ส่วนลด"
        '
        'XrLine4
        '
        Me.XrLine4.LocationFloat = New DevExpress.Utils.PointFloat(1.041667!, 0!)
        Me.XrLine4.Name = "XrLine4"
        Me.XrLine4.SizeF = New System.Drawing.SizeF(290.5042!, 2.0!)
        '
        'XrLabel4
        '
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TmpOrders.Total")})
        Me.XrLabel4.Font = New System.Drawing.Font("Angsana New", 11.0!)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(178.8942!, 2.000003!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(113.3578!, 18.90276!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrLabel4.TextFormatString = "{0:N2}"
        '
        'Total
        '
        Me.Total.Condition = "[DataSource.CurrentRowIndex] < [DataSource.RowCount]"
        Me.Total.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[False]
        Me.Total.Name = "Total"
        '
        'ReportHeader
        '
        Me.ReportHeader.HeightF = 0!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'ProName
        '
        Me.ProName.DataMember = "TmpProductList"
        Me.ProName.Expression = "Iif([ProductNameExt] != '',[ProductNameExt]  ,[ProductName] )"
        Me.ProName.Name = "ProName"
        '
        'Total_Dis
        '
        Me.Total_Dis.DataMember = "TmpOrders"
        Me.Total_Dis.Expression = "[Total]-[DiscountAmount]"
        Me.Total_Dis.Name = "Total_Dis"
        '
        'TmpProductListTableAdapter
        '
        Me.TmpProductListTableAdapter.ClearBeforeFill = True
        '
        'CalSEQ
        '
        Me.CalSEQ.DataMember = "TmpProductList"
        Me.CalSEQ.Expression = "Iif([SEQ]=999,''  ,[SEQ] )"
        Me.CalSEQ.Name = "CalSEQ"
        '
        'CalUnitSum
        '
        Me.CalUnitSum.DataMember = "TmpProductList"
        Me.CalUnitSum.Expression = "[].Sum([Units])"
        Me.CalUnitSum.Name = "CalUnitSum"
        '
        'CompanyTaxCal
        '
        Me.CompanyTaxCal.DataMember = "TmpOrders"
        Me.CompanyTaxCal.Expression = "Concat('เลขประจำตัวผู้เสียภาษี ',[CompanyTax] )"
        Me.CompanyTaxCal.Name = "CompanyTaxCal"
        '
        'XrCrossBandBox2
        '
        Me.XrCrossBandBox2.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrCrossBandBox2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot
        Me.XrCrossBandBox2.BorderWidth = 1.0!
        Me.XrCrossBandBox2.EndBand = Me.ReportFooter
        Me.XrCrossBandBox2.EndPointFloat = New DevExpress.Utils.PointFloat(0!, 107.533!)
        Me.XrCrossBandBox2.Name = "XrCrossBandBox2"
        Me.XrCrossBandBox2.StartBand = Me.PageHeader
        Me.XrCrossBandBox2.StartPointFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrCrossBandBox2.WidthF = 294.0!
        '
        'rptInvoiceAbb
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader, Me.PageFooter, Me.ReportFooter, Me.ReportHeader})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.ProName, Me.Total_Dis, Me.CalSEQ, Me.CalUnitSum, Me.CompanyTaxCal})
        Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.XrCrossBandBox2})
        Me.DataAdapter = Me.TmpProductListTableAdapter
        Me.DataMember = "TmpProductList"
        Me.DataSource = Me.TmpOrders1
        Me.DisplayName = "Order Report"
        Me.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.Number2Dit, Me.Total})
        Me.Margins = New System.Drawing.Printing.Margins(34, 497, 53, 0)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.SnapGridSize = 8.0!
        Me.Version = "21.2"
        CType(Me.TmpOrders1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TmpOrders1 As TmpOrders
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents Number2Dit As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents Total As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ProName As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents Total_Dis As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents TmpProductListTableAdapter As TmpOrdersTableAdapters.TmpProductListTableAdapter
    Friend WithEvents CalSEQ As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLabel37 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel38 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel39 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CalUnitSum As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CompanyTaxCal As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrCrossBandBox2 As DevExpress.XtraReports.UI.XRCrossBandBox
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine5 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
End Class
