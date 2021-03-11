using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSim
{
    class Program
    {
        static void Main(string[] args)
        {
            DecoyDuck decoyDuck = new DecoyDuck();
            RoastDuck roastDuck = new RoastDuck();
            WoodDuck woodDuck = new WoodDuck();

            decoyDuck.quack();
            roastDuck.display();
            woodDuck.performSwim();
            roastDuck.performQuack();
        }
    }
}
