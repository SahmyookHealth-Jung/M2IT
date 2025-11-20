using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_List
{
    public partial class Form1 : Form
    {
        TermRepository _repo = new TermRepository();

        public Form1()
        {
            InitializeComponent();

            dgvGrid.AutoGenerateColumns = false;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            List<MedicalTerm> list = _repo.SelectAll(searchText);
            dgvGrid.DataSource = list;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCode.Text))
            {
                MessageBox.Show("용어 코드를 입력하세요");
                return;
            }

            MedicalTerm Term = new MedicalTerm();

            Term.TermCode = txtCode.Text.Trim();
            Term.FullName = txtName.Text.Trim(); 
            Term.Description = txtDesc.Text.Trim();

            try
            {
                if (string.IsNullOrEmpty(txtId.Text) || txtId.Text == "자동생성")
                {
                    _repo.Insert(Term);
                    MessageBox.Show("저장되었습니다.");
                }
                else
                {
                    Term.Id = int.Parse(txtId.Text);
                    _repo.Update(Term);
                    MessageBox.Show("수정되었습니다.");
                }
                btnSelect_Click(sender, e);
                btnReset_Click(sender, e);

                SaveToCSV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) || txtId.Text == "자동생성")
            {
                MessageBox.Show("삭제할 데이터를 먼저 선택해주세요.");
                return;

                
            }

            if (MessageBox.Show("정말로 삭제하시겠습니까?", "경고", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    int id = int.Parse(txtId.Text);
                    _repo.Delete(id);

                    MessageBox.Show("삭제되었습니다.");
                    btnSelect_Click(sender, e);
                    btnReset_Click(sender, e);

                    SaveToCSV();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("오류 발생: " + ex.Message);
                }
            }          
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtId.Text = "자동생성";
            txtCode.Clear();
            txtName.Clear();
            txtDesc.Clear();
            txtCode.Focus(); 
        }

        private void dgvGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dgvGrid.Rows[e.RowIndex];

            txtId.Text = row.Cells["colId"].Value?.ToString();
            txtCode.Text = row.Cells["colCode"].Value?.ToString();
            txtName.Text = row.Cells["colName"].Value?.ToString();
            txtDesc.Text = row.Cells["colDesc"].Value?.ToString();
        }

        private void SaveToCSV()
        {
            try
            {
                List<MedicalTerm> list = _repo.SelectAll("");

                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "WordList.csv");

                using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8))
                {
                    sw.WriteLine("ID, 용어코드, 전체명칭, 설명, 등록일");

                    foreach (var item in list)
                    {
                        string line = $"{item.Id},{item.TermCode},{item.FullName}, {item.Description},{item.RegDate}";
                        sw.WriteLine(line);
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show("CSV 저장 실패: " + ex.Message);
            }
        }
    }
}
