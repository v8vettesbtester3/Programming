namespace GuessAWordGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.submitButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.guessBox = new System.Windows.Forms.TextBox();
            this.outLabel = new System.Windows.Forms.Label();
            this.outLabel2 = new System.Windows.Forms.Label();
            this.outLabel3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(100, 101);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit guess";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Visible = false;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(91, 21);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(84, 23);
            this.selectButton.TabIndex = 1;
            this.selectButton.Text = "Start";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // guessBox
            // 
            this.guessBox.Location = new System.Drawing.Point(174, 75);
            this.guessBox.Name = "guessBox";
            this.guessBox.Size = new System.Drawing.Size(38, 20);
            this.guessBox.TabIndex = 2;
            this.guessBox.Visible = false;
            // 
            // outLabel
            // 
            this.outLabel.AutoSize = true;
            this.outLabel.Location = new System.Drawing.Point(51, 64);
            this.outLabel.Name = "outLabel";
            this.outLabel.Size = new System.Drawing.Size(0, 13);
            this.outLabel.TabIndex = 3;
            // 
            // outLabel2
            // 
            this.outLabel2.AutoSize = true;
            this.outLabel2.Location = new System.Drawing.Point(58, 144);
            this.outLabel2.Name = "outLabel2";
            this.outLabel2.Size = new System.Drawing.Size(0, 13);
            this.outLabel2.TabIndex = 4;
            // 
            // outLabel3
            // 
            this.outLabel3.AutoSize = true;
            this.outLabel3.Location = new System.Drawing.Point(58, 184);
            this.outLabel3.Name = "outLabel3";
            this.outLabel3.Size = new System.Drawing.Size(0, 13);
            this.outLabel3.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 215);
            this.Controls.Add(this.outLabel3);
            this.Controls.Add(this.outLabel2);
            this.Controls.Add(this.outLabel);
            this.Controls.Add(this.guessBox);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.submitButton);
            this.Name = "Form1";
            this.Text = "Guess a word";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.TextBox guessBox;
        private System.Windows.Forms.Label outLabel;
        private System.Windows.Forms.Label outLabel2;
        private System.Windows.Forms.Label outLabel3;
    }
}

