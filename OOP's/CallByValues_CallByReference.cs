using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CallByValues_CallByReference
{
    internal class CallByValues_CallByReference
    {
        public void CallByValues(int num1,int num2)
        {
            num1 = 1;
             num2 = 2;
        }

        public void CallByreference(ref int num1,ref int num2)
        {
            num1 = 3;
            num2 = 4;
        }
    }
}
