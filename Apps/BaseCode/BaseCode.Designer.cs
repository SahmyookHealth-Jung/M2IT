namespace BaseCodeApp
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
            this.pnlBase = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.dgvSml = new System.Windows.Forms.DataGridView();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnDelSml = new System.Windows.Forms.Button();
            this.btnAddSml = new System.Windows.Forms.Button();
            this.pnlSml = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.dgvMedl = new System.Windows.Forms.DataGridView();
            this.MEDL_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEDL_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnDelMedl = new System.Windows.Forms.Button();
            this.btnAddMedl = new System.Windows.Forms.Button();
            this.pnlMedl = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dgvBig = new System.Windows.Forms.DataGridView();
            this.BIG_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BIG_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnDelBig = new System.Windows.Forms.Button();
            this.btnAddBig = new System.Windows.Forms.Button();
            this.pnlBig = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboBizGubun = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SML_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SML_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMMENTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMMENTS2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBase.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSml)).BeginInit();
            this.panel14.SuspendLayout();
            this.pnlSml.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedl)).BeginInit();
            this.panel11.SuspendLayout();
            this.pnlMedl.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBig)).BeginInit();
            this.panel8.SuspendLayout();
            this.pnlBig.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBase
            // 
            this.pnlBase.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlBase.Controls.Add(this.panel3);
            this.pnlBase.Controls.Add(this.panel2);
            this.pnlBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBase.Location = new System.Drawing.Point(0, 0);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(1037, 610);
            this.pnlBase.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1037, 543);
            this.panel3.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel13);
            this.panel6.Controls.Add(this.panel14);
            this.panel6.Controls.Add(this.pnlSml);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(456, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(581, 543);
            this.panel6.TabIndex = 4;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.dgvSml);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(0, 64);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(581, 479);
            this.panel13.TabIndex = 2;
            // 
            // dgvSml
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSml.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSml.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSml.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SML_CODE,
            this.SML_NAME,
            this.COMMENTS,
            this.COMMENTS2});
            this.dgvSml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSml.Location = new System.Drawing.Point(0, 0);
            this.dgvSml.Name = "dgvSml";
            this.dgvSml.RowTemplate.Height = 23;
            this.dgvSml.Size = new System.Drawing.Size(581, 479);
            this.dgvSml.TabIndex = 1;
            // 
            // panel14
            // 
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Controls.Add(this.btnDelSml);
            this.panel14.Controls.Add(this.btnAddSml);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 32);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(581, 32);
            this.panel14.TabIndex = 1;
            // 
            // btnDelSml
            // 
            this.btnDelSml.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelSml.Location = new System.Drawing.Point(492, 4);
            this.btnDelSml.Name = "btnDelSml";
            this.btnDelSml.Size = new System.Drawing.Size(75, 21);
            this.btnDelSml.TabIndex = 8;
            this.btnDelSml.Text = "삭제";
            this.btnDelSml.UseVisualStyleBackColor = true;
            // 
            // btnAddSml
            // 
            this.btnAddSml.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSml.Location = new System.Drawing.Point(411, 4);
            this.btnAddSml.Name = "btnAddSml";
            this.btnAddSml.Size = new System.Drawing.Size(75, 21);
            this.btnAddSml.TabIndex = 7;
            this.btnAddSml.Text = "추가";
            this.btnAddSml.UseVisualStyleBackColor = true;
            // 
            // pnlSml
            // 
            this.pnlSml.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSml.Controls.Add(this.label4);
            this.pnlSml.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSml.Location = new System.Drawing.Point(0, 0);
            this.pnlSml.Name = "pnlSml";
            this.pnlSml.Size = new System.Drawing.Size(581, 32);
            this.pnlSml.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 10F);
            this.label4.Location = new System.Drawing.Point(5, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "소분류";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.panel11);
            this.panel5.Controls.Add(this.pnlMedl);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(228, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(228, 543);
            this.panel5.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.dgvMedl);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 64);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(228, 479);
            this.panel10.TabIndex = 2;
            // 
            // dgvMedl
            // 
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
            this.dgvMedl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMedl.Location = new System.Drawing.Point(0, 0);
            this.dgvMedl.Name = "dgvMedl";
            this.dgvMedl.RowTemplate.Height = 23;
            this.dgvMedl.Size = new System.Drawing.Size(228, 479);
            this.dgvMedl.TabIndex = 1;
            this.dgvMedl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedl_CellClick);
            // 
            // MEDL_CODE
            // 
            this.MEDL_CODE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MEDL_CODE.DataPropertyName = "MEDL_CODE";
            this.MEDL_CODE.HeaderText = "코드";
            this.MEDL_CODE.Name = "MEDL_CODE";
            this.MEDL_CODE.Width = 54;
            // 
            // MEDL_NAME
            // 
            this.MEDL_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MEDL_NAME.DataPropertyName = "MEDL_NAME";
            this.MEDL_NAME.HeaderText = "코드명";
            this.MEDL_NAME.Name = "MEDL_NAME";
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.btnDelMedl);
            this.panel11.Controls.Add(this.btnAddMedl);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 32);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(228, 32);
            this.panel11.TabIndex = 1;
            // 
            // btnDelMedl
            // 
            this.btnDelMedl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelMedl.Location = new System.Drawing.Point(145, 3);
            this.btnDelMedl.Name = "btnDelMedl";
            this.btnDelMedl.Size = new System.Drawing.Size(75, 21);
            this.btnDelMedl.TabIndex = 7;
            this.btnDelMedl.Text = "삭제";
            this.btnDelMedl.UseVisualStyleBackColor = true;
            // 
            // btnAddMedl
            // 
            this.btnAddMedl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddMedl.Location = new System.Drawing.Point(67, 3);
            this.btnAddMedl.Name = "btnAddMedl";
            this.btnAddMedl.Size = new System.Drawing.Size(75, 21);
            this.btnAddMedl.TabIndex = 6;
            this.btnAddMedl.Text = "추가";
            this.btnAddMedl.UseVisualStyleBackColor = true;
            // 
            // pnlMedl
            // 
            this.pnlMedl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMedl.Controls.Add(this.label3);
            this.pnlMedl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMedl.Location = new System.Drawing.Point(0, 0);
            this.pnlMedl.Name = "pnlMedl";
            this.pnlMedl.Size = new System.Drawing.Size(228, 32);
            this.pnlMedl.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10F);
            this.label3.Location = new System.Drawing.Point(5, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "중분류";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.pnlBig);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(228, 543);
            this.panel4.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dgvBig);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 64);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(228, 479);
            this.panel9.TabIndex = 2;
            // 
            // dgvBig
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBig.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BIG_CODE,
            this.BIG_NAME});
            this.dgvBig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBig.Location = new System.Drawing.Point(0, 0);
            this.dgvBig.Name = "dgvBig";
            this.dgvBig.RowTemplate.Height = 23;
            this.dgvBig.Size = new System.Drawing.Size(228, 479);
            this.dgvBig.TabIndex = 0;
            this.dgvBig.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBig_CellClick);
            // 
            // BIG_CODE
            // 
            this.BIG_CODE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.BIG_CODE.DataPropertyName = "BIG_CODE";
            this.BIG_CODE.HeaderText = "코드";
            this.BIG_CODE.Name = "BIG_CODE";
            this.BIG_CODE.Width = 54;
            // 
            // BIG_NAME
            // 
            this.BIG_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BIG_NAME.DataPropertyName = "BIG_NAME";
            this.BIG_NAME.HeaderText = "코드명";
            this.BIG_NAME.Name = "BIG_NAME";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.btnDelBig);
            this.panel8.Controls.Add(this.btnAddBig);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 32);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(228, 32);
            this.panel8.TabIndex = 1;
            // 
            // btnDelBig
            // 
            this.btnDelBig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelBig.Location = new System.Drawing.Point(145, 3);
            this.btnDelBig.Name = "btnDelBig";
            this.btnDelBig.Size = new System.Drawing.Size(75, 21);
            this.btnDelBig.TabIndex = 5;
            this.btnDelBig.Text = "삭제";
            this.btnDelBig.UseVisualStyleBackColor = true;
            // 
            // btnAddBig
            // 
            this.btnAddBig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddBig.Location = new System.Drawing.Point(64, 3);
            this.btnAddBig.Name = "btnAddBig";
            this.btnAddBig.Size = new System.Drawing.Size(75, 21);
            this.btnAddBig.TabIndex = 4;
            this.btnAddBig.Text = "추가";
            this.btnAddBig.UseVisualStyleBackColor = true;
            // 
            // pnlBig
            // 
            this.pnlBig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBig.Controls.Add(this.label2);
            this.pnlBig.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBig.Location = new System.Drawing.Point(0, 0);
            this.pnlBig.Name = "pnlBig";
            this.pnlBig.Size = new System.Drawing.Size(228, 32);
            this.pnlBig.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10F);
            this.label2.Location = new System.Drawing.Point(11, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "대분류";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboBizGubun);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1037, 67);
            this.panel2.TabIndex = 0;
            // 
            // cboBizGubun
            // 
            this.cboBizGubun.FormattingEnabled = true;
            this.cboBizGubun.Location = new System.Drawing.Point(135, 26);
            this.cboBizGubun.Name = "cboBizGubun";
            this.cboBizGubun.Size = new System.Drawing.Size(160, 20);
            this.cboBizGubun.TabIndex = 3;
            this.cboBizGubun.SelectedIndexChanged += new System.EventHandler(this.cboBizGubun_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15F);
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "업무 구분";
            // 
            // SML_CODE
            // 
            this.SML_CODE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SML_CODE.DataPropertyName = "SML_CODE";
            this.SML_CODE.HeaderText = "코드";
            this.SML_CODE.Name = "SML_CODE";
            this.SML_CODE.Width = 54;
            // 
            // SML_NAME
            // 
            this.SML_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SML_NAME.DataPropertyName = "SML_NAME";
            this.SML_NAME.HeaderText = "코드명";
            this.SML_NAME.Name = "SML_NAME";
            this.SML_NAME.Width = 66;
            // 
            // COMMENTS
            // 
            this.COMMENTS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.COMMENTS.DataPropertyName = "COMMENTS";
            this.COMMENTS.HeaderText = "내용";
            this.COMMENTS.Name = "COMMENTS";
            // 
            // COMMENTS2
            // 
            this.COMMENTS2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.COMMENTS2.DataPropertyName = "COMMENTS2";
            this.COMMENTS2.HeaderText = "비고";
            this.COMMENTS2.Name = "COMMENTS2";
            // 
            // BaseCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1037, 610);
            this.Controls.Add(this.pnlBase);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BaseCode";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BaseCode_Load);
            this.pnlBase.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSml)).EndInit();
            this.panel14.ResumeLayout(false);
            this.pnlSml.ResumeLayout(false);
            this.pnlSml.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedl)).EndInit();
            this.panel11.ResumeLayout(false);
            this.pnlMedl.ResumeLayout(false);
            this.pnlMedl.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBig)).EndInit();
            this.panel8.ResumeLayout(false);
            this.pnlBig.ResumeLayout(false);
            this.pnlBig.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBase;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlBig;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel pnlSml;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel pnlMedl;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnDelSml;
        private System.Windows.Forms.Button btnAddSml;
        private System.Windows.Forms.Button btnDelMedl;
        private System.Windows.Forms.Button btnAddMedl;
        private System.Windows.Forms.Button btnDelBig;
        private System.Windows.Forms.Button btnAddBig;
        private System.Windows.Forms.ComboBox cboBizGubun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSml;
        private System.Windows.Forms.DataGridView dgvMedl;
        private System.Windows.Forms.DataGridView dgvBig;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEDL_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEDL_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn BIG_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn BIG_NAME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn SML_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SML_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMMENTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMMENTS2;
    }
}

