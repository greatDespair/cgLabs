using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cgLabs
{
    public class Plane
    {
        private static Plane instance;
        public List<Figure> figureList;
        private Plane()
        {
            Quadrilateral qNose = new Quadrilateral(18, 26, 19, 28, 20, 28, 21, 26);
            Quadrilateral qBody = new Quadrilateral(18, 26, 21, 26, 21, 4, 18, 4);
            Quadrilateral qTailSquare = new Quadrilateral(19, 0, 19, 1, 20, 1, 20, 0);
            Quadrilateral qEngSlopRight = new Quadrilateral(21, 8, 23, 8, 22, 6, 21, 6);
            Quadrilateral qEngSlopLeft = new Quadrilateral(16, 8, 18, 8, 18, 6, 17, 6);
            Quadrilateral qEngBodyLeft = new Quadrilateral(16, 20, 18, 20, 18, 8, 16, 8);
            Quadrilateral qEngBodyRight = new Quadrilateral(21, 20, 23, 20, 23, 8, 21, 8);

            Quadrilateral qWingLeft = new Quadrilateral(3, 13, 16, 15, 16, 9, 3, 9);
            Quadrilateral qWingRight = new Quadrilateral(23, 15, 36, 13, 36, 9, 23, 9);

            Quadrilateral qTailThing = new Quadrilateral(18, 4, 21, 4, 20, 1, 19, 1);


            Quadrilateral qTailLeft = new Quadrilateral(14, 2, 18, 4, 19, 1, 14, 1);
            Quadrilateral qTailRight = new Quadrilateral(21, 4, 25, 2, 25, 1, 20, 1);

            Triangle tEngTopLeft = new Triangle(16, 20, 18, 21, 18, 20);
            Triangle tEngTopRight = new Triangle(21, 21, 23, 20, 21, 20);

            Triangle tTailLeft = new Triangle(14, 1, 19, 1, 19, 0);
            Triangle tTailRight = new Triangle(20, 1, 25, 1, 20, 0);

            figureList = new List<Figure> {
                            qNose, qBody, qTailSquare, qEngBodyRight, qEngBodyLeft,
                            qWingLeft, qWingRight, qTailThing, qTailLeft, qTailRight, tEngTopLeft, tEngTopRight,
                            tTailLeft, tTailRight, qEngSlopLeft, qEngSlopRight
                        };
        }
        public static Plane getInstance()
        {
            if(instance == null)
                instance = new Plane();
            return instance;    
        }
    }
}
