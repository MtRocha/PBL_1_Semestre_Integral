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

namespace PBL_1_Semestre_Integral
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Connect the Paint event of the PictureBox to the event handler method.
            pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.Controls.Add(pictureBox1);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PointF[] points = new PointF[4];

            points[0].X = 3;
            points[0].Y = 12;
            points[1].Y = 34;
            points[1].X = 354;
            points[2].X = 35;
            points[2].Y = 354;
            points[3].X = 354;
            points[3].Y = 321;

            Graphics graphics = pictureBox1.CreateGraphics();
            Pen brush = new Pen(Color.Red);
            GraphicsPath path = new GraphicsPath();

            path.AddCurve(points, 1);

            graphics.DrawCurve(brush, points);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen pen = new Pen(Color.Red);

            var dx0 = (int)(e.ClipRectangle.Width / 4.0);
            var dy0 = (int)(e.ClipRectangle.Height / 4.0);

            // draw X axis
            e.Graphics.DrawLine(new Pen(Color.Black), 0, pictureBox1.Height / 2, pictureBox1.Width, pictureBox1.Height / 2);

            // draw Y axis
            e.Graphics.DrawLine(new Pen(Color.Black), pictureBox1.Width / 2, 0, pictureBox1.Width / 2, e.ClipRectangle.Height);
            base.OnPaint(e);
        }
    }
}