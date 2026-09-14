namespace P01
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
            nameBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            nameBox2 = new TextBox();
            label4 = new Label();
            nameBox3 = new TextBox();
            votesBox3 = new TextBox();
            votesBox2 = new TextBox();
            label5 = new Label();
            votesBox1 = new TextBox();
            percentBox3 = new TextBox();
            percentBox2 = new TextBox();
            label6 = new Label();
            percentBox1 = new TextBox();
            calcBtn1 = new Button();
            SuspendLayout();
            // 
            // nameBox1
            // 
            nameBox1.Location = new Point(45, 96);
            nameBox1.Name = "nameBox1";
            nameBox1.Size = new Size(148, 23);
            nameBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 68);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 99);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 2;
            label2.Text = "1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 126);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 4;
            label3.Text = "2";
            // 
            // nameBox2
            // 
            nameBox2.Location = new Point(45, 123);
            nameBox2.Name = "nameBox2";
            nameBox2.Size = new Size(148, 23);
            nameBox2.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 155);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 6;
            label4.Text = "3";
            // 
            // nameBox3
            // 
            nameBox3.Location = new Point(45, 152);
            nameBox3.Name = "nameBox3";
            nameBox3.Size = new Size(148, 23);
            nameBox3.TabIndex = 5;
            // 
            // votesBox3
            // 
            votesBox3.Location = new Point(213, 153);
            votesBox3.Name = "votesBox3";
            votesBox3.Size = new Size(74, 23);
            votesBox3.TabIndex = 10;
            // 
            // votesBox2
            // 
            votesBox2.Location = new Point(213, 124);
            votesBox2.Name = "votesBox2";
            votesBox2.Size = new Size(74, 23);
            votesBox2.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(213, 69);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 8;
            label5.Text = "Votes";
            // 
            // votesBox1
            // 
            votesBox1.Location = new Point(213, 97);
            votesBox1.Name = "votesBox1";
            votesBox1.Size = new Size(74, 23);
            votesBox1.TabIndex = 7;
            // 
            // percentBox3
            // 
            percentBox3.Location = new Point(316, 153);
            percentBox3.Name = "percentBox3";
            percentBox3.Size = new Size(74, 23);
            percentBox3.TabIndex = 14;
            // 
            // percentBox2
            // 
            percentBox2.Location = new Point(316, 124);
            percentBox2.Name = "percentBox2";
            percentBox2.Size = new Size(74, 23);
            percentBox2.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(316, 69);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 12;
            label6.Text = "Percents";
            // 
            // percentBox1
            // 
            percentBox1.Location = new Point(316, 97);
            percentBox1.Name = "percentBox1";
            percentBox1.Size = new Size(74, 23);
            percentBox1.TabIndex = 11;
            // 
            // calcBtn1
            // 
            calcBtn1.Location = new Point(321, 205);
            calcBtn1.Name = "calcBtn1";
            calcBtn1.Size = new Size(75, 23);
            calcBtn1.TabIndex = 15;
            calcBtn1.Text = "Calculate";
            calcBtn1.UseVisualStyleBackColor = true;
            calcBtn1.Click += calcBtn1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 257);
            Controls.Add(calcBtn1);
            Controls.Add(percentBox3);
            Controls.Add(percentBox2);
            Controls.Add(label6);
            Controls.Add(percentBox1);
            Controls.Add(votesBox3);
            Controls.Add(votesBox2);
            Controls.Add(label5);
            Controls.Add(votesBox1);
            Controls.Add(label4);
            Controls.Add(nameBox3);
            Controls.Add(label3);
            Controls.Add(nameBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nameBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox nameBox2;
        private Label label4;
        private TextBox nameBox3;
        private TextBox votesBox3;
        private TextBox votesBox2;
        private Label label5;
        private TextBox votesBox1;
        private TextBox percentBox3;
        private TextBox percentBox2;
        private Label label6;
        private TextBox percentBox1;
        private Button calcBtn1;
    }
}
