using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Examiniation
{

    public partial class Form1 : Form
    {
        private List<Patient> allPatients;

        private string conns =
            "Server = localhost; Port = 3306; Database = db_practice; Uid = downer; Pwd = dkdlxl123!;";

        public Form1()
        {
            InitializeComponent();
            dgvPatients.AutoGenerateColumns = false;

            allPatients = LoadPatientFromDatabase();
            dgvPatients.DataSource = allPatients;
            dgvPatients.DataSource = null;
        }
        
        public List<Patient> LoadPatientFromDatabase()
        {
            List<Patient> patients = new List<Patient>();
            // MySQL에서 모든 환자 정보를 조회하는 쿼리
            string sql = "SELECT Name, ChartNumber, CheckupDate, CheckupStatus FROM PatientTable";

            // using 문을 사용하여 안전하게 연결 자원 관리
            using (MySqlConnection conn = new MySqlConnection(conns))
            {
                try
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // reader가 읽을 데이터가 남아있는 동안 반복
                        while (reader.Read())
                        {
                            // DB에서 읽은 데이터를 Patient 객체에 매핑
                            Patient p = new Patient
                            {
                                // 컬럼 이름을 사용하여 데이터를 읽어옵니다.
                                Name = reader.GetString("Name"),
                                ChartNumber = reader.GetString("ChartNumber"),
                                // DB의 DATE 타입은 DateTime으로 읽고, 필요에 따라 문자열로 변환
                                CheckupDate = reader.GetDateTime("CheckupDate").ToString("yyyy-MM-dd"),
                                CheckupStatus = reader.GetString("CheckupStatus")
                            };
                            patients.Add(p);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DB 로드 오류: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // 오류 발생 시 빈 리스트 반환
                    return new List<Patient>();
                }
            }
            return patients;
        }

        public void FilterPatients(object sender, EventArgs e)
        {
            string searchTerm = txtSearchName.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
                //dgvPatients.DataSource = allPatients;
                dgvPatients.DataSource = null;
                return;
            }
            
            var filteredList = allPatients
        .Where(patient => patient.Name.Contains(searchTerm) ||
                          patient.ChartNumber.Contains(searchTerm) ||
            patient.CheckupStatus.Contains(searchTerm))        // 이름 또는 차트 번호에 검색어가 포함되는지 검사
        .ToList(); // 필터링된 결과를 List로 변환

            // 4. DataGridView 업데이트
            dgvPatients.DataSource = filteredList;
        }
    }
      public class Patient
        {
        public string Name { get; set; }
        public string ChartNumber { get; set; }
        public string CheckupDate { get; set; }
        public string CheckupStatus { get; set; }
    }   
}
