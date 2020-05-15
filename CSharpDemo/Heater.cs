using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo
{
    /// <summary>
    /// 热水器
    /// </summary>
    class Heater
    {
        private int temperature;

        public delegate void BoilHandler(int param);
        public event BoilHandler boilEvent;

        // 烧水
        public void boilWater()
        {
            for(int i = 0; i < 100; ++i)
            {
                temperature = i;
                if(temperature > 95)
                {
                    // do something
                    boilEvent?.Invoke(temperature);
                }
            }
        }
    }
}
