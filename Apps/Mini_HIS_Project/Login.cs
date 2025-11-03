using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_HIS_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string userId = txtID.Text.Trim();
            string userPwd = txtPWD.Text;

            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(userPwd))
            {
                MessageBox.Show("아이디와 비밀번호는 필수 입력값입니다.");
                return;
            }

            // DBHelper에 ExecuteReader에 전달할 데이터 
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@ID", userId),
                new MySqlParameter("@PWD", userPwd)
            };

            MySqlDataReader reader = null;
            try
            {
                string sql = "SELECT AUTH_CODE, USER_NAME FROM User WHERE USER_ID = @ID AND USER_PWD = @PWD;";

                DBHelper db = new DBHelper();
                reader = db.ExecuteReader(sql, parameters);

                if (reader.Read())
                {
                    int authCode = reader.GetInt32("AUTH_CODE");
                    string username = reader.GetString("USER_NAME");

                    SessionManager.Login(authCode, userId, username);

                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("로그인에 실패하셨습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("로그인 중 오류가 발생했습니다." + ex.Message);
            }
            finally
            {
                // Reader 객체를 반드시 닫아주어야 CommandBehavior.CloseConnection에 의해 DB 연결 종료
                if (reader != null && !reader.IsClosed) 
                {
                    reader.Close();
                }
            }
        }
    }
}
