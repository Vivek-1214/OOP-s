using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ConstructorDemo2
{
    internal class patients
    {
        public int id { get; set; }
        public String name { get; set; }
        public String problem { get; set; }

        public patients()
        {
            this.id = 01;
            this .name ="patient01";
            this.problem = "maleria";
        }
        public patients(int id,String name,String problem)
        {
            this.id = id;
            this.name = name;
            this.problem = problem;
        }
        public patients(patients obj)
        {
            this.id = obj.id;
            this.name = obj. name;
            this.problem = obj. problem;
        }

        public void Display()
        {
            Console.WriteLine("id = " + id);
            Console.WriteLine("name = " + name);
            Console.WriteLine("problem = " + problem);
        }

    }
}
