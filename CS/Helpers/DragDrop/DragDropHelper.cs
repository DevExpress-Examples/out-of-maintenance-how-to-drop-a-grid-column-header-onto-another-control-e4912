using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace dxQ529392 {
    public class DragDropHelper {
        public static List<IDropGridColumnHeaderSupport> controlHelpers = new List<IDropGridColumnHeaderSupport>();

        public static void ProcessDropObject(List<Control> ctrlList) {
            AddControlsHelpers();
            foreach (Control control in ctrlList) {
                SubscribeControlEvents(control);
            }
        }
        private static void SubscribeControlEvents(Control control) {
            control.DragEnter -= new DragEventHandler(Control_DropEnter);
            control.DragEnter += new DragEventHandler(Control_DropEnter);
            control.DragDrop -= new DragEventHandler(Control_DragDrop);
            control.DragDrop += new DragEventHandler(Control_DragDrop);
        }
        private static void AddControlsHelpers() {
            controlHelpers.Add(new ChartControlHelper());
            controlHelpers.Add(new ListBoxControlHelper());
            controlHelpers.Add(new PivotGridControlHelper());
            controlHelpers.Add(new TreeListHelper());
        }
        private static void Control_DropEnter(object sender, DragEventArgs e) {
            SetDragDropEffects(e);
        }
        private static void SetDragDropEffects(DragEventArgs e) {
            e.Effect = DragDropEffects.Move;
        }
        private static void Control_DragDrop(object sender, DragEventArgs e) {
            var control = sender as Control;
            var location = Control.MousePosition;
            foreach (var helper in controlHelpers) {
                if (helper.SupportsControl(control)) {
                    var columnFieldName = e.Data.GetData(typeof(string)).ToString();
                    if (columnFieldName == null) {
                        return;
                    }
                    helper.ProcessDropObject(columnFieldName, location, control);
                }
            }
        }
    }
}
