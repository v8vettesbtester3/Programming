#include "RaceHorse.h"

RaceHorse::RaceHorse() : Horse()
{
}

int RaceHorse::getRaces() const
{
    return races;
}

void RaceHorse::setRaces(int numRaces)
{
    races = numRaces;
}
