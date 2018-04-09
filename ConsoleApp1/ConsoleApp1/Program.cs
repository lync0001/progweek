using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new Mallard();
            mallard.performFly();
            mallard.performQuack();

            Console.Read(); 

        }
    }
}
