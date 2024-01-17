// See https://aka.ms/new-console-template for more information


//while..do loop


string word;

do
{
    Console.WriteLine("Enter a word longer thne 10 leeters");
    word = Console.ReadLine();
}
while (word.Length <= 10);


Console.WriteLine("The loop is finished");
Console.ReadKey();

//for loop
for(int i= 1; i < 5; i+=2)
{
    Console.WriteLine("Loop run" + i);
}


//break

int userNumber;
do
{
    Console.WriteLine("Enter a number larger then 10:");
    var userInput = Console.ReadLine();
    if (userInput == "stop")
    {
        break;
    }

    userNumber = int.Parse(userInput);

} while (userNumber <= 10);

Console.WriteLine("The loop is finished");
Console.ReadKey();

//continue
for(var i = 0; i < 20; ++i)
{
    if(i % 3 != 0)
    {
        Console.WriteLine("i is " + 1);
    }
    

}
Console.WriteLine("The loop is finished")
Console.ReadKey();


// Arrays
