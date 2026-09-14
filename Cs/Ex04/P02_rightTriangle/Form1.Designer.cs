namespace P02_rightTriangle
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
            textBoxResult = new TextBox();
            Calculate = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxResult.Location = new Point(35, 353);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(392, 43);
            textBoxResult.TabIndex = 16;
            // 
            // Calculate
            // 
            Calculate.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Calculate.Location = new Point(105, 256);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(272, 61);
            Calculate.TabIndex = 15;
            Calculate.Text = "Calculate";
            Calculate.UseVisualStyleBackColor = true;
            Calculate.Click += Calculate_Click_1;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(277, 152);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 43);
            textBox3.TabIndex = 14;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(277, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 43);
            textBox2.TabIndex = 13;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(277, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 43);
            textBox1.TabIndex = 12;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(105, 155);
            label3.Name = "label3";
            label3.Size = new Size(96, 37);
            label3.TabIndex = 11;
            label3.Text = "Side 3:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(105, 95);
            label2.Name = "label2";
            label2.Size = new Size(96, 37);
            label2.TabIndex = 10;
            label2.Text = "Side 2:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(105, 30);
            label1.Name = "label1";
            label1.Size = new Size(96, 37);
            label1.TabIndex = 9;
            label1.Text = "Side 1:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 450);
            Controls.Add(textBoxResult);
            Controls.Add(Calculate);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Right Triangle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxResult;
        private Button Calculate;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
