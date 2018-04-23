Imports Microsoft.VisualBasic
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms

Namespace dxQ529392
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			InitGridControl()
			ProcessDropObject()
		End Sub
		Private Sub InitGridControl()
			gridControl1.DataSource = DataHelper.GetDataSource()
		End Sub
		Private Sub ProcessDropObject()
			Dim ctrlList = New List(Of Control)()
			ctrlList.AddRange(New Control() { treeList1, listBoxControl1, chartControl1, pivotGridControl1 })
			DragDropHelper.ProcessDropObject(ctrlList)
		End Sub
		Private Sub gridView1_DragObjectDrop(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.DragObjectDropEventArgs) Handles gridView1.DragObjectDrop
			Dim column = TryCast(e.DragObject, GridColumn)
			If column Is Nothing Then
				Return
			End If
			Dim gridView = TryCast(sender, GridView)
			Dim hi = gridView.CalcHitInfo(gridView.GridControl.PointToClient(Cursor.Position))
			If hi.HitTest <> GridHitTest.None AndAlso hi.HitTest <> GridHitTest.Column Then
				column.Visible = False
				Return
			End If
			BeginInvoke(New MethodInvoker(Function() AnonymousMethod1(column)))
		End Sub
		
        Private Function AnonymousMethod1(ByVal column As GridColumn) As Boolean
            DoDragDrop(column.FieldName.ToString(), DragDropEffects.All)
            Return True
        End Function
		Private Sub gridView1_DragObjectOver(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.DragObjectOverEventArgs) Handles gridView1.DragObjectOver
			Dim view = TryCast(sender, GridView)
			Dim gridControl = view.GridControl
			Dim hitInfo = view.CalcHitInfo(gridControl.PointToClient(MousePosition))
			If hitInfo.HitTest = GridHitTest.Column Then
				Return
			End If
			e.DropInfo.Valid = False
		End Sub
	End Class
End Namespace
