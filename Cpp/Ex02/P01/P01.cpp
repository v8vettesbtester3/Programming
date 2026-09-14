// P01.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
/*
* C++ 02, Exercise 01
* 
* Write a C++ program that asks you to enter a floating point (double) number.  
* The program calculates its square root and outputs the result using  
* the fixed and setprecision output manipulators (must include iomanip) 
* to display two digits after the decimal point.
* 
* J. M. Hinckley
* 2024
*/

#include <iostream>
#include <iomanip>
#include <math.h>

using namespace std;

int main()
{
    cout << "Enter a number: ";

    double x;
    cin >> x;

    double y = sqrt(x);

    cout << "Square root is: ";
    cout << fixed << setprecision(2) << y << endl;
}
