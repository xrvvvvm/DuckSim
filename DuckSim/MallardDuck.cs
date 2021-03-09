using System;
using DuckSim.interfaces;
using DuckSim.behaviors;


namespace DuckSim
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new ReactFly();
        }

        public override void display()
        {
            Console.WriteLine("MallardDuck display");
        }
    }
}
