namespace P03_conicalCup
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
            button1 = new Button();
            RadiustextBox = new TextBox();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ApexAngletextBox = new TextBox();
            label4 = new Label();
            ConeVoltextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(169, 53);
            button1.TabIndex = 0;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RadiustextBox
            // 
            RadiustextBox.Location = new Point(262, 120);
            RadiustextBox.Name = "RadiustextBox";
            RadiustextBox.Size = new Size(127, 43);
            RadiustextBox.TabIndex = 1;
            RadiustextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDown1.Location = new Point(262, 179);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(127, 43);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 120);
            label1.Name = "label1";
            label1.Size = new Size(231, 37);
            label1.TabIndex = 2;
            label1.Text = "Disk Radius (inch):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 185);
            label2.Name = "label2";
            label2.Size = new Size(218, 37);
            label2.TabIndex = 4;
            label2.Text = "Sector Len (inch):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 254);
            label3.Name = "label3";
            label3.Size = new Size(227, 37);
            label3.TabIndex = 6;
            label3.Text = "Apex Angle (deg):";
            // 
            // ApexAngletextBox
            // 
            ApexAngletextBox.Location = new Point(262, 254);
            ApexAngletextBox.Name = "ApexAngletextBox";
            ApexAngletextBox.ReadOnly = true;
            ApexAngletextBox.Size = new Size(127, 43);
            ApexAngletextBox.TabIndex = 5;
            ApexAngletextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 318);
            label4.Name = "label4";
            label4.Size = new Size(209, 37);
            label4.TabIndex = 8;
            label4.Text = "Cone Vol (cu in):";
            // 
            // ConeVoltextBox
            // 
            ConeVoltextBox.Location = new Point(262, 318);
            ConeVoltextBox.Name = "ConeVoltextBox";
            ConeVoltextBox.ReadOnly = true;
            ConeVoltextBox.Size = new Size(127, 43);
            ConeVoltextBox.TabIndex = 7;
            ConeVoltextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 400);
            Controls.Add(label4);
            Controls.Add(ConeVoltextBox);
            Controls.Add(label3);
            Controls.Add(ApexAngletextBox);
            Controls.Add(label2);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Controls.Add(RadiustextBox);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Conical Cup";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox RadiustextBox;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox ApexAngletextBox;
        private Label label4;
        private TextBox ConeVoltextBox;
    }
}
