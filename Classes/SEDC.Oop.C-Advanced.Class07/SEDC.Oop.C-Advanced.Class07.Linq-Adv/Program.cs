
List<Order> orderList = new List<Order>
{
    new Order(){Id =1,Name = "Order 1", OrderStatus = OrderStatus.shipped,Quantity= 15},
    new Order(){Id =3,Name = "Order 3", OrderStatus = OrderStatus.proccessing,Quantity= 14},
    new Order(){Id =2,Name = "Order 2", OrderStatus = OrderStatus.delivered,Quantity= 69},
    new Order(){Id =4,Name = "Order 4", OrderStatus = OrderStatus.proccessing,Quantity= 45},
    new Order(){Id =6,Name = "Order 6", OrderStatus = OrderStatus.shipped,Quantity= 13},
    new Order(){Id =5,Name = "Order 5", OrderStatus = OrderStatus.delivered,Quantity= 3},
    new Order(){Id =11,Name = "Order 11", OrderStatus = OrderStatus.shipped,Quantity= 11},
    new Order(){Id =10,Name = "Order 10", OrderStatus = OrderStatus.delivered,Quantity= 9},
    new Order(){Id =12,Name = "Order 12", OrderStatus = OrderStatus.proccessing,Quantity= 3},
    new Order(){Id =14,Name = "Order 14", OrderStatus = OrderStatus.delivered,Quantity= 8},
    new Order(){Id =15,Name = "Order 15", OrderStatus = OrderStatus.proccessing,Quantity= 30},
    new Order(){Id =19,Name = "Order 19", OrderStatus = OrderStatus.delivered,Quantity= 10},
    new Order(){Id =8,Name = "Order 8", OrderStatus = OrderStatus.proccessing,Quantity= 42}

};

List<Order> copyList = orderList.Select(x =>x).ToList();

Console.WriteLine($"Original list");
orderList.ForEach(orderList => Console.WriteLine(orderList));

orderList.FirstOrDefault(x => x.Id == 1).Name = "Order 1 changed";
orderList.FirstOrDefault(x => x.Id == 4).Name = "Order 4 changed";

Console.WriteLine(copyList);
copyList.ForEach(copyList => Console.WriteLine(copyList));



List<Order> realCopyList = orderList.Select(x => new Order
{
    Id = x.Id,
    OrderStatus = x.OrderStatus,    
    Quantity = x.Quantity,  
    Name = x.Name,  
}).ToList();

public class Order
{
    public int Id { get; set; } 
    public string Name { get; set; }
    public int Quantity { get; set; }

    public OrderStatus  OrderStatus { get; set; }

    public override string ToString()
    {
        return $"Id:{Id} Name:{Name}, Quantity :{Quantity}, Orderstatus:{OrderStatus}";
    }








}




public enum OrderStatus
{
        proccessing,
        shipped,
        delivered
}