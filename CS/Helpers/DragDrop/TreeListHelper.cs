using DevExpress.XtraGrid.Columns;
using DevExpress.XtraTreeList;
using System;
using System.Collections.Generic;
using System.Linq;

namespace dxQ529392 {
    public class TreeListHelper : BaseDropGridColumnHeaderSupportHelper<TreeList> {
        public override void DropObjectCore(string columnFieldName, System.Drawing.Point location, TreeList control) {
            control.Columns.AddField(columnFieldName).Visible = true;
        }
    }
}
