// See https://aka.ms/new-console-template for more information
using SEDC.Oop.Class3.StaticClasses;
using SEDC.Oop.Class3.StaticClasses.Enteties;
using SEDC.Oop.Class3.StaticClasses.Utils;

//Console.WriteLine(FirstStaticClass.Counter);
//FirstStaticClass.Counter++;

//Console.WriteLine(FirstStaticClass.Counter);



//Console.WriteLine(FirstStaticClass.AddTwoNUmbers(2,3));

//Console.WriteLine($"Number of created users :{User.UserCount}");
//User user1 = new User(1, "Stefan", "Ivanovski");
//user1.PrintInfo();
//User.PrintCount();

//Console.WriteLine($"Number of created users :{User.UserCount}");

//User user2 = new User(4, "Petko", "Petkovski");
//user2.PrintInfo();
//Console.WriteLine($"Number of created users :{User.UserCount}");


//User user3 = new User(7, "Trajko", "Trajkovski");
//user3.PrintInfo();
//Console.WriteLine($"Number of created users :{User.UserCount}");



//Console.WriteLine(StringUtils.CapitaliseFirstLetter("the sun is shining"));
//Console.WriteLine(StringUtils.CapitaliseFirstLetter("Today is Saturday"));
//Console.WriteLine(StringUtils.CapitaliseFirstLetter("1231234124"));
//Console.WriteLine(StringUtils.CapitaliseFirstLetter(null));
//Console.WriteLine(StringUtils.CapitaliseFirstLetter(""));
//Console.WriteLine(StringUtils.CapitaliseFirstLetter("t"));

//int parsedValue = StringUtils.VerifyStringNumber(Console.ReadLine());

//Console.WriteLine(parsedValue);

foreach(Order order in OrdersFakeDB.Orders)
{
    order.Print();
}

foreach(User user in OrdersFakeDB.Users)
{
    user.PrintOrders();
}




Console.ReadLine();