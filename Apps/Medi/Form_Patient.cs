using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medi
{
    public partial class Form_Patient : Form
    {
        public Form_Patient()
        {
            InitializeComponent();
        }

        private void Form_Patient_Load(object sender, EventArgs e)
        {
            ReceptionForm recepForm = new ReceptionForm();
            recepForm.TopLevel = false;
            recepForm.FormBorderStyle = FormBorderStyle.None;

            recepForm.AutoSize = false;
            recepForm.Dock = DockStyle.Fill;

            tabControl1.TabPages[0].Padding = new Padding(0);
            tabControl1.TabPages[0].Controls.Add(recepForm);
            tabControl1.TabPages[0].Text = "통합 접수";

            recepForm.Show();
        }
    }
}
