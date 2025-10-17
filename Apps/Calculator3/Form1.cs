using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator3
{
    // Form1 클래스 내부의 Operators Enum 정의를 사용합니다.
    public partial class Form1 : Form
    {
        // 중복 정의 제거 및 private로 변경 (필요하다면 public으로 유지 가능)
        private enum Operators
        {
            None,
            Add,
            Sub,
            Mul,
            Div,
            Result
        }

        Operators currentOperator = Operators.None;
        Boolean operatorChangeFlag = false;
        // Int32.Parse 사용을 고려하여 firstOperand를 int로 유지합니다.
        int firstOperand = 0;
        int secondOperand = 0;

        public Form1()
        {
            InitializeComponent();
            // 키보드 입력을 받기 위해 KeyPreview를 true로 설정해야 합니다. 
            this.KeyPreview = true;
        }


        // 1. 공통 숫자 입력 처리 로직 (HandleNumberInput)
        private void HandleNumberInput(string digit)
        {
            // 연산자 플래그 확인 동작 로직
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }

            string strNum = display.Text + digit; // += 대신 + 사용 후 결과를 strNum에 저장

            // Int32.Parse 대신 TryParse를 사용하여 입력된 값을 firstOperand에 저장하고,
            // 동시에 선행 0을 제거하는 역할도 수행합니다.
            if (int.TryParse(strNum, out int newNumValue))
            {
                display.Text = newNumValue.ToString();
                if (currentOperator == Operators.None)
                {
                    firstOperand = newNumValue; // 현재 입력 값을 firstOperand에 저장
                }
            }
            else
            {
                // Int32 범위를 초과하는 경우: 
                // 이 예제에서는 입력된 문자열 그대로 유지합니다. (실제 계산기에서는 예외 처리 필요)
                display.Text = strNum;
            }
        }


        // 2. 버튼 클릭 이벤트 핸들러 (HandleNumberInput 호출)
        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string digit = clickedButton.Text;

            HandleNumberInput(digit);
        }


        // 3. 키보드 입력 이벤트 핸들러 (HandleNumberInput 호출)

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            string digit = ""; // 키보드 입력이 발생했을 때 어떤 숫자 키가 눌렸는지 저장할 변수를 미리 선언하고 초기화 

            // 일반 숫자 키 (0-9)
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                digit = (e.KeyCode - Keys.D0).ToString();
                HandleNumberInput(digit);
                e.SuppressKeyPress = true;
            }
            // 숫자 패드 키 (NumPad 0-9)
            else if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                digit = (e.KeyCode - Keys.NumPad0).ToString();
                HandleNumberInput(digit);
                e.SuppressKeyPress = true;
            }
            // Enter 키를 누르면 결과 버튼 클릭과 동일하게 동작
            else if (e.KeyCode == Keys.Enter)
            {
                btnResult_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            // 기타 연산자 키 (+, -, *, /) 처리 (옵션)
            else if (e.KeyCode == Keys.Add || e.KeyCode == Keys.Oemplus)
            {
                btnPlus_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus)
            {
                btnSub_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                btnMul_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Divide)
            {
                btnDiv_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }


        private void HandleOperatorClick(Operators nextOperator)
        {
            // 1. 현재 화면의 숫자를 secondOperand에 저장합니다.
            // 이 로직은 첫 번째 연산자를 누른 후 두 번째 숫자를 입력할 때 실행됩니다.
            if (int.TryParse(display.Text, out secondOperand))
            {
                // 2. 이전에 저장된 연산자(currentOperator)가 있다면 계산을 수행합니다.
                if (currentOperator != Operators.None)
                {
                    int result = Calculate(firstOperand, secondOperand, currentOperator);
                    display.Text = result.ToString();
                    firstOperand = result; // 계산 결과를 다음 연산의 첫 번째 피연산자로 사용
                }
                else
                {
                    // 첫 번째 연산자 입력 시: firstOperand는 이미 HandleNumberInput에서 저장됨
                }
            }

            // 3. 새로운 연산자를 저장하고, 다음 숫자 입력을 위해 플래그 설정
            currentOperator = nextOperator;
            operatorChangeFlag = true;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            HandleOperatorClick(Operators.Add);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            HandleOperatorClick(Operators.Sub);
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            HandleOperatorClick(Operators.Mul);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            // 나눗셈은 0으로 나누는 경우를 대비해 Result 버튼에서 최종 확인하는 것이 일반적입니다.
            HandleOperatorClick(Operators.Div);
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            // 1. 현재 화면의 숫자를 두 번째 피연산자로 저장합니다.
            if (int.TryParse(display.Text, out secondOperand))
            {
                // 2. 이전에 저장된 연산자가 있어야만 계산을 수행합니다.
                if (currentOperator != Operators.None)
                {
                    int result = Calculate(firstOperand, secondOperand, currentOperator);
                    display.Text = result.ToString();
                    firstOperand = result; // 계산 결과를 다음 연산의 시작 값으로 사용
                }
            }

            // 3. 계산이 완료되었으므로 연산자 초기화 및 플래그 설정
            currentOperator = Operators.None; // 계산 후에는 다음 연산자가 들어올 때까지 대기
            operatorChangeFlag = true; // 계산 결과가 화면에 표시되므로, 다음 숫자 입력 시 화면을 지움
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            // 모든 상태 변수 초기화
            firstOperand = 0;
            secondOperand = 0;
            currentOperator = Operators.None;
            operatorChangeFlag = false;
            display.Text = "0"; // 화면을 0으로 초기화
        }

        // ----------------------------------------------------------------------
        // 5. 계산 수행 로직 (Calculate)
        // ----------------------------------------------------------------------

        private int Calculate(int a, int b, Operators op)
        {
            switch (op)
            {
                case Operators.Add:
                    return a + b;
                case Operators.Sub:
                    return a - b;
                case Operators.Mul:
                    return a * b;
                case Operators.Div:
                    // 0으로 나누는 경우 예외 처리
                    if (b == 0)
                    {
                        display.Text = "ERROR"; // 화면에 오류 메시지 표시
                        btnAC_Click(null, null); // 계산기 상태 초기화
                        return 0;
                    }
                    return a / b; // 정수 나눗셈
                default:
                    return b;
            }
        }
    }
}