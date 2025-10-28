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
    /// <summary>
    /// 수정/삭제 폼 
    /// </summary>
    public partial class ModifyDeleteForm : Form
    {
        // selectedPatientId 를 -1 로 설정 ->  -1 일 경우 선택된 아이디가 없는 것
        private int selectedPatientId = -1;
        
        // allpatients 라는 변수명으로 List 그릇 만듬
        private List<Patient> allpatients = new List<Patient>();

        public ModifyDeleteForm()
        {
            InitializeComponent();

            this.dgvPatientList.AutoGenerateColumns = false;
            RefreshPatientList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // 선택된 것이 없으면 
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

        /// <summary>
        ///  DataGridView의 행이 클릭될 때 실행되는 이벤트
        ///  클릭된 행의 ID와 정보를 가져와 TextBox에 표시하고, selectedPatientId 변수에 ID를 저장하여
        ///  update 및 delete 쿼리의 where 절에 사용할 수 있도록 준비합니다. 
        /// </summary>           
        private void dgvPatientList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 유효성 검사 : 컬럼 헤더(인덱스 < 0) 또는 빈 행 클릭 시 처리 중단 
            if (e.RowIndex < 0)
            {
                return;
            }
            // DataGridViewRow 객체 획득(DataGridViewRow 중요) 
            DataGridViewRow selectedRow = dgvPatientList.Rows[e.RowIndex];

            // ID 값 저장
            selectedPatientId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

            // TextBox에 데이터 바인딩 (수정 준비)
            // DB와 Patient 모델의 속성 이름인 Name과 Status로 접근합니다. 
            txtSelectedName.Text = selectedRow.Cells["updateName"].Value.ToString();
            txtSelectedStatus.Text = selectedRow.Cells["Status"].Value.ToString();
        }
    }
}
