using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstracttion
{
    internal abstract class AbstractionDemo  //Abstract class
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        public abstract int sub(int x,int y);             //we cannot give body to abstract method   
    }

    interface IinterfaceDemo         //Interface
    {
       public  void mul(int a,int b);
       public  void div(int x,int y);

        public void rem(int m,int n);
    }

   /* class child :   AbstractionDemo
    {

        public override  int sub(int x,int y)
        {
            return x - y;
        }
    }*/

   public class child1 : IinterfaceDemo
    {
      public void mul(int a,int b)
        {
            int c = a * b;
            Console.WriteLine("multiplication is = "+c);
        }
       public  void div(int x,int y)
        {
            int c = x / y;
            Console.WriteLine("division is = "+c);
        }

      public   void rem(int m, int n)
        {
            int c = m % n;
            Console.WriteLine("reminder is = " + c);
        }

    }


}
