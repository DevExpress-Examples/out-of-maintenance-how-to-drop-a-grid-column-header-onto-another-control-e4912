using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.Linq;

namespace dxQ529392 {
    public class ListBoxControlHelper : BaseDropGridColumnHeaderSupportHelper<ListBoxControl> {
        public override void DropObjectCore(string columnFieldName, System.Drawing.Point location, ListBoxControl control) {
            control.Items.Add(columnFieldName);
        }
    }
}
