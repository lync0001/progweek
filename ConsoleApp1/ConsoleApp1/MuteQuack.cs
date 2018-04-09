using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class MuteQuack : QuackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}
