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

        public override double GetZ()
        {
            return (MatrixP[0][2] + MatrixP[1][2] + MatrixP[2][2])/3;
        }

        private static bool IsInPolygon(PointF[] polygon, PointF testPoint)
        {
            bool result = false;
            int j = polygon.Count() - 1;
            for (int i = 0; i < polygon.Count(); i++)
            {
                if (polygon[i].Y < testPoint.Y && polygon[j].Y >= testPoint.Y || polygon[j].Y < testPoint.Y && polygon[i].Y >= testPoint.Y)
                {
                    if (polygon[i].X + (testPoint.Y - polygon[i].Y) / (polygon[j].Y - polygon[i].Y) * (polygon[j].X - polygon[i].X) < testPoint.X)
                    {
                        result = !result;
                    }
                }
                j = i;
            }
            return result;
        }
        private bool IsInPolygonBorder(double x, double y)
        {
            for (int i = 0; i < 2; i++)
            {
                if ((x - MatrixP[i][0]) / (MatrixP[i + 1][0] - MatrixP[i][0]) ==
                    (y - MatrixP[i][1]) / (MatrixP[i + 1][1] - MatrixP[i][1]))
                {
                    return true;
                }
            }
            if ((x - MatrixP[2][0]) / (MatrixP[0][0] - MatrixP[2][0]) ==
                    (y - MatrixP[2][1]) / (MatrixP[0][1] - MatrixP[2][1]))
            {
                return true;
            }
            return false;
        }

        public override bool ItBelongsPolygon(double x, double y)
        {
            bool inPolygon;
            PointF[] polygon = new PointF[] { new PointF {X = (float)MatrixP[0][0], Y = (float)MatrixP[0][1] },
                                              new PointF {X = (float)MatrixP[1][0], Y = (float)MatrixP[1][1] },
                                              new PointF {X = (float)MatrixP[2][0], Y = (float)MatrixP[2][1] }};
            PointF testPoint = new PointF { X = (float)x, Y = (float)y };
            inPolygon = IsInPolygon(polygon, testPoint);
            return inPolygon;
        }
        public override bool ItBelongsBorder(double x, double y)
        {
            bool inPolygon;
            inPolygon = IsInPolygonBorder(x, y);
            return inPolygon;
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
