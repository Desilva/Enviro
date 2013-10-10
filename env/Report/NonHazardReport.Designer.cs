using System.Configuration;
namespace env.Report
{
    partial class NonHazardReport
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NonHazardReport));
            Telerik.Reporting.GraphGroup graphGroup1 = new Telerik.Reporting.GraphGroup();
            Telerik.Reporting.GraphGroup graphGroup2 = new Telerik.Reporting.GraphGroup();
            Telerik.Reporting.GraphTitle graphTitle1 = new Telerik.Reporting.GraphTitle();
            Telerik.Reporting.CategoryScale categoryScale1 = new Telerik.Reporting.CategoryScale();
            Telerik.Reporting.NumericalScale numericalScale1 = new Telerik.Reporting.NumericalScale();
            Telerik.Reporting.NumericalScale numericalScale2 = new Telerik.Reporting.NumericalScale();
            Telerik.Reporting.GraphGroup graphGroup3 = new Telerik.Reporting.GraphGroup();
            Telerik.Reporting.ReportParameter reportParameter1 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.ReportParameter reportParameter2 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.ReportParameter reportParameter3 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.ReportParameter reportParameter4 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            this.Month = new Telerik.Reporting.SqlDataSource();
            this.Year = new Telerik.Reporting.SqlDataSource();
            this.sqlDataSource1 = new Telerik.Reporting.SqlDataSource();
            this.detail = new Telerik.Reporting.DetailSection();
            this.panel1 = new Telerik.Reporting.Panel();
            this.pictureBox1 = new Telerik.Reporting.PictureBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.graph1 = new Telerik.Reporting.Graph();
            this.cartesianCoordinateSystem1 = new Telerik.Reporting.CartesianCoordinateSystem();
            this.graphAxis1 = new Telerik.Reporting.GraphAxis();
            this.graphAxis2 = new Telerik.Reporting.GraphAxis();
            this.cartesianCoordinateSystem2 = new Telerik.Reporting.CartesianCoordinateSystem();
            this.graphAxis3 = new Telerik.Reporting.GraphAxis();
            this.barSeries1 = new Telerik.Reporting.BarSeries();
            this.barSeries2 = new Telerik.Reporting.BarSeries();
            this.lineSeries1 = new Telerik.Reporting.LineSeries();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Month
            // 
            this.Month.ConnectionString = "starenergyenviro";
            this.Month.Name = "Month";
            this.Month.ProviderName = "System.Data.SqlClient";
            this.Month.SelectCommand = "with mnth(mnuum) as (\r\nselect 1\r\nunion all\r\nselect mnuum+1 from mnth where mnuum<" +
    "12)\r\nselect mnuum as month from mnth";
            // 
            // Year
            // 
            this.Year.ConnectionString = "starenergyenviro";
            this.Year.Name = "Year";
            this.Year.ProviderName = "System.Data.SqlClient";
            this.Year.SelectCommand = "with yeer(yrnum) as (\r\nselect 2000\r\nunion all\r\nselect yrnum+1 from yeer where yrn" +
    "um<2100)\r\nselect yrnum as year from yeer";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionString = "starenergyenviro";
            this.sqlDataSource1.Name = "sqlDataSource1";
            this.sqlDataSource1.Parameters.AddRange(new Telerik.Reporting.SqlDataSourceParameter[] {
            new Telerik.Reporting.SqlDataSourceParameter("@monthfrom", System.Data.DbType.String, "=Parameters.monthfrom.Value"),
            new Telerik.Reporting.SqlDataSourceParameter("@yearfrom", System.Data.DbType.String, "=Parameters.yearfrom.Value"),
            new Telerik.Reporting.SqlDataSourceParameter("@monthto", System.Data.DbType.String, "=Parameters.monthto.Value"),
            new Telerik.Reporting.SqlDataSourceParameter("@yearto", System.Data.DbType.String, "=Parameters.yearto.Value")});
            this.sqlDataSource1.SelectCommand = resources.GetString("sqlDataSource1.SelectCommand");
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(6.8000001907348633D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.panel1,
            this.graph1});
            this.detail.Name = "detail";
            // 
            // panel1
            // 
            this.panel1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pictureBox1,
            this.textBox1,
            this.textBox2});
            this.panel1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.099999986588954926D), Telerik.Reporting.Drawing.Unit.Inch(0.099999986588954926D));
            this.panel1.Name = "panel1";
            this.panel1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(10.899998664855957D), Telerik.Reporting.Drawing.Unit.Inch(1.2000000476837158D));
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9339065551757812E-05D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.pictureBox1.MimeType = "image/png";
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6999607086181641D), Telerik.Reporting.Drawing.Unit.Inch(1.1999210119247437D));
            this.pictureBox1.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional;
            this.pictureBox1.Value = ((object)(resources.GetObject("pictureBox1.Value")));
            // 
            // textBox1
            // 
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.7999998331069946D), Telerik.Reporting.Drawing.Unit.Inch(0.099999986588954926D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(9D), Telerik.Reporting.Drawing.Unit.Inch(0.40000006556510925D));
            this.textBox1.Style.Font.Bold = true;
            this.textBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(20D);
            this.textBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox1.Value = "STAR ENERGY (WAYANG WINDU) LIMITED";
            // 
            // textBox2
            // 
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.8000000715255737D), Telerik.Reporting.Drawing.Unit.Inch(0.50000005960464478D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(9D), Telerik.Reporting.Drawing.Unit.Inch(0.599921464920044D));
            this.textBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(16D);
            this.textBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox2.Value = "Non Hazardous Recycle Rate Report";
            // 
            // graph1
            // 
            graphGroup2.Groupings.Add(new Telerik.Reporting.Grouping("=Fields.yeer"));
            graphGroup2.Groupings.Add(new Telerik.Reporting.Grouping("=Fields.mnuum"));
            graphGroup2.Label = resources.GetString("graphGroup2.Label");
            graphGroup2.Name = "yearGroup1";
            graphGroup2.Sortings.Add(new Telerik.Reporting.Sorting("=Fields.yeer", Telerik.Reporting.SortDirection.Asc));
            graphGroup2.Sortings.Add(new Telerik.Reporting.Sorting("=Fields.mnuum", Telerik.Reporting.SortDirection.Asc));
            graphGroup1.ChildGroups.Add(graphGroup2);
            graphGroup1.Label = "= Fields.mnuum";
            graphGroup1.Name = "graphGroup1";
            this.graph1.CategoryGroups.Add(graphGroup1);
            this.graph1.CoordinateSystems.Add(this.cartesianCoordinateSystem1);
            this.graph1.CoordinateSystems.Add(this.cartesianCoordinateSystem2);
            this.graph1.DataSource = this.sqlDataSource1;
            this.graph1.Legend.Style.LineColor = System.Drawing.Color.LightGray;
            this.graph1.Legend.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0D);
            this.graph1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.10000000894069672D), Telerik.Reporting.Drawing.Unit.Inch(1.4000000953674316D));
            this.graph1.Name = "graph1";
            this.graph1.PlotAreaStyle.LineColor = System.Drawing.Color.LightGray;
            this.graph1.PlotAreaStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0D);
            this.graph1.Series.Add(this.barSeries1);
            this.graph1.Series.Add(this.barSeries2);
            this.graph1.Series.Add(this.lineSeries1);
            this.graph1.SeriesGroups.Add(graphGroup3);
            this.graph1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(10.899999618530273D), Telerik.Reporting.Drawing.Unit.Inch(5.2999997138977051D));
            graphTitle1.Style.Font.Bold = true;
            graphTitle1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(16D);
            graphTitle1.Style.LineColor = System.Drawing.Color.LightGray;
            graphTitle1.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0D);
            graphTitle1.Text = "Non Hazardous Recycle Rate";
            this.graph1.Titles.Add(graphTitle1);
            // 
            // cartesianCoordinateSystem1
            // 
            this.cartesianCoordinateSystem1.Name = "cartesianCoordinateSystem1";
            this.cartesianCoordinateSystem1.XAxis = this.graphAxis1;
            this.cartesianCoordinateSystem1.YAxis = this.graphAxis2;
            // 
            // graphAxis1
            // 
            this.graphAxis1.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis1.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis1.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis1.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis1.MinorGridLineStyle.Visible = false;
            this.graphAxis1.Name = "GraphAxis1";
            categoryScale1.SpacingSlotCount = 1D;
            this.graphAxis1.Scale = categoryScale1;
            // 
            // graphAxis2
            // 
            this.graphAxis2.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis2.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis2.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis2.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis2.MinorGridLineStyle.Visible = false;
            this.graphAxis2.Name = "GraphAxis2";
            numericalScale1.CrossAxisValue = 0D;
            numericalScale1.SpacingSlotCount = 1D;
            this.graphAxis2.Scale = numericalScale1;
            // 
            // cartesianCoordinateSystem2
            // 
            this.cartesianCoordinateSystem2.Name = "cartesianCoordinateSystem2";
            this.cartesianCoordinateSystem2.XAxis = this.graphAxis1;
            this.cartesianCoordinateSystem2.YAxis = this.graphAxis3;
            // 
            // graphAxis3
            // 
            this.graphAxis3.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis3.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis3.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis3.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis3.MinorGridLineStyle.Visible = false;
            this.graphAxis3.Name = "GraphAxis3";
            numericalScale2.CrossAxisValue = 0D;
            numericalScale2.SpacingSlotCount = 1D;
            this.graphAxis3.Scale = numericalScale2;
            // 
            // barSeries1
            // 
            this.barSeries1.CategoryGroup = graphGroup2;
            this.barSeries1.CoordinateSystem = this.cartesianCoordinateSystem1;
            this.barSeries1.Legend = "Waste In";
            this.barSeries1.LegendFormat = "";
            graphGroup3.Name = "graphGroup2";
            this.barSeries1.SeriesGroup = graphGroup3;
            this.barSeries1.Y = "= Fields.waste_in";
            // 
            // barSeries2
            // 
            this.barSeries2.CategoryGroup = graphGroup2;
            this.barSeries2.CoordinateSystem = this.cartesianCoordinateSystem1;
            this.barSeries2.Legend = "Waste Out";
            this.barSeries2.LegendFormat = "";
            this.barSeries2.SeriesGroup = graphGroup3;
            this.barSeries2.Y = "= Fields.waste_out";
            // 
            // lineSeries1
            // 
            this.lineSeries1.CategoryGroup = graphGroup2;
            this.lineSeries1.CoordinateSystem = this.cartesianCoordinateSystem2;
            this.lineSeries1.DataPointLabel = "= Fields.recycle_rate / 100";
            this.lineSeries1.DataPointLabelFormat = "{0:P2}";
            this.lineSeries1.DataPointLabelStyle.BorderColor.Default = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.lineSeries1.DataPointLabelStyle.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.lineSeries1.DataPointLabelStyle.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(10D);
            this.lineSeries1.DataPointLabelStyle.Color = System.Drawing.Color.Black;
            this.lineSeries1.DataPointLabelStyle.Font.Bold = true;
            this.lineSeries1.DataPointLabelStyle.LineColor = System.Drawing.Color.Bisque;
            this.lineSeries1.DataPointStyle.Visible = true;
            this.lineSeries1.Legend = "Recycle Rate";
            this.lineSeries1.LegendFormat = "";
            this.lineSeries1.LineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(3D);
            this.lineSeries1.MarkerMaxSize = Telerik.Reporting.Drawing.Unit.Pixel(50D);
            this.lineSeries1.MarkerMinSize = Telerik.Reporting.Drawing.Unit.Pixel(5D);
            this.lineSeries1.MarkerSize = Telerik.Reporting.Drawing.Unit.Pixel(5D);
            this.lineSeries1.MarkerType = Telerik.Reporting.DataPointMarkerType.Circle;
            this.lineSeries1.SeriesGroup = graphGroup3;
            this.lineSeries1.Size = null;
            this.lineSeries1.Y = "= Fields.recycle_rate";
            // 
            // NonHazardReport
            // 
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.detail});
            this.Name = "Report1";
            this.PageSettings.Landscape = true;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.25D), Telerik.Reporting.Drawing.Unit.Inch(0.25D), Telerik.Reporting.Drawing.Unit.Inch(0.25D), Telerik.Reporting.Drawing.Unit.Inch(0.25D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            reportParameter1.AutoRefresh = true;
            reportParameter1.AvailableValues.DataSource = this.Month;
            reportParameter1.AvailableValues.DisplayMember = "= Fields.month";
            reportParameter1.AvailableValues.ValueMember = "= Fields.month";
            reportParameter1.Name = "monthfrom";
            reportParameter1.Text = "Month From";
            reportParameter1.Type = Telerik.Reporting.ReportParameterType.Integer;
            reportParameter1.Visible = true;
            reportParameter2.AutoRefresh = true;
            reportParameter2.AvailableValues.DataSource = this.Month;
            reportParameter2.AvailableValues.DisplayMember = "= Fields.month";
            reportParameter2.AvailableValues.ValueMember = "= Fields.month";
            reportParameter2.Name = "monthto";
            reportParameter2.Text = "Month To";
            reportParameter2.Type = Telerik.Reporting.ReportParameterType.Integer;
            reportParameter2.Visible = true;
            reportParameter3.AutoRefresh = true;
            reportParameter3.AvailableValues.DataSource = this.Year;
            reportParameter3.AvailableValues.DisplayMember = "= Fields.year";
            reportParameter3.AvailableValues.ValueMember = "= Fields.year";
            reportParameter3.Name = "yearfrom";
            reportParameter3.Text = "Year From";
            reportParameter3.Type = Telerik.Reporting.ReportParameterType.Integer;
            reportParameter3.Visible = true;
            reportParameter4.AutoRefresh = true;
            reportParameter4.AvailableValues.DataSource = this.Year;
            reportParameter4.AvailableValues.DisplayMember = "= Fields.year";
            reportParameter4.AvailableValues.ValueMember = "= Fields.year";
            reportParameter4.Name = "yearto";
            reportParameter4.Text = "Year To";
            reportParameter4.Type = Telerik.Reporting.ReportParameterType.Integer;
            reportParameter4.Visible = true;
            this.ReportParameters.Add(reportParameter1);
            this.ReportParameters.Add(reportParameter2);
            this.ReportParameters.Add(reportParameter3);
            this.ReportParameters.Add(reportParameter4);
            this.Style.BackgroundColor = System.Drawing.Color.White;
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1});
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(11.100001335144043D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.Panel panel1;
        private Telerik.Reporting.PictureBox pictureBox1;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.SqlDataSource sqlDataSource1;
        private Telerik.Reporting.Graph graph1;
        private Telerik.Reporting.CartesianCoordinateSystem cartesianCoordinateSystem1;
        private Telerik.Reporting.GraphAxis graphAxis1;
        private Telerik.Reporting.GraphAxis graphAxis2;
        private Telerik.Reporting.BarSeries barSeries1;
        private Telerik.Reporting.CartesianCoordinateSystem cartesianCoordinateSystem2;
        private Telerik.Reporting.GraphAxis graphAxis3;
        private Telerik.Reporting.BarSeries barSeries2;
        private Telerik.Reporting.LineSeries lineSeries1;
        private Telerik.Reporting.SqlDataSource Month;
        private Telerik.Reporting.SqlDataSource Year;
    }
}