// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("What do you want to do ?");
Console.WriteLine("[S]ee all Todos");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine();

// int.Parse

if (userChoice == "S")
{
    PrintSelectedOption("See all TODOs");
}