using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ConstructorDemo1
{  //Constructor-- it is used to initialized the values of a object or member of  class
    internal class ConDemo1
    {
      public  int id { get; set; }
      public  String name { get; set; }

        public int salary { get; set; }
        //differnce bet method and constructor
        public ConDemo1()  //1) parameterless / default constructor
        {
            this.id = 01;
            this.name = "vivek";

            this.salary  = 50000;
        }

        public ConDemo1(int id,String name,int salary)  //1) parameterless / default constructor
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public ConDemo1(ConDemo1 obj)
        {
            this.id = obj.id;
            this.name = obj. name;
            this.salary = obj. salary;
        }
        public void show()
        {
            Console.WriteLine(this.id);
            Console.WriteLine(this.name);
            Console.WriteLine(this.salary );
        }



        


    }


}
