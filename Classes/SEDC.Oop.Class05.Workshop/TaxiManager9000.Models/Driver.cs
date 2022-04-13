using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiManager9000.Models
{
    public class Driver 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Shifts Shift { get; set; }

        public Car Car { get; set; }


        public Driver(int id, string firstName, string lastName, Shifts shifts, Car car)
        {
            id = id;
            FirstName = firstName;
            LastName = lastName;
            Shift = shifts;
            Car = car;
        }
    }


}
