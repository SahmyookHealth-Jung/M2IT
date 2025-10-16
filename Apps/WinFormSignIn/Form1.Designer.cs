namespace WinFormSignIn
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
            label1 = new Label();
            id = new TextBox();
            pwd = new TextBox();
            loginbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 20F);
            label1.Location = new Point(305, 67);
            label1.Name = "label1";
            label1.Size = new Size(168, 46);
            label1.TabIndex = 0;
            label1.Text = "로그인 창";
            // 
            // id
            // 
            id.Font = new Font("맑은 고딕", 20F);
            id.Location = new Point(204, 166);
            id.Name = "id";
            id.Size = new Size(369, 52);
            id.TabIndex = 1;
            id.Text = "아이디";
            // 
            // pwd
            // 
            pwd.Font = new Font("맑은 고딕", 20F);
            pwd.Location = new Point(204, 269);
            pwd.Name = "pwd";
            pwd.PasswordChar = '*';
            pwd.Size = new Size(369, 52);
            pwd.TabIndex = 2;
            pwd.Text = "비밀번호";
            pwd.UseSystemPasswordChar = true;
            // 
            // loginbtn
            // 
            loginbtn.Location = new Point(305, 360);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(168, 29);
            loginbtn.TabIndex = 3;
            loginbtn.Text = "로그인";
            loginbtn.UseVisualStyleBackColor = true;
            loginbtn.Click += loginbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loginbtn);
            Controls.Add(pwd);
            Controls.Add(id);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox id;
        private TextBox pwd;
        private Button loginbtn;
    }
}
