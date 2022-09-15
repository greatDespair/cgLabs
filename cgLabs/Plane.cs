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
            Quadrilateral qNose = new Quadrilateral(18, 26, 19, 28, 20, 28, 21, 26, 0);
            Quadrilateral qBody = new Quadrilateral(18, 26, 21, 26, 21, 4, 18, 4, 0);
            Quadrilateral qTailSquare = new Quadrilateral(19, 0, 19, 1, 20, 1, 20, 0, 0);
            Quadrilateral qEngSlopRight = new Quadrilateral(21, 8, 23, 8, 22, 6, 21, 6, 0);
            Quadrilateral qEngSlopLeft = new Quadrilateral(16, 8, 18, 8, 18, 6, 17, 6, 0);
            Quadrilateral qEngBodyLeft = new Quadrilateral(16, 20, 18, 20, 18, 8, 16, 8, 0);
            Quadrilateral qEngBodyRight = new Quadrilateral(21, 20, 23, 20, 23, 8, 21, 8, 0);

            Quadrilateral qWingLeft = new Quadrilateral(3, 13, 16, 15, 16, 9, 3, 9, 0);
            Quadrilateral qWingRight = new Quadrilateral(23, 15, 36, 13, 36, 9, 23, 9, 0);

            Quadrilateral qTailThing = new Quadrilateral(18, 4, 21, 4, 20, 1, 19, 1, 0);


            Quadrilateral qTailLeft = new Quadrilateral(14, 2, 18, 4, 19, 1, 14, 1, 0);
            Quadrilateral qTailRight = new Quadrilateral(21, 4, 25, 2, 25, 1, 20, 1, 0);

            Triangle tEngTopLeft = new Triangle(16, 20, 18, 21, 18, 20, 0);
            Triangle tEngTopRight = new Triangle(21, 21, 23, 20, 21, 20, 0);

            Triangle tTailLeft = new Triangle(14, 1, 19, 1, 19, 0, 0);
            Triangle tTailRight = new Triangle(20, 1, 25, 1, 20, 0, 0);

            Quadrilateral qNoseD = new Quadrilateral(18, 26, 19, 28, 20, 28, 21, 26, 2);
            Quadrilateral qBodyD = new Quadrilateral(18, 26, 21, 26, 21, 4, 18, 4, 2);
            Quadrilateral qTailSquareD = new Quadrilateral(19, 0, 19, 1, 20, 1, 20, 0, 2);
            Quadrilateral qEngSlopRightD = new Quadrilateral(21, 8, 23, 8, 22, 6, 21, 6, 2);
            Quadrilateral qEngSlopLeftD = new Quadrilateral(16, 8, 18, 8, 18, 6, 17, 6, 2);
            Quadrilateral qEngBodyLeftD = new Quadrilateral(16, 20, 18, 20, 18, 8, 16, 8, 2);
            Quadrilateral qEngBodyRightD = new Quadrilateral(21, 20, 23, 20, 23, 8, 21, 8, 2);

            Quadrilateral qWingLeftD = new Quadrilateral(3, 13, 16, 15, 16, 9, 3, 9, 2);
            Quadrilateral qWingRightD = new Quadrilateral(23, 15, 36, 13, 36, 9, 23, 9, 2);

            Quadrilateral qTailThingD = new Quadrilateral(18, 4, 21, 4, 20, 1, 19, 1, 2);


            Quadrilateral qTailLeftD = new Quadrilateral(14, 2, 18, 4, 19, 1, 14, 1, 2);
            Quadrilateral qTailRightD = new Quadrilateral(21, 4, 25, 2, 25, 1, 20, 1, 2);

            Triangle tEngTopLeftD = new Triangle(16, 20, 18, 21, 18, 20, 2);
            Triangle tEngTopRightD = new Triangle(21, 21, 23, 20, 21, 20, 2);

            Triangle tTailLeftD = new Triangle(14, 1, 19, 1, 19, 0, 2);
            Triangle tTailRightD = new Triangle(20, 1, 25, 1, 20, 0, 2);

            figureList = new List<Figure> {
                            qNose, qBody, qTailSquare, qEngBodyRight, qEngBodyLeft,
                            qWingLeft, qWingRight, qTailThing, qTailLeft, qTailRight, tEngTopLeft, tEngTopRight,
                            tTailLeft, tTailRight, qEngSlopLeft, qEngSlopRight
                        };

            figureList2 = new List<Figure> {
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
