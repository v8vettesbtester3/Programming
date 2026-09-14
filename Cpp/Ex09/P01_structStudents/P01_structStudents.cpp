/*
C++ 09, Ex 01

Write a C++ program to implement a simple student management system that keeps track of students' details. 
You will need to define a structure (struct) to represent a student's information and then write code
to manipulate and display the information for multiple students.

J. M. Hinckley
2024
*/
#include <iostream>
#include <string>
using namespace std;

// Structure to represent a date (day, month, year)
struct Date {
    int day;
    int month;
    int year;
};

// Structure to represent a student
struct Student {
    int id;
    string name;
    float gpa;
    int yearOfStudy;
    Date dob; // Date of birth as a structure
};

int main() {
    const int MAX_STUDENTS = 5;
    Student students[MAX_STUDENTS];  // Array to store 5 students

    // Input details for each student
    for (int i = 0; i < MAX_STUDENTS; ++i) {
        cout << "Enter details for student " << i + 1 << ":\n";
        cout << "ID: ";
        cin >> students[i].id;
        cin.ignore();  // Ignore leftover newline

        cout << "Name: ";
        getline(cin, students[i].name);

        cout << "GPA: ";
        cin >> students[i].gpa;

        cout << "Year of Study: ";
        cin >> students[i].yearOfStudy;

        cout << "Date of Birth (day month year): ";
        cin >> students[i].dob.day >> students[i].dob.month >> students[i].dob.year;
    }

    // Print a summary of all students
    cout << "\nSummary of Student Information:\n";
    for (int i = 0; i < MAX_STUDENTS; ++i) {
        cout << "Student " << i + 1 << ":\n";
        cout << "ID: " << students[i].id << "\n";
        cout << "Name: " << students[i].name << "\n";
        cout << "GPA: " << students[i].gpa << "\n";
        cout << "Year of Study: " << students[i].yearOfStudy << "\n";
        cout << "Date of Birth: " << students[i].dob.day << "/"
            << students[i].dob.month << "/" << students[i].dob.year << "\n";
        cout << "--------------------------\n";
     }

    // Calculate and print the average GPA.
    double avgGPA = 0.0;
    for (int i = 0; i < MAX_STUDENTS; ++i) {
        avgGPA += students[i].gpa;
    }
    avgGPA /= MAX_STUDENTS;
    cout << "Average GPA: " << avgGPA << endl;

    return 0;
}
