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

namespace NewCtoF
{
    public partial class Form1 : Form
    {
        // 상태 정의
        private const decimal C_to_F_Factor = 1.8M;
        private const decimal C_to_F_Offset = 32M;
        private const decimal F_to_C_Factor = 1M / 1.8M;

        private bool isCInputMode = true; // true : C 입력 false : F 입력

        private bool isChangingText = false;

        public Form1()
        {
            InitializeComponent();
            txtF.ReadOnly = true;
            UpdateInputModeUI();
        }

        private void UpdateInputModeUI()
        {
            if (isCInputMode)
            {
                txtF.ReadOnly = true;
                txtC.ReadOnly = false;

                btnChange.Text = "C to F";
                btnChange.BackColor = Color.White;
            }
            else
            {
                txtC.ReadOnly = true;
                txtF.ReadOnly = false;

                btnChange.Text = "F to C";
                btnChange.BackColor = Color.LightBlue;
            }
        }

        private void ConvertCtoF(string input)
        {
            decimal inputValue;
            decimal result;
           
            if (decimal.TryParse(input, out inputValue))
            {
                isChangingText = true;

                if (isCInputMode)
                {
                    result = inputValue * C_to_F_Factor + C_to_F_Offset;
                    txtF.Text = result.ToString("N1");
                }
                else
                {
                   
                    result = (inputValue - C_to_F_Offset) * F_to_C_Factor;
                    txtC.Text = result.ToString("N1");
                   
                }

                isChangingText = false;
            }
        }
        private void txtC_TextChanged(object sender, EventArgs e)
        {
            if (isChangingText) return; // 순환 호출 방지 

            isCInputMode = true;
          
            ConvertCtoF(txtC.Text);
        }

        private void txtF_TextChanged(object sender, EventArgs e)
        {
            isCInputMode = false;
                      
            ConvertCtoF(txtF.Text);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            isCInputMode = !isCInputMode; 
            UpdateInputModeUI();

            string currentInput = isCInputMode ? txtC.Text : txtF.Text;
            ConvertCtoF(currentInput);
        }

    }
}
