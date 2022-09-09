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

    public class Quadrilateral : Figure
    {

        public Quadrilateral(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            Matrix = new double[4][];
            Matrix[0] = new double[2] { x1, y1 };
            Matrix[1] = new double[2] { x2, y2 };
            Matrix[2] = new double[2] { x3, y3 };
            Matrix[3] = new double[2] { x4, y4 };
        }

        public override void draw(Graphics g, Pen p)
        {
            PointF[] points = new PointF[]
            {
                new Point((int)Matrix[0][0]*10,(int)(30-Matrix[0][1])*10),
                new Point((int)Matrix[1][0]*10,(int)(30-Matrix[1][1])*10),
                new Point((int)Matrix[2][0]*10,(int)(30-Matrix[2][1])*10),
                new Point((int)Matrix[3][0]*10,(int)(30-Matrix[3][1])*10)
            };
            g.DrawPolygon(p, points);
        }

        public override void rotate(Graphics g, Pen p)
        {
            
        }
    }
}
