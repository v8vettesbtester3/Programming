// Db01_01.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include "sqlite3.h"

using namespace std;

int main()
{
    cout << "SQLite Runtime Version: " << sqlite3_libversion() << endl;
}
