// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

int num1 = 0;
int num2 = 0;
int num3 = 0;
int num4 = 0;
int num5 = 0;

//Array integer

//declare an array
//Indexes [0][1][2][3][4]
//content [0][0][0][0][0]

int[] myIntArray = new int[5];
Console.WriteLine("Type a number");
int number1 = int.Parse(Console.ReadLine());
//assigned values to the array
myIntArray[0] = 5;
myIntArray[1] = number1;
myIntArray[2] = 10;
myIntArray[3] = 20;
myIntArray[4] = 30;


Console.WriteLine(myIntArray[0]);
Console.WriteLine(myIntArray[1]);
Console.WriteLine(myIntArray[2]);


//declare and assigned value in one line

int[] myIntArray2 = [5, 12, 13, 14, 15];

string[] weekDays = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"];

Console.WriteLine(myIntArray2[3]);
Console.WriteLine(weekDays[4]);
Console.WriteLine($"Today is {weekDays[4]}");

//lenght of Array
Console.WriteLine("Lenght of weekDays Array is: " + weekDays.Length);

//for loop
Console.WriteLine("Printing from FOR loop");
for (int i = 0; i < weekDays.Length; i++)
{
    Console.WriteLine($"Today is {weekDays[i]}");
}

Console.WriteLine("Printing from FOR EACH loop");
//for each loop
foreach (var item in weekDays)
{
    Console.WriteLine($"Today is {item}");
}


Console.ReadKey();