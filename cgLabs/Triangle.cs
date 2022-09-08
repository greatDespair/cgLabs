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
    internal class Triangle:Figure
    {
        public int x1 { get; set; }
        public int y1 { get; set; }
        public int x2 { get; set; }
        public int y2 { get; set; }
        public int x3 { get; set; }
        public int y3 { get; set; }

        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
        }

        public override void draw(Graphics g, Pen p)
        {
            PointF[] points = new PointF[]
{
                new Point(x1*10,(30-y1)*10),new Point(x2*10,(30-y2)*10),
                new Point(x3*10,(30-y3)*10)
};
            g.DrawPolygon(p, points);
        }
    }
}
