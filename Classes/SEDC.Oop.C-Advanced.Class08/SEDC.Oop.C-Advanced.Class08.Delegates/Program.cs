

SayDelegate SayDelegate = new SayDelegate(WriteToConsole);
SayDelegate sayWithColor  = new SayDelegate(WriteWithRedColor);


SayDelegate("hello world from delegate");
sayWithColor("this text is RED!:D");
SaySomething(WriteWithRedColor,1);
SaySomething(WriteToConsole,2);
PerformCalculations(AddNumber, SubstractNumbers, 6, 7);


CalculateDelegate addToNumbers = AddNumber;
CalculateDelegate substractNumbers = SubstractNumbers;



static void WriteToConsole(string text)
{
    Console.WriteLine(text);
}

static void SaySomething(SayDelegate sayMechanism, int counter)
{
    sayMechanism($"text from method {counter}");

}

static void WriteWithRedColor(string text)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(text);
    Console.ResetColor();
}

static int AddNumber(int firstNum1, int secondNum2)
{
    return firstNum1 + secondNum2;
};


static int SubstractNumbers( int firstNum1, int secondNum2)
{
    return firstNum1 - secondNum2;
}

static void PerformCalculations(CalculateDelegate addNumbers, CalculateDelegate substractNumbers, int first,int second)
{
    Console.WriteLine($"addition: of {first} and {second} is {addNumbers(first,second)}");
    Console.WriteLine($"Substraction: of {first} and {second} is {substractNumbers(first, second)}");

}

delegate int CalculateDelegate(int firstNum, int secondNum);

delegate void SayDelegate(string text);
