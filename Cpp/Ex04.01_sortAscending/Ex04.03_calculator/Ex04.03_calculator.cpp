// Ex04.03_calculator.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
/*
C++ 04, Ex 03

Write a program that mimics a calculator.  
The program should take as input two integers and the operation to be performed.  
It should then output the numbers, the operator and the result.  
For division if the denominator is zero, output an appropriate message.  
Use a switch statement, switching on the operator character to determine the operation to carry out.

J. M. Hinckley
2024
*/

#include <iostream>

using namespace std;

int main()
{
    int num1, num2;
    char opr;

    cout << "Enter two integers: ";
    cin >> num1 >> num2;
    cout << endl;

    cout << "Enter operator: + (addition), - (subtraction),"
        << " * (multiplication), / (division): ";
    cin >> opr;
    cout << endl;

    cout << num1 << " " << opr << " " << num2 << " = ";

    switch (opr)
    {
    case '+':
        cout << num1 + num2 << endl;
        break;
    case '-':
        cout << num1 - num2 << endl;
        break;
    case '*':
        cout << num1 * num2 << endl;
        break;
    case '/':
        if (num2 != 0)
            cout << num1 / num2 << endl;
        else
            cout << "ERROR \nCannot divide by zero" << endl;
        break;
    default:
        cout << "Illegal operation" << endl;
    }

    return 0;
}