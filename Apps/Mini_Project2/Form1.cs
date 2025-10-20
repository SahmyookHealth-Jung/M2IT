using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Project2
{
    
    public partial class Form1 : Form
    {
        private bool isButtonClicked = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {   
            // 눌린 키가 엔터인지 확인
            if (e.KeyCode == Keys.Enter)
            {
                // 버튼의 클릭 이벤트를 강제로 실행
                btn.PerformClick();
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter키가 눌렸습니다.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isButtonClicked)
            {
                button1.BackColor = Color.White;
            }
            else
            {   
                button1.BackColor = Color.LightBlue;
            }
            // button1.BackColor = isButtonClicked ? Color.LightBlue : Color.White;
            // 다음 클릭을 위해 상태를 반전시킨다!! (중요)

            isButtonClicked = !isButtonClicked;
        }
    }
}
