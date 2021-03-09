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
        public IFlyable flyBehavior;
        public IQuackable quackBehavior;
        public ISwimmable swimBehavior;

        public void performFly()
        {
            flyBehavior.fly();
        }

        public void performQuack()
        {
            quackBehavior.quack();
        }

        public void performSwim()
        {
            swimBehavior.swim();
        }

        public abstract void display();
    }
}
