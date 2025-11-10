using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Exam_MySQL
{
    public partial class Form1 : Form
    {
        private readonly Exam_Service service = new Exam_Service();
        private int _selectedExamId = 0; // 선택된 행의 ID를 저장

        public Form1()
        {
            InitializeComponent();

            // DGV 설정
            dgvInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInfo.MultiSelect = false;

            // 💡 초기 화면에 데이터 로드 호출 제거 (요구사항 반영)
        }

        // 데이터 바인딩 메서드 (갱신 및 조회 시 사용)
        public void RefreshDataGrid(List<Exam> data)
        {
            dgvInfo.AutoGenerateColumns = false;

            dgvInfo.DataSource = null;
            dgvInfo.DataSource = data;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            _selectedExamId = 0; // ID 초기화
            dgvInfo.ClearSelection();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Exam exam = new Exam
                {
                    Name = txtName.Text,
                    Phone = txtPhone.Text
                };
                service.Register(exam);

                MessageBox.Show("데이터가 성공적으로 추가되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnReset_Click(sender, e);

                // 삽입 후 전체 데이터로 갱신
                RefreshDataGrid(service.GetAllRegisterExams());
            }
            catch (Exception ex)
            {
                MessageBox.Show("추가 오류: " + ex.Message);
            }
        }

        private void dgvInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvInfo.Rows[e.RowIndex].DataBoundItem != null)
            {
                Exam selectedItem = dgvInfo.Rows[e.RowIndex].DataBoundItem as Exam;

                if (selectedItem != null)
                {
                    // 선택된 ID를 저장하여 수정/삭제 시 사용
                    _selectedExamId = selectedItem.Id;
                    txtName.Text = selectedItem.Name;
                    txtPhone.Text = selectedItem.Phone;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedExamId == 0)
                {
                    MessageBox.Show("수정할 데이터를 선택해주세요.");
                    return;
                }

                Exam exam = new Exam
                {
                    Id = _selectedExamId, // 💡 ID 전달
                    Name = txtName.Text,
                    Phone = txtPhone.Text
                };
                service.Update(exam);

                MessageBox.Show("데이터가 성공적으로 수정되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnReset_Click(sender, e);
                _selectedExamId = 0;

                // 💡 수정 후 전체 데이터로 갱신
                RefreshDataGrid(service.GetAllRegisterExams());
            }
            catch (Exception ex)
            {
                MessageBox.Show("수정 오류: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInfo.SelectedRows.Count == 0) return;

                Exam selectedExam = dgvInfo.SelectedRows[0].DataBoundItem as Exam;

                // 💡 Null 체크 추가
                if (selectedExam == null) return;

                int idToDelete = selectedExam.Id;

                if (MessageBox.Show($"ID {idToDelete}의 데이터를 정말 삭제하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }

                service.Delete(idToDelete);

                MessageBox.Show("데이터가 성공적으로 삭제되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnReset_Click(sender, e);
                _selectedExamId = 0;

                // 💡 삭제 후 전체 데이터로 갱신
                RefreshDataGrid(service.GetAllRegisterExams());
            }
            catch (Exception ex)
            {
                MessageBox.Show("삭제 오류: " + ex.Message);
            }
        }

        // 조회하기 버튼
        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text.Trim();
                string phone = txtPhone.Text.Trim();

                List<Exam> results;

                // 요구사항: 빈칸 검색 시 전체 데이터를 가져옵니다.
                if (string.IsNullOrWhiteSpace(name) && string.IsNullOrWhiteSpace(phone))
                {
                    results = service.GetAllRegisterExams(); // 전체 데이터 조회
                }
                else
                {
                    results = service.GetAllRegisteredExams(name, phone); // 필터링 조회
                }

                // DGV 갱신
                RefreshDataGrid(results);
            }

            catch (Exception ex)
            {
                MessageBox.Show("조회 오류: " + ex.Message);
            }
        }
    }
}