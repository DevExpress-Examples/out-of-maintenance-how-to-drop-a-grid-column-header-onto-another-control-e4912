using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace dxQ529392 {
    public class DataHelper {
        public static object GetDataSource() {
            var table = new DataTable();
            table.Columns.Add(new DataColumn("ID"));
            table.Columns.Add(new DataColumn("Name"));
            table.Columns.Add(new DataColumn("SecondName"));
            table.Columns.Add(new DataColumn("Adress"));
            table.Columns.Add(new DataColumn("PhoneNum"));
            table.Columns.Add(new DataColumn("Personal information"));
            return table;
        }
    }
}
