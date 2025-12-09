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
    public partial class ReceptionForm : Form
    {
        public ReceptionForm()
        {
            InitializeComponent();
        }

        public void ReceptionForm_Load(object sender, EventArgs e)
        {
            if (DBHelper.TestConnection())
            {
                MessageBox.Show("DB 연결 성공");
            }
            else
            {
                MessageBox.Show("DB 연결 실패");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtSearchName.Text;
            string sql = $"SELECT PatientID, Name, BirthDate FROM Patient_Master WHERE Name LIKE '%{searchName}%'";
            DataTable dt = DBHelper.Select(sql);
            dgvPatientList.DataSource = dt;
        }

        private void dgvPatientList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 ) return; 

            DataGridViewRow row = dgvPatientList.Rows[e.RowIndex];

            txtPatientID.Text = row.Cells["PatientID"].Value.ToString();
            txtPatientName.Text = row.Cells["pName"].Value.ToString();
            txtBirth.Text = row.Cells["BirthDate"].Value.ToString();

            dtpRegDate.Value = DateTime.Now;

            txtNote.Text = "";
            txtNote.Focus();    
        }
     
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPatientID.Text == "")
            {
                MessageBox.Show("먼저 왼쪽 리스트에서 환자를 선택해주세요!");
                return;
            }

            string patientID = txtPatientID.Text;
            string note = txtNote.Text;

            string regDate = dtpRegDate.Value.ToString("yyyy-MM-dd");

            string sql = $"INSERT INTO Reception_Master (PatientID, ReceptionDate, Note)" +
                            $"VALUES ({patientID}, '{regDate}' ,'{note}')";

            DBHelper.ExecuteSql(sql);
            MessageBox.Show("접수가 정상적으로 등록되었습니다.");
            txtNote.Text = "";
        }
    }
}
