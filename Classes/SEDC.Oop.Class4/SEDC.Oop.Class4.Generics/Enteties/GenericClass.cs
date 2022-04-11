using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class4.Generics.Enteties
{
    public class GenericClass<T> 
    {
        public T MyCustomProperty { get; set; }


        public GenericClass(T myproperty)
        {
            MyCustomProperty = myproperty;
        }

        public void PrintPropertyTypeAndValidate()
        {
            Console.WriteLine($"The property is of type {MyCustomProperty.GetType()} and it's value is {MyCustomProperty}");
        }
    }
}
