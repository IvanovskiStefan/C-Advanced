// See https://aka.ms/new-console-template for more information
using SEDC.Oop.Class3.Polymorhism.Entities;

Console.WriteLine("Hello, World!");


List<Pet> pets = new List<Pet>()
{
    new Cat("Meow",2),
    new Dog("Bark", "GermanShepard"),
    new Dog("Sparky", "Doga")
};

foreach(Pet pet in pets)
{
    pet.Eat();
};



Dog dog1 = new Dog();
Dog dog2 = new Dog("Opaaa");
Dog dog3 = new Dog("Chuchill", "Englishbulldog");

MethodPoly methodpoly = new MethodPoly();

methodpoly.AddNumbers(1, 2);


Console.ReadLine();
