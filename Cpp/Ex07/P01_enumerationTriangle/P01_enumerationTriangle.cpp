/*
C++ 07, Ex 01

Write a C++ program which uses enumerations in the following way.

* Define an enumeration type triangleType that has the values scalene, 
isosceles, equilateral and noTriangle.

* Write a function triangleShape() that thales as parameters three numbers, 
each of which represents the length of a side of the triangle.  
The function should return the shape of the triangle.  
Note that in a triangle, the sum of the lengths of any two sides is 
greater than the length of the third side.

* The program prompts the user to input the length of the sides of 
a triangle and outputs the shape of the triangle.

Adapted from Malik.

J. M. Hinckley
2024
*/
#include <iostream> 

using namespace std;

enum triangleType { scalene, isosceles, equilateral, noTriangle };

triangleType triangleShape(double side1, double side2, double side3);
void printShape(triangleType triangle);

int main()
{
    double lenSide1, lenSide2, lenSide3;

    do {

        cout << "Enter the lengths of the three sides of a triangle (zero to quit)."
            << endl;
        cin >> lenSide1 >> lenSide2 >> lenSide3;
        cout << endl;

        if (lenSide1 > 0 && lenSide2 > 0 && lenSide3 > 0) {

            cout << "The shape of the triangle is: ";
            printShape(triangleShape(lenSide1, lenSide2, lenSide3));
            cout << endl;
        }
    } while (lenSide1 > 0 && lenSide2 > 0 && lenSide3 > 0);

    return 0;
}

triangleType triangleShape(double side1, double side2, double side3)
{
    if (side1 == side2 && side2 == side3)
        return equilateral;
    else if ((side1 + side2 > side3) &&
        (side1 + side3 > side2) &&
        (side2 + side3 > side1))
        if (side1 == side2 || side2 == side3 || side1 == side3)
            return isosceles;
        else
            return scalene;
    else
        return noTriangle;
}

void printShape(triangleType triangle)
{
    switch (triangle)
    {
    case scalene:
        cout << "scalene" << endl;
        break;
    case isosceles:
        cout << "isosceles" << endl;
        break;
    case equilateral:
        cout << "equilateral" << endl;
        break;
    case noTriangle:
        cout << "noTriangle" << endl;
    }
}