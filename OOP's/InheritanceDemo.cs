using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_s
{
    internal class InheritanceDemo
    {
        private String Name="vivek";

        public InheritanceDemo()
        {
            Console.WriteLine("Thise is Constructor ");

        }

        public void method()
        {
            Console.WriteLine("Thise is method ");
        }
    }

    class child01 : InheritanceDemo
    {
       public String surname = "shinde";

        public child01()
        {
            Console.WriteLine("Thise is Constructor 01");

        }
        public void method01()
        {
            Console.WriteLine("Thise is method 01");
        }
}
    class child02 : InheritanceDemo
    {

        public child02()
        {
            Console.WriteLine("Thise is Constructor 02");

        }
        public void method02()
        {
            Console.WriteLine("Thise is method 02");
        }
    }
    class child03 : InheritanceDemo
    {
       

        public child03()
        {
            Console.WriteLine("Thise is Constructor 03");

        }
        public void method03()
        {
            Console.WriteLine("Thise is method 03");
        }
    }

    public class exe
    {
        //  static void Main(String[] args)
         // {
              //1)SINGLE INHERITANCE

                /*child01 c1 = new child01();
                c1.method01();
                c1.method02();
                   Console.WriteLine(c1.Name);                 //we cannot access private member of parent class
                Console.WriteLine(c1.surname);

               InheritanceDemo I = new InheritanceDemo();
               I.method02();   */                                        //we cannot accessing the member of child by parent class

        //2) MULTI-LEVEL INHERITANCE

       /* child03 c3 = new child03();
        c3.method01();
        c3.method02();
        c3.method03();*/

        //3) HIRERCHIAL INHERITENCE

       // child01 c1 = new child01();      //it only use member of parent class
          //  c1.method();

        //}
    }
}
