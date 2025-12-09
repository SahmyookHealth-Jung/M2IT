using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace Medi
{
    public class DBHelper
    {
        public static MySqlConnection GetConnection()
        {
            string connectString = ConfigurationManager.ConnectionStrings["MyHospitalDB"].ConnectionString;
            return new MySqlConnection(connectString);
        }

        // (테스트용)  
        public static bool TestConnection()
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("DB 연결 실패: " + ex.Message);
                return false;
            }
        }

        // 조회
        public static DataTable Select(string query)
        {
            DataTable dt = new DataTable();

            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                    adapter.Fill(dt);
                }
            }
            catch (Exception ex) 
            {
                System.Windows.Forms.MessageBox.Show("DB 에러 발생" + ex.Message);
            }
            return dt;
        }

        public static void ExecuteSql(string query)
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("SQL 실행 에러: " + ex.Message);
            }
        }
    }
}
