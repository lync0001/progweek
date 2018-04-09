using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Mallard : Duck
    {
        public Mallard()
        {
        this.quackBehaviour = new Squeak();
        this.flyBehaviour = new FlyWithWings();
        }

    }
}
