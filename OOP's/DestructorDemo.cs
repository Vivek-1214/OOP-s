using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Destructor
{
    internal class Demo
    {
        public Demo()
        {
            Console.WriteLine("thise is constructor");
        }

       ~  Demo()
        {
            Console.WriteLine("thise is destructor");
        }

    }
}
