namespace Medi
{
    partial class ReceptionForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvPatientList = new System.Windows.Forms.DataGridView();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpRegDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtBirth = new System.Windows.Forms.TextBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvExamList = new System.Windows.Forms.DataGridView();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelExam = new System.Windows.Forms.Button();
            this.btnAddExam = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientList)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamList)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvPatientList);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1232, 703);
            this.splitContainer1.SplitterDistance = 366;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvPatientList
            // 
            this.dgvPatientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientID,
            this.pName,
            this.BirthDate});
            this.dgvPatientList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPatientList.Location = new System.Drawing.Point(0, 125);
            this.dgvPatientList.MultiSelect = false;
            this.dgvPatientList.Name = "dgvPatientList";
            this.dgvPatientList.ReadOnly = true;
            this.dgvPatientList.RowHeadersVisible = false;
            this.dgvPatientList.RowHeadersWidth = 51;
            this.dgvPatientList.RowTemplate.Height = 27;
            this.dgvPatientList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatientList.Size = new System.Drawing.Size(366, 578);
            this.dgvPatientList.TabIndex = 1;
            this.dgvPatientList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatientList_CellDoubleClick);
            // 
            // PatientID
            // 
            this.PatientID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PatientID.DataPropertyName = "PatientID";
            this.PatientID.HeaderText = "환자번호";
            this.PatientID.MinimumWidth = 6;
            this.PatientID.Name = "PatientID";
            this.PatientID.ReadOnly = true;
            this.PatientID.Width = 96;
            // 
            // pName
            // 
            this.pName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.pName.DataPropertyName = "Name";
            this.pName.HeaderText = "환자명";
            this.pName.MinimumWidth = 6;
            this.pName.Name = "pName";
            this.pName.ReadOnly = true;
            this.pName.Width = 81;
            // 
            // BirthDate
            // 
            this.BirthDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BirthDate.DataPropertyName = "BirthDate";
            this.BirthDate.HeaderText = "생년월일";
            this.BirthDate.MinimumWidth = 6;
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearchName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 125);
            this.panel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("굴림", 14F);
            this.btnSearch.Location = new System.Drawing.Point(245, 72);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 35);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchName
            // 
            this.txtSearchName.Font = new System.Drawing.Font("굴림", 14F);
            this.txtSearchName.Location = new System.Drawing.Point(99, 21);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(160, 34);
            this.txtSearchName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 14F);
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "환자명";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnSave);
            this.splitContainer2.Panel1.Controls.Add(this.dtpRegDate);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.txtNote);
            this.splitContainer2.Panel1.Controls.Add(this.textBox4);
            this.splitContainer2.Panel1.Controls.Add(this.txtBirth);
            this.splitContainer2.Panel1.Controls.Add(this.txtPatientName);
            this.splitContainer2.Panel1.Controls.Add(this.txtPatientID);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvExamList);
            this.splitContainer2.Panel2.Controls.Add(this.panel2);
            this.splitContainer2.Size = new System.Drawing.Size(862, 703);
            this.splitContainer2.SplitterDistance = 405;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSave.Font = new System.Drawing.Font("굴림", 14F);
            this.btnSave.Location = new System.Drawing.Point(675, 300);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 47);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "접수 등록";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpRegDate
            // 
            this.dtpRegDate.Location = new System.Drawing.Point(161, 179);
            this.dtpRegDate.Name = "dtpRegDate";
            this.dtpRegDate.Size = new System.Drawing.Size(200, 25);
            this.dtpRegDate.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 14F);
            this.label7.Location = new System.Drawing.Point(17, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "접수일자";
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("굴림", 14F);
            this.txtNote.Location = new System.Drawing.Point(161, 246);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(430, 101);
            this.txtNote.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("굴림", 14F);
            this.textBox4.Location = new System.Drawing.Point(161, 110);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(204, 34);
            this.textBox4.TabIndex = 10;
            // 
            // txtBirth
            // 
            this.txtBirth.Font = new System.Drawing.Font("굴림", 14F);
            this.txtBirth.Location = new System.Drawing.Point(500, 109);
            this.txtBirth.Name = "txtBirth";
            this.txtBirth.ReadOnly = true;
            this.txtBirth.Size = new System.Drawing.Size(285, 34);
            this.txtBirth.TabIndex = 9;
            // 
            // txtPatientName
            // 
            this.txtPatientName.Font = new System.Drawing.Font("굴림", 14F);
            this.txtPatientName.Location = new System.Drawing.Point(500, 48);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(285, 34);
            this.txtPatientName.TabIndex = 8;
            // 
            // txtPatientID
            // 
            this.txtPatientID.Font = new System.Drawing.Font("굴림", 14F);
            this.txtPatientID.Location = new System.Drawing.Point(161, 45);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.ReadOnly = true;
            this.txtPatientID.Size = new System.Drawing.Size(204, 34);
            this.txtPatientID.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 14F);
            this.label6.Location = new System.Drawing.Point(17, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "특이사항";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 14F);
            this.label5.Location = new System.Drawing.Point(17, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "성별";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 14F);
            this.label4.Location = new System.Drawing.Point(388, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "생년월일";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 14F);
            this.label3.Location = new System.Drawing.Point(388, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "환자명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 14F);
            this.label2.Location = new System.Drawing.Point(17, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "환자번호";
            // 
            // dgvExamList
            // 
            this.dgvExamList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExamList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCode,
            this.colExname,
            this.colPrice,
            this.colStatus});
            this.dgvExamList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExamList.Location = new System.Drawing.Point(0, 59);
            this.dgvExamList.MultiSelect = false;
            this.dgvExamList.Name = "dgvExamList";
            this.dgvExamList.ReadOnly = true;
            this.dgvExamList.RowHeadersVisible = false;
            this.dgvExamList.RowHeadersWidth = 51;
            this.dgvExamList.RowTemplate.Height = 27;
            this.dgvExamList.Size = new System.Drawing.Size(862, 235);
            this.dgvExamList.TabIndex = 1;
            // 
            // colCode
            // 
            this.colCode.DataPropertyName = "ExamCode";
            this.colCode.HeaderText = "검사코드";
            this.colCode.MinimumWidth = 6;
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;
            this.colCode.Width = 125;
            // 
            // colExname
            // 
            this.colExname.DataPropertyName = "ExamName";
            this.colExname.HeaderText = "검사명";
            this.colExname.MinimumWidth = 6;
            this.colExname.Name = "colExname";
            this.colExname.ReadOnly = true;
            this.colExname.Width = 125;
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "Price";
            this.colPrice.HeaderText = "비용";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 125;
            // 
            // colStatus
            // 
            this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "상태";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnDelExam);
            this.panel2.Controls.Add(this.btnAddExam);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(862, 59);
            this.panel2.TabIndex = 0;
            // 
            // btnDelExam
            // 
            this.btnDelExam.Font = new System.Drawing.Font("굴림", 14F);
            this.btnDelExam.Location = new System.Drawing.Point(661, 6);
            this.btnDelExam.Name = "btnDelExam";
            this.btnDelExam.Size = new System.Drawing.Size(140, 45);
            this.btnDelExam.TabIndex = 4;
            this.btnDelExam.Text = "검사 삭제";
            this.btnDelExam.UseVisualStyleBackColor = true;
            // 
            // btnAddExam
            // 
            this.btnAddExam.Font = new System.Drawing.Font("굴림", 14F);
            this.btnAddExam.Location = new System.Drawing.Point(499, 6);
            this.btnAddExam.Name = "btnAddExam";
            this.btnAddExam.Size = new System.Drawing.Size(140, 45);
            this.btnAddExam.TabIndex = 3;
            this.btnAddExam.Text = "검사 추가";
            this.btnAddExam.UseVisualStyleBackColor = true;
            this.btnAddExam.Click += new System.EventHandler(this.btnAddExam_Click);
            // 
            // ReceptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ReceptionForm";
            this.Text = "ReceptionForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPatientList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtBirth;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpRegDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvExamList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelExam;
        private System.Windows.Forms.Button btnAddExam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn pName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
    }
}