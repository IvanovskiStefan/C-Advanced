using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class4.Generics.Enteties
{
    public class GenericHelper
    {
        public void GoTroughList<T>(List<T> list)
        {
            foreach(T item in list)
            {
                Console.WriteLine(item);
            }
        }

        public void GetInfoForList<T>(List<T> list)
        {
            Console.WriteLine($"There are {list.Count} items of type {typeof(T)}");
        }

    }
}
