using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace DB_Practice
{
    public partial class Form1 : Form
    {
        private string connectingString =
            "Server=localhost;Port=3306;Database=db_practice;Uid=downer;Pwd=dkdlxl123!";
        public Form1()
        {
            InitializeComponent();
        }
        private string FindUserName(string searchId)
        {
            string userName = null;

            using (MySqlConnection conn = new MySqlConnection(connectingString))
            {
                try
                {
                    conn.Open();

                    string sql = "SELECT UserName From Users WHERE UserId = @id";                 

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", searchId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                userName = reader.GetString("UserName");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"DB 오류 발생 : {ex.Message}");
                }
            }
            return userName ?? "회원을 찾을 수 없습니다.";
        }
       
        private void btnFind_Click(object sender, EventArgs e)
        {
            string inputId = txtId.Text.Trim();

            string foundName = FindUserName(inputId);
            lblName.Text = foundName;

            string foundEmail = FindUserName(inputId);
            lblEmail.Text = foundEmail;

            if(foundName.Contains("찾을 수 없습니다."))
            {
                lblName.ForeColor = Color.Red;
            }
            else
            {
                lblName.ForeColor = Color.Black;
            }
        }
    }
}
