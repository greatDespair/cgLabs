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
    public class Triangle:Figure, ICloneable
    {

        public Triangle(double x1, double y1, double z1, double x2, double y2, double z2, double x3, double y3, double z3)
        {
            MatrixP = new double[3][];
            MatrixP[0] = new double[4] { x1, y1, z1, 1 };
            MatrixP[1] = new double[4] { x2, y2, z2, 1 };
            MatrixP[2] = new double[4] { x3, y3, z3, 1 };
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

            Array.Copy(lib.moveMatrix(MatrixP, value, 0, 0), MatrixP, 3);

            draw(g, p);
        }

        public override void moveY(Graphics g, Pen p, int value)
        {
            Matrix lib = new Matrix();

            Array.Copy(lib.moveMatrix(MatrixP, 0, value, 0), MatrixP, 3);

            draw(g, p);
        }

        public override void rotateX(Graphics g, Pen p, int degreeX)
        {
            Matrix lib = new Matrix();

            Array.Copy(lib.rotateMatrixX(MatrixP, degreeX, ox, oy, oz), MatrixP, 3);

            this.draw(g, p);
        }
        public override void rotateY(Graphics g, Pen p, int degreeY)
        {
            Matrix lib = new Matrix();

            Array.Copy(lib.rotateMatrixY(MatrixP, degreeY, ox, oy, oz), MatrixP, 3);

            this.draw(g, p);
        }
        public override void rotateZ(Graphics g, Pen p, int degreeZ)
        {
            Matrix lib = new Matrix();

            Array.Copy(lib.rotateMatrixZ(MatrixP, degreeZ, ox, oy, oz), MatrixP, 3);

            this.draw(g, p);
        }

        public override void scale(Graphics g, Pen p, double value)
        {
            Matrix lib = new Matrix();

            Array.Copy(lib.scaleMatrix(MatrixP, value, ox, oy, oz), MatrixP, 3);

            this.draw(g, p);
        }
        public override void reflect(Graphics g, Pen p)
        {
            Matrix lib = new Matrix();

            Array.Copy(lib.reflectMatrix(MatrixP, ox, oy, oz), MatrixP, 3);

            this.draw(g, p);
        }
        public override void projection(Graphics g, Pen p, int degree)
        {
            Matrix lib = new Matrix();

            Array.Copy(lib.projectionMatrix(MatrixP, degree), MatrixP, 3);

            this.draw(g, p);
        }
        public override object Clone()
        {
            Triangle result = new Triangle(this.MatrixP[0][0], this.MatrixP[0][1], this.MatrixP[0][2],
                                           this.MatrixP[1][0], this.MatrixP[1][1], this.MatrixP[1][2],
                                           this.MatrixP[2][0], this.MatrixP[2][1], this.MatrixP[2][2]);
            return result;
        }
    }
}
