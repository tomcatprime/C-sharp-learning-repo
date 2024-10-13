// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

//do while loops is a post-test loop


int number = 15;

do
{
    Console.WriteLine("Enter a positive whole number");
    number = int.Parse(Console.ReadLine());
} while (number <= 10);


//average calculator

int currectScore;
int sum = 0;
int counter = 0;
do
{
    Console.WriteLine("Enter your students score. Enter -1 to finish the program");
    currectScore = int.Parse(Console.ReadLine());
    if (currectScore != 1)
    {
        sum = sum + currectScore;
        counter++;
    }
    
} while (currectScore != -1);

int average = sum / counter;
Console.WriteLine($"The average score is: {average}");
Console.ReadKey();