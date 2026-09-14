namespace P02_popGrowth
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
            label1 = new Label();
            popAtxtBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            rateAtxtBox = new TextBox();
            rateBtxtBox = new TextBox();
            popBtxtBox = new TextBox();
            label4 = new Label();
            calcBtn = new Button();
            numericUpDown1 = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            futurepopBtxtBox = new TextBox();
            label8 = new Label();
            futurepopAtxtBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 106);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 37);
            label1.TabIndex = 0;
            label1.Text = "Town A:";
            // 
            // popAtxtBox
            // 
            popAtxtBox.Location = new Point(169, 106);
            popAtxtBox.Name = "popAtxtBox";
            popAtxtBox.Size = new Size(146, 43);
            popAtxtBox.TabIndex = 1;
            popAtxtBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 61);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(146, 37);
            label2.TabIndex = 2;
            label2.Text = "Population";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(355, 61);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(210, 37);
            label3.TabIndex = 4;
            label3.Text = "Growth Rate (%)";
            // 
            // rateAtxtBox
            // 
            rateAtxtBox.Location = new Point(384, 106);
            rateAtxtBox.Name = "rateAtxtBox";
            rateAtxtBox.Size = new Size(146, 43);
            rateAtxtBox.TabIndex = 3;
            rateAtxtBox.TextAlign = HorizontalAlignment.Center;
            // 
            // rateBtxtBox
            // 
            rateBtxtBox.Location = new Point(384, 174);
            rateBtxtBox.Name = "rateBtxtBox";
            rateBtxtBox.Size = new Size(146, 43);
            rateBtxtBox.TabIndex = 7;
            rateBtxtBox.TextAlign = HorizontalAlignment.Center;
            // 
            // popBtxtBox
            // 
            popBtxtBox.Location = new Point(169, 174);
            popBtxtBox.Name = "popBtxtBox";
            popBtxtBox.Size = new Size(146, 43);
            popBtxtBox.TabIndex = 6;
            popBtxtBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 174);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(107, 37);
            label4.TabIndex = 5;
            label4.Text = "Town B:";
            // 
            // calcBtn
            // 
            calcBtn.Location = new Point(28, 12);
            calcBtn.Name = "calcBtn";
            calcBtn.Size = new Size(163, 49);
            calcBtn.TabIndex = 8;
            calcBtn.Text = "Calculate";
            calcBtn.UseVisualStyleBackColor = true;
            calcBtn.Click += calcBtn_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(585, 175);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 43);
            numericUpDown1.TabIndex = 10;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(585, 123);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(78, 37);
            label5.TabIndex = 11;
            label5.Text = "Years";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(281, 24);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(105, 37);
            label6.TabIndex = 12;
            label6.Text = "Current";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(747, 24);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(92, 37);
            label7.TabIndex = 16;
            label7.Text = "Future";
            // 
            // futurepopBtxtBox
            // 
            futurepopBtxtBox.Location = new Point(736, 174);
            futurepopBtxtBox.Name = "futurepopBtxtBox";
            futurepopBtxtBox.Size = new Size(146, 43);
            futurepopBtxtBox.TabIndex = 15;
            futurepopBtxtBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(736, 61);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(146, 37);
            label8.TabIndex = 14;
            label8.Text = "Population";
            // 
            // futurepopAtxtBox
            // 
            futurepopAtxtBox.Location = new Point(736, 106);
            futurepopAtxtBox.Name = "futurepopAtxtBox";
            futurepopAtxtBox.Size = new Size(146, 43);
            futurepopAtxtBox.TabIndex = 13;
            futurepopAtxtBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 275);
            Controls.Add(label7);
            Controls.Add(futurepopBtxtBox);
            Controls.Add(label8);
            Controls.Add(futurepopAtxtBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(numericUpDown1);
            Controls.Add(calcBtn);
            Controls.Add(rateBtxtBox);
            Controls.Add(popBtxtBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(rateAtxtBox);
            Controls.Add(label2);
            Controls.Add(popAtxtBox);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Population Growth";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox popAtxtBox;
        private Label label2;
        private Label label3;
        private TextBox rateAtxtBox;
        private TextBox rateBtxtBox;
        private TextBox popBtxtBox;
        private Label label4;
        private Button calcBtn;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox futurepopBtxtBox;
        private Label label8;
        private TextBox futurepopAtxtBox;
    }
}
