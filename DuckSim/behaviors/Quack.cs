using DuckSim.interfaces;
using System;

namespace DuckSim.behaviors
{
    public class Quack : IQuackable
    {
        public void quack()
        {
            Console.WriteLine("Quack");
        }

    }
}
