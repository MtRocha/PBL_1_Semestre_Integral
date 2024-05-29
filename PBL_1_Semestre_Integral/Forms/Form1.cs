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
using PBL_1_Semestre_Integral.Services;
using System.Reflection;

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
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Obtem as dimensões do PictureBox
            int width = pictureBox1.Width;
            int height = pictureBox1.Height;

            // Calcula o centro do PictureBox
            int centerX = width / 2;
            int centerY = height / 2;

            // Desenha os eixos X e Y
            Pen axisPen = new Pen(Color.Black, 2);
            g.DrawLine(axisPen, new Point(centerX, 0), new Point(centerX, height));
            g.DrawLine(axisPen, new Point(0, centerY), new Point(width, centerY));

            // Desenha as linhas da grade
            Pen gridPen = new Pen(Color.LightGray, 1);
            for (int x = centerX; x < width; x += 20)
            {
                g.DrawLine(gridPen, new Point(x, 0), new Point(x, height));
            }
            for (int x = centerX; x > 0; x -= 20)
            {
                g.DrawLine(gridPen, new Point(x, 0), new Point(x, height));
            }
            for (int y = centerY; y < height; y += 20)
            {
                g.DrawLine(gridPen, new Point(0, y), new Point(width, y));
            }
            for (int y = centerY; y > 0; y -= 20)
            {
                g.DrawLine(gridPen, new Point(0, y), new Point(width, y));
            }

            // Desenha uma curva (por exemplo, uma parábola)
            Pen curvePen = new Pen(Color.Red, 2);
            for (int x = -centerX; x < centerX; x++)
            {
                // y = (x / 20)^2 para desenhar uma parábola
                int screenX = centerX + x;
                int screenY = centerY - (x * x) / 400;

                // Desenhe o ponto (ou linha entre pontos)
                g.DrawRectangle(curvePen, screenX, screenY, 1, 1);
            }
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.DesenhaFuncaoSegundoGrau);
            this.Controls.Add(pictureBox1);
            




        }

        public void DesenhaFuncaoSegundoGrau(object sender, PaintEventArgs e)
        {
           
            Graphics g = e.Graphics;

            // Obtem as dimensões do PictureBox
            int width = pictureBox1.Width;
            int height = pictureBox1.Height;

            // Calcula o centro do PictureBox
            int centerX = width / 2;
            int centerY = height / 2;
            pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            Pen curvePen = new Pen(Color.Red, 2);

            double cofA = double.Parse(CoeficienteSegundGrau1.Text);
            double cofB = double.Parse(CoeficienteSegundGrau2.Text);
            double cofC = double.Parse(CoeficienteSegundGrau3.Text);

            for (int x = -centerX; x < centerX; x++)
            {
                // y = (x / 20)^2 para desenhar uma parábola
                int screenX = centerX + x;
                int screenY = centerY - (x * x) / 400;



                // Desenhe o ponto (ou linha entre pontos)
                g.DrawRectangle(curvePen, screenX, (float)Calculo.FuncaoSegundoGrau(screenX, cofC, cofB, cofC), 1, 1);
            }
            


        }

    }
}