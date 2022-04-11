using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class4.Generics.Enteties
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public virtual void PrintInfro()
        {
            Console.WriteLine($"ID:{Id}");
        }
    }
}
