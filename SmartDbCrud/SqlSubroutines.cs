using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDbCrud
{
    internal class SqlSubroutines
    {
        internal SqlSubroutines() { }

        internal DataTable SelectDataTable(string storedProcedureName, List<SqlParameter> lstSqlParams, string connectionString)
        {
            DataTable dt = new DataTable();
            SqlParameter[] sqlParams = lstSqlParams.ToArray<SqlParameter>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(storedProcedureName, conn))
                {
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddRange(sqlParams);

                        conn.Open();
                        da.Fill(dt);
                        conn.Close();
                    }
                }
            }

            return dt;
        }
    }
}
