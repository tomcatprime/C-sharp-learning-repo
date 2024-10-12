// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome in the quiz app");

string question1 = "What is the capital of France?";
string answer1 = "Paris";
string question2 = "What is 2+2";
string answer2 = "4";
string question3 = "What is the largest planet in our solar system?";
string answer3 = "Jupiter";

int score = 0;

Console.WriteLine(question1);
string userAnswer1 = Console.ReadLine();
if(userAnswer1.Trim().ToLower() == answer1.ToLower())
{
    Console.WriteLine("Correct answer");
    score++;
}
else
{
    Console.WriteLine("Wrong answer");
    Console.WriteLine("The correct answer is " + answer1.ToLower());

}
Console.WriteLine(question2);
string userAnswer2 = Console.ReadLine();
if (userAnswer2.Trim().ToLower() == answer2.ToLower())
{
    Console.WriteLine("Correct answer");
    score++;
}
else
{
    Console.WriteLine("Wrong answer");
    Console.WriteLine("The correct answer is " + answer2.ToLower());

}

Console.WriteLine(question3);
string userAnswer3 = Console.ReadLine();
if (userAnswer3.Trim().ToLower() == answer3.ToLower())
{
    Console.WriteLine("Correct answer");
    score++;
}
else
{
    Console.WriteLine("Wrong answer");
    Console.WriteLine("The correct answer is " + answer3.ToLower());

}

Console.WriteLine("Quiz Completed. Your final score is " + score + " out of 3");
if (score == 3)
{
    Console.WriteLine("Excellent!, You got all the answers correct");
}
else if (score == 2)
{
    Console.WriteLine("Good, You got 2 out of 3 answers correct");
}
else if(score == 1)
{
    Console.WriteLine("Fair, You got 1 out of 3 answers correct");
}
else
{
    Console.WriteLine("Poor, You got none of the answers correct");
}



Console.ReadKey();
