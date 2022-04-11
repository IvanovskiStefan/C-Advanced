using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class4.Generics.Enteties
{
    public class Order : BaseEntity
    {
        public Product Product { get; set; }
        public string Address { get; set; }

        public override void PrintInfro()
        {
            base.PrintInfro();
            Console.WriteLine($"Product name:{Product} -{Address}");
            
        }

        public override string ToString()
        {
            return $"Product name:{Product} -{Address}";
        }
    }
}
