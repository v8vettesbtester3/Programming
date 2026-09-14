// ExFixedScientific.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
/*
C++ 03, Ex 05

Use the fixed, scientific, showpoint and setprecision() output manipulators with console output.
The speed of light is exactly 299,792,458 m / s in vacuum.  
Using this value  and the above four output manipulators, write a 
C++ program that outputs this number to the console in three formats, exactly:
299792458
299792458.  (shows a trailing decimal point)
2.99792458e+08

J. M. Hinckley
2024
*/

#include <iostream>
#include <iomanip>
using namespace std;
int main()
{
    double s;
    s = 2.99792458e8;
    s = 299'792'458;
    cout << fixed << setprecision(0) << s << endl;
    cout << fixed << setprecision(0) << showpoint << s << endl;
    cout << scientific << setprecision(8) << s << endl;
}
