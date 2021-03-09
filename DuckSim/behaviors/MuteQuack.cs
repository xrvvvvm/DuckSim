using DuckSim.interfaces;
using System;

namespace DuckSim.behaviors
{
    public class MuteQuack : IQuackable
    {
        public void quack()
        {
            Console.WriteLine("mute quack");
        }
    }
}
