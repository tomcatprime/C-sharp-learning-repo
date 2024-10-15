// See https://aka.ms/new-console-template for more information


//method Void, return nothing, without parameter
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

void AddTwoValues(int value1, int value2)
{
    int result = value1 + value2;
    Console.WriteLine($"The result is {result}");
}

AddTwoValues(5,10);