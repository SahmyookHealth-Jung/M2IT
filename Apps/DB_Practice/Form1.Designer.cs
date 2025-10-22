namespace DB_Practice
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(68, 75);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(384, 25);
            this.txtId.TabIndex = 0;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(553, 77);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(157, 23);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "입력";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(68, 141);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(384, 23);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "이름";
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(68, 190);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(384, 23);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "이메일";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
    }
}

