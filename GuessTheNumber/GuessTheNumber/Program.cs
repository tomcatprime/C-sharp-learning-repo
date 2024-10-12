// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome in guess the number game");

Random random = new Random();

int randomNumber = random.Next(1, 25);
int counter = 0;
int userGuess = 0;


Console.WriteLine("Think of a number between 1 and 25 and type it.");

while (userGuess != randomNumber)
{
    counter++;
    userGuess = int.Parse(Console.ReadLine());
    if (userGuess > randomNumber)
    {
        Console.WriteLine("Too high. Try Again");
    }
    else if (userGuess < randomNumber)
    {
        Console.WriteLine("Too low. Try Again");
    }
    else
    {
        Console.WriteLine("You guessed correctly in " + counter + " attempts");
    }
}

Console.ReadKey();