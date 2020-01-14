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
        private void btnGen_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            n = Convert.ToInt32(txtWidth.Text);
            m = Convert.ToInt32(txtHeight.Text);
            if (n < 9)
            {
                flowLayoutPanel1.Width = n * 40;
            }
            else
            {
                flowLayoutPanel1.Width = n * 38;
            }
            
            for (int n = 0; n < m; n++)
            {
                for (int m = 0; m < n; m++)
                { 
                    flowLayoutPanel1.Controls.Add(tbox(n+1, m+1));
                }
            }
        }

        List<TextBox> tbs = new List<TextBox>();

        TextBox tbox(int n, int m)
        {
            TextBox t = new TextBox();
            string name = "txt_" + n.ToString() + "_" + m.ToString();
            t.Name = name;
            t.Width = 30;
            t.Height = 100;
            //t.Text = name;
            tbs.Add(t);
            return t;

        }

        private void btnMatrify_Click(object sender, EventArgs e)
        {
            double[,] matrix_kyd = new double[m, n];
            for (int i = 0; i < n; i++)
            {
                
            }
        }
    }
}
