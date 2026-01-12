using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Basecode_Hana.BaseCode;

namespace Basecode_Hana
{
    public partial class BaseCode : Form
    {
        public BaseCode()
        {
            InitializeComponent();
        }
        private void BaseCode_Load(object sender, EventArgs e)
        {
            SetGridStyle(dgvBig);
            SetGridStyle(dgvMedl);
            SetGridStyle(dgvSml);

            LoadBizGubun();
            if (cboBizGubun.Items.Count > 0) 
            {
                cboBizGubun.SelectedIndex = 0;
            }
            AutoSelectInitialData();
        }

        private void LoadBizGubun()
        {
            try
            {
                string sql = @"
                    SELECT SML_CODE, SML_NAME
                    FROM BASECODE_SML
                    WHERE BIG_CODE = '100'
                        AND MEDL_CODE = '10'
                        AND BIZ_GUBUN = 'A'
                    ORDER BY SML_CODE";

                DataTable dt = DBHelper.GetDataTable(sql);

                cboBizGubun.Items.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    string code = row["SML_CODE"].ToString();
                    string name = row["SML_NAME"].ToString();

                    cboBizGubun.Items.Add(new ComboItem(code, name));
                }

                cboBizGubun.DisplayMember = "Text";
                cboBizGubun.ValueMember = "Value";
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show("업무구분 조회 실패: " + ex.Message);
                }
            }
        }
        
        private void AutoSelectInitialData() 
        {
            string targetBigCode = "232";
            bool bigFound = false;

            foreach (DataGridViewRow row in dgvBig.Rows)
            {
                if (row.Cells["BIG_CODE"].Value?.ToString() == targetBigCode)
                {
                    row.Selected = true;
                    dgvBig.CurrentCell = row.Cells[0];
                    bigFound = true;
                    break;
                }
            }

            if (bigFound) 
            {
                ComboItem selectedBiz = cboBizGubun.SelectedItem as ComboItem;
                LoadMedlCode(selectedBiz.Value, targetBigCode);

                string targetMedlCode = "11";
                bool medlFound = false;

                foreach (DataGridViewRow row in dgvMedl.Rows)
                {
                    if (row.Cells["MEDL_CODE"].Value?.ToString() == targetMedlCode)
                    {
                        row.Selected = true;
                        dgvMedl.CurrentCell = row.Cells[0];
                        medlFound = true;
                        break;
                    }
                }
                if (medlFound) 
                {
                    LoadSmlCode(selectedBiz.Value, targetBigCode, targetMedlCode);
                }
            }
        }
        
        private void choBizGubun_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBigCode();
        }

        private void LoadBigCode()
        {
            ComboItem selected = cboBizGubun.SelectedItem as ComboItem;
            if (selected == null) return;

            string bizType = selected.Value; 

            string sql = $"SELECT BIG_CODE, BIG_NAME FROM BASECODE_BIG WHERE BIZ_GUBUN = '{bizType}' ORDER BY BIG_CODE";
            dgvBig.DataSource = DBHelper.GetDataTable(sql);
           
            dgvMedl.DataSource = null;
            dgvSml.DataSource = null;
        }

        private void dgvBig_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            ComboItem selectedBiz = cboBizGubun.SelectedItem as ComboItem;
            string bigCode = dgvBig.Rows[e.RowIndex].Cells["BIG_CODE"].Value.ToString();

            LoadMedlCode(selectedBiz.Value, bigCode);

            if (dgvMedl.Rows.Count > 0)
            {
                dgvMedl.Rows[0].Selected = true;
                dgvMedl.CurrentCell = dgvMedl.Rows[0].Cells[0];

                string firstMedlCode = dgvMedl.Rows[0].Cells["MEDL_CODE"].Value.ToString();
                LoadSmlCode(selectedBiz.Value, bigCode, firstMedlCode);
            }
            else
            {
                dgvSml.DataSource = null;
            } 
        }

        private void LoadMedlCode(string bizType, string bigCode)
        {
            string sql = $@"
                SELECT MEDL_CODE, MEDL_NAME 
                FROM BASECODE_MEDL 
                WHERE BIZ_GUBUN = '{bizType}' 
                  AND BIG_CODE = '{bigCode}'
                ORDER BY MEDL_CODE";

            dgvMedl.DataSource = DBHelper.GetDataTable(sql);
        }

        private void dgvMedl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            ComboItem selectedBiz = cboBizGubun.SelectedItem as ComboItem;

            // 대분류 그리드에서 현재 선택된 줄의 코드 가져오기 (CurrentRow 이용)
            if (dgvBig.CurrentRow == null) return;
            string bigCode = dgvBig.CurrentRow.Cells["BIG_CODE"].Value.ToString();

            string medlCode = dgvMedl.Rows[e.RowIndex].Cells["MEDL_CODE"].Value.ToString();

            LoadSmlCode(selectedBiz.Value, bigCode, medlCode);
        }

        private void LoadSmlCode(string bizType, string bigCode, string medlCode)
        {
            string sql = $@"
                SELECT SML_CODE, SML_NAME, COMMENTS, COMMENTS2 
                FROM BASECODE_SML 
                WHERE BIZ_GUBUN = '{bizType}' 
                  AND BIG_CODE = '{bigCode}' 
                  AND MEDL_CODE = '{medlCode}'
                ORDER BY SML_CODE";

            dgvSml.DataSource = DBHelper.GetDataTable(sql);
        }

        public class ComboItem 
        {
            public string Value { get; set; }
            public string Text { get; set; }

            public ComboItem(string val, string text) 
            {
                Value = val;
                Text = text;
            }
            public override string ToString()
            {
                return Text;
            }
        }
        private void SetGridStyle(DataGridView dgv)
        {
            // 1. 델파이처럼 줄 단위로 선택되게 함 (셀 하나가 아니라)
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // 2. 여러 줄 선택 못하게 막음
            dgv.MultiSelect = false;

            // 3. 내용 수정 못하게 막음 (이걸 해야 클릭하자마자 바로 이벤트가 터짐!)
            dgv.ReadOnly = true;          


        }
    }
}
