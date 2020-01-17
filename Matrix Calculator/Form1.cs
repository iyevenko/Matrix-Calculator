using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Matrix_Calculator
{
    public partial class Form1 : Form
    {
        public States CurrentState = States.STORE;
        public Matrix A;
        public Matrix B;
        public Matrix C;
        public Matrix selectedMatrix;

        public Form1()
        {
            InitializeComponent();
            resizeMatrix(flpMatrixA, nudA_m, nudA_n);
            /*
            double[,] val1 = {{1, 2, 3}, 
                              {4, 5, 6}};
            double[,] val2 = {{9, 8, 7}, 
                              {8, 7, 9},
                              {7, 8, 9}
            };
            Matrix A = new Matrix(val1);
            Matrix B = new Matrix(val2);

            try
            {
                Matrix C = A * B;
                MessageBox.Show(C.ToString());
                Matrix Ct = C.transpose();
                MessageBox.Show(Ct.ToString());
                Matrix D = Ct + 1;
                MessageBox.Show(D.ToString());
                Matrix E = D * 2;
                MessageBox.Show(E.ToString());

            }
            catch (InvalidSizeException ise)
            {
                MessageBox.Show(ise.Message);
            }
            */
        }
        public int n;
        public int m;

        TextBox tbox(int m, int n)
        {
            TextBox t = new TextBox();
            string name = "txt_" + m.ToString() + "_" + n.ToString();
            t.Name = name;
            t.Width = 30;
            t.Height = 100;
            return t;

        }

        private void displayMatrix(FlowLayoutPanel flp, NumericUpDown nudM, NumericUpDown nudN, Matrix matrix)
        {
            int m = matrix.getM();
            int n = matrix.getN();
            nudM.Value = m;
            nudN.Value = n;
            resizeMatrix(flp, nudM, nudN);
            int count = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    flp.Controls[count].Text = matrix.getValue(i, j).ToString();
                    count++;
                }
            }

        }

        private Matrix ConvertToMatrix(FlowLayoutPanel flp, NumericUpDown nudM, NumericUpDown nudN)
        {
            m = Convert.ToInt32(nudM.Value);
            n = Convert.ToInt32(nudN.Value);
            double[,] matrix_kyd = new double[m, n];
            int count = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix_kyd[i, j] = Convert.ToDouble(flp.Controls[count].Text);
                    count++;
                }
            }
            return new Matrix(matrix_kyd);
        }
        /*
        Matrix A;
        private void btnMatrify_Click(object sender, EventArgs e)
        {
            A = ConvertToMatrix(flpMatrixA, nudA_m, nudA_n);
            MessageBox.Show(A.ToString());
        }
        */

        private void resizeMatrix(FlowLayoutPanel flp, NumericUpDown nudM, NumericUpDown nudN)
        {
            flp.Controls.Clear();
            m = Convert.ToInt32(nudM.Value);
            n = Convert.ToInt32(nudN.Value);

            if (n < 9)
            {
                flp.Width = n * 40;
            }
            else
            {
                flp.Width = n * 38;
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    flp.Controls.Add(tbox(m + 1, n + 1));
                }
            }
        }

        private void saveToFile()
        {
            saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog.FileName = "Saved_Matrices";
            saveFileDialog.Filter = "CSV files | *.csv";
            saveFileDialog.DefaultExt = "csv";

            StreamWriter sw = null;
            try
            {
                // Only proceed if user successfully selects output file
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    sw = new StreamWriter(saveFileDialog.OpenFile());

                    sw.WriteLine("A:");
                    if (A != null)
                    {
                        sw.WriteLine(A.ToString());
                    }
                    else
                    {
                        sw.WriteLine($"M: {0}, N: {0}");
                    }

                    sw.WriteLine("B:");
                    if (B != null)
                    {
                        sw.WriteLine(B.ToString());
                    }
                    else
                    {
                        sw.WriteLine($"M: {0}, N: {0}");
                    }

                    sw.WriteLine("C:");
                    if (C != null)
                    {
                        sw.WriteLine(C.ToString());
                    }
                    else
                    {
                        sw.WriteLine($"M: {0}, N: {0}");
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Writing to file failed");
            }
            finally
            {
                // Make sure stream is closed even if exception is thrown
                sw?.Close();
            }
        }

        private void readFromFile()
        {
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog.FileName = "Saved_Matrices";
            openFileDialog.Filter = "CSV files | *.csv";
            openFileDialog.DefaultExt = "csv";

            StreamReader sr = null;
            try
            {
                // Only proceed if user successfully selects output file
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    sr = new StreamReader(openFileDialog.OpenFile());

                    string[] currLine;
                    double[,] values;
                    string name;
                    int M;
                    int N;

                    for (int k = 0; k < 3; k++)
                    {
                        name = sr.ReadLine().Substring(0, 1);
                        currLine = sr.ReadLine().Split(',');
                        M = Convert.ToInt32(currLine[0].Substring(3));
                        N = Convert.ToInt32(currLine[1].Substring(3));
                        values = new double[M, N];
                        for (int i = 0; i < M; i++)
                        {
                            currLine = sr.ReadLine().Split(',');
                            for (int j = 0; j < N; j++)
                            {
                                values[i, j] = Convert.ToDouble(currLine[j]);
                            }
                        }

                        if (name == "A")
                        {
                            A = new Matrix(values);
                        } else if (name == "B")
                        {
                            B = new Matrix(values);
                        }
                        else if (name == "C")
                        {
                            C = new Matrix(values);
                        }
                        sr.ReadLine();
                    }
                }

                MessageBox.Show(A.ToString());
                MessageBox.Show(B.ToString());
                MessageBox.Show(C.ToString());
            }
            catch (IOException)
            {
                MessageBox.Show("Reading from file failed");
            }
            finally
            {
                // Make sure stream is closed even if exception is thrown
                sr?.Close();
            }
        }

        private void nudA_m_ValueChanged(object sender, EventArgs e)
        {
            resizeMatrix(flpMatrixA, nudA_m, nudA_n);
        }

        private void nudA_n_ValueChanged(object sender, EventArgs e)
        {
            resizeMatrix(flpMatrixA, nudA_m, nudA_n);
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            displayMatrix(flpMatrixA, nudA_m, nudA_n, A);
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            bool allValid = true;
            foreach (Control tbox in flpMatrixA.Controls)
            {
                if (!Regex.IsMatch(tbox.Text, @"^\d+$"))
                {
                    allValid = false;
                    break;
                }
            }
            if (allValid)
            {
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                CurrentState = States.STORE;
            }
            else
            {
                MessageBox.Show("Ensure your matrix is full and only numbers!");
            }
            
            /*
            btnAdd.Enabled = false;
            btnSubtract.Enabled = false;
            btnMultiply.Enabled = false;
            */
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            StateHandle(ref A);
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            StateHandle(ref B);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            StateHandle(ref C);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CurrentState = States.ADD;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            CurrentState = States.SUBTRACT;
        }

        private void StateHandle(ref Matrix self)
        {
            if (CurrentState == States.STORE)
            {
                self = ConvertToMatrix(flpMatrixA, nudA_m, nudA_n);
                selectedMatrix = self;

            }
            else if (CurrentState == States.ADD)
            {
                selectedMatrix = selectedMatrix + self;
                displayMatrix(flpMatrixA, nudA_m, nudA_n, selectedMatrix);
            }
            else if (CurrentState == States.SUBTRACT)
            {
                selectedMatrix = selectedMatrix - self;
                displayMatrix(flpMatrixA, nudA_m, nudA_n, selectedMatrix);
            }
            else if (CurrentState == States.MULTIPLY)
            {
                selectedMatrix = selectedMatrix * self;
                displayMatrix(flpMatrixA, nudA_m, nudA_n, selectedMatrix);
            }
            else
            {
                displayMatrix(flpMatrixA, nudA_m, nudA_n, self);
                selectedMatrix = self;
            }
            CurrentState = States.SELECT;

            if (A == null)
            {
                btnA.Enabled = false;
            }
            if (B == null)
            {
                btnB.Enabled = false;
            }
            if (C == null)
            {
                btnC.Enabled = false;
            }
            

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            CurrentState = States.MULTIPLY;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
        }
    }
}
