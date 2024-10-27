 namespace QuizProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[]
            {

                new Question("What is the Capital of Germany", new string[] {"paris", "berlin", "london", "madrid"}, 1)

            };
            Quiz myquiz = new Quiz(questions);

            myquiz.DisplayQuestion(questions[0]);
            Console.ReadLine();
        }
    }
}
