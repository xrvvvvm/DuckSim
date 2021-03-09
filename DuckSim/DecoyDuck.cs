using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuckSim.interfaces;

namespace DuckSim
{
    public class DecoyDuck : IQuackable
    {
        public void quack()
        {
            Console.WriteLine("Duck decoy quack");
        }
    }
}
