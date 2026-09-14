#include "Coffee.h"

string Coffee::getBean() const
{
    return bean;
}

bool Coffee::isDecaffeinated() const
{
    return decaffeinated;
}

void Coffee::setBean(string b)
{
    bean = b;
}

void Coffee::setDecaffeinated(bool d)
{
    decaffeinated = d;
}
