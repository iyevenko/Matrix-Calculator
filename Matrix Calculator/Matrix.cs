using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Matrix_Calculator
{
    public class Matrix
    {
        private int M, N;
        private double[,] values;

        public Matrix(int M, int N)
        {
            this.M = M;
            this.N = N;
            values = new double[M, N];
        }

        public Matrix(double[,] values)
        {
            M = values.GetLength(0);
            N = values.GetLength(1);
            this.values = values;
        }

        public static Matrix operator + (Matrix A, Matrix B)
        {
            if (A.getM() != B.getM() || A.getN() != B.getN())
            {
                throw new InvalidSizeException(A.getM(), A.getN(), B.getM(), B.getN());
            }

            int newM = A.getM();
            int newN = A.getN();

            Matrix C = new Matrix(newM, newN);
            for (int i = 0; i < newM; i++)
            {
                for (int j = 0; j < newN; j++)
                {
                    double val = A.getValue(i, j) + B.getValue(i, j);
                    C.setValue(i, j, val);
                }
            }

            return C;
        }

        public static Matrix operator + (Matrix A, double c)
        {
            Matrix B = new Matrix(A.getM(), A.getN());
            for (int i = 0; i < A.getM(); i++)
            {
                for (int j = 0; j < A.getN(); j++)
                {
                    double val = A.getValue(i, j) + c;
                    B.setValue(i, j, val);
                }
            }

            return B;
        }

        public static Matrix operator - (Matrix A, Matrix B)
        {
            if (A.getM() != B.getM() || A.getN() != B.getN())
            {
                throw new InvalidSizeException(A.getM(), A.getN(), B.getM(), B.getN());
            }

            int newM = A.getM();
            int newN = A.getN();

            Matrix C = new Matrix(newM, newN);
            for (int i = 0; i < newM; i++)
            {
                for (int j = 0; j < newN; j++)
                {
                    double val = A.getValue(i, j) - B.getValue(i, j);
                    C.setValue(i, j, val);
                }
            }

            return C;
        }

        public static Matrix operator - (Matrix A, double c)
        {
            Matrix B = new Matrix(A.getM(), A.getN());
            for (int i = 0; i < A.getM(); i++)
            {
                for (int j = 0; j < A.getN(); j++)
                {
                    double val = A.getValue(i, j) - c;
                    B.setValue(i, j, val);
                }
            }

            return B;
        }

        public static Matrix operator * (Matrix A, Matrix B)
        {
            if (A.getN() != B.getM())
            {
                throw new InvalidSizeException(A.getM(), A.getN(), B.getM(), B.getN());
            }

            int newM = A.getM();
            int newN = B.getN();

            Matrix C = new Matrix(newM, newN);

            for (int i = 0; i < newM; i++)
            {
                for (int j = 0; j < newN; j++)
                {
                    double val = 0;
                    for (int k = 0; k < A.getN(); k++)
                    {
                        val += A.getValue(i, k) * B.getValue(k, j);
                       
                    }
                    C.setValue(i, j, val);
                }
            }

            return C;
        }

        public static Matrix operator * (Matrix A, double c)
        {
            Matrix B = new Matrix(A.getM(), A.getN());
            for (int i = 0; i < A.getM(); i++)
            {
                for (int j = 0; j < A.getN(); j++)
                {
                    double val = A.getValue(i, j) * c;
                    B.setValue(i, j, val);
                }
            }

            return B;
        }

        public Matrix transpose()
        {
            Matrix transposed = new Matrix(N, M);
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    transposed.setValue(j, i, getValue(i, j));
                }
            }

            return transposed;
        }

        public double upperTriangular()
        {
            Matrix L = new Matrix(M, N);
            Matrix U = new Matrix(values);
            return 0;

        }

        public double determinant()
        {
            throw new NotImplementedException();
        }

        public bool isSquare()
        {
            return M == N;
        }

        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < M; i++)
            {
                str += "| ";
                for (int j = 0; j < N; j++)
                {
                    str += values[i, j] + " ";
                }
                str += "|\n";
            }

            return str;
        }

        private int getM()
        {
            return M;
        }

        private int getN()
        {
            return N;
        }

        private double getValue(int i, int j)
        {
            return values[i, j];
        }

        private void setValue(int i, int j, double val)
        {
            values[i, j] = val;
        }
    }

    public class InvalidSizeException : Exception
    {
        public InvalidSizeException(int am, int an, int bm, int bn) : base(
            String.Format("Can not perform operation on {0}x{1} and {2}x{3} matrix", am, an, bm, bn)
        ) { }
    }
}
