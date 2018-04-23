using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace FormatCrosshairLabels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.Load += new System.EventHandler(this.Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create an empty chart.
            ChartControl chartControl1 = new ChartControl();

            // Create a first line series and add points to it.
            Series series1 = new Series("Europe", ViewType.Line);
            series1.Points.Add(new SeriesPoint(1950, 546));
            series1.Points.Add(new SeriesPoint(1960, 605));
            series1.Points.Add(new SeriesPoint(1970, 656));
            series1.Points.Add(new SeriesPoint(1980, 694));
            series1.Points.Add(new SeriesPoint(1990, 721));
            series1.Points.Add(new SeriesPoint(2000, 730));
            series1.Points.Add(new SeriesPoint(2010, 728));

            // Create a second line series and add points to it.
            Series series2 = new Series("Americas", ViewType.Line);
            series2.Points.Add(new SeriesPoint(1950, 332));
            series2.Points.Add(new SeriesPoint(1960, 417));
            series2.Points.Add(new SeriesPoint(1970, 513));
            series2.Points.Add(new SeriesPoint(1980, 614));
            series2.Points.Add(new SeriesPoint(1990, 721));
            series2.Points.Add(new SeriesPoint(2000, 836));
            series2.Points.Add(new SeriesPoint(2010, 935));

            // Add the series to the chart.
            chartControl1.Series.Add(series1);
            chartControl1.Series.Add(series2);

            // Hide the legend (if necessary).
            chartControl1.Legend.Visible = false;

            //Show crosshair axis lines and crosshair axis labels to see format values of crosshair labels 
            chartControl1.CrosshairOptions.ShowArgumentLabels = true;
            chartControl1.CrosshairOptions.ShowValueLabels = true;
            chartControl1.CrosshairOptions.ShowValueLine = true;
            chartControl1.CrosshairOptions.ShowArgumentLine = true;

            // Specify the crosshair label pattern for both series.
            series1.CrosshairLabelPattern = "{S} population: {V}";
            series2.CrosshairLabelPattern = "{S} population: {V}";

            // Specify the crosshair group header pattern.
            chartControl1.CrosshairOptions.GroupHeaderPattern = "Year: {A}";

            // Cast the chart's diagram to the XYDiagram type, to access its axes.
            XYDiagram diagram = (XYDiagram)chartControl1.Diagram;

            // Specify the crosshair axis labels pattern for X-axis.
            diagram.AxisX.CrosshairAxisLabelOptions.Pattern = "Year: {A:F0}";

            // Add the chart to the form.
            chartControl1.Dock = DockStyle.Fill;
            this.Controls.Add(chartControl1);
        }

    }
}
