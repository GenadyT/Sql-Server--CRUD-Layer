using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace SmartDbCrud
{
    public class Utils
    {
        /*public static int FieldValueToInt32(object row, string fieldName)
        {
            return Convert.ToInt32(((DbEntityRow)row)[fieldName]);
        }*/

        public static string FieldValueToString(object row, string fieldName)
        {
            return ((DbEntityRow)row)[fieldName].ToString();
        }

        public static List<string> EntityRowsToStringList(List<DbEntityRow> dataRows, string valueField)
        {
            List<string> strings = new List<string>();

            foreach (var row in dataRows)
            {   
                string value = row[valueField].ToString();
                strings.Add(value);
            }

            return strings;
        }

        public static Dictionary<string, bool> EntityRowsToBoolDictionary(List<DbEntityRow> dataRows, string keyField, string valueField)
        {
            Dictionary<string, bool> keyValuePairs = new Dictionary<string, bool>();

            foreach (var row in dataRows)
            {
                string key = Convert.ToString(row[keyField]);
                bool value = Convert.ToBoolean(row[valueField]);
                keyValuePairs.Add(key, value);
            }

            return keyValuePairs;
        }

        /*public static List<int, string> EntityRowsToIntStringList(List<DbEntityRow> dataRows, int intValueField, string stringValueField)
        {
            List<string> strings = new List<string>();

            foreach (var row in dataRows)
            {
                string value = row[valueField].ToString();
                strings.Add(value);
            }

            return strings;
        }*/

        public static string ConvertIntArrayToString(int[] array)
        {
            return string.Join(",", array);
        }

        internal static List<DbEntityRow> DataTableConvert(DataTable dataTable)
        {
            List<DbEntityRow> entityRows = new List<DbEntityRow>();

            foreach (DataRow dataRow in dataTable.Rows)
            {
                entityRows.Add(DataRowConvert(dataRow));
            }

            return entityRows;
        }

        internal static DbEntityRow DataRowConvert(DataRow dataRow)
        {
            return new DbEntityRow(dataRow);
        }

        internal static SqlParameter SqlParameterWithValue(string parameterName, SqlDbType dbType, object value)
        {
            SqlParameter sqlParameter = new SqlParameter(parameterName, dbType);
            sqlParameter.Value = value;
            return sqlParameter;
        }

        internal static SqlDbType ConvertToSqlDbType(Type csharpType)
        {
            return SqlDbTypeConverter.ConvertToSqlDbType(csharpType);
        }

        internal static string ParameterNameFix(string objectFieldName)
        {
            return $"@{objectFieldName}";
        }
    }
}
