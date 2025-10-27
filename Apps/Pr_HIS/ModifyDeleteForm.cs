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

namespace Pr_HIS
{
    public partial class ModifyDeleteForm : Form
    {
        private int selectedPatientId = -1;
        private List<Patient> allpatients = new List<Patient>();

        public ModifyDeleteForm()
        {
            InitializeComponent();

            this.dgvPatientList.AutoGenerateColumns = false;
            RefreshPatientList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedPatientId == -1)
            {
                MessageBox.Show("수정할 환자를 목록에서 선택해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newName = txtSelectedName.Text.Trim();
            string newStatus = txtSelectedStatus.Text.Trim();   
            
            using (MySqlConnection conn = new MySqlConnection(DBHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "UPDATE patients SET name = @name, status = @status WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", newName);
                        cmd.Parameters.AddWithValue("@status", newStatus);
                        cmd.Parameters.AddWithValue("@id", selectedPatientId); // 중요

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("수정이 완료되었습니다.");
                            RefreshPatientList();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("수정 중 오류 발생");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedPatientId == -1)
            {
                MessageBox.Show("삭제할 환자를 목록에서 선택해주세요", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("선택된 환자를 정말 삭제하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes) 
            {
                using (MySqlConnection conn = new MySqlConnection(DBHelper.ConnectionString))
                {
                    try
                    {
                        conn.Open();
                        string sql = "DELETE FROM patients WHERE id = @id";

                        using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", selectedPatientId); // <<-- 핵심!

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("삭제가 완료되었습니다.");
                               
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("삭제 중 오류 발생");
                    }
                }
            }
        }
        private void RefreshPatientList()
        {
            allpatients = PatientService.GetAllPatients();

            dgvPatientList.DataSource = null;
            dgvPatientList.DataSource = allpatients;

            txtSelectedName.Clear();
            txtSelectedStatus.Clear();
            selectedPatientId = -1;
        }
        private void dgvPatientList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow selectedRow = dgvPatientList.Rows[e.RowIndex];

            selectedPatientId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

            txtSelectedName.Text = selectedRow.Cells["updateName"].Value.ToString();
            txtSelectedStatus.Text = selectedRow.Cells["Status"].Value.ToString();
        }
    }
}
