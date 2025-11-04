using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;

namespace Exam_MySQL
{
    public class DBHelper
    {
        public static readonly string ConnectionString = "Server = localhost; Port = 3306; Database = his; Uid = downer; Pwd = dkdlxl123!;";

        public MySqlDataReader ExecuteReader(string sql, MySqlParameter[] parameters = null)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        if (parameters != null)
                        {
                            foreach (var p in parameters)
                            {
                                cmd.Parameters.Add(p);
                            }
                        }
                        return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                    }
                }
                catch (Exception ex)
                {
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        conn.Close();
                    }
                    throw;
                }
            }
        }

        public int ExecuteNonQuery(string sql, MySqlParameter[] parameters = null)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        if (parameters != null)
                        {
                            foreach (var p in parameters)
                            {
                                cmd.Parameters.Add(p);
                            }
                        }
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("DB NonQuery 실행 오류" , ex);
                }
            }           
         }
    }
}
