using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo3Guia1PED
{
    public partial class Form1 : Form
    {
        int x, y;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Point punto = new Point(e.X, e.Y);
            x = punto.X;
            y = punto.Y;
            panel1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Pen lapiz = new Pen(Color.Black);

           

                if (listBox1.SelectedIndex == 0)
                {
                    Random fill = new Random();
                    int R = fill.Next(1, 256);
                    int G = fill.Next(1, 256);
                    int B = fill.Next(1, 256);
                    SolidBrush sb = new SolidBrush(Color.FromArgb(R, G, B));
                    Random size = new Random();
                    int xsize = size.Next(1, 200);
                    int ysize = size.Next(1, 200);
                    g.DrawEllipse(lapiz, x - 50, y - 50, xsize, ysize);
                    g.FillEllipse(sb, x - 50, y - 50, xsize, ysize);
                }
            
            
                if (listBox1.SelectedIndex == 1)
                {
                    Random fill = new Random();
                    int R = fill.Next(1, 256);
                    int G = fill.Next(1, 256);
                    int B = fill.Next(1, 256);
                    SolidBrush sb = new SolidBrush(Color.FromArgb(R, G, B));
                    Random size = new Random();
                    int xsize = size.Next(1, 200);
                    int ysize = size.Next(1, 200);
                    g.DrawRectangle(lapiz, x - 50, y - 50, xsize, ysize);
                    g.FillRectangle(sb, x - 50, y - 50, xsize, ysize);
                }
            
        }
    }
}
