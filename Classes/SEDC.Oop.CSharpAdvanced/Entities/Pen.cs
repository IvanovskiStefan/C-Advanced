using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Pen : IThingsTatCanWriteANote
    {
        public void WriteNote()
        {
            Console.WriteLine("Writing a note with a pen");
        }
    }
}
