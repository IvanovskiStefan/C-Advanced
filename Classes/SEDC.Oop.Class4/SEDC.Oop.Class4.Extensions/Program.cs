


using SEDC.Oop.Class4.Extensions.Extensions;

Console.WriteLine(StringExtensions.DeleteLastCharacterClassic("String to shorten"));

string textToShorten = "Some string value";

Console.WriteLine(textToShorten.DeleteLastCharacter());

string textToQuote = "Quoted Text";

Console.WriteLine(textToQuote.AddQuotations());

List<string> list = new List<string>() { "First", "Second", "Third", "Fourth", "Fifth" };


list.PrintElements();