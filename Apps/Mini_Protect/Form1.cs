using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Protect
{
    public partial class Form1 : Form
    {
        // 문제 1번
        private bool isButtonClicked = true;
        // 문제 3번
        private bool isChecked = false;
        // 문제 4번
        private bool isButtonPressed = true; // true : plus false : minus

        // 문제 5번
        private const decimal a = 1.5M;
        private decimal inputValue = 0.0M;

        public Form1()
        {
            InitializeComponent();
        }
        // 문제 1번
        private void btn_1_Click(object sender, EventArgs e)
        {
            if (isButtonClicked)
            {
                MessageBox.Show("안녕하세요");
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            lblOutput.Text = txt.Text;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            isChecked = !isChecked;

            if (isChecked)
            {
                lbl3Output.Text = "상태 : 켜짐";
            }
            else
            {
                lbl3Output.Text = "상태 : 꺼짐";
            }
        }
        private int countValue = 0;
        private void btnPlus_Click(object sender, EventArgs e)
        {
            countValue++;
            lblCount.Text = countValue.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            countValue--;
            lblCount.Text = countValue.ToString();
        }

        // 문제 5번 
        private void Convert(string input)
        {
            if (decimal.TryParse(input, out inputValue))
            {
                decimal result = inputValue * a;
                txt2.Text = result.ToString();
            }
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            Convert(txt1.Text);
        }

        // 문제 6번 
        private void txt6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
