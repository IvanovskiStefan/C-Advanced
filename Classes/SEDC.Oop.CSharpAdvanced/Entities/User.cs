using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User : IUser
    {
        public int Id { get; set; }
       
        public User(int id)
        {
            Id = id;
        }
       
        public string GetID()
        {
            return $"{Id}";
        }
    }
}
