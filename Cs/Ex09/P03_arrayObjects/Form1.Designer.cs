namespace P03_arrayObjects
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numericUpDownSphereIndex = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            txtX = new TextBox();
            txtY = new TextBox();
            label3 = new Label();
            txtZ = new TextBox();
            label4 = new Label();
            txtR = new TextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            txtNumSpheres = new TextBox();
            label6 = new Label();
            listBoxSpheres = new ListBox();
            label7 = new Label();
            btnInit = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSphereIndex).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // numericUpDownSphereIndex
            // 
            numericUpDownSphereIndex.Location = new Point(16, 104);
            numericUpDownSphereIndex.Name = "numericUpDownSphereIndex";
            numericUpDownSphereIndex.Size = new Size(72, 23);
            numericUpDownSphereIndex.TabIndex = 0;
            numericUpDownSphereIndex.TextAlign = HorizontalAlignment.Center;
            numericUpDownSphereIndex.ValueChanged += numericUpDownSphereIndex_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 72);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 1;
            label1.Text = "Sphere Index";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 40);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 2;
            label2.Text = "X";
            // 
            // txtX
            // 
            txtX.Location = new Point(160, 104);
            txtX.Name = "txtX";
            txtX.Size = new Size(64, 23);
            txtX.TabIndex = 3;
            txtX.TextChanged += txtX_TextChanged;
            // 
            // txtY
            // 
            txtY.Location = new Point(160, 144);
            txtY.Name = "txtY";
            txtY.Size = new Size(64, 23);
            txtY.TabIndex = 5;
            txtY.TextChanged += txtY_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 80);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 4;
            label3.Text = "Y";
            // 
            // txtZ
            // 
            txtZ.Location = new Point(160, 184);
            txtZ.Name = "txtZ";
            txtZ.Size = new Size(64, 23);
            txtZ.TabIndex = 7;
            txtZ.TextChanged += txtZ_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 120);
            label4.Name = "label4";
            label4.Size = new Size(14, 15);
            label4.TabIndex = 6;
            label4.Text = "Z";
            // 
            // txtR
            // 
            txtR.Location = new Point(280, 104);
            txtR.Name = "txtR";
            txtR.Size = new Size(64, 23);
            txtR.TabIndex = 9;
            txtR.TextChanged += txtR_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(288, 72);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 8;
            label5.Text = "Radius";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlDark;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(112, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(144, 160);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Center Coordinates";
            // 
            // txtNumSpheres
            // 
            txtNumSpheres.Location = new Point(168, 24);
            txtNumSpheres.Name = "txtNumSpheres";
            txtNumSpheres.Size = new Size(64, 23);
            txtNumSpheres.TabIndex = 13;
            txtNumSpheres.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 24);
            label6.Name = "label6";
            label6.Size = new Size(137, 15);
            label6.TabIndex = 12;
            label6.Text = "Total Number of Spheres";
            // 
            // listBoxSpheres
            // 
            listBoxSpheres.FormattingEnabled = true;
            listBoxSpheres.HorizontalScrollbar = true;
            listBoxSpheres.ItemHeight = 15;
            listBoxSpheres.Location = new Point(40, 296);
            listBoxSpheres.Name = "listBoxSpheres";
            listBoxSpheres.Size = new Size(296, 124);
            listBoxSpheres.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 272);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 15;
            label7.Text = "Sphere List";
            // 
            // btnInit
            // 
            btnInit.Location = new Point(272, 24);
            btnInit.Name = "btnInit";
            btnInit.Size = new Size(75, 23);
            btnInit.TabIndex = 16;
            btnInit.Text = "Initialize";
            btnInit.UseVisualStyleBackColor = true;
            btnInit.Click += btnInit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 450);
            Controls.Add(btnInit);
            Controls.Add(label7);
            Controls.Add(listBoxSpheres);
            Controls.Add(txtNumSpheres);
            Controls.Add(label6);
            Controls.Add(txtR);
            Controls.Add(label5);
            Controls.Add(txtZ);
            Controls.Add(txtY);
            Controls.Add(txtX);
            Controls.Add(label1);
            Controls.Add(numericUpDownSphereIndex);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Many Spheres";
            ((System.ComponentModel.ISupportInitialize)numericUpDownSphereIndex).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownSphereIndex;
        private Label label1;
        private Label label2;
        private TextBox txtX;
        private TextBox txtY;
        private Label label3;
        private TextBox txtZ;
        private Label label4;
        private TextBox txtR;
        private Label label5;
        private GroupBox groupBox1;
        private TextBox txtNumSpheres;
        private Label label6;
        private ListBox listBoxSpheres;
        private Label label7;
        private Button btnInit;
    }
}
