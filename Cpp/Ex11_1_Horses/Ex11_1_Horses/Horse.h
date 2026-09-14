#pragma once

#include <string>
using namespace std;

class Horse
{
private:
	string name;
	string color;
	int birthYear;

public:
	Horse();
	string getName() const;
	string getColor() const;
	int getBirthYear() const;
	void setName(string n);
	void setColor(string c);
	void setBirthYear(int y);
};

