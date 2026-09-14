namespace P02
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
            totalEggCountBox = new TextBox();
            calcBtn = new Button();
            label2 = new Label();
            QuantBox1 = new TextBox();
            ItemBox1 = new TextBox();
            label3 = new Label();
            PrEachBox1 = new TextBox();
            label4 = new Label();
            PrTotalBox1 = new TextBox();
            label5 = new Label();
            PrTotalBox2 = new TextBox();
            PrEachBox2 = new TextBox();
            ItemBox2 = new TextBox();
            QuantBox2 = new TextBox();
            label6 = new Label();
            totalCostBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 10);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "Number of Eggs";
            // 
            // totalEggCountBox
            // 
            totalEggCountBox.Location = new Point(12, 41);
            totalEggCountBox.Name = "totalEggCountBox";
            totalEggCountBox.Size = new Size(52, 23);
            totalEggCountBox.TabIndex = 1;
            // 
            // calcBtn
            // 
            calcBtn.Location = new Point(148, 40);
            calcBtn.Name = "calcBtn";
            calcBtn.Size = new Size(75, 23);
            calcBtn.TabIndex = 2;
            calcBtn.Text = "Calculate";
            calcBtn.UseVisualStyleBackColor = true;
            calcBtn.Click += calcBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 121);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 3;
            label2.Text = "Quantity";
            // 
            // QuantBox1
            // 
            QuantBox1.Location = new Point(14, 147);
            QuantBox1.Name = "QuantBox1";
            QuantBox1.Size = new Size(50, 23);
            QuantBox1.TabIndex = 4;
            // 
            // ItemBox1
            // 
            ItemBox1.Location = new Point(86, 147);
            ItemBox1.Name = "ItemBox1";
            ItemBox1.Size = new Size(118, 23);
            ItemBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 121);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 5;
            label3.Text = "Item";
            // 
            // PrEachBox1
            // 
            PrEachBox1.Location = new Point(225, 147);
            PrEachBox1.Name = "PrEachBox1";
            PrEachBox1.Size = new Size(50, 23);
            PrEachBox1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(222, 121);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 7;
            label4.Text = "Price Ea";
            // 
            // PrTotalBox1
            // 
            PrTotalBox1.Location = new Point(293, 147);
            PrTotalBox1.Name = "PrTotalBox1";
            PrTotalBox1.Size = new Size(50, 23);
            PrTotalBox1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(290, 121);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 9;
            label5.Text = "Price Tot";
            // 
            // PrTotalBox2
            // 
            PrTotalBox2.Location = new Point(293, 176);
            PrTotalBox2.Name = "PrTotalBox2";
            PrTotalBox2.Size = new Size(50, 23);
            PrTotalBox2.TabIndex = 14;
            // 
            // PrEachBox2
            // 
            PrEachBox2.Location = new Point(225, 176);
            PrEachBox2.Name = "PrEachBox2";
            PrEachBox2.Size = new Size(50, 23);
            PrEachBox2.TabIndex = 13;
            // 
            // ItemBox2
            // 
            ItemBox2.Location = new Point(86, 176);
            ItemBox2.Name = "ItemBox2";
            ItemBox2.Size = new Size(118, 23);
            ItemBox2.TabIndex = 12;
            // 
            // QuantBox2
            // 
            QuantBox2.Location = new Point(14, 176);
            QuantBox2.Name = "QuantBox2";
            QuantBox2.Size = new Size(50, 23);
            QuantBox2.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(216, 238);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 15;
            label6.Text = "Total Cost";
            // 
            // totalCostBox
            // 
            totalCostBox.Location = new Point(293, 230);
            totalCostBox.Name = "totalCostBox";
            totalCostBox.Size = new Size(50, 23);
            totalCostBox.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 264);
            Controls.Add(totalCostBox);
            Controls.Add(label6);
            Controls.Add(PrTotalBox2);
            Controls.Add(PrEachBox2);
            Controls.Add(ItemBox2);
            Controls.Add(QuantBox2);
            Controls.Add(PrTotalBox1);
            Controls.Add(label5);
            Controls.Add(PrEachBox1);
            Controls.Add(label4);
            Controls.Add(ItemBox1);
            Controls.Add(label3);
            Controls.Add(QuantBox1);
            Controls.Add(label2);
            Controls.Add(calcBtn);
            Controls.Add(totalEggCountBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Eggs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox totalEggCountBox;
        private Button calcBtn;
        private Label label2;
        private TextBox QuantBox1;
        private TextBox ItemBox1;
        private Label label3;
        private TextBox PrEachBox1;
        private Label label4;
        private TextBox PrTotalBox1;
        private Label label5;
        private TextBox PrTotalBox2;
        private TextBox PrEachBox2;
        private TextBox ItemBox2;
        private TextBox QuantBox2;
        private Label label6;
        private TextBox totalCostBox;
    }
}
