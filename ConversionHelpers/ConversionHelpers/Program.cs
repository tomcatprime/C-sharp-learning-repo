//Converison Helpers Parse and Convert

string numberString = "123";

int result = int.Parse(numberString);

string myBoolString = "true";

bool myBool = Convert.ToBoolean(myBoolString);
Console.WriteLine($"My bool is {myBool}");

Console.WriteLine(Convert.ToString(myBoolString));