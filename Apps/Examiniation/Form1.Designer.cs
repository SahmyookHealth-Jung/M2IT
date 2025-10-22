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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColChartNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCheckupDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCheckupStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.txtSearchName.Location = new System.Drawing.Point(215, 16);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(485, 36);
            this.txtSearchName.TabIndex = 1;
            this.txtSearchName.TextChanged += new System.EventHandler(this.FilterPatients);
            // 
            // dgvPatients
            // 
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColName,
            this.ColChartNumber,
            this.ColCheckupDate,
            this.ColCheckupStatus});
            this.dgvPatients.Location = new System.Drawing.Point(47, 113);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.RowHeadersWidth = 51;
            this.dgvPatients.RowTemplate.Height = 27;
            this.dgvPatients.Size = new System.Drawing.Size(715, 213);
            this.dgvPatients.TabIndex = 2;
            // 
            // ColName
            // 
            this.ColName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColName.DataPropertyName = "Name";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ColName.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColName.HeaderText = "환자명";
            this.ColName.MinimumWidth = 6;
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            // 
            // ColChartNumber
            // 
            this.ColChartNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColChartNumber.DataPropertyName = "ChartNumber";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColChartNumber.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColChartNumber.HeaderText = "차트 번호";
            this.ColChartNumber.MinimumWidth = 6;
            this.ColChartNumber.Name = "ColChartNumber";
            this.ColChartNumber.ReadOnly = true;
            this.ColChartNumber.Width = 101;
            // 
            // ColCheckupDate
            // 
            this.ColCheckupDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColCheckupDate.DataPropertyName = "CheckupDate";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColCheckupDate.DefaultCellStyle = dataGridViewCellStyle7;
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColCheckupStatus.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColCheckupStatus.HeaderText = "상태";
            this.ColCheckupStatus.MinimumWidth = 6;
            this.ColCheckupStatus.Name = "ColCheckupStatus";
            this.ColCheckupStatus.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Controls.Add(this.txtSearchName);
            this.panel1.Location = new System.Drawing.Point(48, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 62);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvPatients);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColChartNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCheckupDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCheckupStatus;
    }
}

