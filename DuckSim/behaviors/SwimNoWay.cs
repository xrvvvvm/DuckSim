using System;
using DuckSim.interfaces;

namespace DuckSim.behaviors
{
    public class SwimNoWay : ISwimmable
    {
        public void swim()
        {
            Console.WriteLine("Swim no way");
        }
    }
}