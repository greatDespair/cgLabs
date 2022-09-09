using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cgLabs
{
    public abstract class Figure
    {

        public static double ox { get; set; }
        public static double oy { get; set; }
        public double[][] Matrix { get; set; }
        public virtual void draw(Graphics g, Pen p)
        {

        }
    }
}
