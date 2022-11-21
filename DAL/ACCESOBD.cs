using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class ACCESOBD
    {
        private SqlConnection conn;

        public void OpenConnection()
        {
            conn = new SqlConnection(@"Data Source=RYZEN-DESKTOP;Initial Catalog=BatallaNaval;Integrated Security=SSPI");
            conn.Open();
        }

        public void CloseConnection()
        {
            conn.Close();
            conn = null;
            GC.Collect();
        }

        private SqlCommand CreateCommand(string sp, List<SqlParameter> parameters = null)
        {
            SqlCommand cmd = new SqlCommand(sp, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (parameters != null)
            {
                cmd.Parameters.Add(parameters.ToArray());
            }
            return cmd;
        }

        public DataTable ReadDB(string sp, List<SqlParameter> parameters = null)
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter())
            {
                da.SelectCommand = CreateCommand(sp, parameters);
                da.Fill(dt);
                da.Dispose();
            }
            return dt;
        }

        public int WriteDB(string sp, List<SqlParameter> parameters = null)
        {
            int result;
            SqlCommand cmd = CreateCommand(sp, parameters);
            try
            {
                result = cmd.ExecuteNonQuery();
            }
            catch
            {
                result = -1;
            }

            return result;
        }

        public SqlParameter CreateParameter(string name, string value)
        {
            SqlParameter p = new SqlParameter(name, value);
            p.DbType = DbType.String;
            return p;
        }

        public SqlParameter CreateParameter(string name, int value)
        {
            SqlParameter p = new SqlParameter(name, value);
            p.DbType = DbType.Int32;
            return p;
        }
        public SqlParameter CreateParameter(string name, float value)
        {
            SqlParameter p = new SqlParameter(name, value);
            p.DbType = DbType.Single;
            return p;
        }
    }
}
