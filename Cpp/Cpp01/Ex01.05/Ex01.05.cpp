/*
* C++ Ex01.05
*
* Write a C++ program that outputs a list of integers from 1 to 10, and their squares and cubes.
* The output should start like this:
* 1     1     1
* 2     4     8 , etc.
* Control the format to use 6 columns per number, right justified.
*
* J. M. Hinckley
* 2024
*/

#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
    for (int irow = 0; irow < 10; irow++) {
        int x = irow + 1;
        int a = x;
        int b = x * x;
        int c = pow(x, 3);
        cout << setw(6) << right << a << setw(6) 
            << right << b << setw(6) << right << c << endl;
    }
}
