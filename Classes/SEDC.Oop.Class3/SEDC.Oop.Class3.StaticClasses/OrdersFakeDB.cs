using SEDC.Oop.Class3.StaticClasses.Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class3.StaticClasses
{
    public static class OrdersFakeDB
    {
        public static int orderId =5;

        public static List<Order> Orders { get; set; }

        public static List<User> Users { get; set; }

        static OrdersFakeDB()
        {
            Orders = new List<Order>();
            Users = new List<User>();

            Orders.Add(new Order(1, "Order 1", "Order 1 description", OrderStatus.Delivered));
            Orders.Add(new Order(1, "Order 2", "Order 1 description", OrderStatus.Processing));
            Orders.Add(new Order(1, "Order 3", "Order 1 description", OrderStatus.Shipped));
            Orders.Add(new Order(1, "Order 4", "Order 1 description", OrderStatus.Delivered));
            Orders.Add(new Order(1, "Order 5", "Order 1 description", OrderStatus.Processing));
            Orders.Add(new Order(1, "Order 6", "Order 1 description", OrderStatus.Delivered));

            Users.Add(new User(1, "Stefan", "Ivanovski"));
            Users.Add(new User(2, "Ivan", "Djikovski"));

            Users[0].Orders.Add(Orders[0]);
            Users[0].Orders.Add(Orders[1]);
            Users[1].Orders.Add(Orders[2]);
            Users[1].Orders.Add(Orders[3]);
            Users[1].Orders.Add(Orders[4]);

            Users.FirstOrDefault(user => user.Name == "Stefan")
                .Orders.Add(Orders.FirstOrDefault(order => order.Id == 1));
       }
        public static void AddOrder(string title, string description, OrderStatus orderstatus)
        {
            orderId++;
            Order order = new Order
            {
                Id = orderId,
                Title = title,
                Description = description,
                OrderStatus = orderstatus
               
            };
            Orders.Add(order);
            User.Orders.Add(order);

        }

    }
}
