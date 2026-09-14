// ExPeek.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
/*
* C++ 03, Ex 02
* 
* Use the peek() and ignore() functions with console input.
* Write a C++ program which asks the user to input a character 
* (could be letter, number, punctuation, etc.).  
* Use the peek() function to check whether the user just pressed 
* the Enter key (the input would be ‘\n’ in this case).  
* If this happens, use the ignore() function to ignore the rest of 
* the characters in the input buffer.  Then ask the user to input a character again.  
* Keep asking until a character (other than ‘\n’) is input.  
* When a valid character is input, write its value back out to the console.
*
* J. M. Hinckley
* 2024
*/

#include <iostream>
using namespace std;
int main()
{
    char ch;

    cout << "Enter a character: ";
    while (cin.peek() == '\n') {
        cin.ignore(1,'\n');
        cout << "You didn't enter a character.  Try again.  Enter a character: ";
    }
    cin.get(ch);
    cout << "You entered: " << ch << endl;
}
