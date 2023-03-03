using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_s
{
    internal class OverridingDemo
    {
        public virtual  void add()                      //for overriding use virtual keyword in parent class method
        {
            int a, b, c;
            a = 1;
            b = 2;
            c = a + b;
            Console.WriteLine(c);
        }
        public virtual void add(int a,int b)                  //thise is method overloading         
        {
            int  c;
    
            c = a + b;
            Console.WriteLine(c);
        }
        public virtual void add(int a,int b,int c)                      
        {
            int d;
      
            d = a + b+c;
            Console.WriteLine(d);
        }

        public void name()
        {
            Console.WriteLine("this is parenr class method");
        }


    }
    class child : OverridingDemo
    {
        public override  void add()           //for overriding use overridi keyword in child class method
        {
            int a, b, c;
            a = 1;
            b = 2;
            c = a + b;
            Console.WriteLine(c);
        }

        public void name()
        {
            Console.WriteLine("this is child class method");
        }

    }
    class exec1
    {
      /*  static void Main()
        {
            OverridingDemo O = new OverridingDemo();
            O.add();
            O.add(10,20);
            O.add(10,20,30);

            //child c = new child();
            // c.add();

        }*/
    }
}
