using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class3.StaticClasses.Utils
{
    public static class FirstStaticClass
    {
        public static int Counter;

        static FirstStaticClass()
        {
            Counter = 1;
        }
        public static int AddTwoNUmbers(int firstNumber,int secondNumber)
        {
            return firstNumber + secondNumber;  
        }




    }
}
