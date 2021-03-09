using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuckSim.interfaces;

namespace DuckSim
{
    public abstract class Duck
    {
        public Flyable flyBehavior;
        public IQuackable quackBehavior;

        public void performFly()
        {
            flyBehavior.fly();
        }

        public void performQuack()
        {
            quackBehavior.quack();
        }

        public abstract void display();
    }
}
