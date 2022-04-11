// See https://aka.ms/new-console-template for more information
 
using SEDC.Oop.Class4.Generics.Enteties;

//GenericMethods genericMethods = new GenericMethods();

//genericMethods.PrintObject<string>("Something");
//genericMethods.PrintObject<DateTime>(DateTime.Now);
//genericMethods.PrintObject<int>(34);

//NonGenericHelper nonGenericHelper = new NonGenericHelper(); 

//List<string> stringList = new List<string> () { "Hello", "World", "Geeneric", "Methods" };

//nonGenericHelper.GoTroughList(stringList);
//nonGenericHelper.GetInfoForList(stringList);

//List<int> integerList = new List<int>() { 1, 2, 3, 4, 5, 6 };


//nonGenericHelper.GetInfoForList(integerList);
//nonGenericHelper.GoTroughList(integerList);
//Console.WriteLine("-------------------------WITH GENERIC CLASSES ----------------------------------");
//GenericHelper genericHelper = new GenericHelper(); 
//genericHelper.GoTroughList(stringList);
//genericHelper.GetInfoForList(stringList);
//genericHelper.GetInfoForList(integerList);
//genericHelper.GoTroughList(integerList);


//GenericClass <double> genericClass = new GenericClass<double>(3.5);

//genericClass.PrintPropertyTypeAndValidate();

//GenericClass<bool> genericBool = new GenericClass<bool>(true);

//genericBool.PrintPropertyTypeAndValidate();

//GenericClass<decimal> genericDecimal = new GenericClass<decimal>(5.9m);

//genericDecimal.PrintPropertyTypeAndValidate();


//Console.ReadLine();

GenericDB <Product> productDB = new GenericDB <Product> ();
productDB.Add(new Product { Id = 1, Title = "Book1", Description = "C#Advcanced", });
productDB.Add(new Product { Id = 2, Title = "Book2", Description = "C#ABasic", });
productDB.Add(new Product { Id =3, Title = "Book3", Description = "JavaScript", });

GenericDB<Order> orderDB = new GenericDB<Order>();

orderDB.Add(new Order { Id = 4, Address = "Partizanska", Product =  new Product { Id = 4, Title = "Book1", Description = "C#Advcanced", } });
orderDB.Add(new Order { Id = 4, Address = "VaSIL Gjorgov", Product = new Product { Id = 5, Title = "Book2", Description = "C#basic", } });
orderDB.Add(new Order { Id = 4, Address = "T.Gologanov", Product = new Product { Id =6, Title = "Book3", Description = "JavaScript", } });

//productDB.PrintInfo();
//orderDB.PrintInfo();


Product productForDelete = new Product { Id = 4, Title = "Book1", Description = "C#Advcanced", } ;
productDB.Add(productForDelete);
productDB.DeleteItem(productForDelete);
productDB.DeleteItemByID(2);