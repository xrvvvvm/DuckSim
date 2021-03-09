﻿using System;
using DuckSim.interfaces;
using DuckSim.behaviors;

namespace DuckSim
{
    public class ReadheadDuck : Duck
    {
        public ReadheadDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }
        public override void display()
        {
            Console.WriteLine("ReadheadDuck display");
        }
    }
}
