namespace NewScoreTracker
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
            this.HomeS = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.HomeScore = new System.Windows.Forms.Label();
            this.AwayScore = new System.Windows.Forms.Label();
            this.Aways = new System.Windows.Forms.Label();
            this.btnAfive = new System.Windows.Forms.Button();
            this.btnSfive = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnAway = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HomeS
            // 
            this.HomeS.Font = new System.Drawing.Font("굴림", 30F);
            this.HomeS.Location = new System.Drawing.Point(24, 37);
            this.HomeS.Name = "HomeS";
            this.HomeS.Size = new System.Drawing.Size(165, 51);
            this.HomeS.TabIndex = 0;
            this.HomeS.Text = "Home";
            this.HomeS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("굴림", 25F);
            this.btnAdd.Location = new System.Drawing.Point(304, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 107);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+1";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnScoreChange);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("굴림", 25F);
            this.btnSub.Location = new System.Drawing.Point(549, 12);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(114, 107);
            this.btnSub.TabIndex = 2;
            this.btnSub.Text = "-1";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnScoreChange);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("굴림", 25F);
            this.btnReset.Location = new System.Drawing.Point(304, 317);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(359, 107);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // HomeScore
            // 
            this.HomeScore.Font = new System.Drawing.Font("굴림", 25F);
            this.HomeScore.Location = new System.Drawing.Point(81, 135);
            this.HomeScore.Name = "HomeScore";
            this.HomeScore.Size = new System.Drawing.Size(152, 47);
            this.HomeScore.TabIndex = 4;
            this.HomeScore.Text = "0";
            // 
            // AwayScore
            // 
            this.AwayScore.Font = new System.Drawing.Font("굴림", 25F);
            this.AwayScore.Location = new System.Drawing.Point(81, 238);
            this.AwayScore.Name = "AwayScore";
            this.AwayScore.Size = new System.Drawing.Size(152, 47);
            this.AwayScore.TabIndex = 5;
            this.AwayScore.Text = "0";
            // 
            // Aways
            // 
            this.Aways.Font = new System.Drawing.Font("굴림", 30F);
            this.Aways.Location = new System.Drawing.Point(24, 353);
            this.Aways.Name = "Aways";
            this.Aways.Size = new System.Drawing.Size(165, 51);
            this.Aways.TabIndex = 6;
            this.Aways.Text = "Away";
            this.Aways.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAfive
            // 
            this.btnAfive.Font = new System.Drawing.Font("굴림", 25F);
            this.btnAfive.Location = new System.Drawing.Point(304, 163);
            this.btnAfive.Name = "btnAfive";
            this.btnAfive.Size = new System.Drawing.Size(114, 107);
            this.btnAfive.TabIndex = 7;
            this.btnAfive.Text = "+5";
            this.btnAfive.UseVisualStyleBackColor = true;
            this.btnAfive.Click += new System.EventHandler(this.btnScoreChange);
            // 
            // btnSfive
            // 
            this.btnSfive.Font = new System.Drawing.Font("굴림", 25F);
            this.btnSfive.Location = new System.Drawing.Point(549, 163);
            this.btnSfive.Name = "btnSfive";
            this.btnSfive.Size = new System.Drawing.Size(114, 107);
            this.btnSfive.TabIndex = 8;
            this.btnSfive.Text = "-5";
            this.btnSfive.UseVisualStyleBackColor = true;
            this.btnSfive.Click += new System.EventHandler(this.btnScoreChange);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(206, 53);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnAway
            // 
            this.btnAway.Location = new System.Drawing.Point(206, 368);
            this.btnAway.Name = "btnAway";
            this.btnAway.Size = new System.Drawing.Size(75, 23);
            this.btnAway.TabIndex = 10;
            this.btnAway.Text = "Away";
            this.btnAway.UseVisualStyleBackColor = true;
            this.btnAway.Click += new System.EventHandler(this.btnAway_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAway);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnSfive);
            this.Controls.Add(this.btnAfive);
            this.Controls.Add(this.Aways);
            this.Controls.Add(this.AwayScore);
            this.Controls.Add(this.HomeScore);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.HomeS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label HomeS;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label HomeScore;
        private System.Windows.Forms.Label AwayScore;
        private System.Windows.Forms.Label Aways;
        private System.Windows.Forms.Button btnAfive;
        private System.Windows.Forms.Button btnSfive;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnAway;
    }
}

