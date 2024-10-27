 namespace QuizProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[]
            {

                new Question("What is the Capital of Germany?", new string[] {"paris", "berlin", "london", "madrid"}, 1),
                new Question("Which planet is known as the Red Planet?", new string[] {"earth", "mars", "jupiter", "venus"}, 1),
                new Question("What is the largest ocean on Earth?", new string[] {"atlantic", "indian", "arctic", "pacific"}, 3),
                new Question("Who wrote 'Romeo and Juliet'?", new string[] {"charles dickens", "william shakespeare", "mark twain", "jane austen"}, 1),
                new Question("What is the boiling point of water?", new string[] {"100°C", "0°C", "50°C", "25°C"}, 0)


            };
            Quiz myQuiz = new Quiz(questions);

            myQuiz.StartQuiz();
            Console.ReadLine();
        }
    }
}
