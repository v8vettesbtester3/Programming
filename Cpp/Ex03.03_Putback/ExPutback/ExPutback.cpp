// ExPutback.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
/*
C++ 03, Ex 03

Use the putback() function with console input.
Write a C++ program which asks the user to input a character 
(could be letter, number, punctuation, etc.).  
Input the character into a char variable. 
Test whether the character is a numeral (0,.. ,9).  
If it is a numeral, use the putback() function to put the 
character back into the input stream.  
Then read it in again, this time reading it into an integer variable. 
The output the message that a number was input and print the number.  
If, on the other hand, a non-number character was input, 
just output a message saying that a non-number was input 
and print that character.

J. M. Hinckley
2024
*/

#include <iostream>
using namespace std;
int main()
{
    int num;
    char ch;

    cout << "Enter a single character: ";
    cin.get(ch);
    if (ch >= '0' && ch <= '9') {
        // put it back and read it into the integer variable.
        cin.putback(ch);
        cin >> num;
        cout << "A number was input: " << num << endl;
    }
    else
    {
        cout << "A non-number was input: " << ch << endl;
    }
}
