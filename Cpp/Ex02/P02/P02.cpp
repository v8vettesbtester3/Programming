// P02.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
/*
* C++ 02, Exercise 02
*
* Write a C++ program that inputs from the user the length of an 
* edge of a cube and prints the cube’s surface area.
*
* J. M. Hinckley
* 2024
*/

#include <iostream>

using namespace std;

int main()
{
    cout << "Enter the length of the edge of a cube: ";
    double x;
    cin >> x;

    double area = 6 * x * x;

    cout << "Surface area: " << area << endl;
}
