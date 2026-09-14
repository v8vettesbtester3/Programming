// Ex11_2_Beverage.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include "Beverage.h"
#include "Coffee.h"

int main()
{
    Beverage* beverage1 = new Beverage();
    Coffee* beverage2 = new Coffee();

    beverage1->setName("Yerba Mate");
    beverage1->setColor("Greenish yellow");
    beverage1->setTemperature(160);

    beverage2->setName("Blue Mountain");
    beverage2->setColor("Dark brown");
    beverage2->setTemperature(200);
    beverage2->setBean("Roasted");
    beverage2->setDecaffeinated("false");

    // Print field values of Beverage
    cout << "Beverage Details:" << endl;
    cout << "Name: " << beverage1->getName() << endl;
    cout << "Color: " << beverage1->getColor() << endl;
    cout << "Temperature: " << beverage1->getTemperature() << " degrees Fahrenheit" << endl << endl;


    // Print field values of Coffee
    cout << "Coffee Details:" << endl;
    cout << "Name: " << beverage2->getName() << endl;
    cout << "Color: " << beverage2->getColor() << endl;
    cout << "Temperature: " << beverage2->getTemperature() << " degrees Fahrenheit" << endl;
    cout << "Bean: " << beverage2->getBean() << endl;
    cout << "Decaffeinated: " << (beverage2->isDecaffeinated() ? "Yes" : "No") << endl;

}
