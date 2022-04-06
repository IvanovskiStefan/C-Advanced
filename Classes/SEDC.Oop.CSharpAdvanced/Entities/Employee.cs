using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Employee : Person
    {
        public Employee(int Id, string name, string lastname, int workHours)
            : base(Id, name, lastname)
        {
            WorkHours = workHours;   
        }
        public int WorkHours { get; set; }
        public override string GetInfo()
        {
            return $"{Name} {LastName} WorkHours:{WorkHours}";
        }
    }
}
