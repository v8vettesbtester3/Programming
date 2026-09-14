// P05.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
/*
* C++ 02, Exercise 05
*
* Light travels at a speed of 3 * 10**8 m / s in a vacuum.
* A light-year is the distance that light travels in one year.
* Write a C++ program that calculates and displays the distance 
* of a light-year in units of meters.
*
* J. M. Hinckley
* 2024
*/

#include <iostream>

using namespace std;

int main()
{
    double speed = 3e8;

    int minPerHr = 60;
    int minPerDay = minPerHr * 24;
    int minPerYr = minPerDay * 365.25;
    int secPerYr = minPerYr * 60;

    double distance = speed * secPerYr;

    cout << "One light year is " << distance << " meters." << endl;
}
