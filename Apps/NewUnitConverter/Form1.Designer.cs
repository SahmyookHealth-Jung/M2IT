namespace NewUnitConverter
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
            this.txtMile = new System.Windows.Forms.TextBox();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.txtMile.TextChanged += new System.EventHandler(this.txtMile_TextChanged);
            // 
            // txtMile
            // 
            this.txtMile.Location = new System.Drawing.Point(99, 151);
            this.txtMile.Name = "txtMile";
            this.txtMile.Size = new System.Drawing.Size(204, 25);
            this.txtMile.TabIndex = 0;
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(462, 151);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(204, 25);
            this.txtKm.TabIndex = 1;
            this.txtKm.TextChanged += new System.EventHandler(this.txtKm_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "mile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(545, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "km";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(324, 305);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(137, 15);
            this.lblError.TabIndex = 4;
            this.lblError.Text = "숫자를 입력하세요.";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(350, 153);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 5;
            this.btnChange.Text = "<=>";
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.txtMile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMile;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnChange;
    }
}

