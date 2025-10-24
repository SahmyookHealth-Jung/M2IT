namespace Examiniation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.dtpCheckupDate = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.txtNewChartNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbStatusUpdate = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChartNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCheckupDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCheckupStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.Font = new System.Drawing.Font("굴림", 15F);
            this.lblSearch.Location = new System.Drawing.Point(3, 15);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(163, 33);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "환자 검색 :";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSearchName
            // 
            this.txtSearchName.Font = new System.Drawing.Font("굴림", 15F);
            this.txtSearchName.Location = new System.Drawing.Point(185, 16);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(355, 36);
            this.txtSearchName.TabIndex = 1;
            this.txtSearchName.TextChanged += new System.EventHandler(this.FilterPatients);
            // 
            // dgvPatients
            // 
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColName,
            this.ChartNumber,
            this.ColCheckupDate,
            this.ColCheckupStatus});
            this.dgvPatients.Location = new System.Drawing.Point(23, 154);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.RowHeadersWidth = 51;
            this.dgvPatients.RowTemplate.Height = 27;
            this.dgvPatients.Size = new System.Drawing.Size(566, 213);
            this.dgvPatients.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Controls.Add(this.txtSearchName);
            this.panel1.Location = new System.Drawing.Point(24, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 62);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnRegister);
            this.panel2.Controls.Add(this.dtpCheckupDate);
            this.panel2.Controls.Add(this.cmbStatus);
            this.panel2.Controls.Add(this.txtNewName);
            this.panel2.Controls.Add(this.txtNewChartNo);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(727, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(494, 457);
            this.panel2.TabIndex = 4;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("굴림", 15F);
            this.btnRegister.Location = new System.Drawing.Point(374, 385);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 34);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "등록";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // dtpCheckupDate
            // 
            this.dtpCheckupDate.Location = new System.Drawing.Point(223, 304);
            this.dtpCheckupDate.Name = "dtpCheckupDate";
            this.dtpCheckupDate.Size = new System.Drawing.Size(226, 25);
            this.dtpCheckupDate.TabIndex = 8;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "검사 대기",
            "결과 대기",
            "완료",
            "예약"});
            this.cmbStatus.Location = new System.Drawing.Point(223, 227);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(226, 23);
            this.cmbStatus.TabIndex = 7;
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(223, 154);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(226, 25);
            this.txtNewName.TabIndex = 6;
            // 
            // txtNewChartNo
            // 
            this.txtNewChartNo.Location = new System.Drawing.Point(223, 84);
            this.txtNewChartNo.Name = "txtNewChartNo";
            this.txtNewChartNo.Size = new System.Drawing.Size(226, 25);
            this.txtNewChartNo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("굴림", 14F);
            this.label5.Location = new System.Drawing.Point(34, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "검진 날짜 :";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("굴림", 14F);
            this.label4.Location = new System.Drawing.Point(34, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "상태 선택 :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("굴림", 14F);
            this.label3.Location = new System.Drawing.Point(34, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "환자 이름 :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("굴림", 14F);
            this.label2.Location = new System.Drawing.Point(34, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "차트 번호 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20F);
            this.label1.Location = new System.Drawing.Point(119, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "신규 환자 등록";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.dgvPatients);
            this.panel3.Location = new System.Drawing.Point(12, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(615, 457);
            this.panel3.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 20F);
            this.label6.Location = new System.Drawing.Point(169, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 34);
            this.label6.TabIndex = 10;
            this.label6.Text = "내원 환자 조회";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbStatusUpdate
            // 
            this.cmbStatusUpdate.FormattingEnabled = true;
            this.cmbStatusUpdate.Items.AddRange(new object[] {
            "검사 대기",
            "결과 대기",
            "완료",
            "예약"});
            this.cmbStatusUpdate.Location = new System.Drawing.Point(186, 11);
            this.cmbStatusUpdate.Name = "cmbStatusUpdate";
            this.cmbStatusUpdate.Size = new System.Drawing.Size(142, 23);
            this.cmbStatusUpdate.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("굴림", 14F);
            this.label7.Location = new System.Drawing.Point(29, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "상태 수정 :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.Font = new System.Drawing.Font("굴림", 12F);
            this.btnUpdateStatus.Location = new System.Drawing.Point(378, 5);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(75, 34);
            this.btnUpdateStatus.TabIndex = 10;
            this.btnUpdateStatus.Text = "수정";
            this.btnUpdateStatus.UseVisualStyleBackColor = true;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnUpdateStatus);
            this.panel4.Controls.Add(this.cmbStatusUpdate);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(23, 385);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(566, 51);
            this.panel4.TabIndex = 13;
            // 
            // ColName
            // 
            this.ColName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColName.DataPropertyName = "Name";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ColName.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColName.HeaderText = "환자명";
            this.ColName.MinimumWidth = 6;
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            // 
            // ChartNumber
            // 
            this.ChartNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ChartNumber.DataPropertyName = "ChartNumber";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ChartNumber.DefaultCellStyle = dataGridViewCellStyle2;
            this.ChartNumber.HeaderText = "차트 번호";
            this.ChartNumber.MinimumWidth = 6;
            this.ChartNumber.Name = "ChartNumber";
            this.ChartNumber.ReadOnly = true;
            this.ChartNumber.Width = 101;
            // 
            // ColCheckupDate
            // 
            this.ColCheckupDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColCheckupDate.DataPropertyName = "CheckupDate";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColCheckupDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColCheckupDate.HeaderText = "검진 날짜";
            this.ColCheckupDate.MinimumWidth = 6;
            this.ColCheckupDate.Name = "ColCheckupDate";
            this.ColCheckupDate.ReadOnly = true;
            this.ColCheckupDate.Width = 101;
            // 
            // ColCheckupStatus
            // 
            this.ColCheckupStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColCheckupStatus.DataPropertyName = "CheckupStatus";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColCheckupStatus.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColCheckupStatus.HeaderText = "상태";
            this.ColCheckupStatus.MinimumWidth = 6;
            this.ColCheckupStatus.Name = "ColCheckupStatus";
            this.ColCheckupStatus.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 505);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.DateTimePicker dtpCheckupDate;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.TextBox txtNewChartNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.ComboBox cmbStatusUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChartNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCheckupDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCheckupStatus;
    }
}

