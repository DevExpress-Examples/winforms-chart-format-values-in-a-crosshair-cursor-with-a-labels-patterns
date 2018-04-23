Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace FormatCrosshairLabels
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            AddHandler Load, AddressOf Form1_Load
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' Create an empty chart.
            Dim chartControl1 As New ChartControl()

            ' Create a first line series and add points to it.
            Dim series1 As New Series("Europe", ViewType.Line)
            series1.Points.Add(New SeriesPoint(1950, 546))
            series1.Points.Add(New SeriesPoint(1960, 605))
            series1.Points.Add(New SeriesPoint(1970, 656))
            series1.Points.Add(New SeriesPoint(1980, 694))
            series1.Points.Add(New SeriesPoint(1990, 721))
            series1.Points.Add(New SeriesPoint(2000, 730))
            series1.Points.Add(New SeriesPoint(2010, 728))

            ' Create a second line series and add points to it.
            Dim series2 As New Series("Americas", ViewType.Line)
            series2.Points.Add(New SeriesPoint(1950, 332))
            series2.Points.Add(New SeriesPoint(1960, 417))
            series2.Points.Add(New SeriesPoint(1970, 513))
            series2.Points.Add(New SeriesPoint(1980, 614))
            series2.Points.Add(New SeriesPoint(1990, 721))
            series2.Points.Add(New SeriesPoint(2000, 836))
            series2.Points.Add(New SeriesPoint(2010, 935))

            ' Add the series to the chart.
            chartControl1.Series.Add(series1)
            chartControl1.Series.Add(series2)

            ' Hide the legend (if necessary).
            chartControl1.Legend.Visible = False

            'Show crosshair axis lines and crosshair axis labels to see format values of crosshair labels 
            chartControl1.CrosshairOptions.ShowArgumentLabels = True
            chartControl1.CrosshairOptions.ShowValueLabels = True
            chartControl1.CrosshairOptions.ShowValueLine = True
            chartControl1.CrosshairOptions.ShowArgumentLine = True

            ' Specify the crosshair label pattern for both series.
            series1.CrosshairLabelPattern = "{S} population: {V}"
            series2.CrosshairLabelPattern = "{S} population: {V}"

            ' Specify the crosshair group header pattern.
            chartControl1.CrosshairOptions.GroupHeaderPattern = "Year: {A}"

            ' Cast the chart's diagram to the XYDiagram type, to access its axes.
            Dim diagram As XYDiagram = CType(chartControl1.Diagram, XYDiagram)

            ' Specify the crosshair axis labels pattern for X-axis.
            diagram.AxisX.CrosshairAxisLabelOptions.Pattern = "Year: {A:F0}"

            ' Add the chart to the form.
            chartControl1.Dock = DockStyle.Fill
            Me.Controls.Add(chartControl1)
        End Sub

    End Class
End Namespace
