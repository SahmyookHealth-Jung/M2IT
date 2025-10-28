namespace BoardProject
{
    partial class BoardListForm
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
            this.dgvPosts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.txtSearchKeyword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuther = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPostDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colViewCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosts)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPosts
            // 
            this.dgvPosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colCategory,
            this.colTitle,
            this.colAuther,
            this.colPostDate,
            this.colViewCount});
            this.dgvPosts.Location = new System.Drawing.Point(133, 221);
            this.dgvPosts.Name = "dgvPosts";
            this.dgvPosts.RowHeadersWidth = 51;
            this.dgvPosts.RowTemplate.Height = 27;
            this.dgvPosts.Size = new System.Drawing.Size(873, 275);
            this.dgvPosts.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20F);
            this.label1.Location = new System.Drawing.Point(388, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "게시판";
            // 
            // cmbCategories
            // 
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Items.AddRange(new object[] {
            "자유게시판",
            "공지사항",
            "자주 묻는 질문(FAQ)",
            "Q&A"});
            this.cmbCategories.Location = new System.Drawing.Point(683, 12);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(166, 23);
            this.cmbCategories.TabIndex = 3;
            // 
            // txtSearchKeyword
            // 
            this.txtSearchKeyword.Location = new System.Drawing.Point(5, 137);
            this.txtSearchKeyword.Multiline = true;
            this.txtSearchKeyword.Name = "txtSearchKeyword";
            this.txtSearchKeyword.Size = new System.Drawing.Size(384, 31);
            this.txtSearchKeyword.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnWrite);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearchKeyword);
            this.panel1.Controls.Add(this.cmbCategories);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(133, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 179);
            this.panel1.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("굴림", 12F);
            this.btnSearch.Location = new System.Drawing.Point(412, 137);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 31);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnWrite
            // 
            this.btnWrite.Font = new System.Drawing.Font("굴림", 12F);
            this.btnWrite.Location = new System.Drawing.Point(774, 137);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 31);
            this.btnWrite.TabIndex = 6;
            this.btnWrite.Text = "작성";
            this.btnWrite.UseVisualStyleBackColor = true;
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "번호";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.Width = 66;
            // 
            // colCategory
            // 
            this.colCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colCategory.DataPropertyName = "CategoryName";
            this.colCategory.HeaderText = "카테고리";
            this.colCategory.MinimumWidth = 6;
            this.colCategory.Name = "colCategory";
            this.colCategory.Width = 96;
            // 
            // colTitle
            // 
            this.colTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTitle.DataPropertyName = "Title";
            this.colTitle.HeaderText = "제목";
            this.colTitle.MinimumWidth = 6;
            this.colTitle.Name = "colTitle";
            // 
            // colAuther
            // 
            this.colAuther.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAuther.DataPropertyName = "Author";
            this.colAuther.HeaderText = "작성자";
            this.colAuther.MinimumWidth = 6;
            this.colAuther.Name = "colAuther";
            // 
            // colPostDate
            // 
            this.colPostDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPostDate.DataPropertyName = "PostDate";
            this.colPostDate.HeaderText = "작성일";
            this.colPostDate.MinimumWidth = 6;
            this.colPostDate.Name = "colPostDate";
            // 
            // colViewCount
            // 
            this.colViewCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colViewCount.DataPropertyName = "ViewCount";
            this.colViewCount.HeaderText = "조회수";
            this.colViewCount.MinimumWidth = 6;
            this.colViewCount.Name = "colViewCount";
            this.colViewCount.Width = 81;
            // 
            // BoardPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 531);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvPosts);
            this.Name = "BoardPost";
            this.Text = "BoardPost";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPosts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.TextBox txtSearchKeyword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuther;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPostDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colViewCount;
    }
}