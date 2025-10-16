namespace NumberGame2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Game = new Label();
            textBox = new TextBox();
            btnInput = new Button();
            btnStart = new Button();
            display2 = new Label();
            display = new Label();
            displayHint = new Label();
            SuspendLayout();
            // 
            // Game
            // 
            Game.AutoSize = true;
            Game.Font = new Font("맑은 고딕", 20F);
            Game.Location = new Point(188, 9);
            Game.Name = "Game";
            Game.Size = new Size(416, 46);
            Game.TabIndex = 0;
            Game.Text = "숫자 맞추기 게임 응용.ver";
            Game.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox
            // 
            textBox.Font = new Font("맑은 고딕", 20F);
            textBox.Location = new Point(75, 126);
            textBox.Name = "textBox";
            textBox.Size = new Size(400, 52);
            textBox.TabIndex = 1;
            // 
            // btnInput
            // 
            btnInput.Font = new Font("맑은 고딕", 20F);
            btnInput.Location = new Point(553, 126);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(180, 52);
            btnInput.TabIndex = 2;
            btnInput.Text = "입력";
            btnInput.UseVisualStyleBackColor = true;
            btnInput.Click += btnInput_Click;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("맑은 고딕", 20F);
            btnStart.Location = new Point(75, 209);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(658, 55);
            btnStart.TabIndex = 3;
            btnStart.Text = "Game Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // display2
            // 
            display2.AutoSize = true;
            display2.Location = new Point(73, 316);
            display2.Name = "display2";
            display2.Size = new Size(0, 20);
            display2.TabIndex = 4;
            // 
            // display
            // 
            display.AutoSize = true;
            display.Font = new Font("맑은 고딕", 15F);
            display.Location = new Point(289, 77);
            display.Name = "display";
            display.Size = new Size(229, 35);
            display.TabIndex = 5;
            display.Text = "게임을 시작합니다.";
            // 
            // displayHint
            // 
            displayHint.AutoSize = true;
            displayHint.Font = new Font("맑은 고딕", 20F);
            displayHint.Location = new Point(289, 333);
            displayHint.Name = "displayHint";
            displayHint.Size = new Size(242, 46);
            displayHint.TabIndex = 6;
            displayHint.Text = "UP OR DOWN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(displayHint);
            Controls.Add(display);
            Controls.Add(display2);
            Controls.Add(btnStart);
            Controls.Add(btnInput);
            Controls.Add(textBox);
            Controls.Add(Game);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Game;
        private TextBox textBox;
        private Button btnInput;
        private Button btnStart;
        private Label display2;
        private Label display;
        private Label displayHint;
    }
}
