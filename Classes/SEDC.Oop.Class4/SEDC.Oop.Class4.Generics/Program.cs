// See https://aka.ms/new-console-template for more information
 
using SEDC.Oop.Class4.Generics.Enteties;

//GenericMethods genericMethods = new GenericMethods();

//genericMethods.PrintObject<string>("Something");
//genericMethods.PrintObject<DateTime>(DateTime.Now);
//genericMethods.PrintObject<int>(34);

NonGenericHelper nonGenericHelper = new NonGenericHelper(); 

List<string> stringList = new List<string> () { "Hello", "World", "Geeneric", "Methods" };

nonGenericHelper.GoTroughList(stringList);
nonGenericHelper.GetInfoForList(stringList);

List<int> integerList = new List<int>() { 1, 2, 3, 4, 5, 6 };


nonGenericHelper.GetInfoForList(integerList);
nonGenericHelper.GoTroughList(integerList);
Console.WriteLine("-------------------------WITH GENERIC CLASSES ----------------------------------");
GenericHelper genericHelper = new GenericHelper(); 
genericHelper.GoTroughList(stringList);
genericHelper.GetInfoForList(stringList);
genericHelper.GetInfoForList(integerList);
genericHelper.GoTroughList(integerList);



Console.ReadLine();