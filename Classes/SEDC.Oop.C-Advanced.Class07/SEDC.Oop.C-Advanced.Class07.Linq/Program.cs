List<int> intList = new List<int>() { 5,6,7,1,2,19,32,};
var largerThenTen = intList.Where(isLargerThanTen).ToList();

largerThenTen.ForEach(number => Console.WriteLine(number));

static bool isLargerThanTen (int number) 
{
    return number > 10;
}
List<string> stringList = new List<string>() { "12", "4", "15", "8", "44", "89" ,"asdas"};

List<int> convertedList = stringList.Select((stringNumber) =>
{
    int number;
    int.TryParse(stringNumber, out number);
    return number;

}).ToList();

convertedList.ForEach(x => Console.WriteLine(x));