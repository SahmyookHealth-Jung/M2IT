using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using MySql.Data.MySqlClient;


namespace Exam_MySQL
{
    public class DBHelper
    {
        public static readonly string ConnectionString =
                ConfigurationManager.ConnectionStrings["HisDatabase"].ConnectionString;

        /// <summary>
        /// SELECT 쿼리 실행을 전담하는 메서드 (데이터 읽을 때 사용)
        /// </summary>
        public MySqlDataReader ExecuteReader(string sql, MySqlParameter[] parameters = null)
        {
            MySqlConnection conn = new MySqlConnection(ConnectionString);
            
                try
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        if (parameters != null)
                        {
                            foreach (MySqlParameter p in parameters)
                            {
                                cmd.Parameters.Add(p);
                            }
                        }
                        // DataReader 가 닫힐 때 DB 연결도 자동으로 닫히도록 지시 
                        return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                    }
                }

                catch (Exception ex)
                {
                    // 예외 발생 시 DataReader가 Connection을 닫지 못할 수 있으므로, 수동으로 닫아준다.
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        conn.Close();
                    }
                    throw new Exception("DB Reader 실행 오류", ex);
                }
            }
        
        // INSERT, UPDATE, DELETE 쿼리 실행을 전담하는 메서드
        public int ExecuteNonQuery(string sql, MySqlParameter[] parameters = null)
        {
            // using 구문 : 이 블록을 벗어나는 순간 Connection이 자동으로 닫힌다. (데이터를 즉시 처리하고 연결을 바로 끊을 때 적합)
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        if (parameters != null)
                        {
                            foreach (MySqlParameter p in parameters)
                            {
                                cmd.Parameters.Add(p);
                            }
                        }
                        return cmd.ExecuteNonQuery(); // 쿼리 실행 및 영향 받은 행 수 반환
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
