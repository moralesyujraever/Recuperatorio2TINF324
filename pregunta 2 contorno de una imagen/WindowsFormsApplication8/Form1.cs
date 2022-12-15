using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        Bitmap bmp, b2mp, b3mp;
        int x, y, r, s,t,w, contador=0;
        int mR = 0, mG = 0, mB = 0, m2R = 0, m2G = 0, m2B = 0, m3R = 0, m3G = 0, m3B = 0;
        int[,] array1 = new int[3, 3] { { 1, 0, 0 },{ 0, 1, 0 },
                                { 0, 0, 1 } };
        int[,] array2 = new int[3, 3] { { 10, 5, 100 },{ 10, 5, 100 },
                                { 50, 75, 25 } };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Todos|*.*|Archivos JPEG|*.jpg|Archivos GIF|*.gif";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            bmp = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = bmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Color c = new Color();
            c = bmp.GetPixel(10, 10);
            textBox1.Text = c.R.ToString();
            textBox2.Text = c.G.ToString();
            textBox3.Text = c.B.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    bmp2.SetPixel(i, j, Color.FromArgb(c.R, 0, 0));
                }
            pictureBox1.Image = bmp2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    bmp2.SetPixel(i, j, Color.FromArgb(0, c.G, 0));
                }
            pictureBox1.Image = bmp2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    bmp2.SetPixel(i, j, Color.FromArgb(0, 0, c.B));
                }
            pictureBox1.Image = bmp2;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            contador++;
            if (contador == 1) { 
                x = e.X;
            y = e.Y;
            textBox4.Text = x.ToString();
            textBox5.Text = y.ToString();
            Color c = new Color();
            mR = 0; mG = 0; mB = 0;
            for (int i = x; i < x + 10; i++)
                for (int j = y; j < y + 10; j++)
                {
                    c = bmp.GetPixel(i, j);
                    mR = mR + c.R;
                    mG = mG + c.G;
                    mB = mB + c.B;
                }
            mR = mR / 100;
            mG = mG / 100;
            mB = mB / 100;
            textBox1.Text = mR.ToString();
            textBox2.Text = mG.ToString();
            textBox3.Text = mB.ToString();
            }
            if (contador == 2)
            {
                r = e.X;
                s = e.Y;
                textBox4.Text = r.ToString();
                textBox5.Text = s.ToString();
                Color c = new Color();
                m2R = 0; m2G = 0; m2B = 0;
                for (int i = r; i < r + 10; i++)
                    for (int j = s; j < s + 10; j++)
                    {
                        c = bmp.GetPixel(i, j);
                        m2R = m2R + c.R;
                        m2G = m2G + c.G;
                        m2B = m2B + c.B;
                    }
                m2R = m2R / 100;
                m2G = m2G / 100;
                m2B = m2B / 100;
                textBox1.Text = m2R.ToString();
                textBox2.Text = m2G.ToString();
                textBox3.Text = m2B.ToString();
            }
            if (contador == 3)
            {
                t = e.X;
                w = e.Y;
                textBox4.Text = t.ToString();
                textBox5.Text = w.ToString();
                Color c = new Color();
                m3R = 0; m3G = 0; m3B = 0;
                for (int i = t; i < t + 10; i++)
                    for (int j = w; j < w + 10; j++)
                    {
                        c = bmp.GetPixel(i, j);
                        m3R = m3R + c.R;
                        m3G = m3G + c.G;
                        m3B = m3B + c.B;
                    }
                m3R = m3R / 100;
                m3G = m3G / 100;
                m3B = m3B / 100;
                textBox1.Text = m3R.ToString();
                textBox2.Text = m3G.ToString();
                textBox3.Text = m3B.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Color cleido = new Color();
            cleido = bmp.GetPixel(x, y);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    if (((cleido.R - 10 <= c.R) && (c.R <= cleido.R + 10)) &&
                        ((cleido.G - 10 <= c.G) && (c.G <= cleido.G + 10)) &&
                        ((cleido.B - 10 <= c.B) && (c.B <= cleido.B + 10)))
                    {
                        bmp2.SetPixel(i, j, Color.Fuchsia);
                    }
                    else {
                        bmp2.SetPixel(i, j, Color.FromArgb(c.R, c.G, c.B));
                    }
            
                }
            pictureBox1.Image = bmp2;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int mRn= 0, mGn = 0, mBn = 0;
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            for (int i = 0; i < bmp.Width-10; i=i+10)
                for (int j = 0; j < bmp.Height-10; j=j+10)
                {

                    for (int i2 = i; i2 < i + 10; i2++)
                        for (int j2 = j; j2 < j + 10; j2++)
                        {
                            c = bmp.GetPixel(i2, j2);
                            mRn = mRn + c.R;
                            mGn = mGn + c.G;
                            mBn = mBn + c.B;
                        }
                    mRn = mRn / 100;
                    mGn = mGn / 100;
                    mBn = mBn / 100;

                    if (((mR - 10 <= mRn) && (mRn <= mR + 10)) &&
                        ((mG - 10 <= mGn) && (mGn <= mG + 10)) &&
                        ((mB - 10 <= mBn) && (mBn <= mB + 10)))
                    {
                        for (int i2 = i; i2 < i + 10; i2++)
                            for (int j2 = j; j2 < j + 10; j2++)
                            {
                                bmp2.SetPixel(i2, j2, Color.Fuchsia);
                            }
                    }
                    else
                    {
                        for (int i2 = i; i2 < i + 10; i2++)
                            for (int j2 = j; j2 < j + 10; j2++)
                            {
                                c = bmp.GetPixel(i2, j2);
                                bmp2.SetPixel(i2, j2, Color.FromArgb(c.R, c.G, c.B));
                            }
                    }
                }

            bmp =bmp2;
            mR = m2R;
            mG = m2G;
            mB = m2B;
            
            for (int i = 0; i < bmp.Width - 10; i = i + 10)
                for (int j = 0; j < bmp.Height - 10; j = j + 10)
                {

                    for (int i2 = i; i2 < i + 10; i2++)
                        for (int j2 = j; j2 < j + 10; j2++)
                        {
                            c = bmp.GetPixel(i2, j2);
                            mRn = mRn + c.R;
                            mGn = mGn + c.G;
                            mBn = mBn + c.B;
                        }
                    mRn = mRn / 100;
                    mGn = mGn / 100;
                    mBn = mBn / 100;

                    if (((mR - 10 <= mRn) && (mRn <= mR + 10)) &&
                        ((mG - 10 <= mGn) && (mGn <= mG + 10)) &&
                        ((mB - 10 <= mBn) && (mBn <= mB + 10)))
                    {
                        for (int i2 = i; i2 < i + 10; i2++)
                            for (int j2 = j; j2 < j + 10; j2++)
                            {
                                bmp2.SetPixel(i2, j2, Color.LightGreen);
                            }
                    }
                    else
                    {
                        for (int i2 = i; i2 < i + 10; i2++)
                            for (int j2 = j; j2 < j + 10; j2++)
                            {
                                c = bmp.GetPixel(i2, j2);
                                bmp2.SetPixel(i2, j2, Color.FromArgb(c.R, c.G, c.B));
                            }
                    }
                }

            bmp =bmp2;
            mR = m3R;
            mG = m3G;
            mB = m3B;
            
            for (int i = 0; i < bmp.Width - 10; i = i + 10)
                for (int j = 0; j < bmp.Height - 10; j = j + 10)
                {

                    for (int i2 = i; i2 < i + 10; i2++)
                        for (int j2 = j; j2 < j + 10; j2++)
                        {
                            c = bmp.GetPixel(i2, j2);
                            mRn = mRn + c.R;
                            mGn = mGn + c.G;
                            mBn = mBn + c.B;
                        }
                    mRn = mRn / 100;
                    mGn = mGn / 100;
                    mBn = mBn / 100;

                    if (((mR - 10 <= mRn) && (mRn <= mR + 10)) &&
                        ((mG - 10 <= mGn) && (mGn <= mG + 10)) &&
                        ((mB - 10 <= mBn) && (mBn <= mB + 10)))
                    {
                        for (int i2 = i; i2 < i + 10; i2++)
                            for (int j2 = j; j2 < j + 10; j2++)
                            {
                                bmp2.SetPixel(i2, j2, Color.AliceBlue);
                            }
                    }
                    else
                    {
                        for (int i2 = i; i2 < i + 10; i2++)
                            for (int j2 = j; j2 < j + 10; j2++)
                            {
                                c = bmp.GetPixel(i2, j2);
                                bmp2.SetPixel(i2, j2, Color.FromArgb(c.R, c.G, c.B));
                            }
                    }
                }
            pictureBox1.Image = bmp2;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            int i, j,n=0,m=0,l;
            for (i = 0; i < bmp.Width; i++)
            {
                for (j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    bmp2.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                    n = j;
                }
                
                for (int k = 100; k > 60; k--)
                {
                    bmp2.SetPixel(i, n - k, Color.FromArgb(c.R, c.G, c.B));
                }
                n = 0;
                for (int k = 0; k < 30; k++)
                {
                    bmp2.SetPixel(i, n + k, Color.FromArgb(c.R, c.G, c.B));
                }
                m = bmp.Width;
               //// for (l = 0; m > m; m--)
               // {
               //     bmp2.SetPixel(i, m, Color.FromArgb(c.R, c.G, c.B));
               // }

            }
            
            pictureBox1.Image = bmp2;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Bitmap res = new Bitmap(bmp.Width, bmp.Height);
            int[][] sobelx = {new int[] {-1, 0, 1},
                          new int[] {-2, 0, 2},
                          new int[] {-1, 0, 1}};

            int[][] sobely = {new int[] {-1, -2, -1},
                          new int[] { 0, 0, 0},
                          new int[] { 1, 2, 1}};

            for (int i = 1; i < bmp.Width - 1; i++)
            {
                for (int j = 1; j < bmp.Height - 1; j++)
                {
                    int dx = bmp.GetPixel(i - 1, j - 1).R * sobelx[0][0] + bmp.GetPixel(i, j - 1).R * sobelx[0][1] + bmp.GetPixel(i + 1, j - 1).R * sobelx[0][2]
                              + bmp.GetPixel(i - 1, j).R * sobelx[1][0] + bmp.GetPixel(i, j).R * sobelx[1][1] + bmp.GetPixel(i + 1, j).R * sobelx[1][2]
                              + bmp.GetPixel(i - 1, j + 1).R * sobelx[2][0] + bmp.GetPixel(i, j + 1).R * sobelx[2][1] + bmp.GetPixel(i + 1, j + 1).R * sobelx[2][2];

                    int dy = bmp.GetPixel(i - 1, j - 1).R * sobely[0][0] + bmp.GetPixel(i, j - 1).R * sobely[0][1] + bmp.GetPixel(i + 1, j - 1).R * sobely[0][2]
                           + bmp.GetPixel(i - 1, j).R * sobely[1][0] + bmp.GetPixel(i, j).R * sobely[1][1] + bmp.GetPixel(i + 1, j).R * sobely[1][2]
                           + bmp.GetPixel(i - 1, j + 1).R * sobely[2][0] + bmp.GetPixel(i, j + 1).R * sobely[2][1] + bmp.GetPixel(i + 1, j + 1).R * sobely[2][2];
                    double derivata = Math.Sqrt((dx * dx) + (dy * dy));

                    if (derivata > 255)
                    {
                        res.SetPixel(i, j, Color.White);
                    }
                    else
                    {
                        res.SetPixel(i, j, Color.FromArgb(255, (int)derivata, (int)derivata, (int)derivata));
                    }
                }
            }

            pictureBox1.Image = res;
        }     
    }
}
