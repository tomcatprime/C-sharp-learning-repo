// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Globalization;


Console.WriteLine("Hello, World!");
Console.WriteLine("Enter something");

//takes the user input and stores it

//data type "string"
string userInput = Console.ReadLine();

int iAmAnNumber = 5;

//We are adding 2 strings togerther and writing them onto the console
Console.WriteLine("You entered " + userInput);  




//data types:
///<summary>
///XML documenation - Data types
/// </summary>
float pi = 3.14f;

bool isGPSEnabled = true;

string myName = "Tomcat";

char at = '@';

int newNumber = 5;
double newDouble = 5.5;


Console.WriteLine(pi);
Console.WriteLine(at);
Console.WriteLine(newNumber);
Console.WriteLine(isGPSEnabled);


byte day = 200; //unsigned byte 2 to the power of 8
sbyte number = -128; //signed byte to hold negative number

short linedinConnections = 32767; 

long phoneNumber = 11234567890;
float newPi = 3.14f;


//Define and initialize variable
string petName = "Kobe";
Console.WriteLine($"My pet is {petName}");


//parsing from input to integer
int myNumber = 0;

Console.WriteLine("Enter a number");
myNumber = int.Parse(Console.ReadLine());

Console.WriteLine($"You have entered {myNumber}");

//making calculation

//using double to be able to store decimal numbers

double myFirstNumber = 0.0;
double mySecondNumber = 0;


//for whole number we would use int.Parse(), for decimal numbers we use double.Parse()
Console.WriteLine("Enter the first number");
myFirstNumber = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number");
mySecondNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//string concatination
Console.WriteLine("Your calculation of " + myFirstNumber + " and " + mySecondNumber + " equals to " + (myFirstNumber + mySecondNumber));


double sum = Math.Round((myFirstNumber + mySecondNumber), 2);
//string interpolation
Console.WriteLine($"Your calculation of {myFirstNumber.ToString(CultureInfo.InvariantCulture)} and {mySecondNumber} equals to {sum.ToString(CultureInfo.InvariantCulture)}");

//implicit conversion

int myInt = 13;
double myDouble = myInt;

long myLong = myInt;

//explicit conversion(casting)


long myLong4 = 31241224152463634;
int myInt2 = (int)myLong4;

float myFloat1 = 123.123f;
myDouble = 13.312412412412;

myFloat1 = (float)myDouble;

Console.ReadKey();
