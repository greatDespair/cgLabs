using cgLabs.Animation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace cgLabs
{
    public partial class Form1 : Form
    {
        double[,] ScreenMatrix;
        Plane plane;
        public Form1()
        {
            plane = new Plane();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ScreenMatrix = new double[615, 935];
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawNewPlane();
            projectionButton.Enabled = true;
            button1.Enabled = false;
        }
        private void drawNewPlane()
        {
            drawPlane();
            reflectPlane();
            scalePlane(4);
            movePlaneX(50);
            movePlaneY(50);
            rotatePlaneZ(135);
            fillPlane();

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

            fillPlane();
            /*            foreach (Figure figure in plane.figureList)
                        {
                            figure.draw(g, p);
                        }*/

        }
        private void clearGraphics(Graphics g)
        {
            foreach (Figure figure in plane.figureList)
            {
                figure.clear(g);
            }
        }
        private void movePlaneX(int x)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);

            clearGraphics(g);

            foreach (Figure figure in plane.figureList)
            {
                figure.moveX(g, p, x);
            }

            Figure.ox += x;
            fillPlane();
        }
        private void movePlaneY(int y)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);

            clearGraphics(g);

            foreach (Figure figure in plane.figureList)
            {
                figure.moveY(g, p, y);
            }

            Figure.oy += y;
            fillPlane();
        }
        private void rotatePlaneX(int degree)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);

            clearGraphics(g);
            plane.XRotate += degree;
            foreach (Figure figure in plane.figureList)
            {
                figure.rotateX(g, p, degree);
            }
            fillPlane();
        }
        private void rotatePlaneY(int degree)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);

            clearGraphics(g);
            plane.YRotate += degree;

            foreach (Figure figure in plane.figureList)
            {
                figure.rotateY(g, p, degree);
            }
            fillPlane();
        }
        private void rotatePlaneZ(int degree)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);

            clearGraphics(g);

            foreach (Figure figure in plane.figureList)
            {
                figure.rotateZ(g, p, degree);
            }
            fillPlane();

        }
        private void scalePlane(double scale)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);

            clearGraphics(g);

            foreach (Figure figure in plane.figureList)
            {
                figure.scale(g, p, scale);
            }

            fillPlane();
        }
        private void drawProjection()
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);

            clearGraphics(g);

            Plane projectionPlane = plane.getCopy();

            foreach (Figure figure in projectionPlane.figureList)
            {
                figure.projection(g, p, 45);
            }
        }
        private void reflectPlane()
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);

            clearGraphics(g);

            foreach (Figure figure in plane.figureList)
            {
                figure.reflect(g, p);
            }

        }
        //935,615
        private void TestButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);

            clearGraphics(g);



            uint[] AnimationSequence = new uint[]
            {
                 1, 2, 1, 2, 1, 2, 1, 2, 1, 3, 4, 2, 5, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 5, 3, 4, 2, 1, 2, 1, 2, 1, 2, 1, 2, 5, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 5, 3, 4,
                 1, 2, 1, 2, 1, 2, 1, 2, 1, 3, 4, 2, 5, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 5, 3, 4, 2, 1, 2, 1, 2, 1, 2, 1, 2, 5, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 5, 3, 4,
                 1, 2, 1, 2, 1, 3, 4, 2, 5, 1, 2, 1, 2, 1, 2, 5, 3, 4, 2, 1, 2, 1, 2, 1, 3, 4, 2, 5, 1, 2, 1, 2, 1, 2, 1, 2, 5, 3, 4, 6,
                 1, 2, 1, 2, 3, 4, 6, 3, 4, 6, 3, 4, 6, 6, 3, 4, 6, 3, 4, 1, 2, 1, 2, 3, 4, 1, 2, 7, 6, 6, 6, 6, 7, 6, 6, 6, 6, 7, 6, 6, 6, 6, 7, 6, 6, 6, 6, 6, 7, 6
            };

            BaseAnimation epicFly = new BaseAnimation(AnimationSequence);
            epicFly.Play(() => movePlaneX(5), 
                         () => movePlaneY(5), 
                         () => rotatePlaneX(-4), 
                         () => rotatePlaneY(4), 
                         () => scalePlane(1.04),
                         () => scalePlane(1.2), 
                         () => rotatePlaneZ(5));
        }

        public void fillPlane()
        {
            Graphics g = this.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.Gray);
            int i = 1;
            if ((((plane.XRotate - 180) % 360 > -180) && ((plane.XRotate - 180) % 360 < 180)) &&
                (((plane.YRotate - 180) % 360 > -180) && ((plane.YRotate - 180) % 360 < 180)))
            {
                int intColor = (int)Math.Abs(90 - Math.Abs(Math.Min(plane.XRotate % 180, plane.YRotate % 180))) % 90;
                foreach (Figure figure in plane.figureList)
                {
                    if ((i > 16) && (i < 47))
                        brush.Color = Color.DarkGray;
                    if (i > 46)
                        brush.Color = Color.FromArgb(255, 63, 82, 46 + intColor);
                    figure.fill(g, brush);
                    i++;

                }
            }
            else
            {
                Plane reversePlane = plane.getCopy();
                reversePlane.figureList.Reverse();
                int intColor = (int)Math.Abs(90 - Math.Abs(Math.Min(plane.XRotate % 180, plane.YRotate % 180))) % 90;
                foreach (Figure figure in reversePlane.figureList)
                {
                    if ((i > 16) && (i < 47))
                        brush.Color = Color.DarkGray;
                    if (i > 46)
                        brush.Color = Color.FromArgb(255, 63, 82, 46 + intColor);
                    figure.fill(g, brush);
                    i++;

                }
            }
        }
    }
}

