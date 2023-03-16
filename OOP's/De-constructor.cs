using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_De_constructor
{
   public  class Employee
    {
        int id;
        String name;
        int age;
        double salary;

        public  Employee(int id, String name,int age,double salary)
        {
           this.id = id;
            this.name= name;
            this.age = age;
            this.salary  = salary ;
        }

        public void Deconstruct(out int id,out String name,out int age,out double salary)
        {
            id = this.id;
            name = this.name;
            age = this.age;
            salary = this.salary;
        }
        public void Deconstruct( out String name ,out double salary)
        {
         
            name = this.name;
       
            salary = this.salary;
        }

        static void Main()
        {
            Employee Employee = new Employee(01,"ram",18,22000);
            (int id, String name, int age, double salary) =Employee;
            Console.WriteLine("id="+id);
            Console.WriteLine("name=" + name);
            Console.WriteLine("age=" + age );
            Console.WriteLine("salaryt=" + salary );
            Console.WriteLine();

            (String _name, double _salary) = Employee;
            Console.WriteLine("name=" + _name);
            Console.WriteLine("salaryt=" + _salary);
        }

        class demo
        {
            

        }
    }
 
}
