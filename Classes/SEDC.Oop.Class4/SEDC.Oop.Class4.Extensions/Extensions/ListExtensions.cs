using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class4.Extensions.Extensions
{
    public static class ListExtensions
    {
        public static void PrintElements<T>(this List<T> listToPrint )
        {
            foreach(T item in listToPrint)
            {
                Console.WriteLine(item);
            }
        }


    }
}
