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

namespace Mini_HIS_Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // 폼 로드 이벤트 핸들러 : 폼이 화면에 표시되기 직전에 실행된다.
        private void MainForm_Load(object sender, EventArgs e)
        {
            // 다른 자식 폼들을 담을 수 있는 부모 창으로 설정한다.
            this.IsMdiContainer = true;

            // 핵심 로직 호출 : 현재 사용자 권한에 맞춰 메뉴를 DB에서 가져와 로드한다.
            LoadMenuByAuthority();

            this.Text = $"{SessionManager.UserName}님 (권한: {SessionManager.UserAuthCode})";
        }

        // 사용자 권한에 따라 메뉴를 로드하고 TreeView에 구성하는 메서드
        private void LoadMenuByAuthority()
        {
            // 현재 로그인된 권한 코드를 SessionManager에서 가져옵니다. 
            int userAuthCode = SessionManager.UserAuthCode;

            // 파라미터 설정
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                // @AuthCode에 권한 코드 할당
                new MySqlParameter("@AuthCode", userAuthCode)
            };

            string sql = "SELECT MENU_ID, PARENT_ID, MENU_NAME, FORM_NAME FROM Menu WHERE MIN_AUTH_CODE >= @AuthCode ORDER BY PARENT_ID, MENU_ORDER; ";

            DBHelper db = new DBHelper();
            MySqlDataReader reader = null;
            try
            {
                reader = db.ExecuteReader(sql, parameters);

                treeView.Nodes.Clear();

                // 조회된 데이터 기반으로 TreeView 메뉴 구성
                while (reader.Read())
                {
                    // DB에서 필요한 메뉴 정보를 컬럼 이름으로 읽어옵니다. 
                    int menuId = reader.GetInt32("MENU_ID");
                    int parentId = reader.GetInt32("PARENT_ID");
                    string menuName = reader.GetString("MENU_NAME");
                    string formName = reader["FORM_NAME"] as string;

                    TreeNode newNode = new TreeNode(menuName);
                    newNode.Tag = formName;

                    // PARENT_ID 가 0이면 부모 노드
                    if (parentId == 0)
                    {
                        newNode.Name = menuId.ToString();
                        treeView.Nodes.Add(newNode);
                    }
                    else
                    {
                        TreeNode parentNode = treeView.Nodes.Find(parentId.ToString(), true).FirstOrDefault();

                        if (parentNode != null)
                        {
                            parentNode.Nodes.Add(newNode);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }
        }
    }
}
