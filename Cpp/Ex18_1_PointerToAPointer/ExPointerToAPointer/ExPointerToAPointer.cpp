#include <iostream>
using namespace std;

// Function to dynamically allocate memory for an integer
void allocateMemory(int** ptr2ptr2int) {
    // On entry to this function, the argument ptr2ptr2int is a
    // pointer to (a pointer to an integer).
    // This is of type int**.

    // The entity that it points to is a (pointer to an integer).
    // This is *ptr2ptr2int: note the asterisk!

    //*ptr2ptr2int = new int; // Allocate memory for an integer
    int* ptr2int = new int;     // memory is allocated for an integer
    cout << "The address contained by the pointer to the integer: " << ptr2int << endl;
    cout << "This is the address of the integer." << endl;
    *ptr2ptr2int = ptr2int;     // the address of that memory is passed here

    //**ptr2ptr2int = 10;     // Assign a value to the integer
    *ptr2int = 10;          // a value is assigned to the integer


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

    cout << "The address contained by the pointer to the pointer to the integer: " << &ptr2int << endl;
    cout << "This is the address of the pointer to the integer." << endl;

    allocateMemory(&ptr2int); // Pass the address of ptr2int

    // Now ptr2int points to dynamically allocated memory
    cout << "Value at pointer: " << *ptr2int << std::endl;

    delete ptr2int; // Free the dynamically allocated memory

    return 0;
}
