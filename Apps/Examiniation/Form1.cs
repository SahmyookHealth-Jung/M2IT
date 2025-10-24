using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // MySQL 연동을 위한 필수

namespace Examiniation
{

    public partial class Form1 : Form
    {
        // 전역 변수 - 모든 메서드가 접근할 수 있는 '원본 데이터 저장소'
        private List<Patient> allPatients;

        // DB 연결 문자열
        private string conns =
            "Server = localhost; Port = 3306; Database = db_practice; Uid = downer; Pwd = dkdlxl123!;";

        public Form1()
        {
            InitializeComponent();
            // DataGridView 설정 : 컬럼을 자동으로 생성하지 않도록 막아, 수동 설정한 헤더(한글) 유지
            dgvPatients.AutoGenerateColumns = false;

            // [프로그램 초기화 흐름]

            // DB에서 전체 데이터를 메모리(allPatients)로 로드합니다.
            allPatients = LoadPatientFromDatabase();

            // DataGridView에 컬럼 틀을 생성하기 위해 데이터를 잠시 연결합니다.
            dgvPatients.DataSource = allPatients;

            // 사용자가 검색하기 전에는 내용이 보이지 않도록 null로 바꿉니다. 
            dgvPatients.DataSource = null;
        }

        /// <summary>
        /// 데이터 조회 : DB의 모든 데이터를 List<Patient>로 가져오는 역할
        /// LoadPatientFromDatabase() 함수는 List<patient> 타입의 데이터를 돌려준다.
        /// </summary>
        public List<Patient> LoadPatientFromDatabase()
        {
            // DB에서 읽은 데이터를 담을 임시 리스트
            List<Patient> patients = new List<Patient>();
            // MySQL에서 모든 환자 정보를 조회하는 쿼리
            string sql = "SELECT Name, ChartNumber, CheckupDate, CheckupStatus FROM PatientTable";

            // using 문을 사용하여 안전하게 연결 자원 관리
            using (MySqlConnection conn = new MySqlConnection(conns)) // 연결
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
        /// <summary>
        /// 데이터 필터링 : TextBox 입력에 따라 DataGridView 내용을 갱신 
        /// </summary>
        public void FilterPatients(object sender, EventArgs e)
        {
            string searchTerm = txtSearchName.Text.Trim(); // 검색어 준비 

            if (string.IsNullOrEmpty(searchTerm))
            {
                //dgvPatients.DataSource = allPatients;
                dgvPatients.DataSource = null;
                return;
            }

            // LinQ를 사용한 메모리 필터링 
            var filteredList = allPatients
        .Where(patient => patient.Name.Contains(searchTerm) ||
                          patient.ChartNumber.Contains(searchTerm) ||
            patient.CheckupStatus.Contains(searchTerm))        // 이름 또는 차트 번호에 검색어가 포함되는지 검사
        .ToList(); // 필터링된 결과를 List로 변환

            // 4. DataGridView 업데이트
            dgvPatients.DataSource = filteredList;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string chartNumber = txtNewChartNo.Text.Trim();
            string newName = txtNewName.Text.Trim();
            string checkupDate = dtpCheckupDate.Value.ToString("yyyy-MM-dd");
            string status = cmbStatus.SelectedItem.ToString();

            string sql = "INSERT INTO PatientTable  (ChartNumber, Name, CheckupDate, CheckupStatus)" +
                "VALUES (@ChartNumber, @newName, @checkupDate, @status)";

            if (string.IsNullOrEmpty(chartNumber) || string.IsNullOrEmpty(newName))
            {
                MessageBox.Show("빈 칸을 채워주세요.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(conns))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        // 매개변수 바인딩 : SQL Injection 방지 및 안전한 데이터 전송
                        cmd.Parameters.AddWithValue("@ChartNumber", chartNumber);
                        cmd.Parameters.AddWithValue("@newName", newName);
                        cmd.Parameters.AddWithValue("checkupDate", checkupDate);
                        cmd.Parameters.AddWithValue("status", status);

                        // 쿼리 실행 (ExecuteNonQuery): INSERT, UPDATE, DELETE 문 실행 시 사용
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("✅ 환자 정보가 성공적으로 등록되었습니다.", "등록 완료");

                            allPatients = LoadPatientFromDatabase();
                            FilterPatients(null, null);
                        }
                        else
                        {
                            MessageBox.Show("환자 정보 등록에 실패했습니다. (차트 번호 중복 등 확인 필요)", "등록 실패");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"DB 오류: {ex.Message}", "시스템 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count == 0 || cmbStatusUpdate.SelectedItem == null)
            {
                MessageBox.Show("수정할 행과 상태를 선택해주세요!");
                return;
            }

            DataGridViewRow selectedRow = dgvPatients.SelectedRows[0];

            string chartNoToUpdate = selectedRow.Cells["ChartNumber"].Value.ToString();
            string newStatus = cmbStatusUpdate.SelectedItem.ToString();

            string sql = "UPDATE PatientTable SET CheckupStatus = @newStatus WHERE ChartNumber = @ChartNumber";
            using (MySqlConnection conn = new MySqlConnection(conns))
            {
                try
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@NewStatus", newStatus);
                        cmd.Parameters.AddWithValue("@ChartNumber", chartNoToUpdate);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"✅ 차트 번호 {chartNoToUpdate}의 상태가 '{newStatus}'로 수정되었습니다.", "수정 완료");

                            allPatients = LoadPatientFromDatabase();
                            dgvPatients.DataSource = allPatients;
                            dgvPatients.DataSource = null;
                        }
                        else
                        {
                            MessageBox.Show("쿼리가 실행되지 않았습니다.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DB 오류 발생");
                }
            }
        }
        /// <summary>
        /// C# 객체와 DB 행(Row)을 1:1로 매핑하는 구조
        /// </summary>
        public class Patient
        {
            public string Name { get; set; }
            public string ChartNumber { get; set; }
            public string CheckupDate { get; set; }
            public string CheckupStatus { get; set; }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count == 0)
            {
                MessageBox.Show("삭제하실 차트를 선택해주세요");
                return;
            }

            DataGridViewRow selectedRow = dgvPatients.SelectedRows[0];

            string chartToDelete = selectedRow.Cells["ChartNumber"].Value.ToString();
            string sql = "DELETE FROM PatientTable WHERE ChartNumber = @ChartNumber";

            DialogResult confirm = MessageBox.Show(
                $"{chartToDelete} 차트 번호의 환자 정보를 정말로 삭제하시겠습니까?", "삭제확인",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.No)
            {
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(conns))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@ChartNumber", chartToDelete);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"{chartToDelete}의 정보가 성공적으로 삭제되었습니다.");
                        }

                        allPatients = LoadPatientFromDatabase();
                        FilterPatients(null, null); // FilterPatients 메서드를 수동으로 호출하여 현재 텍스트 실시간 반영
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"DB 오류 발생 : {ex.Message}", "시스템 오류");
                }
             }
         }
     }
}
