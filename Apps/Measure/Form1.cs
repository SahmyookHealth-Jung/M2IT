using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Measure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "정승우의 신체계측 검사";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblAcptNo.Text = "";
            lblName.Text = "";
            lblRegiFnt.Text = "";
            lblSex.Text = "";
            lblAge.Text = "";
            lblPcustNo.Text = "";

            try
            {
                MeasureService service = new MeasureService();

                MeasureDto room = service.GetCurrentRoomInfo();

                if (room != null)
                {
                    lblroomInfo.Text = room.RoomName;
                }
                LoadWaitingList(); 
            }
            catch(Exception ex)
            {
                MessageBox.Show("데이터 로드 중 오류" + ex.Message);
            }
        }
        
        public void LoadWaitingList()
        {
            MeasureService service = new MeasureService();
            List<MeasureDto> list = service.GetWaitingList();

            dgvWaitingList.Rows.Clear();

            foreach (var item in list)
            {
                int rowIndex = dgvWaitingList.Rows.Add(null, item.Name, item.Sex, item.ItemName);
                dgvWaitingList.Rows[rowIndex].Tag = item.AcptNo;
            }
        }

        public void SearchPatient(string acptNo)
        {
            MeasureService service = new MeasureService();

            MeasureDto patient = service.GetPatientAndItemInfo(acptNo);

            if (patient != null)
            {
                lblAcptNo.Text = patient.AcptNo;       // 접수번호
                lblRegiFnt.Text = patient.FullRegiNum;   // 주민번호 (010910-*******)
                lblName.Text = patient.Name;           // 홍길동
                lblSex.Text = patient.Sex;          // 남/여
                lblPcustNo.Text = patient.FixPcustNo; // 회원번호
                lblAge.Text = patient.Age;

                LoadExamList(acptNo);

                LoadRightGrid(acptNo);
            }
            else
            {
                MessageBox.Show("해당 접수번호의 수검자가 없습니다.");
            }
        }
        
        public void LoadExamList(string acptNo)
        {
            MeasureService service = new MeasureService();
            List<MeasureDto> exams = service.GetPatientExamList(acptNo);

            dgvExamItemList.Rows.Clear();

            foreach (var exam in exams) 
            {
                dgvExamItemList.Rows.Add(exam.ExamCode, exam.ExamName);
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string acptNo = txtAcptNo.Text.Trim();

            if (string.IsNullOrEmpty(acptNo))
            {
                MessageBox.Show("접수번호(9자리) 또는 회원번호(8자리 이하)를 입력하세요.");
                return;
            }

            string targetAcptNo = "";

            if (acptNo.Length == 9 )
            {
                targetAcptNo = acptNo;
            }
            else if (acptNo.Length <= 8 )
            {
                MeasureService service = new MeasureService();
                string foundAcptNo = service.GetTodayAcptNoByPcustNo(acptNo);

                if(string.IsNullOrEmpty(foundAcptNo))
                {
                    MessageBox.Show($"회원번호({acptNo})로 금일 접수된 내역이 없습니다.\n\n" +
                            "1. 접수가 되었는지 확인해주세요.\n" +
                            "2. 과거 이력을 보시려면 접수번호를 직접 입력해주세요.",
                            "검색 결과 없음", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; // 검색 중단
                }
                targetAcptNo = foundAcptNo;
            }
            else
            {     
                    MessageBox.Show("입력하신 번호 형식이 올바르지 않습니다.\n(접수번호: 9자리, 회원번호: 8자리 이하)");
                    return;
            }
                SearchPatient(targetAcptNo);
        }

        private void txtAcptNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                btnSearch_Click(sender, e);
            }
        }

        private void dgvWaitingList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.Value = (e.RowIndex + 1).ToString();
                e.FormattingApplied = true;
            }
        }

        private void dgvWaitingList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                var tag = dgvWaitingList.Rows[e.RowIndex].Tag;

                if (tag != null)
                {
                    string acptNo = tag.ToString();

                    txtAcptNo.Text = acptNo;

                    SearchPatient(acptNo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("선택 중 오류 발생: " + ex.Message);
            }
        }

        private void LoadRightGrid(string acptNo)
        {
            MeasureService service = new MeasureService();
            List<MeasureResultDto> list = service.GetMeasureResults(acptNo);

            // 우측 그리드 이름이 dgvResult 라고 가정
            dgvBodyMeasure.Rows.Clear();

            // (만약 컬럼 헤더가 없다면 디자인탭에서 미리 만들어두세요: 접수일자, 신장, 체중...)

            foreach (var item in list)
            {
                dgvBodyMeasure.Rows.Add(
                    null,
                    item.AcptNo,
                    item.AcptDate,
                    item.Height,
                    item.Weight,
                    item.Bmi,
                    item.Waist,
                    item.Chest,
                    item.Neck
                );
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAcptNo.Text = "";
            lblAcptNo.Text = "";       // 접수번호
            lblRegiFnt.Text = "";   // 주민번호 (010910-*******)
            lblName.Text = "";           // 홍길동
            lblSex.Text = "";          // 남/여
            lblPcustNo.Text = ""; // 회원번호
            lblAge.Text = "";

            dgvWaitingList.Rows.Clear();
            dgvExamItemList.Rows.Clear();
            dgvBodyMeasure.Rows.Clear();

            LoadWaitingList();
            txtAcptNo.Focus();
        }

        private void btnReTest_Click(object sender, EventArgs e)
        {
            if (dgvBodyMeasure.Rows.Count == 0) return;

            string recentAcptNo = dgvBodyMeasure.Rows[0].Cells[1].Value?.ToString();
            string recentDate = dgvBodyMeasure.Rows[0].Cells[2].Value?.ToString();

            if (recentDate != DateTime.Now.ToString("yyyy-MM-dd")) 
            {
                MessageBox.Show("금일 접수된 내역만 재측정이 가능합니다. \n\n과거 접수 내역은 재측정할 수 없습니다.",
                    "재측정 불가",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            dgvBodyMeasure.Rows.Insert(0,
                true,
                recentAcptNo,
                recentDate,
                "", "", "", "", "", ""
                );
            dgvBodyMeasure.CurrentCell = dgvBodyMeasure.Rows[0].Cells[3];
            dgvBodyMeasure.BeginEdit(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 1. 현재 입력 중인 셀의 편집을 강제로 종료시킵니다. (이거 안 하면 마지막 입력값 저장 안 됨)
            dgvBodyMeasure.EndEdit();

            List<MeasureResultDto> saveList = new List<MeasureResultDto>();
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            bool hasPastDateError = false;

            // 2. 그리드 전체를 돌면서 '체크박스'가 선택된 행을 찾습니다.
            foreach (DataGridViewRow row in dgvBodyMeasure.Rows)
            {
                // 0번 컬럼이 체크박스라고 가정 (CheckBoxCell)
                bool isChecked = Convert.ToBoolean(row.Cells[0].Value);

                if (isChecked)
                {
                    // 날짜 확인 (2번 컬럼이 내원일자라고 가정)
                    string rowDate = row.Cells[2].Value?.ToString();

                    // [방어 로직] 오늘 날짜가 아니면 저장을 막습니다.
                    if (rowDate != today)
                    {
                        hasPastDateError = true;
                        continue; // 이 행은 저장 리스트에 담지 않고 넘어감
                    }

                    // [데이터 담기] DTO 생성
                    MeasureResultDto dto = new MeasureResultDto();

                    // 컬럼 인덱스는 디자인 화면 순서에 맞춰주세요!
                    dto.AcptNo = row.Cells[1].Value?.ToString(); // 접수번호
                    dto.AcptDate = row.Cells[2].Value?.ToString();
                    dto.Height = row.Cells[3].Value?.ToString(); // 신장
                    dto.Weight = row.Cells[4].Value?.ToString(); // 체중
                    dto.Bmi = row.Cells[5].Value?.ToString(); // BMI
                    dto.Waist = row.Cells[6].Value?.ToString(); // 허리
                    dto.Chest = row.Cells[7].Value?.ToString(); // 가슴
                    dto.Neck = row.Cells[8].Value?.ToString(); // 목

                    saveList.Add(dto);
                }
            }

            // 3. 예외 처리 알림
            if (hasPastDateError)
            {
                MessageBox.Show("과거 내원 이력은 수정하거나 저장할 수 없습니다.\n(금일 접수건만 저장되었습니다.)",
                                "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (saveList.Count == 0)
            {
                MessageBox.Show("저장할 데이터가 없습니다.\n저장할 항목의 '선택' 체크박스를 체크해주세요.");
                return;
            }

            // 4. 서비스 호출 (저장 실행)
            try
            {
                MeasureService service = new MeasureService();
                bool isSuccess = service.SaveMeasureResults(saveList);

                if (isSuccess)
                {
                    MessageBox.Show("성공적으로 저장되었습니다.");

                    // [중요] 저장 후 그리드를 새로고침해서 최신 상태로 보여줌
                    // 저장한 데이터 중 첫 번째 접수번호로 재조회
                    string targetAcptNo = saveList[0].AcptNo;
                    LoadRightGrid(targetAcptNo);
                }
                else
                {
                    MessageBox.Show("저장에 실패했습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
        }

        private void dgvBodyMeasure_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // 1. 현재 수정된 컬럼이 '신장(3번)' 또는 '체중(4번)'인지 확인
            int heightColIndex = 3;
            int weightColIndex = 4;
            int bmiColIndex = 5;

            DataGridViewRow currentRow = dgvBodyMeasure.Rows[e.RowIndex];

            if (e.ColumnIndex == heightColIndex || e.ColumnIndex == weightColIndex)
            {
                // 2. 현재 행(Row) 가져오기
                DataGridViewRow row = dgvBodyMeasure.Rows[e.RowIndex];

                // 3. 신장, 체중 값 가져오기 (값이 없으면 0으로 처리)
                string hStr = row.Cells[heightColIndex].Value?.ToString();
                string wStr = row.Cells[weightColIndex].Value?.ToString();

                double height = 0;
                double weight = 0;

                // 4. 숫자로 변환 (TryParse를 써서 에러 방지)
                bool hOk = double.TryParse(hStr, out height);
                bool wOk = double.TryParse(wStr, out weight);

                // 5. 둘 다 유효한 숫자이고, 신장이 0이 아닐 때만 계산
                if (hOk && wOk && height > 0 && weight > 0)
                {
                    // [공식] BMI = 체중(kg) / (신장(m) * 신장(m))
                    // 입력받은 신장은 보통 cm이므로 m로 변환 (/ 100.0)
                    double heightM = height / 100.0;
                    double bmi = weight / (heightM * heightM);

                    // 6. 소수점 1자리로 반올림하여 BMI 셀에 값 넣기
                    row.Cells[bmiColIndex].Value = Math.Round(bmi, 1).ToString();
                }
                else
                {
                    // 값이 이상하거나 지워졌으면 BMI도 초기화
                    row.Cells[bmiColIndex].Value = "";
                }
            }
            if (e.RowIndex < dgvBodyMeasure.Rows.Count - 1)
            {
                // 바로 아랫줄(Index + 1)이 직전 과거 데이터입니다.
                DataGridViewRow pastRow = dgvBodyMeasure.Rows[e.RowIndex + 1];

                // -----------------------------------------------------
                // [신장 비교] 차이 2cm 이상 체크
                // -----------------------------------------------------
                if (e.ColumnIndex == heightColIndex)
                {
                    string currValStr = currentRow.Cells[heightColIndex].Value?.ToString();
                    string pastValStr = pastRow.Cells[heightColIndex].Value?.ToString();

                    if (double.TryParse(currValStr, out double currHeight) &&
                        double.TryParse(pastValStr, out double pastHeight))
                    {
                        // Math.Abs: 절댓값 (키가 컸거나 작아졌거나 모두 포함)
                        if (Math.Abs(currHeight - pastHeight) >= 2.0)
                        {
                            MessageBox.Show($"신장이 2cm 이상 차이납니다.\n(현재: {currHeight}, 과거: {pastHeight})",
                                            "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

                // -----------------------------------------------------
                // [체중 비교] 차이 5kg 이상 체크
                // -----------------------------------------------------
                if (e.ColumnIndex == weightColIndex)
                {
                    string currValStr = currentRow.Cells[weightColIndex].Value?.ToString();
                    string pastValStr = pastRow.Cells[weightColIndex].Value?.ToString();

                    if (double.TryParse(currValStr, out double currWeight) &&
                        double.TryParse(pastValStr, out double pastWeight))
                    {
                        // Math.Abs: 절댓값 (살이 쪘거나 빠졌거나 모두 포함)
                        if (Math.Abs(currWeight - pastWeight) >= 5.0)
                        {
                            MessageBox.Show($"몸무게 5kg 이상 차이납니다.\n(현재: {currWeight}, 과거: {pastWeight})",
                                            "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
         }
    }
}
