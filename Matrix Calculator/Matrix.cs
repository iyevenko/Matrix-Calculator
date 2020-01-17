using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace Matrix_Calculator
{
    public class Matrix
    {
        private int M, N;
        private int rank; // Set to -1 by default until computed during rref calculation (will always be a integer >= 0 otherwise)
        private double[,] values;

        public Matrix(int M, int N)
        {
            this.M = M;
            this.N = N;
            values = new double[M, N];
            this.rank = -1;
        }

        public Matrix(double[,] values)
        {
            M = values.GetLength(0);
            N = values.GetLength(1);
            this.values = copyValues(values);
            rank = -1;
        }

        public Matrix(double[,] values, int rank)
        {
            M = values.GetLength(0);
            N = values.GetLength(1);
            this.values = copyValues(values);
            this.rank = rank;
        }

        // Copies each value from a 2D array to a new ones (newVals)
        private double[,] copyValues(double[,] values)
        {
            int m = values.GetLength(0);
            int n = values.GetLength(1);
            double[,] newVals = new double[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    newVals[i, j] = values[i, j];
                }
            }

            return newVals;
        }

        // Add corresponding values from A to B
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

        // Add some value c to every value (for library use)
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

        // Subtract corresponding values in B from A
        public static Matrix operator - (Matrix A, Matrix B)
        {
            // Make sure matrices are the same size
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

        // Subtract some value c from every value (for library use)
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

        // Multiply columns of A by rows of B into a new Matrix C
        public static Matrix operator * (Matrix A, Matrix B)
        {
            // Check that matrices are compatible for multiplication
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

        // Multiply every value by some value c (for library use)
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

        public static Matrix identity(int N)
        {
            double[,] values = new double[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    // Add 1's on diagonal and 0's everywhere else
                    if (i == j)
                    {
                        values[i, j] = 1;
                    }
                    else
                    {
                        values[i, j] = 0;
                    }
                }
            }

            return new Matrix(values, N);
        }

        public Matrix transpose()
        {
            // Flip all values over diagonal
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

        // Returns array with { Upper, Lower }
        public Matrix[] decompose()
        {
            // Only works with square matrices
            if (!isSquare())
            {
                throw new InvalidSizeException(M, N);
            }

            double[,] lower = new double[N, N];
            double[,] upper = new double[N, N];

            // Decomposing matrix into Upper and Lower triangular matrix 
            for (int i = 0; i < N; i++)
            {
                // Upper Triangular 
                for (int k = i; k < N; k++)
                {
                    // Summation of L(i, j) * U(j, k) 
                    double sum = 0;
                    for (int j = 0; j < i; j++)
                    {
                        sum += (lower[i, j] * upper[j, k]);
                    }

                    // Evaluating U(i, k) 
                    upper[i, k] = values[i, k] - sum;
                }

                // Lower Triangular 
                for (int k = i; k < N; k++)
                {
                    if (i == k)
                        lower[i, i] = 1; // Diagonal as 1 
                    else
                    {

                        // Summation of L(k, j) * U(j, i) 
                        double sum = 0;
                        for (int j = 0; j < i; j++)
                        {
                            sum += (lower[k, j] * upper[j, i]);
                        }

                        // Evaluating L(k, i) 
                        lower[k, i] = (values[k, i] - sum) / upper[i, i];
                    }
                }
            }

            return new[] {new Matrix(upper), new Matrix(lower)};
        }

        public double determinant()
        {
            // Get the upper triangular matrix
            Matrix upper = decompose()[0];

            // Multiply all values in diagonal of upper for determinant
            double det = 1;
            for (int i = 0; i < N; i++)
            {
                double currVal = upper.getValue(i, i);
                // if upper has Nan or infinite values, determinant must be zero
                if (Double.IsInfinity(currVal) || Double.IsNaN(currVal))
                {
                    return 0;
                }
                det *= currVal;
            }

            return det;
        }

        public Matrix rref()
        {
            double[,] rref = copyValues(values);
            int j = 0;
            int rank = -1;

            for (int i = 0; i < M && j < N; i++)
            {
                int yOffset = 0;
                bool swapped = false;
                // Look through all values below current in column j
                while (i + yOffset < M)
                {
                    // Check for non-zeroes that can be swapped if current is 0
                    if (rref[i + yOffset, j] != 0)
                    {
                        if (yOffset > 0)
                        {
                            swapRows(i, i + yOffset, rref);
                        }
                        swapped = true;
                        break;
                    }
                    yOffset++;
                }

                // Skip if 0 pivot was found
                if (swapped)
                {
                    // Divide all in ith row by value at ij to make the pivot 1
                    double aij = rref[i, j];
                    for (int k = 0; k < N; k++)
                    {
                        rref[i, k] /= aij;
                    }

                    //Subtract multiples of ith row from all other rows
                    for (int k = 0; k < M; k++)
                    {
                        if (k == j)
                        {
                            continue;
                        }

                        double multiplier = rref[k, j];
                        for (int l = 0; l < N; l++)
                        {
                            rref[k, l] -= multiplier * rref[i, l];
                        }
                    }
                }
                else if (rank == -1) // if row of zeroes, set rank = number of rows done
                {
                    rank = j;
                }

                j++;
            }
            if (rank == -1)
            {
                rank = j;
            }

            this.rank = rank;
            return new Matrix(rref, rank);
        }

        private void swapRows(int i, int j, double[,] values)
        {
            int n = values.GetLength(1);
            double[] temp = new double[n];

            // Save all from i to temp
            for (int k = 0; k < n; k++)
            {
                temp[k] = values[i, k];
            }
            // Copy all from j to i
            for (int k = 0; k < n; k++)
            {
                values[i, k] = values[j, k];
            }
            // Copy all from temp to j
            for (int k = 0; k < n; k++)
            {
                values[j, k] = temp[k];
            }

        }

        public bool isSquare()
        {
            return M == N;
        }

        // For csv formatting
        public override string ToString()
        {
            string str = "";
            // First line is M and N
            str += String.Format("M: {0}, N: {1}\r\n", M, N);
            for (int i = 0; i < M; i++)
            {
                // add all values in ith row separated by comma
                for (int j = 0; j < N; j++)
                {
                    str += values[i, j] + (j < N - 1 ? "," : "");
                }

                str += "\r\n";
            }

            return str;
        }

        public int getM()
        {
            return M;
        }

        public int getN()
        {
            return N;
        }

        public double getValue(int i, int j)
        {
            return values[i, j];
        }

        private void setValue(int i, int j, double val)
        {
            values[i, j] = val;
        }

        public int getRank()
        {
            return rank;
        }
    }

    // Custom exception for displaying when an operation can only be done on a square matrix
    public class InvalidSizeException : Exception
    {
        public InvalidSizeException(int am, int an, int bm, int bn) : base(
            String.Format("Can not perform operation on {0}x{1} and {2}x{3} matrix", am, an, bm, bn))
        {

        }

        public InvalidSizeException(int m, int n) : base(
            String.Format("Can not perform operation on {0}x{1} matrix", m, n))
        {

        }
    }
}
