using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_s
{  //Constructor-- it is used to initialized the values of a feild or class
    internal class ConDemo
    {
          //differnce bet method and constructor
      public ConDemo()  //1) without parameters
        {
            Console.WriteLine("thise is a constructor");
        }   



        public void MethDemo()                        //we cannot give parameters to implicite constructor
        {
            Console.WriteLine("thise is a method");
        }


      /*  public  static void Main(String[] args)
            {
                ConDemo C1 = new ConDemo();

            
                
            }*/
    }


}
