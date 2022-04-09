using SEDC.Oop.Class3.StaticClasses.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class3.StaticClasses.Enteties
{
    public  class Order
    {
        public  int Id { get; set; }
        public  string Title { get; set; }
        public  string  Description { get; set; }

        public  OrderStatus OrderStatus { get; set; }

        public List<Order> Orders { get; set; }

        public Order(int id, string title, string description, OrderStatus orderstatus) 
        {
            Id = id;    
            Title = title;
            Description = description;
            OrderStatus = orderstatus;
        }

        public void Print()
        {
            Console.WriteLine($"{StringUtils.CapitaliseFirstLetter(Title)} - {StringUtils.CapitaliseFirstLetter(Description)}");
        }


        public Order()
        {

        }

        
    }

    public enum OrderStatus
    {
        Delivered,
        Processing,
        Shipped
    }
    
}
