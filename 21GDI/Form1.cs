using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _21GDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDrawLine_Click(object sender, EventArgs e)
        {
            //创建GDI+对象
            Graphics g = this.CreateGraphics();

            //创建Pen对象，参数为   笔的颜色
            Pen p = new Pen(Brushes.Green);

            Point p1 = new Point(50, 50);
            Point p2 = new Point(200, 200);

            //DrawLine参数：
            //1.Pen对象
            //2.开始的点Point对象
            //3.结束的点Point对象
            g.DrawLine(p, p1, p2);
        }

        private void btnDrawRect_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            Pen pen = new Pen(Brushes.Red);

            //矩形对象，参数对象：
            //1.X轴的坐标
            //2.Y轴的坐标
            //3.矩形的宽度
            //4.举行的长度
            Rectangle r = new Rectangle(100, 100, 100, 100);
            //绘制矩形
            g.DrawRectangle(pen, r);
        }

        private void btnDrawLetter_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            //参数：
            //1.绘制的文字
            //2.字体：设置字体和大小，以及其他样式
            //3.绘制的点
            g.DrawString("做全栈攻城狮", new Font("楷体", 20), Brushes.Red, new Point(150, 100));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;

            string str = string.Empty;

            Random rand = new Random();

            for (int i = 0; i < 5; i++)
            {
                int num =rand.Next(0, 10);
                str += num;
            }

            Bitmap bitmap = new Bitmap(150,40);//创建BitMap  150X40的
            Graphics g = Graphics.FromImage(bitmap);//直接画到Bitmap上


            for (int i = 0; i < 5; i++)
            {
                Point p = new Point(i * 20, 0);//指定位置，左上角
                Color[] colors = new Color[] { Color.Green,Color.Red,Color.Purple,Color.RoyalBlue};

                g.DrawString(str[i].ToString(), new Font("楷体", 20, FontStyle.Bold), new SolidBrush(colors[rand.Next(0, 4)]), p);
            }


            for (int i = 0; i < 20; i++)
            {
                //根据Bitmap的高和款，随机画线
                Point p1 = new Point(rand.Next(0, bitmap.Width), rand.Next(0, bitmap.Height));
                Point p2 = new Point(rand.Next(0, bitmap.Width), rand.Next(0, bitmap.Height));
                g.DrawLine(new Pen(Brushes.Green), p1, p2);
            }

            pictureBox1.Image = bitmap;

        }
    }
}
