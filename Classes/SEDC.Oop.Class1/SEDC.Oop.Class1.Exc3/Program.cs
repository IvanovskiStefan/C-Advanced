// See https://aka.ms/new-console-template for more information
//2.Create a console application that checks if a day is a working day 🔹
//The app should request for a user to enter a date as an input or multiple inputs
//The app should then open and see if the day is a working day
//It should show the user a message whether the date they entered is working or not
//-Weekends are not working
//-1 January, 7 January, 20 April, 1 May, 25 May, 3 August, 8 September, 12 October, 23 October, and 8 December are not working days as well
//It should ask the user if they want to check another date
//Yes - the app runs again
//No - the app closes

List<DateTime> listOfDays = new List<DateTime>
{
    new DateTime(2000,1,1),
    new DateTime(2000,7,1),
    new DateTime(2000,5,1),
    new DateTime(2000,5,25),
    new DateTime(2000,8,3),
    new DateTime(2000,5,1),
    new DateTime(2000,8,3),
    new DateTime(2000,9,8),
    new DateTime(2000,10,12),
    new DateTime(2000,10,23),
    new DateTime(2000,12,8)

};

Console.WriteLine("Please enter the date that you want to check");
string inputFromConsole = Console.ReadLine();
bool isValid = DateTime.TryParse(inputFromConsole, out DateTime parsedDate);


bool isHoliday = false;

foreach (DateTime date in listOfDays)
{
    if (date.Month == parsedDate.Month && date.Day == parsedDate.Day)
    {
        isHoliday = true;
        break;
    }
    
}




if (parsedDate.DayOfWeek == DayOfWeek.Sunday || parsedDate.DayOfWeek == DayOfWeek.Saturday)
{
    Console.WriteLine("Weekeeennnddd !!!!");
}

 else if (isHoliday)
{
    Console.WriteLine("IS HOLIDAY !!");
}


else
{

    Console.WriteLine("WORKING TODAAYY !");
}
