using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace dxQ529392 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            InitGridControl();
            ProcessDropObject();
        }
        private void InitGridControl() {
            gridControl1.DataSource = DataHelper.GetDataSource();
        }
        private void ProcessDropObject() {
            var ctrlList = new List<Control>();
            ctrlList.AddRange(new Control[] { treeList1, listBoxControl1, chartControl1, pivotGridControl1 });
            DragDropHelper.ProcessDropObject(ctrlList);
        }
        private void gridView1_DragObjectDrop(object sender, DevExpress.XtraGrid.Views.Base.DragObjectDropEventArgs e) {
            var column = e.DragObject as GridColumn;
            if (column == null) {
                return;
            }
            var gridView = sender as GridView;
            var hi = gridView.CalcHitInfo(gridView.GridControl.PointToClient(Cursor.Position));
            if (hi.HitTest != GridHitTest.None && hi.HitTest != GridHitTest.Column) {
                column.Visible = false;
                return;
            }
            BeginInvoke(new MethodInvoker(() => {
                DoDragDrop(column.FieldName.ToString(), DragDropEffects.All);
            }));
        }
        private void gridView1_DragObjectOver(object sender, DevExpress.XtraGrid.Views.Base.DragObjectOverEventArgs e) {
            var view = sender as GridView;
            var gridControl = view.GridControl;
            var hitInfo = view.CalcHitInfo(gridControl.PointToClient(MousePosition));
            if (hitInfo.HitTest == GridHitTest.Column) {
                return;
            }
            e.DropInfo.Valid = false;
        }
    }
}
