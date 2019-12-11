namespace 纸娃娃系统
{
    partial class zwwParentWin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.HeadTexturWindow = new System.Windows.Forms.PictureBox();
            this.BodyTexturWindow = new System.Windows.Forms.PictureBox();
            this.Sex_Male = new System.Windows.Forms.RadioButton();
            this.Sex_Female = new System.Windows.Forms.RadioButton();
            this.SexBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HeadTexturWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BodyTexturWindow)).BeginInit();
            this.SexBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "生成";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HeadTexturWindow
            // 
            this.HeadTexturWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HeadTexturWindow.Location = new System.Drawing.Point(81, 74);
            this.HeadTexturWindow.Name = "HeadTexturWindow";
            this.HeadTexturWindow.Size = new System.Drawing.Size(172, 95);
            this.HeadTexturWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HeadTexturWindow.TabIndex = 1;
            this.HeadTexturWindow.TabStop = false;
            this.HeadTexturWindow.Click += new System.EventHandler(this.HeadTexturWindow_Click);
            // 
            // BodyTexturWindow
            // 
            this.BodyTexturWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BodyTexturWindow.Location = new System.Drawing.Point(81, 196);
            this.BodyTexturWindow.Name = "BodyTexturWindow";
            this.BodyTexturWindow.Size = new System.Drawing.Size(172, 235);
            this.BodyTexturWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BodyTexturWindow.TabIndex = 2;
            this.BodyTexturWindow.TabStop = false;
            this.BodyTexturWindow.Click += new System.EventHandler(this.BodyTexturWindow_Click);
            // 
            // Sex_Male
            // 
            this.Sex_Male.AutoSize = true;
            this.Sex_Male.Location = new System.Drawing.Point(21, 20);
            this.Sex_Male.Name = "Sex_Male";
            this.Sex_Male.Size = new System.Drawing.Size(35, 16);
            this.Sex_Male.TabIndex = 3;
            this.Sex_Male.TabStop = true;
            this.Sex_Male.Text = "男";
            this.Sex_Male.UseVisualStyleBackColor = true;
            this.Sex_Male.CheckedChanged += new System.EventHandler(this.Sex_Male_CheckedChanged);
            // 
            // Sex_Female
            // 
            this.Sex_Female.AutoSize = true;
            this.Sex_Female.Checked = true;
            this.Sex_Female.Location = new System.Drawing.Point(139, 20);
            this.Sex_Female.Name = "Sex_Female";
            this.Sex_Female.Size = new System.Drawing.Size(35, 16);
            this.Sex_Female.TabIndex = 4;
            this.Sex_Female.TabStop = true;
            this.Sex_Female.Text = "女";
            this.Sex_Female.UseVisualStyleBackColor = true;
            this.Sex_Female.CheckedChanged += new System.EventHandler(this.Sex_Female_CheckedChanged);
            // 
            // SexBox
            // 
            this.SexBox.Controls.Add(this.Sex_Female);
            this.SexBox.Controls.Add(this.Sex_Male);
            this.SexBox.Location = new System.Drawing.Point(66, 12);
            this.SexBox.Name = "SexBox";
            this.SexBox.Size = new System.Drawing.Size(200, 44);
            this.SexBox.TabIndex = 5;
            this.SexBox.TabStop = false;
            this.SexBox.Text = "性别";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "点击头部进行编辑";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "选择她的身体";
            // 
            // zwwParentWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 496);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SexBox);
            this.Controls.Add(this.BodyTexturWindow);
            this.Controls.Add(this.HeadTexturWindow);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "zwwParentWin";
            this.Text = "纸娃娃系统";
            ((System.ComponentModel.ISupportInitialize)(this.HeadTexturWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BodyTexturWindow)).EndInit();
            this.SexBox.ResumeLayout(false);
            this.SexBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox BodyTexturWindow;
        private System.Windows.Forms.RadioButton Sex_Male;
        private System.Windows.Forms.RadioButton Sex_Female;
        private System.Windows.Forms.GroupBox SexBox;
        public System.Windows.Forms.PictureBox HeadTexturWindow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

