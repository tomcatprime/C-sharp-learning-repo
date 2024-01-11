// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("What do you want to do ?");
Console.WriteLine("[S]ee all Todos");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine();


switch(userChoice)
{
    case "S":
    case "s":
        PrintSelectedOption("See all TODOs");
        break;
    case "A":
    case "a":
        PrintSelectedOption("Add a TODO");
        break;
    case "R":
    case "r":
        PrintSelectedOption("Remove a TODOs");
        break;
    case "E":
    case "e":
        PrintSelectedOption("EXIT");
        break;
    default:
        Console.WriteLine("Invalid Choise");
        break;
}

// int.Parse



void PrintSelectedOption(string selectedOption)
{
    Console.Write($"Selected option: {selectedOption}");
}

Console.ReadLine();
//string interpolation - $"here is text and variable in {variable} text."
int a = 4, b = 2, c = 10;
Console.WriteLine($"First is: {a}, second is: {b}, third is {c}.");


//switch case
//if we have just single character, we can use char instead of string
var number = 0;
while (number < 10)
{
    number = number + 1;
    Console.WriteLine($"Current number is {number}");
}

Console.WriteLine("The loop is finished");






///////////////////////////////////////
var dis = ConvertPointtoGrade(9);
Console.WriteLine(dis);
char ConvertPointtoGrade(int points)
{
    switch(points)
    {
        case 10:
        case 9:
            return 'A';
        case 8:
        case 7:
        case 6:
            return 'B';
        default:
            return '!';

    }
}