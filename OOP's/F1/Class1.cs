using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_s.F1
{
    internal class Class1
    {
        public void Add1()
        {
            Add2();
            sub1();
        }

        public void Add2()
        {

        }

        static void sub1()
        {

        }

        static void sub2()
        {
            Class1 c1 = new Class1();
            sub1();
            c1.Add2();

        }
    }
}