using DuckSim.interfaces;
using System;

namespace DuckSim.behaviors
{
    class Squeak : IQuackable
    {
        public void quack()
        {
            Console.WriteLine("squeak");
        }
    }
}
