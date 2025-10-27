using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_HIS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        ///  viewForm. registerForm, modifyForm 객체 생성 후 Show() 메서드를 통해서 폼을 띄운다.
        ///  ShowDialog() 경우 새로 띄운 폼을 닫기 전까지 메인 폼을 조작할 수 없다. 
        /// </summary>
      
        private void btnCheckupView_Click(object sender, EventArgs e)
        {
            ViewForm viewForm = new ViewForm();
            viewForm.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            ModifyDeleteForm modifyForm = new ModifyDeleteForm();
            modifyForm.Show();
        }
    }
}
