#pragma once
#include "Beverage.h"
class Coffee :
    public Beverage
{
    string bean;
    bool decaffeinated;
public:
    Coffee() : Beverage() {};
    string getBean()const;
    bool isDecaffeinated() const;
    void setBean(string b);
    void setDecaffeinated(bool d);

};

