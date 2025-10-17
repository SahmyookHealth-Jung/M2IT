using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreTracker
{
    public partial class Form1 : Form
    {
        enum Operators
        {
            Add,
            Substract,
            Reset
        }

        private int currentScore = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            currentScore++;                         // 상태 변경
            Score.Text = currentScore.ToString();           
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (currentScore > 0)
            {
                currentScore--;
                Score.Text = currentScore.ToString();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            currentScore = 0;
            Score.Text = "0";
        }
    }
}
