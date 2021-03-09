using DuckSim.interfaces;
using System;

namespace DuckSim.behaviors
{
    public class Squeak : IQuackable
    {
        public void quack()
        {
            Console.WriteLine("squeak");
        }
    }
}
