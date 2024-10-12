// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int counter = 0;

while (counter < 10)
{
    Console.WriteLine(counter);
    counter++;
}

Console.ReadKey();

//

bool isGood = true;

while (isGood)
{
    Console.WriteLine("Running....");
    
    isGood = false;
}
Console.WriteLine("Take a break");

// guessing number game 

Console.WriteLine("Welcome in Guess the number game");
Random randomNum = new Random();

int randomNumber = randomNum.Next(1, 10);

bool isCorrectNumber = true;

while (isCorrectNumber)
{
    Console.WriteLine("Guess a number between 1 and 10");
    string userGuess = Console.ReadLine();
    if (int.Parse(userGuess) == randomNumber)
    {
        Console.WriteLine("You guessed the number correctly");
        isCorrectNumber = false;
    }
    else
    {
        Console.WriteLine("Keep trying, Enter a number.....");
    }
}

Console.ReadLine();
