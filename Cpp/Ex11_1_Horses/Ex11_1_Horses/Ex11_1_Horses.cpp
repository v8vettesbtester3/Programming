// Ex11_1_Horses.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>
#include "Horse.h"
#include "RaceHorse.h"

using namespace std;

int main()
{
	Horse* horse1 = new Horse();
	RaceHorse* horse2 = new RaceHorse();

	horse1->setName("Bob");
	horse1->setColor("brown");
	horse1->setBirthYear(2017);

	horse2->setName("Charlene");
	horse2->setColor("black");
	horse2->setBirthYear(2019);
	horse2->setRaces(4);


	cout << horse1->getName() << " is " << horse1->getColor() << " and was born in " << horse1->getBirthYear() << ".\n";
	cout << horse2->getName() << " is " << horse2->getColor() << " and was born in " << horse2->getBirthYear() << ".\n";
	cout << horse2->getName() << " has been in " << horse2->getRaces() << " races.\n";
}
