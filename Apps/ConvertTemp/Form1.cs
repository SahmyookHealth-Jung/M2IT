using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertTemp
{
    public partial class Form1 : Form
    {
        // 상태 정의 
        private const decimal C_To_F_Factor = 1.8M;
        private const decimal C_To_F_Offset = 32.0M;

        public Form1()
        {
            InitializeComponent();
        }

        private void ConvertValue(string input)
        {
            decimal celsius;

            if (decimal.TryParse(input, out celsius))
            {
                decimal fa = celsius * C_To_F_Factor + C_To_F_Offset;
                txtFa.Text = fa.ToString();
            }
        }
        private void txtCelsius_TextChanged(object sender, EventArgs e)
        {
            ConvertValue(txtCelsius.Text);
        }
    }
}
