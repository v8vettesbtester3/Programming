namespace P01_autoimplementProps
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
            btnAddStudent = new Button();
            btnClearFields = new Button();
            label4 = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            txtGPA = new TextBox();
            txtCourse = new TextBox();
            listBoxStudents = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 46);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 77);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 111);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 2;
            label3.Text = "GPA:";
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(63, 220);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(93, 23);
            btnAddStudent.TabIndex = 3;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnClearFields
            // 
            btnClearFields.Location = new Point(236, 220);
            btnClearFields.Name = "btnClearFields";
            btnClearFields.Size = new Size(93, 23);
            btnClearFields.TabIndex = 4;
            btnClearFields.Text = "Clear Fields";
            btnClearFields.UseVisualStyleBackColor = true;
            btnClearFields.Click += btnClearFields_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 146);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 5;
            label4.Text = "Course:";
            // 
            // txtID
            // 
            txtID.Location = new Point(104, 38);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(104, 77);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 7;
            // 
            // txtGPA
            // 
            txtGPA.Location = new Point(104, 111);
            txtGPA.Name = "txtGPA";
            txtGPA.Size = new Size(100, 23);
            txtGPA.TabIndex = 8;
            // 
            // txtCourse
            // 
            txtCourse.Location = new Point(104, 146);
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(100, 23);
            txtCourse.TabIndex = 9;
            // 
            // listBoxStudents
            // 
            listBoxStudents.FormattingEnabled = true;
            listBoxStudents.ItemHeight = 15;
            listBoxStudents.Location = new Point(29, 269);
            listBoxStudents.Name = "listBoxStudents";
            listBoxStudents.Size = new Size(362, 169);
            listBoxStudents.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 450);
            Controls.Add(listBoxStudents);
            Controls.Add(txtCourse);
            Controls.Add(txtGPA);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(label4);
            Controls.Add(btnClearFields);
            Controls.Add(btnAddStudent);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Student Grade Tracker Overload";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAddStudent;
        private Button btnClearFields;
        private Label label4;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtGPA;
        private TextBox txtCourse;
        private ListBox listBoxStudents;
    }
}
