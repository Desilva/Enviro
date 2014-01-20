namespace env.Report
{
    using System;
    using System.ComponentModel;
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;
    using System.Diagnostics;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Charting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for Graphics.
    /// </summary>
    public partial class Graphics : Telerik.Reporting.Report
    {
        public Graphics()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void Graphics_NeedDataSource(object sender, EventArgs e)
        {
            Telerik.Reporting.Processing.Chart report = (Telerik.Reporting.Processing.Chart)sender;
            string yearfrom = report.Report.Parameters["yearfrom"].Value.ToString();
            string yearto = report.Report.Parameters["yearto"].Value.ToString();
            object[] parameter = (object[])report.Report.Parameters["parameter"].Value;
            string type = report.Report.Parameters["TYPE"].Value.ToString();
            string parameters = "";
            foreach (object a in parameter)
            {
                parameters += "," + a.ToString();
            }
            parameters = parameters.Substring(1);
            object[] month = (object[])report.Report.Parameters["months"].Value;
            string months = "";
            foreach (object a in month)
            {
                months += "," + a.ToString();
            }
            months = months.Substring(1);

            ////chart.DataSource = table.DefaultView;             
            DataTable table = new DataTable();
            DataTable tXLabel = new DataTable();
            DataTable tSeries = new DataTable();
            //string sql = @"SELECT procedure_reference, COUNT(date_rise) as [yeartodate] FROM pir group by procedure_reference";
            //string connectionString = "Data Source=LIGHTCROSS;Initial Catalog=star_energi_geo;Integrated Security=True";
            //SqlDataAdapter adapter = new SqlDataAdapter(sql, connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(
            @"select month(date) as month, year(date) as year, lokasi_sampling, sum(case is_galat when 1 then 0 else hasil_analisis end) as hasil_analisis
                from graphic_data left join graphic_type on graphic_data.type = graphic_type.id
	                left join graphic_parameter on graphic_data.id_parameter = graphic_parameter.id
	                left join lokasi_sampling on graphic_data.id_lokasi = lokasi_sampling.id
                where graphic_data.type = " + type + " and id_parameter in (" + parameters + ") and year(date) >= " + yearfrom + @" and year(date) <= " + yearto + " and month(date) in (" + months + @") 
                group by month(date), year(date), lokasi_sampling
                order by year, month
                "
                 , "Data Source=(local);Initial Catalog=star_energy_enviro;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
            adapter.Fill(table);
            SqlDataAdapter adapter2 = new SqlDataAdapter(
            @"select distinct month(date) as month, year(date) as year
                from graphic_data left join graphic_type on graphic_data.type = graphic_type.id
	                left join graphic_parameter on graphic_data.id_parameter = graphic_parameter.id
	                left join lokasi_sampling on graphic_data.id_lokasi = lokasi_sampling.id
                where graphic_data.type = " + type + " and id_parameter in (" + parameters + ") and year(date) >= " + yearfrom + @" and year(date) <= " + yearto + " and month(date) in (" + months + @") 
                order by year, month"
                 , "Data Source=(local);Initial Catalog=star_energy_enviro;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
            adapter2.Fill(tXLabel);
            DataColumn[] column = new DataColumn[2];
            column[0] = tXLabel.Columns["month"];
            column[1] = tXLabel.Columns["year"];
            tXLabel.PrimaryKey = column;
            SqlDataAdapter adapter3 = new SqlDataAdapter(
            @"select distinct lokasi_sampling
                            from graphic_data left join graphic_type on graphic_data.type = graphic_type.id
            	                left join graphic_parameter on graphic_data.id_parameter = graphic_parameter.id
            	                left join lokasi_sampling on graphic_data.id_lokasi = lokasi_sampling.id
                            where graphic_data.type = " + type + " and id_parameter in (" + parameters + ") and year(date) >= " + yearfrom + @" and year(date) <= " + yearto + " and month(date) in (" + months + @") 
                            "
                 , "Data Source=(local);Initial Catalog=star_energy_enviro;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
            adapter3.Fill(tSeries);
            DataColumn[] column2 = new DataColumn[1];
            column2[0] = tSeries.Columns["lokasi_sampling"];
            tSeries.PrimaryKey = column2;

            Color[] colors = new Color[] { 
                Color.Red, 
                Color.Yellow, 
                Color.Black, 
                Color.Blue, 
                Color.Pink, 
                Color.Green, 
                Color.MediumPurple, 
                Color.Brown, 
                Color.Orange, 
                Color.Gray 
            };

            this.chart1.PlotArea.XAxis.Appearance.ValueFormat = Telerik.Reporting.Charting.Styles.ChartValueFormat.General;
            this.chart1.PlotArea.XAxis.AutoScale = false;
            if (tXLabel.Rows.Count != 0)
            {
                this.chart1.PlotArea.XAxis.AddRange(0, tXLabel.Rows.Count - 1, 1);
            }
            else
            {
                this.chart1.PlotArea.XAxis.AddRange(0, 0, 1);
            }
            int i = 0;
            foreach (DataRow d in tXLabel.Rows)
            {
                this.chart1.PlotArea.XAxis.Items[i].TextBlock.Text = ((int)d["month"] == 1 ? "Jan" : ((int)d["month"] == 2 ? "Feb" : ((int)d["month"] == 3 ? "Mar" : ((int)d["month"] == 4 ? "Apr" : ((int)d["month"] == 5 ? "May" : ((int)d["month"] == 6 ? "Jun" : ((int)d["month"] == 7 ? "Jul" : ((int)d["month"] == 8 ? "Aug" : ((int)d["month"] == 9 ? "Sep" : ((int)d["month"] == 10 ? "Oct" : ((int)d["month"] == 11 ? "Nov" : "Dec"))))))))))) + " " + d["year"];
                i++;
            }
            
            Telerik.Reporting.Chart defChart = (Telerik.Reporting.Chart)report.ItemDefinition;
            ChartSeries[] series = new ChartSeries[tSeries.Rows.Count];

            defChart.Series.Clear();
            for (i = 0; i < tSeries.Rows.Count;i++)
            {
                series[i] = new ChartSeries();
                series[i].Type = ChartSeriesType.Line;
                defChart.Series.Add(series[i]);
                series[i].Clear();
                series[i].Appearance.LegendDisplayMode = ChartSeriesLegendDisplayMode.SeriesName;
                series[i].Name = tSeries.Rows[i]["lokasi_sampling"].ToString();
                series[i].Appearance.EmptyValue.Mode = Telerik.Reporting.Charting.Styles.EmtyValuesMode.Approximation;
                series[i].Appearance.EmptyValue.Line.Width = 0;
                series[i].Appearance.EmptyValue.PointMark.Visible = false;
                series[i].Appearance.PointMark.Visible = true;
                series[i].Appearance.PointShape = "rectangle";
                series[i].Appearance.PointMark.FillStyle.FillType = Telerik.Reporting.Charting.Styles.FillType.Solid;
                series[i].Appearance.PointMark.FillStyle.MainColor = colors[i];
            }

            foreach (DataRow row in table.Rows)
            {
                ChartSeriesItem item = new ChartSeriesItem();
                item.YValue = (double)row["hasil_analisis"];
                object[] a = { row["month"], row["year"] };
                int x = tXLabel.Rows.IndexOf(tXLabel.Rows.Find(a));
                item.XValue = x;
                item.Label.TextBlock.Text = "#Y";
                item.Label.TextBlock.Appearance.Dimensions.Margins.Bottom = 0;
                item.Label.TextBlock.Appearance.Position.X = 0;
                item.Label.Appearance.Position.AlignedPosition = Telerik.Reporting.Charting.Styles.AlignedPositions.Left;
                item.Label.TextBlock.Appearance.TextProperties.Color = Color.FromArgb(65,64,66);
                item.Label.TextBlock.Appearance.TextProperties.Font = new System.Drawing.Font("Arial", 12, FontStyle.Regular);
                int totalData = series[tSeries.Rows.IndexOf(tSeries.Rows.Find(row["lokasi_sampling"]))].Items.Count;
                if (x == totalData)
                {
                    series[tSeries.Rows.IndexOf(tSeries.Rows.Find(row["lokasi_sampling"]))].Items.Add(item);
                }
                else
                {
                    for (i = 0; i < x - totalData; i++)
                    {
                        ChartSeriesItem itemDummy = new ChartSeriesItem();
                        itemDummy.Empty = true;
                        itemDummy.XValue = totalData + i;
                        itemDummy.Label.TextBlock.Visible = false;
                        series[tSeries.Rows.IndexOf(tSeries.Rows.Find(row["lokasi_sampling"]))].Items.Add(itemDummy);
                    }
                    series[tSeries.Rows.IndexOf(tSeries.Rows.Find(row["lokasi_sampling"]))].Items.Add(item);
                }
                

            }
            this.chart1.ChartTitle.TextBlock.Text = report.Report.Parameters["TYPE"].Label.ToString() + " Quality";
            this.chart1.PlotArea.YAxis.AxisLabel.TextBlock.Text = report.Report.Parameters["unit"].Label == null ? "" : report.Report.Parameters["unit"].Label.ToString();
            this.chart1.PlotArea.YAxis.AxisLabel.Visible = true;
            this.chart1.Legend.Appearance.Position.AlignedPosition = Telerik.Reporting.Charting.Styles.AlignedPositions.BottomRight;
            this.chart1.Legend.Appearance.Position.Auto = true;
            this.chart1.Legend.Appearance.ItemMarkerAppearance.Figure = "Rectangle";
            this.chart1.Legend.Appearance.ItemTextAppearance.TextProperties.Color = Color.FromArgb(88,89,91);
            this.chart1.Legend.Appearance.ItemTextAppearance.TextProperties.Font = new System.Drawing.Font("Arial", 12, FontStyle.Regular);
            this.chart1.Legend.Appearance.Dimensions.Margins.Bottom = 60;
            Palette pal = new Palette();
            foreach (var color in colors)
            {
                pal.Items.Add(new PaletteItem(color, color));
            }
            pal.Name = "MyPalette";
            this.chart1.CustomPalettes.Add(pal);
            this.chart1.SeriesPalette = "MyPalette"; 

        }
    }
}