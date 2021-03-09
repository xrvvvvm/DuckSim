using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuckSim.interfaces;

namespace DuckSim
{
    abstract class Duck
    {
        Flyable flyBehavior;
        Quackable quackBehavior;

        void performFly()
        {
            flyBehavior.fly();
        }

        void performQuack()
        {
            quackBehavior.quack();
        }

        void display()
        {

        }
    }
}
