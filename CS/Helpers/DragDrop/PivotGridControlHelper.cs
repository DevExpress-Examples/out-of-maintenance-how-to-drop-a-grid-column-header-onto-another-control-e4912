using DevExpress.XtraGrid.Columns;
using DevExpress.XtraPivotGrid;
using System;
using System.Collections.Generic;
using System.Linq;

namespace dxQ529392 {
    public class PivotGridControlHelper : BaseDropGridColumnHeaderSupportHelper<PivotGridControl> {
        public override void DropObjectCore(string columnFieldName, System.Drawing.Point location, PivotGridControl control) {
            var hitInfo = control.CalcHitInfo(control.PointToClient(location));
            if (hitInfo.HeadersAreaInfo == null) {
                return;
            }
            control.Fields.Add(columnFieldName, hitInfo.HeadersAreaInfo.Area);
        }
    }
}
