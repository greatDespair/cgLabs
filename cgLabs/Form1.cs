using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);

            foreach (Figure figure in plane.figureList)
            {
                figure.draw(g, p);
            }
        }

        private void rotate_Scroll(object sender, EventArgs e)
        {

        }



        private void leftButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);

            foreach (Figure figure in plane.figureList)
            {
                figure.clear(g);
            }

            foreach (Figure figure in plane.figureList)
            {
                figure.moveX(g, p, -2);
            }
            Figure.ox -= 2;
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);

            foreach (Figure figure in plane.figureList)
            {
                figure.clear(g);
            }

            foreach (Figure figure in plane.figureList)
            {
                figure.moveX(g, p, 2);
            }
            Figure.ox += 2;
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);

            foreach (Figure figure in plane.figureList)
            {
                figure.clear(g);
            }

            foreach (Figure figure in plane.figureList)
            {
                figure.moveY(g, p, 2);
            }
            Figure.oy += 2;
        }


        private void downButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);

            foreach (Figure figure in plane.figureList)
            {
                figure.clear(g);
            }

            foreach (Figure figure in plane.figureList)
            {
                figure.moveY(g, p, -2);
            }
            Figure.oy -= 2;
        }

        private void rotateLeft_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);

            foreach (Figure figure in plane.figureList)
            {
                figure.clear(g);
            }

            foreach (Figure figure in plane.figureList)
            {
                figure.rotate(g, p, 30);
            }
        }

        private void rotateRight_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);

            foreach (Figure figure in plane.figureList)
            {
                figure.clear(g);
            }

            foreach (Figure figure in plane.figureList)
            {
                figure.rotate(g, p, -30);
            }
        }
    }
}
