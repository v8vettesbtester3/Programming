#include <iostream>
using namespace std;

int main() {
    // Get the size of the dynamic array from the user
    int size;
    cout << "Enter the number of values N: ";
    cin >> size;

    // Dynamically allocate memory for the array
    int* dynamicArray = new int[size];

    // Initialize the array with values
    for (int i = 0; i < size; ++i) {
        dynamicArray[i] = (i+1) * 2;
    }

    // Display the values of the dynamic array
    cout << "\nValues in the dynamic array, listed in reverse:" << endl;
    for (int i = size-1; i >= 0; i--) {
        cout << dynamicArray[i] << " ";
    }

    // Release the dynamically allocated memory
    delete[] dynamicArray;

    return 0;
}