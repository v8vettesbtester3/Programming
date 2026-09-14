// P04.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
/*
* C++ 02, Exercise 04
*
* Write a C++ program that calculates the number of minutes in the following:
* in an hour,
* in a day
* in a week
* in a year (365.25 days).
* Then input the user’s age (in whole years) and calculate and display their age in minutes.
*
* J. M. Hinckley
* 2024
*/

#include <iostream>

using namespace std;

int main()
{
    int minPerHr = 60;
    int minPerDay = minPerHr * 24;
    int minPerWk = minPerDay * 7;
    int minPerYr = minPerDay * 365.25;

    cout << "Enter your age in years: ";
    int ageInYears;
    cin >> ageInYears;
    double ageInMins = ageInYears * minPerYr;

    cout << "Minutes per hour: " << minPerHr << endl;
    cout << "Minutes per day: " << minPerDay << endl;
    cout << "Minutes per week: " << minPerWk << endl;
    cout << "Minutes per year: " << minPerYr << endl;
    cout << "At your " << ageInYears << " birthday, you were " 
        << ageInMins << " minutes old." << endl;

}
