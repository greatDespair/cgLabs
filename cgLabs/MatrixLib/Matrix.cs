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
        private double[][] projectionM;

        public void initializeProjection(int degree)
        {
            double angle = (double)degree * Math.PI / 180;
            projectionM = new double[4][];
            projectionM[0] = new double[4] {1, 0,0,0 }; 
            projectionM[1] = new double[4] { 0, 1, 0, 0 };
            projectionM[2] = new double[4] { -Math.Cos(angle), -Math.Sin(angle), 0, 0 };
            projectionM[3] = new double[4] { 0, 0, 0, 1 };
        }
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
            scaleM[3] = new double[4] { 0, 0, 0, 1};
        }

        public void initializeRotateX(int degree)
        {
            double angle = (double)degree * Math.PI / 180;
            rotateM = new double[4][];
            rotateM[0] = new double[4] { 1, 0, 0, 0};
            rotateM[1] = new double[4] { 0, Math.Cos(angle), Math.Sin(angle), 0 };
            rotateM[2] = new double[4] { 0, - Math.Sin(angle), Math.Cos(angle), 0 };
            rotateM[3] = new double[4] { 0, 0, 0, 1 };
        }

        public void initializeRotateY(int degree)
        {
            double angle = (double)degree * Math.PI / 180;
            rotateM = new double[4][];
            rotateM[0] = new double[4] { Math.Cos(angle), 0, -Math.Sin(angle), 0 };
            rotateM[1] = new double[4] { 0, 1, 0, 0 };
            rotateM[2] = new double[4] { Math.Sin(angle), 0, Math.Cos(angle), 0 };
            rotateM[3] = new double[4] { 0, 0, 0, 1 };
        }
        public void initializeRotateZ(int degree)
        {
            double angle = (double)degree * Math.PI / 180;
            rotateM = new double[4][];
            rotateM[0] = new double[4] { Math.Cos(angle), Math.Sin(angle), 0, 0 };
            rotateM[1] = new double[4] { -Math.Sin(angle), Math.Cos(angle), 0, 0 };
            rotateM[2] = new double[4] { 0, 0, 1, 0 };
            rotateM[3] = new double[4] { 0, 0, 0, 1 };
        }
        public void initializeMove(double valueX, double valueY, double valueZ)
        {
            moveM = new double[4][];
            moveM[0] = new double[4] { 1, 0, 0, 0};
            moveM[1] = new double[4] { 0, 1, 0, 0};
            moveM[2] = new double[4] { 0, 0, 1, 0 };
            moveM[3] = new double[4] { valueX, valueY, valueZ, 1 };
        }
        public double[][] projectionMatrix(double[][] m, int degree)
        {
            double[][] resMatrix = new double[m.Length][];

            for (int i = 0; i < m.Length; i++)
            {
                resMatrix[i] = new double[4];
            }

            initializeProjection(degree);

            for (int i = 0; i < m.Length; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        resMatrix[i][j] += m[i][k] * projectionM[k][j];
                    }
                }
            }

            return resMatrix;
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
        public double[][] rotateMatrixZ(double[][] m, int degreeZ, double ox, double oy, double oz)
        {
            double[][] resMatrix = new double[m.Length][];
            for (int i = 0; i < m.Length; i++)
            {
                resMatrix[i] = new double[4];
            }

            for (int j = 0; j < m.Length; j++)
            {
                m[j][0] -= ox;
                m[j][1] -= oy;
                m[j][2] -= oz;
            }
            initializeRotateZ(degreeZ);

            for (int i = 0; i < m.Length; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        resMatrix[i][j] += m[i][k] * rotateM[k][j];
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
        public double[][] rotateMatrixY(double[][] m, int degreeY, double ox, double oy, double oz)
        {
            double[][] resMatrix = new double[m.Length][];
            for (int i = 0; i < m.Length; i++)
            {
                resMatrix[i] = new double[4];
            }

            for (int j = 0; j < m.Length; j++)
            {
                m[j][0] -= ox;
                m[j][1] -= oy;
                m[j][2] -= oz;
            }
            initializeRotateY(degreeY);

            for (int i = 0; i < m.Length; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        resMatrix[i][j] += m[i][k] * rotateM[k][j];
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
        public double[][] rotateMatrixX(double[][] m, int degreeX, double ox, double oy, double oz)
        {
            double[][] resMatrix = new double[m.Length][];
            for(int i = 0; i < m.Length; i++)
            {
                resMatrix[i] = new double[4];
            }

            for (int j = 0; j < m.Length; j++)
            {
                m[j][0] -= ox;
                m[j][1] -= oy;
                m[j][2] -= oz;
            }
            initializeRotateX(degreeX);

            for (int i = 0; i < m.Length; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    for(int k = 0; k < 4; k++)
                    {
                        resMatrix[i][j] += m[i][k]*rotateM[k][j];
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

        public double[][] moveMatrix(double[][] m, double offsetX, double offsetY, double offsetZ)
        {
            double[][] resMatrix = new double[m.Length][];
            for (int i = 0; i < m.Length; i++)
            {
                resMatrix[i] = new double[4];
            }

            initializeMove(offsetX, offsetY, offsetZ);

            for (int i = 0; i < m.Length; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
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
