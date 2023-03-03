using OOP_Abstracttion;
using OOP_Employees;
using OOP_Student;
using System;
using OOP_s.F1;
namespace OOP_Concepts
{
    class TypesOfMethods
    {
        //non-values return methood without parameter

       /* public void Add()
        {
            int a = 10, b = 15, c;
            c = a + b;
            Console.WriteLine(c);*/
        //non-values return methood with parameter
       /* public void Add01(int a, int b, out int c)             //types of parameters
        {

            c = a + b;
            Console.WriteLine(c);
        }*/

        //values return methood without parameter

      /*  public int Sub()
        {
            int a = 5, b = 3;

            return a - b;
        }*/
        //values return methood with parameter
       /* public int Sub01(int a = 5, int b = 6)                  //parameter with default value
        {


            return a - b;
        }*/
    }
    class program
    {
        static void Main(String[] args)
        {
            /*  TypesOfMethods T = new TypesOfMethods();
              ParaConDemo Para = new ParaConDemo(85);          //we can give parameter to the explicite constructor
              ParaConDemo Para01 = new ParaConDemo(90);
               ParaConDemo Para02 = new ParaConDemo(100);
              class1 c1 = new class1();
              // T.Add();
              // T.Add01(45,5);
              //Console.WriteLine(T.Sub());
              // Console.WriteLine(T.Sub01(2,1));
              // Console.WriteLine(U.Id);
              // U.Fullname();*/


            //Class1 c1 = new Class1();
            //c1.Add();
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Employee//

          //  Employee Id;        // class variable

            /* Employee Employee01 = new Employee();   //objectb of class
             Employee01.Id = 1;
             Employee01.Name  = "vivek";
             Employee01.Gender = "male";
             Console.WriteLine("Employee1 id = " + Employee01.Id);
             Console.WriteLine("Employee1 name = " + Employee01.Name);
             Console.WriteLine("Employee1 gender = " + Employee01.Gender);
             Console.WriteLine("-------------------------------------------------------------------------------");
             Employee Employee02 = new Employee();
             Console.WriteLine("enter employee Id ");
             Employee02.Id =Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("enter employee Name ");
             Employee02.Name  = Console.ReadLine();
             Console.WriteLine("enter employee Gender ");
             Employee02.Gender  = Console.ReadLine();
             Console.WriteLine("Employee2 id = " + Employee02.Id);
             Console.WriteLine("Employee2 name = " + Employee02.Name);
             Console.WriteLine("Employee2 gender = " + Employee02.Gender);
             Console.WriteLine("-------------------------------------------------------------------------------");
             Employee Employee03= new Employee();
             Employee03.GetData();
             Employee03.ShowData();
             Console.WriteLine("-------------------------------------------------------------------------------");*/
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //STUDENTS//

            /*  Students students1 = new Students();
              students1.GetData();
              students1.ShowData();
              Console.WriteLine("-------------------------------------------------------------------------------");
              Students students2 = new Students();
              students1.GetData();
              students1.ShowData();
              Console.WriteLine("-------------------------------------------------------------------------------");
              Students students3 = new Students();
              students1.GetData();
              students1.ShowData();
              Console.WriteLine("-------------------------------------------------------------------------------");
              Students students4 = new Students();
              students1.GetData();
              students1.ShowData();
              Console.WriteLine("-------------------------------------------------------------------------------");*/

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //ABSTRACTION//

            // AbstractionDemo A = new AbstractionDemo();       //we cannot create the object of abstract class

           /* child c = new child();
            Console.WriteLine(c.add(10,5));
            Console.WriteLine(c.sub(10,5));*/

            // IinterfaceDemo I = new IinterfaceDemo();            // we cannot create the object of Interface

            child1 c1 = new child1();
            c1.mul(10, 2);
            c1.div (10, 2);
            c1.rem (10, 2);
        }


    }


}
