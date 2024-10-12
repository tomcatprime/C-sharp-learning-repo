// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//boolean TRUE or FALSE

//Logical Operators
// && AND
// || OR
// ! NOT

bool isSunny = true;

bool isSnow = false;

bool isSnowSunny = false;

bool isRainy = false;

bool hasUmbrella = false;

//long examples of operands

bool isSunnySnow = isSunny && isSnow;   

// if statement

// OR || operator
if (!isRainy || hasUmbrella)
{
    Console.WriteLine("I'm protected against rain.");

}
Console.WriteLine("Ay okay...");


//AND Statement &&

if (isSunny && isSnow)
{
    Console.WriteLine("It's snowy.");
}
else
{
    Console.WriteLine("Wait for snow");
}



//relational operators <  <=  >  >=
//
int num1 = 11;
int num2 = 10;

bool isHigher = num1 > num2;

if (isHigher)
{
    Console.WriteLine($"{num1} is higher than {num2}");
}

Console.WriteLine("Enter your age");
bool isWithParents = false;
int age = int.Parse(Console.ReadLine());
if (age >= 13 && isWithParents)
{
    Console.WriteLine("You can go to the club");
}
else if (age > 16)
{
    Console.WriteLine("You can party only in School");
}
else
{
    Console.WriteLine("You can't go to the club");
}



//nested if statement


bool isEqual = num1 == num2;

bool isNotEqual = num1 != num2;
Console.WriteLine("Please enter a whole number");
if (num1 == int.Parse(Console.ReadLine()))
{
    Console.WriteLine("Numbers are Equal");

    Console.WriteLine("Please enter your age");
    int ageNew = int.Parse(Console.ReadLine());
    if (ageNew >= 18)
    {
        Console.WriteLine("Please enter your address, so that we can send you the prize!");
        string address = Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Sorry, you can't get your prize due to your age");
    }

}
else
{
    Console.WriteLine("Numbers are not Equal");
}


//nested if statement

int number1 = 10;
int number2 = 17;
int number3 = 20;

Console.ReadKey();


