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

        public void initializeScale(double value, double ox, double oy)
        {
            scaleM = new double[3][];
            scaleM[0] = new double[3] { value, 0, 0};
            scaleM[1] = new double[3] { 0, value, 0};
            scaleM[2] = new double[3] { 0, 0, 1 };
        }

        public void initializeRotate(int degree, double ox, double oy)
        {
            double angle = (double)degree * Math.PI / 180;
            rotateM = new double[3][];
            rotateM[0] = new double[3] { Math.Cos(angle), Math.Sin(angle), 0 };
            rotateM[1] = new double[3] { -Math.Sin(angle), Math.Cos(angle), 0 };
            rotateM[2] = new double[3] { -ox *(Math.Cos(angle) - 1) + oy * Math.Sin(angle),
                -oy *(Math.Cos(angle) - 1) - ox * Math.Sin(angle), 1 };
        }
        public void initializeMove(double valueX, double valueY)
        {
            moveM = new double[3][];
            moveM[0] = new double[3] { 1, 0, 0 };
            moveM[1] = new double[3] { 0, 1, 0 };
            moveM[2] = new double[3] { valueX, valueY, 1 };
        }

        public double[][] rotateMatrix(double[][] m, int degree, double ox, double oy)
        {
            double[][] resMatrix = new double[m.Length][];
            for(int i = 0; i < m.Length; i++)
            {
                resMatrix[i] = new double[3];
            }

            initializeRotate(degree, ox, oy);

            for(int i = 0; i < m.Length; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    for(int k = 0; k < 3; k++)
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

        public double[][] scaleMatrix(double[][] m, double scale, double ox, double oy)
        {
            double[][] resMatrix = new double[m.Length][];
            for (int i = 0; i < m.Length; i++)
            {
                resMatrix[i] = new double[3];
            }

            for(int j = 0; j < m.Length; j++)
            {
                m[j][0] -= ox;
                m[j][1] -= oy;
            }

            initializeScale(scale, ox, oy);

            for (int i = 0; i < m.Length; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        resMatrix[i][j] += m[i][k] * scaleM[k][j];
                    }
                }
            }

            for (int j = 0; j < m.Length; j++)
            {
                resMatrix[j][0] += ox;
                resMatrix[j][1] += oy;
            }

            return resMatrix;
        }
    }
}
