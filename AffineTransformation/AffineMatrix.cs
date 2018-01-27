using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AffineTransformation
{
    class AffineMatrix
    {
        double[][] mat = new double[3][];
        double[][] inmat = new double[3][];

        public AffineMatrix()
        {
            for (int i = 0; i < mat.Length; i++)
            {
                mat[i] = new double[3];
                inmat[i] = new double[3];
                for (int j = 0; j < mat[i].Length; j++)
                {
                    mat[i][j] = 0;
                    if (i == j)
                        mat[i][j] = 1;
                }
            }
        }

        public void SetMatrix(int angleD, int X, int Y, double Scale)
        {
            // 回転
            double Rot = (double)angleD * Math.PI / 180.0;
            this.mat[0][0] = Math.Cos(Rot) * Scale;
            this.mat[0][1] = -1.0 * Math.Sin(Rot) * Scale;
            this.mat[1][0] = Math.Sin(Rot) * Scale;
            this.mat[1][1] = Math.Cos(Rot) * Scale;

            // 平行移動
            this.mat[0][2] = (double)X;
            this.mat[1][2] = (double)Y;

            // 逆行列を求める
            this.InverseMatrix();
        }

        public Point CalcMatrix(Point point)
        {
            double[] posMatrix = { point.X, point.Y, 1.0 };
            double[] ansMatrix = { 0, 0, 0 };

            for (int i = 0; i < this.mat.Length; i++) // a.Length は a の行数を表す。
                for (int j = 0; j < posMatrix.Length; j++) // b[0].Length は b の列数を表す。
                    ansMatrix[i] += this.mat[i][j] * posMatrix[j];

            Point rePoint = new Point((int)ansMatrix[0], (int)ansMatrix[1]);
            return rePoint;
        }

        public Point CalcInverseMatrix(Point point)
        {
            double[] posMatrix = { point.X, point.Y, 1.0 };
            double[] ansMatrix = { 0, 0, 0 };

            for (int i = 0; i < inmat.Length; i++) // a.Length は a の行数を表す。
                for (int j = 0; j < posMatrix.Length; j++) // b[0].Length は b の列数を表す。
                    ansMatrix[i] += inmat[i][j] * posMatrix[j];

            Point rePoint = new Point((int)ansMatrix[0], (int)ansMatrix[1]);

            return rePoint;
        }

        private void InverseMatrix()
        {
            double[][] preMat = new double[3][];
            double[][] InMat = new double[3][];

            for (int i = 0; i < this.mat.Length; i++)
            {
                preMat[i] = new double[3];
                for (int j = 0; j < this.mat[i].Length; j++)
                    preMat[i][j] = this.mat[i][j];
                InMat[i] = new double[3];
            }

            double buf;
            //単位行列を作る
            for (int i = 0; i < preMat.Length; i++)
                for (int j = 0; j < preMat.Length; j++)
                    InMat[i][j] = (i == j) ? 1.0 : 0.0;
            //掃き出し法
            for (int i = 0; i < preMat.Length; i++)
            {
                buf = 1 / preMat[i][i];
                for (int j = 0; j < preMat.Length; j++)
                {
                    preMat[i][j] *= buf;
                    InMat[i][j] *= buf;
                }
                for (int j = 0; j < preMat.Length; j++)
                {
                    if (i != j)
                    {
                        buf = preMat[j][i];
                        for (int k = 0; k < preMat.Length; k++)
                        {
                            preMat[j][k] -= preMat[i][k] * buf;
                            InMat[j][k] -= InMat[i][k] * buf;
                        }
                    }
                }
            }

            this.inmat = InMat;
        }
    }
}
