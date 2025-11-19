namespace Word_List
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvGrid = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 86);
            this.panel1.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("굴림", 20F);
            this.btnSelect.Location = new System.Drawing.Point(761, 23);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(113, 46);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "조회";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("굴림", 20F);
            this.txtSearch.Location = new System.Drawing.Point(182, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(495, 46);
            this.txtSearch.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20F);
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "검색어 :";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.txtDesc);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtCode);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 513);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1082, 151);
            this.panel2.TabIndex = 1;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("굴림", 12F);
            this.btnReset.Location = new System.Drawing.Point(956, 49);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(113, 46);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "초기화";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("굴림", 12F);
            this.btnSave.Location = new System.Drawing.Point(718, 49);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 46);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("굴림", 12F);
            this.btnDelete.Location = new System.Drawing.Point(837, 49);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 46);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("굴림", 12F);
            this.txtDesc.Location = new System.Drawing.Point(396, 80);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(228, 58);
            this.txtDesc.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F);
            this.label5.Location = new System.Drawing.Point(329, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "설명:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("굴림", 12F);
            this.txtName.Location = new System.Drawing.Point(127, 96);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(176, 30);
            this.txtName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F);
            this.label4.Location = new System.Drawing.Point(18, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "전체 명칭:";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("굴림", 12F);
            this.txtCode.Location = new System.Drawing.Point(396, 28);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(228, 30);
            this.txtCode.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F);
            this.label3.Location = new System.Drawing.Point(283, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "용어 코드:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F);
            this.label2.Location = new System.Drawing.Point(18, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("굴림", 12F);
            this.txtId.Location = new System.Drawing.Point(64, 27);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(171, 30);
            this.txtId.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgvGrid);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1082, 427);
            this.panel3.TabIndex = 2;
            // 
            // dgvGrid
            // 
            this.dgvGrid.CausesValidation = false;
            this.dgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colCode,
            this.colName,
            this.colDesc});
            this.dgvGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGrid.Location = new System.Drawing.Point(0, 0);
            this.dgvGrid.MultiSelect = false;
            this.dgvGrid.Name = "dgvGrid";
            this.dgvGrid.RowHeadersWidth = 51;
            this.dgvGrid.RowTemplate.Height = 27;
            this.dgvGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrid.Size = new System.Drawing.Size(1080, 425);
            this.dgvGrid.TabIndex = 0;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.Visible = false;
            this.colId.Width = 125;
            // 
            // colCode
            // 
            this.colCode.DataPropertyName = "TermCode";
            this.colCode.HeaderText = "용어코드";
            this.colCode.MinimumWidth = 6;
            this.colCode.Name = "colCode";
            this.colCode.Width = 125;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "FullName";
            this.colName.HeaderText = "전체명칭";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.Width = 150;
            // 
            // colDesc
            // 
            this.colDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDesc.DataPropertyName = "Description";
            this.colDesc.HeaderText = "설명";
            this.colDesc.MinimumWidth = 6;
            this.colDesc.Name = "colDesc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 664);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView dgvGrid;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesc;
    }
}

