// P01_classTriangle.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
/*
C++ 10, Ex 01

Write a C++ program that defines a Triangle class to represent a triangle in 2D space.
Prompt the user for the coordinates of the triangle’s vertices.
Instantiate a Triangle object using the input coordinates.
Display the perimeter and area of the triangle.

Distance between two points (x1,y1)(x1?,y1?) and (x2,y2)(x2?,y2?):
d=sqrt((x2?x1)^2+(y2?y1)^2)

Perimeter of the triangle with sides aa, bb, and cc:
P=a+b+c

Area of the triangle using Heron’s formula:
s=(a+b+c?)/2
Area=sqrt(s?(s?a)?(s?b)?(s?c))

J. M. Hinckley
2024
*/

#include <iostream>

#include <cmath>

using namespace std;

class Triangle {
private:
    double x1, y1, x2, y2, x3, y3;

    // Helper function to calculate distance between two points
    double calculateDistance(double x1, double y1, double x2, double y2) const {
        return sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
    }

public:
    // Constructor to initialize the coordinates of the triangle's vertices
    Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        : x1(x1), y1(y1), x2(x2), y2(y2), x3(x3), y3(y3) {}

    // Method to calculate the length of side AB
    double sideLength1() const {
        return calculateDistance(x1, y1, x2, y2);
    }

    // Method to calculate the length of side BC
    double sideLength2() const {
        return calculateDistance(x2, y2, x3, y3);
    }

    // Method to calculate the length of side CA
    double sideLength3() const {
        return calculateDistance(x3, y3, x1, y1);
    }

    // Method to calculate the perimeter of the triangle
    double perimeter() const {
        return sideLength1() + sideLength2() + sideLength3();
    }

    // Method to calculate the area of the triangle using Heron's formula
    double area() const {
        double a = sideLength1();
        double b = sideLength2();
        double c = sideLength3();
        double s = perimeter() / 2;
        return sqrt(s * (s - a) * (s - b) * (s - c));
    }
};

int main()
{
    // Input coordinates for the vertices
    double x1, y1, x2, y2, x3, y3;
    cout << "Enter the coordinates of vertex A (x1, y1): ";
    cin >> x1 >> y1;
    cout << "Enter the coordinates of vertex B (x2, y2): ";
    cin >> x2 >> y2;
    cout << "Enter the coordinates of vertex C (x3, y3): ";
    cin >> x3 >> y3;

    // Create a Triangle object
    Triangle triangle(x1, y1, x2, y2, x3, y3);

    // Calculate and display the perimeter and area
    cout << "Perimeter of the triangle: " << triangle.perimeter() << endl;
    cout << "Area of the triangle: " << triangle.area() << endl;

    return 0;
}
