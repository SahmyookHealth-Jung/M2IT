using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_HIS
{
    public static class PatientService
    {
        public static List<Patient> GetAllPatients() // static 클래스로 만들어 객체 생성 없이 바로 사용
        {
               
            List<Patient> patients = new List<Patient>(); 

            using (MySqlConnection conn = new MySqlConnection(DBHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT id, name, checkup_date, status FROM patients ORDER BY id DESC";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            patients.Add(new Patient
                            {
                                Id = reader.GetInt32("id"),
                                Name = reader.GetString("name"),
                                CheckupDate = reader.GetDateTime("checkup_date"),
                                Status = reader.GetString("status")
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("MySQL 데이터 로드 중 오류 발생");
                }
            }
            return patients;
        }
    }
    
}
