// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Random random = new Random();
//this will give us a random number between  1 and 10
int randomNumber = random.Next(1, 11);

Console.WriteLine("Give me a number");
string inputString = Console.ReadLine();

int num1;
//creating an instance of the Random Class



bool isNumber = int.TryParse(inputString, out num1);

if(isNumber)
{
    if(num1 == randomNumber)
    {
        Console.WriteLine("You guessed the number");
    }
    else
    {
        Console.WriteLine("You didn't guessed the number");
    }
    Console.WriteLine("Well done, you enetered a number");
}
else
{
    Console.WriteLine("You should've enetered a number");
}

num1++;

Console.WriteLine("User entered number +1 " + num1);
Console.ReadKey();

