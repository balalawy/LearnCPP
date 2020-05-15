using System;

// https://www.cnblogs.com/SkySoot/archive/2012/04/05/2433639.html
// C#中的委托和事件详解
namespace CSharpDemo
{
    // 定义委托
    public delegate void GreetingDelegate(string name);

    class Program
    {
        public static void EnglishGreeting(string name)
        {
            Console.WriteLine("Good Morning, " + name);
        }


        public static void ChineseGreeting(string name)
        {
            Console.WriteLine("早上好, " + name);
        }


        // 调用了委托GreetingDelegate
        public static void GreetPeople(string name, GreetingDelegate makeGreeting)
        {
            makeGreeting(name);
        }


        static void Main(string[] args)
        {
            // 使用委托方式一：
            GreetPeople("Mike", EnglishGreeting);
            GreetPeople("张三", ChineseGreeting);

            // 使用委托方式二：
            // 可以将多个方法赋给同一个委托，或者叫将多个方法绑定到同一个委托，
            // 当调用这个委托的时候，将依次调用其所绑定的方法。
            GreetingDelegate delegateFunc;
            delegateFunc = EnglishGreeting;
            delegateFunc += ChineseGreeting;
            GreetPeople("Jake", delegateFunc);

            // 使用委托方式三：
            // 进行封装
            GreetingManager gm = new GreetingManager();
            gm.delegate1 = EnglishGreeting;
            gm.delegate1 += ChineseGreeting;
            gm.GreetPeople("Yumy");

            // 使用事件:
            GreetingManager gm2 = new GreetingManager();
            gm2.MakeGreet += EnglishGreeting;
            gm2.MakeGreet += ChineseGreeting;
            gm2.GreetPeople2("Vaneyu");

            // 烧水:
            Heater heater = new Heater();
            heater.boilEvent += new Alarm().alarm;
            heater.boilEvent += new Display().display;
            heater.boilWater();
        }
    }
}
