using DevExpress.XtraCharts;
using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.Linq;

namespace dxQ529392 {
    public class ChartControlHelper : BaseDropGridColumnHeaderSupportHelper<ChartControl> {
        public override void DropObjectCore(string columnFieldName, System.Drawing.Point location, ChartControl control) {
            var series = new Series() { Name = columnFieldName };
            control.Series.Add(series);
        }
    }
}
