using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManager9000.Data;
using TaxiManager9000.Models;

namespace TaxiManager9000.Services
{
    public class LoginServices
    {
        public User Login()
        {
            Console.WriteLine("Username:");
            string username = Console.ReadLine();
            Console.WriteLine("Password:");
            string password = Console.ReadLine();

            foreach(User user in BasicDB.Users)
            {
                if(username == user.Username && password == user.Password)
                {
                    return user;
                }
                              
            }

            return null;
        }

    }
}
