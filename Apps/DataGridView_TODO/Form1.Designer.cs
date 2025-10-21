namespace DataGridView_TODO
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
            this.txtNewTask = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.ColCompleted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColTaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNewTask
            // 
            this.txtNewTask.Location = new System.Drawing.Point(61, 68);
            this.txtNewTask.Name = "txtNewTask";
            this.txtNewTask.Size = new System.Drawing.Size(387, 25);
            this.txtNewTask.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(475, 70);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvTasks
            // 
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCompleted,
            this.ColTaskName});
            this.dgvTasks.Location = new System.Drawing.Point(61, 108);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.RowHeadersWidth = 51;
            this.dgvTasks.RowTemplate.Height = 27;
            this.dgvTasks.Size = new System.Drawing.Size(547, 181);
            this.dgvTasks.TabIndex = 2;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(61, 308);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(547, 30);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "삭제";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // ColCompleted
            // 
            this.ColCompleted.DataPropertyName = "IsCompleted";
            this.ColCompleted.HeaderText = "선택";
            this.ColCompleted.MinimumWidth = 6;
            this.ColCompleted.Name = "ColCompleted";
            this.ColCompleted.Width = 125;
            // 
            // ColTaskName
            // 
            this.ColTaskName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTaskName.DataPropertyName = "TaskName";
            this.ColTaskName.HeaderText = "할 일 내용";
            this.ColTaskName.MinimumWidth = 6;
            this.ColTaskName.Name = "ColTaskName";
            this.ColTaskName.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dgvTasks);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNewTask);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewTask;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColCompleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTaskName;
    }
}

