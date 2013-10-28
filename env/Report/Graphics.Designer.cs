namespace env.Report
{
    partial class Graphics
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graphics));
            Telerik.Reporting.Charting.Styles.ChartMargins chartMargins1 = new Telerik.Reporting.Charting.Styles.ChartMargins();
            Telerik.Reporting.Charting.Styles.ChartMargins chartMargins2 = new Telerik.Reporting.Charting.Styles.ChartMargins();
            Telerik.Reporting.Charting.Styles.ChartMargins chartMargins3 = new Telerik.Reporting.Charting.Styles.ChartMargins();
            Telerik.Reporting.ReportParameter reportParameter1 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.ReportParameter reportParameter2 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.ReportParameter reportParameter3 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.ReportParameter reportParameter4 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.ReportParameter reportParameter5 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.ReportParameter reportParameter6 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            this.graphic_type = new Telerik.Reporting.SqlDataSource();
            this.Year = new Telerik.Reporting.SqlDataSource();
            this.graphic_parameter = new Telerik.Reporting.SqlDataSource();
            this.detail = new Telerik.Reporting.DetailSection();
            this.chart1 = new Telerik.Reporting.Chart();
            this.graphics_unit = new Telerik.Reporting.SqlDataSource();
            this.month = new Telerik.Reporting.SqlDataSource();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // graphic_type
            // 
            this.graphic_type.ConnectionString = "starenergyenviro";
            this.graphic_type.Name = "graphic_type";
            this.graphic_type.SelectCommand = "select id, name\r\nfrom graphic_type";
            // 
            // Year
            // 
            this.Year.ConnectionString = "starenergyenviro";
            this.Year.Name = "Year";
            this.Year.Parameters.AddRange(new Telerik.Reporting.SqlDataSourceParameter[] {
            new Telerik.Reporting.SqlDataSourceParameter("@TYPE", System.Data.DbType.String, "=Parameters.TYPE.Value")});
            this.Year.SelectCommand = resources.GetString("Year.SelectCommand");
            // 
            // graphic_parameter
            // 
            this.graphic_parameter.ConnectionString = "starenergyenviro";
            this.graphic_parameter.Name = "graphic_parameter";
            this.graphic_parameter.Parameters.AddRange(new Telerik.Reporting.SqlDataSourceParameter[] {
            new Telerik.Reporting.SqlDataSourceParameter("@TYPE", System.Data.DbType.String, "=Parameters.TYPE.Value")});
            this.graphic_parameter.SelectCommand = "select id, parameter\r\nfrom graphic_parameter\r\nwhere type = @TYPE";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(7.3000001907348633D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.chart1});
            this.detail.Name = "detail";
            // 
            // chart1
            // 
            this.chart1.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(136)))), ((int)(((byte)(74)))));
            this.chart1.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(209)))), ((int)(((byte)(151)))));
            this.chart1.BitmapResolution = 96F;
            this.chart1.ChartTitle.Appearance.Border.Color = System.Drawing.Color.Transparent;
            chartMargins1.Bottom = new Telerik.Reporting.Charting.Styles.Unit(14D, Telerik.Reporting.Charting.Styles.UnitType.Pixel);
            chartMargins1.Left = new Telerik.Reporting.Charting.Styles.Unit(6D, Telerik.Reporting.Charting.Styles.UnitType.Percentage);
            chartMargins1.Right = new Telerik.Reporting.Charting.Styles.Unit(10D, Telerik.Reporting.Charting.Styles.UnitType.Pixel);
            chartMargins1.Top = new Telerik.Reporting.Charting.Styles.Unit(3D, Telerik.Reporting.Charting.Styles.UnitType.Percentage);
            this.chart1.ChartTitle.Appearance.Dimensions.Margins = chartMargins1;
            this.chart1.ChartTitle.Appearance.FillStyle.MainColor = System.Drawing.Color.Transparent;
            this.chart1.ChartTitle.TextBlock.Appearance.Position.AlignedPosition = Telerik.Reporting.Charting.Styles.AlignedPositions.Top;
            this.chart1.ChartTitle.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(33)))), ((int)(((byte)(0)))));
            this.chart1.ChartTitle.TextBlock.Appearance.TextProperties.Font = new System.Drawing.Font("Arial", 18F);
            this.chart1.ChartTitle.TextBlock.Text = "Title";
            this.chart1.DefaultType = Telerik.Reporting.Charting.ChartSeriesType.Line;
            this.chart1.ImageFormat = System.Drawing.Imaging.ImageFormat.Emf;
            this.chart1.Legend.Appearance.Border.Color = System.Drawing.Color.Transparent;
            chartMargins2.Bottom = new Telerik.Reporting.Charting.Styles.Unit(9D, Telerik.Reporting.Charting.Styles.UnitType.Percentage);
            chartMargins2.Right = new Telerik.Reporting.Charting.Styles.Unit(2D, Telerik.Reporting.Charting.Styles.UnitType.Percentage);
            this.chart1.Legend.Appearance.Dimensions.Margins = chartMargins2;
            this.chart1.Legend.Appearance.FillStyle.MainColor = System.Drawing.Color.Transparent;
            this.chart1.Legend.Appearance.ItemTextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(68)))), ((int)(((byte)(43)))));
            this.chart1.Legend.Appearance.ItemTextAppearance.TextProperties.Font = new System.Drawing.Font("Arial", 10F);
            this.chart1.Legend.Appearance.Position.AlignedPosition = Telerik.Reporting.Charting.Styles.AlignedPositions.BottomRight;
            this.chart1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.1000000610947609D), Telerik.Reporting.Drawing.Unit.Inch(0.099999904632568359D));
            this.chart1.Name = "chart1";
            this.chart1.PlotArea.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(103)))));
            chartMargins3.Bottom = new Telerik.Reporting.Charting.Styles.Unit(12D, Telerik.Reporting.Charting.Styles.UnitType.Percentage);
            chartMargins3.Left = new Telerik.Reporting.Charting.Styles.Unit(8D, Telerik.Reporting.Charting.Styles.UnitType.Percentage);
            chartMargins3.Right = new Telerik.Reporting.Charting.Styles.Unit(100D, Telerik.Reporting.Charting.Styles.UnitType.Pixel);
            chartMargins3.Top = new Telerik.Reporting.Charting.Styles.Unit(18D, Telerik.Reporting.Charting.Styles.UnitType.Percentage);
            this.chart1.PlotArea.Appearance.Dimensions.Margins = chartMargins3;
            this.chart1.PlotArea.Appearance.FillStyle.FillType = Telerik.Reporting.Charting.Styles.FillType.Solid;
            this.chart1.PlotArea.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(236)))), ((int)(((byte)(194)))));
            this.chart1.PlotArea.EmptySeriesMessage.Appearance.Visible = true;
            this.chart1.PlotArea.EmptySeriesMessage.Visible = true;
            this.chart1.PlotArea.XAxis.Appearance.Color = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(103)))));
            this.chart1.PlotArea.XAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(103)))));
            this.chart1.PlotArea.XAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(103)))));
            this.chart1.PlotArea.XAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(68)))), ((int)(((byte)(43)))));
            this.chart1.PlotArea.XAxis.AxisLabel.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(68)))), ((int)(((byte)(43)))));
            this.chart1.PlotArea.YAxis.Appearance.Color = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(103)))));
            this.chart1.PlotArea.YAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(171)))), ((int)(((byte)(121)))));
            this.chart1.PlotArea.YAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(103)))));
            this.chart1.PlotArea.YAxis.Appearance.MinorGridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(171)))), ((int)(((byte)(121)))));
            this.chart1.PlotArea.YAxis.Appearance.MinorTick.Color = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(103)))));
            this.chart1.PlotArea.YAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(68)))), ((int)(((byte)(43)))));
            this.chart1.PlotArea.YAxis.AxisLabel.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(68)))), ((int)(((byte)(43)))));
            this.chart1.PlotArea.YAxis.Step = 5D;
            this.chart1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(10.500000953674316D), Telerik.Reporting.Drawing.Unit.Inch(7.1000003814697266D));
            this.chart1.Skin = "Forest";
            this.chart1.NeedDataSource += new System.EventHandler(this.Graphics_NeedDataSource);
            // 
            // graphics_unit
            // 
            this.graphics_unit.ConnectionString = "starenergyenviro";
            this.graphics_unit.Name = "graphics_unit";
            this.graphics_unit.SelectCommand = "select * from graphics_unit";
            // 
            // month
            // 
            this.month.ConnectionString = "starenergyenviro";
            this.month.Name = "month";
            this.month.SelectCommand = resources.GetString("month.SelectCommand");
            // 
            // Graphics
            // 
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.detail});
            this.Name = "Graphics";
            this.PageSettings.Landscape = true;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.5D), Telerik.Reporting.Drawing.Unit.Inch(0.5D), Telerik.Reporting.Drawing.Unit.Inch(0.5D), Telerik.Reporting.Drawing.Unit.Inch(0.5D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            reportParameter1.AutoRefresh = true;
            reportParameter1.AvailableValues.DataSource = this.graphic_type;
            reportParameter1.AvailableValues.DisplayMember = "= Fields.name";
            reportParameter1.AvailableValues.ValueMember = "= Fields.id";
            reportParameter1.Name = "TYPE";
            reportParameter1.Text = "type";
            reportParameter2.AutoRefresh = true;
            reportParameter2.AvailableValues.DataSource = this.Year;
            reportParameter2.AvailableValues.DisplayMember = "= Fields.year";
            reportParameter2.AvailableValues.ValueMember = "= Fields.year";
            reportParameter2.Name = "yearfrom";
            reportParameter2.Text = "From";
            reportParameter2.Visible = true;
            reportParameter3.AutoRefresh = true;
            reportParameter3.AvailableValues.DataSource = this.Year;
            reportParameter3.AvailableValues.DisplayMember = "= Fields.year";
            reportParameter3.AvailableValues.ValueMember = "= Fields.year";
            reportParameter3.Name = "yearto";
            reportParameter3.Text = "To";
            reportParameter3.Visible = true;
            reportParameter4.AutoRefresh = true;
            reportParameter4.AvailableValues.DataSource = this.graphic_parameter;
            reportParameter4.AvailableValues.DisplayMember = "= Fields.parameter";
            reportParameter4.AvailableValues.ValueMember = "= Fields.id";
            reportParameter4.MultiValue = true;
            reportParameter4.Name = "parameter";
            reportParameter4.Text = "Parameter";
            reportParameter4.Type = Telerik.Reporting.ReportParameterType.Integer;
            reportParameter4.Visible = true;
            reportParameter5.AutoRefresh = true;
            reportParameter5.AvailableValues.DataSource = this.month;
            reportParameter5.AvailableValues.DisplayMember = "= Fields.month_name";
            reportParameter5.AvailableValues.ValueMember = "= Fields.month";
            reportParameter5.MultiValue = true;
            reportParameter5.Name = "months";
            reportParameter5.Text = "Chosen Month";
            reportParameter5.Type = Telerik.Reporting.ReportParameterType.Integer;
            reportParameter5.Visible = true;
            reportParameter6.AllowNull = true;
            reportParameter6.AutoRefresh = true;
            reportParameter6.AvailableValues.DataSource = this.graphics_unit;
            reportParameter6.AvailableValues.DisplayMember = "= Fields.unit";
            reportParameter6.AvailableValues.ValueMember = "= Fields.id";
            reportParameter6.Name = "unit";
            reportParameter6.Text = "Unit";
            reportParameter6.Visible = true;
            this.ReportParameters.Add(reportParameter1);
            this.ReportParameters.Add(reportParameter2);
            this.ReportParameters.Add(reportParameter3);
            this.ReportParameters.Add(reportParameter4);
            this.ReportParameters.Add(reportParameter5);
            this.ReportParameters.Add(reportParameter6);
            this.Style.BackgroundColor = System.Drawing.Color.White;
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1});
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(10.6899995803833D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.Chart chart1;
        private Telerik.Reporting.SqlDataSource Year;
        private Telerik.Reporting.SqlDataSource graphic_type;
        private Telerik.Reporting.SqlDataSource graphic_parameter;
        private Telerik.Reporting.SqlDataSource graphics_unit;
        private Telerik.Reporting.SqlDataSource month;
    }
}