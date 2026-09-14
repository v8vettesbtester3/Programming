// P01_checkPrime.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
/*
C++ 05, Ex 01

Write a C++ program that prompts the user to input a positive integer.  
Make the program robust to not crash if something other than an integer is input.  
Keep asking for input until a positive integer is input. 
Then determine whether the integer is a prime number.  
Output a message saying whether or not it is prime.

J. M. Hinckley
2024
*/

#include <iostream>
#include <cmath>

using namespace std;

int main()
{
    int number = 0;
    double dnum;
    bool isPrime = true;

    int sqrtNum;
    int divisor = 3;

    while (true) {
        cout << "Enter a positive integer greater than 1: ";
        while (!(cin >> dnum)) {
            cin.clear();
            cin.ignore(1000, '\n');
            cout << "Enter a positive integer greater than 1: ";
        }

        if (dnum > 1 && (dnum == static_cast<int>(dnum))) {
            number = static_cast<int>(dnum);
            break;
        }
    }

    cout << endl;

    cout << "The number you entered is: " << number << endl;

    if  (number == 2)
        cout << "It is a prime number" << endl;
    else if (number % 2 == 0)
        cout << "It is not a prime number" << endl;
    else
    {
        sqrtNum = static_cast<int> (sqrt(static_cast<double>(number)));

        while (divisor <= sqrtNum)
        {
            if (number % divisor == 0)
            {
                cout << "It is not a prime number." << endl;
                isPrime = false;
                break;
            }
            else
                divisor = divisor + 2;
        }

        if (isPrime)
            cout << "It is a prime number" << endl;
    }

    return 0;
}
