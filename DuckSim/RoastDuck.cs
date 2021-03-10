using System;
using DuckSim.behaviors;

namespace DuckSim
{
    public class RoastDuck : Duck
    {
        public RoastDuck()
        {
            quackBehavior = new MuteQuack();
            flyBehavior = new FlyNoWay();
            swimBehavior = new SwimNoWay();
        }
        
        public override void display()
        {
            Console.WriteLine("RoastDuck display");
        }
    }
}