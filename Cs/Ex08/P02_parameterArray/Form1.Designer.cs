namespace P02_parameterArray
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
            textBoxInputs = new TextBox();
            labelPoints = new Label();
            buttonOpenPath = new Button();
            buttonClosedPath = new Button();
            textBoxOpenPL = new TextBox();
            label1 = new Label();
            textBoxClosedPL = new TextBox();
            SuspendLayout();
            // 
            // textBoxInputs
            // 
            textBoxInputs.Location = new Point(54, 27);
            textBoxInputs.Multiline = true;
            textBoxInputs.Name = "textBoxInputs";
            textBoxInputs.Size = new Size(189, 219);
            textBoxInputs.TabIndex = 0;
            // 
            // labelPoints
            // 
            labelPoints.AutoSize = true;
            labelPoints.Location = new Point(128, 9);
            labelPoints.Name = "labelPoints";
            labelPoints.Size = new Size(40, 15);
            labelPoints.TabIndex = 1;
            labelPoints.Text = "Points";
            // 
            // buttonOpenPath
            // 
            buttonOpenPath.Location = new Point(319, 59);
            buttonOpenPath.Name = "buttonOpenPath";
            buttonOpenPath.Size = new Size(96, 23);
            buttonOpenPath.TabIndex = 2;
            buttonOpenPath.Text = "Open Path";
            buttonOpenPath.UseVisualStyleBackColor = true;
            buttonOpenPath.Click += buttonOpenPath_Click;
            // 
            // buttonClosedPath
            // 
            buttonClosedPath.Location = new Point(319, 194);
            buttonClosedPath.Name = "buttonClosedPath";
            buttonClosedPath.Size = new Size(96, 23);
            buttonClosedPath.TabIndex = 3;
            buttonClosedPath.Text = "Closed Path";
            buttonClosedPath.UseVisualStyleBackColor = true;
            buttonClosedPath.Click += buttonClosedPath_Click;
            // 
            // textBoxOpenPL
            // 
            textBoxOpenPL.Location = new Point(464, 59);
            textBoxOpenPL.Name = "textBoxOpenPL";
            textBoxOpenPL.ReadOnly = true;
            textBoxOpenPL.Size = new Size(100, 23);
            textBoxOpenPL.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(481, 30);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 5;
            label1.Text = "Path Length";
            // 
            // textBoxClosedPL
            // 
            textBoxClosedPL.Location = new Point(464, 194);
            textBoxClosedPL.Name = "textBoxClosedPL";
            textBoxClosedPL.ReadOnly = true;
            textBoxClosedPL.Size = new Size(100, 23);
            textBoxClosedPL.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 287);
            Controls.Add(textBoxClosedPL);
            Controls.Add(label1);
            Controls.Add(textBoxOpenPL);
            Controls.Add(buttonClosedPath);
            Controls.Add(buttonOpenPath);
            Controls.Add(labelPoints);
            Controls.Add(textBoxInputs);
            Name = "Form1";
            Text = "Parameter Array";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInputs;
        private Label labelPoints;
        private Button buttonOpenPath;
        private Button buttonClosedPath;
        private TextBox textBoxOpenPL;
        private Label label1;
        private TextBox textBoxClosedPL;
    }
}
