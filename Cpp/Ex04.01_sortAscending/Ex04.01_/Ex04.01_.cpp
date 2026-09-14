// Ex04.01_.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
/*
* C++ 04, Ex 01
* 
* Write a C++ program that prompts the user to input three numbers. 
* The program should then output the numbers in ascending order.
*
* J. M. Hinckley
* 2024
*/

#include <iostream>

using namespace std;

int main()
{
    double num1, num2, num3;
    double temp;

    cout << "Enter three numbers: ";
    cin >> num1 >> num2 >> num3;
    cout << endl;

    if (num1 > num2)
    {
        temp = num1;
        num1 = num2;
        num2 = temp;
    }

    //Now num1 is less than or equal to num2

    cout << "The numbers in the ascending order are: ";

    if (num3 <= num1)
        cout << num3 << " " << num1 << " " << num2 << endl;
    else if (num1 <= num3 && num3 <= num2)
        cout << num1 << " " << num3 << " " << num2 << endl;
    else
        cout << num1 << " " << num2 << " " << num3 << endl;

    return 0;
}
