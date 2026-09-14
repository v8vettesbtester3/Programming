/*
C++ 09, Ex 02

This will be a program that uses functions with structures as arguments and as return types.  
It will be a system that manages employee records, with each employee’s details organized 
in a structure. 
The goals are (1) to pass a structure as an argument to a function and (2) use a function 
that returns a structure as a result.

J. M. Hinckley
2024
*/
#include <iostream>
#include <string>
using namespace std;

// Structure to represent an Employee
struct Employee {
    int id;
    string name;
    float salary;
    string department;
};

// Function to update the salary of an employee (passed by reference)
void updateSalary(Employee& emp, float percentage) {
    emp.salary += emp.salary * (percentage / 100.0);
}

// Function to create a new Employee (returns a structure)
Employee createEmployee() {
    Employee newEmp;

    cout << "Enter Employee ID: ";
    cin >> newEmp.id;
    cin.ignore();  // Ignore leftover newline

    cout << "Enter Employee Name: ";
    getline(cin, newEmp.name);

    cout << "Enter Employee Salary: ";
    cin >> newEmp.salary;
    cin.ignore();

    cout << "Enter Employee Department: ";
    getline(cin, newEmp.department);

    return newEmp;
}

int main() {
    // Create a new employee using the function
    Employee emp = createEmployee();

    // Display initial employee information
    cout << "\nInitial Employee Information:\n";
    cout << "ID: " << emp.id << "\n";
    cout << "Name: " << emp.name << "\n";
    cout << "Salary: $" << emp.salary << "\n";
    cout << "Department: " << emp.department << "\n";

    // Update the employee's salary
    float increasePercentage;
    cout << "\nEnter percentage to increase salary: ";
    cin >> increasePercentage;

    updateSalary(emp, increasePercentage);

    // Display updated employee information
    cout << "\nUpdated Employee Information:\n";
    cout << "ID: " << emp.id << "\n";
    cout << "Name: " << emp.name << "\n";
    cout << "Salary: $" << emp.salary << "\n";
    cout << "Department: " << emp.department << "\n";

    return 0;
}
