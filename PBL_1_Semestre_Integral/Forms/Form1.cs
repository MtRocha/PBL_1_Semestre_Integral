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
using System.

namespace PBL_1_Semestre_Integral
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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


    }
}
