namespace P01_sortAscending
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
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            Calculate = new Button();
            textBoxResult = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 24);
            label1.Name = "label1";
            label1.Size = new Size(142, 37);
            label1.TabIndex = 0;
            label1.Text = "Number 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 89);
            label2.Name = "label2";
            label2.Size = new Size(142, 37);
            label2.TabIndex = 1;
            label2.Text = "Number 2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 149);
            label3.Name = "label3";
            label3.Size = new Size(142, 37);
            label3.TabIndex = 2;
            label3.Text = "Number 3:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(201, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 43);
            textBox1.TabIndex = 3;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(201, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 43);
            textBox2.TabIndex = 4;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(201, 146);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 43);
            textBox3.TabIndex = 5;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // Calculate
            // 
            Calculate.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Calculate.Location = new Point(29, 250);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(272, 61);
            Calculate.TabIndex = 6;
            Calculate.Text = "Calculate";
            Calculate.UseVisualStyleBackColor = true;
            Calculate.Click += Calculate_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxResult.Location = new Point(29, 338);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(272, 43);
            textBoxResult.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 405);
            Controls.Add(textBoxResult);
            Controls.Add(Calculate);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Ascending Order";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button Calculate;
        private TextBox textBoxResult;
    }
}
