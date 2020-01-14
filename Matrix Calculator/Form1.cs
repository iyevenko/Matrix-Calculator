﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix_Calculator
{
    public partial class Form1 : Form
    {
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

        private void btnMatrify_Click(object sender, EventArgs e)
        {
            Matrix A = ConvertToMatrix(flpMatrixA, nudA_m, nudA_n);
            MessageBox.Show(A.ToString());
        }

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

        private void nudA_m_ValueChanged(object sender, EventArgs e)
        {
            resizeMatrix(flpMatrixA, nudA_m, nudA_n);
        }

        private void nudA_n_ValueChanged(object sender, EventArgs e)
        {
            resizeMatrix(flpMatrixA, nudA_m, nudA_n);
        }
    }
}
