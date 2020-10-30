namespace paper_project
{
    partial class SetHead_Female
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
            this.components = new System.ComponentModel.Container();
            this.Head_attribute_Box = new System.Windows.Forms.GroupBox();
            this.Head_attribute_Ear = new System.Windows.Forms.RadioButton();
            this.Head_attribute_Hair_Back = new System.Windows.Forms.RadioButton();
            this.Head_attribute_Hair_Front = new System.Windows.Forms.RadioButton();
            this.Head_attribute_Mouth = new System.Windows.Forms.RadioButton();
            this.Head_attribute_Nose = new System.Windows.Forms.RadioButton();
            this.Head_attribute_Eye = new System.Windows.Forms.RadioButton();
            this.Head_attribute_Eyebrow = new System.Windows.Forms.RadioButton();
            this.Head_attribute_Face = new System.Windows.Forms.RadioButton();
            this.tempBox = new System.Windows.Forms.TextBox();
            this.groupBox_EyeColor = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBar_lightness_Eye = new System.Windows.Forms.TrackBar();
            this.trackBar_saturation_Eye = new System.Windows.Forms.TrackBar();
            this.trackBar_hue_Eye = new System.Windows.Forms.TrackBar();
            this.EyeCurrentColor = new System.Windows.Forms.Label();
            this.groupBox_HairColor = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar_lightness = new System.Windows.Forms.TrackBar();
            this.trackBar_saturation = new System.Windows.Forms.TrackBar();
            this.trackBar_hue = new System.Windows.Forms.TrackBar();
            this.HairCurrentColor = new System.Windows.Forms.Label();
            this.ListView = new System.Windows.Forms.ListView();
            this.imageList_Hair_Front = new System.Windows.Forms.ImageList(this.components);
            this.preview_Hear_photo = new System.Windows.Forms.PictureBox();
            this.imageList_Face = new System.Windows.Forms.ImageList(this.components);
            this.imageList_Ear = new System.Windows.Forms.ImageList(this.components);
            this.imageList_Eyebrow = new System.Windows.Forms.ImageList(this.components);
            this.imageList_Eye = new System.Windows.Forms.ImageList(this.components);
            this.imageList_Hair_Back = new System.Windows.Forms.ImageList(this.components);
            this.imageList_Mouth = new System.Windows.Forms.ImageList(this.components);
            this.imageList_Nose = new System.Windows.Forms.ImageList(this.components);
            this.Button_Save = new System.Windows.Forms.Button();
            this.Button_load = new System.Windows.Forms.Button();
            this.Button_Make = new System.Windows.Forms.Button();
            this.Head_attribute_Box.SuspendLayout();
            this.groupBox_EyeColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_lightness_Eye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_saturation_Eye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_hue_Eye)).BeginInit();
            this.groupBox_HairColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_lightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_saturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_hue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview_Hear_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // Head_attribute_Box
            // 
            this.Head_attribute_Box.Controls.Add(this.Head_attribute_Ear);
            this.Head_attribute_Box.Controls.Add(this.Head_attribute_Hair_Back);
            this.Head_attribute_Box.Controls.Add(this.Head_attribute_Hair_Front);
            this.Head_attribute_Box.Controls.Add(this.Head_attribute_Mouth);
            this.Head_attribute_Box.Controls.Add(this.Head_attribute_Nose);
            this.Head_attribute_Box.Controls.Add(this.Head_attribute_Eye);
            this.Head_attribute_Box.Controls.Add(this.Head_attribute_Eyebrow);
            this.Head_attribute_Box.Controls.Add(this.Head_attribute_Face);
            this.Head_attribute_Box.Location = new System.Drawing.Point(12, 12);
            this.Head_attribute_Box.Name = "Head_attribute_Box";
            this.Head_attribute_Box.Size = new System.Drawing.Size(95, 411);
            this.Head_attribute_Box.TabIndex = 0;
            this.Head_attribute_Box.TabStop = false;
            this.Head_attribute_Box.Text = "脸的属性";
            // 
            // Head_attribute_Ear
            // 
            this.Head_attribute_Ear.AutoSize = true;
            this.Head_attribute_Ear.Location = new System.Drawing.Point(7, 181);
            this.Head_attribute_Ear.Name = "Head_attribute_Ear";
            this.Head_attribute_Ear.Size = new System.Drawing.Size(47, 16);
            this.Head_attribute_Ear.TabIndex = 7;
            this.Head_attribute_Ear.TabStop = true;
            this.Head_attribute_Ear.Text = "耳朵";
            this.Head_attribute_Ear.UseVisualStyleBackColor = true;
            this.Head_attribute_Ear.CheckedChanged += new System.EventHandler(this.Head_attribute_Ear_CheckedChanged);
            // 
            // Head_attribute_Hair_Back
            // 
            this.Head_attribute_Hair_Back.AutoSize = true;
            this.Head_attribute_Hair_Back.Location = new System.Drawing.Point(7, 158);
            this.Head_attribute_Hair_Back.Name = "Head_attribute_Hair_Back";
            this.Head_attribute_Hair_Back.Size = new System.Drawing.Size(65, 16);
            this.Head_attribute_Hair_Back.TabIndex = 6;
            this.Head_attribute_Hair_Back.TabStop = true;
            this.Head_attribute_Hair_Back.Text = "头发_后";
            this.Head_attribute_Hair_Back.UseVisualStyleBackColor = true;
            this.Head_attribute_Hair_Back.CheckedChanged += new System.EventHandler(this.Head_attribute_Hair_Back_CheckedChanged);
            // 
            // Head_attribute_Hair_Front
            // 
            this.Head_attribute_Hair_Front.AutoSize = true;
            this.Head_attribute_Hair_Front.Location = new System.Drawing.Point(7, 136);
            this.Head_attribute_Hair_Front.Name = "Head_attribute_Hair_Front";
            this.Head_attribute_Hair_Front.Size = new System.Drawing.Size(65, 16);
            this.Head_attribute_Hair_Front.TabIndex = 5;
            this.Head_attribute_Hair_Front.TabStop = true;
            this.Head_attribute_Hair_Front.Text = "头发_前";
            this.Head_attribute_Hair_Front.UseVisualStyleBackColor = true;
            this.Head_attribute_Hair_Front.CheckedChanged += new System.EventHandler(this.Head_attribute_Hair_Front_CheckedChanged);
            // 
            // Head_attribute_Mouth
            // 
            this.Head_attribute_Mouth.AutoSize = true;
            this.Head_attribute_Mouth.Location = new System.Drawing.Point(7, 113);
            this.Head_attribute_Mouth.Name = "Head_attribute_Mouth";
            this.Head_attribute_Mouth.Size = new System.Drawing.Size(47, 16);
            this.Head_attribute_Mouth.TabIndex = 4;
            this.Head_attribute_Mouth.TabStop = true;
            this.Head_attribute_Mouth.Text = "嘴巴";
            this.Head_attribute_Mouth.UseVisualStyleBackColor = true;
            this.Head_attribute_Mouth.CheckedChanged += new System.EventHandler(this.Head_attribute_Mouth_CheckedChanged);
            // 
            // Head_attribute_Nose
            // 
            this.Head_attribute_Nose.AutoSize = true;
            this.Head_attribute_Nose.Location = new System.Drawing.Point(7, 90);
            this.Head_attribute_Nose.Name = "Head_attribute_Nose";
            this.Head_attribute_Nose.Size = new System.Drawing.Size(47, 16);
            this.Head_attribute_Nose.TabIndex = 3;
            this.Head_attribute_Nose.TabStop = true;
            this.Head_attribute_Nose.Text = "鼻子";
            this.Head_attribute_Nose.UseVisualStyleBackColor = true;
            this.Head_attribute_Nose.CheckedChanged += new System.EventHandler(this.Head_attribute_Nose_CheckedChanged);
            // 
            // Head_attribute_Eye
            // 
            this.Head_attribute_Eye.AutoSize = true;
            this.Head_attribute_Eye.Location = new System.Drawing.Point(7, 67);
            this.Head_attribute_Eye.Name = "Head_attribute_Eye";
            this.Head_attribute_Eye.Size = new System.Drawing.Size(47, 16);
            this.Head_attribute_Eye.TabIndex = 2;
            this.Head_attribute_Eye.TabStop = true;
            this.Head_attribute_Eye.Text = "眼睛";
            this.Head_attribute_Eye.UseVisualStyleBackColor = true;
            this.Head_attribute_Eye.CheckedChanged += new System.EventHandler(this.Head_attribute_Eye_CheckedChanged);
            // 
            // Head_attribute_Eyebrow
            // 
            this.Head_attribute_Eyebrow.AutoSize = true;
            this.Head_attribute_Eyebrow.Location = new System.Drawing.Point(7, 44);
            this.Head_attribute_Eyebrow.Name = "Head_attribute_Eyebrow";
            this.Head_attribute_Eyebrow.Size = new System.Drawing.Size(47, 16);
            this.Head_attribute_Eyebrow.TabIndex = 1;
            this.Head_attribute_Eyebrow.TabStop = true;
            this.Head_attribute_Eyebrow.Text = "眉毛";
            this.Head_attribute_Eyebrow.UseVisualStyleBackColor = true;
            this.Head_attribute_Eyebrow.CheckedChanged += new System.EventHandler(this.Head_attribute_Eyebrow_CheckedChanged);
            // 
            // Head_attribute_Face
            // 
            this.Head_attribute_Face.AutoSize = true;
            this.Head_attribute_Face.Checked = true;
            this.Head_attribute_Face.Location = new System.Drawing.Point(7, 21);
            this.Head_attribute_Face.Name = "Head_attribute_Face";
            this.Head_attribute_Face.Size = new System.Drawing.Size(47, 16);
            this.Head_attribute_Face.TabIndex = 0;
            this.Head_attribute_Face.TabStop = true;
            this.Head_attribute_Face.Text = "脸型";
            this.Head_attribute_Face.UseVisualStyleBackColor = true;
            this.Head_attribute_Face.CheckedChanged += new System.EventHandler(this.Head_attribute_Face_CheckedChanged);
            // 
            // tempBox
            // 
            this.tempBox.Location = new System.Drawing.Point(300, 12);
            this.tempBox.Name = "tempBox";
            this.tempBox.Size = new System.Drawing.Size(100, 21);
            this.tempBox.TabIndex = 1;
            // 
            // groupBox_EyeColor
            // 
            this.groupBox_EyeColor.Controls.Add(this.label4);
            this.groupBox_EyeColor.Controls.Add(this.label5);
            this.groupBox_EyeColor.Controls.Add(this.label6);
            this.groupBox_EyeColor.Controls.Add(this.trackBar_lightness_Eye);
            this.groupBox_EyeColor.Controls.Add(this.trackBar_saturation_Eye);
            this.groupBox_EyeColor.Controls.Add(this.trackBar_hue_Eye);
            this.groupBox_EyeColor.Controls.Add(this.EyeCurrentColor);
            this.groupBox_EyeColor.Location = new System.Drawing.Point(113, 500);
            this.groupBox_EyeColor.Name = "groupBox_EyeColor";
            this.groupBox_EyeColor.Size = new System.Drawing.Size(297, 147);
            this.groupBox_EyeColor.TabIndex = 2;
            this.groupBox_EyeColor.TabStop = false;
            this.groupBox_EyeColor.Text = "眼睛颜色选择框";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "saturation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "hue";
            // 
            // trackBar_lightness_Eye
            // 
            this.trackBar_lightness_Eye.Location = new System.Drawing.Point(71, 105);
            this.trackBar_lightness_Eye.Maximum = 100;
            this.trackBar_lightness_Eye.Name = "trackBar_lightness_Eye";
            this.trackBar_lightness_Eye.Size = new System.Drawing.Size(216, 45);
            this.trackBar_lightness_Eye.TabIndex = 12;
            this.trackBar_lightness_Eye.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_lightness_Eye.Value = 50;
            this.trackBar_lightness_Eye.Scroll += new System.EventHandler(this.trackBar_lightness_Eye_Scroll);
            // 
            // trackBar_saturation_Eye
            // 
            this.trackBar_saturation_Eye.Location = new System.Drawing.Point(71, 69);
            this.trackBar_saturation_Eye.Maximum = 100;
            this.trackBar_saturation_Eye.Name = "trackBar_saturation_Eye";
            this.trackBar_saturation_Eye.Size = new System.Drawing.Size(216, 45);
            this.trackBar_saturation_Eye.TabIndex = 11;
            this.trackBar_saturation_Eye.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_saturation_Eye.Value = 50;
            this.trackBar_saturation_Eye.Scroll += new System.EventHandler(this.trackBar_saturation_Eye_Scroll);
            // 
            // trackBar_hue_Eye
            // 
            this.trackBar_hue_Eye.Location = new System.Drawing.Point(71, 32);
            this.trackBar_hue_Eye.Maximum = 360;
            this.trackBar_hue_Eye.Name = "trackBar_hue_Eye";
            this.trackBar_hue_Eye.Size = new System.Drawing.Size(216, 45);
            this.trackBar_hue_Eye.TabIndex = 10;
            this.trackBar_hue_Eye.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_hue_Eye.Value = 180;
            this.trackBar_hue_Eye.Scroll += new System.EventHandler(this.trackBar_hue_Eye_Scroll);
            // 
            // EyeCurrentColor
            // 
            this.EyeCurrentColor.AutoSize = true;
            this.EyeCurrentColor.Location = new System.Drawing.Point(82, 17);
            this.EyeCurrentColor.Name = "EyeCurrentColor";
            this.EyeCurrentColor.Size = new System.Drawing.Size(101, 12);
            this.EyeCurrentColor.TabIndex = 0;
            this.EyeCurrentColor.Text = "■■■■■■■■";
            // 
            // groupBox_HairColor
            // 
            this.groupBox_HairColor.Controls.Add(this.label3);
            this.groupBox_HairColor.Controls.Add(this.label2);
            this.groupBox_HairColor.Controls.Add(this.label1);
            this.groupBox_HairColor.Controls.Add(this.trackBar_lightness);
            this.groupBox_HairColor.Controls.Add(this.trackBar_saturation);
            this.groupBox_HairColor.Controls.Add(this.trackBar_hue);
            this.groupBox_HairColor.Controls.Add(this.HairCurrentColor);
            this.groupBox_HairColor.Location = new System.Drawing.Point(113, 352);
            this.groupBox_HairColor.Name = "groupBox_HairColor";
            this.groupBox_HairColor.Size = new System.Drawing.Size(297, 142);
            this.groupBox_HairColor.TabIndex = 2;
            this.groupBox_HairColor.TabStop = false;
            this.groupBox_HairColor.Text = "毛发颜色";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "saturation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "hue";
            // 
            // trackBar_lightness
            // 
            this.trackBar_lightness.Location = new System.Drawing.Point(71, 105);
            this.trackBar_lightness.Maximum = 100;
            this.trackBar_lightness.Name = "trackBar_lightness";
            this.trackBar_lightness.Size = new System.Drawing.Size(216, 45);
            this.trackBar_lightness.TabIndex = 6;
            this.trackBar_lightness.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_lightness.Value = 50;
            this.trackBar_lightness.Scroll += new System.EventHandler(this.trackBar_lightness_Scroll);
            // 
            // trackBar_saturation
            // 
            this.trackBar_saturation.Location = new System.Drawing.Point(71, 69);
            this.trackBar_saturation.Maximum = 100;
            this.trackBar_saturation.Name = "trackBar_saturation";
            this.trackBar_saturation.Size = new System.Drawing.Size(216, 45);
            this.trackBar_saturation.TabIndex = 5;
            this.trackBar_saturation.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_saturation.Value = 50;
            this.trackBar_saturation.Scroll += new System.EventHandler(this.trackBar_saturation_Scroll);
            // 
            // trackBar_hue
            // 
            this.trackBar_hue.Location = new System.Drawing.Point(71, 32);
            this.trackBar_hue.Maximum = 360;
            this.trackBar_hue.Name = "trackBar_hue";
            this.trackBar_hue.Size = new System.Drawing.Size(216, 45);
            this.trackBar_hue.TabIndex = 4;
            this.trackBar_hue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_hue.Value = 180;
            this.trackBar_hue.Scroll += new System.EventHandler(this.trackBar_hue_Scroll);
            // 
            // HairCurrentColor
            // 
            this.HairCurrentColor.AutoSize = true;
            this.HairCurrentColor.Location = new System.Drawing.Point(82, 17);
            this.HairCurrentColor.Name = "HairCurrentColor";
            this.HairCurrentColor.Size = new System.Drawing.Size(101, 12);
            this.HairCurrentColor.TabIndex = 3;
            this.HairCurrentColor.Text = "■■■■■■■■";
            // 
            // ListView
            // 
            this.ListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ListView.HideSelection = false;
            this.ListView.Location = new System.Drawing.Point(113, 170);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(297, 176);
            this.ListView.TabIndex = 3;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.SelectedIndexChanged += new System.EventHandler(this.ListView_Hair_Front_SelectedIndexChanged);
            // 
            // imageList_Hair_Front
            // 
            this.imageList_Hair_Front.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_Hair_Front.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList_Hair_Front.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // preview_Hear_photo
            // 
            this.preview_Hear_photo.Location = new System.Drawing.Point(125, 12);
            this.preview_Hear_photo.Name = "preview_Hear_photo";
            this.preview_Hear_photo.Size = new System.Drawing.Size(160, 152);
            this.preview_Hear_photo.TabIndex = 4;
            this.preview_Hear_photo.TabStop = false;
            // 
            // imageList_Face
            // 
            this.imageList_Face.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_Face.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList_Face.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList_Ear
            // 
            this.imageList_Ear.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_Ear.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList_Ear.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList_Eyebrow
            // 
            this.imageList_Eyebrow.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_Eyebrow.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList_Eyebrow.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList_Eye
            // 
            this.imageList_Eye.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_Eye.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList_Eye.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList_Hair_Back
            // 
            this.imageList_Hair_Back.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_Hair_Back.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList_Hair_Back.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList_Mouth
            // 
            this.imageList_Mouth.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_Mouth.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList_Mouth.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList_Nose
            // 
            this.imageList_Nose.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_Nose.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList_Nose.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Button_Save
            // 
            this.Button_Save.Location = new System.Drawing.Point(300, 48);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(75, 23);
            this.Button_Save.TabIndex = 5;
            this.Button_Save.Text = "存档";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // Button_load
            // 
            this.Button_load.Location = new System.Drawing.Point(300, 86);
            this.Button_load.Name = "Button_load";
            this.Button_load.Size = new System.Drawing.Size(75, 23);
            this.Button_load.TabIndex = 6;
            this.Button_load.Text = "读档";
            this.Button_load.UseVisualStyleBackColor = true;
            this.Button_load.Click += new System.EventHandler(this.Button_load_Click);
            // 
            // Button_Make
            // 
            this.Button_Make.Location = new System.Drawing.Point(300, 125);
            this.Button_Make.Name = "Button_Make";
            this.Button_Make.Size = new System.Drawing.Size(75, 23);
            this.Button_Make.TabIndex = 7;
            this.Button_Make.Text = "生成";
            this.Button_Make.UseVisualStyleBackColor = true;
            this.Button_Make.Click += new System.EventHandler(this.Button_Make_Click);
            // 
            // SetHead_Female
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 659);
            this.Controls.Add(this.Button_Make);
            this.Controls.Add(this.Button_load);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.preview_Hear_photo);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.groupBox_HairColor);
            this.Controls.Add(this.groupBox_EyeColor);
            this.Controls.Add(this.tempBox);
            this.Controls.Add(this.Head_attribute_Box);
            this.Name = "SetHead_Female";
            this.Text = "SetHead";
            this.Head_attribute_Box.ResumeLayout(false);
            this.Head_attribute_Box.PerformLayout();
            this.groupBox_EyeColor.ResumeLayout(false);
            this.groupBox_EyeColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_lightness_Eye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_saturation_Eye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_hue_Eye)).EndInit();
            this.groupBox_HairColor.ResumeLayout(false);
            this.groupBox_HairColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_lightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_saturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_hue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview_Hear_photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Head_attribute_Box;
        private System.Windows.Forms.RadioButton Head_attribute_Hair_Back;
        private System.Windows.Forms.RadioButton Head_attribute_Hair_Front;
        private System.Windows.Forms.RadioButton Head_attribute_Mouth;
        private System.Windows.Forms.RadioButton Head_attribute_Nose;
        private System.Windows.Forms.RadioButton Head_attribute_Eye;
        private System.Windows.Forms.RadioButton Head_attribute_Eyebrow;
        private System.Windows.Forms.RadioButton Head_attribute_Face;
        private System.Windows.Forms.TextBox tempBox;
        private System.Windows.Forms.GroupBox groupBox_EyeColor;
        private System.Windows.Forms.Label EyeCurrentColor;
        private System.Windows.Forms.GroupBox groupBox_HairColor;
        private System.Windows.Forms.Label HairCurrentColor;
        private System.Windows.Forms.ListView ListView;
        private System.Windows.Forms.ImageList imageList_Hair_Front;
        private System.Windows.Forms.PictureBox preview_Hear_photo;
        private System.Windows.Forms.ImageList imageList_Face;
        private System.Windows.Forms.ImageList imageList_Ear;
        private System.Windows.Forms.ImageList imageList_Eyebrow;
        private System.Windows.Forms.RadioButton Head_attribute_Ear;
        private System.Windows.Forms.ImageList imageList_Eye;
        private System.Windows.Forms.ImageList imageList_Hair_Back;
        private System.Windows.Forms.ImageList imageList_Mouth;
        private System.Windows.Forms.ImageList imageList_Nose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar_lightness;
        private System.Windows.Forms.TrackBar trackBar_saturation;
        private System.Windows.Forms.TrackBar trackBar_hue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBar_lightness_Eye;
        private System.Windows.Forms.TrackBar trackBar_saturation_Eye;
        private System.Windows.Forms.TrackBar trackBar_hue_Eye;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.Button Button_load;
        private System.Windows.Forms.Button Button_Make;
    }
}