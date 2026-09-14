// Ex04.02_rightTriangle.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
/*
C++ 04, Ex 02

In a right triangle, the square of the length of one side is equal to the sum 
of the squares of the lengths of the other two sides.  

Write a C++ program that prompts the user to enter the lengths of three sides 
of a triangle then outputs a message indicating whether the 
triangle is a right triangle or not.

J. M. Hinckley
2024
*/

// Since equality of decimal number is machine dependent, convert
// each side to an integer by multiplying each side by 100 and 
// then truncate. 

#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
	double side1, side2, side3;

	int intSide1, intSide2, intSide3;

	cout << "Enter the lengths of the sides a triangle: ";
	cin >> side1 >> side2 >> side3;
	cout << endl;

	intSide1 = static_cast<int>(side1 * 100);
	intSide2 = static_cast<int>(side2 * 100);
	intSide3 = static_cast<int>(side3 * 100);

	if ((intSide1 * intSide1 == (intSide2 * intSide2 + intSide3 * intSide3)) ||
		(intSide2 * intSide2 == (intSide1 * intSide1 + intSide3 * intSide3)) ||
		(intSide3 * intSide3 == (intSide1 * intSide1 + intSide2 * intSide2)))

		cout << "It is a right angled triangle" << endl;
	else
		cout << "It is not a right angled triangle" << endl;

	return 0;
}