using System;
using DuckSim.interfaces;
using DuckSim.behaviors;

namespace DuckSim
{
    public class WoodDuck : Duck
    {
        public WoodDuck()
        {
            quackBehavior = new MuteQuack();
            flyBehavior = new FlyNoWay();
            swimBehavior = new Drifting();
        }

        public override void display()
        {
            Console.WriteLine("WoodDuck display");
        }
    }
}