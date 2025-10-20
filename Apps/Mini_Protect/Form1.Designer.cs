namespace Mini_Protect
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_1 = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btn_3 = new System.Windows.Forms.Button();
            this.lbl3Output = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(24, 25);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(160, 34);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "문제 1번 버튼";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(24, 88);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(138, 25);
            this.txt.TabIndex = 1;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(184, 88);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(94, 33);
            this.btn_send.TabIndex = 2;
            this.btn_send.Text = "전달";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.Location = new System.Drawing.Point(307, 91);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(213, 33);
            this.lblOutput.TabIndex = 3;
            this.lblOutput.Text = "문제 2번 입니다.";
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(24, 162);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(160, 45);
            this.btn_3.TabIndex = 4;
            this.btn_3.Text = "문제 3번";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // lbl3Output
            // 
            this.lbl3Output.Location = new System.Drawing.Point(307, 162);
            this.lbl3Output.Name = "lbl3Output";
            this.lbl3Output.Size = new System.Drawing.Size(136, 45);
            this.lbl3Output.TabIndex = 5;
            this.lbl3Output.Text = "문제 3번";
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(24, 265);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 23);
            this.btnPlus.TabIndex = 6;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(133, 265);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 23);
            this.btnMinus.TabIndex = 7;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(307, 273);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(15, 15);
            this.lblCount.TabIndex = 8;
            this.lblCount.Text = "0";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(24, 349);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 25);
            this.txt1.TabIndex = 9;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(222, 349);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 25);
            this.txt2.TabIndex = 10;
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(556, 349);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(100, 25);
            this.txt6.TabIndex = 11;
            this.txt6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt6_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt6);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.lbl3Output);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.btn_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Label lbl3Output;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt6;
    }
}

