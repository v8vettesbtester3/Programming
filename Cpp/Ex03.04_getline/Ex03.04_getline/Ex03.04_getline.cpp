// Ex03.04_getline.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
/*
C++ 03, Ex 04

Use the getline() function with console input.
Write a C++ program which asks the user to enter their full name.  
This is to be input into a single string.  
In order to input the name, including the space between the first and last name, 
in a single read operation, you will need to use the getline() function.  
Finish by outputting a message telling you what you just entered.

J. M. Hinckley
2024
*/

#include <iostream>
#include <string>

using namespace std;

int main()
{
    string fullName;
    cout << "Enter your full name: ";
    getline(cin, fullName);

    cout << "You just entered: '"<< fullName <<"'" << endl;

}
