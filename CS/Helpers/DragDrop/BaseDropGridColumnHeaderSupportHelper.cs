using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace dxQ529392 {
    public abstract class BaseDropGridColumnHeaderSupportHelper<T> : IDropGridColumnHeaderSupport
        where T: Control {
        public bool SupportsControlCore(Control control) {
            return control is T;
        }
        public abstract void DropObjectCore(string columnFieldName, Point location, T control);

        void IDropGridColumnHeaderSupport.ProcessDropObject(string columnFieldName, Point location, Control control) {
            DropObjectCore(columnFieldName, location, (T)control);
        }
        bool IDropGridColumnHeaderSupport.SupportsControl(Control control) {
            return SupportsControlCore(control);
        }
    }
}
