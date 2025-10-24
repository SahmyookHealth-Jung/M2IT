namespace NEW_INFO
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
            this.txtNewChartNo = new System.Windows.Forms.TextBox();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpCheckupDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNewChartNo
            // 
            this.txtNewChartNo.Location = new System.Drawing.Point(192, 33);
            this.txtNewChartNo.Name = "txtNewChartNo";
            this.txtNewChartNo.Size = new System.Drawing.Size(168, 25);
            this.txtNewChartNo.TabIndex = 0;
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(192, 87);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(168, 25);
            this.txtNewName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 15F);
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "차트 번호 :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("굴림", 15F);
            this.label2.Location = new System.Drawing.Point(15, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "환자 이름 :";
            // 
            // dtpCheckupDate
            // 
            this.dtpCheckupDate.Location = new System.Drawing.Point(192, 150);
            this.dtpCheckupDate.Name = "dtpCheckupDate";
            this.dtpCheckupDate.Size = new System.Drawing.Size(200, 25);
            this.dtpCheckupDate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("굴림", 15F);
            this.label3.Location = new System.Drawing.Point(15, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "검진 날짜 :";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("굴림", 15F);
            this.label4.Location = new System.Drawing.Point(15, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "상태 선택 :";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "검사 대기",
            "결과 대기",
            "완료"});
            this.cmbStatus.Location = new System.Drawing.Point(192, 216);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 23);
            this.cmbStatus.TabIndex = 7;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(317, 295);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "등록";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.txtNewChartNo);
            this.panel1.Controls.Add(this.cmbStatus);
            this.panel1.Controls.Add(this.txtNewName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpCheckupDate);
            this.panel1.Location = new System.Drawing.Point(41, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 349);
            this.panel1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewChartNo;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpCheckupDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Panel panel1;
    }
}

