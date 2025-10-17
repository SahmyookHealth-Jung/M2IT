namespace UnitConverter
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
            this.txtMileInput = new System.Windows.Forms.TextBox();
            this.txtKmOutput = new System.Windows.Forms.TextBox();
            this.Error = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMileInput
            // 
            this.txtMileInput.Location = new System.Drawing.Point(31, 195);
            this.txtMileInput.Name = "txtMileInput";
            this.txtMileInput.Size = new System.Drawing.Size(100, 25);
            this.txtMileInput.TabIndex = 0;
            this.txtMileInput.Click += new System.EventHandler(this.txtMileInput_TextChanged);
            // 
            // txtKmOutput
            // 
            this.txtKmOutput.Location = new System.Drawing.Point(238, 195);
            this.txtKmOutput.Name = "txtKmOutput";
            this.txtKmOutput.Size = new System.Drawing.Size(100, 25);
            this.txtKmOutput.TabIndex = 1;
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.Location = new System.Drawing.Point(106, 319);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(152, 15);
            this.Error.TabIndex = 2;
            this.Error.Text = "숫자만 입력해주세요.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "mile";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "km";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.txtKmOutput);
            this.Controls.Add(this.txtMileInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMileInput;
        private System.Windows.Forms.TextBox txtKmOutput;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

