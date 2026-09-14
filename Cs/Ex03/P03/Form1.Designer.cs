namespace P03
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
            InputBaseComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            OutputBaseComboBox = new ComboBox();
            label66 = new Label();
            InputNumberBox = new TextBox();
            outputNumLbl = new Label();
            CalcBtn = new Button();
            SuspendLayout();
            // 
            // InputBaseComboBox
            // 
            InputBaseComboBox.FormattingEnabled = true;
            InputBaseComboBox.Location = new Point(104, 75);
            InputBaseComboBox.Name = "InputBaseComboBox";
            InputBaseComboBox.Size = new Size(121, 23);
            InputBaseComboBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 48);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 1;
            label1.Text = "Input";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 79);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "Base";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(269, 49);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 4;
            label3.Text = "Output";
            // 
            // OutputBaseComboBox
            // 
            OutputBaseComboBox.FormattingEnabled = true;
            OutputBaseComboBox.Location = new Point(269, 76);
            OutputBaseComboBox.Name = "OutputBaseComboBox";
            OutputBaseComboBox.Size = new Size(121, 23);
            OutputBaseComboBox.TabIndex = 3;
            // 
            // label66
            // 
            label66.AutoSize = true;
            label66.Location = new Point(45, 145);
            label66.Name = "label66";
            label66.Size = new Size(51, 15);
            label66.TabIndex = 5;
            label66.Text = "Number";
            // 
            // InputNumberBox
            // 
            InputNumberBox.Location = new Point(104, 142);
            InputNumberBox.Name = "InputNumberBox";
            InputNumberBox.Size = new Size(121, 23);
            InputNumberBox.TabIndex = 6;
            // 
            // outputNumLbl
            // 
            outputNumLbl.AutoSize = true;
            outputNumLbl.BorderStyle = BorderStyle.FixedSingle;
            outputNumLbl.Location = new Point(273, 145);
            outputNumLbl.Name = "outputNumLbl";
            outputNumLbl.Size = new Size(2, 17);
            outputNumLbl.TabIndex = 7;
            // 
            // CalcBtn
            // 
            CalcBtn.Location = new Point(282, 197);
            CalcBtn.Name = "CalcBtn";
            CalcBtn.Size = new Size(75, 23);
            CalcBtn.TabIndex = 8;
            CalcBtn.Text = "Calculate";
            CalcBtn.UseVisualStyleBackColor = true;
            CalcBtn.Click += CalcBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 263);
            Controls.Add(CalcBtn);
            Controls.Add(outputNumLbl);
            Controls.Add(InputNumberBox);
            Controls.Add(label66);
            Controls.Add(label3);
            Controls.Add(OutputBaseComboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(InputBaseComboBox);
            Name = "Form1";
            Text = "Base Convert";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox InputBaseComboBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox OutputBaseComboBox;
        private Label label66;
        private TextBox InputNumberBox;
        private Label outputNumLbl;
        private Button CalcBtn;
    }
}
