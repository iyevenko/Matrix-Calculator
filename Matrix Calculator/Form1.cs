using System;
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
        }
    }
}
