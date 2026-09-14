/*
C++ 07, Ex 02

Write a C++ program that prompts the user to input a string.  
The program then uses the function substr() to remove all the vowels from the string.  
After removing the vowels, output the resulting string.  
Your program should contain a function to remove all of the vowels and a 
function to determine whether a character is a vowel.

Adapted from Malik, Ch 7, Ex 4

J. M. Hinckley
2024
*/


#include <iostream> 
#include <string>

using namespace std;

void removeVowels(string& str);
bool isVowel(char ch);

int main()
{
    string str;

    do {

        cout << "Enter a string (QUIT to quit): ";
        cin >> str;
        cout << endl;

        if (str != "QUIT") {

            cout << "Before removing vowels: " << str << endl;

            removeVowels(str);

            cout << "Afer removing vowels: " << str << endl;
        }
    } while (str != "QUIT");

    return 0;
}

void removeVowels(string& str)
{
    int len = str.length();

    int index = 0;

    while (index < len)
    {
        if (isVowel(str[index]))
        {
            str = str.substr(0, index) + str.substr(index + 1, str.length());
            len = str.length();
        }
        else
            index++;
    }
}

bool isVowel(char ch)
{
    switch (ch)
    {
    case 'a':
    case 'A':
    case 'e':
    case 'E':
    case 'i':
    case 'I':
    case 'o':
    case 'O':
    case 'u':
    case 'U':
    case 'y':
    case 'Y':
        return true;
    default:
        return false;
    }
}