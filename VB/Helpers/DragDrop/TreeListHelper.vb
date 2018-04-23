Imports Microsoft.VisualBasic
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraTreeList
Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace dxQ529392
	Public Class TreeListHelper
		Inherits BaseDropGridColumnHeaderSupportHelper(Of TreeList)
		Public Overrides Sub DropObjectCore(ByVal columnFieldName As String, ByVal location As System.Drawing.Point, ByVal control As TreeList)
			control.Columns.AddField(columnFieldName).Visible = True
		End Sub
	End Class
End Namespace
