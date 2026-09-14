/*
* C++ Ex01.03
*
* Write a C++ program that inputs from the user the radius of a sphere (floating point number),
* then calculates and displays its volume.  The output should be labeled with the text 
* “Volume = “, followed by the numerical value.
*
* J. M. Hinckley
* 2024
*/

#include <iostream>
using namespace std;

int main()
{
    cout << "Enter radius: ";
    double R;
    cin >> R;

    double vol = (4.0 / 3.0) * 3.141592 * R * R * R;
    cout << "Volume = " << vol << endl;
}
