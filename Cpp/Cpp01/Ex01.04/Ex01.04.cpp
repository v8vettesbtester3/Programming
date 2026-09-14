/*
* C++ Ex01.04
*
* Write a C++ program that outputs a rectangular multiplication table from 1X1 to 10X10.  
* Control the format of the data in each line so that each number is allocated 4 columns, 
* right justified.
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
        int y = irow + 1;
        for (int icol = 0; icol < 10; icol++) {
            int x = icol + 1;
            int z = x * y;
            cout << setw(4) << right << z;
        }
        cout << endl;
    }
}
