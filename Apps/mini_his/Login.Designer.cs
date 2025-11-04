namespace mini_his
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPWD = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblPWD = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Login = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(516, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 500);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(26, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 440);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtPWD);
            this.panel4.Controls.Add(this.txtID);
            this.panel4.Controls.Add(this.lblPWD);
            this.panel4.Controls.Add(this.lblID);
            this.panel4.Location = new System.Drawing.Point(14, 17);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(369, 282);
            this.panel4.TabIndex = 1;
            // 
            // txtPWD
            // 
            this.txtPWD.Location = new System.Drawing.Point(20, 184);
            this.txtPWD.Name = "txtPWD";
            this.txtPWD.Size = new System.Drawing.Size(264, 25);
            this.txtPWD.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(20, 79);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(264, 25);
            this.txtID.TabIndex = 2;
            // 
            // lblPWD
            // 
            this.lblPWD.Font = new System.Drawing.Font("굴림", 15F);
            this.lblPWD.Location = new System.Drawing.Point(15, 136);
            this.lblPWD.Name = "lblPWD";
            this.lblPWD.Size = new System.Drawing.Size(152, 31);
            this.lblPWD.TabIndex = 1;
            this.lblPWD.Text = "PASSWORD";
            // 
            // lblID
            // 
            this.lblID.Font = new System.Drawing.Font("굴림", 15F);
            this.lblID.Location = new System.Drawing.Point(15, 45);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(105, 31);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_Login);
            this.panel3.Location = new System.Drawing.Point(14, 321);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(370, 98);
            this.panel3.TabIndex = 0;
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("굴림", 15F);
            this.btn_Login.Location = new System.Drawing.Point(20, 21);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(330, 55);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "로그인";
            this.btn_Login.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 703);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtPWD;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblPWD;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Login;
    }
}