using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace paper_project
{
    public partial class zwwParentWin : Form
    {
        //全局变量
        string HeadPath = @"texture\head.png";
        string BodyPath = @"texture\body.png";

        public void SelectImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @".\texture";
            openFileDialog.Filter = "贴图素材|*.png*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            //显示对话框，如果选中则关闭对话框
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                HeadPath = openFileDialog.FileName;
                this.HeadTexturWindow.BackgroundImage = Image.FromFile(openFileDialog.FileName);
            }
        }

        public zwwParentWin()
        {
            InitializeComponent();
            this.BodyTexturWindow.BackgroundImage = Image.FromFile(@"texture\body.png");
            this.HeadTexturWindow.BackgroundImage = Image.FromFile(@"texture\head.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //保存图像到相应的位置
            //这里的(textureWindow.Width - this.HeadtextureWindow.Width)/2是计算头的素材到身体中间
            //注意绘制顺序
            Bitmap headBmp = this.HeadTexturWindow.BackgroundImage as Bitmap;
            Bitmap bodyBmp = this.BodyTexturWindow.BackgroundImage as Bitmap;
            Bitmap b = new Bitmap(bodyBmp.Width, bodyBmp.Height + headBmp.Height);
            //using用途：清理非托管资源，不受GC控制的资源。Using结束后会隐式的调用Disposable方法。
            using (Graphics g = Graphics.FromImage(b))
            {
                Rectangle HeadPos = new Rectangle((bodyBmp.Width - headBmp.Width) / 2, 0, headBmp.Width, headBmp.Height);
                Rectangle BodyPos = new Rectangle(0, (headBmp.Height) * 3 / 5, bodyBmp.Width, bodyBmp.Height);
                g.DrawImage(headBmp, HeadPos);
                g.DrawImage(bodyBmp, BodyPos);

                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.InitialDirectory = @".\texture";
                saveFile.Filter = "立绘|*.png*";
                saveFile.RestoreDirectory = true;
                saveFile.FilterIndex = 1;
                saveFile.FileName = "temp.png";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    b.Save(saveFile.FileName, ImageFormat.Png);
                }
            }
            //注意要释放资源
            headBmp.Dispose();
            bodyBmp.Dispose();
            b.Dispose();
        }

        private void HeadTexturWindow_Click(object sender, EventArgs e)
        {
            //winform 弹出子窗口后不能操作父窗口的实现
            if (this.Sex_Male.Checked)
            {
                SetHead_Male setHead = new SetHead_Male(this);
                setHead.ShowDialog();
            }
            else
            {
                SetHead_Female headwin = new SetHead_Female(this);//第二个窗体
                headwin.ShowDialog();
            }
        }

        private void BodyTexturWindow_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @".\texture";
            openFileDialog.Filter = "贴图素材|*.png*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            //显示对话框，如果选中则关闭对话框
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                BodyPath = openFileDialog.FileName;
                this.BodyTexturWindow.BackgroundImage = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void Sex_Female_CheckedChanged(object sender, EventArgs e)
        {
            this.BodyTexturWindow.BackgroundImage = Image.FromFile(@"texture\body.png");
            this.HeadTexturWindow.BackgroundImage = Image.FromFile(@"texture\head.png");
            this.label2.Text = "选择她的身体";
        }

        private void Sex_Male_CheckedChanged(object sender, EventArgs e)
        {
            this.BodyTexturWindow.BackgroundImage = Image.FromFile(@"texture\body_man.png");
            this.HeadTexturWindow.BackgroundImage = Image.FromFile(@"texture\head_man.png");
            this.label2.Text = "选择他的身体";
        }
    }
}
