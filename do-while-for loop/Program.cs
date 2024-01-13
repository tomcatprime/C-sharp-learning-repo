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