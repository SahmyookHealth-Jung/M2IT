namespace Mini_HIS_Project
{
    partial class MainForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("권한목록");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("메뉴목록");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("업무목록");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("코드관리", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("직원목록");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("직원관리", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Calendar");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("일정관리", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("전체현황");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("대시보드", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.treeView = new System.Windows.Forms.TreeView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(59, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 500);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(30, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(990, 450);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(250, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(719, 415);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.treeView);
            this.panel3.Location = new System.Drawing.Point(16, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 415);
            this.panel3.TabIndex = 0;
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            treeNode1.Name = "authlist";
            treeNode1.Tag = "AuthList";
            treeNode1.Text = "권한목록";
            treeNode2.Name = "노드2";
            treeNode2.Tag = "MenuList";
            treeNode2.Text = "메뉴목록";
            treeNode3.Name = "노드3";
            treeNode3.Tag = "TaskList";
            treeNode3.Text = "업무목록";
            treeNode4.Name = "";
            treeNode4.Tag = "CodeManage";
            treeNode4.Text = "코드관리";
            treeNode5.Name = "노드5";
            treeNode5.Tag = "StaffList";
            treeNode5.Text = "직원목록";
            treeNode6.Name = "노드4";
            treeNode6.Tag = "StaffManage";
            treeNode6.Text = "직원관리";
            treeNode7.Name = "노드7";
            treeNode7.Tag = "Cal";
            treeNode7.Text = "Calendar";
            treeNode8.Name = "노드6";
            treeNode8.Tag = "Schedule";
            treeNode8.Text = "일정관리";
            treeNode9.Name = "노드9";
            treeNode9.Tag = "Now";
            treeNode9.Text = "전체현황";
            treeNode10.Name = "노드8";
            treeNode10.Tag = "DashBoard";
            treeNode10.Text = "대시보드";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode6,
            treeNode8,
            treeNode10});
            this.treeView.Size = new System.Drawing.Size(213, 413);
            this.treeView.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TreeView treeView;
    }
}