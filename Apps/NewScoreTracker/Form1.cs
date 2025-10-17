using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewScoreTracker
{
    public partial class Form1 : Form
    {
       
        private int homeScore = 0;
        private int awayScore = 0;
        private bool isHomeTeamSelected = true;

        public Form1()
        {
            InitializeComponent();
            UpdateScoreDisplay();
            UpdateTeamSelectionUI();
        }

        private void HandleScoreChange(int amount)
        {
        
            if (isHomeTeamSelected)
            {
                homeScore += amount;
                if (homeScore < 0) { homeScore = 0; }    
            }
            else
            {
                awayScore += amount;
                if ((awayScore < 0)) {  awayScore = 0; }
            }
            UpdateScoreDisplay();
        }
        private void btnScoreChange(object sender, EventArgs e)
        {   
            // sender를 Button 객체로 변환
            Button clickedButton = (Button)sender;
            // 버튼의 text 속성을 가져옴
            string textAmount = clickedButton.Text;

            // text에서 숫자만 추출하여 int로 변환 
            if (int.TryParse(textAmount, out int amount))
            {
                HandleScoreChange(amount);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            awayScore = 0;
            homeScore = 0;
            isHomeTeamSelected = true;

            UpdateScoreDisplay();
            UpdateTeamSelectionUI();
        }

        private void UpdateScoreDisplay()
        {
            HomeScore.Text = homeScore.ToString();
            AwayScore.Text = awayScore.ToString();
        }
        private void UpdateTeamSelectionUI()
        {
            if (isHomeTeamSelected)
            {
                btnHome.BackColor = Color.LightBlue;
                btnAway.BackColor = SystemColors.Control;
            }
            else
            {
                btnHome.BackColor = SystemColors.Control;
                btnAway.BackColor = Color.LightBlue;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            isHomeTeamSelected = true;
            UpdateTeamSelectionUI();
        }

        private void btnAway_Click(object sender, EventArgs e)
        {
            isHomeTeamSelected = false; 
            UpdateTeamSelectionUI();
        }
    }
}
