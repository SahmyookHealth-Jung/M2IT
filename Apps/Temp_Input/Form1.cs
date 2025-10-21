using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temp_Input
{
    public partial class Form1 : Form
    {
        // 체온의 정상 범위 상수
        private const decimal MIN_NORMAL = 35.0M;
        private const decimal MAX_NORMAL = 40.0M;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 실시간으로 체온 입력의 유효성을 검사하고 사용자에게 피드백 제공
        /// 숫자 형식, 소숫점 자릿수, 정상/위험 범위
        /// </summary>
        private void CheckTemperatureInput_TextChanged(object sender, EventArgs e)
        {
            decimal temp;
            string input = txtTemp.Text;
            //bool isTemperatureCorrect = decimal.TryParse(txtTemp.Text, out temp);

            // 숫자인지 유효성 검사
            if (!decimal.TryParse(input, out temp))
            {
                lblStatus.Text = "숫자 형식으로 입력해주세요";
                lblStatus.ForeColor = Color.Red;
                return;
            }

            // 소수점 검사
            if (input.Contains("."))
            {
                int decimalIndex = input.IndexOf(".");
                // 소수점 둘째 짜리 이상이면
                if (input.Length - 1 - decimalIndex > 1)
                {
                    lblStatus.Text = "소수점 첫째 자리까지만 입력해주세요.";
                    lblStatus.ForeColor = Color.Blue;
                    return;
                }
            }

            // 경계 조건 검사 
            if (temp < MIN_NORMAL)
            {
                lblStatus.Text = "저체온입니다";
                lblStatus.ForeColor = Color.Blue;
                return;
            }
            else if (temp > MAX_NORMAL)
            {
                lblStatus.Text = "고체온입니다.";
                lblStatus.ForeColor = Color.Red;
                return;
            }
            else
            {
                lblStatus.Text = "정상입니다";
                lblStatus.ForeColor = Color.Green;
                return;
            }
        }

        /// <summary>
        /// 저장 시 사용할 최종 유효성 검사 로직
        /// 실시간 피드백과 분리되어 순수한 데이터 무결성만 검사 (private bool)
        /// </summary>
        private bool IsInputValid(out decimal validTemp)
        {
            string input = txtTemp.Text;
            decimal temp;

            if (!decimal.TryParse(input, out temp))
            {
                validTemp = 0.0M;
                return false;
            }

            // 소숫점 두자리 검사
            if (input.Contains("."))
            {
                int decimalIndex = input.IndexOf(".");

                if (input.Length - 1 - decimalIndex > 1)
                {
                    validTemp = 0.0M;
                    return false;
                }
            }

            if (temp < 10.0M || temp > 50.0M)
            {
                validTemp = 0.0M;
                return false;
            }

            // 모든 검사 통과
            validTemp = temp;
            return true;
        }
    
        private void btnSave_Click(object sender, EventArgs e)
        {
            decimal finalTemp;

            if (IsInputValid(out finalTemp)) { 

                // 모든 검사를 통과하고 저장 가능한 값인 경우
                // 실제 병원 시스템에서는 DB에 Insert하는 코드가 들어갑니다.
                MessageBox.Show($"체온 {finalTemp.ToString("N1")}°C 가 성공적으로 저장되었습니다.", "저장 완료");
                Console.WriteLine($"[저장된 데이터] 체온: {finalTemp}°C");
                
                // UI 초기화
                txtTemp.Clear();
                lblStatus.Text = "입력 대기중";
                lblStatus.ForeColor = Color.Black;
            }
            else 
            {
                MessageBox.Show("입력된 체온 값이 유효하지 않거나 형식이 올바르지 않습니다. 다시 확인해주세요.", "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        }
    }

