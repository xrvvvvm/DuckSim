using System;
using DuckSim.interfaces;

namespace DuckSim.behaviors
{
    public class Drifting : ISwimmable
    {
        public void swim()
        {
            Console.WriteLine("Drifting");
        }
    }
}