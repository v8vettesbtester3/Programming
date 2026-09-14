/*
* C++ Ex01.01
* 
* Write a C++ program that asks you for your name, 
* address and phone number and then displays them.
* 
* J. M. Hinckley
* 2024
*/

#include <iostream>
#include <string>
using namespace std;

int main()
{
    cout << "Enter your name: ";
    string name;
    getline(cin, name);

    cout << "Enter your address: ";
    string addr;
    getline(cin, addr);

    cout << "Enter your phone number: ";
    string phNum;
    getline(cin, phNum);

    cout << "Name: " << name << endl;
    cout << "Address: " << addr << endl;
    cout << "PHone Number: " << phNum << endl;
}
