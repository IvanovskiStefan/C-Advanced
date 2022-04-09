using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class3.StaticClasses.Enteties
{


    
    public   class User
    {

        public static int UserCount { get; set; } = 0;
        public string Name { get; set; }
        
        public int Id { get; set; }

        public string LastName { get; set; }

        public List<Order> Orders { get; set; }

        public User(int id, string name, string lastName)
        {
           Id = id;
           Name = name;
           LastName = lastName;
            UserCount++;
            Orders = new List<Order>();

        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Name} {LastName} The number of users is : {UserCount}");
        }

        public static void PrintCount()
        {
            Console.WriteLine($"Number of created users : {UserCount}");
        }

        public void PrintOrders()
        {

            Console.WriteLine($"{Name} {LastName}");
            foreach(Order order in Orders)
            {
                order.Print();
            }
        }
       
    }
}
