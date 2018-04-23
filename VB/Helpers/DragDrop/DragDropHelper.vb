Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms

Namespace dxQ529392
	Public Class DragDropHelper
		Public Shared controlHelpers As New List(Of IDropGridColumnHeaderSupport)()

		Public Shared Sub ProcessDropObject(ByVal ctrlList As List(Of Control))
			AddControlsHelpers()
			For Each control As Control In ctrlList
				SubscribeControlEvents(control)
			Next control
		End Sub
		Private Shared Sub SubscribeControlEvents(ByVal control As Control)
			RemoveHandler control.DragEnter, AddressOf Control_DropEnter
			AddHandler control.DragEnter, AddressOf Control_DropEnter
			RemoveHandler control.DragDrop, AddressOf Control_DragDrop
			AddHandler control.DragDrop, AddressOf Control_DragDrop
		End Sub
		Private Shared Sub AddControlsHelpers()
			controlHelpers.Add(New ChartControlHelper())
			controlHelpers.Add(New ListBoxControlHelper())
			controlHelpers.Add(New PivotGridControlHelper())
			controlHelpers.Add(New TreeListHelper())
		End Sub
		Private Shared Sub Control_DropEnter(ByVal sender As Object, ByVal e As DragEventArgs)
			SetDragDropEffects(e)
		End Sub
		Private Shared Sub SetDragDropEffects(ByVal e As DragEventArgs)
			e.Effect = DragDropEffects.Move
		End Sub
		Private Shared Sub Control_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs)
			Dim control = TryCast(sender, Control)
			Dim location = Control.MousePosition
			For Each helper In controlHelpers
				If helper.SupportsControl(control) Then
					Dim columnFieldName = e.Data.GetData(GetType(String)).ToString()
					If columnFieldName Is Nothing Then
						Return
					End If
					helper.ProcessDropObject(columnFieldName, location, control)
				End If
			Next helper
		End Sub
	End Class
End Namespace
