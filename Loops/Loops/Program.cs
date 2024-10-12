// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// \r - carriage return

//Loops

//For Loop
//count up
for (int counter = 1; counter <= 10; counter++)
{
    Console.WriteLine("For loop, this is the value of counter: " + counter);
}


//count down
Console.WriteLine("Count\ndown");

for (int countDown = 10; countDown >= 0; countDown--)
{
    Console.WriteLine("For loop, count down, the value of counter is " + countDown);
    Thread.Sleep(200);
}

string myString = "Hi \n Hi";

Console.WriteLine(myString);

Console.ReadLine();