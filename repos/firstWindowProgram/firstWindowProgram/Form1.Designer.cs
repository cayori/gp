namespace firstWindowProgram
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStr = new System.Windows.Forms.Label();
            this.lblAbi = new System.Windows.Forms.Label();
            this.lblDex = new System.Windows.Forms.Label();
            this.btnStr = new System.Windows.Forms.Button();
            this.btnAbi = new System.Windows.Forms.Button();
            this.btnDex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Strength";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ability";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dexterity";
            // 
            // lblStr
            // 
            this.lblStr.AutoSize = true;
            this.lblStr.Location = new System.Drawing.Point(111, 28);
            this.lblStr.Name = "lblStr";
            this.lblStr.Size = new System.Drawing.Size(11, 12);
            this.lblStr.TabIndex = 3;
            this.lblStr.Text = "0";
            // 
            // lblAbi
            // 
            this.lblAbi.AutoSize = true;
            this.lblAbi.Location = new System.Drawing.Point(112, 68);
            this.lblAbi.Name = "lblAbi";
            this.lblAbi.Size = new System.Drawing.Size(11, 12);
            this.lblAbi.TabIndex = 4;
            this.lblAbi.Text = "0";
            // 
            // lblDex
            // 
            this.lblDex.AutoSize = true;
            this.lblDex.Location = new System.Drawing.Point(112, 109);
            this.lblDex.Name = "lblDex";
            this.lblDex.Size = new System.Drawing.Size(11, 12);
            this.lblDex.TabIndex = 5;
            this.lblDex.Text = "0";
            // 
            // btnStr
            // 
            this.btnStr.Location = new System.Drawing.Point(159, 21);
            this.btnStr.Name = "btnStr";
            this.btnStr.Size = new System.Drawing.Size(27, 23);
            this.btnStr.TabIndex = 6;
            this.btnStr.Text = "+";
            this.btnStr.UseVisualStyleBackColor = true;
            this.btnStr.Click += new System.EventHandler(this.brnStr_Click);
            // 
            // btnAbi
            // 
            this.btnAbi.Location = new System.Drawing.Point(159, 61);
            this.btnAbi.Name = "btnAbi";
            this.btnAbi.Size = new System.Drawing.Size(27, 23);
            this.btnAbi.TabIndex = 7;
            this.btnAbi.Text = "+";
            this.btnAbi.UseVisualStyleBackColor = true;
            this.btnAbi.Click += new System.EventHandler(this.btnAbi_Click);
            // 
            // btnDex
            // 
            this.btnDex.Location = new System.Drawing.Point(159, 102);
            this.btnDex.Name = "btnDex";
            this.btnDex.Size = new System.Drawing.Size(27, 23);
            this.btnDex.TabIndex = 8;
            this.btnDex.Text = "+";
            this.btnDex.UseVisualStyleBackColor = true;
            this.btnDex.Click += new System.EventHandler(this.btnDex_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 165);
            this.Controls.Add(this.btnDex);
            this.Controls.Add(this.btnAbi);
            this.Controls.Add(this.btnStr);
            this.Controls.Add(this.lblDex);
            this.Controls.Add(this.lblAbi);
            this.Controls.Add(this.lblStr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "레벨업 윈도우";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStr;
        private System.Windows.Forms.Label lblAbi;
        private System.Windows.Forms.Label lblDex;
        private System.Windows.Forms.Button btnStr;
        private System.Windows.Forms.Button btnAbi;
        private System.Windows.Forms.Button btnDex;
    }
}

