namespace Matrix_Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flpMatrixA = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudA_m = new System.Windows.Forms.NumericUpDown();
            this.nudA_n = new System.Windows.Forms.NumericUpDown();
            this.btnStore = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnTranspose = new System.Windows.Forms.Button();
            this.btnDeterminant = new System.Windows.Forms.Button();
            this.btnRank = new System.Windows.Forms.Button();
            this.btnUpperTriangular = new System.Windows.Forms.Button();
            this.btnLowerTriangular = new System.Windows.Forms.Button();
            this.btnRREF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudA_m)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudA_n)).BeginInit();
            this.SuspendLayout();
            // 
            // flpMatrixA
            // 
            this.flpMatrixA.Location = new System.Drawing.Point(9, 169);
            this.flpMatrixA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpMatrixA.Name = "flpMatrixA";
            this.flpMatrixA.Size = new System.Drawing.Size(474, 491);
            this.flpMatrixA.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "m";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "n";
            // 
            // nudA_m
            // 
            this.nudA_m.Location = new System.Drawing.Point(40, 107);
            this.nudA_m.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudA_m.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudA_m.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudA_m.Name = "nudA_m";
            this.nudA_m.Size = new System.Drawing.Size(90, 26);
            this.nudA_m.TabIndex = 8;
            this.nudA_m.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudA_m.ValueChanged += new System.EventHandler(this.nudA_m_ValueChanged);
            // 
            // nudA_n
            // 
            this.nudA_n.Location = new System.Drawing.Point(142, 107);
            this.nudA_n.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudA_n.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudA_n.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudA_n.Name = "nudA_n";
            this.nudA_n.Size = new System.Drawing.Size(90, 26);
            this.nudA_n.TabIndex = 9;
            this.nudA_n.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudA_n.ValueChanged += new System.EventHandler(this.nudA_n_ValueChanged);
            // 
            // btnStore
            // 
            this.btnStore.Location = new System.Drawing.Point(792, 47);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(125, 67);
            this.btnStore.TabIndex = 12;
            this.btnStore.Text = "Store";
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(578, 370);
            this.btnA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnA.Location = new System.Drawing.Point(1151, 118);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(125, 67);
            this.btnA.TabIndex = 13;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(578, 442);
            this.btnB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnB.Location = new System.Drawing.Point(1151, 208);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(125, 67);
            this.btnB.TabIndex = 14;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(578, 514);
            this.btnC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnC.Location = new System.Drawing.Point(1151, 298);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(125, 67);
            this.btnC.TabIndex = 15;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(529, 110);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Location = new System.Drawing.Point(792, 137);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 67);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(529, 182);
            this.btnSubtract.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubtract.Location = new System.Drawing.Point(792, 227);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(125, 67);
            this.btnSubtract.TabIndex = 17;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnMultiply
            //
            this.btnMultiply.Location = new System.Drawing.Point(529, 254);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMultiply.Location = new System.Drawing.Point(792, 317);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(125, 67);
            this.btnMultiply.TabIndex = 18;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // btnTranspose
            // 
            this.btnTranspose.Location = new System.Drawing.Point(792, 442);
            this.btnTranspose.Name = "btnTranspose";
            this.btnTranspose.Size = new System.Drawing.Size(167, 84);
            this.btnTranspose.TabIndex = 19;
            this.btnTranspose.Text = "Transpose";
            this.btnTranspose.UseVisualStyleBackColor = true;
            this.btnTranspose.Click += new System.EventHandler(this.btnTranspose_Click);
            // 
            // btnDeterminant
            // 
            this.btnDeterminant.Location = new System.Drawing.Point(792, 532);
            this.btnDeterminant.Name = "btnDeterminant";
            this.btnDeterminant.Size = new System.Drawing.Size(167, 84);
            this.btnDeterminant.TabIndex = 20;
            this.btnDeterminant.Text = "Determinant";
            this.btnDeterminant.UseVisualStyleBackColor = true;
            this.btnDeterminant.Click += new System.EventHandler(this.btnDeterminant_Click);
            // 
            // btnRank
            // 
            this.btnRank.Location = new System.Drawing.Point(792, 622);
            this.btnRank.Name = "btnRank";
            this.btnRank.Size = new System.Drawing.Size(167, 84);
            this.btnRank.TabIndex = 21;
            this.btnRank.Text = "Rank";
            this.btnRank.UseVisualStyleBackColor = true;
            this.btnRank.Click += new System.EventHandler(this.btnRank_Click);
            // 
            // btnUpperTriangular
            // 
            this.btnUpperTriangular.Location = new System.Drawing.Point(792, 712);
            this.btnUpperTriangular.Name = "btnUpperTriangular";
            this.btnUpperTriangular.Size = new System.Drawing.Size(167, 84);
            this.btnUpperTriangular.TabIndex = 22;
            this.btnUpperTriangular.Text = "Upper Triangular";
            this.btnUpperTriangular.UseVisualStyleBackColor = true;
            this.btnUpperTriangular.Click += new System.EventHandler(this.btnUpperTriangular_Click);
            // 
            // btnLowerTriangular
            // 
            this.btnLowerTriangular.Location = new System.Drawing.Point(965, 712);
            this.btnLowerTriangular.Name = "btnLowerTriangular";
            this.btnLowerTriangular.Size = new System.Drawing.Size(167, 84);
            this.btnLowerTriangular.TabIndex = 23;
            this.btnLowerTriangular.Text = "Lower Triangular";
            this.btnLowerTriangular.UseVisualStyleBackColor = true;
            this.btnLowerTriangular.Click += new System.EventHandler(this.btnLowerTriangular_Click);
            // 
            // btnRREF
            // 
            this.btnRREF.Location = new System.Drawing.Point(965, 442);
            this.btnRREF.Name = "btnRREF";
            this.btnRREF.Size = new System.Drawing.Size(167, 84);
            this.btnRREF.TabIndex = 24;
            this.btnRREF.Text = "RREF";
            this.btnRREF.UseVisualStyleBackColor = true;
            this.btnRREF.Click += new System.EventHandler(this.btnRREF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 670);
            this.ClientSize = new System.Drawing.Size(1559, 1075);
            this.Controls.Add(this.btnRREF);
            this.Controls.Add(this.btnLowerTriangular);
            this.Controls.Add(this.btnUpperTriangular);
            this.Controls.Add(this.btnRank);
            this.Controls.Add(this.btnDeterminant);
            this.Controls.Add(this.btnTranspose);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnStore);
            this.Controls.Add(this.nudA_n);
            this.Controls.Add(this.nudA_m);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpMatrixA);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "el Matriz Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudA_m)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudA_n)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpMatrixA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudA_m;
        private System.Windows.Forms.NumericUpDown nudA_n;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnTranspose;
        private System.Windows.Forms.Button btnDeterminant;
        private System.Windows.Forms.Button btnRank;
        private System.Windows.Forms.Button btnUpperTriangular;
        private System.Windows.Forms.Button btnLowerTriangular;
        private System.Windows.Forms.Button btnRREF;
    }
}

