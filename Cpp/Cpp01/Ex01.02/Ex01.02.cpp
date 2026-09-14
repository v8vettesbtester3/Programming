/*
* C++ Ex01.02
*
* Write a C++ program that inputs from the user the height and width (both floating point numbers) 
* of a rectangle then calculates and displays its area.  
* The output should be labeled with the text “Area = “, followed by the numerical value.
*
* J. M. Hinckley
* 2024
*/

#include <iostream>
using namespace std;

int main()
{
    cout << "Enter height: ";
    double height;
    cin >> height;

    cout << "Enter width: ";
    double width;
    cin >> width;

    double area = height * width;
    cout << "Area = " << area << endl;
}
