using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManager9000.Models;

namespace TaxiManager9000.Data
{
    public static class BasicDB
    {
        public static List<Driver> Drivers { get; set; } = new List<Driver>() { };

        public static List<Car> Cars { get; set; } = new List<Car> { };

        public static List<User> Users { get; set; } = new List<User> { };

         static BasicDB( )
        {
            Car car1 = new Car(1, "toyota avensis", "SK100JE",new DateTime(2023, 7, 7));
            Car car2 = new Car(2, "volkswagen golf", "SK200JE", new DateTime(2023, 5, 5));
            Car car3 = new Car(3, "toyota celica", "SK300JE", new DateTime(2022, 2, 1));

            Driver driver1 = new Driver(1, "Stefan", "Ivanovski", Shifts.Afternoon, car1);
            Driver driver2 = new Driver(2, "Aneta", "Stankovska", Shifts.Morning, car2);
            Driver driver3 = new Driver(3, "Aleksandar", "Zivkovic", Shifts.Evening, car3);

            User user1 = new User()
            {
                Id = 1,
                Username ="admin1",
                Password ="passadmin1",
                Role = Roles.Administrator,

                
            };

            User user2 = new User()
            {
                Id = 2,
                Username = "manager1",
                Password = "passmanager1",
                Role = Roles.Manager,


            };

            User user3 = new User()
            {
                Id = 1,
                Username = "maintanance1",
                Password = "passmaintanance1",
                Role = Roles.Maintenance,


            };

            car1.AssignedDrivers.Add(driver1);
            car2.AssignedDrivers.Add(driver2);
            car3.AssignedDrivers.Add(driver3);

            Cars.Add(car3);
            Cars.Add(car2);
            Cars.Add(car1);

            Drivers.Add(driver1);
            Drivers.Add(driver2);
            Drivers.Add(driver3);

            Users.Add(user1);
            Users.Add(user2);   
            Users.Add(user3);   


             static void AddUser(User user)
            {
                Users.Add(user);
            }

            static void AddDriver(Driver driver)
            {
                Drivers.Add(driver);
            }

            static void AddCar(Car car)
            {
                Cars.Add(car);
            }


            static void RemoveUser(User user)
            {
                Users.Remove(user);
            }

            static void RemoveCar(Car car)
            {
                Cars.Remove(car);
            }

            static void RemoveDriver(Driver driver)
            {
                Drivers.Remove(driver); 
            }


        }
    }
}
