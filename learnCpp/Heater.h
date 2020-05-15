#pragma once
#ifndef HEATER_H
#define HEATER_H

#include <vector>

class Heater
{
public:
    // void (*onBoil)(int);
    std::vector<void (*)(int)> onBoilEvents;

    void boilWater();

private:
    int temperature;
};

#endif // !HEATER_H




