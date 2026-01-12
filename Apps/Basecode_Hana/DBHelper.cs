using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.Odbc;

namespace Basecode_Hana
{
    public class DBHelper
    {
        private static string ConnectionString
        {
            get
            {
                string conn = ConfigurationManager.ConnectionStrings["HanaDB"].ConnectionString;
                return conn;
            }
        }

        public static DataTable GetDataTable(string query)
        {
            DataTable dt = new DataTable();

            using (OdbcConnection conn = new OdbcConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (OdbcDataAdapter da = new OdbcDataAdapter(query, conn))
                    {
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("DB 조회 에러 발생:" + ex.Message);
                }
            }
            return dt;
        }

        public static int ExecuteNonQuery(string query)
        {
            using (OdbcConnection conn = new OdbcConnection(ConnectionString)) 
            {
                conn.Open();
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
