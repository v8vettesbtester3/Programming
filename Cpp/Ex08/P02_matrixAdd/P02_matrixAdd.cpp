/*
C++ 08, Ex 02

Write a C++ program that performs matrix addition using 2D arrays. 
The program will take two matrices of the same size as input and 
store the result in a third matrix.

Ask the user to input the values of the elements for the two matrices A and B.  
Calculate their sum and output the result C.  
You may use int data type for the elements.

J. M. Hinckley
2024
*/
#include <iostream>
using namespace std;

// Function to add two matrices
void addMatrices(int A[3][3], int B[3][3], int C[3][3]) {
    for (int i = 0; i < 3; ++i) {
        for (int j = 0; j < 3; ++j) {
            C[i][j] = A[i][j] + B[i][j];
        }
    }
}

int main() {
    // Define two 3x3 matrices
    int A[3][3] = { {1, 2, 3}, {4, 5, 6}, {7, 8, 9} };
    int B[3][3] = { {9, 8, 7}, {6, 5, 4}, {3, 2, 1} };
    int C[3][3];

    cout << "Enter the components for matrix A, row by row:" << endl;
    for (int i = 0; i < 3; ++i) {
        for (int j = 0; j < 3; ++j) {
            cin >> A[i][j];
        }
    }

    cout << "Enter the components for matrix B, row by row:" << endl;
    for (int i = 0; i < 3; ++i) {
        for (int j = 0; j < 3; ++j) {
            cin >> B[i][j];
        }
    }


    // Add the matrices
    addMatrices(A, B, C);

    // Print the resulting matrix
    cout << "Resulting Matrix (A + B):" << endl;
    for (int i = 0; i < 3; ++i) {
        for (int j = 0; j < 3; ++j) {
            cout << C[i][j] << " ";
        }
        cout << endl;
    }

    return 0;
}