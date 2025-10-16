namespace NumberGame2
{
    public partial class Form1 : Form
    {
        private int findNumber = 0;
        private int chance = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            int inputNubmer = Int32.Parse(textBox.Text);

            if (inputNubmer == findNumber)
            {
                display.Text = "성공했습니다.";
            }
            else if (inputNubmer > findNumber)
            {
                chance--;
                display.Text = "기회는 " + chance + "번 남았습니다.";
                displayHint.Text = "DOWN!!";
            }
            else if (inputNubmer < findNumber)
            {
                chance--;
                display.Text = "기회는 " + chance + "번 남았습니다.";
                displayHint.Text = "UP!!";
            }

            if (chance <= 0)
            {
                display.Text = "실패하셨습니다.";
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            findNumber = rand.Next(1, 21);
            chance = 5;
            display.Text = "맞출 숫자를 입력하시오.";
        }
    }
}
