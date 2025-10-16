namespace WinFormSignIn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string userId = id.Text;
            string userPwd = pwd.Text;

            if (userId.Equals("jungsw") && userPwd.Equals("jsw"))
            {
                MessageBox.Show("로그인 성공", "로그인");
            }
            else
            {
                MessageBox.Show("로그인 실패", "로그인");
            }
        }
    }
}
