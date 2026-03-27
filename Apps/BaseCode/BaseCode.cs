using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq; 
using System.Windows.Forms;

namespace BaseCodeApp
{
    public partial class BaseCode : Form
    {
        private BaseCodeService _service = new BaseCodeService();
      
        // Dto 클래스의 리스트 생성
        private List<BigCodeDto> _bigList = new List<BigCodeDto>();
        private List<MedlCodeDto> _medlList = new List<MedlCodeDto>();
        private List<SmlCodeDto> _smlList = new List<SmlCodeDto>();

        // 이벤트 무한 루프 방지
        // 로딩 중일때는 _isBinding = true 로 해서 이벤트를 무시하게 만듬
        private bool _isBinding = false;

        public BaseCode()
        {
            InitializeComponent();

            this.Text = "정승우의 기초코드";
        }

        // 화면 로드
        private void BaseCode_Load(object sender, EventArgs e)
        {
            // 그리드 설정
            SetGridStyle(dgvBig);
            SetGridStyle(dgvMedl);
            SetGridStyle(dgvSml);
            MapGridColumns(); // 컬럼 강제 연결

            // 콤보박스 코드 실행 
            LoadBizGubun();

            if (cboBizGubun.Items.Count > 0)
                cboBizGubun.SelectedIndex = 0;

            AutoSelectInitialData();
        }

        // ========================================================
        // [설정] 그리드 컬럼과 DTO 연결 
        // ========================================================
        private void MapGridColumns()
        {
            // 디자인의 DataPropertyName이 비어있어도 여기서 강제 연결됨
            if (dgvBig.Columns.Contains("BIG_CODE")) dgvBig.Columns["BIG_CODE"].DataPropertyName = "Code";
            if (dgvBig.Columns.Contains("BIG_NAME")) dgvBig.Columns["BIG_NAME"].DataPropertyName = "Name";

            if (dgvMedl.Columns.Contains("MEDL_CODE")) dgvMedl.Columns["MEDL_CODE"].DataPropertyName = "Code";
            if (dgvMedl.Columns.Contains("MEDL_NAME")) dgvMedl.Columns["MEDL_NAME"].DataPropertyName = "Name";

            if (dgvSml.Columns.Contains("SML_CODE")) dgvSml.Columns["SML_CODE"].DataPropertyName = "Code";
            if (dgvSml.Columns.Contains("SML_NAME")) dgvSml.Columns["SML_NAME"].DataPropertyName = "Name";
            if (dgvSml.Columns.Contains("COMMENTS")) dgvSml.Columns["COMMENTS"].DataPropertyName = "Comments";
            if (dgvSml.Columns.Contains("COMMENTS2")) dgvSml.Columns["COMMENTS2"].DataPropertyName = "Comments2";
        }

        private void SetGridStyle(DataGridView dgv)
        {
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ReadOnly = false; // 수정 가능해야 함 (CellValueChanged 작동 위해)
            dgv.AllowUserToAddRows = false;
            dgv.RowHeadersVisible = true;
            dgv.AutoGenerateColumns = false; // 자동 생성 끔
        }

        // ========================================================
        // 1. 대분류 로직
        // ========================================================
        private void LoadBigCode()
        {
            ComboItem selected = cboBizGubun.SelectedItem as ComboItem;
            if (selected == null) return;

            // DB 조회 -> 원본 리스트 저장
            _bigList = _service.GetBigList(selected.Value);
            BindBigGrid();

            // 하위 초기화
            _medlList.Clear(); BindMedlGrid();
            _smlList.Clear(); BindSmlGrid();

            // 첫줄 자동 선택
            if (dgvBig.Rows.Count > 0)
            {
                dgvBig.Rows[0].Selected = true;
                dgvBig.CurrentCell = dgvBig.Rows[0].Cells[0];
                var item = dgvBig.Rows[0].DataBoundItem as BigCodeDto;
                LoadMedlCode(selected.Value, item.Code);
            }
        }

        // 무슨 메서드인지 모르겠음 왜 필요한지 (세부적으로 설명 필요)
        private void BindBigGrid()
        {
            _isBinding = true; // 로딩 시작
            dgvBig.DataSource = null; 

            string searchText = txtSearchBig.Text;

            var query = _bigList.Where(x => x.Status != "D");

            if (!string.IsNullOrEmpty(searchText)) 
            {
                query = query.Where(x=> x.Name.ToLower().Contains(searchText.ToLower()));
            }  
            dgvBig.DataSource = query.ToList(); 
            _isBinding = false; 
        }

        // 대분류 추가 버튼 
        private void btnAddBig_Click(object sender, EventArgs e)
        {
            // 콤보박스 구분이 선택된 것을 가져옴
            ComboItem selected = cboBizGubun.SelectedItem as ComboItem;
            if (selected == null) return;

            // 새로 만드는 ITEM의 상태를 'A'로 설정해서 만듬
            var newItem = new BigCodeDto { BizGubun = selected.Value, Status = "A" };
            _bigList.Add(newItem);
            BindBigGrid();

            // 마지막 줄 포커스
            if (dgvBig.Rows.Count > 0)
                dgvBig.CurrentCell = dgvBig.Rows[dgvBig.Rows.Count - 1].Cells[0];
        }

        private void btnDelBig_Click(object sender, EventArgs e)
        {
            if (dgvBig.CurrentRow == null) return;
            var item = dgvBig.CurrentRow.DataBoundItem as BigCodeDto;

            // 실제 리스트에서 찾음
            var target = _bigList.FirstOrDefault(x => x == item);
            if (target == null) return;

            if (target.Status != "A")
            {
                MessageBox.Show("기존 등록된 내용은 삭제할 수 없습니다.\n삭제 필요시 전산팀에 문의 후 작업하시길 바랍니다.",
                        "삭제 불가", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } 
            

            _bigList.Remove(target); // 신규는 완전 삭제
            BindBigGrid();
        }

        // 셀 값 변화 
        private void dgvBig_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // 변하면 U 값으로 설정
            if (_isBinding || e.RowIndex < 0) return;
            var item = dgvBig.Rows[e.RowIndex].DataBoundItem as BigCodeDto;
            if (item.Status != "A" && item.Status != "D") item.Status = "U";
        }

        // ========================================================
        // 2. 중분류 로직
        // ========================================================
        private void LoadMedlCode(string bizType, string bigCode)
        {
            _medlList = _service.GetMedlList(bizType, bigCode);
            BindMedlGrid();

            _smlList.Clear(); BindSmlGrid(); // 하위 초기화

            if (dgvMedl.Rows.Count > 0)
            {
                dgvMedl.Rows[0].Selected = true;
                dgvMedl.CurrentCell = dgvMedl.Rows[0].Cells[0];
                var item = dgvMedl.Rows[0].DataBoundItem as MedlCodeDto;
                LoadSmlCode(bizType, bigCode, item.Code);
            }
        }

        private void BindMedlGrid()
        {
            _isBinding = true;
            dgvMedl.DataSource = null;

            string searchText = txtSearchMedl.Text;

            var query = _medlList.Where(x => x.Status != "D");

            if (!string.IsNullOrEmpty(searchText)) 
            {
                query = query.Where(x => x.Name.ToLower().Contains(searchText.ToLower()));
            }

            dgvMedl.DataSource = query.ToList();
            _isBinding = false;
        }

        private void btnAddMedl_Click(object sender, EventArgs e)
        {
            if (dgvBig.CurrentRow == null) return;
            var bigItem = dgvBig.CurrentRow.DataBoundItem as BigCodeDto;

            var newItem = new MedlCodeDto { BigCode = bigItem.Code, Status = "A" };
            _medlList.Add(newItem);
            BindMedlGrid();

            if (dgvMedl.Rows.Count > 0)
                dgvMedl.CurrentCell = dgvMedl.Rows[dgvMedl.Rows.Count - 1].Cells[0];
        }

        private void btnDelMedl_Click(object sender, EventArgs e)
        {
            if (dgvMedl.CurrentRow == null) return;
            var item = dgvMedl.CurrentRow.DataBoundItem as MedlCodeDto;
            var target = _medlList.FirstOrDefault(x => x == item);

            if (target.Status != "A")
            {
                MessageBox.Show("기존 등록된 내용은 삭제할 수 없습니다.\n삭제 필요시 전산팀에 문의 후 작업하시길 바랍니다.",
                        "삭제 불가", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            _medlList.Remove(target);
            BindMedlGrid();
        }

        private void dgvMedl_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (_isBinding || e.RowIndex < 0) return;
            var item = dgvMedl.Rows[e.RowIndex].DataBoundItem as MedlCodeDto;
            if (item.Status != "A" && item.Status != "D") item.Status = "U";
        }

        // ========================================================
        // 3. 소분류 로직
        // ========================================================
        private void LoadSmlCode(string bizType, string bigCode, string medlCode)
        {
            _smlList = _service.GetSmlList(bizType, bigCode, medlCode);
            BindSmlGrid();
        }

        private void BindSmlGrid()
        {
            _isBinding = true;
            dgvSml.DataSource = null;

            string searchText = txtSearchSml.Text;

            var query = _smlList.Where(x => x.Status != "D");

            if (!string.IsNullOrEmpty(searchText)) 
            {
                query = query.Where(x => x.Name.ToLower().Contains(searchText.ToLower()));
            }

            dgvSml.DataSource = query.ToList();
            _isBinding = false;
        }

        private void btnAddSml_Click(object sender, EventArgs e)
        {
            if (dgvMedl.CurrentRow == null) return;
            var medlItem = dgvMedl.CurrentRow.DataBoundItem as MedlCodeDto;

            var newItem = new SmlCodeDto { MedlCode = medlItem.Code, Status = "A" };
            _smlList.Add(newItem);
            BindSmlGrid();
            if (dgvSml.Rows.Count > 0)
                dgvSml.CurrentCell = dgvSml.Rows[dgvSml.Rows.Count - 1].Cells[0];
        }

        private void btnDelSml_Click(object sender, EventArgs e)
        {
            if (dgvSml.CurrentRow == null) return;
            var item = dgvSml.CurrentRow.DataBoundItem as SmlCodeDto;
            var target = _smlList.FirstOrDefault(x => x == item);

            if (target.Status != "A")
            {
                MessageBox.Show("기존 등록된 내용은 삭제할 수 없습니다.\n삭제 필요시 전산팀에 문의 후 작업하시길 바랍니다.",
                        "삭제 불가", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }       

            _smlList.Remove(target);
            BindSmlGrid();
        }

        private void dgvSml_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (_isBinding || e.RowIndex < 0) return;
            var item = dgvSml.Rows[e.RowIndex].DataBoundItem as SmlCodeDto;
            if (item.Status != "A" && item.Status != "D") item.Status = "U";
        }

        // ========================================================
        // 4. 저장 (Batch Save)
        // ========================================================
        private void btnSave_Click(object sender, EventArgs e)
        {
            dgvBig.EndEdit();   // 대분류 편집 종료
            dgvMedl.EndEdit();  // 중분류 편집 종료
            dgvSml.EndEdit();   // 소분류 편집 종료

            if (MessageBox.Show("변경된 내용을 저장하시겠습니까?", "저장", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    ComboItem selected = cboBizGubun.SelectedItem as ComboItem;
                    if (selected == null) return;

                    // 대분류 저장
                    _service.SaveBigList(_bigList);

                    // 중분류 저장 (부모가 없으면 안되므로 대분류 저장 후 실행)
                    _service.SaveMedlList(_medlList, selected.Value);

                    // 소분류 저장 (대분류 키가 필요함)
                    // 현재 선택된 대분류 코드를 가져와서 저장 (단, 전체 저장하려면 로직 보완 필요)
                    if (dgvBig.CurrentRow != null)
                    {
                        var bigItem = dgvBig.CurrentRow.DataBoundItem as BigCodeDto;
                        _service.SaveSmlList(_smlList, selected.Value, bigItem.Code);
                    }

                    MessageBox.Show("저장되었습니다.");
                    LoadBigCode(); // 재조회
                }
                catch (Exception ex)
                {
                    MessageBox.Show("저장 중 오류 발생: " + ex.Message);
                }
            }
        }

        private void LoadBizGubun()
        {
            try
            {
                List<ComboItem> list = _service.GetBizGubunList();

                cboBizGubun.Items.Clear();

                foreach (var item in list) 
                {
                    cboBizGubun.Items.Add(item);
                }
                cboBizGubun.DisplayMember = "Text";
                cboBizGubun.ValueMember = "Value";
            }
            catch { }
        }

        // 콤보박스가 변하면 대분류 조회 로직 실행
        private void cboBizGubun_SelectedIndexChanged(object sender, EventArgs e) => LoadBigCode();

        private void dgvBig_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            ComboItem selected = cboBizGubun.SelectedItem as ComboItem;
            var item = dgvBig.Rows[e.RowIndex].DataBoundItem as BigCodeDto;
            LoadMedlCode(selected.Value, item.Code);
        }

        private void dgvMedl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvBig.CurrentRow == null) return;
            ComboItem selected = cboBizGubun.SelectedItem as ComboItem;
            var bigItem = dgvBig.CurrentRow.DataBoundItem as BigCodeDto;
            var medlItem = dgvMedl.Rows[e.RowIndex].DataBoundItem as MedlCodeDto;
            LoadSmlCode(selected.Value, bigItem.Code, medlItem.Code);
        }

        private void AutoSelectInitialData()
        {
            string targetBig = "232";
            foreach (DataGridViewRow row in dgvBig.Rows)
            {
                var item = row.DataBoundItem as BigCodeDto;
                if (item != null && item.Code == targetBig)
                {
                    row.Selected = true;
                    dgvBig.CurrentCell = row.Cells[0];
                    LoadMedlCode((cboBizGubun.SelectedItem as ComboItem).Value, targetBig);

                    string targetMedl = "11";
                    foreach (DataGridViewRow mRow in dgvMedl.Rows)
                    {
                        var mItem = mRow.DataBoundItem as MedlCodeDto;
                        if (mItem != null && mItem.Code == targetMedl)
                        {
                            mRow.Selected = true;
                            dgvMedl.CurrentCell = mRow.Cells[0];
                            LoadSmlCode((cboBizGubun.SelectedItem as ComboItem).Value, targetBig, targetMedl);
                            break;
                        }
                    }
                    break;
                }
            }
        }

        private void txtSearchBig_TextChanged(object sender, EventArgs e)
        {
            BindBigGrid();
        }

        private void txtSearchMedl_TextChanged(object sender, EventArgs e)
        {
            BindMedlGrid();
        }

        private void txtSearchSml_TextChanged(object sender, EventArgs e)
        {
            BindSmlGrid();
        }
    }
}