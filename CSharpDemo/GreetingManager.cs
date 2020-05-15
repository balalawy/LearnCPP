using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo
{
    class GreetingManager
    {
        public GreetingDelegate delegate1;

        public event GreetingDelegate MakeGreet;

        public void GreetPeople(String name)
        {
            if(null != delegate1)
            {
                delegate1(name);
            }
        }


        public void GreetPeople2(String name)
        {
            MakeGreet(name);
        }
    }
}
