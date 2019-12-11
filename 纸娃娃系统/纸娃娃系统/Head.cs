using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 纸娃娃系统
{
    [Serializable]
    class Head
    {
        //后面的头发是双层的
        public bool is_HairFrontDouble;
        //后面的头发A(如果是单层的就只读取这个)
        public string Hair_Back_A_path;
        //后面的头发B
        public string Hair_Back_B_path;
        //前面头发图片路径
        public string Hair_Front_path;
        //嘴巴图片路径
        public string Mouth_path;
        //鼻子图片路径
        public string Nose_path;
        //脸图片路径
        public string Face_path;
        //耳朵图片路径
        public string Ear_path;
        //眉毛图片路径
        public string Eyebrow_path;
        //眼睛图片A路径
        public string Eye_A_path;
        //眼睛图片B路径
        public string Eye_B_path;
        //色相
        public double hue;
        //饱和度
        public double saturation;
        //亮度
        public double lightness;
        //眼睛色相
        public double hue_Eye;
        //眼睛饱和度
        public double saturation_Eye;
        //眼睛亮度
        public double lightness_Eye;

    }
}
