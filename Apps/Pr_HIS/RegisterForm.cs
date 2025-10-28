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

namespace Pr_HIS
{
    
    // 등록 
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // name, checkupDate, status 변수명으로 텍스트 입력값을 할당
            string name = txtNewName.Text.Trim();
            DateTime checkupDate = dtpCheckupDate.Value;
            string status = txtStatus.Text.Trim();

            // 이름과 상태 텍스트는 비어있으면 안 된다는 유효성 검사 실행
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(status))
            {
                MessageBox.Show("환자 이름과 상태는 필수 입력 항목입니다. ");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(DBHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "INSERT INTO patients (name, checkup_date, status) VALUES (@name, @date, @status) ";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        // 위에 만든 변수를 @name으로 매칭하는 파라미터 메소드 / SQL 인젝션 방지 
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@date", checkupDate);
                        cmd.Parameters.AddWithValue("@status", status);

                        // 쿼리 실행 : ExecuteNonQuery()를 사용하여 INSERT 문 실행
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // rowsAffected가 0보다 크면 DB에 성공적으로 데이터가 삽입된 것이다.
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("환자 등록이 성공적으로 완료되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNewName.Clear();
                            txtStatus.Clear();
                            dtpCheckupDate.Value = DateTime.Now;
                        }
                        else
                        {
                            MessageBox.Show("등록 실패: 데이터베이스에 변경 사항이 없습니다.", "실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("데이터베이스 등록 중 오류 발생: " + ex.Message, "DB 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
