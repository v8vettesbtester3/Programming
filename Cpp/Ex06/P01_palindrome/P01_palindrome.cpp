/*
C++ 06, Ex 01

Write a C++ program that prompts the user to input a string.  
Then the program calls a function, passing the string as a parameter.  
The function returns true or false, depending on whether the string 
is a palindrome or not.
Output a message indicating whether or not the string is a palindrome.

J. M. Hinckley
2024
*/

#include <iostream>
#include <string>

using namespace std;

bool isPalindrome(string str);

int main()
{
	string s;
	cout << "Enter a string (ctl-Z to end): ";
	while (getline(cin, s)) {

		if (isPalindrome(s))
			cout << s << " is a palindrome." << endl;
		else
			cout << s << " is not a palindrome." << endl;

		cout << "Enter a string: ";
	}

	return 0;
}

bool isPalindrome(string str)
{
	int length = str.length();

	char ch1, ch2;

	for (int i = 0; i < length / 2; i++)
	{
		ch1 = toupper(str[i]);
		ch2 = toupper(str[length - 1 - i]);
		if (ch1 != ch2)
			return false;
	}

	return true;
}