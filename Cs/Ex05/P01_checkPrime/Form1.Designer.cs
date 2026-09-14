namespace P01_checkPrime
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
            inputTxtBox = new TextBox();
            calcButton = new Button();
            resultTxtBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // inputTxtBox
            // 
            inputTxtBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inputTxtBox.Location = new Point(107, 55);
            inputTxtBox.Name = "inputTxtBox";
            inputTxtBox.Size = new Size(107, 43);
            inputTxtBox.TabIndex = 0;
            inputTxtBox.TextAlign = HorizontalAlignment.Center;
            // 
            // calcButton
            // 
            calcButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            calcButton.Location = new Point(50, 141);
            calcButton.Name = "calcButton";
            calcButton.Size = new Size(220, 51);
            calcButton.TabIndex = 1;
            calcButton.Text = "Check 4 Prime";
            calcButton.UseVisualStyleBackColor = true;
            calcButton.Click += calcButton_Click;
            // 
            // resultTxtBox
            // 
            resultTxtBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultTxtBox.Location = new Point(50, 263);
            resultTxtBox.Multiline = true;
            resultTxtBox.Name = "resultTxtBox";
            resultTxtBox.ReadOnly = true;
            resultTxtBox.Size = new Size(220, 96);
            resultTxtBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 223);
            label1.Name = "label1";
            label1.Size = new Size(94, 37);
            label1.TabIndex = 3;
            label1.Text = "Result:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 4);
            label2.Name = "label2";
            label2.Size = new Size(252, 37);
            label2.TabIndex = 4;
            label2.Text = "Positive Integer > 1:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 396);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(resultTxtBox);
            Controls.Add(calcButton);
            Controls.Add(inputTxtBox);
            Name = "Form1";
            Text = "Check Prime";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputTxtBox;
        private Button calcButton;
        private TextBox resultTxtBox;
        private Label label1;
        private Label label2;
    }
}
