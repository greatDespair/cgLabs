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
            plane = Plane.getInstance();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);

            clearGraphics(g);

            foreach (Figure figure in plane.figureList)
            {
                figure.draw(g, p);
            }

            clearGraphics(g);

            foreach (Figure figure in plane.figureList)
            {
                figure.moveX(g, p, 250);
            }
            Figure.ox += 250;
            clearGraphics(g);

            foreach (Figure figure in plane.figureList)
            {
                figure.moveY(g, p, 250);
            }
            Figure.oy += 250;

            clearGraphics(g);

            foreach (Figure figure in plane.figureList)
            {
                figure.reflect(g, p);
            }
/*
            clearGraphics(g);

            foreach (Figure figure in plane.figureList)
            {
                figure.scale(g, p, 4);
            }*/
            
            rotateLeft.Enabled = true;
            rotateRight.Enabled = true;
            scaleDown.Enabled = true;
            scaleUp.Enabled = true;
            upButton.Enabled = true;
            downButton.Enabled = true;
            rightButton.Enabled = true;
            leftButton.Enabled = true;
            button1.Enabled = false;
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);

            clearGraphics(g);

            foreach (Figure figure in plane.figureList)
            {
                figure.moveX(g, p, -20);
            }
            Figure.ox -= 20;
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);

            clearGraphics(g);

            foreach (Figure figure in plane.figureList)
            {
                figure.moveX(g, p, 20);
            }
            Figure.ox += 20;
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);

            clearGraphics(g);

            foreach (Figure figure in plane.figureList)
            {
                figure.moveY(g, p, -20);
            }
            Figure.oy -= 20;
        }


        private void downButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);

            clearGraphics(g);

            foreach (Figure figure in plane.figureList)
            {
                figure.moveY(g, p, 20);
            }
            Figure.oy += 20;
        }

        private void rotateLeft_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);

            clearGraphics(g);

            foreach (Figure figure in plane.figureList)
            {
                figure.rotate(g, p, 5, 0, 0);
            }
        }

        private void rotateRight_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);

            clearGraphics(g);

            foreach (Figure figure in plane.figureList)
            {
                figure.rotate(g, p, -5, 0, 0);
            }
        }

        private void scaleDown_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);

            clearGraphics(g);

            foreach (Figure figure in plane.figureList)
            {
                figure.scale(g, p, 0.5);
            }

        }

        private void scaleUp_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);

            clearGraphics(g);

            foreach (Figure figure in plane.figureList)
            {
                figure.scale(g, p, 2);
            }

        }

        private void clearGraphics(Graphics g)
        {
            foreach (Figure figure in plane.figureList)
            {
                figure.clear(g);
            }
        }

        private void rotateLeftY_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);

            clearGraphics(g);

            foreach (Figure figure in plane.figureList)
            {
                figure.rotate(g, p, 0, 5, 0);
            }
        }

        private void rotateRightY_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);

            clearGraphics(g);

            foreach (Figure figure in plane.figureList)
            {
                figure.rotate(g, p, 0, -5, 0);
            }
        }

        private void rotateLeftZ_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);

            clearGraphics(g);

            foreach (Figure figure in plane.figureList)
            {
                figure.rotate(g, p, 0, 0, 5);
            }
        }

        private void rotateRightZ_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);

            clearGraphics(g);

            foreach (Figure figure in plane.figureList)
            {
                figure.rotate(g, p, 0, 0, -5);
            }
        }
    }
}
