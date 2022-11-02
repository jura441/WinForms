using System.Drawing;
using System.Drawing.Drawing2D;

namespace Lesson5GDI
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
           // Pen pn = new Pen(Brushes.Blue, 1);
            //pn.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            //graphics.DrawEllipse(pn, 50, 100, 170, 40);


            GraphicsPath path = new GraphicsPath();
            // path.AddEllipse(170, 170, 100, 50);
            // graphics.FillPath(Brushes.Aqua, path);
            path.StartFigure();
           // path.AddCurve(points, 0.5F);
           // path.AddLine(50, 150, 50, 220);
            
            //path.AddArc(100, 30, 60, 60, 0, -170);
            //path.AddArc(100, 30, 60, 60, 0, 180);

            graphics.DrawLine(new Pen(Brushes.Red, 5), new Point(400, 400), new Point(400, 500));
            graphics.DrawLine(new Pen(Brushes.Red, 5), new Point(400, 420), new Point(360, 460));
            graphics.DrawLine(new Pen(Brushes.Red, 5), new Point(400, 420), new Point(480, 460));
            graphics.DrawLine(new Pen(Brushes.Red, 5), new Point(400, 500), new Point(360, 540));
            graphics.DrawLine(new Pen(Brushes.Red, 5), new Point(400, 500), new Point(440, 540));
            graphics.DrawEllipse(new Pen(Brushes.Blue, 5), 375,350,50,50);
            graphics.DrawLine(new Pen(Brushes.Red, 5), new Point(480, 330), new Point(480, 500));
            graphics.DrawEllipse(new Pen(Brushes.Blue, 5), 480,330,20,20);




            path.CloseFigure();
            //graphics.DrawPath(new Pen(Color.Blue, 3), path);
            graphics.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}