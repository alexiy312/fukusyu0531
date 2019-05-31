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
        int x2 = -10, x3 = 5, x4 = -7;
        int y2 = 10, y3 = -5, y4 = -7;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;

            if (label1.Left > this.Width-50)
                vx = -vx;
            if (label1.Left < 0)
                vx = -vx;
            if (label1.Top > this.Height-50)
                vy = -vy;
            if (label1.Top < 0)
                vy = -vy;

            label2.Left += x2;
            label2.Top += y2;

            if (label2.Left > this.Width - 50)
                x2 = -x2;
            if (label2.Left < 0)
                x2 = -x2;
            if (label2.Top > this.Height - 50)
                y2 = -y2;
            if (label2.Top < 0)
                y2 = -y2;

            label3.Left += x3;
            label3.Top += y3;

            if (label3.Left > this.Width - 50)
                x3 = -x3;
            if (label3.Left < 0)
                x3 = -x3;
            if (label3.Top > this.Height - 50)
                y3 = -y3;
            if (label3.Top < 0)
                y3 = -y3;

            label4.Left += x4;
            label4.Top += y4;

            if (label4.Left > this.Width - 50)
                x4 = -x4;
            if (label4.Left < 0)
                x4 = -x4;
            if (label4.Top > this.Height - 50)
                y4 = -y4;
            if (label4.Top < 0)
                y4 = -y4;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
