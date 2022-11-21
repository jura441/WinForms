using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace MouseMoveClick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool mousePaint { get; set; }
        Pen Pen = new Pen(Brushes.Black, 5);
        Graphics g;
        Graphics gr;
        private Point start;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            start = e.Location;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            start = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                g.DrawEllipse(Pen, new Rectangle(e.Location, new Size(5, 5)));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mousePaint = false;
            g = this.CreateGraphics();
            gr = pictureBox1.CreateGraphics();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                gr.DrawEllipse(Pen, new Rectangle(e.Location, new Size(5, 5)));
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
