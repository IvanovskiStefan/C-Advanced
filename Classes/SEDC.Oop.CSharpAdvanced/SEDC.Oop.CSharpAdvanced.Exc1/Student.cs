using SEDC.Oop.CSharpAdvanced.Exc1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.CSharpAdvanced.Exc1
{
    public class Student : User, IStudent
    {
        public string Grades { get ; set ; }

        public override string PrintUser()
        {
            return Grades;
        }
    }
}
