// P02.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
/*
C++ 05, Ex 02

The population of town A is less than the population of town B.  
However, the population of town A is growing faster than the population of town B.  
Write a C++ program that prompts the user to enter the population and growth rate (in percent) of each town.  
The program should output how many years are required for the population of town A to be greater than 
that of town B, and what the populations of the two towns are at that time.

J. M. Hinckley
2024
*/

#include <iostream>

using namespace std;

int main()
{
    int townAPop;
    int townBPop;
    double growthRateTownA;
    double growthRateTownB;
    int numOfYears = 0;

    cout << "Enter the current population of town A: ";
    cin >> townAPop;
    cout << endl;

    cout << "Enter the current population of town B: ";
    cin >> townBPop;
    cout << endl;

    cout << "Enter the growth rate of town A: ";
    cin >> growthRateTownA;
    cout << endl;

    cout << "Enter the growth rate of town B: ";
    cin >> growthRateTownB;
    cout << endl;

    while (townAPop < townBPop)
    {
        townAPop = static_cast<int>(townAPop * (1 + growthRateTownA / 100.0));
        townBPop = static_cast<int>(townBPop * (1 + growthRateTownB / 100.0));
        numOfYears++;
    }

    cout << "After " << numOfYears << " year(s) the population of town A "
        << "will be greater than or equal to the population of town B." << endl;
    cout << "After " << numOfYears << " year(s) the population of town A is "
        << townAPop << endl;
    cout << "After " << numOfYears << " year(s) the population of town B is "
        << townBPop << endl;


    return 0;
}
