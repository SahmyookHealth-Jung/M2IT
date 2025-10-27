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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtNewName.Text.Trim();
            DateTime checkupDate = dtpCheckupDate.Value;
            string status = txtStatus.Text.Trim();

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
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@date", checkupDate);
                        cmd.Parameters.AddWithValue("@status", status);

                        int rowsAffected = cmd.ExecuteNonQuery();
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
