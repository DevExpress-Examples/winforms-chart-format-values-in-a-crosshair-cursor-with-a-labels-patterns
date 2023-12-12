<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128574728/16.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4490)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Chart for WinForms - How to Format Values in a Crosshair Cursor with Label Patterns

This example demonstrates how to change a text displayed in crosshair labels with crosshair patterns. 

Specify a displayed pattern within a crosshair label with the following properties:

* [CrosshairAxisLabelOptions.Pattern](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.CrosshairAxisLabelOptions.Pattern)
* [SeriesBase.CrosshairLabelPattern](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.SeriesBase.CrosshairLabelPattern)
* [CrosshairOptions.GroupHeaderPattern](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.CrosshairOptions.GroupHeaderPattern)

You can use standard and custom format specifiers are used together with the placeholders to format numeric and date/time values (e.g., "<strong>{A:F0}</strong>").
 
## Files to Review

* [Form1.cs](./CS/FormatCrosshairLabels/Form1.cs) (VB: [Form1.vb](./VB/FormatCrosshairLabels/Form1.vb))

## Documentation

* [Crosshair Cursor](https://docs.devexpress.com/WindowsForms/14710/controls-and-libraries/chart-control/end-user-features/tooltip-and-crosshair-cursor/crosshair-cursor)
* [Format Specifiers](https://docs.devexpress.com/WindowsForms/2141/common-features/formatting-values/format-specifiers)


