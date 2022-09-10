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
        static Figure()
        {
            ox = 19.5;
            oy = 14;

        }
        public virtual void draw(Graphics g, Pen p)
        {

        }
        public virtual void clear(Graphics g)
        {

        }

        public virtual void rotate(Graphics g, Pen p, int value)
        {

        }

        public virtual void moveX(Graphics g, Pen p, int value)
        {

        }

        public virtual void moveY(Graphics g, Pen p, int value)
        {

        }

        public virtual void scale(Graphics g, Pen p, double value)
        {

        }

    }
}
