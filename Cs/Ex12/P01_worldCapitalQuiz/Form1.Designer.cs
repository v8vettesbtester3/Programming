namespace P01_worldCapitalQuiz
{
    partial class QuizShowForm
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
            txtQuestion = new TextBox();
            rdoAnswer1 = new RadioButton();
            rdoAnswer2 = new RadioButton();
            rdoAnswer3 = new RadioButton();
            rdoAnswer4 = new RadioButton();
            btnSubmit = new Button();
            btnNext = new Button();
            SuspendLayout();
            // 
            // txtQuestion
            // 
            txtQuestion.Font = new Font("Segoe UI", 29.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuestion.Location = new Point(0, 0);
            txtQuestion.Margin = new Padding(5);
            txtQuestion.Multiline = true;
            txtQuestion.Name = "txtQuestion";
            txtQuestion.ReadOnly = true;
            txtQuestion.Size = new Size(925, 159);
            txtQuestion.TabIndex = 0;
            // 
            // rdoAnswer1
            // 
            rdoAnswer1.AutoSize = true;
            rdoAnswer1.Font = new Font("Segoe UI", 14.25F);
            rdoAnswer1.Location = new Point(32, 171);
            rdoAnswer1.Margin = new Padding(5);
            rdoAnswer1.Name = "rdoAnswer1";
            rdoAnswer1.Size = new Size(140, 29);
            rdoAnswer1.TabIndex = 1;
            rdoAnswer1.TabStop = true;
            rdoAnswer1.Text = "radioButton1";
            rdoAnswer1.UseVisualStyleBackColor = true;
            // 
            // rdoAnswer2
            // 
            rdoAnswer2.AutoSize = true;
            rdoAnswer2.Font = new Font("Segoe UI", 14.25F);
            rdoAnswer2.Location = new Point(32, 202);
            rdoAnswer2.Margin = new Padding(5);
            rdoAnswer2.Name = "rdoAnswer2";
            rdoAnswer2.Size = new Size(140, 29);
            rdoAnswer2.TabIndex = 2;
            rdoAnswer2.TabStop = true;
            rdoAnswer2.Text = "radioButton2";
            rdoAnswer2.UseVisualStyleBackColor = true;
            // 
            // rdoAnswer3
            // 
            rdoAnswer3.AutoSize = true;
            rdoAnswer3.Font = new Font("Segoe UI", 14.25F);
            rdoAnswer3.Location = new Point(32, 233);
            rdoAnswer3.Margin = new Padding(5);
            rdoAnswer3.Name = "rdoAnswer3";
            rdoAnswer3.Size = new Size(140, 29);
            rdoAnswer3.TabIndex = 3;
            rdoAnswer3.TabStop = true;
            rdoAnswer3.Text = "radioButton3";
            rdoAnswer3.UseVisualStyleBackColor = true;
            // 
            // rdoAnswer4
            // 
            rdoAnswer4.AutoSize = true;
            rdoAnswer4.Font = new Font("Segoe UI", 14.25F);
            rdoAnswer4.Location = new Point(32, 264);
            rdoAnswer4.Margin = new Padding(5);
            rdoAnswer4.Name = "rdoAnswer4";
            rdoAnswer4.Size = new Size(140, 29);
            rdoAnswer4.TabIndex = 4;
            rdoAnswer4.TabStop = true;
            rdoAnswer4.Text = "radioButton4";
            rdoAnswer4.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(376, 336);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(166, 40);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click_1;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(816, 336);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(113, 40);
            btnNext.TabIndex = 6;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // QuizShowForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 377);
            Controls.Add(btnNext);
            Controls.Add(btnSubmit);
            Controls.Add(rdoAnswer4);
            Controls.Add(rdoAnswer3);
            Controls.Add(rdoAnswer2);
            Controls.Add(rdoAnswer1);
            Controls.Add(txtQuestion);
            Font = new Font("Segoe UI", 14.25F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "QuizShowForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "World Capital Quiz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtQuestion;
        private RadioButton rdoAnswer1;
        private RadioButton rdoAnswer2;
        private RadioButton rdoAnswer3;
        private RadioButton rdoAnswer4;
        private Button btnSubmit;
        private Button btnNext;
    }
}
