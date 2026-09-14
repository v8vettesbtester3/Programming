/*
C# 09, Ex 02 

Extend the previous program by adding several overloaded constructors to the Student class.

* Parameterized constructor which has parameters for ID, Name, GPA and Course Name.
* Parameterized constructor which has parameters for ID, Name and GPA. but not for the Course Name.  
  This one uses a constructor initializer, passing “Not Enrolled” for the Course Name.
* Parameterized constructor which has parameters for ID and Name, but not for the GPA and Course Name.  
  This one uses a constructor initializer, passing 0 for the GPA and “Not Enrolled” for the Course Name.
* Default constructor, which takes no parameters.  

This one uses a constructor initializer passing 0 for the ID, 
“Unknown” for the Name, 0 for the GPA and “Not Enrolled” for the Course Name.

When the Add Student button is pressed, read the text boxes, using TryParse so that and empty box can be handled. 
Set up if-else statements so that the correct constructor is called, 
depending which information is present in the text boxes when the Add Student button is pressed.

J. M. Hinckley
2024
 */
namespace P01_autoimplementProps
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double GPA { get; set; }
        public string CourseName { get; set; }

        // Default Constructor
        public Student() : this(0, "Unknown", 0.0, "Not Enrolled")
        {
        }

        // Constructor with ID and Name
        public Student(int id, string name) : this(id, name, 0.0, "Not Enrolled")
        {
        }

        // Constructor with ID, Name, and GPA
        public Student(int id, string name, double gpa) : this(id, name, gpa, "Not Enrolled")
        {
        }

        // Constructor with ID, Name, GPA, and Course Name
        public Student(int id, string name, double gpa, string courseName)
        {
            ID = id;
            Name = name;
            GPA = gpa;
            CourseName = courseName;
        }

    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Student student;

            bool success = int.TryParse(txtID.Text, out int id);
            string name = txtName.Text;
            bool success2 = double.TryParse(txtGPA.Text, out double gpa);
            string courseName = txtCourse.Text;

            // Create a new Student object using the input values
            if (success && name.Length > 0)
            {
                // ID is ok; Name is OK
                if (success2)
                {
                    // GPA is OK
                    if (courseName.Length > 0)
                    {
                        // Course name is OK
                        student = new Student(id, name, gpa, courseName);
                    }
                    else
                    {
                        // Course name is not OK
                        student = new Student(id, name, gpa);
                    }
                }
                else
                {
                    // GPA is not OK
                    student = new Student(id, name);
                }
            }
            else
            {
                // ID and Name are not OK
                student = new Student();
            }


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
}
