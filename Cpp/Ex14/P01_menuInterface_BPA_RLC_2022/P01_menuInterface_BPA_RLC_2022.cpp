// P01_menuInterface_BPA_RLC_2022.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>
#include <sstream>
#include <vector>
#include <fstream>

using namespace std;

void split(string str, vector<string>& tokens);
bool displayMenu(string path, vector<string>& items, vector<double>& costs);
int getSumFromText(string str);
double getCostFromText(vector<string> tokens, vector<string> items, vector<double> costs);

int main()
{
	string in = "";
	int sum = 0;
	double cost = 0.0;

	vector<string> items;
	vector<double> costs;

	if (displayMenu("menu.txt", items, costs))
	{
		if (items.size() > 0)
		{
			cout << endl << "Enter order in format of Num1 Item1 Num2 Item2 ..." << endl;

			while (getline(cin, in))
			{
				if (!strcmp(in.c_str(), "exit")) break;

				vector<string> tokens;
				split(in, tokens);

				if (tokens.size() % 2 != 0)
				{
					cout << "Improper # of tokens - ensure input is in format of Num1 Item1 Num2 ..." << endl;
					continue;
				}

				sum = getSumFromText(in);
				cost = getCostFromText(tokens, items, costs);

				if (sum > 0)
				{
					if (cost > 0.0)
					{
						cout << "Purchasing " << sum << " items for $" << cost << endl;
					}
					else
					{
						cout << "No items were found in menu. Please enter again." << endl;
					}
				}
				else
				{
					cout << "No quantity was defined in input. Please enter again." << endl;
				}

				cout << endl << "Enter order in format of Num1 Item1 Num2 Item2 ..." << endl;
			}
		}
		else
		{
			cout << "No items loaded from menu file." << endl;
		}
	}
	else
	{
		cout << "Error loading menu file." << endl;
	}
}

void split(string str, vector<string>& tokens)
{
	string val;
	stringstream sstr(str);
	while (sstr >> val)
	{
		tokens.push_back(val);
	}
}

bool displayMenu(string path, vector<string>& items, vector<double>& costs)
{
	string line = "";
	ifstream file(path);

	if (file.is_open())
	{
		cout << "Store Menu: " << endl;

		while (getline(file, line))
		{
			vector<string> tokens;
			split(line, tokens);

			double tok1 = stod(tokens[1]);

			cout << "  " << tokens[0] << " for $" << tok1 << endl;

			items.push_back(tokens[0]);
			costs.push_back(tok1);
		}
		return true;
	}
	else
	{
		return false;
	}
}

int getSumFromText(string str)
{
	int num = 0;
	int sum = 0;

	for (int i = 0; i < (int)str.size(); i++)
	{
		if (isdigit(str[i])) continue;
		else str[i] = ' ';
	}

	stringstream sstr(str);
	while (sstr >> num)
	{
		sum += num;
	}

	return sum;
}

double getCostFromText(vector<string> tokens, vector<string> items, vector<double> costs)
{
	double sum = 0;

	for (int i = 0; i < tokens.size(); i += 2)
	{
		int num = atoi(tokens[i].c_str());
		if (!tokens[i].empty() && tokens[i].find_first_not_of("0123456789") == string::npos)
		{
			string item = tokens[i + 1];
			bool found = false;
			int j = 0;

			while (j < items.size() && !found)
			{
				if (item == items[j])
				{
					found = true;
				}
				else
				{
					j++;
				}
			}

			if (found)
			{
				sum += costs[j] * double(num);
			}
			else
			{
				cout << item << " was not found!" << endl;
			}
		}
		else
		{
			cout << tokens[i] << " is not a number! Please verify format." << endl;
		}
	}

	return sum;
}
