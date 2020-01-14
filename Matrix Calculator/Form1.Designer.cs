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
            this.btnMatrify = new System.Windows.Forms.Button();
            this.nudA_m = new System.Windows.Forms.NumericUpDown();
            this.nudA_n = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudA_m)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudA_n)).BeginInit();
            this.SuspendLayout();
            // 
            // flpMatrixA
            // 
            this.flpMatrixA.Location = new System.Drawing.Point(12, 211);
            this.flpMatrixA.Name = "flpMatrixA";
            this.flpMatrixA.Size = new System.Drawing.Size(632, 614);
            this.flpMatrixA.TabIndex = 0;
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
            this.label2.Location = new System.Drawing.Point(202, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "n";
            // 
            // btnMatrify
            // 
            this.btnMatrify.Font = new System.Drawing.Font("Segoe Script", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatrify.Location = new System.Drawing.Point(361, 12);
            this.btnMatrify.Name = "btnMatrify";
            this.btnMatrify.Size = new System.Drawing.Size(218, 188);
            this.btnMatrify.TabIndex = 7;
            this.btnMatrify.Text = "Matrify";
            this.btnMatrify.UseVisualStyleBackColor = true;
            this.btnMatrify.Click += new System.EventHandler(this.btnMatrify_Click);
            // 
            // nudA_m
            // 
            this.nudA_m.Location = new System.Drawing.Point(53, 134);
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
            this.nudA_n.Location = new System.Drawing.Point(190, 134);
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
            this.nudA_n.TabIndex = 9;
            this.nudA_n.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudA_n.ValueChanged += new System.EventHandler(this.nudA_n_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "A";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("Segoe Script", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(701, 106);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(218, 188);
            this.btnDisplay.TabIndex = 11;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 837);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudA_n);
            this.Controls.Add(this.nudA_m);
            this.Controls.Add(this.btnMatrify);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpMatrixA);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudA_m)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudA_n)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpMatrixA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMatrify;
        private System.Windows.Forms.NumericUpDown nudA_m;
        private System.Windows.Forms.NumericUpDown nudA_n;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDisplay;
    }
}

