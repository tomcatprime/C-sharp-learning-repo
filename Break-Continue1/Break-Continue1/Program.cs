// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

//break
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 3)
    {
        Console.WriteLine("Stop");
        break;
    }
}

//continues

for (int i = 0; i < 4; i++)
{
    Console.WriteLine(i);
    if (i == 2)
    {
        Console.WriteLine("Stop");
        continue;
    }
    Console.WriteLine(i);
}