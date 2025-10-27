namespace Pr_HIS
{
    partial class ModifyDeleteForm
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
            this.dgvPatientList = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            this.txtSelectedName = new System.Windows.Forms.TextBox();
            this.txtSelectedStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkupDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPatientList
            // 
            this.dgvPatientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.updateName,
            this.checkupDate,
            this.status});
            this.dgvPatientList.Location = new System.Drawing.Point(49, 91);
            this.dgvPatientList.Name = "dgvPatientList";
            this.dgvPatientList.RowHeadersWidth = 51;
            this.dgvPatientList.RowTemplate.Height = 27;
            this.dgvPatientList.Size = new System.Drawing.Size(880, 251);
            this.dgvPatientList.TabIndex = 0;
            this.dgvPatientList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatientList_CellClick);
            // 
            // lblID
            // 
            this.lblID.Font = new System.Drawing.Font("굴림", 13F);
            this.lblID.Location = new System.Drawing.Point(15, 14);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(142, 23);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "환자 아이디";
            this.lblID.Visible = false;
            // 
            // txtSelectedName
            // 
            this.txtSelectedName.Location = new System.Drawing.Point(187, 61);
            this.txtSelectedName.Name = "txtSelectedName";
            this.txtSelectedName.Size = new System.Drawing.Size(285, 25);
            this.txtSelectedName.TabIndex = 2;
            // 
            // txtSelectedStatus
            // 
            this.txtSelectedStatus.Location = new System.Drawing.Point(187, 104);
            this.txtSelectedStatus.Name = "txtSelectedStatus";
            this.txtSelectedStatus.Size = new System.Drawing.Size(285, 25);
            this.txtSelectedStatus.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 25F);
            this.label1.Location = new System.Drawing.Point(42, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 52);
            this.label1.TabIndex = 4;
            this.label1.Text = "환자 정보 수정/삭제";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("굴림", 13F);
            this.label2.Location = new System.Drawing.Point(15, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "수정할 이름 - ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("굴림", 13F);
            this.label3.Location = new System.Drawing.Point(15, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "수정할 상태 - ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("굴림", 15F);
            this.btnUpdate.Location = new System.Drawing.Point(748, 41);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 44);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSelectedStatus);
            this.panel1.Controls.Add(this.txtSelectedName);
            this.panel1.Location = new System.Drawing.Point(49, 377);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 144);
            this.panel1.TabIndex = 8;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("굴림", 15F);
            this.btnDelete.Location = new System.Drawing.Point(853, 41);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 44);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "환자 아이디";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 116;
            // 
            // updateName
            // 
            this.updateName.DataPropertyName = "Name";
            this.updateName.HeaderText = "환자명";
            this.updateName.MinimumWidth = 6;
            this.updateName.Name = "updateName";
            this.updateName.Width = 125;
            // 
            // checkupDate
            // 
            this.checkupDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.checkupDate.DataPropertyName = "checkupDate";
            this.checkupDate.HeaderText = "검진 날짜";
            this.checkupDate.MinimumWidth = 6;
            this.checkupDate.Name = "checkupDate";
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.DataPropertyName = "Status";
            this.status.HeaderText = "상태";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            // 
            // ModifyDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 533);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPatientList);
            this.Name = "ModifyDeleteForm";
            this.Text = "ModifyDeleteForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPatientList;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtSelectedName;
        private System.Windows.Forms.TextBox txtSelectedStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkupDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}