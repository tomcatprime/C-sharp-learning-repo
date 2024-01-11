// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");




//loops while / do..while / for / foreach
var userNumber = Console.ReadLine();
var number = int.Parse(userNumber);
while(number < 10)
{

    //number = number + 1; or
    //number += 1; or
    number++; //or ++number
    Console.WriteLine($"Current number is {number}");
}

Console.WriteLine("Enter a word");
var userInput = Console.ReadLine();
while(userInput.Length < 15)
{
    userInput += 'a';
    Console.WriteLine(userInput);
}




char ConvertPointtoGrade(int points)
{
    switch (points)
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


Console.ReadLine();



PrintNameFamilyname("karol", "szejk", 1, 10);

void PrintNameFamilyname(string name, string familyname, int number, int number2)
{
    int currentNumber = number;
    int sum = 0;
    Console.WriteLine($"Your starting number is {currentNumber} and your starting sum is {sum}");
    while (currentNumber < number2 )
    {
        sum += currentNumber;
        currentNumber++;
        Console.WriteLine($"You name is {name} and family name is {familyname}. The current number is {currentNumber} and sum is {sum}");
    }
}

Console.ReadKey();