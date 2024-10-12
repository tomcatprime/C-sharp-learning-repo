// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int number = 2;

Console.WriteLine($"Initial number: {number}");

// Postfix increment: prints 2, then increments to 3
Console.WriteLine($"After postfix increment: {number++}");

// Prefix increment: increments to 4, then prints 4
Console.WriteLine($"After prefix increment: {++number}");

// Postfix decrement: prints 4, then decrements to 3
Console.WriteLine($"After postfix decrement: {number--}");

// Prefix decrement: decrements to 2, then prints 2
Console.WriteLine($"After prefix decrement: {--number}");

// Compound addition: adds 30 to 2
number += 30;
Console.WriteLine($"After adding 30: {number}");

// Compound subtraction: subtracts 15 from 32
number -= 15;
Console.WriteLine($"After subtracting 15: {number}");


//modulo operator

int num1 = 10;
int num2 = 3;

int result = num1%num2;
Console.WriteLine($"The reminder of {num1} divided by {num2} is {result}. This is modulo operator.");