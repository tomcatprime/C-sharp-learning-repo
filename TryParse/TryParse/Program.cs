// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Give me a number");
string inputString = Console.ReadLine();

int num1;

bool isNumber = int.TryParse(inputString, out num1);

if(isNumber)
{
    Console.WriteLine("Well done, you enetered a number");
}
else
{
    Console.WriteLine("You should've enetered a number");
}

num1++;

Console.WriteLine("User entered number +1" + num1);
Console.ReadKey();

