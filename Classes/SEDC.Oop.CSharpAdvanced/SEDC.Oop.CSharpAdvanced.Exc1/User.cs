using SEDC.Oop.CSharpAdvanced.Exc1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.CSharpAdvanced.Exc1
{
    public abstract class User : IUser
    {
        public int Id { get ; set ; }
        public string Name { get ; set ; }
        public string Username { get ; set ; }
        public int Password { get; set ; }

        public User()
        {
                
        }

        abstract public string PrintUser();
        
        
    }
}
