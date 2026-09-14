namespace P01_paintingEstimate
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
            label4 = new Label();
            textBoxLength = new TextBox();
            textBoxWidth = new TextBox();
            textBoxHeight = new TextBox();
            label5 = new Label();
            textBoxCostSqFt = new TextBox();
            button1 = new Button();
            textBoxTotalCost = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 20);
            label1.Name = "label1";
            label1.Size = new Size(272, 37);
            label1.TabIndex = 0;
            label1.Text = "Room Dimensions (ft)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 89);
            label2.Name = "label2";
            label2.Size = new Size(99, 37);
            label2.TabIndex = 1;
            label2.Text = "Length";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 152);
            label3.Name = "label3";
            label3.Size = new Size(89, 37);
            label3.TabIndex = 2;
            label3.Text = "Width";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 213);
            label4.Name = "label4";
            label4.Size = new Size(97, 37);
            label4.TabIndex = 3;
            label4.Text = "Height";
            // 
            // textBoxLength
            // 
            textBoxLength.Location = new Point(207, 83);
            textBoxLength.Name = "textBoxLength";
            textBoxLength.Size = new Size(100, 43);
            textBoxLength.TabIndex = 4;
            // 
            // textBoxWidth
            // 
            textBoxWidth.Location = new Point(207, 149);
            textBoxWidth.Name = "textBoxWidth";
            textBoxWidth.Size = new Size(100, 43);
            textBoxWidth.TabIndex = 5;
            // 
            // textBoxHeight
            // 
            textBoxHeight.Location = new Point(207, 210);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(100, 43);
            textBoxHeight.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 306);
            label5.Name = "label5";
            label5.Size = new Size(316, 37);
            label5.TabIndex = 7;
            label5.Text = "Painting Cost ($ per sq ft)";
            // 
            // textBoxCostSqFt
            // 
            textBoxCostSqFt.Location = new Point(207, 358);
            textBoxCostSqFt.Name = "textBoxCostSqFt";
            textBoxCostSqFt.Size = new Size(100, 43);
            textBoxCostSqFt.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(161, 581);
            button1.Name = "button1";
            button1.Size = new Size(146, 64);
            button1.TabIndex = 9;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxTotalCost
            // 
            textBoxTotalCost.Location = new Point(207, 482);
            textBoxTotalCost.Name = "textBoxTotalCost";
            textBoxTotalCost.ReadOnly = true;
            textBoxTotalCost.Size = new Size(155, 43);
            textBoxTotalCost.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 430);
            label6.Name = "label6";
            label6.Size = new Size(172, 37);
            label6.TabIndex = 10;
            label6.Text = "Total Cost ($)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 685);
            Controls.Add(textBoxTotalCost);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(textBoxCostSqFt);
            Controls.Add(label5);
            Controls.Add(textBoxHeight);
            Controls.Add(textBoxWidth);
            Controls.Add(textBoxLength);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxLength;
        private TextBox textBoxWidth;
        private TextBox textBoxHeight;
        private Label label5;
        private TextBox textBoxCostSqFt;
        private Button button1;
        private TextBox textBoxTotalCost;
        private Label label6;
    }
}
