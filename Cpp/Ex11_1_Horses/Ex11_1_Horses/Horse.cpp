#include "Horse.h"

Horse::Horse()
{
}

string Horse::getName() const
{
    return name;
}

string Horse::getColor() const
{
    return color;
}

int Horse::getBirthYear() const
{
    return birthYear;
}

void Horse::setName(string n)
{
    name = n;
}

void Horse::setColor(string c)
{
    color = c;
}

void Horse::setBirthYear(int y)
{
    birthYear = y;
}
