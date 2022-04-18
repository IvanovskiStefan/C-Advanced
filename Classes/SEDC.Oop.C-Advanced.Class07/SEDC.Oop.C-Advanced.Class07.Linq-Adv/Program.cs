
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


int sumOfAllQuanties = orderList.Sum(order => order.Quantity);
Console.WriteLine($"The sum of all quuantities is : {sumOfAllQuanties}");


int max = orderList.Max(x => x.Quantity);
Console.WriteLine($"The maximum quiantity is {max}");


var maxOrder = orderList.FirstOrDefault(x => x.Quantity == max );

Console.WriteLine(maxOrder);


double averageQuiantity = orderList.Average(x => x.Quantity);
Console.WriteLine($"The average quantity is : {averageQuiantity}");
List<Order> aboveAverage = orderList.Where(x=> x.Quantity > averageQuiantity).ToList();
aboveAverage.ForEach(x => Console.WriteLine(x));

//ascending
var orderedOrderList = orderList.OrderBy(x => x.Id).ToList();
orderedOrderList.ForEach(x => Console.WriteLine(x));
//descending
var descOrderedOrderList = orderList.OrderByDescending(x => x.Id).ToList();
descOrderedOrderList.ForEach(x => Console.WriteLine(x));


Console.WriteLine("ORDER BY STRING:");

var orderByString = orderList.OrderBy(x => x.Name).ToList();
orderByString.ForEach(x => Console.WriteLine(x));

Console.WriteLine("Grouped by status ");
var groupedOrders = orderList.GroupBy(x=>x.OrderStatus);
foreach(var orderGrouping in groupedOrders)
{
    Console.WriteLine(orderGrouping.Key);
    foreach(var order in orderGrouping)
    {
        Console.WriteLine(order);
    }
}




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