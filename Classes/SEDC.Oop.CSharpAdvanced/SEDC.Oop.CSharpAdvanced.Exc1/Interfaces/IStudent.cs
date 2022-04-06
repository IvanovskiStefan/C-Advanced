using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.CSharpAdvanced.Exc1.Interfaces
{
    public interface IStudent : IUser
    {
        public string Grades { get; set; }

    }
}
