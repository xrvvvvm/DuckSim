using System;
using DuckSim.interfaces;
using DuckSim.behaviors;


namespace DuckSim
{
    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new ReactFly();
        }
        public void display()
        {
            Console.WriteLine("MallardDuck display");
        }
    }
}
