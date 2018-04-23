using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace dxQ529392 {
    public interface IDropGridColumnHeaderSupport {
        void ProcessDropObject(string columnFieldName, Point location, Control control);
        bool SupportsControl(Control control);
    }
}
