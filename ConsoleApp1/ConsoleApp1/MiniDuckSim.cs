using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class MiniDuckSim
    {
        public static void main(String[] args)
        {
            Duck mallard = new Mallard();
            mallard.performQuack();
            mallard.performFly();
        }
    }
}
