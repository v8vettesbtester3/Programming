// P01_creditCards_BPA_RLC_2023.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>
using namespace std;
// Return this number if it is a single digit, otherwise,
// return the sum of the two digits
int getDigit(int64_t number)
{
	if (number < 9)
		return static_cast<int>(number);
	return static_cast<int>(number / 10 + number % 10);
}
// Return the number of digits in d
int getSize(int64_t d)
{
	string num = to_string(d);
	return static_cast<int>(num.length());
}
// Return the first k number of digits from
// number. If the number of digits in number
// is less than k, return number.
long getPrefix(int64_t number, int k)
{
	if (getSize(number) > k)
	{
		string num = to_string(number);
		return stol(num.substr(0, k));
	}
	return static_cast<long>(number);
}
// Return true if the digit d is a prefix for number
bool prefixMatched(int64_t number, int d)
{
	return getPrefix(number, getSize(d)) == d;
}
// Get the result from Step 2
int sumOfDoubleEvenPlace(int64_t number)
{
	int sum = 0;
	string num = to_string(number);
	for (int i = getSize(number) - 2; i >= 0; i -= 2)
		sum += getDigit(int(num[i] - '0') * 2);
	return sum;
}
// Return sum of odd-place digits in number
int sumOfOddPlace(int64_t number)
{
	int sum = 0;
	string num = to_string(number);
	for (int i = getSize(number) - 1; i >= 0; i -= 2)
		sum += num[i] - '0';
	return sum;
}
// Verifies that the sum of odd and even digits is divisible by 10
bool verifySum(int64_t number)
{
	int sum = sumOfDoubleEvenPlace(number) + sumOfOddPlace(number);
	return sum % 10 == 0; // divisible by 10 - no remainder
}
bool verifyPrefix(int64_t number)
{
	return prefixMatched(number, 4) ||
		prefixMatched(number, 5) ||
		prefixMatched(number, 37) ||
		prefixMatched(number, 6);
}
// Return true if the card number is valid
bool isValid(int64_t number)
{
	bool valid = false;
	if (getSize(number) >= 13 && getSize(number) <= 16)
	{
		if (verifyPrefix(number))
		{
			if (verifySum(number))
			{
				valid = true;
			}
		}
	}
	return valid;
}
bool is_number(const string& s)
{
	return(strspn(s.c_str(), "-.0123456789") == s.size());
}
// Entry point
int main()
{
	int64_t num = 0L; // Defined as long long (64bit signed - value is signed because -1 is exit criteria for application)
	string input;
	do
	{
		cout << "Enter a Credit Card number to check validity for (-1 to exit application): ";
		getline(cin, input);
		if (!is_number(input) || input.size() > 19) // guards stoll call to ensure value is valid
		{
			cout << "Invalid input - only enter numerical values that can be contained in a 64bit signed value (max 9223372036854775807)." << endl;
		}
		else
		{
			num = stoll(input.c_str());
			if (num != -1)
			{
				cout << num << " is " << (isValid(num) ? "valid" : "invalid") << endl;
			}
			else
			{
				cout << "Closing application." << endl;
			}
		}
	} while (num != -1);
	system("pause");
	return 0;
}