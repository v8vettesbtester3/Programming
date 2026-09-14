// P03.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
/*
* C++ 02, Exercise 03
*
* An object’s linear momentum is the product of its mass and its velocity.
* The object’s kinetic energy is one half of its mass multiplied by the
* square of its velocity:
* E = 0.5 * m * v**2.
* 
* Write a C++ program that inputs from the user, the mass (in units of kg)
* and velocity (in units of m / s) and then calculates the momentum
* (in units of kg m / s) and its kinetic energy (in units of Joules = kg m^2 / s^2).
* Label the output:
* Momentum (kg m / s) = …
* Kinetic energy (kg m^2 / s^2) = …
*
* J. M. Hinckley
* 2024
*/

#include <iostream>

using namespace std;

int main()
{
    cout << "Enter the mass (kg): ";
    double m;
    cin >> m;
    cout << "Enter the speed (m/s): ";
    double v;
    cin >> v;

    // Calculate the momentum
    double p = m * v;

    // Calculate the kinetic energy
    double e = 0.5 * m * pow(v, 2);

    cout << "Momentum (kg m / s) = " << p << endl;
    cout << "Kinetic energy (kg m^2 / s^2) = " << e << endl;
}
