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
            swimBehavior = new SwimWithPaws();
        }

        public override void display()
        {
            Console.WriteLine("MallardDuck display");
        }
    }
}
