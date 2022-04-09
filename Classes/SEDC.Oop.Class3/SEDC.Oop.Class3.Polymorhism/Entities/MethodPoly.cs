using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class3.Polymorhism.Entities
{
    public class MethodPoly
    {
        public int AddNumbers( int first, int second)
        {
            return first + second; 
        }

        public int AddNumbers( int first, int second, int third)
        {
            return first +second + third;
        }
    }
}
