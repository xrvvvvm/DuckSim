using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuckSim.interfaces;

namespace DuckSim.behaviors
{
    public class ReactFly : IFlyable
    {
        public void fly()
        {
            Console.WriteLine("React fly");
        }
    }
}
