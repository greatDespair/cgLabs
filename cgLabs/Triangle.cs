using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cgLabs.MatrixLib;
namespace cgLabs
{
    public class Triangle:Figure
    {

        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            MatrixP = new double[3][];
            MatrixP[0] = new double[3] { x1, y1, 1 };
            MatrixP[1] = new double[3] { x2, y2, 1 };
            MatrixP[2] = new double[3] { x3, y3, 1 };
        }

        public override void draw(Graphics g, Pen p)
        {
            PointF[] points = new PointF[]
            {
                new Point((int)MatrixP[0][0],(int)MatrixP[0][1]),
                new Point((int)MatrixP[1][0],(int)MatrixP[1][1]),
                new Point((int)MatrixP[2][0],(int)MatrixP[2][1])
            };
            g.DrawPolygon(p, points);
        }
        public override void moveX(Graphics g, Pen p, int value)
        {
            Matrix lib = new Matrix();

            Array.Copy(lib.moveMatrix(MatrixP, value, 0), MatrixP, 3);

            draw(g, p);
        }

        public override void moveY(Graphics g, Pen p, int value)
        {
            Matrix lib = new Matrix();

            Array.Copy(lib.moveMatrix(MatrixP, 0, value), MatrixP, 3);

            draw(g, p);
        }

        public override void rotate(Graphics g, Pen p, int degree)
        {
            Matrix lib = new Matrix();

            Array.Copy(lib.rotateMatrix(MatrixP, degree, ox, oy), MatrixP, 3);

            this.draw(g, p);
        }

        public override void scale(Graphics g, Pen p, double value)
        {
            Matrix lib = new Matrix();

            Array.Copy(lib.scaleMatrix(MatrixP, value, ox, oy), MatrixP, 3);

            this.draw(g, p);
        }
    }
}
