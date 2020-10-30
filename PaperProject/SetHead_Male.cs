using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paper_project
{
    public partial class SetHead_Male : Form
    {
        #region 全局变量
        int Fag = 0;
        Head_Male hear = new Head_Male();
        //全部前面的头发的名字
        List<string> FrontHairNames = new List<string>();
        //标识从哪里开始是但层的
        int BackHairFag = 0;
        //后面的头发的名字
        List<string> BackHairANames = new List<string>();
        //后面的头发的名字B
        List<string> BackHairBNames = new List<string>();
        //全部眼睛A
        List<string> EyeANames = new List<string>();
        //全部眼睛B
        List<string> EyeBNames = new List<string>();
        //全部嘴巴
        List<string> MouthNames = new List<string>();
        //全部鼻子
        List<string> NoseNames = new List<string>();
        //全部胡子
        List<string> MoustacheNames = new List<string>();
        //全部脸
        List<string> FaceNames = new List<string>();
        //全部耳朵
        List<string> EarNames = new List<string>();
        //全部眉毛
        List<string> EyebrowNames = new List<string>();
        //父窗口
        zwwParentWin from_parent;

        #endregion

        public SetHead_Male(zwwParentWin _from)
        {
            InitializeComponent();
            Initial_texture_Window();
            from_parent = _from;
        }

        #region 切换不同部位

        private void Head_attribute_Face_CheckedChanged_1(object sender, EventArgs e)
        {
            if (this.Head_attribute_Face.Checked)
            {
                Fag = 0;
                tempBox.Text = "Face";
                RefreshListView(FaceNames, this.imageList_Face);
            }
        }

        private void Head_attribute_Eyebrow_CheckedChanged_1(object sender, EventArgs e)
        {
            if (this.Head_attribute_Eyebrow.Checked)
            {
                Fag = 1;
                tempBox.Text = "Eyebrow";
                RefreshListView(EyebrowNames, this.imageList_Eyebrow);
            }
        }

        private void Head_attribute_Eye_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Head_attribute_Eye.Checked)
            {
                Fag = 2;
                tempBox.Text = "Eye";
                RefreshListView(EyeANames, this.imageList_Eye);
            }
        }

        private void Head_attribute_Nose_CheckedChanged_1(object sender, EventArgs e)
        {
            if (this.Head_attribute_Nose.Checked)
            {
                Fag = 3;
                tempBox.Text = "Nose";
                RefreshListView(NoseNames, this.imageList_Nose);
            }
        }

        private void Head_attribute_Mouth_CheckedChanged_1(object sender, EventArgs e)
        {
            if (this.Head_attribute_Mouth.Checked)
            {
                Fag = 4;
                tempBox.Text = "Mouth";
                RefreshListView(MouthNames, this.imageList_Mouth);
            }
        }

        private void Head_attribute_Hair_Front_CheckedChanged_1(object sender, EventArgs e)
        {
            if (this.Head_attribute_Hair_Front.Checked)
            {
                Fag = 5;
                tempBox.Text = "Hair_Front";
                RefreshListView(FrontHairNames, this.imageList_Hair_Front);
            }
        }

        private void Head_attribute_Hair_Back_CheckedChanged_1(object sender, EventArgs e)
        {
            if (this.Head_attribute_Hair_Back.Checked)
            {
                Fag = 6;
                tempBox.Text = "Hair_Back";
                RefreshListView(BackHairANames, this.imageList_Hair_Back);
            }
        }
        private void Head_attribute_Ear_CheckedChanged_1(object sender, EventArgs e)
        {
            if (this.Head_attribute_Ear.Checked)
            {
                Fag = 7;
                tempBox.Text = "Ear";
                RefreshListView(EarNames, this.imageList_Ear);
            }
        }

        private void Head_attribute_Moustache_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Head_attribute_Moustache.Checked)
            {
                Fag = 8;
                tempBox.Text = "Moustache";
                RefreshListView(MoustacheNames, this.imageList_Moustache);
            }
        }

        #endregion

        #region 改变颜色
        //眼睛颜色
        private void trackBar_hue_Eye_Scroll_1(object sender, EventArgs e)
        {
            hear.hue_Eye = this.trackBar_hue_Eye.Value;
            RefreshHeadPhoto();
        }
        private void trackBar_saturation_Eye_Scroll_1(object sender, EventArgs e)
        {
            hear.saturation_Eye = this.trackBar_saturation_Eye.Value * .01;
            RefreshHeadPhoto();
        }
        private void trackBar_lightness_Eye_Scroll_1(object sender, EventArgs e)
        {
            hear.lightness_Eye = this.trackBar_lightness_Eye.Value * .01;
            RefreshHeadPhoto();
        }

        //毛发颜色
        private void trackBar_hue_Scroll_1(object sender, EventArgs e)
        {
            hear.hue = this.trackBar_hue.Value;
            RefreshHeadPhoto();
        }
        private void trackBar_saturation_Scroll_1(object sender, EventArgs e)
        {
            hear.saturation = this.trackBar_saturation.Value * .01;
            RefreshHeadPhoto();
        }
        private void trackBar_lightness_Scroll_1(object sender, EventArgs e)
        {
            hear.lightness = this.trackBar_lightness.Value * .01;
            RefreshHeadPhoto();
        }
        #endregion

        //先遍历一遍所有图片
        private void Initial_texture_Window()
        {
            #region 预先加载图片文件
            try
            {
                string FrontHairpath = @".\texture\Male\Hair_Front";
                string Facepath = @".\texture\Male\Face_shape";
                string Earpath = @".\texture\Male\Ear";
                string Eyebrowpath = @".\texture\Male\Eyebrow";
                string Eyepath = @".\texture\Male\Eyes";
                string BackHairDoublepath = @".\texture\Male\Hair_Back\double";
                string BackHaironepath = @".\texture\Male\Hair_Back\one";
                string Mouthpath = @".\texture\Male\Mouth";
                string Nosepath = @".\texture\Male\Nose";
                string Moustachepath = @".\texture\Male\Moustache";

                //Directory:文件夹 Info:信息
                DirectoryInfo FrontHairTheFolder = new DirectoryInfo(FrontHairpath);
                DirectoryInfo FaceTheFolder = new DirectoryInfo(Facepath);
                DirectoryInfo EarTheFolder = new DirectoryInfo(Earpath);
                DirectoryInfo EyebrowTheFolder = new DirectoryInfo(Eyebrowpath);
                DirectoryInfo EyeTheFolder = new DirectoryInfo(Eyepath);
                DirectoryInfo BackHairDoubleTheFolder = new DirectoryInfo(BackHairDoublepath);
                DirectoryInfo BackHaironeTheFolder = new DirectoryInfo(BackHaironepath);
                DirectoryInfo MouthTheFolder = new DirectoryInfo(Mouthpath);
                DirectoryInfo NoseTheFolder = new DirectoryInfo(Nosepath);
                DirectoryInfo MoustacheTheFolder = new DirectoryInfo(Moustachepath);

                //先初始化
                this.imageList_Hair_Front.Images.Clear();
                this.imageList_Face.Images.Clear();
                this.imageList_Ear.Images.Clear();
                this.imageList_Eyebrow.Images.Clear();
                this.imageList_Eye.Images.Clear();
                this.imageList_Hair_Back.Images.Clear();
                this.imageList_Mouth.Images.Clear();
                this.imageList_Nose.Images.Clear();
                this.imageList_Moustache.Images.Clear();

                //胡子
                for (int i = 0; i < MoustacheTheFolder.GetFiles().Length; i++)
                {
                    if (MoustacheTheFolder.GetFiles()[i].Length > 0 && MoustacheTheFolder.GetFiles()[i].Extension == ".png")
                    {
                        //DirectoryName取得的只是路径，要加上文件名
                        Image image = Image.FromFile(MoustacheTheFolder.GetFiles()[i].DirectoryName + "\\" + MoustacheTheFolder.GetFiles()[i].Name);
                        MoustacheNames.Add(MoustacheTheFolder.GetFiles()[i].Name);
                        this.imageList_Moustache.Images.Add(image);
                    }
                }

                //鼻子
                for (int i = 0; i < NoseTheFolder.GetFiles().Length; i++)
                {
                    if (NoseTheFolder.GetFiles()[i].Length > 0 && NoseTheFolder.GetFiles()[i].Extension == ".png")
                    {
                        //DirectoryName取得的只是路径，要加上文件名
                        Image image = Image.FromFile(NoseTheFolder.GetFiles()[i].DirectoryName + "\\" + NoseTheFolder.GetFiles()[i].Name);
                        NoseNames.Add(NoseTheFolder.GetFiles()[i].Name);
                        this.imageList_Nose.Images.Add(image);
                    }
                }

                //嘴巴
                for (int i = 0; i < MouthTheFolder.GetFiles().Length; i++)
                {
                    if (MouthTheFolder.GetFiles()[i].Length > 0 && MouthTheFolder.GetFiles()[i].Extension == ".png")
                    {
                        //DirectoryName取得的只是路径，要加上文件名
                        Image image = Image.FromFile(MouthTheFolder.GetFiles()[i].DirectoryName + "\\" + MouthTheFolder.GetFiles()[i].Name);
                        MouthNames.Add(MouthTheFolder.GetFiles()[i].Name);
                        this.imageList_Mouth.Images.Add(image);
                    }
                }

                //后面头发(double)
                for (int i = 0; i < BackHairDoubleTheFolder.GetFiles().Length; i++)
                {
                    if (BackHairDoubleTheFolder.GetFiles()[i].Length > 0 && BackHairDoubleTheFolder.GetFiles()[i].Extension == ".png")
                    {
                        //只显示部分就行了(不显示B)
                        if (BackHairDoubleTheFolder.GetFiles()[i].Name.Contains("A"))
                        {
                            Image image = Image.FromFile(BackHairDoubleTheFolder.GetFiles()[i].DirectoryName + "\\" + BackHairDoubleTheFolder.GetFiles()[i].Name);
                            BackHairANames.Add(BackHairDoubleTheFolder.GetFiles()[i].Name);
                            this.imageList_Hair_Back.Images.Add(image);
                            BackHairFag++;
                        }
                        else
                        {
                            BackHairBNames.Add(BackHairDoubleTheFolder.GetFiles()[i].Name);
                        }
                    }
                }
                //后面头发(one)
                for (int i = 0; i < BackHaironeTheFolder.GetFiles().Length; i++)
                {
                    if (BackHaironeTheFolder.GetFiles()[i].Length > 0 && BackHaironeTheFolder.GetFiles()[i].Extension == ".png")
                    {
                        Image image = Image.FromFile(BackHaironeTheFolder.GetFiles()[i].DirectoryName + "\\" + BackHaironeTheFolder.GetFiles()[i].Name);
                        BackHairANames.Add(BackHaironeTheFolder.GetFiles()[i].Name);
                        this.imageList_Hair_Back.Images.Add(image);
                    }
                }


                //眼睛
                for (int i = 0; i < EyeTheFolder.GetFiles().Length; i++)
                {
                    if (EyeTheFolder.GetFiles()[i].Length > 0 && EyeTheFolder.GetFiles()[i].Extension == ".png")
                    {
                        //只显示部分就行了(不显示B)
                        if (EyeTheFolder.GetFiles()[i].Name.Contains("B"))
                        {
                            Image image = Image.FromFile(EyeTheFolder.GetFiles()[i].DirectoryName + "\\" + EyeTheFolder.GetFiles()[i].Name);
                            EyeANames.Add(EyeTheFolder.GetFiles()[i].Name);
                            this.imageList_Eye.Images.Add(image);
                        }
                        else
                        {
                            EyeBNames.Add(EyeTheFolder.GetFiles()[i].Name);
                        }

                    }
                }

                //脸
                for (int i = 0; i < FaceTheFolder.GetFiles().Length; i++)
                {
                    if (FaceTheFolder.GetFiles()[i].Length > 0 && FaceTheFolder.GetFiles()[i].Extension == ".png")
                    {
                        //DirectoryName取得的只是路径，要加上文件名
                        Image image = Image.FromFile(FaceTheFolder.GetFiles()[i].DirectoryName + "\\" + FaceTheFolder.GetFiles()[i].Name);
                        FaceNames.Add(FaceTheFolder.GetFiles()[i].Name);
                        this.imageList_Face.Images.Add(image);
                    }
                }

                //前头发
                for (int i = 0; i < FrontHairTheFolder.GetFiles().Length; i++)
                {
                    if (FrontHairTheFolder.GetFiles()[i].Length > 0 && FrontHairTheFolder.GetFiles()[i].Extension == ".png")
                    {
                        Image image = Image.FromFile(FrontHairTheFolder.GetFiles()[i].DirectoryName + "\\" + FrontHairTheFolder.GetFiles()[i].Name);
                        FrontHairNames.Add(FrontHairTheFolder.GetFiles()[i].Name);
                        this.imageList_Hair_Front.Images.Add(image);
                    }
                }

                //耳朵
                for (int i = 0; i < EarTheFolder.GetFiles().Length; i++)
                {
                    if (EarTheFolder.GetFiles()[i].Length > 0 && EarTheFolder.GetFiles()[i].Extension == ".png")
                    {
                        Image image = Image.FromFile(EarTheFolder.GetFiles()[i].DirectoryName + "\\" + EarTheFolder.GetFiles()[i].Name);
                        EarNames.Add(EarTheFolder.GetFiles()[i].Name);
                        this.imageList_Ear.Images.Add(image);
                    }
                }

                //眉毛
                for (int i = 0; i < EyebrowTheFolder.GetFiles().Length; i++)
                {
                    if (EyebrowTheFolder.GetFiles()[i].Length > 0 && EyebrowTheFolder.GetFiles()[i].Extension == ".png")
                    {
                        Image image = Image.FromFile(EyebrowTheFolder.GetFiles()[i].DirectoryName + "\\" + EyebrowTheFolder.GetFiles()[i].Name);
                        EyebrowNames.Add(EyebrowTheFolder.GetFiles()[i].Name);
                        this.imageList_Eyebrow.Images.Add(image);
                    }
                }
                #endregion

                //初始化
                this.ListView.View = View.LargeIcon;
                this.ListView.LargeImageList = this.imageList_Face;
                //开始绑定
                this.ListView.BeginUpdate();
                this.ListView.Items.Clear();//Item:项目

                for (int i = 0; i < FaceNames.Count; i++)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.ImageIndex = i;
                    lvi.Text = FaceNames[i];
                    this.ListView.Items.Add(lvi);
                }
                this.ListView.EndUpdate();

                #region 给hear赋初始值
                //给hear赋初值;
                hear.Hair_Front_path = @".\texture\Male\Hair_Front\" + FrontHairNames[0];
                hear.Face_path = @".\texture\Male\Face_shape\" + FaceNames[0];
                hear.Ear_path = @".\texture\Male\Ear\" + EarNames[0];
                hear.Eyebrow_path = @".\texture\Male\Eyebrow\" + EyebrowNames[0];
                hear.Eye_A_path = @".\texture\Male\Eyes\" + EyeANames[0];
                hear.Eye_B_path = @".\texture\Male\Eyes\" + EyeBNames[0];
                hear.is_HairFrontDouble = false;
                hear.Hair_Back_A_path = @".\texture\Male\Hair_Back\one\" + BackHairANames[BackHairFag];
                hear.Hair_Back_B_path = @".\texture\Male\Hair_Back\one\" + BackHairANames[BackHairFag];
                hear.Mouth_path = @".\texture\Male\Mouth\" + MouthNames[0];
                hear.Nose_path = @".\texture\Male\Nose\" + NoseNames[0];
                hear.hue_Eye = this.trackBar_hue_Eye.Value;
                hear.saturation_Eye = this.trackBar_saturation_Eye.Value * .01;
                hear.lightness_Eye = this.trackBar_lightness_Eye.Value * .01;
                hear.hue = this.trackBar_hue.Value;
                hear.saturation = this.trackBar_saturation.Value * .01;
                hear.lightness = this.trackBar_lightness.Value * .01;
                hear.Moustache_path = @".\texture\Male\Moustache\" + MoustacheNames[0];
                #endregion
                RefreshHeadPhoto();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        //列表选择图片
        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectitem = ListView.SelectedItems.Cast<ListViewItem>().FirstOrDefault();
            if (selectitem != null)
            {
                RefreshSelectiem(selectitem.ImageIndex);
                RefreshHeadPhoto();
            }
        }

        //判断选中的是哪张图片
        private void RefreshSelectiem(int _seleIndex)
        {
            switch (Fag)
            {
                case 0:
                    hear.Face_path = @".\texture\Male\Face_shape\" + FaceNames[_seleIndex];
                    break;
                case 1:
                    hear.Eyebrow_path = @".\texture\Male\Eyebrow\" + EyebrowNames[_seleIndex];
                    break;
                case 2:
                    hear.Eye_A_path = @".\texture\Male\Eyes\" + EyeANames[_seleIndex];
                    hear.Eye_B_path = @".\texture\Male\Eyes\" + EyeBNames[_seleIndex];
                    break;
                case 3:
                    hear.Nose_path = @".\texture\Male\Nose\" + NoseNames[_seleIndex];
                    break;
                case 4:
                    hear.Mouth_path = @".\texture\Male\Mouth\" + MouthNames[_seleIndex];
                    break;
                case 5:
                    hear.Hair_Front_path = @".\texture\Male\Hair_Front\" + FrontHairNames[_seleIndex];
                    break;
                case 6:
                    if (_seleIndex >= BackHairFag)
                    {
                        hear.is_HairFrontDouble = false;
                        hear.Hair_Back_B_path = @".\texture\Male\Hair_Back\one\" + BackHairANames[_seleIndex];
                    }
                    else
                    {
                        hear.is_HairFrontDouble = true;
                        hear.Hair_Back_A_path = @".\texture\Male\Hair_Back\double\" + BackHairANames[_seleIndex];
                        hear.Hair_Back_B_path = @".\texture\Male\Hair_Back\double\" + BackHairBNames[_seleIndex];
                    }
                    break;
                case 7:
                    hear.Ear_path = @".\texture\Male\Ear\" + EarNames[_seleIndex];
                    break;
                case 8:
                    hear.Moustache_path = @".\texture\Male\Moustache\" + MoustacheNames[_seleIndex];
                    break;
                default:
                    break;
            }
        }

        //刷新列表
        private void RefreshListView(List<string> _namelist, ImageList _imagelist)
        {
            try
            {
                //初始化
                this.ListView.View = View.LargeIcon;
                this.ListView.LargeImageList = _imagelist;

                //开始绑定
                this.ListView.BeginUpdate();
                this.ListView.Items.Clear();//Item:项目

                for (int i = 0; i < _namelist.Count; i++)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.ImageIndex = i;
                    lvi.Text = _namelist[i];
                    this.ListView.Items.Add(lvi);
                    //Thread.Sleep(200);
                }
                this.ListView.EndUpdate();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //刷新预览图像
        private void RefreshHeadPhoto()
        {

            Bitmap FrontHairBmp = new Bitmap(hear.Hair_Front_path);
            Bitmap FaceBmp = new Bitmap(hear.Face_path);
            Bitmap EarBmp = new Bitmap(hear.Ear_path);
            Bitmap EyebrowBmp = new Bitmap(hear.Eyebrow_path);
            Bitmap EyeABmp = new Bitmap(hear.Eye_A_path);
            Bitmap EyeBBmp = new Bitmap(hear.Eye_B_path);
            Bitmap BackHairABmp = new Bitmap(hear.Hair_Back_A_path);
            Bitmap BackHairBBmp = new Bitmap(hear.Hair_Back_B_path);
            Bitmap NoseBmp = new Bitmap(hear.Nose_path);
            Bitmap MouthBmp = new Bitmap(hear.Mouth_path);
            Bitmap MoustacheBmp = new Bitmap(hear.Moustache_path);
            Bitmap NeckBmp = new Bitmap(@".\texture\Male\Neck.png");
            Bitmap b = new Bitmap(NeckBmp.Width, NeckBmp.Height);
            //using用途：清理非托管资源，不受GC控制的资源。Using结束后会隐式的调用Disposable方法。
            using (Graphics g = Graphics.FromImage(b))
            {
                FrontHairBmp = ChangeColor(FrontHairBmp, hear.hue, hear.saturation, hear.lightness);
                BackHairBBmp = ChangeColor(BackHairBBmp, hear.hue, hear.saturation, hear.lightness);
                EyebrowBmp = ChangeColor(EyebrowBmp, hear.hue, hear.saturation, hear.lightness);
                EyeBBmp = ChangeColor(EyeBBmp, hear.hue_Eye, hear.saturation_Eye, hear.lightness_Eye);
                MoustacheBmp = ChangeColor(MoustacheBmp, hear.hue, hear.saturation, hear.lightness);

                Rectangle tempPos = new Rectangle(0, 0, NeckBmp.Width, NeckBmp.Height);
                if (hear.is_HairFrontDouble)
                {
                    BackHairABmp = ChangeColor(BackHairABmp, hear.hue, hear.saturation, hear.lightness);
                    g.DrawImage(BackHairABmp, tempPos);
                }
                g.DrawImage(NeckBmp, tempPos);
                g.DrawImage(FaceBmp, tempPos);
                g.DrawImage(BackHairBBmp, tempPos);
                g.DrawImage(EarBmp, tempPos);
                g.DrawImage(MouthBmp, tempPos);
                g.DrawImage(NoseBmp, tempPos);
                g.DrawImage(MoustacheBmp, tempPos);
                g.DrawImage(EyeABmp, tempPos);
                g.DrawImage(EyeBBmp, tempPos);
                g.DrawImage(EyebrowBmp, tempPos);
                g.DrawImage(FrontHairBmp, tempPos);
                this.preview_Hear_photo.Image = b;
            }
            //注意要释放资源
            FrontHairBmp.Dispose();
            BackHairBBmp.Dispose();
            BackHairABmp.Dispose();
            MoustacheBmp.Dispose();
            MouthBmp.Dispose();
            NoseBmp.Dispose();
            EyeABmp.Dispose();
            EyeBBmp.Dispose();
            FaceBmp.Dispose();
            EyebrowBmp.Dispose();
            EarBmp.Dispose();
            NeckBmp.Dispose();
        }

        //改变颜色 对于hue，范围为0 - 360，对于saturation或value，范围为0 - 1。
        private Bitmap ChangeColor(Bitmap srcBitmap, double _H, double _S, double _V)
        {

            Bitmap newbitmap = srcBitmap.Clone() as Bitmap;
            double saturation, hue, value;
            if (srcBitmap != null)
            {
                Rectangle rect = new Rectangle(0, 0, newbitmap.Width, newbitmap.Height);
                System.Drawing.Imaging.BitmapData bmpdata = newbitmap.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, newbitmap.PixelFormat);
                IntPtr ptr = bmpdata.Scan0;

                int bytes = newbitmap.Width * newbitmap.Height * 4;
                byte[] rgbvalues = new byte[bytes];
                System.Runtime.InteropServices.Marshal.Copy(ptr, rgbvalues, 0, bytes);

                for (int i = 0; i < rgbvalues.Length; i += 4)
                {
                    //A为零时剔除
                    if (rgbvalues[i + 3] == 0)
                        continue;

                    //先把颜色转成HSV进行调节
                    int max = Math.Max(rgbvalues[i + 2], Math.Max(rgbvalues[i + 1], rgbvalues[i]));
                    int min = Math.Min(rgbvalues[i + 2], Math.Min(rgbvalues[i + 1], rgbvalues[i]));
                    saturation = (max == 0) ? 0 : 1d - (1d * min / max);
                    value = max / 255d;

                    saturation *= _S;
                    value *= _V;
                    hue = _H;

                    //转回RGB
                    ColorFromHSV(hue, saturation, value, out rgbvalues[i + 2], out rgbvalues[i + 1], out rgbvalues[i]);
                }

                System.Runtime.InteropServices.Marshal.Copy(rgbvalues, 0, ptr, bytes);

                newbitmap.UnlockBits(bmpdata);
            }
            return newbitmap;
        }
        //把hsv转回color
        public static void ColorFromHSV(double hue, double saturation, double value, out byte R, out byte G, out byte B)
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            if (hi == 0)
            {
                R = (byte)v; G = (byte)t; B = (byte)p;
            }
            else if (hi == 1)
            {
                R = (byte)q; G = (byte)v; B = (byte)p;
            }
            else if (hi == 2)
            {
                R = (byte)p; G = (byte)v; B = (byte)t;
            }
            else if (hi == 3)
            {
                R = (byte)p; G = (byte)q; B = (byte)v;
            }
            else if (hi == 4)
            {
                R = (byte)t; G = (byte)p; B = (byte)v;
            }
            else
            {
                R = (byte)v; G = (byte)p; B = (byte)q;
            }
        }

        
        //生成头像
        private void Button_Make_Click_1(object sender, EventArgs e)
        {
            from_parent.HeadTexturWindow.BackgroundImage = this.preview_Hear_photo.Image;
            this.Close();
        }
        //读档
        private void Button_load_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @".\HeadFile";
            openFileDialog.Filter = "头部文件|*.mheadfile*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            //显示对话框，如果选中则关闭对话框
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream file = new FileStream(openFileDialog.FileName, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                hear = bf.Deserialize(file) as Head_Male;
                //读取之后再刷新一下
                RefreshHeadPhoto();
                file.Close();
            }

        }
        //存档
        private void button1_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.InitialDirectory = @".\HeadFile";
            saveFile.Filter = "头部文件|*.mheadfile*";
            saveFile.RestoreDirectory = true;
            saveFile.FilterIndex = 1;
            saveFile.FileName = "temp.mheadfile";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                FileStream file = new FileStream(saveFile.FileName, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, hear);
                file.Close();
            }
        }

    }
}
