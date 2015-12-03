<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptSellOrders
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel39 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel37 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel38 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TmpOrders1 = New UB.TmpOrders()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.Number2Dit = New DevExpress.XtraReports.UI.FormattingRule()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.Total = New DevExpress.XtraReports.UI.FormattingRule()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.ProName = New DevExpress.XtraReports.UI.CalculatedField()
        Me.Total_Dis = New DevExpress.XtraReports.UI.CalculatedField()
        Me.TmpProductListTableAdapter = New UB.TmpOrdersTableAdapters.TmpProductListTableAdapter()
        Me.CalSEQ = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CalUnitSum = New DevExpress.XtraReports.UI.CalculatedField()
        Me.XrCrossBandBox1 = New DevExpress.XtraReports.UI.XRCrossBandBox()
        Me.XrCrossBandLine1 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.XrCrossBandLine2 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.XrCrossBandLine3 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.XrCrossBandLine4 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.XrCrossBandBox2 = New DevExpress.XtraReports.UI.XRCrossBandBox()
        CType(Me.TmpOrders1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel13, Me.XrLabel12, Me.XrLabel11, Me.XrLabel5, Me.XrLabel4})
        Me.Detail.HeightF = 17.35763!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel13
        '
        Me.XrLabel13.CanGrow = False
        Me.XrLabel13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TmpProductList.Units", "{0:#,#}")})
        Me.XrLabel13.Font = New System.Drawing.Font("Angsana New", 11.0!)
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(237.7254!, 0.0!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(26.30664!, 16.70658!)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "XrLabel13"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel12
        '
        Me.XrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TmpProductList.ProName")})
        Me.XrLabel12.Font = New System.Drawing.Font("Angsana New", 11.0!)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(103.7596!, 0.0!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(135.1952!, 16.70658!)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "XrLabel12"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel11
        '
        Me.XrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TmpProductList.ProductCode")})
        Me.XrLabel11.Font = New System.Drawing.Font("Angsana New", 11.0!)
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(28.01681!, 0.0!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(76.78448!, 16.70658!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "XrLabel11"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.CanGrow = False
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TmpProductList.UnitCode")})
        Me.XrLabel5.Font = New System.Drawing.Font("Angsana New", 10.0!)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(263.8921!, 0.0!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(30.10794!, 16.70658!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "XrLabel5"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.CanGrow = False
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TmpProductList.CalSEQ", "{0:0}")})
        Me.XrLabel4.Font = New System.Drawing.Font("Angsana New", 11.0!)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(1.690482!, 0.0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(25.47404!, 16.70658!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "XrLabel4"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 0.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 0.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel10
        '
        Me.XrLabel10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TmpProductList.CalUnitSum")})
        Me.XrLabel10.Font = New System.Drawing.Font("Angsana New", 12.0!)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(193.4804!, 9.999994!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(47.7451!, 24.45832!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.Text = "XrLabel10"
        '
        'XrLine2
        '
        Me.XrLine2.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(48.31351!, 77.08337!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(232.4859!, 26.12502!)
        '
        'XrLabel18
        '
        Me.XrLabel18.CanGrow = False
        Me.XrLabel18.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 77.08337!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(52.60118!, 26.12502!)
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.Text = "ผู้จัดของ"
        '
        'XrLabel17
        '
        Me.XrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TmpOrders.Employee")})
        Me.XrLabel17.Font = New System.Drawing.Font("Angsana New", 12.0!)
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(48.31356!, 50.95837!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(232.4858!, 26.12499!)
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.Text = "XrLabel17"
        '
        'XrLabel16
        '
        Me.XrLabel16.CanGrow = False
        Me.XrLabel16.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 50.95837!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(52.60118!, 26.12499!)
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.Text = "ผู้ขอเบิก"
        '
        'XrLabel14
        '
        Me.XrLabel14.CanGrow = False
        Me.XrLabel14.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(63.19627!, 9.999994!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(112.5862!, 24.45831!)
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.Text = "จำนวนรวม"
        '
        'XrLabel1
        '
        Me.XrLabel1.CanGrow = False
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TmpOrders.CustomerName")})
        Me.XrLabel1.Font = New System.Drawing.Font("Angsana New", 14.0!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(69.57974!, 111.7546!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(138.6564!, 25.00686!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.Text = "XrLabel1"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel19, Me.XrLabel15, Me.XrLine1, Me.XrLabel21, Me.XrLabel9, Me.XrLabel8, Me.XrLabel7, Me.XrLabel2, Me.XrLabel3, Me.XrLabel39, Me.XrLabel37, Me.XrLabel38, Me.XrLabel1, Me.XrLabel6})
        Me.PageHeader.Font = New System.Drawing.Font("Cordia New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PageHeader.HeightF = 161.377!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.StylePriority.UseFont = False
        '
        'XrLabel19
        '
        Me.XrLabel19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TmpOrders.CustomerCode")})
        Me.XrLabel19.Font = New System.Drawing.Font("Cordia New", 14.0!)
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(69.57974!, 90.45833!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(84.72224!, 23.92594!)
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.Text = "XrLabel19"
        '
        'XrLabel15
        '
        Me.XrLabel15.BorderColor = System.Drawing.Color.Navy
        Me.XrLabel15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TmpOrders.Header1")})
        Me.XrLabel15.Font = New System.Drawing.Font("Angsana New", 18.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(9.999998!, 10.00001!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(284.0!, 45.99998!)
        Me.XrLabel15.StylePriority.UseBorderColor = False
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "XrLabel15"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 159.377!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(292.9584!, 2.0!)
        '
        'XrLabel21
        '
        Me.XrLabel21.CanGrow = False
        Me.XrLabel21.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(260.1442!, 137.1232!)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(32.81415!, 22.25378!)
        Me.XrLabel21.StylePriority.UseFont = False
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        Me.XrLabel21.Text = "หน่วย"
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel9
        '
        Me.XrLabel9.CanGrow = False
        Me.XrLabel9.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(237.305!, 137.1232!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(24.0123!, 22.25374!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "จน."
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel8
        '
        Me.XrLabel8.CanGrow = False
        Me.XrLabel8.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(108.6207!, 138.165!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(105.9447!, 21.21199!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "รายการ"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel7
        '
        Me.XrLabel7.CanGrow = False
        Me.XrLabel7.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(25.41666!, 138.1649!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(79.38461!, 21.21204!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "รหัส"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.CanGrow = False
        Me.XrLabel2.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 137.1232!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(25.41666!, 22.25371!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "ลบ"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel3
        '
        Me.XrLabel3.CanGrow = False
        Me.XrLabel3.Font = New System.Drawing.Font("Angsana New", 15.75!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 91.50003!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(76.58324!, 34.45831!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.Text = "ชื่อลูกค้า"
        '
        'XrLabel39
        '
        Me.XrLabel39.CanGrow = False
        Me.XrLabel39.Font = New System.Drawing.Font("Angsana New", 15.75!)
        Me.XrLabel39.LocationFloat = New DevExpress.Utils.PointFloat(169.5797!, 56.0!)
        Me.XrLabel39.Name = "XrLabel39"
        Me.XrLabel39.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel39.SizeF = New System.Drawing.SizeF(52.62499!, 34.45832!)
        Me.XrLabel39.StylePriority.UseFont = False
        Me.XrLabel39.Text = "วันที่"
        '
        'XrLabel37
        '
        Me.XrLabel37.CanGrow = False
        Me.XrLabel37.Font = New System.Drawing.Font("Angsana New", 15.75!)
        Me.XrLabel37.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 56.0!)
        Me.XrLabel37.Name = "XrLabel37"
        Me.XrLabel37.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel37.SizeF = New System.Drawing.SizeF(52.62499!, 34.45832!)
        Me.XrLabel37.StylePriority.UseFont = False
        Me.XrLabel37.Text = "เลขที่"
        '
        'XrLabel38
        '
        Me.XrLabel38.CanGrow = False
        Me.XrLabel38.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TmpOrders.OrderCode")})
        Me.XrLabel38.Font = New System.Drawing.Font("Angsana New", 14.25!)
        Me.XrLabel38.LocationFloat = New DevExpress.Utils.PointFloat(50.00404!, 56.0!)
        Me.XrLabel38.Name = "XrLabel38"
        Me.XrLabel38.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel38.SizeF = New System.Drawing.SizeF(119.5757!, 35.50003!)
        Me.XrLabel38.StylePriority.UseFont = False
        Me.XrLabel38.Text = "XrLabel3"
        '
        'XrLabel6
        '
        Me.XrLabel6.CanGrow = False
        Me.XrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TmpOrders.OrderDate", "{0:dd/MM/yy}")})
        Me.XrLabel6.Font = New System.Drawing.Font("Angsana New", 14.25!)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(204.8432!, 56.0!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(89.1568!, 34.45833!)
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
        '
        '
        '
        Me.Number2Dit.Formatting.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.Number2Dit.Name = "Number2Dit"
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel14, Me.XrLabel10, Me.XrLabel16, Me.XrLabel17, Me.XrLabel18, Me.XrLine2})
        Me.ReportFooter.HeightF = 113.9723!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'Total
        '
        Me.Total.Condition = "[DataSource.CurrentRowIndex] < [DataSource.RowCount]"
        '
        '
        '
        Me.Total.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[False]
        Me.Total.Name = "Total"
        '
        'ReportHeader
        '
        Me.ReportHeader.HeightF = 0.0!
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
        'XrCrossBandBox1
        '
        Me.XrCrossBandBox1.BorderWidth = 1
        Me.XrCrossBandBox1.EndBand = Me.ReportFooter
        Me.XrCrossBandBox1.EndPointFloat = New DevExpress.Utils.PointFloat(0.6488164!, 3.063725!)
        Me.XrCrossBandBox1.LocationFloat = New DevExpress.Utils.PointFloat(0.6488164!, 137.1233!)
        Me.XrCrossBandBox1.Name = "XrCrossBandBox1"
        Me.XrCrossBandBox1.StartBand = Me.PageHeader
        Me.XrCrossBandBox1.StartPointFloat = New DevExpress.Utils.PointFloat(0.6488164!, 137.1233!)
        Me.XrCrossBandBox1.WidthF = 293.3512!
        '
        'XrCrossBandLine1
        '
        Me.XrCrossBandLine1.EndBand = Me.ReportFooter
        Me.XrCrossBandLine1.EndPointFloat = New DevExpress.Utils.PointFloat(25.6963!, 4.063718!)
        Me.XrCrossBandLine1.LocationFloat = New DevExpress.Utils.PointFloat(25.6963!, 137.1951!)
        Me.XrCrossBandLine1.Name = "XrCrossBandLine1"
        Me.XrCrossBandLine1.StartBand = Me.PageHeader
        Me.XrCrossBandLine1.StartPointFloat = New DevExpress.Utils.PointFloat(25.6963!, 137.1951!)
        Me.XrCrossBandLine1.WidthF = 1.468208!
        '
        'XrCrossBandLine2
        '
        Me.XrCrossBandLine2.EndBand = Me.ReportFooter
        Me.XrCrossBandLine2.EndPointFloat = New DevExpress.Utils.PointFloat(105.0!, 2.838223!)
        Me.XrCrossBandLine2.LocationFloat = New DevExpress.Utils.PointFloat(105.0!, 136.7615!)
        Me.XrCrossBandLine2.Name = "XrCrossBandLine2"
        Me.XrCrossBandLine2.StartBand = Me.PageHeader
        Me.XrCrossBandLine2.StartPointFloat = New DevExpress.Utils.PointFloat(105.0!, 136.7615!)
        Me.XrCrossBandLine2.WidthF = 1.225502!
        '
        'XrCrossBandLine3
        '
        Me.XrCrossBandLine3.EndBand = Me.ReportFooter
        Me.XrCrossBandLine3.EndPointFloat = New DevExpress.Utils.PointFloat(240.0!, 4.063718!)
        Me.XrCrossBandLine3.LocationFloat = New DevExpress.Utils.PointFloat(240.0!, 138.0872!)
        Me.XrCrossBandLine3.Name = "XrCrossBandLine3"
        Me.XrCrossBandLine3.StartBand = Me.PageHeader
        Me.XrCrossBandLine3.StartPointFloat = New DevExpress.Utils.PointFloat(240.0!, 138.0872!)
        Me.XrCrossBandLine3.WidthF = 1.225494!
        '
        'XrCrossBandLine4
        '
        Me.XrCrossBandLine4.EndBand = Me.ReportFooter
        Me.XrCrossBandLine4.EndPointFloat = New DevExpress.Utils.PointFloat(262.0!, 3.450973!)
        Me.XrCrossBandLine4.LocationFloat = New DevExpress.Utils.PointFloat(262.0!, 137.1403!)
        Me.XrCrossBandLine4.Name = "XrCrossBandLine4"
        Me.XrCrossBandLine4.StartBand = Me.PageHeader
        Me.XrCrossBandLine4.StartPointFloat = New DevExpress.Utils.PointFloat(262.0!, 137.1403!)
        Me.XrCrossBandLine4.WidthF = 1.225479!
        '
        'XrCrossBandBox2
        '
        Me.XrCrossBandBox2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot
        Me.XrCrossBandBox2.BorderWidth = 1
        Me.XrCrossBandBox2.EndBand = Me.ReportFooter
        Me.XrCrossBandBox2.EndPointFloat = New DevExpress.Utils.PointFloat(0.0!, 3.921565!)
        Me.XrCrossBandBox2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrCrossBandBox2.Name = "XrCrossBandBox2"
        Me.XrCrossBandBox2.StartBand = Me.PageHeader
        Me.XrCrossBandBox2.StartPointFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrCrossBandBox2.WidthF = 294.0!
        '
        'rptSellOrders
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader, Me.PageFooter, Me.ReportFooter, Me.ReportHeader})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.ProName, Me.Total_Dis, Me.CalSEQ, Me.CalUnitSum})
        Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.XrCrossBandBox2, Me.XrCrossBandLine4, Me.XrCrossBandLine3, Me.XrCrossBandLine2, Me.XrCrossBandLine1, Me.XrCrossBandBox1})
        Me.DataAdapter = Me.TmpProductListTableAdapter
        Me.DataMember = "TmpProductList"
        Me.DataSource = Me.TmpOrders1
        Me.DisplayName = "Order Report"
        Me.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.Number2Dit, Me.Total})
        Me.Margins = New System.Drawing.Printing.Margins(17, 516, 0, 0)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.SnapGridSize = 8.0!
        Me.Version = "13.2"
        CType(Me.TmpOrders1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
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
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ProName As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents Total_Dis As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents TmpProductListTableAdapter As TmpOrdersTableAdapters.TmpProductListTableAdapter
    Friend WithEvents CalSEQ As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel37 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel38 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel39 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CalUnitSum As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrCrossBandBox1 As DevExpress.XtraReports.UI.XRCrossBandBox
    Friend WithEvents XrCrossBandLine1 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents XrCrossBandLine2 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents XrCrossBandLine3 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents XrCrossBandLine4 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrCrossBandBox2 As DevExpress.XtraReports.UI.XRCrossBandBox
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
End Class
