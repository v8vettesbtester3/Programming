#pragma once
#include <string>
using namespace std;
class Beverage
{
	string name;
	string color;
	double temperature;
public:
	Beverage()
		: name(""), color(""), temperature(0) {}
	string getName() const;
	string getColor() const;
	double getTemperature() const;
	void setName(string n);
	void setColor(string c);
	void setTemperature(double t);
};

