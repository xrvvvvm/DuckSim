using System;
using DuckSim.interfaces;
using DuckSim.behaviors;

namespace DuckSim
{
    class ReadheadDuck : Duck
    {
        public ReadheadDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }
        public void display()
        {
            Console.WriteLine("ReadheadDuck display");
        }
    }
}
