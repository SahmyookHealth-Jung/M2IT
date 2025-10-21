using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 상태 정의 : 기억해야 할 핵심 데이터 
        /// decimal bmiResult; 라고만 작성해도 자동으로 0.0M이 할당된다.
        /// 코드를 읽는 사람에게 이 변수의 시작 값이 무엇인지 알려주기 위한 좋은 관례
        /// </summary> 
        private decimal bmiResult = 0.0M;
        private string classification = "데이터 없음";
        public Form1()
        {
            InitializeComponent();

            UpdateDisplay();
        }
        /// <summary>
        /// 이벤트 핸들러 : 키/체중이 입력이 바뀔 때마다 실행된다. (TextChanged에 연결됨)
        /// </summary>       
        private void Input_TextChanged(object sender, EventArgs e)
        {
            CalculatorBMI();    // 핵심 계산 함수 호출
        }
        // 핵심 계산 함수
        private void CalculatorBMI()
        {
            decimal weight, height;     // 계산이 끝나면 그 값이 필요없기 때문에 지역변수로 선언

            // 유효성 검사
            bool isHeightValid = decimal.TryParse(txtHeight.Text, out height);
            bool isWeightValid = decimal.TryParse(txtWeight.Text, out weight);

            if (isHeightValid && isWeightValid)
            {

                if (height <= 0M && weight <= 0M)
                {
                    bmiResult = 0.0M;
                    classification = "입력 오류";
                    UpdateDisplay();
                    return;
                }

                // 키(CM)를 미터(m)으로 변환 
                decimal heightInMeters = height / 100M;

                // bmi 계산 
                bmiResult = weight / (heightInMeters * heightInMeters);

                ClassifyBMI();
            }
            else if (!string.IsNullOrEmpty(txtHeight.Text) || !string.IsNullOrEmpty(txtWeight.Text))
            {
                bmiResult = 0.0M;
                classification = "오류";
            }
            else
            {
                bmiResult = 0.0M;
                classification = "데이터 없음";
            }

            UpdateDisplay();
        }    

        private void ClassifyBMI()
        {   
            if (bmiResult < 18.5M)
            {
               classification = "저체중";
            }
            else if (bmiResult < 23M)
            {
                classification = "정상";
            }
            else if (bmiResult < 25M)
            {
                classification = "과체중";
            }
            else
            {
                classification = "비만";
            }
        }
        private void UpdateDisplay()
        {
            lblBMIValue.Text = bmiResult.ToString("N2");
            lblResult.Text = classification;
        }
    }
}
