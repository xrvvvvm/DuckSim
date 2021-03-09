using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuckSim.interfaces;

namespace DuckSim.behaviors
{
    public class FlyWithWings : Flyable
    {
        public void fly()
        {
            Console.WriteLine("Fly with wings");
        }
    }
}
