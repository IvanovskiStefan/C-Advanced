using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Tester : ITester,IDeveloper
    {
        public void Code()
        {
            Console.WriteLine("Writing automated tests");
        }

        public void Test()
        {
            
        }

        public void TestCode()
        {
            Console.WriteLine("Testing the code");
        }
    }
}
