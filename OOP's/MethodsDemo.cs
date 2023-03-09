using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Methods
{
    internal class MethodsDemo
    {


        public int num1 { get; set; }
        public int num2 { get; set; }

        public void add()               //method without parameter
        {
            int result = num1 + num2;
            Console.WriteLine($"addition of num1 and num2 is = {result}");  //interpolation use of $ symbol

        }


        public void add(int x,int y)               //method with simple parameter
        {
            int result = x+y;
            Console.WriteLine($"addition of x and y is = {result}");

        }
        public void sub(MethodsDemo MD)               //method with complex parameter
        {
            int result = MD.num1 - MD.num2;
            Console.WriteLine($"substarction of num1 and num2 is = {result}");

        }
        public void div1(MethodsDemo MD1)               //method with complex parameter
        {
            int result = MD1.num1 / MD1.num2;
            Console.WriteLine($"division of num1 and num2 is = {result}");

        }

      



    }
}
