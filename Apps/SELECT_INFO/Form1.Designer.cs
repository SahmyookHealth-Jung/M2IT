namespace SELECT_INFO
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
            this.txtEmpolyeeId = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmpolyeeId
            // 
            this.txtEmpolyeeId.BackColor = System.Drawing.SystemColors.Info;
            this.txtEmpolyeeId.Location = new System.Drawing.Point(12, 25);
            this.txtEmpolyeeId.Name = "txtEmpolyeeId";
            this.txtEmpolyeeId.Size = new System.Drawing.Size(261, 25);
            this.txtEmpolyeeId.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtEmpolyeeId);
            this.panel1.Location = new System.Drawing.Point(67, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 77);
            this.panel1.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(315, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Controls.Add(this.lblDepartment);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Location = new System.Drawing.Point(67, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(437, 258);
            this.panel2.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(37, 65);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(334, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "이름";
            // 
            // lblDepartment
            // 
            this.lblDepartment.Location = new System.Drawing.Point(37, 111);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(334, 23);
            this.lblDepartment.TabIndex = 1;
            this.lblDepartment.Text = "부서";
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(37, 159);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(334, 23);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "오류";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmpolyeeId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblName;
    }
}

