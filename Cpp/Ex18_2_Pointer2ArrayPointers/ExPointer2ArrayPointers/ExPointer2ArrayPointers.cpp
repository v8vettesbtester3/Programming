#include <iostream>
using namespace std;

// Function to dynamically allocate memory for an array of integers
void allocateMemory(int** ptr2ptr2int, int num) {
    // On entry to this function, the argument ptr2ptr2int is a
    // pointer to (a pointer to an integer).
    // This is of type int**.
    // The parameter num is the number of elements in the array
    // to be allocated.

    // The entity that ptr2ptr2int points to is a (pointer to an array of integers).
    // This entity is *ptr2ptr2int: note the asterisk!

    int* ptr2int = new int[num];     // memory is allocated for an array of integers
    cout << "The address CONTAINED by the pointer to the integer array: " << ptr2int << endl;
    cout << "This is the address of the start of the integer array." << endl << endl;

    *ptr2ptr2int = ptr2int;     // the address of that memory is passed here

    for (int i = 0; i < num; i++) {
        //*(ptr2int + i) = 2 * i; // a value is assigned to the integer
        // Or, alternatively.
        *(*ptr2ptr2int + i) = 2 * i; // a value is assigned to the integer
    }
}

int main() {
    int* ptr2int = nullptr; // Pointer to int, initially nullptr

    // At this point, the only thing that exists is a pointer to an int.
    // This does not point to a valid int, yet; it points to 0x0 (nullptr).
    // This pointer, having been allocated, exists at some location in memory
    // and therefore does have an address.
    // This address is obtained as &ptr2int.
    // The value of ptr2int is meaningless; you wouldn't pass it as an argument.
    // Instead, pass the address of ptr2int.
    /*
    *   -------      -------       -------
    *   |     |      |     |       |     |
    *   | &p  |  ->  |  p  |  ->   | int |
    *   |valid|      | 0x0 |       |  ?  |
    *   -------      -------       -------
    */

    cout << "The ADDRESS of the POINTER to the integer array: " 
        << &ptr2int << endl;
    cout << "This is the address of the pointer to the integer." << endl << endl;

    int num;
    cout << "Enter number of integers to allocate: ";
    cin >> num;
    cout << endl;

    allocateMemory(&ptr2int, num); // Pass the address of ptr2int and the number of values to allocate

    /*
    *   If num = 4, for example:
    * 
    *   -------------      -----------       -------
    *   |           |      |         |       |     |
    *   | &ptr2int  |  ->  | ptr2int |  ->   | int |
    *   |  valid    |      |  valid  |       |  0  |
    *   -------------      -----------       -------
    * 
    *                                        -------
    *                                        |     |
    *                       ptr2int+1   ->   | int |
    *                                        |  2  |
    *                                        -------
    *
    *                                        -------
    *                                        |     |
    *                       ptr2int+2   ->   | int |
    *                                        |  4  |
    *                                        -------
    *
    *                                        -------
    *                                        |     |
    *                       ptr2int+3   ->   | int |
    *                                        |  6  |
    *                                        -------
    */

    // Now ptr2int points to dynamically allocated memory
    for (int i = 0; i < num; i++) {
        cout << "Value at " << (ptr2int + i) << " is " << *(ptr2int + i) << endl;
    }

    delete [] ptr2int; // Free the dynamically allocated memory

     return 0;
}
