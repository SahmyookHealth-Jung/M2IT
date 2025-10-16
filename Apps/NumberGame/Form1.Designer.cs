namespace NumberGame
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
            display = new Label();
            textBox = new TextBox();
            btnInput = new Button();
            btnStart = new Button();
            SuspendLayout();
            // 
            // display
            // 
            display.AutoSize = true;
            display.Font = new Font("맑은 고딕", 20F);
            display.Location = new Point(253, 9);
            display.Name = "display";
            display.Size = new Size(282, 46);
            display.TabIndex = 0;
            display.Text = "숫자 맞추기 게임";
            display.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox
            // 
            textBox.Font = new Font("맑은 고딕", 20F);
            textBox.Location = new Point(111, 142);
            textBox.Name = "textBox";
            textBox.Size = new Size(287, 52);
            textBox.TabIndex = 1;
            // 
            // btnInput
            // 
            btnInput.Font = new Font("맑은 고딕", 20F);
            btnInput.Location = new Point(441, 141);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(221, 52);
            btnInput.TabIndex = 2;
            btnInput.Text = "입력";
            btnInput.UseVisualStyleBackColor = true;
            btnInput.Click += btnInput_Click;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("맑은 고딕", 20F);
            btnStart.Location = new Point(111, 234);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(551, 52);
            btnStart.TabIndex = 3;
            btnStart.Text = "게임 시작";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStart);
            Controls.Add(btnInput);
            Controls.Add(textBox);
            Controls.Add(display);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label display;
        private TextBox textBox;
        private Button btnInput;
        private Button btnStart;
    }
}
