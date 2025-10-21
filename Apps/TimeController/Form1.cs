using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeController
{
    public partial class Form1 : Form
    {
        private DateTime currentTime;
        public Form1()
        {
            InitializeComponent();

            // 앱이 시작할 때 초기 시간으로 상태를 설정
            currentTime = DateTime.Now;
            clockTimer.Interval = 1000;
            clockTimer.Start();

            UpdateDisplay();
        }

        private void UpdateDisplay()
        {          
            {
                // 시간 형식 지정 
                lblDigitalClock.Text = currentTime.ToString("HH:mm:ss");
            }
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            // 시스템의 현재시간을 가져와 상태 업데이트
            currentTime = DateTime.Now; 

            UpdateDisplay();
        }
    }
}
