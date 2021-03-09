using DuckSim.interfaces;
using System;

namespace DuckSim.behaviors
{
    class MuteQuack : IQuackable
    {
        public void quack()
        {
            Console.WriteLine("mute quack");
        }
    }
}
