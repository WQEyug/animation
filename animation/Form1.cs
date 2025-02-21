using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animation
{
    public partial class Form1 : Form
    {
        static Image F1 = animation.Properties.Resources.walkF1;
        static Image F2 = Resource1.walkF2;
        static Image B1 = Resource1.walkB1;
        static Image B2 = Resource1.walkB2;
        static Image L1 = Resource1.walkL1;
        static Image L2 = Resource1.walkL2;
        static Image R2 = Resource1.walkR2;
        static Image R1 = Resource1.walkR1;
        Image man = F1;
        static int y = 20;
        static int x = 20;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(man, x, y,30,40);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                if(man==L1)
                {
                    man = L2;
                }
                else
                {
                    man=L1;
                }
                x = x - 10;
                pictureBox1.Refresh();
                pictureBox1.Update();
            }
            if (e.KeyCode == Keys.D)
            {
                if (man == R1)
                {
                    man = R2;
                }
                else
                {
                    man = R1;
                }
                x = x + 10;
                pictureBox1.Refresh();
                pictureBox1.Update();
            }
            if (e.KeyCode == Keys.S)
            {
                if (man == F1)
                {
                    man = F2;
                }
                else
                {
                    man = F1;
                }
                y=y+10;
                pictureBox1.Refresh();
                pictureBox1.Update();
            }
            if (e.KeyCode == Keys.W)
            {
                if (man == B1)
                {
                    man = B2;
                }
                else
                {
                    man = B1;
                }
                y = y - 10;
                pictureBox1.Refresh();
                pictureBox1.Update();
            }
        }
    }
}
