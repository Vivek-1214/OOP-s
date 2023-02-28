using OOP_s;
using System;
namespace OOP_Concepts
{   class TypesOfMethods
    {
        //non-values return methood without parameter

        public void Add()
        {   
            int a=10, b=15, c;
            c = a + b;
            Console.WriteLine(c);
        }
        //non-values return methood with parameter
        public void Add01(int a,int b,out int c)             //types of parameters
        {
           
            c = a + b;
            Console.WriteLine(c);
        }

        //values return methood without parameter

        public  int Sub()
        { int a = 5, b = 3;

            return a - b;
        }
        //values return methood with parameter
        public int Sub01(int a=5,int b=6)                  //parameter with default value
        {
           

            return a - b;
        }
    }
    class program
    {
       static void Main(String[] args)
        {
            TypesOfMethods T = new TypesOfMethods();
            userdefinedclass U = new userdefinedclass();
            ParaConDemo Para = new ParaConDemo(85);          //we can give parameter to the explicite constructor
            ParaConDemo Para01 = new ParaConDemo(90);
             ParaConDemo Para02 = new ParaConDemo(100);

            // T.Add();
            // T.Add01(45,5);
            //Console.WriteLine(T.Sub());
            // Console.WriteLine(T.Sub01(2,1));

            // Console.WriteLine(U.Id);
            // U.Fullname();


        }


    }


}
