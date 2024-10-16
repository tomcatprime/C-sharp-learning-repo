// See https://aka.ms/new-console-template for more information


//method Void, return nothing, without parameter
using System.ComponentModel.DataAnnotations;

void WriteSomething()
{
    Console.WriteLine("I'm writing something");
}

WriteSomething();
//method with parameter myString of type String
//method declaration
void WriteSomethingElse(string myString)
{
    Console.WriteLine("My string is " + myString);
}
//calling methond
WriteSomethingElse("Something else");

//Calling method using an Argument called mUsername

string myUsername = "Frank";
WriteSomethingElse(myUsername);

//Method with return
//return method - instead of void we need to specify data type
int AddTwoValues(int value1, int value2)
{
    int result = value1 + value2;
    return result;
}


int myResult = AddTwoValues(8, 16);
Console.WriteLine("The result of AddTwoValues is: " + myResult);

Console.WriteLine("Type a number");
int num1 = int.Parse(Console.ReadLine());

int myResult2 = AddTwoValues(num1, 10);
Console.WriteLine($"The result of myResult2 is: " + myResult2);


int SubstractTwoValues(int value1, int value2)
{
    int result = value1 - value2;
    return result;
}

Console.WriteLine("Substraction:");
Console.WriteLine("Type number 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Type number 2: ");
int number2 = int.Parse(Console.ReadLine());

int myResult3 = SubstractTwoValues(number1, number2);

Console.WriteLine("The result of substraction is " + myResult3);

Console.WriteLine("Press any key to close the program....");


Console.ReadKey();