Imports Microsoft.VisualBasic
Imports DevExpress.XtraCharts
Imports DevExpress.XtraGrid.Columns
Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace dxQ529392
	Public Class ChartControlHelper
		Inherits BaseDropGridColumnHeaderSupportHelper(Of ChartControl)
		Public Overrides Sub DropObjectCore(ByVal columnFieldName As String, ByVal location As System.Drawing.Point, ByVal control As ChartControl)
			Dim series = New Series() With {.Name = columnFieldName}
			control.Series.Add(series)
		End Sub
	End Class
End Namespace
