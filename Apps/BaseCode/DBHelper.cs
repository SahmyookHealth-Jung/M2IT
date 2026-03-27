using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BaseCodeApp
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

            using (OracleConnection conn = new OracleConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (OracleDataAdapter da = new OracleDataAdapter(query, conn))
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
            using (OracleConnection conn = new OracleConnection(ConnectionString))
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
