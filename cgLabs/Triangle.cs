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
    public class Triangle:Figure
    {

        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            Matrix = new double[3][];
            Matrix[0] = new double[2] { x1, y1 };
            Matrix[1] = new double[2] { x2, y2 };
            Matrix[2] = new double[2] { x3, y3 };
        }

        public override void draw(Graphics g, Pen p)
        {
            PointF[] points = new PointF[]
            {
                new Point((int)Matrix[0][0],(int)(Matrix[0][1])),
                new Point((int)Matrix[1][0],(int)(Matrix[1][1])),
                new Point((int)Matrix[2][0],(int)(Matrix[2][1]))
            };
            g.DrawPolygon(p, points);
        }
        public override void moveX(Graphics g, Pen p, int value)
        {
            Matrix[0][0] += value;
            Matrix[1][0] += value;
            Matrix[2][0] += value;

            PointF[] points = new PointF[]
            {
                new Point((int)(Matrix[0][0]),(int)(Matrix[0][1])),
                new Point((int)(Matrix[1][0]),(int)(Matrix[1][1])),
                new Point((int)(Matrix[2][0]),(int)(Matrix[2][1]))
            };
            g.DrawPolygon(p, points);
        }

        public override void moveY(Graphics g, Pen p, int value)
        {
            Matrix[0][1] += value;
            Matrix[1][1] += value;
            Matrix[2][1] += value;
            PointF[] points = new PointF[]
            {
                new Point((int)Matrix[0][0],(int)(Matrix[0][1])),
                new Point((int)Matrix[1][0],(int)(Matrix[1][1])),
                new Point((int)Matrix[2][0],(int)(Matrix[2][1]))
            };
            g.DrawPolygon(p, points);
        }

        public override void rotate(Graphics g, Pen p, int degree)
        {
            double angle = (double)degree * Math.PI / 180;
            for (int i = 0; i < 3; i++)
            {
                double tempX = Matrix[i][0] - ox;
                double tempY = Matrix[i][1] - oy;
                Matrix[i][0] = tempX * Math.Cos(angle) - tempY * Math.Sin(angle) + ox;
                Matrix[i][1] = tempX * Math.Sin(angle) + tempY * Math.Cos(angle) + oy;
            }
            this.draw(g, p);
        }

        public override void scale(Graphics g, Pen p, double value)
        {
            for (int i = 0; i < 3; i++)
            {
                double tempX = Matrix[i][0] - ox;
                double tempY = Matrix[i][1] - oy;
                Matrix[i][0] = (tempX) * value + ox;
                Matrix[i][1] = (tempY) * value + oy;
            }
            this.draw(g, p);
        }
    }
}
