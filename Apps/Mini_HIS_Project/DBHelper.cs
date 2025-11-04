using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Mini_HIS_Project
{
    public class DBHelper
    {
        // DB 접속 정보 
        private static readonly string ConnectionString = "Server = localhost; Port = 3306; Database = mini_his; Uid = downer; Pwd=dkdlxl123!;";
        
        // SELECT 쿼리 실행 및 MySqlDataReader 반환 메서드
        public MySqlDataReader ExecuteReader(string sql, MySqlParameter[] parameters = null)
        {
            MySqlConnection conn = new MySqlConnection(ConnectionString);
      
                try
                {
                    conn.Open();

                    // 명령 객체 생성
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        // 파라미터가 있다면 반복문을 통해 sqlCommand에 추가
                        if (parameters != null)
                        {
                            foreach (var p in parameters)
                            {
                                cmd.Parameters.Add(p);
                            }
                        }
                        // ExecuteReader 실행 및 Reader 반환
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
        

        // INSERT, UPDATE, DELETE 쿼리 실행 및 영향 받은 행의 수 반환 메서드
        // MySqlParameter 는 사용자 입력 데이터와 SQL 쿼리문을 분리하여, 데이터를 안전하게 보호
        // EX) string sql = "SELECT * FROM User WHERE USER_ID = @UserID";
        public int ExecuteNonQuery(string sql, MySqlParameter[] parameters = null) 
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    if (parameters != null) 
                    {
                        foreach (var p in parameters) 
                        {
                            cmd.Parameters.Add(p);
                        }
                    }
                    try
                    {
                        conn.Open();

                        int rowsAffected = cmd.ExecuteNonQuery(); // rowsAffected - 실제로 영향을 받은 행의 수 
                        return rowsAffected;
                    }
                    catch (Exception ex) 
                    {
                        throw new Exception("DB NonQuery 실행 오류");
                    }
                }
            }
        }     
    }
}
