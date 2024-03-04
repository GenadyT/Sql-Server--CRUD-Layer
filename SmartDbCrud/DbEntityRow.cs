using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;

namespace SmartDbCrud
{
    public class DbEntityRow
    {
        private DataRow dataRow;

        public DbEntityRow(DataRow dataRow)
        {
            this.dataRow = dataRow;
        }

        public object this[string fieldName]
        {
            get => dataRow.Table.Columns.Contains(fieldName) ? dataRow[fieldName] : null;
        }
    }
}
