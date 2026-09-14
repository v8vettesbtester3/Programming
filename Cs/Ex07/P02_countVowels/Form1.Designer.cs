namespace P02_countVowels
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
            textBoxInput = new TextBox();
            label2 = new Label();
            textBoxCount = new TextBox();
            buttonCount = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 24);
            label1.Name = "label1";
            label1.Size = new Size(159, 37);
            label1.TabIndex = 0;
            label1.Text = "Input string:";
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(29, 80);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(450, 198);
            textBoxInput.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 305);
            label2.Name = "label2";
            label2.Size = new Size(239, 37);
            label2.TabIndex = 2;
            label2.Text = "Number of vowels:";
            // 
            // textBoxCount
            // 
            textBoxCount.Location = new Point(287, 302);
            textBoxCount.Name = "textBoxCount";
            textBoxCount.Size = new Size(100, 43);
            textBoxCount.TabIndex = 3;
            // 
            // buttonCount
            // 
            buttonCount.Location = new Point(357, 375);
            buttonCount.Name = "buttonCount";
            buttonCount.Size = new Size(146, 55);
            buttonCount.TabIndex = 4;
            buttonCount.Text = "Count";
            buttonCount.UseVisualStyleBackColor = true;
            buttonCount.Click += buttonCount_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 442);
            Controls.Add(buttonCount);
            Controls.Add(textBoxCount);
            Controls.Add(label2);
            Controls.Add(textBoxInput);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Vowel Counter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxInput;
        private Label label2;
        private TextBox textBoxCount;
        private Button buttonCount;
    }
}
