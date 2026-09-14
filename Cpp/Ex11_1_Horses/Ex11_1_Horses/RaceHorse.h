#pragma once
#include "Horse.h"

class RaceHorse :
    public Horse
{
private:
    int races;

public:
    RaceHorse();
    int getRaces() const;
    void setRaces(int numRaces);
};

