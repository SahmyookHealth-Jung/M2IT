using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitConverter
{
    public partial class Form1 : Form
    {
        private const decimal Mile_To_Km_Factor = 1.60934M;
        private decimal inputValue = 0.0M;

        public Form1()
        {
            InitializeComponent();
        }
        private void txtMileInput_TextChanged(object sender, EventArgs e)
        {
            ConvertValue(txtMileInput.Text);
        }
        private void ConvertValue(string input)
        {
            if (decimal.TryParse(input, out inputValue))
            {
                // 유효한 숫자일 경우: 계산 수행
                Error.Text = string.Empty;
                decimal resultKm = inputValue * Mile_To_Km_Factor;
                txtKmOutput.Text = resultKm.ToString("N2");
            }
            else
            {
                if (string.IsNullOrEmpty(input))
                {
                    Error.Text = string.Empty;
                }
                else
                {
                    Error.Text = "유효한 숫자만 입력해주세요";
                }
                txtKmOutput.Text = string.Empty;
                inputValue = 0.0M;
            }
        }
    }
}
