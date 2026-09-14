/*
C++ 08, Ex 01

Write a C++ program which multiplies a vector shown in the figure below, 
as represented by a 1-D array of double, by a multiplicative factor (a scalar).

The purpose of this exercise is to practice passing a 1-D array as a 
parameter to a function.  Write a function that takes the vector and 
the scalar as its parameters and returns the new (scaled) vector using 
the same array as was input.

Ask the user to give all three of the vector components.  
Store these in a one dimensional array.  
Note: use an array of doubles, not the vector data type.  
Ask the user to input the multiplicative factor.  
Send this array and factor to your function to carry out the multiplication.

J. M. Hinckley
2024
*/
#include <iostream>
using namespace std;

// Function to multiply each element of the array by a scalar
void multiplyByScalar(double arr[], int size, double scalar) {
    for (int i = 0; i < size; ++i) {
        arr[i] *= scalar;
    }
}

int main() {
    double vector[] = { 1, 3, 5 };
    int size = sizeof(vector) / sizeof(vector[0]);

    // Multiply by a scalar value
    double scalar = 2;

    cout << "Input the three vector components: ";
    cin >> vector[0] >> vector[1] >> vector[2];

    cout << "Input the multiplicative value: ";
    cin >> scalar;

    multiplyByScalar(vector, size, scalar);

    // Print the modified array
    cout << "Modified Vector: ";
    for (int i = 0; i < size; ++i) {
        cout << vector[i] << " ";
    }
    cout << endl;

    return 0;
}