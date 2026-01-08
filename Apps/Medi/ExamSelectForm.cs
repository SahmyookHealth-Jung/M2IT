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
    public partial class ExamSelectForm : Form
    {
        public ExamSelectForm()
        {
            InitializeComponent();
        }

        public void ExamSelectForm_Load(object sender, EventArgs e)
        {
            string sql = "SELECT ExamCode, ExamName, Price, Category FROM Exam_Code";
            DataTable dt = DBHelper.Select(sql);

            dgvExamSelect.DataSource = dt;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
