Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace dxQ529392
	Public Class ListBoxControlHelper
		Inherits BaseDropGridColumnHeaderSupportHelper(Of ListBoxControl)
		Public Overrides Sub DropObjectCore(ByVal columnFieldName As String, ByVal location As System.Drawing.Point, ByVal control As ListBoxControl)
			control.Items.Add(columnFieldName)
		End Sub
	End Class
End Namespace
