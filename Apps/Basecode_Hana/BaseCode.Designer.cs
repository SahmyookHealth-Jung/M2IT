namespace Basecode_Hana
{
    partial class BaseCode
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboBizGubun = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelB = new System.Windows.Forms.Button();
            this.btnDelBig = new System.Windows.Forms.Button();
            this.btnAddB = new System.Windows.Forms.Button();
            this.dgvBig = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDelM = new System.Windows.Forms.Button();
            this.btnAddM = new System.Windows.Forms.Button();
            this.dgvMedl = new System.Windows.Forms.DataGridView();
            this.MEDL_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEDL_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnDelS = new System.Windows.Forms.Button();
            this.btnAddS = new System.Windows.Forms.Button();
            this.dgvSml = new System.Windows.Forms.DataGridView();
            this.SML_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SML_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMMENTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMMENTS2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BIG_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BIG_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedl)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSml)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cboBizGubun);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 42);
            this.panel1.TabIndex = 0;
            // 
            // cboBizGubun
            // 
            this.cboBizGubun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBizGubun.FormattingEnabled = true;
            this.cboBizGubun.Location = new System.Drawing.Point(130, 9);
            this.cboBizGubun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboBizGubun.Name = "cboBizGubun";
            this.cboBizGubun.Size = new System.Drawing.Size(154, 20);
            this.cboBizGubun.TabIndex = 1;
            this.cboBizGubun.SelectedIndexChanged += new System.EventHandler(this.choBizGubun_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15F);
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "업무 구분";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 42);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.dgvBig);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1234, 516);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 67);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10F);
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "대분류";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.btnDelB);
            this.panel3.Controls.Add(this.btnDelBig);
            this.panel3.Controls.Add(this.btnAddB);
            this.panel3.Location = new System.Drawing.Point(0, 31);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(302, 38);
            this.panel3.TabIndex = 0;
            // 
            // btnDelB
            // 
            this.btnDelB.Location = new System.Drawing.Point(236, 7);
            this.btnDelB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelB.Name = "btnDelB";
            this.btnDelB.Size = new System.Drawing.Size(60, 25);
            this.btnDelB.TabIndex = 2;
            this.btnDelB.Text = "삭제";
            this.btnDelB.UseVisualStyleBackColor = true;
            // 
            // btnDelBig
            // 
            this.btnDelBig.Location = new System.Drawing.Point(358, 9);
            this.btnDelBig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelBig.Name = "btnDelBig";
            this.btnDelBig.Size = new System.Drawing.Size(60, 18);
            this.btnDelBig.TabIndex = 1;
            this.btnDelBig.Text = "삭제";
            this.btnDelBig.UseVisualStyleBackColor = true;
            // 
            // btnAddB
            // 
            this.btnAddB.Location = new System.Drawing.Point(170, 7);
            this.btnAddB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddB.Name = "btnAddB";
            this.btnAddB.Size = new System.Drawing.Size(60, 25);
            this.btnAddB.TabIndex = 0;
            this.btnAddB.Text = "추가";
            this.btnAddB.UseVisualStyleBackColor = true;
            // 
            // dgvBig
            // 
            this.dgvBig.AllowUserToAddRows = false;
            this.dgvBig.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBig.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BIG_CODE,
            this.BIG_NAME});
            this.dgvBig.Location = new System.Drawing.Point(1, 68);
            this.dgvBig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBig.MultiSelect = false;
            this.dgvBig.Name = "dgvBig";
            this.dgvBig.RowHeadersWidth = 51;
            this.dgvBig.RowTemplate.Height = 27;
            this.dgvBig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBig.Size = new System.Drawing.Size(301, 454);
            this.dgvBig.TabIndex = 0;
            this.dgvBig.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBig_CellClick);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel4);
            this.splitContainer2.Panel1.Controls.Add(this.dgvMedl);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel6);
            this.splitContainer2.Panel2.Controls.Add(this.dgvSml);
            this.splitContainer2.Size = new System.Drawing.Size(932, 516);
            this.splitContainer2.SplitterDistance = 300;
            this.splitContainer2.SplitterWidth = 2;
            this.splitContainer2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 67);
            this.panel4.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10F);
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "중분류";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Controls.Add(this.btnDelM);
            this.panel5.Controls.Add(this.btnAddM);
            this.panel5.Location = new System.Drawing.Point(-1, 29);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(302, 38);
            this.panel5.TabIndex = 2;
            // 
            // btnDelM
            // 
            this.btnDelM.Location = new System.Drawing.Point(236, 7);
            this.btnDelM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelM.Name = "btnDelM";
            this.btnDelM.Size = new System.Drawing.Size(60, 25);
            this.btnDelM.TabIndex = 2;
            this.btnDelM.Text = "삭제";
            this.btnDelM.UseVisualStyleBackColor = true;
            // 
            // btnAddM
            // 
            this.btnAddM.Location = new System.Drawing.Point(170, 7);
            this.btnAddM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddM.Name = "btnAddM";
            this.btnAddM.Size = new System.Drawing.Size(60, 25);
            this.btnAddM.TabIndex = 2;
            this.btnAddM.Text = "추가";
            this.btnAddM.UseVisualStyleBackColor = true;
            // 
            // dgvMedl
            // 
            this.dgvMedl.AllowUserToAddRows = false;
            this.dgvMedl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMedl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MEDL_CODE,
            this.MEDL_NAME});
            this.dgvMedl.Location = new System.Drawing.Point(0, 67);
            this.dgvMedl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMedl.MultiSelect = false;
            this.dgvMedl.Name = "dgvMedl";
            this.dgvMedl.RowHeadersWidth = 51;
            this.dgvMedl.RowTemplate.Height = 27;
            this.dgvMedl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedl.Size = new System.Drawing.Size(301, 454);
            this.dgvMedl.TabIndex = 0;
            this.dgvMedl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedl_CellClick);
            // 
            // MEDL_CODE
            // 
            this.MEDL_CODE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MEDL_CODE.DataPropertyName = "MEDL_CODE";
            this.MEDL_CODE.HeaderText = "코드";
            this.MEDL_CODE.MinimumWidth = 6;
            this.MEDL_CODE.Name = "MEDL_CODE";
            this.MEDL_CODE.Width = 54;
            // 
            // MEDL_NAME
            // 
            this.MEDL_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MEDL_NAME.DataPropertyName = "MEDL_NAME";
            this.MEDL_NAME.HeaderText = "코드명";
            this.MEDL_NAME.MinimumWidth = 6;
            this.MEDL_NAME.Name = "MEDL_NAME";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(630, 67);
            this.panel6.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 10F);
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "소분류";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel7.Controls.Add(this.btnDelS);
            this.panel7.Controls.Add(this.btnAddS);
            this.panel7.Location = new System.Drawing.Point(0, 30);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(629, 37);
            this.panel7.TabIndex = 0;
            // 
            // btnDelS
            // 
            this.btnDelS.Location = new System.Drawing.Point(565, 6);
            this.btnDelS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelS.Name = "btnDelS";
            this.btnDelS.Size = new System.Drawing.Size(60, 25);
            this.btnDelS.TabIndex = 3;
            this.btnDelS.Text = "삭제";
            this.btnDelS.UseVisualStyleBackColor = true;
            // 
            // btnAddS
            // 
            this.btnAddS.Location = new System.Drawing.Point(499, 6);
            this.btnAddS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddS.Name = "btnAddS";
            this.btnAddS.Size = new System.Drawing.Size(60, 25);
            this.btnAddS.TabIndex = 3;
            this.btnAddS.Text = "추가";
            this.btnAddS.UseVisualStyleBackColor = true;
            // 
            // dgvSml
            // 
            this.dgvSml.AllowUserToAddRows = false;
            this.dgvSml.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSml.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSml.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSml.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SML_CODE,
            this.SML_NAME,
            this.COMMENTS,
            this.COMMENTS2});
            this.dgvSml.Location = new System.Drawing.Point(0, 67);
            this.dgvSml.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSml.MultiSelect = false;
            this.dgvSml.Name = "dgvSml";
            this.dgvSml.RowHeadersWidth = 51;
            this.dgvSml.RowTemplate.Height = 27;
            this.dgvSml.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSml.Size = new System.Drawing.Size(630, 454);
            this.dgvSml.TabIndex = 0;
            // 
            // SML_CODE
            // 
            this.SML_CODE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SML_CODE.DataPropertyName = "SML_CODE";
            this.SML_CODE.HeaderText = "코드";
            this.SML_CODE.MinimumWidth = 6;
            this.SML_CODE.Name = "SML_CODE";
            this.SML_CODE.Width = 60;
            // 
            // SML_NAME
            // 
            this.SML_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SML_NAME.DataPropertyName = "SML_NAME";
            this.SML_NAME.FillWeight = 273.7226F;
            this.SML_NAME.HeaderText = "코드명";
            this.SML_NAME.MinimumWidth = 6;
            this.SML_NAME.Name = "SML_NAME";
            this.SML_NAME.Width = 125;
            // 
            // COMMENTS
            // 
            this.COMMENTS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.COMMENTS.DataPropertyName = "COMMENTS";
            this.COMMENTS.FillWeight = 13.13869F;
            this.COMMENTS.HeaderText = "내용";
            this.COMMENTS.MinimumWidth = 6;
            this.COMMENTS.Name = "COMMENTS";
            // 
            // COMMENTS2
            // 
            this.COMMENTS2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.COMMENTS2.DataPropertyName = "COMMENTS2";
            this.COMMENTS2.FillWeight = 13.13869F;
            this.COMMENTS2.HeaderText = "비고";
            this.COMMENTS2.MinimumWidth = 6;
            this.COMMENTS2.Name = "COMMENTS2";
            // 
            // BIG_CODE
            // 
            this.BIG_CODE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BIG_CODE.DataPropertyName = "BIG_CODE";
            this.BIG_CODE.HeaderText = "코드";
            this.BIG_CODE.MinimumWidth = 6;
            this.BIG_CODE.Name = "BIG_CODE";
            this.BIG_CODE.Width = 54;
            // 
            // BIG_NAME
            // 
            this.BIG_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BIG_NAME.DataPropertyName = "BIG_NAME";
            this.BIG_NAME.HeaderText = "코드명";
            this.BIG_NAME.MinimumWidth = 6;
            this.BIG_NAME.Name = "BIG_NAME";
            // 
            // BaseCode
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1234, 558);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BaseCode";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BaseCode_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBig)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedl)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSml)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvBig;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgvMedl;
        private System.Windows.Forms.DataGridView dgvSml;
        private System.Windows.Forms.ComboBox cboBizGubun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEDL_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEDL_NAME;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDelBig;
        private System.Windows.Forms.Button btnAddB;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnDelM;
        private System.Windows.Forms.Button btnAddM;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnDelS;
        private System.Windows.Forms.Button btnAddS;
        private System.Windows.Forms.Button btnDelB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SML_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SML_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMMENTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMMENTS2;
        private System.Windows.Forms.DataGridViewTextBoxColumn BIG_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn BIG_NAME;
    }
}

