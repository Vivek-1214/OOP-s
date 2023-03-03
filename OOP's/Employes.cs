using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Employees
{
    internal class Employee
    {
      public  int Id;
      public  String Name;
       public String Gender;    //variable

        public void GetData()
        {
            Console.WriteLine("enter employee Id ");
           Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter employee Name ");
            Name = Console.ReadLine();

            Console.WriteLine("enter employee Gender ");
            Gender = Console.ReadLine();
        }
        public void ShowData()
        {
            Console.WriteLine("Employee2 id = " + Id);
            Console.WriteLine("Employee2 name = " +Name);
            Console.WriteLine("Employee2 gender = " +Gender);
        }

    }
}
