using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDbCrud
{
    internal class DataAPI
    {
        private readonly string connectionString;
        private SqlSubroutines sqlSubroutines;

        internal DataAPI(string connectionString) 
        { 
            this.connectionString = connectionString;
            sqlSubroutines = new SqlSubroutines();
        }

        internal List<DbEntityRow> CommitSubroutine(DbEntryCartridge cartridge)
        {
            List<SqlParameter> sqlParameters = new List<SqlParameter>();

            foreach (DbEntityFieldData fieldData in cartridge.DbEntityFieldsData)
            {
                SqlDbType dbType = Utils.ConvertToSqlDbType(fieldData.FieldType);
                string parameterName = Utils.ParameterNameFix(fieldData.FieldName); 
                SqlParameter sqlParameter = Utils.SqlParameterWithValue(parameterName, dbType, fieldData.FieldValue);
                sqlParameters.Add(sqlParameter);
            }            

            DataTable dataTable = sqlSubroutines.SelectDataTable(cartridge.DbSubroutine, sqlParameters, connectionString);

            return Utils.DataTableConvert(dataTable);
        }
    }
}
