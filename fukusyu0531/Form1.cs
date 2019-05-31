using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukusyu0531
{
    public partial class Form1 : Form
    {
        int vx = -10;
        int vy = -10;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;
            
            Text = MousePosition.X + ", " + MousePosition.Y;
            //マウスポジションをクライアント座標に置き換える
            Point p = PointToClient(MousePosition);

            label2.Left = p.X - label2.Width / 2;
            label2.Top = p.Y - label2.Height / 2;

            if ((label1.Left <= p.X) && (label1.Right >= p.X) && (label1.Top <= p.Y) && (label1.Bottom >= p.Y))
            {
                label1.Visible = false;
            }
            else
            {
                label1.Visible = true;
            }


            if (label1.Left > ClientSize.Width - label1.Width)
            {
                //Math.Abs()  絶対値
                //vx = -vx だけだと画面外に行ったときに戻ってこれない
                vx = -Math.Abs(vx);
            }
            if (label1.Left < 0)
            {
                vx = Math.Abs(vx);
            }
            if (label1.Top > ClientSize.Height - label1.Height)
            {
                vy = -Math.Abs(vy);
            }
            if (label1.Top < 0)
            {
                vy = Math.Abs(vy);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("" + ClientSize.Width + ", " + ClientSize.Height);
            MessageBox.Show("" + label1.Width + ", " + label1.Height);


        }
    }
}
