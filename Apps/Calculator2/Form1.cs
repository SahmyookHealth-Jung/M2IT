using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 텍스트 박스2를 여러 줄, 스크롤 가능하게 설정하여 많은 이벤트 정보를 볼 수 있게 함
            textBox2.Multiline = true;
            textBox2.ScrollBars = ScrollBars.Both;

            // setup events that listens on keypress
            // textbox1에 이벤트 핸돌러(메서드) 연결
            textBox1.KeyDown += TextBox1_KeyDown;
            textBox1.KeyPress += TextBox1_KeyPress;
            textBox1.KeyUp += TextBox1_KeyUp;

        }


        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            textBox2.AppendText($"KeyUp code: {e.KeyCode}, value: {e.KeyValue}, modifiers: {e.Modifiers}" + "\r\n");
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            textBox2.AppendText($"KeyDown code: {e.KeyCode}, value: {e.KeyValue}, modifiers: {e.Modifiers}" + "\r\n");
            display.Text = textBox1.Text;
        }
        

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox2.AppendText($"KeyPress keychar: {e.KeyChar}" + "\r\n");
        }
    }
}
