Imports Microsoft.VisualBasic
Imports DevExpress.XtraGrid.Columns
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms

Namespace dxQ529392
	Public MustInherit Class BaseDropGridColumnHeaderSupportHelper(Of T As Control)
		Implements IDropGridColumnHeaderSupport
		Public Function SupportsControlCore(ByVal control As Control) As Boolean
			Return TypeOf control Is T
		End Function
		Public MustOverride Sub DropObjectCore(ByVal columnFieldName As String, ByVal location As Point, ByVal control As T)

		Private Sub ProcessDropObject(ByVal columnFieldName As String, ByVal location As Point, ByVal control As Control) Implements IDropGridColumnHeaderSupport.ProcessDropObject
			DropObjectCore(columnFieldName, location, CType(control, T))
		End Sub
		Private Function SupportsControl(ByVal control As Control) As Boolean Implements IDropGridColumnHeaderSupport.SupportsControl
			Return SupportsControlCore(control)
		End Function
	End Class
End Namespace
