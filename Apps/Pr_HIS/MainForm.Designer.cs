namespace Pr_HIS
{
    partial class MainForm
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
            this.btnCheckupView = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCheckupView
            // 
            this.btnCheckupView.Font = new System.Drawing.Font("굴림", 13F);
            this.btnCheckupView.Location = new System.Drawing.Point(118, 68);
            this.btnCheckupView.Name = "btnCheckupView";
            this.btnCheckupView.Size = new System.Drawing.Size(257, 86);
            this.btnCheckupView.TabIndex = 0;
            this.btnCheckupView.Text = "1.검진 조회/관리";
            this.btnCheckupView.UseVisualStyleBackColor = true;
            this.btnCheckupView.Click += new System.EventHandler(this.btnCheckupView_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("굴림", 13F);
            this.btnRegister.Location = new System.Drawing.Point(118, 182);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(257, 86);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "2. 새 환자 등록";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("굴림", 13F);
            this.btnModify.Location = new System.Drawing.Point(118, 298);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(257, 86);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "3. 상태 수정/삭제";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnCheckupView);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCheckupView;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnModify;
    }
}

