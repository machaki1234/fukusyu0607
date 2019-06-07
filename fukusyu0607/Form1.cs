using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukusyu0607
{
    public partial class Form1 : Form
    {
        //疑似乱数
        //ランダムのシード(種)を指定して初期化したら、
        //それを使い続ける
        private static Random rand = new Random();
        int vx =rand.Next(-10,11);
        int vy = rand.Next(-10, 11);
        int vx1 = rand.Next(-10, 11);
        int vy1 = rand.Next(-10, 11);
        int vx2 = rand.Next(-10, 11);
        int vy2 = rand.Next(-10, 11);
        int time = 100 * 5;

        public Form1()
        {
            InitializeComponent();
            
            // 以下にlabel1.Leftとlabel1.Topの座標をランダムで求めよ
            label1.Left = rand.Next(ClientSize.Width - label1.Width);
            label1.Top = rand.Next(ClientSize.Height - label1.Height);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            Point p = PointToClient(MousePosition);

            if ((p.X >= label1.Left)
                && (p.X < label1.Right)
                && (p.Y >= label1.Top)
                && (p.Y < label1.Bottom))
            {
                timer1.Enabled = false;
            }
            
            label1.Left += vx;
            label1.Top += vy;

            if(label1.Left<0)
            {
                vx = Math.Abs(vx);
            }
            if(label1.Top<0)
            {
                vy = Math.Abs(vy);
            }
            if (label1.Right > ClientSize.Width)
            {
                vx = -Math.Abs(vx);
            }
            if (label1.Bottom > ClientSize.Height)
            {
                vy = -Math.Abs(vy);
            }

            if ((p.X >= label2.Left)
                && (p.X < label2.Right)
                && (p.Y >= label2.Top)
                && (p.Y < label2.Bottom))
            {
                timer1.Enabled = false;
            }

            label2.Left += vx1;
            label2.Top += vy1;

            if (label2.Left < 0)
            {
                vx1 = Math.Abs(vx1);
            }
            if (label2.Top < 0)
            {
                vy1 = Math.Abs(vy1);
            }
            if (label2.Right > ClientSize.Width)
            {
                vx1 = -Math.Abs(vx1);
            }
            if (label2.Bottom > ClientSize.Height)
            {
                vy1 = -Math.Abs(vy1);
            }

            if ((p.X >= label3.Left)
                && (p.X < label3.Right)
                && (p.Y >= label3.Top)
                && (p.Y < label3.Bottom))
            {
                timer1.Enabled = false;
            }

            label3.Left += vx2;
            label3.Top += vy2;

            if (label3.Left < 0)
            {
                vx2 = Math.Abs(vx2);
            }
            if (label3.Top < 0)
            {
                vy2 = Math.Abs(vy2);
            }
            if (label3.Right > ClientSize.Width)
            {
                vx2 = -Math.Abs(vx2);
            }
            if (label3.Bottom > ClientSize.Height)
            {
                vy2 = -Math.Abs(vy2);
            }
           // timer1--;



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
