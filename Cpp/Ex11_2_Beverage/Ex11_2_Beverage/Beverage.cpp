#include "Beverage.h"

string Beverage::getName() const
{
    return name;
}

string Beverage::getColor() const
{
    return color;
}

double Beverage::getTemperature() const
{
    return temperature;
}

void Beverage::setName(string n)
{
    name = n;
}

void Beverage::setColor(string c)
{
    color = c;
}

void Beverage::setTemperature(double t)
{
    temperature = t;
}
