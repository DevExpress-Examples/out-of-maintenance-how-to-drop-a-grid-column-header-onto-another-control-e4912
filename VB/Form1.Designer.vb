Imports Microsoft.VisualBasic
Imports System
Namespace dxQ529392
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim sideBySideBarSeriesLabel2 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.listBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.AllowDrop = True
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(441, 282)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
'			Me.gridView1.DragObjectDrop += New DevExpress.XtraGrid.Views.Base.DragObjectDropEventHandler(Me.gridView1_DragObjectDrop);
'			Me.gridView1.DragObjectOver += New DevExpress.XtraGrid.Views.Base.DragObjectOverEventHandler(Me.gridView1_DragObjectOver);
			' 
			' treeList1
			' 
			Me.treeList1.AllowDrop = True
			Me.treeList1.Location = New System.Drawing.Point(57, 364)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.Size = New System.Drawing.Size(400, 200)
			Me.treeList1.TabIndex = 1
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "webmail.png")
			' 
			' listBoxControl1
			' 
			Me.listBoxControl1.AllowDrop = True
			Me.listBoxControl1.Location = New System.Drawing.Point(495, 26)
			Me.listBoxControl1.Name = "listBoxControl1"
			Me.listBoxControl1.Size = New System.Drawing.Size(243, 256)
			Me.listBoxControl1.TabIndex = 3
			' 
			' chartControl1
			' 
			Me.chartControl1.AllowDrop = True
			Me.chartControl1.Location = New System.Drawing.Point(540, 364)
			Me.chartControl1.Name = "chartControl1"
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
			sideBySideBarSeriesLabel2.LineVisible = True
			Me.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel2
			Me.chartControl1.Size = New System.Drawing.Size(300, 200)
			Me.chartControl1.TabIndex = 4
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.AllowDrop = True
			Me.pivotGridControl1.Location = New System.Drawing.Point(887, 82)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.Size = New System.Drawing.Size(400, 200)
			Me.pivotGridControl1.TabIndex = 5
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1434, 659)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Controls.Add(Me.chartControl1)
			Me.Controls.Add(Me.listBoxControl1)
			Me.Controls.Add(Me.treeList1)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form11"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private treeList1 As DevExpress.XtraTreeList.TreeList
		Private imageList1 As System.Windows.Forms.ImageList
		Private listBoxControl1 As DevExpress.XtraEditors.ListBoxControl
		Private chartControl1 As DevExpress.XtraCharts.ChartControl
		Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
	End Class
End Namespace

