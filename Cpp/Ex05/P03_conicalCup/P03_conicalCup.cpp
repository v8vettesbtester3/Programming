// P03_conicalCup.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
/*
C++ 05, Ex 03

Consider making a conical waxed paper cup by cutting a sector of length X out of a 
circular piece of waxed paper.  
By closing the remaining part of the circle, a conical cup is made.  
The objective is to determine the size of X, so that the cup has maximum volume.

Write a C++ program that prompts the user to input the radius of the circular paper.  
The program then outputs the length of X and volume of the cup. 
The answer is to be precise to two decimal places.

J. M. Hinckley
2024
*/

#include <iostream>
#include <iomanip>
#include <cmath>
using namespace std;

const double PI = 3.141592654;

int main()
{
    double removedSectorLength;
    double waxedPaperRad;
    double paperCupBaseRad; //r
    double paperCupHeight; //h
    double paperCupVol;
    double waxedPaperCircum;
    double maxVolume;
    double cupRadiusAtMaxV = 0;
    double cupHeightAtMaxV = 0;

    double x;

    cout << fixed << showpoint << setprecision(6);

    cout << "Enter the radius of the circular waxed paper in inches: ";
    cin >> waxedPaperRad;
    cout << endl;

    x = 0.00;
    maxVolume = 0.0;
    removedSectorLength = 0.0;
    waxedPaperCircum = 2 * PI * waxedPaperRad;

    cout << fixed << showpoint << setprecision(2);

    while (x <= waxedPaperCircum)
    {
        paperCupBaseRad = waxedPaperRad - (x / (2 * PI));
        paperCupHeight = sqrt(waxedPaperRad * waxedPaperRad - paperCupBaseRad * paperCupBaseRad);

        paperCupVol = (1.0 / 3.0) * PI * (paperCupBaseRad * paperCupBaseRad) * paperCupHeight;

        if (paperCupVol > maxVolume)
        {
            maxVolume = paperCupVol;
            cupRadiusAtMaxV = paperCupBaseRad;
            cupHeightAtMaxV = paperCupHeight;
            removedSectorLength = x;
        }

        x = x + 0.01;
    }

    // Code modification 2509260958: fixed bug: arguments of atan2 were backwards
    double halfAngleRadians = atan2(cupRadiusAtMaxV, cupHeightAtMaxV);
    double angleDegrees = 2.0 * halfAngleRadians * 180.0 / PI;

    cout << "Length of the removed sector: " << removedSectorLength << " inch" << endl;
    cout << "Max Volume " << maxVolume << " cubic inches" << endl;
    cout << "Angle at apex: " << angleDegrees << " degrees." << endl;

    return 0;
}
