using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Betfair_Football_Markets
{
    static class ExtensionMethods
    {
        public static DataTable ToDataTable(this IEnumerable<dynamic> items)
        {
            var data = items.ToArray();
            if (data.Count() == 0) return null;

            var dt = new DataTable();
            foreach (var key in ((IDictionary<string, object>)data[0]).Keys)
                if (!key.StartsWith("_"))
                    dt.Columns.Add(key);
            foreach (var d in data)
            {
                var row = ((IDictionary<string, object>)d).Values.Take(dt.Columns.Count).ToArray();
                dt.Rows.Add(row);
            }
            return dt;
        }
    }
}
