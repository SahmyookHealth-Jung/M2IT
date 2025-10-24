using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEW_INFO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtNewName.Text.Trim(); 
            string chartNo = txtNewChartNo.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("이름이 비어있습니다.");
            }
            if (string.IsNullOrEmpty(chartNo))
            {
                MessageBox.Show("차트 번호가 비어있습니다.");
            }
        }
    }
}
