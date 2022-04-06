using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Admin : Person
    {

        public string Department { get; set; }

        public Admin(int id, string name, string lastname, string department)
            : base(id, name, lastname)
        {
            Department = department;
        }
        public override string GetInfo()
        {
            return $"{Name} {LastName} os admin to department {Department}";
        }


    }
}