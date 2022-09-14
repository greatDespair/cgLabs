using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cgLabs.MatrixLib
{
    public class Matrix
    {
        private double[][] rotateM;
        private double[][] moveM;
        private double[][] scaleM;
        private double[][] mirrorM;

        public void initializeReflect()
        {
            mirrorM = new double[4][];
            mirrorM[0] = new double[4] { -1, 0, 0, 0};
            mirrorM[1] = new double[4] { 0, -1, 0, 0};
            mirrorM[2] = new double[4] { 0, 0, -1, 0 };
            mirrorM[3] = new double[4] { 0, 0, 0, 1 };
        }
        public void initializeScale(double value)
        {
            scaleM = new double[4][];
            scaleM[0] = new double[4] { value, 0, 0, 0};
            scaleM[1] = new double[4] { 0, value, 0, 0};
            scaleM[2] = new double[4] { 0, 0, value, 0};
            scaleM[3] = new double[4] { 0, 0, 0, value};
        }

        public void initializeRotate(int degreeX, int degreeY, int degreeZ, double ox, double oy, double oz)
        {
            double angleX = (double)degreeX * Math.PI / 180;
            double angleY = (double)degreeY * Math.PI / 180;
            double angleZ = (double)degreeZ * Math.PI / 180;
            rotateM = new double[4][];
            /*rotateM[0] = new double[4] { Math.Cos(angleY), 0, -Math.Sin(angleY), 0 };
            rotateM[1] = new double[4] {Math.Sin(angleX) * Math.Sin(angleY), Math.Cos(angleX), Math.Cos(angleY) * Math.Sin(angleX), 0 };
            rotateM[2] = new double[4] { Math.Sin(angleY) * Math.Cos(angleX), -Math.Sin(angleX), Math.Cos(angleY) * Math.Cos(angleX), 0 };
            rotateM[3] = new double[4] { ox * Math.Cos(angleY) + oy * Math.Sin(angleY) * Math.Sin(angleX) + oz * Math.Sin(angleY) * Math.Cos(angleX),
                                         oy * Math.Cos(angleX) - oz * Math.Sin(angleX),
                                       - ox * Math.Sin(angleY) + oy * Math.Cos(angleY) * Math.Sin(angleX) + oz * Math.Cos(angleY) * Math.Cos(angleX), 1};*/
            rotateM[0] = new double[4] { Math.Cos(angleY), Math.Sin(angleY) * Math.Sin(angleX), -Math.Sin(angleY) * Math.Cos(angleX), 0 };
            rotateM[1] = new double[4] {0, Math.Cos(angleX), Math.Sin(angleX), 0 };
            rotateM[2] = new double[4] { Math.Sin(angleY), - Math.Cos(angleY) * Math.Sin(angleX), Math.Cos(angleY) * Math.Cos(angleX), 0 };
            rotateM[3] = new double[4] {ox*(1 - Math.Cos(angleY)) - oz * Math.Sin(angleY),
                                        - ox * Math.Sin(angleY) * Math.Sin(angleX) + oy * (1 - Math.Sin(angleX)) + oz * Math.Cos(angleY) * Math.Sin(angleX),
                                        ox * Math.Sin(angleY) * Math.Cos(angleX) - oy * Math.Sin(angleX) + oz * (1 - Math.Cos(angleY) * Math.Cos(angleX)), 1};

        }
        public void initializeMove(double valueX, double valueY)
        {
            moveM = new double[3][];
            moveM[0] = new double[3] { 1, 0, 0 };
            moveM[1] = new double[3] { 0, 1, 0 };
            moveM[2] = new double[3] { valueX, valueY, 1 };
        }

        public double[][] reflectMatrix(double[][] m, double ox, double oy, double oz)
        {
            double[][] resMatrix = new double[m.Length][];
            for (int i = 0; i < m.Length; i++)
            {
                resMatrix[i] = new double[4];
            }

            initializeReflect();

            for (int j = 0; j < m.Length; j++)
            {
                m[j][0] -= ox;
                m[j][1] -= oy;
                m[j][2] -= oz;
            }


            for (int i = 0; i < m.Length; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        resMatrix[i][j] += m[i][k] * mirrorM[k][j];
                    }
                }
            }

            for (int j = 0; j < m.Length; j++)
            {
                resMatrix[j][0] += ox;
                resMatrix[j][1] += oy;
                resMatrix[j][2] += oz;
            }

            return resMatrix;
        }

        public double[][] rotateMatrix(double[][] m, int degreeX, int degreeY, int degreeZ, double ox, double oy, double oz)
        {
            double[][] resMatrix = new double[m.Length][];
            for(int i = 0; i < m.Length; i++)
            {
                resMatrix[i] = new double[4];
            }

            initializeRotate(degreeX, degreeY, degreeZ, ox, oy, oz);

            for(int i = 0; i < m.Length; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    for(int k = 0; k < 4; k++)
                    {
                        resMatrix[i][j] += m[i][k]*rotateM[k][j];
                    }
                }
            }
            return resMatrix;
        }

        public double[][] moveMatrix(double[][] m, double offsetX, double offsetY)
        {
            double[][] resMatrix = new double[m.Length][];
            for (int i = 0; i < m.Length; i++)
            {
                resMatrix[i] = new double[3];
            }

            initializeMove(offsetX, offsetY);

            for (int i = 0; i < m.Length; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        resMatrix[i][j] += m[i][k] * moveM[k][j];
                    }
                }
            }
            return resMatrix;
        }

        public double[][] scaleMatrix(double[][] m, double scale, double ox, double oy, double oz)
        {
            double[][] resMatrix = new double[m.Length][];
            for (int i = 0; i < m.Length; i++)
            {
                resMatrix[i] = new double[4];
            }

            for(int j = 0; j < m.Length; j++)
            {
                m[j][0] -= ox;
                m[j][1] -= oy;
                m[j][2] -= oz;
            }

            initializeScale(scale);

            for (int i = 0; i < m.Length; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        resMatrix[i][j] += m[i][k] * scaleM[k][j];
                    }
                }
            }

            for (int j = 0; j < m.Length; j++)
            {
                resMatrix[j][0] += ox;
                resMatrix[j][1] += oy;
                resMatrix[j][2] += oz;
            }

            return resMatrix;
        }
    }
}
