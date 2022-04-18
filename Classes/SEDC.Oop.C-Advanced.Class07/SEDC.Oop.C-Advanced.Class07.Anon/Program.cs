
Console.WriteLine("-----------------FUNC------------");
Func<string, bool> isValidNumber = text => int.TryParse(text, out int parsed);

static bool IsValidNumber(string text)
{
    return int.TryParse(text, out int parsed);
}

Func<int> getRandomNumber = () =>
{
    Random random = new Random();
    return random.Next(1, 100);
};

Func<int, int, int> addTwoNumbers = (firstNumber, secondNumber) =>
{
    return firstNumber + secondNumber;
};

Console.WriteLine("---- Func ----");

int randomNumber = getRandomNumber();
Console.WriteLine(randomNumber);

Console.WriteLine("Enter two numbers:");

int first;
int second;

string firstString = Console.ReadLine();
if (isValidNumber(firstString))
{
    first = int.Parse(firstString);
}
else
{
    Console.WriteLine("The first number was not valid");
    return;
}

string secondString = Console.ReadLine();
if (isValidNumber(secondString))
{
    second = int.Parse(secondString);
}
else
{
    Console.WriteLine("The second number was not valid");
    return;
}

Console.WriteLine($"The additon of the two numbers is {addTwoNumbers(first, second)}");



Console.WriteLine("_________________________ACTION______________________");

Action<string> PrintWithRedColor = (text) =>
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(text);
    Console.ResetColor();   
};

PrintWithRedColor("this is an error messsage");


Action<string, ConsoleColor> printWithColor = (text, color) =>
{
    Console.ForegroundColor = color;
    Console.WriteLine(text);
    Console.ResetColor();
};

Action printHelloMassage = () => Console.WriteLine("hello from anon method");

printHelloMassage();



printWithColor("This is blue", ConsoleColor.Blue);
printWithColor("This is green", ConsoleColor.Green);




