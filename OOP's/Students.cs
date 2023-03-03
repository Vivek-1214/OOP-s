using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Student
{
    internal class Students
    {
        public int Roll_No;
        public String Name;
        public String Division;

        public void GetData()
        {
            Console.WriteLine("enter student roll no ");
            Roll_No = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter student Name ");
            Name = Console.ReadLine();

            Console.WriteLine("enter student division ");
            Division = Console.ReadLine();
        }
        public void ShowData()
        {
            Console.WriteLine("student roll no. = " + Roll_No);
            Console.WriteLine("student name = " + Name);
            Console.WriteLine("student division = " + Division);
        }
    }
}
