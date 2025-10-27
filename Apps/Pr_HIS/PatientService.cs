using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_HIS
{
    /// <summary>
    /// 데이터베이스와 직접 통신하며 데이터를 조회(SELECT), 등록(INSERT), 수정(UPDATE), 삭제(DELETE)하는
    /// 모든 로직을 캡슐화한 정적(static) 클래스입니다. 
    /// </summary>
    public static class PatientService
    {     
        // DB의 모든 환자 리스트를 조회하고 객체 리스트로 반환한다.
        public static List<Patient> GetAllPatients() // static 클래스로 만들어 객체 생성 없이 바로 사용
        {
              
            List<Patient> patients = new List<Patient>(); // DB에서 가져온 Patient 객체들을 담을 '그릇'을 생성

            // MySql 연결문 (DBHelper 클래스에 sql 정보를 따로 두어 보안성을 강화한다.)
            using (MySqlConnection conn = new MySqlConnection(DBHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT id, name, checkup_date, status FROM patients ORDER BY id DESC";

                    // SQL 명령어를 DB에 전달할 객체를 생성한다.
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))

                    // MySqlDataReader : SELECT 쿼리 실행 후 결과를 Row(행) 단위로 순차적으로 읽을 수 있는 스트림 객체
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read()) // DB에서 읽을 다음 행이 있는 동안 반복 
                        {
                            // DB의 행 데이터를 Patient 객체로 매핑하여 리스트에 추가한다.
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
            // 최종적으로 DB에서 조회한 환자 데이터(Patient 객체들)가 담긴 List<Patient> 전체를 호출한 폼으로 반환한다.
            return patients;
        }
    }
}
