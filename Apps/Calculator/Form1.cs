using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        // 열거형 정의 
        // 현재 선택된 연산자의 종류를 나타내기 위한 열거형
        enum Operators
        {
            None,
            Add,
            Substract,
            Multiply,
            Divide,
            Result
        }

        // 현재 선택된 연산자를 저장하는 변수, 초기값은 None
        Operators currentOperator = Operators.None;

        // 연산자 버튼을 눌렀는지 여부를 나타내는 플래그
        // True 이면, 다음에 숫자 버튼을 누를 때 디스플레이를 초기화해야 함을 의미
        Boolean operatorChangeFlag = false;

        int firstOperand = 0;
        int secondOperand = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            // operatorChangeFlag 변수는 연산자가 눌렸음을 알 수 있는 변수 (연산자가 눌릴 시 true 값을 가짐)
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNum = display.Text += "1";
            int intNum = Int32.Parse(strNum);
            display.Text = intNum.ToString();
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNum = display.Text += "2";
            int intNum = Int32.Parse(strNum);
            display.Text = intNum.ToString();
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNum = display.Text += "3";
            int intNum = Int32.Parse(strNum);
            display.Text = intNum.ToString();
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNum = display.Text += "4";
            int intNum = Int32.Parse(strNum);
            display.Text = intNum.ToString();
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNum = display.Text += "5";
            int intNum = Int32.Parse(strNum);
            display.Text = intNum.ToString();
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNum = display.Text += "6";
            int intNum = Int32.Parse(strNum);
            display.Text = intNum.ToString();
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNum = display.Text += "7";
            int intNum = Int32.Parse(strNum);
            display.Text = intNum.ToString();
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNum = display.Text += "8";
            int intNum = Int32.Parse(strNum);
            display.Text = intNum.ToString();
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNum = display.Text += "9";
            int intNum = Int32.Parse(strNum);
            display.Text = intNum.ToString();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            secondOperand = Int32.Parse(display.Text);
            if (currentOperator == Operators.Add)
            {
                firstOperand += secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Substract)
            {
                firstOperand -= secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Multiply)
            {
                firstOperand *= secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Divide)
            {
                if (secondOperand == 0)
                {
                    display.Text = "0으로 나눌 수 없습니다.";
                }
                else
                {
                    firstOperand /= secondOperand;
                    display.Text = firstOperand.ToString();
                }
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            currentOperator = Operators.Add;
            operatorChangeFlag = true;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            /*
             * firstOperand 변수에 기존에 입력한 숫자를 저장한다. 
             * Int32.Parse 메소드를 통해 정수형으로 전환.
             * currentOperator에 - 버튼이 눌렸음을 알려주기 위해 Operators.substract 값을 저장
             * operatorChangeFlag 변수는 연산자가 눌릴때마다 true 값으로 설정해야 버튼을 누를때 출력된 값을 지우고 다시 숫자를 
             * 출력해야 하기 때문에 필요.
            */
            firstOperand = Int32.Parse(display.Text);
            currentOperator = Operators.Substract;
            operatorChangeFlag = true;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            currentOperator = Operators.Multiply;
            operatorChangeFlag = true;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            firstOperand =Int32.Parse(display.Text);
            currentOperator = Operators.Divide;
            operatorChangeFlag = true;
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            firstOperand = 0;
            secondOperand = 0;
            currentOperator = Operators.None;
            display.Text = "0";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "0";
                operatorChangeFlag = false;
            }
            string strNum = display.Text += "0";
            int intNum = Int32.Parse(strNum);
            display.Text = intNum.ToString();
        }
    }
}
