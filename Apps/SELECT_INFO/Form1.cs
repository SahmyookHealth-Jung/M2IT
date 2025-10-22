using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SELECT_INFO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // 데이터베이스 연결 문자열 정의
            string connect =
                "Server = localhost; Port = 3306; Database = db_practice; Uid=downer; Pwd=dkdlxl123!;";

            // 유효성 검사
            if (string.IsNullOrWhiteSpace(txtEmpolyeeId.Text))
            {
                lblStatus.Text = "아이디에 공백이 있으면 안 됩니다.";
                return;
            }
            else if (txtEmpolyeeId.TextLength > 50)
            {
                lblStatus.Text = "아이디를 50자 이하로 입력해주세요";
                return;
            }

            // SQL 쿼리 준비 
            // WHERE: 조회 조건 지정 (userID = @id) -> @id는 매개변수
            string sql = $"SELECT userName, userDepartment FROM info WHERE userID = @id";

            // MySQL 연결 객체 생성 
            MySqlConnection connection = new MySqlConnection(connect);

            try
            {
                // DB 연결 
                connection.Open();
                // MySQL 명령어 객체 생성 (쿼리문과 객체를 인수로 받음)
                MySqlCommand com = new MySqlCommand(sql, connection);
                com.Parameters.AddWithValue("@id", txtEmpolyeeId.Text);

                // 쿼리 실행 및 데이터 리더 객체 생성 (데이터를 한 줄씩 읽어오기 위함)
                MySqlDataReader reader = com.ExecuteReader();

                // 데이터 읽기(결과 행이 하나라도 존재하는지 확인)
                if (reader.Read())
                {
                    lblName.Text = "이름: " + reader["userName"].ToString();
                    lblDepartment.Text = "부서명: " + reader["userDepartment"].ToString();
                    lblStatus.Text = $"ID {txtEmpolyeeId} 직원 정보 조회 성공.";
                    lblStatus.ForeColor = Color.Green;
                }
                else
                {
                    lblName.Text = "이름 : -";
                    lblDepartment.Text = "부서: -";
                    lblStatus.Text = "정보를 찾을 수 없습니다.";
                    lblStatus.ForeColor = Color.Red;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                lblStatus.Text = "DB 오류 발생 " + ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
            finally 
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
