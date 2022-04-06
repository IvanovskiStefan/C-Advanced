// See https://aka.ms/new-console-template for more information


using Entities;
using Entities.Interfaces;

//IUser user = new User(4);
//Console.WriteLine(user.GetID());

//IThingsTatCanWriteANote pen = new Pen();
//IThingsTatCanWriteANote computer = new Computer();
//IThingsTatCanWriteANote phone  = new Phone();

//pen.WriteNote();
//computer.WriteNote();
//phone.WriteNote();  

//ITester tester = new Tester();
IDeveloper developer = new Developer();
Tester tester = new Tester();

developer.Code();
tester.Code();
tester.TestCode();








Console.ReadLine();