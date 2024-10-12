// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("How old are you?");
int age = int.Parse(Console.ReadLine());

bool isWithParents = false;





if (age > 18)
{
    Console.WriteLine("Go party in the club");
}
else if (age >= 13)
{
    Console.WriteLine("Are you with parents? Type yes or no");
    string isWithParentsString = Console.ReadLine();
    if (isWithParentsString == "yes")
    {
        isWithParents = true;
        Console.WriteLine("Go party in the club with your parents");
    }
    else
    {
        Console.WriteLine("No Party for you");
    }
}
else
{
    Console.WriteLine("Go home and study");
}

Console.ReadKey();

