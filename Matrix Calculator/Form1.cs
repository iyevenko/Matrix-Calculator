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
        public States CurrentState;
        public Matrix A;
        public Matrix B;
        public Matrix C;
        public Matrix selectedMatrix;

        public Form1()
        {
            InitializeComponent();
            resizeMatrix(flpMatrixA, nudA_m, nudA_n);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;

            CurrentState = States.SELECT;
        }

        public int m;
        public int n;

        // Generate TextBox for the m,n position
        TextBox tbox(int m, int n)
        {
            TextBox t = new TextBox();
            string name = "txt_" + m + "_" + n;
            t.Name = name;
            t.Width = 30;
            t.Height = 100;
            return t;

        }

        // Displays all values of a stored matrix on flp (display)
        private void displayMatrix(FlowLayoutPanel flp, NumericUpDown nudM, NumericUpDown nudN, Matrix matrix)
        {
            int m = matrix.getM();
            int n = matrix.getN();
            nudM.Value = m;
            nudN.Value = n;
            //Create textboxes and flp
            resizeMatrix(flp, nudM, nudN);

            // Set each TextBox value to corresponding matrix value
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

        private Matrix convertToMatrix(FlowLayoutPanel flp, NumericUpDown nudM, NumericUpDown nudN)
        {
            // Read dimensions of matrix and create mxn matrix
            m = Convert.ToInt32(nudM.Value);
            n = Convert.ToInt32(nudN.Value);
            double[,] values = new double[m, n];

            // Read each TextBox and place value in corresponding matrix position
            int count = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    values[i, j] = Convert.ToDouble(flp.Controls[count].Text);
                    count++;
                }
            }
            return new Matrix(values);
        }
        /*
        Matrix A;
        private void btnMatrify_Click(object sender, EventArgs e)
        {
            A = convertToMatrix(flpMatrixA, nudA_m, nudA_n);
            MessageBox.Show(A.ToString());
        }
        */

        private void resizeMatrix(FlowLayoutPanel flp, NumericUpDown nudM, NumericUpDown nudN)
        {
            flp.Controls.Clear();
            m = Convert.ToInt32(nudM.Value);
            n = Convert.ToInt32(nudN.Value);

            // Slightly smaller if max size
            if (n < 9)
            {
                flp.Width = n * 40;
            }
            else
            {
                flp.Width = n * 38;
            }

            // Create mxn textboxes in correct position
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
            // Open save file dialog in bin/debug with default name Saved_Matrix.csv and only show CSV files
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

                    // Write A to file
                    sw.WriteLine("A:");
                    if (A != null)
                    {
                        sw.WriteLine(A.ToString());
                    }
                    else
                    {
                        sw.WriteLine($"M: {0}, N: {0}");
                    }

                    // Write B to file
                    sw.WriteLine("B:");
                    if (B != null)
                    {
                        sw.WriteLine(B.ToString());
                    }
                    else
                    {
                        sw.WriteLine($"M: {0}, N: {0}");
                    }

                    // Write C to file
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
            // Open open file dialog in bin/debug with default name Saved_Matrix.csv and only show CSV files
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

                    try
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            // First line is A, B or C
                            name = sr.ReadLine().Substring(0, 1);

                            // Next line contains M and N
                            currLine = sr.ReadLine().Split(',');
                            M = Convert.ToInt32(currLine[0].Substring(3));
                            N = Convert.ToInt32(currLine[1].Substring(3));

                            if (M > 0 && N > 0)
                            {
                                // Save next M lines into values
                                values = new double[M, N];
                                for (int i = 0; i < M; i++)
                                {
                                    currLine = sr.ReadLine().Split(',');
                                    for (int j = 0; j < N; j++)
                                    {
                                        values[i, j] = Convert.ToDouble(currLine[j]);
                                    }
                                }

                                //Save to appropriate matrix based on name
                                if (name == "A")
                                {
                                    A = new Matrix(values);
                                    btnA.Enabled = true;
                                }
                                else if (name == "B")
                                {
                                    B = new Matrix(values);
                                    btnB.Enabled = true;
                                }
                                else if (name == "C")
                                {
                                    C = new Matrix(values);
                                    btnC.Enabled = true;
                                }
                                sr.ReadLine();
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Couldn't read from file. Likely incorrect formatting.");
                    }
                }
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

        private void btnStore_Click(object sender, EventArgs e)
        {
            
            if (validMatrix())
            {
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                CurrentState = States.STORE;
            }
        }

        private bool validMatrix()
        {
            bool allValid = true;
            foreach (Control tbox in flpMatrixA.Controls)
            {
                // Try parsing double to see if valid number
                try
                {
                    Convert.ToDouble(tbox.Text);
                }
                catch (FormatException)
                {
                    allValid = false;
                    MessageBox.Show("Ensure your matrix is full and only numbers!");
                    break;
                }
                catch (OverflowException)
                {
                    tbox.Text = tbox.Text.Substring(0, 4);
                    // try again after truncating long number
                    try
                    {
                        Convert.ToDouble(tbox.Text);
                    }
                    catch (FormatException)
                    {
                        allValid = false;
                        MessageBox.Show("Ensure your matrix is full and only numbers!");
                        break;
                    }
                }
            }
            return allValid;
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

        private void StateHandle(ref Matrix arg)
        {
            try
            {
                // Get currently displayed matrix and store to memory
                if (CurrentState == States.STORE)
                {
                    arg = convertToMatrix(flpMatrixA, nudA_m, nudA_n);
                    selectedMatrix = arg;
                }
                // Add previously selected matrix to clicked matrix
                else if (CurrentState == States.ADD)
                {
                    selectedMatrix = selectedMatrix + arg;
                    displayMatrix(flpMatrixA, nudA_m, nudA_n, selectedMatrix);
                }
                // Subtract clicked matrix from previously selected matrix
                else if (CurrentState == States.SUBTRACT)
                {
                    selectedMatrix = selectedMatrix - arg;
                    displayMatrix(flpMatrixA, nudA_m, nudA_n, selectedMatrix);
                }
                // Multiply clicked matrix by previously selected matrix (A x B)
                else if (CurrentState == States.MULTIPLY)
                {
                    selectedMatrix = selectedMatrix * arg;
                    displayMatrix(flpMatrixA, nudA_m, nudA_n, selectedMatrix);
                }
                // Transpose selected matrix
                else if (CurrentState == States.TRANSPOSE)
                {
                    selectedMatrix = arg.transpose();
                    displayMatrix(flpMatrixA, nudA_m, nudA_n, selectedMatrix);
                }
                // Get U for selected matrix
                else if (CurrentState == States.UPPER_TRIANGULAR)
                {
                    selectedMatrix = arg.decompose()[0];
                    displayMatrix(flpMatrixA, nudA_m, nudA_n, selectedMatrix);
                }
                // Get L for selected matrix
                else if (CurrentState == States.LOWER_TRIANGULAR)
                {
                    selectedMatrix = arg.decompose()[1];
                    displayMatrix(flpMatrixA, nudA_m, nudA_n, selectedMatrix);
                }
                // Get rref for selected matrix
                else if (CurrentState == States.RREF)
                {
                    selectedMatrix = arg.rref();
                    displayMatrix(flpMatrixA, nudA_m, nudA_n, selectedMatrix);
                }
                // Default: display the matrix
                else
                {
                    displayMatrix(flpMatrixA, nudA_m, nudA_n, arg);
                    selectedMatrix = arg;
                }
                // Reset to SELECT
                CurrentState = States.SELECT;

                // If there's nothing in the memory slot, make it Disabled
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
            catch (InvalidSizeException ise)
            {
                // Display custom message if not a square matrix
                MessageBox.Show(ise.Message);
            }


        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            CurrentState = States.MULTIPLY;
        }

        private void btnRank_Click(object sender, EventArgs e)
        {
            if (validMatrix())
            {
                selectedMatrix = convertToMatrix(flpMatrixA, nudA_m, nudA_n);
                int rank = selectedMatrix.getRank();
                // Compute rank through rref if not done already
                if (rank == -1)
                {
                    selectedMatrix.rref();
                    rank = selectedMatrix.getRank();
                }
                MessageBox.Show("Rank of matrix is " + rank);
            }
        }

        private void btnDeterminant_Click(object sender, EventArgs e)
        {
            try
            {
                if (validMatrix())
                {
                    selectedMatrix = convertToMatrix(flpMatrixA, nudA_m, nudA_n);
                    MessageBox.Show("Determinant of matrix is " + selectedMatrix.determinant());
                }
            }
            catch (InvalidSizeException ise)
            {
                // Display custom message if not a square matrix
                MessageBox.Show(ise.Message);
            }
        }

        private void btnTranspose_Click(object sender, EventArgs e)
        {
            if (validMatrix())
            { 
                selectedMatrix = convertToMatrix(flpMatrixA, nudA_m, nudA_n);
                CurrentState = States.TRANSPOSE;
                StateHandle(ref selectedMatrix);
            }
        }

        private void btnUpperTriangular_Click(object sender, EventArgs e)
        {
            try
            {
                if (validMatrix())
                {
                    selectedMatrix = convertToMatrix(flpMatrixA, nudA_m, nudA_n);
                    CurrentState = States.UPPER_TRIANGULAR;
                    StateHandle(ref selectedMatrix);
                }
            }
            catch (InvalidSizeException ise)
            {
                // Display custom message if not a square matrix
                MessageBox.Show(ise.Message);
            }
            
        }

        private void btnLowerTriangular_Click(object sender, EventArgs e)
        {
            try
            {
                if (validMatrix())
                {
                    selectedMatrix = convertToMatrix(flpMatrixA, nudA_m, nudA_n);
                    CurrentState = States.LOWER_TRIANGULAR;
                    StateHandle(ref selectedMatrix);
                }
            }
            catch (InvalidSizeException ise)
            {
                // Display custom message if not a square matrix
                MessageBox.Show(ise.Message);
            }
        }

        private void btnRREF_Click(object sender, EventArgs e)
        {
            if (validMatrix())
            {
                selectedMatrix = convertToMatrix(flpMatrixA, nudA_m, nudA_n);
                CurrentState = States.RREF;
                StateHandle(ref selectedMatrix);
            }
        }

        private void btnGenIdentity_Click(object sender, EventArgs e)
        {
            // If a square template is currently displayed, generate NxN identity
            if (nudA_m.Value == nudA_n.Value)
            {
                int n = (int)nudA_m.Value;
                Matrix identity = Matrix.identity(n);
                selectedMatrix = identity;
                displayMatrix(flpMatrixA, nudA_m, nudA_n, selectedMatrix);
            }
            else
            {
                MessageBox.Show("Identity matrix must be square, ensure m and n values are the same.");
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            readFromFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToFile();
        }
    }
}
