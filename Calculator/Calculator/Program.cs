// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Hello!");
Console.WriteLine("Input the first number: ");
var userInput = Console.ReadLine();
int firstNumber = int.Parse(userInput);
Console.WriteLine("Input the second number: ");
var userInput2 = Console.ReadLine();
int secondNumber = int.Parse(userInput2);

Console.WriteLine("What do you want to do with those numbers? ");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubstract");
Console.WriteLine("[M]ultiply]");
var whatUserSelect = Console.ReadLine();

if(EqualsCaseInsensitive(whatUserSelect, "A"))
{
    var sum = firstNumber + secondNumber;
    PrintFinalEquation(firstNumber, secondNumber, sum, "+");
}
else if (EqualsCaseInsensitive(whatUserSelect, "S"))
{
    var sum = firstNumber - secondNumber;
    PrintFinalEquation(firstNumber, secondNumber, sum, "-");
}
else if (EqualsCaseInsensitive(whatUserSelect, "M"))
{
    var sum = firstNumber * secondNumber;
    PrintFinalEquation(firstNumber, secondNumber, sum, "*");
}
else
{
    Console.WriteLine("Invalid Choise");
}

void PrintFinalEquation(int number1, int number2, int result, string @operator)
{
     Console.WriteLine(number1 + " " + @operator + " " + number2 + " = " + result);
}
Console.Write("Press any key to close");
Console.Read();


bool EqualsCaseInsensitive(string left, string right)
{
    return left.ToUpper() == right.ToUpper();
}

