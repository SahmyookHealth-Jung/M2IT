using System;
using System.Data;
using System.Drawing; // Color 사용을 위해 추가
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewUnitConverter
{
    public partial class Form1 : Form
    {
        // 1. 상태 정의 및 상수
        private const decimal Mile_to_Km = 1.60934M;
        private const decimal Km_to_Mile = 0.621371M;
        private bool isMileInputMode = true; // true : mile 입력, false : km 입력 

        // 순환 호출 방지 플래그 (치명적인 오류 방지)
        private bool isChangingText = false;

        // UI 컨트롤 이름: txtMile, txtKm, btnChange, lblError

        public Form1()
        {
            InitializeComponent();

            txtKm.ReadOnly = true;
            UpdateInputModeUI();
        }

        // ----------------------------------------------------------------------
        // UI 업데이트 로직
        // ----------------------------------------------------------------------
        private void UpdateInputModeUI()
        {
            if (isMileInputMode)
            {
                txtMile.ReadOnly = false;
                txtKm.ReadOnly = true;

                btnChange.Text = "Mile → Km";
                btnChange.BackColor = Color.LightGreen;
            }
            else
            {
                txtMile.ReadOnly = true;
                txtKm.ReadOnly = false;

                btnChange.Text = "Km → Mile";
                btnChange.BackColor = Color.LightBlue;
            }
        }

        // 🚨 수정: btnChange_Click (C 대문자로 변경)
        private void btnChange_Click(object sender, EventArgs e)
        {
            isMileInputMode = !isMileInputMode;
            UpdateInputModeUI();

            // 모드 전환 후, 현재 활성화된 입력 필드의 값으로 변환을 다시 실행합니다.
            string currentInput = isMileInputMode ? txtMile.Text : txtKm.Text;
            ConvertValue(currentInput);
        }

        // ----------------------------------------------------------------------
        // TextChanged 이벤트 핸들러 (🚨 이름 수정: txtMile_TextChanged)
        // ----------------------------------------------------------------------
        private void txtMile_TextChanged(object sender, EventArgs e)
        {
            if (isChangingText) return;

            isMileInputMode = true;
            UpdateInputModeUI();

            ConvertValue(txtMile.Text);
        }

        // ----------------------------------------------------------------------
        // TextChanged 이벤트 핸들러 (🚨 이름 수정: txtKm_TextChanged)
        // ----------------------------------------------------------------------
        private void txtKm_TextChanged(object sender, EventArgs e)
        {
            if (isChangingText) return;

            isMileInputMode = false;
            UpdateInputModeUI();

            ConvertValue(txtKm.Text);
        }

        // ----------------------------------------------------------------------
        // 핵심 변환 로직
        // ----------------------------------------------------------------------
        private void ConvertValue(string input)
        {
            decimal inputValue;
            decimal result;

            if (decimal.TryParse(input, out inputValue))
            {
                // 성공: 오류 메시지 제거
                lblError.Text = string.Empty;

                // 🚨 순환 호출 방지 시작
                isChangingText = true;

                if (isMileInputMode)
                {
                    result = inputValue * Mile_to_Km;
                    txtKm.Text = result.ToString("N3");
                }
                else // Km -> Mile 모드
                {
                    result = inputValue * Km_to_Mile;
                    txtMile.Text = result.ToString("N3");
                }

                // ✅ 순환 호출 방지 해제
                isChangingText = false;
            }
            else // 유효성 검사 실패 시
            {
                // 오류 처리 로직
                lblError.Text = string.IsNullOrEmpty(input) ? string.Empty : "🚨 유효한 숫자만 입력해 주세요.";

                // 순환 방지 플래그를 사용하여 출력 필드 초기화
                isChangingText = true;

                if (isMileInputMode)
                {
                    txtKm.Text = string.Empty;
                }
                else
                {
                    txtMile.Text = string.Empty;
                }

                isChangingText = false;
            }
        }
    }
}
