// See https://aka.ms/new-console-template for more information

//exc 1

Console.WriteLine("please enter  names");
Console.WriteLine("If you want to exit the app please entert X");
string inputFromConsole = Console.ReadLine();
List<string> Names = new List<string>();

while (inputFromConsole != "x")
{
    Names.Add(inputFromConsole);
    inputFromConsole = Console.ReadLine();
    
}

Console.WriteLine("now enter some sentence and check how many times the name appears");
string sentenceInput = Console.ReadLine();

      

string [] sentenceToWords = sentenceInput.Split(" ");


foreach (string Name in Names)
{
    int counter = 0;
    foreach (string word in sentenceToWords)
    {


        if (word == Name)
        {
            counter++;
            
        }
    }

    Console.WriteLine($"Name {Name} : {counter}");

}













