Imports Microsoft.VisualBasic
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraPivotGrid
Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace dxQ529392
	Public Class PivotGridControlHelper
		Inherits BaseDropGridColumnHeaderSupportHelper(Of PivotGridControl)
		Public Overrides Sub DropObjectCore(ByVal columnFieldName As String, ByVal location As System.Drawing.Point, ByVal control As PivotGridControl)
			Dim hitInfo = control.CalcHitInfo(control.PointToClient(location))
			If hitInfo.HeadersAreaInfo Is Nothing Then
				Return
			End If
			control.Fields.Add(columnFieldName, hitInfo.HeadersAreaInfo.Area)
		End Sub
	End Class
End Namespace
