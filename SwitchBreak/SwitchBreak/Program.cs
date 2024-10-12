// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Enter the month number");
int month = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the number of the day");
int day = int.Parse(Console.ReadLine());
string monthName = "";
string dayName = "";
if (month == 1)
{
    monthName = "January";
    Console.WriteLine(monthName);
}
else if (month == 2)
{
    monthName = "February";
    Console.WriteLine(monthName);
}
else if (month == 3)
{
    monthName = "March";
    Console.WriteLine(monthName);
}
else
{
    monthName = "Unknown";
}


//switch statement
switch (day)
{
    case 1:
        dayName = "Monday";
        break;
    case 2:
        dayName = "Tuesday";
        break;
    case 3:
        dayName = "Wednesday";
        break;
    default:
        dayName = "Unknown";
        break;
}

Console.WriteLine($"The day is {dayName} and the month is {monthName}");