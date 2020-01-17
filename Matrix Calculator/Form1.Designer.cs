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
            this.btnGenIdentity = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudA_m)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudA_n)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpMatrixA
            // 
            this.flpMatrixA.Location = new System.Drawing.Point(12, 211);
            this.flpMatrixA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpMatrixA.Name = "flpMatrixA";
            this.flpMatrixA.Size = new System.Drawing.Size(632, 614);
            this.flpMatrixA.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "m";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "n";
            // 
            // nudA_m
            // 
            this.nudA_m.Location = new System.Drawing.Point(53, 134);
            this.nudA_m.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.nudA_m.Size = new System.Drawing.Size(120, 31);
            this.nudA_m.TabIndex = 0;
            this.nudA_m.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudA_m.ValueChanged += new System.EventHandler(this.nudA_m_ValueChanged);
            // 
            // nudA_n
            // 
            this.nudA_n.Location = new System.Drawing.Point(189, 134);
            this.nudA_n.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.nudA_n.Size = new System.Drawing.Size(120, 31);
            this.nudA_n.TabIndex = 1;
            this.nudA_n.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudA_n.ValueChanged += new System.EventHandler(this.nudA_n_ValueChanged);
            // 
            // btnStore
            // 
            this.btnStore.Location = new System.Drawing.Point(1091, 62);
            this.btnStore.Margin = new System.Windows.Forms.Padding(4);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(167, 84);
            this.btnStore.TabIndex = 3;
            this.btnStore.Text = "Store";
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(1091, 174);
            this.btnA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(167, 84);
            this.btnA.TabIndex = 3;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(1091, 287);
            this.btnB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(167, 84);
            this.btnB.TabIndex = 4;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(1091, 399);
            this.btnC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(167, 84);
            this.btnC.TabIndex = 5;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1313, 174);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(167, 84);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(1313, 287);
            this.btnSubtract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(167, 84);
            this.btnSubtract.TabIndex = 8;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(1313, 399);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(167, 84);
            this.btnMultiply.TabIndex = 9;
            this.btnMultiply.Text = "x";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // btnTranspose
            // 
            this.btnTranspose.Location = new System.Drawing.Point(1056, 552);
            this.btnTranspose.Margin = new System.Windows.Forms.Padding(4);
            this.btnTranspose.Name = "btnTranspose";
            this.btnTranspose.Size = new System.Drawing.Size(223, 105);
            this.btnTranspose.TabIndex = 10;
            this.btnTranspose.Text = "Transpose";
            this.btnTranspose.UseVisualStyleBackColor = true;
            this.btnTranspose.Click += new System.EventHandler(this.btnTranspose_Click);
            // 
            // btnDeterminant
            // 
            this.btnDeterminant.Location = new System.Drawing.Point(1056, 778);
            this.btnDeterminant.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeterminant.Name = "btnDeterminant";
            this.btnDeterminant.Size = new System.Drawing.Size(223, 105);
            this.btnDeterminant.TabIndex = 14;
            this.btnDeterminant.Text = "Determinant";
            this.btnDeterminant.UseVisualStyleBackColor = true;
            this.btnDeterminant.Click += new System.EventHandler(this.btnDeterminant_Click);
            // 
            // btnRank
            // 
            this.btnRank.Location = new System.Drawing.Point(1287, 778);
            this.btnRank.Margin = new System.Windows.Forms.Padding(4);
            this.btnRank.Name = "btnRank";
            this.btnRank.Size = new System.Drawing.Size(223, 105);
            this.btnRank.TabIndex = 15;
            this.btnRank.Text = "Rank";
            this.btnRank.UseVisualStyleBackColor = true;
            this.btnRank.Click += new System.EventHandler(this.btnRank_Click);
            // 
            // btnUpperTriangular
            // 
            this.btnUpperTriangular.Location = new System.Drawing.Point(1056, 665);
            this.btnUpperTriangular.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpperTriangular.Name = "btnUpperTriangular";
            this.btnUpperTriangular.Size = new System.Drawing.Size(223, 105);
            this.btnUpperTriangular.TabIndex = 12;
            this.btnUpperTriangular.Text = "Upper Triangular";
            this.btnUpperTriangular.UseVisualStyleBackColor = true;
            this.btnUpperTriangular.Click += new System.EventHandler(this.btnUpperTriangular_Click);
            // 
            // btnLowerTriangular
            // 
            this.btnLowerTriangular.Location = new System.Drawing.Point(1287, 665);
            this.btnLowerTriangular.Margin = new System.Windows.Forms.Padding(4);
            this.btnLowerTriangular.Name = "btnLowerTriangular";
            this.btnLowerTriangular.Size = new System.Drawing.Size(223, 105);
            this.btnLowerTriangular.TabIndex = 13;
            this.btnLowerTriangular.Text = "Lower Triangular";
            this.btnLowerTriangular.UseVisualStyleBackColor = true;
            this.btnLowerTriangular.Click += new System.EventHandler(this.btnLowerTriangular_Click);
            // 
            // btnRREF
            // 
            this.btnRREF.Location = new System.Drawing.Point(1287, 552);
            this.btnRREF.Margin = new System.Windows.Forms.Padding(4);
            this.btnRREF.Name = "btnRREF";
            this.btnRREF.Size = new System.Drawing.Size(223, 105);
            this.btnRREF.TabIndex = 11;
            this.btnRREF.Text = "RREF";
            this.btnRREF.UseVisualStyleBackColor = true;
            this.btnRREF.Click += new System.EventHandler(this.btnRREF_Click);
            // 
            // btnGenIdentity
            // 
            this.btnGenIdentity.Location = new System.Drawing.Point(1314, 62);
            this.btnGenIdentity.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenIdentity.Name = "btnGenIdentity";
            this.btnGenIdentity.Size = new System.Drawing.Size(166, 84);
            this.btnGenIdentity.TabIndex = 6;
            this.btnGenIdentity.Text = "Generate Identity Matrix";
            this.btnGenIdentity.UseVisualStyleBackColor = true;
            this.btnGenIdentity.Click += new System.EventHandler(this.btnGenIdentity_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1612, 40);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(173, 38);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(173, 38);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1612, 1029);
            this.Controls.Add(this.btnGenIdentity);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "el Matriz Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudA_m)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudA_n)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Button btnGenIdentity;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}

