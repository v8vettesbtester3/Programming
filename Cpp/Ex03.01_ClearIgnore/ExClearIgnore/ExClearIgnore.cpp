// ExClearIgnore.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
/*
* C++ 03, Ex 01
* 
* Use the clear() and ignore() functions with console input.
* Write a C++ program which asks the user to input a number.  
* Attempt to read the number.  
* If the input is not valid (characters) this will cause the input stream to be in an error state.  
* In this situation, use the clear() to clear the error state and use the ignore() function 
* to ignore the rest of the characters in the input buffer.  
* Then ask the user to input a number again.  
* Keep asking until a valid number is input.  
* When a valid number is input, write its value back out to the console.
*
* J. M. Hinckley
* 2024
*/

#include <iostream>
using namespace std;

int main()
{
    int num;

    cout << "Enter a number: ";

    while (!(cin >> num)) {
        // There's an error.
        // clear the error state in the input stream.
        cin.clear();

        // Discard any remaining characters in the input buffer.
        cin.ignore(1000, '\n');

        // Query again.
        cout << "That was not valid, try again.  ";
    }

    cout << "You entered: " << num << endl;
}
