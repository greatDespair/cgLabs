using System;
using System.Drawing;
using System.Windows.Forms;

namespace cgLabs
{
    public partial class Form1 : Form
    {
        Plane plane;
        public Form1()
        {
            plane = new Plane();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawPlane();
            reflectPlane();
            scalePlane(4);
            movePlaneX(150);
            movePlaneY(150);

            projectionButton.Enabled = true;
            button1.Enabled = false;
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            movePlaneX(-20);
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            movePlaneX(20);
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            movePlaneY(-20);
        }


        private void downButton_Click(object sender, EventArgs e)
        {
            movePlaneY(20);
        }

        private void rotateLeft_Click(object sender, EventArgs e)
        {
            rotatePlaneX(15);
        }

        private void rotateRight_Click(object sender, EventArgs e)
        {
            rotatePlaneX(-15);
        }

        private void scaleDown_Click(object sender, EventArgs e)
        {
            scalePlane(0.5);
        }

        private void scaleUp_Click(object sender, EventArgs e)
        {
            scalePlane(2);
        }


        private void rotateLeftY_Click(object sender, EventArgs e)
        {
            rotatePlaneY(15);
        }

        private void rotateRightY_Click(object sender, EventArgs e)
        {
            rotatePlaneY(-15);
        }

        private void rotateLeftZ_Click(object sender, EventArgs e)
        {
            rotatePlaneZ(15);
        }

        private void rotateRightZ_Click(object sender, EventArgs e)
        {
            rotatePlaneZ(-15);
        }

        private void projectionButton_Click(object sender, EventArgs e)
        {
            drawProjection();
        }

        private void drawPlane()
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);

            clearGraphics(g);

            foreach (Figure figure in plane.figureList1)
            {
                figure.draw(g, p);
            }
            foreach (Figure figure in plane.figureList2)
            {
                figure.draw(g, p);
            }
            foreach (Figure figure in plane.figureList3)
            {
                figure.draw(g, p);
            }
        }
        private void clearGraphics(Graphics g)
        {
            foreach (Figure figure in plane.figureList1)
            {
                figure.clear(g);
            }
            foreach (Figure figure in plane.figureList2)
            {
                figure.clear(g);
            }
            foreach (Figure figure in plane.figureList3)
            {
                figure.clear(g);
            }
        }
        private void movePlaneX(int x)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);

            clearGraphics(g);

            foreach (Figure figure in plane.figureList1)
            {
                figure.moveX(g, p, x);
            }
            foreach (Figure figure in plane.figureList2)
            {
                figure.moveX(g, p, x);
            }
            foreach (Figure figure in plane.figureList3)
            {
                figure.moveX(g, p, x);
            }
            Figure.ox += x;
        }
        private void movePlaneY(int y)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);

            clearGraphics(g);

            foreach (Figure figure in plane.figureList1)
            {
                figure.moveY(g, p, y);
            }
            foreach (Figure figure in plane.figureList2)
            {
                figure.moveY(g, p, y);
            }
            foreach (Figure figure in plane.figureList3)
            {
                figure.moveY(g, p, y);
            }
            Figure.oy += y;
        }
        private void rotatePlaneX(int degree)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);

            clearGraphics(g);

            foreach (Figure figure in plane.figureList1)
            {
                figure.rotateX(g, p, degree);
            }
            foreach (Figure figure in plane.figureList2)
            {
                figure.rotateX(g, p, degree);
            }
            foreach (Figure figure in plane.figureList3)
            {
                figure.rotateX(g, p, degree);
            }
        }
        private void rotatePlaneY(int degree)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);

            clearGraphics(g);

            foreach (Figure figure in plane.figureList1)
            {
                figure.rotateY(g, p, degree);
            }
            foreach (Figure figure in plane.figureList2)
            {
                figure.rotateY(g, p, degree);
            }
            foreach (Figure figure in plane.figureList3)
            {
                figure.rotateY(g, p, degree);
            }
        }
        private void rotatePlaneZ(int degree)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);

            clearGraphics(g);

            foreach (Figure figure in plane.figureList1)
            {
                figure.rotateZ(g, p, degree);
            }
            foreach (Figure figure in plane.figureList2)
            {
                figure.rotateZ(g, p, degree);
            }
            foreach (Figure figure in plane.figureList3)
            {
                figure.rotateZ(g, p, degree);
            }
        }
        private void scalePlane(double scale)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);

            clearGraphics(g);

            foreach (Figure figure in plane.figureList1)
            {
                figure.scale(g, p, scale);
            }
            foreach (Figure figure in plane.figureList2)
            {
                figure.scale(g, p, scale);
            }
            foreach (Figure figure in plane.figureList3)
            {
                figure.scale(g, p, scale);
            }
        }
        private void drawProjection()
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);

            clearGraphics(g);

            Plane projectionPlane = plane.getCopy();

            foreach (Figure figure in projectionPlane.figureList1)
            {
                figure.projection(g, p, 45);
            }
            foreach (Figure figure in projectionPlane.figureList2)
            {
                figure.projection(g, p, 45);
            }

            foreach (Figure figure in projectionPlane.figureList3)
            {
                figure.projection(g, p, 45);
            }
        }
        private void reflectPlane()
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);

            clearGraphics(g);

            foreach (Figure figure in plane.figureList1)
            {
                figure.reflect(g, p);
            }
            foreach (Figure figure in plane.figureList2)
            {
                figure.reflect(g, p);
            }
            foreach (Figure figure in plane.figureList3)
            {
                figure.reflect(g, p);
            }
        }
    }
}
