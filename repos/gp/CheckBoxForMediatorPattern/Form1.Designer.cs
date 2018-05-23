namespace CheckBoxForMediatorPattern
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
            this.warrior = new System.Windows.Forms.CheckBox();
            this.berserker = new System.Windows.Forms.CheckBox();
            this.sorcerer = new System.Windows.Forms.CheckBox();
            this.wand = new System.Windows.Forms.CheckBox();
            this.doublesword = new System.Windows.Forms.CheckBox();
            this.singlesword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // warrior
            // 
            this.warrior.AutoSize = true;
            this.warrior.Location = new System.Drawing.Point(13, 27);
            this.warrior.Name = "warrior";
            this.warrior.Size = new System.Drawing.Size(48, 16);
            this.warrior.TabIndex = 0;
            this.warrior.Text = "검사";
            this.warrior.UseVisualStyleBackColor = true;
            this.warrior.CheckedChanged += new System.EventHandler(this.chkWarrior_CheckedChanged);
            // 
            // berserker
            // 
            this.berserker.AutoSize = true;
            this.berserker.Location = new System.Drawing.Point(13, 50);
            this.berserker.Name = "berserker";
            this.berserker.Size = new System.Drawing.Size(60, 16);
            this.berserker.TabIndex = 1;
            this.berserker.Text = "광전사";
            this.berserker.UseVisualStyleBackColor = true;
            this.berserker.CheckedChanged += new System.EventHandler(this.chkBerserker_CheckedChanged);
            // 
            // sorcerer
            // 
            this.sorcerer.AutoSize = true;
            this.sorcerer.Location = new System.Drawing.Point(13, 73);
            this.sorcerer.Name = "sorcerer";
            this.sorcerer.Size = new System.Drawing.Size(60, 16);
            this.sorcerer.TabIndex = 2;
            this.sorcerer.Text = "마법사";
            this.sorcerer.UseVisualStyleBackColor = true;
            this.sorcerer.CheckedChanged += new System.EventHandler(this.chkSorcerer_CheckedChanged);
            // 
            // wand
            // 
            this.wand.AutoSize = true;
            this.wand.Location = new System.Drawing.Point(127, 27);
            this.wand.Name = "wand";
            this.wand.Size = new System.Drawing.Size(116, 16);
            this.wand.TabIndex = 3;
            this.wand.Text = "지팡이 착용 여부";
            this.wand.UseVisualStyleBackColor = true;
            // 
            // doublesword
            // 
            this.doublesword.AutoSize = true;
            this.doublesword.Location = new System.Drawing.Point(127, 49);
            this.doublesword.Name = "doublesword";
            this.doublesword.Size = new System.Drawing.Size(116, 16);
            this.doublesword.TabIndex = 4;
            this.doublesword.Text = "두손검 착용 여부";
            this.doublesword.UseVisualStyleBackColor = true;
            // 
            // singlesword
            // 
            this.singlesword.AutoSize = true;
            this.singlesword.Location = new System.Drawing.Point(127, 73);
            this.singlesword.Name = "singlesword";
            this.singlesword.Size = new System.Drawing.Size(116, 16);
            this.singlesword.TabIndex = 5;
            this.singlesword.Text = "한손검 착용 여부";
            this.singlesword.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 106);
            this.Controls.Add(this.singlesword);
            this.Controls.Add(this.doublesword);
            this.Controls.Add(this.wand);
            this.Controls.Add(this.sorcerer);
            this.Controls.Add(this.berserker);
            this.Controls.Add(this.warrior);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox warrior;
        private System.Windows.Forms.CheckBox berserker;
        private System.Windows.Forms.CheckBox sorcerer;
        private System.Windows.Forms.CheckBox wand;
        private System.Windows.Forms.CheckBox doublesword;
        private System.Windows.Forms.CheckBox singlesword;
    }
}

