#include "Heater.h"

void Heater::boilWater()
{
	for (int i = 0; i < 100; ++i)
	{
		temperature = i;
		if (temperature > 95) 
		{
			// do something
			// onBoil(temperature);
			for (auto onBoil : onBoilEvents)
			{
				onBoil(temperature);
			}
		}
	}
}
