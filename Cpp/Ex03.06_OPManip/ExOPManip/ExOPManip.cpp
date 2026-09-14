// ExOPManip.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
/*
C++ 03, Ex 06

Use the setw(), left, right and setfill() output manipulators with console output.
Write a C++ program which outputs 19 lines of characters.  
Use setw() to control each line to be 10 characters long.  
On the first line, output “A”, filling to the right with period characters (‘.’).  
On the second line, output “AA”, filling to the right with period characters.  
Continue in this manner for a total of 10 lines, with the 10th line being “AAAAAAAAAA”.  
Then, the next nine lines have progressively fewer A’s, 
being padded on the left with period characters.  
Use the setfill() manipulator to specify that the lines are padded with period characters.  
Use the left and right output manipulators to make the A’s in the first 
nine rows left justified and the A’s in the last nine rows right justified.

J. M. Hinckley
2024
*/

#include <iostream>
#include <iomanip>
#include <string>
using namespace std;
int main()
{
    for (int i = 1; i <= 10; i++) {
        cout << setw(10) << left << setfill('.');
        string s = "";
        for (int j = 1; j <= i; j++) {
            s += 'A';
        }
        cout << s << '\n';
    }
    for (int i = 9; i >= 1; i--) {
        cout << setw(10) << right << setfill('.');
        string s = "";
        for (int j = 1; j <= i; j++) {
            s += 'A';
        }
        cout << s << '\n';
    }
}
