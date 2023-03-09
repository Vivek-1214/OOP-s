using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOP_parameter
{
    internal class parameterDemo
    {
        //TYPES OF PARAMETERES

        public int result;
        public int result1;

       

        // a and b  is a Formal parameters
        public void add1(int a,int b)      //input parameters 
        {
            result = a + b;
            Console.WriteLine(result);
        }

        // x and y  is a Formal parameters
        public void sub1(int x, int y,out int result2)      
        {
           
            result2 = x - y;
            Console.WriteLine(result2);
        }

        public void div1(int x, int y, ref int result1)  //input-output parameter
        {
            result1 = result1+ x / y;
            Console.WriteLine($"division of x and y is = {result1}");
        }
      
        public int ArithmeticOps(int m,int n, out int sub, out int mul, out int div)
        {
            
            sub= m - n;
            mul= m * n;
           div= m / n;
            Console.WriteLine($"the sub is {sub} and mul is {mul} and the div is {div}");
            return m + n;
         
        }






    }
}
