using DuckSim.interfaces;
using System;

namespace DuckSim.behaviors
{
    class Quack : IQuackable
    {
        public void quack()
        {
            Console.WriteLine("Quack");
        }

    }
}
