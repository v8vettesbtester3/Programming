/*
 C# 09, Ex 01

Build a C# Windows Forms Application that allows users to input and display 
student information using auto-implemented properties.  
This Student Grade Tracker GUI application. 

It should allow the user to:
* Input student details: ID, Name, GPA, and Course Name.
* Display the student's information in a ListBox after submission.
* Store the student data in an object of a class that uses auto-implemented properties.

Create a Student class that uses auto-implemented properties to manage the students’ data:
ID, Name, GPA, and Course Name.

J. M. Hinckley
2024
 */
namespace P01_autoimplementProps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            // Create a new Student object using the input values
            Student student = new Student
            {
                ID = int.Parse(txtID.Text),
                Name = txtName.Text,
                GPA = double.Parse(txtGPA.Text),
                CourseName = txtCourse.Text
            };

            // Add the student's information to the ListBox
            listBoxStudents.Items.Add($"{student.ID} - {student.Name} - {student.GPA} - {student.CourseName}");

            // Clear the input fields
            ClearFields();
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // Helper method to clear the TextBoxes
        private void ClearFields()
        {
            txtID.Clear();
            txtName.Clear();
            txtGPA.Clear();
            txtCourse.Clear();
        }

    }
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double GPA { get; set; }
        public string CourseName { get; set; }
    }
}
