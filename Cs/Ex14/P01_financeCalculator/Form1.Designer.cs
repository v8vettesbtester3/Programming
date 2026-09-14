namespace P01_financeCalculator
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
            calculatorTabs = new TabControl();
            tabCalculator = new TabPage();
            btnClear = new Button();
            btnPlus = new Button();
            btnEquals = new Button();
            btnPeriod = new Button();
            btn0 = new Button();
            btnMinus = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnMultiply = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnDivide = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            outputBox = new TextBox();
            tabInterest = new TabPage();
            btnCalculate = new Button();
            grpFrequency = new GroupBox();
            rdoAnnually = new RadioButton();
            rdoSemi = new RadioButton();
            rdoQtr = new RadioButton();
            rdoMonthly = new RadioButton();
            cmpdOutput = new TextBox();
            txtYears = new TextBox();
            txtInterest = new TextBox();
            txtDollars = new TextBox();
            lblYears = new Label();
            lblRate = new Label();
            lblAmount = new Label();
            calculatorTabs.SuspendLayout();
            tabCalculator.SuspendLayout();
            tabInterest.SuspendLayout();
            grpFrequency.SuspendLayout();
            SuspendLayout();
            // 
            // calculatorTabs
            // 
            calculatorTabs.Controls.Add(tabCalculator);
            calculatorTabs.Controls.Add(tabInterest);
            calculatorTabs.Dock = DockStyle.Top;
            calculatorTabs.Location = new Point(0, 0);
            calculatorTabs.Name = "calculatorTabs";
            calculatorTabs.SelectedIndex = 0;
            calculatorTabs.Size = new Size(403, 480);
            calculatorTabs.TabIndex = 0;
            // 
            // tabCalculator
            // 
            tabCalculator.BackColor = Color.Black;
            tabCalculator.Controls.Add(btnClear);
            tabCalculator.Controls.Add(btnPlus);
            tabCalculator.Controls.Add(btnEquals);
            tabCalculator.Controls.Add(btnPeriod);
            tabCalculator.Controls.Add(btn0);
            tabCalculator.Controls.Add(btnMinus);
            tabCalculator.Controls.Add(btn3);
            tabCalculator.Controls.Add(btn2);
            tabCalculator.Controls.Add(btn1);
            tabCalculator.Controls.Add(btnMultiply);
            tabCalculator.Controls.Add(btn6);
            tabCalculator.Controls.Add(btn5);
            tabCalculator.Controls.Add(btn4);
            tabCalculator.Controls.Add(btnDivide);
            tabCalculator.Controls.Add(btn9);
            tabCalculator.Controls.Add(btn8);
            tabCalculator.Controls.Add(btn7);
            tabCalculator.Controls.Add(outputBox);
            tabCalculator.Location = new Point(4, 24);
            tabCalculator.Name = "tabCalculator";
            tabCalculator.Padding = new Padding(3);
            tabCalculator.Size = new Size(395, 452);
            tabCalculator.TabIndex = 0;
            tabCalculator.Text = "Calculator";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DodgerBlue;
            btnClear.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(120, 376);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(144, 56);
            btnClear.TabIndex = 17;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.SkyBlue;
            btnPlus.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(280, 304);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(64, 56);
            btnPlus.TabIndex = 16;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += operator_Click;
            // 
            // btnEquals
            // 
            btnEquals.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEquals.Location = new Point(200, 304);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(64, 56);
            btnEquals.TabIndex = 15;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += equalBtn_Click;
            // 
            // btnPeriod
            // 
            btnPeriod.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPeriod.Location = new Point(120, 304);
            btnPeriod.Name = "btnPeriod";
            btnPeriod.Size = new Size(64, 56);
            btnPeriod.TabIndex = 14;
            btnPeriod.Text = ".";
            btnPeriod.UseVisualStyleBackColor = true;
            btnPeriod.Click += click_btn;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn0.Location = new Point(40, 304);
            btn0.Name = "btn0";
            btn0.Size = new Size(64, 56);
            btn0.TabIndex = 13;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += click_btn;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.SkyBlue;
            btnMinus.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinus.Location = new Point(280, 232);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(64, 56);
            btnMinus.TabIndex = 12;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += operator_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn3.Location = new Point(200, 232);
            btn3.Name = "btn3";
            btn3.Size = new Size(64, 56);
            btn3.TabIndex = 11;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += click_btn;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.Location = new Point(120, 232);
            btn2.Name = "btn2";
            btn2.Size = new Size(64, 56);
            btn2.TabIndex = 10;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += click_btn;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.Location = new Point(40, 232);
            btn1.Name = "btn1";
            btn1.Size = new Size(64, 56);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += click_btn;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.SkyBlue;
            btnMultiply.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMultiply.Location = new Point(280, 160);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(64, 56);
            btnMultiply.TabIndex = 8;
            btnMultiply.Text = "X";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += operator_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn6.Location = new Point(200, 160);
            btn6.Name = "btn6";
            btn6.Size = new Size(64, 56);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += click_btn;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn5.Location = new Point(120, 160);
            btn5.Name = "btn5";
            btn5.Size = new Size(64, 56);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += click_btn;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4.Location = new Point(40, 160);
            btn4.Name = "btn4";
            btn4.Size = new Size(64, 56);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += click_btn;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.SkyBlue;
            btnDivide.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDivide.Location = new Point(280, 88);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(64, 56);
            btnDivide.TabIndex = 4;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += operator_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn9.Location = new Point(200, 88);
            btn9.Name = "btn9";
            btn9.Size = new Size(64, 56);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += click_btn;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn8.Location = new Point(120, 88);
            btn8.Name = "btn8";
            btn8.Size = new Size(64, 56);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += click_btn;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn7.Location = new Point(40, 88);
            btn7.Name = "btn7";
            btn7.Size = new Size(64, 56);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += click_btn;
            // 
            // outputBox
            // 
            outputBox.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            outputBox.Location = new Point(40, 8);
            outputBox.Name = "outputBox";
            outputBox.Size = new Size(304, 54);
            outputBox.TabIndex = 0;
            outputBox.Text = "0";
            outputBox.TextAlign = HorizontalAlignment.Center;
            // 
            // tabInterest
            // 
            tabInterest.Controls.Add(btnCalculate);
            tabInterest.Controls.Add(grpFrequency);
            tabInterest.Controls.Add(cmpdOutput);
            tabInterest.Controls.Add(txtYears);
            tabInterest.Controls.Add(txtInterest);
            tabInterest.Controls.Add(txtDollars);
            tabInterest.Controls.Add(lblYears);
            tabInterest.Controls.Add(lblRate);
            tabInterest.Controls.Add(lblAmount);
            tabInterest.Location = new Point(4, 24);
            tabInterest.Name = "tabInterest";
            tabInterest.Padding = new Padding(3);
            tabInterest.Size = new Size(395, 452);
            tabInterest.TabIndex = 1;
            tabInterest.Text = "Compound Interest";
            tabInterest.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(56, 328);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(112, 48);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculateInterest;
            // 
            // grpFrequency
            // 
            grpFrequency.Controls.Add(rdoAnnually);
            grpFrequency.Controls.Add(rdoSemi);
            grpFrequency.Controls.Add(rdoQtr);
            grpFrequency.Controls.Add(rdoMonthly);
            grpFrequency.Location = new Point(8, 192);
            grpFrequency.Name = "grpFrequency";
            grpFrequency.Size = new Size(384, 64);
            grpFrequency.TabIndex = 7;
            grpFrequency.TabStop = false;
            grpFrequency.Text = "Compound Frequency";
            // 
            // rdoAnnually
            // 
            rdoAnnually.AutoSize = true;
            rdoAnnually.Location = new Point(288, 24);
            rdoAnnually.Name = "rdoAnnually";
            rdoAnnually.Size = new Size(72, 19);
            rdoAnnually.TabIndex = 3;
            rdoAnnually.TabStop = true;
            rdoAnnually.Text = "Annually";
            rdoAnnually.UseVisualStyleBackColor = true;
            // 
            // rdoSemi
            // 
            rdoSemi.AutoSize = true;
            rdoSemi.Location = new Point(184, 24);
            rdoSemi.Name = "rdoSemi";
            rdoSemi.Size = new Size(96, 19);
            rdoSemi.TabIndex = 2;
            rdoSemi.TabStop = true;
            rdoSemi.Text = "Semiannually";
            rdoSemi.UseVisualStyleBackColor = true;
            // 
            // rdoQtr
            // 
            rdoQtr.AutoSize = true;
            rdoQtr.Location = new Point(96, 24);
            rdoQtr.Name = "rdoQtr";
            rdoQtr.Size = new Size(74, 19);
            rdoQtr.TabIndex = 1;
            rdoQtr.TabStop = true;
            rdoQtr.Text = "Quarterly";
            rdoQtr.UseVisualStyleBackColor = true;
            // 
            // rdoMonthly
            // 
            rdoMonthly.AutoSize = true;
            rdoMonthly.Location = new Point(16, 24);
            rdoMonthly.Name = "rdoMonthly";
            rdoMonthly.Size = new Size(70, 19);
            rdoMonthly.TabIndex = 0;
            rdoMonthly.TabStop = true;
            rdoMonthly.Text = "Monthly";
            rdoMonthly.UseVisualStyleBackColor = true;
            // 
            // cmpdOutput
            // 
            cmpdOutput.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmpdOutput.Location = new Point(192, 336);
            cmpdOutput.Name = "cmpdOutput";
            cmpdOutput.Size = new Size(184, 35);
            cmpdOutput.TabIndex = 6;
            // 
            // txtYears
            // 
            txtYears.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtYears.Location = new Point(232, 128);
            txtYears.Name = "txtYears";
            txtYears.Size = new Size(144, 35);
            txtYears.TabIndex = 5;
            // 
            // txtInterest
            // 
            txtInterest.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInterest.Location = new Point(232, 88);
            txtInterest.Name = "txtInterest";
            txtInterest.Size = new Size(144, 35);
            txtInterest.TabIndex = 4;
            // 
            // txtDollars
            // 
            txtDollars.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDollars.Location = new Point(232, 48);
            txtDollars.Name = "txtDollars";
            txtDollars.Size = new Size(144, 35);
            txtDollars.TabIndex = 3;
            // 
            // lblYears
            // 
            lblYears.AutoSize = true;
            lblYears.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblYears.Location = new Point(48, 128);
            lblYears.Name = "lblYears";
            lblYears.Size = new Size(168, 30);
            lblYears.TabIndex = 2;
            lblYears.Text = "Number of Years";
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRate.Location = new Point(64, 88);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(156, 30);
            lblRate.TabIndex = 1;
            lblRate.Text = "Rate of Interest";
            lblRate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAmount.Location = new Point(16, 48);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(206, 30);
            lblAmount.TabIndex = 0;
            lblAmount.Text = "Initial Dollar Amount";
            lblAmount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 480);
            Controls.Add(calculatorTabs);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Finance Calculator";
            calculatorTabs.ResumeLayout(false);
            tabCalculator.ResumeLayout(false);
            tabCalculator.PerformLayout();
            tabInterest.ResumeLayout(false);
            tabInterest.PerformLayout();
            grpFrequency.ResumeLayout(false);
            grpFrequency.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl calculatorTabs;
        private TabPage tabCalculator;
        private TabPage tabInterest;
        private Button btnDivide;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private TextBox outputBox;
        private Button btnPlus;
        private Button btnEquals;
        private Button btnPeriod;
        private Button btn0;
        private Button btnMinus;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnMultiply;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnClear;
        private Label lblYears;
        private Label lblRate;
        private Label lblAmount;
        private GroupBox grpFrequency;
        private TextBox cmpdOutput;
        private TextBox txtYears;
        private TextBox txtInterest;
        private TextBox txtDollars;
        private RadioButton rdoMonthly;
        private Button btnCalculate;
        private RadioButton rdoAnnually;
        private RadioButton rdoSemi;
        private RadioButton rdoQtr;
    }
}
