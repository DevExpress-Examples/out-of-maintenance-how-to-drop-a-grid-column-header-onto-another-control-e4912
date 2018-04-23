Imports Microsoft.VisualBasic
Imports DevExpress.XtraGrid.Columns
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms

Namespace dxQ529392
	Public Interface IDropGridColumnHeaderSupport
		Sub ProcessDropObject(ByVal columnFieldName As String, ByVal location As Point, ByVal control As Control)
		Function SupportsControl(ByVal control As Control) As Boolean
	End Interface
End Namespace
