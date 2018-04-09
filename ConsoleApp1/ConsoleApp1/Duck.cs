using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Duck
    {
        protected FlyBehaviour flyBehaviour;
        protected QuackBehaviour quackBehaviour;
        public Duck()
        {
        }

        public void performFly()
        {
            flyBehaviour.fly();
        }
        public void performQuack()
        {
            quackBehaviour.quack();
        }
        public void swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}
