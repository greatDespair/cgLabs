using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace cgLabs
{
    public class Plane
    {
        public double XRotate { get; set; }
        public double YRotate { get; set; }
        public List<Figure> figureList;
        public Plane(bool flag)
        {
            this.figureList = new List<Figure>();
        }
        public Plane()
        {
            Quadrilateral qNose = new Quadrilateral(18, 26, 0, 19, 28, 0, 20, 28, 0, 21, 26, 0);
            Quadrilateral qBody = new Quadrilateral(18, 26, 0, 21, 26, 0, 21, 4, 0, 18, 4, 0);
            Quadrilateral qTailSquare = new Quadrilateral(19, 0, 0, 19, 1, 0, 20, 1, 0, 20, 0, 0);
            Quadrilateral qEngSlopRight = new Quadrilateral(21, 8, 0, 23, 8, 0, 22, 6, 0, 21, 6, 0);
            Quadrilateral qEngSlopLeft = new Quadrilateral(16, 8, 0, 18, 8, 0, 18, 6, 0, 17, 6, 0);
            Quadrilateral qEngBodyLeft = new Quadrilateral(16, 20, 0, 18, 20, 0, 18, 8, 0, 16, 8, 0);
            Quadrilateral qEngBodyRight = new Quadrilateral(21, 20, 0, 23, 20, 0, 23, 8, 0, 21, 8, 0);

            Quadrilateral qWingLeft = new Quadrilateral(3, 13, 0, 16, 15, 0, 16, 9, 0, 3, 9, 0);
            Quadrilateral qWingRight = new Quadrilateral(23, 15, 0, 36, 13, 0, 36, 9, 0, 23, 9, 0);

            Quadrilateral qTailThing = new Quadrilateral(18, 4, 0, 21, 4, 0, 20, 1, 0, 19, 1, 0);


            Quadrilateral qTailLeft = new Quadrilateral(14, 2, 0, 18, 4, 0, 19, 1, 0, 14, 1, 0);
            Quadrilateral qTailRight = new Quadrilateral(21, 4, 0, 25, 2, 0, 25, 1, 0, 20, 1, 0);

            Triangle tEngTopLeft = new Triangle(16, 20, 0, 18, 21, 0, 18, 20, 0);
            Triangle tEngTopRight = new Triangle(21, 21, 0, 23, 20, 0, 21, 20, 0);

            Triangle tTailLeft = new Triangle(14, 1, 0, 19, 1, 0, 19, 0, 0);
            Triangle tTailRight = new Triangle(20, 1, 0, 25, 1, 0, 20, 0, 0);

            Quadrilateral qNoseD = new Quadrilateral(18, 26, 2, 19, 28, 2, 20, 28, 2, 21, 26, 2);
            Quadrilateral qBodyD = new Quadrilateral(18, 26, 2, 21, 26, 2, 21, 4, 2, 18, 4, 2);
            Quadrilateral qTailSquareD = new Quadrilateral(19, 0, 2, 19, 1, 2, 20, 1, 2, 20, 0, 2);
            Quadrilateral qEngSlopRightD = new Quadrilateral(21, 8, 2, 23, 8, 2, 22, 6, 2, 21, 6, 2);
            Quadrilateral qEngSlopLeftD = new Quadrilateral(16, 8, 2, 18, 8, 2, 18, 6, 2, 17, 6, 2);
            Quadrilateral qEngBodyLeftD = new Quadrilateral(16, 20, 2, 18, 20, 2, 18, 8, 2, 16, 8, 2);
            Quadrilateral qEngBodyRightD = new Quadrilateral(21, 20, 2, 23, 20, 2, 23, 8, 2, 21, 8, 2);

            Quadrilateral qWingLeftD = new Quadrilateral(3, 13, 2, 16, 15, 2, 16, 9, 2, 3, 9, 2);
            Quadrilateral qWingRightD = new Quadrilateral(23, 15, 2, 36, 13, 2, 36, 9, 2, 23, 9, 2);

            Quadrilateral qTailThingD = new Quadrilateral(18, 4, 2, 21, 4, 2, 20, 1, 2, 19, 1, 2);


            Quadrilateral qTailLeftD = new Quadrilateral(14, 2, 2, 18, 4, 2, 19, 1, 2, 14, 1, 2);
            Quadrilateral qTailRightD = new Quadrilateral(21, 4, 2, 25, 2, 2, 25, 1, 2, 20, 1, 2);

            Triangle tEngTopLeftD = new Triangle(16, 20, 2, 18, 21, 2, 18, 20, 2);
            Triangle tEngTopRightD = new Triangle(21, 21, 2, 23, 20, 2, 21, 20, 2);

            Triangle tTailLeftD = new Triangle(14, 1, 2, 19, 1, 2, 19, 0, 2);
            Triangle tTailRightD = new Triangle(20, 1, 2, 25, 1, 2, 20, 0, 2);


            Quadrilateral qLeftNose = new Quadrilateral(19, 28, 2, 20, 28, 2, 20, 28, 0, 19, 28, 0);
            Quadrilateral qTopNose = new Quadrilateral(20, 28, 2, 21, 26, 2, 21, 26, 0, 20, 28, 0);
            Quadrilateral qRightNose = new Quadrilateral(21, 26, 2, 21, 21, 2, 21, 21, 0, 21, 26, 0);
            Quadrilateral qRightCenter = new Quadrilateral(21, 21, 2, 23, 20, 2, 23, 20, 0, 21, 21, 0);
            Quadrilateral qRightEngine = new Quadrilateral(23, 20, 2, 23, 15, 2, 23, 15, 0, 23, 20, 0);
            Quadrilateral qRightEngineWingTop = new Quadrilateral(23, 15, 2, 36, 13, 2, 36, 13, 0, 23, 15, 0);
            Quadrilateral qRightWingTop = new Quadrilateral(36, 13, 2, 36, 9, 2, 36, 9, 0, 36, 13, 0);
            Quadrilateral qRightWingRight = new Quadrilateral(36, 9, 2, 23, 9, 2, 23, 9, 0, 36, 9, 0);
            Quadrilateral qRightWingBottom = new Quadrilateral(23, 9, 2, 23, 8, 2, 23, 8, 0, 23, 9, 0);
            Quadrilateral qRightEngineWingBottom = new Quadrilateral(23, 8, 2, 22, 6, 2, 22, 6, 0, 23, 8, 0);
            Quadrilateral qRightEngineWingTriangle = new Quadrilateral(22, 6, 2, 21, 6, 2, 21, 6, 0, 22, 6, 0);
            Quadrilateral qRightEngineTop = new Quadrilateral(21, 6, 2, 21, 4, 2, 21, 4, 0, 21, 6, 0);
            Quadrilateral qRightCenterBottom = new Quadrilateral(21, 4, 2, 25, 2, 2, 25, 2, 0, 21, 4, 0);
            Quadrilateral qRightEleroneTop = new Quadrilateral(25, 2, 2, 25, 1, 2, 25, 1, 0, 25, 2, 0);
            Quadrilateral qRightEleroneRight = new Quadrilateral(25, 1, 2, 20, 0, 2, 20, 0, 0, 25, 1, 0);
            Quadrilateral qRightEleroneBottom = new Quadrilateral(20, 0, 2, 19, 0, 2, 19, 0, 0, 20, 0, 0);
            Quadrilateral qCenterBottom = new Quadrilateral(19, 0, 2, 14, 1, 2, 14, 1, 0, 19, 0, 0);
            Quadrilateral qLeftEleroneBottom = new Quadrilateral(14, 1, 2, 14, 2, 2, 14, 2, 0, 14, 1, 0);
            Quadrilateral qLeftEleroneLeft = new Quadrilateral(14, 2, 2, 18, 4, 2, 18, 4, 0, 14, 2, 0);
            Quadrilateral qLeftEleroneTop = new Quadrilateral(18, 4, 2, 18, 6, 2, 18, 6, 0, 18, 4, 0);
            Quadrilateral qLeftCenterBottom = new Quadrilateral(18, 6, 2, 17, 6, 2, 17, 6, 0, 18, 6, 0);
            Quadrilateral qLeftEngineTop = new Quadrilateral(17, 6, 2, 16, 8, 2, 16, 8, 0, 17, 6, 0);
            Quadrilateral qLeftEngineWingTriangle = new Quadrilateral(16, 8, 2, 16, 9, 2, 16, 9, 0, 16, 8, 0);
            Quadrilateral qLeftEngineWingBottom = new Quadrilateral(16, 9, 2, 3, 9, 2, 3, 9, 0, 16, 9, 0);
            Quadrilateral qLeftWingBottom = new Quadrilateral(3, 9, 2, 3, 13, 2, 3, 13, 0, 3, 9, 0);
            Quadrilateral qLeftWingLeft = new Quadrilateral(3, 13, 2, 16, 15, 2, 16, 15, 0, 3, 13, 0);
            Quadrilateral qLeftWingTop = new Quadrilateral(16, 15, 2, 16, 20, 2, 16, 20, 0, 16, 15, 0);
            Quadrilateral qLeftEngineWingTop = new Quadrilateral(16, 20, 2, 18, 21, 2, 18, 21, 0, 16, 20, 0);
            Quadrilateral qLeftEngine = new Quadrilateral(18, 21, 2, 18, 26, 2, 18, 26, 0, 18, 21, 0);
            Quadrilateral qLeftCenter = new Quadrilateral(18, 26, 2, 19, 28, 2, 19, 28, 0, 18, 26, 0);


            figureList = new List<Figure>
            {
                qNose, qBody, qTailSquare, qEngBodyRight, qEngBodyLeft,
                qWingLeft, qWingRight, qTailThing, qTailLeft, qTailRight, tEngTopLeft, tEngTopRight,
                tTailLeft, tTailRight, qEngSlopLeft, qEngSlopRight, 
                
                qLeftNose, qTopNose, qRightNose, qRightCenter, qRightEngine, qRightEngineWingTop,
                qRightWingTop, qRightWingRight, qRightWingBottom, qRightEngineWingBottom,
                qRightEngineWingTriangle, qRightEngineTop, qRightCenterBottom, qRightEleroneTop,
                qRightEleroneRight, qCenterBottom, qLeftEleroneBottom, qLeftEleroneLeft, qLeftEleroneTop,
                qLeftCenterBottom, qLeftEngineTop, qLeftEngineWingTriangle, qLeftEngineWingBottom,
                qLeftWingBottom, qLeftWingLeft, qLeftWingTop, qLeftEngineWingTop, qLeftEngine, qLeftCenter,
                qRightEleroneBottom,
                
                qNoseD, qBodyD, qTailSquareD, qEngBodyRightD, qEngBodyLeftD,
                qWingLeftD, qWingRightD, qTailThingD, qTailLeftD, qTailRightD, tEngTopLeftD, tEngTopRightD,
                tTailLeftD, tTailRightD, qEngSlopLeftD, qEngSlopRightD
            };
            XRotate = 0;
            YRotate = 0;
        }

        public Plane getCopy()
        {
            Plane result = new Plane(true);

            foreach( Figure figure in this.figureList)
            {
                result.figureList.Add((Figure)figure.Clone());
            }

            return result;
        }
    }
}
